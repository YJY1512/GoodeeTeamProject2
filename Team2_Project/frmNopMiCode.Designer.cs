﻿
namespace Team2_Project
{
    partial class frmNopMiCode
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
            this.dgvMaData = new System.Windows.Forms.DataGridView();
            this.dgvMiData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlSub.SuspendLayout();
            this.pnlListL.SuspendLayout();
            this.pnlListR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiData)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSearchUse
            // 
            this.cboSearchUse.Size = new System.Drawing.Size(121, 24);
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvMiData);
            this.splitContainer2.Size = new System.Drawing.Size(1220, 803);
            this.splitContainer2.SplitterDistance = 570;
            // 
            // cboUseYN
            // 
            this.cboUseYN.Size = new System.Drawing.Size(121, 24);
            // 
            // pnlSub
            // 
            this.pnlSub.Size = new System.Drawing.Size(1834, 65);
            // 
            // pnlListL
            // 
            this.pnlListL.Controls.Add(this.dgvMaData);
            this.pnlListL.Size = new System.Drawing.Size(610, 803);
            // 
            // pnlListR
            // 
            this.pnlListR.Size = new System.Drawing.Size(1220, 803);
            // 
            // dgvMaData
            // 
            this.dgvMaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaData.Location = new System.Drawing.Point(152, 111);
            this.dgvMaData.Name = "dgvMaData";
            this.dgvMaData.RowTemplate.Height = 23;
            this.dgvMaData.Size = new System.Drawing.Size(240, 150);
            this.dgvMaData.TabIndex = 0;
            // 
            // dgvMiData
            // 
            this.dgvMiData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiData.Location = new System.Drawing.Point(305, 96);
            this.dgvMiData.Name = "dgvMiData";
            this.dgvMiData.RowTemplate.Height = 23;
            this.dgvMiData.Size = new System.Drawing.Size(240, 150);
            this.dgvMiData.TabIndex = 1;
            // 
            // frmNopMiCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Name = "frmNopMiCode";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMiData;
        private System.Windows.Forms.DataGridView dgvMaData;
    }
}
