using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class UserGroup_Master
	{
		public string UserGroup_Code { get; set; }	 //
		public string UserGroup_Name { get; set; }	 //
		public char Admin { get; set; }	 //
		public char Use_YN { get; set; }	 //
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}