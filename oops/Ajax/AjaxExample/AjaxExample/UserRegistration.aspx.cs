using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxExample.Model;

namespace AjaxExample
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

         [WebMethod]
        public static Registration Register(Registration userDetails) 
        {

            Registration obj = new Registration();
            obj.Name = "Name : " + userDetails.Name;
            obj.Email = "E-Mail : " + userDetails.Email;
            obj.PhoneNumber = "PhoneNumber : " + userDetails.PhoneNumber;
            obj.Website = "Website : " + userDetails.Website;
            obj.Password = "Password : " + userDetails.Password;
            obj.ConfirmPassword = "Confirm Password : " + userDetails.ConfirmPassword;

            return obj;
        }

    }
}