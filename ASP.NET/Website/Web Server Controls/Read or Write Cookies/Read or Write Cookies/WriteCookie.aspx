<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WriteCookie.aspx.cs" Inherits="Read_or_Write_Cookies.WriteCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br /><br />
        <table style="width:400px; height:100px;">
            <%-- Cookie Name Section --%>
            <tr>
                <td>
                    <span style="font-weight: bold; align-content: center;">Cookie Name: </span>
                </td>
                <td>
                    <asp:TextBox ID="txbName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <%-- Cookie Value Section --%>
            <tr>
                <td>
                    <span style="font-weight: bold; align-content: center;">Cookie Value: </span>
                </td>
                <td>
                    <asp:TextBox ID="txbValue" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br /><br />
        <div>
            <asp:Button ID="btnWrite" runat="server" Text="Write Cookie" OnClick="btnWrite_Click" style="margin-left: 100px;"/>
        </div>
        <br /><br />
        <div>
            <asp:HyperLink ID="ReadLink" runat="server" NavigateUrl="~/ReadCookie.aspx">
                Read the Cookie
            </asp:HyperLink>
        </div>
    </form>
</body>
</html>
