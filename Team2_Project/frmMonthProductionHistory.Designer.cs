
namespace Team2_Project
{
    partial class frmMonthProductionHistory
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ucItemSearch = new Team2_Project.Controls.ucSearch();
            this.label1 = new System.Windows.Forms.Label();
            this.chtDataPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerChart = new System.Windows.Forms.SplitContainer();
            this.chtDataLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoChartOne = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoChartTwo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoPrdQty = new System.Windows.Forms.RadioButton();
            this.rdoInQty = new System.Windows.Forms.RadioButton();
            this.rdoOutQty = new System.Windows.Forms.RadioButton();
            this.rdoPlanQty = new System.Windows.Forms.RadioButton();
            this.panCriteria = new System.Windows.Forms.Panel();
            this.rdoLossQty = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDataPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChart)).BeginInit();
            this.splitContainerChart.Panel1.SuspendLayout();
            this.splitContainerChart.Panel2.SuspendLayout();
            this.splitContainerChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDataLine)).BeginInit();
            this.panel2.SuspendLayout();
            this.panCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.panCriteria);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Controls.Add(this.ucItemSearch);
            this.pnlSub.Controls.Add(this.label6);
            this.pnlSub.Controls.Add(this.dtpDate);
            this.pnlSub.Size = new System.Drawing.Size(1834, 60);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.splitContainer1);
            this.pnlList.Location = new System.Drawing.Point(0, 103);
            this.pnlList.Size = new System.Drawing.Size(1834, 808);
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(60, 18);
            this.lblTitle.Text = "조회내역";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Location = new System.Drawing.Point(0, 60);
            this.pnlTitle.Size = new System.Drawing.Size(1834, 43);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy-MM";
            this.dtpDate.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(111, 17);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(125, 25);
            this.dtpDate.TabIndex = 73;
            this.dtpDate.Value = new System.DateTime(2023, 2, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(30, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "조회년월";
            // 
            // ucItemSearch
            // 
            this.ucItemSearch._Code = "";
            this.ucItemSearch._Name = "";
            this.ucItemSearch.BackColor = System.Drawing.Color.Transparent;
            this.ucItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucItemSearch.Location = new System.Drawing.Point(352, 15);
            this.ucItemSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ucItemSearch.Name = "ucItemSearch";
            this.ucItemSearch.Size = new System.Drawing.Size(340, 28);
            this.ucItemSearch.TabIndex = 77;
            this.ucItemSearch.BtnClick += new System.EventHandler(this.ucItemSearch_BtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(300, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "품목";
            // 
            // chtDataPie
            // 
            chartArea2.Name = "ChartArea1";
            this.chtDataPie.ChartAreas.Add(chartArea2);
            this.chtDataPie.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chtDataPie.Legends.Add(legend2);
            this.chtDataPie.Location = new System.Drawing.Point(0, 0);
            this.chtDataPie.Name = "chtDataPie";
            this.chtDataPie.Size = new System.Drawing.Size(985, 431);
            this.chtDataPie.TabIndex = 3;
            this.chtDataPie.Text = "chart1";
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(1834, 330);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvData_CellFormatting);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1834, 808);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainerChart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1834, 431);
            this.panel1.TabIndex = 4;
            // 
            // splitContainerChart
            // 
            this.splitContainerChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerChart.Location = new System.Drawing.Point(0, 0);
            this.splitContainerChart.Name = "splitContainerChart";
            // 
            // splitContainerChart.Panel1
            // 
            this.splitContainerChart.Panel1.Controls.Add(this.chtDataLine);
            // 
            // splitContainerChart.Panel2
            // 
            this.splitContainerChart.Panel2.Controls.Add(this.chtDataPie);
            this.splitContainerChart.Size = new System.Drawing.Size(1834, 431);
            this.splitContainerChart.SplitterDistance = 845;
            this.splitContainerChart.TabIndex = 0;
            // 
            // chtDataLine
            // 
            chartArea1.Name = "ChartArea1";
            this.chtDataLine.ChartAreas.Add(chartArea1);
            this.chtDataLine.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chtDataLine.Legends.Add(legend1);
            this.chtDataLine.Location = new System.Drawing.Point(0, 0);
            this.chtDataLine.Name = "chtDataLine";
            this.chtDataLine.Size = new System.Drawing.Size(845, 431);
            this.chtDataLine.TabIndex = 4;
            this.chtDataLine.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.rdoChartOne);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rdoChartTwo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1834, 43);
            this.panel2.TabIndex = 3;
            // 
            // rdoChartOne
            // 
            this.rdoChartOne.AutoSize = true;
            this.rdoChartOne.BackColor = System.Drawing.Color.Transparent;
            this.rdoChartOne.ForeColor = System.Drawing.Color.White;
            this.rdoChartOne.Location = new System.Drawing.Point(190, 8);
            this.rdoChartOne.Name = "rdoChartOne";
            this.rdoChartOne.Size = new System.Drawing.Size(68, 21);
            this.rdoChartOne.TabIndex = 86;
            this.rdoChartOne.TabStop = true;
            this.rdoChartOne.Text = "Single";
            this.rdoChartOne.UseVisualStyleBackColor = false;
            this.rdoChartOne.CheckedChanged += new System.EventHandler(this.rdoChartTwo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "▷";
            // 
            // rdoChartTwo
            // 
            this.rdoChartTwo.AutoSize = true;
            this.rdoChartTwo.BackColor = System.Drawing.Color.Transparent;
            this.rdoChartTwo.ForeColor = System.Drawing.Color.White;
            this.rdoChartTwo.Location = new System.Drawing.Point(285, 8);
            this.rdoChartTwo.Name = "rdoChartTwo";
            this.rdoChartTwo.Size = new System.Drawing.Size(76, 21);
            this.rdoChartTwo.TabIndex = 87;
            this.rdoChartTwo.TabStop = true;
            this.rdoChartTwo.Text = "Double";
            this.rdoChartTwo.UseVisualStyleBackColor = false;
            this.rdoChartTwo.CheckedChanged += new System.EventHandler(this.rdoChartTwo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "월별 생산현황";
            // 
            // rdoPrdQty
            // 
            this.rdoPrdQty.AutoSize = true;
            this.rdoPrdQty.BackColor = System.Drawing.Color.Transparent;
            this.rdoPrdQty.Location = new System.Drawing.Point(68, 9);
            this.rdoPrdQty.Name = "rdoPrdQty";
            this.rdoPrdQty.Size = new System.Drawing.Size(82, 21);
            this.rdoPrdQty.TabIndex = 79;
            this.rdoPrdQty.TabStop = true;
            this.rdoPrdQty.Text = "생산수량";
            this.rdoPrdQty.UseVisualStyleBackColor = false;
            this.rdoPrdQty.CheckedChanged += new System.EventHandler(this.rdoChecked_CheckedChanged);
            // 
            // rdoInQty
            // 
            this.rdoInQty.AutoSize = true;
            this.rdoInQty.BackColor = System.Drawing.Color.Transparent;
            this.rdoInQty.Location = new System.Drawing.Point(260, 9);
            this.rdoInQty.Name = "rdoInQty";
            this.rdoInQty.Size = new System.Drawing.Size(82, 21);
            this.rdoInQty.TabIndex = 80;
            this.rdoInQty.TabStop = true;
            this.rdoInQty.Text = "투입수량";
            this.rdoInQty.UseVisualStyleBackColor = false;
            this.rdoInQty.CheckedChanged += new System.EventHandler(this.rdoChecked_CheckedChanged);
            // 
            // rdoOutQty
            // 
            this.rdoOutQty.AutoSize = true;
            this.rdoOutQty.BackColor = System.Drawing.Color.Transparent;
            this.rdoOutQty.Location = new System.Drawing.Point(356, 9);
            this.rdoOutQty.Name = "rdoOutQty";
            this.rdoOutQty.Size = new System.Drawing.Size(82, 21);
            this.rdoOutQty.TabIndex = 81;
            this.rdoOutQty.TabStop = true;
            this.rdoOutQty.Text = "산출수량";
            this.rdoOutQty.UseVisualStyleBackColor = false;
            this.rdoOutQty.CheckedChanged += new System.EventHandler(this.rdoChecked_CheckedChanged);
            // 
            // rdoPlanQty
            // 
            this.rdoPlanQty.AutoSize = true;
            this.rdoPlanQty.BackColor = System.Drawing.Color.Transparent;
            this.rdoPlanQty.Location = new System.Drawing.Point(164, 9);
            this.rdoPlanQty.Name = "rdoPlanQty";
            this.rdoPlanQty.Size = new System.Drawing.Size(82, 21);
            this.rdoPlanQty.TabIndex = 82;
            this.rdoPlanQty.TabStop = true;
            this.rdoPlanQty.Text = "목표수량";
            this.rdoPlanQty.UseVisualStyleBackColor = false;
            this.rdoPlanQty.CheckedChanged += new System.EventHandler(this.rdoChecked_CheckedChanged);
            // 
            // panCriteria
            // 
            this.panCriteria.BackColor = System.Drawing.Color.Transparent;
            this.panCriteria.Controls.Add(this.rdoLossQty);
            this.panCriteria.Controls.Add(this.label5);
            this.panCriteria.Controls.Add(this.rdoPrdQty);
            this.panCriteria.Controls.Add(this.rdoPlanQty);
            this.panCriteria.Controls.Add(this.rdoOutQty);
            this.panCriteria.Controls.Add(this.rdoInQty);
            this.panCriteria.Location = new System.Drawing.Point(741, 11);
            this.panCriteria.Name = "panCriteria";
            this.panCriteria.Size = new System.Drawing.Size(561, 37);
            this.panCriteria.TabIndex = 83;
            // 
            // rdoLossQty
            // 
            this.rdoLossQty.AutoSize = true;
            this.rdoLossQty.BackColor = System.Drawing.Color.Transparent;
            this.rdoLossQty.Location = new System.Drawing.Point(452, 10);
            this.rdoLossQty.Name = "rdoLossQty";
            this.rdoLossQty.Size = new System.Drawing.Size(82, 21);
            this.rdoLossQty.TabIndex = 85;
            this.rdoLossQty.TabStop = true;
            this.rdoLossQty.Text = "불량수량";
            this.rdoLossQty.UseVisualStyleBackColor = false;
            this.rdoLossQty.CheckedChanged += new System.EventHandler(this.rdoChecked_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(18, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 84;
            this.label5.Text = "기준";
            // 
            // frmMonthProductionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Name = "frmMonthProductionHistory";
            this.Text = "월별 생산현황";
            this.Load += new System.EventHandler(this.frmMonthProductionHistory_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDataPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainerChart.Panel1.ResumeLayout(false);
            this.splitContainerChart.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChart)).EndInit();
            this.splitContainerChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtDataLine)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panCriteria.ResumeLayout(false);
            this.panCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private Controls.ucSearch ucItemSearch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDataPie;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoInQty;
        private System.Windows.Forms.RadioButton rdoPrdQty;
        private System.Windows.Forms.RadioButton rdoPlanQty;
        private System.Windows.Forms.RadioButton rdoOutQty;
        private System.Windows.Forms.Panel panCriteria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoLossQty;
        private System.Windows.Forms.SplitContainer splitContainerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDataLine;
        private System.Windows.Forms.RadioButton rdoChartOne;
        private System.Windows.Forms.RadioButton rdoChartTwo;
    }
}
