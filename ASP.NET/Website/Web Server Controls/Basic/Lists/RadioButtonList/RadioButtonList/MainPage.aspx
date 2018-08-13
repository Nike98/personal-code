<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="RadioButtonList.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span>
                <asp:Label ID="Label1" runat="server" Text="Select at least One so that the Default one does not get Displayed" style="margin-left: 50px"></asp:Label>
                
                <br /> <br />
            <asp:RadioButtonList ID="RdBtnLs1" runat="server" style="margin-left: 100px" BorderStyle="Solid" BorderColor="Silver">
                <asp:ListItem>Mouse</asp:ListItem>
                <asp:ListItem>Keyboard</asp:ListItem>
                <asp:ListItem>Monitor</asp:ListItem>
                <asp:ListItem>Headphones</asp:ListItem>
                <asp:ListItem Selected="True">Other Pointing Device</asp:ListItem>
            </asp:RadioButtonList>
            </span>
        </div>
        <br /><br />
        <div>

            <asp:Button ID="btnSelection" runat="server" Text="Show" style="margin-left: 150px" OnClick="btnSelection_Click" />

        </div>
        <br /><br />
        <div>
            <asp:Label ID="lblDisplay" runat="server" Text="" style="margin-left: 100px" ></asp:Label>
        </div>
    </form>
</body>
</html>
