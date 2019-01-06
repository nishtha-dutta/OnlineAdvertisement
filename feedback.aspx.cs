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

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string driverstr;
        driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection  con = new SqlConnection(driverstr);
        con.Open();
        string n = TextBox1.Text;
        string n2 = TextBox2.Text;
        string n1 = DropDownList1.SelectedItem.ToString();
        string s = "insert into feedback values('" + n + "','" + n1 + "','" + n2 + "')";
        SqlCommand cmd = new SqlCommand(s, con);
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            ImageButton1.Visible = false;
            Label1.Visible = true;
            TextBox1.ReadOnly = true;
            TextBox2.ReadOnly = true;
            DropDownList1.Enabled = false;
        }
    }
}
