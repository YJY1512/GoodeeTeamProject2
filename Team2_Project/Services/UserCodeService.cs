﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    public class UserCodeService
    {
        public List<UserCodeDTO> GetUserCode()
        {
            UserCodeDAO db = new UserCodeDAO();
            List<UserCodeDTO> list = db.GetUserCode();

            return list;
        }
    }
}
