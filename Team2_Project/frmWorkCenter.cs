using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmWorkCenter : frmListUpAreaDown
    {
        WorkCenterService srv = new WorkCenterService();
        List<WorkCenterDTO> wcList;
        public frmWorkCenter()
        {
            InitializeComponent();
        }

        private void frmWorkShopInfo_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvWorkShop);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 상태", "Wc_Status", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 코드", "Wc_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 명", "Wc_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 그룹 명", "Wc_Group_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "공정 코드", "Process_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "공정명", "Process_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "팔렛생성여부", "Pallet_YN", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "사용여부", "Use_YN", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "비고", "Remark", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 그룹 코드", "Wc_Group_Code", visible :false);
        }
        private void SetInitEditPnl()
        {
            foreach (Control ctrl in pnlArea.Controls)
            {
                if (ctrl is Label || ctrl is Panel)
                    continue;

                if (ctrl is TextBox)
                    ctrl.Text = "";

                ctrl.Enabled = false;
            }
        }

        #region 버튼 이벤트

        public void OnSearch()
        {

        }
        public void OnAdd()
        {

        }
        public void OnEdit()
        {

        }
        public void OnDelete()
        {

        }
        public void OnSave()
        {

        }
        public void OnCancel()
        {

        }
        public void OnReLoad()
        {

        }
        #endregion
    }
}
