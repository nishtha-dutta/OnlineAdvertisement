<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="membership.aspx.cs" Inherits="Default4" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 1289px; height: 143px; border-collapse: collapse;">
        <tr>
            <td align="center" style="width: 51px; height: 32px; background-color: firebrick">
            </td>
            <td align="center" colspan="3" style="width: 51px; height: 32px; background-color: firebrick">
            </td>
            <td align="center" style="width: 51px; height: 32px; background-color: firebrick">
            </td>
        </tr>
        <tr>
            <td style="width: 51px" align="center">
                <asp:Image ID="Image2" runat="server" Height="167px" ImageUrl="~/images/online-ads.jpg"
                    Width="262px" /></td>
            <td style="background-color: floralwhite;" align="center" colspan="3">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/banner.jpg" /></td>
            <td style="width: 63px" align="center">
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/Top_Right_book.gif" /></td>
        </tr>
        <tr>
            <td colspan="5" style="background-color: firebrick">
            </td>
        </tr>
        <tr>
            <td style="width: 51px">
            </td>
            <td align="center" colspan="3">
                <span style="font-size: 24pt; color: #cc3333; font-family: Bradley Hand ITC"><strong>
                    -: MEMBERSHIP FORM :-</strong></span></td>
            <td style="width: 63px">
            </td>
        </tr>
        <tr>
            <td style="width: 51px; height: 21px">
            </td>
            <td align="center" colspan="3" style="height: 21px; background-color: white">
                <strong>Registering with Advertisement India.com is easy, fast and free !</strong></td>
            <td style="width: 63px; height: 21px">
            </td>
        </tr>
        <tr>
            <td colspan="5" style="height: 27px; background-color: firebrick">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="width: 231px; height: 26px">
            </td>
            <td align="right" style="width: 55px; height: 26px; background-color: white">
                &nbsp;&nbsp; Name</td>
            <td align="left" style="width: 488px; height: 26px; background-color: white">
                &nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter name" ControlToValidate="TextBox1" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="RegularExpressionValidator" ValidationExpression="[a-zA-Z]*$">must enter characters</asp:RegularExpressionValidator></td>
            <td style="width: 63px; height: 26px">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="width: 231px; height: 10px">
            </td>
            <td align="right" style="width: 55px; height: 10px; background-color: white">
                LoginID</td>
            <td align="left" style="width: 488px; height: 10px; background-color: white">
                &nbsp;
                <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="Enter Login Id" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:Label ID="Label2" runat="server" ForeColor="#C00000" Text="Already exist" Visible="False"
                    Width="127px"></asp:Label></td>
            <td style="width: 63px; height: 10px">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="width: 231px; height: 26px;">
            </td>
            <td align="right" style="width: 55px; background-color: white; height: 26px;">
                &nbsp;Password</td>
            <td align="left" style="width: 488px; background-color: white; height: 26px;">
                &nbsp;
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="147px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                    ErrorMessage="Enter password" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
            <td style="width: 63px; height: 26px;">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="width: 231px; height: 26px">
            </td>
            <td align="right" style="width: 55px; height: 26px; background-color: white">
                RetypePassword</td>
            <td align="left" style="width: 488px; height: 26px; background-color: white">
                &nbsp;
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" Width="147px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3"
                    ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="password should be same" SetFocusOnError="True"></asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4"
                    ErrorMessage="Enter Password Again" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
            <td style="width: 63px; height: 26px">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="width: 231px; height: 26px">
            </td>
            <td align="right" style="width: 55px; height: 26px; background-color: white">
                SecurityQuestion</td>
            <td align="left" style="width: 488px; height: 26px; background-color: white">
                &nbsp;
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox10"
                    ErrorMessage="enter some value">*</asp:RequiredFieldValidator></td>
            <td style="width: 63px; height: 26px">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="width: 231px; height: 31px">
            </td>
            <td align="right" style="width: 55px; height: 31px; background-color: white">
                SecurityAnswer</td>
            <td align="left" style="width: 488px; height: 31px; background-color: white">
                &nbsp;
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox11"
                    ErrorMessage="enter some value">*</asp:RequiredFieldValidator></td>
            <td style="width: 63px; height: 31px">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="width: 231px; height: 26px;">
            </td>
            <td align="right" style="width: 55px; background-color: white; height: 26px;">
                &nbsp;PhoneNo.</td>
            <td align="left" style="width: 488px; background-color: white; height: 26px;">
                &nbsp;
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>&nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox5"
                    ErrorMessage="must enter numbers" ValidationExpression="[0-9]*$"></asp:RegularExpressionValidator></td>
            <td align="center" style="width: 152px; background-color: white; height: 26px;">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="width: 231px; height: 25px">
            </td>
            <td align="right" style="width: 55px; height: 25px; background-color: white">
                &nbsp;Address</td>
            <td align="left" style="width: 488px; height: 25px; background-color: white">
                &nbsp;
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            <td align="center" style="width: 152px; height: 25px; background-color: white">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="width: 231px">
            </td>
            <td align="right" style="width: 55px; background-color: white">
                &nbsp;State</td>
            <td align="left" style="width: 488px; background-color: white">
                &nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>----------select------------</asp:ListItem>
                    <asp:ListItem>UP</asp:ListItem>
                    <asp:ListItem>MP</asp:ListItem>
                    <asp:ListItem>Jammu And Kasmir</asp:ListItem>
                    <asp:ListItem>Bihar</asp:ListItem>
                    <asp:ListItem>Maharashtra</asp:ListItem>
                    <asp:ListItem>Rajasthan</asp:ListItem>
                    <asp:ListItem>Gujarat</asp:ListItem>
                    <asp:ListItem>Himachal Pradesh</asp:ListItem>
                    <asp:ListItem>Andhra Pradesh</asp:ListItem>
                    <asp:ListItem>Orissa</asp:ListItem>
                    <asp:ListItem>karnataka</asp:ListItem>
                    <asp:ListItem>Tamil Nadu</asp:ListItem>
                    <asp:ListItem>West Bangal </asp:ListItem>
                    <asp:ListItem>Assam</asp:ListItem>
                    <asp:ListItem>Arunachal Pradesh</asp:ListItem>
                    <asp:ListItem>Jharkhand</asp:ListItem>
                    <asp:ListItem>Punjab</asp:ListItem>
                    <asp:ListItem>Haryana</asp:ListItem>
                    <asp:ListItem>Kerala</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DropDownList1"
                    ErrorMessage="select state" InitialValue="select">*</asp:RequiredFieldValidator></td>
            <td style="width: 63px">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="width: 231px; height: 7px">
            </td>
            <td align="right" style="width: 55px; height: 7px; background-color: white">
                &nbsp;
                City</td>
            <td align="left" style="width: 488px; height: 7px; background-color: white">
                &nbsp;
                <asp:DropDownList ID="DropDownList2" runat="server" Width="149px">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DropDownList2"
                    ErrorMessage="select city" InitialValue="Lucknow">*</asp:RequiredFieldValidator></td>
            <td style="width: 63px; height: 7px">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="width: 231px">
            </td>
            <td align="left" style="width: 55px; background-color: white">
                </td>
            <td align="left" style="width: 488px; background-color: white">
                &nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#C00000"
                    Text="Label" Visible="False" Width="421px"></asp:Label></td>
            <td style="width: 63px">
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="width: 231px">
            </td>
            <td align="left" style="width: 55px; background-color: white">
            </td>
            <td align="left" style="width: 488px; background-color: white">
            </td>
            <td style="width: 63px">
            </td>
        </tr>
        <tr>
            <td colspan="2" style="width: 231px">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT * FROM [membership]"></asp:SqlDataSource>
            </td>
            <td align="left" style="width: 55px; background-color: white">
            </td>
            <td align="left" style="width: 488px; background-color: white">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/sub.jpg" OnClick="ImageButton1_Click" /></td>
            <td style="width: 63px">
            </td>
        </tr>
    </table>
</asp:Content>

