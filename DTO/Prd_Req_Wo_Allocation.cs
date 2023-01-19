using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class Prd_Req_Wo_Allocation
	{
		public string Prd_Req_No { get; set; }	 //
		public string WorkOrderNo { get; set; }	 //
		public int Prd_Qty { get; set; }	 //
		public string Remark { get; set; }	 //
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}