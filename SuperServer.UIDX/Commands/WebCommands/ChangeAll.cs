using SuperServer.Models;
using SuperSocket.WebSocket;
using SuperSocket.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer.Helpers
{
    /// <summary>
    /// 全开全关
    /// </summary>
    public class ChangeAll : SubCommandBase<WebSocketSession>
    {
        public override void ExecuteCommand(WebSocketSession session, SubRequestInfo requestInfo)
        {
            try
            {
                Logger.Error(requestInfo.ToString2());
                var request = requestInfo.ToBaseModel();
                var obj = JsonHelper.DeserializeJsonToObject<ChangeAllModel>(request.Content + "");
                if (obj != null)
                {
                    MyAppServer.Sessions.Where(s => s.AppSession != null).ToList().ForEach(s =>
                    {
                        s.Send("change", request);
                    });
                }


            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }

        }
    }
}
