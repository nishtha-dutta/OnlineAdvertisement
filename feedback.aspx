<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="Default5" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 1287px; height: 336px">
        <tr>
            <td colspan="4" style="height: 20px; background-color: firebrick">
                <strong><span style="font-size: 36pt; font-family: Bradley Hand ITC"></span></strong>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="4" style="height: 56px; background-color: darksalmon">
                <strong><span style="font-size: 36pt; font-family: Bradley Hand ITC">&nbsp; &nbsp; &nbsp;
                    SUBMIT YOUR FEEDBACK</span></strong></td>
        </tr>
        <tr>
            <td align="center" colspan="4" style="height: 28px; background-color: white">
                &nbsp; &nbsp;
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/feedback_dt_xsm.jpg" Width="341px" /></td>
        </tr>
        <tr>
            <td style="width: 431px; height: 1px">
            </td>
            <td align="right" rowspan="2" style="width: 107px">
            </td>
            <td rowspan="2" style="width: 362px">
                &nbsp;&nbsp;
            </td>
            <td align="center" style="height: 1px; width: 355px;">
                <span style="font-size: 14pt; color: #ff0000">
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="True" NavigateUrl="~/r_feedback.aspx">Read More Customer Feedback</asp:HyperLink>&nbsp;</span></td>
        </tr>
        <tr>
            <td style="width: 431px;" align="center" rowspan="8">
            </td>
            <td style="width: 355px;" align="center" rowspan="8">
                <asp:Image ID="Image2" runat="server" Height="193px" ImageUrl="~/images/feedback_img.jpg"
                    Width="326px" /></td>
        </tr>
        <tr>
            <td style="width: 107px; height: 1px" align="right">
                Name</td>
            <td style="width: 362px; height: 1px">
                <asp:TextBox ID="TextBox1" runat="server" Width="138px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Must to enter" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 107px; height: 1px" align="right">
                State</td>
            <td style="width: 362px; height: 1px">
                &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Width="144px">
                    <asp:ListItem>----------select-------------</asp:ListItem>
                    <asp:ListItem>UP</asp:ListItem>
                    <asp:ListItem>MP</asp:ListItem>
                    <asp:ListItem>Assam</asp:ListItem>
                    <asp:ListItem>Punjab</asp:ListItem>
                    <asp:ListItem>Haryana</asp:ListItem>
                    <asp:ListItem>Jammu And kasmir</asp:ListItem>
                    <asp:ListItem>Maharastra</asp:ListItem>
                    <asp:ListItem>Tamil Nadu</asp:ListItem>
                    <asp:ListItem>Kerala</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                    <asp:ListItem>Gujarat</asp:ListItem>
                    <asp:ListItem>Rajasthan</asp:ListItem>
                    <asp:ListItem>West Bengal</asp:ListItem>
                    <asp:ListItem>Arunachal Pradesh</asp:ListItem>
                    <asp:ListItem>Karnataka</asp:ListItem>
                    <asp:ListItem>Bihar</asp:ListItem>
                    <asp:ListItem>Chattisgarh</asp:ListItem>
                    <asp:ListItem>Jharkhand</asp:ListItem>
                    <asp:ListItem>Orissa</asp:ListItem>
                    <asp:ListItem>Uttaranchal</asp:ListItem>
                    <asp:ListItem>Andra Pradesh</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1"
                    ErrorMessage="RequiredFieldValidator">must to select state</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 107px; height: 1px" align="right">
                Your Message</td>
            <td style="width: 362px; height: 1px">
                &nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="66px" TextMode="MultiLine"
                    Width="205px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="RequiredFieldValidator">plz write some comment</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td align="right" style="width: 107px; height: 1px">
            </td>
            <td style="width: 362px; height: 1px">
            </td>
        </tr>
        <tr>
            <td align="right" rowspan="2" style="width: 107px">
            </td>
            <td rowspan="2" style="width: 362px">
                &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#C00000"
                    Text="Thanks for your feedback" Visible="False" Width="206px"></asp:Label></td>
        </tr>
        <tr>
        </tr>
        <tr>
            <td style="width: 107px; height: 3px" align="right">
                </td>
            <td style="width: 362px; height: 3px">
                &nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/sub.jpg" OnClick="ImageButton1_Click" /></td>
        </tr>
        <tr>
            <td style="width: 431px; height: 3px">
            </td>
            <td style="width: 107px; height: 3px">
            </td>
            <td style="width: 362px; height: 3px">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT * FROM [feedback]"></asp:SqlDataSource>
                </td>
            <td style="height: 3px; width: 355px;">
            </td>
        </tr>
    </table>
</asp:Content>

