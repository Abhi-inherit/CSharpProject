using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCounter.Text = counter.ToString();
            counter++;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.ValidationGroup == "a" && Page.IsValid == true )
            {
                ViewState["yourName"] = TextBox1.Text.ToString();
                Lblmsg.Text = "Your name is stored in view state.";
            }
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            Lblmsg.Text = "Hai  " + ViewState["yourName"].ToString() + "  we found your Name in View State";
        }

        public int counter
        {
            get
            {
                if (ViewState["pcounter"] != null)
                {
                    return ((int)ViewState["pcounter"]);
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState["pcounter"] = value;

            }
        }
    }
}