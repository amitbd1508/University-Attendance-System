<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDashBoard.aspx.cs" Inherits="UIUASWebsite.Dashboard.StudentDashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Student Dashboard</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div>
        <h1>
            Welcome &nbsp;&nbsp;
            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
        </h1>
        <br />
        <br />
        <div>
            Name : <asp:Label ID="name" runat="server" Text="Label"></asp:Label> <br />
            Student ID : <asp:Label ID="id" runat="server" Text="Label"></asp:Label><br />
            Type : <asp:Label ID="accountType" runat="server" Text="Label"></asp:Label><br />
            Department : <asp:Label ID="department" runat="server" Text="Label"></asp:Label><br />
            Email : <asp:Label ID="email" runat="server" Text="Label"></asp:Label><br />

        </div>
        <br />
        <br />
        <div>
            <h2>Your Attendence Information</h2>
        </div>
        <br />
        <br />
        <div>
            <asp:Button ID="btnGenarateReport" runat="server" Text="Genarate Report" OnClick="btnGenarateReport_Click" />
        </div>
        <br />

        <div>

            Serial &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Course Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Course Code&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Trimister&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Attendence
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
            <td id="Td3" runat="server">
                <asp:Label ID="Index" runat="server" Text='<%#Eval("Index") %>' />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td id="Td1" runat="server">
                <asp:Label ID="CourseName" runat="server" Text='<%#Eval("CourseName") %>' />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td id="Td2" runat="server">
                <asp:Label ID="CourseCode" runat="server" Text='<%#Eval("CourseCode") %>' />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td id="Td5" runat="server">
                <asp:Label ID="trimister" runat="server" Text='<%#Eval("trimister") %>' />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td id="Td4" runat="server">
                <asp:Label ID="attend" runat="server" Text='<%#Eval("attend") %>' />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            
        </tr>
    </ItemTemplate>
</asp:ListView>

        </div>

    
        <div>

        </div>
    </div>
    </form>
</body>
</html>
