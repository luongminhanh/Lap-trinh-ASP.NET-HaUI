<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListBox_Example.aspx.cs" Inherits="ViDu1.ListBox_Example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" cellpadding="0" cellspacing="0">
                <tr>
                    <td style="width:40%">
                        <asp:Label ID="label1" runat="server" Text="Khu du lịch"></asp:Label>
                    </td>
                    <td>
                        <asp:ListBox ID="lstKhu_dl" SelectionMode="Multiple" Rows="4" runat="server" Width="250"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnChon" runat="server" text="Chọn địa điểm" onclick="btnChon_click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lbDia_Diem" runat="server" Text="Dia diem"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
