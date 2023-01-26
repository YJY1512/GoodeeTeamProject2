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
using System.Linq;
using Team2_Project_DTO;
using Team2_Project.Controls;

namespace Team2_Project
{
    //메인폼에서 사용자 id 가져오기

    public partial class frmEmpManagement : frmListUpAreaDown
    {
        EmployeeService empSrv;
        string empId;
        DataTable dt;
        string[] use_YNSearchList = { "전체", "재직", "퇴직" };
        Dictionary<char, string> use_YNList = new Dictionary<char, string>(){{ 'Y', "재직" }, { 'N', "퇴직" }};
        Dictionary<char, string> AuthList = new Dictionary<char, string>() { { 'A', "관리자" }, { 'U', "일반" } };
        int pnlStat;
        int idx = -1;
        List<CodeDTO> userGroupCodeList;

        public frmEmpManagement()
        {
            InitializeComponent();
            empSrv = new EmployeeService();
            //int empid = ((frmMain)this.MdiParent).LoginEmpInfo.emp_id;
            empId = "1000";
        }

        private void frmEmpManagement_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            DataGridViewUtil.SetInitDataGridView(dgvEmp);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "사용자 ID", "User_ID", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "사용자 이름", "User_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "사용자 권한", "User_Type", 115);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "권한그룹코드", "UserGroup_Code", 115);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "권한그룹 명", "UserGroup_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "재직여부", "Use_YN", 150);

            dt = empSrv.GetEmployeeList();
            dgvEmp.DataSource = dt;
            dgvEmp.ClearSelection();

            cboSearchDel.Items.AddRange(use_YNSearchList);
            cboSearchDel.SelectedIndex = 0;
            cboDel.DataSource = new BindingSource(use_YNList, null);
            cboDel.DisplayMember = "Value";
            cboDel.ValueMember = "Key";

            cboAuth.DataSource = new BindingSource(AuthList, null);
            cboAuth.DisplayMember = "Value";
            cboAuth.ValueMember = "Key";

            pnlStat = 0;
            SetPannel(pnlArea, false);
        }

        private void SetPannel(Panel pnl, bool val)
        {
            foreach (Control ctrl in pnl.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox || ctrl is ucSearch)
                {
                    ctrl.Enabled = val;
                }
            }
        }

        private void ucSearchGroup_BtnClick(object sender, EventArgs e)
        {
            if (userGroupCodeList == null || userGroupCodeList.Count() < 1)
            {
                userGroupCodeList = empSrv.GetUserGroupCode();
            }

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("그룹코드", "Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("그룹명", "Name", 200));

            CommonPop<CodeDTO> popInfo = new CommonPop<CodeDTO>();
            popInfo.DgvDatasource = userGroupCodeList;
            popInfo.DgvCols = colList;
            popInfo.PopName = "그룹 검색";

            ucSearchGroup.OpenPop(popInfo);
        }

        private void ClearPnl()
        {
            foreach (Control item in pnlArea.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            ucSearchGroup._Code = "";
            ucSearchGroup._Name = "";

            cboDel.SelectedIndex = 0;
            cboAuth.SelectedIndex = 0;
        }

        public void OnAdd()
        {
            pnlStat = 1;
            ClearPnl();
            SetPannel(pnlArea, true);
            SetPannel(pnlSub, false);
            dgvEmp.ClearSelection();
            dgvEmp.Enabled = false;

            //저장, 취소 빼고 다 비활성화
        }

        public void OnEdit()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("수정할 인사정보를 선택해 주세요.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            pnlStat = 2;

            idx = dgvEmp.CurrentCell.RowIndex;
            SetPannel(pnlArea, true);
            txtID.Enabled = false;
            SetPannel(pnlSub, false);
            dgvEmp.Enabled = false;

            //저장, 취소 빼고 다 비활성화
        }

        public void OnDelete()
        {
            if (MessageBox.Show("선택한 인사정보를 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            string msg = empSrv.Delete(dgvEmp.SelectedRows[0].Cells["User_ID"].Value.ToString());
            if (string.IsNullOrWhiteSpace(msg))
            {
                MessageBox.Show("인사정보가 정상적으로 삭제되었습니다.");
                dt = empSrv.GetEmployeeList();
                dgvEmp.DataSource = dt;
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        public void OnSave()
        {
            int i = 0; //유효성 체크용

            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("사용자 ID는 필수 입력 항목입니다.");
                return;
            }

            else if (!int.TryParse(txtID.Text, out i))
            {
                MessageBox.Show("사용자 ID는 숫자만 사용할 수 있습니다.");
                return;
            }

            if (empSrv.CheckUserID(txtID.Text))
            {
                MessageBox.Show("이미 존재하는 사용자 ID 입니다.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("사용자 이름은 필수 입력 항목입니다.");
                return;
            }

            if (MessageBox.Show("입력한 정보를 저장하시겠습니까?", "저장확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            EmployeeDTO data = new EmployeeDTO
            {
                User_ID = txtID.Text,
                User_Name = txtName.Text,
                User_Type = Convert.ToChar(cboAuth.SelectedValue),
                UserGroup_Code = ucSearchGroup._Code,
                UserGroup_Name = ucSearchGroup._Name,
                Use_YN = Convert.ToChar(cboDel.SelectedValue)
            };

            if (pnlStat == 1)
            {
                bool result = empSrv.Insert(data, empId);
                if (result)
                {
                    MessageBox.Show("인사정보가 정상적으로 추가되었습니다.\n초기 비밀번호는 아이디와 동일합니다.");
                    dt = empSrv.GetEmployeeList();
                    dgvEmp.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("인사정보 추가에 실패하였습니다. 다시 시도하여 주세요.");
                }
            }
            else if (pnlStat == 2)
            {
                bool result = empSrv.Update(data, empId);
                if (result)
                {
                    MessageBox.Show("인사정보가 정상적으로 수정되었습니다.");
                    dt = empSrv.GetEmployeeList();
                    dgvEmp.DataSource = dt;
                    idx = -1;
                }
                else
                {
                    MessageBox.Show("인사정보 수정에 실패하였습니다. 다시 시도하여 주세요.");
                }

                pnlStat = 0;
                SetPannel(pnlArea, false);
                SetPannel(pnlSub, true);
                dgvEmp.Enabled = true;
            }
        }

        public void OnCancel()
        {
            if(MessageBox.Show("취소하시겠습니까?", "취소확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            pnlStat = 0;
            idx = -1;
            SetPannel(pnlArea, false);
            SetPannel(pnlSub, true);
            dgvEmp.Enabled = true;
        }

        public void OnReLoad()
        {
            txtSearchID.Text = txtSearchName.Text = "";
            cboSearchDel.SelectedIndex = 0;

            dt = empSrv.GetEmployeeList();
            dgvEmp.DataSource = null;
            dgvEmp.DataSource = dt;

            ClearPnl();
        }

        public void OnSearch()
        {
            DataTable temp = dt;
            if (!string.IsNullOrWhiteSpace(txtSearchID.Text))
                temp = Filtering(temp, "User_ID", txtSearchID.Text);
            if (temp != null && !string.IsNullOrWhiteSpace(txtSearchName.Text))
                temp = Filtering(temp, "User_Name", txtSearchName.Text);
            if (temp != null && cboSearchDel.Text != "전체")
                temp = Filtering(temp, "Use_YN", cboSearchDel.Text);

            dgvEmp.DataSource = null;
            dgvEmp.DataSource = temp;

            ClearPnl();
        }

        private DataTable Filtering(DataTable dt, string col, string str)
        {
            IEnumerable<DataRow> SortTable = null;

            SortTable = from row in dt.AsEnumerable()
                        where row.Field<string>(col).Contains(str)
                        select row;
            if (SortTable.Count() < 1)
                return null;

            return SortTable.CopyToDataTable();
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            txtID.Text = dgvEmp["User_ID", e.RowIndex].Value.ToString();
            txtName.Text = dgvEmp["User_Name", e.RowIndex].Value.ToString();
            ucSearchGroup._Code = dgvEmp["UserGroup_Code", e.RowIndex].Value.ToString();
            ucSearchGroup._Name = dgvEmp["UserGroup_Name", e.RowIndex].Value.ToString();
            cboDel.Text = dgvEmp["Use_YN", e.RowIndex].Value.ToString();
            cboAuth.Text = dgvEmp["User_Type", e.RowIndex].Value.ToString();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                MessageBox.Show("사용자 ID는 숫자만 사용할 수 있습니다.");
                e.Handled = true;
            }
        }
    }
}
