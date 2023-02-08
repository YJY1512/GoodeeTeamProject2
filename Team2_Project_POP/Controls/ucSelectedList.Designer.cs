
namespace Team2_Project_POP.Controls
{
    partial class ucSelectedList
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
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblWorkSpace = new System.Windows.Forms.Label();
            this.lblStatuse = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.Controls.Add(this.lblGroup, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWorkSpace, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStatuse, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblGroup
            // 
            this.lblGroup.BackColor = System.Drawing.Color.DarkBlue;
            this.lblGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGroup.ForeColor = System.Drawing.Color.White;
            this.lblGroup.Location = new System.Drawing.Point(673, 10);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(114, 80);
            this.lblGroup.TabIndex = 2;
            this.lblGroup.Text = "그  룹";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGroup.Click += new System.EventHandler(this.ucSelectedList_Click);
            // 
            // lblWorkSpace
            // 
            this.lblWorkSpace.BackColor = System.Drawing.Color.DarkBlue;
            this.lblWorkSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkSpace.ForeColor = System.Drawing.Color.White;
            this.lblWorkSpace.Location = new System.Drawing.Point(132, 10);
            this.lblWorkSpace.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblWorkSpace.Name = "lblWorkSpace";
            this.lblWorkSpace.Size = new System.Drawing.Size(531, 80);
            this.lblWorkSpace.TabIndex = 1;
            this.lblWorkSpace.Text = "작 업 장";
            this.lblWorkSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWorkSpace.Click += new System.EventHandler(this.ucSelectedList_Click);
            // 
            // lblStatuse
            // 
            this.lblStatuse.BackColor = System.Drawing.Color.DarkBlue;
            this.lblStatuse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatuse.ForeColor = System.Drawing.Color.White;
            this.lblStatuse.Location = new System.Drawing.Point(10, 10);
            this.lblStatuse.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.lblStatuse.Name = "lblStatuse";
            this.lblStatuse.Size = new System.Drawing.Size(112, 80);
            this.lblStatuse.TabIndex = 0;
            this.lblStatuse.Text = "상  태";
            this.lblStatuse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatuse.Click += new System.EventHandler(this.ucSelectedList_Click);
            // 
            // ucSelectedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "ucSelectedList";
            this.Size = new System.Drawing.Size(797, 100);
            this.Load += new System.EventHandler(this.ucSelectedList_Load);
            this.Click += new System.EventHandler(this.ucSelectedList_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblWorkSpace;
        public System.Windows.Forms.Label lblStatuse;
        public System.Windows.Forms.Label lblGroup;
    }
}
