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

            for (int i = 0; i < workCenterList.Count; i++)
            {
                Controls.ucSelectedList list = new Controls.ucSelectedList();
                //list.Location = new Point(0, i * 100);
                //list.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 120, 100);
                
                list.Size = new Size( 100,100);
                list.Dock = DockStyle.Top;
                list.Name = $"list{i}";
                list.Statuse = workCenterList[i].Wc_Status;
                list.WorkSpace = workCenterList[i].Wc_Name;
                list.Group = workCenterList[i].Wc_Group_Name;
                list.Tag = workCenterList[i].Wc_Code;
                if (list.Statuse == "Stop")
                    list.lblStatuse.BackColor = Color.Red;
                else if (list.Statuse == "Run")
                    list.lblStatuse.BackColor = Color.Green;
                list.lblWorkSpace.BackColor = list.lblGroup.BackColor = Color.LightSkyBlue;
                list.lblWorkSpace.ForeColor = list.lblGroup.ForeColor = Color.Black;
                list.ucListClick += List_ListClick;
             
                panel2.Controls.Add(list);
            }
        }

        private void List_ListClick(object sender, EventArgs e)
        {
            ((frmParent)this.MdiParent).LoginedWorkCenter = workCenterList.Find((work) => work.Wc_Code == ((Controls.ucSelectedList)sender).Tag.ToString());
            ((frmParent)this.MdiParent).LoginedOrders = ser.GetOrders(((frmParent)this.MdiParent).LoginedWorkCenter.Wc_Code);
            //확인후 코딩
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