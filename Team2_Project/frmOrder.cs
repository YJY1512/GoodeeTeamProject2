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
        int idx = -1;
        int stat = 0;
        int[] orangeCols = new int[] { 2, 6, 7, 9, 10 };

        public frmOrder()
        {
            InitializeComponent();
            ordSrv = new OrderService();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvOrder);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "생산요청코드", "Prd_Req_No", 200, frosen:true); //0
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "순번", "Req_Seq", 200, frosen: true); //1
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "프로젝트코드", "Prj_No", 200); //2
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "프로젝트명", "Prj_Name", 200); //3
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "거래처명", "Company_Name", 200); //4
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "요청일자", "Req_Date", 200); //5
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "납기일자", "Delivery_Date", 200); //6
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "품목코드", "Item_Code", 200); //7
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "품목명", "Item_Name", 200); //8
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "수량", "Req_Qty", 200); //9
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "비고", "Remark", 200); //10

            foreach (int idx in orangeCols)
            {
                dgvOrder.Columns[idx].DefaultCellStyle.BackColor = Color.Orange;
            }

            ResetDtp();
            dt = ordSrv.GetOrderList(GetSearchValues());
            dgvOrder.DataSource = dt;

            stat = 0;
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
            return new string[] { dtpSearchOrd1.Value.ToString("yyyy-MM-dd"), dtpSearchOrd2.Value.ToString("yyyy-MM-dd"), 
                    dtpSearchDue1.Value.ToString("yyyy-MM-dd"), dtpSearchDue2.Value.ToString("yyyy-MM-dd"),
                    ucSearchItem._Code, ucSearchProject._Code};
        }

        public void OnSearch()
        {
            dt = ordSrv.GetOrderList(GetSearchValues());
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = dt;
        }

        public void OnAdd()
        {
            dt.Rows.Add();
            idx = dt.Rows.Count - 1;
            dgvOrder.Rows[idx].Cells["Req_Qty"].ReadOnly = false;
            dgvOrder.Rows[idx].Cells["Remark"].ReadOnly = false;

            stat = 1;
            //저장, 취소 빼고 다 비활성화
        }

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
            ucSearchItem.OpenPop(GetPopInfo_Item());
        }

        private void ucSearchProject_BtnClick(object sender, EventArgs e)
        {
            ucSearchItem.OpenPop(GetPopInfo_Project());
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(stat != 0)
            {
                if (e.RowIndex != idx) return;
                switch(e.ColumnIndex){
                    case 2: OpenPop(GetPopInfo_Project()); break;
                    case 6: SetDtpCell(dgvOrder[e.ColumnIndex, e.RowIndex]); break;
                    case 7: OpenPop(GetPopInfo_Item());  break;
                    default: break;
                }
            }
        }

        private void SetDtpCell(DataGridViewCell cell)
        {
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Visible = true;
            if (!string.IsNullOrWhiteSpace(cell.Value.ToString()))
                dtp.Value = DateTime.Parse(cell.Value.ToString());
            else
            {
                dtp.Value = DateTime.Now;
            }

            var rect = dgvOrder.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, true);
            dtp.Size = new Size(rect.Width, rect.Height);
            dtp.Location = new Point(rect.X, rect.Y);
            dgvOrder.Controls.Add(dtp);

            dtp.CloseUp += Dtp_CloseUp;
            dtp.TextChanged += Dtp_TextChanged;
        }

        private void Dtp_TextChanged(object sender, EventArgs e)
        {
            dgvOrder.SelectedRows[0].Cells["Delivery_Date"].Value = ((DateTimePicker)sender).Value.ToString("yyyy-MM-dd");
        }

        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            ((DateTimePicker)sender).Visible = false;
            dgvOrder.Controls.Remove((DateTimePicker)sender);
        }

        private CommonPop<ProjectDTO> GetPopInfo_Project()
        {
            if (projectCodeList == null || projectCodeList.Count() < 1)
            {
                projectCodeList = ordSrv.GetProjectList();
            }

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("프로젝트코드", "Prj_No", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("프로젝트명", "Prj_Name", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("거래처명", "Company_Name", 200));

            CommonPop<ProjectDTO> popInfo = new CommonPop<ProjectDTO>();
            popInfo.DgvDatasource = projectCodeList;
            popInfo.DgvCols = colList;
            popInfo.PopName = "프로젝트 검색";

            return popInfo;
        }

        private CommonPop<ItemDTO> GetPopInfo_Item()
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

            return popInfo;
        }

        private void OpenPop<T>(CommonPop<T> popInfo) where T : class, new()
        {
            frmPop pop = new frmPop();
            pop.PopLoadData<T>(popInfo);

            if (pop.ShowDialog(this) == DialogResult.OK)
            {
                dgvOrder[popInfo.DgvCols[0].DataPropertyName, idx].Value = pop.SelCode;
                dgvOrder[popInfo.DgvCols[1].DataPropertyName, idx].Value = pop.SelName;
                if(popInfo.DgvCols.Count > 2)
                    dgvOrder[popInfo.DgvCols[2].DataPropertyName, idx].Value = pop.SelEtc;
            }
        }

        private void GetItemInfo()
        {

        }
        private void GetDate()
        {

        }
    }
}
