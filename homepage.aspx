<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="homepage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style ="background-color:#ffe4c4">
    <form id="form1" runat="server">
    <div>
        <table width="1249px" border="0" cellpadding="0" cellspacing="0" style="border-collapse: collapse">
            <tr>
                <td align="left" style="width: 166px; height: 124px; background-color: #ffffff">
                    <asp:Image ID="Image13" runat="server" Height="151px" ImageUrl="~/images/advertising_company11.jpg"
                        Width="216px" /></td>
                <td style="width: 650px; background-color: #000000; height: 124px;" align="center">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/Untitled.jpg" Height="154px" Width="780px" /></td>
                <td style="color: #ffffff; width: 427px; background-color: #000000; border-color :Black; height: 124px;" align="center" colspan="5">
                    <table style="width: 158px; height: 1px;">
                        <tr>
                            <td align="right" style="width: 115px; height: 15px">
                                <asp:RadioButton ID="RadioButton1" runat="server" Text="Admin" name="type" GroupName ="g1"/></td>
                            <td align="left" colspan="2" style="width: 462px; height: 15px">
                                <asp:RadioButton ID="RadioButton2" runat="server" Text="Member" name="type" GroupName ="g1"/></td>
                        </tr>
                        <tr>
                            <td align="left" style="width: 115px; height: 29px;">
                                Login ID</td>
                            <td colspan="2" style="width: 462px; height: 29px;" align="left">
                                <asp:TextBox ID="tUsername" runat="server" Width="110px"></asp:TextBox>
                                </td>
                        </tr>
                        <tr>
                            <td align="left" style="width: 115px; height: 18px;">
                                Password</td>
                            <td align="left" colspan="2" style="width: 462px; height: 18px;">
                                <asp:TextBox ID="tPassword" runat="server" Width="111px" TextMode="Password"></asp:TextBox>
                                <br />
                                <asp:Label ID="lErrPassword" runat="server" Text="This login doesnot exist" Width="156px" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 115px; height: 48px; background-color: #000000;">
                                <asp:ImageButton ID="ImageButton1" runat="server" Height="54px" ImageUrl="~/images/signin.jpg"
                                   Width="84px" OnClick="ImageButton1_Click1" /></td>
                            <td style="width: 115px; height: 48px; background-color: #000000">
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl ="~/forgot.aspx" ForeColor="White" Width="137px">Forgot Password?</asp:HyperLink><br />
                                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/membership.aspx" ForeColor="White">Free Sign Up</asp:HyperLink></td>
                            &nbsp;&nbsp;&nbsp; &nbsp; SELECT YOUR TYPE</tr>
                    </table>
                    </td>
            </tr>
            <tr>
                <td colspan="6" style="height: 34px">
                </td>
            </tr>
        </table>
    
    </div>
        <table style="width: 1249px; background-color: # ">
            <tr>
                <td align="left" colspan="7" style="color: #cc0000; height: 9px; background-color: red">
                    <br />
                </td>
            </tr>
            <tr>
                <td align="left" colspan="3" style="color: #cc0000; height: 129px; background-color:  Transparent ">
                    &nbsp;<asp:Label ID="Label1" runat="server" Font-Size="X-Large" ForeColor="DarkRed" Text="NEWSPAPER"
                        Width="95px"></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:Label ID="Label2" runat="server" ForeColor="Black" Text="Editions"></asp:Label>
                    <br />
                    <hr style="color: #ff0000" />
                    </td>
                <td colspan="2" style="height: 129px">
                    <asp:Label ID="Label3" runat="server" ForeColor="DarkRed" Text="WE" Font-Size="X-Large"></asp:Label>
                    <asp:Label
                        ID="Label4" runat="server" ForeColor="Black" Text="Accept"></asp:Label><br />
                    <hr style="color: red" />
                    </td>
                <td align="left" colspan="2" style="height: 129px">
                    <asp:Label ID="Label5" runat="server" ForeColor="DarkRed" Text="BENEFITS" Font-Size="X-Large"></asp:Label>
                    <asp:Label ID="Label6" runat="server" ForeColor="Black" Text="Advertisement India"></asp:Label><br /><hr style="width: 473px; color: red" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="width: 97px; height: 126px">
                    <asp:Image ID="Image7" runat="server" Height="202px" ImageUrl="~/images/29pakistan.slide.9.jpg"
                        Width="158px" /></td>
                <td style="width: 1807079px; height: 126px;">
                    We provide <b>online booking of Ads</b>
                    in following Newspapers<br />
                    <ul>
                        <li>The Times Of India</li>
                        <li>Hindustan Times</li>
                        <li>Indian Express</li>
                        <li>The Hindu</li>
                        <li>Dainik Jagarn&nbsp;</li>
                    </ul>
                    <p>
                        <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" ForeColor="Red" NavigateUrl ="~/newspaper.aspx">Read  More</asp:HyperLink>&nbsp;</p>
                </td>
                <td style="height: 126px; background-color:  Transparent ;">
                    <asp:Image ID="Image9" runat="server" Height="197px" ImageUrl="~/images/Benefits.jpg"
                        Width="184px" /></td>
                <td style="width: 37260px; height: 126px;">
                    <table align="right" border="0" cellpadding="1" cellspacing="1" class="Verdana10" style="width: 100%">
                        <tr>
                            <td colspan="2" rowspan="13" style="width: 230px; height: 200px;">
                                    <p>
                                        &nbsp;</p>
                                <ul>
                                    <li>Classifieds Ads </li>
                                    <li>Matrimonial Ads</li>
                                    <li>Recuritment Ads&nbsp;</li><li>Property Ads&nbsp;</li><li>Vehicle Ads</li>
                                    <li>Other Ads</li>
                                </ul>
                                    <p>
                                        &nbsp;<asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" Font-Underline="True"
                                            ForeColor="Red" NavigateUrl="~/contact us.aspx">Contact Detail</asp:HyperLink></p>
                            </td>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                    </table>
                </td>
                <td style="width: 163px; height: 126px; background-color:  Transparent ">
                    <asp:Image ID="Image11" runat="server" Height="202px" ImageUrl="~/images/Social-and-Financial-Benefits-of-Branding.jpg"
                        Width="186px" /></td>
                <td style="width: 722px; height: 126px">
                    
                        <table align="right" border="0" cellpadding="1" cellspacing="1" class="Verdana10" style="width: 98%">
                            <tr>
                                <td colspan="2" rowspan="13" style="width: 436px; height: 135px">
                                        <p>
                                            &nbsp;</p>
                                    <ul>
                                        <li>Easy to Place Ad </li>
                                        <li>Media Planning</li>
                                        <li>Single Window e-booking</li>
                                        <li>Area wise reach of all leading Newspapers</li>
                                        <li>Advertising in your budget</li>
                                        <li>Wide variety of Newspapers</li>
                                    </ul>
                                    <p>
                                        <asp:HyperLink ID="HyperLink5" runat="server" Font-Bold="True" Font-Underline="True"
                                            ForeColor="Red" NavigateUrl="~/contact us.aspx">Contact Detail</asp:HyperLink>&nbsp;</p>
                                </td>
                            </tr>
                            <tr>
                            </tr>
                            <tr>
                            </tr>
                            <tr>
                            </tr>
                            <tr>
                            </tr>
                            <tr>
                            </tr>
                            <tr>
                            </tr>
                            <tr>
                            </tr>
                            <tr>
                            </tr>
                            <tr>
                            </tr>
                            <tr>
                            </tr>
                            <tr>
                            </tr>
                            <tr>
                            </tr>
                        </table>
                  
                </td>
            </tr>
            <tr>
                <td align="left" colspan="3" style="height: 62px">
                    <asp:Label ID="Label7" runat="server" Font-Size="X-Large" ForeColor="DarkRed" Text="ADVERTISEMENT"
                        Width="95px"></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="Label8" runat="server" ForeColor="Black" Text="Tips"></asp:Label>
                    <hr style="color: #ff0033" />
                </td>
                <td colspan="2" style="height: 62px">
                    <asp:Label ID="Label9" runat="server" Font-Size="X-Large" ForeColor="DarkRed" Text="FAQ"></asp:Label>
                    <asp:Label ID="Label10" runat="server" ForeColor="Black" Text="Users"></asp:Label><br />
                    <hr style="color: red" />
                    </td>
                <td colspan="2" style="height: 62px">
                    <asp:Label ID="Label11" runat="server" Font-Size="X-Large" ForeColor="Maroon" Text="FEEDBACK"></asp:Label>
                    <asp:Label ID="Label12" runat="server" ForeColor="Black" Text="Users"></asp:Label><br />
                    <hr style="width: 473px; color: red" />
                    </td>
            </tr>
            <tr>
                <td colspan="1" style="height: 229px; width: 72px; background-color: transparent;">
                    <asp:Image ID="Image8" runat="server" Height="201px" ImageUrl="~/images/spiral-notebook-paper-pad-pen-and-glasses-on-a-desk.jpg" Width="154px" /></td>
                <td colspan="2" style="width: 97px; height: 229px;">
                    DON'T Know how to write Advertisement? Need help...<br />
                    Here we complied a list of DO's and DON'Ts, so that you get maximum leverage
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLink6" runat="server" Font-Bold="True" ForeColor="Red" NavigateUrl="~/help.aspx">Read  More</asp:HyperLink></td>
                <td style="height: 229px">
                    <asp:Image ID="Image10" runat="server" Height="202px" ImageUrl="~/images/Faq2.jpg"
                        Width="186px" /></td>
                <td style="width: 37260px; height: 229px;">
                    <table border="0" cellpadding="0" cellspacing="0" class="Verdana10" style="width: 208px;
                        height: 174px">
                        <tr>
                            <td rowspan="3" valign="top">
                                <table border="0" cellpadding="0" cellspacing="0" class="Verdana10" width="100%">
                                    <tr valign="top">
                                        <td colspan="2">
                                            <b style="color: #000000">Are you looknig for help while placing online Ads?</b></td>
                                    </tr>
                                </table>
                                Read our advertisement help
                                section to get immediate answers to the most common queries posted by the users
                                while placing advertisements in newspapers and magazines of India.<br />
                                <br />
                                <asp:HyperLink ID="HyperLink7" runat="server" Font-Bold="True" ForeColor="Red" NavigateUrl="~/faq.aspx">Read  More</asp:HyperLink></td>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                    </table>
                </td>
                <td style="width: 163px; height: 229px;">
                    <asp:Image ID="Image12" runat="server" Height="197px" ImageUrl="~/images/feedback.gif"
                        Width="188px" /></td>
                <td style="width: 722px; height: 229px;">
                    <strong><span style="text-decoration: underline">CUSTOMER FEEDBACK</span></strong><br />
                    <br />
                    It is really very nice to see such a great, user-friendly &amp; service oriented
                    site.
                    <br />
                    I wish that in future you will keep moving &amp; strengthen your efforts to enlighten
                    the city "Lucknow" in Advertis<br />
                    <b>Vivek Singh<br />
                        <br />
                        <asp:HyperLink ID="HyperLink8" runat="server" ForeColor="Red" NavigateUrl ="~/feedback.aspx">Post Your Feedback</asp:HyperLink></b></td>
            </tr>
        </table>
        <table style="width: 1250px">
            <tr>
                <td colspan="3" style="height: 26px; background-color:  Transparent ">
                </td>
            </tr>
            <tr>
                <td colspan="3" style="background-color: #ff3300; height: 28px;">
                </td>
            </tr>
            <tr>
                <td align="center" colspan="3" style="height: 40px">
                    © 2011 IndianAdvertisement.com<br />
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                        SelectCommand="SELECT [password], [loginid] FROM [membership]" ></asp:SqlDataSource>
                    </td>
            </tr>
            <tr>
                <td colspan="3" style="background-color: #ff3300; height: 29px;">
                </td>
            </tr>
        </table>
    </form>
    
</body>
</html>
