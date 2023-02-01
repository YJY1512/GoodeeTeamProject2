using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmSettingDashboard : Form
    {
        DashboardService srv = new DashboardService();

        public frmSettingDashboard()
        {
            InitializeComponent();

            //panTop.AllowDrop = true;
            //panBottom.AllowDrop = true;
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
        }


        public void SettingSave()   //저장 버튼 클릭시 
        {
            if(lblTop.Text.Equals(lblBottom.Text))
            {
                MessageBox.Show("중복된 화면입니다. 다시 설정해주십시오.","설정중복",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            DialogResult dr = MessageBox.Show("대시보드 설정을 저장하시겠습니까?", "설정저장", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                ////////////////////////////////사용자 DB에 UPDATE

                //반복문 돌면서 lblTop과 lblBottom 대시보드코드와 위치를 (top/bottom) 업데이트
                DashboardMappingDTO dto = new DashboardMappingDTO()
                {
                    User_ID = "1000",               /////////////// 사용자ID
                    DashboardItem = "",             /////////////// 대시보드 코드
                    Loc             ="",            /////////////// 위치 (top/bottom) 
                    Use_YN            ="Y",         /////////////// 사용여부 
                };
                bool result = srv.UpdateDashboardMapping();
                if(result) MessageBox.Show("저장이 완료되었습니다.", "저장완료");
                else MessageBox.Show("저장중 오류가 발생했습니다. 다시 시도하여주십시오.", "저장오류");
            }
            else if (dr == DialogResult.Cancel) return;
        }

        public void SettingCancel() //취소 버튼 클릭시 
        {
            DialogResult dr = MessageBox.Show("대시보드 설정을 취소하시겠습니까?", "설정취소", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(dr == DialogResult.OK) this.ParentForm.Close();
            else if(dr == DialogResult.Cancel) return;
        }






        private void lstContent_MouseDown(object sender, MouseEventArgs e) => DoDragDrop(((ListBox)sender).Text, DragDropEffects.All);

        private void panTop_DragOver(object sender, DragEventArgs e) => e.Effect = DragDropEffects.All;

        private void panTop_DragDrop(object sender, DragEventArgs e) => lblTop.Text = (string)e.Data.GetData(typeof(string));

        private void panBottom_DragOver(object sender, DragEventArgs e) => e.Effect = DragDropEffects.All;

        private void panBottom_DragDrop(object sender, DragEventArgs e) => lblBottom.Text = (string)e.Data.GetData(typeof(string));











        #region TEST

        //private void label1_MouseDown(object sender, MouseEventArgs e) => DoDragDrop(((Label)sender).Text, DragDropEffects.All);

        //private void textBox1_DragOver(object sender, DragEventArgs e) => e.Effect = DragDropEffects.All;

        //private void textBox1_DragDrop(object sender, DragEventArgs e) => textBox1.Text = (string)e.Data.GetData(typeof(string));

        //private void textBox1_DragEnter(object sender, DragEventArgs e)
        //{
        //    // 데이타가 문자열 타입이면 복사하고, 아니면 Drop 무효처리
        //    if (e.Data.GetDataPresent(typeof(string)))
        //    {
        //        // Drop하여 복사함
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //    else
        //    {
        //        // Drop 할 수 없음
        //        e.Effect = DragDropEffects.None;
        //    }
        //}

        //private void txtDropSource_MouseDown(object sender, MouseEventArgs e)
        //{
        //    DoDragDrop(txtDropSource.Text, DragDropEffects.Copy);
        //    //txtDropSource.Text = "";  // 만약 Move 이면 소스를 이렇게 지움
        //}

        //private void txtDropTarget_DragEnter(object sender, DragEventArgs e)
        //{
        //    // 데이타가 문자열 타입이면 복사하고, 아니면 Drop 무효처리
        //    if (e.Data.GetDataPresent(typeof(string)))
        //    {
        //        // Drop하여 복사함
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //    else
        //    {
        //        // Drop 할 수 없음
        //        e.Effect = DragDropEffects.None;
        //    }
        //}

        //private void txtDropTarget_DragDrop(object sender, DragEventArgs e)
        //{
        //    // e.Data.GetData() 메서드는 드래그-앤-드롭에서 전달된 데이타를 가져옴.
        //    // 타켓컨트롤(txtDropTarget)에 드랍 데이타 지정
        //    txtDropTarget.Text = (string)e.Data.GetData(DataFormats.StringFormat);
        //}
        #endregion
    }
}
/*
 * 사용자에 따른 대시보드정보 저장
 * 사용자ID(FK), 대시보드코드(FK), 위치, 사용여부 (+수정정보) UPDATE
 */