using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BL
{
    public class UserWS
    {
        public string FirstName { get; set; }
        public string username { get; set; }

        /// <summary>
        /// empty constructor
        /// </summary>
        public UserWS()
        {

        }
        /// <summary>
        /// build userWS by DataRow
        /// </summary>
        public UserWS(DataRow row)
        {
            this.FirstName = (string)row["FirstName"];
            this.username = (string)row["UserName"];
        }
        /// <summary>
        /// return UserWS by username
        /// </summary>
        public static UserWS ReturnUser(string userName)
        {
            DataRow rowUser = UserDB.ReturnUser(userName);
            if (rowUser != null)
            {
                UserWS user1 = new UserWS(rowUser);
                return user1;
            }
            UserWS user = new UserWS();
            return user;
        }
    }
}
