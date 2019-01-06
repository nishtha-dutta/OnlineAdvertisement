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

public partial class Default4 : System.Web.UI.Page
{
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string s;
        s = DropDownList1.SelectedItem.ToString();
        DropDownList2.Items.Clear();
        if (s == "UP")
        {
            DropDownList2.Items.Add("Lucknow");
            DropDownList2.Items.Add("Allahabad");
            DropDownList2.Items.Add("Kanpur");
            DropDownList2.Items.Add("Noida");
            DropDownList2.Items.Add("Meerut");
            DropDownList2.Items.Add("Agra");
            DropDownList2.Items.Add("Bareily");
            DropDownList2.Items.Add("Dehradun");
            DropDownList2.Items.Add("Aligarh");
            DropDownList2.Items.Add("Ghaziabad");
        }
        if (s == "MP")
        {
            DropDownList2.Items.Add("Bhopal");
            DropDownList2.Items.Add("Rewah");
            DropDownList2.Items.Add("Jabalpur");
            DropDownList2.Items.Add("Indore");
            DropDownList2.Items.Add("Bilaspur");
            DropDownList2.Items.Add("Raipur");
            DropDownList2.Items.Add("Bina");
            DropDownList2.Items.Add("Itarsi");
            DropDownList2.Items.Add("Katni");
        }
        if (s == "Maharashtra")
        {
            DropDownList2.Items.Add("Mumbai");
            DropDownList2.Items.Add("pune");
            DropDownList2.Items.Add("Nagpur");
            DropDownList2.Items.Add("Solapur");
            DropDownList2.Items.Add("Kholapur");
            DropDownList2.Items.Add("Ratnagiri");
        }
        if (s == "Karnataka")
        {
            DropDownList2.Items.Add("Banglore");
            DropDownList2.Items.Add("Mysore");
            DropDownList2.Items.Add("Hubli");
            DropDownList2.Items.Add("Shimoga");
            DropDownList2.Items.Add("Mangalore");
        }
        if (s == "Bihar")
        {
            DropDownList2.Items.Add("Patna");
            DropDownList2.Items.Add("Gaya");
            DropDownList2.Items.Add("Ranchi");
            DropDownList2.Items.Add("Bhagalpur");
            DropDownList2.Items.Add("Muzaffarpur");
            DropDownList2.Items.Add("Bettiah");
            DropDownList2.Items.Add("Darbhanga");
        }
        if (s == "TamilNadu")
        {
            DropDownList2.Items.Add("Chennai");
            DropDownList2.Items.Add("Kancheepuram");
            DropDownList2.Items.Add("Krishnagiri");
            DropDownList2.Items.Add("Madurai");
            DropDownList2.Items.Add("Nagercoil");
            DropDownList2.Items.Add("Namakkal");
            DropDownList2.Items.Add("Vellore");
        }
        if (s == "Orissa")
        {
            DropDownList2.Items.Add("Bhubaneswar");
            DropDownList2.Items.Add("Cuttack");
            DropDownList2.Items.Add("Raurkela");
            DropDownList2.Items.Add("Berhampur");
            DropDownList2.Items.Add("Puri");
            DropDownList2.Items.Add("Sambalpur");
        }
        if (s == "Andhra Pradesh")
        {
            DropDownList2.Items.Add("Hyderabad");
            DropDownList2.Items.Add("Secunderabad");
            DropDownList2.Items.Add("Vishakhapatnam");
            DropDownList2.Items.Add("Nellore");
        }
        if (s == "Kerala")
        {
            DropDownList2.Items.Add("Thiruvananthapuram");
            DropDownList2.Items.Add("Kottayam");
            DropDownList2.Items.Add("Kozhikodu");
            DropDownList2.Items.Add("Ernakulam");
            DropDownList2.Items.Add("Palakkad");
        }
        if (s == "Assam")
        {
            DropDownList2.Items.Add("Dispur");
            DropDownList2.Items.Add("Guwahati");
            DropDownList2.Items.Add("Dibrugarh");
        }
        if (s == "Arunachal Pradesh")
        {
            DropDownList2.Items.Add("Itanagar");
        }
        if (s == "Gujarat")
        {
            DropDownList2.Items.Add("Gandhinagar");
            DropDownList2.Items.Add("Ahmedabad");
            DropDownList2.Items.Add("Rajkot");
            DropDownList2.Items.Add("Surat");
            DropDownList2.Items.Add("Vadodara");
            DropDownList2.Items.Add("Dul");
        }
        if (s == "Rajasthan")
        {
            DropDownList2.Items.Add("Jaipur");
            DropDownList2.Items.Add("Ajmer");
            DropDownList2.Items.Add("Jodhpur");
            DropDownList2.Items.Add("Kota");
            DropDownList2.Items.Add("Bikaner");
            DropDownList2.Items.Add("Udaipur");
        }
        if (s == "Delhi")
        {
            DropDownList2.Items.Add("Delhi");
            DropDownList2.Items.Add("New Delhi");
        }
        if (s == "Himachal Pradesh")
        {
            DropDownList2.Items.Add("Shimla");
            DropDownList2.Items.Add("Chamba");
        }
        if (s == "Jammu And Kashmir")
        {
            DropDownList2.Items.Add("Shinagar");
            DropDownList2.Items.Add("Jammu");
            DropDownList2.Items.Add("Rawalpindi");
            DropDownList2.Items.Add("Gulmarg");
        }
        if (s == "Punjab")
        {
            DropDownList2.Items.Add("Chandigard");
            DropDownList2.Items.Add("Amritsar");
            DropDownList2.Items.Add("Jalandar");
            DropDownList2.Items.Add("Patiala");
        }
        if (s == "Haryana")
        {
            DropDownList2.Items.Add("Ambala");
            DropDownList2.Items.Add("Faidabad");
            DropDownList2.Items.Add("Hissar");
            DropDownList2.Items.Add("Bahadurgard");
            DropDownList2.Items.Add("Kurukshetra");
            DropDownList2.Items.Add("Sonipat");
        }
        if (s == "West Bangal")
        {
            DropDownList2.Items.Add("Kolkata");
            DropDownList2.Items.Add("Siliguri");
            DropDownList2.Items.Add("Durgapur");
        }
        if (s == "Jharkhand")
        {
            DropDownList2.Items.Add("Ranchi");
            DropDownList2.Items.Add("Jamshedpur");
            DropDownList2.Items.Add("Hazaribagh");
            DropDownList2.Items.Add("Giridih");
            DropDownList2.Items.Add("Dhanbad");
            DropDownList2.Items.Add("Bokaro Steel City");
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        string driverstr;
        driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con = new SqlConnection(driverstr);
        con.Open();
        string n = TextBox1.Text;
        string n1 = TextBox2.Text;
        string n2 = TextBox3.Text;
        string n4 = TextBox10.Text;
        string n5 = TextBox11.Text;
        string n6 = TextBox5.Text;
        string n7 = TextBox6.Text;
        string n8 = DropDownList1.SelectedItem.ToString ();
        string n9 = DropDownList2.SelectedItem.ToString ();
        string s = "insert into membership values('" + n + "','" + n1 + "','" + n2 + "','" + n4 + "','" + n5 + "'," + n6 + ",'" + n7 + "','" + n9 + "','" + n8 + "')";
        SqlCommand cmd = new SqlCommand(s, con);
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            ImageButton1.Visible = false;
            Label1.Text = "record inserted sucessfully";
            Label1.Visible = true;
            TextBox1.ReadOnly = true;
            TextBox2.ReadOnly = true;
            TextBox3.ReadOnly = true;
            TextBox4.ReadOnly = true;
            TextBox5.ReadOnly = true;
            TextBox6.ReadOnly = true;
            TextBox10.ReadOnly = true;
            TextBox11.ReadOnly = true;
            DropDownList2.Enabled = false;
            DropDownList1.Enabled = false;
            RequiredFieldValidator1.Enabled = false;
            RequiredFieldValidator2.Enabled = false;
            RequiredFieldValidator3.Enabled = false;
            RequiredFieldValidator4.Enabled = false;
            RequiredFieldValidator5.Enabled = false;
            RequiredFieldValidator6.Enabled = false;
            RequiredFieldValidator7.Enabled = false;
            RequiredFieldValidator8.Enabled = false;
            RegularExpressionValidator1.Enabled = false;
            RegularExpressionValidator2.Enabled = false;
            CompareValidator1.Enabled = false;
        }
        
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        string driverstr;
        driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con = new SqlConnection(driverstr);
        con.Open();
        string s = "select loginid from membership";
        SqlCommand cmd = new SqlCommand(s,con);
        SqlDataReader rs = cmd.ExecuteReader();
        string st=TextBox2 .Text ;
        while (rs.Read())
        {
            if (rs.GetString(0).Equals(st))
            {
                Label2.Visible = true;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == " ")
        {
            Response.Redirect("error.aspx");
        }
    }
}
