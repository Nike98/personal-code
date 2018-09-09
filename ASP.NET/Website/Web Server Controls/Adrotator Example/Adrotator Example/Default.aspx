<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Adrotator_Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator1" runat ="server" AdvertisementFile="~/Advert.xml"
                style="height: 152px; width: 152px;" OnAdCreated="AdRotator_Ad" />
        </div>
    </form>
</body>
</html>
