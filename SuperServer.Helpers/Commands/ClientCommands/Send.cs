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
                var request = requestInfo.ToSendModel();

                var toSessions = MyAppServer.Sessions;
                if (requestInfo.GetFirstParam().ToLower() == "reply")//返回
                {
                    toSessions = toSessions.Where(s => s.Address == request.FromDeviceId).ToList();
                }
                else//转发
                {
                    var fromDevice = MyAppServer.Sessions.FirstOrDefault(s => s.SessionId == session.SessionID);
                    request.FromDeviceId = fromDevice.Address;

                    toSessions = toSessions.Where(s => s.Address == request.ToDeviceId).ToList();
                }


                toSessions.ForEach(s =>
                {
                    s.Send(requestInfo.GetFirstParam(), request);
                });
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message + "");
            }


        }
    }
}
