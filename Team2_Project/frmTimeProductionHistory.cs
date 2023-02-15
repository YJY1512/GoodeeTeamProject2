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
using System.Windows.Forms.DataVisualization.Charting;

namespace Team2_Project
{
    public partial class frmTimeProductionHistory : Team2_Project.frmList
    {
        AnalysisService srv = new AnalysisService();
        List<TimeProductionHistoryDTO> TPHistoryList = new List<TimeProductionHistoryDTO>();
        List<WorkCenterDTO> wcList;
        List<ProcessMasterDTO> prcList;

        public frmTimeProductionHistory()
        {
            InitializeComponent();
        }

        private void frmTimeProductionHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            List<CodeDTO> SpecList = srv.GetWoStatus();
            CommonCodeUtil.ComboBinding(cboWoStatus, SpecList, "WO_STATUS", blankText: "전체");
            cboWoStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시상태", "Wo_Status", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시번호", "WorkOrderNo", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시일자", "Plan_Date", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시수량", "Plan_Qty_Box", 100, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "계획수량단위", "Plan_Unit", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목코드", "Item_Code", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목명", "Item_Name", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업장", "Wc_Name", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산일자", "Prd_Date", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산시작", "Prd_StartTime", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산종료", "Prd_EndTime", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "투입수량", "In_Qty_Main", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "산출수량", "Out_Qty_Main", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산수량", "Prd_Qty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "불량수량", "Def_Qty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업장코드", "Wc_Code", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "공정코드", "Process_Code", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "공정명", "Process_Name", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시상태코드", "Wo_Status_code", visible: false);
            this.dgvData.Columns["WorkOrderNo"].Frozen = true;
            dgvData.MultiSelect = false;

            string[] dotCell = new string[] { "Plan_Qty_Box", "In_Qty_Main", "Out_Qty_Main", "Prd_Qty", "Def_Qty" };
            foreach (string item in dotCell) dgvData.Columns[item].DefaultCellStyle.Format = "N0";

            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("나눔고딕", 11);
            dgvData.DefaultCellStyle.Font = new Font("나눔고딕", 11);

            ResetDtp();
            OnSearch();
        }

        private void AdvancedListBind(List<TimeProductionHistoryDTO> datasource, DataGridView dgv)
        {
            BindingSource bs = new BindingSource(new AdvancedList<TimeProductionHistoryDTO>(datasource), null);
            dgv.DataSource = null;
            dgv.DataSource = bs;
        }

        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            string wcCode = ucWcCode._Code;

            List<TimeProductionHistoryDTO> list = null;
            TPHistoryList = srv.GetWorkOrder(dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.AddDays(1).ToString("yyyy-MM-dd")); ////////// SP불량부분 수정하기
            if (TPHistoryList != null && TPHistoryList.Count > 0)
            {
                string processSC = ucProcessCode._Code ?? "";
                string workSC = ucWcCode._Code ?? "";
                string woStatus = (cboWoStatus.Text == "전체") ? "" : cboWoStatus.Text;
                if (TPHistoryList.Where(t => t.Process_Code == (string.IsNullOrWhiteSpace(processSC) ? t.Process_Code : processSC)
                                        && t.Wc_Code == (string.IsNullOrWhiteSpace(workSC) ? t.Wc_Code : workSC)
                                         && t.Wo_Status == (string.IsNullOrWhiteSpace(woStatus) ? t.Wo_Status : woStatus)).ToList() == null)
                    AdvancedListBind(TPHistoryList, dgvData);
                else
                {
                    list = TPHistoryList.Where(t => t.Process_Code == (string.IsNullOrWhiteSpace(processSC) ? t.Process_Code : processSC)
                                        && t.Wc_Code == (string.IsNullOrWhiteSpace(workSC) ? t.Wc_Code : workSC)
                                         && t.Wo_Status == (string.IsNullOrWhiteSpace(woStatus) ? t.Wo_Status : woStatus)).ToList();
                    AdvancedListBind(list, dgvData);
                }

                if (dgvData.Rows.Count > 0)
                {
                    if (dgvData.CurrentRow != null)
                        dgvData_CellClick(dgvData.CurrentRow.Index, new DataGridViewCellEventArgs(0, 0));
                }
                else
                    chtData.Series.Clear();
            }
            else
                dgvData.DataSource = null;
        }

        public void OnReLoad()  //새로고침
        {
            ResetTop();//검색리셋
            OnSearch();//로드
        }
        #endregion

        private void ResetTop() //검색 리셋
        {
            ResetDtp();
            cboWoStatus.SelectedIndex = 0;
            ucProcessCode._Code = ucProcessCode._Name = "";
            ucWcCode._Code = ucWcCode._Name = "";
            chkDefQty.Checked = false;
        }

        private void ResetDtp() //날짜리셋
        {
            dtpFrom.Value = DateTime.Now.AddDays(-7);
            dtpTo.Value = DateTime.Now;
        }

        private CommonPop<WorkCenterDTO> GetWcPopInfo()
        {
            if (wcList == null)
            {
                WorkCenterService srv = new WorkCenterService();
                wcList = srv.GetWcCodeName();
            }

            CommonPop<WorkCenterDTO> wcPopInfo = new CommonPop<WorkCenterDTO>();
            wcPopInfo.DgvDatasource = wcList;
            wcPopInfo.PopName = "작업장 검색";

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장코드", "Wc_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장명", "Wc_Name", 200));

            wcPopInfo.DgvCols = colList;

            return wcPopInfo;
        }

        private CommonPop<ProcessMasterDTO> GetProcessPopInfo()
        {
            if (prcList == null)
            {
                ProcessMasterService srv = new ProcessMasterService();
                prcList = srv.GetPrcCodeName();
            }

            CommonPop<ProcessMasterDTO> prcPopInfo = new CommonPop<ProcessMasterDTO>();
            prcPopInfo.DgvDatasource = prcList;
            prcPopInfo.PopName = "공정 검색";

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("공정코드", "Process_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("공정명", "Process_Name", 200));

            prcPopInfo.DgvCols = colList;

            return prcPopInfo;
        }

        private void ucProcessCode_BtnClick(object sender, EventArgs e)
        {
            ucProcessCode.OpenPop(GetProcessPopInfo());
        }

        private void ucWcCode_BtnClick(object sender, EventArgs e)
        {
            ucWcCode.OpenPop(GetWcPopInfo());
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;           
            else if(dgvData.Rows.Count > 0)
                ChartData();
        }

        public void ChartData()
        {            
            string curInfo = dgvData["WorkOrderNo", dgvData.CurrentRow.Index].Value.ToString();
            TPHistoryList = srv.GetTimeProductionHistory(curInfo); //SP 테스트용 아닌걸로 수정

            chtData.Series.Clear();
            chtData.Series.Add("생산량");
            chtData.Series["생산량"].Points.Clear();
            chtData.Series["생산량"].ChartType = SeriesChartType.StackedColumn;
            chtData.Series["생산량"].Color = Color.FromArgb(211, 226, 223);
            chtData.Series["생산량"].BorderColor = Color.Gray;
            chtData.Series["생산량"].Points.DataBind(TPHistoryList, "Start_Hour", "Prd_Qty", "Label=Prd_Qty"); // X축: 시간, Y축:  생산량    //Prd_Qty //Def_Qty

            if (!chkDefQty.Checked)
            {
                chtData.Series.Add("불량");
                chtData.Series["불량"].Points.Clear();
                chtData.Series["불량"].ChartType = SeriesChartType.StackedColumn;
                chtData.Series["불량"].Color = Color.FromArgb(255, 217, 217);
                chtData.Series["불량"].BorderColor = Color.Gray;
                chtData.Series["불량"].Points.DataBind(TPHistoryList, "Start_Hour", "Def_Qty", "Label=Def_Qty"); // X축: Time, Y축: Score
            }            
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvData["Wo_Status_code", e.RowIndex].Value == null) return;

            string status = dgvData["Wo_Status_code", e.RowIndex].Value.ToString();
            switch (status)
            {
                case "W01": //생산대기
                    dgvData["Wo_Status", e.RowIndex].Style.BackColor = Color.Orange;
                    break;
                case "W02": //생산중
                    dgvData["Wo_Status", e.RowIndex].Style.BackColor = Color.ForestGreen;
                    break;
                case "W03": //생산중지
                    dgvData["Wo_Status", e.RowIndex].Style.BackColor = Color.Gold;
                    break;
                case "W04": //현장마감
                    dgvData["Wo_Status", e.RowIndex].Style.BackColor = Color.LightSkyBlue;
                    break;
                case "W05": //작업지시마감
                    dgvData["Wo_Status", e.RowIndex].Style.BackColor = Color.DarkBlue;
                    break;
                default: break;
            }
        }
    }    
}
