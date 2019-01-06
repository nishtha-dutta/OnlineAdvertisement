<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="forgot.aspx.cs" Inherits="Default8" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 1289px; height: 276px">
        <tr>
            <td colspan="5" style="height: 31px; background-color: firebrick">
            </td>
        </tr>
        <tr>
            <td align="center" style="width: 75px; height: 37px">
                <asp:Image ID="Image2" runat="server" Height="136px" ImageUrl="~/images/FAQ2.png"
                    Width="165px" /></td>
            <td align="center" colspan="3" style="height: 37px">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/forgot.jpg" /></td>
            <td style="width: 2px; height: 37px">
                <asp:Image ID="Image3" runat="server" Height="136px" ImageUrl="~/images/FAQ2.png"
                    Width="165px" /></td>
        </tr>
        <tr>
            <td style="width: 75px">
            </td>
            <td style="width: 194px">
            </td>
            <td style="width: 17px">
            </td>
            <td style="width: 4px">
            </td>
            <td style="width: 2px">
            </td>
        </tr>
        <tr>
            <td style="width: 75px">
            </td>
            <td align="left" style="width: 194px">
            </td>
            <td style="width: 17px" align="left">
                LoginID</td>
            <td style="width: 4px">
                <asp:TextBox ID="TextBox1" runat="server" Width="147px" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True"></asp:TextBox></td>
            <td style="width: 2px">
            </td>
        </tr>
        <tr>
            <td style="width: 75px; height: 19px">
            </td>
            <td align="left" style="width: 194px; height: 19px">
            </td>
            <td style="width: 17px; height: 19px" align="left">
                SecurityQuestion</td>
            <td style="width: 4px; height: 19px">
                <asp:Label ID="Label3" runat="server" Visible="False" Width="152px"></asp:Label></td>
            <td style="width: 2px; height: 19px">
            </td>
        </tr>
        <tr>
            <td style="width: 75px; height: 5px">
            </td>
            <td align="left" style="width: 194px; height: 5px">
            </td>
            <td style="width: 17px; height: 5px" align="left">
                SecurityAnswer</td>
            <td style="width: 4px; height: 5px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Label" Visible="False"
                    Width="124px"></asp:Label></td>
            <td style="width: 2px; height: 5px">
            </td>
        </tr>
        <tr>
            <td style="width: 75px; height: 57px;">
            </td>
            <td align="left" style="width: 194px; height: 57px">
            </td>
            <td style="width: 17px; height: 57px;" align="left">
                <asp:Label ID="Label4" runat="server" Text="Your password is:" Width="188px" Font-Bold="True" Font-Size="X-Large" ForeColor="#C00000" Height="10px"></asp:Label></td>
            <td style="width: 4px; height: 57px;">
                <asp:Label ID="Label1" runat="server" Visible="False" Width="157px" Font-Bold="True" Font-Size="X-Large" ForeColor="#C00000"></asp:Label></td>
            <td style="width: 2px; height: 57px;">
            </td>
        </tr>
        <tr>
            <td style="width: 75px; height: 67px;">
            </td>
            <td align="center" colspan="3" style="height: 67px">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/sub.jpg" OnClick="ImageButton1_Click" /></td>
            <td style="width: 2px; height: 67px;">
            </td>
        </tr>
        <tr>
            <td style="width: 75px; height: 11px;">
            </td>
            <td style="width: 194px; height: 11px">
            </td>
            <td style="width: 17px; height: 11px;">
            </td>
            <td style="width: 4px; height: 11px;">
            </td>
            <td style="width: 2px; height: 11px;">
            </td>
        </tr>
        <tr>
            <td style="width: 75px">
            </td>
            <td style="width: 194px">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT * FROM [membership]"></asp:SqlDataSource>
            </td>
            <td style="width: 17px">
            </td>
            <td style="width: 4px">
            </td>
            <td style="width: 2px">
            </td>
        </tr>
        <tr>
            <td style="width: 75px">
            </td>
            <td style="width: 194px">
            </td>
            <td style="width: 17px">
            </td>
            <td style="width: 4px">
            </td>
            <td style="width: 2px">
            </td>
        </tr>
        <tr>
            <td style="width: 75px">
            </td>
            <td style="width: 194px">
            </td>
            <td style="width: 17px">
            </td>
            <td style="width: 4px">
            </td>
            <td style="width: 2px">
            </td>
        </tr>
    </table>
</asp:Content>

