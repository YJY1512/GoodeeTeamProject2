using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    class EmployeeService
    {
        public DataTable GetEmployeeList()
        {
            EmployeeDAO db = new EmployeeDAO();
            DataTable dt = db.GetEmployeeList();
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

        public bool Delete(string empID)
        {
            EmployeeDAO db = new EmployeeDAO();
            bool result = db.Delete(empID);
            db.Dispose();

            return result;
        }

        public List<CodeDTO> GetUserGroupCode()
        {
            UserGroupDAO db = new UserGroupDAO();
            List<CodeDTO> list = db.GetUserGroupCode();
            db.Dispose();

            return list;
        }
    }
}
