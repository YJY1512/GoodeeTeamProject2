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
    public partial class frmProcessManagement : Team2_Project.frmListUpAreaDown
    {
        public event EventHandler BtnClick;
        public frmProcessManagement()
        {
            InitializeComponent();
        }

        private void frmProcessManagement_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvProcess);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "공정코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "공정명", "", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "공정그룹", "", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "비고", "", 900);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "사용유무", "", 120);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
