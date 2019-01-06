<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="member_detail.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 1114px; height: 242px">
        <tr>
            <td colspan="3" style="background-color: #cc0000">
            </td>
        </tr>
        <tr>
            <td style="width: 355px; height: 67px">
            </td>
            <td style="width: 480px; height: 67px">
                <strong><span style="font-size: 32pt; color: #333366; text-decoration: underline">MEMBER
                    DETAILS</span></strong></td>
            <td style="height: 67px">
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 355px; height: 113px">
                <asp:Image ID="Image1" runat="server" Height="157px" ImageUrl="~/images/untitled.bmp"
                    Width="142px" /></td>
            <td colspan="2" style="height: 113px">
                &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>----------select----------------</asp:ListItem>
                    <asp:ListItem>UP</asp:ListItem>
                    <asp:ListItem>MP</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                    <asp:ListItem>Maharastra</asp:ListItem>
                    <asp:ListItem>Haryana</asp:ListItem>
                </asp:DropDownList>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<br />
                <br />
                &nbsp;<br />
                <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False"
                    DataSourceID="SqlDataSource1" Height="50px" Width="125px" BackColor="Maroon" BorderColor="#C00000" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                    <Fields>
                        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                        <asp:BoundField DataField="sques" HeaderText="sques" SortExpression="sques" />
                        <asp:BoundField DataField="sans" HeaderText="sans" SortExpression="sans" />
                        <asp:BoundField DataField="pno" HeaderText="pno" SortExpression="pno" />
                        <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                        <asp:BoundField DataField="state" HeaderText="state" SortExpression="state" />
                        <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                    </Fields>
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                </asp:DetailsView>
                <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT [name], [sques], [sans], [pno], [address], [state], [city] FROM [membership] WHERE ([city] = @city)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" DefaultValue="select" Name="city"
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

