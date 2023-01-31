
namespace Team2_Project
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.dtpSearchFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpSearchTo = new System.Windows.Forms.DateTimePicker();
            this.ucSearchItem = new Team2_Project.Controls.ucSearch();
            this.ucSearchProject = new Team2_Project.Controls.ucSearch();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.pnlSub.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.cbo);
            this.pnlSub.Controls.Add(this.ucSearchProject);
            this.pnlSub.Controls.Add(this.label5);
            this.pnlSub.Controls.Add(this.ucSearchItem);
            this.pnlSub.Controls.Add(this.dtpSearchTo);
            this.pnlSub.Controls.Add(this.dtpSearchFrom);
            this.pnlSub.Controls.Add(this.label6);
            this.pnlSub.Controls.Add(this.label3);
            this.pnlSub.Size = new System.Drawing.Size(1834, 60);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Location = new System.Drawing.Point(0, 60);
            this.pnlTitle.Size = new System.Drawing.Size(1834, 43);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvOrder);
            this.pnlList.Location = new System.Drawing.Point(0, 103);
            this.pnlList.Size = new System.Drawing.Size(1834, 808);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(39, 8);
            this.lblTitle.Size = new System.Drawing.Size(64, 17);
            this.lblTitle.Text = "조회내역";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(315, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "~";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(538, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "품목코드";
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.Name = "dgvOrder";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvOrder.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.RowTemplate.Height = 23;
            this.dgvOrder.Size = new System.Drawing.Size(1834, 808);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            this.dgvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellDoubleClick);
            this.dgvOrder.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvOrder_EditingControlShowing);
            // 
            // dtpSearchFrom
            // 
            this.dtpSearchFrom.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpSearchFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchFrom.Location = new System.Drawing.Point(170, 18);
            this.dtpSearchFrom.Name = "dtpSearchFrom";
            this.dtpSearchFrom.Size = new System.Drawing.Size(130, 25);
            this.dtpSearchFrom.TabIndex = 71;
            // 
            // dtpSearchTo
            // 
            this.dtpSearchTo.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpSearchTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchTo.Location = new System.Drawing.Point(348, 18);
            this.dtpSearchTo.Name = "dtpSearchTo";
            this.dtpSearchTo.Size = new System.Drawing.Size(130, 25);
            this.dtpSearchTo.TabIndex = 72;
            // 
            // ucSearchItem
            // 
            this.ucSearchItem._Code = "";
            this.ucSearchItem._Name = "";
            this.ucSearchItem.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearchItem.Location = new System.Drawing.Point(615, 18);
            this.ucSearchItem.Margin = new System.Windows.Forms.Padding(4);
            this.ucSearchItem.Name = "ucSearchItem";
            this.ucSearchItem.Size = new System.Drawing.Size(340, 28);
            this.ucSearchItem.TabIndex = 73;
            this.ucSearchItem.BtnClick += new System.EventHandler(this.ucSearchItem_BtnClick);
            // 
            // ucSearchProject
            // 
            this.ucSearchProject._Code = "";
            this.ucSearchProject._Name = "";
            this.ucSearchProject.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearchProject.Location = new System.Drawing.Point(1122, 18);
            this.ucSearchProject.Margin = new System.Windows.Forms.Padding(4);
            this.ucSearchProject.Name = "ucSearchProject";
            this.ucSearchProject.Size = new System.Drawing.Size(340, 28);
            this.ucSearchProject.TabIndex = 75;
            this.ucSearchProject.BtnClick += new System.EventHandler(this.ucSearchProject_BtnClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(1015, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 74;
            this.label5.Text = "프로젝트코드";
            // 
            // cbo
            // 
            this.cbo.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(30, 18);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(110, 25);
            this.cbo.TabIndex = 76;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmOrder";
            this.Text = "생산요청 관리";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DateTimePicker dtpSearchTo;
        private System.Windows.Forms.DateTimePicker dtpSearchFrom;
        private Controls.ucSearch ucSearchItem;
        private Controls.ucSearch ucSearchProject;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo;
    }
}