using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class WorkOrderDTO
    {
		public string WorkOrderNo { get; set; }  //
		public int Plan_Qty_Box { get; set; }    //작업지시수량
		public string Plan_Unit { get; set; }    //
		public DateTime Plan_Date { get; set; }  //작업지시일자
		public DateTime Prd_Date { get; set; }   //실제생산일자
		public string Prd_Plan_No { get; set; }  //
		public string Wc_Code { get; set; }  //
		public string Wc_Name { get; set; }  //
		public string Wo_Status { get; set; }    //
		public string Wo_Status_Code { get; set; }//
		public int Wo_Order { get; set; }    //작업순서
		public DateTime Plan_StartTime { get; set; }     //
		public DateTime Plan_EndTime { get; set; }   //
		public DateTime Prd_StartTime { get; set; }  //
		public DateTime Prd_EndTime { get; set; }    //
		public int In_Qty_Sub { get; set; }  //pop
		public int In_Qty_Main { get; set; }     //pop
		public int Out_Qty_Main { get; set; }    //pop
		public int Out_Qty_Sub { get; set; }     //pop
		public int Prd_Qty { get; set; }     //pop 실제생산수량 = Out_Qty_Main
		public string Prd_Unit { get; set; }     //
		public DateTime Worker_CloseTime { get; set; }   //
		public DateTime Manager_CloseTime { get; set; }  //
		public string Remark { get; set; }   //
		public DateTime Ins_Date { get; set; }   //
		public string Ins_Emp { get; set; }  //
		public DateTime Up_Date { get; set; }    //
		public string Up_Emp { get; set; }   //

		public string Item_Code { get; set; }    //
		public string Item_Name { get; set; }    //

		public string Process_Code { get; set; }    //
		public string Process_Name { get; set; }    //

		
	}
}
