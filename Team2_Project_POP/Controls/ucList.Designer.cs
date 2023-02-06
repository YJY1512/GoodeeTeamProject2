
namespace Team2_Project_POP.Controls
{
    partial class ucList
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.Controls.Add(this.lblRemark, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStatuse, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1135, 118);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblRemark
            // 
            this.lblRemark.BackColor = System.Drawing.Color.DarkBlue;
            this.lblRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemark.ForeColor = System.Drawing.Color.White;
            this.lblRemark.Location = new System.Drawing.Point(875, 4);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(2, 4, 4, 4);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(256, 110);
            this.lblRemark.TabIndex = 2;
            this.lblRemark.Text = "전달 사항";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRemark.Click += new System.EventHandler(this.lblStatuse_Click);
            this.lblRemark.MouseEnter += new System.EventHandler(this.lblStatuse_MouseEnter);
            this.lblRemark.MouseLeave += new System.EventHandler(this.lblStatuse_MouseLeave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(158, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(715, 118);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblProductDate
            // 
            this.lblProductDate.BackColor = System.Drawing.Color.DarkBlue;
            this.lblProductDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductDate.ForeColor = System.Drawing.Color.White;
            this.lblProductDate.Location = new System.Drawing.Point(2, 61);
            this.lblProductDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.lblProductDate.Name = "lblProductDate";
            this.lblProductDate.Size = new System.Drawing.Size(196, 53);
            this.lblProductDate.TabIndex = 7;
            this.lblProductDate.Text = "생산 일자";
            this.lblProductDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductDate.Click += new System.EventHandler(this.lblStatuse_Click);
            this.lblProductDate.MouseEnter += new System.EventHandler(this.lblStatuse_MouseEnter);
            this.lblProductDate.MouseLeave += new System.EventHandler(this.lblStatuse_MouseLeave);
            // 
            // lblPlanDate
            // 
            this.lblPlanDate.BackColor = System.Drawing.Color.DarkBlue;
            this.lblPlanDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlanDate.ForeColor = System.Drawing.Color.White;
            this.lblPlanDate.Location = new System.Drawing.Point(2, 4);
            this.lblPlanDate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.lblPlanDate.Name = "lblPlanDate";
            this.lblPlanDate.Size = new System.Drawing.Size(196, 53);
            this.lblPlanDate.TabIndex = 3;
            this.lblPlanDate.Text = "계획 일자";
            this.lblPlanDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlanDate.Click += new System.EventHandler(this.lblStatuse_Click);
            this.lblPlanDate.MouseEnter += new System.EventHandler(this.lblStatuse_MouseEnter);
            this.lblPlanDate.MouseLeave += new System.EventHandler(this.lblStatuse_MouseLeave);
            // 
            // lblProcessNum
            // 
            this.lblProcessNum.BackColor = System.Drawing.Color.DarkBlue;
            this.lblProcessNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcessNum.ForeColor = System.Drawing.Color.White;
            this.lblProcessNum.Location = new System.Drawing.Point(202, 4);
            this.lblProcessNum.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.lblProcessNum.Name = "lblProcessNum";
            this.lblProcessNum.Size = new System.Drawing.Size(196, 53);
            this.lblProcessNum.TabIndex = 4;
            this.lblProcessNum.Text = "작업 지시 번호";
            this.lblProcessNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProcessNum.Click += new System.EventHandler(this.lblStatuse_Click);
            this.lblProcessNum.MouseEnter += new System.EventHandler(this.lblStatuse_MouseEnter);
            this.lblProcessNum.MouseLeave += new System.EventHandler(this.lblStatuse_MouseLeave);
            // 
            // lblPlanQty
            // 
            this.lblPlanQty.BackColor = System.Drawing.Color.DarkBlue;
            this.lblPlanQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlanQty.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPlanQty.ForeColor = System.Drawing.Color.White;
            this.lblPlanQty.Location = new System.Drawing.Point(402, 4);
            this.lblPlanQty.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.lblPlanQty.Name = "lblPlanQty";
            this.lblPlanQty.Size = new System.Drawing.Size(110, 53);
            this.lblPlanQty.TabIndex = 5;
            this.lblPlanQty.Text = "계획 수량";
            this.lblPlanQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlanQty.Click += new System.EventHandler(this.lblStatuse_Click);
            this.lblPlanQty.MouseEnter += new System.EventHandler(this.lblStatuse_MouseEnter);
            this.lblPlanQty.MouseLeave += new System.EventHandler(this.lblStatuse_MouseLeave);
            // 
            // lblStartTime
            // 
            this.lblStartTime.BackColor = System.Drawing.Color.DarkBlue;
            this.lblStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(516, 4);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(197, 53);
            this.lblStartTime.TabIndex = 6;
            this.lblStartTime.Text = "생산 시작 시간";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStartTime.Click += new System.EventHandler(this.lblStatuse_Click);
            this.lblStartTime.MouseEnter += new System.EventHandler(this.lblStatuse_MouseEnter);
            this.lblStartTime.MouseLeave += new System.EventHandler(this.lblStatuse_MouseLeave);
            // 
            // lblIngQty
            // 
            this.lblIngQty.BackColor = System.Drawing.Color.DarkBlue;
            this.lblIngQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngQty.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIngQty.ForeColor = System.Drawing.Color.White;
            this.lblIngQty.Location = new System.Drawing.Point(402, 61);
            this.lblIngQty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.lblIngQty.Name = "lblIngQty";
            this.lblIngQty.Size = new System.Drawing.Size(110, 53);
            this.lblIngQty.TabIndex = 9;
            this.lblIngQty.Text = "실적 수량";
            this.lblIngQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIngQty.Click += new System.EventHandler(this.lblStatuse_Click);
            this.lblIngQty.MouseEnter += new System.EventHandler(this.lblStatuse_MouseEnter);
            this.lblIngQty.MouseLeave += new System.EventHandler(this.lblStatuse_MouseLeave);
            // 
            // lblFinishTime
            // 
            this.lblFinishTime.BackColor = System.Drawing.Color.DarkBlue;
            this.lblFinishTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFinishTime.ForeColor = System.Drawing.Color.White;
            this.lblFinishTime.Location = new System.Drawing.Point(516, 61);
            this.lblFinishTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.lblFinishTime.Name = "lblFinishTime";
            this.lblFinishTime.Size = new System.Drawing.Size(197, 53);
            this.lblFinishTime.TabIndex = 10;
            this.lblFinishTime.Text = "생산 종료 시간";
            this.lblFinishTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinishTime.Click += new System.EventHandler(this.lblStatuse_Click);
            this.lblFinishTime.MouseEnter += new System.EventHandler(this.lblStatuse_MouseEnter);
            this.lblFinishTime.MouseLeave += new System.EventHandler(this.lblStatuse_MouseLeave);
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.DarkBlue;
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(202, 61);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(196, 53);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Text = "품목명";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductName.Click += new System.EventHandler(this.lblStatuse_Click);
            this.lblProductName.MouseEnter += new System.EventHandler(this.lblStatuse_MouseEnter);
            this.lblProductName.MouseLeave += new System.EventHandler(this.lblStatuse_MouseLeave);
            // 
            // lblStatuse
            // 
            this.lblStatuse.BackColor = System.Drawing.Color.DarkBlue;
            this.lblStatuse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatuse.ForeColor = System.Drawing.Color.White;
            this.lblStatuse.Location = new System.Drawing.Point(4, 4);
            this.lblStatuse.Margin = new System.Windows.Forms.Padding(4, 4, 2, 4);
            this.lblStatuse.Name = "lblStatuse";
            this.lblStatuse.Size = new System.Drawing.Size(152, 110);
            this.lblStatuse.TabIndex = 1;
            this.lblStatuse.Text = "상  태";
            this.lblStatuse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatuse.Click += new System.EventHandler(this.lblStatuse_Click);
            this.lblStatuse.MouseEnter += new System.EventHandler(this.lblStatuse_MouseEnter);
            this.lblStatuse.MouseLeave += new System.EventHandler(this.lblStatuse_MouseLeave);
            // 
            // ucList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "ucList";
            this.Size = new System.Drawing.Size(1135, 118);
            this.Load += new System.EventHandler(this.ucList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblStatuse;
        private System.Windows.Forms.Label lblPlanDate;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblProductDate;
        private System.Windows.Forms.Label lblProcessNum;
        private System.Windows.Forms.Label lblPlanQty;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblIngQty;
        private System.Windows.Forms.Label lblFinishTime;
        private System.Windows.Forms.Label lblProductName;
    }
}
