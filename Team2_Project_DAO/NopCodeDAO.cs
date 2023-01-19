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
    public class NopCodeDAO : IDisposable
    {
        SqlConnection conn;
        public NopCodeDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }


        public List<NopMaCodeDTO> GetNopSearch(NopMaCodeDTO item) //비가동 대분류코드 조회
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                SqlCommand cmd = new SqlCommand();
                //sb.Append("SP_OrderList");
                sb.Append(@"SELECT Nop_Ma_Code , Nop_Ma_Name
                                 , CASE WHEN Use_YN = 'Y' THEN '예' ELSE '아니오' END AS Use_YN
	                             , CONVERT(VARCHAR(10), Ins_Date, 23) Ins_Date	                               
                             FROM Nop_Ma_Master
                            WHERE 1 = 1");   // , Ins_Emp , CONVERT(VARCHAR(10), Up_Date, 23) Up_Date , Up_Emp

                cmd.Parameters.AddWithValue("@Nop_Ma_Code", item.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Nop_Ma_Name", item.Nop_Ma_Name);
                cmd.Parameters.AddWithValue("@Use_YN", item.Use_YN);

                if (!string.IsNullOrWhiteSpace(item.Nop_Ma_Code))
                {
                    sb.Append(" AND Nop_Ma_Code LIKE @Nop_Ma_Code");
                    cmd.Parameters.AddWithValue("@Nop_Ma_Code", "%" + item.Nop_Ma_Code + "%");
                }
                if (!string.IsNullOrWhiteSpace(item.Nop_Ma_Name))
                {
                    sb.Append(" AND Nop_Ma_Name LIKE @Nop_Ma_Name");
                    cmd.Parameters.AddWithValue("@Nop_Ma_Name", "%" + item.Nop_Ma_Name + "%");
                }

                if (item.Use_YN == "사용")
                    sb.Append(" AND Use_YN = 'Y'");
                else if (item.Use_YN == "미사용")
                    sb.Append(" AND Use_YN = 'N'");

                sb.Append(" ORDER BY Nop_Ma_Code");

                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();

                conn.Open();
                Debug.WriteLine(cmd.CommandText);
                List<NopMaCodeDTO> list = Helper.DataReaderMapToList<NopMaCodeDTO>(cmd.ExecuteReader());

                return list;
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

        public bool NopMaCodeAdd(NopMaCodeDTO item) //대분류 추가
        {
            try
            {
                string sql = @"INSERT INTO Nop_Ma_Master(Nop_Ma_Code , Nop_Ma_Name, Ins_Emp, Ins_Date) 
                                               VALUES (@Nop_Ma_Code , @Nop_Ma_Name , @Ins_Emp, GETDATE())";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", item.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Nop_Ma_Name", item.Nop_Ma_Name);
                cmd.Parameters.AddWithValue("@Use_YN", item.Use_YN);
                cmd.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);

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

        public List<NopMaCodeDTO> GetCurItem(string item) //대분류 패널로드
        {
            try
            {
                string sql = @"SELECT Nop_Ma_Code , Nop_Ma_Name, Use_YN                          
                                 FROM Nop_Ma_Master 
                                WHERE Nop_Ma_Code = @Nop_Ma_Code";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", item);
                cmd.Connection = conn;

                conn.Open();
                Debug.WriteLine(cmd.CommandText);
                List<NopMaCodeDTO> list = Helper.DataReaderMapToList<NopMaCodeDTO>(cmd.ExecuteReader());
                return list;
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
        public bool NopMaCodeUpdate(NopMaCodeDTO item) //대분류 수정
        {
            try
            {
                string sql = @"UPDATE Nop_Ma_Master
                                  SET Nop_Ma_Name = @Nop_Ma_Name, Use_YN = @Use_YN, Up_Date = GETDATE(), Up_Emp = @Up_Emp
                                WHERE Nop_Ma_Code = @Nop_Ma_Code";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", item.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Nop_Ma_Name", item.Nop_Ma_Name);
                cmd.Parameters.AddWithValue("@Use_YN", item.Use_YN);
                cmd.Parameters.AddWithValue("@Up_Emp", item.Up_Emp);

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
