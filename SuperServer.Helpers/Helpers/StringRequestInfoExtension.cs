using SuperSocket.SocketBase.Protocol;
using SuperSocket.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer
{
    public static class RequestInfoExtension
    {
        /// <summary>
        /// XXXX {}#
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static SendBaseModel ToBaseModel(this StringRequestInfo info)
        {
            var key = info.Key;
            var body = info.Body;

            var request = JsonHelper.DeserializeJsonToObject<SendBaseModel>(body);
            return request;
        }

        /// <summary>
        /// Send XXXX {}#
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static SendBaseModel ToSendModel(this StringRequestInfo info)
        {
            var key = info.Key;
            var body = info.Body;

            var request = JsonHelper.DeserializeJsonToObject<SendBaseModel>(info.Parameters[1]);
            return request;
        }

        /// <summary>
        /// XXXX {}#
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static SendBaseModel ToBaseModel(this SubRequestInfo info)
        {
            var key = info.Key;
            var body = info.Body;

            var request = JsonHelper.DeserializeJsonToObject<SendBaseModel>(body);
            return request;
        }

        /// <summary>
        /// Send XXXX {}#
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static SendBaseModel ToSendModel(this SubRequestInfo info)
        {
            var request = JsonHelper.DeserializeJsonToObject<SendBaseModel>(info.ToSecParam());
            return request;
        }

        /// <summary>
        /// 第一个参数
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static string ToFirstParam(this SubRequestInfo info)
        {
            string firstParam = "";
            try
            {
                var key = info.Key;
                var body = info.Body;


                firstParam = body.Substring(0, body.IndexOf(" "));
            }
            catch (Exception)
            {
                firstParam = "";
            }
            return firstParam;
        }

        /// <summary>
        /// 第二个参数
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static string ToSecParam(this SubRequestInfo info)
        {
            var key = info.Key;
            var body = info.Body;

            string secondParam = body.Substring(body.IndexOf(" ") + 1);
            return secondParam;
        }

    }
}
