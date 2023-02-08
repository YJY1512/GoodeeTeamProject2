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
    public class ProductionDAO : IDisposable
    {
        SqlConnection conn = null;

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

        public List<ProductionVO> GetProdOList(string date, string itemCode, int page , int pagesize, out int totalCount)
        {
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
                cmd.Parameters.AddWithValue("@PageSize", pagesize);

                SqlParameter pOutput = new SqlParameter("@PO_TotalCnt", DbType.Int32);
                pOutput.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOutput);

                SqlDataReader reader = cmd.ExecuteReader();
                List<ProductionVO> list = Helper.DataReaderMapToList<ProductionVO>(reader);
                reader.Close();

                totalCount = Convert.ToInt32(pOutput.Value);

                return list;
            }
        }

        public List<string> GetProdNoList()
        {
            string sql = @"select top 10 WorkOrderNo 
                            from WorkOrder 
                            where Plan_Date between convert(varchar(10), dateadd(day, -7, getdate()), 23) 
                                                and convert(varchar(10), getdate(), 23)";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            { 
                SqlDataReader reader = cmd.ExecuteReader();
                //List<ProductionVO> list = Helper.DataReaderMapToList<ProductionVO>(reader);
                List<string> list = new List<string>();
                while (reader.Read())
                {
                    list.Add(reader["WorkOrderNo"].ToString());
                }
                reader.Close();

                return list;
            }
        }

        public List<string> GetProdList_TotProd()
        {
            //작업일자, 계획수량, 양품수량, 불량수량, 작업시작시각, 작업종료시각, 비가동시간, 가동률, 비가동률, 시간당 생샨량
            string sql = @"with GetDefData as(
	                            select wo.WorkOrderNo, sum(Def_Qty) TotDef
	                            from WorkOrder wo inner join Def_History dh on wo.WorkOrderNo = dh.WorkOrderNo
	                            where convert(date, Plan_Date) = convert(date, @date)
	                            group by wo.WorkOrderNo
                            )

                            select convert(nvarchar(10), Plan_Date, 23) Plan_Date, sum(Plan_Qty_Box) Plan_Qty_Box, (isnull(sum(prd_Qty), 0)) Prd_Qty, (isnull(sum(TotDef), 0)) TotDef
                                , CONVERT(VARCHAR(23), wo.Prd_StartTime, 8) Prd_StartTime, CONVERT(VARCHAR(23), wo.Prd_EndTime, 8) Prd_EndTime
                            from WorkOrder wo inner join Production_Plan_Detail ppd on wo.Prd_Plan_No = ppd.Prd_Plan_No
	                            inner join Item_Master im on ppd.Item_Code = im.Item_Code
	                            left outer join GetDefData gd on wo.WorkOrderNo = gd.WorkOrderNo
                            where convert(date, Plan_Date) = convert(date, @date)
                            group by convert(nvarchar(10), Plan_Date, 23)";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                //List<ProductionVO> list = Helper.DataReaderMapToList<ProductionVO>(reader);
                List<string> list = new List<string>();
                while (reader.Read())
                {
                    list.Add(reader["WorkOrderNo"].ToString());
                }
                reader.Close();

                return list;
            }
        }
    }
}