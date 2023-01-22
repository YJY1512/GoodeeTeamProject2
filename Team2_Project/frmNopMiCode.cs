﻿using System;
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
    public partial class frmNopMiCode : frmCodeControlBase
    {
        NopCodeService srv = new NopCodeService();
        List<NopMaCodeDTO> NopMaList = new List<NopMaCodeDTO>();
        List<NopMiCodeDTO> NopMiList = new List<NopMiCodeDTO>();
        string situation = "";

        public frmNopMiCode()
        {
            InitializeComponent();
        }

        private void frmNopMiCode_Load(object sender, EventArgs e)
        {
            cboSearchUse.Items.Add("전체");
            cboSearchUse.Items.Add("사용");
            cboSearchUse.Items.Add("미사용");
            cboSearchUse.SelectedIndex = 0;
            cboSearchUse.DropDownStyle = ComboBoxStyle.DropDownList;

            DataGridViewUtil.SetInitDataGridView(dgvMaData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaData, "비가동 대분류코드", "Nop_Ma_Code", 250);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaData, "비가동 대분류명", "Nop_Ma_Name", 250);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaData, "사용유무", "Use_YN", 100, align: DataGridViewContentAlignment.MiddleCenter);

            DataGridViewUtil.SetInitDataGridView(dgvMiData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiData, "비가동 상세분류코드", "Nop_Mi_Code", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiData, "비가동 상세분류명", "Nop_Mi_Name", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiData, "비가동 구분", "Regular_Type", 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiData, "비가동 유형", "Nop_type", 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiData, "사용유무", "Use_YN", 100, align: DataGridViewContentAlignment.MiddleCenter);

            cboUseYN.Items.Add("-선택-");
            cboUseYN.Items.Add("사용");
            cboUseYN.Items.Add("미사용");
            cboUseYN.SelectedIndex = 0;
            cboUseYN.DropDownStyle = ComboBoxStyle.DropDownList;

            Deactivation(); //입력패널 비활성화
            OnSearch();
        }

        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            NopMaCodeDTO item = new NopMaCodeDTO
            {
                Nop_Ma_Code = ucSearchCode._Code,
                Nop_Ma_Name = ucSearchCode._Name,
                Use_YN = cboSearchUse.Text
            };
            NopMaList = srv.GetNopMaSearch(item);
            dgvMaData.DataSource = null;
            dgvMaData.DataSource = NopMaList;
        }
        public void OnAdd()     //추가
        {
            ResetBottom();
            Activation();
            situation = "Add";
        }
        public void OnEdit()    //수정
        {
            Activation();
            situation = "Update";
        }
        public void OnDelete()  //삭제
        {

        }
        public void OnSave()    //저장
        {
            

            OnReLoad();
        }

        public void OnCancel()  //취소
        {
            ResetBottom();  //입력패널 리셋
            Deactivation(); //입력패널 비활성화
            OnSearch();     //로드
        }
        public void OnReLoad()  //새로고침
        {
            //Deactivation();
            ResetTop();       //검색조건 리셋
            ResetBottom();    //입력패널 리셋
            OnSearch();       //로드
        }
        #endregion

        private void dgvMiData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string curCode = dgvMiData[1, dgvMiData.CurrentRow.Index].Value.ToString();
            //NopMiList = srv.GetCurItem(curCode);

            //입력정보에 바인딩
            //NopMiCodeDTO dto = NopMiList.FirstOrDefault((p) => p.Nop_Mi_Code == curCode);
            //if (dto != null)
            //{
            //    txtCode.Text = dto.Nop_Ma_Code;
            //    txtName.Text = dto.Nop_Ma_Name;
            //    cboUseYN.Text = dto.Use_YN;
            //}
        }

        private void ResetTop() //검색조건 리셋
        {
            //txtCodeSC.Text = txtName.Text = txtNameSC.Text = "";
            //cboUseYNSC.SelectedIndex = 0;
        }

        private void ResetBottom() //입력패널 리셋
        {
            //txtCode.Text = txtName.Text = "";
            //cboUseYN.SelectedIndex = 0;
        }

        private void Deactivation() //입력패널 비활성화
        {
            //txtCode.Enabled = txtName.Enabled = cboUseYN.Enabled = false;
        }

        private void Activation() //입력패널 활성화
        {
            //txtName.Enabled = txtCode.Enabled = cboUseYN.Enabled = true;
        }

    }
}
