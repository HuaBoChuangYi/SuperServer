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
                var request = requestInfo.ToBaseModel();
                var obj = JsonHelper.DeserializeJsonToObject<ReplyDeviceIdModel>(request.Content + "");


                ConnectSession newClient = MyAppServer.Sessions.FirstOrDefault(s => s.AppSession == session);
                if (obj != null && !string.IsNullOrWhiteSpace(obj.DeviceId) && newClient != null)
                {
                    if (newClient.IsThree)
                    {
                        Logger.Error("该设备从三方设备转成非三方设备,请验证！");
                    }
                    newClient.SetIdState = SetIdState.HadSet;
                    newClient.DeviceId = obj.DeviceId;
                    newClient.IsThree = false;

                    newClient.Send("reply", new SendBaseModel
                    {
                        Content = new ReplyModel
                        {
                            Success = 1
                        },
                        FromDeviceId = session.GetAddress(),
                        ToDeviceId = ""
                    });

                }


            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message + "");
            }


        }
    }

}
