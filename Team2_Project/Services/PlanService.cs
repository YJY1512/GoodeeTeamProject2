using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    public class PlanService
    {
        public DataTable GetPrdReq(string from, string to)
        {
            PlanDAO db = new PlanDAO();
            DataTable dt = db.GetPrdReq(from, to);

            return dt;
        }

        public bool InsertReqPlan(List<PlanDTO> plans)
        {
            PlanDAO db = new PlanDAO();
            bool result = db.InsertReqPlan(plans);

            return result;
        }

        public DataTable GetPlan(string planMonth)
        {
            PlanDAO db = new PlanDAO();
            DataTable dt = db.GetPlan(planMonth);

            return dt;
        }

        public bool InsertPlan(PlanDTO plan)
        {
            PlanDAO db = new PlanDAO();
            bool result = db.InsertPlan(plan);

            return result;
        }

        public int DeletePlan(string planID)
        {
            PlanDAO db = new PlanDAO();
            int result = db.DeletePlan(planID);

            return result;
        }

        public int UpdatePlan(PlanDTO plan)
        {
            PlanDAO db = new PlanDAO();
            int result = db.UpdatePlan(plan);

            return result;
        }

        public bool SplitPlan(PlanDTO plan)
        {
            PlanDAO db = new PlanDAO();
            bool result = db.SplitPlan(plan);

            return result;
        }

        public bool ClosePlan(string planID, string empID)
        {
            PlanDAO db = new PlanDAO();
            bool result = db.ClosePlan(planID, empID);

            return result;
        }

        public bool CloseCancel(string planID, string empID)
        {
            PlanDAO db = new PlanDAO();
            bool result = db.CloseCancel(planID, empID);

            return result;
        }
    }
}
