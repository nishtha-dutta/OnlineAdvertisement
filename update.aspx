<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 1114px; height: 283px">
        <tr>
            <td colspan="3" style="background-color: #cc0000">
            </td>
        </tr>
        <tr style="background-color: #ffffff">
            <td style="height: 22px; width: 203px;">
            </td>
            <td style="width: 388px; height: 22px">
                <strong><span style="font-size: 32pt; color: #cc0000; text-decoration: underline">UPDATE
                    PROFILE</span></strong></td>
            <td style="height: 22px">
            </td>
        </tr>
        <tr style="background-color: #ffffff">
            <td style="height: 89px; width: 203px;">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/wer.png" Width="201px" /></td>
            <td style="width: 388px; height: 89px">
                <asp:Label ID="Label1" runat="server" Text="ENTER YOUR LOGIN ID" Width="180px"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="enter login id" ControlToValidate="TextBox1">*</asp:RequiredFieldValidator>
                <asp:Label ID="Label9" runat="server" ForeColor="Red" Text="LOGIN ID DOES NOT EXIST"
                    Visible="False" Width="200px"></asp:Label><br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="NAME" Visible="False" Width="73px"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox><br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="ADDRESS" Visible="False"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                &nbsp;<asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox><br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="PHONE NUMBER" Visible="False"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                <asp:TextBox ID="TextBox4" runat="server" Visible="False"></asp:TextBox><br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="SECURITY QUESTION" Visible="False"></asp:Label>&nbsp;
                <asp:TextBox ID="TextBox5" runat="server" Visible="False"></asp:TextBox><br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="SECURITY ANSWER" Visible="False"></asp:Label>
                &nbsp; &nbsp;
                <asp:TextBox ID="TextBox6" runat="server" Visible="False"></asp:TextBox><br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="STATE" Visible="False"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp;<asp:TextBox ID="TextBox8" runat="server" Visible="False"></asp:TextBox>&nbsp;<br />
                <br />
                <asp:Label ID="Label8" runat="server" Text="CITY" Visible="False"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp;
                <asp:TextBox ID="TextBox7" runat="server" Visible="False"></asp:TextBox>&nbsp;<br />
                <br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton1" runat="server" Height="58px" ImageUrl="~/images/sub.jpg"
                    OnClick="ImageButton1_Click" Visible="False" Width="146px" /><br />
                &nbsp;<asp:Label ID="Label10" runat="server" Font-Size="XX-Large" ForeColor="Red"
                    Text="Record updated successfully" Visible="False" Width="375px"></asp:Label><br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT * FROM [membership]"></asp:SqlDataSource>
                <br />
                &nbsp;
            </td>
            <td style="height: 89px">
            </td>
        </tr>
    </table>
</asp:Content>

