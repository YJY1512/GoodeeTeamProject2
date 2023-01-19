using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class Screenitem_Master
	{
		public string Screen_Code { get; set; }	 //
		public int Sort_Index { get; set; }	 //
		public string Type { get; set; }	 //
		public string Screen_Path { get; set; }	 //
		public string ContentDLL { get; set; }	 //
		public char Monitoring_YN { get; set; }	 //
		public char Use_YN { get; set; }	 //
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}