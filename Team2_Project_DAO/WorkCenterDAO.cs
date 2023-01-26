using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Team2_Project_DTO;
using System.Configuration;
using System.Diagnostics;

namespace Team2_Project_DAO
{
    public class WorkCenterDAO : IDisposable
    {
        SqlConnection conn;
        public WorkCenterDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }
        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<WorkCenterDTO> GetWorkCenterInfo()
        {
            try
            {
                string sql = @"select case when WC.Wo_Status = 'W02' then 'Run' else 'Stop' end  Wc_Status,
                               		  Wc_Code, Wc_Name , UD.Userdefine_Mi_Code Wc_Group_Code, UD.Userdefine_Mi_Name Wc_Group_Name, P.Process_Code, P.Process_Name ,WC.Remark, 
                               		  case when WC.Use_YN = 'Y' then '예' when WC.Use_YN = 'N' then '아니오' end as Use_YN , 
                               		  case when Pallet_YN = 'Y' then '예' when Pallet_YN = 'N' then '아니오' end as Pallet_YN, WC.Wo_Status, SY.Sys_Mi_Name Wo_Status_Name	
                               from WorkCenter_Master WC inner join (select Userdefine_Mi_Code, Userdefine_Ma_Code, Userdefine_Mi_Name, Use_YN
                               									  from Userdefine_Mi_Master
                               									  where Userdefine_Ma_Code = 'WC_GROUP' and Use_YN ='Y') UD on WC.Wc_Group = UD.Userdefine_Mi_Code
                               						  inner join Process_Master P ON WC.Process_Code = P.Process_Code
                               						  inner join (select Sys_Ma_Code, Sys_Mi_Code, Sys_Mi_Name, Sort_Index, Remark, Use_YN
                               									  from Sys_Mi_Master
                               									  where Sys_Ma_Code = 'WO_STATUS' or Sys_Ma_Code ='WC_STATUS') SY on Wc.Wo_Status = SY.Sys_Mi_Code";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    List<WorkCenterDTO> list = Helper.DataReaderMapToList<WorkCenterDTO>(cmd.ExecuteReader());
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
        
        public bool InsertWorkCenter(WorkCenterDTO wc, string empID)
        {
            try
            {
                string sql = @"Insert Into WorkCenter_Master(Wc_Code, Wc_Name, Wc_Group, Process_Code, Remark, Use_YN, Pallet_YN, Ins_Emp)
                               Values (@Wc_Code, @Wc_Name, @Wc_Group, @Process_Code, @Remark, @Use_YN, @Pallet_YN, @Ins_Emp)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Wc_Code", wc.Wc_Code);
                cmd.Parameters.AddWithValue("@Wc_Name", wc.Wc_Name);
                cmd.Parameters.AddWithValue("@Wc_Group", wc.Wc_Group_Code);
                cmd.Parameters.AddWithValue("@Process_Code", wc.Process_Code);
                cmd.Parameters.AddWithValue("@Remark", wc.Remark);
                cmd.Parameters.AddWithValue("@Use_YN", wc.Use_YN);
                cmd.Parameters.AddWithValue("@Pallet_YN", wc.Pallet_YN);
                cmd.Parameters.AddWithValue("@Ins_Emp", empID);

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
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

        public bool UpdateWorkCenter(WorkCenterDTO wc, string empID)
        {
            try
            {
                string sql = @"Update WorkCenter_Master
                               Set Wc_Name = @Wc_Name, Wc_Group = @Wc_Group, Process_Code = @Process_Code, Remark = @Remark, 
                               	 Use_YN = @Use_YN, Pallet_YN = @Pallet_YN, Up_Date = GETDATE(), Up_Emp = @Up_Emp
                               where Wc_Code = @Wc_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Wc_Name", wc.Wc_Name);
                    cmd.Parameters.AddWithValue("@Wc_Group", wc.Wc_Group_Code);
                    cmd.Parameters.AddWithValue("@Process_Code", wc.Process_Code);
                    cmd.Parameters.AddWithValue("@Remark", wc.Remark);
                    cmd.Parameters.AddWithValue("@Use_YN", wc.Use_YN);
                    cmd.Parameters.AddWithValue("@Pallet_YN", wc.Pallet_YN);
                    cmd.Parameters.AddWithValue("@Up_Emp", empID);
                    cmd.Parameters.AddWithValue("@Wc_Code", wc.Wc_Code);

                    conn.Open();
                    int iRowAffect = cmd.ExecuteNonQuery();
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

        public bool DeleteWorkCenter(string wcCode)
        {
            try
            {
                string sql = "Delete From WorkCenter_Master where Wc_Code = @Wc_Code";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Wc_Code", wcCode);
                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
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
    }
}
