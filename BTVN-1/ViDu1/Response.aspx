<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Response.aspx.cs" Inherits="ViDu1.Response" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang gửi</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User name: <asp:TextBox runat="server" ID="txtUserName" ></asp:TextBox><br />
            Password: <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox><br />
            <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
