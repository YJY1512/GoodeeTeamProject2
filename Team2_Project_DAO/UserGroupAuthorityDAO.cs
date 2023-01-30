﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Team2_Project_DTO;
using System.Configuration;
using System.Diagnostics;

namespace Team2_Project_DAO
{
    public class UserGroupAuthorityDAO : IDisposable
    {
        SqlConnection conn;
        public UserGroupAuthorityDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        
        public List<UserGroupAuthorityDTO> GetUserGroupCodeSearh()
        {
            try
            {
                string sql = @"select UserGroup_Code, UserGroup_Name, 
                               case when Admin = 'Y' then '예' when Admin = 'N' then '아니오' end as Admin, 
                               case when Use_YN = 'Y' then '예' when Use_YN = 'N' then '아니오' end as Use_YN 
                               from UserGroup_Master";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    List<UserGroupAuthorityDTO> list = Helper.DataReaderMapToList<UserGroupAuthorityDTO>(cmd.ExecuteReader());
                    conn.Close();

                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public bool FindSamePK(string userGrpCode)
        {
            try
            {
                string sql = @"select count(*) cnt
                               from UserGroup_Master
                               where UserGroup_Code = @UserGroup_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@UserGroup_Code", userGrpCode);

                    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    return (cnt < 1);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }


        public bool InsertUserGroup(UserGroupAuthorityDTO uga) //추가
        {
            try
            {
                string sql = @"Insert Into UserGroup_Master(UserGroup_Code, UserGroup_Name, Admin, Use_YN, Ins_Date, Ins_Emp)
                               Values (@UserGroup_Code, @UserGroup_Name, @Admin, @Use_YN, getdate(), @Ins_Emp)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserGroup_Code", uga.UserGroup_Code);
                cmd.Parameters.AddWithValue("@UserGroup_Name", uga.UserGroup_Name);
                cmd.Parameters.AddWithValue("@Admin", uga.Admin);
                cmd.Parameters.AddWithValue("@Use_YN", uga.Use_YN);
                cmd.Parameters.AddWithValue("@Ins_Emp", uga.Ins_Emp);

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool UpdateUserGroup(UserGroupAuthorityDTO uga) //수정
        {
            string sql1 = @"update UserGroup_Master
                           set UserGroup_Name = @UserGroup_Name, Admin = @Admin, Use_YN = @Use_YN, Up_Date = GetDate(), Up_Emp=@Up_Emp
                           where UserGroup_Code = @UserGroup_Code";
            string sql2 = @"update UserGroup_Mapping
                           set User_ID = @User_ID, Up_Date = GetDate(), Up_Date = GetDate(), Up_Emp = @Up_Emp
                           where UserGroup_Code = @UserGroup_Code";

            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = sql1;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@UserGroup_Name", uga.UserGroup_Name);
                    cmd.Parameters.AddWithValue("@Admin", uga.Admin);
                    cmd.Parameters.AddWithValue("@Use_YN", uga.Use_YN);
                    cmd.Parameters.AddWithValue("@Up_Emp", uga.Up_Emp);
                    cmd.Parameters.AddWithValue("@UserGroup_Code", uga.UserGroup_Code);
                    cmd.Transaction = trans;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }

                    cmd.Parameters.Clear();

                    cmd.CommandText = sql2;
                    cmd.Parameters.AddWithValue("@User_ID", uga.User_ID);
                    cmd.Parameters.AddWithValue("@Up_Emp", uga.Up_Emp);
                    cmd.Parameters.AddWithValue("@UserGroup_Code", uga.UserGroup_Code);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }

                    trans.Commit();
                }
                return true;
            }
            catch 
            {
                trans.Rollback();
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public int DeleteUserGroup(string userGrpCode) //삭제
        {
            try
            {
                string sql = @"delete from UserGroup_Master
                               where UserGroup_Code = @UserGroup_Code";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@UserGroup_Code", userGrpCode);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
