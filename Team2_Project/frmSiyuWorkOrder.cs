using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Services;
using Team2_Project.Utils;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmSiyuWorkOrder : Team2_Project.frmListListUpDown
    {
        PlanService planSrv = new PlanService();
        WorkOrderService woSrv = new WorkOrderService();

        DataTable planDt;
        DataTable woDt;
        DataTable filterWoDt;

        List<WorkCenterDTO> wcList;
        List<UserCodeDTO> wcGrpList;
        List<ItemDTO> itemList;

        int rIdx;

        enum ButtonClick { Add, Edit, None };
        ButtonClick clickState = ButtonClick.None;

        public frmSiyuWorkOrder()
        {
            InitializeComponent();
        }

        private void frmSiyuWorkOrder_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvPlan);
            DataGridViewCheckBoxColumn cbk = new DataGridViewCheckBoxColumn();
            cbk.Width = 30;
            cbk.Frozen = true;
            dgvPlan.Columns.Add(cbk);

            DataGridViewUtil.SetInitDataGridView(dgvPlan);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획번호", "Prd_Plan_No", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "작업장코드", "Wc_Code", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "작업장명", "Wc_Name", 150);            
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "품목코드", "Item_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "품목명", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획수량", "Plan_Qty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "작업지시수량", "Plan_Qty_Box", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "거래처", "Company_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "납기일", "Delivery_Date", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획상태", "Prd_Plan_Status", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "Plan_Month", "Plan_Month", visible:false);

            DataGridViewUtil.SetInitDataGridView(dgvWorkOrder);
            DataGridViewCheckBoxColumn cbk2 = new DataGridViewCheckBoxColumn();
            cbk2.Width = 30;
            cbk2.Frozen = true;
            dgvWorkOrder.Columns.Add(cbk2);

            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시상태", "Wo_Status", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시번호", "WorkOrderNo", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시일자", "Plan_Date", 120, DataGridViewContentAlignment.MiddleCenter, OrangebackColor: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시수량", "Plan_Qty_Box", 120, DataGridViewContentAlignment.MiddleRight, OrangebackColor: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "품목코드", "Item_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "품목명", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업장코드", "Wc_Code", 120, OrangebackColor: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업장명", "Wc_Name", 150, OrangebackColor: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "생산일자", "Prd_Date", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "생산수량", "Prd_Qty", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "전달사항", "Remark", 200, OrangebackColor: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "Wo_Status_code", "Wo_Status_code", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "Prd_Plan_No", "Prd_Plan_No", visible:false);
            dgvWorkOrder.Columns["Plan_Qty_Box"].ReadOnly = false;

            LoadData();            
        }

        private void frmSiyuWorkOrder_Shown(object sender, EventArgs e)
        {
            dgvWorkOrder.ClearSelection();
        }

        private void LoadData()
        {
            string planMonth = dtpMonth.Value.ToString("yyyy-MM");
            planDt = planSrv.GetPlan(planMonth);
            dgvPlan.DataSource = planDt;

            dgvWorkOrder.DataSource = null;
            woDt = woSrv.GetSiyuWorkOrder(planMonth);

            if (woDt != null && woDt.Rows.Count > 0)
            {
                if (dgvPlan.CurrentRow != null)
                    dgvPlan_CellClick(dgvPlan, new DataGridViewCellEventArgs(0, dgvPlan.CurrentRow.Index));
            }
        }

        private void SetInit()
        {
            dtpMonth.Value = DateTime.Now;

            ucProd._Code = ucProd._Name = "";
            ucWc._Code = ucWc._Name = "";
            ucWcGrp._Code = ucWcGrp._Name = "";
        }


        //작업지시생성 버튼
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rIdx = dgvPlan.CurrentRow.Index;

            if (!Convert.ToBoolean(dgvPlan[0, rIdx].Value))
            {
                MessageBox.Show("작업지시를 생성할 항목을 선택하여 주십시오.");
                return;
            }

            string planID = dgvPlan["Prd_Plan_No", rIdx].Value.ToString();
            string status = planSrv.ChkStatus(planID);

            if (!status.Equals("A")) //대기중
            {
                MessageBox.Show("대기중인 계획만 작업지시 생성이 가능합니다.");
                return;
            }

            frmSiyuPop pop = new frmSiyuPop();
            pop.PlanInfo = new PlanDTO
            {
                Prd_Plan_No = dgvPlan["Prd_Plan_No", rIdx].Value.ToString(),
                Wc_Code = dgvPlan["Wc_Code", rIdx].Value.ToString(),
                Wc_Name = dgvPlan["Wc_Name", rIdx].Value.ToString(),
                Item_Code = dgvPlan["Item_Code", rIdx].Value.ToString(),
                Item_Name = dgvPlan["Item_Name", rIdx].Value.ToString(),
                Plan_Month = dgvPlan["Plan_Month", rIdx].Value.ToString(),
                Plan_Qty = Convert.ToInt32(dgvPlan["Plan_Qty", rIdx].Value)
            };
            pop.UserId = ((frmMain)this.MdiParent).LoginEmp.User_ID;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                bool result = woSrv.InserSiyuWorkOrder(pop.WoInfo);

                if (result)
                {
                    MessageBox.Show("작업지시 생성이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("작업지시 생성 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }

            OnReLoad();
        }


        #region dgvWorkOrder crud 관련 버튼

        //작업지시 dgv 버튼 enable 상태 설정
        private void SetWobtnEnabled(bool active)
        {
            btnWoAdd.Enabled = btnWoEdit.Enabled = btnWoDel.Enabled = btnMsgEdit.Enabled = active;
        }
        private void SetEditStart()
        {
            dgvPlan.Enabled = false;
            dgvWorkOrder.Enabled = false;
            SetWobtnEnabled(false);
        }
        private void SetEditEnd()
        {
            dgvPlan.Enabled = true;
            dgvWorkOrder.Enabled = true;
            SetWobtnEnabled(true);
        }


        private void btnWoAdd_Click(object sender, EventArgs e) //작업지시 추가
        {
            int curIdx = dgvPlan.CurrentRow.Index;
            string planID = dgvPlan["Prd_Plan_No", curIdx].Value.ToString();
            string status = planSrv.ChkStatus(planID);

            if (status.Equals("A")) //대기중
            {
                MessageBox.Show("작업지시 미생성 계획입니다. 작업지시 생성 후 다시 시도하여 주십시오.");
                return;
            }                
            else if(status.Equals("C")) //생산마감
            {
                MessageBox.Show("이미 마감된 생산계획이므로 작업지시 추가가 불가합니다.");
                return;
            }

            ((frmMain)this.MdiParent).AddClickEvent();
            SetEditStart();
            clickState = ButtonClick.Add;

            filterWoDt = (DataTable)dgvWorkOrder.DataSource;

            DataRow dr = filterWoDt.NewRow();
            dr["Item_Code"] = dgvPlan["Item_Code", curIdx].Value.ToString();
            dr["Item_Name"] = dgvPlan["Item_Name", curIdx].Value.ToString();
            dr["Prd_Plan_No"] = dgvPlan["Prd_Plan_No", curIdx].Value.ToString();

            filterWoDt.Rows.Add(dr);
            rIdx = filterWoDt.Rows.Count-1;

            string[] cols = new string[] { "Wc_Code", "Wc_Name", "Plan_Date", "Plan_Qty_Box" };
            foreach (var col in cols)
            {
                dgvWorkOrder[col, rIdx].Style.SelectionBackColor = Color.PeachPuff;
                dgvWorkOrder[col, rIdx].Style.SelectionForeColor = Color.Black;
            }
            
            dgvWorkOrder.CurrentCell = dgvWorkOrder.Rows[rIdx].Cells[0];
            dgvWorkOrder.Enabled = true;
        }

        private void btnWoEdit_Click(object sender, EventArgs e) //작업지시 수정저장
        {
            SetEditStart();
            clickState = ButtonClick.Edit;

            List<WorkOrderDTO> wo = new List<WorkOrderDTO>();
            foreach (DataGridViewRow row in dgvWorkOrder.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    string woID = row.Cells["WorkOrderNo"].Value.ToString();
                    string status = woSrv.ChkStatus(woID);
                    if (!status.Equals("W01")) //생산대기
                    {
                        MessageBox.Show("생산대기중인 작업지시만 수정이 가능합니다.");
                        clickState = ButtonClick.None;
                        SetEditEnd();                        
                        return;
                    }

                    bool isVaild = WorkOrderValidChk(row.Index);
                    if (!isVaild)
                    {
                        clickState = ButtonClick.None;
                        SetEditEnd();
                        return;
                    }

                    wo.Add(new WorkOrderDTO
                    {
                        WorkOrderNo = row.Cells["WorkOrderNo"].Value.ToString(),
                        Plan_Qty_Box = Convert.ToInt32(row.Cells["Plan_Qty_Box"].Value),
                        Plan_Date = Convert.ToDateTime(row.Cells["Plan_Date"].Value),
                        Item_Code = row.Cells["Item_Code"].Value.ToString(),
                        Wc_Code = row.Cells["Wc_Code"].Value.ToString(),
                        Up_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                    });
                }
            }

            if (wo.Count < 1)
            {
                MessageBox.Show("수정할 항목을 선택하여 주십시오.");
                clickState = ButtonClick.None;
                SetEditEnd();                
                return;
            }

            bool result = woSrv.UpdateWorkOrder(wo);
            if(result)
            {
                MessageBox.Show("작업지시 수정이 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("작업지시 수정 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
            }

            clickState = ButtonClick.None;
            SetEditEnd();
            OnReLoad();

        }

        private void btnWoDel_Click(object sender, EventArgs e) //작업지시 삭제
        {
            SetEditStart();

            List<string> delIds = new List<string>();
            foreach (DataGridViewRow row in dgvWorkOrder.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    string woID = row.Cells["WorkOrderNo"].Value.ToString();
                    string status = woSrv.ChkStatus(woID);
                    if (!status.Equals("W01")) //생산대기
                    {
                        MessageBox.Show("생산대기중인 작업지시만 삭제가 가능합니다.");
                        clickState = ButtonClick.None;
                        SetEditEnd();
                        return;
                    }

                    delIds.Add(row.Cells["WorkOrderNo"].Value.ToString());
                }                
            }

            if (delIds.Count < 1)
            {
                MessageBox.Show("삭제할 항목을 선택하여 주십시오.");
                clickState = ButtonClick.None;
                SetEditEnd();
                return;
            }

            string upEmp = ((frmMain)this.MdiParent).LoginEmp.User_ID;
            bool result = woSrv.DeleteWorkOrder(delIds, upEmp);
            if (result)
            {
                MessageBox.Show("작업지시 삭제가 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("작업지시 삭제 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
            }

            clickState = ButtonClick.None;
            SetEditEnd();
            OnReLoad();
        }

        private void btnMsgEdit_Click(object sender, EventArgs e) //전달메세지 수정저장
        {
            SetEditStart();

            Dictionary<string, string> woMsg = new Dictionary<string, string>();
            foreach (DataGridViewRow row in dgvWorkOrder.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    string msg = row.Cells["Remark"].Value.ToString();
                    if (string.IsNullOrWhiteSpace(msg))
                    {
                        MessageBox.Show("전달메세지를 입력하여 주십시오.");
                        clickState = ButtonClick.None;
                        SetEditEnd();
                        return;
                    }

                    woMsg.Add(row.Cells["WorkOrderNo"].Value.ToString(), row.Cells["Remark"].Value.ToString());
                }
            }

            if (woMsg.Count < 1)
            {
                MessageBox.Show("저장할 항목을 선택하여 주십시오.");
                clickState = ButtonClick.None;
                SetEditEnd();                
                return;
            }

            string upEmp = ((frmMain)this.MdiParent).LoginEmp.User_ID;
            bool result = woSrv.UpdateMsg(woMsg, upEmp);
            if (result)
            {
                MessageBox.Show("저장이 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("저장 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
            }

            clickState = ButtonClick.None;
            SetEditEnd();
            OnReLoad();
        }

        #endregion

        private bool WorkOrderValidChk(int rowIndex = 0)
        {
            int rowIdx = 0;

            if (clickState == ButtonClick.Add)
                rowIdx = rIdx;
            else if (clickState == ButtonClick.Edit)
                rowIdx = rowIndex;

            if (dgvWorkOrder["Plan_Qty_Box", rowIdx].Value == DBNull.Value || Convert.ToInt32(dgvWorkOrder["Plan_Qty_Box", rowIdx].Value) == 0)
            {
                MessageBox.Show("지시 수량을 입력해주세요.");                
                return false;
            }

            if (string.IsNullOrWhiteSpace(dgvWorkOrder["Wc_Code", rowIdx].Value.ToString()) ||
                    string.IsNullOrWhiteSpace(dgvWorkOrder["Wc_Name", rowIdx].Value.ToString()))
            {
                MessageBox.Show("작업장 정보를 입력해주세요.");
                return false;
            }

            if ((clickState == ButtonClick.Add || clickState == ButtonClick.Edit) &&
                dgvWorkOrder["Plan_Date", rowIdx].Value == DBNull.Value)
            {
                if (dgvWorkOrder.Tag == null)
                {
                    MessageBox.Show("작업지시 일자를 입력하여 주십시오.");
                    return false;
                }
                else
                {
                    Dtp_TextChanged(dgvWorkOrder.Tag, null);
                    Dtp_CloseUp(dgvWorkOrder.Tag, null);
                }
            }

            if (Convert.ToDateTime(dgvWorkOrder["Plan_Date", rowIdx].Value) < DateTime.Today)
            {
                MessageBox.Show("작업지시 일자는 오늘 이전으로 설정할 수 없습니다.");
                return false;
            }

            return true;
        }


        private void dgvPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvWorkOrder.Tag != null)
            {
                Dtp_CloseUp(dgvWorkOrder.Tag, null);
            }

            string planID = dgvPlan["Prd_Plan_No", e.RowIndex].Value.ToString();

            var filter = from row in woDt.AsEnumerable()
                         where row.Field<string>("Prd_Plan_No") == planID
                         select row;

            if (filter.Count() < 1)
            {
                dgvWorkOrder.DataSource = null;
                return;
            }
            
            dgvWorkOrder.DataSource = filter.CopyToDataTable();
            dgvWorkOrder.ClearSelection();
        }

        private void dgvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //chk 한개만 되게
            if (e.ColumnIndex == 0)
            {
                bool isChk = Convert.ToBoolean(dgvPlan[0, e.RowIndex].Value);

                foreach (DataGridViewRow dr in dgvPlan.Rows)
                {
                    dr.Cells[0].Value = false;
                }

                dgvPlan[0, e.RowIndex].Value = !isChk;
            }
        }

        private void dgvWorkOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvWorkOrder["Wo_Status_code", e.RowIndex].Value == null) return;

            string status = dgvWorkOrder["Wo_Status_code", e.RowIndex].Value.ToString();
            switch (status)
            {
                case "W01": //생산대기
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.BackColor = Color.Orange;
                    break;
                case "W02": //생산중
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.BackColor = Color.ForestGreen;
                    break;
                case "W03": //생산중지
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.BackColor = Color.Gold;
                    break;
                case "W04": //현장마감
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.BackColor = Color.LightSkyBlue;
                    break;
                case "W05": //작업지시마감
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.BackColor = Color.DarkBlue;
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.ForeColor = Color.White;
                    break;
                default: break;
            }
        }

        private void dgvWorkOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (e.ColumnIndex == dgvWorkOrder.Columns["Plan_Date"].Index)
            {
                if (dgvWorkOrder.Tag == null)
                    SetDtpCell(dgvWorkOrder[e.ColumnIndex, e.RowIndex]);
            }
            else if (e.ColumnIndex == dgvWorkOrder.Columns["Wc_Code"].Index || e.ColumnIndex == dgvWorkOrder.Columns["Wc_Name"].Index)
            {
                OpenPop<WorkCenterDTO>(GetWcPopInfo(), dgvWorkOrder, e.RowIndex);

            }
            else if (e.ColumnIndex == dgvWorkOrder.Columns["Remark"].Index)
            {
                dgvWorkOrder[e.ColumnIndex, e.RowIndex].ReadOnly = false;
            }

            if (e.ColumnIndex != dgvWorkOrder.Columns["Plan_Date"].Index 
                    && (clickState == ButtonClick.Add || clickState == ButtonClick.Edit) 
                    && dgvWorkOrder.Tag != null && dgvWorkOrder["Plan_Date", e.RowIndex].Value == DBNull.Value)
            {
                Dtp_TextChanged(dgvWorkOrder.Tag, null);
                Dtp_CloseUp(dgvWorkOrder.Tag, null);             
            }
        }


        //Add, Edit 상태일 때 cell 선택 불가하게
        private void dgvWorkOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (clickState == ButtonClick.Add)
            {
                dgvWorkOrder.CurrentCell.Selected = false;
                dgvWorkOrder.CurrentCell = dgvWorkOrder.Rows[rIdx].Cells[0];
            }
        }

        #region 데이터그리드뷰 숫자만 입력가능하게
        private void dgvWorkOrder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            OnDgvCellKeyPress(dgvWorkOrder, "Plan_Qty_Box", e);
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


        #region 데이터그리드뷰 dtp 관련 메서드
        private void SetDtpCell(DataGridViewCell cell)
        {
            dgvWorkOrder.ScrollBars = ScrollBars.None;
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Visible = true;
            if (!string.IsNullOrWhiteSpace(cell.Value.ToString()))
                dtp.Value = DateTime.Parse(cell.Value.ToString());
            else
            {
                dtp.Value = DateTime.Now;
            }

            var rect = dgvWorkOrder.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, true);
            dtp.Size = new Size(rect.Width, rect.Height);
            dtp.Location = new Point(rect.X, rect.Y);
            dgvWorkOrder.Controls.Add(dtp);
            dgvWorkOrder.Tag = dtp;

            dtp.CloseUp += Dtp_CloseUp;
            dtp.TextChanged += Dtp_TextChanged;
        }

        private void Dtp_TextChanged(object sender, EventArgs e)
        {
            dgvWorkOrder.SelectedRows[0].Cells["Plan_Date"].Value = ((DateTimePicker)sender).Value.ToString("yyyy-MM-dd");
        }

        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            ((DateTimePicker)sender).Visible = false;
            dgvWorkOrder.Controls.Remove((DateTimePicker)sender);
            dgvWorkOrder.ScrollBars = ScrollBars.Both;
            dgvWorkOrder.Tag = null;
        }
        #endregion


        #region 데이터그리드뷰 pop열기 관련 메서드
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

        private CommonPop<UserCodeDTO> GetWcGroupPopInfo()
        {
            if (wcGrpList == null)
            {
                UserCodeService srv = new UserCodeService();
                wcGrpList = srv.GetUserMiCode("WC_GROUP");
            }

            CommonPop<UserCodeDTO> wcGrpPopInfo = new CommonPop<UserCodeDTO>();
            wcGrpPopInfo.DgvDatasource = wcGrpList;
            wcGrpPopInfo.PopName = "작업장그룹 검색";

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장그룹코드", "Userdefine_Mi_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장그룹명", "Userdefine_Mi_Name", 200));

            wcGrpPopInfo.DgvCols = colList;

            return wcGrpPopInfo;
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

        private void ucProd_BtnClick(object sender, EventArgs e)
        {
            ucProd.OpenPop(GetItemPopInfo());
        }

        private void ucWc_BtnClick(object sender, EventArgs e)
        {
            ucWc.OpenPop(GetWcPopInfo());
        }

        private void ucWcGrp_BtnClick(object sender, EventArgs e)
        {
            ucWcGrp.OpenPop(GetWcGroupPopInfo());
        }




        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            string itemCode = ucProd._Code;
            string wcGrpCode = ucWcGrp._Code;
            string wcCode = ucWc._Code;

            if (string.IsNullOrWhiteSpace(itemCode) && string.IsNullOrWhiteSpace(wcGrpCode) && string.IsNullOrWhiteSpace(wcCode))
            {
                LoadData();
                return;
            }

            var filter = planDt.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(itemCode))
                filter = filter.Where((r) => r.Field<string>("Item_code") == itemCode);

            if (!string.IsNullOrWhiteSpace(wcGrpCode))
                filter = filter.Where((r) => r.Field<string>("Wc_Group") == wcGrpCode);

            if (!string.IsNullOrWhiteSpace(wcCode))
                filter = filter.Where((r) => r.Field<string>("Wc_Code") == wcCode);

            if (filter.Count() < 1)
            {
                dgvPlan.DataSource = null;
            }
            else
            {
                dgvPlan.DataSource = filter.CopyToDataTable();
                dgvPlan_CellClick(dgvPlan, new DataGridViewCellEventArgs(0, 0));
            }
            
        }

        public void OnAdd()     //추가
        {
            if (clickState == ButtonClick.None)
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }
        }

        public void OnEdit()    //수정
        {
            ((frmMain)this.MdiParent).BtnEditReturn(true);
            return;
        }

        public void OnDelete()  //삭제
        {
            ((frmMain)this.MdiParent).BtnEditReturn(true);
            return;
        }

        public void OnSave()    //저장
        {
            if (clickState == ButtonClick.Add) //추가
            {
                bool isVaild = WorkOrderValidChk();
                if (!isVaild)
                {
                    ((frmMain)this.MdiParent).AddClickEvent();
                    return;
                }

                WorkOrderDTO wo = new WorkOrderDTO
                {
                    Prd_Plan_No = dgvWorkOrder["Prd_Plan_No", rIdx].Value.ToString(),
                    Plan_Date = Convert.ToDateTime(dgvWorkOrder["Plan_Date", rIdx].Value),
                    Plan_Qty_Box = Convert.ToInt32(dgvWorkOrder["Plan_Qty_Box", rIdx].Value),
                    Wc_Code = dgvWorkOrder["Wc_Code", rIdx].Value.ToString(),
                    Item_Code = dgvWorkOrder["Item_Code", rIdx].Value.ToString(),
                    Ins_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                };

                bool result = woSrv.InserSiyuWorkOrder(wo);
                if (result)
                {
                    MessageBox.Show("작업지시 생성이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("작업지시 생성 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }

                clickState = ButtonClick.None;
                rIdx = -1;
                SetEditEnd();
                OnReLoad();
            }
            else
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }                
        }

        public void OnCancel()  //취소
        {
            if (clickState == ButtonClick.None)
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            if (clickState == ButtonClick.Add)
            {
                clickState = ButtonClick.None;
                filterWoDt.Rows.RemoveAt(rIdx);
                rIdx = -1;

                SetEditEnd();
            }

            if (dgvWorkOrder.Tag != null)
            {
                Dtp_CloseUp(dgvWorkOrder.Tag, null);
            }            
        }

        public void OnReLoad()  //새로고침
        {
            SetInit();
            LoadData();
        }

        #endregion

       
    }
}
