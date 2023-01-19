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

        public List<NopMaCodeDTO> GetMaCurItem(string item)
        {
            NopCodeDAO db = new NopCodeDAO();
            List<NopMaCodeDTO> list = db.GetMaCurItem(item);
            db.Dispose();
            return list;
        }

        public bool NopMaCodeUpdate(NopMaCodeDTO item)
        {
            NopCodeDAO db = new NopCodeDAO();
            bool result = db.NopMaCodeUpdate(item);
            db.Dispose();
            return result;
        }
    }
}
