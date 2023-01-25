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

namespace Team2_Project_DAO
{
    public class WorkCenterDAO : IDisposable
    {
        SqlConnection conn;
        public WorkCenterDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }
        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public bool InsertWorkCenter(WorkCenterDTO wc)
        {
            try
            {
                string sql = @"Insert Into UserGroup_Master(UserGroup_Code, UserGroup_Name, Admin, Use_YN, Ins_Date, Ins_Emp)
                               Values (@UserGroup_Code, @UserGroup_Name, @Admin, @Use_YN, getdate(), @Ins_Emp)";
                SqlCommand cmd = new SqlCommand(sql, conn);


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
