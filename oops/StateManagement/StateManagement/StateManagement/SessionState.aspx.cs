using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class SessionState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        //protected void btnLogin_Click(object sender, EventArgs e)
        //{
        //    if (btnLogin.ValidationGroup == "a" && Page.IsValid == true)
        //    {
        //        Session.Add("UserName", txtUsername.Text);
        //        Response.Redirect("~/SessionSateSample.aspx");
        //    }
        //}

        protected void BtnClick(object sender, EventArgs e)
        {
            if (Button1.ValidationGroup == "a" && Page.IsValid == true)
            {
                Session.Add("Username", TextBox1.Text);
                Response.Redirect("~/SessionSateSample.aspx");
            }
        }
    }
}