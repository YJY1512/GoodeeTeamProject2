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
    public partial class frmOrder : frmList
    {
        OrderService ordSrv;
        DataTable dt;
        List<ItemDTO> itemCodeList;
        List<ProjectDTO> projectCodeList;
        int pnlStat;
        int idx = -1;
        List<CodeDTO> userGroupCodeList;

        public frmOrder()
        {
            InitializeComponent();
            ordSrv = new OrderService();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvOrder);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "생산요청코드", "Prd_Req_No", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "순번", "Req_Seq", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "거래처명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "프로젝트코드", "Prj_No", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "프로젝트명", "Prj_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "요청일자", "Req_Date", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "납기일자", "Delivery_Date", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "품목코드", "Item_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "품목명", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "수량", "Req_Qty", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "비고", "Remark", 200);

            ResetDtp();

            dt = ordSrv.GetOrderList(GetSearchValues());
            dgvOrder.DataSource = dt;
        }

        private void ResetDtp()
        {
            dtpSearchOrd1.Value = DateTime.Today.AddDays(-7);
            dtpSearchOrd2.Value = DateTime.Today;
            dtpSearchDue1.Value = DateTime.Today.AddMonths(-1);
            dtpSearchDue2.Value = DateTime.Today.AddMonths(1);
        }

        private string[] GetSearchValues()
        {
            return new string[] { dtpSearchOrd1.Value.ToString("yyyy-MM-dd"), dtpSearchOrd1.Value.ToString("yyyy-MM-dd"), 
                    dtpSearchDue1.Value.ToString("yyyy-MM-dd"), dtpSearchDue1.Value.ToString("yyyy-MM-dd"),
                    ucSearchItem._Code, ucSearchItem._Code};
        }

        public void OnSearch()
        {
            //DataTable temp = dt;
            //if (!string.IsNullOrWhiteSpace(ucSearchItem._Name))
            //    temp = Filtering(temp, "Item_Code", ucSearchItem._Code);
            //if (temp != null && !string.IsNullOrWhiteSpace(ucSearchItem.Text))
            //    temp = Filtering(temp, "Prj_No", ucSearchProject._Code);

            //dgvOrder.DataSource = null;
            //dgvOrder.DataSource = temp;
        }

        //public void OnAdd()
        //{
        //    pnlStat = 1;
        //    ClearPnl();
        //    CboEnable(true);

        //    //저장, 취소 빼고 다 비활성화
        //}

        //public void OnEdit()
        //{
        //    if (string.IsNullOrWhiteSpace(txtID.Text))
        //    {
        //        MessageBox.Show("수정할 인사정보를 선택해 주세요.");
        //        return;
        //    }


        //    pnlStat = 2;
        //    idx = dgvEmp.CurrentCell.RowIndex;
        //    txtID.Enabled = false;
        //    CboEnable(true);

        //    //저장, 취소 빼고 다 비활성화
        //}



        //public void OnDelete() //다른 테이블에서 사용한다면 삭제 불가능
        //{
        //    if (MessageBox.Show("선택한 인사정보를 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
        //    {
        //        return;
        //    }

        //    bool result = empSrv.Delete(dgvEmp.SelectedRows[0].Cells["User_ID"].Value.ToString());
        //    if (result)
        //    {
        //        MessageBox.Show("인사정보가 정상적으로 삭제되었습니다.");
        //        dt = empSrv.GetEmployeeList();
        //        dgvEmp.DataSource = dt;
        //    }
        //    else
        //    {
        //        MessageBox.Show("인사정보 삭제에 실패하였습니다. 다시 시도하여 주세요.");
        //    }
        //}

        //public void OnSave()
        //{
        //    if (MessageBox.Show("입력한 정보를 저장하시겠습니까?", "저장확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
        //    {
        //        return;
        //    }

        //    EmployeeDTO data = new EmployeeDTO
        //    {
        //        User_ID = txtID.Text,
        //        User_Name = txtName.Text,
        //        User_Type = Convert.ToChar(cboAuth.SelectedValue),
        //        UserGroup_Code = ucSearchGroup._Code,
        //        UserGroup_Name = ucSearchGroup._Name,
        //        Use_YN = Convert.ToChar(cboDel.SelectedValue)
        //    };

        //    if (pnlStat == 1)
        //    {
        //        bool result = empSrv.Insert(data, "1000");
        //        if (result)
        //        {
        //            MessageBox.Show("인사정보가 정상적으로 추가되었습니다.\n초기 비밀번호는 아이디와 동일합니다.");
        //            dt = empSrv.GetEmployeeList();
        //            dgvEmp.DataSource = dt;

        //            pnlStat = 0;

        //            CboEnable(false);
        //        }
        //        else
        //        {
        //            MessageBox.Show("인사정보 추가에 실패하였습니다. 다시 시도하여 주세요.");
        //        }
        //    }
        //    else if (pnlStat == 2)
        //    {
        //        bool result = empSrv.Update(data, "1000");
        //        if (result)
        //        {
        //            MessageBox.Show("인사정보가 정상적으로 수정되었습니다.");
        //            dt = empSrv.GetEmployeeList();
        //            dgvEmp.DataSource = dt;

        //            pnlStat = 0;
        //            idx = -1;
        //            txtID.Enabled = true;
        //            CboEnable(false);
        //        }
        //        else
        //        {
        //            MessageBox.Show("인사정보 수정에 실패하였습니다. 다시 시도하여 주세요.");
        //        }
        //    }
        //}

        //public void OnCancel()
        //{
        //    if (MessageBox.Show("취소하시겠습니까?", "취소확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
        //    {
        //        return;
        //    }

        //    pnlStat = 0;
        //    idx = -1;
        //    txtID.Enabled = true;
        //    CboEnable(false);
        //}

        //public void OnReLoad()
        //{
        //    txtSearchID.Text = txtSearchName.Text = "";
        //    cboSearchDel.SelectedIndex = 0;

        //    dt = empSrv.GetEmployeeList();
        //    dgvEmp.DataSource = null;
        //    dgvEmp.DataSource = dt;
        //}

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

        private void ucSearchItem_BtnClick(object sender, EventArgs e)
        {
            if (itemCodeList == null || itemCodeList.Count() < 1)
            {
                itemCodeList = ordSrv.GetItemCodeName();
            }

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목코드", "Item_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목명", "Item_Name", 200));

            CommonPop<ItemDTO> popInfo = new CommonPop<ItemDTO>();
            popInfo.DgvDatasource = itemCodeList;
            popInfo.DgvCols = colList;
            popInfo.PopName = "품목 검색";

            ucSearchItem.OpenPop(popInfo);
        }

        private void ucSearchProject_BtnClick(object sender, EventArgs e)
        {
            if (projectCodeList == null || projectCodeList.Count() < 1)
            {
                projectCodeList = ordSrv.GetProjectList();
            }

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("프로젝트코드", "Item_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("프로젝트명", "Item_Name", 200));

            CommonPop<ProjectDTO> popInfo = new CommonPop<ProjectDTO>();
            popInfo.DgvDatasource = projectCodeList;
            popInfo.DgvCols = colList;
            popInfo.PopName = "프로젝트 검색";

            ucSearchItem.OpenPop(popInfo);
        }
    }
}
