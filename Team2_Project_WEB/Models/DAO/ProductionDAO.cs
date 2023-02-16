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
    public class ProductionDAO : IDisposable
    {
        SqlConnection conn = null;
        int pageSize = int.Parse(WebConfigurationManager.AppSettings["list_pagesize"]);

        public ProductionDAO()
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

        public List<ProductionVO> GetProdOList(string date, string itemCode, int page, out int totalCount)
        {
            List<ProductionVO> list = new List<ProductionVO>();
            string sql = "SP_GetProdOList";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Date", date);
                if(itemCode == null)
                    cmd.Parameters.AddWithValue("@ItemCode", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@ItemCode", itemCode);
                cmd.Parameters.AddWithValue("@Page", page);
                cmd.Parameters.AddWithValue("@PageSize", pageSize);

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

        public List<ProductionVO> GetProdList_TotProd(string from , string to, string wcCode, string itemCode, int page, out int totalCount)
        {
            // 작업일자, 작업수량, 양품수량, 불량수량, 양품률, 불량률, 작업시작시각, 작업종료시각, 작업시간, 시간당 생샨량
            List<ProductionVO> list = new List<ProductionVO>();
            string sql = "SP_GetTotProdList";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@From", from);
                cmd.Parameters.AddWithValue("@To", to);
                cmd.Parameters.AddWithValue("@Page", page);
                cmd.Parameters.AddWithValue("@PageSize", 7);
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