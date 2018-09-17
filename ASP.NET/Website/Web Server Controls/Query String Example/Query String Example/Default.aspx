<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Query_String_Example.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Query String Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <br /><br /><br />
        <table style="width:500px; height:100px;">
            <%-- Username Section --%>
            <tr>
                <td>
                    <span style="font-weight:bold;">Username:</span>
                </td>
                <td>
                    <asp:TextBox ID="txbUname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <%-- Email Section --%>
            <tr>
                <td>
                    <span style="font-weight:bold;">Email:</span>
                </td>
                <td>
                    <asp:TextBox ID="txbEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>

        <br /><br /><br />

        <div>
            <asp:Button ID="btnSend" runat="server" Text="Send Data" OnClick="btnSend_Click" style="margin-left: 120px;"/>
        </div>
    </form>
</body>
</html>
