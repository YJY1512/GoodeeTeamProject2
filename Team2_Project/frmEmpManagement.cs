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
        //Dictionary를 Combobox에 바인딩
        Dictionary<char, string> use_YNList = new Dictionary<char, string>(){{ 'Y', "재직" }, { 'N', "퇴직" }};
        //Dictionary<char, string> AuthList = new Dictionary<char, string>() { { 'A', "관리자" }, { 'U', "일반" } };
        int pnlStat;
        int idx;
        List<CodeDTO> userGroupCodeList;

        public frmEmpManagement()
        {
            InitializeComponent();
            empSrv = new EmployeeService();
        }

        private void frmEmpManagement_Load(object sender, EventArgs e)
        {
            idx = pnlStat = 0;
            DataGridViewUtil.SetInitDataGridView(dgvEmp);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "사용자 ID", "User_ID", 180);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "사용자 이름", "User_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "사용자그룹 코드", "UserGroup_Code", 180);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "사용자그룹 명", "UserGroup_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "재직여부", "Use_YN", 120, align: DataGridViewContentAlignment.MiddleCenter);
            dgvEmp.MultiSelect = false;

            dt = empSrv.GetEmployeeList();
            dgvEmp.DataSource = dt;
            dgvEmp_CellClick(dgvEmp, new DataGridViewCellEventArgs(0, 0));

            cboSearchDel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSearchDel.Items.AddRange(use_YNSearchList);
            cboSearchDel.SelectedIndex = 0;
            cboDel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDel.DataSource = new BindingSource(use_YNList, null);
            cboDel.DisplayMember = "Value";
            cboDel.ValueMember = "Key";

            //cboAuth.DropDownStyle = ComboBoxStyle.DropDownList;
            //cboAuth.DataSource = new BindingSource(AuthList, null);
            //cboAuth.DisplayMember = "Value";
            //cboAuth.ValueMember = "Key";

            txtID.KeyPress += txtID_KeyPress;

            SetPannel(pnlArea, false);

            empId = ((frmMain)this.MdiParent).LoginEmp.User_ID;
        }

        /// <summary>
        /// 패널을 활성화/비활성화 한다
        /// </summary>
        /// <param name="pnl">활성화/비활성화 하고자 하는 패널</param>
        /// <param name="val">활성화 시키려면 true, 비활성화 시키려면 false를 전달</param>
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

        /// <summary>
        /// 입력정보 패널을 초기화한다.
        /// </summary>
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
            //cboAuth.SelectedIndex = 0;
        }

        public void OnAdd()
        {
            pnlStat = 1;
            ClearPnl();
            SetPannel(pnlArea, true);
            SetPannel(pnlSub, false);
            dgvEmp.ClearSelection();
            dgvEmp.Enabled = false;
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
        }

        public void OnDelete()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("삭제할 인사정보를 선택해 주세요.");
                return;
            }

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

                dgvEmp_CellClick(dgvEmp, new DataGridViewCellEventArgs(0, 0));
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        public void OnSave()
        {
            int i = 0; //유효성 체크용

            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                    throw new Exception("사용자 ID는 필수 입력 항목입니다.");
                if (!int.TryParse(txtID.Text, out i))
                    throw new Exception("사용자 ID는 숫자만 사용할 수 있습니다.");
                if (string.IsNullOrWhiteSpace(txtName.Text))
                    throw new Exception("사용자 이름은 필수 입력 항목입니다.");
                if(string.IsNullOrWhiteSpace(ucSearchGroup._Code))
                    throw new Exception("권한 그룹은 필수 입력 항목입니다.");
                if (pnlStat == 1 && empSrv.CheckUserID(txtID.Text))
                    throw new Exception("이미 존재하는 사용자 ID 입니다.");

                if (MessageBox.Show("입력한 정보를 저장하시겠습니까?", "저장확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    throw new Exception("");
                }

                EmployeeDTO data = new EmployeeDTO
                {
                    User_ID = txtID.Text,
                    User_Name = txtName.Text,
                    //User_Type = cboAuth.SelectedValue.ToString(),
                    UserGroup_Code = ucSearchGroup._Code,
                    UserGroup_Name = ucSearchGroup._Name,
                    Use_YN = cboDel.SelectedValue.ToString(),
                };

                if (pnlStat == 1)
                {
                    bool result = empSrv.Insert(data, empId);
                    if (result)
                    {
                        MessageBox.Show("인사정보가 정상적으로 추가되었습니다.\n초기 비밀번호는 아이디와 동일합니다.");
                        dt = empSrv.GetEmployeeList();
                        dgvEmp.DataSource = dt;

                        pnlStat = 0;
                        SetPannel(pnlArea, false);
                        SetPannel(pnlSub, true);
                        dgvEmp.Enabled = true;
                    }
                    else
                        throw new Exception("인사정보 추가에 실패하였습니다. 다시 시도하여 주세요.");
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

                        pnlStat = 0;
                        SetPannel(pnlArea, false);
                        SetPannel(pnlSub, true);
                        dgvEmp.Enabled = true;
                    }
                    else
                        throw new Exception("인사정보 수정에 실패하였습니다. 다시 시도하여 주세요.");
                }
            }
            catch(Exception err)
            {
                if (!string.IsNullOrWhiteSpace(err.Message))
                    MessageBox.Show(err.Message);

                if (pnlStat == 1)
                    ((frmMain)this.MdiParent).AddClickEvent();
                else if (pnlStat == 2)
                    ((frmMain)this.MdiParent).EditClickEvent();
            }
        }

        public void OnCancel()
        {
            if(MessageBox.Show("취소하시겠습니까?", "취소확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                if (pnlStat == 1)
                    ((frmMain)this.MdiParent).AddClickEvent();
                else if(pnlStat == 2)
                    ((frmMain)this.MdiParent).EditClickEvent();

                return;
            }

            pnlStat = 0;
            idx = -1;
            SetPannel(pnlArea, false);
            SetPannel(pnlSub, true);
            dgvEmp.Enabled = true;

            txtSearchID.Text = txtSearchName.Text = "";
            cboSearchDel.SelectedIndex = 0;
            dgvEmp_CellClick(dgvEmp, new DataGridViewCellEventArgs(0, 0));
        }

        public void OnReLoad()
        {
            txtSearchID.Text = txtSearchName.Text = "";
            cboSearchDel.SelectedIndex = 0;

            dt = empSrv.GetEmployeeList();
            dgvEmp.DataSource = null;
            dgvEmp.DataSource = dt;

            dgvEmp_CellClick(dgvEmp, new DataGridViewCellEventArgs(0, 0));
        }

        /// <summary>
        /// Filtering 메서드를 통해 전체 DataTable로부터 
        /// 검색조건에 맞는 데이터만 가져온 새로운 DataTable을 DGV에 바인딩한다.
        /// </summary>
        public void OnSearch()
        {
            idx = -1;
            ClearPnl();
            dgvEmp.ClearSelection();

            DataTable temp = dt;
            if (!string.IsNullOrWhiteSpace(txtSearchID.Text))
                temp = Filtering(temp, "User_ID", txtSearchID.Text);
            if (temp != null && !string.IsNullOrWhiteSpace(txtSearchName.Text))
                temp = Filtering(temp, "User_Name", txtSearchName.Text);
            if (temp != null && cboSearchDel.Text != "전체")
                temp = Filtering(temp, "Use_YN", cboSearchDel.Text);

            dgvEmp.DataSource = null;
            dgvEmp.DataSource = temp;

            //dgvEmp_CellClick(dgvEmp, new DataGridViewCellEventArgs(0, 0));
        }

        /// <summary>
        /// Linq를 통해 DataTable에서 검색조건에 맞는 데이터만 추출한
        /// 새로운 DataTable을 return한다.
        /// </summary>
        /// <param name="dt">원본 DataTable</param>
        /// <param name="col">검색조건을 적용할 DataTable의 열</param>
        /// <param name="str">검색조건</param>
        /// <returns></returns>
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

            try
            {
                txtID.Text = dgvEmp["User_ID", e.RowIndex].Value.ToString();
                txtName.Text = dgvEmp["User_Name", e.RowIndex].Value.ToString();
                ucSearchGroup._Code = dgvEmp["UserGroup_Code", e.RowIndex].Value.ToString();
                ucSearchGroup._Name = dgvEmp["UserGroup_Name", e.RowIndex].Value.ToString();
                cboDel.Text = dgvEmp["Use_YN", e.RowIndex].Value.ToString();
                //cboAuth.Text = dgvEmp["User_Type", e.RowIndex].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == 13))
            {
                MessageBox.Show("사용자 ID는 숫자만 사용할 수 있습니다.");
                e.Handled = true;
            }
        }

        private void txtID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }

        private void cboSearchDel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                OnSearch();
        }

        private void cboDel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                OnSave();
        }
    }
}
