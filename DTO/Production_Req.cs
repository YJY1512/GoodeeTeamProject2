using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class Production_Req
	{
		public string Prd_Req_No { get; set; }	 //
		public DateTime Req_Date { get; set; }	 //
		public string Req_Seq { get; set; }	 //
		public string Item_Code { get; set; }	 //
		public int Req_Qty { get; set; }	 //
		public string Customer_Name { get; set; }	 //
		public string Project_No { get; set; }	 //
		public string Project_Nm { get; set; }	 //
		public string Sale_Prsn_Nm { get; set; }	 //
		public DateTime Delivery_Date { get; set; }	 //
		public int Plan_Qty { get; set; }	 //
		public char Plan_YN { get; set; }	 //
		public string Prd_Progress_Status { get; set; }	 //
		public string Remark { get; set; }	 //
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}