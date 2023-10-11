<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TienDien.aspx.cs" Inherits="ViDu1.TienDien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
            <table border="2" cellpadding="1" cellspacing="1">
                <tr>
                    <td style="width: 40%">
                        <asp:Label runat="server" Text="Chỉ số điện cũ"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCu" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 40%">
                        <asp:Label runat="server" Text="Chỉ số điện mới"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMoi" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnTinh" Text="Tính tiền" runat="server" PostBackUrl="~/TienDien2.aspx"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
