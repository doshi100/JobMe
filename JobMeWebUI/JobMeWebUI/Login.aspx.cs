using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
namespace JobMeWebUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LogInUser(object sender, EventArgs e)
        {
            if(BL.User.CheckCredentials(UsernameBox.Text,PasswordBox.Text))
            {
                BL.User loggedUser = BL.User.ReturnUserByCredentials(UsernameBox.Text, PasswordBox.Text);
                Session["UserID"] = loggedUser.ID;
                Response.Redirect("Login.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "prompt", "prompt('Password or Username are incorrect')", true);
            }
        }
    }
}