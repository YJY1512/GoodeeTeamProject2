using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Team2_Project_DTO;

namespace Team2_Project_POP
{
    public partial class frmParent : Form
    {
        // frmSelect에 리스트
        public List<WorkCenterDTO> WrokLineList { get; set; } 

        // frmSelect에서 선택된 작업장
        public WorkCenterDTO SelectedWorkLine { get; set; }

        // frmSelect에서 선택된 작업장의 작업지시 리스트
        public List<WorkOrderDTO> WorkOrderList { get; set; }

        // 선택된 작업장의 실적 리스트
        public PopPrdDTO SelectedWorkOrder { get; set; }
        // 
        public PopPrdQtyDTO PrdWork { get; set; }
        // 불량
        public PopDefQtyDTO DefWork { get; set; }

        public string DefMaCodeP { get; set; }
        //public string DefMaNameP { get; set; }
        public string DefMiCodeP { get; set; }
        //public string DefMiNameP { get; set; }
        //public int PDQtyP { get; set; }

        // 비가동 리스트
        public List<NonDTO> NonList { get; set; }

        // 팔레트 리스트
        public List<PaletteDTO> PaletteList { get; set; }

        public frmParent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            menuStrip1.Hide();
        }

        private void frmParent_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            frmSelect frm = new frmSelect();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            //MDI메뉴와 Child메뉴가 합쳐질때 발생하는 이벤트
            //최소화(&N) 이전 크기로(&R)  닫기(&C) ""
            //if (e.Item.Text == "" ||
            //    e.Item.Text == "최소화(&N)" ||
            //    e.Item.Text == "이전 크기로(&R)" ||
            //    e.Item.Text == "닫기(&C)")
            //    e.Item.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            Type frmType = this.ActiveMdiChild.GetType();
            if (frmType == typeof(frmSelect)) 
            {
                this.lblSelected.Text = "";
                return;
            }

            this.lblSelected.Text = "";
            this.WorkOrderList = null;
            this.SelectedWorkLine = null;

            foreach(Form frms in this.MdiChildren)
                frms.Close();
            
            frmSelect frm = new frmSelect();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            this.btnBack.Visible = false;
        }
    }
}
