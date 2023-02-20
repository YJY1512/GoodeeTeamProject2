
namespace Team2_Project_POP
{
    partial class frmDefListPopUp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMaDef = new System.Windows.Forms.DataGridView();
            this.dgvMiDef = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiDef)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaDef
            // 
            this.dgvMaDef.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvMaDef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaDef.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaDef.Location = new System.Drawing.Point(31, 71);
            this.dgvMaDef.MultiSelect = false;
            this.dgvMaDef.Name = "dgvMaDef";
            this.dgvMaDef.ReadOnly = true;
            this.dgvMaDef.RowHeadersWidth = 10;
            this.dgvMaDef.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMaDef.RowTemplate.Height = 23;
            this.dgvMaDef.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMaDef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaDef.Size = new System.Drawing.Size(350, 720);
            this.dgvMaDef.TabIndex = 0;
            this.dgvMaDef.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaDef_RowEnter);
            // 
            // dgvMiDef
            // 
            this.dgvMiDef.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvMiDef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMiDef.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMiDef.Location = new System.Drawing.Point(419, 71);
            this.dgvMiDef.MultiSelect = false;
            this.dgvMiDef.Name = "dgvMiDef";
            this.dgvMiDef.ReadOnly = true;
            this.dgvMiDef.RowHeadersWidth = 10;
            this.dgvMiDef.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMiDef.RowTemplate.Height = 23;
            this.dgvMiDef.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMiDef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMiDef.Size = new System.Drawing.Size(350, 720);
            this.dgvMiDef.TabIndex = 1;
            this.dgvMiDef.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMiDef_RowEnter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(806, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "선택";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(806, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 84);
            this.button2.TabIndex = 3;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "대 분 류";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(419, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 56);
            this.label2.TabIndex = 5;
            this.label2.Text = "세 분 류";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDefListPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1065, 812);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvMiDef);
            this.Controls.Add(this.dgvMaDef);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmDefListPopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDefList";
            this.Load += new System.EventHandler(this.frmDefListPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiDef)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaDef;
        private System.Windows.Forms.DataGridView dgvMiDef;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}