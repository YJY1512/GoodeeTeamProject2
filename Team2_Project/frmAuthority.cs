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
        //List<CodeDTO> code;
        //List<CodeDTO> screen = null;
        List<UserGroupAuthorityDTO> grpList = null;
        string empID;
        string grpCode;
        string[] comboList = ["Y", "N" , "R" , "CRUD"];
        public frmAuthority()
        {
            InitializeComponent();
        }

        private void frmAuthority_Load(object sender, EventArgs e)
        {
            empID = ((frmMain)this.MdiParent).LoginEmp.User_ID;

            DataGridViewUtil.SetInitDataGridView(dgvAuthority);
            DataGridViewUtil.AddGridTextBoxColumn(dgvAuthority, " 메뉴 코드", "Screen_Code", 300);       //0
            DataGridViewUtil.AddGridTextBoxColumn(dgvAuthority, " 메뉴 명", "Menu_Name", 250);           //1
            DataGridViewUtil.AddGridTextBoxColumn(dgvAuthority, " 권한타입", "Type", 100);               //2
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 모듈권한", "Module", 100, disable:true);  //3
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 조회권한", "Src", 100, disable: true);    //4
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 추가권한", "Ins", 100, disable: true);    //5
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 수정권한", "Upd", 100, disable: true);    //6
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 삭제권한", "Del", 100, disable: true);    //7
            DataGridViewUtil.AddGridTextBoxColumn(dgvAuthority, " 권한문자", "Pre_Type", 100);           //8
            dgvAuthority.MultiSelect = false;

            //CommonCodeUtil.ComboBinding(cboAuthNM, code, "PRE_TYPE");
            //CommonCodeUtil.ComboBinding(cboAuthNM, code, "PRE_TYPE");
            //CommonCodeUtil.ComboBinding(cboAuthNM, code, "PRE_TYPE");
            //CommonCodeUtil.ComboBinding(cboAuthNM, code, "PRE_TYPE");


            LoadData();
        }
        
        private void LoadData()
        {
            ucgrpSearch._Code = "Admin";
            ucgrpSearch._Name = "시스템 총괄 관리자";
            grpCode = ucgrpSearch._Code;
            authList = srv.GetAuthInfo(grpCode);
            BindingSource gc = new BindingSource(new AdvancedList<AuthDTO>(authList), null);
            dgvAuthority.ClearSelection();
            dgvAuthority.DataSource = null;
            dgvAuthority.DataSource = gc;
            if (dgvAuthority.CurrentRow != null)
            {
                dgvAuthority_CellClick(dgvAuthority, new DataGridViewCellEventArgs(0, dgvAuthority.CurrentRow.Index));

            }
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

        private void dgvAuthority_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            txtScreenCode.Text = dgvAuthority["Screen_Code", e.RowIndex].Value.ToString();
            txtMenuNM.Text = dgvAuthority["Menu_Name", e.RowIndex].Value.ToString();
            txtAuthType.Text = dgvAuthority["Type", e.RowIndex].Value.ToString();
            cboAuthNM.SelectedValue = dgvAuthority["Pre_Type", e.RowIndex].Value.ToString();
        }

        //public void ComboBoxCode()
        //{
        //    code = new List<CodeDTO>();
        //    //screen = new List<CodeDTO>();

        //    CodeDTO md1 = new CodeDTO();
        //    md1.Code = "PR01";
        //    md1.Category = "PRE_TYPE";
        //    md1.Name = "Y";
        //    md1.Pcode = "";
        //    code.Add(md1);

        //    CodeDTO md2 = new CodeDTO();
        //    md2.Code = "PR02";
        //    md2.Category = "PRE_TYPE";
        //    md2.Name = "N";
        //    md2.Pcode = "";
        //    code.Add(md2);

        //    CodeDTO md3 = new CodeDTO();
        //    md3.Code = "PR03";
        //    md3.Category = "PRE_TYPE";
        //    md3.Name = "R";
        //    md3.Pcode = "";
        //    code.Add(md3);

        //    CodeDTO md4 = new CodeDTO();
        //    md4.Code = "PR04";
        //    md4.Category = "PRE_TYPE";
        //    md4.Name = "CRUD";
        //    md4.Pcode = "";
        //    code.Add(md4);
        //}
    }
}
