using SuperSocket.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperServer
{
    public class MyWebSocketServer : WebSocketServer<WebSocketSession>
    {
        public MyWebSocketServer() : base()
        {
            this.NewSessionConnected += MyWebSocketServer_NewSessionConnected;
            this.SessionClosed += MyWebSocketServer_SessionClosed;


        }

        private static object obj = new object();
        private void MyWebSocketServer_SessionClosed(WebSocketSession session, SuperSocket.SocketBase.CloseReason value)
        {
            lock (obj)
            {
                var removeSession = MyAppServer.Sessions.FirstOrDefault(s => s.WebSocketSession != null && s.WebSocketSession == session);
                if (removeSession != null)
                {
                    MyAppServer.Sessions.Remove(removeSession);
                }
                MyAppServer.Sessions.RemoveAll(s => s.WebSocketSession != null && !s.WebSocketSession.Connected);
            }
        }

        private void MyWebSocketServer_NewSessionConnected(WebSocketSession session)
        {
            MyAppServer.Sessions.Add(new ConnectSession
            {
                DeviceId = session.SessionID,
                WebSocketSession = session,
                SetIdState = SetIdState.HadSet
            });

        }
    }
}
