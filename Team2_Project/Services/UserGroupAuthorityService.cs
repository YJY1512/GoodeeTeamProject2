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
        public bool InsertUserGroup(UserGroupAuthorityDTO uga)
        {
            UserGroupAuthorityDAO db = new UserGroupAuthorityDAO();
            bool list = db.InsertUserGroup(uga);

            return list;
        }
    }
}
