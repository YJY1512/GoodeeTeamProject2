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
    public partial class frmNop : frmList
    {
        public frmNop()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dataGridView1);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동발생일자", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동발생일시", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동해제일시", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동시간", "", 200);

            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "작업장코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "작업장명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "작업장그룹", "", 200);

            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "공정명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "공정그룹(작업장)", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "공정그룹(비가동)", "", 200);

            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동대분류코드", "", 200);

            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동상세분류코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동대분류명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동상세분류명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동유형", "", 200);


        }
    }
}

















