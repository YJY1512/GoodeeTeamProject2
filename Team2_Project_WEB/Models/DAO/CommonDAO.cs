﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ShoppingMallMVC.Models.DAO
{
    public class CommonDAO : IDisposable
    {
        SqlConnection conn = null;

        public CommonDAO()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        public UserVO Login(string uid, string pwd)
        {
            string sql = @"select user_id, user_pwd, user_name, auth_name
                            from Userinfo u inner join Authority a on u.auth_id = a.auth_id
                            where user_id = @uid and user_pwd = @pwd";

            using(SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@uid", uid);
                cmd.Parameters.AddWithValue("@pwd", pwd);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new UserVO
                    {
                        UserId = reader["user_id"].ToString(),
                        UserPwd = reader["user_pwd"].ToString(),
                        UserName = reader["user_name"].ToString(),
                        AuthName = reader["auth_name"].ToString()
                    };
                }
                else
                    return null;
            }
        }
    }
}