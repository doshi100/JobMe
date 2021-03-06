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
        /// <summary>
        /// returns a list of jobs.
        /// </summary>
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

        /// <summary>
        /// add Job Offer to the DB
        /// </summary>
        [WebMethod]
        public bool AddJobOffer(string username, string password, JobOffer offer)
        {
            if(LogIn(username, password))
            {
                return JobOffer.AddOfferWS(username, offer.Phone, offer.Company, offer.Position);
            }
            return false;
        }


        /// <summary>
        /// Count how many job offers are in the DB
        /// </summary>
        [WebMethod]
        public int countOffers()
        {
            return JobOffer.countOffers();
        }


        /// <summary>
        /// Gets The user First name from the db by the username provided
        /// </summary>
        [WebMethod]
        public string getUserFName(string username)
        {
            return BL.User.GetUserFName(username);
        }


        /// <summary>
        /// returns a User 
        /// </summary>
        [WebMethod]
        public UserWS GetUser(string username)
        {
            return BL.UserWS.ReturnUser(username);
        }


    }
}
