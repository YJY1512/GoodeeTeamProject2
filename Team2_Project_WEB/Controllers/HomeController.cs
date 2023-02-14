using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Web.Mvc;
using Team2_Project_WEB.Models;
using Team2_Project_WEB.Models.DAO;

namespace Team2_Project_WEB.Controllers
{
    public class HomeController : Controller
    {
        int pageSize = int.Parse(WebConfigurationManager.AppSettings["list_pagesize"]);

        // GET: Home
        public ActionResult Index()
        {
            Session["LoginFailed"] = false;
            if (Session["UserName"] == null)
            {
                return RedirectToAction("Index", "Login");
            }

            return RedirectToAction("ProdO", "Home");
        } // 로그인 기능 주석

        public ActionResult Item(string from = "", string to = "") //품목별 수주현황 조회
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

            Session["SelectedAM"] = "Item";

            return View(list);
        }

        public ActionResult ProdO(string date, string itemCode, int page = 1) //작업지시 실적 조회
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

            if (!string.IsNullOrWhiteSpace(itemCode) && itemCode.Equals("All"))
                itemCode = null;
            ViewBag.ItemCode = itemCode;
            int totalCount;
            ProductionDAO daoP = new ProductionDAO();
            List<ProductionVO> prodOlist = daoP.GetProdOList(ViewBag.Date, itemCode, page, out totalCount);
            daoP.Dispose();

            ItemDAO daoI = new ItemDAO();
            List<CommonVO> itemList = daoI.GetItemCodeNameList();
            daoI.Dispose();

            itemList.Insert(0, new CommonVO { Code = "All", Name ="전체"}); 
            ViewBag.Items = new SelectList(itemList, "Code", "Name");

            ViewBag.Page = new PagingInfo
            {
                TotalItems = totalCount,
                CurrentPage = page,
                ItemsPerPage = pageSize
            };

            // 화면 상단 선택일 진행률 Progerss Bar로 표시
            if (prodOlist.Count > 0 && prodOlist.Sum((e) => e.Plan_Qty_Box) != 0)
            {
                double totProgress = (double)prodOlist.Sum((e) => e.Total) / prodOlist.Sum((e) => e.Plan_Qty_Box);
                ViewBag.DateProgress = totProgress > 1.00 ? 1.00 : totProgress;
            }
            else
                ViewBag.DateProgress = 0.00;

            Session["SelectedAM"] = "ProdO";

            return View(prodOlist);
        }

        public ActionResult TotProd(string fromDate = "", string toDate = "", string wcCode = null, string itemCode = null,  int page = 1) //작업지시 종합 실적 조회
        {
            // 날짜(Range), 작업장, 품목
            // 작업일자, 작업수량, 양품수량, 불량수량, 양품률, 불량률, 작업시작시각, 작업종료시각, 작업시간, 시간당 생샨량

            // 작업장, 품목 목록 불러오기
            WorkCenterDAO daoW = new WorkCenterDAO();
            List<CommonVO> wcList = daoW.GetWorkCenterCodeList();
            daoW.Dispose();
            wcList.Insert(0, new CommonVO { Code = "All", Name = "전체" });
            ViewBag.wcList = new SelectList(wcList, "Code", "Name");

            ItemDAO daoI = new ItemDAO();
            List<CommonVO> itemList = daoI.GetItemCodeNameList();
            daoI.Dispose();
            itemList.Insert(0, new CommonVO { Code = "All", Name = "전체" });
            ViewBag.Items = new SelectList(itemList, "Code", "Name");

            // 조회조건(기간)
            ViewBag.FromDate = fromDate;
            ViewBag.ToDate = toDate;
            if (string.IsNullOrWhiteSpace(fromDate) && string.IsNullOrWhiteSpace(toDate))
            {
                //ViewBag.FromDate = DateTime.Today.AddMonths(-1).ToString("yyyy-MM-dd");
                //ViewBag.ToDate = DateTime.Today.ToString("yyyy-MM-dd");
                ViewBag.FromDate = DateTime.Today.AddDays(-13).ToString("yyyy-MM-dd");
                ViewBag.ToDate = DateTime.Today.ToString("yyyy-MM-dd");
            }
            else if (string.IsNullOrWhiteSpace(fromDate))
                ViewBag.FromDate = Convert.ToDateTime(toDate).AddMonths(-1).ToString("yyyy-MM-dd");
            else if (string.IsNullOrWhiteSpace(toDate))
                ViewBag.ToDate = Convert.ToDateTime(fromDate).AddMonths(1).ToString("yyyy-MM-dd");

            // 데이터 가져오기
            string searchToDate = Convert.ToDateTime(ViewBag.ToDate).AddDays(1).ToString("yyyy-MM-dd");
            int totalCount;
            if (!string.IsNullOrWhiteSpace(wcCode) && wcCode.Equals("All"))
                wcCode = null;
            if (!string.IsNullOrWhiteSpace(itemCode) && itemCode.Equals("All"))
                itemCode = null;

            ProductionDAO daoP = new ProductionDAO();
            List<ProductionVO> prodList = daoP.GetProdList_TotProd(ViewBag.FromDate, searchToDate, wcCode, itemCode, page, out totalCount);
            daoP.Dispose();

            ViewBag.ItemCode = itemCode;
            ViewBag.WcCode = wcCode;

            ViewBag.Page = new PagingInfo
            {
                TotalItems = totalCount,
                CurrentPage = page,
                ItemsPerPage = pageSize
        };

            StringBuilder sb1 = new StringBuilder();
            List<int> fairSum = new List<int>();
            List<int> defSum = new List<int>();
            foreach (ProductionVO item in prodList)
            {
                sb1.Append(item.Dates).Append(",");
                fairSum.Add(item.Prd_Qty);
                defSum.Add(item.TotDef);
            }

            ViewData["Name"] = sb1.ToString().TrimEnd(',');
            ViewData["fairSum"] = "[" + string.Join(",", fairSum) + "]";
            ViewData["defSum"] = "[" + string.Join(",", defSum) + "]";

            Session["SelectedAM"] = "TotProd";

            return View(prodList);
        }

        public ActionResult Defect(string fromDate = "", string toDate = "", string wcCode = null, string itemCode = null, int page = 1) //불량 내역 조회
        {
            // 날짜, 작업장, 품목
            // 발생일시, 작업지시번호, 작업장명, 품목명, 불량현상 대분류명, 불량현상 상세분류명, 불량수량

            // 작업장, 품목 목록 불러오기
            WorkCenterDAO daoW = new WorkCenterDAO();
            List<CommonVO> wcList = daoW.GetWorkCenterCodeList();
            daoW.Dispose();
            wcList.Insert(0, new CommonVO { Code = "All", Name = "전체" });
            ViewBag.wcList = new SelectList(wcList, "Code", "Name");

            ItemDAO daoI = new ItemDAO();
            List<CommonVO> itemList = daoI.GetItemCodeNameList();
            daoI.Dispose();
            itemList.Insert(0, new CommonVO { Code = "All", Name = "전체" });
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

            //데이터 가져오기
            string searchToDate = Convert.ToDateTime(ViewBag.ToDate).AddDays(1).ToString("yyyy-MM-dd");
            int totalCount;
            if (!string.IsNullOrWhiteSpace(wcCode) && wcCode.Equals("All"))
                wcCode = null;
            if (!string.IsNullOrWhiteSpace(itemCode) && itemCode.Equals("All"))
                itemCode = null;


            DefDAO daoD = new DefDAO();
            List<DefVO> defList = daoD.GetDefList(ViewBag.FromDate, searchToDate, wcCode, itemCode, page, out totalCount);
            daoD.Dispose();

            ViewBag.ItemCode = itemCode;
            ViewBag.WcCode = wcCode;

            ViewBag.Page = new PagingInfo
            {
                TotalItems = totalCount,
                CurrentPage = page,
                ItemsPerPage = pageSize
            };

            Session["SelectedAM"] = "Defect";

            return View(defList);
        }

        public ActionResult WPlace(string fromDate = "", string toDate = "", string wcCode = null, string itemCode = null, int page = 1) // 비가동 내역 조회
        {
            // 날짜, 작업장
            // 발생일자, 작업장명, 비가동 대분류명, 비가동 상세분류명, 비가동발생일시, 비가동해제일시, 비가동시간

            // 작업장, 품목 목록 불러오기
            WorkCenterDAO daoW = new WorkCenterDAO();
            List<CommonVO> wcList = daoW.GetWorkCenterCodeList();
            daoW.Dispose();
            wcList.Insert(0, new CommonVO { Code = "All", Name = "전체" });
            ViewBag.wcList = new SelectList(wcList, "Code", "Name");

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

            //데이터 가져오기
            string searchToDate = Convert.ToDateTime(ViewBag.ToDate).AddDays(1).ToString("yyyy-MM-dd");
            int totalCount;
            if (!string.IsNullOrWhiteSpace(wcCode) && wcCode.Equals("All"))
                wcCode = null;

            NopDAO daoN = new NopDAO();
            List<NopVo> nopList = daoN.GetNopList(ViewBag.FromDate, searchToDate, wcCode, page, out totalCount);
            daoN.Dispose();

            ViewBag.WcCode = wcCode;

            ViewBag.Page = new PagingInfo
            {
                TotalItems = totalCount,
                CurrentPage = page,
                ItemsPerPage = pageSize
            };

            Session["SelectedAM"] = "WPlace";  
            return View(nopList); 
        } 

        #region 미사용
        public ActionResult ProdT(string prdCode) //시간당 생산량 조회 - 구현 불가능으로 폐기(실적 테이블 없음)
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

        public ActionResult Schedule() //월별 스케쥴 조회 - 답없어서 폐기
        {
            Session["SelectedAM"] = "Schedule";

            return View();
        }
        #endregion
    }
}