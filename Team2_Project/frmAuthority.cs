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

    public partial class frmAuthority : frmList
    {
        string empID;
        public frmAuthority()
        {
            InitializeComponent();
        }

        private void frmAuthority_Load(object sender, EventArgs e)
        {
            empID = ((frmMain)this.MdiParent).LoginEmp.User_ID;

            DataGridViewUtil.SetInitDataGridView(dgvAuthority);
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, "", "모듈권한", 100);
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, "", "모듈권한", 100);
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, "", "모듈권한", 100);
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, "", "모듈권한", 100);
            //DataGridViewUtil.DataGridViewSetting(Dgv_Bom);
            //DataGridViewUtil.AddCheckBoxColumn(Dgv_Bom, "Checked", "선택", 40, frozen: true, visible: false);
            //DataGridViewUtil.AddTextColumn(Dgv_Bom, "PRODUCT_CODE", "     제품 코드", 105, true, DataGridViewContentAlignment.MiddleCenter, frozen: true);
        }
    }
}
