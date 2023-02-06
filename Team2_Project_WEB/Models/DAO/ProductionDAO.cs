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

        public List<ProductionVO> GetProdOList(string date)
        {
            string sql = @"with GetDefData as(
	                            select wo.WorkOrderNo, sum(Def_Qty) TotDef
	                            from WorkOrder wo inner join Def_History dh on wo.WorkOrderNo = dh.WorkOrderNo
	                            where convert(date, Plan_Date) = convert(date, @date)
	                            group by wo.WorkOrderNo
                            )

                            select wo.WorkOrderNo, convert(nvarchar(10), Plan_Date, 23) Plan_Date, ppd.Item_Code, Item_Name 
                                ,Plan_Qty_Box, round( convert( decimal, (isnull(prd_Qty, 0) + isnull(TotDef, 0))) / Plan_Qty_Box, 2 ) Progress, (isnull(prd_Qty, 0)) Prd_Qty, (isnull(TotDef, 0)) TotDef
                            from WorkOrder wo inner join Production_Plan_Detail ppd on wo.Prd_Plan_No = ppd.Prd_Plan_No
	                            inner join Item_Master im on ppd.Item_Code = im.Item_Code
	                            left outer join GetDefData gd on wo.WorkOrderNo = gd.WorkOrderNo
                            where convert(date, Plan_Date) = convert(date, @date)
                            order by wo.WorkOrderNo";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@date", date);

                SqlDataReader reader = cmd.ExecuteReader();
                List<ProductionVO> list = Helper.DataReaderMapToList<ProductionVO>(reader);
                reader.Close();

                return list;
            }
        }
    }
}