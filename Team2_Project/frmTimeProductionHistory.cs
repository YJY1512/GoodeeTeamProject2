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
            #region cboWoStatus항목
            //cboWoStatus.Items.Add("전체");
            //cboWoStatus.Items.Add("생산대기");
            //cboWoStatus.Items.Add("생산중");
            //cboWoStatus.Items.Add("생산중지");
            //cboWoStatus.Items.Add("현장마감");
            //cboWoStatus.Items.Add("작업지시마감"); //추후 DB에서 CODE 가져오기
            #endregion

            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시상태", "Wo_Status", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시번호", "WorkOrderNo", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시일자", "Plan_Date", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시수량", "Plan_Qty_Box", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "계획수량단위", "Plan_Unit", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목코드", "Item_Code", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목명", "Item_Name", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업장", "Wc_Name", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산일자", "Prd_Date", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산시작", "Prd_StartTime", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산종료", "Prd_EndTime", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "투입수량", "In_Qty_Main", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "산출수량", "Out_Qty_Main", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산수량", "Prd_Qty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "불량수량", "Def_Qty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업장코드", "Wc_Code", 120);
            dgvData.MultiSelect = false;

            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("나눔고딕", 11);
            dgvData.DefaultCellStyle.Font = new Font("나눔고딕", 11);

            //---- test용 ----
            cboWoStatus.SelectedIndex = cboTest.SelectedIndex = 0; 
            cboTest.DropDownStyle = ComboBoxStyle.DropDownList;
            //----------------
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
            TPHistoryList = srv.GetWorkOrder(dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd")); //////////SP불량부분 수정하기
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
            ucWcCode._Code = ucProcessCode._Name = "";
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
            //1. 조회조건으로 검색하면  (DB에서 List<작업지시테이블기반>가져와서)   dgv가 뜸 
            //2. 작업지시 dgv를 선택하면 작업지시번호 DB가져가서 (DB에서 List<시간대별실적조회>가져와서)    chart에 반영

            //string txt = dgvData["WorkOrderNo", e.RowIndex].Value.ToString();
            //MessageBox.Show($"차트불러올 작업지시번호 : {txt}", "TEST");

            if (e.RowIndex < 0) return;           
            else if(dgvData.Rows.Count > 0)
                ChartData();
        }

        public void ChartData()
        {
            //---test----
            //string curInfo = cboTest.Text;
            //------------

            string curInfo = dgvData["WorkOrderNo", dgvData.CurrentRow.Index].Value.ToString();
            TPHistoryList = srv.GetTimeProductionHistory(curInfo); //SP 테스트용 아닌걸로 수정

            chtData.Series.Clear();
            chtData.Series.Add("생산량");
            chtData.Series["생산량"].Points.Clear();
            chtData.Series["생산량"].ChartType = SeriesChartType.StackedColumn;
            chtData.Series["생산량"].Color = Color.FromArgb(211, 226, 223);
            chtData.Series["생산량"].Points.Clear();
            chtData.Series["생산량"].Points.DataBind(TPHistoryList, "Start_Hour", "Prd_Qty", "Label=Prd_Qty"); // X축: 시간, Y축:  생산량    //Prd_Qty //Def_Qty

            if (!chkDefQty.Checked)
            {
                chtData.Series.Add("불량");
                chtData.Series["불량"].Points.Clear();
                chtData.Series["불량"].ChartType = SeriesChartType.StackedColumn;
                chtData.Series["불량"].Color = Color.FromArgb(255, 217, 217);
                chtData.Series["불량"].Points.Clear();
                chtData.Series["불량"].Points.DataBind(TPHistoryList, "Start_Hour", "Def_Qty", "Label=Def_Qty"); // X축: Time, Y축: Score
            }
            
            #region test
            //(방법2)//////////////////

            //chtData.Series["Series1"].Points.AddXY(10, 100);
            //chtData.Series["Series1"].Points.AddXY(20, 200);
            //chtData.Series["Series1"].Points.AddXY(30, 300);
            //chtData.Series["Series1"].Points.AddXY(40, 400);

            //List<string> x = new List<string> { "철수", "영희", "길동", "재동", "민희" };
            //List<double> y = new List<double> { 80, 90, 85, 70, 95 };
            //chtData.Series[0].Points.DataBindXY(x, y);


            //(방법3)//////////////////
            //List<Student> students = new List<Student>();
            //for (int i = 8; i <= 24; i++)
            //{
            //    students.Add(new Student($"{i}시", i * 100));
            //}
            //chtData.Series[0].Points.DataBind(students, "Time", "Score", null); // X축: Time, Y축: Score
            //                                                                    // (참고) DataBindTable() 사용시. (X축: Time, Y축: 자동검색)
            //                                                                    //chtData.DataBindTable(students, "Time");
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChartData();
        }
    }    
}
