using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team2_Project_WEB.Models
{ // 발생일시, 작업지시번호, 작업장명, 품목명, 불량현상 대분류명, 불량현상 상세분류명, 불량수량
    public class DefVO
    {
        public string Def_Date { get; set; }
        public string WorkOrderNo { get; set; }
        public string Wc_Name { get; set; }
        public string Item_Name { get; set; }
        public string Def_Ma_Name { get; set; }
        public string Def_Mi_Name { get; set; }
        public int Def_Qty { get; set; }
    }
}