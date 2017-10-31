<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="AjaxExample.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="Style/bootstrap.css" rel="stylesheet" />
    <script src="Script/jquery-1.7.1.intellisense.js"></script>
    <script src="Script/jquery-1.9.1.js"></script>
    <script src="Script/UserRegistration.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container" style="width: 20%; background-color:aliceblue; margin: 10px auto;">
                <div class="row">
                    <div class="col-lg-8">
                        <div style="margin-top: 10px" id="loginDiv">
                            <div class="form-group">
                                <label for="InputName">Enter Mail-ID</label>
                                <div class="input-group">
                                   <asp:TextBox ID="Txt_Email" runat="server"></asp:TextBox>
                                   <span id="ValTxt_Email" style="display:none">&nbsp Enter valid mail id.</span>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="InputName">Enter Password</label>
                                <div class="input-group">
                                    <asp:TextBox ID="Txt_Password" runat="server"></asp:TextBox>   
                                    <span id="ValTxt_Password" style="display:none">&nbsp Enter password.</span>
                                </div>
                            </div>
                            
                                                
                            <input id="Button1" class="btn btn-info pull-left" name="" type="button" value="Sign In" onclick="Login()" />

                            <br />
                            <br />
                            Register <a href="UserRegistration.aspx">Click</a> hear
                            
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

