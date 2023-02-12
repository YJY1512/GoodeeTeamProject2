
namespace Team2_Project_POP
{
    partial class frmNonOperate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductionLine = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNonTime = new System.Windows.Forms.Label();
            this.lblNonMi = new System.Windows.Forms.Label();
            this.lblNonMa = new System.Windows.Forms.Label();
            this.pnlNon = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.lblProductionLine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 89);
            this.panel1.TabIndex = 4;
            // 
            // lblProductionLine
            // 
            this.lblProductionLine.ForeColor = System.Drawing.Color.White;
            this.lblProductionLine.Location = new System.Drawing.Point(538, 17);
            this.lblProductionLine.Name = "lblProductionLine";
            this.lblProductionLine.Size = new System.Drawing.Size(240, 60);
            this.lblProductionLine.TabIndex = 1;
            this.lblProductionLine.Text = "비가동 등록";
            this.lblProductionLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1119, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 642);
            this.panel3.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            this.button4.Location = new System.Drawing.Point(24, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(264, 200);
            this.button4.TabIndex = 3;
            this.button4.Text = "비가동 삭제";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(24, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(264, 200);
            this.button3.TabIndex = 2;
            this.button3.Text = "비가동 해제";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(24, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 200);
            this.button1.TabIndex = 0;
            this.button1.Text = "비가동 등록";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 124);
            this.panel2.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.lblNonTime, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNonMi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNonMa, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1119, 124);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblNonTime
            // 
            this.lblNonTime.BackColor = System.Drawing.Color.DarkBlue;
            this.lblNonTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNonTime.ForeColor = System.Drawing.Color.White;
            this.lblNonTime.Location = new System.Drawing.Point(787, 5);
            this.lblNonTime.Margin = new System.Windows.Forms.Padding(5);
            this.lblNonTime.Name = "lblNonTime";
            this.lblNonTime.Size = new System.Drawing.Size(327, 114);
            this.lblNonTime.TabIndex = 4;
            this.lblNonTime.Text = "발생시";
            this.lblNonTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNonMi
            // 
            this.lblNonMi.BackColor = System.Drawing.Color.DarkBlue;
            this.lblNonMi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNonMi.ForeColor = System.Drawing.Color.White;
            this.lblNonMi.Location = new System.Drawing.Point(396, 5);
            this.lblNonMi.Margin = new System.Windows.Forms.Padding(5);
            this.lblNonMi.Name = "lblNonMi";
            this.lblNonMi.Size = new System.Drawing.Size(381, 114);
            this.lblNonMi.TabIndex = 2;
            this.lblNonMi.Text = "상세분류";
            this.lblNonMi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNonMa
            // 
            this.lblNonMa.BackColor = System.Drawing.Color.DarkBlue;
            this.lblNonMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNonMa.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNonMa.Location = new System.Drawing.Point(5, 5);
            this.lblNonMa.Margin = new System.Windows.Forms.Padding(5);
            this.lblNonMa.Name = "lblNonMa";
            this.lblNonMa.Size = new System.Drawing.Size(381, 114);
            this.lblNonMa.TabIndex = 1;
            this.lblNonMa.Text = "대분류";
            this.lblNonMa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNon
            // 
            this.pnlNon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNon.Location = new System.Drawing.Point(0, 213);
            this.pnlNon.Name = "pnlNon";
            this.pnlNon.Size = new System.Drawing.Size(1119, 518);
            this.pnlNon.TabIndex = 7;
            // 
            // frmNonOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 731);
            this.Controls.Add(this.pnlNon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.Name = "frmNonOperate";
            this.Text = "frmNonOperate";
            this.Activated += new System.EventHandler(this.frmNonOperate_Activated);
            this.Load += new System.EventHandler(this.frmNonOperate_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductionLine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlNon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNonTime;
        private System.Windows.Forms.Label lblNonMi;
        private System.Windows.Forms.Label lblNonMa;
    }
}