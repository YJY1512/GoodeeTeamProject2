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

        List<WorkCenterDTO> wcList;

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
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획량", "Plan_Qty", 120, DataGridViewContentAlignment.MiddleRight);
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
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "전달사항", "Remark", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "Wo_Status_code", "Wo_Status_code", visible: false);
            dgvWorkOrder.Columns["Plan_Qty_Box"].ReadOnly = false;

            LoadData();

            if (woDt != null && woDt.Rows.Count > 0)
            {
                dgvPlan_CellClick(dgvPlan, new DataGridViewCellEventArgs(0, 0));
                dgvPlan[0, 0].Value = false;
            }
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

            woDt = woSrv.GetWorkOrder(planMonth);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rIdx = dgvPlan.CurrentRow.Index;
            if (!Convert.ToBoolean(dgvPlan[0, rIdx].Value))
            {
                MessageBox.Show("작업지시를 생성할 항목을 선택하여 주십시오.");
                return;
            }

            if (!dgvPlan["Prd_Plan_Status", rIdx].Value.ToString().Equals("대기중"))
            {
                MessageBox.Show("대기상태인 생산계획만 작업지시 생성이 가능합니다.");
                return;
            }

            frmSiyuPop pop = new frmSiyuPop();
            pop.PlanInfo = new PlanDTO
            {
                Prd_Plan_No = dgvPlan["Prd_Plan_No", rIdx].Value.ToString(),
                Wc_Code = dgvPlan["Wc_Code", rIdx].Value.ToString(),
                Wc_Name = dgvPlan["Wc_Name", rIdx].Value.ToString(),
                Item_Code = dgvPlan["Item_Code", rIdx].Value.ToString(),
                Item_Name = dgvPlan["Item_Code", rIdx].Value.ToString(),
                Plan_Month = dgvPlan["Plan_Month", rIdx].Value.ToString(),
                Plan_Qty = Convert.ToInt32(dgvPlan["Plan_Qty", rIdx].Value)
            };
            pop.UserId = ((frmMain)this.MdiParent).LoginEmp.User_ID;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                bool result = woSrv.InserWorkOrder(pop.WoInfo);

                if (result)
                {
                    MessageBox.Show("작업지시 생성이 완료되었습니다.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("계획생성 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }

            
        }

        private void dgvPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

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
                    break;
                default: break;
            }
        }

        private void dgvWorkOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (e.ColumnIndex == dgvWorkOrder.Columns["Plan_Date"].Index)
            {
                SetDtpCell(dgvWorkOrder[e.ColumnIndex, e.RowIndex]);
            }
            else if (e.ColumnIndex == dgvWorkOrder.Columns["Wc_Code"].Index || e.ColumnIndex == dgvWorkOrder.Columns["Wc_Name"].Index)
            {
                OpenPop<WorkCenterDTO>(GetWcPopInfo(), dgvWorkOrder, e.RowIndex);
            }
        }


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

    }
}
