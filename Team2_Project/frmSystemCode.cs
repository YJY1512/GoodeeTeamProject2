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

namespace Team2_Project
{
    public partial class frmSystemCode : frmCodeControlBase
    {
        public frmSystemCode()
        {
            InitializeComponent();
        }

        private void frmSystemCode_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dataGridView1);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "시스템정의 대분류코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "시스템정의 대분류명", "", 200);

            DataGridViewUtil.SetInitDataGridView(dataGridView2);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView2, "시스템정의 상세분류코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView2, "시스템정의 상세분류명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView2, "정렬순서", "", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView2, "비고", "", 400);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView2, "사용유무", "", 100);
        }
    }
}
