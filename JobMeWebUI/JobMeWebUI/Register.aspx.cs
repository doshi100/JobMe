using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace JobMeWebUI
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void AddUser(object sender, EventArgs e)
        {
            if(UsernameBox.Text != "" && PasswordBox.Text != "")
            {
                if(!BL.User.CheckUserName(UsernameBox.Text))
                {
                    BL.User.AddUser(UsernameBox.Text, PasswordBox.Text, FirstNameBox.Text);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "prompt", "prompt('your selected Username is taken already, enter a different one.')", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "prompt", "prompt('please enter the provieded credentials.')", true);
            }
        }
    }
}