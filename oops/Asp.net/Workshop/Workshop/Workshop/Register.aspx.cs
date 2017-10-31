using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Workshop
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtAge.Text = "";
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label10.Text = Calendar1.SelectedDate.ToString();
        }
    }
}