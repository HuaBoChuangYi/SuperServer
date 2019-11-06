using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer
{
    public class TestLogger
    {
        public static void Log(string message)
        {
            Program.FormMain.Log(DateTime.Now + " " + message + "\r\n");
        }
    }
}
