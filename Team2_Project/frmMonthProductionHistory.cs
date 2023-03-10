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
        CheckBox headerChk = new CheckBox();

        public frmMonthProductionHistory()
        {
            InitializeComponent(); //월별 제품 생산비율 화면
        }

        private void frmMonthProductionHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dtpDate.Value = DateTime.Now;
            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Name = "chk";
            chk.Width = 30;
            chk.HeaderText = "";
            dgvData.Columns.Add(chk);

            Point headerCell = dgvData.GetCellDisplayRectangle(0, -1, true).Location; //컬럼헤더부분에 사각형의 위치를 가져옴 (-1)
            headerChk.Location = new Point(headerCell.X + 8, headerCell.Y + 12);
            headerChk.Size = new Size(18, 18);
            headerChk.BackColor = Color.Transparent;
            headerChk.Click += HeaderChk_Click;
            dgvData.Controls.Add(headerChk);

            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목코드", "Item_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목명", "Item_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목유형", "Item_Type", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "목표수량", "TotPlanQty", 110, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "투입수량", "TotInQty", 110, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "산출수량", "TotOutQty", 110, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산수량", "TotPrdQty", 110, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "불량수량", "TotDefectQty", 110, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "달성률", "AttainmentRate", 110, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "양품률", "QualityRate", 110, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "가동률", "OperatingRate", 110, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "불량률", "DefectRate", 110, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "일평균생산수량", "AverageDailyProduction", 130, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "월평균생산수량", "AverageMonthProduction", 150, DataGridViewContentAlignment.MiddleRight); //일일생산량?
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산일수", "TotalProductionDays", 110, DataGridViewContentAlignment.MiddleRight);
            string[] dotCell = new string[] { "TotPlanQty", "TotInQty", "TotOutQty", "TotPrdQty", "AverageMonthProduction", "TotalProductionDays", "TotDefectQty" };
            foreach (string item in dotCell) dgvData.Columns[item].DefaultCellStyle.Format = "N0";

            dgvData.ColumnHeadersDefaultCellStyle.Font = dgvData.DefaultCellStyle.Font = new Font("나눔고딕", 11);
            this.dgvData.Columns["Item_Name"].Frozen = true;
            dgvData.MultiSelect = false;
            dgvData.ClearSelection();
            OnSearch();
            rdoPrdQty.Checked = rdoChartTwo.Checked = true;
        }

        private void HeaderChk_Click(object sender, EventArgs e)
        {
            dgvData.EndEdit();

            foreach (DataGridViewRow dr in dgvData.Rows)
            {
                dr.Cells["chk"].Value = headerChk.Checked;
            }
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

            MTHistoryList = srv.GetMonthProductionHistory(from, to);
            if (MTHistoryList != null && MTHistoryList.Count > 0)
            {
                string ItemSC = ucItemSearch._Code ?? "";
                if (MTHistoryList.Where(t => t.Item_Code == (string.IsNullOrWhiteSpace(ItemSC) ? t.Item_Code : ItemSC)).ToList() == null) //조회조건 없을 때
                    AdvancedListBind(MTHistoryList, dgvData);
                else
                {
                    MTHistoryList = MTHistoryList.Where(t => t.Item_Code == (string.IsNullOrWhiteSpace(ItemSC) ? t.Item_Code : ItemSC)).ToList(); //조회조건 있을 때
                    AdvancedListBind(MTHistoryList, dgvData);
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
            ResetTop(); //검색리셋
            OnSearch(); //로드
            chtDataPie.Series.Clear();
            chtDataLine.Series.Clear();
            headerChk.Checked = false;
        }
        #endregion

        private void ResetTop() //검색 리셋
        {
            dtpDate.Value = DateTime.Now;
            ucItemSearch._Code = ucItemSearch._Name = "";
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            //else if (dgvData.Rows.Count > 0)
            //{
            //    ChartData();
            //}

            //dgvData의 chk컬럼에 체크된게 없으면 headerChk.Checked는 false
            bool isAnyRowChecked = false;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells["chk"] as DataGridViewCheckBoxCell;
                if (!Convert.ToBoolean(chk.Value))
                {
                    isAnyRowChecked = false;
                    break;
                }
            }
            headerChk.Checked = isAnyRowChecked;
        }

        public void ChartData()
        {
            List<MonthProductionHistoryDTO> list = new List<MonthProductionHistoryDTO>();
            List<string> txt = new List<string>();
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                    txt.Add(row.Cells["Item_Code"].Value.ToString());
            }
            list = MTHistoryList.Where(dto => txt.Contains(dto.Item_Code)).ToList();
            if (rdoPrdQty.Checked || rdoPlanQty.Checked || rdoInQty.Checked || rdoOutQty.Checked || rdoLossQty.Checked)
            {
                string chartTitle = "";
                if (list != null && list.Count > 0)
                {
                    if (rdoPrdQty.Checked) chartTitle = "월별 제품 생산비율";
                    else if (rdoPlanQty.Checked) chartTitle = "월별 제품 목표량";
                    else if (rdoInQty.Checked) chartTitle = "월별 제품 투입량";
                    else if (rdoOutQty.Checked) chartTitle = "월별 제품 산출량";
                    else if (rdoLossQty.Checked) chartTitle = "월별 제품 불량수량";

                    chtDataPie.Series.Clear();
                    chtDataLine.Series.Clear();

                    chtDataPie.Series.Add(chartTitle);
                    chtDataPie.Series[chartTitle].Points.Clear();
                    chtDataPie.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
                    chtDataPie.Series[chartTitle].IsValueShownAsLabel = true;

                    chtDataLine.Series.Add(chartTitle);
                    chtDataLine.Series[chartTitle].Points.Clear();
                    chtDataLine.Series[chartTitle].IsValueShownAsLabel = true;
                    chtDataLine.Series[chartTitle].ChartType = SeriesChartType.StackedColumn;

                    int num = 0;
                    Random rd = new Random();
                    foreach (var item in list)
                    {
                        int rbColor = rd.Next(1, 255);
                        int gbColor = rd.Next(1, 255);
                        int bColor = rd.Next(1, 255);

                        int TotQty = 0;
                        string itemName = item.Item_Name;
                        if (chartTitle.Equals("월별 제품 생산비율")) TotQty = item.TotPrdQty;
                        else if (chartTitle.Equals("월별 제품 목표량")) TotQty = item.TotPlanQty;
                        else if (chartTitle.Equals("월별 제품 투입량")) TotQty = item.TotInQty;
                        else if (chartTitle.Equals("월별 제품 산출량")) TotQty = item.TotOutQty;
                        else if (chartTitle.Equals("월별 제품 불량수량")) TotQty = item.TotDefectQty;

                        chtDataPie.Series[chartTitle].Points.AddXY(itemName, TotQty);
                        chtDataPie.Series[chartTitle].BorderColor = Color.Gray;
                        chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                        chtDataPie.Series[chartTitle].Points[num].Color = Color.FromArgb(rbColor, gbColor, bColor);
                        //chtDataPie.Series[chartTitle].Points[num].LabelFormat = "N2";

                        chtDataLine.Series[chartTitle].Points.AddXY(itemName, TotQty);
                        chtDataLine.Series[chartTitle].BorderColor = Color.Gray;
                        chtDataLine.Series[chartTitle].Points[num].LegendText = itemName;
                        chtDataLine.Series[chartTitle].Points[num].Color = Color.FromArgb(rbColor, gbColor, bColor);
                        //chtDataLine.Series[chartTitle].Points[num].LabelFormat = "#,###";
                        num++;
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
            if (dgvData.Rows.Count > 0 && dgvData.Columns.Count > 0)
            {
                foreach (DataGridViewColumn col in dgvData.Columns)
                {
                    col.DefaultCellStyle.BackColor = Color.White;
                }
                dgvData.Columns[/*"Item_Name"*/ "Item_Code"].DefaultCellStyle.BackColor = Color.FromArgb(215, 215, 215);

                string[] backColorCell = null;
                if (rdoPrdQty.Checked) //생산수량 양품
                {
                    backColorCell = new string[] { "TotInQty", "TotOutQty", "TotPrdQty", "AttainmentRate"/*, "TotDefectQty"*/ }; //투입수량, 산출수량, 생산수량, 달성률, 불량수량
                }
                else if (rdoPlanQty.Checked) //목표량 
                {
                    backColorCell = new string[] { "TotPlanQty", "TotPrdQty", "AttainmentRate", "QualityRate" }; //목표량, 총생산량, 달성율, 양품률
                }
                else if (rdoInQty.Checked) //투입량
                {
                    backColorCell = new string[] { "TotInQty", "TotPrdQty", "OperatingRate" }; //투입수량, 산출수량, 가동률
                }
                else if (rdoOutQty.Checked) //산출량
                {
                    backColorCell = new string[] { "TotPlanQty", "TotOutQty", "AttainmentRate", "QualityRate" }; //목표량, 산출수량, 달성율, 양품률
                }
                else if (rdoLossQty.Checked) //Loss수량
                {
                    backColorCell = new string[] { "TotInQty", "TotOutQty", "TotDefectQty", "DefectRate" }; //투입수량, 산출수량, 불량수량, 불량비율
                }

                foreach (string item in backColorCell)
                    dgvData.Columns[item].DefaultCellStyle.BackColor = Color.FromArgb(215, 215, 215);

                ChartData();
                dgvData.ClearSelection();
            }
        }

        private void rdoChartTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChartOne.Checked)
            {
                splitContainerChart.Panel1Collapsed = true;
            }
            else if (rdoChartTwo.Checked)
            {
                splitContainerChart.Panel1Collapsed = false;
            }
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dgvData.Columns[e.ColumnIndex];
            if (column.HeaderText == "달성률") column.HeaderCell.ToolTipText = "(생산수량 / 목표수량) *100";
            else if (column.HeaderText == "양품률") column.HeaderCell.ToolTipText = "(산출수량 / 투입수량) *100";
            else if (column.HeaderText == "가동률") column.HeaderCell.ToolTipText = "(투입수량 / 목표수량) *100";
            else if (column.HeaderText == "불량률") column.HeaderCell.ToolTipText = "(불량수량 / 생산수량 ) *100";
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            List<string> txt = new List<string>();
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                    txt.Add(row.Cells["Item_Code"].Value.ToString());
            }

            if (txt.Count < 1)
            {
                MessageBox.Show("차트확인 할 항목을 선택하여 주십시오.");
                chtDataPie.Series.Clear();
                chtDataLine.Series.Clear();
                return;
            }
            else
            {
                ChartData();
                splitContainer1.SplitterDistance = splitContainer1.Height / 2;
                splitContainerChart.SplitterDistance = splitContainerChart.Width / 2;
            }
        }
    }
}

/*
 (분석소재)
- 월별 제품 생산 비율
- 월별 불량 사유 비율
*/