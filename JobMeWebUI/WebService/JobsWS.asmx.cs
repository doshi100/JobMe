using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BL;

namespace WebService
{
    /// <summary>
    /// Summary description for JobsWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class JobsWS : System.Web.Services.WebService
    {

        [WebMethod]
        public List<JobOffer> ReturnJobOffers()
        {
            return JobOffer.GetOffers();
        }

        /// <summary>
        /// returns true if there is a user by that name and password.
        /// </summary>
        [WebMethod]
        public bool LogIn(string username, string password)
        {
            return BL.User.CheckCredentials(username, password);
        }

        [WebMethod]
        public void AddJobOffer(string username, string phone, string company, string pos)
        {
            JobOffer.AddOfferWS(username, phone, company, pos);
        }

        [WebMethod]
        public int countOffers()
        {
            return JobOffer.countOffers();
        }

        [WebMethod]
        public string getUserFName(string username)
        {
            return BL.User.GetUserFName(username);
        }


    }
}
