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
    public partial class ucPrdList : UserControl
    {
        public DateTime PrdDate { get; set; }
        public int Qty { get; set; }
        public bool isClick { get; set; }


        public event EventHandler ucPrdListClick;
        public ucPrdList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ucPrdList_Load(object sender, EventArgs e)
        {
            lblDate.Text = PrdDate.ToString("yyyy-MM-dd HH:mm:ss");
            lblQty.Text = Qty.ToString();
            isClick = false;
        } 
    }
}
