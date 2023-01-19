using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Utils;

namespace Team2_Project
{
    public partial class frmWorkShopInfo : Team2_Project.frmListUpAreaDown
    {
        public frmWorkShopInfo()
        {
            InitializeComponent();
        }

        private void frmWorkShopInfo_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvWorkShop);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 상태", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 그룹", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "공정 코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "공정명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "모니터링여부", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "팔렛생성여부", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "사용여부", "", 150);
        }
    }
}
