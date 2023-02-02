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
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "작업지시수량", "Plan_Qty_Box", 120, DataGridViewContentAlignment.MiddleRight);                      
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "거래처", "Company_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "납기일", "Delivery_Date", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획상태", "Prd_Plan_Status", 120, DataGridViewContentAlignment.MiddleCenter);


            DataGridViewUtil.SetInitDataGridView(dgvWorkOrder);
            DataGridViewCheckBoxColumn cbk2 = new DataGridViewCheckBoxColumn();
            cbk2.Width = 30;
            cbk2.Frozen = true;
            dgvWorkOrder.Columns.Add(cbk);





            LoadData();

            if (woDt != null && woDt.Rows.Count > 0)
            {
                dgvPlan_CellClick(dgvPlan, new DataGridViewCellEventArgs(0, 0));
            }
        }

        private void LoadData()
        {
            string planMonth = dtpMonth.Value.ToString("yyyy-MM");
            planDt = planSrv.GetPlan(planMonth);
            dgvPlan.DataSource = planDt;

            List<string> planID = new List<string>();
            foreach(DataRow row in planDt.Rows)
            {
                planID.Add(row["Prd_Plan_No"].ToString());
            }

            woDt = woSrv.GetWorkOrder(planID);
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

                    workOrder.Add(new WorkOrderDTO
                    {
                        Prd_Plan_No = row.Cells["Prd_Plan_No"].Value.ToString(),
                        Plan_Qty_Box = Convert.ToInt32(row.Cells["Plan_Qty"].Value),
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
        }
    }
}
