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
            try 
            { 
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
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }

        }

        public List<WorkOrderDTO> StartWork(string work, string Wc_Code)
        {
            List<WorkOrderDTO> result = new List<WorkOrderDTO>();
            try 
            { 
                using (SqlCommand cmd = new SqlCommand("SP_PopUpdateWorkOrderList", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@WorkOrderNo", work);
                    cmd.Parameters.AddWithValue("@Wc_Code", Wc_Code);

                    conn.Open();
                    result = Helper.DataReaderMapToList<WorkOrderDTO>(cmd.ExecuteReader());
                    conn.Close();

                    return result;
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
