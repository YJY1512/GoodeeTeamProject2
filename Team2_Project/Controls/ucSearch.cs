using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Project.Controls
{
    public partial class ucSearch : UserControl
    {
        public event EventHandler BtnClick;

        public string _Code { 
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string _Name {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public ucSearch()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (BtnClick != null)
            {
                BtnClick(this, e);
            }
        }
    }
}
