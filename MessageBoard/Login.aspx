<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MessageBoard.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            text-align: center;
        }
        .style3
        {
            width: 109px;
        }
        .style4
        {
            width: 148px;
            text-align: right;
        }
        .auto-style1 {
            width: 71px;
        }
        .auto-style2 {
            width: 173px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style2">
        用戶登入頁面
    </div>
    <div>

        <table align="center" class="style1">
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    用&nbsp; 戶&nbsp; 名：</td>
                <td>
                    <asp:TextBox ID="txtUsname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    密&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 碼：</td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    用戶類型：</td>
                <td>
                    <asp:RadioButtonList ID="rblUser" runat="server"
                        onselectedindexchanged="rblUser_SelectedIndexChanged"
                        RepeatDirection="Horizontal" style="text-align: left">
                        <asp:ListItem Selected="True" Value="1">普通用戶</asp:ListItem>
                        <asp:ListItem Value="2">管理員</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" Text="登入" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnReg" runat="server" Text="註冊" onclick="btnReg_Click" />
                </td>
                <td class="style2">
                    <asp:Button ID="btnRcove" runat="server" Text="忘記密碼" onclick="btnRcove_Click" />
&nbsp;&nbsp;
                    <asp:Button ID="btnManage" runat="server" Text="用戶管理"
                        onclick="btnManage_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>