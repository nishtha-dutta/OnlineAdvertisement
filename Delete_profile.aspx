<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Delete_profile.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 1295px; height: 302px">
        <tr>
            <td colspan="3" style="background-color: #cc0000">
            </td>
        </tr>
        <tr>
            <td style="height: 46px; width: 364px;">
            </td>
            <td style="height: 46px">
                <strong><span style="font-size: 24pt; color: #cc0000; text-decoration: underline">DELETE
                    PROFILE</span></strong></td>
            <td style="height: 46px">
            </td>
        </tr>
        <tr>
            <td style="width: 364px; height: 292px">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/member.png" Width="177px" /><br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td style="height: 292px">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="LOGIN ID" Width="74px"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Font-Size="Medium" ForeColor="#C00000" Text="login id does not exist"
                    Width="161px" Visible="False"></asp:Label><br />
                <asp:Label ID="Label3" runat="server" Font-Size="X-Large" ForeColor="#C00000" Text="Your account has been sucessfully deleted"
                    Visible="False" Width="424px"></asp:Label><br />
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="NAME" Width="51px"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox><br />
                <br />
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="PHONE NO." Width="87px"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox><br />
                <br />
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="ADDRESS" Width="86px"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox><br />
                <br />
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="CITY" Width="50px"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:TextBox ID="TextBox5" runat="server" ReadOnly="True"></asp:TextBox><br />
                <br />
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="STATE" Width="64px"></asp:Label>
                &nbsp; &nbsp; &nbsp;<asp:TextBox ID="TextBox6" runat="server" ReadOnly="True"></asp:TextBox><br />
                <br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" BorderColor="Red" Font-Bold="True" Font-Size="Medium"
                    ForeColor="#C00000" OnClick="Button1_Click" Text="DELETE" /><br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT [name], [loginid], [pno], [address], [state], [city] FROM [membership]">
                </asp:SqlDataSource>
                <br />
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#C00000"
                    Text="Are you sure you want to delete your account!" Visible="False" Width="369px"></asp:Label><br />
                <br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Font-Bold="True" ForeColor="#C00000" OnClick="Button2_Click"
                    Text="YES" Visible="False" />
                &nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Font-Bold="True" ForeColor="#C00000" OnClick="Button3_Click"
                    Text="NO" Visible="False" /></td>
            <td style="height: 292px">
            </td>
        </tr>
    </table>
</asp:Content>

