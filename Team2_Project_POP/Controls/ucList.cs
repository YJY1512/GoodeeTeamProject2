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
        public string       Status_Code          { get; set; }
        public DateTime     Plan_Date { get; set; }
        public DateTime     Prd_Date { get; set; }
        public string       WorkOrderNo { get; set; }
        public string       ItemName     { get; set; }
        public string       ItemCode     { get; set; }
        public int          PlanQty         { get; set; }
        public int          Prd_Qty { get; set; }
        public DateTime     StartTime       { get; set; }
        public DateTime     EndTime      { get; set; }
        public string       Remark          { get; set; }
        public string       Wc_Code { get; set; }
        public bool isClick { get; set; }


        public event EventHandler UcListClick;
        
        public ucList()
        {
            InitializeComponent();
        }

        private void ucList_Load(object sender, EventArgs e)
        {
            //lblStatuse.Text = Status;
            
            lblStatuse.Text = Status;
            switch (Status_Code)
            {
                case "W01":
                    lblStatuse.BackColor = Color.Orange;
                    break;
                case "W02":
                    lblStatuse.BackColor = Color.Green;
                    break;
                case "W03":
                    lblStatuse.BackColor = Color.Yellow;
                    break;
                case "W04":
                    lblStatuse.BackColor = Color.DarkBlue;
                    lblStatuse.ForeColor = Color.White;
                    break;
            }
            lblPlanDate.Text = Plan_Date.ToString("yyyy-MM-dd");
            lblProductDate.Text = (Prd_Date.ToString("yyyy-MM-dd") == "0001-01-01") ? "-" : Prd_Date.ToString("yyyy-MM-dd");
            lblProcessNum.Text = WorkOrderNo;
            lblProductName.Text = ItemName;
            lblPlanQty.Text = String.Format("{0:0,0}", PlanQty);
            lblIngQty.Text = String.Format("{0:0}", Prd_Qty);
            lblStartTime.Text = (StartTime.ToString("HH:mm:ss") == "00:00:00") ? "-" : StartTime.ToString("HH:mm:ss");
            lblFinishTime.Text = (EndTime.ToString("HH:mm:ss") == "00:00:00") ? "-" : EndTime.ToString("HH:mm:ss"); ;
            lblRemark.Text = Remark;
        }

        
        private void lblRemark_Click(object sender, EventArgs e)
        {
            if (UcListClick != null)
            {
                UcListClick(this, e);
            }
        }
    }
}
