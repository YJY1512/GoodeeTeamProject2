﻿
namespace Team2_Project
{
    partial class frmDownCode
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
            this.cboUseYNSC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodeSC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameSC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.txtNameSC);
            this.pnlSub.Controls.Add(this.label5);
            this.pnlSub.Controls.Add(this.cboUseYNSC);
            this.pnlSub.Controls.Add(this.txtCodeSC);
            this.pnlSub.Controls.Add(this.label4);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Size = new System.Drawing.Size(1834, 59);
            // 
            // lblTitleU
            // 
            this.lblTitleU.Location = new System.Drawing.Point(45, 10);
            this.lblTitleU.Size = new System.Drawing.Size(60, 18);
            this.lblTitleU.Text = "조회내역";
            // 
            // lblTitleD
            // 
            this.lblTitleD.Location = new System.Drawing.Point(45, 10);
            this.lblTitleD.Size = new System.Drawing.Size(60, 18);
            this.lblTitleD.Text = "입력정보";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvData);
            this.pnlList.Size = new System.Drawing.Size(1834, 648);
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.label8);
            this.pnlArea.Controls.Add(this.label9);
            this.pnlArea.Controls.Add(this.label17);
            this.pnlArea.Controls.Add(this.txtRemark);
            this.pnlArea.Controls.Add(this.label18);
            this.pnlArea.Controls.Add(this.txtName);
            this.pnlArea.Controls.Add(this.txtCode);
            this.pnlArea.Controls.Add(this.label6);
            this.pnlArea.Controls.Add(this.label7);
            this.pnlArea.Size = new System.Drawing.Size(1834, 114);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 59);
            this.splitContainer1.Size = new System.Drawing.Size(1834, 852);
            this.splitContainer1.SplitterDistance = 691;
            // 
            // cboUseYNSC
            // 
            this.cboUseYNSC.FormattingEnabled = true;
            this.cboUseYNSC.Location = new System.Drawing.Point(939, 16);
            this.cboUseYNSC.Name = "cboUseYNSC";
            this.cboUseYNSC.Size = new System.Drawing.Size(136, 25);
            this.cboUseYNSC.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(860, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "사용유무";
            // 
            // txtCodeSC
            // 
            this.txtCodeSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodeSC.Location = new System.Drawing.Point(184, 16);
            this.txtCodeSC.Name = "txtCodeSC";
            this.txtCodeSC.Size = new System.Drawing.Size(202, 25);
            this.txtCodeSC.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "비가동 대분류코드";
            // 
            // txtNameSC
            // 
            this.txtNameSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameSC.Location = new System.Drawing.Point(584, 16);
            this.txtNameSC.Name = "txtNameSC";
            this.txtNameSC.Size = new System.Drawing.Size(202, 25);
            this.txtNameSC.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(454, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "비가동 대분류명";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(197, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 25);
            this.txtName.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(61, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "비가동 대분류명";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(197, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(222, 25);
            this.txtCode.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(61, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "비가동 대분류코드";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(491, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 17);
            this.label17.TabIndex = 58;
            this.label17.Text = "*";
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Location = new System.Drawing.Point(559, 20);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(364, 66);
            this.txtRemark.TabIndex = 57;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(514, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 17);
            this.label18.TabIndex = 56;
            this.label18.Text = "비고";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(25, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(25, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "*";
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(1834, 648);
            this.dgvData.TabIndex = 1;
            // 
            // frmDownCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDownCode";
            this.Text = "비가동 대분류코드";
            this.Load += new System.EventHandler(this.frmDownCode_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUseYNSC;
        protected System.Windows.Forms.TextBox txtCodeSC;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtNameSC;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox txtName;
        protected System.Windows.Forms.TextBox txtCode;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.TextBox txtRemark;
        protected System.Windows.Forms.Label label18;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvData;
    }
}
