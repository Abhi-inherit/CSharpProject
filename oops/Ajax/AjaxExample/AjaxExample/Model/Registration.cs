using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxExample.Model
{
    public class Registration
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}