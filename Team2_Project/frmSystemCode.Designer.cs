
namespace Team2_Project
{
    partial class frmSystemCode
    {
        //// <summary>
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
            this.dgvSysMi = new System.Windows.Forms.DataGridView();
            this.dgvSysMa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).BeginInit();
            this.pnlSub.SuspendLayout();
            this.pnlListL.SuspendLayout();
            this.pnlListR.SuspendLayout();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlListTitleL.SuspendLayout();
            this.pnlListTitleR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysMi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysMa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchName
            // 
            this.lblSearchName.Size = new System.Drawing.Size(138, 17);
            this.lblSearchName.Text = "시스템정의 대분류명";
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.Size = new System.Drawing.Size(152, 17);
            this.lblSearchCode.Text = "시스템정의 대분류코드";
            // 
            // lblInfoCodeMa
            // 
            this.lblInfoCodeMa.Size = new System.Drawing.Size(152, 17);
            this.lblInfoCodeMa.Text = "시스템정의 대분류코드";
            // 
            // lblInfoNameDe
            // 
            this.lblInfoNameDe.Size = new System.Drawing.Size(152, 17);
            this.lblInfoNameDe.Text = "시스템정의 상세분류명";
            // 
            // lblInfoCodeDe
            // 
            this.lblInfoCodeDe.Size = new System.Drawing.Size(166, 17);
            this.lblInfoCodeDe.Text = "시스템정의 상세분류코드";
            // 
            // lblInfoNameMa
            // 
            this.lblInfoNameMa.Size = new System.Drawing.Size(138, 17);
            this.lblInfoNameMa.Text = "시스템정의 대분류명";
            // 
            // comboBox1
            // 
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // cboMaUse
            // 
            this.cboMaUse.Size = new System.Drawing.Size(121, 25);
            // 
            // cboMinUse
            // 
            this.cboMinUse.Size = new System.Drawing.Size(121, 25);
            // 
            // pnlListL
            // 
            this.pnlListL.Controls.Add(this.dgvSysMa);
            this.pnlListL.Size = new System.Drawing.Size(456, 418);
            // 
            // pnlListR
            // 
            this.pnlListR.Controls.Add(this.dgvSysMi);
            this.pnlListR.Size = new System.Drawing.Size(939, 418);
            // 
            // splitContainer2
            // 
            this.splitContainer2.SplitterDistance = 456;
            // 
            // pnlListTitleL
            // 
            this.pnlListTitleL.Size = new System.Drawing.Size(456, 43);
            // 
            // pnlListTitleR
            // 
            this.pnlListTitleR.Size = new System.Drawing.Size(939, 43);
            // 
            // splitContainer1
            // 
            // 
            // dgvSysMi
            // 
            this.dgvSysMi.BackgroundColor = System.Drawing.Color.White;
            this.dgvSysMi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSysMi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSysMi.Location = new System.Drawing.Point(0, 0);
            this.dgvSysMi.Name = "dgvSysMi";
            this.dgvSysMi.RowTemplate.Height = 23;
            this.dgvSysMi.Size = new System.Drawing.Size(939, 418);
            this.dgvSysMi.TabIndex = 0;
            // 
            // dgvSysMa
            // 
            this.dgvSysMa.BackgroundColor = System.Drawing.Color.White;
            this.dgvSysMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSysMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSysMa.Location = new System.Drawing.Point(0, 0);
            this.dgvSysMa.Name = "dgvSysMa";
            this.dgvSysMa.RowTemplate.Height = 23;
            this.dgvSysMa.Size = new System.Drawing.Size(456, 418);
            this.dgvSysMa.TabIndex = 1;
            // 
            // frmSystemCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1399, 728);
            this.Name = "frmSystemCode";
            this.Text = "시스템 코드 관리";
            this.Load += new System.EventHandler(this.frmSystemCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).EndInit();
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlListL.ResumeLayout(false);
            this.pnlListR.ResumeLayout(false);
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlListTitleL.ResumeLayout(false);
            this.pnlListTitleL.PerformLayout();
            this.pnlListTitleR.ResumeLayout(false);
            this.pnlListTitleR.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysMi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysMa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSysMa;
        private System.Windows.Forms.DataGridView dgvSysMi;
    }
}