
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
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.pnlSub.Size = new System.Drawing.Size(1100, 120);
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
            this.pnlList.Size = new System.Drawing.Size(1100, 223);
            // 
            // pnlArea
            // 
            this.pnlArea.Size = new System.Drawing.Size(1100, 197);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 120);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 510);
            this.splitContainer1.SplitterDistance = 266;
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
            this.dgvWorkOrder.Size = new System.Drawing.Size(1100, 223);
            this.dgvWorkOrder.TabIndex = 0;
            // 
            // frmWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Name = "frmWorkOrder";
            this.Text = "작업지시 생성 및 마감";
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
    }
}
