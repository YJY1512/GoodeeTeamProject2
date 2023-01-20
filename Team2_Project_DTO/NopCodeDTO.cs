using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class NopMaCodeDTO
    {
        public string Nop_Ma_Code { get; set; }
        public string Nop_Ma_Name { get; set; }
        public string Use_YN { get; set; }
        public string Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public string Up_Date { get; set; }
        public string Up_Emp { get; set; }
    }

    public class NopMiCodeDTO
    {
        public string Nop_Mi_Code { get; set; }
        public string Nop_Mi_Name { get; set; }
        public string Nop_Ma_Code { get; set; }
        public string Regular_Type { get; set; }
        public string Nop_type { get; set; }
        public string Use_YN { get; set; }
        public string Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public string Up_Date { get; set; }
        public string Up_Emp { get; set; }
    }
}
