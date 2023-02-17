
namespace Team2_Project_POP.Controls
{
    partial class ucNonList
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
            this.lblNonMa = new System.Windows.Forms.Label();
            this.lblNonMi = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblEndTime, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStartTime, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNonMi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNonMa, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 124);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNonMa
            // 
            this.lblNonMa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblNonMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNonMa.Location = new System.Drawing.Point(2, 2);
            this.lblNonMa.Margin = new System.Windows.Forms.Padding(2);
            this.lblNonMa.Name = "lblNonMa";
            this.lblNonMa.Size = new System.Drawing.Size(193, 120);
            this.lblNonMa.TabIndex = 0;
            this.lblNonMa.Text = "대분류";
            this.lblNonMa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNonMi
            // 
            this.lblNonMi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblNonMi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNonMi.Location = new System.Drawing.Point(199, 2);
            this.lblNonMi.Margin = new System.Windows.Forms.Padding(2);
            this.lblNonMi.Name = "lblNonMi";
            this.lblNonMi.Size = new System.Drawing.Size(193, 120);
            this.lblNonMi.TabIndex = 1;
            this.lblNonMi.Text = "세분류";
            this.lblNonMi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartTime
            // 
            this.lblStartTime.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartTime.Location = new System.Drawing.Point(396, 2);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(193, 120);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "등록시";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndTime
            // 
            this.lblEndTime.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblEndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEndTime.Location = new System.Drawing.Point(593, 2);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(193, 120);
            this.lblEndTime.TabIndex = 3;
            this.lblEndTime.Text = "해제시";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucNonList
            // 
            this.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucNonList";
            this.Size = new System.Drawing.Size(788, 124);
            this.Load += new System.EventHandler(this.frmNonList_Load);
            this.Click += new System.EventHandler(this.ucNonList_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblNonMi;
        private System.Windows.Forms.Label lblNonMa;
    }
}
