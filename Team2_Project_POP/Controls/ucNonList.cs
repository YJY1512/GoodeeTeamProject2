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
    public partial class ucNonList : DevExpress.XtraEditors.XtraUserControl
    {
        public string NonMaName { get; set; }
        public string NonMiName { get; set; }
        public DateTime NonStartTime { get; set; }
        public DateTime NonEndTime { get; set; }
        public bool isClick { get; set; }

        public event EventHandler list_Click; 
        public ucNonList()
        {
            InitializeComponent();
        }

        private void frmNonList_Load(object sender, EventArgs e)
        {
            lblNonMa.Text = NonMaName;
            lblNonMi.Text = NonMiName;
            lblStartTime.Text = NonStartTime.ToString("yyyy-MM-dd HH-mm-ss");
            lblEndTime.Text = (NonStartTime.ToString("yyyy-MM-dd") == "1888-11-11") ? "-" : (NonStartTime.ToString("yyyy-MM-dd HH-mm-ss"));
        }

        private void lblNonMa_Click(object sender, EventArgs e)
        {
            if (list_Click != null)
            {
                list_Click(this, e);
            }
        }

        private void ucNonList_Click(object sender, EventArgs e)
        {
            if (list_Click != null)
            {
                list_Click(this, e);
            }
        }
    }
}
