using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Project
{
    public partial class frmPlanPop : Form
    {
        private int BeforeSplitPlanQty;

        public enum OpenMode { Edit, Split };
        public OpenMode mode { get; set; }

        public frmPlanPop()
        {
            InitializeComponent();
        }

        public string PlanID 
        { 
            get { return txtPlanID.Text; }
            set { this.txtPlanID.Text = value; } 
        }

        public int Qty
        {
            get { return Convert.ToInt32(txtQty.Text); }
            set 
            { 
                if (mode == OpenMode.Split)
                {
                    BeforeSplitPlanQty = value;
                    this.txtQty.Text = "0";
                }
                else
                {
                    this.txtQty.Text = value.ToString();
                }                    
            }
        }

        private void frmPlanPop_Load(object sender, EventArgs e)
        {
            if (mode == OpenMode.Edit)
            {
                this.Text = "생산계획 수정";
                label2.Text = "계획수량";
            }
            else if (mode == OpenMode.Split)
            {
                this.Text = "생산계획 분할";
                label2.Text = "분할수량";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQty.Text) || txtQty.Text == "0")
            {
                MessageBox.Show("수량을 입력하여 주십시오.");
                return;
            }

            if (mode == OpenMode.Split && BeforeSplitPlanQty < Convert.ToInt32(txtQty.Text))
            {
                MessageBox.Show("분할 수량이 기존 계획 수량보다 많습니다. 다시 입력하여 주십시오.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
