using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class Item_level_Master
	{
		public string Level_Code { get; set; }	 //
		public string Level_Name { get; set; }	 //
		public int Box_Qty { get; set; }	 //
		public int Pcs_Qty { get; set; }	 //
		public char Use_YN { get; set; }	 //
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}