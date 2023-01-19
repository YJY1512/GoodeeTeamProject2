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

namespace Team2_Project
{
    public partial class frmDownCode : frmListUpAreaDown
    {
        public frmDownCode()
        {
            InitializeComponent();
        }

        private void frmDownCode_Load(object sender, EventArgs e)
        {
            cboUseYNSC.Items.Add("전체");
            cboUseYNSC.Items.Add("사용");
            cboUseYNSC.Items.Add("미사용");
            cboUseYNSC.SelectedIndex = 0;
            cboUseYNSC.DropDownStyle = ComboBoxStyle.DropDownList;

            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동 대분류코드", "Item_Code", 500);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동 대분류명", "Item_Name", 500);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "사용유무", "Use_YN", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비고", "Remark", 500);
        }

    }
}