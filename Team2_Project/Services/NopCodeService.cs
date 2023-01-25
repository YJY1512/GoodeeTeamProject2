using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    class NopCodeService
    {
        public List<NopMaCodeDTO> GetNopMaSearch(NopMaCodeDTO item)
        {
            NopCodeDAO db = new NopCodeDAO();
            List<NopMaCodeDTO> list = db.GetNopMaSearch(item);
            db.Dispose();
            return list;
        }

        public bool NopMaCodeAdd(NopMaCodeDTO item)
        {
            NopCodeDAO db = new NopCodeDAO();
            bool result = db.NopMaCodeAdd(item);
            db.Dispose();
            return result;
        }



        public bool NopMaCodeUpdate(NopMaCodeDTO item)
        {
            NopCodeDAO db = new NopCodeDAO();
            bool result = db.NopMaCodeUpdate(item);
            db.Dispose();
            return result;
        }

        public bool CheckPK(string ItemCode)
        {
            NopCodeDAO db = new NopCodeDAO();
            bool result = db.CheckPK(ItemCode);
            db.Dispose();
            return result;
        }

        public int DeleteItemCode(string Code)
        {
            NopCodeDAO db = new NopCodeDAO();
            int result = db.DeleteItemCode(Code);
            db.Dispose();
            return result;
        }


        #region 미사용
        public List<NopMaCodeDTO> GetMaCurItem(string item)
        {
            NopCodeDAO db = new NopCodeDAO();
            List<NopMaCodeDTO> list = db.GetMaCurItem(item);
            db.Dispose();
            return list;
        }
        #endregion
    }
}
