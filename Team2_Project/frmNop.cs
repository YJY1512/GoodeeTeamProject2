﻿using System;
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
    public partial class frmNop : frmList
    {
        NopCodeService srv = new NopCodeService();
        List<NopHistoryDTO> NopList = new List<NopHistoryDTO>();
        List<NopMaCodeDTO> NopMaList = new List<NopMaCodeDTO>();

        public frmNop()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadData();
            onsearch();
            ResetDtp();//초기dtp (1주전~today)
        }

        private void LoadData()
        {
            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동순번", "Nop_Seq", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동발생일자", "Nop_Date", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동발생일시", "Nop_HappenTime", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동해제일시", "Nop_CancelTime", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동시간", "Nop_Time", 200);

            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업장코드", "Wc_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업장명", "Wc_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업장그룹", "Wc_Group", 200);

            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "공정명", "Process_Name", 200);
            //DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "공정그룹(작업장)", "", 200);
            //DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "공정그룹(비가동)", "", 200);

            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동대분류코드", "", 200);

            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동상세분류코드", "Nop_Mi_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동상세분류명", "Nop_Mi_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동대분류코드", "Nop_Ma_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동대분류명", "Nop_Ma_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동유형", "Nop_type", 200);

        }

        #region main 버튼 클릭이벤트
        public void onsearch()  //검색 
        {
            NopHistoryDTO item = new NopHistoryDTO
            {
                Nop_Ma_Code = ucCodeSearch._Code,
                Nop_Ma_Name = ucCodeSearch._Name,
                DateFrom = dtpFrom.Value.ToString("yyyy-MM-dd"),
                DateTo =dtpTo.Value.ToString("yyyy-MM-dd")
            };
            NopList = srv.GetNopMiSearch(item);
            dgvData.DataSource = null;
            dgvData.DataSource = NopList;
            dgvData.ClearSelection();
        }
        //public void onadd()     //추가
        //{


        //}
        //public void onedit()    //수정
        //{

        //}
        //public void ondelete()  //삭제
        //{

        //}
        //public void onsave()    //저장
        //{

        //}
        //public void oncancel()  //취소
        //{

        //}
        public void onreload()  //새로고침
        {
            ResetTop();       //검색 리셋
            onsearch();       //로드
        }
        #endregion



        private void ResetTop() //검색 리셋
        {
            ucCodeSearch._Code = ucCodeSearch._Name = "";
            ResetDtp();

        }


        private void ucCodeSearch_BtnClick(object sender, EventArgs e)
        {
            var list = NopMaList.GroupBy((g) => g.Nop_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
            List<DataGridViewTextBoxColumn> col = new List<DataGridViewTextBoxColumn>();
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("비가동 대분류코드", "Nop_Ma_Code", 200));
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("비가동 대분류명", "Nop_Ma_Name", 200));

            CommonPop<NopMaCodeDTO> dto = new CommonPop<NopMaCodeDTO>();
            dto.DgvDatasource = list;
            dto.DgvCols = col;
            dto.PopName = "비가동 대분류코드 검색";
            ucCodeSearch.OpenPop(dto);
        }

        private void ResetDtp()
        {
            dtpFrom.Value = DateTime.Now.AddDays(-7);
            dtpTo.Value = DateTime.Now;
        }
    }
}

/*
 * ** dtp 기본값은 오늘로부터 n일(1주일?)
 * dtpTo 오늘날짜를 초과해서 조회하지못할것
 * dtpFrom보다 dtpTo가 이전이지 않을것
 */