using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class DashboardDTO //대쉬보드 Mapping
	{
		/* DashboardItem
		   Title
		   ItemPath
		   ItemDLL
		   Sort_Index
		   Use_YN
		   Up_Date
		   Up_Emp
		   Ins_Date
		   Ins_Emp			*/

		public string DashboardItem { get; set;}
		public string Title { get; set;}	
		public string ItemPath { get; set;}
		public string ItemDLL { get; set;}	
		public int Sort_Index { get; set;}	
		public string Use_YN { get; set;}	
		public string Up_Date { get; set; } //DateTime
		public string Up_Emp { get; set;}	
		public string Ins_Date { get; set; } //DateTime
		public string Ins_Emp { get; set;}
	}

	public class DashboardMappingDTO //대쉬보드
	{
		/* User_ID
		   DashboardItem
		   Loc
		   Use_YN
		   Up_Date
		   Up_Emp
		   Ins_Date
		   Ins_Emp			*/

		public string User_ID { get; set; }
		public string DashboardItem { get; set; }
		public string Loc { get; set; }
		public string Use_YN { get; set; }
		public string Up_Date { get; set; }
		public string Up_Emp { get; set; }
		public string Ins_Date { get; set; }
		public string Ins_Emp { get; set; }
	}
}