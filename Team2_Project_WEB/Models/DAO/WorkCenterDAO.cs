using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Team2_Project_WEB.Models.DAO
{
    public class WorkCenterDAO : IDisposable
    {
        SqlConnection conn = null;

        public WorkCenterDAO()
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

        public List<CommonVO> GetWorkCenterCodeList()
        {
            string sql = "select Wc_Code Code, Wc_Name Name from WorkCenter_Master";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {                 
                return Helper.DataReaderMapToList<CommonVO>(cmd.ExecuteReader());
            }
        }
    }
}