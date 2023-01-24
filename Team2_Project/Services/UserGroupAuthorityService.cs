using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    public class UserGroupAuthorityService
    {
        public List<UserGroupAuthorityDTO> GetUserGroupCodeSearh()
        {
            UserGroupAuthorityDAO db = new UserGroupAuthorityDAO();
            List<UserGroupAuthorityDTO> list = db.GetUserGroupCodeSearh();

            return list;
        }
        public bool InsertUserGroup(UserGroupAuthorityDTO uga)
        {
            UserGroupAuthorityDAO db = new UserGroupAuthorityDAO();
            bool list = db.InsertUserGroup(uga);

            return list;
        }

        public bool UpdateUserGroup(UserGroupAuthorityDTO uga)
        {
            UserGroupAuthorityDAO db = new UserGroupAuthorityDAO();
            bool list = db.UpdateUserGroup(uga);

            return list;
        }
    }
}
