<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeletePersonalInfo.aspx.cs" Inherits="UIUASWebsite.Account.DeletePersonalInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Delete Personal Info Confirmation<br />
        <br />
        <table style="width: 320px">
            <tr>
                <td>Id</td>
                <td><asp:Label ID="lblId" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Name</td>
                <td><asp:Label ID="lblName" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Program</td>
                <td><asp:Label ID="lblDept" runat="server" Font-Bold="True" Text=""></asp:Label></td>
            </tr>
        </table>
    
    </div>
        <br />
        Are you sure you want to delete this Personal Information record: &nbsp; &nbsp;
        <asp:Button ID="btnYES" runat="server" Text="YES" OnClick="btnYES_Click" />
        &nbsp; &nbsp;
        <asp:Button ID="btnNO" runat="server" Text="NO" OnClick="btnNO_Click" /><br />
        <br />
        &nbsp;&nbsp;
    </form>
</body>
</html>
