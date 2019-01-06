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
            Response.Redirect("error.aspx");
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {        
            string driverstr;
        driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con = new SqlConnection(driverstr);
        con.Open();
        string s = "update membership set name='" + TextBox2.Text + "',address='" + TextBox3.Text + "',pno='" + TextBox4.Text + "',sques='" + TextBox5.Text + "',sans='" + TextBox6.Text + "',state='" + TextBox7.Text + "',city='" + TextBox8.Text + "' where loginid='" + TextBox1.Text + "'";
        SqlCommand cmd = new SqlCommand(s, con);
        int n=cmd.ExecuteNonQuery  ();
        if (n == 1)
        {
            Label10.Visible = true;
            ImageButton1.Visible = false;
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        int n=0;
        string driverstr;
        driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con = new SqlConnection(driverstr);
        con.Open();
        string st = TextBox1.Text;
        string s = "select loginid,name,address,pno,sques,sans,state,city from membership";
        SqlCommand cmd = new SqlCommand(s, con);
        SqlData
                n = 0;
                Label2.VisiReader rs = cmd.ExecuteReader();
        while (rs.Read())
        {
            if (rs.GetString(0).Equals(st))
            {ble = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                ImageButton1.Visible = true;
                TextBox2.Text = rs.GetString(1);
                TextBox3.Text = rs.GetString(2);
                TextBox4.Text = rs.GetString(3);
                TextBox5.Text = rs.GetString(4);
                TextBox6.Text = rs.GetString(5);
                TextBox7.Text = rs.GetString(6);
                TextBox8.Text = rs.GetString(7);
            }
            else
            {
                n  = 1;
            }
            if (n == 1)
            {
                Label9.Visible = false ;
            }
            else
            {
                Label9.Visible = true ;
            }
        }
    }
}
