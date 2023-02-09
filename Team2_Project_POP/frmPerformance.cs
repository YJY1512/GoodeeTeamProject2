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
    public partial class frmPerformance : Form
    {
        
        int pdQty = 0;
        public int PDQty { get { return pdQty; } set { pdQty = value; } }

        public string DefMaCode { get; set; }
        public string DefMaName { get; set; }
        public string DefMiCode { get; set; }
        public string DefMiName { get; set; }

        PoPService ser = new PoPService();


        public frmPerformance()
        {
            InitializeComponent();
        }

        private void frmPerformance_Load(object sender, EventArgs e)
        {
            ((frmParent)this.MdiParent).btnBack.Visible = true;

            lblWorkOrderNum.Text = ((frmParent)this.MdiParent).SelectedWorkLine.WrokOrderNum;
            lblPrdName.Text = ((frmParent)this.MdiParent).SelectedWorkLine.PrdName;
            lblPlanDate.Text = ((frmParent)this.MdiParent).SelectedWorkLine.WorkOrderDate.ToString("yyyy-MM-dd");
            lblPlanQty.Text = ((frmParent)this.MdiParent).SelectedWorkLine.PlanQty.ToString();
            lblPrdQty.Text = ((frmParent)this.MdiParent).SelectedWorkLine.PrdQtySum.ToString();
            lblDefQty.Text = ((frmParent)this.MdiParent).SelectedWorkLine.DefQtySum.ToString();
        }
        /// <summary>
        /// 양품 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int sumPrd = 0;
            frmCalcPop cal = new frmCalcPop();
            
            DialogResult dr = cal.ShowDialog(this);
            
            if (dr == DialogResult.No || dr == DialogResult.Cancel) return;
            PDQty = ((frmParent)this.MdiParent).PDQtyP;
            PopPrdQtyDTO prdQty = new PopPrdQtyDTO();
            prdQty.Item_time = DateTime.Now;
            prdQty.WorkOrderNo = ((frmParent)this.MdiParent).SelectedWorkLine.WrokOrderNum;
            prdQty.Item_Code = ((frmParent)this.MdiParent).SelectedWorkLine.PrdCode;
            prdQty.Item_Rank = "";
            prdQty.PrdRankName = "";
            prdQty.Item_Qty = PDQty;

            List<PopPrdQtyDTO> lists = ser.InPrd(prdQty);

            ((frmParent)this.MdiParent).SelectedWorkLine.PrdQty = lists;

            // 그리기
            pnlPrd.Controls.Clear();

            for (int i = 0; i < ((frmParent)this.MdiParent).SelectedWorkLine.PrdQty.Count; i++)
            {
                Controls.ucPrdList list = new Controls.ucPrdList();

                list.Size = new Size(100, 60);
                list.Dock = DockStyle.Top;
                list.Name = $"list{i}";
                list.PrdDate = ((frmParent)this.MdiParent).SelectedWorkLine.PrdQty[i].Item_time;
                list.Qty = ((frmParent)this.MdiParent).SelectedWorkLine.PrdQty[i].Item_Qty;
                sumPrd += list.Qty;
                list.isClick = false;

                list.ucPrdListClick += List_ucPrdListClick;
                pnlPrd.Controls.Add(list);
            }
            
            lblPrdQty.Text = sumPrd.ToString();
        }

        private void List_ucDefListClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void List_ucPrdListClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 불량품 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDef_Click(object sender, EventArgs e)
        {
            int sumPrd = 0;
            frmCalcPop cal = new frmCalcPop();

            DialogResult dr = cal.ShowDialog(this.MdiParent);

            if (dr == DialogResult.No || dr == DialogResult.Cancel) return;

            PDQty = ((frmParent)this.MdiParent).PDQtyP;

            PopDefQtyDTO defQty = new PopDefQtyDTO();
            defQty.Item_time = DateTime.Now;
            defQty.WorkOrderNo = ((frmParent)this.MdiParent).SelectedWorkLine.WrokOrderNum;
            defQty.Item_Code = ((frmParent)this.MdiParent).SelectedWorkLine.PrdCode;
            defQty.Item_Qty = PDQty;
            defQty.DefMaCode = (this.DefMaCode == null)? "" : this.DefMaCode;
            defQty.DefMaName = (this.DefMaName == null)? "" : this.DefMaName;
            defQty.DefMiCode = (this.DefMiCode == null)? "" : this.DefMiCode;
            defQty.DefMiName = (this.DefMiName == null)? "" : this.DefMiName;

            List<PopDefQtyDTO> lists = ser.InDef(defQty);

            ((frmParent)this.MdiParent).SelectedWorkLine.DefQty = lists;

            // 그리기
            pnlDef.Controls.Clear();

            for (int i = 0; i < ((frmParent)this.MdiParent).SelectedWorkLine.DefQty.Count; i++)
            {
                Controls.ucDefList list = new Controls.ucDefList();

                list.Size = new Size(100, 60);
                list.Dock = DockStyle.Top;
                list.Name = $"list{i}";
                list.PrdDate = ((frmParent)this.MdiParent).SelectedWorkLine.DefQty[i].Item_time;
                list.Qty = ((frmParent)this.MdiParent).SelectedWorkLine.DefQty[i].Item_Qty;
                sumPrd += list.Qty;
                list.DefMaCode = ((frmParent)this.MdiParent).SelectedWorkLine.DefQty[i].DefMaCode;
                list.DefMaName = ((frmParent)this.MdiParent).SelectedWorkLine.DefQty[i].DefMaName;
                list.DefMiCode = ((frmParent)this.MdiParent).SelectedWorkLine.DefQty[i].DefMiCode;
                list.DefMiName = ((frmParent)this.MdiParent).SelectedWorkLine.DefQty[i].DefMiName;

                list.isClick = false;

                list.ucDefListClick += List_ucDefListClick;
                pnlDef.Controls.Add(list);
            }
            
            lblDefQty.Text = sumPrd.ToString();
        }

        private void frmPerformance_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("이게 맞나 싶다 ");
        }

        private void btnDefCode_Click(object sender, EventArgs e)
        {
            frmDefListPopUp popUP = new frmDefListPopUp();
            DialogResult dr = popUP.ShowDialog(this.MdiParent);

            if (dr == DialogResult.Cancel || dr == DialogResult.No) return;

            this.DefMaCode = ((frmParent)this.MdiParent).DefMaCodeP;
            this.DefMaName = ((frmParent)this.MdiParent).DefMaNameP;
            this.DefMiCode = ((frmParent)this.MdiParent).DefMiCodeP;
            this.DefMiName = ((frmParent)this.MdiParent).DefMiNameP;


        }
    }
}
