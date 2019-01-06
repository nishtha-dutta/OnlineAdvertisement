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
using System.Data.SqlClient ;

public partial class Default8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == " ")
        {
            Response.Redirect("error.aspx");
        }
        Label2.Visible = false;
        Label4.Visible = false;
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        int n1=0;
        string driverstr;
        driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con = new SqlConnection(driverstr);
        con.Open();
        string st=TextBox3.Text;
        string s = "select sans,password from membership";
        SqlCommand cmd = new SqlCommand(s,con);
        SqlDataReader rs = cmd.ExecuteReader();
        while (rs.Read())
        {

            if (rs.GetString(0).Equals(st))
            {
                string n = rs.GetString(1);
                Label1.Text = n;
                Label4.Visible = true;
                Label1.Visible = true;
                n1 = 1;
            }
            else
            {
                Label2.Text = "invalid answer";
                Label2.Visible = true;
            }
            if (n1 == 1)
            {
                Label2.Visible = false;
            }
            TextBox1.ReadOnly =true ;
            TextBox3.ReadOnly = true;
            ImageButton1.Visible = false;
        }

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        string driverstr;
        driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con = new SqlConnection(driverstr);
        con.Open();
        string st = TextBox1.Text;
        string s = "select sques from membership where loginid='"+st+"'";
        SqlCommand cmd = new SqlCommand(s, con);
        SqlDataReader rs = cmd.ExecuteReader();
        if (rs.Read())
        {
            string n = rs.GetString(0);
            Label3.Visible = true;
            Label3.Text = n;
            TextBox3.Focus() ;
        }
    }
}
