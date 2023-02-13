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
    public class PopWorkOrderDAO : IDisposable
    {
        SqlConnection conn;

        public PopWorkOrderDAO()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connStr);
        }

        public void Dispose()
        {
            if(conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<WorkOrderDTO> GetWorkOrders(string Wc_Code)
        {
            List<WorkOrderDTO> result = new List<WorkOrderDTO>();
            try 
            { 
                using (SqlCommand cmd = new SqlCommand("SP_PopWorkOrderList", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Wc_code", Wc_Code);

                    conn.Open();
                    result = Helper.DataReaderMapToList<WorkOrderDTO>(cmd.ExecuteReader());
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

        public List<WorkOrderDTO> UpdateWork(string work, string Wc_Code, string To_Code)
        {
            List<WorkOrderDTO> result = new List<WorkOrderDTO>();
            try 
            { 
                using (SqlCommand cmd = new SqlCommand("SP_PopUpdateWorkOrderList", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@WorkOrderNo", work);
                    cmd.Parameters.AddWithValue("@Wc_Code", Wc_Code);
                    cmd.Parameters.AddWithValue("@To_Status_Code", To_Code);

                    conn.Open();
                    result = Helper.DataReaderMapToList<WorkOrderDTO>(cmd.ExecuteReader());
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


        public bool InPrd(PopPrdQtyDTO prdQty)
        {
            
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_PopItemInProduction", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@WorkOrderNo", prdQty.WorkOrderNo);
                    cmd.Parameters.AddWithValue("@Item_Code", prdQty.Item_Code);
                    cmd.Parameters.AddWithValue("@Item_Rank", prdQty.Item_Rank);
                    cmd.Parameters.AddWithValue("@Item_In", prdQty.Item_Qty);
                    cmd.Parameters.AddWithValue("@Item_out", prdQty.Item_Qty);
                    cmd.Parameters.AddWithValue("@Item_Time", prdQty.Item_time);


                    conn.Open();

                    int result = cmd.ExecuteNonQuery();
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

        public  bool InDef(PopDefQtyDTO defQty)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_PopDefInProduction", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@WorkOrderNo", defQty.WorkOrderNo);
                    cmd.Parameters.AddWithValue("@Def_Qty", defQty.Item_Qty);
                    cmd.Parameters.AddWithValue("@Def_Ma_Code", defQty.DefMaCode);
                    cmd.Parameters.AddWithValue("@Def_Mi_Code", defQty.DefMiCode);
                    cmd.Parameters.AddWithValue("@Def_Date", defQty.Item_time);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();

                    return (result > 0);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public List<DefVO> GetDefLIST()
        {
            List<DefVO> result = new List<DefVO>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_DefLists", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    conn.Open();
                    result = Helper.DataReaderMapToList<DefVO>(cmd.ExecuteReader());
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
        /// <summary>
        /// 확인 필요함
        /// </summary>
        /// <param name="WorkOrderNo"></param>
        /// <returns></returns>
        public PopPrdDTO SetWrorkOrder(string WorkOrderNo)
        {
            PopPrdDTO result = new PopPrdDTO();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_SetSelectedOrder1", conn);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@WorkOrderNo", WorkOrderNo);
                // 확인필요

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    result.WorkLineName = reader["WorkLineName"].ToString();
                    result.WorkLineCode = reader["WorkLineCode"].ToString();
                    result.WorkOrderDate = Convert.ToDateTime(reader["WorkOrderDate"]);
                    result.PrdDate = Convert.ToDateTime(reader["PrdDate"]);
                    result.WorkOrderNo = reader["WorkOrderNo"].ToString();
                    result.PrdName = reader["PrdName"].ToString();
                    result.PrdCode = reader["PrdCode"].ToString();
                    result.PlanQty = Convert.ToInt32(reader["PlanQty"]);
                    result.PrdStartTime = Convert.ToDateTime(reader["PrdStartTime"]);
                    result.PrdEndTime = (reader["PrdEndTime"] == DBNull.Value )? DateTime.MinValue: Convert.ToDateTime(reader["PrdEndTime"]);
                    result.Remark = reader["Remark"].ToString();
                }
                conn.Close();

                //
                SqlCommand cmd2 = new SqlCommand("Sp_SetSelectedOrder2", conn);

                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@WorkOrderNo", WorkOrderNo);
                // 확인필요
                List<PopPrdQtyDTO> resultPrd = new List<PopPrdQtyDTO>();
                conn.Open();
                resultPrd = Helper.DataReaderMapToList<PopPrdQtyDTO>(cmd2.ExecuteReader());
                conn.Close();
                //
                SqlCommand cmd3 = new SqlCommand("Sp_SetSelectedOrder3", conn);

                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@WorkOrderNo", WorkOrderNo);
                // 확인필요
                List<PopDefQtyDTO> resultDef = new List<PopDefQtyDTO>();
                conn.Open();
                resultDef = Helper.DataReaderMapToList<PopDefQtyDTO>(cmd3.ExecuteReader());
                conn.Close();


                result.PrdQty = resultPrd;
                result.DefQty = resultDef;
                return result;
                
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public List<NonDTO> GetNonList(string wc_COde)
        {
            List<NonDTO> result = new List<NonDTO>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_SetNonList", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Wc_code", wc_COde);

                    conn.Open();
                    result = Helper.DataReaderMapToList<NonDTO>(cmd.ExecuteReader());
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
