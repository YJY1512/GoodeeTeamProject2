
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
            this.cboNoptype = new System.Windows.Forms.ComboBox();
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
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(662, 21);
            // 
            // cboSearchUse
            // 
            this.cboSearchUse.Location = new System.Drawing.Point(741, 17);
            this.cboSearchUse.TabIndex = 2;
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.Location = new System.Drawing.Point(33, 21);
            this.lblSearchCode.Size = new System.Drawing.Size(124, 17);
            this.lblSearchCode.Text = "비가동 대분류코드";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(632, 119);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(655, 119);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(655, 66);
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.Text = "비가동유형";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 172);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 119);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(43, 172);
            // 
            // lblInfoNameMa
            // 
            this.lblInfoNameMa.Location = new System.Drawing.Point(43, 119);
            // 
            // txtInfoNameMi
            // 
            this.txtInfoNameMi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfoNameMi.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtInfoNameMi.Location = new System.Drawing.Point(182, 168);
            this.txtInfoNameMi.MaxLength = 20;
            this.txtInfoNameMi.TabIndex = 5;
            // 
            // txtInfoCodeMi
            // 
            this.txtInfoCodeMi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfoCodeMi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtInfoCodeMi.Location = new System.Drawing.Point(182, 115);
            this.txtInfoCodeMi.MaxLength = 20;
            this.txtInfoCodeMi.TabIndex = 4;
            // 
            // nudSort
            // 
            this.nudSort.Location = new System.Drawing.Point(1042, 168);
            this.nudSort.Size = new System.Drawing.Size(40, 25);
            this.nudSort.Visible = false;
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvMiData);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cboNoptype);
            this.splitContainer2.Size = new System.Drawing.Size(1177, 692);
            this.splitContainer2.SplitterDistance = 463;
            // 
            // ucMaCode
            // 
            this.ucMaCode.Location = new System.Drawing.Point(182, 59);
            this.ucMaCode.TabIndex = 3;
            this.ucMaCode.BtnClick += new System.EventHandler(this.ucMaCode_BtnClick);
            // 
            // cboUseYN
            // 
            this.cboUseYN.ItemHeight = 17;
            this.cboUseYN.Location = new System.Drawing.Point(781, 115);
            // 
            // ucMaCodeSC
            // 
            this.ucMaCodeSC.Location = new System.Drawing.Point(178, 15);
            this.ucMaCodeSC.TabIndex = 1;
            this.ucMaCodeSC.BtnClick += new System.EventHandler(this.ucCodeSearch_BtnClick);
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(632, 66);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(632, 172);
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Location = new System.Drawing.Point(781, 168);
            this.txtRemark.Size = new System.Drawing.Size(255, 25);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(655, 172);
            // 
            // pnlSub
            // 
            this.pnlSub.Size = new System.Drawing.Size(1769, 60);
            // 
            // pnlListL
            // 
            this.pnlListL.Controls.Add(this.dgvMaData);
            this.pnlListL.Size = new System.Drawing.Size(588, 692);
            // 
            // pnlListR
            // 
            this.pnlListR.Size = new System.Drawing.Size(1177, 692);
            // 
            // dgvMaData
            // 
            this.dgvMaData.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaData.Location = new System.Drawing.Point(0, 0);
            this.dgvMaData.Name = "dgvMaData";
            this.dgvMaData.RowTemplate.Height = 23;
            this.dgvMaData.Size = new System.Drawing.Size(588, 692);
            this.dgvMaData.TabIndex = 0;
            this.dgvMaData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaData_CellClick);
            // 
            // dgvMiData
            // 
            this.dgvMiData.BackgroundColor = System.Drawing.Color.White;
            this.dgvMiData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMiData.Location = new System.Drawing.Point(0, 0);
            this.dgvMiData.Name = "dgvMiData";
            this.dgvMiData.RowTemplate.Height = 23;
            this.dgvMiData.Size = new System.Drawing.Size(1177, 463);
            this.dgvMiData.TabIndex = 1;
            this.dgvMiData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMiData_CellClick);
            // 
            // cboNoptype
            // 
            this.cboNoptype.FormattingEnabled = true;
            this.cboNoptype.ItemHeight = 17;
            this.cboNoptype.Location = new System.Drawing.Point(781, 62);
            this.cboNoptype.Name = "cboNoptype";
            this.cboNoptype.Size = new System.Drawing.Size(130, 25);
            this.cboNoptype.TabIndex = 35;
            // 
            // frmNopMiCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1769, 795);
            this.Name = "frmNopMiCode";
            this.Text = "비가동 상세분류코드";
            this.Load += new System.EventHandler(this.frmNopMiCode_Load);
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
        private System.Windows.Forms.ComboBox cboNoptype;
    }
}
