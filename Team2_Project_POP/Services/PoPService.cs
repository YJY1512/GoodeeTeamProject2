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

        public List<WorkOrderDTO> UpdateWork(string WorkOrderNo, string Wc_Code, string To_Code)
        {
            PopWorkOrderDAO db = new PopWorkOrderDAO();
            List<WorkOrderDTO> list = db.UpdateWork(WorkOrderNo, Wc_Code, To_Code);
            db.Dispose();

            return list;
        }


        public bool InPrd(PopPrdQtyDTO prdQty)
        {
            PopWorkOrderDAO db = new PopWorkOrderDAO();
            bool result = db.InPrd(prdQty);
            db.Dispose();

            return result;
        }

        public bool InDef(PopDefQtyDTO defQty)
        {
            PopWorkOrderDAO db = new PopWorkOrderDAO();
            bool result = db.InDef(defQty);
            db.Dispose();

            return result;
        }

        public List<DefVO> GetDefLIST()
        {
            PopWorkOrderDAO db = new PopWorkOrderDAO();
            List<DefVO> list = db.GetDefLIST();
            db.Dispose();

            return list;
        }
        public PopPrdDTO SetWrorkOrder(string wcCode)
        {
            PopWorkOrderDAO db = new PopWorkOrderDAO();
            PopPrdDTO list = db.SetWrorkOrder(wcCode);
            db.Dispose();

            return list;
        }

        public List<NonDTO> GetNonList(string wc_COde)
        {
            PopWorkOrderDAO db = new PopWorkOrderDAO();
            List<NonDTO> list = db.GetNonList(wc_COde);
            db.Dispose();

            return list;
        }

        public List<DefVO> SetNonCodes()
        {
            PopWorkOrderDAO db = new PopWorkOrderDAO();
            List<DefVO> list = db.SetNonCodes();
            db.Dispose();

            return list;
        }

        public List<PaletteDTO> GetPaletteList(string wcCode)
        {
            PopWorkOrderDAO db = new PopWorkOrderDAO();
            List<PaletteDTO> list = db.GetPaletteList(wcCode);
            db.Dispose();

            return list;
        }

        public bool SetPalette(PopPrdDTO selected)
        {
            PopWorkOrderDAO db = new PopWorkOrderDAO();
            bool result = db.SetPalette(selected);
            db.Dispose();

            return result;
        }

    }
}
