using System;
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

            ViewData["Name"] = sb1.ToString().TrimEnd(',');
            ViewData["OrderSum"] = "[" + string.Join(",", OrderSumList) + "]";
            ViewData["CustomerSum"] = "[" + string.Join(",", CustomerSumList) + "]";

            return View(list);
        }

        public ActionResult ProdO() //생산지시 실적 조회
        {
            List<ItemVO> list = new List<ItemVO>();
            //list.Add(new ItemVO { Name = "제품1", Code = "Prod1", Ratio = 100, Order_p = 10, Customer_p = 2, Order_c = 20, Customer_c = 4 });

            return View(list);
        }

        public ActionResult ProdT() //시간당 생산량 조회
        {
            List<ItemVO> list = new List<ItemVO>();
            //list.Add(new ItemVO { Name = "제품1", Code = "Prod1", Ratio = 100, Order_p = 10, Customer_p = 2, Order_c = 20, Customer_c = 4 });

            return View(list);
        }

        public ActionResult Defect() //불량 이력 조회
        {
            List<ItemVO> list = new List<ItemVO>();
            //list.Add(new ItemVO { Name = "제품1", Code = "Prod1", Ratio = 100, Order_p = 10, Customer_p = 2, Order_c = 20, Customer_c = 4 });

            return View(list);
        }

        public ActionResult WPlace() //작업장 가동현황 조회
        {
            List<ItemVO> list = new List<ItemVO>();
            //list.Add(new ItemVO { Name = "제품1", Code = "Prod1", Ratio = 100, Order_p = 10, Customer_p = 2, Order_c = 20, Customer_c = 4 });

            return View(list);
        }

        public ActionResult Schedule() //월별 스케쥴 조회
        {
            List<ItemVO> list = new List<ItemVO>();
            //list.Add(new ItemVO { Name = "제품1", Code = "Prod1", Ratio = 100, Order_p = 10, Customer_p = 2, Order_c = 20, Customer_c = 4 });

            return View(list);
        }
    }
}