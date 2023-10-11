<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Request.aspx.cs" Inherits="ViDu1.Request" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang gửi</title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
            Username: <asp:TextBox runat="server" ID="txtUsername"></asp:TextBox><br />
            Password: <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox><br />
            <asp:Button runat="server" ID="btnSubmit" Text="Submit" PostBackUrl="~/Request2.aspx" />
        </div>
    </form>
</body>
</html>
