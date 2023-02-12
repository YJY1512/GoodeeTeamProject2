using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Team2_Project_WEB.Models;
using System.Web.Configuration;

namespace Team2_Project_WEB.Models.DAO
{
    public class NopDAO : IDisposable
    {
        SqlConnection conn = null;
        int pageSize = int.Parse(WebConfigurationManager.AppSettings["list_pagesize"]);

        public NopDAO()
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

        public List<NopVo> GetNopList(string from, string to, string wcCode, int page, out int totalCount)
        {
            // 발생일자, 작업장명, 비가동 대분류명, 비가동 상세분류명, 비가동발생일시, 비가동해제일시, 비가동시간
            string sql = "SP_GetNopList";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@From", from);
                cmd.Parameters.AddWithValue("@To", to);
                cmd.Parameters.AddWithValue("@Page", page);
                cmd.Parameters.AddWithValue("@PageSize", pageSize);
                if (wcCode == null)
                    cmd.Parameters.AddWithValue("@WcCode", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@WcCode", wcCode);

                SqlParameter pOutput = new SqlParameter("@PO_TotalCnt", DbType.Int32);
                pOutput.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOutput);

                SqlDataReader reader = cmd.ExecuteReader();
                List<NopVo> list = Helper.DataReaderMapToList<NopVo>(reader);
                reader.Close();

                totalCount = Convert.ToInt32(pOutput.Value);

                return list;
            }
        }
    }
}