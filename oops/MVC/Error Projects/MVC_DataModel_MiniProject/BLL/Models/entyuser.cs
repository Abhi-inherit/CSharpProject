using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class entyuser
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public string User_name { get; set; }
        public string Password { get; set; }
        public System.DateTime Created_date { get; set; }
        public System.DateTime Updated_date { get; set; }
        public string status { get; set; }

    }
}
