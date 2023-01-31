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

namespace Team2_Project
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
        }

        public void SettingSave()   //저장 버튼 클릭시 
        {
            if (string.IsNullOrWhiteSpace(txtCheckPwd.Text) ||
                string.IsNullOrWhiteSpace(txtNewPW.Text) ||
                string.IsNullOrWhiteSpace(txtCheckNewPW.Text))
            {
                MessageBox.Show("모든 항목을 입력해주세요.");
                return;
            }
            //if (txtCheckPwd.Text != empPW.UserPW)
            //{
            //    MessageBox.Show("기존 비밀번호가 틀립니다. 다시 입력하세요.");
            //    return;
            //}
        }

        public void SettingCancel() //취소 버튼 클릭시 
        {

        }

    }
}
