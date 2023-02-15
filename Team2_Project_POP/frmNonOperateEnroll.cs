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
using Team2_Project_POP.Utils;

namespace Team2_Project_POP
{
    public partial class frmNonOperateEnroll : Form
    {
        PoPService ser = new PoPService();
        List<DefVO> nonCodes = new List<DefVO>();
        List<DefVO> selectedLine = new List<DefVO>();

        public frmNonOperateEnroll()
        {
            InitializeComponent();
        }

        private void frmNonOperateEnroll_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvWorkLine);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkLine, "작업장", "Name", 400, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkLine, "작업장", "Code", 400, align: DataGridViewContentAlignment.MiddleCenter, visible: false);

            DataGridViewUtil.SetInitDataGridView(dgvMaNon);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaNon, "대분류", "Name", 400, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaNon, "대분류", "Code", 400, align: DataGridViewContentAlignment.MiddleCenter, visible: false);
            DataGridViewUtil.SetInitDataGridView(dgvMiNon);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiNon, "세분류", "Name", 400, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiNon, "세분류", "Code", 400, align: DataGridViewContentAlignment.MiddleCenter, visible: false);
        }

        private void frmNonOperateEnroll_Enter(object sender, EventArgs e)
        {
            lblYear.Text = DateTime.Now.Year.ToString();
            lblMonth.Text = DateTime.Now.Month.ToString();
            lblDay.Text = DateTime.Now.Day.ToString();
            lblHour.Text = DateTime.Now.Hour.ToString();
            lblMinute.Text = DateTime.Now.Minute.ToString();
            lblSecond.Text = DateTime.Now.Second.ToString();

            nonCodes = ser.SetNonCodes();
            foreach(var item in ((frmParent)MdiParent).WorkOrderList)
            {
                DefVO list = new DefVO();
                list.Code = item.Wc_Code;
                list.Name = item.Wc_Name;

                selectedLine.Add(list);
            }
            dgvWorkLine.DataSource = selectedLine;
            dgvMaNon.DataSource = nonCodes.FindAll((a) => a.Parent == "").ToList();
            
        }

        private void dgvWorkLine_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMaNon_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            var defmilist = nonCodes.FindAll((ma) => ma.Parent == dgvMaNon["Code", e.RowIndex].Value.ToString()).ToList();
            dgvMiNon.DataSource = defmilist;

            dgvMiNon.Refresh();
        }

        private void dgvMiNon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnYU_Click(object sender, EventArgs e)
        {
            lblYear.Text = ((Convert.ToInt32(lblYear.Text) + 1) >= 10000)? "9999" : (Convert.ToInt32(lblYear.Text) + 1).ToString();
        }

        private void btnYD_Click(object sender, EventArgs e)
        {
            lblYear.Text = ((Convert.ToInt32(lblYear.Text) - 1) <= 0) ? "0000" : (Convert.ToInt32(lblYear.Text) - 1).ToString();
        }

        private void btnMonU_Click(object sender, EventArgs e)
        {
            lblMonth.Text = ((Convert.ToInt32(lblMonth.Text) + 1) >= 13) ? "12" : (Convert.ToInt32(lblMonth.Text) + 1).ToString();
        }

        private void btnMonD_Click(object sender, EventArgs e)
        {
            lblMonth.Text = ((Convert.ToInt32(lblMonth.Text) - 1) < 1) ? "1" : (Convert.ToInt32(lblMonth.Text) - 1).ToString();
        }

        private void btnDU_Click(object sender, EventArgs e)
        {
            lblDay.Text = ((Convert.ToInt32(lblDay.Text) + 1) >= 32) ? "31" : (Convert.ToInt32(lblDay.Text) + 1).ToString();
        }

        private void btnDD_Click(object sender, EventArgs e)
        {
            lblDay.Text = ((Convert.ToInt32(lblDay.Text) - 1) < 1) ? "1" : (Convert.ToInt32(lblDay.Text) - 1).ToString();
        }

        private void btnHU_Click(object sender, EventArgs e)
        {
            lblHour.Text = ((Convert.ToInt32(lblHour.Text) + 1) > 23) ? "23" : (Convert.ToInt32(lblHour.Text) + 1).ToString();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            lblHour.Text = ((Convert.ToInt32(lblHour.Text) - 1) < 0) ? "00" : (Convert.ToInt32(lblHour.Text) - 1).ToString();
        }

        private void btnMinU_Click(object sender, EventArgs e)
        {
            lblMinute.Text = ((Convert.ToInt32(lblMinute.Text) + 1) > 59) ? "59" : (Convert.ToInt32(lblMinute.Text) + 1).ToString();
        }

        private void btnMinD_Click(object sender, EventArgs e)
        {
            lblMinute.Text = ((Convert.ToInt32(lblMinute.Text) - 1) < 0) ? "00" : (Convert.ToInt32(lblMinute.Text) - 1).ToString();
        }

        private void btnSU_Click(object sender, EventArgs e)
        {
            lblSecond.Text = ((Convert.ToInt32(lblSecond.Text) + 1) > 59) ? "59" : (Convert.ToInt32(lblSecond.Text) + 1).ToString();
        }

        private void btnSD_Click(object sender, EventArgs e)
        {
            lblSecond.Text = ((Convert.ToInt32(lblSecond.Text) - 1) > 0) ? "59" : (Convert.ToInt32(lblSecond.Text) - 1).ToString();
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Parse($"{lblYear.Text.ToString()}-{lblMonth.Text.ToString()}-{lblDay.Text.ToString()} {lblHour.Text.ToString()}:{lblMinute.Text.ToString()}:{lblSecond.Text.ToString()}");

            //ser.SetNop(dgvWorkLine[1,dgvWorkLine.SelectedRows[0].Index].Value.ToString(), dgvMaNon[1, dgvMaNon.SelectedRows[0].Index].Value.ToString(), dgvMiNon[1, dgvMiNon.SelectedRows[0].Index].Value.ToString(), time);

            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            lblYear.Text = DateTime.Now.Year.ToString();
            lblMonth.Text = DateTime.Now.Month.ToString();
            lblDay.Text = DateTime.Now.Day.ToString();
            lblHour.Text = DateTime.Now.Hour.ToString();
            lblMinute.Text = DateTime.Now.Minute.ToString();
            lblSecond.Text = DateTime.Now.Second.ToString();
        }

        
    }

    
}
