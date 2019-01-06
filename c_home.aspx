<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="c_home.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td colspan="4" rowspan="2" style="background-color: #990000">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</td>
        </tr>
        <tr>
        </tr>
        <tr>
            <td align="right" style="width: 727px; height: 61px">
                <asp:Image ID="Image1" runat="server" Height="113px" ImageUrl="~/images/login_icon.jpg"
                    Width="149px" /></td>
            <td style="width: 593px; height: 61px">
                <asp:HyperLink ID="HyperLink1" runat="server" EnableTheming="True" Font-Bold="True"
                    Font-Size="X-Large" ForeColor="#C00000" NavigateUrl="~/update.aspx">UPDATE PROFILE</asp:HyperLink></td>
            <td align="right" style="width: 240px; height: 61px">
                <asp:Image ID="Image4" runat="server" Height="92px" ImageUrl="~/images/cancel-button-icone-7889-96.png"
                    Width="118px" BackColor="White" BorderColor="White" ForeColor="White" /></td>
            <td style="width: 857px; height: 61px">
                <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" Font-Size="X-Large"
                    ForeColor="#C00000" NavigateUrl="~/cancel.aspx">CANCELATION</asp:HyperLink></td>
        </tr>
        <tr>
            <td align="right" style="width: 727px; height: 64px">
                <asp:Image ID="Image2" runat="server" Height="86px" ImageUrl="~/images/login_icon000.gif"
                    Width="146px" /></td>
            <td style="width: 593px; height: 64px">
                <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" Font-Size="X-Large"
                    ForeColor="#C00000" NavigateUrl="~/change_pass.aspx" Width="250px">CHANGE PASSWORD</asp:HyperLink></td>
            <td align="right" style="width: 240px; height: 64px">
                <asp:Image ID="Image5" runat="server" Height="128px" ImageUrl="~/images/feedback1.jpg"
                    Width="132px" /></td>
            <td style="width: 857px; height: 64px">
                <asp:HyperLink ID="HyperLink5" runat="server" Font-Bold="True" Font-Size="X-Large"
                    ForeColor="#C00000" NavigateUrl="~/feedback.aspx"> FEEDBACK</asp:HyperLink>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 727px; height: 58px">
                <asp:Image ID="Image3" runat="server" Height="104px" ImageUrl="~/images/icon_login.jpg"
                    Width="141px" /></td>
            <td style="width: 593px; height: 58px">
                <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" Font-Size="X-Large"
                    ForeColor="#C00000" NavigateUrl="~/Delete_profile.aspx">DELETE PROFILE</asp:HyperLink></td>
            <td align="right" style="width: 240px; height: 58px">
                <asp:Image ID="Image6" runat="server" Height="148px" ImageUrl="~/images/bookvo.jpg"
                    Width="153px" /></td>
            <td style="width: 857px; height: 58px">
                <asp:HyperLink ID="HyperLink6" runat="server" Font-Bold="True" Font-Size="X-Large"
                    ForeColor="#C00000" NavigateUrl="~/booking.aspx">BOOKING</asp:HyperLink></td>
        </tr>
        <tr>
            <td style="height: 13px; background-color: transparent;" colspan="4">
            </td>
        </tr>
    </table>
    &nbsp;
</asp:Content>

