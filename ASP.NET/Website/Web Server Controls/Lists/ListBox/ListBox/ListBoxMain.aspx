
<%-- # 
     ##
     ## This is an Example of the ListBox Web Control in ASP.NET
     ## It demonstrates the following functionality of the control:
     ## 1. Add
     ## 2. Remove
     ## 3. Count total number of Items
     ## 4. Retrieve the Index of the Selected Value
     ## 5. Display the Selected Text from the List
     ## 6. Clear the List
     ##
     # --%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListBoxMain.aspx.cs" Inherits="ListBox.ListBoxMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <br />

        <div>

            <asp:ListBox ID="lsbx1" runat="server" Height="170px" style="margin-left: 500px" Width="120px">
                <asp:ListItem>Value 1</asp:ListItem>
                <asp:ListItem>Value 2</asp:ListItem>
                <asp:ListItem>Value 3</asp:ListItem>
                <asp:ListItem>Value 4</asp:ListItem>
                <asp:ListItem>Value 5</asp:ListItem>
            </asp:ListBox>

        </div>

        <br /> <br />

        <span>

            <asp:Label ID="lblDisplay" runat="server" style="margin-left: 450px"></asp:Label>

        </span>

        <br /> <br /> <br />

        <span>

            <asp:TextBox ID="txbAdd" runat="server" style="margin-left: 500px" Width="113px"></asp:TextBox>

        </span>

        <br /> <br />

        <span>

            <asp:Button ID="btnAdd" runat="server" style="margin-left: 520px; margin-top: 0px" Width="80px" Text="Add" OnClick="btnAdd_Click" />

        </span>

        <br /> <br /> <br />

        <div>

            <asp:Button ID="btnRemove" runat="server" style="margin-left: 520px" Text="Remove" Width="80px" OnClick="btnRemove_Click" />
            <br /> <br />
            <asp:Button ID="btnCount" runat="server" style="margin-left: 520px" Text="Count" Width="80px" OnClick="btnCount_Click" />
            <br /> <br />
            <asp:Button ID="btnIndex" runat="server" style="margin-left: 520px" Text="Index" Width="80px" OnClick="btnIndex_Click" />
            <br /> <br />
            <asp:Button ID="btnSelText" runat="server" style="margin-left: 510px" Text="Selected Text" Width="100px" OnClick="btnSelText_Click" />
            <br /> <br />
            <asp:Button ID="btnClear" runat="server" style="margin-left: 520px" Text="Clear" Width="80px" OnClick="btnClear_Click" />

        </div>
    </form>
</body>
</html>
