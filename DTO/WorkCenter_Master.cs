using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class WorkCenter_Master
	{
		public string Wc_Code { get; set; }	 //작업장 코드
		public string Wc_Name { get; set; }	 //작업장 명
		public string Wc_Group { get; set; }	 //작업장 그룹
		public string Process_Code { get; set; }	 //공정코드
		public string Remark { get; set; }	 //비고
		public char Use_YN { get; set; }	 //사용유무
		public char Auto_Wo_YN { get; set; }	 //자동작업지시여부
		public char Auto_Start_YN { get; set; }	 //자동지시시작여부
		public string Wo_Status { get; set; }	 //비가동상태
		public DateTime Last_Cnt_Time { get; set; }	 //최종실적처리기간
		public char Pallet_YN { get; set; }	 //팔렛생성유무
		public string Prd_Unit { get; set; }	 //실적단위
		public DateTime Ins_Date { get; set; }	 //
		public string Ins_Emp { get; set; }	 //
		public DateTime Up_Date { get; set; }	 //
		public string Up_Emp { get; set; }	 //
	}
}