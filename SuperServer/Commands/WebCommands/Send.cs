using SuperSocket.WebSocket;
using SuperSocket.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer.Commands.WebCommands
{
    public class Send : SubCommandBase
    {
        public override void ExecuteCommand(WebSocketSession session, SubRequestInfo requestInfo)
        {
            try
            {
                TestLogger.Log(requestInfo.ToString2());
                var request = requestInfo.ToSendModel();
                string firstParam = requestInfo.ToFirstParam();
                var toSessions = MyAppServer.Sessions;


                if (string.IsNullOrWhiteSpace(firstParam))
                {
                    TestLogger.Log("命令发送错误");
                    return;
                }
                else if (request.Content == null)
                {
                    var toDevice = request.ToDeviceId.ToDeivce();
                    toSessions = toSessions.Where(s => s.DeviceId == toDevice.DeviceId && s.Ip == toDevice.Ip).ToList();
                    toSessions.ForEach(s =>
                    {
                        var message = firstParam + "#";
                        TestLogger.Log(message);
                        s.Send(message);
                    });
                }
                else if (request.Content != null)
                {

                    if (firstParam.ToLower() == "reply") //回复
                    {
                        var fromDevice = request.FromDeviceId.ToDeivce();
                        if (fromDevice != null)
                        {
                            toSessions = toSessions.Where(s => s.DeviceId == fromDevice.DeviceId && s.Ip == fromDevice.DeviceId).ToList();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else //发送
                    {
                        var fromDevice = MyAppServer.Sessions.FirstOrDefault(s => s.SessionId == session.SessionID);
                        if (fromDevice != null)
                        {
                            request.FromDeviceId = fromDevice.Ip + "," + fromDevice.DeviceId;

                            var toDevice = request.ToDeviceId.ToDeivce();
                            toSessions = toSessions.Where(s => s.DeviceId == toDevice.DeviceId && s.Ip == toDevice.Ip).ToList();
                        }
                        else
                        {
                            return;
                        }
                    }

                    toSessions.ForEach(s =>
                    {
                        var message = CommandHelper.GetCmdStr(firstParam, request);
                        TestLogger.Log(message);
                        s.Send(message);
                    });
                }
            }
            catch (Exception ex)
            {
                TestLogger.Log(ex.Message + "");
            }

        }
    }
}
