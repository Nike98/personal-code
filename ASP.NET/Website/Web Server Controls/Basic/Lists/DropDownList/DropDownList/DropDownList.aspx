6<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownList.aspx.cs" Inherits="DropDownList.DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DropDownList ID="ddlCity" runat="server" style="margin-left: 100px" Width="120px">
                <asp:ListItem>Mumbai</asp:ListItem>
                <asp:ListItem>Pune</asp:ListItem>
                <asp:ListItem>Bangalore</asp:ListItem>
                <asp:ListItem>Chennai</asp:ListItem>
                <asp:ListItem>New Delhi</asp:ListItem>
            </asp:DropDownList>

            &emsp;&emsp;&emsp;

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

        </div>

        <br /> <br />

        <span>
            <asp:Label runat="server" ID="lblDisplay"></asp:Label>
        </span>
    </form>
</body>
</html>
