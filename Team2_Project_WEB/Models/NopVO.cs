using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team2_Project_WEB.Models
{ // 발생일자, 작업장명, 비가동 대분류명, 비가동 상세분류명, 비가동발생일시, 비가동해제일시, 비가동시간
    public class NopVo
    {
        public string Nop_Date { get; set; }
        public string Wc_Name { get; set; }
        public string Nop_Ma_Name { get; set; }
        public string Nop_Mi_Name { get; set; }
        public DateTime Nop_HappenTime { get; set; }
        public DateTime Nop_CancelTime { get; set; }
        public TimeSpan TotNopTime
    {
            get
            {
                if (Nop_HappenTime == default(DateTime) || Nop_CancelTime == default(DateTime))
                    return TimeSpan.Zero;
                else
                    return Convert.ToDateTime(Nop_CancelTime) - Convert.ToDateTime(Nop_HappenTime);
            }
        }
    }
}