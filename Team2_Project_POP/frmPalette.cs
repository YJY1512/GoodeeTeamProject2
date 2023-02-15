using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project_POP.Controls;
using Team2_Project_POP.Services;

namespace Team2_Project_POP
{
    public partial class frmPalette : Form
    {
        PoPService ser = new PoPService();


        public frmPalette()
        {
            InitializeComponent();
        }

        private void frmPalette_Load(object sender, EventArgs e)
        {
            lblWorkOrderNo.Text = ((frmParent)MdiParent).SelectedWorkOrder.WorkOrderNo;
            lblItemName.Text = ((frmParent)MdiParent).SelectedWorkOrder.PrdName;
            //lblItemSize.Text = ((frmParent)MdiParent).SelectedWorkOrder.;
            // PrdQtysub = 0 으로 처리되는
            double d = Math.Ceiling(Convert.ToDouble(((frmParent)MdiParent).SelectedWorkOrder.PlanQty) / 72);
            lblBoxQty.Text = d.ToString();
            
        }

        private void frmPalette_Enter(object sender, EventArgs e)
        {
            // pnlPalette 그리기
            pnlPalette.Controls.Clear();

            ((frmParent)MdiParent).PaletteList = ser.GetPaletteList(((frmParent)MdiParent).SelectedWorkOrder.WorkOrderNo);

            for (int i = 0; i < ((frmParent)MdiParent).PaletteList.Count; i++)
            {
                ucPaletteList list = new ucPaletteList();

                list.Name = $"list{i}";
                list.Size = new Size(100, 80);
                list.Dock = DockStyle.Top;
                list.WorkOrderNo = ((frmParent)MdiParent).PaletteList[i].WorkOrderNo;
                list.PaletteNo = ((frmParent)MdiParent).PaletteList[i].PaletteNo;
                list.ItemName = ((frmParent)MdiParent).PaletteList[i].ItemName;
                list.ItemName= ((frmParent)MdiParent).PaletteList[i].ItemCode;
                list.ItemSize = ((frmParent)MdiParent).PaletteList[i].ItemSize;
                list.BoxQty = ((frmParent)MdiParent).PaletteList[i].BoxQty;
                list.isClick = false;

                list.ucPaletteList_click += List_ucPaletteList_click;
                pnlPalette.Controls.Add(list);
            }

            // wkrdjqwltl 

        }

        private void List_ucPaletteList_click(object sender, EventArgs e)
        {
            if (((ucPaletteList)sender).isClick)
            {
                ((ucPaletteList)sender).isClick = false;
                ((ucPaletteList)sender).lblISClick.BackColor = Color.Silver;
            }
            else 
            {
                ((ucPaletteList)sender).isClick = true;
                ((ucPaletteList)sender).lblISClick.BackColor = Color.Red;
            } 
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnA4_Click(object sender, EventArgs e)
        {

        }

    }
}
