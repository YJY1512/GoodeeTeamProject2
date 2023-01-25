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
    class ProcessMasterService
    {
        public List<ProcessMasterDTO> SetData()
        {
            ProcessMasterDAO db = new ProcessMasterDAO();
            List<ProcessMasterDTO> list = db.SetProcessList();
            db.Dispose();

            return list;
        }

        public bool InputProcess(ProcessMasterDTO newProcess, string user)
        {
            ProcessMasterDAO db = new ProcessMasterDAO();
            bool result = db.InputProcess(newProcess, user);
            db.Dispose();

            return result;
        }

        public bool EditProcess(ProcessMasterDTO editProcess, string user)
        {
            ProcessMasterDAO db = new ProcessMasterDAO();
            bool result = db.EditProcess(editProcess, user);
            db.Dispose();

            return result;
        }

        public List<ProcessMasterDTO> DelProcess(string txtProcessCode)
        {
            ProcessMasterDAO db = new ProcessMasterDAO();
            List<ProcessMasterDTO> list = db.DelProcess(txtProcessCode);
            db.Dispose();

            return list;
        }
    }
}
