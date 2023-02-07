using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team2_Project_WEB.Models
{
    public class ProductionVO
    {//wo.WorkOrderNo, Plan_Date, ppd.Item_Code, Item_Name, Plan_Qty_Box, ( prd_Qty + TotDef / Plan_Qty_Box ) Progress, prd_Qty, TotDef
        public string WorkOrderNo { get; set; }
        public string Plan_Date { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public int Plan_Qty_Box { get; set; }
        public decimal Progress { get; set; }
        public int Prd_Qty { get; set; }
        public int TotDef { get; set; }
        public int Total { get { return Prd_Qty + TotDef; } }
        public decimal FairRatio { get 
            {
                if (Total == 0)
                    return 0;
                else
                    return Math.Round((decimal)Prd_Qty * 100 / Total, 2); 
            } 
        }
        public decimal DefRatio { get 
            {
                if (Total == 0)
                    return 0;
                else
                    return Math.Round((decimal)TotDef * 100 / Total, 2); 
            } 
        }
    }
}