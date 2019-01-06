<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="r_feedback.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 1210px; height: 256px">
        <tr>
            <td colspan="3" style="height: 5px; background-color: #cc0000">
            </td>
        </tr>
        <tr>
            <td align="center" style="width: 601px; height: 185px">
            </td>
            <td style="width: 507px; height: 185px">
                <asp:Image ID="Image1" runat="server" Height="120px" ImageUrl="~/images/feedback_dt_xsm.jpg"
                    Width="508px" /></td>
            <td style="width: 485px; height: 185px">
            </td>
        </tr>
        <tr>
            <td align="center" colspan="3" style="height: 13px; background-color: #cc0000">
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 601px">
                <asp:Image ID="Image2" runat="server" Height="180px" ImageUrl="~/images/feed.jpg"
                    Width="142px" /></td>
            <td style="width: 507px">
                &nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="SqlDataSource2"
                    Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                    Font-Underline="False" Width="507px" ForeColor="Black">
                    <FooterStyle BackColor="Tan" />
                    <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    <ItemTemplate>
                        name:
                        <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>'></asp:Label><br />
                        state:
                        <asp:Label ID="stateLabel" runat="server" Text='<%# Eval("state") %>'></asp:Label><br />
                        msg:
                        <asp:Label ID="msgLabel" runat="server" Text='<%# Eval("msg") %>'></asp:Label><br />
                        <br />
                    </ItemTemplate>
                    <HeaderStyle BackColor="Tan" Font-Bold="True" />
                    <AlternatingItemStyle BackColor="PaleGoldenrod" />
                </asp:DataList><asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT * FROM [feedback]"></asp:SqlDataSource>
                &nbsp;
            </td>
            <td style="width: 485px">
            </td>
        </tr>
    </table>
</asp:Content>

