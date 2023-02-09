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

namespace Team2_Project_POP
{
    public partial class frmCalcPop : Form
    {
        StringBuilder sb = new StringBuilder();
        
        public frmCalcPop()
        {
            InitializeComponent();
        }

        private void frmCalcPop_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            sb.Append(((Button)sender).Tag);
            txtCal.Text = sb.ToString();
        }

        private void btnZeroPoint_Click(object sender, EventArgs e)
        {
            sb.Clear();
            txtCal.Text = sb.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            sb.Remove(sb.Length - 1, 1);
            txtCal.Text = sb.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            ((frmParent)Owner).PDQtyP = Convert.ToInt32(sb.ToString());
         
            DialogResult = DialogResult.OK;
            
            this.Close();
        }
    }
}
