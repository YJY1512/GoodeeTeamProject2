﻿
namespace Team2_Project.BaseForms
{
    partial class frmCodeControlBase
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cboUseYN = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudSort = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInfoNameMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInfoNameMa = new System.Windows.Forms.Label();
            this.txtInfoNameMi = new System.Windows.Forms.TextBox();
            this.txtInfoCodeMi = new System.Windows.Forms.TextBox();
            this.txtInfoCodeMa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblInfoCodeMa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListTitleR = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboSearchUse = new System.Windows.Forms.ComboBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.lblSearchCode = new System.Windows.Forms.Label();
            this.pnlSub.SuspendLayout();
            this.pnlListR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.label16);
            this.pnlSub.Controls.Add(this.cboSearchUse);
            this.pnlSub.Controls.Add(this.txtSearchName);
            this.pnlSub.Controls.Add(this.lblSearchName);
            this.pnlSub.Controls.Add(this.txtSearchCode);
            this.pnlSub.Controls.Add(this.lblSearchCode);
            this.pnlSub.Size = new System.Drawing.Size(1318, 65);
            // 
            // pnlListL
            // 
            this.pnlListL.Size = new System.Drawing.Size(438, 596);
            // 
            // lblTitleL
            // 
            this.lblTitleL.Text = "대분류";
            // 
            // pnlListR
            // 
            this.pnlListR.Controls.Add(this.splitContainer2);
            this.pnlListR.Size = new System.Drawing.Size(876, 596);
            // 
            // lblTitleR
            // 
            this.lblTitleR.Size = new System.Drawing.Size(64, 17);
            this.lblTitleR.Text = "상세분류";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.splitContainer2.Panel2.Controls.Add(this.cboUseYN);
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.nudSort);
            this.splitContainer2.Panel2.Controls.Add(this.label13);
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Panel2.Controls.Add(this.txtRemark);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label15);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.txtInfoNameMa);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.lblInfoNameMa);
            this.splitContainer2.Panel2.Controls.Add(this.txtInfoNameMi);
            this.splitContainer2.Panel2.Controls.Add(this.txtInfoCodeMi);
            this.splitContainer2.Panel2.Controls.Add(this.txtInfoCodeMa);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.lblInfoCodeMa);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(876, 596);
            this.splitContainer2.SplitterDistance = 363;
            this.splitContainer2.TabIndex = 0;
            // 
            // cboUseYN
            // 
            this.cboUseYN.FormattingEnabled = true;
            this.cboUseYN.Location = new System.Drawing.Point(659, 183);
            this.cboUseYN.Name = "cboUseYN";
            this.cboUseYN.Size = new System.Drawing.Size(121, 24);
            this.cboUseYN.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(507, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(530, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "사용유무";
            // 
            // nudSort
            // 
            this.nudSort.Location = new System.Drawing.Point(659, 63);
            this.nudSort.Name = "nudSort";
            this.nudSort.Size = new System.Drawing.Size(99, 24);
            this.nudSort.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(507, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(507, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "*";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(659, 103);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(200, 64);
            this.txtRemark.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(530, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "비고";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(530, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "정렬 순서";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(30, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(30, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 17);
            this.label15.TabIndex = 23;
            this.label15.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(30, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(30, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "*";
            // 
            // txtInfoNameMa
            // 
            this.txtInfoNameMa.Location = new System.Drawing.Point(217, 103);
            this.txtInfoNameMa.Name = "txtInfoNameMa";
            this.txtInfoNameMa.Size = new System.Drawing.Size(190, 24);
            this.txtInfoNameMa.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(53, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "상세분류명";
            // 
            // lblInfoNameMa
            // 
            this.lblInfoNameMa.AutoSize = true;
            this.lblInfoNameMa.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoNameMa.Location = new System.Drawing.Point(53, 147);
            this.lblInfoNameMa.Name = "lblInfoNameMa";
            this.lblInfoNameMa.Size = new System.Drawing.Size(92, 17);
            this.lblInfoNameMa.TabIndex = 20;
            this.lblInfoNameMa.Text = "상세분류코드";
            // 
            // txtInfoNameMi
            // 
            this.txtInfoNameMi.Location = new System.Drawing.Point(217, 183);
            this.txtInfoNameMi.Name = "txtInfoNameMi";
            this.txtInfoNameMi.Size = new System.Drawing.Size(190, 24);
            this.txtInfoNameMi.TabIndex = 19;
            // 
            // txtInfoCodeMi
            // 
            this.txtInfoCodeMi.Location = new System.Drawing.Point(217, 143);
            this.txtInfoCodeMi.Name = "txtInfoCodeMi";
            this.txtInfoCodeMi.Size = new System.Drawing.Size(190, 24);
            this.txtInfoCodeMi.TabIndex = 19;
            // 
            // txtInfoCodeMa
            // 
            this.txtInfoCodeMa.Location = new System.Drawing.Point(217, 63);
            this.txtInfoCodeMa.Name = "txtInfoCodeMa";
            this.txtInfoCodeMa.Size = new System.Drawing.Size(190, 24);
            this.txtInfoCodeMa.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(53, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "대분류명";
            // 
            // lblInfoCodeMa
            // 
            this.lblInfoCodeMa.AutoSize = true;
            this.lblInfoCodeMa.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoCodeMa.Location = new System.Drawing.Point(53, 67);
            this.lblInfoCodeMa.Name = "lblInfoCodeMa";
            this.lblInfoCodeMa.Size = new System.Drawing.Size(78, 17);
            this.lblInfoCodeMa.TabIndex = 18;
            this.lblInfoCodeMa.Text = "대분류코드";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblListTitleR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 43);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "▷";
            // 
            // lblListTitleR
            // 
            this.lblListTitleR.AutoSize = true;
            this.lblListTitleR.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblListTitleR.ForeColor = System.Drawing.Color.White;
            this.lblListTitleR.Location = new System.Drawing.Point(40, 10);
            this.lblListTitleR.Name = "lblListTitleR";
            this.lblListTitleR.Size = new System.Drawing.Size(64, 17);
            this.lblListTitleR.TabIndex = 0;
            this.lblListTitleR.Text = "입력정보";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(875, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "사용유무";
            // 
            // cboSearchUse
            // 
            this.cboSearchUse.FormattingEnabled = true;
            this.cboSearchUse.Location = new System.Drawing.Point(973, 18);
            this.cboSearchUse.Name = "cboSearchUse";
            this.cboSearchUse.Size = new System.Drawing.Size(121, 24);
            this.cboSearchUse.TabIndex = 12;
            this.cboSearchUse.Text = "전체";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(590, 18);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(200, 24);
            this.txtSearchName.TabIndex = 11;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchName.Location = new System.Drawing.Point(432, 22);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(64, 17);
            this.lblSearchName.TabIndex = 10;
            this.lblSearchName.Text = "대분류명";
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Location = new System.Drawing.Point(187, 18);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(180, 24);
            this.txtSearchCode.TabIndex = 9;
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.AutoSize = true;
            this.lblSearchCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchCode.Location = new System.Drawing.Point(29, 22);
            this.lblSearchCode.Name = "lblSearchCode";
            this.lblSearchCode.Size = new System.Drawing.Size(78, 17);
            this.lblSearchCode.TabIndex = 8;
            this.lblSearchCode.Text = "대분류코드";
            // 
            // frmCodeControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1318, 704);
            this.Name = "frmCodeControlBase";
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlListR.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label lblListTitleR;
        protected System.Windows.Forms.Label label16;
        protected System.Windows.Forms.ComboBox cboSearchUse;
        protected System.Windows.Forms.TextBox txtSearchName;
        protected System.Windows.Forms.Label lblSearchName;
        protected System.Windows.Forms.TextBox txtSearchCode;
        protected System.Windows.Forms.Label lblSearchCode;
        private System.Windows.Forms.ComboBox cboUseYN;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.TextBox txtRemark;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox txtInfoNameMa;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label lblInfoNameMa;
        protected System.Windows.Forms.TextBox txtInfoNameMi;
        protected System.Windows.Forms.TextBox txtInfoCodeMi;
        protected System.Windows.Forms.TextBox txtInfoCodeMa;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label lblInfoCodeMa;
        protected System.Windows.Forms.NumericUpDown nudSort;
    }
}