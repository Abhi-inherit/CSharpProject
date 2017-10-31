<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/StudentRegMain.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ThreeTireWorkshop.Admin.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Admin/AdminStyle/Style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login2">
        <asp:TextBox ID="TextBox4" runat="server" Visible="false"></asp:TextBox>
    <br />&nbsp
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="a"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ValidationGroup="a" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    <br /><br />&nbsp
        <asp:Label ID="Label2" runat="server" Text="E mail:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="49%" ValidationGroup="a"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ValidationGroup="a" ControlToValidate="TextBox2" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    <br /><br />&nbsp

        <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="42.5%" ValidationGroup="a"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ValidationGroup="a" ForeColor="#CC0000" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>

        <br /><br />&nbsp
        <asp:Label ID="Label3" runat="server" Text="Select course:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Width="35.5%">
            <asp:ListItem Text="--Select--" Value="1" />
            <asp:ListItem Text="MCA" Value="MCA" />
            <asp:ListItem Text="BSC" Value="BSC" />
            <asp:ListItem Text="BCA" Value="BSC" />
        </asp:DropDownList><asp:Label ID="Label7" runat="server" Text="" ForeColor="#CC0000"></asp:Label>
        <br /><br />&nbsp
        <asp:Label ID="Label6" runat="server" Text="District"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" Width="49%" DataSourceID="District_connection" DataTextField="district_name" DataValueField="id"></asp:DropDownList>
        <asp:SqlDataSource ID="District_connection" runat="server" ConnectionString="<%$ ConnectionStrings:Student_RegisterationConnectionString3 %>" SelectCommand="SELECT id, district_name FROM District">
        </asp:SqlDataSource>
        <asp:Label ID="Label8" runat="server" Text="" ForeColor="#CC0000"></asp:Label><br /><br />
        &nbsp
        <asp:Label ID="Label4" runat="server" Text="Gender:"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
           <asp:ListItem Selected="True">Male</asp:ListItem> 
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    &nbsp
        <br />
      <asp:Button ID="Button1" runat="server" Text="SiGn Up" ValidationGroup="a" OnClick="btnClick" />
        <asp:Button ID="BtnEdit" runat="server" Text="Edit" Visible="false" OnClick="BtnEdit_Click"/>

        <asp:Label ID="Label10" runat="server" Text="Are u sure u want to delete:" Visible="False" ForeColor="#CC0000"></asp:Label>
        <asp:Button ID="BtnYes" runat="server" Text="Yes" Visible="False" OnClick="BtnYes_Click" />
        <asp:Button ID="BtnNo" runat="server" Text="No" Visible="False" OnClick="BtnNo_Click" />

        <asp:HiddenField ID="HiddenField1" runat="server" Value="-1" /><br />
        <asp:Label ID="Label9" runat="server" Text="" ForeColor="#CC0000"></asp:Label>
</div>

    <div class="districtEdit">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="113px" Width="624px">
        <Columns>
            <asp:BoundField DataField="studentId" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="studentId" />
            <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
            <asp:BoundField DataField="eMail" HeaderText="E-Mail" SortExpression="eMail" />
            <asp:BoundField DataField="password" HeaderText="Password" SortExpression="password" />
            <asp:BoundField DataField="course" HeaderText="Course" SortExpression="course" />
            <asp:BoundField DataField="district" HeaderText="District" SortExpression="district" />
            <asp:BoundField DataField="gender" HeaderText="Gender" SortExpression="gender" />
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="28px" ImageUrl="~/Image/editimage.jpg"  Width="27px" OnClick="ImageButton1_Click" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="27px" ImageUrl="~/Image/deleteicon.jpg" OnClick="ImageButton2_Click" Width="28px" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Student_RegisterationConnectionString %>" SelectCommand="SELECT * FROM [StudentDetail]"></asp:SqlDataSource>

</asp:Content>
