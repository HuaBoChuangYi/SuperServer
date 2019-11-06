using SuperServer.Services;
using SuperSocket.WebSocket;
using SuperSocket.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer.Commands.WebCommands
{
    public class Connection : SubCommandBase
    {
        public override void ExecuteCommand(WebSocketSession session, SubRequestInfo requestInfo)
        {
            try
            {
                TestLogger.Log(requestInfo.ToString2());
                var request = requestInfo.ToBaseModel();
                var obj = JsonHelper.DeserializeJsonToObject<ConnectionModel>(request.Content + "");

                var sessions = MyAppServer.Sessions
                    .Where(s => s.AppSession != null)
                    .ToList();
                sessions.ForEach(s =>
                {
                    if (!string.IsNullOrEmpty(s.DeviceId))
                    {
                        s.SetIdState = SetIdState.HadSet;
                    }
                    else
                    {
                        s.SetIdState = SetIdState.NotSet;
                    }
                });



                var data = sessions.Select(s => new
                {
                    s.Ip,
                    s.DeviceId,
                    s.SetIdState,
                    s.IsThree
                }).ToList();

                string message = "Reply " + JsonHelper.SerializeObject(new SendBaseModel
                {
                    Content = new ReplyModel
                    {
                        Data = data,
                        Message = Encoding.UTF8.GetBytes("获取成功").ToString(),
                        Success = 1
                    },
                    CommandId = request.CommandId
                });
                TestLogger.Log(message);

                session.Send(message);
            }
            catch (Exception ex)
            {
                TestLogger.Log(ex.Message + "");
            }

        }
    }
}
