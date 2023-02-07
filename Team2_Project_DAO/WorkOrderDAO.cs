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

        public bool InserSiyuWorkOrder(WorkOrderDTO workOrder)
        {            
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_InsertSiyuWorkOrder", conn))
                {
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Prd_Plan_No", workOrder.Prd_Plan_No);
                    cmd.Parameters.AddWithValue("@Wc_Code", workOrder.Wc_Code);
                    cmd.Parameters.AddWithValue("@Item_Code", workOrder.Item_Code);
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
                    if (pCode != 1)
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

        public bool InserWorkOrder(WorkOrderDTO workOrder)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_InsertWorkOrder", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Wc_Code", workOrder.Wc_Code);
                    cmd.Parameters.AddWithValue("@Item_Code", workOrder.Item_Code);
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
                    if (pCode != 1)
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
            try
            {
                string sql = @"select WorkOrderNo, Plan_Qty_Box, Plan_Date, wo.Wc_Code, wc.Wc_Name, wo.Item_Code, i.Item_Name, s.Sys_Mi_Name Wo_Status, 
                                        Prd_Date, Prd_Qty, wo.Wo_Status Wo_Status_Code,  wc.Process_Code, p.Process_Name
                                from WorkOrder wo inner join WorkCenter_Master wc on wo.Wc_Code = wc.Wc_Code
                                					inner join Process_Master p on wc.Process_Code = p.Process_Code
                                					inner join Item_Master i on wo.Item_Code = i.Item_Code
                                					inner join Sys_Mi_Master s on s.Sys_Mi_Code = wo.Wo_Status and s.Sys_Ma_Code = 'WO_STATUS'
                                where Plan_Date between @start and @end";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    conn.Open();
                    List<WorkOrderDTO> list = Helper.DataReaderMapToList<WorkOrderDTO>(cmd.ExecuteReader());
                    conn.Close();

                    return list;
                }

            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        //시유 작업지시용
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
                                    Item_Code = @Item_Code,
                               		Up_Date = GETDATE(),
                               		Up_Emp = @Up_Emp
                               where WorkOrderNo = @WorkOrderNo";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {                    
                    cmd.Parameters.Add("@Up_Emp", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Plan_Qty_Box", SqlDbType.Int);
                    cmd.Parameters.Add("@Plan_Date", SqlDbType.Date);
                    cmd.Parameters.Add("@Wc_Code", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Item_Code", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@WorkOrderNo", SqlDbType.NVarChar);
                    cmd.Transaction = trans;

                    foreach (var wo in workOrders)
                    {
                        cmd.Parameters["@Up_Emp"].Value = wo.Up_Emp;
                        cmd.Parameters["@Plan_Qty_Box"].Value = wo.Plan_Qty_Box;
                        cmd.Parameters["@Plan_Date"].Value = wo.Plan_Date;
                        cmd.Parameters["@Wc_Code"].Value = wo.Wc_Code;
                        cmd.Parameters["@Item_Code"].Value = wo.Item_Code;
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

        public bool UpdateWorkOrder(WorkOrderDTO workOrder)
        {
            try
            {
                string sql = @"update WorkOrder
                               set Plan_Qty_Box = @Plan_Qty_Box,
                               		Plan_Date = @Plan_Date,
                               		Wc_Code = @Wc_Code,
                                    Item_Code = @Item_Code,
                               		Up_Date = GETDATE(),
                               		Up_Emp = @Up_Emp
                               where WorkOrderNo = @WorkOrderNo";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Wc_Code", workOrder.Wc_Code);
                    cmd.Parameters.AddWithValue("@Item_Code", workOrder.Item_Code);
                    cmd.Parameters.AddWithValue("@Plan_Qty_Box", workOrder.Plan_Qty_Box);
                    cmd.Parameters.AddWithValue("@Up_Emp", workOrder.Up_Emp);
                    cmd.Parameters.AddWithValue("@Plan_Date", workOrder.Plan_Date);
                    cmd.Parameters.AddWithValue("@WorkOrderNo", workOrder.WorkOrderNo);

                    conn.Open();
                    int iRowAffet = cmd.ExecuteNonQuery();
                    conn.Close();

                    return (iRowAffet > 0);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
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
                    if (pCode != 1)
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

        public bool CloseWorkOrder(List<string> woIDs, string empID)
        {
            try
            {
                string ids = string.Join("','", woIDs);
                string sql = $@"update WorkOrder
                                set Wo_Status = 'W05',
                                	Manager_CloseTime = GETDATE(),
                                	Up_Date = GETDATE(),
                                	Up_Emp = @Up_Emp
                                where WorkOrderNo in ('{ids}')";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Up_Emp", empID);

                    conn.Open();
                    int iRowAffect = cmd.ExecuteNonQuery();
                    conn.Close();

                    return (iRowAffect > 0);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public bool CloseCancel(List<string> woIDs, string empID)
        {
            try
            {
                string ids = string.Join("','", woIDs);
                string sql = $@"update WorkOrder
                                set Wo_Status = 'W04',
                                	Up_Date = GETDATE(),
                                	Up_Emp = @Up_Emp
                                where WorkOrderNo in ('{ids}')";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Up_Emp", empID);

                    conn.Open();
                    int iRowAffect = cmd.ExecuteNonQuery();
                    conn.Close();

                    return (iRowAffect > 0);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public bool UpdateMsg(Dictionary<string, string> woMsg, string empID)
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"update WorkOrder
                                set Remark = @Remark,
                                	Up_Date = GETDATE(),
                                	Up_Emp = @Up_Emp
                                where WorkOrderNo = @WorkOrderNo";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Up_Emp", empID);
                    cmd.Parameters.Add("@Remark", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@WorkOrderNo", SqlDbType.NVarChar);
                    cmd.Transaction = trans;

                    foreach (var msg in woMsg)
                    {
                        cmd.Parameters["@Remark"].Value = msg.Value;
                        cmd.Parameters["@WorkOrderNo"].Value = msg.Key;

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

        public string ChkStatus(string woID)
        {
            try
            {
                string sql = @"select Wo_Status
                                from WorkOrder
                                where WorkOrderNo = @WorkOrderNo";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@WorkOrderNo", woID);

                    string result = cmd.ExecuteScalar().ToString();
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
