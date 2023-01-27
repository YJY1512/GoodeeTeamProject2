using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;


namespace Team2_Project
{
    public partial class frmPlan : Form
    {
        PlanService srv = new PlanService();
        List<ItemDTO> itemList;

        public frmPlan()
        {
            InitializeComponent();
        }

        private void frmPlan_Load(object sender, EventArgs e)
        {
            //생산요청 tab
            DataGridViewUtil.SetInitDataGridView(dgvReq);
            DataGridViewCheckBoxColumn cbk = new DataGridViewCheckBoxColumn();
            cbk.Width = 30;
            cbk.DefaultCellStyle.BackColor = Color.PeachPuff;
            dgvReq.Columns.Add(cbk);

            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "생산요청번호", "Prd_Req_No", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "의뢰일", "Req_Date", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "순번", "Req_Seq", 80);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "납기일자", "Delivery_Date", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "작업장코드", "Wc_Code", OrangebackColor:true); //입력값
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "작업장명", "Wc_Name", 150, OrangebackColor: true); //입력값
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "품목", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "계획수량", "In_Plan_Qty", 120, OrangebackColor: true); //계획 수량(입력값)
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "계획반영수량", "Plan_Qty", 120); //계획 수량 합계
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "요청수량/잔량", "Plan_Rest_Qty", 120); //요청수량(Req) - 계획반영수량(Plan_Rest)
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "Plan_YN", "Plan_YN", visible:false);

            CommonCodeUtil.UseYNComboBinding(cboReqStat);
            cboReqStat.SelectedIndex = 0;

            //생산요청 tab
            DataGridViewUtil.SetInitDataGridView(dgvWcPlan);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWcPlan, "작업장코드", "Wc_Code");
            DataGridViewUtil.AddGridTextBoxColumn(dgvWcPlan, "작업장명", "Wc_Name");
            DataGridViewUtil.AddGridTextBoxColumn(dgvWcPlan, "계획반영수량", "Plan_Qty"); //작업장별 합계
            DataGridViewUtil.AddGridTextBoxColumn(dgvWcPlan, "계획수량", "In_Plan_Qty"); //작업장별 합계

            //생산계획 tab
            DataGridViewUtil.SetInitDataGridView(dgvPlan);

            SetInit();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = srv.GetPlanReq(dtpReqFrom.Value.ToShortDateString(), dtpReqTo.Value.ToShortDateString());
            dgvReq.DataSource = dt;

            DgvWcPlanBinding(dt);
        }

        private void SetInit()
        {
            dtpReqFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpReqTo.Value = dtpReqFrom.Value.AddMonths(1).AddDays(-1);
            dtpDue.Format = DateTimePickerFormat.Custom;
            dtpDue.CustomFormat = " ";
        }

        private void DgvWcPlanBinding(DataTable dt)
        {
            var SortTable = (from row in dt.AsEnumerable()
                             group row by new
                             {
                                 Wc_Code = row.Field<string>("Wc_Code"),
                                 Wc_Name = row.Field<string>("Wc_Name")
                             } into g
                             select new PlanDTO
                             {
                                 Wc_Code = g.Key.Wc_Code,
                                 Wc_Name = g.Key.Wc_Name,
                                 Plan_Qty = g.Sum((c) => c.Field<int>("Plan_Qty"))
                             }).ToList();

            dgvWcPlan.DataSource = SortTable;
        }

        private void ucProd_BtnClick(object sender, EventArgs e)
        {
            if (itemList == null)
            {
                itemList = new List<ItemDTO>();
                ItemService srv = new ItemService();
                itemList = srv.GetItemCodeName();
            }
            
            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목코드", "Item_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목명", "Item_Name", 200));

            CommonPop<ItemDTO> popInfo = new CommonPop<ItemDTO>();
            popInfo.DgvDatasource = itemList;
            popInfo.DgvCols = colList;
            popInfo.PopName = "품목코드 검색";

            ucProd.OpenPop(popInfo);

        }
    }
}
