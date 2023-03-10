
namespace Team2_Project
{
    partial class frmDashBoard
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
            this.dgvDataA = new System.Windows.Forms.DataGridView();
            this.dgvDataB = new System.Windows.Forms.DataGridView();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.lblMsg2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlUp.SuspendLayout();
            this.pnlDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataB)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1834, 911);
            this.splitContainer1.SplitterDistance = 451;
            // 
            // pnlUp
            // 
            this.pnlUp.Controls.Add(this.lblMsg1);
            this.pnlUp.Controls.Add(this.dgvDataA);
            this.pnlUp.Size = new System.Drawing.Size(1834, 408);
            // 
            // lblTitleUp
            // 
            this.lblTitleUp.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleUp.Size = new System.Drawing.Size(61, 17);
            this.lblTitleUp.Text = "소제목A";
            // 
            // pnlDown
            // 
            this.pnlDown.Controls.Add(this.lblMsg2);
            this.pnlDown.Controls.Add(this.dgvDataB);
            this.pnlDown.Size = new System.Drawing.Size(1834, 413);
            // 
            // lblTitleDown
            // 
            this.lblTitleDown.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleDown.Size = new System.Drawing.Size(59, 17);
            this.lblTitleDown.Text = "소제목B";
            // 
            // dgvDataA
            // 
            this.dgvDataA.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataA.Location = new System.Drawing.Point(0, 0);
            this.dgvDataA.Name = "dgvDataA";
            this.dgvDataA.RowTemplate.Height = 23;
            this.dgvDataA.Size = new System.Drawing.Size(1834, 408);
            this.dgvDataA.TabIndex = 2;
            this.dgvDataA.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDataA_CellFormatting);
            // 
            // dgvDataB
            // 
            this.dgvDataB.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataB.Location = new System.Drawing.Point(0, 0);
            this.dgvDataB.Name = "dgvDataB";
            this.dgvDataB.RowTemplate.Height = 23;
            this.dgvDataB.Size = new System.Drawing.Size(1834, 413);
            this.dgvDataB.TabIndex = 2;
            this.dgvDataB.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDataA_CellFormatting);
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.Location = new System.Drawing.Point(13, 7);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(0, 12);
            this.lblMsg1.TabIndex = 3;
            this.lblMsg1.Visible = false;
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.Location = new System.Drawing.Point(12, 12);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(0, 12);
            this.lblMsg2.TabIndex = 4;
            this.lblMsg2.Visible = false;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Name = "frmDashBoard";
            this.Text = "DashBoard";
            this.Activated += new System.EventHandler(this.frmDashBoard_Activated);
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            this.pnlDown.ResumeLayout(false);
            this.pnlDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataA;
        private System.Windows.Forms.DataGridView dgvDataB;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.Label lblMsg2;
    }
}
