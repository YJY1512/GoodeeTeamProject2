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
        frmNonList selectedList = null;
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
            pnlNon.Controls.Clear();

            ((frmParent)MdiParent).NonList = ser.GetNonList(((frmParent)MdiParent).SelectedWorkLine.Wc_Code);

            for (int i = 0; i < ((frmParent)MdiParent).NonList.Count; i++)
            {
                frmNonList list = new frmNonList();

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

        private void List_list_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedList != null) return;

            frmNonOperateEnroll frm = new frmNonOperateEnroll();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedList == null) return;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedList == null) return;
        }
    }
}
