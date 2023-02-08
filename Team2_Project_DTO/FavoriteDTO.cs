using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class FavoriteDTO
    {
        public int    Seq                   { get; set; }   //순번
        public string User_ID               { get; set; }   //사용자 ID
        public string Screen_Code           { get; set; }   //화면코드
        public string Parent_Screen_Code    { get; set; }   //부모코드  
        public string Type                  { get; set; }   //유형
        public int    Sort_Index            { get; set; }   //순서
        public string Menu_Name             { get; set; }   //메뉴이름
        public int    Menu_Level            { get; set; }   //메뉴레벨
        public string Form_Name             { get; set; }   //폼이름
        public string Ins_Date              { get; set; }   //최초등록날짜
        public string Ins_Emp               { get; set; }   //최초등록자
        public string Up_Date               { get; set; }   //최종수정날짜
        public string Up_Emp                { get; set; }   //최종수정자
    }
}
