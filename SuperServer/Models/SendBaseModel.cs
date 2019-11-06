using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer
{
    public class SendBaseModel
    {
        public object Content { get; set; }
        /// <summary>
        /// IP地址+','+deviceId
        /// </summary>
        public string FromDeviceId { get; set; }
        public string ToDeviceId { get; set; }
        public string CommandId { get; set; }

        public override string ToString()
        {
            return string.Format("来源：{0};目标：{1};内容：{2} ,", FromDeviceId, ToDeviceId, Content);
        }

    }
}
