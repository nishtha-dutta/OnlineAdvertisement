<%@ Page Language="C#" AutoEventWireup="true" CodeFile="error.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span style="font-size: 24pt; color: #990000"><strong style="background-color: transparent">
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp;&nbsp; oop's your seesion has been expired.<br />
            <br />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" ForeColor="Maroon"
                OnClick="LinkButton1_Click">Click here to login again</asp:LinkButton><br />
            <br />
            <br />
        </strong></span>
    
    </div>
    </form>
</body>
</html>
