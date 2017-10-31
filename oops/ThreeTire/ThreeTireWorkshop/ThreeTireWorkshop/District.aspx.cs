using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.AdminManager;

namespace ThreeTireWorkshop.Admin
{
    public partial class District : System.Web.UI.Page
    {
        AdminLogin Al = new AdminLogin();

        protected void Page_Load(object sender, EventArgs e)
        {
            BtnEdit.Visible = false;
            lblConfirm.Visible = false;
            btnDelYes.Visible = false;
            btnDelNo.Visible = false;
        }

        protected void BtnDistrictClick(object sender, EventArgs e)
        {
            if(HiddenField1.Value == "-1")
            {
                DistrictInsert();
            }

        }

        public void DistrictInsert() 
        {
            
            Al.Dis.districtName = TextBox1.Text.Trim().ToString();
           string result = Al.DistrictInsert();
           if (result == "Already Exist")
           {
               Label2.Text = result;
           }
           else
           {
               TextBox1.Text = "";
               Label2.Text = result;
               GridView1.DataBind();
           }
           
        }


        protected void Delete_Click(object sender, ImageClickEventArgs e)
        {
            Label2.Text = "";
            
            Button1.Visible = false;
            lblConfirm.Visible = true;
            btnDelYes.Visible = true;
            btnDelNo.Visible = true;
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            TextBox2.Text = GridView1.DataKeys[grdow.RowIndex].Value.ToString();
            TextBox1.Text = grdow.Cells[1].Text;
            TextBox1.ReadOnly = true;
        }



        protected void Edit_Click1(object sender, ImageClickEventArgs e)
        {
            Label2.Text = "";
            Button1.Visible = false;
            BtnEdit.Visible = true;
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            TextBox2.Text = GridView1.DataKeys[grdow.RowIndex].Value.ToString();
            TextBox1.Text = grdow.Cells[1].Text;
        }

        protected void Btn_Edit_Click(object sender, EventArgs e)
        {
            Al.Dis.districtId = Convert.ToInt32(TextBox2.Text);
            Al.Dis.districtName = TextBox1.Text;
            string result = Al.DistrictUpdate();
            TextBox1.Text = "";
            Label2.Text = result;
            GridView1.DataBind();
        }

        protected void btnDelYes_Click(object sender, EventArgs e)
        {
            Al.Dis.districtId = Convert.ToInt32(TextBox2.Text);
            string result = Al.DistrictDelete();
            Label2.Text = result;
            GridView1.DataBind();
            TextBox1.Text = "";
            TextBox1.ReadOnly = false;
            Button1.Visible = true;
        }

        protected void btnDelNo_Click(object sender, EventArgs e)
        {
            this.Page_Load(null, null);
            TextBox1.Text = "";
            Button1.Visible = true;
        }

       
    }
}