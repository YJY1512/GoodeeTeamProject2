using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project_POP.Services
{
    public class PoPService
    {
        public List<WorkCenterDTO> GetWorkCenterInfo()
        {
            WorkCenterDAO db = new WorkCenterDAO();
            List<WorkCenterDTO> list = db.GetWorkCenterInfo();
            db.Dispose();

            return list;
        }

        public List<WorkOrderDTO> GetOrders(string Wc_Code)
        {
            PopWorkOrderDAO db = new PopWorkOrderDAO();
            List<WorkOrderDTO> list = db.GetWorkOrders(Wc_Code);
            db.Dispose();

            return list;
        }

        public List<WorkOrderDTO> StartWork(string WorkOrderNo, string Wc_Code)
        {
            PopWorkOrderDAO db = new PopWorkOrderDAO();
            List<WorkOrderDTO> list = db.StartWork(WorkOrderNo, Wc_Code);
            db.Dispose();

            return list;
        }
    }
}
