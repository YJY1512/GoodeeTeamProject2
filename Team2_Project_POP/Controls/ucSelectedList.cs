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
    public partial class ucSelectedList : UserControl
    {
        string statuse = "상  태";
        public string Statuse { get { return statuse; } set { statuse = value; } }
        string workSpace = "작 업 장";
        public string WorkSpace { get { return workSpace; } set { workSpace = value; } }
        string group = "그  룹";
        public string Group { get { return group; } set { group = value; } }
        public string isPalette { get; set; }
        public bool isClick { get; set; }


        public event EventHandler ucListClick;
     
        public ucSelectedList()
        {
            InitializeComponent();
        }

        private void ucSelectedList_Load(object sender, EventArgs e)
        {
            lblStatuse.Text = Statuse;
            lblWorkSpace.Text = WorkSpace;
            lblGroup.Text = Group;
        }

       

        private void ucSelectedList_Click(object sender, EventArgs e)
        {
            if (ucListClick != null)
            {
                ucListClick(this, e);
            }
        }
    }
}
