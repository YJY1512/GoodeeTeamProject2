
namespace Team2_Project
{
    partial class frmPlanAddPop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlanTitle = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpPlanMonth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvPlanHeader = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "생산계획월";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "생산계획제목";
            // 
            // txtPlanTitle
            // 
            this.txtPlanTitle.Location = new System.Drawing.Point(158, 66);
            this.txtPlanTitle.Name = "txtPlanTitle";
            this.txtPlanTitle.Size = new System.Drawing.Size(273, 25);
            this.txtPlanTitle.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(262, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpPlanMonth
            // 
            this.dtpPlanMonth.CustomFormat = "yyyy-MM";
            this.dtpPlanMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPlanMonth.Location = new System.Drawing.Point(158, 24);
            this.dtpPlanMonth.Name = "dtpPlanMonth";
            this.dtpPlanMonth.Size = new System.Drawing.Size(132, 25);
            this.dtpPlanMonth.TabIndex = 8;
            this.dtpPlanMonth.ValueChanged += new System.EventHandler(this.dtpPlanMonth_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(21, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(21, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "*";
            // 
            // dgvPlanHeader
            // 
            this.dgvPlanHeader.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlanHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanHeader.Location = new System.Drawing.Point(24, 149);
            this.dgvPlanHeader.Name = "dgvPlanHeader";
            this.dgvPlanHeader.RowTemplate.Height = 23;
            this.dgvPlanHeader.Size = new System.Drawing.Size(407, 145);
            this.dgvPlanHeader.TabIndex = 35;
            this.dgvPlanHeader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanHeader_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdd.Location = new System.Drawing.Point(23, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 29);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MistyRose;
            this.btnEdit.Location = new System.Drawing.Point(161, 105);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 29);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "수정";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.MistyRose;
            this.btnDel.Location = new System.Drawing.Point(299, 105);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(132, 29);
            this.btnDel.TabIndex = 38;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // frmPlanAddPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 366);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPlanHeader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpPlanMonth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPlanTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlanAddPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "생산계획생성";
            this.Load += new System.EventHandler(this.frmPlanAddPop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlanTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpPlanMonth;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvPlanHeader;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
    }
}