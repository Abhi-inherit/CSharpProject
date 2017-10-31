<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/StudentRegMain.Master" AutoEventWireup="true" CodeBehind="District.aspx.cs" Inherits="ThreeTireWorkshop.Admin.District" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Admin/AdminStyle/Style.css" rel="stylesheet" />
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login">
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text="Enter District:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="a"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ValidationGroup="a" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br /><br />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="BtnDistrictClick" ValidationGroup="a" />
        <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="Btn_Edit_Click"/><br />
        <asp:Label ID="lblConfirm" runat="server" Text="Are you sure to delete this entry:"></asp:Label>
        <asp:Button ID="btnDelYes" runat="server" Text="Yes" OnClick="btnDelYes_Click" />
        <asp:Button ID="btnDelNo" runat="server" Text="No" OnClick="btnDelNo_Click" />
        <br />&nbsp
        <asp:Label ID="Label2" runat="server" Text="" ForeColor="#CC0000"></asp:Label>
        <asp:HiddenField ID="HiddenField1" Value="-1" runat="server" />
    </div>
    
    <div class="districtEdit">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Width="75px">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" InsertVisible="False" Visible="false" SortExpression="id"></asp:BoundField>
                <asp:BoundField DataField="district_name" HeaderText="District" SortExpression="district_name"></asp:BoundField>
                <asp:TemplateField HeaderText="Edit">

                   
                         <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton1" runat="server" ImageUrl="~/Image/editimage.jpg" Height="20px" Width="20px" OnClick="Edit_Click1"/>
                    </div>
                        </ItemTemplate>
                    

                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                  <div>
                         <asp:ImageButton ImageAlign="AbsMiddle" ID="ImageButton2" runat="server" ImageUrl="~/Image/deleteicon.jpg"  Width="20px" Height="20px" OnClick="Delete_Click"/>
                 </div>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:Student_RegisterationConnectionString2 %>' SelectCommand="SELECT [id], [district_name] FROM [District] WHERE ([district_name] <> @district_name)">
            <SelectParameters>
                <asp:Parameter DefaultValue="--Select--" Name="district_name" Type="String"></asp:Parameter>
            </SelectParameters>
        </asp:SqlDataSource>
    </div>

</asp:Content>
