
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
            // 
            // pnlUp
            // 
            this.pnlUp.Controls.Add(this.dgvDataA);
            // 
            // lblTitleUp
            // 
            this.lblTitleUp.Size = new System.Drawing.Size(56, 18);
            this.lblTitleUp.Text = "소제목d";
            // 
            // pnlDown
            // 
            this.pnlDown.Controls.Add(this.dgvDataB);
            // 
            // dgvDataA
            // 
            this.dgvDataA.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataA.Location = new System.Drawing.Point(0, 0);
            this.dgvDataA.Name = "dgvDataA";
            this.dgvDataA.RowTemplate.Height = 23;
            this.dgvDataA.Size = new System.Drawing.Size(800, 180);
            this.dgvDataA.TabIndex = 2;
            // 
            // dgvDataB
            // 
            this.dgvDataB.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataB.Location = new System.Drawing.Point(0, 0);
            this.dgvDataB.Name = "dgvDataB";
            this.dgvDataB.RowTemplate.Height = 23;
            this.dgvDataB.Size = new System.Drawing.Size(800, 180);
            this.dgvDataB.TabIndex = 2;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmDashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlUp.ResumeLayout(false);
            this.pnlDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataA;
        private System.Windows.Forms.DataGridView dgvDataB;
    }
}
