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

        public frmMonthProductionHistory()
        {
            InitializeComponent();
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
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "목표량", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산량", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "달성율", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "가동율", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "일일생산량", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산일수", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "LOSS수량", "", 150, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "LOSS비율", "", 150);
            dgvData.MultiSelect = false;

            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("나눔고딕", 11);
            dgvData.DefaultCellStyle.Font = new Font("나눔고딕", 11);

            ResetTop();
            OnSearch();
            ChartData();
        }

        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {


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

        }


        public void ChartData()
        {
            //string curInfo = dgvData["Item_Code", dgvData.CurrentRow.Index].Value.ToString();
            //TPHistoryList = srv.Get(curInfo);

            chtData.Titles.Add("월별 제품 생산비율");
            chtData.Series.Clear();
            chtData.Series.Add("품목");
            chtData.Series["품목"].Points.Clear();
            chtData.Series["품목"].ChartType = SeriesChartType.Doughnut;
                        
            chtData.Series["품목"].Points.Add(75);
            chtData.Series["품목"].Points[0].LegendText = "품목1";

            chtData.Series["품목"].Points.Add(70);
            chtData.Series["품목"].Points[1].LegendText = "품목2";

            chtData.Series["품목"].Points.Add(50);
            chtData.Series["품목"].Points[2].LegendText = "품목3";

            chtData.Series["품목"].Points[0].Color = Color.FromArgb(211, 226, 223);
            chtData.Series["품목"].Points[1].Color = Color.FromArgb(255, 227, 217);
            chtData.Series["품목"].Points[2].Color = Color.FromArgb(255, 237, 227);
        }

        private void ucItemSearch_BtnClick(object sender, EventArgs e)
        {
            var list = itemList.GroupBy((g) => g.Item_Code).Select((g) => g.FirstOrDefault()).ToList();
            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목코드", "Item_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목명", "Item_Name", 200));

            CommonPop<ItemDTO> popInfo = new CommonPop<ItemDTO>();
            popInfo.DgvDatasource = list;
            popInfo.DgvCols = colList;
            popInfo.PopName = "품목코드 검색";
            ucItemSearch.OpenPop(popInfo);
        }
    }  
}
/*
 (분석소재)
- 월별 제품 생산 비율
- 월별 불량 사유 비율
*/