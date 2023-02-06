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

        public bool InserWorkOrder(WorkOrderDTO workOrder)
        {            
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_InsertWorkOrder", conn))
                {
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Prd_Plan_No", workOrder.Prd_Plan_No);
                    cmd.Parameters.AddWithValue("@Wc_Code", workOrder.Wc_Code);
                    cmd.Parameters.AddWithValue("@Plan_Qty_Box", workOrder.Plan_Qty_Box);
                    cmd.Parameters.AddWithValue("@Ins_Emp", workOrder.Ins_Emp);
                    cmd.Parameters.AddWithValue("@Plan_Date", workOrder.Plan_Date);

                    cmd.Parameters.Add("@PO_CD", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PO_MSG", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    string pMsg = cmd.Parameters["@PO_MSG"].Value.ToString();
                    int pCode = Convert.ToInt32(cmd.Parameters["@PO_CD"].Value);
                    if (pCode < 0)
                    {
                        throw new Exception(pMsg);
                    }

                    return true;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }

        }

        public DataTable GetSiyuWorkOrder(string planMonth)
        {
            try
            {
                string sql = @"select WorkOrderNo, Plan_Date, Plan_Qty_Box, d.Item_Code, i.Item_Name, 
                                    wo.Wc_Code, wc.Wc_Name, s.Sys_Mi_Name Wo_Status, Prd_Date, Prd_Qty, wo.Prd_Plan_No, wo.Remark, wo.Wo_Status Wo_Status_code
                                from WorkOrder wo inner join WorkCenter_Master wc on wo.Wc_Code = wc.Wc_Code
                                				inner join Production_Plan_Detail d on wo.Prd_Plan_No = d.Prd_Plan_No and d.Plan_Month = @Plan_Month
                                				inner join Item_Master i on d.Item_Code = i.Item_Code
												inner join Sys_Mi_Master s on s.Sys_Mi_Code = wo.Wo_Status and s.Sys_Ma_Code = 'WO_STATUS'";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@Plan_Month", planMonth);

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

        public List<WorkOrderDTO> GetWorkOrder(string start, string end)
        {
            return null;
        }

        public bool UpdateWorkOrder(List<WorkOrderDTO> workOrders)
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"update WorkOrder
                               set Plan_Qty_Box = @Plan_Qty_Box,
                               		Plan_Date = @Plan_Date,
                               		Wc_Code = @Wc_Code,
                               		Up_Date = GETDATE(),
                               		Up_Emp = @Up_Emp
                               where WorkOrderNo = @WorkOrderNo";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {                    
                    cmd.Parameters.Add("@Up_Emp", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Plan_Qty_Box", SqlDbType.Int);
                    cmd.Parameters.Add("@Plan_Date", SqlDbType.Date);
                    cmd.Parameters.Add("@Wc_Code", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@WorkOrderNo", SqlDbType.NVarChar);
                    cmd.Transaction = trans;

                    foreach (var wo in workOrders)
                    {
                        cmd.Parameters["@Up_Emp"].Value = wo.Up_Emp;
                        cmd.Parameters["@Plan_Qty_Box"].Value = wo.Plan_Qty_Box;
                        cmd.Parameters["@Plan_Date"].Value = wo.Plan_Date;
                        cmd.Parameters["@Wc_Code"].Value = wo.Wc_Code;
                        cmd.Parameters["@WorkOrderNo"].Value = wo.WorkOrderNo;

                        int iRowAffet = cmd.ExecuteNonQuery();

                        if (iRowAffet < 1)
                        {
                            throw new Exception();
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

        public bool DeleteWorkOrder(List<string> delWoIDs, string empId)
        {
            try
            {
                string delIds = string.Join("@", delWoIDs);
                using (SqlCommand cmd = new SqlCommand("SP_DeleteWorkOrder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@WorkOrderNo", delIds);
                    cmd.Parameters.AddWithValue("@Up_Emp", empId);

                    cmd.Parameters.Add("@PO_CD", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PO_MSG", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    string pMsg = cmd.Parameters["@PO_MSG"].Value.ToString();
                    int pCode = Convert.ToInt32(cmd.Parameters["@PO_CD"].Value);
                    if (pCode < 0)
                    {
                        throw new Exception(pMsg);
                    }

                    return true;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

    }
}
