using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Team2_Project_DTO;

namespace Team2_Project_DAO
{
    public class DashboardDAO : IDisposable
    {
        SqlConnection conn;
        public DashboardDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<DashboardDTO> GetData(string uid)
        {
            try
            {
                string sql = @"SELECT User_ID , D.DashboardItem, Loc
	                                , CASE WHEN M.Use_YN = 'N' THEN '미사용대쉬보드'
		                                ELSE M.Title_Ko END AS Title_Ko
	                                , M.Use_YN
                                 FROM Dashboard_Mapping D INNER JOIN Dashboard_Master M ON D.DashboardItem = M.DashboardItem
                                WHERE USER_ID = @USER_ID
                                ORDER BY Loc DESC";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@USER_ID", uid);
                    conn.Open();
                    Debug.WriteLine(cmd.CommandText);
                    List<DashboardDTO> list = Helper.DataReaderMapToList<DashboardDTO>(cmd.ExecuteReader());
                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
                

        public bool UpdateDashboardMapping(DashboardDTO dto) //사용자 대시보드 매핑 UPDATE
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_DashboardMapping", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@User_ID", dto.User_ID);
                    cmd.Parameters.AddWithValue("@TopPage", dto.TopPage);
                    cmd.Parameters.AddWithValue("@BottomPage", dto.BottomPage);
                    
                    Debug.WriteLine(cmd.CommandText);
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
            finally
            {
                conn.Close();
            }
        }


        public List<DashboardDTO> GetDashList()
        {
            try
            {
                string sql = @"SELECT Title_Ko FROM Dashboard_Master";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    Debug.WriteLine(cmd.CommandText);
                    List<DashboardDTO> list = Helper.DataReaderMapToList<DashboardDTO>(cmd.ExecuteReader());
                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<WorkCenterDTO> GetWorkCenterInfo() //작업장정보
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetDashBoardWo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    List<WorkCenterDTO> list = Helper.DataReaderMapToList<WorkCenterDTO>(cmd.ExecuteReader());
                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<NopHistoryDTO> GetNopHistory() //비가동이력 조회
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_NopHistory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DateFrom", DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") );
                    cmd.Parameters.AddWithValue("@DateTo", DateTime.Now.AddDays(+1).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Ma_Code", "%%");
                    cmd.Parameters.AddWithValue("@Ma_Name", "%%");

                    conn.Open();
                    List<NopHistoryDTO> list = Helper.DataReaderMapToList<NopHistoryDTO>(cmd.ExecuteReader());
                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<TimeProductionHistoryDTO> Production() //생산진행현황 (작업지시별)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_TimeProductionHistory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PrdDateFrom", DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@PrdDateTo", DateTime.Now.AddDays(+1).ToString("yyyy-MM-dd"));

                    conn.Open();
                    List<TimeProductionHistoryDTO> list = Helper.DataReaderMapToList<TimeProductionHistoryDTO>(cmd.ExecuteReader());
                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<TimeProductionHistoryDTO> GetProductionHistory() //생산실적현황 (시간대별)
        {
            try
            {
                string sql = @"SELECT TOP 10 WorkOrderNo, Start_Hour, In_Qty_Main, Out_Qty_Main, Prd_Qty, Prd_Unit, Ins_Date
                                 FROM Time_Production_History 
								ORDER BY Ins_Date DESC"; //--WHERE Ins_Date = getdate()
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    List<TimeProductionHistoryDTO> list = Helper.DataReaderMapToList<TimeProductionHistoryDTO>(cmd.ExecuteReader());
                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
