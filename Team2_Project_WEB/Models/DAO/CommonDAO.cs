using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Team2_Project_WEB.Models.DAO
{
    public class CommonDAO : IDisposable
    {
        SqlConnection conn = null;

        public CommonDAO()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        public string Login(string uid, string pwd)
        {
            string sql = @"select User_Name
                            from User_Master
                            where User_ID = @id and PWDCOMPARE(@pwd, User_PW) = 1";

            using(SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", uid);
                cmd.Parameters.AddWithValue("@pwd", pwd);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return reader["User_Name"].ToString();
                else
                    return "";
            }
        }
    }
}