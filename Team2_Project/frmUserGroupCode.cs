using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmUserGroupCode : frmListUpAreaDown
    {
        UserGroupAuthorityService srv = new UserGroupAuthorityService();
        List<UserGroupAuthorityDTO> codeList;
        public frmUserGroupCode()
        {
            InitializeComponent();
        }

        private void frmUserGroupCode_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvGroup);
            DataGridViewUtil.AddGridTextBoxColumn(dgvGroup, "사용자 그룹 코드", "UserGroup_Code",250);
            DataGridViewUtil.AddGridTextBoxColumn(dgvGroup, "사용자 그룹명", "UserGroup_Name",250);
            DataGridViewUtil.AddGridTextBoxColumn(dgvGroup, "Admin 여부", "Admin",150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvGroup, "사용 여부", "Use_YN",150);

            CommonCodeUtil.UseYNComboBinding(cboUseYN1);
            CommonCodeUtil.UseAdminComboBinding(cboAdUseYN2, false);
            CommonCodeUtil.UseYNComboBinding(cboUseYN2, false);
            cboUseYN1.SelectedIndex = 0;

            SetInitEditPnl();
            codeList = srv.GetUserGroupCodeSearh();
            dgvGroup.DataSource = codeList;
        }
        private void SetInitEditPnl()
        {
            foreach (Control ctrl in pnlArea.Controls)
            {
                if (ctrl is Label || ctrl is Panel)
                    continue;

                if (ctrl is TextBox)
                    ctrl.Text = "";

                ctrl.Enabled = false;
            }

            cboAdUseYN2.SelectedIndex = -1; 
            cboUseYN2.SelectedIndex = -1;
        }

        #region 
        public void OnSearch()  //검색
        {
            string grpNM = txtGroupNM1.Text.Trim();
            string useYN = (cboUseYN1.SelectedItem.ToString() == "전체") ? "" : cboUseYN1.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(grpNM) && string.IsNullOrWhiteSpace(useYN))   //공백일때
            {
                dgvGroup.DataSource = null;
                dgvGroup.DataSource = codeList;
                return;
            }

            var list = (from grp in codeList
                        where grp.UserGroup_Name.Contains(grpNM) && grp.Use_YN.Contains(useYN)
                        select grp).ToList();

            dgvGroup.DataSource = null;
            dgvGroup.DataSource = codeList;
        }
        public void OnAdd()     //추가
        {
            SetInitEditPnl();
            dgvGroup.Enabled = false;
            dgvGroup.ClearSelection();
            txtGroupCode2.Enabled = txtGroupNM2.Enabled = cboAdUseYN2.Enabled = cboUseYN2.Enabled = true;
            cboAdUseYN2.SelectedIndex = cboUseYN2.SelectedIndex = 0;
        }
        public void OnEdit()    //수정
        {
            if (dgvGroup.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 항목을 선택하여 주세요.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }
            dgvGroup.Enabled = false;
            txtGroupNM2.Enabled = cboAdUseYN2.Enabled = cboUseYN2.Enabled = true;
        }
        public void OnDelete()  //삭제
        {
            if (dgvGroup.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 항목을 선택하여 주세요.");
                return;
            }
        }
        public void OnSave()    //저장
        {
            if (string.IsNullOrWhiteSpace(txtGroupCode2.Text) || string.IsNullOrWhiteSpace(txtGroupNM2.Text))
            {
                MessageBox.Show("필수 항목을 입력해주시기 바랍니다.");
                return;
            }

            if (txtGroupCode2.Enabled)
            {
                int idx = codeList.FindIndex((m) => m.UserGroup_Code == txtGroupCode2.Text);
                if (idx != -1)
                {
                    MessageBox.Show("사용자그룹 코드가 중복되었습니다. 다시시도하여 주세요.");
                    return;
                }
                UserGroupAuthorityDTO group = new UserGroupAuthorityDTO
                {
                    UserGroup_Code = txtGroupCode2.Text,
                    UserGroup_Name = txtGroupNM2.Text,
                    Admin = (cboAdUseYN2.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Use_YN = (cboUseYN2.SelectedItem.ToString() == "예") ? "Y" : "N",
                    //Ins_Emp = 
                };

                bool result = srv.InsertUserGroup(group);
                if (result)
                {
                    MessageBox.Show("등록이 완료되었습니다.");                   
                    dgvGroup.Enabled = true;
                    dgvGroup.DataSource = null;
                    SetInitEditPnl();                 
                    dgvGroup.DataSource = codeList;
                }
                else
                {
                    MessageBox.Show("등록 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }
            else
            {
                UserGroupAuthorityDTO group = new UserGroupAuthorityDTO
                {
                    UserGroup_Code = txtGroupCode2.Text,
                    UserGroup_Name = txtGroupNM2.Text,
                    Admin = (cboAdUseYN2.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Use_YN = (cboUseYN2.SelectedItem.ToString() == "예") ? "Y" : "N",
                    //Ins_Emp = 
                };

                bool result = srv.UpdateUserGroup(group);
                if (result)
                {
                    MessageBox.Show("수정이 완료되었습니다.");
                    dgvGroup.Enabled = true;
                    dgvGroup.DataSource = null;
                    SetInitEditPnl();
                    dgvGroup.DataSource = codeList;
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
            dgvGroup.Enabled = true;
            dgvGroup.ClearSelection();
        }
        public void OnReLoad()  //새로고침
        {
            txtGroupNM1.Text = "";
            cboUseYN1.SelectedIndex = 0;

            SetInitEditPnl();
            dgvGroup.DataSource = null;
            dgvGroup.DataSource = codeList;
        }

        #endregion

        private void dgvGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            txtGroupCode2.Text = dgvGroup["UserGroup_Code", e.RowIndex].Value.ToString();
            txtGroupNM2.Text = dgvGroup["UserGroup_Name", e.RowIndex].Value.ToString();
            cboAdUseYN2.SelectedItem = dgvGroup["Admin", e.RowIndex].Value.ToString();
            cboUseYN2.SelectedItem = dgvGroup["Use_YN", e.RowIndex].Value.ToString();
        }
    }
}
