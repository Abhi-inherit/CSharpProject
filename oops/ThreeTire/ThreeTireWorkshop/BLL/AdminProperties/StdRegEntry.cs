using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AdminProperties
{
    public class StdRegEntry
    {
        public int stdId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string course { get; set; }
        public string district { get; set; }
        public string gender { get; set; }
    }
}
