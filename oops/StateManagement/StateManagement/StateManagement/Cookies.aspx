<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="StateManagement.Cookies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="txtViewState">
        <asp:Label ID="Label1" runat="server" Text="Cookie Name:" ForeColor="Maroon"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Field Required." ControlToValidate="TextBox1" ValidationGroup="a" Display="Static" ForeColor="#FF3300"></asp:RequiredFieldValidator>
    <br />
    <br />
        <asp:Label ID="Label2" runat="server" Text="Cookie Value:" ForeColor="Maroon"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Field Required." ControlToValidate="TextBox2" ValidationGroup="a" ForeColor="#FF3300"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Save data to Cookies." ValidationGroup="a" OnClick="BtnCookies_Click" />
    <br />
    <br />
         <asp:LinkButton ID="lbReadcookies" runat="server" onclick="lbReadcookies_Click" 
                    Visible="False">Read Cookies</asp:LinkButton>
        <br />
    <br />
 <asp:Label ID="lblReadcookies" runat="server" ForeColor="Red"></asp:Label>
</div>

</asp:Content>
