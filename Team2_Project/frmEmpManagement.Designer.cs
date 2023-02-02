
namespace Team2_Project
{
    partial class frmEmpManagement
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
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ucSearchGroup = new Team2_Project.Controls.ucSearch();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.cboSearchDel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTitleD.SuspendLayout();
            this.pnlTitleU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.cboSearchDel);
            this.pnlSub.Controls.Add(this.txtSearchName);
            this.pnlSub.Controls.Add(this.txtSearchID);
            this.pnlSub.Controls.Add(this.label11);
            this.pnlSub.Controls.Add(this.label10);
            this.pnlSub.Controls.Add(this.label9);
            this.pnlSub.Size = new System.Drawing.Size(1834, 60);
            // 
            // lblTitleU
            // 
            this.lblTitleU.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleU.Location = new System.Drawing.Point(39, 8);
            this.lblTitleU.Size = new System.Drawing.Size(64, 17);
            this.lblTitleU.Text = "조회내역";
            // 
            // lblTitleD
            // 
            this.lblTitleD.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleD.Location = new System.Drawing.Point(39, 8);
            this.lblTitleD.Size = new System.Drawing.Size(64, 17);
            this.lblTitleD.Text = "입력정보";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvEmp);
            this.pnlList.Size = new System.Drawing.Size(1834, 592);
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.label17);
            this.pnlArea.Controls.Add(this.label16);
            this.pnlArea.Controls.Add(this.label12);
            this.pnlArea.Controls.Add(this.label7);
            this.pnlArea.Controls.Add(this.cboDel);
            this.pnlArea.Controls.Add(this.label8);
            this.pnlArea.Controls.Add(this.ucSearchGroup);
            this.pnlArea.Controls.Add(this.txtName);
            this.pnlArea.Controls.Add(this.txtID);
            this.pnlArea.Controls.Add(this.label5);
            this.pnlArea.Controls.Add(this.label4);
            this.pnlArea.Controls.Add(this.label1);
            this.pnlArea.Size = new System.Drawing.Size(1834, 118);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Size = new System.Drawing.Size(1834, 800);
            this.splitContainer1.SplitterDistance = 635;
            // 
            // pnlTitleD
            // 
            this.pnlTitleD.Size = new System.Drawing.Size(1834, 43);
            // 
            // pnlTitleU
            // 
            this.pnlTitleU.Size = new System.Drawing.Size(1834, 43);
            // 
            // dgvEmp
            // 
            this.dgvEmp.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmp.Location = new System.Drawing.Point(0, 0);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowTemplate.Height = 23;
            this.dgvEmp.Size = new System.Drawing.Size(1834, 592);
            this.dgvEmp.TabIndex = 0;
            this.dgvEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자 ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "사용자 이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "사용자 그룹";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(137, 18);
            this.txtID.MaxLength = 20;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(170, 25);
            this.txtID.TabIndex = 0;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress_1);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 78);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 25);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress_1);
            // 
            // ucSearchGroup
            // 
            this.ucSearchGroup._Code = "";
            this.ucSearchGroup._Name = "";
            this.ucSearchGroup.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearchGroup.Location = new System.Drawing.Point(488, 18);
            this.ucSearchGroup.Margin = new System.Windows.Forms.Padding(4);
            this.ucSearchGroup.Name = "ucSearchGroup";
            this.ucSearchGroup.Size = new System.Drawing.Size(340, 26);
            this.ucSearchGroup.TabIndex = 2;
            this.ucSearchGroup.BtnClick += new System.EventHandler(this.ucSearchGroup_BtnClick);
            this.ucSearchGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "재직여부";
            // 
            // cboDel
            // 
            this.cboDel.FormattingEnabled = true;
            this.cboDel.Location = new System.Drawing.Point(488, 78);
            this.cboDel.Name = "cboDel";
            this.cboDel.Size = new System.Drawing.Size(130, 25);
            this.cboDel.TabIndex = 3;
            this.cboDel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDel_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(30, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "사용자 ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(304, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "사용자 이름";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(591, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "재직여부";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(114, 16);
            this.txtSearchID.MaxLength = 20;
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(130, 25);
            this.txtSearchID.TabIndex = 0;
            this.txtSearchID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress_1);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(401, 16);
            this.txtSearchName.MaxLength = 100;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(130, 25);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress_1);
            // 
            // cboSearchDel
            // 
            this.cboSearchDel.FormattingEnabled = true;
            this.cboSearchDel.Location = new System.Drawing.Point(670, 16);
            this.cboSearchDel.Name = "cboSearchDel";
            this.cboSearchDel.Size = new System.Drawing.Size(100, 25);
            this.cboSearchDel.TabIndex = 2;
            this.cboSearchDel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSearchDel_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(20, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(20, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(367, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 17);
            this.label16.TabIndex = 23;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(367, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "*";
            // 
            // frmEmpManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1834, 860);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEmpManagement";
            this.Text = "인사관리";
            this.Load += new System.EventHandler(this.frmEmpManagement_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlTitleD.ResumeLayout(false);
            this.pnlTitleD.PerformLayout();
            this.pnlTitleU.ResumeLayout(false);
            this.pnlTitleU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.ComboBox cboSearchDel;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboDel;
        private System.Windows.Forms.Label label8;
        private Controls.ucSearch ucSearchGroup;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label label16;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.Label label7;
    }
}
