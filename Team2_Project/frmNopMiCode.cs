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
            LoadData();     //로드            
            OnSearch();     //조회
        }

        private void LoadData()
        {
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

            CommonCodeUtil.UseYNComboBinding(cboSearchUse);
            CommonCodeUtil.UseYNComboBinding(cboUseYN, false);
            cboSearchUse.SelectedIndex = 0;
            cboSearchUse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUseYN.DropDownStyle = ComboBoxStyle.DropDownList;

            DeactivationBottom(); //입력패널 비활성화
            OnSearch();
            label12.Visible = label9.Visible = nudSort.Visible = label13.Visible = label8.Visible = txtRemark.Visible = false;
        }

        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            NopMaCodeDTO item = new NopMaCodeDTO
            {
                Nop_Ma_Code = ucMaCodeSC._Code,
                Nop_Ma_Name = ucMaCodeSC._Name,
                Use_YN = cboSearchUse.Text
            };
            NopMaList = srv.GetNopMaSearch(item);
            dgvMaData.DataSource = null;
            dgvMaData.DataSource = NopMaList;
            dgvMaData.ClearSelection();
            dgvMiData.ClearSelection();
            ResetBottom();  //입력패널 리셋
            DeactivationBottom(); //입력패널 비활성화
        }
        public void OnAdd()     //추가
        {
            if (dgvMaData.SelectedRows.Count < 1)
            {
                MessageBox.Show("추가할 항목을 선택하여 주십시오.");
                return;
            }

            situation = "Add";
            cboUseYN.SelectedIndex = 0;
            dgvMaData.Enabled = dgvMiData.Enabled = false;
            dgvMiData.ClearSelection();
            DeactivationTop();            //검색조건 비활성화
            ResetBottom();                //입력패널 리셋
            ActivationBottom(situation);  //입력패널 활성화
            txtInfoCodeMi.Focus();
            int idx = dgvMaData.CurrentRow.Index;
            ucMaCode._Code = dgvMaData["Nop_Ma_Code", idx].Value.ToString();
            ucMaCode._Name = dgvMaData["Nop_Ma_Name", idx].Value.ToString();
        }
        public void OnEdit()    //수정
        {
            if (dgvMiData.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 항목을 선택하여 주십시오.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }
            situation = "Update";
            dgvMaData.Enabled = dgvMiData.Enabled = false;
            dgvMiData.ClearSelection();
            DeactivationTop();      //검색조건 비활성화
            ActivationBottom(situation);  //입력패널 활성화
        }
        public void OnDelete()  //삭제
        {
            if (dgvMiData.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 항목을 선택하여 주십시오.");
                return;
            }

            dgvMaData.Enabled = dgvMiData.Enabled = false;

            if (MessageBox.Show($"{txtInfoNameMi.Text}을 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int result = srv.DeleteMiCode(txtInfoCodeMi.Text);
                if (result == 0) MessageBox.Show("삭제가 완료되었습니다."); //성공
                else if (result == 3726) MessageBox.Show("데이터를 삭제할 수 없습니다."); //FK 충돌
                else MessageBox.Show("삭제 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                ResetBottom(); //입력패널 리셋
                OnSearch();    //로드
            }
            dgvMaData.Enabled = dgvMiData.Enabled = true;
        }
        public void OnSave()    //저장
        {
            //필수입력항목: 코드, 명, 사용유무
            if (string.IsNullOrWhiteSpace(txtInfoCodeMi.Text) || string.IsNullOrWhiteSpace(txtInfoNameMi.Text)) //|| cboUseYN.SelectedIndex == 0
            {
                MessageBox.Show("필수항목을 입력하여 주십시오.");
                return;
            }

            NopMiCodeDTO code = new NopMiCodeDTO
            {
                Nop_Ma_Code = ucMaCode._Code,                
                Nop_Mi_Code = txtInfoCodeMi.Text,
                Nop_Mi_Name = txtInfoNameMi.Text,
                Use_YN = cboUseYN.Text.Equals("사용") ? "Y" : "N",                
                Up_Emp = "홍길동" //////////////////////////////////////////////////////// 추후수정
            };

            if (situation == "Add")
            {
                bool pkresult = srv.CheckMiPK(txtInfoCodeMi.Text);
                if (!pkresult)
                {
                    MessageBox.Show("상세코드가 중복되었습니다. 다시 입력하여 주십시오.");
                    txtInfoCodeMi.Clear();
                    txtInfoCodeMi.Focus();
                    return;
                }

                bool result = srv.NopMiCodeAdd(code);
                if (result) MessageBox.Show("등록이 완료되었습니다.", "등록완료");
                else MessageBox.Show("다시 시도하여주십시오.", "등록오류");
            }
            else if (situation == "Update")
            {
                bool result = srv.NopMiCodeUpdate(code);
                if (result) MessageBox.Show("수정이 완료되었습니다.", "수정완료");
                else MessageBox.Show("다시 시도하여주십시오.", "수정오류");
            }

            OnReLoad();
            ActivationTop();    //검색 활성화
            situation = "";
            dgvMaData.Enabled = dgvMiData.Enabled = true;
        }

        public void OnCancel()  //취소
        {
            dgvMaData.Enabled = dgvMiData.Enabled = true;
            ResetBottom();          //입력 리셋
            DeactivationBottom();   //입력 비활성화
            OnSearch();             //로드
            ActivationTop();        //검색 활성화
        }
        public void OnReLoad()  //새로고침
        {
            //Deactivation();
            ResetTop();       //검색 리셋
            ResetBottom();    //입력 리셋
            OnSearch();       //로드
        }
        #endregion

        private void ResetTop() //검색 리셋
        {
            ucMaCodeSC._Code = ucMaCodeSC._Name = "";
            cboSearchUse.SelectedIndex = 0;
        }

        private void ActivationTop() //검색 활성화
        {
            ucMaCodeSC.Enabled = cboSearchUse.Enabled = true;
        }

        private void DeactivationTop() //검색 비활성화
        {
            ucMaCodeSC.Enabled = cboSearchUse.Enabled = false;
        }

        private void ResetBottom() //입력 리셋
        {
            foreach (Control ctrl in splitContainer2.Panel2.Controls)
            {
                if (ctrl is Label || ctrl is Panel) continue;
                if (ctrl is TextBox) ctrl.Text = "";
            }
            ucMaCode._Code = ucMaCode._Name = "";
            cboUseYN.SelectedIndex = -1;
        }

        private void ActivationBottom(string situation) //입력 활성화
        {
            foreach (Control ctrl in splitContainer2.Panel2.Controls)
                ctrl.Enabled = true;
            if (situation.Equals("Update"))
            {
                ucMaCode.Enabled = false;
                txtInfoCodeMi.Enabled = false;
            }            
        }

        private void DeactivationBottom() //입력 비활성화
        {
            foreach (Control ctrl in splitContainer2.Panel2.Controls)
                ctrl.Enabled = false;
        }

        private void ucCodeSearch_BtnClick(object sender, EventArgs e)
        {
            //var list = NopMaList.GroupBy((g) => g.Nop_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("비가동 대분류코드", "Nop_Ma_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("비가동 대분류명", "Nop_Ma_Name", 200));

            CommonPop<NopMaCodeDTO> popInfo = new CommonPop<NopMaCodeDTO>();
            //.DgvDatasource = list;
            popInfo.DgvCols = colList;
            popInfo.PopName = "품목코드 검색";
            ucMaCodeSC.OpenPop(popInfo);
        }

        private void dgvMaData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMiData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
