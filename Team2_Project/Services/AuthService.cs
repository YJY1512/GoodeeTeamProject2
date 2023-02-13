using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    public class AuthService
    {
        public List<AuthDTO> GetAuthInfo(string grpCode)
        {
            AuthDAO db = new AuthDAO();
            List<AuthDTO> list = db.GetAuthInfo(grpCode);
            db.Dispose();

            return list;
        }

        public bool SaveAuthority(string grpCode, string userID, List<AuthDTO> authList)
        {
            AuthDAO db = new AuthDAO();
            bool result = db.SaveAuthority(grpCode, userID, authList);
            db.Dispose();

            return result;
        }
    }
}
