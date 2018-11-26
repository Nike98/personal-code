<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DataBase_Example_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br /><br />
        <table style="height:200px; width:400px; align-content:center">
            <tr>
                <td>
                    <span style="font-weight:bold;">
                        Enter First Name:
                    </span>
                </td>
                <td>
                    <asp:TextBox ID="txbFName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <span style="font-weight:bold;">
                        Enter Last Name:
                    </span>
                </td>
                <td>
                    <asp:TextBox ID="txbLName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <span style="font-weight:bold;">
                        Enter Age:
                    </span>
                </td>
                <td>
                    <asp:TextBox ID="txbAge" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <span style="font-weight:bold;">
                        Enter Gender:
                    </span>
                </td>
                <td>
               <asp:DropDownList ID="ddlGender" runat="server">
                   <asp:ListItem Text="M" Value="M"></asp:ListItem>
                   <asp:ListItem Text="F" Value="F"></asp:ListItem>
               </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <span>Mobile</span>
                    <td>
                        <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <span>Email</span>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>

        <br /><br />

        <div>
             <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br />
            <asp:Label ID="lblStatus" runat="server" ></asp:Label>
        </div>
        <hr />
        <asp:GridView id="gvData" runat="server" Width="100%" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Mobile" HeaderText="Mobile" SortExpression="Mobile" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            </Columns>
            
        </asp:GridView>
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Constr %>" SelectCommand="SELECT * FROM [tblStudent]" DeleteCommand="DELETE FROM [tblStudent] WHERE [Id] = @Id" InsertCommand="INSERT INTO [tblStudent] ([FirstName], [LastName], [Gender], [Mobile], [Email]) VALUES (@FirstName, @LastName, @Gender, @Mobile, @Email)" UpdateCommand="UPDATE [tblStudent] SET [FirstName] = @FirstName, [LastName] = @LastName, [Gender] = @Gender, [Mobile] = @Mobile, [Email] = @Email WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="Gender" Type="String" />
                <asp:Parameter Name="Mobile" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="Gender" Type="String" />
                <asp:Parameter Name="Mobile" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
       
    </form>
</body>
</html>
