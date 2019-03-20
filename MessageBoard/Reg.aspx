<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="MessageBoard.Reg" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        .style1
        {
            width: 109%;
        }
        .style2
        {
            width: 362px;
            text-align: right;
        }
        .style3
        {
            color: #FF3300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td colspan="2" style="text-align: center">
                用戶註冊訊息</td>
        </tr>
        <tr>
            <td class="style2" style="text-align: right">
                用户名：</td>
            <td style="color: #FF3300">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                *<asp:LinkButton ID="lbtCheck" runat="server" onclick="lbtCheck_Click">檢查用戶名</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style2">
                密碼：</td>
            <td>
                <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                <span class="style3">*</span></td>
        </tr>
        <tr>
            <td class="style2">
                確認密碼：</td>
            <td>
                <asp:TextBox ID="txtSecPwd" runat="server" TextMode="Password"></asp:TextBox>
                <span class="style3">*</span></td>
        </tr>
        <tr>
            <td class="style2">
                密碼提示問題：</td>
            <td>
                <asp:TextBox ID="txtQuestion" runat="server" Width="322px"></asp:TextBox>
                <span class="style3">*</span></td>
        </tr>
        <tr>
            <td class="style2">
                提示問題答案：</td>
            <td>
                <asp:TextBox ID="txtAnswer" runat="server" Width="320px"></asp:TextBox>
                <span class="style3">*</span></td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Button ID="btnSubMit" runat="server" onclick="btnSubMit_Click" Text="確認" />
            </td>
            <td>
                <asp:Button ID="btnReturn" runat="server" onclick="btnReturn_Click" Text="返回" />
            </td>
        </tr>
    </table>
    <div>
    </div>
    </form>
</body>
</html>