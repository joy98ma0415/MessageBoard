<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Msg.aspx.cs" Inherits="MessageBoard.Msg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        .style1 {
            width: 100%;
        }

        .style2 {
            text-align: center;
        }

        .style3 {
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
            查看留言
        </div>
        <table class="style1">
            <tr>
                <td class="auto-style1"></td>
                <td colspan="3" class="auto-style2">
                    <asp:GridView ID="gvMessage" runat="server" Width="473px"
                        BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                        BorderWidth="1px" CellPadding="3" GridLines="Horizontal"
                        DataKeyNames="ID" OnRowDeleting="gvMessage_RowDeleting">
                        <AlternatingRowStyle BackColor="#F7F7F7" />
                        <Columns>
                            <asp:TemplateField HeaderText="刪除">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonDelete" runat="server"
                                        CausesValidation="false" CommandName="Delete"
                                        OnClientClick="return confirm('您確定要刪除此筆資料？');"
                                        Style="position: static">刪除</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <SortedAscendingCellStyle BackColor="#F4F4FD" />
                        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                        <SortedDescendingCellStyle BackColor="#D8D8F0" />
                        <SortedDescendingHeaderStyle BackColor="#3E3277" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="style2" colspan="4">發表留言</td>
            </tr>
            <tr>
                <td class="style3">留言人</td>
                <td colspan="3">
                    <asp:Label ID="lblUser" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3">&nbsp;</td>
                <td colspan="3">
                    <asp:TextBox ID="txtMessage" runat="server" Height="141px" TextMode="MultiLine"
                        Width="439px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">&nbsp&nbsp;</td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="提交" OnClick="btnSubmit_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancel" runat="server" Text="取消" OnClick="btnCancel_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="style3">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>