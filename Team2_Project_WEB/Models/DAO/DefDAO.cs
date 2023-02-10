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
    public class DefDAO : IDisposable
    {
        SqlConnection conn = null;
        int pageSize = int.Parse(WebConfigurationManager.AppSettings["list_pagesize"]);

        public DefDAO()
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

        public List<ProductionVO> GetDefList(string from, string to, string wcCode, string itemCode, int page, out int totalCount)
        {
            // 발생일시, 작업지시번호, 작업장명, 품목명, 불량현상 대분류명, 불량현상 상세분류명, 불량수량
            List<ProductionVO> list = new List<ProductionVO>();
            string sql = "SP_GetTotProdList";

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

                if (itemCode == null)
                    cmd.Parameters.AddWithValue("@ItemCode", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@ItemCode", itemCode);

                SqlParameter pOutput = new SqlParameter("@PO_TotalCnt", DbType.Int32);
                pOutput.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOutput);

                SqlDataReader reader = cmd.ExecuteReader();
                list = Helper.DataReaderMapToList<ProductionVO>(reader);
                reader.Close();

                totalCount = Convert.ToInt32(pOutput.Value);

                return list;
            }
        }
    }
}