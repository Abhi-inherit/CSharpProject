using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.AdminManager;
using System.Data.SqlClient;
using System.Data;


namespace ThreeTireWorkshop.Admin
{
    public partial class Register : System.Web.UI.Page
    {
        AdminLogin al = new AdminLogin();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick(object sender, EventArgs e)
        {
            Label9.Text = "";

            if (DropDownList1.SelectedItem.Text == "--Select--" || DropDownList2.SelectedItem.Text == "--Select--")
            {
                if (DropDownList1.SelectedItem.Text == "--Select--")
                {
                    
                    Label7.Text = "*";
                }
                if (DropDownList2.SelectedItem.Text == "--Select--")
                {
                   
                    Label8.Text = "*";
                }
            }
            else
            {
                Label7.Text = "";
                Label8.Text = "";
                if (HiddenField1.Value == "-1")
                {
                    al.Sre.name = TextBox1.Text.Trim().ToString();
                    al.Sre.email = TextBox2.Text.Trim().ToString();
                    al.Sre.password = TextBox3.Text.Trim().ToString();
                    al.Sre.course = DropDownList1.Text.Trim().ToString();
                    al.Sre.district = DropDownList2.SelectedItem.Text;
                    al.Sre.gender = RadioButtonList1.SelectedItem.Value.ToString();
                    string result = al.StdRegInsert();
                    Label9.Text = result;
                    DropDownList1.SelectedValue = "1";
                    DropDownList2.SelectedValue = "28";
                    TextBox1.Text="";
                    TextBox2.Text="";
                    TextBox3.Text = "";
                    GridView1.DataBind(); 
                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Label9.Text = "";
            Button1.Visible = false;
            BtnEdit.Visible = true;
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            TextBox4.Text = grdow.Cells[0].Text;
            TextBox1.Text = grdow.Cells[1].Text;
            TextBox2.Text = grdow.Cells[2].Text;
            TextBox3.Text = grdow.Cells[3].Text;
            DropDownList1.Text = grdow.Cells[4].Text;
            string x = Convert.ToString(grdow.Cells[5].Text);
            District_connection.SelectCommand = "SELECT Id, district_name FROM District ORDER BY CASE WHEN district_name = '"+x+"' THEN 0 ELSE 1 END ASC, district_name ASC";
            RadioButtonList1.SelectedValue = grdow.Cells[6].Text;
        }

       

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Label9.Text = "";
            Button1.Visible = false;
            BtnEdit.Visible = false;
            BtnYes.Visible = true;
            BtnNo.Visible = true;
            Label10.Visible = true;
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            TextBox4.Text = grdow.Cells[0].Text;
            TextBox1.Text = grdow.Cells[1].Text;
            TextBox2.Text = grdow.Cells[2].Text;
            TextBox3.Text = grdow.Cells[3].Text;
            DropDownList1.Text = grdow.Cells[4].Text;
            string x = Convert.ToString(grdow.Cells[5].Text);
            District_connection.SelectCommand = "SELECT Id, district_name FROM District ORDER BY CASE WHEN district_name = '" + x + "' THEN 0 ELSE 1 END ASC, district_name ASC";
            RadioButtonList1.SelectedValue = grdow.Cells[6].Text;
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            Label9.Text = "";
            if (DropDownList1.SelectedItem.Text == "--Select--" || DropDownList2.SelectedItem.Text == "--Select--")
            {
                if (DropDownList1.SelectedItem.Text == "--Select--")
                {

                    Label7.Text = "*";
                }
                if (DropDownList2.SelectedItem.Text == "--Select--")
                {

                    Label8.Text = "*";
                }
            }
            else
            {
                Label7.Text = "";
                Label8.Text = "";
                if (HiddenField1.Value == "-1")
                {
                    al.Sre.stdId = Convert.ToInt32(TextBox4.Text);
                    al.Sre.name = TextBox1.Text.Trim().ToString();
                    al.Sre.email = TextBox2.Text.Trim().ToString();
                    al.Sre.password = TextBox3.Text.Trim().ToString();
                    al.Sre.course = DropDownList1.Text.Trim().ToString();
                    al.Sre.district = DropDownList2.SelectedItem.Text;
                    al.Sre.gender = RadioButtonList1.SelectedItem.Value.ToString();
                    string result = al.StdRegUpdate();
                    Label9.Text = result;
                    DropDownList1.SelectedValue = "1";
                    DropDownList2.SelectedValue = "28";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    BtnEdit.Visible = false;
                    Button1.Visible = true;
                    GridView1.DataBind();
                }
            }
        }

        protected void BtnYes_Click(object sender, EventArgs e)
        {
            al.Sre.stdId = Convert.ToInt32(TextBox4.Text);
            string result = al.stdDelete();
            Label9.Text = result;
            DropDownList1.SelectedValue = "1";
            DropDownList2.SelectedValue = "28";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            BtnYes.Visible = false;
            BtnNo.Visible = false;
            Label10.Visible = false;
            Button1.Visible = true;
            GridView1.DataBind();
        }

        protected void BtnNo_Click(object sender, EventArgs e)
        {
            this.Page_Load(null, null);
            DropDownList1.SelectedValue = "1";
            DropDownList2.SelectedValue = "28";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            BtnYes.Visible = false;
            BtnNo.Visible = false;
            Label10.Visible = false;
            Button1.Visible = true;
            GridView1.DataBind();
        }

       
    }
}