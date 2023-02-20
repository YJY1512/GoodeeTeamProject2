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
using Team2_Project_POP.Controls;
using Team2_Project_POP.Services;

namespace Team2_Project_POP
{
    public partial class frmPerformance : Form
    {
        PoPService ser = new PoPService();
        int pagePrd = 1;
        int pageDef = 1;


        public frmPerformance()
        {
            InitializeComponent();
        }

        private void frmPerformance_Load(object sender, EventArgs e)
        {
            ((frmParent)this.MdiParent).btnBack.Visible = true;
        }
        /// <summary>
        /// 양품 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            frmCalcPop cal = new frmCalcPop();
            cal.Tag = "Prd";
            cal.ShowDialog(this.MdiParent);
            frmPerformance_Enter(this, e);
        }
        /// <summary>
        /// 불량품 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDef_Click(object sender, EventArgs e)
        {
            frmDefListPopUp popUP = new frmDefListPopUp();
            DialogResult drcode = popUP.ShowDialog(this.MdiParent);

            if (drcode == DialogResult.OK)
            {
                frmCalcPop cal = new frmCalcPop();
                cal.Tag = "Def";
                cal.ShowDialog(this.MdiParent);
            }
            frmPerformance_Enter(this, e);
        }


        private void btnUpPRD_Click(object sender, EventArgs e)
        {
            if (pagePrd <= 1) return;
            pagePrd--;
            frmPerformance_Enter(this, e);
        }

        private void btnDownPRD_Click(object sender, EventArgs e)
        {
            if (pagePrd >= 3) return;
            pagePrd++;
            frmPerformance_Enter(this, e);
        }

        private void btnUpDEF_Click(object sender, EventArgs e)
        {
            if (pageDef <= 1) return;
            pageDef--;
            frmPerformance_Enter(this, e);
        }

        private void btnDownDEF_Click(object sender, EventArgs e)
        {
            if (pageDef >= 3) return;
            pageDef++;
            frmPerformance_Enter(this, e);
        }

        private void frmPerformance_Enter(object sender, EventArgs e)
        {
            pnlDef.Controls.Clear();
            pnlPrd.Controls.Clear();

            ((frmParent)MdiParent).SelectedWorkOrder = ser.SetWrorkOrder(((frmParent)MdiParent).SelectedWorkOrder.WorkOrderNo);
            int sum = 0;
            lblWorkOrderNum.Text = ((frmParent)this.MdiParent).SelectedWorkOrder.WorkOrderNo;
            lblPrdName.Text = ((frmParent)this.MdiParent).SelectedWorkOrder.PrdName;
            lblPlanDate.Text = ((frmParent)this.MdiParent).SelectedWorkOrder.WorkOrderDate.ToString("yyyy-MM-dd");
            lblPlanQty.Text = ((frmParent)this.MdiParent).SelectedWorkOrder.PlanQty.ToString();

            if (pagePrd == 1)
            {
                btnUpPRD.Visible = false;
            }
            else
            {
                btnUpPRD.Visible = true;
            }

            lblPagePRD.Text = pagePrd.ToString();

            lblTotPagePRD.Text = Math.Ceiling(((frmParent)this.MdiParent).SelectedWorkOrder.PrdQty.Count / 6.0).ToString();

            if (pageDef == Math.Ceiling(((frmParent)this.MdiParent).SelectedWorkOrder.PrdQty.Count / 6.0))
            {
                btnDownDEF.Visible = false;
            }
            else
            {
                btnDownDEF.Visible = true;
            }


            if (pageDef == 1)
            {
                btnUpDEF.Visible = false;
            }
            else
            {
                btnUpDEF.Visible = true;
            }

            lblPageDEF.Text = pageDef.ToString();

            lblTotPageDEF.Text = Math.Ceiling(((frmParent)this.MdiParent).SelectedWorkOrder.DefQty.Count / 6.0).ToString();

            if (pageDef == Math.Ceiling(((frmParent)this.MdiParent).SelectedWorkOrder.DefQty.Count / 6.0))
            {
                btnDownDEF.Visible = false;
            }
            else
            {
                btnDownDEF.Visible = true;
            }


            for (int i = 0; i < ((frmParent)this.MdiParent).SelectedWorkOrder.PrdQty.Count; i++)
            {
                sum += ((frmParent)this.MdiParent).SelectedWorkOrder.PrdQty[i].Item_Qty;
                ucPrdList prdList = new ucPrdList();
                prdList.Name = $"list{i}";
                prdList.PrdDate = ((frmParent)this.MdiParent).SelectedWorkOrder.PrdQty[i].Item_time;
                prdList.Qty = ((frmParent)this.MdiParent).SelectedWorkOrder.PrdQty[i].Item_Qty;
                prdList.Size = new Size(100, 80);
                prdList.Dock = DockStyle.Top;

                if (pagePrd == (Math.Ceiling((i + 1) / (6.0))))
                {
                    pnlPrd.Controls.Add(prdList);
                }
            }

            lblPrdQty.Text = sum.ToString();
            sum = 0;

            for (int i = 0; i < ((frmParent)this.MdiParent).SelectedWorkOrder.DefQty.Count; i++)
            {
                sum += ((frmParent)this.MdiParent).SelectedWorkOrder.DefQty[i].Item_Qty;
                ucDefList defList = new ucDefList();
                defList.Name = $"list{i}";
                defList.DefMiName = ((frmParent)this.MdiParent).SelectedWorkOrder.DefQty[i].DefMiName;
                defList.PrdDate = ((frmParent)this.MdiParent).SelectedWorkOrder.DefQty[i].Item_time;
                defList.Qty = ((frmParent)this.MdiParent).SelectedWorkOrder.DefQty[i].Item_Qty;
                defList.Size = new Size(100, 80);
                defList.Dock = DockStyle.Top;

                if (pageDef == (Math.Ceiling((i + 1) / (6.0))))
                {
                    pnlDef.Controls.Add(defList);
                }
            }

            lblDefQty.Text = sum.ToString();
        }
    }
}
