<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="recover.aspx.cs" Inherits="MessageBoard.recover" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 180px;
            text-align: right;
        }
        .auto-style1 {
            margin-top: 29px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <table class="style1">
            <tr>
                <td class="style2">
                    用戶名：</td>
                <td>
                    <asp:TextBox ID="txtUsName" runat="server" Width="176px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    提示問題：</td>
                <td>
                    <asp:TextBox ID="txtQusetion" runat="server" Width="459px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    答案：</td>
                <td>
                    <asp:TextBox ID="txtAnswer" runat="server" Width="457px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="提交" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" />
                </td>
            </tr>
        </table>
    </div>
    <asp:Panel ID="Panel1" runat="server" Visible="False" CssClass="auto-style1">
        新密碼：<asp:TextBox ID="txtNewPwd" runat="server" Width="158px"
            TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 確認密碼：<asp:TextBox ID="txtNewPwd2" runat="server"
            TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnModifyPwd" runat="server" Text="確認修改"
            onclick="btnModifyPwd_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" Text="重填" OnClick="btnClear_Click" />
    </asp:Panel>
    </form>
</body>
</html>