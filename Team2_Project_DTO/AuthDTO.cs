using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Project_DTO
{
    public class AuthDTO
    {
        public string UserGroup_Code { get; set; }
        public string Screen_Code { get; set; }
        public string Parent_Screen_Code { get; set; }
        public string Menu_Name   { get; set; }
        public bool Module      { get; set; }
        public bool Src         { get; set; }
        public bool Ins         { get; set; }
        public bool Upd         { get; set; }
        public bool Del         { get; set; }
        public string Type        { get; set; }
        public string Pre_Type    { get; set; }
        public int    Sort_Index  { get; set; }
    } 
}
