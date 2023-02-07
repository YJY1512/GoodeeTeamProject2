using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project.Services;
using Team2_Project.Utils;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmPlanAddPop : Form
    {
        PlanService srv = new PlanService();

        public string PlanMonth { get; private set; }
        public string EmpID { get; set; }

        public frmPlanAddPop()
        {
            InitializeComponent();
        }

        private void frmPlanAddPop_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvPlanHeader);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlanHeader, "생산계획월", "Plan_Month", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlanHeader, "생산계획제목", "Plan_Title", 200);

            LoadData();
        }

        private void LoadData()
        {
            List<PlanHeaderDTO> list = srv.GetPlanHeader();

            if (list != null && list.Count > 0)
            {
                dtpPlanMonth.Value = Convert.ToDateTime(list[0].Plan_Month);
                txtPlanTitle.Text = list[0].Plan_Title;
                dgvPlanHeader.DataSource = list;
            }
        }

        private void dgvPlanHeader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            dtpPlanMonth.Value = Convert.ToDateTime(dgvPlanHeader["Plan_Month", e.RowIndex].Value);
            txtPlanTitle.Text = dgvPlanHeader["Plan_Title", e.RowIndex].Value.ToString();
        }

        private bool isPlanHeadY()
        {
            bool flag = false;
            string planMonth = dtpPlanMonth.Value.ToString("yyyy-MM");
            foreach (DataGridViewRow row in dgvPlanHeader.Rows)
            {
                if (row.Cells["Plan_Month"].Value.ToString() == planMonth)
                {
                    flag = true;
                    break;
                }
            }

            return flag; //생산계획 있으면 true, 없으면 false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isValid = isPlanHeadY();

            if (isValid)
            {
                MessageBox.Show("기존에 생성된 생산계획이 있습니다.");
                return;
            }

            int result = srv.UpsertPlanHeader(new PlanHeaderDTO
            {
                Plan_Month = dtpPlanMonth.Value.ToString("yyyy-MM"),
                Plan_Title = txtPlanTitle.Text,
                Ins_Emp = EmpID
            });

            if (result == 1)
            {
                LoadData();
            }
            else if (result == 2627) //pk 충돌
            {
                MessageBox.Show("기존에 생성된 생산계획이 있습니다.");
                LoadData();
            }
            else
            {
                MessageBox.Show("오류가 발생하였습니다. 다시 시도하여 주십시오.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            bool isValid = isPlanHeadY();
            if (!isValid)
            {
                MessageBox.Show("기존에 생성된 생산계획이 존재하지 않습니다.");
                return;
            };

            int result = srv.UpsertPlanHeader(new PlanHeaderDTO
            {
                Plan_Month = dtpPlanMonth.Value.ToString("yyyy-MM"),
                Plan_Title = txtPlanTitle.Text,
                Ins_Emp = EmpID
            });

            if (result == 1)
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("오류가 발생하였습니다. 다시 시도하여 주십시오.");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string planMonth = dtpPlanMonth.Value.ToString("yyyy-MM");
            if (DialogResult.OK == MessageBox.Show($"{planMonth} 계획을 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel))
            {
                int result = srv.DelPlanHeader(planMonth);

                if (result == 0) //성공
                {
                    MessageBox.Show("삭제가 완료되었습니다.");
                    LoadData();
                }
                else if (result == 547 || result == 3726) //FK 충돌
                {
                    MessageBox.Show("데이터를 삭제할 수 없습니다.");
                }
                else
                {
                    MessageBox.Show("삭제 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {  
            PlanMonth = dtpPlanMonth.Value.ToString("yyyy-MM");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
