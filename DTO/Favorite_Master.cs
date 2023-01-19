using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class Favorite_Master
	{
		public long Seq { get; set; }	 //
		public string User_ID { get; set; }	 //
		public string Screen_Code { get; set; }	 //
		public string Parent_Screen_Code { get; set; }	 //
		public char Type { get; set; }	 //
		public int Sort_Index { get; set; }	 //
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}