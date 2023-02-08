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
using System.Reflection;
using Team2_Project_DTO;
using Team2_Project.Utils;
using Team2_Project.Services;

namespace Team2_Project
{
    public partial class frmMain : Form
    {
        #region 유효성체크 실패 시 넣어줘야하는 버튼 이벤트 (!!!!!!!!필수!!!!!!!!)
        // 유효성 체크 후 return 값 주기 전에 이벤트 넣어주시면 됩니다. 
        // OnSave() 버튼 이벤트에서만 사용
        // 예시)
        // MessageBox.Show($"{lblGroupCode.Text} 항목을 입력해주시기 바랍니다.");
        //            if (clickState == "각 폼에서 clickstate를 '추가'로 정의해준 문자열 혹은 숫자 적어주시면됩니다")
        //            {
        //                ((frmMain)this.MdiParent).AddClickEvent();
        //            }
        //            else if (clickState == "각 폼에서 clickstate를 '수정'으로 정의해준 문자열 혹은 숫자 적어주시면됩니다")
        //            {
        //                ((frmMain)this.MdiParent).EditClickEvent();
        //            }
        //  return;
        #endregion

        public EmployeeDTO LoginEmp { get; set; }
        public int curP_MenuID { get; set; }

        MenuService srv = new MenuService();
        List<MenuDTO> menuList;
        Panel pnlChildMenu = new Panel();
        TreeView menuTree = new TreeView();
        const int MaxWidth = 212;
        const int MinWidth = 56;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            frmLogin login = new frmLogin();
            if (login.ShowDialog(this) != DialogResult.OK)
            {
                this.Close();
                return;
            }
            this.Visible = true;
            try
            {
                tStripDate.Text = DateTime.Now.ToShortDateString();
                tStripTime.Text = DateTime.Now.ToShortTimeString();
                tStripName.Text = LoginEmp.User_Name;
                tStripDept.Text = LoginEmp.UserGroup_Name;

                menuList = srv.GetMenuInfo(LoginEmp.UserGroup_Code);
                DrawSideMenu();
                pnlChildMenu.Visible = false;
                menuTree.ItemHeight = 30;
                menuTree.ExpandAll();
                menuTree.ShowLines = false;
                menuTree.ShowRootLines = false;
                menuTree.AfterSelect += MenuTree_AfterSelect;
                menuTree.Font = new Font("나눔고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
                menuTree.BackColor = Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
                chkHide.Checked = true;
                RoadClickEvent();
                OpenChildPage("frmDashBoard" , "HOME");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }            
        }

        private void chkHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHide.Checked)
            {
                panel2.Width = MinWidth;
                pnlMenu.Width = MinWidth;
                pnlChildMenu.Visible = false;
                chkHide.Text = ">";
            }
            else
            {
                panel2.Width = MaxWidth;
                pnlMenu.Width = MaxWidth;
                pnlChildMenu.Visible = false;
                chkHide.Text = "<";
            }
            pnlMenu.Update();
        }

        private void DrawSideMenu()
        {
            List<MenuDTO> menu1List = menuList.FindAll((m) => m.Menu_Level == 1).OrderBy((m) => m.Sort_Index).ToList();
            for (int i = 0; i < menu1List.Count; i++)
            {
                Button btn = new Button();              
                
                btn.BackColor = Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
                btn.Dock = DockStyle.Top;
                btn.FlatAppearance.BorderColor = Color.White;
                btn.FlatAppearance.BorderSize = 3;               
                btn.FlatStyle = FlatStyle.Flat;
                btn.Margin = new Padding(0);
                btn.Padding = new Padding(8, 8, 8, 8);
                btn.FlatAppearance.MouseDownBackColor = Color.Black;
                btn.FlatAppearance.MouseOverBackColor = Color.Black;
                btn.Font = new Font("나눔고딕 ExtraBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 129);
                btn.ForeColor = Color.White;
                btn.ImageList = imageListLeftSideBar;
                btn.ImageIndex = Convert.ToInt32(menu1List[i].Menu_Image);
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.Text = menu1List[i].Menu_Name.PadLeft(menu1List[i].Menu_Name.Length + 6);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Name = menu1List[i].Screen_Code;
                btn.Location = new Point(0, (i * 65));
                btn.Size = new Size(MaxWidth, 65);

                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.UseVisualStyleBackColor = false;

                btn.Tag = i;



                pnlMenu.Controls.Add(btn);
                
                btn.Click += Btn_Click;
                btn.MouseEnter += Btn_MouseEnter;

                pnlChildMenu.Dock = DockStyle.Top;
                pnlChildMenu.Location = new Point(0, 0);
                pnlChildMenu.Size = new Size(MaxWidth, 350);
                menuTree.Dock = DockStyle.Fill;
                menuTree.Location = new Point(0, 0);
                menuTree.Size = new Size(MaxWidth, 350);
               
                pnlMenu.Controls.Add(pnlChildMenu);
                pnlChildMenu.Controls.Add(menuTree);                  
            }
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            if (chkHide.Checked) return;

            panel2.Width = MaxWidth;
            pnlMenu.Width = MaxWidth;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            chkHide.Checked = false;

            Button btn = (Button)sender;
            string menuID = btn.Name;
            int pnlIndex = Convert.ToInt32(btn.Tag) + 1;

            if (menuID == "HOM")
            {
                OpenChildPage("frmDashBoard", "대쉬보드");
            }

            pnlMenu.Controls.SetChildIndex(pnlChildMenu, pnlIndex);      //SetChildIndex : 어떤 컨트롤을 index 몇으로 바꾸겠다는 메서드 
            if (pnlIndex == 1)
            {
                pnlChildMenu.Visible = false;
                return;
            }
            pnlMenu.Invalidate();                                        //Invalidate    : 다시 디자인을 그려달라는 메서드 


            menuTree.Nodes.Clear();

            var menu2List = menuList.FindAll((m) => m.Parent_Screen_Code == menuID
                                                    && m.Menu_Level == 2)
                                    .OrderBy((m) => m.Sort_Index).ToList();

            for (int k = 0; k < menu2List.Count; k++)
            {
                TreeNode treeNode1 = new TreeNode();
                treeNode1.Name = menu2List[k].Screen_Code;
                treeNode1.Text = menu2List[k].Menu_Name;
                treeNode1.Tag = menu2List[k].Form_Name;
                treeNode1.BackColor = Color.FromArgb(211, 226, 223);
                treeNode1.NodeFont = new Font("나눔고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                treeNode1.ForeColor = Color.Black;

                string menu1ID = treeNode1.Name;
                var menu3List = menuList.FindAll((m) => m.Parent_Screen_Code == menu1ID
                                        && m.Menu_Level == 3).OrderBy((m) => m.Sort_Index).ToList();

                for (int c = 0; c < menu3List.Count; c++)
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Name = menu3List[c].Screen_Code;
                    childNode.Text = menu3List[c].Menu_Name;
                    childNode.Tag = menu3List[c].Form_Name;
                    childNode.BackColor = Color.FromArgb(211, 226, 223);
                    childNode.NodeFont = new Font("나눔고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                    childNode.ForeColor = Color.Black;
                    treeNode1.Nodes.Add(childNode);
                }

                menuTree.Nodes.Add(treeNode1);
            }
            pnlChildMenu.Visible = true;
            menuTree.ExpandAll();
        }

        private void MenuTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                OpenChildPage(e.Node.Tag.ToString(), e.Node.Text);
            }
            else
            {
                MessageBox.Show("미생성 화면");
            }
        }
        private void OpenChildPage(string prgName, string menuName)
        {
            string appName = Assembly.GetEntryAssembly().GetName().Name;
            Type frmType = Type.GetType($"{appName}.{prgName}");
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == frmType)
                {
                    form.Activate();
                    form.BringToFront();
                    

                    return;
                }
            }
            if (frmType == null)
            {
                MessageBox.Show("미생성 화면");
                return;
            }
            Form frm = (Form)Activator.CreateInstance(frmType);
            frm.MdiParent = this;
            frm.Text = menuName;
            frm.Show();
        } //자식폼 Open 이벤트 
       

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
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text + "       ");
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

                //화면당 조회, 저장, 출력여부를 메뉴테이블을 참고해서 버튼 비활성화 여부 코딩


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
                btnSearch_Click(frm, new EventArgs());
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
                    if (ActiveMdiChild.Text == "HOME") return;
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

        void Function_Invoke(string funcName)
        {
            try
            {
                Type frmType = this.ActiveMdiChild.GetType();

                MethodInfo btnEventHandlerCall = frmType.GetMethod(funcName, BindingFlags.Instance | BindingFlags.Public);

                if (btnEventHandlerCall != null)
                {
                    if (funcName == "OnAdd")
                    {
                        AddClickEvent();
                    }
                    else if (funcName == "OnEdit")
                    {
                        EditClickEvent();
                    }
                    else if (funcName == "OnSave" || funcName == "OnCancel")
                    {
                        SaveOrCancelClickEvent();
                    }
                    btnEventHandlerCall.Invoke(this.ActiveMdiChild, null);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("자식폼 이벤트핸들러 미구현");
            }
        }

        #region 버튼 클릭 이벤트
        public void RoadClickEvent()
        {
            btnSave.Enabled = btnCancel.Enabled = false;
            btnSave.BackColor = btnCancel.BackColor = Color.DarkGray;
        }
        public void AddClickEvent() //추가 버튼 클릭시
        {
            btnAdd.BackColor = Color.White;            
            btnSearch.Enabled = btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReLoad.Enabled = false;
            btnSave.Enabled = btnCancel.Enabled = true;
            btnSearch.BackColor = btnEdit.BackColor = btnDelete.BackColor = btnReLoad.BackColor = Color.DarkGray;
            btnSave.BackColor = btnCancel.BackColor = Color.FromArgb(211, 226, 223);
        }
        public void EditClickEvent() // 수정 버튼 클릭시 
        {
            btnEdit.BackColor = Color.White;
            btnSearch.Enabled = btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReLoad.Enabled = false;
            btnSave.Enabled = btnCancel.Enabled = true;
            btnSearch.BackColor = btnAdd.BackColor = btnDelete.BackColor = btnReLoad.BackColor = Color.DarkGray;
            btnSave.BackColor = btnCancel.BackColor = Color.FromArgb(211, 226, 223);
        }
        void SaveOrCancelClickEvent()   //저장 or 취소 버튼 클릭시  
        {
            if (btnSearch.Enabled == false &&
                btnAdd.Enabled == false &&
                btnEdit.Enabled == false &&
                btnDelete.Enabled == false &&
                btnReLoad.Enabled == false &&
                btnAdd.BackColor == Color.White ||
                btnEdit.BackColor == Color.White
                )
            {
                btnSearch.Enabled = btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReLoad.Enabled = true;
                btnAdd.BackColor = btnEdit.BackColor = btnSearch.BackColor =  btnDelete.BackColor = btnReLoad.BackColor = Color.FromArgb(211, 226, 223);
                RoadClickEvent();
            }
        }
        public void BtnEditReturn(bool bactive) //셀 선택없이 수정버튼 클릭시 값 초기화 이벤트
        {
            btnSearch.Enabled = btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReLoad.Enabled = bactive;
            btnAdd.BackColor = btnEdit.BackColor = btnSearch.BackColor = btnDelete.BackColor = btnReLoad.BackColor = Color.FromArgb(211, 226, 223);
            RoadClickEvent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnSearch");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnAdd");         
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnEdit");          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnDelete");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnSave");           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnCancel");            
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnReLoad");
        }
        #endregion

        private void tsBtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void tsBtnSetting_Click(object sender, EventArgs e)
        {
            frmSettings pop = new frmSettings();
            pop.ShowDialog(this);
        }

        private void tsBtnFavorite_Click(object sender, EventArgs e)
        {
            frmFavorite pop = new frmFavorite();
            pop.ShowDialog(this);
        }
    }
    class TabTag
    {
        public Form ActiveOpenForm { get; set; }
        public int MenuID { get; set; }
    }
}
