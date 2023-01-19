using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Team2_Project_DAO
{
    public class EmployeeDAO : IDisposable
    {
        string connStr = null;
        SqlConnection conn;

        public EmployeeDAO()
        {
            connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {   
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable GetEmployeeList()
        {
            string sql = @"select u.User_ID, User_Name, 
                                case when User_Type = 'A' then '관리자'
                                     else '일반' end User_Type, 
                                umas.UserGroup_Code, umas.UserGroup_Name,
                                case when u.Use_YN = 'Y' then '재직'
                                    else '퇴직' end Use_YN
                        from UserGroup_Mapping umap inner join User_Master u on umap.User_ID = u.User_ID
                               inner join UserGroup_Master umas on umap.UserGroup_Code = umas.UserGroup_Code";

            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Insert()
        {
            //string sql = @"";

            //using (SqlCommand cmd = new SqlCommand(sql, conn))
            //{
            //    cmd.Parameters.AddWithValue("@, )
            //    cmd.ExecuteNonQuery();
            //}
        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}
