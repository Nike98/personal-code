<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SquareSite.aspx.cs" Inherits="Rectangle_Square_Triangle_Shape_Area_OOP.SquareSite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"> 
        <div align="center">
            <span style="font-weight:bold;">Enter the Side of the Square</span>
            <asp:TextBox ID="txbSquareSide" runat="server" TextMode="Number" 
                style="margin-left:50px; margin-top:100px;" ></asp:TextBox>
            <asp:Button ID="btnCalc" runat="server" Text="Calculate" style="margin-left:30px;" OnClick="btnCalc_Click" />
            <asp:Button ID="btnBack" runat="server" Text="Go Back" style="margin-left:30px;" OnClick="btnBack_Click" />
            <br /><br />
            <asp:Label ID="lblAnswer" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
