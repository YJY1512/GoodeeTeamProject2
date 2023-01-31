﻿using System;
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
    public partial class ucListSelect : UserControl
    {
        public ucListSelect()
        {
            InitializeComponent();
        }

        private void ucListSelect_Load(object sender, EventArgs e)
        {
            int screenWidh = ((Screen.PrimaryScreen.Bounds.Width - 120) / 50);
            
            lbl1.Location = new Point(20, 10);
            lbl1.Size = new Size(screenWidh * 8, 80);

            lbl2.Location = new Point(40 + lbl1.Size.Width, 10);
            lbl2.Size = new Size(screenWidh * 26, 80);

            lbl3.Location = new Point(60 + lbl1.Size.Width + lbl2.Size.Width, 10);
            lbl3.Size = new Size(screenWidh * 8, 80);
        }
    }
}
