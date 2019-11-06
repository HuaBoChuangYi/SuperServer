using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer.Services
{
    public class PagedDevice
    {
        public int TotalCount { get; set; }
        public List<Device> Items { get; set; }
    }
}
