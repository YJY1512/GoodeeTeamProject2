using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DTO;

namespace Team2_Project_DAO
{
    public class PopWorkOrderDAO : IDisposable
    {
        SqlConnection conn;

        public PopWorkOrderDAO()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connStr);
        }

        public void Dispose()
        {
            if(conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<WorkOrderDTO> GetWorkOrders(string Wc_Code)
        {
            List<WorkOrderDTO> result = new List<WorkOrderDTO>();

            using (SqlCommand cmd = new SqlCommand("SP_PopWorkOrderList", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wc_code", Wc_Code);

                conn.Open();
                result = Helper.DataReaderMapToList<WorkOrderDTO>(cmd.ExecuteReader());
                conn.Close();

                return result;
            }
        }

        public List<WorkOrderDTO> StartWork(WorkOrderDTO work)
        {
            List<WorkOrderDTO> result = new List<WorkOrderDTO>();

            using (SqlCommand cmd = new SqlCommand("SP_PopUpdateWorkOrderList", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wo_Status", work.Wo_Status);
                cmd.Parameters.AddWithValue("@Prd_Date", work.Prd_Date);
                cmd.Parameters.AddWithValue("@Prd_Qty", work.Prd_Qty);
                cmd.Parameters.AddWithValue("@Prd_StartTime", work.Prd_StartTime);
                cmd.Parameters.AddWithValue("@Prd_EndTime", work.Prd_EndTime);
                cmd.Parameters.AddWithValue("@Worker_CloseTime", work.Worker_CloseTime);
                cmd.Parameters.AddWithValue("@Prd_Plan_No", work.Prd_Plan_No);
                cmd.Parameters.AddWithValue("@Wc_code", work.Wc_Code);

                conn.Open();
                result = Helper.DataReaderMapToList<WorkOrderDTO>(cmd.ExecuteReader());
                conn.Close();

                return result;
            }
        }

    }
}
