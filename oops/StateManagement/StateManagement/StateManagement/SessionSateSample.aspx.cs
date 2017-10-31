using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StateManagement.Classes;

namespace StateManagement
{
    public partial class SessionSateSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                if (Session.Contents["Username"] == null)
                {
                    Response.Redirect("~/SessionState.aspx");
                }
                else
                {
                    Label1.Text = Session.Contents["Username"].ToString();

                    ProductDetails pd1 = new ProductDetails("PHP","6 Months","MySql","30,000","HTML,CSS,Javascript,Ajax,PHP,Three tier,MVC","7 Hour");
                    ProductDetails pd2 = new ProductDetails("ASP.Net", "7 Months", "Sql", "40,000", "HTML,CSS,Javascript,Ajax,PHP,Three tier,MVC", "8 Hour");
                    ProductDetails pd3 = new ProductDetails("Java", "6 Months", "Oracle", "40,000", "HTML,CSS,Javascript,Ajax,PHP,Three tier,MVC", "7 Hour");
                    ProductDetails pd4 = new ProductDetails("Android", "6 Months", "MySql,Sql,Oracle", "45,000", "HTML,CSS,Javascript,Ajax,PHP,Three tier,MVC", "7 Hour");

                    Session["PD1"] = pd1;
                    Session["PD2"] = pd2;
                    Session["PD3"] = pd3;
                    Session["PD4"] = pd4;

                    ListBox1.Items.Clear();
                    ListBox1.Items.Add(pd1.name);
                    ListBox1.Items.Add(pd2.name);
                    ListBox1.Items.Add(pd3.name);
                    ListBox1.Items.Add(pd4.name);


                    Label2.Text = "Session ID: " + Session.SessionID;
                    Label2.Text += "<br>Number of objects: ";
                    Label2.Text += Session.Count.ToString();
                    Label2.Text += "<br>Mode: " + Session.Mode.ToString();
                    Label2.Text += "<br>Is Cookieless: ";
                    Label2.Text += Session.IsCookieless.ToString();
                    Label2.Text += "<br>Is New: ";
                    Label2.Text += Session.IsNewSession.ToString();
                    Label2.Text += "<br>Time out(min):";
                    Label2.Text += Session.Timeout.ToString();
                }
            }

        }

        protected void MoreInfo(object sender, EventArgs e)
        {
            if (Session["PD1"] == null && Session["PD2"] == null && Session["PD3"] == null)
            {
                Label2.Text = "Your session timed out.";
            }
            else
            {
                if (ListBox1.SelectedIndex == -1)
                {
                    Label3.Text = "Select any one course.";
                }
                else 
                {
                    string key = "PD" + (ListBox1.SelectedIndex + 1).ToString();

                    ProductDetails prd = (ProductDetails)Session[key];
                    Label3.ForeColor = System.Drawing.Color.White;
                    Label3.Text = "Course: " + prd.name;
                    Label3.Text += "<br>Duration: " + prd.duration;
                    Label3.Text += "<br>Database for project: "+prd.database;
                    Label3.Text += "<br>Course Fee:" + prd.fee;
                    Label3.Text += "<br>Topics: "+ prd.topics;
                    Label3.Text += "<br>Hours per day:"+prd.perDayHours;
                }
            }
        }
    }
}