using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    class OrderService
    {
        public DataTable GetOrderList(string[] list)
        {
            OrderDAO db = new OrderDAO();
            DataTable dt = db.GetOrderList(list);
            db.Dispose();

            return dt;
        }

        public bool Insert(EmployeeDTO data, string Ins_Emp)
        {
            EmployeeDAO db = new EmployeeDAO();
            bool result = db.Insert(data, Ins_Emp);
            db.Dispose();

            return false;
        }

        public bool Update(EmployeeDTO data, string Ins_Emp)
        {
            EmployeeDAO db = new EmployeeDAO();
            bool result = db.Update(data, Ins_Emp);
            db.Dispose();

            return result;
        }

        public string Delete(string empID)
        {
            EmployeeDAO db = new EmployeeDAO();
            string msg = db.Delete(empID);
            db.Dispose();

            return msg;
        }

        public List<ItemDTO> GetItemCodeName()
        {
            ItemDAO db = new ItemDAO();
            List<ItemDTO> list = db.GetItemCodeName();
            db.Dispose();

            return list;
        }

        public List<ProjectDTO> GetProjectList()
        {
            ProjectDAO db = new ProjectDAO();
            List<ProjectDTO> list = db.GetProjectList();
            db.Dispose();

            return list;
        }
    }
}
