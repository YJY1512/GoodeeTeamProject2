
namespace Team2_Project
{
    partial class frmTimeProductionHistory
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboWoStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.ucWcCode = new Team2_Project.Controls.ucSearch();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ucProcessCode = new Team2_Project.Controls.ucSearch();
            this.chkDefQty = new System.Windows.Forms.CheckBox();
            this.cboTest = new System.Windows.Forms.ComboBox();
            this.lbltest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.cboTest);
            this.pnlSub.Controls.Add(this.button1);
            this.pnlSub.Controls.Add(this.lbltest);
            this.pnlSub.Controls.Add(this.chkDefQty);
            this.pnlSub.Controls.Add(this.ucProcessCode);
            this.pnlSub.Controls.Add(this.label7);
            this.pnlSub.Controls.Add(this.dtpTo);
            this.pnlSub.Controls.Add(this.ucWcCode);
            this.pnlSub.Controls.Add(this.dtpFrom);
            this.pnlSub.Controls.Add(this.label6);
            this.pnlSub.Controls.Add(this.label4);
            this.pnlSub.Controls.Add(this.label9);
            this.pnlSub.Controls.Add(this.cboWoStatus);
            this.pnlSub.Controls.Add(this.label5);
            this.pnlSub.Size = new System.Drawing.Size(1834, 120);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.splitContainer1);
            this.pnlList.Location = new System.Drawing.Point(0, 163);
            this.pnlList.Size = new System.Drawing.Size(1834, 748);
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(86, 18);
            this.lblTitle.Text = "작업지시목록";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.label15);
            this.pnlTitle.Controls.Add(this.label16);
            this.pnlTitle.Controls.Add(this.label10);
            this.pnlTitle.Controls.Add(this.label18);
            this.pnlTitle.Controls.Add(this.label14);
            this.pnlTitle.Controls.Add(this.label17);
            this.pnlTitle.Controls.Add(this.label8);
            this.pnlTitle.Controls.Add(this.label13);
            this.pnlTitle.Controls.Add(this.label11);
            this.pnlTitle.Controls.Add(this.label12);
            this.pnlTitle.Location = new System.Drawing.Point(0, 120);
            this.pnlTitle.Size = new System.Drawing.Size(1834, 43);
            this.pnlTitle.Controls.SetChildIndex(this.label12, 0);
            this.pnlTitle.Controls.SetChildIndex(this.label11, 0);
            this.pnlTitle.Controls.SetChildIndex(this.label13, 0);
            this.pnlTitle.Controls.SetChildIndex(this.label8, 0);
            this.pnlTitle.Controls.SetChildIndex(this.label17, 0);
            this.pnlTitle.Controls.SetChildIndex(this.label14, 0);
            this.pnlTitle.Controls.SetChildIndex(this.label18, 0);
            this.pnlTitle.Controls.SetChildIndex(this.label10, 0);
            this.pnlTitle.Controls.SetChildIndex(this.lblTitle, 0);
            this.pnlTitle.Controls.SetChildIndex(this.label16, 0);
            this.pnlTitle.Controls.SetChildIndex(this.label15, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1834, 748);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(1834, 287);
            this.dgvData.TabIndex = 1;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvData_CellFormatting);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chtData);
            this.splitContainer2.Size = new System.Drawing.Size(1834, 457);
            this.splitContainer2.SplitterDistance = 45;
            this.splitContainer2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1834, 41);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "▷";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "시간대별 실적";
            // 
            // chtData
            // 
            chartArea4.Name = "ChartArea1";
            this.chtData.ChartAreas.Add(chartArea4);
            this.chtData.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chtData.Legends.Add(legend4);
            this.chtData.Location = new System.Drawing.Point(0, 0);
            this.chtData.Name = "chtData";
            this.chtData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            this.chtData.Size = new System.Drawing.Size(1834, 408);
            this.chtData.TabIndex = 0;
            this.chtData.Text = "chart";
            // 
            // cboWoStatus
            // 
            this.cboWoStatus.FormattingEnabled = true;
            this.cboWoStatus.Location = new System.Drawing.Point(130, 68);
            this.cboWoStatus.Name = "cboWoStatus";
            this.cboWoStatus.Size = new System.Drawing.Size(130, 25);
            this.cboWoStatus.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(464, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "공정";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(280, 19);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(125, 25);
            this.dtpTo.TabIndex = 69;
            this.dtpTo.Value = new System.DateTime(2023, 1, 30, 0, 0, 0, 0);
            // 
            // ucWcCode
            // 
            this.ucWcCode._Code = "";
            this.ucWcCode._Name = "";
            this.ucWcCode.BackColor = System.Drawing.Color.Transparent;
            this.ucWcCode.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucWcCode.Location = new System.Drawing.Point(544, 67);
            this.ucWcCode.Margin = new System.Windows.Forms.Padding(4);
            this.ucWcCode.Name = "ucWcCode";
            this.ucWcCode.Size = new System.Drawing.Size(340, 26);
            this.ucWcCode.TabIndex = 67;
            this.ucWcCode.BtnClick += new System.EventHandler(this.ucWcCode_BtnClick);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(127, 19);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(125, 25);
            this.dtpFrom.TabIndex = 68;
            this.dtpFrom.Value = new System.DateTime(2023, 1, 25, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(29, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 72;
            this.label6.Text = "생산일자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(258, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "~";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(29, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 70;
            this.label9.Text = "작업지시상태";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(464, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 74;
            this.label7.Text = "작업장";
            // 
            // ucProcessCode
            // 
            this.ucProcessCode._Code = "";
            this.ucProcessCode._Name = "";
            this.ucProcessCode.BackColor = System.Drawing.Color.Transparent;
            this.ucProcessCode.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucProcessCode.Location = new System.Drawing.Point(544, 18);
            this.ucProcessCode.Margin = new System.Windows.Forms.Padding(4);
            this.ucProcessCode.Name = "ucProcessCode";
            this.ucProcessCode.Size = new System.Drawing.Size(340, 26);
            this.ucProcessCode.TabIndex = 75;
            this.ucProcessCode.BtnClick += new System.EventHandler(this.ucProcessCode_BtnClick);
            // 
            // chkDefQty
            // 
            this.chkDefQty.AutoSize = true;
            this.chkDefQty.BackColor = System.Drawing.Color.Transparent;
            this.chkDefQty.Location = new System.Drawing.Point(927, 21);
            this.chkDefQty.Name = "chkDefQty";
            this.chkDefQty.Size = new System.Drawing.Size(83, 21);
            this.chkDefQty.TabIndex = 77;
            this.chkDefQty.Text = "불량제외";
            this.chkDefQty.UseVisualStyleBackColor = false;
            // 
            // cboTest
            // 
            this.cboTest.FormattingEnabled = true;
            this.cboTest.Items.AddRange(new object[] {
            "WorkOrder_001",
            "WorkOrder_002",
            "WorkOrder_003",
            "WorkOrder_004"});
            this.cboTest.Location = new System.Drawing.Point(1638, 54);
            this.cboTest.Name = "cboTest";
            this.cboTest.Size = new System.Drawing.Size(194, 25);
            this.cboTest.TabIndex = 79;
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.BackColor = System.Drawing.Color.Transparent;
            this.lbltest.Location = new System.Drawing.Point(1638, 14);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(120, 34);
            this.lbltest.TabIndex = 80;
            this.lbltest.Text = "(바인딩 테스트)\r\n임시작업지시번호";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1761, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 26);
            this.button1.TabIndex = 81;
            this.button1.Text = "테스트";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(638, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "작업지시 마감";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.DarkBlue;
            this.label16.Location = new System.Drawing.Point(600, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 17);
            this.label16.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(521, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "현장마감";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Location = new System.Drawing.Point(483, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 17);
            this.label14.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(404, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "생산중지";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(366, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(301, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "생산중";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.ForestGreen;
            this.label13.Location = new System.Drawing.Point(263, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(187, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "생산대기";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Orange;
            this.label18.Location = new System.Drawing.Point(149, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 17);
            this.label18.TabIndex = 22;
            // 
            // frmTimeProductionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Name = "frmTimeProductionHistory";
            this.Text = "시간대별 실적조회";
            this.Load += new System.EventHandler(this.frmTimeProductionHistory_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboWoStatus;
        protected System.Windows.Forms.Label label5;
        private Controls.ucSearch ucProcessCode;
        protected System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private Controls.ucSearch ucWcCode;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtData;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox chkDefQty;
        private System.Windows.Forms.ComboBox cboTest;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}
