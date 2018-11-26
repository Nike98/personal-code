<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Rectangle_Square_Triangle_Shape_Area_OOP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center" style="margin-top:100px;">
            <asp:RadioButton ID="rdbtnSquare" runat="server" AutoPostBack="true" Font-Bold="true"
                Text="Square" OnCheckedChanged="rdbtnSquare_CheckedChanged" /> &emsp;
            <asp:RadioButton ID="rdbtnRectangle" runat="server" AutoPostBack="true" Font-Bold="true"
                Text="Rectangle" OnCheckedChanged="rdbtnRectangle_CheckedChanged" />&emsp;
            <asp:RadioButton ID="rdbtnTriangle" runat="server" AutoPostBack="true" Font-Bold="true"
                Text="Triangle" OnCheckedChanged="rdbtnTriangle_CheckedChanged" />&emsp;
        </div>
    </form>
</body>
</html>
