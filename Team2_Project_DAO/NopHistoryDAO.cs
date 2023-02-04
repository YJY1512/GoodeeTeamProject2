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
    public class NopHistoryDAO : IDisposable
    {
        SqlConnection conn;
        public NopHistoryDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<NopHistoryDTO> GetNopHistory(NopHistoryDTO item) //비가동이력 조회
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_NopHistory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DateFrom", item.DateFrom);
                    cmd.Parameters.AddWithValue("@DateTo", item.DateTo);

                    if (string.IsNullOrWhiteSpace(item.Nop_Ma_Code)) cmd.Parameters.AddWithValue("@Ma_Code", $"%%");
                    else cmd.Parameters.AddWithValue("@Ma_Code", $"%{item.Nop_Ma_Code}%");

                    if (string.IsNullOrWhiteSpace(item.Nop_Ma_Name)) cmd.Parameters.AddWithValue("@Ma_Name", $"%%");
                    else cmd.Parameters.AddWithValue("@Ma_Name", $"%{item.Nop_Ma_Name}%");

                    conn.Open();
                    List<NopHistoryDTO> list = Helper.DataReaderMapToList<NopHistoryDTO>(cmd.ExecuteReader());
                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
