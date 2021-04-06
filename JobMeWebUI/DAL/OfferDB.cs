using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class OfferDB
    {
        // GETS ALL THE OFFERS OFF THE DB
        public static DataTable GetOffers()
        {
            DBHelper helper = new DBHelper(Constants.PROVIDER, Constants.PATH);
            string sql = "SELECT Jobs.*, Users.UserName, Users.FirstName FROM Jobs INNER JOIN Users ON Jobs.UserID = Users.ID ORDER BY (Users.ID) DESC;";
            DataTable dt = helper.GetDataTable(sql);
            return dt;
        }


        public static int AddOffer(int userID, string phone, string company, string pos)
        {
            DBHelper helper = new DBHelper(Constants.PROVIDER, Constants.PATH);
            string sql = $"INSERT INTO [Jobs] ([UserID], [Phone], [Company], [Position]) VALUES ({userID}, '{phone}', '{company}', '{pos}');";
            int dtID = helper.InsertWithAutoNumKey(sql);
            return dtID;
        }


        /// <summary>
        /// used only after logging in, so the credentials are confirmed. (userName)
        /// </summary>
        public static int AddOfferWS(string userName, string phone, string company, string pos)
        {
            DBHelper helper = new DBHelper(Constants.PROVIDER, Constants.PATH);
            int userID = GetUserID(userName);
            string sql = $"INSERT INTO [Jobs] ([UserID], [Phone], [Company], [Position]) VALUES ({userID}, '{phone}', '{company}', '{pos}');";
            int dtID = helper.InsertWithAutoNumKey(sql);
            return dtID;
        }

        public static int countOffers()
        {
            DBHelper helper = new DBHelper(Constants.PROVIDER, Constants.PATH);
            string sql = $"SELECT COUNT(Jobs.OfferID) AS offers FROM Jobs;";
            DataTable dt = helper.GetDataTable(sql);
            return (int)dt.Rows[0]["offers"];
        }

        public static int GetUserID(string username)
        {
            DBHelper helper = new DBHelper(Constants.PROVIDER, Constants.PATH);
            string sql = $"SELECT * FROM Users WHERE UserName = '{username}';";
            DataTable dt = helper.GetDataTable(sql);
            return (int)dt.Rows[0]["ID"];
        }
    }
}
