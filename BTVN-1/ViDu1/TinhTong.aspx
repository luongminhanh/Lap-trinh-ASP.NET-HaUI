<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhTong.aspx.cs" Inherits="ViDu1.TinhTong" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" cellpađing="0" cellspacing="0">
                <tr>
                    <td style="width:40%">
                        <asp:Label ID="label1" runat="server" text="Nhập số a: " Width="100px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSoA" runat="server" width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:40%">
                        <asp:Label ID="label2" runat="server" text="Nhập số b: " Width="100px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSoB" runat="server" width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:40%">
                        <asp:Label ID="label3" runat="server" text="Nhập số c: " Width="100px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSoC" runat="server" width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                         <asp:Button ID="btnTinh" runat="server" Text="Tính tổng" Width="100px" OnClick="btnTinh_Click" />       
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
