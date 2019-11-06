using SuperServer.Services;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer
{
    public class MyAppServer : AppServer<AppSession>
    {
        public static List<ConnectSession> Sessions = new List<ConnectSession>();
        public MyAppServer()
            : base(new TerminatorReceiveFilterFactory("#"))
        {
            // this.NewRequestReceived += MyAppServer_NewRequestReceived;

        }

        private void MyAppServer_NewRequestReceived(AppSession session, StringRequestInfo requestInfo)
        {
            SuperServer.TestLogger.Log(requestInfo.ToString2());
        }

        protected override void OnNewSessionConnected(AppSession session)
        {
            base.OnNewSessionConnected(session);

            var newClient = new ConnectSession
            {
                AppSession = session,
                SetIdState = SetIdState.Connecting,
                DeviceId = "",
                IsThree = false
            };
            Sessions.Add(newClient);

            string IP = session.RemoteEndPoint.Address + "";
            if (IP.IsThreeDevice())
            {
                newClient.DeviceId = IP.Substring(IP.LastIndexOf(".") + 1);
                newClient.SetIdState = SetIdState.HadSet;
                newClient.IsThree = true;
            }

        }

        private static object obj = new object();
        protected override void OnSessionClosed(AppSession session, CloseReason reason)
        {
            base.OnSessionClosed(session, reason);
            lock (obj)
            {
                var removeSession = MyAppServer.Sessions.FirstOrDefault(s => s.AppSession != null && s.AppSession == session);
                if (removeSession != null)
                {
                    MyAppServer.Sessions.Remove(removeSession);
                }
                MyAppServer.Sessions.RemoveAll(s => s.AppSession != null && !s.AppSession.Connected);
            }


            //if (Sessions.Any(s => s.AppSession == session))
            //{
            //    Sessions.Remove(Sessions.FirstOrDefault(s => s.AppSession == session));
            //}

        }



    }
}
