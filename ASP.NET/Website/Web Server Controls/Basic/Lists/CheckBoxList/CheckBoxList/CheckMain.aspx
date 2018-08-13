<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckMain.aspx.cs" Inherits="CheckBoxList.CheckMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 1000px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Options to be Selected:" style="margin-left: 100px"></asp:Label>

        </div>
        <br />
        <div>
            <asp:CheckBoxList ID="chboxls" runat="server" Width="130px" style="margin-left: 100px" BorderStyle="Solid" BorderColor="Silver">
                <asp:ListItem>C</asp:ListItem>
                <asp:ListItem>C++</asp:ListItem>
                <asp:ListItem>Java</asp:ListItem>
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>Python</asp:ListItem>
                <asp:ListItem>Perl</asp:ListItem>
                <asp:ListItem>FORTRAN</asp:ListItem>
                <asp:ListItem>COBOL</asp:ListItem>
                <asp:ListItem>F#</asp:ListItem>
                <asp:ListItem>J#</asp:ListItem>
                <asp:ListItem>AWS</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <br /><br />
        <div>

            <asp:Button ID="btnClick" runat="server" Text="Show" style="margin-left: 150px" OnClick="btnClick_Click" />

        </div>
        <br /><br />
        <div>
            <span>
                <asp:Label ID="Label2" runat="server" Text="You have Selected:" style="margin-left: 100px"></asp:Label>
                <br /><br />
            </span>

            <asp:Label ID="lblDisplay" runat="server" Width="130px" style="margin-left: 100px" BorderStyle="Solid" BorderColor="Silver"></asp:Label>
        </div>
    </form>
</body>
</html>
