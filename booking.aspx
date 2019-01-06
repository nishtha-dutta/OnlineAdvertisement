<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="booking.aspx.cs" Inherits="Default7" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 1290px; height: 358px">
        <tr>
            <td colspan="4" style="height: 26px; background-color: firebrick">
            </td>
        </tr>
        <tr>
            <td style="width: 268px">
            </td>
            <td align="center" colspan="2" rowspan="2" style="background-color: navajowhite">
                <span style="font-size: 24pt; font-family: Bradley Hand ITC; color: #cc0000;"><strong>BOOK YOUR ADVERTISEMENT</strong></span></td>
            <td style="width: 339px">
                <span style="font-size: 14pt; font-family: Bradley Hand ITC"><strong><span style="color: #ff0000">
                    <br />
                </span></strong></span>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                &nbsp; &nbsp; &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 268px; height: 40px;">
            </td>
            <td style="width: 339px; height: 40px;">
                &nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 268px">
            </td>
            <td style="width: 814px">
            </td>
            <td style="width: 528px">
            </td>
            <td style="width: 339px">
            </td>
        </tr>
        <tr>
            <td style="width: 268px">
            </td>
            <td style="width: 814px">
                <strong><span style="color: red; font-family: Tahoma"><span style="text-decoration: underline">
                    PUBLICATION DETAILS</span> :-</span></strong></td>
            <td style="width: 528px">
            </td>
            <td style="width: 339px">
            </td>
        </tr>
        <tr>
            <td style="width: 268px; height: 5px;">
            </td>
            <td style="width: 814px; height: 5px;">
            </td>
            <td style="width: 528px; height: 5px;">
            </td>
            <td style="width: 339px; height: 5px;">
            </td>
        </tr>
        <tr>
            <td style="width: 268px;" rowspan="2">
            </td>
            <td style="width: 814px;" align="right" rowspan="2">
                <span style="color: infotext">
                </span>
                <span style="color: infotext">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="DropDownList10"
                        ErrorMessage="select type of edition">*</asp:RequiredFieldValidator>Type of
                    edition</span></td>
            <td style="width: 528px;" rowspan="2">
                &nbsp;&nbsp;<asp:DropDownList ID="DropDownList10" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList10_SelectedIndexChanged">
                    <asp:ListItem>--------select--------------</asp:ListItem>
                    <asp:ListItem>All</asp:ListItem>
                    <asp:ListItem>Hindi</asp:ListItem>
                    <asp:ListItem>English</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 339px;" rowspan="2">
            </td>
        </tr>
        <tr>
        </tr>
        <tr>
            <td rowspan="1" style="width: 268px">
            </td>
            <td align="right" rowspan="1" style="width: 814px">
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="DropDownList7"
                    ErrorMessage="select edition">*</asp:RequiredFieldValidator>Choose a Edition</td>
            <td rowspan="1" style="width: 528px">
                &nbsp;<asp:DropDownList ID="DropDownList7" runat="server" Width="152px">
                </asp:DropDownList></td>
            <td rowspan="1" style="width: 339px">
            </td>
        </tr>
        <tr>
            <td align="center" rowspan="15" style="width: 268px">
                <asp:Image ID="Image2" runat="server" Height="168px" ImageUrl="~/images/online-ads.jpg"
                    Width="204px" /></td>
            <td style="width: 814px;" align="right" rowspan="2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="DropDownList11"
                    ErrorMessage="select type of advertisement">*</asp:RequiredFieldValidator>Type of Advertisement</td>
            <td style="width: 528px;" rowspan="2">
                &nbsp;<asp:DropDownList ID="DropDownList11" runat="server" Width="150px">
                    <asp:ListItem>------------select-----------</asp:ListItem>
                    <asp:ListItem>classifieds regular/ordinary</asp:ListItem>
                    <asp:ListItem>classified display</asp:ListItem>
                    <asp:ListItem>display</asp:ListItem>
                </asp:DropDownList>
                &nbsp;</td>
            <td align="center" rowspan="15" style="width: 339px">
                <asp:Image ID="Image1" runat="server" Height="168px" ImageUrl="~/images/online-ads.jpg"
                    Width="204px" /></td>
        </tr>
        <tr>
        </tr>
        <tr>
            <td align="right" style="width: 814px; height: 25px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="DropDownList5"
                    ErrorMessage="select page no.">*</asp:RequiredFieldValidator>Select page no.&nbsp;</td>
            <td style="width: 528px; height: 25px">
                &nbsp;<asp:DropDownList ID="DropDownList5" runat="server" Width="155px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged">
                    <asp:ListItem>select</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" style="width: 814px; height: 25px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="DropDownList6"
                    ErrorMessage="select position">*</asp:RequiredFieldValidator>Select position
                of advertisement&nbsp;</td>
            <td style="width: 528px; height: 25px">
                &nbsp;<asp:DropDownList ID="DropDownList6" runat="server" Width="155px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged1">
                    <asp:ListItem>select</asp:ListItem>
                    <asp:ListItem>center</asp:ListItem>
                    <asp:ListItem>upper</asp:ListItem>
                    <asp:ListItem>lower</asp:ListItem>
                    <asp:ListItem>left side</asp:ListItem>
                    <asp:ListItem>right side</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" style="width: 814px; height: 25px">
                Approx. Budget</td>
            <td style="width: 528px; height: 25px">
                <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 814px; height: 21px" align="right">
            </td>
            <td style="width: 528px; height: 21px">
            </td>
        </tr>
        <tr>
            <td style="width: 814px; height: 20px" align="left">
                <span style="color: red; font-family: Tahoma"><strong><span style="text-decoration: underline">
                    ADVERTISING DETAILS</span>:-</strong></span></td>
            <td style="width: 528px; height: 20px">
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 814px; height: 21px">
            </td>
            <td style="width: 528px; height: 21px">
            </td>
        </tr>
        <tr>
            <td style="width: 814px; height: 26px;" align="right">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox3"
                    ErrorMessage="enter name of advertisement">*</asp:RequiredFieldValidator>Advertisement Name</td>
            <td style="width: 528px; height: 26px;">
                &nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3"
                    ErrorMessage="RegularExpressionValidator" ValidationExpression="[a-zA-Z]*$">enter the name using charaters only</asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td style="width: 814px; height: 10px" align="right">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList1"
                    ErrorMessage="select date" InitialValue="1">*</asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList2"
                    ErrorMessage="select month" InitialValue="select month">*</asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList3"
                    ErrorMessage="select year" InitialValue="select year">*</asp:RequiredFieldValidator>Release Date</td>
            <td style="width: 528px; height: 10px">
                &nbsp;Day
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
                Month
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged">
                    <asp:ListItem>select month</asp:ListItem>
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
                <br />
                Year
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" >
                    <asp:ListItem>select year</asp:ListItem>
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
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label7" runat="server" ForeColor="#C00000" Text="on this date newspaper is already published select another date"
                    Visible="False" Width="267px"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 814px; height: 10px" align="right">
                Special Instructions</td>
            <td style="width: 528px; height: 10px">
                &nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 814px; height: 12px" align="right">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox8"
                    ErrorMessage="enter amount of DD">*</asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownList8"
                    ErrorMessage="enter date of DD">*</asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6"
                    ErrorMessage="enter bank code">*</asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5"
                    ErrorMessage="enter DD no.">*</asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList4"
                    ErrorMessage="select payment option" InitialValue="select">*</asp:RequiredFieldValidator>Payment Option</td>
            <td style="width: 528px; height: 12px">
                &nbsp;<asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
                    <asp:ListItem>select</asp:ListItem>
                    <asp:ListItem>DD</asp:ListItem>
                    <asp:ListItem>Cash</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label1" runat="server" Text="DD No." Width="52px" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" Width="83px" Visible="False"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox5"
                    ErrorMessage="DD no. must be integer" ValidationExpression="[0-9]*$"></asp:RegularExpressionValidator>&nbsp;<br />
                &nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="bank code" Visible="False" Width="69px"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server" Visible="False" Width="90px"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="amount" Visible="False" Width="50px"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server" Visible="False" Width="108px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1"
                    ControlToValidate="TextBox8" ErrorMessage="CompareValidator">DD must be same amount as the budget</asp:CompareValidator></td>
        </tr>
        <tr>
            <td align="right" style="width: 814px; height: 10px">
            </td>
            <td style="width: 528px; height: 10px">
                &nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Date" Visible="False" Width="38px"></asp:Label>
                &nbsp;<asp:DropDownList ID="DropDownList8" runat="server" Visible="False">
                </asp:DropDownList>&nbsp;<asp:DropDownList ID="DropDownList9" runat="server" AutoPostBack="True"
                    Visible="False" Width="89px" OnSelectedIndexChanged="DropDownList9_SelectedIndexChanged">
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
                <asp:DropDownList ID="DropDownList12" runat="server" AutoPostBack="True" Visible="False"
                    Width="113px">
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
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label8" runat="server" ForeColor="#C00000" Text="This date does not exist"
                    Visible="False" Width="148px"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 814px; height: 10px" align="right">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="FileUpload1"
                    ErrorMessage="attach the document">*</asp:RequiredFieldValidator>Related Document</td>
            <td style="width: 528px; height: 10px">
                &nbsp;<asp:FileUpload ID="FileUpload1" runat="server" /></td>
        </tr>
        <tr>
            <td style="width: 814px; height: 10px" align="right">
                Advertising Text</td>
            <td style="width: 528px; height: 10px">
                &nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="69px" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 268px;" rowspan="2">
            </td>
            <td style="width: 814px;" align="right" rowspan="2">
                </td>
            <td style="width: 528px;" rowspan="2">
                &nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#C00000"
                    Text="Your booking has been done" Width="231px" Visible="False"></asp:Label><br />
                &nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#C00000"
                    Text="This slot is already booked." Visible="False" Width="228px"></asp:Label></td>
            <td style="width: 339px;" rowspan="2">
            </td>
        </tr>
        <tr>
        </tr>
        <tr>
            <td style="width: 268px; height: 10px">
            </td>
            <td style="width: 814px; height: 10px">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
            <td style="width: 528px; height: 10px">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/sub.jpg" OnClick="ImageButton1_Click" />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT * FROM [booking]"></asp:SqlDataSource>
            </td>
            <td style="width: 339px; height: 10px">
            </td>
        </tr>
    </table>
</asp:Content>

