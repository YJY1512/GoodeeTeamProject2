using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project_DTO;

namespace Team2_Project.Utils
{
    public class DataGridViewUtil
    {
        public static void SetInitDataGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;//DataSource를 기준으로 자동 컬럼을 생성 (기본값이 true)
            dgv.AllowUserToAddRows = false;//마지막에 + 행추가 삭제 (기본값이 true)
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersWidth = 25;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 40;
            dgv.RowTemplate.Height = 30;                        
        }

        public static void AddGridTextBoxColumn(
            DataGridView dgv,
            string headerText,
            string propertyName,
            int colWidth = 100,
            DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleLeft,
            bool visible = true,
            bool frosen = false,
            bool OrangebackColor = false)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = propertyName;
            col.HeaderText = headerText;
            
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            //Alignment : 가운데정렬 (길이가 고정적인 경우)
            //Alignment : 왼쪽정렬 (길이가 가변적인 문자열인 경우)
            //Alignment : 오른쪽정렬 (길이가 가변적인 숫자인 경우, 돈, 수량 등)
            col.DataPropertyName = propertyName;
            col.DefaultCellStyle.Alignment = align;
            col.Width = colWidth;
            col.ReadOnly = true;
            col.Visible = visible;
            col.Frozen = frosen;

            if (OrangebackColor)
            {
                col.DefaultCellStyle.BackColor = Color.PeachPuff;
            }

            dgv.Columns.Add(col);
        }



        public static DataGridViewTextBoxColumn ReturnNewDgvColumn(
            string headerText,
            string propertyName,
            int colWidth = 100,
            DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();

            col.Name = propertyName;
            col.HeaderText = headerText;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.DataPropertyName = propertyName;
            col.DefaultCellStyle.Alignment = align;
            col.Width = colWidth;
            col.ReadOnly = true;

            return col;
        }

        public static void AddCheckBoxColumn(
            DataGridView grid, 
            string headerText, 
            string propertyName,  
            int width, 
            DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleCenter, 
            bool frozen = false, 
            bool visible = true,
            bool disable = false)
        {
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.HeaderText = headerText;
            col.Width = width;
            col.DataPropertyName = propertyName;
            col.Frozen = frozen;
            col.Visible = visible;
            col.ReadOnly = disable;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns.Add(col);
        }

        public static void AddGridComboBoxColumn(DataGridView dgv,
            string headerText,
            string propertyName,
            string valueMember,
            string displaymember,
            List<AuthDTO> dataSource,
            int colWidth = 100,
            DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleCenter,
            bool visible = true, bool frozen = false)
        {
            DataGridViewComboBoxColumn cbm = new DataGridViewComboBoxColumn();

            cbm.HeaderText = headerText;
            cbm.Name = propertyName;
            cbm.DataPropertyName = propertyName;

            cbm.ValueMember = valueMember;
            cbm.DisplayMember = displaymember;
            cbm.DataSource = dataSource;

            //foreach (var i in dataSource)
            //{
            //    cbm.Items.Add(i.Name);
            //}



            cbm.Width = colWidth;
            cbm.DefaultCellStyle.Alignment = align;
            cbm.Visible = visible;
            dgv.Columns.Add(cbm);
        }
    }
}
