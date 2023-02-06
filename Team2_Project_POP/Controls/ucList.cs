using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Project_POP.Controls
{
    public partial class ucList : UserControl
    {
        public string       Status          { get; set; }
        public DateTime     PlanDate        { get; set; }
        public DateTime     ProductDate     { get; set; }
        public string       ProcessNum      { get; set; }
        public string       ProductName     { get; set; }
        public int          PlanQty         { get; set; }
        public int          IngQty          { get; set; }
        public DateTime     StartTime       { get; set; }
        public DateTime     FinishTime      { get; set; }
        public string       Remark          { get; set; }


        public event EventHandler ucListClick;
        public event EventHandler ucListEnter;
        public event EventHandler ucListLeave;
        public ucList()
        {
            InitializeComponent();
        }

        private void ucList_Load(object sender, EventArgs e)
        {
            lblStatuse.Text = Status;
            lblPlanDate.Text = PlanDate.ToString();
            lblProductDate.Text = ProductDate.ToString();
            lblProcessNum.Text = ProcessNum;
            lblProductName.Text = ProductName;
            lblPlanQty.Text = PlanQty.ToString();
            lblIngQty.Text = IngQty.ToString();
            lblStartTime.Text = StartTime.ToString();
            lblFinishTime.Text = FinishTime.ToString();
            lblRemark.Text = Remark;
        }

        private void lblStatuse_MouseEnter(object sender, EventArgs e)
        {
            if (ucListEnter != null)
            {
                ucListEnter(this, e);
            }
        }

        private void lblStatuse_MouseLeave(object sender, EventArgs e)
        {
            if (ucListLeave != null)
            {
                ucListLeave(this, e);
            }
        }

        private void lblStatuse_Click(object sender, EventArgs e)
        {
            if (ucListClick != null)
            {
                ucListClick(this, e);
            }
        }
    }
}
