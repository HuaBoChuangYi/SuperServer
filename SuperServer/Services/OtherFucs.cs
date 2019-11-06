using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer
{
    public class OtherFucs
    {
        /// <summary>
        /// 判断设备是否是第三方设备
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool ThreeDeviceIsInDB(string ip)
        {
            int index = ip.LastIndexOf(".");
            return ip.Substring(index + 1).ToInt() > 200;
        }
    }
}
