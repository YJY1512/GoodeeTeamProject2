using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class PopPrdDTO
    {
        public string WorkLineName { get; set; }
        public string WorkLineCode { get; set; }
        public DateTime WorkOrderDate { get; set; }
        public DateTime PrdDate { get; set; }
        public string WrokOrderNum { get; set; }
        public string PrdName { get; set; }
        public string PrdCode { get; set; }
        public int PlanQty { get; set; }
        private int prdQtySum;
        public int PrdQtySum
        {
            get
            {
                return prdQtySum;
            }
            set
            {
                int sum = 0;
                if (PrdQty.Count < 1) defQtySum = 0;
                else
                {
                    foreach (var def in PrdQty)
                    {
                        sum += def.Item_Qty;
                    }
                    prdQtySum = sum;
                }
            }
        }
        private int defQtySum;
        public int DefQtySum
        {
            get
            {
                return defQtySum;
            }
            set 
            {
                int sum = 0;
                if (DefQty.Count < 1) defQtySum = 0;
                else
                {
                    foreach (var def in DefQty)
                    {
                        sum += def.Item_Qty;
                    }
                    defQtySum = sum;
                }
            }
        }
        public DateTime PrdStartTime { get; set; }
        public DateTime PrdEndTime { get; set; }
        public string Remark { get; set; }

        public List<PopPrdQtyDTO> PrdQty { get; set; }
        public List<PopDefQtyDTO> DefQty { get; set; }
    }

    public class PopPrdQtyDTO
    {
        public string WorkOrderNo { get; set; }
        public string Item_Code { get; set; }
        public string Item_Rank { get; set; } // 양품 불량 구분 > 상, 하품 구분  나중에 쓰면 씀
        // 양품이면 갯수만, 불량이면 분류 코드 
        public string PrdRankName { get; set; }
        public int Item_Qty { get; set; }
        public DateTime Item_time { get; set; }
    }
    public class PopDefQtyDTO
    {
        public DateTime Item_time { get; set; }
        public string WorkOrderNo { get; set; }
        public string Item_Code { get; set; }
        public int Item_Qty { get; set; }
        public string DefMaCode { get; set; }
        public string DefMaName { get; set; }
        public string DefMiCode { get; set; }
        public string DefMiName { get; set; }
    }

    public class DefVO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }
    }
}
