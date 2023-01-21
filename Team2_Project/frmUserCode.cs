using System;
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
    public partial class frmUserCode : frmCodeControlBase
    {
        UserCodeService srv = new UserCodeService();
        List<UserCodeDTO> codeList;

        public frmUserCode()
        {
            InitializeComponent();
        }

        private void frmUserCode_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvMa);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "사용자정의 대분류코드", "Userdefine_Ma_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "사용자정의 대분류명", "Userdefine_Ma_Name", 250);

            DataGridViewUtil.SetInitDataGridView(dgvMi);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "사용자정의 상세분류코드", "Userdefine_Mi_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "사용자정의 상세분류명", "Userdefine_Mi_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "정렬순서", "Sort_Index");
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "사용유무", "Use_YN");
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Remark", "Remark", visible:false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Userdefine_Ma_Code", "Userdefine_Ma_Code", visible:false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Userdefine_Ma_Name", "Userdefine_Ma_Name", visible: false);

            CommonCodeUtil.UseYNComboBinding(cboSearchUse);
            CommonCodeUtil.UseYNComboBinding(cboUseYN, false);
            cboSearchUse.SelectedIndex = 0;

            SetInitEditPnl();
            LoadData();            
        }

        private void LoadData()
        {
            codeList = srv.GetUserCode();
            if (codeList != null && codeList.Count > 0)
            {
                List<UserCodeDTO> maList = new List<UserCodeDTO>();
                codeList.GroupBy((g) => g.Userdefine_Ma_Code).ToList().ForEach((g) => maList.Add(g.FirstOrDefault()));
                dgvMa.DataSource = maList;
            }
        }

        private void SetInitEditPnl()
        {
            foreach(Control ctrl in splitContainer2.Panel2.Controls)
            {
                if (ctrl is Label || ctrl is Panel)
                    continue;

                if (ctrl is TextBox)
                    ctrl.Text = "";

                ctrl.Enabled = false;                
            }

            ucSearch1._Code = "";
            ucSearch1._Name = "";
            nudSort.Value = 0;
            cboUseYN.SelectedIndex = -1;
        }


        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            string code = ucSearchCode._Code;
            string useYN = (cboSearchUse.SelectedItem.ToString() == "전체")? "" : cboSearchUse.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(code) && string.IsNullOrWhiteSpace(useYN))
            {
                dgvMi.DataSource = null;
                LoadData();
                return;
            }
            
            var list = (from c in codeList
                        where c.Userdefine_Ma_Code == code && c.Use_YN.Contains(useYN)
                        select c).ToList();
            dgvMi.DataSource = list;

            List<UserCodeDTO> maList = new List<UserCodeDTO>();
            list.GroupBy((g) => g.Userdefine_Ma_Code).ToList().ForEach((g) => maList.Add(g.FirstOrDefault()));
            dgvMa.DataSource = maList;
        }

        public void OnAdd()     //추가
        {
            if (dgvMa.SelectedRows.Count < 1)
            {
                MessageBox.Show("대분류 항목을 선택하여 주십시오.");
                return;
            }

            SetInitEditPnl();

            dgvMa.Enabled = dgvMi.Enabled = false;
            dgvMi.ClearSelection();
            txtInfoCodeMi.Enabled = txtInfoNameMi.Enabled = txtRemark.Enabled = cboUseYN.Enabled = nudSort.Enabled = true;
            cboUseYN.SelectedIndex = 0;

            int idx = dgvMa.CurrentRow.Index;
            ucSearch1._Code = dgvMa["Userdefine_Ma_Code", idx].Value.ToString();
            ucSearch1._Name = dgvMa["Userdefine_Ma_Name", idx].Value.ToString();

        }

        public void OnEdit()    //수정
        {
            if (dgvMi.SelectedRows.Count < 1)
            {
                MessageBox.Show("세부분류 항목을 선택하여 주십시오.");
                return;
            }

            dgvMa.Enabled = dgvMi.Enabled = false;
            txtInfoNameMi.Enabled = txtRemark.Enabled = cboUseYN.Enabled = nudSort.Enabled = true;
        }

        public void OnDelete()  //삭제
        {

        }

        public void OnSave()    //저장
        {
            if (string.IsNullOrWhiteSpace(txtInfoCodeMi.Text) || string.IsNullOrWhiteSpace(txtInfoNameMi.Text))
            {
                MessageBox.Show("필수항목을 입력해주세요.");
                return;
            }

            if (txtInfoCodeMi.Enabled) //신규 저장
            {
                int fidx = codeList.FindIndex((c) => c.Userdefine_Ma_Code == ucSearch1._Code && c.Userdefine_Mi_Code == txtInfoCodeMi.Text);
                if (fidx != -1)
                {
                    MessageBox.Show("상세분류코드가 중복되었습니다. 다시 입력하여 주십시오.");
                    return;
                }

                UserCodeDTO code = new UserCodeDTO
                {
                    Userdefine_Ma_Code = ucSearch1._Code,
                    Userdefine_Mi_Code = txtInfoCodeMi.Text,
                    Userdefine_Mi_Name = txtInfoNameMi.Text,
                    Sort_Index = (int)nudSort.Value,
                    Remark = txtRemark.Text,
                    Use_YN = (cboUseYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Ins_Emp = "" //수정필요
                };

                bool result = srv.InsertUserCode(code);
                if (result)
                {
                    MessageBox.Show("등록이 완료되었습니다.");
                    dgvMa.Enabled = dgvMi.Enabled = true;
                    dgvMi.DataSource = null;

                    SetInitEditPnl();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("등록 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }

            }
            else //수정 저장
            {
                UserCodeDTO code = new UserCodeDTO
                {
                    Userdefine_Ma_Code = ucSearch1._Code,
                    Userdefine_Mi_Code = txtInfoCodeMi.Text,
                    Userdefine_Mi_Name = txtInfoNameMi.Text,
                    Sort_Index = (int)nudSort.Value,
                    Remark = txtRemark.Text,
                    Use_YN = (cboUseYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Up_Emp = "" //수정필요
                };

                bool result = srv.UpdateUserCode(code);
                if (result)
                {
                    MessageBox.Show("수정이 완료되었습니다.");
                    dgvMa.Enabled = dgvMi.Enabled = true;
                    dgvMi.DataSource = null;

                    SetInitEditPnl();
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
            SetInitEditPnl();

            dgvMa.Enabled = dgvMi.Enabled = true;
            dgvMi.ClearSelection();
        }

        public void OnReLoad()  //새로고침
        {
            ucSearch1._Code = ucSearch1._Name = "";
            cboSearchUse.SelectedIndex = 0;

            dgvMi.DataSource = null;
            LoadData();
        }
        #endregion

        private void dgvMa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (!string.IsNullOrWhiteSpace(codeList[0].Userdefine_Mi_Code))
            {
                string code = dgvMa["Userdefine_Ma_Code", e.RowIndex].Value.ToString();
                List<UserCodeDTO> list = codeList.FindAll((c) => c.Userdefine_Ma_Code == code);
                dgvMi.DataSource = list;
                dgvMi.ClearSelection();
            }                
        }

        private void dgvMi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            ucSearch1._Code = dgvMi["Userdefine_Ma_Code", e.RowIndex].Value.ToString();
            ucSearch1._Name = dgvMi["Userdefine_Ma_Name", e.RowIndex].Value.ToString();
            txtInfoCodeMi.Text = dgvMi["Userdefine_Mi_Code", e.RowIndex].Value.ToString();
            txtInfoNameMi.Text = dgvMi["Userdefine_Mi_Name", e.RowIndex].Value.ToString();
            nudSort.Value = Convert.ToInt32(dgvMi["Sort_Index", e.RowIndex].Value);
            txtRemark.Text = dgvMi["Remark", e.RowIndex].Value.ToString();
            cboUseYN.SelectedItem = dgvMi["Use_YN", e.RowIndex].Value.ToString();
        }
    }
}
