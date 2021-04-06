using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BL
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public User(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.FirstName = (string)row["FirstName"];
            this.username = (string)row["UserName"];
            this.password = (string)row["Password"];
        }

        public User()
        {

        }

        public static int AddUser(string userName, string password, string firstname)
        {
            return UserDB.AddUser(userName, password, firstname);
        }

        public static bool CheckCredentials(string userName, string password)
        {
            return UserDB.CheckCredentials(userName, password);
        }

        public static bool CheckUserName(string userName)
        {
            return UserDB.CheckUserName(userName);
        }

        public static User ReturnUserByCredentials(string userName, string password)
        {
            DataRow row = UserDB.ReturnUserByCredentials(userName, password);
            User newuser = new User(row);
            return newuser;
        }

        public static string GetUserFName(string username)
        {
            return UserDB.GetUserFName(username);
        }

    }
}
