using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    
    public class DefCodeService
    {
        #region Def Master
        public List<DefCodeDTO> GetDefCode()
        {
            DefCodeDAO db = new DefCodeDAO();
            List<DefCodeDTO> list = db.GetDefCode();

            return list;
        }

        public bool CheckPK(string maCode)
        {
            DefCodeDAO db = new DefCodeDAO();
            bool result = db.CheckPK(maCode);

            return result;
        }

        public bool InsertDefCode(DefCodeDTO code)
        {
            DefCodeDAO db = new DefCodeDAO();
            bool result = db.InsertDefCode(code);

            return result;
        }

        public bool UpdateDefCode(DefCodeDTO code)
        {
            DefCodeDAO db = new DefCodeDAO();
            bool result = db.UpdateDefCode(code);

            return result;
        }

        public int DeleteDefCode(string maCode)
        {
            DefCodeDAO db = new DefCodeDAO();
            int result = db.DeleteDefCode(maCode);

            return result;
        }
        #endregion


        #region Def Detail
        public List<DefCodeDTO> GetDefMiCode()
        {
            DefCodeDAO db = new DefCodeDAO();
            List<DefCodeDTO> list = db.GetDefMiCode();

            return list;
        }

        #endregion
    }
}
