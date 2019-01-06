using System;
using System.Data;
using System.Configuration;
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
        lErrPassword.Visible = false;
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        if (RadioButton1.Checked == true)
        {
            string st = "admin123";
            if (tUsername.Text == st && tPassword.Text == "123")
                  {
                      Session["User"] = "admin123";    
                      Response.Redirect("admin.aspx");
                  }
            else
            {
                lErrPassword.Visible = true;
            }
        }
        if (RadioButton2 .Checked == true)
          {
            string  cnt=" ";
            string driverstr;
            driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
            SqlConnection con = new SqlConnection(driverstr);
            con.Open();
            string st = tUsername.Text;
            string s = "select password from membership where loginid ='" + st + "'";
            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader rs = cmd.ExecuteReader();
            rs.Read();        
            cnt = rs.GetString(0);
                if (cnt.Equals(tPassword.Text.Trim()))
                {
                    Session["User"] = tUsername.Text;
                    Response.Redirect("c_home.aspx");
                }
                else
                {
                    lErrPassword.Visible = true;
                }
          }     
    }
}
