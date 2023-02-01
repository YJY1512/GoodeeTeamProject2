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
        int thisWitdh = 1300;
        public int ThisWitdh
        {
            get => thisWitdh;
            set => thisWitdh = value;
        }
        public event EventHandler ucListClick;
        public event EventHandler ucListEnter;
        public event EventHandler ucListLeave;


        public ucList()
        {
            InitializeComponent();
        }

        private void ucList_Load(object sender, EventArgs e)
        {
            int thisWitdhR = thisWitdh / 22;
            lbl1.Size = new Size(thisWitdhR * 3, 115);

            lblu2.Size = new Size(thisWitdhR * 4, 55);
            lbld2.Size = new Size(thisWitdhR * 4, 55);

            lblu3.Size = new Size(thisWitdhR * 4, 55);
            lbld3.Size = new Size(thisWitdhR * 4, 55);

            lblu4.Size = new Size(thisWitdhR * 2, 55);
            lbld4.Size = new Size(thisWitdhR * 2, 55);

            lblu5.Size = new Size(thisWitdhR * 4, 55);
            lbld5.Size = new Size(thisWitdhR * 4, 55);

            lbl6.Size = new Size((thisWitdhR * 5), 115);

            lbl1.Location = new Point(5, 5);

            lblu2.Location = new Point(lbl1.Location.X + lbl1.Size.Width + 5, 5);
            lbld2.Location = new Point(lbl1.Location.X + lbl1.Size.Width + 5, 65);

            lblu3.Location = new Point(lblu2.Location.X + lblu2.Size.Width + 5, 5);
            lbld3.Location = new Point(lblu2.Location.X + lblu2.Size.Width + 5, 65);

            lblu4.Location = new Point(lblu3.Location.X + lblu3.Size.Width + 5, 5);
            lbld4.Location = new Point(lblu3.Location.X + lblu3.Size.Width + 5, 65);

            lblu5.Location = new Point(lblu4.Location.X + lblu4.Size.Width + 5, 5);
            lbld5.Location = new Point(lblu4.Location.X + lblu4.Size.Width + 5, 65);

            lbl6.Location = new Point(lblu5.Location.X + lblu5.Size.Width + 5, 5);

        }
    }
}
