<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="EnterNameAndDisplay.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>First ASP.NET Page</title>
</head>
<body>
    <form id="form1" runat="server">

        <span>
            <asp:Label ID="lblWelcome" runat="server" Text="Welcome to this Page !"></asp:Label>
        </span>

        <br /> <br />

        <div>

            <asp:Label ID="Label1" runat="server" Text="Enter your Name"></asp:Label>
            <asp:TextBox ID="txbName" runat="server" style="margin-left: 25px" Width="140px"></asp:TextBox>

            <asp:Button ID="btnClick" runat="server" style="margin-left: 20px" Text="Click Me" OnClick="btnClick_Click" />

        </div>

        <br /> <br />

        <span>
            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
        </span>

        <br /> <br />

        <span>
            <asp:HyperLink ID="hplink1" runat="server"></asp:HyperLink>
        </span>
        
    </form>
</body>
</html>
