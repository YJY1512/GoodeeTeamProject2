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
            dtpDate.Value = new DateTime(2023, 02, 1);
        }

        private void frmMonthProductionHistory_Load(object sender, EventArgs e)
        {
            //월별 제품 생산비율 폼
            LoadData();
        }

        public void LoadData()
        {
            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목코드", "Item_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목명", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목유형", "Item_Type", 150);

            //예상컬럼//
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "목표량", "TotPlanQty", 150, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "INPUT(투입량)", "TotInQty", 150, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "OUTPUT(산출량)", "TotOutQty", 150, DataGridViewContentAlignment.MiddleRight);
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

            string[] backColorCell = new string[] { "TotInQty", "TotPrdQty", "TotLoss" };
            foreach (string item in backColorCell) dgvData.Columns[item].DefaultCellStyle.BackColor = Color.FromArgb(211, 226, 223);

            ResetTop();
            OnSearch();

            //---- test ----
            ChartData();
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
            dtpDate.Value = DateTime.Now;
            ucItemSearch._Code = ucItemSearch._Name = "";
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1. 조회조건으로 검색하면  (DB에서 List<생산현황>가져와서)   dgv가 뜸 
            //2. 제품 dgv를 선택하면 제품코드 DB가져가서 (DB에서 List<월별생산비율>가져와서)    chart에 반영


            if (e.RowIndex < 0) return;
            else if (dgvData.Rows.Count > 0)
                ChartData();
        }


        public void ChartData()
        {
            //string curInfo = dgvData["Item_Code", dgvData.CurrentRow.Index].Value.ToString();
            //TPHistoryList = srv.Get(curInfo);

            chtData.Series.Clear();
            //chtData.Titles.Add("월별 제품 생산비율");
            chtData.Series.Add("월별 제품 생산비율");
            chtData.Series["월별 제품 생산비율"].Points.Clear();
            chtData.Series["월별 제품 생산비율"].ChartType = SeriesChartType.Doughnut;
            chtData.Series["월별 제품 생산비율"].IsValueShownAsLabel = true;
            //chtData.Series["월별 제품 생산비율"].IsXValueIndexed = true;


            int num = 0;
            int colors = 5;
            foreach (var item in MTHistoryList)
            {                
                string itemName = MTHistoryList.Where(x => x.Item_Name.Equals(item.Item_Name)).Select((x) => x.Item_Name).ToList().FirstOrDefault() ?? string.Empty;
                int TotPrdQty = MTHistoryList.Where(x => x.TotPrdQty.Equals(item.TotPrdQty)).Select((x) => x.TotPrdQty).ToList().FirstOrDefault();

                chtData.Series["월별 제품 생산비율"].Points.AddXY(itemName, TotPrdQty);
                //chtData.Series["월별 제품 생산비율"].Points.Add(TotPrdQty);
                chtData.Series["월별 제품 생산비율"].Points[num].LegendText = itemName;
                chtData.Series["월별 제품 생산비율"].Points[num].Color = Color.FromArgb(211 + colors, 226 , 223);
                //chtData.Series["품목"].Points[num].Color = Color.FromArgb(211  , 226 , 223 );
                num++;
                colors += 7;
            }
        }

        public void ChartColor()
        {

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
    }
}
/*
 (분석소재)
- 월별 제품 생산 비율
- 월별 불량 사유 비율
*/