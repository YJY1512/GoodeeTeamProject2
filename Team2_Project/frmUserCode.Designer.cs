
namespace Team2_Project
{
    partial class frmUserCode
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
            this.dgvMa = new System.Windows.Forms.DataGridView();
            this.dgvMi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlSub.SuspendLayout();
            this.pnlListL.SuspendLayout();
            this.pnlListR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMi)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSearchUse
            // 
            this.cboSearchUse.Size = new System.Drawing.Size(121, 24);
            this.cboSearchUse.Text = "";
            // 
            // lblSearchName
            // 
            this.lblSearchName.Size = new System.Drawing.Size(138, 17);
            this.lblSearchName.Text = "사용자정의 대분류명";
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.Size = new System.Drawing.Size(152, 17);
            this.lblSearchCode.Text = "사용자정의 대분류코드";
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.Text = "사용자정의 상세분류명";
            // 
            // lblInfoNameMa
            // 
            this.lblInfoNameMa.Size = new System.Drawing.Size(166, 17);
            this.lblInfoNameMa.Text = "사용자정의 상세분류코드";
            // 
            // lblInfoCodeMa
            // 
            this.lblInfoCodeMa.Size = new System.Drawing.Size(124, 17);
            this.lblInfoCodeMa.Text = "사용자정의 대분류";
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvMi);
            this.splitContainer2.Size = new System.Drawing.Size(987, 596);
            // 
            // pnlSub
            // 
            this.pnlSub.Size = new System.Drawing.Size(1484, 65);
            // 
            // pnlListL
            // 
            this.pnlListL.Controls.Add(this.dgvMa);
            this.pnlListL.Size = new System.Drawing.Size(493, 596);
            // 
            // pnlListR
            // 
            this.pnlListR.Size = new System.Drawing.Size(987, 596);
            // 
            // dgvMa
            // 
            this.dgvMa.BackgroundColor = System.Drawing.Color.White;
            this.dgvMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMa.Location = new System.Drawing.Point(0, 0);
            this.dgvMa.Name = "dgvMa";
            this.dgvMa.RowTemplate.Height = 23;
            this.dgvMa.Size = new System.Drawing.Size(493, 596);
            this.dgvMa.TabIndex = 0;
            // 
            // dgvMi
            // 
            this.dgvMi.BackgroundColor = System.Drawing.Color.White;
            this.dgvMi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMi.Location = new System.Drawing.Point(0, 0);
            this.dgvMi.Name = "dgvMi";
            this.dgvMi.RowTemplate.Height = 23;
            this.dgvMi.Size = new System.Drawing.Size(987, 363);
            this.dgvMi.TabIndex = 0;
            // 
            // frmUserCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1484, 704);
            this.Name = "frmUserCode";
            this.Text = "사용자정의 관리";
            this.Load += new System.EventHandler(this.frmUserCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlListL.ResumeLayout(false);
            this.pnlListR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMi;
        private System.Windows.Forms.DataGridView dgvMa;
    }
}