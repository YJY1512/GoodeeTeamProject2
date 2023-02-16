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
        //List<WorkCenterDTO> workCenterList = null;

        public frmSelect()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 라벨 위치
            int screenWidh = ((Screen.PrimaryScreen.Bounds.Width - 120) / 50);
            lblTitle.Location = new Point(screenWidh * 50 / 2, 30);
        }

        private void frmSelect_Activated(object sender, EventArgs e)
        {
            // 작업장 리스트 DB 가져오기
            ((frmParent)MdiParent).WrokLineList = ser.GetWorkCenterInfo();
            // 작업장 리스트 만들기
            for (int i = 0; i < ((frmParent)MdiParent).WrokLineList.Count; i++)
            {
                Controls.ucSelectedList list = new Controls.ucSelectedList();
                //list.Location = new Point(0, i * 100);
                //list.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 120, 100);

                list.Size = new Size(100, 100);
                list.Dock = DockStyle.Top;
                list.Name = $"list{i}";
                list.Statuse = ((frmParent)MdiParent).WrokLineList[i].Wc_Status;
                list.WorkSpace = ((frmParent)MdiParent).WrokLineList[i].Wc_Name;
                list.isPalette = ((frmParent)MdiParent).WrokLineList[i].Pallet_YN;
                list.Group = ((frmParent)MdiParent).WrokLineList[i].Wc_Group_Name;
                list.Tag = ((frmParent)MdiParent).WrokLineList[i].Wc_Code;
                if (list.Statuse == "RUN")
                    list.lblStatuse.BackColor = Color.Green;
                else if (list.Statuse == "STOP")
                    list.lblStatuse.BackColor = Color.Red;
                list.lblWorkSpace.BackColor = list.lblGroup.BackColor = Color.LightSkyBlue;
                list.lblWorkSpace.ForeColor = list.lblGroup.ForeColor = Color.Black;
                list.ucListClick += List_ListClick;

                panel2.Controls.Add(list);
            }
        }

        private void List_ListClick(object sender, EventArgs e)
        {
            //작업장 리스트 중에 작업장을 선택
            ((frmParent)this.MdiParent).SelectedWorkLine = ((frmParent)MdiParent).WrokLineList.Find((work) => work.Wc_Code == ((Controls.ucSelectedList)sender).Tag.ToString());
            ((frmParent)this.MdiParent).lblSelected.Text = ((frmParent)this.MdiParent).SelectedWorkLine.Wc_Name;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((((frmParent)this.MdiParent).SelectedWorkLine == null))
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