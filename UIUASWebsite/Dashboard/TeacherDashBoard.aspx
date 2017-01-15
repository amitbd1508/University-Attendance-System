<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherDashBoard.aspx.cs" Inherits="UIUASWebsite.Dashboard.DashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 124px;
        }
        .auto-style2 {
            width: 357px;
        }
        .auto-style3 {
            width: 186px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div >
        <div>
            <h1>Chose Course From the List</h1>
        </div>
        <br />
        <div>
            
           <div>
           </div>
            <br />
            
            <table style="width:100%;">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">1</td>
                    <td class="auto-style2">
                        <asp:Label ID="lblSPL" runat="server" Text="Structure Programming Language" Font-Size="Large" Font-Underline="True"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btnSPL" runat="server" Text="Take Attendance" OnClick="btnSPL_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">2</td>
                    <td class="auto-style2">
                        <asp:Label ID="lblSoftWare" runat="server" Text="Software Engineering" Font-Size="Large" Font-Underline="True"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btnSoftware" runat="server" Text="Take Attendance" OnClick="btnSoftware_Click"  />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            
             
        </div>
    
    </div>
    </form>
</body>
</html>
