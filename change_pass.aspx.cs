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
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == " ")
        {
            Response.Redirect ("error.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("c_home.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = " ";
        TextBox2.Text = " ";
        TextBox3.Text = " ";
        TextBox4.Text = " ";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string driverstr;
        driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con = new SqlConnection(driverstr);
        con.Open();
        string s = "update membership set password='" + TextBox3.Text + "' where loginid='" + TextBox1.Text + "' and password='"+TextBox2 .Text+"'";
        SqlCommand cmd = new SqlCommand(s, con);
        int n = cmd.ExecuteNonQuery();
        if (n == 1)
        {
            Label1.Text = "Your password has been changed";
            Label1.Visible = true;
            Button1.Visible = false;
            Button2.Visible = false;
            Button3.Visible = false;
            TextBox1.ReadOnly = true;
            TextBox2.ReadOnly = true;
            TextBox3.ReadOnly = true;
            TextBox4.ReadOnly = true;
        }
    }
}
