using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Controls;
using Team2_Project.Services;
using Team2_Project.Utils;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmWorkOrder : Team2_Project.frmListUpAreaDown
    {
        List<WorkCenterDTO> wcList;
        List<ItemDTO> itemList;
        List<ProcessMasterDTO> prcList;
        List<WorkOrderDTO> woList;

        WorkOrderService srv = new WorkOrderService();

        enum ButtonClick { Add, Edit, None };
        ButtonClick clickState;

        public frmWorkOrder()
        {
            InitializeComponent();
        }

        private void txtWoQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void frmWorkOrder_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvWorkOrder);
            DataGridViewCheckBoxColumn cbk2 = new DataGridViewCheckBoxColumn();
            cbk2.Width = 30;
            cbk2.Frozen = true;
            dgvWorkOrder.Columns.Add(cbk2);

            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시상태", "Wo_Status", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시번호", "WorkOrderNo", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시일자", "Plan_Date", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시수량", "Plan_Qty_Box", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "품목코드", "Item_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "품목명", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업장코드", "Wc_Code", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업장명", "Wc_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "생산일자", "Prd_Date", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "생산수량", "Prd_Qty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "Wo_Status_code", "Wo_Status_code", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "Process_Code", "Process_Code", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "Process_Name", "Process_Name", visible: false);

            SetInit();
            LoadData();            
        }

        private void LoadData()
        {
            woList = srv.GetWorkOrder(dtpWoFrom.Value.ToShortDateString(), dtpWoTo.Value.ToShortDateString());
            dgvWorkOrder.DataSource = woList;

            if (woList != null && woList.Count > 0)
            {
                if (dgvWorkOrder.CurrentRow != null)
                    dgvWorkOrder_CellClick(dgvWorkOrder, new DataGridViewCellEventArgs(0, dgvWorkOrder.CurrentRow.Index));
            }
        }

        private void SetInit()
        {
            dtpWoFrom.Value = DateTime.Today;
            dtpWoTo.Value = dtpWoFrom.Value.AddDays(1);

            ucProcess._Code = ucProcess._Name = "";
            ucProd._Code = ucProd._Name = "";
            ucWc._Code = ucWc._Name = "";

            SetInitPnl();
        }

        private void SetInitPnl()
        {
            ucProcess2.Enabled = ucProd2.Enabled = ucWc2.Enabled = false;
            dtpWo.Enabled = false;
            txtWoQty.Enabled = false;

            txtWorkOrder.Text = "시스템 자동생성";
            ucProcess2._Code = ucProcess2._Name = "";
            ucProd2._Code = ucProd2._Name = "";
            ucWc2._Code = ucWc2._Name = "";
            dtpWo.Value = DateTime.Today;
            txtWoQty.Text = "";
        }

        #region 작업지시 dgv 컨트롤 버튼(마감, 마감취소)

        //작업지시 dgv 버튼 enable 상태 설정
        private void SetWobtnEnabled(bool active)
        {
            btnClose.Enabled = btnCancel.Enabled = active;
        }
        private void SetEditStart()
        {
            dgvWorkOrder.Enabled = false;
            SetWobtnEnabled(false);
        }
        private void SetEditEnd()
        {
            dgvWorkOrder.Enabled = true;
            SetWobtnEnabled(true);
        }

        private void btnClose_Click(object sender, EventArgs e) //작업지시 마감
        {
            SetEditStart();

            List<string> woIds = new List<string>();
            foreach (DataGridViewRow row in dgvWorkOrder.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    string woID = row.Cells["WorkOrderNo"].Value.ToString();
                    string status = srv.ChkStatus(woID);
                    if (!status.Equals("W04")) //현장마감
                    {
                        MessageBox.Show("현장마감된 작업지시만 마감이 가능합니다.");
                        ((frmMain)this.MdiParent).BtnEditReturn(true);
                        SetEditEnd();
                        return;
                    }

                    woIds.Add(row.Cells["WorkOrderNo"].Value.ToString());
                }
            }

            if (woIds.Count < 1)
            {
                MessageBox.Show("마감할 항목을 선택하여 주십시오.");
                SetEditEnd();
                return;
            }

            string empID = ((frmMain)this.MdiParent).LoginEmp.User_ID;

            bool result = srv.CloseWorkOrder(woIds, empID);
            if (result)
            {
                MessageBox.Show("마감처리가 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("마감처리 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
            }

            SetEditEnd();
            OnReLoad();
        }

        private void btnCancel_Click(object sender, EventArgs e) //작업지시 마감취소
        {
            SetEditStart();

            List<string> woIds = new List<string>();
            foreach (DataGridViewRow row in dgvWorkOrder.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    string woID = row.Cells["WorkOrderNo"].Value.ToString();
                    string status = srv.ChkStatus(woID);
                    if (!status.Equals("W05")) //작업지시마감
                    {
                        MessageBox.Show("마감된 작업지시가 아닙니다.");
                        ((frmMain)this.MdiParent).BtnEditReturn(true);
                        SetEditEnd();
                        return;
                    }

                    woIds.Add(row.Cells["WorkOrderNo"].Value.ToString());
                }
            }

            if (woIds.Count < 1)
            {
                MessageBox.Show("마감취소할 항목을 선택하여 주십시오.");
                SetEditEnd();
                return;
            }

            string empID = ((frmMain)this.MdiParent).LoginEmp.User_ID;

            bool result = srv.CloseCancel(woIds, empID);
            if (result)
            {
                MessageBox.Show("마감취소가 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("마감취소 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
            }

            SetEditEnd();
            OnReLoad();

        }
        #endregion


        private void dgvWorkOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            txtWorkOrder.Text = dgvWorkOrder["WorkOrderNo", e.RowIndex].Value.ToString();
            ucProd2._Code = dgvWorkOrder["Item_Code", e.RowIndex].Value.ToString();
            ucProd2._Name = dgvWorkOrder["Item_Name", e.RowIndex].Value.ToString();
            ucProcess2._Code = dgvWorkOrder["Process_Code", e.RowIndex].Value.ToString();
            ucProcess2._Name = dgvWorkOrder["Process_Name", e.RowIndex].Value.ToString();
            ucWc2._Code = dgvWorkOrder["Wc_Code", e.RowIndex].Value.ToString();
            ucWc2._Name = dgvWorkOrder["Wc_Name", e.RowIndex].Value.ToString();
            txtWoQty.Text = dgvWorkOrder["Plan_Qty_Box", e.RowIndex].Value.ToString();
            dtpWo.Value = Convert.ToDateTime(dgvWorkOrder["Plan_Date", e.RowIndex].Value);
        }

        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            string itemCode = ucProd._Code;
            string prcCode = ucProcess._Code;
            string wcCode = ucWc._Code;

            if (string.IsNullOrWhiteSpace(itemCode) && string.IsNullOrWhiteSpace(prcCode) && string.IsNullOrWhiteSpace(wcCode))
            {
                LoadData();
                return;
            }

            var list = (from c in woList
                        where c.Item_Code == (string.IsNullOrWhiteSpace(itemCode) ? c.Item_Code : itemCode) &&
                            c.Process_Code == (string.IsNullOrWhiteSpace(prcCode) ? c.Process_Code : prcCode) &&
                            c.Wc_Code == (string.IsNullOrWhiteSpace(wcCode) ? c.Wc_Code : wcCode)
                        select c).ToList();

            if (list != null && list.Count > 0)
            {
                dgvWorkOrder.DataSource = list;
                dgvWorkOrder_CellClick(dgvWorkOrder, new DataGridViewCellEventArgs(0, 0));
            }
            else
            {
                dgvWorkOrder.DataSource = null;
                SetInitPnl();
            }
        }

        public void OnAdd()     //추가
        {
            SetInitPnl();
            SetEditStart();

            ucProcess2.Enabled = ucProd2.Enabled = ucWc2.Enabled = true;
            dtpWo.Enabled = true;
            txtWoQty.Enabled = true;

            clickState = ButtonClick.Add;
        }

        public void OnEdit()    //수정
        {
            SetEditStart();

            int rIdx = dgvWorkOrder.CurrentRow.Index;
            string woID = dgvWorkOrder["WorkOrderNo", rIdx].Value.ToString();
            string status = srv.ChkStatus(woID);
            if (!status.Equals("W01")) //생산대기
            {
                MessageBox.Show("생산대기중인 작업지시만 수정이 가능합니다.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                SetEditEnd();
                return;
            }

            ucProcess2.Enabled = ucProd2.Enabled = ucWc2.Enabled = true;
            dtpWo.Enabled = true;
            txtWoQty.Enabled = true;

            clickState = ButtonClick.Edit;
        }

        public void OnDelete()  //삭제
        {
            SetEditStart();

            List<string> delIds = new List<string>();
            foreach (DataGridViewRow row in dgvWorkOrder.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    string woID = row.Cells["WorkOrderNo"].Value.ToString();
                    string status = srv.ChkStatus(woID);
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
            bool result = srv.DeleteWorkOrder(delIds, upEmp);
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

        public void OnSave()    //저장
        {
            bool isVaild = WorkOrderValidChk();
            if (!isVaild)
            {
                ((frmMain)this.MdiParent).AddClickEvent();
                return;
            }

            if (clickState == ButtonClick.Add) //추가
            {
                WorkOrderDTO wo = new WorkOrderDTO
                {
                    Plan_Date = dtpWo.Value,
                    Plan_Qty_Box = Convert.ToInt32(txtWoQty.Text),
                    Wc_Code = ucWc2._Code,
                    Item_Code = ucProd2._Code,
                    Ins_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                };

                bool result = srv.InserWorkOrder(wo);
                if (result)
                {
                    MessageBox.Show("작업지시 생성이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("작업지시 생성 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }
            else if (clickState == ButtonClick.Edit)
            {
                WorkOrderDTO wo = new WorkOrderDTO
                {
                    Plan_Date = dtpWo.Value,
                    Plan_Qty_Box = Convert.ToInt32(txtWoQty.Text),
                    Wc_Code = ucWc2._Code,
                    Item_Code = ucProd2._Code,
                    Up_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID,
                    WorkOrderNo = txtWorkOrder.Text
                };

                bool result = srv.UpdateWorkOrder(wo);
                if (result)
                {
                    MessageBox.Show("작업지시 수정이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("작업지시 수정 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }

            clickState = ButtonClick.None;
            SetEditEnd();
            OnReLoad();
        }

        public void OnCancel()  //취소
        {
            SetInitPnl();
            SetEditEnd();
            clickState = ButtonClick.None;
        }

        public void OnReLoad()  //새로고침
        {
            SetInit();
            LoadData();
        }

        #endregion


        //유효성 체크
        private bool WorkOrderValidChk()
        {
            if (string.IsNullOrWhiteSpace(ucProcess2._Code) ||
                    string.IsNullOrWhiteSpace(ucProcess2._Name))
            {
                MessageBox.Show("공정 정보를 입력해주세요.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ucWc2._Code) ||
                    string.IsNullOrWhiteSpace(ucWc2._Name))
            {
                MessageBox.Show("작업장 정보를 입력해주세요.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ucProd2._Code) ||
                   string.IsNullOrWhiteSpace(ucProd2._Name))
            {
                MessageBox.Show("품목 정보를 입력해주세요.");
                return false;
            }

            if (dtpWo.Value < DateTime.Today)
            {
                MessageBox.Show("작업지시 일자는 오늘 이전으로 설정할 수 없습니다.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtWoQty.Text) || Convert.ToInt32(txtWoQty.Text) == 0)
            {
                MessageBox.Show("작업지시 수량을 입력해주세요.");
                return false;
            }

            return true;
        }


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

        private CommonPop<ProcessMasterDTO> GetProcessPopInfo()
        {
            if (prcList == null)
            {
                ProcessMasterService srv = new ProcessMasterService();
                prcList = srv.GetPrcCodeName();
            }

            CommonPop<ProcessMasterDTO> prcPopInfo = new CommonPop<ProcessMasterDTO>();
            prcPopInfo.DgvDatasource = prcList;
            prcPopInfo.PopName = "공정 검색";

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("공정코드", "Process_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("공정명", "Process_Name", 200));

            prcPopInfo.DgvCols = colList;

            return prcPopInfo;
        }
        #endregion

        private void ucProd_BtnClick(object sender, EventArgs e)
        {
            ucSearch ucProd = (ucSearch)sender;
            ucProd.OpenPop(GetItemPopInfo());
        }

        private void ucWc_BtnClick(object sender, EventArgs e)
        {
            ucSearch ucWc = (ucSearch)sender;
            ucWc.OpenPop(GetWcPopInfo());
        }

        private void ucProcess_BtnClick(object sender, EventArgs e)
        {
            ucSearch ucProcess = (ucSearch)sender;
            ucProcess.OpenPop(GetProcessPopInfo());
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
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.ForeColor = Color.Black;
                    break;
                case "W02": //생산중
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.BackColor = Color.ForestGreen;
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.ForeColor = Color.Black;
                    break;
                case "W03": //생산중지
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.BackColor = Color.Gold;
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.ForeColor = Color.Black;
                    break;
                case "W04": //현장마감
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.BackColor = Color.LightSkyBlue;
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.ForeColor = Color.Black;
                    break;
                case "W05": //작업지시마감
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.BackColor = Color.DarkBlue;
                    dgvWorkOrder["Wo_Status", e.RowIndex].Style.ForeColor = Color.White;
                    break;
                default: break;
            }
        }
    }
}
