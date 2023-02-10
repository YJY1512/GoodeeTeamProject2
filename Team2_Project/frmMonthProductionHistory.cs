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
        List<ItemDTO> itemList = new List<ItemDTO>();
        List<MonthProductionHistoryDTO> MTHistoryList = new List<MonthProductionHistoryDTO>();

        public frmMonthProductionHistory()
        {
            InitializeComponent();
        }

        private void frmMonthProductionHistory_Load(object sender, EventArgs e)
        {
            //월별 제품 생산비율 폼
            LoadData();
            dtpDate.Value = new DateTime(2023, 02, 01);
            dgvData.ClearSelection();
        }

        public void LoadData()
        {
            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목코드", "Item_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목명", "Item_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목유형", "Item_Type", 150);

            //예상컬럼//
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "목표량", "TotPlanQty", 150, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "투입량(INPUT)", "TotInQty", 150, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "산출량(OUTPUT)", "TotOutQty", 150, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "총생산량", "TotPrdQty", 150, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "달성율", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "가동율", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "일일생산량", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산일수", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "LOSS수량", "TotLoss", 150, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "LOSS비율", "", 150);
            this.dgvData.Columns["Item_Name"].Frozen = true;
            dgvData.MultiSelect = false;

            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("나눔고딕", 11);
            dgvData.DefaultCellStyle.Font = new Font("나눔고딕", 11);

            //string[] backColorCell = new string[] { "TotInQty", "TotPrdQty", "TotLoss" };
            //foreach (string item in backColorCell) dgvData.Columns[item].DefaultCellStyle.BackColor = Color.FromArgb(211, 226, 223);

            string[] dotCell = new string[] { "TotPlanQty", "TotInQty", "TotOutQty", "TotPrdQty", "TotLoss" };
            foreach (string item in dotCell) dgvData.Columns[item].DefaultCellStyle.Format = "N0";
            rdoPrdQty.Checked = true;
            rdoChartTwo.Checked = true;

            ResetTop();
            OnSearch();

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
            string to = dtpDate.Value.AddMonths(1).ToString("yyyyMM") + "-01";

            MTHistoryList = srv.GetMonthProductionHistory(from, to);
            if (MTHistoryList != null && MTHistoryList.Count > 0)
            {
                //if ()
                //{

                AdvancedListBind(MTHistoryList, dgvData);
                //}
                //else
                //{

                //    AdvancedListBind(MTHistoryList, dgvData);
                //}

                if (dgvData.Rows.Count > 0)
                {
                    if (dgvData.CurrentRow != null)
                        dgvData_CellClick(dgvData.CurrentRow.Index, new DataGridViewCellEventArgs(0, 0));
                }
                else
                    chtDataPie.Series.Clear();
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
            dtpDate.Value = DateTime.Now;
            ucItemSearch._Code = ucItemSearch._Name = "";
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1. 조회조건으로 검색하면  (DB에서 List<생산현황>가져와서)   dgv가 뜸 
            //2. 제품 dgv를 선택하면 제품코드 DB가져가서 (DB에서 List<월별생산비율>가져와서)    chart에 반영



            if (e.RowIndex < 0) return;
            else if (dgvData.Rows.Count > 0)
            {
                if (rdoChartOne.Checked)
                    ChartDataOne();
                else if (rdoChartTwo.Checked)
                    ChartDataTwo();

            }
        }


        public void ChartDataOne() //(테스트중)반복부분 메서드만들어서 수정해야함
        {
            string chartTitle = "";
            int num = 0;
            int colors = 5;

            chtDataPie.Series.Clear();

            if (rdoPrdQty.Checked) //생산수량
            {
                chartTitle = "월별 제품 생산비율";
                #region 파이차트
                string curInfo = dgvData["Item_Code", dgvData.CurrentRow.Index].Value.ToString();
                //TPHistoryList = srv.Get(curInfo);

                //chtData.Titles.Add("월별 제품 생산비율");
                chtDataPie.Series.Add(chartTitle);
                chtDataPie.Series[chartTitle].Points.Clear();
                chtDataPie.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
                chtDataPie.Series[chartTitle].IsValueShownAsLabel = true;
                //chtData.Series["월별 제품 생산비율"].IsXValueIndexed = true;


                foreach (var item in MTHistoryList)
                {
                    //string itemName = MTHistoryList.Where(x => x.Item_Name.Equals(item.Item_Name)).Select((x) => x.Item_Name).ToList().FirstOrDefault() ?? string.Empty;
                    //int TotPrdQty = MTHistoryList.Where(x => x.TotPrdQty.Equals(item.TotPrdQty)).Select((x) => x.TotPrdQty).ToList().FirstOrDefault();
                    string itemName = item.Item_Name;
                    int TotPrdQty = item.TotPrdQty;

                    chtDataPie.Series[chartTitle].Points.AddXY(itemName, TotPrdQty);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataPie.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
                    num++;
                    colors += 7;
                }
                #endregion

            }
            else if (rdoPlanQty.Checked) //목표량
            {
                chartTitle = "월별 제품 목표량";
                #region 파이차트
                chtDataPie.Series.Add(chartTitle);
                chtDataPie.Series[chartTitle].Points.Clear();
                chtDataPie.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
                chtDataPie.Series[chartTitle].IsValueShownAsLabel = true;

                foreach (var item in MTHistoryList)
                {
                    string itemName = item.Item_Name;
                    int TotPlanQty = item.TotPlanQty;

                    chtDataPie.Series[chartTitle].Points.AddXY(itemName, TotPlanQty);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataPie.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
                    num++;
                    colors += 7;
                }
                #endregion

            }
            else if (rdoInQty.Checked) //투입량
            {
                chartTitle = "월별 제품 투입량";
                #region 파이차트
                chtDataPie.Series.Add(chartTitle);
                chtDataPie.Series[chartTitle].Points.Clear();
                chtDataPie.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
                chtDataPie.Series[chartTitle].IsValueShownAsLabel = true;

                foreach (var item in MTHistoryList)
                {
                    string itemName = item.Item_Name;
                    int TotInQty = item.TotInQty;

                    chtDataPie.Series[chartTitle].Points.AddXY(itemName, TotInQty);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataPie.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
                    num++;
                    colors += 7;
                }
                #endregion

            }
            else if (rdoOutQty.Checked) //산출량
            {
                chartTitle = "월별 제품 산출량";
                #region 파이차트
                chtDataPie.Series.Add(chartTitle);
                chtDataPie.Series[chartTitle].Points.Clear();
                chtDataPie.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
                chtDataPie.Series[chartTitle].IsValueShownAsLabel = true;

                foreach (var item in MTHistoryList)
                {
                    string itemName = item.Item_Name;
                    int TotOutQty = item.TotOutQty;

                    chtDataPie.Series[chartTitle].Points.AddXY(itemName, TotOutQty);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataPie.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
                    num++;
                    colors += 7;
                }
                #endregion
            }
            else if (rdoLossQty.Checked) //Loss수량
            {
                chartTitle = "월별 제품 Loss수량";
                #region 파이차트
                chtDataPie.Series.Add(chartTitle);
                chtDataPie.Series[chartTitle].Points.Clear();
                chtDataPie.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
                chtDataPie.Series[chartTitle].IsValueShownAsLabel = true;

                foreach (var item in MTHistoryList)
                {
                    string itemName = item.Item_Name;
                    int TotLoss = item.TotLoss;

                    chtDataPie.Series[chartTitle].Points.AddXY(itemName, TotLoss);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataPie.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
                    num++;
                    colors += 7;
                }
                #endregion
            }
        }

        public void ChartDataTwo() //(테스트중)반복부분 메서드만들어서 수정해야함
        {
            string chartTitle = "";
            int num = 0;
            int colors = 5;

            chtDataPie.Series.Clear();

            if (rdoPrdQty.Checked) //생산수량
            {
                chartTitle = "월별 제품 생산비율";
                #region 파이차트, 라인차트
                chtDataPie.Series.Add(chartTitle);
                chtDataPie.Series[chartTitle].Points.Clear();
                chtDataPie.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
                chtDataPie.Series[chartTitle].IsValueShownAsLabel = true;

                chtDataLine.Series.Clear();
                chtDataLine.Series.Add(chartTitle);
                chtDataLine.Series[chartTitle].Points.Clear();
                chtDataLine.Series[chartTitle].ChartType = SeriesChartType.StackedColumn;
                chtDataLine.Series[chartTitle].IsValueShownAsLabel = true;


                foreach (var item in MTHistoryList)
                {
                    string itemName = item.Item_Name;
                    int TotPrdQty = item.TotPrdQty;
                    chtDataPie.Series[chartTitle].Points.AddXY(itemName, TotPrdQty);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataPie.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);

                    chtDataLine.Series[chartTitle].Points.AddXY(itemName, TotPrdQty);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataLine.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
                    //chtDataLine.Series[chartTitle].Points[num]..DataBind(MTHistoryList, "Item_Name", "TotPrdQty", "Label=TotPrdQty"); // X축: 시간, Y축:  생산량
                    num++;
                    colors += 7;
                }
                #endregion
            }
            else if (rdoPlanQty.Checked) //목표량
            {
                chartTitle = "월별 제품 목표량";
                #region 파이차트, 라인차트
                chtDataPie.Series.Add(chartTitle);
                chtDataPie.Series[chartTitle].Points.Clear();
                chtDataPie.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
                chtDataPie.Series[chartTitle].IsValueShownAsLabel = true;

                chtDataLine.Series.Clear();
                chtDataLine.Series.Add(chartTitle);
                chtDataLine.Series[chartTitle].Points.Clear();
                chtDataLine.Series[chartTitle].ChartType = SeriesChartType.StackedColumn;
                chtDataLine.Series[chartTitle].IsValueShownAsLabel = true;

                foreach (var item in MTHistoryList)
                {
                    string itemName = item.Item_Name;
                    int TotPlanQty = item.TotPlanQty;
                    chtDataPie.Series[chartTitle].Points.AddXY(itemName, TotPlanQty);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataPie.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);

                    chtDataLine.Series[chartTitle].Points.AddXY(itemName, TotPlanQty);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataLine.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
                    num++;
                    colors += 7;
                }
                #endregion
            }
            else if (rdoInQty.Checked) //투입량
            {
                chartTitle = "월별 제품 투입량";
                #region 파이차트, 라인차트
                chtDataPie.Series.Add(chartTitle);
                chtDataPie.Series[chartTitle].Points.Clear();
                chtDataPie.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
                chtDataPie.Series[chartTitle].IsValueShownAsLabel = true;

                chtDataLine.Series.Clear();
                chtDataLine.Series.Add(chartTitle);
                chtDataLine.Series[chartTitle].Points.Clear();
                chtDataLine.Series[chartTitle].ChartType = SeriesChartType.StackedColumn;
                chtDataLine.Series[chartTitle].IsValueShownAsLabel = true;

                foreach (var item in MTHistoryList)
                {
                    string itemName = item.Item_Name;
                    int TotInQty = item.TotInQty;
                    chtDataPie.Series[chartTitle].Points.AddXY(itemName, TotInQty);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataPie.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);

                    chtDataLine.Series[chartTitle].Points.AddXY(itemName, TotInQty);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataLine.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
                    num++;
                    colors += 7;
                }
                #endregion
            }
            else if (rdoOutQty.Checked) //산출량
            {
                chartTitle = "월별 제품 산출량";
                #region 파이차트, 라인차트
                chtDataPie.Series.Add(chartTitle);
                chtDataPie.Series[chartTitle].Points.Clear();
                chtDataPie.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
                chtDataPie.Series[chartTitle].IsValueShownAsLabel = true;

                chtDataLine.Series.Clear();
                chtDataLine.Series.Add(chartTitle);
                chtDataLine.Series[chartTitle].Points.Clear();
                chtDataLine.Series[chartTitle].ChartType = SeriesChartType.StackedColumn;
                chtDataLine.Series[chartTitle].IsValueShownAsLabel = true;

                foreach (var item in MTHistoryList)
                {
                    string itemName = item.Item_Name;
                    int TotOutQty = item.TotOutQty;
                    chtDataPie.Series[chartTitle].Points.AddXY(itemName, TotOutQty);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataPie.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);

                    chtDataLine.Series[chartTitle].Points.AddXY(itemName, TotOutQty);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataLine.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
                    num++;
                    colors += 7;
                }
                #endregion
            }
            else if (rdoLossQty.Checked) //Loss수량
            {
                chartTitle = "월별 제품 Loss수량";
                #region 파이차트, 라인차트
                chtDataPie.Series.Add(chartTitle);
                chtDataPie.Series[chartTitle].Points.Clear();
                chtDataPie.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
                chtDataPie.Series[chartTitle].IsValueShownAsLabel = true;

                chtDataLine.Series.Clear();
                chtDataLine.Series.Add(chartTitle);
                chtDataLine.Series[chartTitle].Points.Clear();
                chtDataLine.Series[chartTitle].ChartType = SeriesChartType.StackedColumn;
                chtDataLine.Series[chartTitle].IsValueShownAsLabel = true;

                foreach (var item in MTHistoryList)
                {
                    string itemName = item.Item_Name;
                    int TotLoss = item.TotLoss;
                    chtDataPie.Series[chartTitle].Points.AddXY(itemName, TotLoss);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataPie.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);

                    chtDataLine.Series[chartTitle].Points.AddXY(itemName, TotLoss);
                    chtDataPie.Series[chartTitle].Points[num].LegendText = itemName;
                    chtDataLine.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
                    num++;
                    colors += 7;
                }
                #endregion
            }
        }

        //private void chartData(string chartTitle)
        //{
        //    chtData.Series.Add(chartTitle);
        //    chtData.Series[chartTitle].Points.Clear();
        //    chtData.Series[chartTitle].ChartType = SeriesChartType.Doughnut;
        //    chtData.Series[chartTitle].IsValueShownAsLabel = true;

        //    foreach (var item in MTHistoryList)
        //    {
        //        string itemName = item.Item_Name;
        //        int TotPrdQty = item.TotInQty;

        //        chtData.Series[chartTitle].Points.AddXY(itemName, TotPrdQty);
        //        chtData.Series[chartTitle].Points[num].LegendText = itemName;
        //        chtData.Series[chartTitle].Points[num].Color = Color.FromArgb(211 + colors, 226, 223);
        //        num++;
        //        colors += 7;
        //    }
        //}


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
            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                col.DefaultCellStyle.BackColor = Color.White;
                //col.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            }
            dgvData.Columns[/*"Item_Name"*/ "Item_Code"].DefaultCellStyle.BackColor = Color.FromArgb(211, 226, 223);

            if (rdoPrdQty.Checked) //생산수량
            {
                string[] backColorCell = new string[] { "TotInQty", "TotOutQty", "TotPrdQty" }; //투입량, 산출량, 총생산량
                foreach (string item in backColorCell) dgvData.Columns[item].DefaultCellStyle.BackColor = Color.FromArgb(211, 226, 223);
            }
            else if (rdoPlanQty.Checked) //목표량
            {
                string[] backColorCell = new string[] { "TotPlanQty", "TotPrdQty" }; //목표량, 총생산량
                foreach (string item in backColorCell) dgvData.Columns[item].DefaultCellStyle.BackColor = Color.FromArgb(211, 226, 223);
            }
            else if (rdoInQty.Checked) //투입량
            {
                string[] backColorCell = new string[] { "TotInQty", "TotPrdQty" }; //투입량, 산출량
                foreach (string item in backColorCell) dgvData.Columns[item].DefaultCellStyle.BackColor = Color.FromArgb(211, 226, 223);
            }
            else if (rdoOutQty.Checked) //산출량
            {
                string[] backColorCell = new string[] { "TotPlanQty", "TotOutQty" }; //목표량, 산출량
                foreach (string item in backColorCell) dgvData.Columns[item].DefaultCellStyle.BackColor = Color.FromArgb(211, 226, 223);
            }
            else if (rdoLossQty.Checked) //Loss수량
            {
                string[] backColorCell = new string[] { "TotInQty", "TotOutQty", "TotLoss" }; //투입량, 산출량, Loss수량
                foreach (string item in backColorCell) dgvData.Columns[item].DefaultCellStyle.BackColor = Color.FromArgb(211, 226, 223);
            }

            if (dgvData.Rows.Count > 0)
                if (dgvData.CurrentRow != null) dgvData_CellClick(dgvData.CurrentRow.Index, new DataGridViewCellEventArgs(0, 0));
                else
                    chtDataPie.Series.Clear();
        }

        private void rdoChartTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChartOne.Checked)
            {
                chtDataLine.Visible = false;
                ChartDataOne();
            }

            else if (rdoChartTwo.Checked)
            {
                ChartDataTwo();
                splitContainerChart.Visible = true;
                chtDataLine.Visible = true;

            }
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