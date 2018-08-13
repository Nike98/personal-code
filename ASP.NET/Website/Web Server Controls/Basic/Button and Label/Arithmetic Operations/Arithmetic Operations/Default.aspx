<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Arithmetic_Operations.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text="Enter the First Number: " Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txb1" runat="server" style="margin-left: 100px"></asp:TextBox>

            <br /><br />

            <asp:Label ID="Label2" runat="server" Text="Enter the Second Number: " Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txb2" runat="server" style="margin-left: 82px"></asp:TextBox>
        </div>

        <br /><br />

        <span>
            <asp:Button ID="btnCalc" runat="server" Text="Calculate" style="margin-left: 150px" OnClick="btnCalc_Click"/>
        </span>

        <br /><br />

        <div>
            <asp:Label ID="lblAdd" runat="server" style="font-weight: bold; color: green"></asp:Label>
            <br />
            <asp:Label ID="lblSub" runat="server" style="font-weight: bold; color: green"></asp:Label>
            <br />
            <asp:Label ID="lblMul" runat="server" style="font-weight: bold; color: green"></asp:Label>
            <br />
            <asp:Label ID="lblDiv" runat="server" style="font-weight: bold; color: green"></asp:Label>
            <br />
            <asp:Label ID="lblMod" runat="server" style="font-weight: bold; color: green"></asp:Label>
        </div>
    </form>
</body>
</html>
