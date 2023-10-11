<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TienLuong2.aspx.cs" Inherits="ViDu1.TienLuong2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" cellspacing="0" cellpadding="0">
                 <tr>
                    <td style="width: 40%">
                        <asp:Label runat="server" Text="Mã NV: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMa" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 40%">
                        <asp:Label runat="server" Text="Có ngày công: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNgayCong" runat="server"></asp:TextBox>
                    </td>
                      <tr>
                <tr>
                    <td style="width: 40%">
                        <asp:Label runat="server" Text="Tiền được lĩnh: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTienLinh" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 
            </table>
        </div>
    </form>
</body>
</html>
