using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    public class MenuService
    {
        public List<MenuDTO> GetMenuInfo(string grpCode)
        {
            MenuDAO db = new MenuDAO();
            List<MenuDTO> list = db.GetMenuInfo(grpCode);
            db.Dispose();

            return list;
        }

        public List<MenuDTO> GetFavoriteInfo(string userID)
        {
            MenuDAO db = new MenuDAO();
            List<MenuDTO> list = db.GetFavoriteInfo(userID);
            db.Dispose();

            return list;
        }
    }
}
