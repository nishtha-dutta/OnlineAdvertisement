<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="change_pass.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 1301px; height: 325px">
        <tr>
            <td colspan="3" style="background-color: #cc0000">
            </td>
        </tr>
        <tr>
            <td style="width: 279px; height: 1px">
            </td>
            <td style="height: 1px">
                <span style="font-size: 24pt; color: #cc0000; text-decoration: underline"><strong>CHANGE
                    PASSWORD</strong></span></td>
            <td style="height: 1px">
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 279px; height: 99px">
                <asp:Image ID="Image1" runat="server" Height="107px" ImageUrl="~/images/icon_member_resend_pass.gif"
                    Width="114px" /><br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td style="height: 99px">
                <strong>LOGIN ID &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp;&nbsp; </strong>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Must enter login id">*</asp:RequiredFieldValidator><br />
                <br />
                <strong>OLD PASSWORD &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</strong>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="Must enter password">*</asp:RequiredFieldValidator><br />
                <br />
                <strong>NEW PASSWORD &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; </strong>&nbsp;<asp:TextBox
                    ID="TextBox3" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                    ErrorMessage="Must enter password">*</asp:RequiredFieldValidator>
                <br />
                <br />
                <strong>CONFIRM PASSWORD</strong>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3"
                    ControlToValidate="TextBox4" ErrorMessage="Password should be same">*</asp:CompareValidator><br />
                <br />
                <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="#C00000" Text="Label"
                    Visible="False" Width="122px"></asp:Label><br />
                <br />
                &nbsp; &nbsp;
                <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#C00000" OnClick="Button1_Click"
                    Text="CANCEL" />
                &nbsp; &nbsp;
                <asp:Button ID="Button2" runat="server" Font-Bold="True" ForeColor="#C00000" OnClick="Button2_Click"
                    Text="CLEAR" />
                &nbsp;
                <asp:Button ID="Button3" runat="server" Font-Bold="True" ForeColor="#C00000" OnClick="Button3_Click"
                    Text="SUBMIT" />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT [password], [loginid] FROM [membership]"></asp:SqlDataSource>
            </td>
            <td style="height: 99px">
            </td>
        </tr>
    </table>
</asp:Content>

