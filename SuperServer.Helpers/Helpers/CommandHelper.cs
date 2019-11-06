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
            try
            {
                var data = obj as SendBaseModel;
                if (data == null)
                {
                    return "";
                }

                Logger.LogForm.Log(new LogMessage
                {
                    FromDeviceId = data.FromDeviceId,
                    ToDeviceId = data.ToDeviceId,
                    Key = command,
                    Content = JsonHelper.SerializeObject(data.Content) + ""
                });

                string message = "";
                if (command.ToLower() == "reply")
                {
                    //改成小写
                    data.Content = JsonHelper.DeserializeJsonToObject<ReplyModel>(JsonHelper.SerializeObject(data.Content));
                    message = command + " " + JsonHelper.SerializeObject(data) + "#";
                }
                else
                {
                    if (data.Content == null)
                    {
                        message = command + "#";
                    }
                    else
                    {
                        message = command + " " + JsonHelper.SerializeObject(obj) + "#";
                    }
                }
                return message;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
