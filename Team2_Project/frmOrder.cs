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
    public partial class frmOrder : frmList
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvOrder);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "생산요청코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "순번", "", 200);

            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "거래처명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "프로젝트명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "요청일자", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "납기일자", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "품목", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "품목코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "수량", "", 200);
        }
    }
}
