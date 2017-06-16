<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ADOsample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="getdata" runat="server" OnClick="getdata_Click" Text="Get details" />
        </p>
        <asp:GridView ID="gvEmp" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
