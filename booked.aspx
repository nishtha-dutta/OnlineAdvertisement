<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="booked.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 1115px">
        <tr>
            <td colspan="3" style="background-color: #cc0000">
            </td>
        </tr>
        <tr>
            <td style="width: 340px; height: 87px">
            </td>
            <td style="height: 87px">
                <strong><span style="font-size: 32pt; color: #3366cc; text-decoration: underline">BOOKING
                    DETAIL</span></strong></td>
            <td style="height: 87px">
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 340px; height: 90px">
                <asp:Image ID="Image1" runat="server" Height="205px" Width="165px" ImageUrl="~/images/Benefits.jpg" /></td>
            <td style="height: 90px">
                <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False"
                    BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                    CellPadding="3" DataSourceID="SqlDataSource1" GridLines="Horizontal" Height="50px"
                    Width="343px">
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <Fields>
                        <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
                        <asp:BoundField DataField="edition" HeaderText="edition" SortExpression="edition" />
                        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                        <asp:BoundField DataField="rdate" HeaderText="rdate" SortExpression="rdate" />
                        <asp:BoundField DataField="pgno" HeaderText="pgno" SortExpression="pgno" />
                        <asp:BoundField DataField="position" HeaderText="position" SortExpression="position" />
                    </Fields>
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                </asp:DetailsView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT [type], [edition], [name], [rdate], [pgno], [position] FROM [booking]">
                </asp:SqlDataSource>
            </td>
            <td style="height: 90px">
            </td>
        </tr>
    </table>
</asp:Content>

