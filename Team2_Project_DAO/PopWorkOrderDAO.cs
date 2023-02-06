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
    public class PopWorkOrderDAO : IDisposable
    {
        SqlConnection conn;

        public PopWorkOrderDAO()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connStr);
        }

        public void Dispose()
        {
            if(conn.State == ConnectionState.Open)
                conn.Close();
        }

        publci List<> GetWorkOrders(string ){

        }

    }
}
