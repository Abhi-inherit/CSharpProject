using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                lbReadcookies.Visible = true;

            }
            if (Request.QueryString["cookie"] != null)
            {
                ReadCookie();
            }
        }

        protected void ReadCookie()
        {
            //Get the cookie name the user entered
            String strCookieName = Request.QueryString["cookie"].ToString();

            //Grab the cookie
            HttpCookie cookie = Request.Cookies[strCookieName];

            //Check to make sure the cookie exists
            if (cookie == null)
            {
                lblReadcookies.Text = "Cookie not found. or Cookies Expaired <br><hr>";

            }
            else
            {
                //Write the cookie value
                String strCookieValue = cookie.Value.ToString();
                lblReadcookies.Text = "The " + strCookieName + " cookie contains: <b>" + strCookieValue + "</b><br><hr>";
            }
        }

        protected void BtnCookies_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie(TextBox1.Text);
            cookie.Value = TextBox2.Text;
            DateTime dtNow = DateTime.Now;
            TimeSpan tsMinute = new TimeSpan(0,0,0,10);
            cookie.Expires = dtNow + tsMinute;
            Response.Cookies.Add(cookie);
        }

        protected void lbReadcookies_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cookies.aspx?cookie=" + TextBox1.Text.ToString());

        }

       
    }
}