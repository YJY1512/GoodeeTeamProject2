using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2_Project.Utils;
using Team2_Project_DTO;
using Team2_Project.Services;
using System.Linq;

namespace Team2_Project
{
    public partial class frmDefectCodeDetail : Team2_Project.BaseForms.frmCodeControlBase
    {
        List<DefCodeDTO> defList;
        DefCodeService srv = new DefCodeService();

        public frmDefectCodeDetail()
        {
            InitializeComponent();
        }

        private void frmDefectCodeDetail_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvMa);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "불량현상 대분류코드", "Def_Ma_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "불량현상 대분류명", "Def_Ma_Name", 250);

            DataGridViewUtil.SetInitDataGridView(dgvMi);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "불량현상 상세분류코드", "Def_Mi_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "불량현상 상세분류명", "Def_Mi_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "사용유무", "Use_YN");
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Remark", "Remark", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Def_Ma_Code", "Def_Ma_Code", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Def_Ma_Name", "Def_Ma_Name", visible: false);

            CommonCodeUtil.UseYNComboBinding(cboSearchUse);
            CommonCodeUtil.UseYNComboBinding(cboUseYN, false);
            cboSearchUse.SelectedIndex = 0;

            SetInitPnl();
            LoadData();
        }

        private void LoadData()
        {
            defList = srv.GetDefMiCode();
            if (defList != null && defList.Count > 0)
            {
                var list = defList.GroupBy((g) => g.Def_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
                dgvMa.DataSource = null;
                dgvMa.DataSource = list;
            }
            dgvMi.DataSource = null;

            dgvMa.ClearSelection();
            dgvMi.ClearSelection();
        }

        private void SetInitPnl()
        {
            foreach (Control ctrl in splitContainer2.Panel2.Controls)
            {
                if (ctrl is Label || ctrl is Panel)
                    continue;

                if (ctrl is TextBox)
                    ctrl.Text = "";

                ctrl.Enabled = false;
            }

            ucMaCode._Code = "";
            ucMaCode._Name = "";
            cboUseYN.SelectedIndex = -1;
        }


        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            string code = ucMaCodeSC._Code;
            string useYN = (cboSearchUse.SelectedItem.ToString() == "전체") ? "" : cboSearchUse.SelectedItem.ToString();

            SetInitPnl();

            if (string.IsNullOrWhiteSpace(code) && string.IsNullOrWhiteSpace(useYN))
            {
                LoadData();
                return;
            }

            var list = (from c in defList
                        where c.Def_Ma_Code == code && c.Use_YN.Contains(useYN)
                        select c).ToList();
            dgvMi.DataSource = list;

            var maList = list.GroupBy((g) => g.Def_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
            dgvMa.DataSource = maList;
        }

        public void OnAdd()     //추가
        {
            if (dgvMa.SelectedRows.Count < 1)
            {
                MessageBox.Show("추가할 항목을 선택하여 주십시오.");
                return;
            }

            SetInitPnl();

            dgvMa.Enabled = dgvMi.Enabled = false;
            dgvMi.ClearSelection();
            txtInfoCodeMi.Enabled = txtInfoNameMi.Enabled = txtRemark.Enabled = cboUseYN.Enabled = true;
            cboUseYN.SelectedIndex = 0;

            int idx = dgvMa.CurrentRow.Index;
            ucMaCode._Code = dgvMa["Def_Ma_Code", idx].Value.ToString();
            ucMaCode._Name = dgvMa["Def_Ma_Name", idx].Value.ToString();

        }

        public void OnEdit()    //수정
        {
            if (dgvMi.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 항목을 선택하여 주십시오.");
                return;
            }

            dgvMa.Enabled = dgvMi.Enabled = false;
            txtInfoNameMi.Enabled = txtRemark.Enabled = cboUseYN.Enabled = true;
        }

        public void OnDelete()  //삭제
        {
            
        }

        public void OnSave()    //저장
        {
            
        }

        public void OnCancel()  //취소
        {
            SetInitPnl();

            dgvMa.Enabled = dgvMi.Enabled = true;
            dgvMi.ClearSelection();
        }

        public void OnReLoad()  //새로고침
        {
            ucMaCodeSC._Code = ucMaCodeSC._Name = "";
            cboSearchUse.SelectedIndex = 0;

            SetInitPnl();
            LoadData();
        }
        #endregion
    }
}
