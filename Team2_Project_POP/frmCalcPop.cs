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
    public partial class frmCalcPop : Form
    {
        StringBuilder sb = new StringBuilder();
        PoPService ser = new PoPService();

        public frmCalcPop()
        {
            InitializeComponent();
        }

        private void frmCalcPop_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            sb.Append(((Button)sender).Tag);
            txtCal.Text = sb.ToString();
        }

        private void btnZeroPoint_Click(object sender, EventArgs e)
        {
            sb.Clear();
            txtCal.Text = sb.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            sb.Remove(sb.Length - 1, 1);
            txtCal.Text = sb.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            bool result = false;
            if (this.Tag.ToString() == "Prd")
            {
                //((frmParent)Owner).SelectedWorkOrder
                PopPrdQtyDTO inPrd = new PopPrdQtyDTO {
                    WorkOrderNo = ((frmParent)Owner).SelectedWorkOrder.WorkOrderNo,
                    Item_Code = ((frmParent)Owner).SelectedWorkOrder.PrdCode,
                    Item_Rank = "",
                    Item_Qty = Convert.ToInt32(sb.ToString()),
                    Item_time = DateTime.Now
                };
                result = ser.InPrd(inPrd);
               
            }
            else if(this.Tag.ToString() == "Def")
            {
                PopDefQtyDTO inDef = new PopDefQtyDTO{
                    WorkOrderNo = ((frmParent)Owner).SelectedWorkOrder.WorkOrderNo,
                    Item_Code = ((frmParent)Owner).SelectedWorkOrder.PrdCode,
                    Item_Qty = Convert.ToInt32(sb.ToString()),
                    DefMaCode = ((frmParent)Owner).DefMaCodeP,
                    DefMiCode = ((frmParent)Owner).DefMiCodeP,
                    Item_time = DateTime.Now
                };
                result = ser.InDef(inDef);
            }
            
            if (!result) MessageBox.Show("입력 오류");

            //((frmParent)Owner).PDQtyP = Convert.ToInt32(sb.ToString());
         
            this.Close();
        }
    }
}
