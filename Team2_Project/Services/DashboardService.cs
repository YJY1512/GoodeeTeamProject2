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

        public List<WorkCenterDTO> GetWorkCenterInfo()
        {
            DashboardDAO db = new DashboardDAO();
            List<WorkCenterDTO> list = db.GetWorkCenterInfo();
            db.Dispose();
            return list;
        }

        public List<NopHistoryDTO> GetNopHistory()
        {
            DashboardDAO db = new DashboardDAO();
            List<NopHistoryDTO> list = db.GetNopHistory();
            db.Dispose();
            return list;
        }

        public List<TimeProductionHistoryDTO> Production()
        {
            DashboardDAO db = new DashboardDAO();
            List<TimeProductionHistoryDTO> list = db.Production();
            db.Dispose();
            return list;
        }

        public List<TimeProductionHistoryDTO> GetProductionHistory()
        {
            DashboardDAO db = new DashboardDAO();
            List<TimeProductionHistoryDTO> list = db.GetProductionHistory();
            db.Dispose();
            return list;
        }

        public List<DefCodeDTO> GetDefHistory()
        {
            DashboardDAO db = new DashboardDAO();
            List<DefCodeDTO> list = db.GetDefHistory();
            db.Dispose();
            return list;
        }
        
    }
}
