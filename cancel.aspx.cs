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
using System.Data .SqlClient ;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == " ")
        {
            Response.Redirect("error.aspx");
        }
        DropDownList10.Items.Add("amar ujala");
        DropDownList10.Items.Add("Dainik Bhaskar");
        DropDownList10.Items.Add("Dainik Jagran");
        DropDownList10.Items.Add("Dainik Tribune");
        DropDownList10.Items.Add("Hindustan");
        DropDownList10.Items.Add("I-Next");
        DropDownList10.Items.Add("Nai Dunia");
        DropDownList10.Items.Add("Nava Bharat");
        DropDownList10.Items.Add("Prabhat Khabar");
        DropDownList10.Items.Add("The Hindu");
        DropDownList10.Items.Add("The Hitavada");
        DropDownList10.Items.Add("The Hindu Business Line");
        DropDownList10.Items.Add("Business Standard");
        DropDownList10.Items.Add("Deccan Herald");
        DropDownList10.Items.Add("Economic Times");
        DropDownList10.Items.Add("Hindustan Times");
        DropDownList10.Items.Add("Nav Bharat Times");
        DropDownList10.Items.Add("I-Next");
        DropDownList10.Items.Add("The Pioneer");
        DropDownList10.Items.Add("The Hindu Business Line");
        DropDownList10.Items.Add("The New Indian Express");
        DropDownList10.Items.Add("The Times Of India");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("logout.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int kk=0;
        
        string st = DropDownList10.SelectedItem.ToString();
        string st1 = DropDownList2.SelectedItem.ToString();
        string st2 = DropDownList3.SelectedItem.ToString();
        string st3 = DropDownList4.SelectedItem.ToString() + DropDownList5.SelectedItem.ToString() + DropDownList6.SelectedItem.ToString();
        DateTime dt = DateTime.Parse(st3);
        DateTime dt1 = DateTime.Today;
        int y = dt1.Year;
        int m = dt1.Month;
        int d = dt1.Day;
        int y1 = dt.Year;
        int m1 = dt.Month;
        int d1 = dt.Day;
        if (y >= y1)
        {
            if (m >= m1)
            {
                if (d >= d1)
                {
                    Label6.Visible = true;
                }
                else
                {
                    string driverstr;
                    driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
                    SqlConnection con = new SqlConnection(driverstr);
                    con.Open();
                    string s = "select pgno,position,edition,rdate from booking";
                    SqlCommand cmd = new SqlCommand(s, con);
                    SqlDataReader rs = cmd.ExecuteReader();
                    while (rs.Read())
                    {
                        if (rs.GetString(0).Equals(st1))
                            if (rs.GetString(1).Equals(st2))
                                if (rs.GetString(2).Equals(st))
                                    if (rs.GetDateTime(3).Equals(dt))
                                    {
                                        kk = 1;
                                    }
                                    else
                                    {
                                        kk = 0;
                                    }
                    }
                    if (kk == 1)
                    {
                        string dir;
                        dir = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
                        SqlConnection con1 = new SqlConnection(dir);
                        con1.Open();
                        string pp = "delete from booking where pgno='" + st + "'and position='" + st2 + "'and edition='" + st + "'and rdate='" + dt + "'";
                        SqlCommand cmd1 = new SqlCommand(pp, con1);
                        cmd1.ExecuteReader();
                        Label5.Text = "Your booking han been cancelled";
                        Label5.Visible = true;

                    }
                    else
                    {
                        Label5.Visible = true;
                    }

                }
            }
            else
            {
                string driverstr;
                driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
                SqlConnection con = new SqlConnection(driverstr);
                con.Open();
                string s = "select pgno,position,edition,rdate from booking";
                SqlCommand cmd = new SqlCommand(s, con);
                SqlDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    if (rs.GetString(0).Equals(st1))
                        if (rs.GetString(1).Equals(st2))
                            if (rs.GetString(2).Equals(st))
                                if (rs.GetDateTime(3).Equals(dt))
                                {
                                    kk = 1;
                                }
                                else
                                {
                                    kk = 0;
                                }
                }
                if (kk == 1)
                {
                    string dir;
                    dir = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
                    SqlConnection con1 = new SqlConnection(dir);
                    con1.Open();
                    string pp = "delete from booking where pgno='" + st + "'and position='" + st2 + "'and edition='" + st + "'and rdate='" + dt + "'";
                    SqlCommand cmd1 = new SqlCommand(pp, con1);
                    cmd1.ExecuteReader();
                    Label5.Text = "Your booking has been cancelled";
                    Label5.Visible = true;

                }
                else
                {
                    Label5.Visible = true;
                }

            }
        }

        else
        {
            string driverstr;
            driverstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
            SqlConnection con = new SqlConnection(driverstr);
            con.Open();
            string s = "select pgno,position,edition,rdate from booking";
            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                if (rs.GetString(0).Equals(st1))
                    if (rs.GetString(1).Equals(st2))
                        if (rs.GetString(2).Equals(st))
                            if (rs.GetDateTime(3).Equals(dt))
                            {
                                kk = 1;
                            }
                            else
                            {
                                kk = 0;
                            }
            }
            if (kk == 1)
            {
                string dir;
                dir = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
                SqlConnection con1 = new SqlConnection(dir);
                con1.Open();
                string pp = "delete from booking where pgno='" + st + "'and position='" + st2 + "'and edition='" + st + "'and rdate='" + dt + "'";
                SqlCommand cmd1 = new SqlCommand(pp, con1);
                cmd1.ExecuteReader();
                Label5.Text = "Your booking han been cancelled";
                Label5.Visible = true;

            }
            else
            {
                Label5.Visible = true;
            }

        }
    }
   protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        string s1, st;
        s1 = DropDownList5.SelectedItem.ToString();
        st = DropDownList6.SelectedItem.ToString();
        int n = int.Parse(st);
        DropDownList4.Items.Clear();
        if (s1 == "jan")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("1");
            DropDownList4.Items.Add("2");
            DropDownList4.Items.Add("3");
            DropDownList4.Items.Add("4");
            DropDownList4.Items.Add("5");
            DropDownList4.Items.Add("6");
            DropDownList4.Items.Add("7");
            DropDownList4.Items.Add("8");
            DropDownList4.Items.Add("9");
            DropDownList4.Items.Add("10");
            DropDownList4.Items.Add("11");
            DropDownList4.Items.Add("12");
            DropDownList4.Items.Add("13");
            DropDownList4.Items.Add("14");
            DropDownList4.Items.Add("15");
            DropDownList4.Items.Add("16");
            DropDownList4.Items.Add("17");
            DropDownList4.Items.Add("18");
            DropDownList4.Items.Add("19");
            DropDownList4.Items.Add("20");
            DropDownList4.Items.Add("21");
            DropDownList4.Items.Add("22");
            DropDownList4.Items.Add("23");
            DropDownList4.Items.Add("24");
            DropDownList4.Items.Add("25");
            DropDownList4.Items.Add("26");
            DropDownList4.Items.Add("27");
            DropDownList4.Items.Add("28");
            DropDownList4.Items.Add("29");
            DropDownList4.Items.Add("30");
            DropDownList4.Items.Add("31");
        }
        if (s1 == "feb")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("1");
            DropDownList4.Items.Add("2");
            DropDownList4.Items.Add("3");
            DropDownList4.Items.Add("4");
            DropDownList4.Items.Add("5");
            DropDownList4.Items.Add("6");
            DropDownList4.Items.Add("7");
            DropDownList4.Items.Add("8");
            DropDownList4.Items.Add("9");
            DropDownList4.Items.Add("10");
            DropDownList4.Items.Add("11");
            DropDownList4.Items.Add("12");
            DropDownList4.Items.Add("13");
            DropDownList4.Items.Add("14");
            DropDownList4.Items.Add("15");
            DropDownList4.Items.Add("16");
            DropDownList4.Items.Add("17");
            DropDownList4.Items.Add("18");
            DropDownList4.Items.Add("19");
            DropDownList4.Items.Add("20");
            DropDownList4.Items.Add("21");
            DropDownList4.Items.Add("22");
            DropDownList4.Items.Add("23");
            DropDownList4.Items.Add("24");
            DropDownList4.Items.Add("25");
            DropDownList4.Items.Add("26");
            DropDownList4.Items.Add("27");
            DropDownList4.Items.Add("28");
        }
        if (s1 == "mar")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("1");
            DropDownList4.Items.Add("2");
            DropDownList4.Items.Add("3");
            DropDownList4.Items.Add("4");
            DropDownList4.Items.Add("5");
            DropDownList4.Items.Add("6");
            DropDownList4.Items.Add("7");
            DropDownList4.Items.Add("8");
            DropDownList4.Items.Add("9");
            DropDownList4.Items.Add("10");
            DropDownList4.Items.Add("11");
            DropDownList4.Items.Add("12");
            DropDownList4.Items.Add("13");
            DropDownList4.Items.Add("14");
            DropDownList4.Items.Add("15");
            DropDownList4.Items.Add("16");
            DropDownList4.Items.Add("17");
            DropDownList4.Items.Add("18");
            DropDownList4.Items.Add("19");
            DropDownList4.Items.Add("20");
            DropDownList4.Items.Add("21");
            DropDownList4.Items.Add("22");
            DropDownList4.Items.Add("23");
            DropDownList4.Items.Add("24");
            DropDownList4.Items.Add("25");
            DropDownList4.Items.Add("26");
            DropDownList4.Items.Add("27");
            DropDownList4.Items.Add("28");
            DropDownList4.Items.Add("29");
            DropDownList4.Items.Add("30");
            DropDownList4.Items.Add("31");
        }
        if (s1 == "apr")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("1");
            DropDownList4.Items.Add("2");
            DropDownList4.Items.Add("3");
            DropDownList4.Items.Add("4");
            DropDownList4.Items.Add("5");
            DropDownList4.Items.Add("6");
            DropDownList4.Items.Add("7");
            DropDownList4.Items.Add("8");
            DropDownList4.Items.Add("9");
            DropDownList4.Items.Add("10");
            DropDownList4.Items.Add("11");
            DropDownList4.Items.Add("12");
            DropDownList4.Items.Add("13");
            DropDownList4.Items.Add("14");
            DropDownList4.Items.Add("15");
            DropDownList4.Items.Add("16");
            DropDownList4.Items.Add("17");
            DropDownList4.Items.Add("18");
            DropDownList4.Items.Add("19");
            DropDownList4.Items.Add("20");
            DropDownList4.Items.Add("21");
            DropDownList4.Items.Add("22");
            DropDownList4.Items.Add("23");
            DropDownList4.Items.Add("24");
            DropDownList4.Items.Add("25");
            DropDownList4.Items.Add("26");
            DropDownList4.Items.Add("27");
            DropDownList4.Items.Add("28");
            DropDownList4.Items.Add("29");
            DropDownList4.Items.Add("30");
        }
        if (s1 == "may")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("1");
            DropDownList4.Items.Add("2");
            DropDownList4.Items.Add("3");
            DropDownList4.Items.Add("4");
            DropDownList4.Items.Add("5");
            DropDownList4.Items.Add("6");
            DropDownList4.Items.Add("7");
            DropDownList4.Items.Add("8");
            DropDownList4.Items.Add("9");
            DropDownList4.Items.Add("10");
            DropDownList4.Items.Add("11");
            DropDownList4.Items.Add("12");
            DropDownList4.Items.Add("13");
            DropDownList4.Items.Add("14");
            DropDownList4.Items.Add("15");
            DropDownList4.Items.Add("16");
            DropDownList4.Items.Add("17");
            DropDownList4.Items.Add("18");
            DropDownList4.Items.Add("19");
            DropDownList4.Items.Add("20");
            DropDownList4.Items.Add("21");
            DropDownList4.Items.Add("22");
            DropDownList4.Items.Add("23");
            DropDownList4.Items.Add("24");
            DropDownList4.Items.Add("25");
            DropDownList4.Items.Add("26");
            DropDownList4.Items.Add("27");
            DropDownList4.Items.Add("28");
            DropDownList4.Items.Add("29");
            DropDownList4.Items.Add("30");
            DropDownList4.Items.Add("31");
        }
        if (s1 == "jun")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("1");
            DropDownList4.Items.Add("2");
            DropDownList4.Items.Add("3");
            DropDownList4.Items.Add("4");
            DropDownList4.Items.Add("5");
            DropDownList4.Items.Add("6");
            DropDownList4.Items.Add("7");
            DropDownList4.Items.Add("8");
            DropDownList4.Items.Add("9");
            DropDownList4.Items.Add("10");
            DropDownList4.Items.Add("11");
            DropDownList4.Items.Add("12");
            DropDownList4.Items.Add("13");
            DropDownList4.Items.Add("14");
            DropDownList4.Items.Add("15");
            DropDownList4.Items.Add("16");
            DropDownList4.Items.Add("17");
            DropDownList4.Items.Add("18");
            DropDownList4.Items.Add("19");
            DropDownList4.Items.Add("20");
            DropDownList4.Items.Add("21");
            DropDownList4.Items.Add("22");
            DropDownList4.Items.Add("23");
            DropDownList4.Items.Add("24");
            DropDownList4.Items.Add("25");
            DropDownList4.Items.Add("26");
            DropDownList4.Items.Add("27");
            DropDownList4.Items.Add("28");
            DropDownList4.Items.Add("29");
            DropDownList4.Items.Add("30");
        }
        if (s1 == "jul")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("1");
            DropDownList4.Items.Add("2");
            DropDownList4.Items.Add("3");
            DropDownList4.Items.Add("4");
            DropDownList4.Items.Add("5");
            DropDownList4.Items.Add("6");
            DropDownList4.Items.Add("7");
            DropDownList4.Items.Add("8");
            DropDownList4.Items.Add("9");
            DropDownList4.Items.Add("10");
            DropDownList4.Items.Add("11");
            DropDownList4.Items.Add("12");
            DropDownList4.Items.Add("13");
            DropDownList4.Items.Add("14");
            DropDownList4.Items.Add("15");
            DropDownList4.Items.Add("16");
            DropDownList4.Items.Add("17");
            DropDownList4.Items.Add("18");
            DropDownList4.Items.Add("19");
            DropDownList4.Items.Add("20");
            DropDownList4.Items.Add("21");
            DropDownList4.Items.Add("22");
            DropDownList4.Items.Add("23");
            DropDownList4.Items.Add("24");
            DropDownList4.Items.Add("25");
            DropDownList4.Items.Add("26");
            DropDownList4.Items.Add("27");
            DropDownList4.Items.Add("28");
            DropDownList4.Items.Add("29");
            DropDownList4.Items.Add("30");
            DropDownList4.Items.Add("31");
        }
        if (s1 == "aug")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("1");
            DropDownList4.Items.Add("2");
            DropDownList4.Items.Add("3");
            DropDownList4.Items.Add("4");
            DropDownList4.Items.Add("5");
            DropDownList4.Items.Add("6");
            DropDownList4.Items.Add("7");
            DropDownList4.Items.Add("8");
            DropDownList4.Items.Add("9");
            DropDownList4.Items.Add("10");
            DropDownList4.Items.Add("11");
            DropDownList4.Items.Add("12");
            DropDownList4.Items.Add("13");
            DropDownList4.Items.Add("14");
            DropDownList4.Items.Add("15");
            DropDownList4.Items.Add("16");
            DropDownList4.Items.Add("17");
            DropDownList4.Items.Add("18");
            DropDownList4.Items.Add("19");
            DropDownList4.Items.Add("20");
            DropDownList4.Items.Add("21");
            DropDownList4.Items.Add("22");
            DropDownList4.Items.Add("23");
            DropDownList4.Items.Add("24");
            DropDownList4.Items.Add("25");
            DropDownList4.Items.Add("26");
            DropDownList4.Items.Add("27");
            DropDownList4.Items.Add("28");
            DropDownList4.Items.Add("29");
            DropDownList4.Items.Add("30");
            DropDownList4.Items.Add("31");
        }
        if (s1 == "sep")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("1");
            DropDownList4.Items.Add("2");
            DropDownList4.Items.Add("3");
            DropDownList4.Items.Add("4");
            DropDownList4.Items.Add("5");
            DropDownList4.Items.Add("6");
            DropDownList4.Items.Add("7");
            DropDownList4.Items.Add("8");
            DropDownList4.Items.Add("9");
            DropDownList4.Items.Add("10");
            DropDownList4.Items.Add("11");
            DropDownList4.Items.Add("12");
            DropDownList4.Items.Add("13");
            DropDownList4.Items.Add("14");
            DropDownList4.Items.Add("15");
            DropDownList4.Items.Add("16");
            DropDownList4.Items.Add("17");
            DropDownList4.Items.Add("18");
            DropDownList4.Items.Add("19");
            DropDownList4.Items.Add("20");
            DropDownList4.Items.Add("21");
            DropDownList4.Items.Add("22");
            DropDownList4.Items.Add("23");
            DropDownList4.Items.Add("24");
            DropDownList4.Items.Add("25");
            DropDownList4.Items.Add("26");
            DropDownList4.Items.Add("27");
            DropDownList4.Items.Add("28");
            DropDownList4.Items.Add("29");
            DropDownList4.Items.Add("30");
        }
        if (s1 == "oct")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("1");
            DropDownList4.Items.Add("2");
            DropDownList4.Items.Add("3");
            DropDownList4.Items.Add("4");
            DropDownList4.Items.Add("5");
            DropDownList4.Items.Add("6");
            DropDownList4.Items.Add("7");
            DropDownList4.Items.Add("8");
            DropDownList4.Items.Add("9");
            DropDownList4.Items.Add("10");
            DropDownList4.Items.Add("11");
            DropDownList4.Items.Add("12");
            DropDownList4.Items.Add("13");
            DropDownList4.Items.Add("14");
            DropDownList4.Items.Add("15");
            DropDownList4.Items.Add("16");
            DropDownList4.Items.Add("17");
            DropDownList4.Items.Add("18");
            DropDownList4.Items.Add("19");
            DropDownList4.Items.Add("20");
            DropDownList4.Items.Add("21");
            DropDownList4.Items.Add("22");
            DropDownList4.Items.Add("23");
            DropDownList4.Items.Add("24");
            DropDownList4.Items.Add("25");
            DropDownList4.Items.Add("26");
            DropDownList4.Items.Add("27");
            DropDownList4.Items.Add("28");
            DropDownList4.Items.Add("29");
            DropDownList4.Items.Add("30");
            DropDownList4.Items.Add("31");
        }
        if (s1 == "nov")
        {
            DropDownList4.Items.Clear(); 
            DropDownList4.Items.Add("1");
            DropDownList4.Items.Add("2");
            DropDownList4.Items.Add("3");
            DropDownList4.Items.Add("4");
            DropDownList4.Items.Add("5");
            DropDownList4.Items.Add("6");
            DropDownList4.Items.Add("7");
            DropDownList4.Items.Add("8");
            DropDownList4.Items.Add("9");
            DropDownList4.Items.Add("10");
            DropDownList4.Items.Add("11");
            DropDownList4.Items.Add("12");
            DropDownList4.Items.Add("13");
            DropDownList4.Items.Add("14");
            DropDownList4.Items.Add("15");
            DropDownList4.Items.Add("16");
            DropDownList4.Items.Add("17");
            DropDownList4.Items.Add("18");
            DropDownList4.Items.Add("19");
            DropDownList4.Items.Add("20");
            DropDownList4.Items.Add("21");
            DropDownList4.Items.Add("22");
            DropDownList4.Items.Add("23");
            DropDownList4.Items.Add("24");
            DropDownList4.Items.Add("25");
            DropDownList4.Items.Add("26");
            DropDownList4.Items.Add("27");
            DropDownList4.Items.Add("28");
            DropDownList4.Items.Add("29");
            DropDownList4.Items.Add("30");
        }
        if (s1 == "dec")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("1");
            DropDownList4.Items.Add("2");
            DropDownList4.Items.Add("3");
            DropDownList4.Items.Add("4");
            DropDownList4.Items.Add("5");
            DropDownList4.Items.Add("6");
            DropDownList4.Items.Add("7");
            DropDownList4.Items.Add("8");
            DropDownList4.Items.Add("9");
            DropDownList4.Items.Add("10");
            DropDownList4.Items.Add("11");
            DropDownList4.Items.Add("12");
            DropDownList4.Items.Add("13");
            DropDownList4.Items.Add("14");
            DropDownList4.Items.Add("15");
            DropDownList4.Items.Add("16");
            DropDownList4.Items.Add("17");
            DropDownList4.Items.Add("18");
            DropDownList4.Items.Add("19");
            DropDownList4.Items.Add("20");
            DropDownList4.Items.Add("21");
            DropDownList4.Items.Add("22");
            DropDownList4.Items.Add("23");
            DropDownList4.Items.Add("24");
            DropDownList4.Items.Add("25");
            DropDownList4.Items.Add("26");
            DropDownList4.Items.Add("27");
            DropDownList4.Items.Add("28");
            DropDownList4.Items.Add("29");
            DropDownList4.Items.Add("30");
            DropDownList4.Items.Add("31");
        }

        if (n % 4 == 0)
        {
            if (s1 == "feb")
            {
                DropDownList4.Items.Clear();
                DropDownList4.Items.Add("1");
                DropDownList4.Items.Add("2");
                DropDownList4.Items.Add("3");
                DropDownList4.Items.Add("4");
                DropDownList4.Items.Add("5");
                DropDownList4.Items.Add("6");
                DropDownList4.Items.Add("7");
                DropDownList4.Items.Add("8");
                DropDownList4.Items.Add("9");
                DropDownList4.Items.Add("10");
                DropDownList4.Items.Add("11");
                DropDownList4.Items.Add("12");
                DropDownList4.Items.Add("13");
                DropDownList4.Items.Add("14");
                DropDownList4.Items.Add("15");
                DropDownList4.Items.Add("16");
                DropDownList4.Items.Add("17");
                DropDownList4.Items.Add("18");
                DropDownList4.Items.Add("19");
                DropDownList4.Items.Add("20");
                DropDownList4.Items.Add("21");
                DropDownList4.Items.Add("22");
                DropDownList4.Items.Add("23");
                DropDownList4.Items.Add("24");
                DropDownList4.Items.Add("25");
                DropDownList4.Items.Add("26");
                DropDownList4.Items.Add("27");
                DropDownList4.Items.Add("28");
                DropDownList4.Items.Add("29");
            }
        }
    }
}
