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

        public bool SaveAuthority(string grpCode, string userID, AuthDTO auth)
        {
            try
            {
                string sql = @"update ScreenItem_Authority
                              set  Screen_Code = @Screen_Code, Pre_Type= @Pre_Type, Up_Date = GETDATE(), Up_Emp = @Up_Emp
                              where UserGroup_Code = @UserGroup_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Screen_Code", auth.Screen_Code);
                    cmd.Parameters.AddWithValue("@Pre_Type", auth.Screen_Code);
                    cmd.Parameters.AddWithValue("@Up_Emp", userID);
                    cmd.Parameters.AddWithValue("@UserGroup_Code", grpCode);

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
        //public bool SaveAuthority(string grpCode, string userID ,List<AuthDTO> authList)
        //{
        //    conn.Open();
        //    SqlTransaction trans = conn.BeginTransaction();
        //    try
        //    {
        //        string sql = @"update ScreenItem_Authority
        //                       set  Screen_Code = @Screen_Code, Pre_Type= @Pre_Type, Up_Date = GETDATE(), Up_Emp = @Up_Emp
        //                       where UserGroup_Code = @UserGroup_Code";

        //        SqlCommand cmd1 = new SqlCommand(sql, conn);
        //        cmd1.Parameters.Add(new SqlParameter("@Screen_Code", SqlDbType.NVarChar, 50));
        //        cmd1.Parameters.Add(new SqlParameter("@Pre_Type", SqlDbType.NVarChar, 20));
        //        cmd1.Parameters.Add(new SqlParameter("@Up_Emp", SqlDbType.NVarChar, 20));
        //        cmd1.Parameters.AddWithValue("@UserGroup_Code", grpCode);

        //        for (int i = 0; i < authList.Count; i++)
        //        {
        //            cmd1.Parameters["@Screen_Code"].Value = authList[i].Screen_Code;
        //            cmd1.Parameters["@Pre_Type"].Value = authList[i].Pre_Type;
        //            cmd1.Parameters["@Up_Emp"].Value = userID;
        //            cmd1.ExecuteNonQuery();
        //        }

        //        sql = @"update Screenitem_Master
        //                set Screen_Code = @Screen_Code, Parent_Screen_Code = @Parent_Screen_Code, Menu_Name = @Menu_Name Type = @Type";
        //        SqlCommand cmd2 = new SqlCommand(sql, conn);
        //        cmd2.Parameters.Add(new SqlParameter("@Screen_Code", SqlDbType.NVarChar, 50));
        //        cmd2.Parameters.Add(new SqlParameter("@Parent_Screen_Code", SqlDbType.NVarChar, 50));
        //        cmd2.Parameters.Add(new SqlParameter("@Menu_Name", SqlDbType.NVarChar, 100));
        //        cmd2.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 30));

        //        for (int i = 0; i < authList.Count; i++)
        //        {
        //            cmd2.Parameters["@Screen_Code"].Value = authList[i].Screen_Code;
        //            cmd2.Parameters["@Parent_Screen_Code"].Value = authList[i].Parent_Screen_Code;
        //            cmd2.Parameters["@Menu_Name"].Value = authList[i].Menu_Name;
        //            cmd2.Parameters["@Type"].Value = authList[i].Type;
        //            cmd2.ExecuteNonQuery();
        //        }

        //        trans.Commit();
        //        return true;
        //    }
        //    catch (Exception err)
        //    {
        //        trans.Rollback();
        //        Debug.WriteLine(err.Message);
        //        MessageBox.Show(err.Message);
        //        return false;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
    }
}
