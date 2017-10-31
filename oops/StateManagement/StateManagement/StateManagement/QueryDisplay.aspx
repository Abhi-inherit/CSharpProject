<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="QueryDisplay.aspx.cs" Inherits="StateManagement.QueryDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="txtViewState">

        <asp:Label ID="lblAge" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblName" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblpassword" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblUsername" runat="server" ForeColor="Red"></asp:Label>

    </div>
    
</asp:Content>
