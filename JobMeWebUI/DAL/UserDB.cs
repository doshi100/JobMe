﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class UserDB
    {

        public static DataRow ReturnUser(string userName)
        {
            DBHelper helper = new DBHelper(Constants.PROVIDER, Constants.PATH);
            string sql = $"SELECT * FROM Users WHERE Users.UserName = {userName}";
            DataTable dt = helper.GetDataTable(sql);
            if(dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }
        public static int AddUser(string userName, string password, string firstname)
        {
            DBHelper helper = new DBHelper(Constants.PROVIDER, Constants.PATH);
            string sql = $"INSERT INTO Users ([UserName], [Password], [FirstName]) VALUES ('{userName}', '{password}', '{firstname}');";
            int dtID = helper.InsertWithAutoNumKey(sql);
            return dtID;
        }

        public static bool CheckCredentials(string userName, string password)
        {
            DBHelper helper = new DBHelper(Constants.PROVIDER, Constants.PATH);
            string sql = $"SELECT * FROM Users WHERE UserName = '{userName}' AND Password = '{password}'";
            DataTable dt = helper.GetDataTable(sql);
            return dt.Rows.Count > 0;
        }

        public static DataRow ReturnUserByCredentials(string userName, string password)
        {
            DBHelper helper = new DBHelper(Constants.PROVIDER, Constants.PATH);
            string sql = $"SELECT * FROM Users WHERE UserName = '{userName}' AND Password = '{password}'";
            DataTable dt = helper.GetDataTable(sql);
            if(dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public static bool CheckUserName(string userName)
        {
            DBHelper helper = new DBHelper(Constants.PROVIDER, Constants.PATH);
            string sql = $"SELECT * FROM Users WHERE UserName = '{userName}'";
            DataTable dt = helper.GetDataTable(sql);
            return dt.Rows.Count > 0;
        }

        public static string GetUserFName(string username)
        {
            DBHelper helper = new DBHelper(Constants.PROVIDER, Constants.PATH);
            string sql = $"SELECT * FROM Users WHERE UserName = '{username}'";
            DataTable dt = helper.GetDataTable(sql);
            return (string)dt.Rows[0]["FirstName"];
        }
    }
}
