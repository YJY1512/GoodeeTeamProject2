﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DTO;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace Team2_Project_DAO
{
    public class UserCodeDAO : IDisposable
    {
        SqlConnection conn;

        public UserCodeDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }
        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<UserCodeDTO> GetUserCode()
        {
            try
            {
                string sql = @"select ma.Userdefine_Ma_Code, Userdefine_Ma_Name, Userdefine_Mi_Code, Userdefine_Mi_Name,  
                                    Sort_Index, mi.Remark,
                                    case when mi.Use_YN = 'Y' then '예'
										when mi.Use_YN = 'N' then '아니오' end as Use_YN
                            from Userdefine_Mi_Master mi right outer join Userdefine_Ma_Master ma 
                                                        on mi.Userdefine_Ma_Code = ma.Userdefine_Ma_Code and ma.Use_YN = 'Y'";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    List<UserCodeDTO> list = Helper.DataReaderMapToList<UserCodeDTO>(cmd.ExecuteReader());

                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

    }
}
