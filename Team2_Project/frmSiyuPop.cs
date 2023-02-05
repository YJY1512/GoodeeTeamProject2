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
    public partial class frmSiyuPop : Form
    {
        public frmSiyuPop()
        {
            InitializeComponent();
        }

        List<WorkCenterDTO> wcList;

        public PlanDTO PlanInfo
        {
            set
            {
                txtPlanID.Text = value.Prd_Plan_No.ToString();
                ucProd._Code = ucProd2._Code = value.Item_Code.ToString();
                ucProd._Name = ucProd2._Name = value.Item_Name.ToString();
                ucWc._Code = ucWc2._Code = value.Wc_Code.ToString();
                ucWc._Name = ucWc2._Name = value.Wc_Name.ToString();
                txtPlanQty.Text = value.Plan_Qty.ToString();
                dtpPlanMonth.Value = Convert.ToDateTime(value.Plan_Month);
            }
        }

        public WorkOrderDTO WoInfo
        {
            get 
            {
                return new WorkOrderDTO
                {
                    Prd_Plan_No = txtPlanID.Text,
                    Plan_Date = dtpWo.Value,
                    Plan_Qty_Box = Convert.ToInt32(txtWoQty.Text),
                    Wc_Code = ucWc2._Code,
                    Ins_Emp = this.UserId
                };
            }
        }

        public string UserId { get; set; }


        private void txtWoQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ucWc2._Code) || string.IsNullOrWhiteSpace(ucWc2._Name) || string.IsNullOrWhiteSpace(txtWoQty.Text))
            {
                MessageBox.Show("필수항목을 입력해주세요");
                return;
            }

            if (txtWoQty.Text.Equals("0"))
            {
                MessageBox.Show("작업지시 수량을 입력해주세요.");
                return;
            }

            if (dtpWo.Value < DateTime.Today)
            {
                MessageBox.Show("작업지시 일자는 오늘 이전으로 설정할 수 없습니다.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ucWc2_BtnClick(object sender, EventArgs e)
        {
            ucWc2.OpenPop<WorkCenterDTO>(GetWcPopInfo());
        }

        private CommonPop<WorkCenterDTO> GetWcPopInfo()
        {
            if (wcList == null)
            {
                WorkCenterService srv = new WorkCenterService();
                wcList = srv.GetWcCodeName();
            }

            CommonPop<WorkCenterDTO> wcPopInfo = new CommonPop<WorkCenterDTO>();
            wcPopInfo.DgvDatasource = wcList;
            wcPopInfo.PopName = "작업장 검색";

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장코드", "Wc_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장명", "Wc_Name", 200));

            wcPopInfo.DgvCols = colList;

            return wcPopInfo;

        }
    }
}
