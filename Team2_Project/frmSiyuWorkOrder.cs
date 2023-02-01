using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2_Project.Utils;

namespace Team2_Project
{
    public partial class frmSiyuWorkOrder : Team2_Project.frmListListUpDown
    {
        public frmSiyuWorkOrder()
        {
            InitializeComponent();
        }

        private void frmSiyuWorkOrder_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvPlan);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획번호", "Prd_Plan_No", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획월", "Plan_Month", align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "작업장코드", "Wc_Code", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "작업장명", "Wc_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "품목코드", "Item_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "품목명", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획량", "Plan_Qty", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "작업지시수량", "Plan_Qty_Box", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "거래처", "Company_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "납기일", "Delivery_Date", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획상태", "Prd_Plan_Status", 120, DataGridViewContentAlignment.MiddleCenter);
        }
    }
}
