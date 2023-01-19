using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmNopCode : frmListUpAreaDown
    {
        NopCodeService srv = new NopCodeService();
        List<NopMaCodeDTO> NopMaList = new List<NopMaCodeDTO>();
        string situation = "";

        public frmNopCode()
        {
            InitializeComponent();
        }

        private void frmDownCode_Load(object sender, EventArgs e)
        {
            cboUseYNSC.Items.Add("전체");
            cboUseYNSC.Items.Add("사용");
            cboUseYNSC.Items.Add("미사용");
            cboUseYNSC.SelectedIndex = 0;
            cboUseYNSC.DropDownStyle = ComboBoxStyle.DropDownList;

            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동 대분류코드", "Item_Code", 500);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동 대분류명", "Item_Name", 500);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "사용유무", "Use_YN", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비고", "Remark", 500);
        }

        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            NopMaCodeDTO item = new NopMaCodeDTO
            {
                Nop_Ma_Code = txtCodeSC.Text,
                Nop_Ma_Name = txtNameSC.Text,
                Use_YN = cboUseYNSC.Text
            };
            NopMaList = srv.GetNopSearch(item);
            dgvData.DataSource = null;
            dgvData.DataSource = NopMaList;
        }

        public void OnAdd()     //추가
        {
            Reset();
            Activation();
            situation = "Add";

        }
        public void OnEdit()    //수정
        {
            Activation();
            situation = "Update";
        }
        public void OnDelete()  //삭제
        {

        }
        public void OnSave()    //저장
        {

        }
        public void OnCancel()  //취소
        {
            // 입력중이던 입력패널을 초기화하고 비활성화
            Reset();
            Deactivation();
            OnSearch(); ///////////////////////////////////////////////////// 
        }
        public void OnReLoad()  //새로고침
        {
            Reset();
            //Deactivation();
            OnSearch(); ///////////////////////////////////////////////////// 
        }
        #endregion

        private void Reset()
        {
            txtCode.Text = txtName.Text = txtRemark.Text = "";
            cboUseYN.SelectedIndex = 0;
        }

        private void Deactivation()
        {
            txtCode.Enabled = txtName.Enabled = txtRemark.Enabled = false;
            cboUseYN.Enabled = false;
        }

        private void Activation()
        {
            txtCode.Enabled = true; /////////////////////////////////////////////////////// 추후수정
            txtName.Enabled = txtRemark.Enabled = true;
            cboUseYN.Enabled = true;

        }




        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (situation == "Add")
            {
                //필수입력항목: 품목코드. 품목명, 품목유형, 사용유무
                if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text)
                    || cboUseYN.SelectedIndex == 0)
                {
                    MessageBox.Show("입력정보를 정확하게 입력하여 주십시오.");
                    return;
                }


                ItemDTO item = new ItemDTO
                {
                    Item_Code = txtCode.Text, ////////////////////////////////////////////// 추후 자동발행
                    Item_Name = txtName.Text,
                    Use_YN = cboUseYN.Text.Equals("사용") ? "Y" : "N",
                    Remark = txtRemark.Text,
                    Ins_Emp = "홍길동" ///////////////////////////////////////////////////// 추후수정
                };

                //bool result = srv.GetItemAdd(item);
                //if (result)
                //    MessageBox.Show("등록이 완료되었습니다.", "등록완료");
                //else
                //    MessageBox.Show("다시 시도하여주십시오.", "등록오류");

                OnSearch(); ///////////////////////////////////////////////////// 
            }
            else if (situation == "Update")
            {
                //필수입력항목: 품목코드. 품목명, 품목유형, 사용유무
                if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text)
                    || cboUseYN.SelectedIndex == 0)
                {
                    MessageBox.Show("입력정보를 정확하게 입력하여 주십시오.");
                    return;
                }


                ItemDTO item = new ItemDTO
                {
                    Item_Code = txtCode.Text,
                    Item_Name = txtName.Text,

                    Use_YN = cboUseYN.Text.Equals("사용") ? "Y" : "N",
                    Remark = txtRemark.Text,
                    Up_Emp = "홍길동" //////////////////////////////////////////////////////// 추후수정
                };

                //bool result = srv.GetItemUpdate(item);
                //if (result)
                //    MessageBox.Show("수정이 완료되었습니다.", "수정완료");
                //else
                //    MessageBox.Show("다시 시도하여주십시오.", "수정오류");

                OnSearch(); ///////////////////////////////////////////////////// 
            }
        }
    }
}