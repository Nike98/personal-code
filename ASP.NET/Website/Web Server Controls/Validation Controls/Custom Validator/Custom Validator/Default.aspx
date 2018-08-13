<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Custom_Validator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text="User ID"></asp:Label>
            <asp:TextBox ID="txbUid" runat="server" style="margin-left: 70px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="UserIdFieldValidator" runat="server" style="margin-left: 100px; color: red;"
                ControlToValidate="txbUid" ErrorMessage="User ID is Mandatory"></asp:RequiredFieldValidator>
            <br />
            <asp:CustomValidator ID="UidCustomValidate" runat="server" style="margin-left: 350px; color: red;"
                OnServerValidate="UserIdCustomValidate" ControlToValidate="txbUid"
                ErrorMessage="User ID should have atleast a capital, small and digit and should be greater than 5 and less than 26 letters" SetFocusOnError="true"></asp:CustomValidator>
        </div>

        <br /><br />

        <div>
            <asp:Button ID="btnValidate" runat="server" Text="Submit" style="margin-left: 200px" OnClick="btnValidate_Click"/>
        </div>
    </form>
</body>
</html>
