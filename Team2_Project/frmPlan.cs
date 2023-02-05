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
using Team2_Project.Controls;

namespace Team2_Project
{
    public partial class frmPlan : Form
    {
        PlanService srv = new PlanService();

        List<ItemDTO> itemList;
        List<WorkCenterDTO> wcList;

        DataTable ReqDt;
        DataTable planDt;

        enum ButtonClick { Add, Edit, None };
        ButtonClick clickState = ButtonClick.None;
        int rIdx;

        public frmPlan()
        {
            InitializeComponent();
        }

        private void frmPlan_Load(object sender, EventArgs e)
        {
            //생산요청 tab
            DataGridViewUtil.SetInitDataGridView(dgvReq);
            DataGridViewCheckBoxColumn cbk = new DataGridViewCheckBoxColumn();
            cbk.Width = 30;
            cbk.DefaultCellStyle.BackColor = Color.PeachPuff;
            cbk.Frozen = true;
            dgvReq.Columns.Add(cbk);

            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "생산요청번호", "Prd_Req_No", 150, frosen:true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "의뢰일", "Req_Date", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "순번", "Req_Seq", 60, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "납기일", "Delivery_Date", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "작업장코드", "Wc_Code", OrangebackColor: true); //입력값
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "작업장명", "Wc_Name", 150, OrangebackColor: true); //입력값
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "품목명", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "계획수량", "In_Plan_Qty", 120, DataGridViewContentAlignment.MiddleRight, OrangebackColor: true); //계획 수량(입력값)
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "계획반영수량", "Plan_Qty", 120, DataGridViewContentAlignment.MiddleRight); //계획 수량 합계
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "요청수량/잔량", "Plan_Rest_Qty", 120, DataGridViewContentAlignment.MiddleRight); //요청수량(Req) - 계획반영수량(Plan_Qty)
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "Plan_YN", "Plan_YN", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "Item_Code", "Item_Code", visible: false);
            dgvReq.Columns["In_Plan_Qty"].ReadOnly = false;

            CommonCodeUtil.UseYNComboBinding(cboReqStat);

            //생산요청 tab
            DataGridViewUtil.SetInitDataGridView(dgvWcPlan);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWcPlan, "작업장코드", "Wc_Code");
            DataGridViewUtil.AddGridTextBoxColumn(dgvWcPlan, "작업장명", "Wc_Name");
            DataGridViewUtil.AddGridTextBoxColumn(dgvWcPlan, "계획반영수량", "Plan_Qty", align: DataGridViewContentAlignment.MiddleRight); //작업장별 합계
            DataGridViewUtil.AddGridTextBoxColumn(dgvWcPlan, "계획수량", "In_Plan_Qty", align: DataGridViewContentAlignment.MiddleRight); //작업장별 합계

            //생산계획 tab
            DataGridViewUtil.SetInitDataGridView(dgvPlan);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획번호", "Prd_Plan_No", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획월", "Plan_Month", align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "작업장코드", "Wc_Code", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "작업장명", "Wc_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "품목코드", "Item_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "품목명", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획수량", "Plan_Qty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "거래처", "Company_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "납기일", "Delivery_Date", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획상태", "Prd_Plan_Status", 120, DataGridViewContentAlignment.MiddleCenter);
            

            tab1SetInit();
            tab1LoadData();
        }


        #region popOpen 관련 공통 메서드
        private CommonPop<WorkCenterDTO> GetWcPopInfo()
        {            
            if (wcList == null)
            {                                
                WorkCenterService srv = new WorkCenterService();
                wcList = srv.GetWcCodeName();                              
            }

            CommonPop<WorkCenterDTO> wcPopInfo = new CommonPop<WorkCenterDTO>();
            wcPopInfo.DgvDatasource = wcList;
            wcPopInfo.PopName = "작업장 검색";

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장코드", "Wc_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장명", "Wc_Name", 200));

            wcPopInfo.DgvCols = colList;

            return wcPopInfo;

        }

        private CommonPop<ItemDTO> GetItemPopInfo()
        {
            if (itemList == null)
            {                
                ItemService srv = new ItemService();
                itemList = srv.GetItemCodeName();                
            }

            CommonPop<ItemDTO> itemPopInfo = new CommonPop<ItemDTO>();
            itemPopInfo.DgvDatasource = itemList;
            itemPopInfo.PopName = "품목 검색";

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목코드", "Item_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목명", "Item_Name", 200));

            itemPopInfo.DgvCols = colList;

            return itemPopInfo;
        }

        private void OpenPop<T>(CommonPop<T> popInfo, DataGridView dgv, int rowIndex) where T : class, new()
        {
            frmPop pop = new frmPop();
            pop.PopLoadData<T>(popInfo);

            if (pop.ShowDialog() == DialogResult.OK)
            {
                dgv[popInfo.DgvCols[0].DataPropertyName, rowIndex].Value = pop.SelCode;
                dgv[popInfo.DgvCols[1].DataPropertyName, rowIndex].Value = pop.SelName;
            }
        }
        #endregion


        #region tabPage1 (생산요청tab)

        private void tab1LoadData()
        {
            ReqDt = srv.GetPrdReq(dtpReqFrom.Value.ToShortDateString(), dtpReqTo.Value.ToShortDateString());
            dgvReq.DataSource = ReqDt;

            DgvWcPlanBinding(ReqDt);
        }

        private void tab1SetInit()
        {
            dtpReqFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpReqTo.Value = dtpReqFrom.Value.AddMonths(1).AddDays(-1);
            dtpDue.Format = DateTimePickerFormat.Custom;
            dtpDue.CustomFormat = " ";

            ucProd._Code = ucProd._Name = "";
            cboReqStat.SelectedIndex = 0;
        }

        //계획수량 입력값 dgvWc로 바인딩하는 함수
        private void DgvWcPlanBinding(DataTable dt)
        {
            var SortTable = (from row in dt.AsEnumerable()
                             group row by new
                             {
                                 Wc_Code = row.Field<string>("Wc_Code"),
                                 Wc_Name = row.Field<string>("Wc_Name")
                             } into g
                             where g.Key.Wc_Code != null
                             select new
                             {
                                 Wc_Code = g.Key.Wc_Code,
                                 Wc_Name = g.Key.Wc_Name,
                                 In_Plan_Qty = g.Sum((c) => c.Field<int?>("In_Plan_Qty")),
                                 Plan_Qty = g.Sum((c) => c.Field<int>("Plan_Qty"))
                             }).ToList();

            if (SortTable.Count > 0)
            {
                dgvWcPlan.DataSource = SortTable;
            }
            else
            {
                dgvWcPlan.DataSource = null;
            }
        }

        //계획수량 입력되면 dgvWc 바인딩 함수 호출
        private void dgvReq_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvReq.Columns["In_Plan_Qty"].Index)
            {
                DataTable newDt = (DataTable)dgvReq.DataSource;
                DgvWcPlanBinding(newDt);
            }
        }
        

        private void dgvReq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            if (e.ColumnIndex == dgvReq.Columns["Wc_Code"].Index || e.ColumnIndex == dgvReq.Columns["Wc_Name"].Index)
            {
                OpenPop<WorkCenterDTO>(GetWcPopInfo(), dgvReq, e.RowIndex);
            }
        }

        //생산계획 생성버튼
        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<PlanDTO> plan = new List<PlanDTO>();

            foreach (DataGridViewRow row in dgvReq.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    if (row.Cells["Plan_Rest_Qty"].Value.ToString().Equals("0"))
                    {
                        MessageBox.Show("계획 잔량이 0이므로 계획 생성이 불가합니다.");
                        tab1LoadData();
                        return;
                    }

                    if (row.Cells["In_Plan_Qty"].Value == null || Convert.ToInt32(row.Cells["In_Plan_Qty"].Value) == 0)
                    {
                        MessageBox.Show("계획 수량을 입력해주세요.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(row.Cells["Wc_Code"].Value.ToString()) ||
                        string.IsNullOrWhiteSpace(row.Cells["Wc_Name"].Value.ToString()))
                    {
                        MessageBox.Show("작업장 정보를 입력해주세요.");
                        return;
                    }

                    plan.Add(new PlanDTO
                    {
                        Prd_Req_No = dgvReq["Prd_Req_No", row.Index].Value.ToString(),
                        Item_Code = dgvReq["Item_Code", row.Index].Value.ToString(),
                        Plan_Qty = Convert.ToInt32(dgvReq["In_Plan_Qty", row.Index].Value),
                        Plan_Rest_Qty = Convert.ToInt32(dgvReq["Plan_Rest_Qty", row.Index].Value) - Convert.ToInt32(dgvReq["In_Plan_Qty", row.Index].Value),
                        Wc_Code = dgvReq["Wc_Code", row.Index].Value.ToString(),
                        Ins_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                    });
                }
            }

            if (plan.Count < 1)
            {
                MessageBox.Show("생산계획을 생성할 항목을 선택하여 주십시오.");
                return;
            }

            bool result = srv.InsertReqPlan(plan);
            if (result)
            {
                MessageBox.Show("계획생성이 완료되었습니다.");
                tab1LoadData();
            }
            else
            {
                MessageBox.Show("계획생성 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
            }
        }

        private void ucProd_BtnClick(object sender, EventArgs e)
        {
            ucProd.OpenPop(GetItemPopInfo());
        }

        private void dtpDue_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDue.Format == DateTimePickerFormat.Custom)
            {
                dtpDue.Format = DateTimePickerFormat.Short;
            }
        }

        #endregion


        #region 데이터그리드뷰 숫자만 입력가능하게 (공통)

        private void dgvReq_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            OnDgvCellKeyPress(dgvReq, "In_Plan_Qty", e);
        }

        private void dgvPlan_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            OnDgvCellKeyPress(dgvPlan, "Plan_Qty", e);
        }

        //데이터그리드뷰 숫자만 입력가능 관련 공통 메서드
        private void OnDgvCellKeyPress(DataGridView dgv, string colName, DataGridViewEditingControlShowingEventArgs e)
        {
            string curCol = dgv.CurrentCell.OwningColumn.Name;

            if (curCol == colName)
                e.Control.KeyPress += CheckIsNum;
            else
                e.Control.KeyPress -= CheckIsNum;
        }

        private void CheckIsNum(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        #endregion


        #region tabPage2 (생산계획tab)

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && planDt == null)
            {
                tab2LoadData();
                tab2SetInit();
            }
        }

        private void tab2LoadData()
        {
            string planMonth = dtpMonth.Value.ToString("yyyy-MM");
            planDt = srv.GetPlan(planMonth);

            dgvPlan.DataSource = planDt;
        }

        private void tab2SetInit()
        {
            dtpMonth.Value = DateTime.Now;

            ucProd2._Code = ucProd2._Name = "";
            ucWc._Code = ucWc._Name = "";
        }

        private void ucProd2_BtnClick(object sender, EventArgs e)
        {
            ucProd2.OpenPop(GetItemPopInfo());
        }

        private void ucWc_BtnClick(object sender, EventArgs e)
        {
            ucWc.OpenPop(GetWcPopInfo());
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            dgvPlan.Enabled = false;

            int rIdx = dgvPlan.CurrentRow.Index;
            if (!dgvPlan["Prd_Plan_Status", rIdx].Value.ToString().Equals("대기중"))
            {
                MessageBox.Show("대기중인 계획만 분할이 가능합니다.");
                dgvPlan.Enabled = true;
                return;
            }

            frmPlanPop pop = new frmPlanPop();
            pop.mode = frmPlanPop.OpenMode.Split;

            pop.PlanID = dgvPlan["Prd_Plan_No", rIdx].Value.ToString();
            pop.Qty = Convert.ToInt32(dgvPlan["Plan_Qty", rIdx].Value);

            if (pop.ShowDialog(this) == DialogResult.OK)
            {
                PlanDTO plan = new PlanDTO
                {
                    Prd_Plan_No = pop.PlanID,
                    Item_Code = dgvPlan["Item_Code", rIdx].Value.ToString(),
                    Wc_Code = dgvPlan["Wc_Code", rIdx].Value.ToString(),
                    Plan_Qty = pop.Qty,
                    Ins_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                };

                bool result = srv.SplitPlan(plan);
                if (result)
                {
                    MessageBox.Show("계획 분할이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("계획 분할 중 요류가 발생하였습니다.");
                }

                OnReLoad();
            }

            dgvPlan.Enabled = true;
        }

        private void dgvPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            if (clickState == ButtonClick.Add)
            {
                if (e.ColumnIndex == dgvPlan.Columns["Wc_Code"].Index || e.ColumnIndex == dgvPlan.Columns["Wc_Name"].Index)
                {
                    OpenPop<WorkCenterDTO>(GetWcPopInfo(), dgvPlan, e.RowIndex);
                }

                if (e.ColumnIndex == dgvPlan.Columns["Item_Code"].Index || e.ColumnIndex == dgvPlan.Columns["Item_Name"].Index)
                {
                    OpenPop<ItemDTO>(GetItemPopInfo(), dgvPlan, e.RowIndex);
                }
            }
        }

        //Add일 때 cell 선택 불가하게
        private void dgvPlan_SelectionChanged(object sender, EventArgs e)
        {
            if (clickState == ButtonClick.Add)
            {
                dgvPlan.CurrentCell.Selected = false;
                dgvPlan.CurrentCell = dgvPlan.Rows[rIdx].Cells[0];
            }
        }

        #endregion


        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            if (tabControl1.SelectedIndex == 0)
            {
                string itemCode = ucProd._Code;
                string planYN = (cboReqStat.SelectedItem.ToString() == "전체")? "" : cboReqStat.SelectedItem.ToString();
                string dueDt = (dtpDue.Format == DateTimePickerFormat.Custom) ? null : dtpDue.Value.ToShortDateString();

                if (string.IsNullOrWhiteSpace(itemCode) && string.IsNullOrWhiteSpace(planYN) && string.IsNullOrWhiteSpace(dueDt))
                {
                    tab1LoadData();
                    return;
                }                    

                var filter = ReqDt.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(itemCode))
                    filter = filter.Where((r) => r.Field<string>("Item_code") == itemCode);

                if (!string.IsNullOrWhiteSpace(planYN))
                    filter = filter.Where((r) => r.Field<string>("Plan_YN") == planYN);

                if (!string.IsNullOrWhiteSpace(dueDt))
                    filter = filter.Where((r) => r.Field<DateTime>("Delivery_Date") == Convert.ToDateTime(dueDt));

                if (filter.Count() < 1)
                {
                    dgvReq.DataSource = null;
                    dgvWcPlan.DataSource = null;
                    return;
                }

                dgvReq.DataSource = filter.CopyToDataTable();
            }
            else
            {
                string itemCode = ucProd2._Code;
                string wcCode = ucWc._Code;

                if (string.IsNullOrWhiteSpace(itemCode) && string.IsNullOrWhiteSpace(wcCode))
                {
                    tab2LoadData();
                    return;
                }

                var filter = planDt.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(itemCode))
                    filter = filter.Where((r) => r.Field<string>("Item_code") == itemCode);

                if (!string.IsNullOrWhiteSpace(wcCode))
                    filter = filter.Where((r) => r.Field<string>("Wc_Code") == wcCode);

                if (filter.Count() < 1)
                {
                    dgvPlan.DataSource = null;
                    return;
                }

                dgvPlan.DataSource = filter.CopyToDataTable();
            }
        }

        public void OnAdd()     //추가
        {
            if (tabControl1.SelectedIndex == 0)
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            //tab2
            planDt.Rows.Add();
            rIdx = dgvPlan.Rows.Count - 1;

            dgvPlan["Plan_Qty", rIdx].ReadOnly = false;

            string[] cols = new string[] { "Wc_Code", "Wc_Name", "Item_Code", "Item_Name", "Plan_Qty" };
            foreach (var col in cols)
            {                
                dgvPlan[col, rIdx].Style.SelectionBackColor = Color.PeachPuff;
                dgvPlan[col, rIdx].Style.SelectionForeColor = Color.Black;
            }

            clickState = ButtonClick.Add;
            dgvPlan.CurrentCell = dgvPlan.Rows[rIdx].Cells[0];            
        }

        public void OnEdit()    //수정
        {
            if (tabControl1.SelectedIndex == 0)
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            if (dgvPlan.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 항목을 선택하여 주십시오.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            int rIdx = dgvPlan.CurrentRow.Index;
            if (!dgvPlan["Prd_Plan_Status", rIdx].Value.ToString().Equals("대기중"))
            {
                MessageBox.Show("대기중인 계획만 수정이 가능합니다.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            dgvPlan.Enabled = false;
            clickState = ButtonClick.Edit;

            frmPlanPop pop = new frmPlanPop();
            pop.mode = frmPlanPop.OpenMode.Edit;

            pop.PlanID = dgvPlan["Prd_Plan_No", rIdx].Value.ToString();
            pop.Qty = Convert.ToInt32(dgvPlan["Plan_Qty", rIdx].Value);

            if (pop.ShowDialog(this) == DialogResult.OK)
            {
                dgvPlan["Plan_Qty", rIdx].Value = pop.Qty;
                OnSave();
            }
            else
            {
                clickState = ButtonClick.None;
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                dgvPlan.Enabled = true;
            }
        }

        public void OnDelete()  //삭제
        {
            if (tabControl1.SelectedIndex == 0)
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            if (dgvPlan.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 항목을 선택하여 주십시오.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            dgvPlan.Enabled = false;
            int rIdx = dgvPlan.CurrentRow.Index;
            string planID = dgvPlan["Prd_Plan_No", rIdx].Value.ToString();

            if (MessageBox.Show($"생산계획({planID})를 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int result = srv.DeletePlan(planID);

                if (result == 0) //성공
                {
                    MessageBox.Show("삭제가 완료되었습니다.");
                }
                else if (result == 547 || result == 3726) //FK 충돌
                {
                    MessageBox.Show("이미 생성된 생산지시가 있어 생산계획을 삭제할 수 없습니다.");
                }
                else
                {
                    MessageBox.Show("삭제 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }

                OnReLoad();
            }

            dgvPlan.Enabled = true;
        }

        public void OnSave()    //저장
        {
            if (tabControl1.SelectedIndex == 0)
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            if (clickState == ButtonClick.Add) //추가
            {
                dgvPlan.Columns["Plan_Qty"].ReadOnly = true;

                if (dgvPlan["Plan_Qty", rIdx].Value == DBNull.Value || Convert.ToInt32(dgvPlan["Plan_Qty", rIdx].Value) == 0)
                {
                    MessageBox.Show("계획 수량을 입력해주세요.");

                    if (clickState == ButtonClick.Add)
                        ((frmMain)this.MdiParent).AddClickEvent();

                    else if (clickState == ButtonClick.Edit)
                        ((frmMain)this.MdiParent).EditClickEvent();

                    return;
                }

                if (string.IsNullOrWhiteSpace(dgvPlan["Wc_Code", rIdx].Value.ToString()) ||
                        string.IsNullOrWhiteSpace(dgvPlan["Wc_Name", rIdx].Value.ToString()))
                {
                    MessageBox.Show("작업장 정보를 입력해주세요.");
                    ((frmMain)this.MdiParent).AddClickEvent();
                    return;
                }

                if (string.IsNullOrWhiteSpace(dgvPlan["Item_Code", rIdx].Value.ToString()) ||
                        string.IsNullOrWhiteSpace(dgvPlan["Item_Name", rIdx].Value.ToString()))
                {
                    MessageBox.Show("품목 정보를 입력해주세요.");
                    ((frmMain)this.MdiParent).AddClickEvent();
                    return;
                }

                PlanDTO plan = new PlanDTO
                {
                    Item_Code = dgvPlan["Item_Code", rIdx].Value.ToString(),
                    Plan_Qty = Convert.ToInt32(dgvPlan["Plan_Qty", rIdx].Value),
                    Plan_Rest_Qty = 0,
                    Wc_Code = dgvPlan["Wc_Code", rIdx].Value.ToString(),
                    Ins_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                };

                bool result = srv.InsertPlan(plan);
                if (result)
                {
                    MessageBox.Show("계획등록이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("계획등록 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }

                clickState = ButtonClick.None;
                rIdx = -1;
                OnReLoad();
            }
            else if (clickState == ButtonClick.Edit) //수정
            {
                int rIdx = dgvPlan.CurrentRow.Index;

                PlanDTO plan = new PlanDTO
                {
                    Prd_Plan_No = dgvPlan["Prd_Plan_No", rIdx].Value.ToString(),
                    Plan_Qty = Convert.ToInt32(dgvPlan["Plan_Qty", rIdx].Value),
                    Up_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                };

                int result = srv.UpdatePlan(plan);
                if (result == 0) //성공
                {
                    MessageBox.Show("수정이 완료되었습니다.");
                    ((frmMain)this.MdiParent).BtnEditReturn(true);
                }
                else if (result == 547 || result == 3726) //FK 충돌
                {
                    MessageBox.Show("대기중인 계획만 수정이 가능합니다.");
                }
                else
                {
                    MessageBox.Show("수정 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
                
                clickState = ButtonClick.None;
                dgvPlan.Enabled = true;                
                OnReLoad();
            }
        }

        public void OnCancel()  //취소
        {
            if (tabControl1.SelectedIndex == 0)
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            if (clickState == ButtonClick.Add)
            {
                clickState = ButtonClick.None;
            
                planDt.Rows.RemoveAt(rIdx);
                rIdx = -1;
            }
        }

        public void OnReLoad()  //새로고침
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tab1SetInit();
                tab1LoadData();
            }
            else
            {
                tab2SetInit();
                tab2LoadData();
            }
        }

        #endregion



    }
}
