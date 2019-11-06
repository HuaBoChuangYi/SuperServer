using SuperServer.Models;
using SuperSocket.WebSocket;
using SuperSocket.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer.Commands.WebCommands
{
    /// <summary>
    /// 全开全关
    /// </summary>
    public class ChangeAll : SubCommandBase
    {
        public override void ExecuteCommand(WebSocketSession session, SubRequestInfo requestInfo)
        {
            try
            {
                TestLogger.Log(requestInfo.ToString2());
                var request = requestInfo.ToBaseModel();
                var obj = JsonHelper.DeserializeJsonToObject<ChangeAllModel>(request.Content + "");
                if (obj != null)
                {
                    MyAppServer.Sessions.Where(s => s.AppSession != null).ToList().ForEach(s =>
                    {
                        string message = CommandHelper.GetCmdStr("change", request);
                        TestLogger.Log(message);
                        //
                        s.Send("message");
                    });
                }


            }
            catch (Exception ex)
            {
                TestLogger.Log(ex.Message);
            }

        }
    }
}
