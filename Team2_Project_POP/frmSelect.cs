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
using Team2_Project_DTO;

namespace Team2_Project_POP
{
    public partial class frmSelect : Form
    {
        PoPService ser = new PoPService();
        List<WorkCenterDTO> workCenterList = null;

        public frmSelect()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int screenWidh = ((Screen.PrimaryScreen.Bounds.Width - 120) / 50);
            lblTitle.Location = new Point(screenWidh * 50 / 2, 30);

            

            workCenterList = ser.GetWorkCenterInfo();

            //for(int i = 0; i < workCenterList.Count;i++)
            //{
            //    Controls.ucList list = new Controls.ucList();
            //    list.Location = new Point(0, i * 100);
            //    list.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 120, 100);
            //    list.Name = $"list{i}";
            //    list.Status = workCenterList[i].Wc_Status;
            //    list.Space = workCenterList[i].Wc_Name;
            //    list.Group = workCenterList[i].Wc_Group_Name;
            //    list.Tag = workCenterList[i].Wc_Code;
            //    list.ListClick += List_ListClick;
            //    list.ListMouseEnter += List_MouseEnter;
            //    list.ListMouseOut += List_MouseLeave;
            //    panel2.Controls.Add(list);
            //}
        }

        private void List_MouseLeave(object sender, EventArgs e)
        {
            ((Controls.ucList)sender).BackColor = Color.White;
        }

        private void List_MouseEnter(object sender, EventArgs e)
        {
            ((Controls.ucList)sender).BackColor = Color.Black;
        }

        private void List_ListClick(object sender, EventArgs e)
        {
            ((frmParent)this.MdiParent).LoginedWorkCenter = workCenterList.Find((work) => work.Wc_Code == ((Controls.ucList)sender).Tag.ToString());
            ((frmParent)this.MdiParent).lblSelected.Text = ((frmParent)this.MdiParent).LoginedWorkCenter.Wc_Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((((frmParent)this.MdiParent).LoginedWorkCenter == null))
            {
                MessageBox.Show("선택해주세요");
                return;
            }
            frmProductionList frm = new frmProductionList();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            this.Close();
            frm.Show();
        }
    }
}