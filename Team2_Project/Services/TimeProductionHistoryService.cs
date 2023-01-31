using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    class TimeProductionHistoryService
    {

        public List<TimeProductionHistoryDTO> GetTimeProductionHistory(string from, string to)
        {
            TimeProductionHistoryDAO db = new TimeProductionHistoryDAO();
            List<TimeProductionHistoryDTO> list = db.GetTimeProductionHistory(from, to);
            db.Dispose();
            return list;
        }
    }
}
