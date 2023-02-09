using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;
using System.Linq;

namespace Team2_Project
{
    public partial class frmDashBoard : Team2_Project.BaseForms.frmStart
    {
        DashboardService srv = new DashboardService();
        List<DashboardDTO> mappingList = new List<DashboardDTO>();
        string empID;

        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            empID = ((frmMain)this.MdiParent).LoginEmp.User_ID;
            LoadData();
        }

        private void LoadData()
        {
            lblMsg1.Visible = lblMsg2.Visible = false;
            mappingList = srv.GetData(empID);
            if (mappingList.Count > 0)
            {
                lblTitleUp.Text = mappingList.Where(x => x.Loc.Equals("U")).Select((x) => x.Title_Ko).ToList().FirstOrDefault() ?? string.Empty;
                lblTitleDown.Text = mappingList.Where(x => x.Loc.Equals("L")).Select((x) => x.Title_Ko).ToList().FirstOrDefault() ?? string.Empty;

                if (lblTitleUp.Text == "작업장현황") WorkCenterData(dgvDataA);
                else if (lblTitleUp.Text == "생산진행현황") ProductionData(dgvDataA);
                else if (lblTitleUp.Text == "생산실적현황") ProductionHistoryData(dgvDataA);
                else if (lblTitleUp.Text == "비가동내역") NopData(dgvDataA);
                else lblTitleDown.Text = "미선택";

                if (lblTitleDown.Text == "작업장현황") WorkCenterData(dgvDataB);
                else if (lblTitleDown.Text == "생산진행현황") ProductionData(dgvDataB);
                else if (lblTitleDown.Text == "생산실적현황") ProductionHistoryData(dgvDataB);
                else if (lblTitleDown.Text == "비가동내역") NopData(dgvDataB);
                else lblTitleDown.Text = "미선택";
            }
            else
                lblTitleUp.Text = lblTitleDown.Text = "미선택";

            dgvDataA.MultiSelect = false;
            dgvDataB.MultiSelect = false;
            dgvDataA.ReadOnly = true;
            dgvDataB.ReadOnly = true;

            //dgvDataA.ClearSelection();
            //dgvDataB.ClearSelection();

            #region 대시보드 종류
            /* 생산진행현황
             * 작업장현황
             * 생산실적
             * 비가동내역
             */
            #endregion
        }

        private void WorkCenterData(DataGridView dgv) //작업장현황
        {
            DataGridViewUtil.SetInitDataGridView(dgv);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장상태", "Wc_Status", 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장코드", "Wc_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장명", "Wc_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장그룹명", "Wc_Group_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "공정코드", "Process_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "공정명", "Process_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "팔렛생성여부", "Pallet_YN", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "사용여부", "Use_YN", 150);

            List<WorkCenterDTO> wcList = new List<WorkCenterDTO>();
            wcList = srv.GetWorkCenterInfo();
            if (wcList.Count > 0)
            {
                dgv.DataSource = wcList;
            }
            else
            {
                NoData(dgv);
            }
        }

        private void ProductionData(DataGridView dgv) //생산진행현황 (작업지시별)
        {
            DataGridViewUtil.SetInitDataGridView(dgv);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업지시상태", "Wo_Status", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업지시번호", "WorkOrderNo", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업지시일자", "Plan_Date", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업지시수량", "Plan_Qty_Box", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "계획수량단위", "Plan_Unit", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "품목코드", "Item_Code", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "품목명", "Item_Name", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장", "Wc_Name", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "생산일자", "Prd_Date", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "생산시작", "Prd_StartTime", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "생산종료", "Prd_EndTime", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "투입수량", "In_Qty_Main", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "산출수량", "Out_Qty_Main", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "생산수량", "Prd_Qty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "불량수량", "Def_Qty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장코드", "Wc_Code", 120);
            List<TimeProductionHistoryDTO> ProductionHistoryList = new List<TimeProductionHistoryDTO>();
            ProductionHistoryList = srv.Production();
            if (ProductionHistoryList.Count > 0)
            {
                var newList = ProductionHistoryList.OrderByDescending(x => x.Plan_Date).ToList();
                dgv.DataSource = newList;
            }
            else
            {
                NoData(dgv);
            }
        }

        private void ProductionHistoryData(DataGridView dgv) //생산실적현황 (시간대별)
        {
            //WorkOrderNo, Start_Hour, In_Qty_Main, Out_Qty_Main, Prd_Qty, Prd_Unit
            DataGridViewUtil.SetInitDataGridView(dgv);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업지시번호", "WorkOrderNo", 150, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "시작시간대", "Start_Hour", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "투입수량", "In_Qty_Main", 150, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "산출수량", "Out_Qty_Main", 150, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "생산수량", "Prd_Qty", 150, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "생산수량단위", "Prd_Unit", 150);
            List<TimeProductionHistoryDTO> ProductionHistoryList = new List<TimeProductionHistoryDTO>();
            ProductionHistoryList = srv.GetProductionHistory();
            if (ProductionHistoryList.Count > 0)
            {
                dgv.DataSource = ProductionHistoryList;
            }
            else
            {
                NoData(dgv);
            }            
        }
   
        private void NopData(DataGridView dgv) //비가동내역
        {
            DataGridViewUtil.SetInitDataGridView(dgv);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "순번", "Nop_Seq", 60, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동발생일자", "Nop_Date", 160);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동발생일시", "Nop_HappenTime", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동해제일시", "Nop_CancelTime", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동시간(분)", "Nop_Time", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장코드", "Wc_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장명", "Wc_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장그룹", "Wc_Group", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "공정명", "Process_Name", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동대분류코드", "Nop_Ma_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동상세분류코드", "Nop_Mi_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동상세분류명", "Nop_Mi_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동대분류코드", "Nop_Ma_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동대분류명", "Nop_Ma_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동유형", "Nop_type", 150);

            List<NopHistoryDTO> NopHistoryList = new List<NopHistoryDTO>();
            NopHistoryList = srv.GetNopHistory();
            if(NopHistoryList.Count > 0)
            {
                dgv.DataSource = NopHistoryList;
            }
            else
            {                
                NoData(dgv);
                //dgv.Rows.Add("데이터가 없습니다.");
            }
        }

        private void NoData(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Visible = false;

            if(dgv == dgvDataA)
            {
                lblMsg1.Visible = true;
                lblMsg1.Text = "최신 데이터가 없습니다.";
            }
            else if (dgv == dgvDataB)
            {
                lblMsg2.Visible = true;
                lblMsg2.Text = "최신 데이터가 없습니다.";
            }
        }
    }
}
//= Color.FromArgb(211, 226, 223);