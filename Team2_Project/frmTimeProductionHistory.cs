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

namespace Team2_Project
{
    public partial class frmTimeProductionHistory : Team2_Project.frmList
    {
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
            //작업지시목록 : 작업지시번호, 작업지시일자, 작업지시수량, 계획수량단위, 품목코드, 품목명, 작업장, 생산일자, 생산시작, 생산종료, 투입, 산출, 생산수량, 불량수량
            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시번호", "", 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시일자", "", 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시수량", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "계획수량단위", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업장", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산일자", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산시작", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산종료", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "투입", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "산출", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산수량", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "불량수량", "", 200);
            dgvData.MultiSelect = false;



        }

        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {

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
        public void OnPrint()   //프린트(액셀)
        {

        }
        #endregion
    }
}
