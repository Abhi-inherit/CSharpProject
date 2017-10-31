using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class entyPlace
    {
        public int Id { get; set; }
        public int Fk_Districtid { get; set; }
        public string District { get; set; }
        public string Places { get; set; }
        public string Discription { get; set; }
        public string Nearesr_Place { get; set; }
        public string Image { get; set; }
        public System.DateTime Created_date { get; set; }
        public System.DateTime Updated_date { get; set; }
        public string Status { get; set; }
    }
}
