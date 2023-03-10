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
    public class PlanDAO : IDisposable
    {
        SqlConnection conn;

        public PlanDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable GetPrdReq(string from, string to)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_GetPrdReq", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@from", from);
                da.SelectCommand.Parameters.AddWithValue("@to", to);

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

        public bool InsertReqPlan(List<PlanDTO> plans)
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();

            try
            {                
                using (SqlCommand cmd = new SqlCommand("SP_InsertReqPlan", conn))
                {                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Emp", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Plan_Qty", SqlDbType.Int);
                    cmd.Parameters.Add("@Plan_Rest_Qty", SqlDbType.Int);
                    cmd.Parameters.Add("@Prd_Req_No", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Item_Code", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Wc_Code", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Plan_Month", SqlDbType.NVarChar);
                    cmd.Transaction = trans;

                    cmd.Parameters.Add("@PO_CD", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PO_MSG", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;

                    foreach (var plan in plans)
                    {
                        cmd.Parameters["@Emp"].Value = plan.Ins_Emp;
                        cmd.Parameters["@Plan_Qty"].Value = plan.Plan_Qty;
                        cmd.Parameters["@Plan_Rest_Qty"].Value = plan.Plan_Rest_Qty;
                        cmd.Parameters["@Prd_Req_No"].Value = plan.Prd_Req_No;
                        cmd.Parameters["@Item_Code"].Value = plan.Item_Code;
                        cmd.Parameters["@Wc_Code"].Value = plan.Wc_Code;
                        cmd.Parameters["@Plan_Month"].Value = plan.Plan_Month;
                        
                        cmd.ExecuteNonQuery();                        

                        string pMsg = cmd.Parameters["@PO_MSG"].Value.ToString();
                        int pCode = Convert.ToInt32(cmd.Parameters["@PO_CD"].Value);
                        if (pCode != 1)
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

        public DataTable GetPlan(string planMonth)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_GetPlan", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
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

        public bool InsertPlan(PlanDTO plan)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_InsertPlan", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Emp", plan.Ins_Emp);
                    cmd.Parameters.AddWithValue("@Plan_Qty", plan.Plan_Qty);
                    cmd.Parameters.AddWithValue("@Plan_Rest_Qty", plan.Plan_Rest_Qty);
                    cmd.Parameters.AddWithValue("@Item_Code", plan.Item_Code);
                    cmd.Parameters.AddWithValue("@Wc_Code", plan.Wc_Code);
                    cmd.Parameters.AddWithValue("@Plan_Month", plan.Plan_Month);

                    cmd.Parameters.Add("@PO_CD", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PO_MSG", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;

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

        public int DeletePlan(string planID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeletePlan", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Prd_Plan_No", planID);
                    
                    cmd.Parameters.Add("@PO_CD", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PO_MSG", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    string pMsg = cmd.Parameters["@PO_MSG"].Value.ToString();
                    int pCode = Convert.ToInt32(cmd.Parameters["@PO_CD"].Value);
                    
                    return pCode;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return -1;
            }
        }

        public int UpdatePlan(PlanDTO plan)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_UpdatePlan", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Prd_Plan_No", plan.Prd_Plan_No);
                    cmd.Parameters.AddWithValue("@Plan_Qty", plan.Plan_Qty);
                    cmd.Parameters.AddWithValue("@Up_Emp", plan.Up_Emp);

                    cmd.Parameters.Add("@PO_CD", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PO_MSG", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    string pMsg = cmd.Parameters["@PO_MSG"].Value.ToString();
                    int pCode = Convert.ToInt32(cmd.Parameters["@PO_CD"].Value);

                    return pCode;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return -1;
            }
        }

        public bool SplitPlan(PlanDTO plan)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_SplitPlan", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Prd_Plan_No", plan.Prd_Plan_No);
                    cmd.Parameters.AddWithValue("@Emp", plan.Ins_Emp);
                    cmd.Parameters.AddWithValue("@Item_Code", plan.Item_Code);
                    cmd.Parameters.AddWithValue("@SplitQty", plan.Plan_Qty);
                    cmd.Parameters.AddWithValue("@Wc_Code", plan.Wc_Code);

                    cmd.Parameters.Add("@PO_CD", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PO_MSG", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;

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

        public bool ClosePlan(string planID, string empID)
        {
            try
            {
                string sql = @"update Production_Plan_Detail
                                set Prd_Plan_Status = 'C',
                                	Up_Date = GETDATE(),
                                	Up_Emp = @Up_Emp
                                where Prd_Plan_No = @Prd_Plan_No";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {                    
                    cmd.Parameters.AddWithValue("@Prd_Plan_No", planID);
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

        public bool CloseCancel(string planID, string empID)
        {
            try
            {
                string sql = @"update Production_Plan_Detail
                                set Prd_Plan_Status = case when (select count(Wo_Status) from WorkOrder 
                                                                where Prd_Plan_No = @Prd_Plan_No and Wo_Status <> 'W01') > 0 
                                                        then 'B' else 'D' end,
                                	Up_Date = GETDATE(),
                                	Up_Emp = @Up_Emp
                                where Prd_Plan_No = @Prd_Plan_No";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Prd_Plan_No", planID);
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

        public List<PlanHeaderDTO> GetPlanHeader()
        {
            try
            {
                string sql = @"select top 6 Plan_Month, Plan_Title 
                                from Production_Plan_Header
                                where SUBSTRING(Plan_Month, 1, 4) = @year
                                order by Plan_Month desc";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@year", DateTime.Today.Year.ToString());
                    List<PlanHeaderDTO> list = Helper.DataReaderMapToList<PlanHeaderDTO>(cmd.ExecuteReader());
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

        public int UpsertPlanHeader(PlanHeaderDTO planHeader)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_UpsertPlanHeader", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Plan_Month", planHeader.Plan_Month);
                    cmd.Parameters.AddWithValue("@Plan_Title", planHeader.Plan_Title);
                    cmd.Parameters.AddWithValue("@Emp", planHeader.Ins_Emp);

                    cmd.Parameters.Add("@PO_CD", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PO_MSG", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    string pMsg = cmd.Parameters["@PO_MSG"].Value.ToString();
                    int pCode = Convert.ToInt32(cmd.Parameters["@PO_CD"].Value);

                    return pCode;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return -1;
            }
        }

        public int DelPlanHeader(string planMonth)
        {
            try
            {
                string sql = @"BEGIN TRY
                                delete Production_Plan_Header
                                where Plan_Month = @Plan_Month
                                END TRY
                                BEGIN CATCH
                                select @@ERROR
                                END CATCH";
          
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Plan_Month", planMonth);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    return result;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return -1;
            }
        }

        public string ChkStatus(string planID)
        {
            try
            {
                string sql = @"select Prd_Plan_Status
                                from Production_Plan_Detail
                                where Prd_Plan_No = @Prd_Plan_No";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Prd_Plan_No", planID);

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
