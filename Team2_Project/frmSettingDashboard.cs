using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Project
{
    public partial class frmSettingDashboard : Form
    {
        public frmSettingDashboard()
        {
            InitializeComponent();
        }

        private void frmSettingDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            lstContent.Items.Add("생산진행현황");
            lstContent.Items.Add("작업장현황");
            lstContent.Items.Add("생산실적현황");
            lstContent.Items.Add("비가동현황");

            this.AllowDrop = true;
        }


        public void SettingSave()   //저장 버튼 클릭시 
        {

        }

        public void SettingCancel() //취소 버튼 클릭시 
        {


        }



        private void lstContent_MouseDown(object sender, MouseEventArgs e) => DoDragDrop(((ListBox)sender).Text, DragDropEffects.All);

        private void panel1_DragOver(object sender, DragEventArgs e) => e.Effect = DragDropEffects.All;

        private void panel1_DragDrop(object sender, DragEventArgs e) => lblTop.Text = (string)e.Data.GetData(typeof(string));



    }
}
/*
 * 사용자에 따른 대시보드정보 저장
 * 사용자ID(FK), 대시보드코드(FK), 위치, 사용여부 (+수정정보) UPDATE
 */