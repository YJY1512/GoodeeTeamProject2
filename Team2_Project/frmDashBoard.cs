using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmDashBoard : Team2_Project.BaseForms.frmStart
    {
        string empID;
        string txt = "Top";
        DataGridView dgv;


        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            LoadData();
            empID = ((frmMain)this.MdiParent).LoginEmp.User_ID;
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

            if (txt.Equals("Top"))
                dgv = dgvDataA;
            else if (txt.Equals("Bottom"))
                dgv = dgvDataB;

            //temp//
            //WorkCenterData(dgvDataA);
            //NopData(dgvDataB);


        }

        private void WorkCenterData(DataGridView dgv) //작업장현황
        {   
            DataGridViewUtil.SetInitDataGridView(dgv);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장상태", "Wc_Status", 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장코드", "Wc_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장명", "Wc_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장그룹명", "Wc_Group_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "공정코드", "Process_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "공정명", "Process_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "팔렛생성여부", "Pallet_YN", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "사용여부", "Use_YN", 150);
            //서비스 DB연결

        }
        private void NopData(DataGridView dgv) //비가동내역
        {
            DataGridViewUtil.SetInitDataGridView(dgv);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "순번", "Nop_Seq", 60);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동발생일자", "Nop_Date", 160);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동발생일시", "Nop_HappenTime", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동해제일시", "Nop_CancelTime", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동시간(분)", "Nop_Time", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장코드", "Wc_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장명", "Wc_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "작업장그룹", "Wc_Group", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "공정명", "Process_Name", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동대분류코드", "Nop_Ma_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동상세분류코드", "Nop_Mi_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동상세분류명", "Nop_Mi_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동대분류코드", "Nop_Ma_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동대분류명", "Nop_Ma_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgv, "비가동유형", "Nop_type", 150);
        }

        private void ProductionData() //생산진행현황
        {


        }

        private void ProductionHistoryData() //생산실적
        {


        }


    }
}
