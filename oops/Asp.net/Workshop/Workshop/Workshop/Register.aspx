<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Workshop.WebForm2" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="name">
    <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Field required." ControlToValidate="txtName"></asp:RequiredFieldValidator>
    </div>

    <div class="dateOfBirth">
        <asp:Label ID="Label2" runat="server" Text="Date of birth:"></asp:Label>
    </div>

    <div class="dateDisplay">
 <asp:Label ID="Label10" runat="server" Text="Test"></asp:Label>
</div>

    <div class="calander">
        <asp:Calendar ID="Calendar1" runat="server" ControlToValidate="Calendar1" OnSelectionChanged="Calendar1_SelectionChanged"> </asp:Calendar>
    </div>

    <br />
    <br />

    <div class="age">
<asp:Label ID="Label3" runat="server" Text="Age:"></asp:Label>
    <asp:TextBox ID="txtAge" runat="server" Width="30px" ControlToValidate="txtAge"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Age required." ControlToValidate="txtAge"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter a valid age." ValidationExpression="^(?:100|[1-9]?[0-9])$" ControlToValidate="txtAge"></asp:RegularExpressionValidator>
    </div>

    <br />
    <br />

    <div class="gender">
    <asp:Label ID="Label4" runat="server" Text="Gender:"></asp:Label></div>

    <div class="radioButton1">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
           <asp:ListItem Selected="True">Male</asp:ListItem> 
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    </div>

    <div class="qualification">
    <asp:Label ID="LblQuali" runat="server" Text="Qualification:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Text="BCA" Value="BCA" />
            <asp:ListItem Text="MCA" Value="MCA" />
            <asp:ListItem Text="BSC" Value="BSC" />
        </asp:DropDownList>
    </div>

    <div class="image">
        <asp:Label ID="Label5" runat="server" Text="Image:"></asp:Label>
        <asp:FileUpload ID="fpPicture" runat="server" />
    </div>

    <div class="contactNumber">
    <asp:Label ID="Label6" runat="server" Text="Contact number:"></asp:Label>
    <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Contact number required." ControlToValidate="txtContact"></asp:RequiredFieldValidator>
    </div>

    <div class="email">
    <asp:Label ID="Label7" runat="server" Text="Email:"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Email required." ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
    </div>

    <div class="password1">
        <asp:Label ID="Label8" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword1" runat="server" ControlToCompare="txtPassword1" TextMode="SingleLine" ReadOnly="False"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Password can't be blank." ControlToValidate="txtPassword1"></asp:RequiredFieldValidator>
    </div>

    <div class="password2">
        <asp:Label ID="Label9" runat="server" Text="Confirm Password:"></asp:Label>
        <asp:TextBox ID="txtPassword2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Password can't be blank." ControlToValidate="txtPassword2"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Both password must match" ControlToCompare="txtPassword1" ControlToValidate="txtPassword2"></asp:CompareValidator>
    </div>
    
    <div class="button">
    <asp:Button ID="Button1" runat="server" Text="Submit"/>
    <asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click"/>
    </div>

</asp:Content>
