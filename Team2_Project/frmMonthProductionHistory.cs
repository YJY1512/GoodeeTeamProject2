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
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

namespace Team2_Project
{
    public partial class frmMonthProductionHistory : Team2_Project.frmList
    {
        AnalysisService srv = new AnalysisService();
        List<ItemDTO> itemList;
        List<MonthProductionHistoryDTO> MTHistoryList = new List<MonthProductionHistoryDTO>();

        public frmMonthProductionHistory()
        {
            InitializeComponent(); //월별 제품 생산비율 폼
        }

        private void frmMonthProductionHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dtpDate.Value = DateTime.Now;

            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목코드", "Item_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목명", "Item_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목유형", "Item_Type", 120);

            //예상컬럼//
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "목표수량", "TotPlanQty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "투입수량", "TotInQty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "산출수량", "TotOutQty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산수량", "TotPrdQty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "불량수량", "TotDefectQty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "달성률", "AttainmentRate", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "양품률", "QualityRate", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "가동률", "OperatingRate", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "불량률", "DefectRate", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "일평균생산수량", "AverageDailyProduction", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "월평균생산수량", "AverageMonthProduction", 150, DataGridViewContentAlignment.MiddleRight); //일일생산량?
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산일수", "TotalProductionDays", 120, DataGridViewContentAlignment.MiddleRight);

            string[] dotCell = new string[] { "TotPlanQty", "TotInQty", "TotOutQty", "TotPrdQty", "AverageMonthProduction", "TotalProductionDays", "TotDefectQty" };
            foreach (string item in dotCell) dgvData.Columns[item].DefaultCellStyle.Format = "N0";

            string[] dotPersentCell = new string[] { "AttainmentRate", "QualityRate", "OperatingRate", "DefectRate" };
            //foreach (string item in dotPersentCell)
            //{
            //    dgvData.Columns[item].DefaultCellStyle.Format = "N0";
            //    //dgvData.Columns[item].DefaultCellStyle.FormatProvider = CultureInfo.InvariantCulture;
            //}

                dgvData.ColumnHeadersDefaultCellStyle.Font = dgvData.DefaultCellStyle.Font = new Font("나눔고딕", 11);
            this.dgvData.Columns["Item_Name"].Frozen = true;
            dgvData.MultiSelect = false;
            dgvData.ClearSelection();

            OnSearch();

            rdoPrdQty.Checked = rdoChartTwo.Checked = true;
            //---- test ----
            //ChartData();
            //--------------
        }

        private void AdvancedListBind(List<MonthProductionHistoryDTO> datasource, DataGridView dgv)
        {
            BindingSource bs = new BindingSource(new AdvancedList<MonthProductionHistoryDTO>(datasource), null);
            dgv.DataSource = null;
            dgv.DataSource = bs;
        }

        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            string from = dtpDate.Value.ToString("yyyy-MM") + "-01";
            string to = dtpDate.Value.AddMonths(1).ToString("yyyy-MM") + "-01";
            //List<MonthProductionHistoryDTO> list = null;

            MTHistoryList = srv.GetMonthProductionHistory(from, to);
            if (MTHistoryList != null && MTHistoryList.Count > 0)
            {
                string ItemSC = ucItemSearch._Code ?? "";
                if (MTHistoryList.Where(t => t.Item_Code == (string.IsNullOrWhiteSpace(ItemSC) ? t.Item_Code : ItemSC)).ToList() == null) //조회조건없을 때
                    AdvancedListBind(MTHistoryList, dgvData);
                else
                {
                    MTHistoryList = MTHistoryList.Where(t => t.Item_Code == (string.IsNullOrWhiteSpace(ItemSC) ? t.Item_Code : ItemSC)).ToList(); //조회조건있을 때
                    AdvancedListBind(MTHistoryList, dgvData);
                }

                if (dgvData.Rows.Count > 0) //데이터가 있을 때
                {
                    ChartData();
                }
            }
            else
            {
                dgvData.DataSource = null;
                chtDataPie.Series.Clear();
                chtDataLine.Series.Clear();
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
            dtpDate.Value = DateTime.Now;
            ucItemSearch._Code = ucItemSearch._Name = "";
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1. 조회조건으로 검색하면  (DB에서 List<생산현황>가져와서)   dgv가 뜸 
            //2. 제품 dgv를 선택하면 제품코드 DB가져가서 (DB에서 List<월별생산비율>가져와서)    chart에 반영
            //if (e.RowIndex < 0) return;
            //else if (dgvData.Rows.Count > 0)
            //{
            //    ChartData();
            //}
        }

        public void ChartData() //(테스트중)반복부분 메서드만들어서 수정해야함
        {


            if (rdoPrdQty.Checked || rdoPlanQty.Checked || rdoInQty.Checked || rdoOutQty.Checked || rdoLossQty.Checked)
            {
                string chartTitle = "";
                if (MTHistoryList != null && MTHistoryList.Count > 0)
                {
                    if (rdoPrdQty.Checked) chartTitle = "월별 제품 생산비율";
                    else if (rdoPlanQty.Checked) chartTitle = "월별 제품 목표량";
                    else if (rdoInQty.Checked) chartTitle = "월별 제품 투입량";
                    else if (rdoOutQty.Checked) chartTitle = "월별 제품 산출량";
                    else if (rdoLossQty.Checked) chartTitle = "월별 제품 불량수량";

                    int num = 0;
                    int colors = 5;
                    chtDataPie.Series.Clear();
                    chtDataLine.Series.Clear();

                    chtDataPie.Series.Add(chartTitle);
                    chtDataPie.Series[chartTitle].Points.Clear();
                    chtDataPie.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
                    chtDataPie.Series[chartTitle].IsValueShownAsLabel = true;

                    if (rdoChartTwo.Checked)
                    {
                        chtDataLine.Series.Add(chartTitle);
                        chtDataLine.Series[chartTitle].Points.Clear();
                        chtDataLine.Series[chartTitle].ChartType = SeriesChartType.StackedColumn;
                        chtDataLine.Series[chartTitle].IsValueShownAsLabel = true;
                    }

                    foreach (var item in MTHistoryList)
                    {
                        string itemName = item.Item_Name;
                        int TotQty = 0;

                        if (chartTitle.Equals("월별 제품 생산비율")) TotQty = item.TotPrdQty;
                        else if (chartTitle.Equals("월별 제품 목표량")) TotQty = item.TotPlanQty;
                        else if (chartTitle.Equals("월별 제품 투입량")) TotQty = item.TotInQty;
                        else if (chartTitle.Equals("월별 제품 산출량")) TotQty = item.TotOutQty;
                        else if (chartTitle.Equals("월별 제품 불량수량")) TotQty = item.TotDefectQty;

                        chtDataPie.Series[chartTitle].Points.AddXY(itemName, TotQty);
                        chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                        chtDataPie.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
                        chtDataPie.Series[chartTitle].BorderColor = Color.Gray;
                        //chtDataPie.Series[chartTitle].BorderWidth 
                        //chtDataPie.Series[chartTitle].BoardDashStyle = 

                        //chtDataPie.Series[chartTitle].Points[num].LabelFormat = "N2";

                        if (rdoChartTwo.Checked)
                        {
                            chtDataLine.Series[chartTitle].Points.AddXY(itemName, TotQty);
                            chtDataLine.Series[chartTitle].Points[num].LegendText = itemName;
                            chtDataLine.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
                            chtDataLine.Series[chartTitle].BorderColor = Color.Gray;
                            //chtDataLine.Series[chartTitle].Points[num].LabelFormat = "#,###";
                        }
                        num++;
                        colors += 7;
                    }
                }
            }            
        }

        private CommonPop<ItemDTO> GetItemPopInfo()
        {
            if (itemList == null)
            {
                ItemService srv = new ItemService();
                itemList = srv.GetItemCodeName();
            }

            CommonPop<ItemDTO> itemPopInfo = new CommonPop<ItemDTO>();
            itemPopInfo.DgvDatasource = itemList;
            itemPopInfo.PopName = "품목 검색";

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목코드", "Item_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목명", "Item_Name", 200));

            itemPopInfo.DgvCols = colList;

            return itemPopInfo;
        }

        private void ucItemSearch_BtnClick(object sender, EventArgs e)
        {
            ucItemSearch.OpenPop(GetItemPopInfo());
        }

        private void rdoChecked_CheckedChanged(object sender, EventArgs e)
        {
            if(dgvData.Rows.Count > 0 && dgvData.Columns.Count > 0)
            {
                foreach (DataGridViewColumn col in dgvData.Columns)
                {
                    col.DefaultCellStyle.BackColor = Color.White;
                }
                dgvData.Columns[/*"Item_Name"*/ "Item_Code"].DefaultCellStyle.BackColor = Color.FromArgb(211, 226, 223);


                string[] backColorCell = null;
                if (rdoPrdQty.Checked) //생산수량
                {
                    backColorCell = new string[] { "TotInQty", "TotOutQty", "TotPrdQty", "QualityRate" }; //투입수량, 산출수량, 생산수량, 양품률
                }
                else if (rdoPlanQty.Checked) //목표량
                {
                    backColorCell = new string[] { "TotPlanQty", "TotPrdQty", "AttainmentRate", "QualityRate" }; //목표량, 총생산량, 달성율, 양품률
                }
                else if (rdoInQty.Checked) //투입량
                {
                    backColorCell = new string[] { "TotInQty", "TotPrdQty", "AttainmentRate", "QualityRate", "TotDefectQty", "DefectRate" }; //투입수량, 산출수량, 달성율, 양품률, 불량수량, 불량비율
                }
                else if (rdoOutQty.Checked) //산출량
                {
                    backColorCell = new string[] { "TotPlanQty", "TotOutQty", "AttainmentRate" }; //목표량, 산출수량, 달성율
                }
                else if (rdoLossQty.Checked) //Loss수량
                {
                    backColorCell = new string[] { "TotInQty", "TotOutQty", "TotDefectQty", "DefectRate" }; //투입수량, 산출수량, 불량수량, 불량비율
                }

                foreach (string item in backColorCell) 
                    dgvData.Columns[item].DefaultCellStyle.BackColor = Color.FromArgb(211, 226, 223);


                if (dgvData.Rows.Count > 0) ChartData();/* dgvData_CellClick(dgvData.CurrentRow.Index, new DataGridViewCellEventArgs(0, 0));*/
                else chtDataPie.Series.Clear();

                dgvData.ClearSelection();
            }                
        }

        private void rdoChartTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChartOne.Checked)
            {
                chtDataLine.Visible = false;
                
            }

            else if (rdoChartTwo.Checked)
            {
                splitContainerChart.Visible = true;
                chtDataLine.Visible = true;
            }
            ChartData();
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dgvData.Columns[e.ColumnIndex];

            if (column.HeaderText == "달성률") column.HeaderCell.ToolTipText = "(생산수량 / 목표수량) *100";
            else if (column.HeaderText == "양품률") column.HeaderCell.ToolTipText = "(산출수량 / 투입수량) *100";
            else if (column.HeaderText == "가동률") column.HeaderCell.ToolTipText = "(투입수량 / 목표수량) *100";
            else if (column.HeaderText == "불량률") column.HeaderCell.ToolTipText = "(불량수량 / 생산수량 ) *100";

        }
    }
}

//"목표량", "TotPlanQty", 150, D
// "INPUT(투입량)", "TotInQty", 1
// "OUTPUT(산출량)", "TotOutQty",
// "총생산량", "TotPrdQty", 150, 
// "달성율", "", 150);
//"가동율", "", 150);
//"일일생산량", "", 150);
//"생산일수", "", 150);
//"LOSS수량", "TotLoss", 150, Da
// "LOSS비율", "", 150);
/*
 (분석소재)
- 월별 제품 생산 비율
- 월별 불량 사유 비율
*/