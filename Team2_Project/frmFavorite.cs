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
        public frmFavorite()
        {
            InitializeComponent();
        }

        private void frmFavorite_Load(object sender, EventArgs e)
        {
            this.LoginEmp = ((frmMain)this.Owner).LoginEmp;
            allMenuList = srv.GetMenuInfo(LoginEmp.UserGroup_Code);
            AllMenuBinding();
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
            e.Node.BackColor = Color.FromArgb(211, 226, 223);

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
                item.BackColor = Color.White;
                ClearRecursive(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in lstSubList.SelectedItems)
            {
                if (lstFavorite.Items.IndexOf(item.ToString()) < 0)
                {
                    lstFavorite.Items.Add(item.ToString());
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstFavorite.Items.Remove(lstFavorite.SelectedItem);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstSubList.Items.Clear();
            lstFavorite.Items.Clear();
            trvAllList.SelectedNode.BackColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lstFavorite.Items.Count > 0)
            {
                if (MessageBox.Show("현재 즐겨찾기 추가한 목록들이 아직 저장되지 않았습니다. \n 그래도 종료하시겠습니까?", "종료확인", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                    return;
            }
            else 
                this.Close();
        }

    }
}
