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
        public List<MenuDTO> GetMenuInfo(string grpCode, string userID)
        {
            MenuDAO db = new MenuDAO();
            List<MenuDTO> list = db.GetMenuInfo(grpCode, userID);
            db.Dispose();

            return list;
        }

        //public List<MenuDTO> GetMenuFavInfo(string userID)
        //{
        //    MenuDAO db = new MenuDAO();
        //    List<MenuDTO> list = db.GetMenuFavInfo(userID);
        //    db.Dispose();

        //    return list;
        //}

        public List<MenuDTO> GetFavoriteInfo(string userID)
        {
            MenuDAO db = new MenuDAO();
            List<MenuDTO> list = db.GetFavoriteInfo(userID);
            db.Dispose();

            return list;
        }

        public bool SaveFavorite(string userID, List<MenuDTO> favoriteList)
        {
            MenuDAO db = new MenuDAO();
            bool result = db.SaveFavorite(userID, favoriteList);
            db.Dispose();

            return result;
        }
    }
}
