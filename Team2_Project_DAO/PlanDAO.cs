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
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_InsertReqPlan", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Emp", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Plan_Qty", SqlDbType.Int);
                    cmd.Parameters.Add("@Plan_Rest_Qty", SqlDbType.Int);
                    cmd.Parameters.Add("@Prd_Req_No", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Item_Code", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Wc_Code", SqlDbType.NVarChar);

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

                        cmd.ExecuteNonQuery();

                        string pMsg = cmd.Parameters["@PO_MSG"].Value.ToString();
                        int pCode = Convert.ToInt32(cmd.Parameters["@PO_CD"].Value);
                        if (pCode < 0)
                        {
                            throw new Exception(pMsg);
                        }
                    }

                    conn.Close();
                    return true;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public DataTable GetPlan(string planMonth)
        {
            try
            {
                string sql = @"with req_plan_alloc as
                                (
                                	select a.Prd_Req_No, Prd_Plan_No, pj.Company_Name, r.Delivery_Date
                                	from Prd_Req_Plan_Allocation a inner join Production_Req r on a.Prd_Req_No = r.Prd_Req_No
                                									inner join Project pj on r.Prj_No = pj.Prj_No
                                ), planDetail as
                                (
                                	select d.Prd_Plan_No, Plan_Month, d.Item_Code, i.Item_Name, d.Plan_Qty, Plan_Rest_Qty, d.Wc_Code, w.Wc_Name, s.Sys_Mi_Name Prd_Plan_Status
                                	from Production_Plan_Detail d inner join Item_Master i on d.Item_Code = i.Item_Code
                                								inner join WorkCenter_Master w on d.Wc_Code = w.Wc_Code
                                								inner join Sys_Mi_Master s on s.Sys_Mi_Code = d.Prd_Plan_Status and s.Sys_Ma_Code = 'PRD_PLAN_STATUS'
                                	where Plan_Month = @Plan_Month
                                ) select D.*, A.Company_Name, A.Delivery_Date
                                from planDetail D left outer join req_plan_alloc A on D.Prd_Plan_No = A.Prd_Plan_No";
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

                    cmd.Parameters.Add("@PO_CD", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PO_MSG", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    string pMsg = cmd.Parameters["@PO_MSG"].Value.ToString();
                    int pCode = Convert.ToInt32(cmd.Parameters["@PO_CD"].Value);

                    if (pCode < 0)
                    {
                        throw new Exception(pMsg);
                    }

                    conn.Close();
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
