
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.dtpSearchOrd1 = new System.Windows.Forms.DateTimePicker();
            this.dtpSearchOrd2 = new System.Windows.Forms.DateTimePicker();
            this.dtpSearchDue1 = new System.Windows.Forms.DateTimePicker();
            this.dtpSearchDue2 = new System.Windows.Forms.DateTimePicker();
            this.ucSearch1 = new Team2_Project.Controls.ucSearch();
            this.pnlSub.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.ucSearch1);
            this.pnlSub.Controls.Add(this.dtpSearchDue2);
            this.pnlSub.Controls.Add(this.dtpSearchDue1);
            this.pnlSub.Controls.Add(this.dtpSearchOrd2);
            this.pnlSub.Controls.Add(this.dtpSearchOrd1);
            this.pnlSub.Controls.Add(this.label6);
            this.pnlSub.Controls.Add(this.label3);
            this.pnlSub.Controls.Add(this.label4);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Controls.Add(this.label9);
            this.pnlSub.Size = new System.Drawing.Size(1834, 100);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Location = new System.Drawing.Point(0, 100);
            this.pnlTitle.Size = new System.Drawing.Size(1834, 43);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvOrder);
            this.pnlList.Location = new System.Drawing.Point(0, 143);
            this.pnlList.Size = new System.Drawing.Size(1834, 768);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(44, 10);
            this.lblTitle.Size = new System.Drawing.Size(60, 18);
            this.lblTitle.Text = "조회내역";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(45, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "생산요청일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(255, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(255, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "~";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(45, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "납기일";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(448, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "품목";
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 23;
            this.dgvOrder.Size = new System.Drawing.Size(1834, 768);
            this.dgvOrder.TabIndex = 0;
            // 
            // dtpSearchOrd1
            // 
            this.dtpSearchOrd1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpSearchOrd1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchOrd1.Location = new System.Drawing.Point(129, 16);
            this.dtpSearchOrd1.Name = "dtpSearchOrd1";
            this.dtpSearchOrd1.Size = new System.Drawing.Size(107, 25);
            this.dtpSearchOrd1.TabIndex = 69;
            // 
            // dtpSearchOrd2
            // 
            this.dtpSearchOrd2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpSearchOrd2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchOrd2.Location = new System.Drawing.Point(294, 16);
            this.dtpSearchOrd2.Name = "dtpSearchOrd2";
            this.dtpSearchOrd2.Size = new System.Drawing.Size(107, 25);
            this.dtpSearchOrd2.TabIndex = 70;
            // 
            // dtpSearchDue1
            // 
            this.dtpSearchDue1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpSearchDue1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchDue1.Location = new System.Drawing.Point(129, 60);
            this.dtpSearchDue1.Name = "dtpSearchDue1";
            this.dtpSearchDue1.Size = new System.Drawing.Size(107, 25);
            this.dtpSearchDue1.TabIndex = 71;
            // 
            // dtpSearchDue2
            // 
            this.dtpSearchDue2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpSearchDue2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchDue2.Location = new System.Drawing.Point(294, 60);
            this.dtpSearchDue2.Name = "dtpSearchDue2";
            this.dtpSearchDue2.Size = new System.Drawing.Size(107, 25);
            this.dtpSearchDue2.TabIndex = 72;
            // 
            // ucSearch1
            // 
            this.ucSearch1._Code = "";
            this.ucSearch1._Name = "";
            this.ucSearch1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearch1.Location = new System.Drawing.Point(491, 14);
            this.ucSearch1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Size = new System.Drawing.Size(340, 28);
            this.ucSearch1.TabIndex = 73;
            this.ucSearch1.BtnClick += new System.EventHandler(this.ucSearch1_BtnClick);
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
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DateTimePicker dtpSearchDue2;
        private System.Windows.Forms.DateTimePicker dtpSearchDue1;
        private System.Windows.Forms.DateTimePicker dtpSearchOrd2;
        private System.Windows.Forms.DateTimePicker dtpSearchOrd1;
        private Controls.ucSearch ucSearch1;
    }
}