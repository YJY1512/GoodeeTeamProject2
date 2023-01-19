using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class Wo_Req_backup
	{
		public long Backup_Seq { get; set; }	 //
		public string Wo_Req_No { get; set; }	 //
		public string Item_Code { get; set; }	 //
		public int Req_Seq { get; set; }	 //
		public int Req_Qty { get; set; }	 //
		public string Req_Unit { get; set; }	 //
		public DateTime Prd_Plan_Date { get; set; }	 //
		public string Project_No { get; set; }	 //
		public string Project_Name { get; set; }	 //
		public string Sale_Emp { get; set; }	 //
		public string Work_Group { get; set; }	 //
		public DateTime End_Req_Date { get; set; }	 //
		public string Req_Status { get; set; }	 //
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}