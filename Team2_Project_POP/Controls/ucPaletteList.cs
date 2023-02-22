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
    public partial class ucPaletteList : UserControl
    {
        public bool isClick { get; set; }
        public string WorkOrderNo { get; set; }
        public string PaletteNo { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string ItemSize { get; set; }
        public int BoxQty { get; set; }

        public event EventHandler ucPaletteList_click;

        public ucPaletteList()
        {
            InitializeComponent();
        }

        private void ucPaletteList_Load(object sender, EventArgs e)
        {
            lblWorkNo.Text = WorkOrderNo;
            lblPaletteNo.Text = PaletteNo;
            lblItemName.Text = ItemName;
            lblSize.Text = ItemSize;
            lblBoxQty.Text = String.Format("{0:0,0}", BoxQty);
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            if (ucPaletteList_click != null)
            {
                ucPaletteList_click(this, e);
            }
        }
    }
}
