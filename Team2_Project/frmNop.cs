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
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동 등록 날짜", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동 발생 일시", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동 종료 일시", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동 시간", "", 200);

            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "작업장코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "작업장명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비가동 사유", "", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "비고", "", 400);

        }
    }
}
