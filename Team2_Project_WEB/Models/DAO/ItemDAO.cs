using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Team2_Project_WEB.Models;

namespace Team2_Project_WEB.Models.DAO
{
    public class ItemDAO : IDisposable
    {
        SqlConnection conn = null;

        public ItemDAO()
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

        public List<ItemVO> GetItemList(string from, string to)
        {
            string sql = @"with OrderData as
                            (
	                            select Item_Code, sum(Req_Qty) OrderSum, Count(distinct Prj_No) ProjCnt
	                            from Production_Req 
	                            where Req_Date between @fromDate and @toDate
	                            group by Item_Code
                            )
                            , ResultWithoutRatio as
                            (
	                            select im.Item_Code, Item_Name, isnull(OrderSum, 0) OrderSum, isnull(ProjCnt, 0) ProjCnt, round(convert(decimal, isnull(OrderSum, 0)) / (select sum(OrderSum) from OrderData), 2) * 100 ratio
	                            from Item_Master im left outer join OrderData od on im.Item_Code = od.Item_Code
	                            where Item_Type = 'PR'
                            )

                            select Item_Code Code, Item_Name Name, OrderSum, ProjCnt CustomerSum, ratio Ratio
                            from ResultWithoutRatio
                            order by OrderSum DESC, ProjCnt DESC, Item_Code";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@fromDate", from);
                cmd.Parameters.AddWithValue("@toDate", to);

                SqlDataReader reader = cmd.ExecuteReader();
                List<ItemVO> list = Helper.DataReaderMapToList<ItemVO>(reader);
                reader.Close();

                return list;
            }
        }

        public List<ItemVO> GetItemCodeNameList()
        {
            string sql = "select Item_Code Code, Item_Name Name from Item_Master where Use_YN = 'Y'";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ItemVO> list = Helper.DataReaderMapToList<ItemVO>(reader);
                reader.Close();

                return list;
            }
        }
    }
}