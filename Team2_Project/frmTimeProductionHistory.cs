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
    public partial class frmTimeProductionHistory : Team2_Project.frmList
    {
        TimeProductionHistoryService srv = new TimeProductionHistoryService();
        List<TimeProductionHistoryDTO> TPHistoryList = new List<TimeProductionHistoryDTO>();

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
            cboWoStatus.Items.Add("전체");
            cboWoStatus.Items.Add("생산대기");
            cboWoStatus.Items.Add("생산중");
            cboWoStatus.Items.Add("생산중지");
            cboWoStatus.Items.Add("현장마감");
            cboWoStatus.Items.Add("작업지시마감"); //추후 DB에서 CODE 가져오기


            //작업지시목록 : 작업지시번호, 작업지시일자, 작업지시수량, 계획수량단위, 품목코드, 품목명, 작업장, 생산일자, 생산시작, 생산종료, 투입, 산출, 생산수량, 불량수량
            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시번호", "Wo_Status", 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시번호", "WorkOrderNo", 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시일자", "Ins_Date", 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시수량", "Plan_Qty_Box", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "계획수량단위", "Plan_Unit", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목코드", "Item_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목명", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업장", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산일자", "Prd_Date", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산시작", "Prd_StartTime", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산종료", "Prd_EndTime", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "투입", "In_Qty_Main", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "산출", "Out_Qty_Main", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산수량", "Prd_Qty", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "불량수량", "Def_Qty", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업장코드", "Wc_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "시작시간대", "Start_Hour", 200, visible:false);
            dgvData.MultiSelect = false;



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

            TPHistoryList = srv.GetTimeProductionHistory(dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd"));

            if (TPHistoryList != null && TPHistoryList.Count > 0)
            {
                //var list = TPHistoryList.GroupBy((n) => n.Nop_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
                AdvancedListBind(TPHistoryList, dgvData);
            }

        }

        public void OnAdd()     //추가
        {

        }
        public void OnEdit()    //수정
        {

        }
        public void OnDelete()  //삭제
        {

        }
        public void OnSave()    //저장
        {

        }
        public void OnCancel()  //취소
        {

        }
        public void OnReLoad()  //새로고침
        {

        }
        #endregion

        private void ucProcessCode_BtnClick(object sender, EventArgs e)
        {
            //var list = (from g in TPHistoryList
            //            group g by g.Process_Code ).ToList();
            var list = TPHistoryList.GroupBy((g) => g.Process_Code).Select((g) => g.FirstOrDefault()).ToList();

            List<DataGridViewTextBoxColumn> col = new List<DataGridViewTextBoxColumn>();
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("공정코드", "Process_Code", 200));
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("공정명", "Process_Name", 200));

            CommonPop<TimeProductionHistoryDTO> dto = new CommonPop<TimeProductionHistoryDTO>();
            dto.DgvDatasource = list;
            dto.DgvCols = col;
            dto.PopName = "공정정보 검색";
            ucProcessCode.OpenPop(dto);
        }

        private void ucWcCode_BtnClick(object sender, EventArgs e)
        {
            var list = TPHistoryList.GroupBy((g) => g.Wc_Code).Select((g) => g.FirstOrDefault()).ToList();
            List<DataGridViewTextBoxColumn> col = new List<DataGridViewTextBoxColumn>();
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장코드", "Wc_Code", 200));
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장명", "Wc_Name", 200));

            CommonPop<TimeProductionHistoryDTO> dto = new CommonPop<TimeProductionHistoryDTO>();
            dto.DgvDatasource = list;
            dto.DgvCols = col;
            dto.PopName = "작업장정보 검색";
            ucWcCode.OpenPop(dto);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
