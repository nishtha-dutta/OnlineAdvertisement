<%@ Page Language="C#" AutoEventWireup="true" CodeFile="logout.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 931px; height: 323px">
            <tr>
                <td style="width: 290px">
                </td>
                <td style="width: 342px">
                    <span style="font-size: 24pt">&nbsp; <span style="color: #cc0000">You are now logged
                        out</span></span></td>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Underline="True"
                        ForeColor="Red" OnClick="LinkButton1_Click">Click to login again</asp:LinkButton></td>
            </tr>
            <tr>
                <td style="width: 290px" align="right">
                    <asp:Image ID="Image1" runat="server" Width="105px" Height="138px" ImageUrl="~/images/image.gif" /></td>
                <td style="width: 342px; text-align: center">
                    <span style="font-size: 16pt; color: #cc0000"><strong>A project by:<br />
                    </strong></span><span style="font-size: 14pt; color: #ff0000">NISHTHA DUTTA<br />
                        SUNITA YADAV<br />
                        DILIP KUMAR<br />
                        YADAV JAI SINGH</span></td>
                <td>
                    <asp:Image ID="Image2" runat="server" Height="133px" Width="110px" ImageUrl="~/images/image1.gif" /></td>
            </tr>
            <tr>
                <td style="width: 290px">
                </td>
                <td style="width: 342px">
                </td>
                <td>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
