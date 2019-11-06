using SuperSocket.WebSocket;
using SuperSocket.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer.Helpers
{
    public class Send : SubCommandBase<WebSocketSession>
    {
        public override void ExecuteCommand(WebSocketSession session, SubRequestInfo requestInfo)
        {
            try
            {
                var request = requestInfo.ToSendModel();
                string firstParam = requestInfo.ToFirstParam();
                var toSessions = MyAppServer.Sessions;


                if (string.IsNullOrWhiteSpace(firstParam))
                {
                    Logger.Error("命令发送错误");
                    return;
                }
                //else if (request.Content == null)
                //{
                //    toSessions = toSessions.Where(s => s.Address == request.ToDeviceId).ToList();
                //    toSessions.ForEach(s =>
                //    {
                //        s.Send(firstParam, request);
                //    });
                //}
                //else if (request.Content != null)
                //{
                //if (firstParam.ToLower() == "reply") //回复
                //{
                //    toSessions = toSessions.Where(s => s.Address == request.FromDeviceId).ToList();
                //}
                //else //发送
                //{
                //    var fromDevice = MyAppServer.Sessions.FirstOrDefault(s => s.SessionId == session.SessionID);
                //    request.FromDeviceId = fromDevice.IP + "," + fromDevice.DeviceId;

                //    var toDevice = request.ToDeviceId.ToDeivce();
                //    toSessions = toSessions.Where(s => s.Address == request.ToDeviceId).ToList();

                //}

                var fromDevice = MyAppServer.Sessions.FirstOrDefault(s => s.SessionId == session.SessionID);
                request.FromDeviceId = fromDevice.Address;

                toSessions = toSessions.Where(s => s.Address == request.ToDeviceId).ToList();
                toSessions.ForEach(s =>
                {
                    s.Send(firstParam, request);
                });
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message + "");
            }

        }
    }
}
