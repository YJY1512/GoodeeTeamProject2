
namespace Team2_Project
{
    partial class frmAuthority
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
            this.label1 = new System.Windows.Forms.Label();
            this.ucgrpSearch = new Team2_Project.Controls.ucSearch();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvAuthority = new System.Windows.Forms.DataGridView();
            this.cboAuthNM = new System.Windows.Forms.ComboBox();
            this.txtAuthType = new System.Windows.Forms.TextBox();
            this.lblAuth = new System.Windows.Forms.Label();
            this.txtMenuNM = new System.Windows.Forms.TextBox();
            this.txtScreenCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthority)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.ucgrpSearch);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Size = new System.Drawing.Size(1420, 65);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.splitContainer1);
            this.pnlList.Size = new System.Drawing.Size(1420, 533);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(36, 10);
            this.lblTitle.Size = new System.Drawing.Size(64, 18);
            this.lblTitle.Text = "권한설정";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Size = new System.Drawing.Size(1420, 43);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자 그룹";
            // 
            // ucgrpSearch
            // 
            this.ucgrpSearch._Code = "";
            this.ucgrpSearch._Name = "";
            this.ucgrpSearch.BackColor = System.Drawing.Color.Transparent;
            this.ucgrpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucgrpSearch.Location = new System.Drawing.Point(125, 18);
            this.ucgrpSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ucgrpSearch.Name = "ucgrpSearch";
            this.ucgrpSearch.Size = new System.Drawing.Size(340, 28);
            this.ucgrpSearch.TabIndex = 1;
            this.ucgrpSearch.BtnClick += new System.EventHandler(this.ucSearch1_BtnClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvAuthority);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cboAuthNM);
            this.splitContainer1.Panel2.Controls.Add(this.txtAuthType);
            this.splitContainer1.Panel2.Controls.Add(this.lblAuth);
            this.splitContainer1.Panel2.Controls.Add(this.txtMenuNM);
            this.splitContainer1.Panel2.Controls.Add(this.txtScreenCode);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(1420, 533);
            this.splitContainer1.SplitterDistance = 1032;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvAuthority
            // 
            this.dgvAuthority.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuthority.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAuthority.Location = new System.Drawing.Point(0, 0);
            this.dgvAuthority.Name = "dgvAuthority";
            this.dgvAuthority.RowTemplate.Height = 23;
            this.dgvAuthority.Size = new System.Drawing.Size(1032, 533);
            this.dgvAuthority.TabIndex = 1;
            this.dgvAuthority.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthority_CellClick);
            // 
            // cboAuthNM
            // 
            this.cboAuthNM.FormattingEnabled = true;
            this.cboAuthNM.Location = new System.Drawing.Point(147, 232);
            this.cboAuthNM.Name = "cboAuthNM";
            this.cboAuthNM.Size = new System.Drawing.Size(170, 25);
            this.cboAuthNM.TabIndex = 7;
            // 
            // txtAuthType
            // 
            this.txtAuthType.Location = new System.Drawing.Point(147, 168);
            this.txtAuthType.Name = "txtAuthType";
            this.txtAuthType.Size = new System.Drawing.Size(170, 25);
            this.txtAuthType.TabIndex = 6;
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAuth.Location = new System.Drawing.Point(45, 238);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(69, 19);
            this.lblAuth.TabIndex = 5;
            this.lblAuth.Text = "권한문자";
            // 
            // txtMenuNM
            // 
            this.txtMenuNM.Location = new System.Drawing.Point(147, 104);
            this.txtMenuNM.Name = "txtMenuNM";
            this.txtMenuNM.Size = new System.Drawing.Size(170, 25);
            this.txtMenuNM.TabIndex = 4;
            // 
            // txtScreenCode
            // 
            this.txtScreenCode.Location = new System.Drawing.Point(147, 40);
            this.txtScreenCode.Name = "txtScreenCode";
            this.txtScreenCode.Size = new System.Drawing.Size(170, 25);
            this.txtScreenCode.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(45, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "권한타입";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(56, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "메뉴 명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(41, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "메뉴 코드";
            // 
            // frmAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1420, 641);
            this.Name = "frmAuthority";
            this.Text = "사용자권한설정";
            this.Load += new System.EventHandler(this.frmAuthority_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthority)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Controls.ucSearch ucgrpSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvAuthority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMenuNM;
        private System.Windows.Forms.TextBox txtScreenCode;
        private System.Windows.Forms.ComboBox cboAuthNM;
        private System.Windows.Forms.TextBox txtAuthType;
        private System.Windows.Forms.Label lblAuth;
    }
}
