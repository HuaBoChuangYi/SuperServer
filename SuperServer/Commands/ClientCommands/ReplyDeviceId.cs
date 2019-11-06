using SuperServer.Services;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer.Commands.ClientCommands
{
    public class ReplyDeviceId : CommandBase<AppSession, StringRequestInfo>
    {
        public override void ExecuteCommand(AppSession session, StringRequestInfo requestInfo)
        {
            try
            {
                TestLogger.Log(requestInfo.ToString2());
                var request = requestInfo.ToBaseModel();
                var obj = JsonHelper.DeserializeJsonToObject<ReplyDeviceIdModel>(request.Content + "");

                var newClient = MyAppServer.Sessions.FirstOrDefault(s => s.AppSession == session);


                if (obj != null && !string.IsNullOrWhiteSpace(obj.DeviceId))
                {
                    if (newClient.IsThree)
                    {
                        TestLogger.Log("该设备从三方设备转成非三方设备,请验证！");
                    }
                    newClient.SetIdState = SetIdState.HadSet;
                    newClient.DeviceId = obj.DeviceId;
                    newClient.IsThree = false;
                    string message = CommandHelper.GetCmdStr("reply", new ReplyModel
                    {
                        Success = 1
                    });
                    TestLogger.Log(message);
                    session.Send(message);
                }
                else
                {
                    //newClient.SetIdState = SetIdState.NotSet;
                }
            }
            catch (Exception ex)
            {
                TestLogger.Log(ex.Message + "");
            }


        }
    }

}
