
<%-- 
    
            Write code to accept user id and password from the user. 
          UserId is stored in a cookie if correct Login and open a new 
          web application to display Welcom message with accepted user 
                   id and error message for incorrect login.
    
    --%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cookie.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:50%; height:30%; border-spacing:1em;">
                <tr>
                    <td>
                        <span style="font-weight:bold;">User ID</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txbUid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span style="font-weight:bold;">Password</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txbPass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <br /><br />
        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" style="margin-left:100px;" />
        </div>
        <br />
        <div>
            <asp:Label ID="lblStatus" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
