<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ADOdn.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="getdatabtn" runat="server" OnClick="getdatabtn_Click" Text="Get Data" />
        <asp:GridView ID="gvEmp" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
