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

namespace Team2_Project
{
    public partial class frmEmpManagement : frmListUpAreaDown
    {
        EmployeeService empSrv;
        DataTable dt;
        int pnlStat;
        string[] use_YNSearchList = { "전체", "재직", "퇴직" };
        //char[] use_YNCodeList = { 'Y', 'N' };
        Dictionary<char, string> use_YNList = new Dictionary<char, string>(){{ 'Y', "재직" }, { 'N', "퇴직" }};
        //string[] AuthList = { "관리자", "일반" };
        //char[] AuthCodeList = { 'A', 'U' };
        Dictionary<char, string> AuthList = new Dictionary<char, string>() { { 'A', "관리자" }, { 'U', "일반" } };

        public frmEmpManagement()
        {
            InitializeComponent();
            empSrv = new EmployeeService();
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

            cboSearchDel.Items.AddRange(use_YNSearchList);
            cboSearchDel.SelectedIndex = 0;
            cboDel.DataSource = new BindingSource(use_YNList, null);
            cboDel.DisplayMember = "Value";
            cboDel.ValueMember = "Key";
            cboDel.Enabled = false;

            cboAuth.DataSource = new BindingSource(AuthList, null);
            cboAuth.DisplayMember = "Value";
            cboAuth.ValueMember = "Key";
            cboAuth.Enabled = false;

            pnlStat = 0;
        }

        private void ucSearchDept_BtnClick(object sender, EventArgs e)
        {

        }

        private void ucSearchGroup_BtnClick(object sender, EventArgs e)
        {

        }

        private void ClearPnl()
        {
            foreach (TextBox item in pnlArea.Controls)
            {
                item.Text = "";
            }

            ucSearchGroup._Code = "";
            ucSearchGroup._Name = "";

            cboDel.SelectedIndex = 0;
            cboAuth.SelectedIndex = 0;
        }

        private void CboEnable(bool val)
        {
            cboDel.Enabled = val;
            cboAuth.Enabled = val;
        }

        private void Insert()
        {
            pnlStat = 1;
            ClearPnl();
            CboEnable(true);

            //저장, 취소 빼고 다 비활성화
        }

        private void _Update()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("수정할 인사정보를 선택해 주세요.");
                return;
            }
               
            pnlStat = 2;
            txtID.Enabled = false;
            CboEnable(true);

            //저장, 취소 빼고 다 비활성화
        }

        private void Delete()
        {
            if (MessageBox.Show("선택한 인사정보를 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            bool result = empSrv.Delete(dgvEmp.SelectedRows[0].Cells["User_ID"].Value.ToString());
            if (result)
            {
                MessageBox.Show("인사정보가 정상적으로 삭제되었습니다.");
                dt = empSrv.GetEmployeeList();
                dgvEmp.DataSource = dt;
            }
            else
            {
                MessageBox.Show("인사정보 삭제에 실패하였습니다. 다시 시도하여 주세요.");
            }
        }

        private void Save()
        {
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
                bool result = empSrv.Insert(data, "1000");
                if (result)
                {
                    MessageBox.Show("인사정보가 정상적으로 추가되었습니다.\n초기 비밀번호는 아이디와 동일합니다.");
                    dt = empSrv.GetEmployeeList();
                    dgvEmp.DataSource = dt;

                    pnlStat = 0;
                    CboEnable(false);
                }
                else
                {
                    MessageBox.Show("인사정보 추가에 실패하였습니다. 다시 시도하여 주세요.");
                }
            }
            else if (pnlStat == 2)
            {
                bool result = empSrv.Update(data, "1000");
                if (result)
                {
                    MessageBox.Show("인사정보가 정상적으로 수정되었습니다.");
                    dt = empSrv.GetEmployeeList();
                    dgvEmp.DataSource = dt;

                    pnlStat = 0;
                    CboEnable(false);
                }
                else
                {
                    MessageBox.Show("인사정보 수정에 실패하였습니다. 다시 시도하여 주세요.");
                }
            }
        }

        private void Cancel()
        {
            if(MessageBox.Show("취소하시겠습니까?", "취소확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            pnlStat = 0;
            CboEnable(false);
        }

        private void Search()
        {
            DataTable temp = dt;
            if (!string.IsNullOrWhiteSpace(txtSearchID.Text))
            {
                temp = Filtering(temp, "User_ID", txtSearchID.Text);
            }
            if (temp != null && !string.IsNullOrWhiteSpace(txtSearchName.Text))
            {
                temp = Filtering(temp, "User_Name", txtSearchName.Text);
            }
            if (temp != null && cboSearchDel.Text != "전체")
            {
                temp = Filtering(temp, "Use_YN", cboSearchDel.Text);
            }

            dgvEmp.DataSource = null;
            dgvEmp.DataSource = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search();
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

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (pnlStat == 0)
                e.Handled = true;
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pnlStat != 0)
                return;

            txtID.Text = dgvEmp.SelectedRows[0].Cells["User_ID"].Value.ToString();
            txtName.Text = dgvEmp.SelectedRows[0].Cells["User_Name"].Value.ToString();
            ucSearchGroup._Code = dgvEmp.SelectedRows[0].Cells["UserGroup_Code"].Value.ToString();
            ucSearchGroup._Name = dgvEmp.SelectedRows[0].Cells["UserGroup_Name"].Value.ToString();
            cboDel.Text = dgvEmp.SelectedRows[0].Cells["Use_YN"].Value.ToString();
            cboAuth.Text = dgvEmp.SelectedRows[0].Cells["User_Type"].Value.ToString();
        }
    }
}
