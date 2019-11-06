using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer
{
    public class CommandHelper
    {
        public static string GetCmdStr(string command, object obj)
        {
            string message = "";
            if (command.ToLower() == "reply" && obj is SendBaseModel)
            {
                var data = obj as SendBaseModel;
                data.Content = JsonHelper.DeserializeJsonToObject<ReplyModel>(data.Content + "");
                message = command + " " + JsonHelper.SerializeObject(data) + "#";
            }
            else
            {
                message = command + " " + JsonHelper.SerializeObject(obj) + "#";
            }
            //Logger.Log(message + "");
            return message;
        }
    }
}
