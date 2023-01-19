using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class User_Master
	{
		public string User_ID { get; set; }	 //
		public string User_Name { get; set; }	 //
		public string User_PW { get; set; }	 //
		public string Customer_Code { get; set; }	 //
		public char User_Type { get; set; }	 //
		public int PW_Reset_Count { get; set; }	 //
		public string Default_Screen_Code { get; set; }	 //
		public string Default_Major_Process_Code { get; set; }	 //
		public char Monitoring_YN { get; set; }	 //
		public char Use_YN { get; set; }	 //
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}