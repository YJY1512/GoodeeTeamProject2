using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project_DTO;
using Team2_Project_POP.Services;

namespace Team2_Project_POP
{
    public partial class frmProductionList : Form
    {
        //List<WorkOrderDTO> workList = null;
        int pages = 1;
        PoPService serv = new PoPService();

        Controls.ucList selectedOrder = null;

        public frmProductionList()
        {
            InitializeComponent();
        }


        private void frmProductionList_Load(object sender, EventArgs e)
        {
            ((frmParent)this.MdiParent).btnBack.Visible = false;

            int screenWidh = Screen.PrimaryScreen.Bounds.Width;
            btnStart.Size = btnStop.Size = btnPalette.Size = btnPerfomance.Size = btnFinish.Size = btnNonP.Size = new Size(screenWidh / 6, 150);
            btnStop.Location = new Point((screenWidh / 6), 0);
            btnPalette.Location = new Point((screenWidh / 6) * 2, 0);
            btnPerfomance.Location = new Point((screenWidh / 6) * 3, 0);
            btnFinish.Location = new Point((screenWidh / 6) * 4, 0);
            btnNonP.Location = new Point((screenWidh / 6) * 5, 0);
        }

        private void List_ucListClick(object sender, EventArgs e)
        {
            if (((Controls.ucList)sender).isClick)
            {
                ((Controls.ucList)sender).isClick = false;
                selectedOrder = null;
                ((frmParent)MdiParent).SelectedWorkOrder = new PopPrdDTO();
                
                ((Controls.ucList)sender).lblPlanDate.BackColor = Color.White;
                ((Controls.ucList)sender).lblProductDate.BackColor = Color.White;
                ((Controls.ucList)sender).lblProcessNum.BackColor = Color.White;
                ((Controls.ucList)sender).lblProductName.BackColor = Color.White;
                ((Controls.ucList)sender).lblPlanQty.BackColor = Color.White;
                ((Controls.ucList)sender).lblIngQty.BackColor = Color.White;
                ((Controls.ucList)sender).lblStartTime.BackColor = Color.White;
                ((Controls.ucList)sender).lblFinishTime.BackColor = Color.White;
                ((Controls.ucList)sender).lblRemark.BackColor = Color.White;
            }
            else
            {
                foreach(var listitem in pnlList.Controls)
                {
                    if(((Controls.ucList)listitem).isClick == true)
                    {
                        ((Controls.ucList)listitem).isClick = false;
                        ((Controls.ucList)listitem).lblPlanDate.BackColor = Color.White;
                        ((Controls.ucList)listitem).lblProductDate.BackColor = Color.White;
                        ((Controls.ucList)listitem).lblProcessNum.BackColor = Color.White;
                        ((Controls.ucList)listitem).lblProductName.BackColor = Color.White;
                        ((Controls.ucList)listitem).lblPlanQty.BackColor = Color.White;
                        ((Controls.ucList)listitem).lblIngQty.BackColor = Color.White;
                        ((Controls.ucList)listitem).lblStartTime.BackColor = Color.White;
                        ((Controls.ucList)listitem).lblFinishTime.BackColor = Color.White;
                        ((Controls.ucList)listitem).lblRemark.BackColor = Color.White;
                    }
                }
                ((Controls.ucList)sender).isClick = true;
                selectedOrder = (Controls.ucList)sender;
                ((Controls.ucList)sender).lblPlanDate.BackColor = Color.PeachPuff;
                ((Controls.ucList)sender).lblProductDate.BackColor = Color.PeachPuff;
                ((Controls.ucList)sender).lblProcessNum.BackColor = Color.PeachPuff;
                ((Controls.ucList)sender).lblProductName.BackColor = Color.PeachPuff;
                ((Controls.ucList)sender).lblPlanQty.BackColor = Color.PeachPuff;
                ((Controls.ucList)sender).lblIngQty.BackColor = Color.PeachPuff;
                ((Controls.ucList)sender).lblStartTime.BackColor = Color.PeachPuff;
                ((Controls.ucList)sender).lblFinishTime.BackColor = Color.PeachPuff;
                ((Controls.ucList)sender).lblRemark.BackColor = Color.PeachPuff;
            }
        }
        /// <summary>
        /// Start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null || selectedOrder.Status_Code == "W02" || selectedOrder.Status_Code == "W04") return;

            foreach(var list in pnlList.Controls)
            {
                if (((Controls.ucList)list).Status_Code == "W02") 
                {
                    
                    return; 
                }
            }
            // 대기 >>  생산 중인 경우

            ((frmParent)this.MdiParent).WorkOrderList = serv.UpdateWork(selectedOrder.WorkOrderNo, ((frmParent)this.MdiParent).SelectedWorkLine.Wc_Code, "W02");
            frmProductionList_Enter(this, e);
        }
        /// <summary>
        /// Stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null || selectedOrder.Status_Code != "W02") return;

            ((frmParent)this.MdiParent).WorkOrderList = serv.UpdateWork(selectedOrder.WorkOrderNo, ((frmParent)this.MdiParent).SelectedWorkLine.Wc_Code, "W03");
            frmProductionList_Enter(this, e);
        }
        /// <summary>
        /// 팔렛트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPalette_Click(object sender, EventArgs e)
        {
            if (((frmParent)this.MdiParent).SelectedWorkLine.Pallet_YN == "아니오") return;
            if (selectedOrder == null) return;
            ((frmParent)this.MdiParent).SelectedWorkOrder = serv.SetWrorkOrder(selectedOrder.WorkOrderNo);
            frmPalette frm = new frmPalette();
            frm.MdiParent = MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        /// <summary>
        /// 현장마감
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null || selectedOrder.Status_Code != "W02" || selectedOrder.PlanQty > selectedOrder.Prd_Qty) return;

            ((frmParent)this.MdiParent).WorkOrderList = serv.UpdateWork(selectedOrder.WorkOrderNo, ((frmParent)this.MdiParent).SelectedWorkLine.Wc_Code, "W04");
            frmProductionList_Enter(this, e);
        }
        /// <summary>
        /// 실적등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPerfomance_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null || selectedOrder.Status_Code != "W02") return;

            ((frmParent)this.MdiParent).SelectedWorkOrder = serv.SetWrorkOrder(selectedOrder.WorkOrderNo);

            //PopPrdDTO selected = new PopPrdDTO
            //{
            //    WorkLineName = ((frmParent)this.MdiParent).SelectedWorkLine.Wc_Name,
            //    WorkLineCode = ((frmParent)this.MdiParent).SelectedWorkLine.Wc_Code,
            //    WorkOrderDate = selectedOrder.Plan_Date,
            //    PrdDate = selectedOrder.Prd_Date,
            //    WorkOrderNo = selectedOrder.WorkOrderNo,
            //    PrdCode = selectedOrder.ItemCode,
            //    PrdName = selectedOrder.ItemName,
            //    PlanQty = selectedOrder.PlanQty,
            //    PrdStartTime = selectedOrder.StartTime,
            //    PrdEndTime = selectedOrder.EndTime,
            //    Remark = selectedOrder.Remark
            //};

            //((frmParent)this.MdiParent).SelectedWorkOrder = selected;

            frmPerformance frm = new frmPerformance();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            
            frm.Show();

            frmProductionList_Enter(this, e);
        }

        
        
        /// <summary>
        /// 비가동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNonP_Click(object sender, EventArgs e)
        {
            
            frmNonOperate frm = new frmNonOperate();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();

            frmProductionList_Enter(this, e);

        }

        private void frmProductionList_Enter(object sender, EventArgs e)
        {
            //((frmParent)this.MdiParent).WorkOrderList = serv.UpdateWork(selectedOrder.WorkOrderNo, ((frmParent)this.MdiParent).SelectedWorkLine.Wc_Code, "W04");
            // parent에 작업장 리스트 중에 선택된 작업장 리스트를 DB 에서 가져와 넣기
            ((frmParent)this.MdiParent).WorkOrderList = serv.GetOrders(((frmParent)this.MdiParent).SelectedWorkLine.Wc_Code);

            if (pages == 1)
            {
                btnUp.Visible = false;
            }
            else
            {
                btnUp.Visible = true;
            }

            lblPage.Text = pages.ToString();

            lblTotPage.Text = Math.Ceiling(((frmParent)this.MdiParent).WorkOrderList.Count / 6.0).ToString();

            if (pages == Math.Ceiling(((frmParent)this.MdiParent).WorkOrderList.Count / 6.0))
            {
                btnDown.Visible = false;
            }
            else
            {
                btnDown.Visible = true;
            }


            pnlList.Controls.Clear();

            //for (int i = 0; i < 10; i++)
            for (int i = 0; i < ((frmParent)this.MdiParent).WorkOrderList.Count; i++)
            {
                Controls.ucList list = new Controls.ucList();

                list.Size = new Size(100, 100);
                list.Dock = DockStyle.Top;
                list.Name = $"list{i}";
                list.Status = ((frmParent)this.MdiParent).WorkOrderList[i].Wo_Status;
                list.Status_Code = ((frmParent)this.MdiParent).WorkOrderList[i].Wo_Status_Code;
                list.Plan_Date = ((frmParent)this.MdiParent).WorkOrderList[i].Plan_Date;
                list.Prd_Date = ((frmParent)this.MdiParent).WorkOrderList[i].Prd_Date;
                list.WorkOrderNo = ((frmParent)this.MdiParent).WorkOrderList[i].WorkOrderNo;
                list.ItemName = ((frmParent)this.MdiParent).WorkOrderList[i].Item_Name;
                list.ItemCode = ((frmParent)this.MdiParent).WorkOrderList[i].Item_Code;
                list.PlanQty = ((frmParent)this.MdiParent).WorkOrderList[i].Plan_Qty_Box;
                list.Prd_Qty= ((frmParent)this.MdiParent).WorkOrderList[i].Prd_Qty;
                list.StartTime = ((frmParent)this.MdiParent).WorkOrderList[i].Prd_StartTime;
                list.Remark = ((frmParent)this.MdiParent).WorkOrderList[i].Remark;
                list.Wc_Code = ((frmParent)this.MdiParent).WorkOrderList[i].Wc_Code;
                list.isClick = false;

                list.UcListClick += List_ucListClick;

                

                if (pages == (Math.Ceiling((i + 1) / (6.0))))
                {
                    pnlList.Controls.Add(list);
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (pages <= 1) return;
            pages--;
            selectedOrder = null;
            frmProductionList_Enter(this, e);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (pages >= 3) return;
            pages++;
            selectedOrder = null;
            frmProductionList_Enter(this, e);
        }
    }
}