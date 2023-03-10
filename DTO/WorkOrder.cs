using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class WorkOrder
	{
		public string WorkOrderNo { get; set; }	 //
		public int Plan_Qty_Box { get; set; }	 //
		public string Plan_Unit { get; set; }	 //
		public DateTime Plan_Date { get; set; }	 //
		public DateTime Prd_Date { get; set; }	 //
		public string Prd_Plan_No { get; set; }	 //
		public string Wc_Code { get; set; }	 //
		public string Wo_Status { get; set; }	 //
		public int Wo_Order { get; set; }	 //
		public DateTime Plan_StartTime { get; set; }	 //
		public DateTime Plan_EndTime { get; set; }	 //
		public DateTime Prd_StartTime { get; set; }	 //
		public DateTime Prd_EndTime { get; set; }	 //
		public int In_Qty_Sub { get; set; }	 //
		public int In_Qty_Main { get; set; }	 //
		public int Out_Qty_Main { get; set; }	 //
		public int Out_Qty_Sub { get; set; }	 //
		public int Prd_Qty { get; set; }	 //
		public string Prd_Unit { get; set; }	 //
		public DateTime Worker_CloseTime { get; set; }	 //
		public DateTime Manager_CloseTime { get; set; }	 //
		public string Remark { get; set; }	 //
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}