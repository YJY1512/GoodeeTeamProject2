﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using Team2_Project_WEB.Models;
using Team2_Project_WEB.Models.DAO;
using System.Text;

namespace Team2_Project_WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Item(string from = "", string to = "") //제품별 판매량 조회
        {
            ViewBag.ColText = "선택기간 ";
            ViewBag.FromDate = from;
            ViewBag.ToDate = to;

            if (string.IsNullOrWhiteSpace(from) && string.IsNullOrWhiteSpace(from))
            {
                ViewBag.ColText = "최근 30일 ";
                ViewBag.FromDate = DateTime.Today.AddMonths(-1).ToString("yyyy-MM-dd");
                ViewBag.ToDate = DateTime.Today.ToString("yyyy-MM-dd");
            }
            else if (string.IsNullOrWhiteSpace(from))
                ViewBag.FromDate = Convert.ToDateTime(to).AddMonths(-1).ToString("yyyy-MM-dd");
            else if (string.IsNullOrWhiteSpace(to))
                ViewBag.ToDate = Convert.ToDateTime(from).AddMonths(1).ToString("yyyy-MM-dd");

            ItemDAO dao = new ItemDAO();
            List<ItemVO> list = dao.GetItemList(ViewBag.FromDate, ViewBag.ToDate);
            StringBuilder sb1 = new StringBuilder();
            List<int> OrderSumList = new List<int>();
            List<int> CustomerSumList = new List<int>();
            foreach (ItemVO item in list)
            {
                if (item.OrderSum < 1)
                    continue;
                sb1.Append(item.Name).Append(",");
                OrderSumList.Add(item.OrderSum);
                CustomerSumList.Add(item.CustomerSum);
            }

            ViewData["Name"] = string.IsNullOrWhiteSpace(sb1.ToString().TrimEnd(',')) ? "주문없음" : sb1.ToString().TrimEnd(',');
            ViewData["OrderSum"] = "[" + string.Join(",", OrderSumList) + "]";
            ViewData["CustomerSum"] = "[" + string.Join(",", CustomerSumList) + "]";

            return View(list);
        }

        public ActionResult ProdO(string date, string itemCode) //생산지시 실적 조회
        {
            ViewBag.Date = date;
            if (string.IsNullOrWhiteSpace(date))
                ViewBag.Date = DateTime.Today.ToString("yyyy-MM-dd");

            try
            {
                string[] dateTemp = ViewBag.Date.Split('-');
                ViewBag.DateStr = $"{dateTemp[0]}년 {dateTemp[1]}월 {dateTemp[2]}일";
            }
            catch
            {
                ViewBag.DateStr = "";
            }

            ProductionDAO daoP = new ProductionDAO();
            List<ProductionVO> prodOlist = daoP.GetProdOList(ViewBag.Date, itemCode);
            daoP.Dispose();

            ItemDAO daoI = new ItemDAO();
            List<ItemVO> itemList = daoI.GetItemCodeNameList();
            daoI.Dispose();

            ViewBag.Items = new SelectList(itemList, "Code", "Name");

            // 화면 상단 선택일 진행도 Progerss Bar로 표시
            if (prodOlist.Count > 0)
                ViewBag.DateProgress = prodOlist.Sum((e) => e.Progress) / prodOlist.Count;
            else
                ViewBag.DateProgress = 0.00;

            return View(prodOlist);
        }

        public ActionResult TotProd(string fromDate, string toDate, string wcCode, string itemCode) //제조 종합 효율 조회
        {
            //날짜(Range), 작업장, 품목
            //작업일자, 계획수량, 양품수량, 불량수량, 양품률, 불량률, 작업시작시각, 작업종료시각, 작업시간, 비가동시간, 가동률, 비가동률, 시간당 생샨량

            // 작업장, 품목 목록 불러오기
            WorkCenterDAO daoW = new WorkCenterDAO();
            List<CommonVO> wcList = daoW.GetWorkCenterCodeList();
            daoW.Dispose();
            ViewBag.wcList = new SelectList(wcList, "Code", "Name");

            ItemDAO daoI = new ItemDAO();
            List<ItemVO> itemList = daoI.GetItemCodeNameList();
            daoI.Dispose();
            ViewBag.Items = new SelectList(itemList, "Code", "Name");

            // 조회조건(기간)
            ViewBag.FromDate = fromDate;
            ViewBag.ToDate = toDate;
            if (string.IsNullOrWhiteSpace(fromDate) && string.IsNullOrWhiteSpace(toDate))
            {
                ViewBag.FromDate = DateTime.Today.AddMonths(-1).ToString("yyyy-MM-dd");
                ViewBag.ToDate = DateTime.Today.ToString("yyyy-MM-dd");
            }
            else if (string.IsNullOrWhiteSpace(fromDate))
                ViewBag.FromDate = Convert.ToDateTime(toDate).AddMonths(-1).ToString("yyyy-MM-dd");
            else if (string.IsNullOrWhiteSpace(toDate))
                ViewBag.ToDate = Convert.ToDateTime(fromDate).AddMonths(1).ToString("yyyy-MM-dd");

            // 데이터 가져오기


            return View();
        }

        public ActionResult Defect() //불량 이력 조회
        {
            //날짜, 작업장, 품목
            //발생일자, 작업장, 품목, 불량코드, 불량수량
            //불량발생일자, 품목, 작업장, 불량코드로 차트
            //페이징

            return View();
        }






        public ActionResult WPlace() //작업장 가동현황 조회 - 일정보고 넣기 / 빼기 생각
        {
           //가동상태, 작업장명, 작업장 코드, 공정명, 진행 생산지시, 상태, 비고:비가동이면 사유

            return View();
        }

        

        public ActionResult Schedule() //월별 스케쥴 조회 - 일정보고 넣기 / 빼기 생각
        {
            return View();
        }

        public ActionResult ProdT(string prdCode) //시간당 생산량 조회 - 불가능(실적 테이블 없음)
        {
            //생산지시 선택 -> 시작시간 ~ 작업장 마감시간 시간별로 쪼개서 생산량 분석
            //바 차트로 시간당 생산량
            //추가)생산량 가장 많은 시간, 적은 시간 색갈 따로
            //작업지시번호(작업일자) 시간당 생산량
            //작업장:작업장명(작업장번호)  생산품목:품목명(품목코드)
            //시간(09:00) 생산량, 양품수량, 불량수량, 양품률, 불량률, 비고:비가동(빨간색으로?)

            /*
            // 작업지시번호 DropDown 50개
            ProductionDAO dao = new ProductionDAO();
            List<string> codeList = dao.GetProdNoList();
            ViewBag.CodeList = new SelectList(codeList);

            // 선택된 생산지시 정보 불러오기
            if (string.IsNullOrWhiteSpace(prdCode))
                return View();
            */

            return View();
        }
    }
}