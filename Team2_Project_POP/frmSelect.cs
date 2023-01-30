using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Project_POP
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int screenWidh = ((Screen.PrimaryScreen.Bounds.Width - 120) / 100);
            lblTitle.Location = new Point(screenWidh * 50 / 2, 30);

            lbl1.Location = new Point(20, 10);
            lbl1.Size = new Size(360, 80);
            //lbl2.Visible = lbl3.Visible = false;
            lbl2.Location = new Point(400, 10);
            lbl3.Location = new Point(2 * screenWidh + screenWidh * 12, 10);
            lbl3.Size = new Size(720, 80);
            
        }
    }
}