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

        public List<DashboardDTO> GetData(string uid)
        {
            DashboardDAO db = new DashboardDAO();
            List<DashboardDTO> list = db.GetData(uid);
            db.Dispose();
            return list;
        }

        public bool UpdateDashboardMapping(DashboardDTO dto)
        {
            DashboardDAO db = new DashboardDAO();
            bool result = db.UpdateDashboardMapping(dto);
            db.Dispose();
            return result;
        }

        public List<DashboardDTO> GetDashList()
        {
            DashboardDAO db = new DashboardDAO();
            List<DashboardDTO> list = db.GetDashList();
            db.Dispose();
            return list;
        }
        

    }
}
