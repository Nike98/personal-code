<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Validation_Summary.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 70%; align-self: center; align-content: center; border-style: none; border-spacing: 1em">

            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Enter your Name : "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txbName" runat="server"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="NameVaidator" runat="server" Style="color: red"
                        ErrorMessage="Name is Mandatory" ControlToValidate="txbName">*</asp:RequiredFieldValidator>
                </td>

            </tr>
            <%-- End of Row for Name --%>

            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txbPassword" runat="server" TextMode="Password"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="PasswordValidator" runat="server" Style="color: red"
                        ErrorMessage="Password Required" ControlToValidate="txbPassword">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <%-- End of Row for Password Field --%>

            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Confirm Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txbConfPassword" runat="server" TextMode="Password"></asp:TextBox>

                    <asp:CompareValidator ID="ConfPasswordValidator" runat="server" Style="color: red"
                        ErrorMessage="Passwords do not match" ControlToCompare="txbPassword"
                        ControlToValidate="txbConfPassword" Display="Dynamic">*</asp:CompareValidator>
                </td>
            </tr>
            <%-- End of Row for Confirm Password Field --%>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Enter your Age"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txbAge" runat="server"></asp:TextBox>

                    <asp:RangeValidator ID="AgeRangeValidator" runat="server" Style="color: red"
                        ErrorMessage="Age value out of Bounds" ControlToValidate="txbAge"
                        MinimumValue="18" MaximumValue="100" Type="Integer">*</asp:RangeValidator>
                </td>
            </tr>
            <%-- End of Row for Age --%>
        </table>

        <br />
        <br />

        <%-- Button Control --%>
        <div>
            <asp:Button ID="btnValidate" runat="server" Style="margin-left: 200px" Text="Submit" />
        </div>

        <br />
        <br />

        <asp:ValidationSummary ID="MainSummary" runat="server" style="color: red;"/>
    </form>
</body>
</html>
