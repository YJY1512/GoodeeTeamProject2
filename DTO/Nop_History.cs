using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class Nop_History
	{
		public long Nop_Seq { get; set; }	 //
		public DateTime Nop_Date { get; set; }	 //
		public DateTime Nop_HappenTime { get; set; }	 //
		public DateTime Nop_CancelTime { get; set; }	 //
		public string Nop_Mi_Code { get; set; }	 //
		public string Nop_Type { get; set; }	 //
		public decimal Nop_Time { get; set; }	 //
		public string Remark { get; set; }	 //
		public string Wc_Code { get; set; }	 //
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}