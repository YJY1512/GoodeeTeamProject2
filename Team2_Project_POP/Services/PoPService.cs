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
            WorkOrderDAO db = new WorkOrderDAO();
            //List<WorkOrderDTO> list = db.GetWorkCenterInfo(Wc_Code);
            db.Dispose();

            return null;// list;
        }
    }
}
