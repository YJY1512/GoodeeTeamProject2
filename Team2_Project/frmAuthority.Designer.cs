
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
            this.dgvAuthority = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ucgrpSearch = new Team2_Project.Controls.ucSearch();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthority)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.ucgrpSearch);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Size = new System.Drawing.Size(1252, 65);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvAuthority);
            this.pnlList.Size = new System.Drawing.Size(1252, 533);
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
            this.pnlTitle.Size = new System.Drawing.Size(1252, 43);
            // 
            // dgvAuthority
            // 
            this.dgvAuthority.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuthority.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuthority.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthority.Location = new System.Drawing.Point(0, 0);
            this.dgvAuthority.Name = "dgvAuthority";
            this.dgvAuthority.RowTemplate.Height = 23;
            this.dgvAuthority.Size = new System.Drawing.Size(1205, 533);
            this.dgvAuthority.TabIndex = 0;
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
            // frmAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1252, 641);
            this.Name = "frmAuthority";
            this.Text = "사용자권한설정";
            this.Load += new System.EventHandler(this.frmAuthority_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthority)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuthority;
        private System.Windows.Forms.Label label1;
        private Controls.ucSearch ucgrpSearch;
    }
}
