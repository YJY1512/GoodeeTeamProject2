using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;

namespace Team2_Project
{

    public partial class frmAuthority : frmList
    {
        AuthService srv = new AuthService();
        UserGroupAuthorityService grpSrv = new UserGroupAuthorityService();
        List<AuthDTO> authList = null;
        List<UserGroupAuthorityDTO> grpList = null;
        string empID;
        public frmAuthority()
        {
            InitializeComponent();
        }

        private void frmAuthority_Load(object sender, EventArgs e)
        {
            empID = ((frmMain)this.MdiParent).LoginEmp.User_ID;

            DataGridViewUtil.SetInitDataGridView(dgvAuthority);
            DataGridViewUtil.AddGridTextBoxColumn(dgvAuthority, " 메뉴 코드", "Screen_Code", 400);
            DataGridViewUtil.AddGridTextBoxColumn(dgvAuthority, " 메뉴 명", "Menu_Name", 300);
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 모듈권한", "Module", 100, disable:true);
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 조회권한", "Src", 100, disable: true);
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 추가권한", "Ins", 100, disable: true);
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 수정권한", "Upd", 100, disable: true);
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 삭제권한", "Del", 100, disable: true);
            //DataGridViewUtil.AddGridComboBoxColumn(dgvAuthority," 권한문자열", "Pre_Type ")
            dgvAuthority.MultiSelect = false;

            LoadData();
        }
        
        private void LoadData()
        {
            ucgrpSearch._Code = "Admin";
            ucgrpSearch._Name = "시스템 총괄 관리자";
            authList = srv.GetAuthInfo(ucgrpSearch._Code);
            BindingSource gc = new BindingSource(new AdvancedList<AuthDTO>(authList), null);
            dgvAuthority.ClearSelection();
            dgvAuthority.DataSource = null;
            dgvAuthority.DataSource = gc;
        }
        #region 사용자 그룹코드 검색 
        private CommonPop<UserGroupAuthorityDTO> GetGroupCodePopInfo()
        {
            if (grpList == null)
            {
                grpList = grpSrv.GetUserGroupCodeSearh();
            }

            CommonPop<UserGroupAuthorityDTO> grpPopInfo = new CommonPop<UserGroupAuthorityDTO>();
            grpPopInfo.DgvDatasource = grpList;
            grpPopInfo.PopName = "사용자 그룹 검색";

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("사용자 그룹 코드", "UserGroup_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("사용자 그룹 명", "UserGroup_Name", 200));

            grpPopInfo.DgvCols = colList;

            return grpPopInfo;
        }
        private void OpenPop<T>(CommonPop<T> popInfo, DataGridView dgv, int rowIndex) where T : class, new()
        {
            frmPop pop = new frmPop();
            pop.PopLoadData<T>(popInfo);

            if (pop.ShowDialog() == DialogResult.OK)
            {
                dgv[popInfo.DgvCols[0].DataPropertyName, rowIndex].Value = pop.SelCode;
                dgv[popInfo.DgvCols[1].DataPropertyName, rowIndex].Value = pop.SelName;
            }
        }
        private void ucSearch1_BtnClick(object sender, EventArgs e)
        {
            ucgrpSearch.OpenPop(GetGroupCodePopInfo());
        }
        #endregion

        public void OnSearch()
        {
            string grpCode = ucgrpSearch._Code;

            if (string.IsNullOrWhiteSpace(ucgrpSearch._Code))
            {
                MessageBox.Show("사용자 그룹코드를 선택해주세요.");
                return;
            }

            else
            {
                authList = srv.GetAuthInfo(grpCode);
                BindingSource gc = new BindingSource(new AdvancedList<AuthDTO>(authList), null);
                dgvAuthority.DataSource = null;
                dgvAuthority.DataSource = gc;
            }
        }
    }
}
