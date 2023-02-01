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

        public List<DashboardMappingDTO> GetData(string uid)
        {
            DashboardDAO db = new DashboardDAO();
            List<DashboardMappingDTO> list = db.GetData(uid);
            db.Dispose();
            return list;
        }

        public bool UpdateDashboardMapping()
        {
            DashboardDAO db = new DashboardDAO();
            bool result = db.UpdateDashboardMapping();
            db.Dispose();
            return result;
        }



    }
}
