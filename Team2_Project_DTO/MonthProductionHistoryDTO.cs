using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class MonthProductionHistoryDTO
    {
        //I.Item_Code, I.Item_Name, I.Item_Type, LC.TotPlanQty, LC.TotInQty, LC.TotPrd_Qty, LC.TotLoss
        public string Item_Code { get; set; } //품목코드
        public string Item_Name { get; set; } //품목명
        public string Item_Type { get; set; } //품목유형
        public int TotPlanQty { get; set; } //총목표량
        public int TotInQty { get; set; } //총투입량
        public int TotPrd_Qty { get; set; } //총생산량
        public int TotLoss { get; set; } //총Loss수량
    }
}
