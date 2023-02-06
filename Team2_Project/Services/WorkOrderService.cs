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
        public bool InserSiyuWorkOrder(WorkOrderDTO workOrder)
        {
            WorkOrderDAO db = new WorkOrderDAO();
            bool result = db.InserSiyuWorkOrder(workOrder);

            return result;
        }

        public bool InserWorkOrder(WorkOrderDTO workOrder)
        {
            WorkOrderDAO db = new WorkOrderDAO();
            bool result = db.InserWorkOrder(workOrder);

            return result;
        }

        
        public DataTable GetSiyuWorkOrder(string planMonth)
        {
            WorkOrderDAO db = new WorkOrderDAO();
            DataTable dt = db.GetSiyuWorkOrder(planMonth);

            return dt;
        }

        public List<WorkOrderDTO> GetWorkOrder(string start, string end)
        {
            WorkOrderDAO db = new WorkOrderDAO();
            List<WorkOrderDTO> list = db.GetWorkOrder(start, end);

            return list;
        }

        //시유 작업지시 용
        public bool UpdateWorkOrder(List<WorkOrderDTO> workOrders)
        {
            WorkOrderDAO db = new WorkOrderDAO();
            bool result = db.UpdateWorkOrder(workOrders);

            return result;
        }

        public bool UpdateWorkOrder(WorkOrderDTO workOrder)
        {
            WorkOrderDAO db = new WorkOrderDAO();
            bool result = db.UpdateWorkOrder(workOrder);

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
