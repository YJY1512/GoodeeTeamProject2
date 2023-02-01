using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Team2_Project_DTO;

namespace Team2_Project_DAO
{
    public class DashboardDAO : IDisposable
    {
        SqlConnection conn;
        public DashboardDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        
        public bool UpdateDashboardMapping() //사용자 대시보드 매핑 UPDATE
        {
            try
            {
                string sql = @"update 
                                set 
                                where ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //cmd.Parameters.AddWithValue("@", );

                    conn.Open();
                    int iRowAffect = cmd.ExecuteNonQuery();
                    conn.Close();
                    return (iRowAffect > 0);
                }
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
