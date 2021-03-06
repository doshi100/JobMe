using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobMeWebUI
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserID"] != null)
            {
                loggedInNav.Visible = true;
            }
            else
            {
                RegularNav.Visible = true;
            }
        }

        protected void LogOut(object sender, EventArgs e)
        {
            Session["UserID"] = null;
            Response.Redirect("login.aspx");
        }
    }
}