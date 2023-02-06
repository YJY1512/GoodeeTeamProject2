using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project_POP.Services;

namespace Team2_Project_POP
{
    public partial class frmProductionList : Form
    {
        PoPService popSrv = new PoPService();

        public frmProductionList()
        {
            InitializeComponent();
        }

        private void frmProductionList_Load(object sender, EventArgs e)
        {
            int screenWidh = Screen.PrimaryScreen.Bounds.Width;
            btnStart.Size = btnStop.Size = btnPalette.Size = btnPerfomance.Size = btnFinish.Size = btnNonP.Size = new Size(screenWidh / 6, 150);
            btnStop.Location = new Point((screenWidh / 6), 0);
            btnPalette.Location = new Point((screenWidh / 6) * 2, 0);
            btnPerfomance.Location = new Point((screenWidh / 6) * 3, 0);
            btnFinish.Location = new Point((screenWidh / 6) * 4, 0);
            btnNonP.Location = new Point((screenWidh / 6) * 5, 0);

            //popSrv.GetOrders();


        }

       
    }
}