using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Team2_Project_DTO;
using System.Diagnostics;

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

        public bool Insert(EmployeeDTO data, string Ins_Emp)
        {
            Ins_Emp = "1000"; //나중에 수정!!!

            string sql1 = @"insert into User_Master (User_ID, User_Name, User_PW, User_Type, PW_Reset_Count, Use_YN, Ins_Date, Ins_Emp, Up_Date, Up_Emp)
values (@User_ID, @User_Name, @User_ID, @User_Type, 0, @Use_YN, getdate(), @Ins_Emp, getdate(), @Ins_Emp)";

            string sql2 = @"insert into UserGroup_Mapping (UserGroup_Code, User_ID, Ins_Date, Ins_Emp, Up_Date, Up_Emp)
values (@UserGroup_Code, @User_ID, getdate(), @Ins_Emp, getdate(), @Ins_Emp)";

            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = sql1;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@User_ID", data.User_ID);
                    cmd.Parameters.AddWithValue("@User_Name", data.User_Name);
                    cmd.Parameters.AddWithValue("@User_Type", data.User_Type);
                    cmd.Parameters.AddWithValue("@Use_YN", data.Use_YN);
                    cmd.Parameters.AddWithValue("@Ins_Emp", Ins_Emp);
                    cmd.Transaction = trans;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }

                    cmd.Parameters.Clear();

                    cmd.CommandText = sql2;
                    cmd.Parameters.AddWithValue("@UserGroup_Code", data.UserGroup_Code);
                    cmd.Parameters.AddWithValue("@User_ID", data.User_ID);
                    cmd.Parameters.AddWithValue("@Ins_Emp", Ins_Emp);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }

                    trans.Commit();
                }

                return true;
            }
            catch(Exception err)
            {
                trans.Rollback();
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public bool Update(EmployeeDTO data, string Ins_Emp)
        {
            Ins_Emp = "1000"; //나중에 수정!!!

            string sql1 = @"update User_Master
                            set User_Name = @User_Name, User_Type = @User_Type, Use_YN = @Use_YN, Up_Date = getdate(), Up_Emp = @Up_Emp
                            where User_ID = @User_ID";

            string sql2 = @"update UserGroup_Mapping
                            set UserGroup_Code = @UserGroup_Code, Up_Date = getdate(), Up_Emp = @Up_Emp
                            where User_ID = @User_ID";

            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = sql1;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@User_ID", data.User_ID);
                    cmd.Parameters.AddWithValue("@User_Name", data.User_Name);
                    cmd.Parameters.AddWithValue("@User_Type", data.User_Type);
                    cmd.Parameters.AddWithValue("@Use_YN", data.Use_YN);
                    cmd.Parameters.AddWithValue("@Up_Emp", Ins_Emp);
                    cmd.Transaction = trans;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }

                    cmd.Parameters.Clear();

                    cmd.CommandText = sql2;
                    cmd.Parameters.AddWithValue("@UserGroup_Code", data.UserGroup_Code);
                    cmd.Parameters.AddWithValue("@User_ID", data.User_ID);
                    cmd.Parameters.AddWithValue("@Up_Emp", Ins_Emp);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }

                    trans.Commit();
                }

                return true;
            }
            catch(Exception err)
            {
                trans.Rollback();
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public bool Delete(string empID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SP_UserDelete";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@User_ID", empID);
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }
    }
}
