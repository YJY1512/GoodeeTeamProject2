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
        public int TotOutQty { get; set; } //총Out량
        public int TotPrdQty { get; set; } //총생산량
        public int TotDefectQty { get; set; } //총Loss수량


        public int DefectRate { get; set; } //총불량비율
        public int AttainmentRate { get; set; } //달성률
        public int QualityRate { get; set; } //양품률
        public int OperatingRate { get; set; } //가동률
        public int AverageDailyProduction { get; set; } //일일평균생산량
        public int AverageMonthProduction { get; set; } //월평균생산량
        public int TotalProductionDays { get; set; } //총생산일수
    }
}
