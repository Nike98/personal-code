
<%-- 
    
    Create a web app for Login purpose, after a successful login
    user must be redirected to a new web page having his username as
    "You are logged in as<username>". (Using Cookies)
    
    --%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Set1Question1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top: 50px;">
            <span style="font-weight: bold;">Name: </span>
            <asp:TextBox ID="txbName" runat="server" style="margin-left: 50px"></asp:TextBox>
            <br /><br />
            <span style="font-weight: bold;">Password: </span>
            <asp:TextBox ID="txbPassword" runat="server" TextMode="Password" style="margin-left: 50px"></asp:TextBox>
        </div>
        <br /><br /> 
        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" style="margin-left: 150px;" OnClick="btnLogin_Click" />
        </div>
        <br /><br />
        <div>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
