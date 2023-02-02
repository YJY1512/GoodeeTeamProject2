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
    public class WorkOrderDAO : IDisposable
    {
        SqlConnection conn;

        public WorkOrderDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public bool InserWorkOrder(List<WorkOrderDTO> workOrder)
        {
            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_InsertWorkOrder", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Prd_Req_No", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Wc_Code", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Plan_Qty_Box", SqlDbType.Int);
                    cmd.Parameters.Add("@Ins_Emp", SqlDbType.NVarChar);

                    cmd.Transaction = trans;

                    cmd.Parameters.Add("@PO_CD", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PO_MSG", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;

                    foreach (var wo in workOrder)
                    {
                        cmd.Parameters["@Prd_Req_No"].Value = wo.Ins_Emp;
                        cmd.Parameters["@Wc_Code"].Value = wo.Wc_Code;
                        cmd.Parameters["@Plan_Qty_Box"].Value = wo.Plan_Qty_Box;
                        cmd.Parameters["@Ins_Emp"].Value = wo.Ins_Emp;

                        cmd.ExecuteNonQuery();

                        string pMsg = cmd.Parameters["@PO_MSG"].Value.ToString();
                        int pCode = Convert.ToInt32(cmd.Parameters["@PO_CD"].Value);
                        if (pCode < 0)
                        {
                            throw new Exception(pMsg);
                        }
                    }

                    trans.Commit();
                    return true;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                trans.Rollback();
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable GetWorkOrder(List<string> planID)
        {
            try
            {
                string sql = @"select WorkOrderNo, Plan_Date, Plan_Qty_Box, d.Item_Code, i.Item_Name, 
                                    wo.Wc_Code, wc.Wc_Name, wo.Wo_Status, Prd_Date, Prd_Qty, wo.Prd_Plan_No
                                from WorkOrder wo inner join WorkCenter_Master wc on wo.Wc_Code = wc.Wc_Code
                                				inner join Production_Plan_Detail d on wo.Prd_Plan_No = d.Prd_Plan_No and d.Prd_Plan_No in (@planID)
                                				inner join Item_Master i on d.Item_Code = i.Item_Code";

                string Ids = $"%{string.Join(",", planID)}%";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("planID", Ids);

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();

                return dt;

            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

    }
}
