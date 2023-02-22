
namespace Team2_Project_POP
{
    partial class frmProductionList
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNonP = new System.Windows.Forms.Button();
            this.btnPerfomance = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnPalette = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tplUpDown = new System.Windows.Forms.TableLayoutPanel();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotPage = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRemark = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductDate = new System.Windows.Forms.Label();
            this.lblPlanDate = new System.Windows.Forms.Label();
            this.lblProcessNum = new System.Windows.Forms.Label();
            this.lblPlanQty = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblIngQty = new System.Windows.Forms.Label();
            this.lblFinishTime = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStatuse = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tplUpDown.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.btnNonP);
            this.panel2.Controls.Add(this.btnPerfomance);
            this.panel2.Controls.Add(this.btnFinish);
            this.panel2.Controls.Add(this.btnPalette);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 637);
            this.panel2.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1316, 130);
            this.panel2.TabIndex = 1;
            // 
            // btnNonP
            // 
            this.btnNonP.Location = new System.Drawing.Point(1114, 0);
            this.btnNonP.Name = "btnNonP";
            this.btnNonP.Size = new System.Drawing.Size(180, 130);
            this.btnNonP.TabIndex = 5;
            this.btnNonP.Text = "비가동  등록";
            this.btnNonP.UseVisualStyleBackColor = true;
            this.btnNonP.Click += new System.EventHandler(this.btnNonP_Click);
            // 
            // btnPerfomance
            // 
            this.btnPerfomance.Location = new System.Drawing.Point(891, 0);
            this.btnPerfomance.Name = "btnPerfomance";
            this.btnPerfomance.Size = new System.Drawing.Size(180, 130);
            this.btnPerfomance.TabIndex = 4;
            this.btnPerfomance.Text = " 실적   등록";
            this.btnPerfomance.UseVisualStyleBackColor = true;
            this.btnPerfomance.Click += new System.EventHandler(this.btnPerfomance_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(668, 0);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(180, 130);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = " 현장   마감";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnPalette
            // 
            this.btnPalette.Location = new System.Drawing.Point(456, 0);
            this.btnPalette.Name = "btnPalette";
            this.btnPalette.Size = new System.Drawing.Size(180, 130);
            this.btnPalette.TabIndex = 2;
            this.btnPalette.Text = " 팔레트   생성";
            this.btnPalette.UseVisualStyleBackColor = true;
            this.btnPalette.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Firebrick;
            this.btnStop.Location = new System.Drawing.Point(242, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(180, 130);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 130);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tplUpDown);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1166, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 637);
            this.panel3.TabIndex = 3;
            // 
            // tplUpDown
            // 
            this.tplUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.tplUpDown.ColumnCount = 1;
            this.tplUpDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplUpDown.Controls.Add(this.btnUp, 0, 1);
            this.tplUpDown.Controls.Add(this.btnDown, 0, 3);
            this.tplUpDown.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tplUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplUpDown.Location = new System.Drawing.Point(0, 0);
            this.tplUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.tplUpDown.Name = "tplUpDown";
            this.tplUpDown.RowCount = 4;
            this.tplUpDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tplUpDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tplUpDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tplUpDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tplUpDown.Size = new System.Drawing.Size(150, 637);
            this.tplUpDown.TabIndex = 1;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUp.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUp.Location = new System.Drawing.Point(10, 160);
            this.btnUp.Margin = new System.Windows.Forms.Padding(10);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(130, 150);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.btnDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDown.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDown.Location = new System.Drawing.Point(10, 476);
            this.btnDown.Margin = new System.Windows.Forms.Padding(10);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(130, 151);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblTotPage, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblPage, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(15, 335);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(120, 116);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblTotPage
            // 
            this.lblTotPage.AutoSize = true;
            this.lblTotPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotPage.Location = new System.Drawing.Point(3, 66);
            this.lblTotPage.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotPage.Name = "lblTotPage";
            this.lblTotPage.Size = new System.Drawing.Size(114, 47);
            this.lblTotPage.TabIndex = 2;
            this.lblTotPage.Text = "1";
            this.lblTotPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 54);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 8);
            this.panel4.TabIndex = 0;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPage.Location = new System.Drawing.Point(3, 3);
            this.lblPage.Margin = new System.Windows.Forms.Padding(3);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(114, 47);
            this.lblPage.TabIndex = 1;
            this.lblPage.Text = "1";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 150);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblRemark, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStatuse, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1166, 150);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblRemark
            // 
            this.lblRemark.BackColor = System.Drawing.Color.DarkBlue;
            this.lblRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemark.ForeColor = System.Drawing.Color.White;
            this.lblRemark.Location = new System.Drawing.Point(933, 4);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(2, 4, 4, 4);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(229, 142);
            this.lblRemark.TabIndex = 2;
            this.lblRemark.Text = "전달 사항";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.Controls.Add(this.lblProductDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPlanDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblProcessNum, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPlanQty, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStartTime, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblIngQty, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblFinishTime, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblProductName, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(174, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(757, 150);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblProductDate
            // 
            this.lblProductDate.BackColor = System.Drawing.Color.DarkBlue;
            this.lblProductDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductDate.ForeColor = System.Drawing.Color.White;
            this.lblProductDate.Location = new System.Drawing.Point(2, 77);
            this.lblProductDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.lblProductDate.Name = "lblProductDate";
            this.lblProductDate.Size = new System.Drawing.Size(207, 69);
            this.lblProductDate.TabIndex = 7;
            this.lblProductDate.Text = "생산 일자";
            this.lblProductDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlanDate
            // 
            this.lblPlanDate.BackColor = System.Drawing.Color.DarkBlue;
            this.lblPlanDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlanDate.ForeColor = System.Drawing.Color.White;
            this.lblPlanDate.Location = new System.Drawing.Point(2, 4);
            this.lblPlanDate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.lblPlanDate.Name = "lblPlanDate";
            this.lblPlanDate.Size = new System.Drawing.Size(207, 69);
            this.lblPlanDate.TabIndex = 3;
            this.lblPlanDate.Text = "작업지시 일자";
            this.lblPlanDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcessNum
            // 
            this.lblProcessNum.BackColor = System.Drawing.Color.DarkBlue;
            this.lblProcessNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcessNum.ForeColor = System.Drawing.Color.White;
            this.lblProcessNum.Location = new System.Drawing.Point(213, 4);
            this.lblProcessNum.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.lblProcessNum.Name = "lblProcessNum";
            this.lblProcessNum.Size = new System.Drawing.Size(207, 69);
            this.lblProcessNum.TabIndex = 4;
            this.lblProcessNum.Text = "작업지시 번호";
            this.lblProcessNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlanQty
            // 
            this.lblPlanQty.BackColor = System.Drawing.Color.DarkBlue;
            this.lblPlanQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlanQty.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPlanQty.ForeColor = System.Drawing.Color.White;
            this.lblPlanQty.Location = new System.Drawing.Point(424, 4);
            this.lblPlanQty.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.lblPlanQty.Name = "lblPlanQty";
            this.lblPlanQty.Size = new System.Drawing.Size(117, 69);
            this.lblPlanQty.TabIndex = 5;
            this.lblPlanQty.Text = "계획 수량";
            this.lblPlanQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartTime
            // 
            this.lblStartTime.BackColor = System.Drawing.Color.DarkBlue;
            this.lblStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(545, 4);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(210, 69);
            this.lblStartTime.TabIndex = 6;
            this.lblStartTime.Text = "생산 시작 시간";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIngQty
            // 
            this.lblIngQty.BackColor = System.Drawing.Color.DarkBlue;
            this.lblIngQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngQty.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIngQty.ForeColor = System.Drawing.Color.White;
            this.lblIngQty.Location = new System.Drawing.Point(424, 77);
            this.lblIngQty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.lblIngQty.Name = "lblIngQty";
            this.lblIngQty.Size = new System.Drawing.Size(117, 69);
            this.lblIngQty.TabIndex = 9;
            this.lblIngQty.Text = "실적 수량";
            this.lblIngQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinishTime
            // 
            this.lblFinishTime.BackColor = System.Drawing.Color.DarkBlue;
            this.lblFinishTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFinishTime.ForeColor = System.Drawing.Color.White;
            this.lblFinishTime.Location = new System.Drawing.Point(545, 77);
            this.lblFinishTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.lblFinishTime.Name = "lblFinishTime";
            this.lblFinishTime.Size = new System.Drawing.Size(210, 69);
            this.lblFinishTime.TabIndex = 10;
            this.lblFinishTime.Text = "생산 종료 시간";
            this.lblFinishTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.DarkBlue;
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(213, 77);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(207, 69);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Text = "품목명";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatuse
            // 
            this.lblStatuse.BackColor = System.Drawing.Color.DarkBlue;
            this.lblStatuse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatuse.ForeColor = System.Drawing.Color.White;
            this.lblStatuse.Location = new System.Drawing.Point(4, 4);
            this.lblStatuse.Margin = new System.Windows.Forms.Padding(4, 4, 2, 4);
            this.lblStatuse.Name = "lblStatuse";
            this.lblStatuse.Size = new System.Drawing.Size(168, 142);
            this.lblStatuse.TabIndex = 1;
            this.lblStatuse.Text = "상  태";
            this.lblStatuse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 150);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1166, 487);
            this.pnlList.TabIndex = 5;
            // 
            // frmProductionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1316, 767);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.Name = "frmProductionList";
            this.Text = "frmProductionList";
            this.Load += new System.EventHandler(this.frmProductionList_Load);
            this.Enter += new System.EventHandler(this.frmProductionList_Enter);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tplUpDown.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNonP;
        private System.Windows.Forms.Button btnPerfomance;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnPalette;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblProductDate;
        private System.Windows.Forms.Label lblPlanDate;
        private System.Windows.Forms.Label lblProcessNum;
        private System.Windows.Forms.Label lblPlanQty;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblIngQty;
        private System.Windows.Forms.Label lblFinishTime;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblStatuse;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.TableLayoutPanel tplUpDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblTotPage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPage;
    }
}