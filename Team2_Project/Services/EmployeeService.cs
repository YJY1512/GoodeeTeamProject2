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

        public void Insert()
        {
            EmployeeDAO db = new EmployeeDAO();
            db.Insert();
            db.Dispose();

            return;
        }

        public void Update()
        {
            EmployeeDAO db = new EmployeeDAO();
            db.Update();
            db.Dispose();

            return;
        }

        public void Delete()
        {
            EmployeeDAO db = new EmployeeDAO();
            db.Delete();
            db.Dispose();

            return;
        }

        
    }
}
