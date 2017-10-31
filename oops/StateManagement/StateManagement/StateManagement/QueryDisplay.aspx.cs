using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class QueryDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                lblAge.Text = Request.QueryString["age"];
                lblName.Text = Request.QueryString["name"];
                lblpassword.Text = Request.QueryString["passWord"];
                lblUsername.Text = Request.QueryString["userName"];
            }
        }
    }
}