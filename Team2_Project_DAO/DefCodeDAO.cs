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
    public class DefCodeDAO : IDisposable
    {
        SqlConnection conn;

        public DefCodeDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }
        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    
        public List<DefCodeDTO> GetDefCode()
        {
            try
            {
                string sql = @"select Def_Ma_Code, Def_Ma_Name, case when Use_YN = 'Y' then '예'
									when Use_YN = 'N' then '아니오' end as Use_YN
                        from Def_Ma_Master";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    List<DefCodeDTO> list = Helper.DataReaderMapToList<DefCodeDTO>(cmd.ExecuteReader());
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

        public bool CheckPK(string maCode)
        {
            try
            {
                string sql = @"select count(*) cnt
                                from Def_Ma_Master
                                where Def_Ma_Code = @Def_Ma_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Def_Ma_Code", maCode);

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

        public bool InsertDefCode(DefCodeDTO code)
        {
            try
            {
                string sql = @"insert into Def_Ma_Master(Def_Ma_Code, Def_Ma_Name, Use_YN, Ins_Emp)
                                    values (@Def_Ma_Code, @Def_Ma_Name, @Use_YN, @Ins_Emp)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Def_Ma_Code", code.Def_Ma_Code);
                    cmd.Parameters.AddWithValue("@Def_Ma_Name", code.Def_Ma_Name);
                    cmd.Parameters.AddWithValue("@Use_YN", code.Use_YN);
                    cmd.Parameters.AddWithValue("@Ins_Emp", code.Ins_Emp);

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

        public bool UpdateDefCode(DefCodeDTO code)
        {
            try
            {
                string sql = @"update Def_Ma_Master
                                set Def_Ma_Name = @Def_Ma_Name, 
                                    Use_YN = @Use_YN, 
                                    Up_Emp = @Up_Emp, 
                                    Up_Date = getdate()
                                where Def_Ma_Code = @Def_Ma_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Def_Ma_Code", code.Def_Ma_Code);
                    cmd.Parameters.AddWithValue("@Def_Ma_Name", code.Def_Ma_Name);
                    cmd.Parameters.AddWithValue("@Use_YN", code.Use_YN);
                    cmd.Parameters.AddWithValue("@Up_Emp", code.Up_Emp);

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

        public int DeleteDefCode(string maCode)
        {
            try
            {
                string sql = @"delete from Def_Ma_Master
                                where Def_Ma_Code = @Def_Ma_Code;
                                select @@ERROR";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Def_Ma_Code", maCode);

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
    }
}
