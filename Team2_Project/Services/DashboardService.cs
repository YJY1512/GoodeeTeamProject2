using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    class DashboardService
    { 
        public bool UpdateDashboardMapping()
        {
            DashboardDAO db = new DashboardDAO();
            bool result = db.UpdateDashboardMapping();
            db.Dispose();
            return result;
        }



    }
}
