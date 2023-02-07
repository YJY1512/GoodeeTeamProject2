using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project_DTO;
using Team2_Project_DAO;
using Team2_Project;
using Team2_Project.Services;

namespace Team2_Project
{
    public partial class frmFavorite : Form
    {
        public EmployeeDTO LoginEmp { get; set; }
        MenuService srv = new MenuService();
        List<MenuDTO> allMenuList;
        List<MenuDTO> favoriteList;
        int startcnt;
        int curCnt;
        public frmFavorite()
        {
            InitializeComponent();
        }

        private void frmFavorite_Load(object sender, EventArgs e)
        {
            startcnt = 0;
            curCnt = 0;
            this.LoginEmp = ((frmMain)this.Owner).LoginEmp;
            allMenuList = srv.GetMenuInfo(LoginEmp.UserGroup_Code);
            favoriteList = srv.GetFavoriteInfo(LoginEmp.User_ID);
            AllMenuBinding();
            FavritListBinding();
            startcnt = trvFavorite.Nodes.Count;
        }

        private void AllMenuBinding()   //allList에 대메뉴 중메뉴만 출력 
        {
            List<MenuDTO> menus = allMenuList;
            var menu1 = menus.FindAll((k) => k.Menu_Level == 1 && k.Type == "MODULE").OrderBy((k) => k.Sort_Index).ToList();
            for (int b = 0; b < menu1.Count; b++)
            {
                TreeNode bigNode = new TreeNode();
                bigNode.Name = menu1[b].Screen_Code;
                bigNode.Text = menu1[b].Menu_Name;
                bigNode.Tag = menu1[b].Parent_Screen_Code;
                bigNode.NodeFont = new Font("나눔고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                bigNode.ForeColor = Color.DarkGray;

                string menu1ID = bigNode.Name;
                var menu2 = menus.FindAll((k) => k.Menu_Level == 2 && k.Parent_Screen_Code == menu1ID).OrderBy((k) => k.Sort_Index).ToList();
                for (int m = 0; m < menu2.Count; m++)
                {
                    TreeNode middleNode = new TreeNode();
                    middleNode.Name = menu2[m].Screen_Code;
                    middleNode.Text = menu2[m].Menu_Name;
                    middleNode.Tag = menu2[m].Parent_Screen_Code;
                    middleNode.NodeFont = new Font("나눔고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                    middleNode.ForeColor = Color.FromArgb(60, 75, 80);
                    bigNode.Nodes.Add(middleNode);
                }
                trvAllList.Nodes.Add(bigNode);
            }
            trvAllList.ExpandAll();
        }

        private void FavritListBinding()
        {
            List<MenuDTO> lists = favoriteList;
            var list1 = lists.FindAll((k) => k.Menu_Level == 3).OrderBy((k) => k.Seq).ToList();
            for (int l = 0; l < list1.Count; l++)
            {
                TreeNode favList = new TreeNode();
                favList.Name = list1[l].Screen_Code;
                favList.Text = list1[l].Menu_Name;
                favList.NodeFont = new Font("나눔고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                favList.ForeColor = Color.FromArgb(60, 75, 80);
                favList.BackColor = Color.FromArgb(211, 226, 223);

                trvFavorite.Nodes.Add(favList);
            }
        }


        private void trvAllList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lstSubList.Items.Clear();

            if (e.Node.Tag == null) return;
            string menuID = e.Node.Name;
            var menu3 = allMenuList.FindAll((k) => k.Menu_Level == 3 && k.Parent_Screen_Code == menuID).OrderBy((k) => k.Sort_Index).ToList();
            for (int s = 0; s <menu3.Count; s++)
            {

                ListBox infolist = new ListBox();
                infolist.Name = menu3[s].Menu_Name;
                lstSubList.Items.Add(infolist.Name);
            }
            e.Node.BackColor = Color.White;

        }

        private void trvAllList_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            foreach (TreeNode item in trvAllList.Nodes)          //루트노드만 조회한다 
            {
                ClearRecursive(item);
            }
        }

        private void ClearRecursive(TreeNode node)      //재귀함수 
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.BackColor = Color.FromArgb(211, 226, 223);
                ClearRecursive(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)   //즐겨찾기 List에 추가
        {
            if (lstSubList.SelectedItems.Count < 1) return;

            string selItemName = lstSubList.SelectedItems[0].ToString();
            var menus = favoriteList.FindAll((k) => k.Menu_Name == selItemName).ToList();
            if (menus.Count == 1)
            {
                MessageBox.Show($"{selItemName}은 현재 즐겨찾기 List에 추가되어 있습니다.");
                return;
            }

            var childMenu = allMenuList.FindAll((c) => c.Menu_Level == 3 && c.Menu_Name == selItemName).ToList();
            int d = 0;
            if (childMenu.Count == 1)
            {
                TreeNode nodes = new TreeNode();
                nodes.Name = childMenu[d].Screen_Code;
                nodes.Text = childMenu[d].Menu_Name;
                nodes.NodeFont = new Font("나눔고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                nodes.ForeColor = Color.FromArgb(60, 75, 80);
                nodes.BackColor = Color.White;

                trvFavorite.Nodes.Add(nodes);
                favoriteList.Add(childMenu[0]);
            }
            
        }

        private void btnNodeUp_Click(object sender, EventArgs e)
        { 
            TreeNode curNode = trvFavorite.SelectedNode;
            TreeNode pntNode = curNode.Parent;
            TreeView view = curNode.TreeView;
            if (pntNode != null)
            {
                int index = pntNode.Nodes.IndexOf(curNode);
                if (index > 0)
                {
                    pntNode.Nodes.RemoveAt(index);
                    pntNode.Nodes.Insert(index - 1, curNode);
                }
            }
            else if (curNode.TreeView.Nodes.Contains(curNode))
            {
                int index = view.Nodes.IndexOf(curNode);
                if (index > 0)
                {
                    view.Nodes.RemoveAt(index);
                    view.Nodes.Insert(index - 1, curNode);
                    curNode.ForeColor = Color.White;
                }
            }
        }

        private void btnNodeDown_Click(object sender, EventArgs e)
        {
            TreeNode curNode = trvFavorite.SelectedNode;
            TreeNode pntNode = curNode.Parent;
            TreeView view = curNode.TreeView;
            if (pntNode != null)
            {
                int index = pntNode.Nodes.IndexOf(curNode);
                if (index < pntNode.Nodes.Count - 1)
                {
                    pntNode.Nodes.RemoveAt(index);
                    pntNode.Nodes.Insert(index + 1, curNode);
                }
            }
            else if (view != null && view.Nodes.Contains(curNode))
            {
                int index = view.Nodes.IndexOf(curNode);
                if (index < view.Nodes.Count - 1)
                {
                    view.Nodes.RemoveAt(index);
                    view.Nodes.Insert(index + 1, curNode);
                    curNode.ForeColor = Color.White;
                }
            }
        }

        private void btnNodeDel_Click(object sender, EventArgs e)
        {
            string delnode = trvFavorite.SelectedNode.Text;
            var delmenu = favoriteList.FindAll((c) => c.Menu_Name == delnode).ToList();
            trvFavorite.Nodes.Remove(trvFavorite.SelectedNode);
            favoriteList.Remove(delmenu[0]);
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            curCnt = trvFavorite.Nodes.Count;
            TreeNode curNode = trvFavorite.SelectedNode;
            curNode.BackColor = Color.White;
            if (startcnt != curCnt )
            {
                if (MessageBox.Show("현재 즐겨찾기 List에 수정된 사항이 있습니다. \n 종료하시면 수정된 내용이 저장되지 않습니다. 그래도 종료하시겠습니까?", "종료확인", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                    return;
            }
            this.Close();
            
        }      
    }
}
