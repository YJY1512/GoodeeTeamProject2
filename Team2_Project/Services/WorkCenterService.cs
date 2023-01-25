using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    public class WorkCenterService
    {
        public List<WorkCenterDTO> GetWorkCenterInfo()
        {
            WorkCenterDAO db = new WorkCenterDAO();
            List<WorkCenterDTO> list = db.GetWorkCenterInfo();
            db.Dispose();

            return list;
        }
        public bool InsertWorkCenter(WorkCenterDTO wc, string empID)
        {
            WorkCenterDAO db = new WorkCenterDAO();
            bool result = db.InsertWorkCenter(wc, empID);
            db.Dispose();

            return result;
        }

        public bool UpdateWorkCenter(WorkCenterDTO wc, string empID)
        {
            WorkCenterDAO db = new WorkCenterDAO();
            bool result = db.UpdateWorkCenter(wc, empID);
            db.Dispose();

            return result;
        }

        public bool DeleteWorkCenter(string wcCode)
        {
            WorkCenterDAO db = new WorkCenterDAO();
            bool result = db.DeleteWorkCenter(wcCode);
            db.Dispose();

            return result;
        }
    }
}
