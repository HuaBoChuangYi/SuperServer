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
    /// <summary>
    /// 转发
    /// 命令格式为Send xxxx { Content:””,CommandId:””, ToDeviceId:””，FromDeviceId:”” }
    /// Send Reply { Content:””,CommandId:””,ToDeviceId:””,FromDeviceId:”” }
    /// </summary>
    public class Send : CommandBase<AppSession, StringRequestInfo>
    {
        public override void ExecuteCommand(AppSession session, StringRequestInfo requestInfo)
        {
            try
            {
                TestLogger.Log(requestInfo.ToString2());
                var request = requestInfo.ToSendModel();

                var toSessions = MyAppServer.Sessions;
                if (requestInfo.GetFirstParam().ToLower() == "reply")
                {
                    var fromDevice = request.FromDeviceId.ToDeivce();
                    toSessions = toSessions.Where(s => fromDevice != null && s.DeviceId == fromDevice.DeviceId && s.Ip == fromDevice.Ip).ToList();
                }
                else
                {
                    var a = requestInfo.GetFirstParam();
                    var fromDevice = MyAppServer.Sessions.FirstOrDefault(s => s.SessionId == session.SessionID);
                    if (fromDevice != null)
                    {
                        request.FromDeviceId = fromDevice.Ip + "," + fromDevice.DeviceId;
                    }

                    var toDevice = request.ToDeviceId.ToDeivce();
                    toSessions = toSessions.Where(s => toDevice != null && s.DeviceId == toDevice.DeviceId && s.Ip == toDevice.Ip).ToList();
                }

                toSessions.ForEach(s =>
                {
                    string message = CommandHelper.GetCmdStr(requestInfo.GetFirstParam(), request);
                    TestLogger.Log(message);
                    s.Send(message);
                });
            }
            catch (Exception ex)
            {
                TestLogger.Log(ex.Message + "");
            }


        }
    }
}
