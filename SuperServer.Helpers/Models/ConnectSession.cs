using SuperSocket.SocketBase;
using SuperSocket.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer
{
    public class ConnectSession
    {
        /// <summary>
        /// web使用sessionid
        /// 客户端sessionid，分为
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// 设置Id的状态
        /// </summary>
        public SetIdState SetIdState { get; set; }

        public bool IsThree { get; set; }
        public string SessionId
        {
            get
            {
                return this.AppSession == null ? this.WebSocketSession.SessionID : this.AppSession.SessionID;
            }
        }

        public WebSocketSession WebSocketSession { get; set; }
        public AppSession AppSession { get; set; }

        public string IP
        {
            get
            {
                return this.AppSession != null ? this.AppSession.RemoteEndPoint.Address + "" : this.WebSocketSession.RemoteEndPoint.Address + "";
            }
        }

        public string Address { get { return this.IP + "," + this.DeviceId; } }


        public void Send(string key, object request)
        {
            try
            {
                string message = CommandHelper.GetCmdStr(key, request);
                if (WebSocketSession != null)
                {
                    WebSocketSession.Send(message);
                }
                else if (AppSession != null)
                {
                    AppSession.Send(message);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }
    }

    public enum SetIdState
    {
        Connecting = 1,//刚连接
        NotSet = 2,    //未设置
        HadSet = 3     //已设置
    }
}
