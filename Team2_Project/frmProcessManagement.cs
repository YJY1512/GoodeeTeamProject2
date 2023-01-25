using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmProcessManagement : Team2_Project.frmListUpAreaDown
    {
        public event EventHandler BtnClick;
        string loginedUser = "";
        bool isAdd, isEdit = false;
        ProcessMasterService service;
        // 리스트
        List<ProcessMasterDTO> processList;
        List<CodeDTO> code;

        public frmProcessManagement()
        {
            InitializeComponent();
        }

        private void frmProcessManagement_Load(object sender, EventArgs e)
        {
            //loginedUser = this.MdiParent. //로그인 유저
            service = new ProcessMasterService();
            CodeSetting();
            // DGV 설정
            DataGridViewUtil.SetInitDataGridView(dgvProcess);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "공정코드", "Process_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "공정명", "Process_Name", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "공정그룹", "Process_Group", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "비고", "Remark", 900);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "사용유무", "Use_YN", 120);
            dgvProcess.MultiSelect = false;

            //CBO 설정
            CommonCodeUtil.ComboBinding(cboProcessGroupArea, code, "process");
            CommonCodeUtil.ComboBinding(cboProcessGroupSub, code, "process");
            CommonCodeUtil.ComboBinding(cboUseArea, code, "use");
            CommonCodeUtil.ComboBinding(cboUseSub, code, "use");

            //데이터 불러오기
            processList = service.SetData();
            BindingSource bs = new BindingSource(processList, null);
            dgvProcess.DataSource = bs;
            // 기본설정
            //아래 패널 크기 120 으로 고정
            splitContainer1.SplitterDistance = 467;

            // 콤보박스 초기화
            cboProcessGroupSub.SelectedIndex = 0;
            cboUseSub.SelectedIndex = 0;
            cboProcessGroupArea.SelectedIndex = 0;
            cboUseArea.SelectedIndex = 0;

            // Enable 처리
            pnlArea.Enabled = false;

        }



        /// <summary>
        /// 메인 버튼 이벤트정렬
        /// 검색, 추가, 수정, 삭제, 저장, 취소, 새로고침, 엑셀
        /// </summary>
        //검색
        public void OnSearch()
        {
            if (isAdd || isEdit) 
            {
                MessageBox.Show("편집 진행 중 입니다.");
                return;
            }
            // 검색
            

            MessageBox.Show("yjy의 조회버튼 코딩");
           
            
        }
        //추가
        public void OnAdd()
        {
            if (isAdd)
            {
                MessageBox.Show("이미 진행 중 입니다.");
                return;
            }
            if (isEdit)
            {
                MessageBox.Show("수정 진행 중 이니다.");
                return;
            }
            //추가
            isAdd = pnlArea.Enabled = true;
            
            // 중복 업무 처리 금지
            dgvProcess.Enabled = false;
            pnlSub.Enabled = false;

        }
        //수정
        public void OnEdit()
        {
            if (isAdd)
            {
                MessageBox.Show("추가 진행 중 입니다.");
                return;
            }
            if (isEdit)
            {
                MessageBox.Show("이미 진행 중 입니다.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtProcessCodeName.Text))
            {
                MessageBox.Show("선택된 정보가 없습니다.");
                return;
            }
            //수정
            isEdit = true;

            // 중복 업무 처리 금지
            dgvProcess.Enabled = false;
            pnlSub.Enabled = false;
        }
        //삭제
        public void OnDelete()
        {
            MessageBox.Show("yjy의 추가버튼 코딩");
            if (isAdd || isEdit)
            {
                MessageBox.Show("편집 진행 중 입니다.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtProcessCodeName.Text))
            {
                MessageBox.Show("선택된 정보가 없습니다.");
                return;
            }
            //삭제
            try 
            {
                processList = service.DelProcess(txtProcessCode.Text);
                MessageBox.Show("삭제 성공 했습니다.");
            }
            catch 
            {
                MessageBox.Show("삭제 실패 했습니다.");
            }
            finally
            {
                BindingSource bs = new BindingSource(processList, null);
                dgvProcess.DataSource = bs;

                //후처리
                pnlArea.Enabled = false;
                cboProcessGroupSub.SelectedIndex = 0;
                cboUseSub.SelectedIndex = 0;
                cboProcessGroupArea.SelectedIndex = 0;
                cboUseArea.SelectedIndex = 0;
            }
        }
        //저장
        public void OnSave()
        {
            if (!isAdd && !isEdit) return;
            //저장
            //중복 처리
            if (processList.Find((l) => l.Process_Code == txtProcessCode.Text.Trim()) != null)
            {
                MessageBox.Show("이미 있는 코드 입니다.");
                txtProcessCode.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtProcessCode.Text)) 
            {
                txtProcessCode.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtProcessCodeName.Text))
            {
                txtProcessCodeName.Focus();
                return;
            }
            if (cboProcessGroupArea.SelectedIndex == 0)
            {
                cboProcessGroupArea.Focus();
                return;
            }
            if (cboUseArea.SelectedIndex == 0)
            {
                cboUseArea.Focus();
                return;
            }
            if (isAdd)
            {
                ProcessMasterDTO newProcess = new ProcessMasterDTO
                {
                    Process_Code = txtProcessCode.Text,
                    Process_Name = txtProcessCodeName.Text,
                    Process_Group = cboProcessGroupArea.SelectedValue.ToString(),
                    Use_YN = Convert.ToChar(cboUseArea.SelectedValue),
                    Remark = txtRemark.Text
                };

                bool result = service.InputProcess(newProcess, loginedUser);

                if (result)
                {
                    MessageBox.Show("저장 되었습니다.");
                }
                else 
                {
                    MessageBox.Show("저장 실패했습니다.");
                }
            }   
            if (isEdit)
            {
                ProcessMasterDTO editProcess = new ProcessMasterDTO
                {
                    Process_Code = txtProcessCode.Text,
                    Process_Name = txtProcessCodeName.Text,
                    Process_Group = cboProcessGroupArea.SelectedValue.ToString(),
                    Use_YN = Convert.ToChar(cboUseArea.SelectedValue),
                    Remark = txtRemark.Text
                };

                bool result = service.EditProcess(editProcess, loginedUser);

                if (result)
                {
                    MessageBox.Show("저장 되었습니다.");
                }
                else
                {
                    MessageBox.Show("저장 실패했습니다.");
                }
            }
            
            // 후처리
            pnlArea.Enabled = isAdd = isEdit = false;
            pnlSub.Enabled = true;
            cboProcessGroupArea.SelectedIndex = 0;
            cboUseArea.SelectedIndex = 0;
        }
        //취소
        public void OnCancel()
        {
            if (!isAdd && !isEdit) return;
            //취소
            txtProcessCode.Clear();
            txtProcessCodeName.Clear();
            cboProcessGroupArea.SelectedIndex = 0;
            cboUseArea.SelectedIndex = 0;
            txtRemark.Clear();

            // 후처리
            pnlArea.Enabled = isAdd = isEdit = false;
            pnlSub.Enabled = true;
        }

        private void dgvProcess_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0) return;
            txtProcessCode.Text = dgvProcess["Process_Code", e.RowIndex].Value.ToString();
            txtProcessCodeName.Text = dgvProcess["Process_Name", e.RowIndex].Value.ToString();
            cboProcessGroupArea.SelectedValue = dgvProcess["Process_Group", e.RowIndex].Value.ToString();
            cboUseArea.SelectedValue = dgvProcess["Use_YN", e.RowIndex].Value.ToString();
            txtRemark.Text = dgvProcess["", e.RowIndex].Value.ToString();
        }

        //새로고침
        public void OnReLoad()
        {
            if (!isAdd && !isEdit) return;
            // 새로 고침
            cboProcessGroupSub.SelectedIndex = 0;
            cboUseSub.SelectedIndex = 0;
            // uc 새로고침
        }

        private void ucSearch1_BtnClick(object sender, EventArgs e)
        {

        }

        public void CodeSetting()
        {
            code = new List<CodeDTO>();
            CodeDTO item = new CodeDTO();
            item.Code = "glazing";
            item.Category = "process";
            item.Name = "시유";
            item.Pcode = "";
            code.Add(item);
            CodeDTO item2 = new CodeDTO();
            item2.Code = "packaging";
            item2.Category = "process";
            item2.Name = "포장";
            item2.Pcode = "";
            code.Add(item2);
            CodeDTO item3 = new CodeDTO();
            item3.Code = "Y";
            item3.Category = "use";
            item3.Name = "예";
            item3.Pcode = "";
            code.Add(item3);
            CodeDTO item4 = new CodeDTO();
            item4.Code = "N";
            item4.Category = "use";
            item4.Name = "아니요";
            item4.Pcode = "";
            code.Add(item4);
        }


    }
}
