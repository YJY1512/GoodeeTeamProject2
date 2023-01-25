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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtID.Text = "1000";
            txtPwd.Text = "1000";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtPwd.Text))
                {
                    MessageBox.Show("ID와 비밀번호를 입력해주세요.");
                    return;
                }
                

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
