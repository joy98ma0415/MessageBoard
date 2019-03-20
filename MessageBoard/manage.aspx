<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage.aspx.cs" Inherits="MessageBoard.manage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .style2
        {
            width: 302px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <table class="style1">
            <tr>
                <td colspan="2" style="text-align: center">
                    用戶管理</td>
            </tr>
            <tr>
                <td class="style2" style="text-align: right">
                    用戶名：</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" style="text-align: right">
                    新密碼：</td>
                <td>
                    <asp:TextBox ID="txtNewPwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" style="text-align: right">
                    確認密碼：</td>
                <td>
                    <asp:TextBox ID="txtPwd2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" style="text-align: right">
                    <asp:Button ID="btnDel" runat="server" onclick="btnDel_Click" Text="執行刪除" />
                </td>
                <td>
                    <asp:RadioButtonList ID="rblType" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True" Value="1">僅刪除用戶</asp:ListItem>
                        <asp:ListItem Value="2">刪除用戶和留言</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="style2" style="text-align: right">
                    <asp:Button ID="btnModifyPwd" runat="server" onclick="btnModifyPwd_Click"
                        Text="修改密碼" />
                </td>
                <td>
                    <asp:Button ID="btnReturn" runat="server" onclick="btnReturn_Click"
                        Text="返回主頁" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>