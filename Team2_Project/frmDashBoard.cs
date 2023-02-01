using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team2_Project
{
    public partial class frmDashBoard : Team2_Project.BaseForms.frmStart
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //사용자에 따른 대시보드를 보여줘야함.
            //대시보드 위치컬럼에 따라서 바인딩
            
            /* 생산진행현황
             * 작업장현황
             * 생산실적
             * 비가동내역
             */





        }
    }
}
