using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class MenuDTO
    {
        public string Screen_Code        { get; set; }
        public string Parent_Screen_Code { get; set; }
        public int    Sort_Index         { get; set; }
        public string Type               { get; set; }
        public string Form_Name          { get; set; }
        public string Menu_Name          { get; set; }
        public string Menu_Image         { get; set; }
        public int    Menu_Level         { get; set; }
        public string Use_YN             { get; set; }
        public int    Seq                { get; set; }
        public string Pre_Type           { get; set; }
    }
}
