using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;
using System.Linq;

namespace Team2_Project
{
    public partial class frmDefectCode : frmListUpAreaDown
    {
        DefCodeService srv = new DefCodeService();
        List<DefCodeDTO> defList;
        
        public frmDefectCode()
        {
            InitializeComponent();
        }

        private void frmDefectCode_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvMa);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "불량현상 대분류코드", "Def_Ma_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "불량현상 대분류명", "Def_Ma_Name", 250);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "사용유무", "Use_YN");

            CommonCodeUtil.UseYNComboBinding(cboUseSC);
            CommonCodeUtil.UseYNComboBinding(cboUseYN, false);
            cboUseSC.SelectedIndex = 0;

            LoadData();
            SetInitPnl();
        }

        private void LoadData()
        {
            defList = srv.GetDefCode();
            if (defList != null)
            {
                dgvMa.DataSource = null;
                dgvMa.DataSource = defList;
            }            
        }

        private void SetInitPnl()
        {
            txtCode.Text = txtName.Text = "";
            cboUseYN.SelectedIndex = -1;

            txtName.Enabled = txtCode.Enabled = cboUseYN.Enabled = false;
        }


        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            string defName = txtNameSC.Text;
            string defCode = txtCodeSC.Text;
            string useYN = (cboUseSC.SelectedItem.ToString() == "전체") ? "" : cboUseSC.SelectedItem.ToString();

            var list = (from c in defList
                        where c.Def_Ma_Code.Contains(defCode) && c.Def_Ma_Name.Contains(defName) && c.Use_YN.Contains(useYN)
                        select c).ToList();

            dgvMa.DataSource = list;
        }

        public void OnAdd()     //추가
        {
            SetInitPnl();

            dgvMa.Enabled = false;
            txtName.Enabled = txtCode.Enabled = cboUseYN.Enabled = true;            
            cboUseYN.SelectedIndex = 0;
        }

        public void OnEdit()    //수정
        {
            txtName.Enabled = cboUseYN.Enabled = true;
            dgvMa.Enabled = false;
        }

        public void OnDelete()  //삭제
        {

        }

        public void OnSave()    //저장
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("필수항목을 입력해주세요.");
                return;
            }

            if (txtCode.Enabled) //신규 저장
            {
                bool result = srv.CheckPK(txtCode.Text);
                if (!result)
                {
                    MessageBox.Show("불량현상 대분류코드가 중복되었습니다. 다시 입력하여 주십시오.");
                    return;
                }

                DefCodeDTO code = new DefCodeDTO
                {
                    Def_Ma_Code = txtCode.Text,
                    Def_Ma_Name = txtName.Text,
                    Use_YN = (cboUseYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Ins_Emp = "" //수정필요
                };

                result = srv.InsertDefCode(code);
                if(result)
                {
                    MessageBox.Show("등록이 완료되었습니다.");
                    dgvMa.Enabled = true;

                    SetInitPnl();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("등록 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }

            }
            else //수정 저장
            {
                DefCodeDTO code = new DefCodeDTO
                {
                    Def_Ma_Code = txtCode.Text,
                    Def_Ma_Name = txtName.Text,
                    Use_YN = (cboUseYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Up_Emp = "" //수정필요
                };

                bool result = srv.UpdateDefCode(code);
                if (result)
                {
                    MessageBox.Show("수정이 완료되었습니다.");
                    dgvMa.Enabled = true;

                    SetInitPnl();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("수정 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }
        }

        public void OnCancel()  //취소
        {
            SetInitPnl();

            dgvMa.Enabled = true;
            dgvMa.ClearSelection();
        }

        public void OnReLoad()  //새로고침
        {
            txtCodeSC.Text = txtNameSC.Text = "";
            cboUseSC.SelectedIndex = 0;
            
            SetInitPnl();
            LoadData();
        }
        #endregion

        private void dgvMa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            txtCode.Text = dgvMa["Def_Ma_Code", e.RowIndex].Value.ToString();
            txtName.Text = dgvMa["Def_Ma_Name", e.RowIndex].Value.ToString();
            cboUseYN.SelectedItem = dgvMa["Use_YN", e.RowIndex].Value.ToString();
        }
    }
}
