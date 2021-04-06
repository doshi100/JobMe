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

        public UserWS()
        {

        }

        public UserWS(DataRow row)
        {
            this.FirstName = (string)row["FirstName"];
            this.username = (string)row["UserName"];
        }

        public static User ReturnUser(string userName)
        {
            DataRow rowUser = UserDB.ReturnUser(userName);
            if (rowUser != null)
            {
                User user1 = new User(rowUser);
                return user1;
            }
            User user = new User();
            return user;
        }
    }
}
