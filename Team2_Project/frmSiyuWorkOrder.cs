using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "거래처", "Company_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "납기일", "Delivery_Date", 120, DataGridViewContentAlignment.MiddleCenter);            
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획상태", "Prd_Plan_Status", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "작업지시일자", "Plan_Date", 120, DataGridViewContentAlignment.MiddleCenter, OrangebackColor: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "작업지시수량", "Plan_Qty_Box", 120, DataGridViewContentAlignment.MiddleRight, OrangebackColor: true);


            DataGridViewUtil.SetInitDataGridView(dgvWorkOrder);
            DataGridViewCheckBoxColumn cbk2 = new DataGridViewCheckBoxColumn();
            cbk2.Width = 30;
            cbk2.Frozen = true;
            dgvWorkOrder.Columns.Add(cbk2);

            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시상태", "Wo_Status", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시번호", "WorkOrderNo", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시일자", "Plan_Date", 120, DataGridViewContentAlignment.MiddleCenter, OrangebackColor: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시수량", "Plan_Qty_Box", 120, DataGridViewContentAlignment.MiddleRight, OrangebackColor:true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "품목코드", "Item_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "품목명", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업장코드", "Wc_Code", 120, OrangebackColor:true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업장명", "Wc_Name", 150, OrangebackColor:true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "생산일자", "Prd_Date", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "생산수량", "Prd_Qty", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "전달사항", "Remark", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "Wo_Status_code", "Wo_Status_code", visible:false);

            LoadData();

            if (woDt != null && woDt.Rows.Count > 0)
            {
                dgvPlan_CellClick(dgvPlan, new DataGridViewCellEventArgs(0, 0));                
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
            List<WorkOrderDTO> workOrder = new List<WorkOrderDTO>();

            foreach (DataGridViewRow row in dgvPlan.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    if (!row.Cells["Prd_Plan_Status"].Value.ToString().Equals("대기중"))
                    {
                        MessageBox.Show("대기상태인 생산계획만 작업지시가 가능합니다.");
                        return;
                    }

                    if (Convert.ToInt32(row.Cells["Plan_Qty_Box"].Value) == 0)
                    {
                        MessageBox.Show("작업지시수량을 입력해주세요.");
                        return;
                    }

                    workOrder.Add(new WorkOrderDTO
                    {
                        Prd_Plan_No = row.Cells["Prd_Plan_No"].Value.ToString(),
                        Plan_Date = Convert.ToDateTime(row.Cells["Plan_Date"].Value),
                        Plan_Qty_Box = Convert.ToInt32(row.Cells["Plan_Qty_Box"].Value),
                        Wc_Code = row.Cells["Wc_Code"].Value.ToString(),
                        Ins_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                    });
                }
            }

            if (workOrder.Count < 1)
            {
                MessageBox.Show("작업지시를 생성할 항목을 선택하여 주십시오.");
                return;
            }

            bool result = woSrv.InserWorkOrder(workOrder);
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

        private void dgvPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            int rIdx = dgvPlan.CurrentRow.Index;
            string planID = dgvPlan["Prd_Plan_No", rIdx].Value.ToString();

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

        private void dgvPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void SetDtpCell(DataGridViewCell cell)
        {
            dgvPlan.ScrollBars = ScrollBars.None;
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Visible = true;
            if (!string.IsNullOrWhiteSpace(cell.Value.ToString()))
                dtp.Value = DateTime.Parse(cell.Value.ToString());
            else
            {
                dtp.Value = DateTime.Now;
            }

            var rect = dgvPlan.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, true);
            dtp.Size = new Size(rect.Width, rect.Height);
            dtp.Location = new Point(rect.X, rect.Y);
            dgvPlan.Controls.Add(dtp);

            dtp.CloseUp += Dtp_CloseUp;
            dtp.TextChanged += Dtp_TextChanged;
        }

        private void Dtp_TextChanged(object sender, EventArgs e)
        {
            dgvPlan.SelectedRows[0].Cells["Plan_Date"].Value = ((DateTimePicker)sender).Value.ToString("yyyy-MM-dd");
        }

        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            ((DateTimePicker)sender).Visible = false;
            dgvPlan.Controls.Remove((DateTimePicker)sender);
            dgvPlan.ScrollBars = ScrollBars.Both;
        }

    }
}
