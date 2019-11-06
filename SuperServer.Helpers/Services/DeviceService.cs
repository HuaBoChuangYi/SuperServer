using EasyHttp.Http;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer.Services
{
    public class DeviceService
    {
        public static string Server
        {
            get
            {
                return ConfigurationManager.AppSettings["server"] + "";
            }
        }

        public static bool IsInDB(string deviceId, string ip)
        {
            bool result = false;
            try
            {
                string url = string.Format("{0}/api/services/app/device/IsInDB?ip={1}&deviceid={2}", Server, ip, deviceId);

                var http = new HttpClient();
                var reponse = http.Get(url);
                var abpResult = reponse.StaticBody<IsInDbResult>(); // JsonHelper.DeserializeJsonToObject<AbpResult>(reponse);
                result = abpResult != null ? abpResult.Result : false;
            }
            catch (Exception)
            {
            }

            return result;
        }

        public static List<Device> GetDevices(long? tenantId = null)
        {
            List<Device> result = new List<Device>();
            try
            {
                string url = string.Format("{0}/api/services/app/device/GetAll?tenantId={1}", Server, tenantId);

                var http = new HttpClient();
                var reponse = http.Get(url);
                var abpResult = reponse.StaticBody<GetDevicesResult>();

                result = abpResult.Result.Items;
            }
            catch (Exception)
            {
            }
            return result;
        }
    }
}
