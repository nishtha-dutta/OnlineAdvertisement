<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cancel.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 1274px; height: 354px">
        <tr>
            <td colspan="3" style="background-color: #990000">
            </td>
        </tr>
        <tr>
            <td style="height: 57px">
            </td>
            <td style="width: 411px; height: 57px">
                <span style="font-size: 32pt; color: #990000; text-decoration: underline"><strong>CANCEL
                    BOOKING</strong></span></td>
            <td style="height: 57px">
            </td>
        </tr>
        <tr>
            <td style="height: 217px">
            </td>
            <td style="width: 411px; height: 217px">
                <asp:Label ID="Label1" runat="server" Text="Chose Edition"></asp:Label>&nbsp;
                <asp:DropDownList ID="DropDownList10" runat="server" >
                </asp:DropDownList><br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Page Number"></asp:Label>&nbsp;<asp:DropDownList
                    ID="DropDownList2" runat="server">
                    <asp:ListItem>select</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:DropDownList><br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Position"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>select</asp:ListItem>
                    <asp:ListItem>upper</asp:ListItem>
                    <asp:ListItem>lower</asp:ListItem>
                    <asp:ListItem>top</asp:ListItem>
                    <asp:ListItem>buttom</asp:ListItem>
                    <asp:ListItem>center</asp:ListItem>
                </asp:DropDownList>&nbsp;<br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Release Date"></asp:Label>&nbsp;
                <asp:DropDownList ID="DropDownList4" runat="server">
                </asp:DropDownList><asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged">
                    <asp:ListItem>month</asp:ListItem>
                    <asp:ListItem>jan</asp:ListItem>
                    <asp:ListItem>feb</asp:ListItem>
                    <asp:ListItem>mar</asp:ListItem>
                    <asp:ListItem>apr</asp:ListItem>
                    <asp:ListItem>may</asp:ListItem>
                    <asp:ListItem>jun</asp:ListItem>
                    <asp:ListItem>jul</asp:ListItem>
                    <asp:ListItem>aug</asp:ListItem>
                    <asp:ListItem>sep</asp:ListItem>
                    <asp:ListItem>oct</asp:ListItem>
                    <asp:ListItem>nov</asp:ListItem>
                    <asp:ListItem>dec</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="True"  >
                    <asp:ListItem>year</asp:ListItem>
                    <asp:ListItem>1990</asp:ListItem>
                    <asp:ListItem>1991</asp:ListItem>
                    <asp:ListItem>1992</asp:ListItem>
                    <asp:ListItem>1993</asp:ListItem>
                    <asp:ListItem>1994</asp:ListItem>
                    <asp:ListItem>1995</asp:ListItem>
                    <asp:ListItem>1996</asp:ListItem>
                    <asp:ListItem>1997</asp:ListItem>
                    <asp:ListItem>1998</asp:ListItem>
                    <asp:ListItem>1999</asp:ListItem>
                    <asp:ListItem>2000</asp:ListItem>
                    <asp:ListItem>2001</asp:ListItem>
                    <asp:ListItem>2002</asp:ListItem>
                    <asp:ListItem>2003</asp:ListItem>
                    <asp:ListItem>2004</asp:ListItem>
                    <asp:ListItem>2005</asp:ListItem>
                    <asp:ListItem>2006</asp:ListItem>
                    <asp:ListItem>2007</asp:ListItem>
                    <asp:ListItem>2008</asp:ListItem>
                    <asp:ListItem>2009</asp:ListItem>
                    <asp:ListItem>2010</asp:ListItem>
                    <asp:ListItem>2011</asp:ListItem>
                    <asp:ListItem>2012</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                </asp:DropDownList>&nbsp;&nbsp;<br />
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#C00000"
                    Text="Newspaper has been published on this date your booking can't be cancelled"
                    Visible="False" Width="592px"></asp:Label><br />
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#C00000"
                    Text="This slot does not exist" Visible="False" Width="238px"></asp:Label><br />
                <br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button ID="Button1" runat="server"
                    Font-Bold="True" Font-Size="Large" ForeColor="#C00000" OnClick="Button1_Click"
                    Text="Exit" />&nbsp;
                <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#C00000"
                    OnClick="Button2_Click" Text="Cancel" /><br />
                <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                     SelectCommand="SELECT [position], [rdate], [pgno], [edition] FROM [booking]">
                </asp:SqlDataSource>
            </td>
            <td style="height: 217px">
            </td>
        </tr>
    </table>
</asp:Content>

