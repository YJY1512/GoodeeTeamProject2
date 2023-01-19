using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class Goods_In_History
	{
		public string WorkOrderNo { get; set; }	 //
		public string Pallet_No { get; set; }	 //
		public string Grade_Code { get; set; }	 //
		public string Grade_Detail_Code { get; set; }	 //
		public string Grade_Detail_Name { get; set; }	 //
		public int In_Qty { get; set; }	 //
		public char Update_YN { get; set; }	 //
		public int F_In_Qty { get; set; }	 //
		public DateTime Closed_Time { get; set; }	 //
		public string Remark { get; set; }	 //
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}