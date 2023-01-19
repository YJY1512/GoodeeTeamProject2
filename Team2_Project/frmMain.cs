using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project.Controls;

namespace Team2_Project
{
    public partial class frmMain : Form
    {
        public event EventHandler BtnClick;

        private Boolean showPanelTreenode1 = false;
        private Boolean showPanelTreenode2 = false;
        private Boolean showPanelTreenode3 = false;
        private Boolean showPanelTreenode4 = false;
        private string toolDate;
        private string toolTime;
        public string curP_MenuID { get; set; }
        public frmMain()
        {
            InitializeComponent();

            tooglepanels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tStripName.Text = "윤종윤님";
            tStripDept.Text = "관리자";
            OpenGMMainPage<frmStartMain>();
        }
        #region 왼쪽버튼 수정 예정
        private void tooglepanels()
        {
            if (showPanelTreenode1)
            {
                pnltreenode1.Height = 155;
                treeView1.ExpandAll();
            }
            else
            {
                pnltreenode1.Height = 0;
            }

            if (showPanelTreenode2)
            {
                pnltreenode2.Height = 190;
                treeView2.ExpandAll();
            }
            else
            {
                pnltreenode2.Height = 0;
            }

            if (showPanelTreenode3)
            {
                pnltreenode3.Height = 164;
                treeView3.ExpandAll();
            }
            else
            {
                pnltreenode3.Height = 0;
            }

            if (showPanelTreenode4)
            {
                pnltreenode4.Height = 89;
                treeView4.ExpandAll();
            }
            else
            {
                pnltreenode4.Height = 0;
            }
        }

        private void btnsystem_Click(object sender, EventArgs e)
        {
            showPanelTreenode1 = !showPanelTreenode1;

            tooglepanels();
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            showPanelTreenode2 = !showPanelTreenode2;

            tooglepanels();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            showPanelTreenode3 = !showPanelTreenode3;

            tooglepanels();
        }

        private void btnProduce_Click(object sender, EventArgs e)
        {
            showPanelTreenode4 = !showPanelTreenode4;

            tooglepanels();
        }
        #endregion

        private void OpenGMMainPage<T>() where T : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    form.BringToFront();

                    return;
                }
            }
            T frm = new T();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        #region 왼쪽 treeview 수정예정
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            curP_MenuID = e.Node.Text.ToString();
            if (e.Node.Text == "사용자 관리")
            {
                OpenGMMainPage<frmUserManagement>();
            }
            else if (e.Node.Text == "인사 관리")
            {
                OpenGMMainPage<frmEmpManagement>();
            }
            else if (e.Node.Text == "시스템 코드 관리")
            {
                OpenGMMainPage<frmSystemCode>();
            }
            else if (e.Node.Text == "즐겨찾기및 화면관리")
            {
                OpenGMMainPage<frmScreen>();
            }
            else
            {
                MessageBox.Show("빈 생성 화면입니다.");
            }
        }

        private void treeView2_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            curP_MenuID = e.Node.Text.ToString();
            if (e.Node.Text == "공정정보")
            {
                OpenGMMainPage<frmProcessManagement>();
            }
            else if (e.Node.Text == "작업장정보")
            {
                OpenGMMainPage<frmWorkShopInfo>();
            }
            else if (e.Node.Text == "품목정보")
            {
                OpenGMMainPage<frmItem>();
            }
            else if (e.Node.Text == "사용자 정의 관리")
            {
                OpenGMMainPage<frmUserCode>();
            }
            else if (e.Node.Text == "불량현상 관리")
            {
                OpenGMMainPage<frmDefectCode>();
            }
            else if (e.Node.Text == "비가동 관리")
            {
                OpenGMMainPage<frmDownCode>();
            }
            else
            {
                MessageBox.Show("빈 생성 화면입니다.");
            }
        }

        private void treeView3_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            curP_MenuID = e.Node.Text.ToString();
            if (e.Node.Text == "작업지시 생성 및 마감")
            {
                //OpenGMMainPage<>();
                MessageBox.Show("빈 생성 화면입니다.");
            }
            else if (e.Node.Text == "시간대별 실적 조회")
            {
                //OpenGMMainPage<>();
                MessageBox.Show("빈 생성 화면입니다.");
            }
            else if (e.Node.Text == "작업지시 현황")
            {
                //OpenGMMainPage<>();
                MessageBox.Show("빈 생성 화면입니다.");
            }
            else if (e.Node.Text == "비가동 내역")
            {
                OpenGMMainPage<frmDown>();
            }
            else if (e.Node.Text == "일별 생산 현황")
            {
                //OpenGMMainPage<>();
                MessageBox.Show("빈 생성 화면입니다.");
            }
            else
            {
                MessageBox.Show("빈 생성 화면입니다.");
            }
        }

        private void treeView4_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            curP_MenuID = e.Node.Text.ToString();
            if (e.Node.Text == "생산요청 관리")
            {
                OpenGMMainPage<frmOrder>();
            }
            else if (e.Node.Text == "생산계획 관리")
            {
                OpenGMMainPage<frmPlan>();
            }
            else if (e.Node.Text == "시유 작업지시 생성")
            {
                //OpenGMMainPage<>();
                MessageBox.Show("빈 생성 화면입니다.");
            }
            else
            {
                MessageBox.Show("빈 생성 화면입니다.");
            }
        }
        #endregion
        private void OpenCreateForm(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                tabControl1.Visible = false;
            }
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;

                if (this.ActiveMdiChild.Tag == null) //신규로 탭을 생성하는 경우
                {
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text + "    ");
                    tabControl1.TabPages.Add(tp);

                    //tp.Tag = this.ActiveMdiChild;
                    tp.Tag = new TabTag { ActiveOpenForm = this.ActiveMdiChild, MenuID = curP_MenuID };
                    this.ActiveMdiChild.Tag = tp;

                    tabControl1.SelectedTab = tp;

                    //자식폼이 닫힐때 탭페이지도 같이 삭제
                    this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
                }
                else //기존에 탭이 있는 경우
                {
                    tabControl1.SelectedTab = (TabPage)this.ActiveMdiChild.Tag;
                }

                if (!tabControl1.Visible)
                {
                    tabControl1.Visible = true;
                }
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = (Form)sender;
            ((TabPage)frm.Tag).Dispose();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                Form frm = ((TabTag)tabControl1.SelectedTab.Tag).ActiveOpenForm;
                frm.Select();
            }
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                var r = tabControl1.GetTabRect(i);
                var closeImage = Properties.Resources.close_grey;
                var closeRect = new Rectangle((r.Right - closeImage.Width), r.Top + (r.Height - closeImage.Height) / 2,
                    closeImage.Width, closeImage.Height);

                if (closeRect.Contains(e.Location))
                {
                    this.ActiveMdiChild.Close();
                    break;
                }
            }
        }

        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            //MDI메뉴와 Child메뉴가 합쳐질때 발생하는 이벤트
            //최소화(&N) 이전 크기로(&R)  닫기(&C) ""
            if (e.Item.Text == "" ||
                e.Item.Text == "최소화(&N)" ||
                e.Item.Text == "이전 크기로(&R)" ||
                e.Item.Text == "닫기(&C)")
                e.Item.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tStripDate.Text = DateTime.Now.ToShortDateString();
            tStripTime.Text = DateTime.Now.ToShortTimeString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form d = this.ActiveMdiChild;
            OpenGMMainPage<frmStartMain>();
            Button btn = (Button)sender;
            if (this.BtnClick != null)
            {
                btn.Tag = btn.Name;
                BtnClick(btn, e);
            }
        }

    }
    class TabTag
    {
        public Form ActiveOpenForm { get; set; }
        public string MenuID { get; set; }
    }
}
