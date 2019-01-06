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
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        int n=0;
        string driverstr;
        driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con = new SqlConnection(driverstr);
        con.Open();
        string s = "select name,pno,address,city,state from membership where loginid='" + TextBox1.Text + "'";
        SqlCommand cmd = new SqlCommand(s, con);
        SqlDataReader rs = cmd.ExecuteReader();
        while (rs.Read())
            {
                TextBox2.Text = rs.GetString(0);
                TextBox3.Text = rs.GetString(1);
                TextBox4.Text = rs.GetString(2);
                TextBox5.Text = rs.GetString(3);
                TextBox6.Text = rs.GetString(4);
            n=1;
        }
        if(n ==0)
        {
            Label2.Visible = true;
        }
        }
    

    protected void Button1_Click(object sender, EventArgs e)
    { 
       Label1 .Visible =true ;
       Button1 .Visible =false ;
       Button2 .Visible =true ;
       Button3 .Visible =true;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("c_home.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string driverstr;
        driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con = new SqlConnection(driverstr);
        con.Open();
        string s = "delete from membership where loginid='" + TextBox1.Text + "'";
        SqlCommand cmd = new SqlCommand(s, con);
        SqlDataReader rs = cmd.ExecuteReader();
            Label3.Visible = true;
            Label1.Visible = false;
            Label2.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            Label6.Visible = false;
            Label7.Visible = false;
            Label8.Visible = false;
            Label9.Visible = false;
            Button2.Visible = false;
            Button1.Visible = false;
            Button3.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            Session["User"] = " ";
       }
}
