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
    public partial class frmWorkCenter : frmListUpAreaDown
    {
        WorkCenterService srv = new WorkCenterService();
        List<WorkCenterDTO> wcList;
        string empID;

        
        string clickState = "";
        public frmWorkCenter()
        {
            InitializeComponent();
        }

        private void frmWorkShopInfo_Load(object sender, EventArgs e)
        {
            empID = ((frmMain)this.MdiParent).LoginEmp.User_ID;

            DataGridViewUtil.SetInitDataGridView(dgvWorkShop);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 상태", "Wc_Status", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 코드", "Wc_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 명", "Wc_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 그룹 명", "Wc_Group_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "공정 코드", "Process_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "공정명", "Process_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "팔렛생성여부", "Pallet_YN", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "사용여부", "Use_YN", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "비고", "Remark", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 그룹 코드", "Wc_Group_Code", visible :false);
            dgvWorkShop.MultiSelect = false;

            CommonCodeUtil.UseYNComboBinding(cboSearchUseYN);
            CommonCodeUtil.UseYNComboBinding(cboUseYN, false);
            cboSearchUseYN.SelectedIndex = 0;

            cboPalletYN.Items.Add("선택");
            cboPalletYN.Items.Add("예");
            cboPalletYN.Items.Add("아니요");
            cboPalletYN.SelectedIndex = 0;

            SetInitEditPnl();
            LoadData();
        }
        private void LoadData()
        {
            wcList = srv.GetWorkCenterInfo();
            dgvWorkShop.DataSource = wcList;
            dgvWorkShop.ClearSelection();
        }
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

            ucSrchProcCode._Code = "";
            ucSrchProcCode._Name = "";
            cboSearchUseYN.SelectedIndex = -1;
        }

        private void OpenSearchPnl()    //검색 패널 잠금해제
        {
            txtSearchCode.Enabled = txtSearchName.Enabled = ucSrchProcCode.Enabled = cboSearchUseYN.Enabled = true;
            cboSearchUseYN.SelectedIndex = 0;
        }
        private void SetInitEditPnl()   //폼 하단 패널 정보 값 clear 및 잠금
        {
            foreach (Control ctrl in pnlArea.Controls)
            {
                if (ctrl is Label || ctrl is Panel)
                    continue;

                if (ctrl is TextBox)
                    ctrl.Text = "";

                ctrl.Enabled = false;
            }

            ucCenterGrpCode._Code = "";
            ucCenterGrpCode._Name = "";
            cboPalletYN.SelectedIndex = -1;
            cboSearchUseYN.SelectedIndex = -1;
        }

        private void OpenInitEditPnl()  //폼 하단 패널 잠금해제 
        {
            if (clickState == "Add")    //클릭 상태가 추가일때 PK text 잠금해제      
            {
                txtCenterCode.Enabled = txtCenterName.Enabled = txtRemark.Enabled = ucCenterGrpCode.Enabled
                = ucProcCode.Enabled = cboPalletYN.Enabled = cboUseYN.Enabled = true;
                cboPalletYN.SelectedIndex = cboUseYN.SelectedIndex = 0;
            }
            else if (clickState == "Edit")
            {
                txtCenterName.Enabled = txtRemark.Enabled = ucCenterGrpCode.Enabled = ucProcCode.Enabled = cboPalletYN.Enabled = cboUseYN.Enabled = true;
                cboPalletYN.SelectedIndex = cboUseYN.SelectedIndex = 0;
            }
        }

        #region 버튼 이벤트

        public void OnSearch()  //검색
        {

        }
        public void OnAdd()     //추가
        {
            clickState = "Add";             //현재 클릭 상태
            SetInitEditPnl();               //폼 하단 패널 clear
            dgvWorkShop.Enabled = false;    //dgv 잠금
            dgvWorkShop.ClearSelection();   //셀 선택 초기화
            SetSearchPnl();                 //검색 패널 잠금 및 값 초기화
            OpenInitEditPnl();              //폼 하단 패널 잠금 해제 
        }
        public void OnEdit()    //수정
        {
            if (dgvWorkShop.SelectedRows.Count < 1)                 // 셀 선택 안했을 때
            {
                MessageBox.Show("수정할 항목을 선택하여 주세요.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);      // Main버튼 이벤트 초기화
                return;
            }
            clickState = "Edit";                                    //현재 클릭 상태
            dgvWorkShop.Enabled = false;                            //dgv 잠금
            dgvWorkShop.ClearSelection();                           //셀 선택 초기화
            SetSearchPnl();                                         //검색 패널 잠금 및 값 초기화
            OpenInitEditPnl();                                      //폼 하단 패널 잠금 해제
        }
        public void OnDelete()  //삭제
        {
            if (dgvWorkShop.SelectedRows.Count < 1)                 // 셀 선택 안했을 때
            {
                MessageBox.Show("삭제할 항목을 선택하여 주세요.");
                return;
            }
        }
        public void OnSave()    //저장
        {
            if (string.IsNullOrWhiteSpace(txtCenterCode.Text) || string.IsNullOrWhiteSpace(txtCenterName.Text) || string.IsNullOrWhiteSpace(ucProcCode._Code))
            {
                MessageBox.Show("필수 항목을 입력해주시기 바랍니다.");
                return;
            }
            else if (cboPalletYN.SelectedIndex == 0 || cboUseYN.SelectedIndex == 0)
            {
                MessageBox.Show("현재 '전체'로 선택이 되어있습니다. '예' 혹은 '아니요'를 선택해주시기 바랍니다.");
                return;
            }
            if (clickState == "Add")    //신규 추가
            {
                bool result = srv.FindSamePK(txtCenterCode.Text);   //PK값 중복체크
                if (!result)                                        //PK값 중복되었을 때
                {
                    MessageBox.Show("작업장 코드가 중복되었습니다. 다시 시도하여 주세요.");
                    return;
                }

                WorkCenterDTO dto = new WorkCenterDTO
                {
                    Wc_Code = txtCenterCode.Text,
                    Wc_Name = txtCenterName.Text,
                    Wc_Group_Code = ucCenterGrpCode._Code,
                    Wc_Group_Name = ucCenterGrpCode._Name,
                    Process_Code = ucProcCode._Code,
                    Process_Name = ucProcCode._Name,
                    Pallet_YN = (cboPalletYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Use_YN = (cboUseYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Remark = txtRemark.Text,
                    Ins_Emp = empID
                };

                result = srv.InsertWorkCenter(dto);
                if (result)
                {
                    MessageBox.Show("등록이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("등록 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }
            else if (clickState == "Edit")  //기본값 수정
            {
                WorkCenterDTO dto = new WorkCenterDTO
                {
                    Wc_Code = txtCenterCode.Text,
                    Wc_Name = txtCenterName.Text,
                    Wc_Group_Code = ucCenterGrpCode._Code,
                    Wc_Group_Name = ucCenterGrpCode._Name,
                    Process_Code = ucProcCode._Code,
                    Process_Name = ucProcCode._Name,
                    Pallet_YN = (cboPalletYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Use_YN = (cboUseYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Remark = txtRemark.Text,
                    Ins_Emp = empID
                };

                bool result = srv.UpdateWorkCenter(dto);
                if (result)
                {
                    MessageBox.Show("수정이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("수정 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }
        }
        public void OnCancel()  //취소
        {
            clickState = "";    //클릭 상태 초기화
            SetInitEditPnl();   //폼 하단 패널 clear 및 잠금 
            OpenSearchPnl();    //검색 패널 잠금 해제
            dgvWorkShop.Enabled = true; //dgv 잠금 해제
            dgvWorkShop.DataSource = null;
            dgvWorkShop.DataSource = wcList;   // 데이터 재조회
        }
        public void OnReLoad()  //새로고침
        {

        }
        #endregion
    }
}
