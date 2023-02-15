using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project_POP.Controls;
using Team2_Project_POP.Services;

namespace Team2_Project_POP
{
    public partial class frmNonOperate : Form
    {
        ucNonList selectedList = null;
        PoPService ser = new PoPService();

        public frmNonOperate()
        {
            InitializeComponent();
        }

        private void frmNonOperate_Load(object sender, EventArgs e)
        {

        }

        private void frmNonOperate_Activated(object sender, EventArgs e)
        {
            
        }

        private void List_list_Click(object sender, EventArgs e)
        {
            selectedList = ((ucNonList)sender);
            foreach(var item in pnlNon.Controls)
            {
                ((ucNonList)item).isClick = false;
                ((ucNonList)item).tableLayoutPanel1.BackColor = Color.White;
            }
            ((ucNonList)sender).isClick = true;

            ((ucNonList)sender).tableLayoutPanel1.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedList != null) return;

            frmNonOperateEnroll frm = new frmNonOperateEnroll();
            frm.MdiParent = MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();


            selectedList = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedList == null) return;




            selectedList = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedList == null) return;




            selectedList = null;
        }

        private void frmNonOperate_Enter(object sender, EventArgs e)
        {
            pnlNon.Controls.Clear();

            ((frmParent)MdiParent).NonList = ser.GetNonList(((frmParent)MdiParent).SelectedWorkLine.Wc_Code);

            for (int i = 0; i < ((frmParent)MdiParent).NonList.Count; i++)
            {
                ucNonList list = new ucNonList();

                list.Name = $"list{i}";
                list.Size = new Size(100, 80);
                list.Dock = DockStyle.Top;
                list.NonMaName = ((frmParent)MdiParent).NonList[i].NonTypeName;
                list.NonMiName = ((frmParent)MdiParent).NonList[i].NonMiName;
                list.NonStartTime = ((frmParent)MdiParent).NonList[i].NonHappenTime;

                list.list_Click += List_list_Click;
                pnlNon.Controls.Add(list);
            }
        }
    }
}
