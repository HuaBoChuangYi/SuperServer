using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer
{
    public class ReplyModel
    {
        public object Data { get; set; }
        /// <summary>
        /// 0 失败
        /// 1 成功
        /// </summary>
        public int Success { get; set; }
        public string Message { get; set; }
    }
}
