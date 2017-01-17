<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="UIUASWebsite.Account.UserList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       

            <h3>
                List of User Information</h3>
            <br />
            <asp:GridView ID="gvPersonalInfo" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="False"
                AutoGenerateEditButton="True" OnRowCancelingEdit="gvPersonalInfo_RowCancelingEdit"
                OnRowEditing="gvPersonalInfo_RowEditing" OnRowUpdating="gvPersonalInfo_RowUpdating" BorderColor="Silver"
                BorderStyle="Solid" BorderWidth="1px">
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#EFF3FB" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <AlternatingRowStyle BackColor="White" />
                 <Columns>
                <asp:TemplateField HeaderText="Id">
                    <EditItemTemplate>
                        <asp:Label ID="txtId" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblId" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("name") %>' Width="100px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Department">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDepartment" runat="server" Text='<%# Bind("department") %>' Width="100px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblDepartment" runat="server" Text='<%# Bind("department") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEmail" runat="server" Text='<%# Bind("email") %>' Width="100px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblEmail" runat="server" Text='<%# Bind("email") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Password">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPassword" runat="server" Text='<%# Bind("password") %>' Width="100px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPassword" runat="server" Text='<%# Bind("password") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Designation">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDesignation" runat="server" Text='<%# Bind("designation") %>' Width="100px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblDesignation" runat="server" Text='<%# Bind("designation") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UniversityID">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtuniversity_id" runat="server" Text='<%# Bind("university_id") %>' Width="100px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbluniversity_id" runat="server" Text='<%# Bind("university_id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                
                
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="~/Account/DeletePersonalInfo.aspx?Id={0}" Text="Delete" />
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="/UpdatePersonalInformation.aspx?Id={0}" Text="Update" />
            </Columns>
                <EmptyDataTemplate>
                    <b>No Data Found !</b>
                </EmptyDataTemplate>
            </asp:GridView>
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Button ID="btnCreate" runat="server" Text="Create A New User" OnClick="btnCreate_Click" />
        <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
