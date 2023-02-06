using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Services;
using Team2_Project.Utils;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmWorkOrder : Team2_Project.frmListUpAreaDown
    {
        List<WorkCenterDTO> wcList;
        List<ItemDTO> itemList;

        WorkOrderService srv = new WorkOrderService();
        public frmWorkOrder()
        {
            InitializeComponent();
        }

        private void txtWoQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void frmWorkOrder_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvWorkOrder);
            DataGridViewCheckBoxColumn cbk2 = new DataGridViewCheckBoxColumn();
            cbk2.Width = 30;
            cbk2.Frozen = true;
            dgvWorkOrder.Columns.Add(cbk2);

            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시상태", "Wo_Status", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시번호", "WorkOrderNo", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시일자", "Plan_Date", 120, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업지시수량", "Plan_Qty_Box", 120, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "품목코드", "Item_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "품목명", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업장코드", "Wc_Code", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "작업장명", "Wc_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "생산일자", "Prd_Date", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "생산수량", "Prd_Qty", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "Wo_Status_code", "Wo_Status_code", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkOrder, "Prd_Plan_No", "Prd_Plan_No", visible: false);
        }

        private void LoadData()
        {
            dgvWorkOrder.DataSource = null;

        }


        #region 데이터그리드뷰 pop열기 관련 메서드
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

        private CommonPop<ItemDTO> GetItemPopInfo()
        {
            if (itemList == null)
            {
                ItemService srv = new ItemService();
                itemList = srv.GetItemCodeName();
            }

            CommonPop<ItemDTO> itemPopInfo = new CommonPop<ItemDTO>();
            itemPopInfo.DgvDatasource = itemList;
            itemPopInfo.PopName = "품목 검색";

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목코드", "Item_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목명", "Item_Name", 200));

            itemPopInfo.DgvCols = colList;

            return itemPopInfo;
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

        #endregion

        private void ucProd_BtnClick(object sender, EventArgs e)
        {
            ucProd.OpenPop(GetItemPopInfo());
        }

        private void ucWc_BtnClick(object sender, EventArgs e)
        {
            ucWc.OpenPop(GetWcPopInfo());
        }

        private void ucProcess_BtnClick(object sender, EventArgs e)
        {

        }
    }
}
