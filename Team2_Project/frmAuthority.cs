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
        List<CodeDTO> moduel;
        List<CodeDTO> screen;
        //List<CodeDTO> screen = null;
        List<UserGroupAuthorityDTO> grpList = null;
        string empID;
        string grpCode;
        public frmAuthority()
        {
            InitializeComponent();
        }

        private void frmAuthority_Load(object sender, EventArgs e)
        {
            empID = ((frmMain)this.MdiParent).LoginEmp.User_ID;
            ComboBoxCode();

            DataGridViewUtil.SetInitDataGridView(dgvAuthority);
            DataGridViewUtil.AddGridTextBoxColumn(dgvAuthority, " 메뉴 코드", "Screen_Code", 300);       //0
            DataGridViewUtil.AddGridTextBoxColumn(dgvAuthority, " 메뉴 명", "Menu_Name", 250);           //1
            DataGridViewUtil.AddGridTextBoxColumn(dgvAuthority, " 권한타입", "Type", 100);               //2
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 모듈권한", "Module", 100, disable:true);  //3
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 조회권한", "Src", 100, disable: true);    //4
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 추가권한", "Ins", 100, disable: true);    //5
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 수정권한", "Upd", 100, disable: true);    //6
            DataGridViewUtil.AddCheckBoxColumn(dgvAuthority, " 삭제권한", "Del", 100, disable: true);    //7
            DataGridViewUtil.AddGridTextBoxColumn(dgvAuthority, " 권한문자", "Pre_Type_NM", 100);           //8

            DataGridViewUtil.AddGridTextBoxColumn(dgvAuthority, " 권한문자", "Pre_Type", visible: false);           //8
            dgvAuthority.MultiSelect = false;

            CommonCodeUtil.ComboBinding(cboAuthNM, moduel, "PRE_TYPE");
            CommonCodeUtil.ComboBinding(cboAuthNM, moduel, "PRE_TYPE");
            CommonCodeUtil.ComboBinding(cboAuthNM, screen, "PRE_TYPE");
            CommonCodeUtil.ComboBinding(cboAuthNM, screen, "PRE_TYPE");


            SetInitEditPnl();
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


        #region  패널 잠금및 해제
        private void SetSearchPnl()  //검색 패널 값 clear 및 잠금
        {
            foreach (Control ctrl in pnlSub.Controls)
            {
                if (ctrl is Label || ctrl is Panel)
                    continue;

                if (ctrl is TextBox)
                    ctrl.Text = "";

                ctrl.Enabled = false;
            }

            //ucgrpSearch._Code = "";
            //ucgrpSearch._Name = "";
        }
        private void OpenSearchPnl()    //검색 패널 Clear 및 잠금해제
        {
            ucgrpSearch._Code = ucgrpSearch._Name = "";
            ucgrpSearch.Enabled = true;
        }
        private void SetInitEditPnl()   //폼 하단 패널 정보 값 clear 및 잠금
        {
            foreach (Control ctrl in splitContainer1.Panel2.Controls)
            {
                if (ctrl is Label || ctrl is Panel)
                    continue;

                if (ctrl is TextBox)
                    ctrl.Text = "";

                ctrl.Enabled = false;
            }
            cboAuthNM.SelectedIndex = -1;
        }
        private void OpenInitEditPnl()  //폼 하단 패널 잠금해제 
        {
             cboAuthNM.Enabled = true;
        }

        #endregion

        #region
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

            SetInitEditPnl();
            if (dgvAuthority.CurrentRow != null)
                dgvAuthority_CellClick(dgvAuthority, new DataGridViewCellEventArgs(0, 0));
        }

        public void OnEdit()
        {
            if (dgvAuthority.SelectedRows.Count < 1)                 // 셀 선택 안했을 때
            {
                MessageBox.Show("수정할 항목을 선택하여 주세요.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);      // Main버튼 이벤트 초기화
                return;
            }
            dgvAuthority.Enabled = false;                            //dgv 잠금
            SetSearchPnl();                                         //검색 패널 잠금 및 값 초기화
            OpenInitEditPnl();
        }

        public void OnSave()
        {
            grpCode = ucgrpSearch._Code;
            if (cboAuthNM.SelectedIndex == 0)
            {
                MessageBox.Show($"{lblAuth.Text}를 선택해주세요.");
                ((frmMain)this.MdiParent).EditClickEvent();
                return;
            }

            bool result = srv.SaveAuthority(grpCode, empID, authList);
            if (result)
            {
                MessageBox.Show("수정이 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("수정 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                ((frmMain)this.MdiParent).EditClickEvent();
                return;
            }
        }

        public void OnCancel()
        {
            SetInitEditPnl();   //폼 하단 패널 clear 및 잠금 
            OpenSearchPnl();    //검색 패널 잠금 해제
            dgvAuthority.Enabled = true; //dgv 잠금 해제
            LoadData();         //초기 로드 화면 
        }

        public void OnReLoad()
        {
            SetInitEditPnl();   //폼 하단 입력 패널 clear 및 잠금 
            LoadData();         //초기 로드 화면
        }
        #endregion


        private void dgvAuthority_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string type = dgvAuthority["Type", e.RowIndex].Value.ToString();

            txtScreenCode.Text = dgvAuthority["Screen_Code", e.RowIndex].Value.ToString().Trim();
            txtMenuNM.Text = dgvAuthority["Menu_Name", e.RowIndex].Value.ToString();
            txtAuthType.Text = dgvAuthority["Type", e.RowIndex].Value.ToString();
            if (type == "MODULE")
            {
                CommonCodeUtil.ComboBinding(cboAuthNM, moduel, "PRE_TYPE");
                CommonCodeUtil.ComboBinding(cboAuthNM, moduel, "PRE_TYPE");
            }
            else if (type == "SCREEN")
            {
                CommonCodeUtil.ComboBinding(cboAuthNM, screen, "PRE_TYPE");
                CommonCodeUtil.ComboBinding(cboAuthNM, screen, "PRE_TYPE");
            }
            cboAuthNM.SelectedValue = dgvAuthority["Pre_Type", e.RowIndex].Value.ToString();
        }

        public void ComboBoxCode()
        {
            moduel = new List<CodeDTO>();
            screen = new List<CodeDTO>();


            CodeDTO md1 = new CodeDTO();
            md1.Code = "Y";
            md1.Category = "PRE_TYPE";
            md1.Name = "메뉴권한O";
            md1.Pcode = "";
            moduel.Add(md1);

            CodeDTO md2 = new CodeDTO();
            md2.Code = "N";
            md2.Category = "PRE_TYPE";
            md2.Name = "메뉴권한X";
            md2.Pcode = "";
            moduel.Add(md2);

            CodeDTO sc1 = new CodeDTO();
            sc1.Code = "R";
            sc1.Category = "PRE_TYPE";
            sc1.Name = "조회권한";
            sc1.Pcode = "";
            screen.Add(sc1);

            CodeDTO sc2 = new CodeDTO();
            sc2.Code = "CRUD";
            sc2.Category = "PRE_TYPE";
            sc2.Name = "전체권한";
            sc2.Pcode = "";
            screen.Add(sc2);
        }
    }
}
