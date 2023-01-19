using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class RunTime_History
	{
		public int Time_Seq { get; set; }	 //
		public string WorkOrderNo { get; set; }	 //
		public DateTime Run_StartTime { get; set; }	 //
		public DateTime Run_EndTime { get; set; }	 //
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}