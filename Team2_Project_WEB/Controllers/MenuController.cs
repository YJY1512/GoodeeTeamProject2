using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using Team2_Project_WEB.Models;

namespace Team2_Project_WEB.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public PartialViewResult MenuList(string am)
        {
            string[] pMenuName = WebConfigurationManager.AppSettings["PmenuList"].Split(',');
            string[] pMenuAM = WebConfigurationManager.AppSettings["PmenuListAM"].Split(',');
            string[] menuName = WebConfigurationManager.AppSettings["menuList"].Split(',');
            string[] menuAM = WebConfigurationManager.AppSettings["menuListAM"].Split(',');
            List<MenuVO> pList = new List<MenuVO>();
            List<MenuVO> list = new List<MenuVO>();

            for (int i = 0; i < pMenuName.Length; i++)
            {
                pList.Add(new MenuVO { MenuName = pMenuName[i], MenuAM = pMenuAM[i] });
            }

            for (int i = 0; i < menuName.Length; i++)
            {
                list.Add(new MenuVO { MenuName = menuName[i], MenuAM = menuAM[i] });
            }

            ViewBag.PMenuList = pList;
            ViewBag.MenuList = list;

            return PartialView();
        }
    }
}