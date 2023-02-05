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
        public bool InserWorkOrder(WorkOrderDTO workOrder)
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

        public bool UpdateWorkOrder(List<WorkOrderDTO> workOrders)
        {
            WorkOrderDAO db = new WorkOrderDAO();
            bool result = db.UpdateWorkOrder(workOrders);

            return result;
        }

        public bool DeleteWorkOrder(List<string> delWoIDs, string empId)
        {
            WorkOrderDAO db = new WorkOrderDAO();
            bool result = db.DeleteWorkOrder(delWoIDs, empId);

            return result;
        }
    }
}
