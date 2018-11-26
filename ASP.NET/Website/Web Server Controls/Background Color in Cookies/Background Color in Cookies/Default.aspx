<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Background_Color_in_Cookies.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="mainBody" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblName" runat="server" Text="Name" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txbName" runat="server" style="margin-left:30px;"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblColor" runat="server" Text="Color" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txbColor" runat="server" TextMode="Color" style="margin-left:30px;"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnClick" runat="server" Text="Click Me" OnClick="btnClick_Click" />
        </div>
    </form>
</body>
</html>
