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
    public partial class frmNopMaCode : frmListUpAreaDown
    {
        NopCodeService srv = new NopCodeService();
        List<NopMaCodeDTO> NopMaList = new List<NopMaCodeDTO>();
        string situation = "";

        public frmNopMaCode()
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
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동 대분류코드", "Nop_Ma_Code", 500);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동 대분류명", "Nop_Ma_Name", 500);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "사용유무", "Use_YN", 200, align: DataGridViewContentAlignment.MiddleCenter);

            cboUseYN.Items.Add("-선택-");
            cboUseYN.Items.Add("사용");
            cboUseYN.Items.Add("미사용");
            cboUseYN.SelectedIndex = 0;
            cboUseYN.DropDownStyle = ComboBoxStyle.DropDownList;

            Deactivation(); //입력패널 비활성화
            OnSearch();
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
            NopMaList = srv.GetNopMaSearch(item);
            dgvData.DataSource = null;
            dgvData.DataSource = NopMaList;
        }
        public void OnAdd()     //추가
        {
            ResetBottom();
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
            if (situation == "Add")
            {
                //필수입력항목: 품목코드. 품목명, 품목유형, 사용유무
                if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text)
                    || cboUseYN.SelectedIndex == 0)
                {
                    MessageBox.Show("입력정보를 정확하게 입력하여 주십시오.");
                    return;
                }

                NopMaCodeDTO item = new NopMaCodeDTO
                {
                    Nop_Ma_Code = txtCode.Text,
                    Nop_Ma_Name = txtName.Text,
                    Use_YN = cboUseYN.Text.Equals("사용") ? "Y" : "N",
                    Ins_Emp = "홍길동" ///////////////////////////////////////////////////// 추후수정
                };

                bool result = srv.NopMaCodeAdd(item);
                if (result)
                    MessageBox.Show("등록이 완료되었습니다.", "등록완료");
                else
                    MessageBox.Show("다시 시도하여주십시오.", "등록오류");
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

                NopMaCodeDTO item = new NopMaCodeDTO
                {
                    Nop_Ma_Code = txtCode.Text,
                    Nop_Ma_Name = txtName.Text,
                    Use_YN = cboUseYN.Text.Equals("사용") ? "Y" : "N",
                    Up_Emp = "홍길동" //////////////////////////////////////////////////////// 추후수정
                };

                bool result = srv.NopMaCodeUpdate(item);
                if (result)
                    MessageBox.Show("수정이 완료되었습니다.", "수정완료");
                else
                    MessageBox.Show("다시 시도하여주십시오.", "수정오류");
            }

            OnReLoad();
            ResetBottom();  //입력패널 리셋
            Deactivation(); //입력패널 비활성화
        }

        public void OnCancel()  //취소
        {
            ResetBottom();  //입력패널 리셋
            Deactivation(); //입력패널 비활성화
            OnSearch();     //로드
        }
        public void OnReLoad()  //새로고침
        {
            //Deactivation();
            ResetTop();       //검색조건 리셋
            ResetBottom();    //입력패널 리셋
            OnSearch();       //로드
        }
        #endregion

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string curCode = dgvData[0, dgvData.CurrentRow.Index].Value.ToString();
            NopMaList = srv.GetMaCurItem(curCode);

            //입력정보에 바인딩
            NopMaCodeDTO dto = NopMaList.FirstOrDefault((p) => p.Nop_Ma_Code == curCode);
            if (dto != null)
            {
                txtCode.Text = dto.Nop_Ma_Code;
                txtName.Text = dto.Nop_Ma_Name;
                cboUseYN.Text = dto.Use_YN;
            }
        }

        private void ResetTop() //검색조건 리셋
        {
            txtCodeSC.Text = txtName.Text = txtNameSC.Text = "";
            cboUseYNSC.SelectedIndex = 0;
        }

        private void ResetBottom() //입력패널 리셋
        {
            txtCode.Text = txtName.Text = "";
            cboUseYN.SelectedIndex = 0;
        }

        private void Deactivation() //입력패널 비활성화
        {
            txtCode.Enabled = txtName.Enabled = cboUseYN.Enabled = false;
        }

        private void Activation() //입력패널 활성화
        {
            txtName.Enabled = txtCode.Enabled = cboUseYN.Enabled = true;
        }
    }
}