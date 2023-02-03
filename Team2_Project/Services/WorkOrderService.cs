using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;
using System.Data;

namespace Team2_Project.Services
{
    public class WorkOrderService
    {
        public bool InserWorkOrder(List<WorkOrderDTO> workOrder)
        {
            WorkOrderDAO db = new WorkOrderDAO();
            bool result = db.InserWorkOrder(workOrder);

            return result;
        }

        public DataTable GetWorkOrder(string planMonth)
        {
            WorkOrderDAO db = new WorkOrderDAO();
            DataTable dt = db.GetWorkOrder(planMonth);

            return dt;
        }
    }
}
