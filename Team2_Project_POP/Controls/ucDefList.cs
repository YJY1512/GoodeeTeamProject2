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
    public partial class ucDefList : UserControl
    {
        public DateTime PrdDate { get; set; }
        public int Qty { get; set; }
        public string DefMaCode { get; set; }
        public string DefMaName { get; set; }
        public string DefMiCode { get; set; }
        public string DefMiName { get; set; }
        public bool isClick { get; set; }

        public event EventHandler ucDefListClick;
        public ucDefList()
        {
            InitializeComponent();
        }

        private void ucDefList_Load(object sender, EventArgs e)
        {
            lblDate.Text = PrdDate.ToString("yyyy-MM-dd HH:mm:ss");
            lblDefMiName.Text = DefMiName;
            lblDefQty.Text = Qty.ToString();
        }
    }
}
