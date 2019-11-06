using Newtonsoft.Json;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer
{
    public static class StringExtension
    {
        private static List<int> m_threeIps = null;
        public static List<int> ThreeIps
        {
            get
            {
                if (m_threeIps == null)
                {
                    m_threeIps = new List<int>();
                    string three = ConfigurationManager.AppSettings["three"] + "";
                    three.Split(",".ToCharArray()).ToList().ForEach(s =>
                    {
                        m_threeIps.Add(s.ToInt());
                    });
                }
                return m_threeIps;
            }
        }
        public static int ToInt(this string value)
        {
            var result = 0;
            try
            {
                result = Convert.ToInt32(value);
            }
            catch (Exception)
            {
                result = -1;
            }
            return result;
        }

        public static bool IsThreeDevice(this string ip)
        {
            bool result = false;

            string lastIpNo = ip.Substring(ip.LastIndexOf(".") + 1);
            int ipNo = lastIpNo.ToInt();
            if (ThreeIps.Any(s => s == ipNo) || ipNo > 200)
            {
                result = true;
            }

            return result;
        }

        public static T ToObject<T>(this string json) where T : class
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                StringReader sr = new StringReader(json);
                object o = serializer.Deserialize(new JsonTextReader(sr), typeof(T));
                T t = o as T;
                return t;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Device ToDeivce(this string value)
        {
            Device device = null;
            int index = value.IndexOf(",");
            if (index != -1)
            {
                device = new Device
                {
                    Ip = value.Substring(0, index),
                    DeviceId = value.Substring(index + 1)
                };
            }
            return device;
        }

        public static string ToString2(this SubRequestInfo value)
        {
            return value.Key + " " + value.Body;
        }

        public static string ToString2(this StringRequestInfo value)
        {
            return value.Key + " " + value.Body;
        }


    }

}
