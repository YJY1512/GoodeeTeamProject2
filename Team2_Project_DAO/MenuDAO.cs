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
    public class MenuDAO : IDisposable
    {
        SqlConnection conn;
        public MenuDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }
        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<MenuDTO> GetMenuInfo(string grpCode)
        {
            string sql = @"select Screen_Code, Parent_Screen_Code, Sort_Index, Type, Form_Name, Menu_Name, Menu_Image, Menu_Level, Use_YN
                            from Screenitem_Master 
                            where Screen_Code in (select Screen_Code 
                            						from ScreenItem_Authority SA inner join UserGroup_Mapping UM on SA.UserGroup_Code = UM.UserGroup_Code
                            						where UM.UserGroup_Code = @UserGroup_Code)
                            union 
                            select distinct S.Screen_Code, S.Parent_Screen_Code, S.Sort_Index, S.Type, S.Form_Name, S.Menu_Name, S.Menu_Image, S.Menu_Level, S.Use_YN
                            from Screenitem_Master S inner join Screenitem_Master M on S.Screen_Code = M.Parent_Screen_Code
                            where M.Screen_Code in (select Screen_Code 
                            					     from ScreenItem_Authority SA inner join UserGroup_Mapping UM on SA.UserGroup_Code = UM.UserGroup_Code
                            					     where UM.UserGroup_Code = @UserGroup_Code)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserGroup_Code", grpCode);

            conn.Open();
            List<MenuDTO> list = Helper.DataReaderMapToList<MenuDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }

        public List<MenuDTO> GetFavoriteInfo(string userID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SP_GetFavoriteInfo";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@User_ID", userID);

                    conn.Open();
                    List<MenuDTO> list = Helper.DataReaderMapToList<MenuDTO>(cmd.ExecuteReader());
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
