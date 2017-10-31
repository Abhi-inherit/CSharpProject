using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnSend_Click(object sender, EventArgs e)
        {
            if (Button1.ValidationGroup == "a" && Page.IsValid == true) 
            {
                Response.Redirect("QueryDisplay.aspx?name='"+TextBox1.Text+"'&age='"+TextBox2.Text+"'&userName='"+TextBox3.Text+"'&passWord='"+TextBox4.Text+"'"); 
            }
        }
    }
}