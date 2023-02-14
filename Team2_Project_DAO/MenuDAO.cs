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

        public List<MenuDTO> GetMenuInfo(string grpCode, string userID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SP_GetScreenMenuInfo";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserGroup_Code", grpCode);
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

        //public List<MenuDTO> GetMenuFavInfo(string userID)
        //{
        //    string sql = @"select SM.Screen_Code, FM.Screen_Code Fav_Screen_Code, SM.Parent_Screen_Code, FM.Sort_Index, SM.Type, SS.Form_Name,SM.Menu_Image,SM.Menu_Level
        //                    from Favorite_Master FM inner join Screenitem_Master SM on SM.Parent_Screen_Code = FM.Parent_Screen_Code
        //                    						inner join Screenitem_Master SS on SS.Screen_Code = FM.Screen_Code
        //                    where SM.Screen_Code = 'FAV' and FM.User_ID = @User_ID";
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    cmd.Parameters.AddWithValue("@User_ID", userID);

        //    conn.Open();
        //    List<MenuDTO> list = Helper.DataReaderMapToList<MenuDTO>(cmd.ExecuteReader());
        //    conn.Close();

        //    return list;
        //}

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

        public bool SaveFavorite (string userID, List<MenuDTO> favoriteList)
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = "delete from Favorite_Master where User_ID = @User_ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@User_ID", userID);
                cmd.Transaction = trans;
                cmd.ExecuteNonQuery();

                sql = @"insert into Favorite_Master (User_ID, Screen_Code, Parent_Screen_Code, Type, Sort_Index, Ins_Date, Ins_Emp)
					values (@User_ID, @Screen_Code, 'FAV', 'FAVORITE' , @Sort_Index, GETDATE(), @Ins_Emp)";

                SqlCommand cmd2 = new SqlCommand(sql, conn);
                cmd2.Parameters.Add(new SqlParameter("@User_ID", SqlDbType.NVarChar, 20));
                cmd2.Parameters.Add(new SqlParameter("@Screen_Code", SqlDbType.NVarChar, 50));
                cmd2.Parameters.Add(new SqlParameter("@Sort_Index", SqlDbType.Int));
                cmd2.Parameters.Add(new SqlParameter("@Ins_Emp", SqlDbType.NVarChar, 20));
                cmd2.Transaction = trans;

                for (int i = 0; i < favoriteList.Count; i++)
                {
                    cmd2.Parameters["@User_ID"].Value = userID;
                    cmd2.Parameters["@Screen_Code"].Value = favoriteList[i].Screen_Code;
                    cmd2.Parameters["@Sort_Index"].Value = i;
                    cmd2.Parameters["@Ins_Emp"].Value = userID;
                    cmd2.ExecuteNonQuery();
                }

                trans.Commit();
                return true;
            }
            catch (Exception err)
            {
                trans.Rollback();
                Debug.WriteLine(err.Message);
                MessageBox.Show(err.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
