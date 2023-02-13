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
using System.Windows.Forms;

namespace Team2_Project_DAO
{
    public class AuthDAO
    {
        SqlConnection conn;
        public AuthDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }
        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<AuthDTO> GetAuthInfo(string grpCode)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SP_GetAuthorityInfo";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserGroup_Code", grpCode);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<AuthDTO> list = new List<AuthDTO>(); // Helper.DataReaderMapToList<AuthDTO>(cmd.ExecuteReader());
        
                    while(reader.Read())
                    {
                        list.Add(new AuthDTO
                        {
                            Screen_Code = reader["Screen_Code"].ToString(),
                            Parent_Screen_Code = reader["Parent_Screen_Code"].ToString(),
                            Menu_Name = reader["Menu_Name"].ToString(),
                            Module = (Convert.ToInt32(reader["Module"]) == 1) ? true : false,
                            Src = (Convert.ToInt32(reader["Src"]) == 1) ? true : false,
                            Ins = (Convert.ToInt32(reader["Ins"]) == 1) ? true : false,
                            Upd = (Convert.ToInt32(reader["Upd"]) == 1) ? true : false,
                            Del = (Convert.ToInt32(reader["Del"]) == 1) ? true : false,
                            Type = reader["Type"].ToString(),
                            Pre_Type = reader["Pre_Type"].ToString(),
                            Pre_Type_NM = reader["Pre_Type_NM"].ToString(),
                            Sort_Index = Convert.ToInt32(reader["Sort_Index"])
                        });
                    }
                    
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

        public bool SaveAuthority(string grpCode, string userID , List<AuthDTO> authList)
        {
            try
            {
                string sql = @"update ScreenItem_Authority
                               set Screen_Code = @Screen_Code, Pre_Type= @Pre_Type, Up_Date = GETDATE(), Up_Emp = @Up_Emp
                               where UserGroup_Code = @UserGroup_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Screen_Code", SqlDbType.NVarChar, 50));
                    cmd.Parameters.Add(new SqlParameter("@Pre_Type", SqlDbType.NVarChar, 20));
                    cmd.Parameters.AddWithValue("@Up_Emp", userID);
                    cmd.Parameters.AddWithValue("@UserGroup_Code", grpCode);

                    for (int i = 0; i < authList.Count; i++)
                    {
                        cmd.Parameters["@Screen_Code"].Value = authList[i].Screen_Code;
                        cmd.Parameters["@Pre_Type"].Value = authList[i].Pre_Type;
                    }
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
    }
}
