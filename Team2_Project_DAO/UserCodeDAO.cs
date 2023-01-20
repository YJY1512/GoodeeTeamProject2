using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DTO;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace Team2_Project_DAO
{
    public class UserCodeDAO : IDisposable
    {
        SqlConnection conn;

        public UserCodeDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }
        public void Dispose()
        {
           
        }

        //public List<UserCodeDTO> GetUserCode()
        //{
            
        //}
        
    }
}
