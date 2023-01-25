using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Team2_Project_DTO;


namespace Team2_Project_DAO
{
    public class ProcessMasterDAO : IDisposable
    {
        string connStr = null;
        SqlConnection conn;

        public ProcessMasterDAO()
        {
            connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<ProcessMasterDTO> SetProcessList()
        {
            try
            {
                string sql = "select Process_Code, Process_Name, Process_Group, Use_YN, Remark from Process_Master";

                SqlCommand cmd = new SqlCommand(sql,conn);
                conn.Open();
                List<ProcessMasterDTO> list = Helper.DataReaderMapToList<ProcessMasterDTO>(cmd.ExecuteReader());
                conn.Close();
                return list;
            }
            catch 
            {
                return null;
            }
        }

        public bool InputProcess(ProcessMasterDTO newProcess, string user)
        {
            try
            {
                string sql = @"INSERT INTO dbo.Process_Master (Process_Code, Process_Name, Process_Group, Use_YN, Remark, Ins_Emp, Up_Emp) 
                                            VALUES(@Process_Code, @Process_Name, @Process_Group, @Use_YN, @Remark, @Ins_Emp, @Up_Emp)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Process_Code",newProcess.Process_Code);
                cmd.Parameters.AddWithValue("@Process_Name",newProcess.Process_Name);
                cmd.Parameters.AddWithValue("@Process_Group",newProcess.Process_Group);
                cmd.Parameters.AddWithValue("@Use_YN",newProcess.Use_YN);
                cmd.Parameters.AddWithValue("@Remark",newProcess.Remark);
                cmd.Parameters.AddWithValue("@Ins_Emp", user);
                cmd.Parameters.AddWithValue("@Up_Emp", user);

                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return (result > 0);
            }
            catch
            {
                return false;
            }
        }

        public bool EditProcess(ProcessMasterDTO newProcess, string user)
        {
            try
            {
                string sql = @"";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Process_Code", newProcess.Process_Code);
                cmd.Parameters.AddWithValue("@Process_Name", newProcess.Process_Name);
                cmd.Parameters.AddWithValue("@Process_Group", newProcess.Process_Group);
                cmd.Parameters.AddWithValue("@Use_YN", newProcess.Use_YN);
                cmd.Parameters.AddWithValue("@Remark", newProcess.Remark);
                cmd.Parameters.AddWithValue("@Up_Emp", user);

                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<ProcessMasterDTO> DelProcess(string txtProcessCode)
        {
            SqlTransaction trans = conn.BeginTransaction();
            
            string sql = "Delete from Process_Master where Process_Code = @Process_Code";
            
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@Ins_Emp", Ins_Emp);
            cmd.Transaction = trans;

            if (cmd.ExecuteNonQuery() < 1)
            {
                return false;
            }
            cmd.ExecuteNonQuery();

            List<ProcessMasterDTO> list = Helper.DataReaderMapToList<ProcessMasterDTO>(cmd.ExecuteReader());
            conn.Close();
            return list;
           
        }
    }
}
