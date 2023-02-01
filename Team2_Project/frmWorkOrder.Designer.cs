
namespace Team2_Project
{
    partial class frmWorkOrder
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucWcGrp = new Team2_Project.Controls.ucSearch();
            this.label1 = new System.Windows.Forms.Label();
            this.ucWc = new Team2_Project.Controls.ucSearch();
            this.label13 = new System.Windows.Forms.Label();
            this.ucProd = new Team2_Project.Controls.ucSearch();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpReqTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpReqFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvWorkOrder = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTitleD.SuspendLayout();
            this.pnlTitleU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.dtpReqTo);
            this.pnlSub.Controls.Add(this.label6);
            this.pnlSub.Controls.Add(this.dtpReqFrom);
            this.pnlSub.Controls.Add(this.label4);
            this.pnlSub.Controls.Add(this.ucWcGrp);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Controls.Add(this.ucWc);
            this.pnlSub.Controls.Add(this.label13);
            this.pnlSub.Controls.Add(this.ucProd);
            this.pnlSub.Controls.Add(this.label12);
            this.pnlSub.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSub.Size = new System.Drawing.Size(1232, 120);
            // 
            // lblTitleU
            // 
            this.lblTitleU.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleU.Size = new System.Drawing.Size(92, 17);
            this.lblTitleU.Text = "작업지시목록";
            // 
            // lblTitleD
            // 
            this.lblTitleD.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleD.Size = new System.Drawing.Size(124, 17);
            this.lblTitleD.Text = "작업지시 상세목록";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvWorkOrder);
            this.pnlList.Size = new System.Drawing.Size(1232, 223);
            // 
            // pnlArea
            // 
            this.pnlArea.Size = new System.Drawing.Size(1232, 197);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 120);
            this.splitContainer1.Size = new System.Drawing.Size(1232, 510);
            this.splitContainer1.SplitterDistance = 266;
            // 
            // pnlTitleD
            // 
            this.pnlTitleD.Size = new System.Drawing.Size(1232, 43);
            // 
            // pnlTitleU
            // 
            this.pnlTitleU.Controls.Add(this.label15);
            this.pnlTitleU.Controls.Add(this.label16);
            this.pnlTitleU.Controls.Add(this.label10);
            this.pnlTitleU.Controls.Add(this.label14);
            this.pnlTitleU.Controls.Add(this.label8);
            this.pnlTitleU.Controls.Add(this.label9);
            this.pnlTitleU.Controls.Add(this.label5);
            this.pnlTitleU.Controls.Add(this.label7);
            this.pnlTitleU.Controls.Add(this.label11);
            this.pnlTitleU.Controls.Add(this.label17);
            this.pnlTitleU.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTitleU.Size = new System.Drawing.Size(1232, 43);
            this.pnlTitleU.Controls.SetChildIndex(this.lblTitleU, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label17, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label11, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label7, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label5, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label9, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label8, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label14, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label10, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label16, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label15, 0);
            // 
            // ucWcGrp
            // 
            this.ucWcGrp._Code = "";
            this.ucWcGrp._Name = "";
            this.ucWcGrp.BackColor = System.Drawing.Color.Transparent;
            this.ucWcGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucWcGrp.Location = new System.Drawing.Point(588, 23);
            this.ucWcGrp.Margin = new System.Windows.Forms.Padding(4);
            this.ucWcGrp.Name = "ucWcGrp";
            this.ucWcGrp.Size = new System.Drawing.Size(340, 28);
            this.ucWcGrp.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(523, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "공정";
            // 
            // ucWc
            // 
            this.ucWc._Code = "";
            this.ucWc._Name = "";
            this.ucWc.BackColor = System.Drawing.Color.Transparent;
            this.ucWc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucWc.Location = new System.Drawing.Point(588, 69);
            this.ucWc.Margin = new System.Windows.Forms.Padding(4);
            this.ucWc.Name = "ucWc";
            this.ucWc.Size = new System.Drawing.Size(340, 28);
            this.ucWc.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(523, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "작업장";
            // 
            // ucProd
            // 
            this.ucProd._Code = "";
            this.ucProd._Name = "";
            this.ucProd.BackColor = System.Drawing.Color.Transparent;
            this.ucProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucProd.Location = new System.Drawing.Point(137, 69);
            this.ucProd.Margin = new System.Windows.Forms.Padding(4);
            this.ucProd.Name = "ucProd";
            this.ucProd.Size = new System.Drawing.Size(340, 28);
            this.ucProd.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(30, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "품목";
            // 
            // dtpReqTo
            // 
            this.dtpReqTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReqTo.Location = new System.Drawing.Point(292, 23);
            this.dtpReqTo.Name = "dtpReqTo";
            this.dtpReqTo.Size = new System.Drawing.Size(125, 25);
            this.dtpReqTo.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(268, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "~";
            // 
            // dtpReqFrom
            // 
            this.dtpReqFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReqFrom.Location = new System.Drawing.Point(137, 23);
            this.dtpReqFrom.Name = "dtpReqFrom";
            this.dtpReqFrom.Size = new System.Drawing.Size(125, 25);
            this.dtpReqFrom.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(30, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "작업지시일자";
            // 
            // dgvWorkOrder
            // 
            this.dgvWorkOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvWorkOrder.Name = "dgvWorkOrder";
            this.dgvWorkOrder.RowTemplate.Height = 23;
            this.dgvWorkOrder.Size = new System.Drawing.Size(1232, 223);
            this.dgvWorkOrder.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(639, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "작업지시 마감";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.DarkBlue;
            this.label16.Location = new System.Drawing.Point(601, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 17);
            this.label16.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(522, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "현장마감";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Location = new System.Drawing.Point(484, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 17);
            this.label14.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(405, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "생산중지";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(367, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(302, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "생산중";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(264, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(188, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "생산대기";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Orange;
            this.label17.Location = new System.Drawing.Point(150, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 17);
            this.label17.TabIndex = 12;
            // 
            // frmWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1232, 630);
            this.Name = "frmWorkOrder";
            this.Text = "작업지시 생성 및 마감";
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlTitleD.ResumeLayout(false);
            this.pnlTitleD.PerformLayout();
            this.pnlTitleU.ResumeLayout(false);
            this.pnlTitleU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ucSearch ucWcGrp;
        private System.Windows.Forms.Label label1;
        private Controls.ucSearch ucWc;
        private System.Windows.Forms.Label label13;
        private Controls.ucSearch ucProd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpReqTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpReqFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvWorkOrder;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
    }
}
