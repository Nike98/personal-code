<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="File_Upload_Control.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FileUpload Control Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br /><br /><br />

            <span>Upload Document/Text File only: </span>
            <asp:FileUpload ID="FileUploadControl1" runat="server" style="margin-left: 50px;"/>

            <br /><br />

            <asp:Button ID="btnUpload" runat="server" Text="Upload" onclick="btnUpload_Click" style="margin-left: 100px;"/>

            <br /><br /><br /><br />
            
            <asp:TextBox ID="txbContent" runat="server" TextMode="MultiLine" Rows="4" Columns="40"></asp:TextBox>

            <br /><br /><br />

            <asp:Label ID="lblStatus" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
