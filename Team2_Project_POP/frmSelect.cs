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
using Team2_Project_POP.Controls;

namespace Team2_Project_POP
{
    public partial class frmSelect : Form
    {
        PoPService ser = new PoPService();
        int pages = 1;
        ucSelectedList selected = null;
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

        private void List_ListClick(object sender, EventArgs e)
        {
            //작업장 리스트 중에 작업장을 선택
            

            //
            if (((Controls.ucSelectedList)sender).isClick)
            {
                ((Controls.ucSelectedList)sender).isClick = false;
                selected = null;
                ((frmParent)MdiParent).SelectedWorkOrder = new PopPrdDTO();

                ((Controls.ucSelectedList)sender).lblWorkSpace.BackColor = Color.White;
                ((Controls.ucSelectedList)sender).lblGroup.BackColor = Color.White;

                ((frmParent)this.MdiParent).SelectedWorkLine = null;
                ((frmParent)this.MdiParent).lblSelected.Text = "";

            }
            else
            {
                foreach (var listitem in pnlList.Controls)
                {
                    if (((Controls.ucSelectedList)listitem).isClick == true)
                    {
                        ((Controls.ucSelectedList)listitem).isClick = false;
                        ((Controls.ucSelectedList)listitem).lblWorkSpace.BackColor = Color.White;
                        ((Controls.ucSelectedList)listitem).lblGroup.BackColor = Color.White;
                        ((frmParent)this.MdiParent).SelectedWorkLine = null;
                        ((frmParent)this.MdiParent).lblSelected.Text = "";
                    }
                }
                ((Controls.ucSelectedList)sender).isClick = true;
                selected = (Controls.ucSelectedList)sender;
                ((Controls.ucSelectedList)sender).lblWorkSpace.BackColor = Color.PeachPuff;
                ((Controls.ucSelectedList)sender).lblGroup.BackColor = Color.PeachPuff;

                ((frmParent)this.MdiParent).SelectedWorkLine = ((frmParent)MdiParent).WrokLineList.Find((work) => work.Wc_Code == ((Controls.ucSelectedList)sender).Tag.ToString());
                ((frmParent)this.MdiParent).lblSelected.Text = ((frmParent)this.MdiParent).SelectedWorkLine.Wc_Name;
            }
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((((frmParent)this.MdiParent).SelectedWorkLine == null))
            {
                return;
            }

            frmProductionList frm = new frmProductionList();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            this.Close();
            frm.Show();
        }

        private void frmSelect_Enter(object sender, EventArgs e)
        {
            pnlList.Controls.Clear();
            // 작업장 리스트 DB 가져오기
            ((frmParent)MdiParent).WrokLineList = ser.GetWorkCenterInfo();
            // 작업장 리스트 만들기

            if (pages == 1)
            {
                btnUp.Visible = false;
            }
            else
            {
                btnUp.Visible = true;
            }

            lblPage.Text = pages.ToString();

            lblTotPage.Text = Math.Ceiling(((frmParent)MdiParent).WrokLineList.Count / 6.0).ToString();

            if (pages == Math.Ceiling(((frmParent)MdiParent).WrokLineList.Count / 6.0))
            {
                btnDown.Visible = false;
            }
            else
            {
                btnDown.Visible = true;
            }
            

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
                list.lblWorkSpace.BackColor = list.lblGroup.BackColor = Color.White;
                list.lblWorkSpace.ForeColor = list.lblGroup.ForeColor = Color.Black;
                list.ucListClick += List_ListClick;

                if (pages == (Math.Ceiling((i+1) / (6.0))) )
                {
                    pnlList.Controls.Add(list);
                }
                
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pages <= 1) return;
            pages--;
            ((frmParent)this.MdiParent).SelectedWorkLine = null;
            ((frmParent)this.MdiParent).lblSelected.Text = "";
            frmSelect_Enter(this, e);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (pages >= 3) return;
            pages++;
            ((frmParent)this.MdiParent).SelectedWorkLine = null;
            ((frmParent)this.MdiParent).lblSelected.Text = "";
            frmSelect_Enter(this, e);
        }
    }
}