<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TienLuong.aspx.cs" Inherits="ViDu1.TienLuong" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="2" cellpadding="1" cellspacing="1">
                <tr>
                    <td style="width: 40%">
                        <asp:Label runat="server" Text="Mã NV"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMa" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 40%">
                        <asp:Label runat="server" Text="Bậc lương"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtBacLuong" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td style="width: 40%">
                        <asp:Label runat="server" Text="Ngày công"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNgayCong" runat="server"></asp:TextBox>
                    </td>
                      <tr>
                    <td style="width: 40%">
                        <asp:Label runat="server" Text="Chức vụ"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="dlChucVu" runat="server" AutoPostBack="false"></asp:DropDownList>
                    </td>
                </tr>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnTinh" Text="Tính tiền" runat="server" OnClick="btnTinh_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
