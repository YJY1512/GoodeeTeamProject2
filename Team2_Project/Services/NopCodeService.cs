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
        public List<NopMaCodeDTO> GetNopSearch(NopMaCodeDTO item)
        {
            NopCodeDAO db = new NopCodeDAO();
            List<NopMaCodeDTO> list = db.GetNopSearch(item);
            db.Dispose();
            return list;
        }




    }
}
