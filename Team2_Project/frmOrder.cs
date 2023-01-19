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
    public partial class frmOrder : frmList
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dataGridView1);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "생산요청코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "순번", "", 200);

            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "거래처명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "프로젝트명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "요청일자", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "납기일자", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "품목", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "품목코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "수량", "", 200);
        }
    }
}
