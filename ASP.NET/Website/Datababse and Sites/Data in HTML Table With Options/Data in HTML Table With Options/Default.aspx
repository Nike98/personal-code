
<%-- 
    
                  Create a Web Application with record details of 
            Customer Order(name, contact no, product no, order date, amount). 
                Now display the data in HTML table on Web Page by the 
                following condition:
                    1. User can search Customer list of Specific Date
                    2. User can search Customer list between two Dates
                    3. User can search the count of Orders on specific date by giving the Product no
    
    --%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Data_in_HTML_Table_With_Options.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:55%; height:30%; border-spacing:1em;">
                <%-- Block for searching by Specific Date --%>
                <tr>
                    <td>
                        <span style="font-weight:bold;">
                            Search by Specific Date
                        </span>
                    </td>
                    <td>
                        <asp:TextBox ID="txbSpecificDate" runat="server"></asp:TextBox>
                    </td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSpecificDate" runat="server" Text="Search" OnClick="btnSpecificDate_Click" />
                    </td>
                </tr>
                <%-- Block to search by Date Range --%>
                <tr>
                    <td>
                        <span style="font-weight:bold;">
                            Search by Date Range
                        </span>
                    </td>
                    <td>
                        <asp:TextBox ID="txbStartDate" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txbEndDate" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnDateRange" runat="server" Text="Search" OnClick="btnDateRange_Click" />
                    </td>
                </tr>
                <%-- Block to search count Orders on a Specific Date, given the Product no --%>
                <tr>
                    <td>
                        <span style="font-weight:bold;">
                            Search Orders by Product No
                        </span>
                    </td>
                    <td>
                        <asp:TextBox ID="txbProductNo" runat="server"></asp:TextBox>
                    </td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnProdNo" runat="server" Text="Search" OnClick="btnProdNo_Click" />
                    </td>
                </tr>
            </table>
            <br /><br />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
