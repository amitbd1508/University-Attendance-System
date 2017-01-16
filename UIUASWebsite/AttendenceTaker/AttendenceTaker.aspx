<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AttendenceTaker.aspx.cs" Inherits="UIUASWebsite.AttendenceTaker.AttendenceTaker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Attendence Panel</title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div >
        
        <h1>Attendance Dashboard</h1>
        <div>
             Sreial No. &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student ID
        </div>
        <div>
            <asp:ListView runat="server" ID="ListView1">
    <LayoutTemplate>
        <table runat="server" id="table1">
            <tr runat="server" id="itemPlaceholder">
            </tr>
        </table>
    </LayoutTemplate>
                
    <ItemTemplate>
        <tr id="Tr1" runat="server">
            <td id="Td1" runat="server">
                <asp:Label ID="Index" runat="server" Text='<%#Eval("Index") %>' />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td id="Td2" runat="server">
                <asp:Label ID="StudentID" runat="server" Text='<%#Eval("StudentID") %>' />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td id="Td3" runat="server">
                <asp:CheckBox ID="Checkbox"  runat="server" />
            </td>
        </tr>
    </ItemTemplate>
</asp:ListView>
<asp:Button ID="btnGetChecked" runat="server" Text="Get Checked Items" OnClick="GetChecked" />
        </div>
    </div>
    </form>
</body>
</html>
