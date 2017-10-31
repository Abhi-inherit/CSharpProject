using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxExample
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        [WebMethod]
        public static string Login(string userName, string password)
        {
            NameValueCollection LoginSettings = (NameValueCollection)ConfigurationManager.GetSection("LoginDetails");

            string x = "Admin";
            string y = "Admin";

            string Username = x;
            string Password = y;

            if ((userName == Username) && (password == Password))
            {
                return "Success in Login";
            }
            else
            {
                return "Failed";
            }
        }

    }
}