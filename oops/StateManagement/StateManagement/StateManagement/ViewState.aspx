<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="StateManagement.ViewState" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="txtViewState">
    <asp:Label ID="Label1" runat="server" Text="Name" ForeColor="#CCFF66"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Field required." ControlToValidate="TextBox1" ForeColor="#990000"></asp:RequiredFieldValidator>
    </div>  

    <div class="btnViewState">
    <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Save data" ValidationGroup="a" /> &nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="Button2" runat="server" Text="Show saved data." onclick="btnRead_Click" />
         <br />
        <br />
   <asp:Label ID="Lblmsg" runat="server" ForeColor="#FF3300"></asp:Label>
   <br />
    <br />
    <br />
    <br />
        <br />
    <br />
        <br />
    <br />
        <br />
    <br />
        <br />
    <br />
        <br />
        <br />
    <br />
    <br />
   
        <p style="color: #FF9933">Page counter:<asp:Label ID="lblCounter" runat="server" Text="" ForeColor="#FF3300"></asp:Label></p>

    </div>
    <p>
    </p>
</asp:Content>
