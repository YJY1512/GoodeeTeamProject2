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
    public partial class frmItem : frmListUpAreaDown
    {
        ItemService srv = new ItemService();
        List<ItemDTO> itemList = new List<ItemDTO>();
        string situation = "";

        public object ExcelUtil { get; private set; }

        public frmItem()
        {
            InitializeComponent();
        }

        private void Common_BtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch(btn.Tag.ToString())
            {
                case "btnSearch":
                    btnSelete_Click(sender, null); break;
                case "btnAdd":
                    btnAdd_Click(sender, null); break;
                case "btnEdit":
                    btnSelete_Click(sender, null); break;
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).BtnClick += Common_BtnClick;


            cboTypeSC.Items.Add("전체");
            cboTypeSC.Items.Add("완제품");
            cboTypeSC.Items.Add("반제품");
            cboTypeSC.SelectedIndex = 0;
            cboTypeSC.DropDownStyle = ComboBoxStyle.DropDownList;

            cboUseYNSC.Items.Add("전체");
            cboUseYNSC.Items.Add("사용");
            cboUseYNSC.Items.Add("미사용");
            cboUseYNSC.SelectedIndex = 0;
            cboUseYNSC.DropDownStyle = ComboBoxStyle.DropDownList;

            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목코드", "Item_Code", 400, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목명", "Item_Name", 400);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목유형", "Item_Type", 300, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "규격", "Item_Spec", 300, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "사용유무", "Use_YN", 100, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비고", "Remark", 500);

            cboType.Items.Add("-선택-");
            cboType.Items.Add("완제품");
            cboType.Items.Add("반제품");
            cboType.SelectedIndex = 0;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;

            cboSpec.Items.Add("-선택-");
            cboSpec.Items.Add("300x600");
            cboSpec.Items.Add("200x500");
            cboSpec.SelectedIndex = 0;
            cboSpec.DropDownStyle = ComboBoxStyle.DropDownList;

            cboUseYN.Items.Add("-선택-");
            cboUseYN.Items.Add("사용");
            cboUseYN.Items.Add("미사용");
            cboUseYN.SelectedIndex = 0;
            cboUseYN.DropDownStyle = ComboBoxStyle.DropDownList;


            //txtCode.Enabled = false;
            //txtCode.Text = "코드 자동발행"; ////////////////////////////////////////////// 추후수정

            //////추가, 수정버튼 클릭 시 입력패널이 열리고 저장버튼 클릭 시 추가, 수정이 되게 해야 함 

            Deactivation(); // 로드 시 입력패널 비활성화
            btnSelete.PerformClick(); ///////////////////////////////////////////////////// 추후수정
        }
        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {

        }

        public void OnAdd()     //추가
        {

        }
        public void OnEdit()    //수정
        {

        }
        public void OnDelete()  //삭제
        {

        }
        public void OnSave()    //저장
        {

        }
        public void OnCancel()  //취소
        {

        }
        public void OnReLoad()  //새로고침
        {

        }
        public void OnPrint()   //프린트(액셀)
        {

        }
        #endregion
        private void btnSelete_Click(object sender, EventArgs e)
        {
            ItemDTO item = new ItemDTO
            {
                Item_Code = txtCodeSC.Text,
                Item_Name = txtNameSC.Text,
                Item_Type = cboTypeSC.Text,
                Use_YN = cboUseYNSC.Text
            };
            itemList = srv.GetItemSearch(item);
            dgvData.DataSource = null;
            dgvData.DataSource = itemList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reset();
            Activation();
            situation = "Add";
        }

        private void cboType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboType == null) return; // || cboType.SelectedIndex < 1

            if (cboType.Text == "반제품")
            {
                cboSpec.SelectedIndex = 0;
                cboSpec.Enabled = false;
            }
            else
                cboSpec.Enabled = true;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string curCode = dgvData[0, dgvData.CurrentRow.Index].Value.ToString();
            itemList = srv.GetCurItem(curCode);

            //입력정보에 바인딩
            ItemDTO dto = itemList.FirstOrDefault((p) => p.Item_Code == curCode);
            if (dto != null)
            {
                txtCode.Text = dto.Item_Code;
                txtName.Text = dto.Item_Name;
                cboType.Text = dto.Item_Type; //////////////////////
                cboSpec.Text = dto.Item_Spec; ////////////////////// cbo에 바인딩
                cboUseYN.Text = dto.Use_YN;
                txtRemark.Text = dto.Remark;
            }
            txtCode.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Activation();
            situation = "Update";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 입력중이던 입력패널을 초기화하고 비활성화
            Reset();
            Deactivation();
            btnSelete.PerformClick(); ///////////////////////////////////////////////////// 추후수정
        }

        private void Reset()
        {
            txtCode.Text = txtName.Text = txtRemark.Text = "";
            cboType.SelectedIndex = cboSpec.SelectedIndex = cboUseYN.SelectedIndex = 0;
        }

        private void Deactivation()
        {
            txtCode.Enabled = txtName.Enabled = txtRemark.Enabled = false;
            cboType.Enabled = cboSpec.Enabled = cboUseYN.Enabled = false;
        }

        private void Activation()
        {
            txtCode.Enabled = true; /////////////////////////////////////////////////////// 추후수정
            txtName.Enabled = txtRemark.Enabled = true;
            cboType.Enabled = cboSpec.Enabled = cboUseYN.Enabled = true;

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            //Deactivation();
            btnSelete.PerformClick(); ///////////////////////////////////////////////////// 추후수정
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (situation == "Add")
            {
                //필수입력항목: 품목코드. 품목명, 품목유형, 사용유무
                if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text)
                    || cboType.SelectedIndex == 0 || cboUseYN.SelectedIndex == 0)
                {
                    MessageBox.Show("입력정보를 정확하게 입력하여 주십시오.");
                    return;
                }
                else if (cboType.SelectedIndex != 2 && cboSpec.SelectedIndex == 0)
                {
                    MessageBox.Show("규격을 선택하여 주십시오.");
                    return;
                }

                ItemDTO item = new ItemDTO
                {
                    Item_Code = txtCode.Text, ////////////////////////////////////////////// 추후 자동발행
                    Item_Name = txtName.Text,
                    Item_Type = cboType.Text.Equals("완제품") ? "PR" : "SA",
                    Item_Spec = cboSpec.Text.Equals("-선택-") ? "" : cboSpec.Text,
                    Use_YN = cboUseYN.Text.Equals("사용") ? "Y" : "N",
                    Remark = txtRemark.Text,
                    Ins_Emp = "홍길동" ///////////////////////////////////////////////////// 추후수정
                };

                bool result = srv.GetItemAdd(item);
                if (result)
                    MessageBox.Show("등록이 완료되었습니다.","등록완료");
                else
                    MessageBox.Show("다시 시도하여주십시오.","등록오류");

                btnSelete.PerformClick(); ///////////////////////////////////////////////////// 추후수정
            }
            else if (situation == "Update")
            {
                //필수입력항목: 품목코드. 품목명, 품목유형, 사용유무
                if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text)
                    || cboType.SelectedIndex == 0 || cboUseYN.SelectedIndex == 0)
                {
                    MessageBox.Show("입력정보를 정확하게 입력하여 주십시오.");
                    return;
                }
                else if (cboType.SelectedIndex != 2 && cboSpec.SelectedIndex == 0)
                {
                    MessageBox.Show("규격을 선택하여 주십시오.");
                    return;
                }

                ItemDTO item = new ItemDTO
                {
                    Item_Code = txtCode.Text,
                    Item_Name = txtName.Text,
                    Item_Type = cboType.Text.Equals("완제품") ? "PR" : "SA",
                    Item_Spec = cboSpec.Text.Equals("-선택-") ? "" : cboSpec.Text,
                    Use_YN = cboUseYN.Text.Equals("사용") ? "Y" : "N",
                    Remark = txtRemark.Text,
                    Up_Emp = "홍길동" //////////////////////////////////////////////////////// 추후수정
                };

                bool result = srv.GetItemUpdate(item);
                if (result)
                    MessageBox.Show("수정이 완료되었습니다.","수정완료");
                else
                    MessageBox.Show("다시 시도하여주십시오.","수정오류");

                btnSelete.PerformClick(); ///////////////////////////////////////////////////// 추후수정
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            
        }
    }
}

/*[품목정보]
	시유전 “반제품” 2개
	사이즈2개 프린트8개 (시유라인4개)
	총 “완제품” 16가지*/