<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Validation_Controls_Example.Default" %>

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
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="NameVaidator" runat="server" style="color: red" 
                        ErrorMessage="Name is Mandatory" ControlToValidate="txbName"></asp:RequiredFieldValidator>
                </td>
            </tr> <%-- End of Row for Name --%>

            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txbPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                     <asp:RequiredFieldValidator ID="PasswordValidator" runat="server" style="color: red" 
                         ErrorMessage="Password Required" ControlToValidate="txbPassword"></asp:RequiredFieldValidator>
                </td>
            </tr> <%-- End of Row for Password Field --%>

            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Confirm Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txbConfPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="ConfPasswordValidator" runat="server" style="color: red" 
                        ErrorMessage="Passwords do not match" ControlToCompare="txbPassword" 
                        ControlToValidate="txbConfPassword" Display="Dynamic"></asp:CompareValidator>
                </td>
            </tr> <%-- End of Row for Confirm Password Field --%>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Enter your Age"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txbAge" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RangeValidator ID="AgeRangeValidator" runat="server" style="color: red" 
                        ErrorMessage="Age value out of Bounds" ControlToValidate="txbAge" 
                        MinimumValue="18" MaximumValue="100" Type="Integer"></asp:RangeValidator>
                </td>
            </tr> <%-- End of Row for Age --%>

            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Font-Bold="true" Text="Enter your E-mail"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txbEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="EmailValidator" runat="server" style="color: red"
                        ErrorMessage="Wrong E-mail syntax" ControlToValidate="txbEmail" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <%--
                        Don't get confused with the above value given
                        for as VaidationExpression. This is a common expression 
                        provided to check E-mail syntax only.

                        No E-mail Verificattion is done here beacause
                        that can only be done the mailing servers.
                    --%>
                </td>
            </tr> <%-- End of Row for E-mail --%>

        </table>

        <br /><br />

        <%-- Button Control --%>
        <div>
            <asp:Button ID="btnValidate" runat="server" style="margin-left: 200px" Text="Submit"/>
        </div>

    </form> 
</body>
</html>
