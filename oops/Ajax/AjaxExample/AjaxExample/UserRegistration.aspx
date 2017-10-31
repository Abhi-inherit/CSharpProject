<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="AjaxExample.UserRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="Style/bootstrap.css" rel="stylesheet" />
    <script src="Script/jquery-1.9.1.js"></script>
    <script src="Script/UserRegistration.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-top:50px;">
    <div class="container" style="width: 35%; background-color:aliceblue; margin: 10px auto;" id="RegisterPage">
            <div class="row" style="margin: 30px auto;">
                <div class="col-lg-8">

                    <div class="form-group">
                        <label for="InputName">REGISTER FORM</label>
                       
                        
                    </div>

                    <div class="form-group">
                        <label for="InputName">Enter Name</label>
                        <div class="input-group">
                            <asp:TextBox ID="Txt_Name" runat="server"></asp:TextBox>
                            <span id="ValTxt_Name" style="display:none">&nbsp Enter your name.</span>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="InputEmail">Enter Email</label>
                        <div class="input-group">
                            <asp:TextBox ID="Txt_Email" runat="server"></asp:TextBox>
                            <span id="ValTxt_Email" style="display:none">&nbsp Enter valid mail id.</span>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="InputPhone">Phone No</label>
                        <div class="input-group">
                            <asp:TextBox ID="Txt_PhoneNo" runat="server"></asp:TextBox>
                            <span id="ValTxt_PhoneNo" style="display:none">&nbsp Enter phone number.</span>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="InputWebsite">Website</label>
                        <div class="input-group">
                            <asp:TextBox ID="Txt_Website" runat="server"></asp:TextBox>
                            <span id="ValTxt_Website" style="display:none">&nbsp Enter registered website.</span>
                        </div>
                    </div>
                  
                    <div class="form-group">
                        <label for="InputEmail">Password</label>
                        <div class="input-group">
                            <asp:TextBox ID="Txt_Password" runat="server"></asp:TextBox>   
                             <span id="ValTxt_Password" style="display:none">&nbsp Enter password.</span>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="InputEmail">Confirm Password</label>
                        <div class="input-group">
                            <asp:TextBox ID="Txt_Confirm_Password" runat="server"></asp:TextBox>
                             <span id="ValTxt_Confirm_Password" style="display:none">&nbsp Confirm password.</span>
                        </div>
                    </div>

                    <br />

                   
                    <input type="button" name="" id="btnRegister" value="Register" onclick="Register()" class="btn btn-info pull-left"/>
                    <br />
                    <br />
                    <br />

                    Login <a href="UserLogin.aspx">Click</a> hear

                   </div>
            </div>
            <div class="col-lg-5 col-md-push-1">
            <div class="col-md-12">
            </div>
        </div>
        </div>
    </div>
    </form>
</body>
</html>
