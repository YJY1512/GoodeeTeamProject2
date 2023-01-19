using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    class ItemService
    {
        public List<ItemDTO> GetItemSearch(ItemDTO item)
        {
            ItemDAO db = new ItemDAO();
            List<ItemDTO> list = db.GetItemSearch(item);
            db.Dispose();
            return list;
        }

        public bool GetItemAdd(ItemDTO item)
        {
            ItemDAO db = new ItemDAO();
            bool result = db.GetItemAdd(item);
            db.Dispose();
            return result;
        }

        public List<ItemDTO> GetCurItem(string item)
        {
             ItemDAO db = new ItemDAO();
            List<ItemDTO> list = db.GetCurItem(item);
            db.Dispose();
            return list;
        }

        public bool GetItemUpdate(ItemDTO item)
        {
            ItemDAO db = new ItemDAO();
            bool result = db.GetItemUpdate(item);
            db.Dispose();
            return result;
        }
    }
}
