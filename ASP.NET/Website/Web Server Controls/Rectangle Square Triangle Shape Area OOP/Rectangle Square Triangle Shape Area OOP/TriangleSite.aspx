<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TriangleSite.aspx.cs" Inherits="Rectangle_Square_Triangle_Shape_Area_OOP.TriangleSite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <span style="font-weight:bold;">Enter the Breadth of the Triangle</span>
            <asp:TextBox ID="txbBreadth" runat="server" TextMode="Number"
                style="margin-left:30px; margin-top:100px;" placeholder="Breadth" ></asp:TextBox>
            <br /><br />
            <span style="font-weight:bold;">Enter the Height of the Triangle</span>
            <asp:TextBox ID="txbHeight" runat="server" TextMode="Number"
                style="margin-left:30px;" placeholder="Height" ></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCalc" runat="server" Text="Calculate" style="margin-left:30px;" OnClick="btnCalc_Click" />
            <asp:Button ID="btnBack" runat="server" Text="Go Back" style="margin-left:30px;" OnClick="btnBack_Click" />
            <br /><br />
            <asp:Label ID="lblAnswer" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
