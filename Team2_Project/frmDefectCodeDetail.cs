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
    public partial class frmDefectCodeDetail : Team2_Project.BaseForms.frmCodeControlBase
    {
        public frmDefectCodeDetail()
        {
            InitializeComponent();
        }

        private void frmDefectCodeDetail_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvMa);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "불량현상 대분류코드", "Def_Ma_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "불량현상 대분류명", "Def_Ma_Name", 250);

            DataGridViewUtil.SetInitDataGridView(dgvMi);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "불량현상 상세분류코드", "Def_Mi_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "불량현상 상세분류명", "Def_Ma_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "정렬순서", "Sort_Index");
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "사용유무", "Use_YN");
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Remark", "Remark", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Def_Ma_Code", "Def_Ma_Code", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Def_Ma_Name", "Def_Ma_Name", visible: false);

            CommonCodeUtil.UseYNComboBinding(cboSearchUse);
            CommonCodeUtil.UseYNComboBinding(cboUseYN, false);
            cboSearchUse.SelectedIndex = 0;
        }


    }
}
