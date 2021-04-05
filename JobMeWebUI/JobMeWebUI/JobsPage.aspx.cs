using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using BL;

namespace JobMeWebUI
{
    public partial class JobsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            jobOffersGrid.DataSource = JobOffer.GetOffers();
            jobOffersGrid.DataBind();
        }

        protected void publishJob(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            if (rg.IsMatch(PhoneNumberText.Text) && CompanyText.Text != "" && Position.Text != "")
            {
                JobOffer.AddOffer((int)Session["UserID"], PhoneNumberText.Text, CompanyText.Text, Position.Text);
                Response.Redirect("JobsPage.aspx");
            }
        }
    }
}