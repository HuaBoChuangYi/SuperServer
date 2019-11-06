using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer
{
    public static class AppSessionExtension
    {
        public static string GetAddress(this AppSession session)
        {
            string result = "";
            var fromDevice = MyAppServer.Sessions.FirstOrDefault(s => s.SessionId == session.SessionID);
            if (fromDevice != null)
            {
                result = fromDevice.IP + "," + fromDevice.DeviceId;
            }
            return result;
        }
    }
}
