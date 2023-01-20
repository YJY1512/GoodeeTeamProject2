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
    public partial class frmUserCode : frmCodeControlBase
    {
        UserCodeService srv = new UserCodeService();

        public frmUserCode()
        {
            InitializeComponent();
        }

        private void frmUserCode_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvMa);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "사용자정의 대분류코드", "Userdefine_Ma_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "사용자정의 대분류명", "Userdefine_Ma_Name", 250);

            DataGridViewUtil.SetInitDataGridView(dgvMi);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "사용자정의 상세분류코드", "Userdefine_Mi_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "사용자정의 상세분류명", "Userdefine_Mi_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "정렬순서", "Sort_Index");
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "사용유무", "Use_YN");
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Remark", "Remark", visible:false);

            List<UserCodeDTO> list = srv.GetUserCode();            
            if (list != null)
            {
                List<UserCodeDTO> maList = list.GroupBy((c) => c.Userdefine_Ma_Code).FirstOrDefault().ToList();
                dgvMa.DataSource = maList;
                dgvMi.DataSource = list;
            }
        }
    }
}
