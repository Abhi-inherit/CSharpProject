using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BLL.Models
{
    public class entyuser
    {
        [ScaffoldColumn(false)] // ScaffoldColumn - Allows hiding fields from editor forms
        public int Id { get; set; }

        [Required]  // Required - Indicates that the property is a required field
        [DisplayName("Registration name")] // DisplayName - Defines the text to be used on form fields and validation messages
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
