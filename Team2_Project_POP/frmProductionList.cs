﻿using System;
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
        List<WorkOrderDTO> workList = null;

        PoPService serv = new PoPService();

        Controls.ucList selectedList = null;

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

            workList = ((frmParent)this.MdiParent).LoginedOrders;

            for (int i = 0; i < workList.Count; i++)
            {
                Controls.ucList list = new Controls.ucList();
                
                list.Size = new Size(100, 100);
                list.Dock = DockStyle.Top;
                list.Name = $"list{i}";
                list.Status = workList[i].Wo_Status;
                list.Status_Code = workList[i].Wo_Status_Code;
                list.Plan_Date = workList[i].Plan_Date;
                list.Prd_Date = workList[i].Prd_Date;
                list.WorkOrderNo = workList[i].WorkOrderNo;
                list.ItemName = workList[i].Item_Name;
                list.ItemCode = workList[i].Item_Code;
                list.PlanQty = workList[i].Plan_Qty_Box;
                list.Prd_Qty = workList[i].Prd_Qty;
                list.StartTime = workList[i].Prd_StartTime;
                list.EndTime = workList[i].Prd_EndTime;
                list.Remark = workList[i].Remark;
                list.Wc_Code = workList[i].Wc_Code;
                list.isClick = false;

                list.UcListClick += List_ucListClick;
                
                pnlList.Controls.Add(list);
            }


        }

        private void List_ucListLeave(object sender, EventArgs e)
        {
            if (((Controls.ucList)sender).isClick) return;

            ((Controls.ucList)sender).lblPlanDate.BackColor = Color.LightSkyBlue;
            ((Controls.ucList)sender).lblProductDate.BackColor = Color.LightSkyBlue;
            ((Controls.ucList)sender).lblProcessNum.BackColor = Color.LightSkyBlue;
            ((Controls.ucList)sender).lblProductName.BackColor = Color.LightSkyBlue;
            ((Controls.ucList)sender).lblPlanQty.BackColor = Color.LightSkyBlue;
            ((Controls.ucList)sender).lblIngQty.BackColor = Color.LightSkyBlue;
            ((Controls.ucList)sender).lblStartTime.BackColor = Color.LightSkyBlue;
            ((Controls.ucList)sender).lblFinishTime.BackColor = Color.LightSkyBlue;
            ((Controls.ucList)sender).lblRemark.BackColor = Color.LightSkyBlue;
        }

        private void List_ucListEnter(object sender, EventArgs e)
        {
            if (((Controls.ucList)sender).isClick) return;
            ((Controls.ucList)sender).lblPlanDate.BackColor = Color.GreenYellow;
            ((Controls.ucList)sender).lblProductDate.BackColor = Color.GreenYellow;
            ((Controls.ucList)sender).lblProcessNum.BackColor = Color.GreenYellow;
            ((Controls.ucList)sender).lblProductName.BackColor = Color.GreenYellow;
            ((Controls.ucList)sender).lblPlanQty.BackColor = Color.GreenYellow;
            ((Controls.ucList)sender).lblIngQty.BackColor = Color.GreenYellow;
            ((Controls.ucList)sender).lblStartTime.BackColor = Color.GreenYellow;
            ((Controls.ucList)sender).lblFinishTime.BackColor = Color.GreenYellow;
            ((Controls.ucList)sender).lblRemark.BackColor = Color.GreenYellow;
        }

        private void List_ucListClick(object sender, EventArgs e)
        {
            if (((Controls.ucList)sender).isClick)
            {
                ((Controls.ucList)sender).isClick = false;
                selectedList = null;
                ((Controls.ucList)sender).lblPlanDate.BackColor = Color.LightSkyBlue;
                ((Controls.ucList)sender).lblProductDate.BackColor = Color.LightSkyBlue;
                ((Controls.ucList)sender).lblProcessNum.BackColor = Color.LightSkyBlue;
                ((Controls.ucList)sender).lblProductName.BackColor = Color.LightSkyBlue;
                ((Controls.ucList)sender).lblPlanQty.BackColor = Color.LightSkyBlue;
                ((Controls.ucList)sender).lblIngQty.BackColor = Color.LightSkyBlue;
                ((Controls.ucList)sender).lblStartTime.BackColor = Color.LightSkyBlue;
                ((Controls.ucList)sender).lblFinishTime.BackColor = Color.LightSkyBlue;
                ((Controls.ucList)sender).lblRemark.BackColor = Color.LightSkyBlue;
            }
            else
            {
                foreach(var listitem in pnlList.Controls)
                {
                    if(((Controls.ucList)listitem).isClick == true)
                    {
                        ((Controls.ucList)listitem).isClick = false;
                        ((Controls.ucList)listitem).lblPlanDate.BackColor = Color.LightSkyBlue;
                        ((Controls.ucList)listitem).lblProductDate.BackColor = Color.LightSkyBlue;
                        ((Controls.ucList)listitem).lblProcessNum.BackColor = Color.LightSkyBlue;
                        ((Controls.ucList)listitem).lblProductName.BackColor = Color.LightSkyBlue;
                        ((Controls.ucList)listitem).lblPlanQty.BackColor = Color.LightSkyBlue;
                        ((Controls.ucList)listitem).lblIngQty.BackColor = Color.LightSkyBlue;
                        ((Controls.ucList)listitem).lblStartTime.BackColor = Color.LightSkyBlue;
                        ((Controls.ucList)listitem).lblFinishTime.BackColor = Color.LightSkyBlue;
                        ((Controls.ucList)listitem).lblRemark.BackColor = Color.LightSkyBlue;
                    }
                }

                ((Controls.ucList)sender).isClick = true;
                selectedList = (Controls.ucList)sender;
                ((Controls.ucList)sender).lblPlanDate.BackColor = Color.Pink;
                ((Controls.ucList)sender).lblProductDate.BackColor = Color.Pink;
                ((Controls.ucList)sender).lblProcessNum.BackColor = Color.Pink;
                ((Controls.ucList)sender).lblProductName.BackColor = Color.Pink;
                ((Controls.ucList)sender).lblPlanQty.BackColor = Color.Pink;
                ((Controls.ucList)sender).lblIngQty.BackColor = Color.Pink;
                ((Controls.ucList)sender).lblStartTime.BackColor = Color.Pink;
                ((Controls.ucList)sender).lblFinishTime.BackColor = Color.Pink;
                ((Controls.ucList)sender).lblRemark.BackColor = Color.Pink;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (selectedList == null) return;

            // 대기 >>  생산 중인 경우

            ((frmParent)this.MdiParent).LoginedOrders = serv.StartWork(selectedList.WorkOrderNo, ((frmParent)this.MdiParent).LoginedWorkCenter.Wc_Code);
            pnlList.Controls.Clear();

            workList = ((frmParent)this.MdiParent).LoginedOrders;

            for (int i = 0; i < workList.Count; i++)
            {
                Controls.ucList list = new Controls.ucList();

                list.Size = new Size(100, 100);
                list.Dock = DockStyle.Top;
                list.Name = $"list{i}";
                list.Status = workList[i].Wo_Status;
                list.Status_Code = workList[i].Wo_Status_Code;
                list.Plan_Date = workList[i].Plan_Date;
                list.Prd_Date = workList[i].Prd_Date;
                list.WorkOrderNo = workList[i].WorkOrderNo;
                list.ItemName = workList[i].Item_Name;
                list.ItemCode = workList[i].Item_Code;
                list.PlanQty = workList[i].Plan_Qty_Box;
                list.Prd_Qty = workList[i].Prd_Qty;
                list.StartTime = workList[i].Prd_StartTime;
                list.EndTime = workList[i].Prd_EndTime;
                list.Remark = workList[i].Remark;
                list.Wc_Code = workList[i].Wc_Code;
                list.isClick = false;

                list.UcListClick += List_ucListClick;
                pnlList.Controls.Add(list);
            }
        }

        private void btnPerfomance_Click(object sender, EventArgs e)
        {
            if (selectedList == null || selectedList.Status_Code != "W02") return;

            PopPrdDTO selected = new PopPrdDTO
            {
                WorkLineName = ((frmParent)this.MdiParent).LoginedWorkCenter.Wc_Name,
                WorkLineCode = ((frmParent)this.MdiParent).LoginedWorkCenter.Wc_Code,
                WorkOrderDate = selectedList.Plan_Date,
                PrdDate = selectedList.Prd_Date,
                WrokOrderNum = selectedList.WorkOrderNo,
                PrdCode = selectedList.ItemCode,
                PrdName = selectedList.ItemName,
                PlanQty = selectedList.PlanQty,
                PrdStartTime = selectedList.StartTime,
                PrdEndTime = selectedList.EndTime,
                Remark = selectedList.Remark
            };

            ((frmParent)this.MdiParent).SelectedWorkLine = selected;

            frmPerformance frm = new frmPerformance();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            
            frm.Show();
        }

        private void frmProductionList_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("이게 맞나 싶다 ");                                                                                                                  
            
        }
    }
}