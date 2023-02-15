using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project_DTO;
using Team2_Project_POP.Services;
using Team2_Project_POP.Utils;

namespace Team2_Project_POP
{
    public partial class frmDefListPopUp : Form
    {
        PoPService ser = new PoPService();
        List<DefVO> defList = new List<DefVO>();

        


        public frmDefListPopUp()
        {
            InitializeComponent();
        }

        private void frmDefListPopUp_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvMaDef);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaDef, "대분류", "Name", 350, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaDef, "대분류", "Code", 350, align: DataGridViewContentAlignment.MiddleCenter, visible: false);
            DataGridViewUtil.SetInitDataGridView(dgvMiDef);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiDef, "세분류", "Name", 350, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiDef, "세분류", "Code", 350, align: DataGridViewContentAlignment.MiddleCenter, visible: false);

            defList = ser.GetDefLIST();

            if (defList == null)
            {
                MessageBox.Show("불량 코드에 문제가 생겼습니다."); 
                return; 
            }

            var defmalist = defList.FindAll((ma) => ma.Parent == "").ToList();

            dgvMaDef.DataSource = defmalist;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ((frmParent)Owner).DefMaCodeP = dgvMaDef.SelectedRows[0].Cells[1].Value.ToString();
            ((frmParent)Owner).DefMiCodeP = dgvMiDef.SelectedRows[0].Cells[1].Value.ToString();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvMaDef_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            var defmilist = defList.FindAll((ma) => ma.Parent == dgvMaDef["Code", e.RowIndex].Value.ToString()).ToList();
            dgvMiDef.DataSource = defmilist;


            dgvMiDef.Refresh();

           
        }

        private void dgvMiDef_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }

     
}
