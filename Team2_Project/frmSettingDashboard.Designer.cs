
namespace Team2_Project
{
    partial class frmSettingDashboard
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
            this.lblContent = new System.Windows.Forms.Label();
            this.lstContent = new System.Windows.Forms.ListBox();
            this.lbltxt = new System.Windows.Forms.Label();
            this.panTop = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panBottom = new System.Windows.Forms.Panel();
            this.lblBottom = new System.Windows.Forms.Label();
            this.panTop.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(451, 88);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(63, 17);
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "Content";
            // 
            // lstContent
            // 
            this.lstContent.FormattingEnabled = true;
            this.lstContent.ItemHeight = 17;
            this.lstContent.Location = new System.Drawing.Point(451, 112);
            this.lstContent.Name = "lstContent";
            this.lstContent.Size = new System.Drawing.Size(201, 225);
            this.lstContent.TabIndex = 1;
            this.lstContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstContent_MouseDown);
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Location = new System.Drawing.Point(148, 359);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(489, 17);
            this.lbltxt.TabIndex = 2;
            this.lbltxt.Text = "우측 리스트의 항목을 드래그하여 좌측의 짙은 하늘색부분에 올려놓으십시오.";
            // 
            // panTop
            // 
            this.panTop.AllowDrop = true;
            this.panTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panTop.Controls.Add(this.lblTop);
            this.panTop.Location = new System.Drawing.Point(138, 113);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(296, 106);
            this.panTop.TabIndex = 3;
            this.panTop.DragDrop += new System.Windows.Forms.DragEventHandler(this.panTop_DragDrop);
            this.panTop.DragOver += new System.Windows.Forms.DragEventHandler(this.panTop_DragOver);
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTop.Location = new System.Drawing.Point(25, 40);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(248, 33);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "대시보드 상단";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panBottom
            // 
            this.panBottom.AllowDrop = true;
            this.panBottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panBottom.Controls.Add(this.lblBottom);
            this.panBottom.Location = new System.Drawing.Point(138, 229);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(296, 106);
            this.panBottom.TabIndex = 4;
            this.panBottom.DragDrop += new System.Windows.Forms.DragEventHandler(this.panBottom_DragDrop);
            this.panBottom.DragOver += new System.Windows.Forms.DragEventHandler(this.panBottom_DragOver);
            // 
            // lblBottom
            // 
            this.lblBottom.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBottom.Location = new System.Drawing.Point(26, 37);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(246, 33);
            this.lblBottom.TabIndex = 1;
            this.lblBottom.Text = "대시보드 하단";
            this.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSettingDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 470);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.lstContent);
            this.Controls.Add(this.lblContent);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSettingDashboard";
            this.Text = "SettingDashboard";
            this.Load += new System.EventHandler(this.frmSettingDashboard_Load);
            this.panTop.ResumeLayout(false);
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.ListBox lstContent;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblBottom;
    }
}