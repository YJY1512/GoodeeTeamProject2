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
        string empId;
        DataTable dt;
        List<ItemDTO> itemCodeList;
        List<ProjectDTO> projectCodeList;
        int idx;
        int stat;
        //bool cellEditStat = false;
        int[] orangeCols = new int[] { 2, 6, 7, 9, 10 };
        int dtpMinDays = 7;
        int dtpMaxMonths = 3;

        public frmOrder()
        {
            InitializeComponent();
            ordSrv = new OrderService();
            //int empid = ((frmMain)this.MdiParent).LoginEmpInfo.emp_id;
            empId = "1000";
            idx = -1;
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

            ResetDtpNSearch();

            stat = 0;
        }

        private void ResetSearchCtrls()
        {
            dtpSearchOrd1.Value = DateTime.Today.AddDays(-7);
            dtpSearchOrd2.Value = DateTime.Today;
            dtpSearchDue1.Value = DateTime.Today.AddMonths(-1);
            dtpSearchDue2.Value = DateTime.Today.AddMonths(1);
            ucSearchItem._Code = "";
            ucSearchItem._Name = "";
            ucSearchProject._Code = "";
            ucSearchProject._Name = "";

        }

        private string[] GetSearchValues()
        {
            return new string[] { dtpSearchOrd1.Value.ToString("yyyy-MM-dd"), dtpSearchOrd2.Value.ToString("yyyy-MM-dd"), 
                    dtpSearchDue1.Value.ToString("yyyy-MM-dd"), dtpSearchDue2.Value.ToString("yyyy-MM-dd"),
                    ucSearchItem._Code, ucSearchProject._Code};
        }

        private void ResetDtpNSearch()
        {
            ResetSearchCtrls();
            dt = ordSrv.GetOrderList(GetSearchValues());
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = dt;
        }

        public void OnSearch()
        {
            idx = -1;
            dt = ordSrv.GetOrderList(GetSearchValues());
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = dt;
        }

        public void OnAdd()
        {
            dt.Rows.Add();
            idx = dt.Rows.Count - 1;
            dgvOrder["Req_Qty", idx].ReadOnly = false;
            dgvOrder["Remark", idx].ReadOnly = false;
            dgvOrder.FirstDisplayedCell = dgvOrder[2, idx];

            stat = 1;
            //저장, 취소 빼고 다 비활성화
        }

        public void OnEdit()
        {
            if (idx < 0)
            {
                MessageBox.Show("수정할 생산요청을 선택해 주세요.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            dgvOrder.Rows[idx].Cells["Req_Qty"].ReadOnly = false;
            dgvOrder.Rows[idx].Cells["Remark"].ReadOnly = false;
            dgvOrder.FirstDisplayedCell = dgvOrder[2, idx];

            stat = 2;

            //저장, 취소 빼고 다 비활성화
        }

        public void OnDelete()
        {
            if (idx < 0)
            {
                MessageBox.Show("삭제할 생산요청을 선택해 주세요.");

                return;
            }

            if (MessageBox.Show("선택한 생산요청을 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            string msg = ordSrv.Delete(dgvOrder["Prd_Req_No", idx].Value.ToString(), empId);
            
            if (string.IsNullOrWhiteSpace(msg))
            {
                MessageBox.Show("생산요청이 정상적으로 삭제되었습니다.");
                ResetDtpNSearch();

                stat = 0;
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        public void OnSave()
        {
            int i = 0; //유효성 체크용

            if (dgvOrder["Prj_No", idx].Value == null || dgvOrder["Prj_No", idx].Value == DBNull.Value)
            {
                MessageBox.Show("프로젝트 정보는 필수 입력 항목입니다.");
                return;
            }
            else if (dgvOrder["Delivery_Date", idx].Value == null || dgvOrder["Delivery_Date", idx].Value == DBNull.Value)
            {
                MessageBox.Show("납기일자는 필수 입력 항목입니다.");
                return;
            }
            else if (dgvOrder["Item_Code", idx].Value == null || dgvOrder["Item_Code", idx].Value == DBNull.Value)
            {
                MessageBox.Show("품목정보는 필수 입력 항목입니다.");
                return;
            }
            else if (dgvOrder["Req_Qty", idx].Value == null || dgvOrder["Req_Qty", idx].Value == DBNull.Value)
            {
                MessageBox.Show("수량은 필수 입력 항목입니다.");
                return;
            }
            else if (!int.TryParse(dgvOrder["Req_Qty", idx].Value.ToString(), out i))
            {
                MessageBox.Show("수량은 숫자만 입력 가능합니다.");
                return;
            }

            if (MessageBox.Show("입력한 정보를 저장하시겠습니까?", "저장확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            OrderDTO data = new OrderDTO
            {
                Prd_Req_No = dgvOrder["Prd_Req_No", idx].Value.ToString(),
                Item_Code = dgvOrder["Item_Code", idx].Value.ToString(),
                Req_Qty = Convert.ToInt32(dgvOrder["Req_Qty", idx].Value),
                Prj_No = dgvOrder["Prj_No", idx].Value.ToString(),
                Delivery_Date = dgvOrder["Delivery_Date", idx].Value.ToString(),
                Remark = dgvOrder["Remark", idx].Value.ToString(),
            };

            if (stat == 1) //추가
            {
                bool result = ordSrv.Insert(data, empId);
                if (result)
                {
                    MessageBox.Show("생산요청이 정상적으로 추가되었습니다.");

                    idx = -1;
                    ResetDtpNSearch();
                    stat = 0;
                }
                else
                {
                    MessageBox.Show("생산요청 추가에 실패하였습니다. 다시 시도하여 주세요.");
                }
            }
            else if (stat == 2) //수정
            {
                string msg = ordSrv.Update(data, empId);
                if (string.IsNullOrWhiteSpace(msg))
                {
                    MessageBox.Show("생산요청이 정상적으로 수정되었습니다.");

                    idx = -1;
                    ResetDtpNSearch();
                    stat = 0;
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
        }

        public void OnCancel()
        {
            if (MessageBox.Show("취소하시겠습니까?", "취소확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            idx = -1;
            ResetDtpNSearch();

            stat = 0;
        }

        public void OnReLoad()
        {
            idx = -1;
            ResetDtpNSearch();
        }

        private void ucSearchItem_BtnClick(object sender, EventArgs e)
        {
            ucSearchItem.OpenPop(GetPopInfo_Item());
        }

        private void ucSearchProject_BtnClick(object sender, EventArgs e)
        {
            ucSearchProject.OpenPop(GetPopInfo_Project());
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(stat != 0)
            {
                if (e.RowIndex == idx) 
                {
                    switch (e.ColumnIndex)
                    {
                        case 2: OpenPop(GetPopInfo_Project()); break;
                        case 6: SetDtpCell(dgvOrder[e.ColumnIndex, e.RowIndex]); break;
                        case 7: OpenPop(GetPopInfo_Item()); break;
                        default: break;
                    }
                }
            }
        }

        private void SetDtpCell(DataGridViewCell cell)
        {
            dgvOrder.ScrollBars = ScrollBars.None;
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.MinDate = DateTime.Now.AddDays(dtpMinDays);
            dtp.MaxDate = DateTime.Now.AddMonths(dtpMaxMonths);
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
            dgvOrder.ScrollBars = ScrollBars.Both;
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

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stat == 0)
                idx = e.RowIndex;
        }

        private void dgvOrder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= CheckNumberOnly;

            if (dgvOrder.CurrentCell.ColumnIndex == 9)
            {
                e.Control.KeyPress += CheckNumberOnly;
            }
        }

        private void CheckNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

    }
}
