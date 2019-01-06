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

public partial class Default3 : System.Web.UI.Page
{
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        Label1 .Text = "The benefits of placing your advertisements using IndianAdvertisement.com are numerous. You can avail of the many services offered, and plan your Newspaper advertising with ease and peace of mind.";
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        Label1.Text = "Please follow the following steps:"+
        "STEP 1: Fill up a small registration form and register yourself."+"STEP 2: Enter your Advertisement details like, Publication, Edition, Message etc. and submit the details.STEP 3: You will get the quotation for the advertisement within 24 hours.STEP 4:Approve the quote and make payment choosing from various payment options.";

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        Label1 .Text ="There are basically three types of advertisements:1. Classifieds Regular / Ordinary2. Classified Display3. Display";
        
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        Label1 .Text ="1. Classifieds Regular / Ordinary:These types of advertisements are the cheapest mode of advertisements. These are priced on per line / per word basis. The basic classified advertisement has the first word in capitals / bold with all remaining lines / words in regular style in simple paragraph.2. Classified Display:These type of advertisements are little costlier than the regular classifieds. These are priced on per column centimeter / per square centimeter basis. The format uses a border in a variable point size for higher visibility and greater impact. This style also allows the use of a logo or a visual.Classified Display advertisements are acceptable only in single column i.e. the width of Classified Display advertisements can vary from 3 centimeter to 4 centimeter as per the publication guidelines, not more than that.3. Display:These types of advertisements are the HIGH IMPACT and the costliest type of advertisements. These advertisements can be of any size in width / height but should not be less than 3 centimeter. It can be color / black & white.";
    }
    protected void page_load (object sender, EventArgs e)
    {
        Label1 .Visible = false;
    }
}
