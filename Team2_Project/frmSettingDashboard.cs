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
        List<DashboardDTO> mappingList = new List<DashboardDTO>();
        string empID;

        public frmSettingDashboard()
        {
            InitializeComponent();
        }

        private void frmSettingDashboard_Load(object sender, EventArgs e)
        {
            empID = ((frmSettings)this.MdiParent).LoginEmp.User_ID;
            LoadData();
            //lstContent.SelectedItems[0] = Color.FromArgb(211, 226, 223);
        }

        public void LoadData()
        {
            foreach (var item in srv.GetDashList()) //생산진행현황, 작업장현황, 생산실적현황, 비가동현황
            {
                lstContent.Items.Add(item.Title_Ko);
            }

            mappingList = srv.GetData(empID);
            if (mappingList.Count > 0)
            {
                lblTop.Text = (from top in mappingList
                               where top.Loc.Equals("U")
                               select top.Title_Ko).ToList().FirstOrDefault();
                lblBottom.Text = (from top in mappingList
                                  where top.Loc.Equals("L")
                                  select top.Title_Ko).ToList().FirstOrDefault();
            }
            else
                lblTop.Text = lblBottom.Text = "미선택";
        }

        #region 마우스 드래그이벤트
        private void lstContent_MouseDown(object sender, MouseEventArgs e) => DoDragDrop(((ListBox)sender).Text, DragDropEffects.All);

        private void panTop_DragOver(object sender, DragEventArgs e) => e.Effect = DragDropEffects.All;

        private void panTop_DragDrop(object sender, DragEventArgs e) => lblTop.Text = (string)e.Data.GetData(typeof(string));

        private void panBottom_DragOver(object sender, DragEventArgs e) => e.Effect = DragDropEffects.All;

        private void panBottom_DragDrop(object sender, DragEventArgs e) => lblBottom.Text = (string)e.Data.GetData(typeof(string));
        #endregion

        #region 버튼 클릭이벤트
        public void SettingSave()   //저장 버튼 클릭시 
        {
            if (lblTop.Text.Equals(lblBottom.Text))
            {
                MessageBox.Show("중복된 화면입니다. 다시 설정해주십시오.", "설정중복", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dr = MessageBox.Show("대시보드 설정을 저장하시겠습니까?", "설정저장", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                
                DashboardDTO dto = new DashboardDTO() //사용자 DB에 UPDATE //반복문 돌면서 lblTop과 lblBottom 대시보드코드와 위치를 (top/bottom) 업데이트
                {
                    User_ID = empID,
                    TopPage = lblTop.Text,
                    BottomPage = lblBottom.Text
                };
                bool result = srv.UpdateDashboardMapping(dto);
                if (result)
                {
                    MessageBox.Show("저장이 완료되었습니다. 재로그인시 반영됩니다.", "저장완료", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.ParentForm.Close();
                }
                else MessageBox.Show("저장중 오류가 발생했습니다. 다시 시도하여주십시오.", "저장오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dr == DialogResult.Cancel) return;
        }

        public void SettingCancel() //취소 버튼 클릭시 
        {
            DialogResult dr = MessageBox.Show("대시보드 설정을 취소하시겠습니까?", "설정취소", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK) this.ParentForm.Close();
            else if (dr == DialogResult.Cancel) return;
        }
        #endregion
    }
}