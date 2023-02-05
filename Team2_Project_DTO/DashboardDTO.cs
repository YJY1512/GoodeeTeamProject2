using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class DashboardDTO //대쉬보드 Mapping
	{
		public string DashboardItem { get; set; }
		public string Title { get; set; }
		public string Title_Ko { get; set; }
		public string User_ID { get; set; }
		public string Loc { get; set; }
		public string Use_YN { get; set; }


		public string TopPage { get; set; }
		public string BottomPage { get; set; }



		public string ItemPath { get; set;}
		public string ItemDLL { get; set;}	
		public int Sort_Index { get; set;}	
		public string Up_Date { get; set; } //DateTime
		public string Up_Emp { get; set;}	
		public string Ins_Date { get; set; } //DateTime
		public string Ins_Emp { get; set;}
	}
}