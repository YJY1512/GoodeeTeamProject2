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
                           where Screen_Code in (select Screen_Code from ScreenItem_Authority where UserGroup_Code = @UserGroup_Code) and Use_YN = 'Y'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserGroup_Code", grpCode);

            conn.Open();
            List<MenuDTO> list = Helper.DataReaderMapToList<MenuDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }
    }
}
