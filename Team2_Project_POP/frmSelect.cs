﻿using System;
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
            int screenWidh = ((Screen.PrimaryScreen.Bounds.Width - 120) / 50);
            lblTitle.Location = new Point(screenWidh * 50 / 2, 30);

            lbl1.Location = new Point(20, 20);
            lbl1.Size = new Size(screenWidh * 8, 80);
            
            lbl2.Location = new Point(40 + lbl1.Size.Width, 20);
            lbl2.Size = new Size(screenWidh * 26, 80);
            
            lbl3.Location = new Point(60 + lbl1.Size.Width + lbl2.Size.Width, 20);
            lbl3.Size = new Size(screenWidh * 8, 80);

            ucListSelect1.Location = new Point(0, 0);
            ucListSelect1.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 120, 120);
        }
    }
}