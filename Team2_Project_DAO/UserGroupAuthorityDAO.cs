using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Team2_Project_DTO;
using System.Configuration;
using System.Diagnostics;

namespace Team2_Project
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

        //검색조건 조회 And
        //public List<UserGroupAuthorityDTO> GetUserGroupSearh(UserGroupAuthorityDTO uga)
        //{

        //}

        public bool InsertUserGroup(UserGroupAuthorityDTO uga)
        {
            try
            {
                string sql = @"Insert Into UserGroup_Master(UserGroup_Code, UserGroup_Name, Use_YN, Ins_Date, Ins_Emp)
                               Values (@UserGroup_Code, @UserGroup_Name, @Use_YN, getdate(), @Ins_Emp)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserGroup_Code", uga.UserGroup_Code);
                cmd.Parameters.AddWithValue("@UserGroup_Name", uga.UserGroup_Name);
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
    }
}
