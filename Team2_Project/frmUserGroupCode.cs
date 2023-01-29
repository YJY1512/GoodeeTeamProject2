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
        string clickState = "";
        string empID;
        public frmUserGroupCode()
        {
            InitializeComponent();
        }

        private void frmUserGroupCode_Load(object sender, EventArgs e)
        {
            empID = ((frmMain)this.MdiParent).LoginEmp.User_ID;

            DataGridViewUtil.SetInitDataGridView(dgvGroup);
            DataGridViewUtil.AddGridTextBoxColumn(dgvGroup, "사용자 그룹 코드", "UserGroup_Code", 250);
            DataGridViewUtil.AddGridTextBoxColumn(dgvGroup, "사용자 그룹명", "UserGroup_Name", 250);
            DataGridViewUtil.AddGridTextBoxColumn(dgvGroup, "Admin 여부", "Admin", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvGroup, "사용 여부", "Use_YN", 150);
            dgvGroup.MultiSelect = false;

            CommonCodeUtil.UseYNComboBinding(cboUseYN1);
            cboUseYN1.SelectedIndex = 0;
            CommonCodeUtil.UseYNComboBinding(cboAdUseYN2, false);
            CommonCodeUtil.UseYNComboBinding(cboUseYN2, false);

            SetInitEditPnl();
            LoadData();
        }

        private void LoadData()
        {
            codeList = srv.GetUserGroupCodeSearh();
            BindingSource gc = new BindingSource(new AdvancedList<UserGroupAuthorityDTO>(codeList), null);
            dgvGroup.DataSource = null;
            dgvGroup.DataSource = gc;
            dgvGroup.ClearSelection();
        }
        #region 패널 이벤트
        private void SetSearchPnl()  //검색 패널 값 clear 및 잠금
        {
            foreach (Control ctrl in pnlSub.Controls)
            {
                if (ctrl is Label || ctrl is Panel)
                    continue;

                if (ctrl is TextBox)
                    ctrl.Text = "";

                ctrl.Enabled = false;
            }
            cboUseYN1.SelectedIndex = -1;
        }
        private void OpenSearchPnl()    //검색 패널 Clear 및 잠금해제
        {
            txtGroupNM1.Text = "";
            txtGroupNM1.Enabled = cboUseYN1.Enabled = true;
            cboUseYN1.SelectedIndex = 0;
        }
        private void SetInitEditPnl()  //폼 하단 패널 정보 값 clear 및 잠금 //폼 하단 패널 잠금해제 
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
        private void OpenInitEditPnl()  //폼 하단 패널 Clear 잠금해제 
        {
            if (clickState == "Add")    //클릭 상태가 추가일때 PK text 잠금해제 및 clear
            {
                txtGroupCode2.Text = txtGroupNM2.Text = "";
                txtGroupCode2.Enabled = txtGroupNM2.Enabled = cboAdUseYN2.Enabled = cboUseYN2.Enabled = true;
                cboAdUseYN2.SelectedIndex = cboUseYN2.SelectedIndex = 0;
            }
            else if (clickState == "Edit")
            {
                txtGroupNM2.Enabled = cboAdUseYN2.Enabled = cboUseYN2.Enabled = true;
                cboAdUseYN2.SelectedIndex = cboUseYN2.SelectedIndex = 0;
            }
        }
        #endregion

        #region 
        public void OnSearch()  //검색
        {
            string grpNM = txtGroupNM1.Text;
            string useYN = (cboUseYN1.SelectedItem.ToString() == "전체") ? "" : cboUseYN1.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(grpNM) || string.IsNullOrWhiteSpace(useYN))   //공백일때
            {
                dgvGroup.DataSource = null;
                dgvGroup.DataSource = codeList;
                return;
            }

            var list = (from grp in codeList
                        where grp.UserGroup_Name.Contains(grpNM) && grp.Use_YN.Contains(useYN)
                        select grp).ToList();
            BindingSource gc = new BindingSource(new AdvancedList<UserGroupAuthorityDTO>(codeList), null);
            dgvGroup.DataSource = gc;
        }
        public void OnAdd()     //추가
        {
            clickState = "Add";         //click상태 add
            SetSearchPnl();             //검색패널 잠금
            dgvGroup.Enabled = false;   //datagridview 잠금
            dgvGroup.ClearSelection();  //dgv 선택 초기화
            OpenInitEditPnl();          //하단 패널 clear및 open
        }
        public void OnEdit()    //수정
        {
            if (dgvGroup.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 항목을 선택하여 주세요.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }
            clickState = "Edit";        //click 상태 edit
            SetSearchPnl();             //검색패널 잠금
            dgvGroup.Enabled = false;   //datagridview 잠금
            OpenInitEditPnl();          //하단 패널 clear및 open
        }
        public void OnDelete()  //삭제
        {
            if (dgvGroup.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 항목을 선택하여 주세요.");
                return;
            }

            dgvGroup.Enabled = false;

            if (MessageBox.Show($"{txtGroupNM2.Text}를 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int result = srv.DeleteUserGroup(txtGroupCode2.Text);

                if (result == 0)
                {
                    MessageBox.Show("삭제에 성공하였습니다.");
                }
                else if (result == 3726)
                {
                    MessageBox.Show("데이터를 삭제할 수 없습니다.");
                }
                else
                {
                    MessageBox.Show("삭제 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
                OnReLoad();
            }
            dgvGroup.Enabled = true;
        }
        public void OnSave()    //저장
        {
            if (string.IsNullOrWhiteSpace(txtGroupCode2.Text) ||
                string.IsNullOrWhiteSpace(txtGroupNM2.Text) ||
                cboAdUseYN2.SelectedIndex == 0 ||
                cboUseYN2.SelectedIndex == 0)
            {
                MessageBox.Show("필수 항목을 입력해주시기 바랍니다.");
                return;
            }

            if (clickState == "Add")
            {
                bool result = srv.FindSamePK(txtGroupCode2.Text);
                if (!result)
                {
                    MessageBox.Show("사용자그룹 코드가 중복되었습니다. 다시 시도하여 주세요.");
                    return;
                }
                UserGroupAuthorityDTO group = new UserGroupAuthorityDTO
                {
                    UserGroup_Code = txtGroupCode2.Text,
                    UserGroup_Name = txtGroupNM2.Text,
                    Admin = (cboAdUseYN2.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Use_YN = (cboUseYN2.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Ins_Emp = empID
                };

                result = srv.InsertUserGroup(group);
                if (result)
                {
                    MessageBox.Show("등록이 완료되었습니다.");                   
                }
                else
                {
                    MessageBox.Show("등록 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }
            else if (clickState == "Edit")
            {
                UserGroupAuthorityDTO group = new UserGroupAuthorityDTO
                {
                    UserGroup_Code = txtGroupCode2.Text,
                    UserGroup_Name = txtGroupNM2.Text,
                    Admin = (cboAdUseYN2.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Use_YN = (cboUseYN2.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Ins_Emp = empID
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
            clickState = "";    //클릭상태 초기화
            SetInitEditPnl();   //하단 패널 clear및 잠금
            OpenSearchPnl();    //검색 패널 clear및 잠금해제
            dgvGroup.Enabled = true; //dgv 잠금해제
            LoadData();             //데이터 로드
        }
        public void OnCancel()  //취소
        {
            clickState = "";    //클릭상태 초기화
            SetInitEditPnl();   //하단 패널 잠금
            OpenSearchPnl();    //검색 패널 clear및 잠금해제
            dgvGroup.Enabled = true; //dgv 잠금해제
            LoadData();             //데이터 로드
        }
        public void OnReLoad()  //새로고침
        {
            OpenSearchPnl(); //검색 패널 clear및 잠금해제
            SetInitEditPnl();//하단 패널 잠금
            LoadData();      //데이터 로드
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
