using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    class AnalysisService
    {

        public List<TimeProductionHistoryDTO> GetWorkOrder(string from, string to)
        {
            AnalysisDAO db = new AnalysisDAO();
            List<TimeProductionHistoryDTO> list = db.GetWorkOrder(from, to);
            db.Dispose();
            return list;
        }

        public List<TimeProductionHistoryDTO> GetTimeProductionHistory(string WorkOrderNo)
        {
            AnalysisDAO db = new AnalysisDAO();
            List<TimeProductionHistoryDTO> list = db.GetTimeProductionHistory(WorkOrderNo);
            db.Dispose();
            return list;
        }

        public List<CodeDTO> GetWoStatus() //작업지시상태cbo
        {
            AnalysisDAO db = new AnalysisDAO();
            List<CodeDTO> list = db.GetWoStatus();
            db.Dispose();
            return list;
        }

        public List<MonthProductionHistoryDTO> GetMonthProductionHistory(string MonthDate)
        {
            AnalysisDAO db = new AnalysisDAO();
            List<MonthProductionHistoryDTO> list = db.GetMonthProductionHistory(MonthDate);
            db.Dispose();
            return list;
        }
    }
}
