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
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SP_GetWorkCenter";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
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

        public bool FindSamePK(string wcCode)
        {
            try
            {
                string sql = @"select count(*) cnt
                               from WorkCenter_Master
                               where Wc_Code = @Wc_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Wc_Code", wcCode);

                    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    return (cnt < 1);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }
        
        public bool InsertWorkCenter(WorkCenterDTO wc)
        {
            try
            {
                string sql = @"Insert Into WorkCenter_Master(Wc_Code, Wc_Name, Wc_Group, Wo_Status, Process_Code, Remark, Use_YN, Prd_Unit, Pallet_YN, Ins_Emp)
				                        Values (@Wc_Code, @Wc_Name, @Wc_Group , 'W01' ,@Process_Code, @Remark, @Use_YN, @Prd_Unit, @Pallet_YN, @Ins_Emp)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Wc_Code", wc.Wc_Code);
                cmd.Parameters.AddWithValue("@Wc_Name", wc.Wc_Name);
                cmd.Parameters.AddWithValue("@Wc_Group", wc.Wc_Group);
                cmd.Parameters.AddWithValue("@Process_Code", wc.Process_Code);
                cmd.Parameters.AddWithValue("@Remark", wc.Remark);
                cmd.Parameters.AddWithValue("@Use_YN", wc.Use_YN);
                cmd.Parameters.AddWithValue("@Prd_Unit", wc.Prd_Unit);
                cmd.Parameters.AddWithValue("@Pallet_YN", wc.Pallet_YN);
                cmd.Parameters.AddWithValue("@Ins_Emp", wc.Ins_Emp);

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

        public bool UpdateWorkCenter(WorkCenterDTO wc)
        {
            try
            {
                string sql = @"Update WorkCenter_Master
                               Set Wc_Name = @Wc_Name, Wc_Group = @Wc_Group, Process_Code = @Process_Code, Remark = @Remark, 
                               	 Use_YN = @Use_YN, Prd_Unit = @Prd_Unit , Pallet_YN = @Pallet_YN, Up_Date = GETDATE(), Up_Emp = @Up_Emp
                               where Wc_Code = @Wc_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Wc_Name", wc.Wc_Name);
                    cmd.Parameters.AddWithValue("@Wc_Group", wc.Wc_Group);
                    cmd.Parameters.AddWithValue("@Process_Code", wc.Process_Code);
                    cmd.Parameters.AddWithValue("@Remark", wc.Remark);
                    cmd.Parameters.AddWithValue("@Use_YN", wc.Use_YN);
                    cmd.Parameters.AddWithValue("@Prd_Unit", wc.Use_YN);
                    cmd.Parameters.AddWithValue("@Pallet_YN", wc.Pallet_YN);
                    cmd.Parameters.AddWithValue("@Up_Emp", wc.Up_Emp);
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

        public int DeleteWorkCenter(string wcCode)
        {
            try
            {
                string sql = @"Delete From WorkCenter_Master 
                               where Wc_Code = @Wc_Code
                               Select @@ERROR";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Wc_Code", wcCode);
                    Debug.WriteLine(cmd.CommandText);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result;
                }

            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                if (err.Message.Contains("REFERENCE 제약 조건"))
                    return -9;
                else
                    return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        //작업장 코드랑 이름만 가져오는 메서드 -- 0127 이은실
        public List<WorkCenterDTO> GetWcCodeName()
        {
            string sql = @"select Wc_Code, Wc_Name, w.Process_Code, Process_Name
                            from WorkCenter_Master w inner join Process_Master p on w.Process_Code = p.Process_Code
                            where w.Use_YN = 'Y'";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                List<WorkCenterDTO> list = Helper.DataReaderMapToList<WorkCenterDTO>(cmd.ExecuteReader());
                conn.Close();

                return list;
            }
        }
    }
}
