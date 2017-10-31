<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="HiddenFields.aspx.cs" Inherits="StateManagement.HiddenFields" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
     <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <div class="txtViewState">

      <asp:Button ID="Button1" runat="server" Text="Dispaly the hidden field" OnClick="Button1_Click" />&nbsp

    <%--<asp:Button ID="btnHidenfieldwo" runat="server" Text="Click here for working of Hidden field" onclick="btnHidenfieldwo_Click" />--%>

      <asp:HiddenField ID="HiddenField1" runat="server" />&nbsp

      <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
    </div>

</asp:Content>
