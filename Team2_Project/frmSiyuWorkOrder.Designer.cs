
namespace Team2_Project
{
    partial class frmSiyuWorkOrder
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
            this.ucWc = new Team2_Project.Controls.ucSearch();
            this.label13 = new System.Windows.Forms.Label();
            this.ucProd = new Team2_Project.Controls.ucSearch();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.ucWcGrp = new Team2_Project.Controls.ucSearch();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.dgvWorkOrder = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlSub.SuspendLayout();
            this.pnlListUP.SuspendLayout();
            this.pnlListDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.btnAdd);
            this.pnlSub.Controls.Add(this.ucWcGrp);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Controls.Add(this.ucWc);
            this.pnlSub.Controls.Add(this.label13);
            this.pnlSub.Controls.Add(this.ucProd);
            this.pnlSub.Controls.Add(this.label12);
            this.pnlSub.Controls.Add(this.dtpMonth);
            this.pnlSub.Controls.Add(this.label11);
            this.pnlSub.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlSub.Size = new System.Drawing.Size(1249, 120);
            // 
            // pnlListUP
            // 
            this.pnlListUP.Controls.Add(this.dgvPlan);
            this.pnlListUP.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlListUP.Size = new System.Drawing.Size(1249, 233);
            // 
            // lblTitleU
            // 
            this.lblTitleU.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleU.Size = new System.Drawing.Size(64, 17);
            this.lblTitleU.Text = "생산계획";
            // 
            // pnlListDown
            // 
            this.pnlListDown.Controls.Add(this.dgvWorkOrder);
            this.pnlListDown.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlListDown.Size = new System.Drawing.Size(1249, 226);
            // 
            // lblTitleD
            // 
            this.lblTitleD.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleD.Size = new System.Drawing.Size(64, 17);
            this.lblTitleD.Text = "작업지시";
            // 
            // ucWc
            // 
            this.ucWc._Code = "";
            this.ucWc._Name = "";
            this.ucWc.BackColor = System.Drawing.Color.Transparent;
            this.ucWc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucWc.Location = new System.Drawing.Point(620, 69);
            this.ucWc.Margin = new System.Windows.Forms.Padding(4);
            this.ucWc.Name = "ucWc";
            this.ucWc.Size = new System.Drawing.Size(340, 28);
            this.ucWc.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(523, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "작업장";
            // 
            // ucProd
            // 
            this.ucProd._Code = "";
            this.ucProd._Name = "";
            this.ucProd.BackColor = System.Drawing.Color.Transparent;
            this.ucProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucProd.Location = new System.Drawing.Point(123, 69);
            this.ucProd.Margin = new System.Windows.Forms.Padding(4);
            this.ucProd.Name = "ucProd";
            this.ucProd.Size = new System.Drawing.Size(340, 28);
            this.ucProd.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(30, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "품목";
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "yyyy-MM";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(123, 23);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(125, 25);
            this.dtpMonth.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(30, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "생산계획월";
            // 
            // ucWcGrp
            // 
            this.ucWcGrp._Code = "";
            this.ucWcGrp._Name = "";
            this.ucWcGrp.BackColor = System.Drawing.Color.Transparent;
            this.ucWcGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucWcGrp.Location = new System.Drawing.Point(620, 23);
            this.ucWcGrp.Margin = new System.Windows.Forms.Padding(4);
            this.ucWcGrp.Name = "ucWcGrp";
            this.ucWcGrp.Size = new System.Drawing.Size(340, 28);
            this.ucWcGrp.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(523, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "작업장 그룹";
            // 
            // dgvPlan
            // 
            this.dgvPlan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlan.Location = new System.Drawing.Point(0, 0);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowTemplate.Height = 23;
            this.dgvPlan.Size = new System.Drawing.Size(1249, 233);
            this.dgvPlan.TabIndex = 0;
            // 
            // dgvWorkOrder
            // 
            this.dgvWorkOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvWorkOrder.Name = "dgvWorkOrder";
            this.dgvWorkOrder.RowTemplate.Height = 23;
            this.dgvWorkOrder.Size = new System.Drawing.Size(1249, 226);
            this.dgvWorkOrder.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(1064, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 71);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "작업지시 생성";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // frmSiyuWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1249, 669);
            this.Name = "frmSiyuWorkOrder";
            this.Text = "시유작업지시생성";
            this.Load += new System.EventHandler(this.frmSiyuWorkOrder_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlListUP.ResumeLayout(false);
            this.pnlListDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ucSearch ucWc;
        private System.Windows.Forms.Label label13;
        private Controls.ucSearch ucProd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label label11;
        private Controls.ucSearch ucWcGrp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.DataGridView dgvWorkOrder;
        private System.Windows.Forms.Button btnAdd;
    }
}
