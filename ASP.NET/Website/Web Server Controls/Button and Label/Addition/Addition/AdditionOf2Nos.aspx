<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdditionOf2Nos.aspx.cs" Inherits="Addition.AdditionOf2Nos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Addition of 2 Numbers</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter the 1st Number"></asp:Label>
            <asp:TextBox ID="txb1" runat="server" style="margin-left: 30px"></asp:TextBox>
        </div>

        <br /> <br />

        <div>
            <asp:Label ID="Label2" runat="server" Text="Enter the 2nd Number"></asp:Label>
            <asp:TextBox ID="txb2" runat="server" style="margin-left: 25px"></asp:TextBox>
        </div>

        <br /> <br />

        <div>
            <asp:Button ID ="btnClick" runat="server" Text="ADD" Width="90px" style="margin-left: 170px" OnClick="btnClick_Click"/>
        </div>

        <br /> <br />

        <span>
            <asp:Label ID="Label3" runat="server" Text="The Addition : "></asp:Label>
        </span>

        <span>
            <asp:Label ID="lblAns" runat="server"></asp:Label>
        </span>
        
    </form>
</body>
</html>
