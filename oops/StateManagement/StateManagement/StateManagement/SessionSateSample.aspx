<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="SessionSateSample.aspx.cs" Inherits="StateManagement.SessionSateSample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="txtViewState" style="color:red">
      
         Welcome Mr. <asp:Label ID="Label1" runat="server" Text="X" ForeColor="Red"></asp:Label><br /><br />
        
         Select your course from the list below.<br />
         <asp:ListBox ID="ListBox1" runat="server" Width="45%"></asp:ListBox>
         <br />
         <br />
         <asp:Button ID="Button1" runat="server" Text="More info:-" OnClick="MoreInfo" /><br /><br />
         <asp:Label ID="Label3" runat="server" Text="" ForeColor="Red"></asp:Label>
           <br />  <br />  <br />
         Session Details.  <br />
         <asp:Label ID="Label2" runat="server" ForeColor="#CCFFFF"></asp:Label>
        </div>

</asp:Content>
