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
    public partial class frmPlan : Form
    {
        public frmPlan()
        {
            InitializeComponent();
        }

        private void frmPlan_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvReq);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "생산요청번호", "Prd_Req_No", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "의뢰일", "Req_Date");
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "순번", "Req_Seq");
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "납기일자", "Delivery_Date");
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "작업장코드", "");
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "작업장명", "");
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "품목", "Item_Name");
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "요청수량", "Req_Qty");




            DataGridViewUtil.SetInitDataGridView(dgvDetail);

            DataGridViewUtil.SetInitDataGridView(dgvPlan);
        }
    }
}
