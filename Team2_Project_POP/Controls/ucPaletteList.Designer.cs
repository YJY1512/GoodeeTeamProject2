
namespace Team2_Project_POP.Controls
{
    partial class ucPaletteList
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBoxQty = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWorkNo = new System.Windows.Forms.Label();
            this.lblPaletteNo = new System.Windows.Forms.Label();
            this.lblISClick = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblISClick, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 96);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblBoxQty, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSize, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblItemName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(40, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1160, 96);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // lblBoxQty
            // 
            this.lblBoxQty.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblBoxQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBoxQty.ForeColor = System.Drawing.Color.Black;
            this.lblBoxQty.Location = new System.Drawing.Point(928, 2);
            this.lblBoxQty.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.lblBoxQty.Name = "lblBoxQty";
            this.lblBoxQty.Size = new System.Drawing.Size(230, 92);
            this.lblBoxQty.TabIndex = 4;
            this.lblBoxQty.Text = "박스 수량";
            this.lblBoxQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBoxQty.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // lblSize
            // 
            this.lblSize.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSize.ForeColor = System.Drawing.Color.Black;
            this.lblSize.Location = new System.Drawing.Point(696, 2);
            this.lblSize.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(230, 92);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "사이즈";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSize.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemName.ForeColor = System.Drawing.Color.Black;
            this.lblItemName.Location = new System.Drawing.Point(372, 2);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(322, 92);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "품목명";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItemName.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblWorkNo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblPaletteNo, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(371, 96);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // lblWorkNo
            // 
            this.lblWorkNo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblWorkNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkNo.ForeColor = System.Drawing.Color.Black;
            this.lblWorkNo.Location = new System.Drawing.Point(1, 2);
            this.lblWorkNo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.lblWorkNo.Name = "lblWorkNo";
            this.lblWorkNo.Size = new System.Drawing.Size(369, 45);
            this.lblWorkNo.TabIndex = 2;
            this.lblWorkNo.Text = "작업지시번호";
            this.lblWorkNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWorkNo.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // lblPaletteNo
            // 
            this.lblPaletteNo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPaletteNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaletteNo.ForeColor = System.Drawing.Color.Black;
            this.lblPaletteNo.Location = new System.Drawing.Point(1, 49);
            this.lblPaletteNo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.lblPaletteNo.Name = "lblPaletteNo";
            this.lblPaletteNo.Size = new System.Drawing.Size(369, 45);
            this.lblPaletteNo.TabIndex = 3;
            this.lblPaletteNo.Text = "팔레트번호";
            this.lblPaletteNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPaletteNo.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // lblISClick
            // 
            this.lblISClick.AutoSize = true;
            this.lblISClick.BackColor = System.Drawing.Color.Silver;
            this.lblISClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblISClick.Location = new System.Drawing.Point(2, 2);
            this.lblISClick.Margin = new System.Windows.Forms.Padding(2, 2, 1, 2);
            this.lblISClick.Name = "lblISClick";
            this.lblISClick.Size = new System.Drawing.Size(37, 92);
            this.lblISClick.TabIndex = 1;
            this.lblISClick.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // ucPaletteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "ucPaletteList";
            this.Size = new System.Drawing.Size(1200, 96);
            this.Load += new System.EventHandler(this.ucPaletteList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblBoxQty;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblWorkNo;
        private System.Windows.Forms.Label lblPaletteNo;
        public System.Windows.Forms.Label lblISClick;
    }
}
