using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Utils;

namespace Team2_Project
{
    public partial class frmProcessManagement : Team2_Project.frmListUpAreaDown
    {
        public event EventHandler BtnClick;
        public frmProcessManagement()
        {
            InitializeComponent();
        }

        private void frmProcessManagement_Load(object sender, EventArgs e)
        {
            // DGV 설정
            DataGridViewUtil.SetInitDataGridView(dgvProcess);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "공정코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "공정명", "", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "공정그룹", "", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "비고", "", 900);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "사용유무", "", 120);

            // 기본설정
            // 판낼 Enable 처리

        }



        /// <summary>
        /// 메인 버튼 이벤트정렬
        /// 검색, 추가, 수정, 삭제, 저장, 취소, 새로고침, 엑셀
        /// </summary>
        //검색
        public void OnSearch()
        {
            MessageBox.Show("Form1의 조회버튼 코딩");
        }
        //추가
        public void OnAdd()
        {
            MessageBox.Show("Form1의 추가버튼 코딩");
        }
        //수정
        public void OnEdit()
        {
            
            MessageBox.Show("Form1의 조회버튼 코딩");
        }
        //삭제
        public void OnDelete()
        {
            MessageBox.Show("Form1의 추가버튼 코딩");
        }
        //저장
        public void OnSave()
        {
            MessageBox.Show("Form1의 조회버튼 코딩");
        }
        //취소
        public void OnCancel()
        {
            MessageBox.Show("Form1의 추가버튼 코딩");
        }
        //새로고침
        public void OnReLoad()
        {
            MessageBox.Show("Form1의 조회버튼 코딩");
        }
        //엑셀
        public void OnPrint()
        {
            MessageBox.Show("Form1의 추가버튼 코딩");
        }

        
    }
}
