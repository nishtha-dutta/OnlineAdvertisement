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

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        Label2.Text = " ";
        Label2.Visible = false;
        Label3.Visible = false;
        Label3.Text = " ";
        TextBox1.Visible = false;
        Label1.Text = "Let us assure you are not alone, every single person who places an advertisement faces the same question. As a customer friendly organization, we believe in helping our customers and readers to learn how to write an effective advertisement. We have gathered some information and presented it below in easy to understand manner. We would also like to remind you that if you wish to place your advertisement with us we would be more than happy to provide you with free consultation about advertisement services.";
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Label2.Visible = true;
        Label1.Visible = false;
        Label1.Text = " ";
        Label3.Visible = false;
        Label3.Text = " ";
        TextBox1.Visible = false;
        Label2.Text = "Following are the ingredients of any good classified ad -1) Attention 2) Interest 3) Desire 4) Action";
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label1.Text = " ";
        Label2.Text = " ";
        Label2.Visible = false;
        Label3.Visible = true;
        Label3.Text = " Please remember to provide the following information in your advertisements to make it most effective:";
        TextBox1.Visible = true;
    }
}
