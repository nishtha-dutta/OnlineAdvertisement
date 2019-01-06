using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("member_detail.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("newspaper.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("booked.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("r_feedback.aspx");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == " ")
        {
            Response.Redirect("error.aspx");
        }
    }
}
