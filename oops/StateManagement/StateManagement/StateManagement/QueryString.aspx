<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="QueryString.aspx.cs" Inherits="StateManagement.QueryString" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="txtViewState">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:Label ID="Label1" runat="server" Text="Name:" ForeColor="Red"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Field required." ValidationGroup="a" ControlToValidate="TextBox1" ForeColor="Maroon"></asp:RequiredFieldValidator>

        <br />
        <br />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:Label ID="Label2" runat="server" Text="Age:" ForeColor="Red"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Filed required." ControlToValidate="TextBox2" ValidationGroup="a" ForeColor="Maroon"></asp:RequiredFieldValidator>

        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="User Name:" ForeColor="Red"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Field required" ControlToValidate="TextBox3" ValidationGroup="a" ForeColor="Maroon"></asp:RequiredFieldValidator>

        <br />
        <br />&nbsp&nbsp
        <asp:Label ID="Label4" runat="server" Text="Password:" ForeColor="Red"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Field required" ControlToValidate="TextBox4" ValidationGroup="a" ForeColor="Maroon"></asp:RequiredFieldValidator>

       
        <br />
        <br />
        <br />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
              &nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:Button ID="Button1" runat="server" Text="Submit to save." ValidationGroup="a" OnClick="BtnSend_Click" />

        <br />
        <br />
        <asp:Label ID="lblAge" runat="server" ForeColor="Maroon"></asp:Label>
        <br />
        <asp:Label ID="lblName" runat="server" ForeColor="Maroon"></asp:Label>
        <br />
        <asp:Label ID="lblpassword" runat="server" ForeColor="Maroon"></asp:Label>
        <br />
        <asp:Label ID="lblUsername" runat="server" ForeColor="Maroon"></asp:Label>
</div>
   

</asp:Content>
