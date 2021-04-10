using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using System.Text.RegularExpressions;

namespace BL
{
    public class JobOffer
    {
        public int OfferID;
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        /// <summary>
        /// constructor that builds an offer from a datarow
        /// </summary>
        /// <param name="row"></param>
        public JobOffer(DataRow row)
        {
            this.OfferID = (int)row["OfferID"];
            this.UserID = (int)row["UserID"];
            this.FirstName = (string)row["FirstName"];
            this.Phone = (string)row["Phone"];
            this.Company = (string)row["Company"];
            this.Position = (string)row["Position"];
        }

        /// <summary>
        /// empty constructor
        /// </summary>
        public JobOffer()
        {

        }

        /// <summary>
        /// add offer thorugh site
        /// </summary>
        public static int AddOffer(int userID, string phone, string company, string pos)
        {
            return OfferDB.AddOffer(userID, phone, company, pos);
        }
        /// <summary>
        /// add offer thorugh WS
        /// </summary>
        public static bool AddOfferWS(string username, string phone, string company, string pos)
        {
            Regex rg = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            if (rg.IsMatch(phone) && company != "" && pos != "")
            {
                return OfferDB.AddOfferWS(username, phone, company, pos);
            }
            return false;
        }
        /// <summary>
        /// get all offers of the site.
        /// </summary>
        public static List<JobOffer> GetOffers()
        {
            DataTable dt = OfferDB.GetOffers();
            List<JobOffer> jobs = new List<JobOffer>();
            foreach (DataRow row in dt.Rows)
            {
                JobOffer offer = new JobOffer(row);
                jobs.Add(offer);
            }
            return jobs;
        }
        /// <summary>
        /// count the offers in the site.
        /// </summary>
        public static int countOffers()
        {
            return OfferDB.countOffers();
        }
    }
}
