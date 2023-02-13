
namespace Team2_Project_POP.Controls
{
    partial class frmNonList
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
            this.lblNonTime = new System.Windows.Forms.Label();
            this.lblNonMi = new System.Windows.Forms.Label();
            this.lblNonMa = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 124);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.lblNonMa_Click);
            // 
            // lblNonTime
            // 
            this.lblNonTime.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblNonTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNonTime.ForeColor = System.Drawing.Color.Black;
            this.lblNonTime.Location = new System.Drawing.Point(557, 7);
            this.lblNonTime.Margin = new System.Windows.Forms.Padding(7);
            this.lblNonTime.Name = "lblNonTime";
            this.lblNonTime.Size = new System.Drawing.Size(224, 110);
            this.lblNonTime.TabIndex = 4;
            this.lblNonTime.Text = "발생시";
            this.lblNonTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNonTime.Click += new System.EventHandler(this.lblNonMa_Click);
            // 
            // lblNonMi
            // 
            this.lblNonMi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblNonMi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNonMi.ForeColor = System.Drawing.Color.Black;
            this.lblNonMi.Location = new System.Drawing.Point(282, 7);
            this.lblNonMi.Margin = new System.Windows.Forms.Padding(7);
            this.lblNonMi.Name = "lblNonMi";
            this.lblNonMi.Size = new System.Drawing.Size(261, 110);
            this.lblNonMi.TabIndex = 2;
            this.lblNonMi.Text = "상세분류";
            this.lblNonMi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNonMi.Click += new System.EventHandler(this.lblNonMa_Click);
            // 
            // lblNonMa
            // 
            this.lblNonMa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblNonMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNonMa.ForeColor = System.Drawing.Color.Black;
            this.lblNonMa.Location = new System.Drawing.Point(7, 7);
            this.lblNonMa.Margin = new System.Windows.Forms.Padding(7);
            this.lblNonMa.Name = "lblNonMa";
            this.lblNonMa.Size = new System.Drawing.Size(261, 110);
            this.lblNonMa.TabIndex = 1;
            this.lblNonMa.Text = "대분류";
            this.lblNonMa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNonMa.Click += new System.EventHandler(this.lblNonMa_Click);
            // 
            // frmNonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "frmNonList";
            this.Size = new System.Drawing.Size(788, 124);
            this.Load += new System.EventHandler(this.frmNonList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNonMa;
        private System.Windows.Forms.Label lblNonMi;
        private System.Windows.Forms.Label lblNonTime;
    }
}
