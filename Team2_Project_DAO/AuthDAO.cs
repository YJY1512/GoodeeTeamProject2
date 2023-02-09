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
    }
}
