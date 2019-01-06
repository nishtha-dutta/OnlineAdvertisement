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

public partial class Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == " ")
        {
            Response.Redirect ("error.aspx");
        }
    }
    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        string s, st;
        s = DropDownList2.SelectedItem.ToString();
        st = DropDownList3.SelectedItem.ToString();
        int n = int.Parse(st);
        DropDownList1.Items.Clear();
        if (s == "jan")
        {
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList1.Items.Add("4");
            DropDownList1.Items.Add("5");
            DropDownList1.Items.Add("6");
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("8");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("10");
            DropDownList1.Items.Add("11");
            DropDownList1.Items.Add("12");
            DropDownList1.Items.Add("13");
            DropDownList1.Items.Add("14");
            DropDownList1.Items.Add("15");
            DropDownList1.Items.Add("16");
            DropDownList1.Items.Add("17");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("19");
            DropDownList1.Items.Add("20");
            DropDownList1.Items.Add("21");
            DropDownList1.Items.Add("22");
            DropDownList1.Items.Add("23");
            DropDownList1.Items.Add("24");
            DropDownList1.Items.Add("25");
            DropDownList1.Items.Add("26");
            DropDownList1.Items.Add("27");
            DropDownList1.Items.Add("28");
            DropDownList1.Items.Add("29");
            DropDownList1.Items.Add("30");
            DropDownList1.Items.Add("31");
        }
        if (s == "feb")
        {
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList1.Items.Add("4");
            DropDownList1.Items.Add("5");
            DropDownList1.Items.Add("6");
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("8");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("10");
            DropDownList1.Items.Add("11");
            DropDownList1.Items.Add("12");
            DropDownList1.Items.Add("13");
            DropDownList1.Items.Add("14");
            DropDownList1.Items.Add("15");
            DropDownList1.Items.Add("16");
            DropDownList1.Items.Add("17");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("19");
            DropDownList1.Items.Add("20");
            DropDownList1.Items.Add("21");
            DropDownList1.Items.Add("22");
            DropDownList1.Items.Add("23");
            DropDownList1.Items.Add("24");
            DropDownList1.Items.Add("25");
            DropDownList1.Items.Add("26");
            DropDownList1.Items.Add("27");
            DropDownList1.Items.Add("28");
        }
        if (s == "mar")
        {
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList1.Items.Add("4");
            DropDownList1.Items.Add("5");
            DropDownList1.Items.Add("6");
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("8");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("10");
            DropDownList1.Items.Add("11");
            DropDownList1.Items.Add("12");
            DropDownList1.Items.Add("13");
            DropDownList1.Items.Add("14");
            DropDownList1.Items.Add("15");
            DropDownList1.Items.Add("16");
            DropDownList1.Items.Add("17");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("19");
            DropDownList1.Items.Add("20");
            DropDownList1.Items.Add("21");
            DropDownList1.Items.Add("22");
            DropDownList1.Items.Add("23");
            DropDownList1.Items.Add("24");
            DropDownList1.Items.Add("25");
            DropDownList1.Items.Add("26");
            DropDownList1.Items.Add("27");
            DropDownList1.Items.Add("28");
            DropDownList1.Items.Add("29");
            DropDownList1.Items.Add("30");
            DropDownList1.Items.Add("31");
        }
        if (s == "apr")
        {
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList1.Items.Add("4");
            DropDownList1.Items.Add("5");
            DropDownList1.Items.Add("6");
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("8");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("10");
            DropDownList1.Items.Add("11");
            DropDownList1.Items.Add("12");
            DropDownList1.Items.Add("13");
            DropDownList1.Items.Add("14");
            DropDownList1.Items.Add("15");
            DropDownList1.Items.Add("16");
            DropDownList1.Items.Add("17");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("19");
            DropDownList1.Items.Add("20");
            DropDownList1.Items.Add("21");
            DropDownList1.Items.Add("22");
            DropDownList1.Items.Add("23");
            DropDownList1.Items.Add("24");
            DropDownList1.Items.Add("25");
            DropDownList1.Items.Add("26");
            DropDownList1.Items.Add("27");
            DropDownList1.Items.Add("28");
            DropDownList1.Items.Add("29");
            DropDownList1.Items.Add("30");
        }
        if (s == "may")
        {
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList1.Items.Add("4");
            DropDownList1.Items.Add("5");
            DropDownList1.Items.Add("6");
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("8");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("10");
            DropDownList1.Items.Add("11");
            DropDownList1.Items.Add("12");
            DropDownList1.Items.Add("13");
            DropDownList1.Items.Add("14");
            DropDownList1.Items.Add("15");
            DropDownList1.Items.Add("16");
            DropDownList1.Items.Add("17");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("19");
            DropDownList1.Items.Add("20");
            DropDownList1.Items.Add("21");
            DropDownList1.Items.Add("22");
            DropDownList1.Items.Add("23");
            DropDownList1.Items.Add("24");
            DropDownList1.Items.Add("25");
            DropDownList1.Items.Add("26");
            DropDownList1.Items.Add("27");
            DropDownList1.Items.Add("28");
            DropDownList1.Items.Add("29");
            DropDownList1.Items.Add("30");
            DropDownList1.Items.Add("31");
        }
        if (s == "jun")
        {
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList1.Items.Add("4");
            DropDownList1.Items.Add("5");
            DropDownList1.Items.Add("6");
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("8");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("10");
            DropDownList1.Items.Add("11");
            DropDownList1.Items.Add("12");
            DropDownList1.Items.Add("13");
            DropDownList1.Items.Add("14");
            DropDownList1.Items.Add("15");
            DropDownList1.Items.Add("16");
            DropDownList1.Items.Add("17");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("19");
            DropDownList1.Items.Add("20");
            DropDownList1.Items.Add("21");
            DropDownList1.Items.Add("22");
            DropDownList1.Items.Add("23");
            DropDownList1.Items.Add("24");
            DropDownList1.Items.Add("25");
            DropDownList1.Items.Add("26");
            DropDownList1.Items.Add("27");
            DropDownList1.Items.Add("28");
            DropDownList1.Items.Add("29");
            DropDownList1.Items.Add("30");
        }
        if (s == "jul")
        {
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList1.Items.Add("4");
            DropDownList1.Items.Add("5");
            DropDownList1.Items.Add("6");
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("8");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("10");
            DropDownList1.Items.Add("11");
            DropDownList1.Items.Add("12");
            DropDownList1.Items.Add("13");
            DropDownList1.Items.Add("14");
            DropDownList1.Items.Add("15");
            DropDownList1.Items.Add("16");
            DropDownList1.Items.Add("17");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("19");
            DropDownList1.Items.Add("20");
            DropDownList1.Items.Add("21");
            DropDownList1.Items.Add("22");
            DropDownList1.Items.Add("23");
            DropDownList1.Items.Add("24");
            DropDownList1.Items.Add("25");
            DropDownList1.Items.Add("26");
            DropDownList1.Items.Add("27");
            DropDownList1.Items.Add("28");
            DropDownList1.Items.Add("29");
            DropDownList1.Items.Add("30");
            DropDownList1.Items.Add("31");
        }
        if (s == "aug")
        {
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList1.Items.Add("4");
            DropDownList1.Items.Add("5");
            DropDownList1.Items.Add("6");
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("8");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("10");
            DropDownList1.Items.Add("11");
            DropDownList1.Items.Add("12");
            DropDownList1.Items.Add("13");
            DropDownList1.Items.Add("14");
            DropDownList1.Items.Add("15");
            DropDownList1.Items.Add("16");
            DropDownList1.Items.Add("17");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("19");
            DropDownList1.Items.Add("20");
            DropDownList1.Items.Add("21");
            DropDownList1.Items.Add("22");
            DropDownList1.Items.Add("23");
            DropDownList1.Items.Add("24");
            DropDownList1.Items.Add("25");
            DropDownList1.Items.Add("26");
            DropDownList1.Items.Add("27");
            DropDownList1.Items.Add("28");
            DropDownList1.Items.Add("29");
            DropDownList1.Items.Add("30");
            DropDownList1.Items.Add("31");
        }
        if (s == "sep")
        {
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList1.Items.Add("4");
            DropDownList1.Items.Add("5");
            DropDownList1.Items.Add("6");
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("8");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("10");
            DropDownList1.Items.Add("11");
            DropDownList1.Items.Add("12");
            DropDownList1.Items.Add("13");
            DropDownList1.Items.Add("14");
            DropDownList1.Items.Add("15");
            DropDownList1.Items.Add("16");
            DropDownList1.Items.Add("17");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("19");
            DropDownList1.Items.Add("20");
            DropDownList1.Items.Add("21");
            DropDownList1.Items.Add("22");
            DropDownList1.Items.Add("23");
            DropDownList1.Items.Add("24");
            DropDownList1.Items.Add("25");
            DropDownList1.Items.Add("26");
            DropDownList1.Items.Add("27");
            DropDownList1.Items.Add("28");
            DropDownList1.Items.Add("29");
            DropDownList1.Items.Add("30");
        }
        if (s == "oct")
        {
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList1.Items.Add("4");
            DropDownList1.Items.Add("5");
            DropDownList1.Items.Add("6");
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("8");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("10");
            DropDownList1.Items.Add("11");
            DropDownList1.Items.Add("12");
            DropDownList1.Items.Add("13");
            DropDownList1.Items.Add("14");
            DropDownList1.Items.Add("15");
            DropDownList1.Items.Add("16");
            DropDownList1.Items.Add("17");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("19");
            DropDownList1.Items.Add("20");
            DropDownList1.Items.Add("21");
            DropDownList1.Items.Add("22");
            DropDownList1.Items.Add("23");
            DropDownList1.Items.Add("24");
            DropDownList1.Items.Add("25");
            DropDownList1.Items.Add("26");
            DropDownList1.Items.Add("27");
            DropDownList1.Items.Add("28");
            DropDownList1.Items.Add("29");
            DropDownList1.Items.Add("30");
            DropDownList1.Items.Add("31");
        }
        if (s == "nov")
        {
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList1.Items.Add("4");
            DropDownList1.Items.Add("5");
            DropDownList1.Items.Add("6");
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("8");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("10");
            DropDownList1.Items.Add("11");
            DropDownList1.Items.Add("12");
            DropDownList1.Items.Add("13");
            DropDownList1.Items.Add("14");
            DropDownList1.Items.Add("15");
            DropDownList1.Items.Add("16");
            DropDownList1.Items.Add("17");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("19");
            DropDownList1.Items.Add("20");
            DropDownList1.Items.Add("21");
            DropDownList1.Items.Add("22");
            DropDownList1.Items.Add("23");
            DropDownList1.Items.Add("24");
            DropDownList1.Items.Add("25");
            DropDownList1.Items.Add("26");
            DropDownList1.Items.Add("27");
            DropDownList1.Items.Add("28");
            DropDownList1.Items.Add("29");
            DropDownList1.Items.Add("30");
        }
        if (s == "dec")
        {
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList1.Items.Add("4");
            DropDownList1.Items.Add("5");
            DropDownList1.Items.Add("6");
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("8");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("10");
            DropDownList1.Items.Add("11");
            DropDownList1.Items.Add("12");
            DropDownList1.Items.Add("13");
            DropDownList1.Items.Add("14");
            DropDownList1.Items.Add("15");
            DropDownList1.Items.Add("16");
            DropDownList1.Items.Add("17");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("19");
            DropDownList1.Items.Add("20");
            DropDownList1.Items.Add("21");
            DropDownList1.Items.Add("22");
            DropDownList1.Items.Add("23");
            DropDownList1.Items.Add("24");
            DropDownList1.Items.Add("25");
            DropDownList1.Items.Add("26");
            DropDownList1.Items.Add("27");
            DropDownList1.Items.Add("28");
            DropDownList1.Items.Add("29");
            DropDownList1.Items.Add("30");
            DropDownList1.Items.Add("31");
        }

        if (n % 4 == 0)
        {
            if (s == "feb")
            {
                DropDownList1.Items.Clear();
                DropDownList1.Items.Add("1");
                DropDownList1.Items.Add("2");
                DropDownList1.Items.Add("3");
                DropDownList1.Items.Add("4");
                DropDownList1.Items.Add("5");
                DropDownList1.Items.Add("6");
                DropDownList1.Items.Add("7");
                DropDownList1.Items.Add("8");
                DropDownList1.Items.Add("9");
                DropDownList1.Items.Add("10");
                DropDownList1.Items.Add("11");
                DropDownList1.Items.Add("12");
                DropDownList1.Items.Add("13");
                DropDownList1.Items.Add("14");
                DropDownList1.Items.Add("15");
                DropDownList1.Items.Add("16");
                DropDownList1.Items.Add("17");
                DropDownList1.Items.Add("18");
                DropDownList1.Items.Add("19");
                DropDownList1.Items.Add("20");
                DropDownList1.Items.Add("21");
                DropDownList1.Items.Add("22");
                DropDownList1.Items.Add("23");
                DropDownList1.Items.Add("24");
                DropDownList1.Items.Add("25");
                DropDownList1.Items.Add("26");
                DropDownList1.Items.Add("27");
                DropDownList1.Items.Add("28");
                DropDownList1.Items.Add("29");
            }
        }
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        string s;
        s = DropDownList4.SelectedItem.ToString();
        if (s == "DD")
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            TextBox5.Visible = true;
            TextBox6.Visible = true;
            DropDownList8.Visible = true;
            DropDownList9.Visible = true;
            DropDownList12.Visible = true;
            TextBox8.Visible = true;
        }
        if (s == "Cash")
        {
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            DropDownList8.Visible =false ;
            DropDownList9.Visible = false ;
            DropDownList12.Visible = false ;
            TextBox8.Visible = false;
        }
        
    }
    protected void DropDownList10_SelectedIndexChanged(object sender, EventArgs e)
    {
        string s;
        s = DropDownList10.SelectedItem.ToString();
        DropDownList7.Items.Clear();
        if (s == "Hindi")
        {
            DropDownList7.Items.Add("amar ujala");
            DropDownList7.Items.Add("Dainik Bhaskar");
            DropDownList7.Items.Add("Dainik Jagran");
            DropDownList7.Items.Add("Dainik Tribune");
            DropDownList7.Items.Add("Hindustan");
            DropDownList7.Items.Add("I-Next");
            DropDownList7.Items.Add("Nai Dunia");
            DropDownList7.Items.Add("Nava Bharat");
            DropDownList7.Items.Add("Prabhat Khabar");
            DropDownList7.Items.Add("The Hindu");
            DropDownList7.Items.Add("The Hitavada");
            DropDownList7.Items.Add("The Hindu Business Line");
        }
        if (s == "English")
        {
            DropDownList7.Items.Add("Business Standard");
            DropDownList7.Items.Add("Deccan Herald");
            DropDownList7.Items.Add("Economic Times");
            DropDownList7.Items.Add("Hindustan Times");
            DropDownList7.Items.Add("Nav Bharat Times");
            DropDownList7.Items.Add("I-Next");
            DropDownList7.Items.Add("The Pioneer");
            DropDownList7.Items.Add("The Hindu Business Line");
            DropDownList7.Items.Add("The New Indian Express");
            DropDownList7.Items.Add("The Times Of India");
            DropDownList7.Items.Add("The Hitavada");
            DropDownList7.Items.Add("The Hindu Business Line");
        }
        if (s == "All")
        {
            DropDownList7.Items.Add("amar ujala");
            DropDownList7.Items.Add("Dainik Bhaskar");
            DropDownList7.Items.Add("Dainik Jagran");
            DropDownList7.Items.Add("Dainik Tribune");
            DropDownList7.Items.Add("Hindustan");
            DropDownList7.Items.Add("I-Next");
            DropDownList7.Items.Add("Nai Dunia");
            DropDownList7.Items.Add("Nava Bharat");
            DropDownList7.Items.Add("Prabhat Khabar");
            DropDownList7.Items.Add("The Hindu");
            DropDownList7.Items.Add("The Hitavada");
            DropDownList7.Items.Add("The Hindu Business Line");
            DropDownList7.Items.Add("Business Standard");
            DropDownList7.Items.Add("Deccan Herald");
            DropDownList7.Items.Add("Economic Times");
            DropDownList7.Items.Add("Hindustan Times");
            DropDownList7.Items.Add("Nav Bharat Times");
            DropDownList7.Items.Add("I-Next");
            DropDownList7.Items.Add("The Pioneer");
            DropDownList7.Items.Add("The Hindu Business Line");
            DropDownList7.Items.Add("The New Indian Express");
            DropDownList7.Items.Add("The Times Of India");
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Label7.Visible = false;
        Label8.Visible = false;
        DateTime dt = System.DateTime.Now;
        string n = TextBox1.Text;
        int s2 = int.Parse(n);
        string nn = TextBox8.Text;
        int s5 = int.Parse(nn);
        string n2 = TextBox3.Text;
        string n4 = TextBox4.Text;
        string nnn = TextBox5.Text;
        int s3 = int.Parse(nnn);
        string nm = TextBox6.Text;
        int s4 = int.Parse(nm);
        string n8 = TextBox2.Text;
        string n11 = DropDownList7.SelectedItem.ToString();
        string n12 = DropDownList11.SelectedItem.ToString();
        string nj = DropDownList5.SelectedItem.ToString();
        //int s1 = int.Parse(nj);
        string n14 = DropDownList6.SelectedItem.ToString();
        string n9 = DropDownList4.SelectedItem.ToString();
        string n16 = FileUpload1.FileName.ToString();
        string n20 = DropDownList1.SelectedItem.ToString() + DropDownList2.SelectedItem.ToString() + DropDownList3.SelectedItem.ToString();
        DateTime n56 = DateTime.Parse(n20);
        if (dt > n56)
        {
            Label7.Visible = true;
        }
        string n15 = DropDownList8.SelectedItem.ToString() + DropDownList9.SelectedItem.ToString() + DropDownList12.SelectedItem.ToString();
        DateTime dt1 = DateTime.Parse(n15);
        if (dt < dt1)
        {
            Label8.Visible = true;
        }
        string driverstr, dir;
        dir = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con1 = new SqlConnection(dir);
        con1.Open();
        string st = "select pgno,rdate,position from booking";
        SqlCommand cmd1 = new SqlCommand(st, con1);
        SqlDataReader rs = cmd1.ExecuteReader();
        while (rs.Read())
        {
            
            if (rs.GetString(0).Equals(nj ))
                if (rs.GetDateTime(1).Equals(n56))
                    if (rs.GetString(2).Equals(n14))
                        Label6.Visible = true;
                    else
                    {
                        Label6.Visible = false;
                        driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
                        SqlConnection con = new SqlConnection(driverstr);
                        con.Open();
                        string s = "insert into booking values('" + n12 + "','" + n11 + "','" + n2 + "','" + n56 + "','" + nj  + "','" + n14 + "'," + s2 + ",'" + n8 + "','" + n4 + "','" + n16 + "','" + n9 + "'," + s3 + ",'" + dt1 + "'," + s5 + "," + s4 + ")";
                        SqlCommand cmd = new SqlCommand(s, con);
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            ImageButton1.Visible = false;
                            Label5.Visible = true;
                            TextBox1.ReadOnly = true;
                            TextBox2.ReadOnly = true;
                            TextBox3.ReadOnly = true;
                            TextBox4.ReadOnly = true;
                            TextBox5.ReadOnly = true;
                            TextBox6.ReadOnly = true;
                            TextBox8.ReadOnly = true;
                            DropDownList2.Enabled = false;
                            DropDownList1.Enabled = false;
                        }
                    }
        }
    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("update.aspx");
    }
    protected void DropDownList6_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string st = DropDownList6.SelectedItem.ToString();
        string st1 = DropDownList5.SelectedItem.ToString();
        if (st == "center")
        {
            if (st1 == "1")
            {
                TextBox1.Text = "700";
            }
            if (st1 == "2")
            {
                TextBox1.Text = "600";
            }
            if (st1 == "3")
            {
                TextBox1.Text = "500";
            }
            if (st1 == "4")
            {
                TextBox1.Text = "400";
            }
            if (st1 == "5")
            {
                TextBox1.Text = "500";
            }
        }
        if (st == "left side")
        {
            if (st1 == "1")
            {
                TextBox1.Text = "600";
            }
            if (st1 == "2")
            {
                TextBox1.Text = "500";
            }
            if (st1 == "3")
            {
                TextBox1.Text = "400";
            }
            if (st1 == "4")
            {
                TextBox1.Text = "300";
            }
            if (st1 == "5")
            {
                TextBox1.Text = "200";
            }
        }
        if (st == "right side")
        {
            if (st1 == "1")
            {
                TextBox1.Text = "600";
            }
            if (st1 == "2")
            {
                TextBox1.Text = "500";
            }
            if (st1 == "3")
            {
                TextBox1.Text = "400";
            }
            if (st1 == "4")
            {
                TextBox1.Text = "300";
            }
            if (st1 == "5")
            {
                TextBox1.Text = "200";
            }
        }
        if (st == "lower")
        {
            if (st1 == "1")
            {
                TextBox1.Text = "800";
            }
            if (st1 == "2")
            {
                TextBox1.Text = "700";
            }
            if (st1 == "3")
            {
                TextBox1.Text = "600";
            }
            if (st1 == "4")
            {
                TextBox1.Text = "500";
            }
            if (st1 == "5")
            {
                TextBox1.Text = "400";
            }
        }
        if (st == "upper")
        {
            if (st1 == "1")
            {
                TextBox1.Text = "800";
            }
            if (st1 == "2")
            {
                TextBox1.Text = "700";
            }
            if (st1 == "3")
            {
                TextBox1.Text = "600";
            }
            if (st1 == "4")
            {
                TextBox1.Text = "500";
            }
            if (st1 == "5")
            {
                TextBox1.Text = "400";
            }
        }
    }
    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        string st = DropDownList6.SelectedItem.ToString();
        string st1 = DropDownList5.SelectedItem.ToString();
        if (st == "center")
        {
            if (st1 == "1")
            {
                TextBox1.Text = "700";
            }
            if (st1 == "2")
            {
                TextBox1.Text = "600";
            }
            if (st1 == "3")
            {
                TextBox1.Text = "500";
            }
            if (st1 == "4")
            {
                TextBox1.Text = "400";
            }
            if (st1 == "5")
            {
                TextBox1.Text = "500";
            }
        }
        if (st == "left side")
        {
            if (st1 == "1")
            {
                TextBox1.Text = "600";
            }
            if (st1 == "2")
            {
                TextBox1.Text = "500";
            }
            if (st1 == "3")
            {
                TextBox1.Text = "400";
            }
            if (st1 == "4")
            {
                TextBox1.Text = "300";
            }
            if (st1 == "5")
            {
                TextBox1.Text = "200";
            }
        }
        if (st == "right side")
        {
            if (st1 == "1")
            {
                TextBox1.Text = "600";
            }
            if (st1 == "2")
            {
                TextBox1.Text = "500";
            }
            if (st1 == "3")
            {
                TextBox1.Text = "400";
            }
            if (st1 == "4")
            {
                TextBox1.Text = "300";
            }
            if (st1 == "5")
            {
                TextBox1.Text = "200";
            }
        }
        if (st == "lower")
        {
            if (st1 == "1")
            {
                TextBox1.Text = "800";
            }
            if (st1 == "2")
            {
                TextBox1.Text = "700";
            }
            if (st1 == "3")
            {
                TextBox1.Text = "600";
            }
            if (st1 == "4")
            {
                TextBox1.Text = "500";
            }
            if (st1 == "5")
            {
                TextBox1.Text = "400";
            }
        }
        if (st == "upper")
        {
            if (st1 == "1")
            {
                TextBox1.Text = "800";
            }
            if (st1 == "2")
            {
                TextBox1.Text = "700";
            }
            if (st1 == "3")
            {
                TextBox1.Text = "600";
            }
            if (st1 == "4")
            {
                TextBox1.Text = "500";
            }
            if (st1 == "5")
            {
                TextBox1.Text = "400";
            }
        }
    }
    protected void DropDownList9_SelectedIndexChanged(object sender, EventArgs e)
    {
        string s1, st;
        s1 = DropDownList9.SelectedItem.ToString();
        st = DropDownList12.SelectedItem.ToString();
        int n = int.Parse(st);
        DropDownList8.Items.Clear();
        if (s1 == "jan")
        {
            DropDownList8.Items.Clear();
            DropDownList8.Items.Add("1");
            DropDownList8.Items.Add("2");
            DropDownList8.Items.Add("3");
            DropDownList8.Items.Add("4");
            DropDownList8.Items.Add("5");
            DropDownList8.Items.Add("6");
            DropDownList8.Items.Add("7");
            DropDownList8.Items.Add("8");
            DropDownList8.Items.Add("9");
            DropDownList8.Items.Add("10");
            DropDownList8.Items.Add("11");
            DropDownList8.Items.Add("12");
            DropDownList8.Items.Add("13");
            DropDownList8.Items.Add("14");
            DropDownList8.Items.Add("15");
            DropDownList8.Items.Add("16");
            DropDownList8.Items.Add("17");
            DropDownList8.Items.Add("18");
            DropDownList8.Items.Add("19");
            DropDownList8.Items.Add("20");
            DropDownList8.Items.Add("21");
            DropDownList8.Items.Add("22");
            DropDownList8.Items.Add("23");
            DropDownList8.Items.Add("24");
            DropDownList8.Items.Add("25");
            DropDownList8.Items.Add("26");
            DropDownList8.Items.Add("27");
            DropDownList8.Items.Add("28");
            DropDownList8.Items.Add("29");
            DropDownList8.Items.Add("30");
            DropDownList8.Items.Add("31");
        }
        if (s1 == "feb")
        {
            DropDownList8.Items.Clear();
            DropDownList8.Items.Add("1");
            DropDownList8.Items.Add("2");
            DropDownList8.Items.Add("3");
            DropDownList8.Items.Add("4");
            DropDownList8.Items.Add("5");
            DropDownList8.Items.Add("6");
            DropDownList8.Items.Add("7");
            DropDownList8.Items.Add("8");
            DropDownList8.Items.Add("9");
            DropDownList8.Items.Add("10");
            DropDownList8.Items.Add("11");
            DropDownList8.Items.Add("12");
            DropDownList8.Items.Add("13");
            DropDownList8.Items.Add("14");
            DropDownList8.Items.Add("15");
            DropDownList8.Items.Add("16");
            DropDownList8.Items.Add("17");
            DropDownList8.Items.Add("18");
            DropDownList8.Items.Add("19");
            DropDownList8.Items.Add("20");
            DropDownList8.Items.Add("21");
            DropDownList8.Items.Add("22");
            DropDownList8.Items.Add("23");
            DropDownList8.Items.Add("24");
            DropDownList8.Items.Add("25");
            DropDownList8.Items.Add("26");
            DropDownList8.Items.Add("27");
            DropDownList8.Items.Add("28");
        }
        if (s1 == "mar")
        {
            DropDownList8.Items.Clear();
            DropDownList8.Items.Add("1");
            DropDownList8.Items.Add("2");
            DropDownList8.Items.Add("3");
            DropDownList8.Items.Add("4");
            DropDownList8.Items.Add("5");
            DropDownList8.Items.Add("6");
            DropDownList8.Items.Add("7");
            DropDownList8.Items.Add("8");
            DropDownList8.Items.Add("9");
            DropDownList8.Items.Add("10");
            DropDownList8.Items.Add("11");
            DropDownList8.Items.Add("12");
            DropDownList8.Items.Add("13");
            DropDownList8.Items.Add("14");
            DropDownList8.Items.Add("15");
            DropDownList8.Items.Add("16");
            DropDownList8.Items.Add("17");
            DropDownList8.Items.Add("18");
            DropDownList8.Items.Add("19");
            DropDownList8.Items.Add("20");
            DropDownList8.Items.Add("21");
            DropDownList8.Items.Add("22");
            DropDownList8.Items.Add("23");
            DropDownList8.Items.Add("24");
            DropDownList8.Items.Add("25");
            DropDownList8.Items.Add("26");
            DropDownList8.Items.Add("27");
            DropDownList8.Items.Add("28");
            DropDownList8.Items.Add("29");
            DropDownList8.Items.Add("30");
            DropDownList8.Items.Add("31");
        }
        if (s1 == "apr")
        {
            DropDownList8.Items.Clear();
            DropDownList8.Items.Add("1");
            DropDownList8.Items.Add("2");
            DropDownList8.Items.Add("3");
            DropDownList8.Items.Add("4");
            DropDownList8.Items.Add("5");
            DropDownList8.Items.Add("6");
            DropDownList8.Items.Add("7");
            DropDownList8.Items.Add("8");
            DropDownList8.Items.Add("9");
            DropDownList8.Items.Add("10");
            DropDownList8.Items.Add("11");
            DropDownList8.Items.Add("12");
            DropDownList8.Items.Add("13");
            DropDownList8.Items.Add("14");
            DropDownList8.Items.Add("15");
            DropDownList8.Items.Add("16");
            DropDownList8.Items.Add("17");
            DropDownList8.Items.Add("18");
            DropDownList8.Items.Add("19");
            DropDownList8.Items.Add("20");
            DropDownList8.Items.Add("21");
            DropDownList8.Items.Add("22");
            DropDownList8.Items.Add("23");
            DropDownList8.Items.Add("24");
            DropDownList8.Items.Add("25");
            DropDownList8.Items.Add("26");
            DropDownList8.Items.Add("27");
            DropDownList8.Items.Add("28");
            DropDownList8.Items.Add("29");
            DropDownList8.Items.Add("30");
        }
        if (s1 == "may")
        {
            DropDownList8.Items.Clear();
            DropDownList8.Items.Add("1");
            DropDownList8.Items.Add("2");
            DropDownList8.Items.Add("3");
            DropDownList8.Items.Add("4");
            DropDownList8.Items.Add("5");
            DropDownList8.Items.Add("6");
            DropDownList8.Items.Add("7");
            DropDownList8.Items.Add("8");
            DropDownList8.Items.Add("9");
            DropDownList8.Items.Add("10");
            DropDownList8.Items.Add("11");
            DropDownList8.Items.Add("12");
            DropDownList8.Items.Add("13");
            DropDownList8.Items.Add("14");
            DropDownList8.Items.Add("15");
            DropDownList8.Items.Add("16");
            DropDownList8.Items.Add("17");
            DropDownList8.Items.Add("18");
            DropDownList8.Items.Add("19");
            DropDownList8.Items.Add("20");
            DropDownList8.Items.Add("21");
            DropDownList8.Items.Add("22");
            DropDownList8.Items.Add("23");
            DropDownList8.Items.Add("24");
            DropDownList8.Items.Add("25");
            DropDownList8.Items.Add("26");
            DropDownList8.Items.Add("27");
            DropDownList8.Items.Add("28");
            DropDownList8.Items.Add("29");
            DropDownList8.Items.Add("30");
            DropDownList8.Items.Add("31");
        }
        if (s1 == "jun")
        {
            DropDownList8.Items.Clear();
            DropDownList8.Items.Add("1");
            DropDownList8.Items.Add("2");
            DropDownList8.Items.Add("3");
            DropDownList8.Items.Add("4");
            DropDownList8.Items.Add("5");
            DropDownList8.Items.Add("6");
            DropDownList8.Items.Add("7");
            DropDownList8.Items.Add("8");
            DropDownList8.Items.Add("9");
            DropDownList8.Items.Add("10");
            DropDownList8.Items.Add("11");
            DropDownList8.Items.Add("12");
            DropDownList8.Items.Add("13");
            DropDownList8.Items.Add("14");
            DropDownList8.Items.Add("15");
            DropDownList8.Items.Add("16");
            DropDownList8.Items.Add("17");
            DropDownList8.Items.Add("18");
            DropDownList8.Items.Add("19");
            DropDownList8.Items.Add("20");
            DropDownList8.Items.Add("21");
            DropDownList8.Items.Add("22");
            DropDownList8.Items.Add("23");
            DropDownList8.Items.Add("24");
            DropDownList8.Items.Add("25");
            DropDownList8.Items.Add("26");
            DropDownList8.Items.Add("27");
            DropDownList8.Items.Add("28");
            DropDownList8.Items.Add("29");
            DropDownList8.Items.Add("30");
        }
        if (s1 == "jul")
        {
            DropDownList8.Items.Clear();
            DropDownList8.Items.Add("1");
            DropDownList8.Items.Add("2");
            DropDownList8.Items.Add("3");
            DropDownList8.Items.Add("4");
            DropDownList8.Items.Add("5");
            DropDownList8.Items.Add("6");
            DropDownList8.Items.Add("7");
            DropDownList8.Items.Add("8");
            DropDownList8.Items.Add("9");
            DropDownList8.Items.Add("10");
            DropDownList8.Items.Add("11");
            DropDownList8.Items.Add("12");
            DropDownList8.Items.Add("13");
            DropDownList8.Items.Add("14");
            DropDownList8.Items.Add("15");
            DropDownList8.Items.Add("16");
            DropDownList8.Items.Add("17");
            DropDownList8.Items.Add("18");
            DropDownList8.Items.Add("19");
            DropDownList8.Items.Add("20");
            DropDownList8.Items.Add("21");
            DropDownList8.Items.Add("22");
            DropDownList8.Items.Add("23");
            DropDownList8.Items.Add("24");
            DropDownList8.Items.Add("25");
            DropDownList8.Items.Add("26");
            DropDownList8.Items.Add("27");
            DropDownList8.Items.Add("28");
            DropDownList8.Items.Add("29");
            DropDownList8.Items.Add("30");
            DropDownList8.Items.Add("31");
        }
        if (s1 == "aug")
        {
            DropDownList8.Items.Clear();
            DropDownList8.Items.Add("1");
            DropDownList8.Items.Add("2");
            DropDownList8.Items.Add("3");
            DropDownList8.Items.Add("4");
            DropDownList8.Items.Add("5");
            DropDownList8.Items.Add("6");
            DropDownList8.Items.Add("7");
            DropDownList8.Items.Add("8");
            DropDownList8.Items.Add("9");
            DropDownList8.Items.Add("10");
            DropDownList8.Items.Add("11");
            DropDownList8.Items.Add("12");
            DropDownList8.Items.Add("13");
            DropDownList8.Items.Add("14");
            DropDownList8.Items.Add("15");
            DropDownList8.Items.Add("16");
            DropDownList8.Items.Add("17");
            DropDownList8.Items.Add("18");
            DropDownList8.Items.Add("19");
            DropDownList8.Items.Add("20");
            DropDownList8.Items.Add("21");
            DropDownList8.Items.Add("22");
            DropDownList8.Items.Add("23");
            DropDownList8.Items.Add("24");
            DropDownList8.Items.Add("25");
            DropDownList8.Items.Add("26");
            DropDownList8.Items.Add("27");
            DropDownList8.Items.Add("28");
            DropDownList8.Items.Add("29");
            DropDownList8.Items.Add("30");
            DropDownList8.Items.Add("31");
        }
        if (s1 == "sep")
        {
            DropDownList8.Items.Clear();
            DropDownList8.Items.Add("1");
            DropDownList8.Items.Add("2");
            DropDownList8.Items.Add("3");
            DropDownList8.Items.Add("4");
            DropDownList8.Items.Add("5");
            DropDownList8.Items.Add("6");
            DropDownList8.Items.Add("7");
            DropDownList8.Items.Add("8");
            DropDownList8.Items.Add("9");
            DropDownList8.Items.Add("10");
            DropDownList8.Items.Add("11");
            DropDownList8.Items.Add("12");
            DropDownList8.Items.Add("13");
            DropDownList8.Items.Add("14");
            DropDownList8.Items.Add("15");
            DropDownList8.Items.Add("16");
            DropDownList8.Items.Add("17");
            DropDownList8.Items.Add("18");
            DropDownList8.Items.Add("19");
            DropDownList8.Items.Add("20");
            DropDownList8.Items.Add("21");
            DropDownList8.Items.Add("22");
            DropDownList8.Items.Add("23");
            DropDownList8.Items.Add("24");
            DropDownList8.Items.Add("25");
            DropDownList8.Items.Add("26");
            DropDownList8.Items.Add("27");
            DropDownList8.Items.Add("28");
            DropDownList8.Items.Add("29");
            DropDownList8.Items.Add("30");
        }
        if (s1 == "oct")
        {
            DropDownList8.Items.Clear();
            DropDownList8.Items.Add("1");
            DropDownList8.Items.Add("2");
            DropDownList8.Items.Add("3");
            DropDownList8.Items.Add("4");
            DropDownList8.Items.Add("5");
            DropDownList8.Items.Add("6");
            DropDownList8.Items.Add("7");
            DropDownList8.Items.Add("8");
            DropDownList8.Items.Add("9");
            DropDownList8.Items.Add("10");
            DropDownList8.Items.Add("11");
            DropDownList8.Items.Add("12");
            DropDownList8.Items.Add("13");
            DropDownList8.Items.Add("14");
            DropDownList8.Items.Add("15");
            DropDownList8.Items.Add("16");
            DropDownList8.Items.Add("17");
            DropDownList8.Items.Add("18");
            DropDownList8.Items.Add("19");
            DropDownList8.Items.Add("20");
            DropDownList8.Items.Add("21");
            DropDownList8.Items.Add("22");
            DropDownList8.Items.Add("23");
            DropDownList8.Items.Add("24");
            DropDownList8.Items.Add("25");
            DropDownList8.Items.Add("26");
            DropDownList8.Items.Add("27");
            DropDownList8.Items.Add("28");
            DropDownList8.Items.Add("29");
            DropDownList8.Items.Add("30");
            DropDownList8.Items.Add("31");
        }
        if (s1 == "nov")
        {
            DropDownList8.Items.Clear();
            DropDownList8.Items.Add("1");
            DropDownList8.Items.Add("2");
            DropDownList8.Items.Add("3");
            DropDownList8.Items.Add("4");
            DropDownList8.Items.Add("5");
            DropDownList8.Items.Add("6");
            DropDownList8.Items.Add("7");
            DropDownList8.Items.Add("8");
            DropDownList8.Items.Add("9");
            DropDownList8.Items.Add("10");
            DropDownList8.Items.Add("11");
            DropDownList8.Items.Add("12");
            DropDownList8.Items.Add("13");
            DropDownList8.Items.Add("14");
            DropDownList8.Items.Add("15");
            DropDownList8.Items.Add("16");
            DropDownList8.Items.Add("17");
            DropDownList8.Items.Add("18");
            DropDownList8.Items.Add("19");
            DropDownList8.Items.Add("20");
            DropDownList8.Items.Add("21");
            DropDownList8.Items.Add("22");
            DropDownList8.Items.Add("23");
            DropDownList8.Items.Add("24");
            DropDownList8.Items.Add("25");
            DropDownList8.Items.Add("26");
            DropDownList8.Items.Add("27");
            DropDownList8.Items.Add("28");
            DropDownList8.Items.Add("29");
            DropDownList8.Items.Add("30");
        }
        if (s1 == "dec")
        {
            DropDownList8.Items.Clear();
            DropDownList8.Items.Add("1");
            DropDownList8.Items.Add("2");
            DropDownList8.Items.Add("3");
            DropDownList8.Items.Add("4");
            DropDownList8.Items.Add("5");
            DropDownList8.Items.Add("6");
            DropDownList8.Items.Add("7");
            DropDownList8.Items.Add("8");
            DropDownList8.Items.Add("9");
            DropDownList8.Items.Add("10");
            DropDownList8.Items.Add("11");
            DropDownList8.Items.Add("12");
            DropDownList8.Items.Add("13");
            DropDownList8.Items.Add("14");
            DropDownList8.Items.Add("15");
            DropDownList8.Items.Add("16");
            DropDownList8.Items.Add("17");
            DropDownList8.Items.Add("18");
            DropDownList8.Items.Add("19");
            DropDownList8.Items.Add("20");
            DropDownList8.Items.Add("21");
            DropDownList8.Items.Add("22");
            DropDownList8.Items.Add("23");
            DropDownList8.Items.Add("24");
            DropDownList8.Items.Add("25");
            DropDownList8.Items.Add("26");
            DropDownList8.Items.Add("27");
            DropDownList8.Items.Add("28");
            DropDownList8.Items.Add("29");
            DropDownList8.Items.Add("30");
            DropDownList8.Items.Add("31");
        }

        if (n % 4 == 0)
        {
            if (s1 == "feb")
            {
                DropDownList8.Items.Clear();
                DropDownList8.Items.Add("1");
                DropDownList8.Items.Add("2");
                DropDownList8.Items.Add("3");
                DropDownList8.Items.Add("4");
                DropDownList8.Items.Add("5");
                DropDownList8.Items.Add("6");
                DropDownList8.Items.Add("7");
                DropDownList8.Items.Add("8");
                DropDownList8.Items.Add("9");
                DropDownList8.Items.Add("10");
                DropDownList8.Items.Add("11");
                DropDownList8.Items.Add("12");
                DropDownList8.Items.Add("13");
                DropDownList8.Items.Add("14");
                DropDownList8.Items.Add("15");
                DropDownList8.Items.Add("16");
                DropDownList8.Items.Add("17");
                DropDownList8.Items.Add("18");
                DropDownList8.Items.Add("19");
                DropDownList8.Items.Add("20");
                DropDownList8.Items.Add("21");
                DropDownList8.Items.Add("22");
                DropDownList8.Items.Add("23");
                DropDownList8.Items.Add("24");
                DropDownList8.Items.Add("25");
                DropDownList8.Items.Add("26");
                DropDownList8.Items.Add("27");
                DropDownList8.Items.Add("28");
                DropDownList8.Items.Add("29");
            }
        }
    }
}


