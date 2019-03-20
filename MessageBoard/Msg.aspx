<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Msg.aspx.cs" Inherits="MessageBoard.Msg" %>

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
            width: 84px;
        }
        .auto-style1 {
            width: 84px;
            height: 181px;
        }
        .auto-style2 {
            height: 181px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">

        查看留言</div>
    <table class="style1">
        <tr>
            <td class="auto-style1">
                </td>
            <td colspan="3" class="auto-style2">
                <asp:GridView ID="gvMessage" runat="server" Width="436px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="4">
                發表留言</td>
        </tr>
        <tr>
            <td class="style3">
                留言人</td>
            <td colspan="3">
                <asp:Label ID="lblUser" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td colspan="3">
                <asp:TextBox ID="txtMessage" runat="server" Height="141px" TextMode="MultiLine"
                    Width="439px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp&nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="提交" onclick="btnSubmit_Click" />
            </td>
            <td>
                <asp:Button ID="btnCancel" runat="server" Text="取消" onclick="btnCancel_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td colspan="3">
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>