﻿
namespace Team2_Project_POP
{
    partial class frmNonOperateEnroll
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductionLine = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnYD = new System.Windows.Forms.Button();
            this.btnYU = new System.Windows.Forms.Button();
            this.pnlNon = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvWorkLine = new System.Windows.Forms.DataGridView();
            this.dgvMaNon = new System.Windows.Forms.DataGridView();
            this.dgvMiNon = new System.Windows.Forms.DataGridView();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.btnMonD = new System.Windows.Forms.Button();
            this.btnMonU = new System.Windows.Forms.Button();
            this.btnDD = new System.Windows.Forms.Button();
            this.btnDU = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnHU = new System.Windows.Forms.Button();
            this.btnMinD = new System.Windows.Forms.Button();
            this.btnMinU = new System.Windows.Forms.Button();
            this.btnSD = new System.Windows.Forms.Button();
            this.btnSU = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlNon.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaNon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiNon)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1403, 125);
            this.panel1.TabIndex = 5;
            // 
            // lblProductionLine
            // 
            this.lblProductionLine.ForeColor = System.Drawing.Color.White;
            this.lblProductionLine.Location = new System.Drawing.Point(538, 32);
            this.lblProductionLine.Name = "lblProductionLine";
            this.lblProductionLine.Size = new System.Drawing.Size(240, 60);
            this.lblProductionLine.TabIndex = 1;
            this.lblProductionLine.Text = "비가동 등록";
            this.lblProductionLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1103, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 616);
            this.panel3.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(24, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(264, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "현재 시간";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(24, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(24, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 192);
            this.button1.TabIndex = 0;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 134);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.btnSD);
            this.panel4.Controls.Add(this.btnSU);
            this.panel4.Controls.Add(this.btnMinD);
            this.panel4.Controls.Add(this.btnMinU);
            this.panel4.Controls.Add(this.btnHD);
            this.panel4.Controls.Add(this.btnHU);
            this.panel4.Controls.Add(this.btnDD);
            this.panel4.Controls.Add(this.btnDU);
            this.panel4.Controls.Add(this.btnMonD);
            this.panel4.Controls.Add(this.btnMonU);
            this.panel4.Controls.Add(this.lblSecond);
            this.panel4.Controls.Add(this.lblMinute);
            this.panel4.Controls.Add(this.lblHour);
            this.panel4.Controls.Add(this.lblDay);
            this.panel4.Controls.Add(this.lblMonth);
            this.panel4.Controls.Add(this.lblYear);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnYD);
            this.panel4.Controls.Add(this.btnYU);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 541);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1103, 200);
            this.panel4.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(898, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 45);
            this.label7.TabIndex = 23;
            this.label7.Text = "초";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(600, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 45);
            this.label8.TabIndex = 19;
            this.label8.Text = "분";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(299, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 45);
            this.label9.TabIndex = 15;
            this.label9.Text = "시";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(898, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 45);
            this.label6.TabIndex = 11;
            this.label6.Text = "일";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(600, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "월";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(299, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "년";
            // 
            // btnYD
            // 
            this.btnYD.BackgroundImage = global::Team2_Project_POP.Properties.Resources.free_icon_down_5422469;
            this.btnYD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYD.Location = new System.Drawing.Point(261, 66);
            this.btnYD.Name = "btnYD";
            this.btnYD.Size = new System.Drawing.Size(32, 30);
            this.btnYD.TabIndex = 2;
            this.btnYD.UseVisualStyleBackColor = true;
            this.btnYD.Click += new System.EventHandler(this.btnYD_Click);
            // 
            // btnYU
            // 
            this.btnYU.BackgroundImage = global::Team2_Project_POP.Properties.Resources.free_icon_up_5422478;
            this.btnYU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYU.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnYU.Location = new System.Drawing.Point(261, 33);
            this.btnYU.Name = "btnYU";
            this.btnYU.Size = new System.Drawing.Size(32, 30);
            this.btnYU.TabIndex = 1;
            this.btnYU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYU.UseVisualStyleBackColor = true;
            this.btnYU.Click += new System.EventHandler(this.btnYU_Click);
            // 
            // pnlNon
            // 
            this.pnlNon.Controls.Add(this.tableLayoutPanel2);
            this.pnlNon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNon.Location = new System.Drawing.Point(0, 259);
            this.pnlNon.Name = "pnlNon";
            this.pnlNon.Size = new System.Drawing.Size(1103, 282);
            this.pnlNon.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1103, 134);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.dgvMiNon, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvMaNon, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvWorkLine, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1103, 282);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.DarkBlue;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(10, 10);
            label1.Margin = new System.Windows.Forms.Padding(10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(310, 114);
            label1.TabIndex = 0;
            label1.Text = "작 업 장";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.DarkBlue;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(340, 10);
            label2.Margin = new System.Windows.Forms.Padding(10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(366, 114);
            label2.TabIndex = 1;
            label2.Text = "대 분 류";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.DarkBlue;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(726, 10);
            label3.Margin = new System.Windows.Forms.Padding(10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(367, 114);
            label3.TabIndex = 2;
            label3.Text = "세 분 류";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvWorkLine
            // 
            this.dgvWorkLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkLine.Location = new System.Drawing.Point(5, 5);
            this.dgvWorkLine.Margin = new System.Windows.Forms.Padding(5);
            this.dgvWorkLine.Name = "dgvWorkLine";
            this.dgvWorkLine.RowTemplate.Height = 23;
            this.dgvWorkLine.Size = new System.Drawing.Size(320, 272);
            this.dgvWorkLine.TabIndex = 0;
            this.dgvWorkLine.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkLine_RowEnter);
            // 
            // dgvMaNon
            // 
            this.dgvMaNon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaNon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaNon.Location = new System.Drawing.Point(335, 5);
            this.dgvMaNon.Margin = new System.Windows.Forms.Padding(5);
            this.dgvMaNon.Name = "dgvMaNon";
            this.dgvMaNon.RowTemplate.Height = 23;
            this.dgvMaNon.Size = new System.Drawing.Size(376, 272);
            this.dgvMaNon.TabIndex = 1;
            this.dgvMaNon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaNon_RowEnter);
            // 
            // dgvMiNon
            // 
            this.dgvMiNon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiNon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMiNon.Location = new System.Drawing.Point(721, 5);
            this.dgvMiNon.Margin = new System.Windows.Forms.Padding(5);
            this.dgvMiNon.Name = "dgvMiNon";
            this.dgvMiNon.RowTemplate.Height = 23;
            this.dgvMiNon.Size = new System.Drawing.Size(377, 272);
            this.dgvMiNon.TabIndex = 2;
            this.dgvMiNon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMiNon_RowEnter);
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(98, 34);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(157, 62);
            this.lblYear.TabIndex = 24;
            this.lblYear.Text = "label10";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonth
            // 
            this.lblMonth.BackColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(399, 33);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(157, 62);
            this.lblMonth.TabIndex = 25;
            this.lblMonth.Text = "label10";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDay
            // 
            this.lblDay.BackColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(697, 34);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(157, 62);
            this.lblDay.TabIndex = 26;
            this.lblDay.Text = "label11";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHour
            // 
            this.lblHour.BackColor = System.Drawing.Color.White;
            this.lblHour.Location = new System.Drawing.Point(98, 112);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(157, 62);
            this.lblHour.TabIndex = 27;
            this.lblHour.Text = "label12";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinute
            // 
            this.lblMinute.BackColor = System.Drawing.Color.White;
            this.lblMinute.Location = new System.Drawing.Point(399, 112);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(157, 62);
            this.lblMinute.TabIndex = 28;
            this.lblMinute.Text = "label10";
            this.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSecond
            // 
            this.lblSecond.BackColor = System.Drawing.Color.White;
            this.lblSecond.Location = new System.Drawing.Point(697, 112);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(157, 62);
            this.lblSecond.TabIndex = 29;
            this.lblSecond.Text = "label10";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMonD
            // 
            this.btnMonD.BackgroundImage = global::Team2_Project_POP.Properties.Resources.free_icon_down_5422469;
            this.btnMonD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonD.Location = new System.Drawing.Point(562, 66);
            this.btnMonD.Name = "btnMonD";
            this.btnMonD.Size = new System.Drawing.Size(32, 30);
            this.btnMonD.TabIndex = 31;
            this.btnMonD.UseVisualStyleBackColor = true;
            this.btnMonD.Click += new System.EventHandler(this.btnMonD_Click);
            // 
            // btnMonU
            // 
            this.btnMonU.BackgroundImage = global::Team2_Project_POP.Properties.Resources.free_icon_up_5422478;
            this.btnMonU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonU.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMonU.Location = new System.Drawing.Point(562, 33);
            this.btnMonU.Name = "btnMonU";
            this.btnMonU.Size = new System.Drawing.Size(32, 30);
            this.btnMonU.TabIndex = 30;
            this.btnMonU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMonU.UseVisualStyleBackColor = true;
            this.btnMonU.Click += new System.EventHandler(this.btnMonU_Click);
            // 
            // btnDD
            // 
            this.btnDD.BackgroundImage = global::Team2_Project_POP.Properties.Resources.free_icon_down_5422469;
            this.btnDD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDD.Location = new System.Drawing.Point(860, 66);
            this.btnDD.Name = "btnDD";
            this.btnDD.Size = new System.Drawing.Size(32, 30);
            this.btnDD.TabIndex = 33;
            this.btnDD.UseVisualStyleBackColor = true;
            this.btnDD.Click += new System.EventHandler(this.btnDD_Click);
            // 
            // btnDU
            // 
            this.btnDU.BackgroundImage = global::Team2_Project_POP.Properties.Resources.free_icon_up_5422478;
            this.btnDU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDU.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDU.Location = new System.Drawing.Point(860, 33);
            this.btnDU.Name = "btnDU";
            this.btnDU.Size = new System.Drawing.Size(32, 30);
            this.btnDU.TabIndex = 32;
            this.btnDU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDU.UseVisualStyleBackColor = true;
            this.btnDU.Click += new System.EventHandler(this.btnDU_Click);
            // 
            // btnHD
            // 
            this.btnHD.BackgroundImage = global::Team2_Project_POP.Properties.Resources.free_icon_down_5422469;
            this.btnHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHD.Location = new System.Drawing.Point(261, 144);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(32, 30);
            this.btnHD.TabIndex = 35;
            this.btnHD.UseVisualStyleBackColor = true;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnHU
            // 
            this.btnHU.BackgroundImage = global::Team2_Project_POP.Properties.Resources.free_icon_up_5422478;
            this.btnHU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHU.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHU.Location = new System.Drawing.Point(261, 111);
            this.btnHU.Name = "btnHU";
            this.btnHU.Size = new System.Drawing.Size(32, 30);
            this.btnHU.TabIndex = 34;
            this.btnHU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHU.UseVisualStyleBackColor = true;
            this.btnHU.Click += new System.EventHandler(this.btnHU_Click);
            // 
            // btnMinD
            // 
            this.btnMinD.BackgroundImage = global::Team2_Project_POP.Properties.Resources.free_icon_down_5422469;
            this.btnMinD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinD.Location = new System.Drawing.Point(562, 144);
            this.btnMinD.Name = "btnMinD";
            this.btnMinD.Size = new System.Drawing.Size(32, 30);
            this.btnMinD.TabIndex = 37;
            this.btnMinD.UseVisualStyleBackColor = true;
            this.btnMinD.Click += new System.EventHandler(this.btnMinD_Click);
            // 
            // btnMinU
            // 
            this.btnMinU.BackgroundImage = global::Team2_Project_POP.Properties.Resources.free_icon_up_5422478;
            this.btnMinU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinU.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinU.Location = new System.Drawing.Point(562, 111);
            this.btnMinU.Name = "btnMinU";
            this.btnMinU.Size = new System.Drawing.Size(32, 30);
            this.btnMinU.TabIndex = 36;
            this.btnMinU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinU.UseVisualStyleBackColor = true;
            this.btnMinU.Click += new System.EventHandler(this.btnMinU_Click);
            // 
            // btnSD
            // 
            this.btnSD.BackgroundImage = global::Team2_Project_POP.Properties.Resources.free_icon_down_5422469;
            this.btnSD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSD.Location = new System.Drawing.Point(860, 144);
            this.btnSD.Name = "btnSD";
            this.btnSD.Size = new System.Drawing.Size(32, 30);
            this.btnSD.TabIndex = 39;
            this.btnSD.UseVisualStyleBackColor = true;
            this.btnSD.Click += new System.EventHandler(this.btnSD_Click);
            // 
            // btnSU
            // 
            this.btnSU.BackgroundImage = global::Team2_Project_POP.Properties.Resources.free_icon_up_5422478;
            this.btnSU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSU.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSU.Location = new System.Drawing.Point(860, 111);
            this.btnSU.Name = "btnSU";
            this.btnSU.Size = new System.Drawing.Size(32, 30);
            this.btnSU.TabIndex = 38;
            this.btnSU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSU.UseVisualStyleBackColor = true;
            this.btnSU.Click += new System.EventHandler(this.btnSU_Click);
            // 
            // frmNonOperateEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 741);
            this.Controls.Add(this.pnlNon);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.Name = "frmNonOperateEnroll";
            this.Text = "frmNonOperateEnroll";
            this.Load += new System.EventHandler(this.frmNonOperateEnroll_Load);
            this.Enter += new System.EventHandler(this.frmNonOperateEnroll_Enter);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlNon.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaNon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiNon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductionLine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnYD;
        private System.Windows.Forms.Button btnYU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlNon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvMiNon;
        private System.Windows.Forms.DataGridView dgvMaNon;
        private System.Windows.Forms.DataGridView dgvWorkLine;
        private System.Windows.Forms.Button btnSD;
        private System.Windows.Forms.Button btnSU;
        private System.Windows.Forms.Button btnMinD;
        private System.Windows.Forms.Button btnMinU;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnHU;
        private System.Windows.Forms.Button btnDD;
        private System.Windows.Forms.Button btnDU;
        private System.Windows.Forms.Button btnMonD;
        private System.Windows.Forms.Button btnMonU;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
    }
}