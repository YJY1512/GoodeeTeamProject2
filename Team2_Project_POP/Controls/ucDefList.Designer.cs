
namespace Team2_Project_POP.Controls
{
    partial class ucDefList
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
            this.lblDefMiName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblDefQty = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.lblDefMiName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDefQty, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDefMiName
            // 
            this.lblDefMiName.BackColor = System.Drawing.Color.White;
            this.lblDefMiName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDefMiName.ForeColor = System.Drawing.Color.Black;
            this.lblDefMiName.Location = new System.Drawing.Point(427, 2);
            this.lblDefMiName.Margin = new System.Windows.Forms.Padding(2);
            this.lblDefMiName.Name = "lblDefMiName";
            this.lblDefMiName.Size = new System.Drawing.Size(293, 146);
            this.lblDefMiName.TabIndex = 4;
            this.lblDefMiName.Text = "label1";
            this.lblDefMiName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(87, 2);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(336, 146);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.MediumBlue;
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(1, 1);
            this.btnDel.Margin = new System.Windows.Forms.Padding(1);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(83, 148);
            this.btnDel.TabIndex = 2;
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // lblDefQty
            // 
            this.lblDefQty.BackColor = System.Drawing.Color.White;
            this.lblDefQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDefQty.Location = new System.Drawing.Point(724, 2);
            this.lblDefQty.Margin = new System.Windows.Forms.Padding(2);
            this.lblDefQty.Name = "lblDefQty";
            this.lblDefQty.Size = new System.Drawing.Size(125, 146);
            this.lblDefQty.TabIndex = 5;
            this.lblDefQty.Text = "label2";
            this.lblDefQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucDefList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "ucDefList";
            this.Size = new System.Drawing.Size(851, 150);
            this.Load += new System.EventHandler(this.ucDefList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblDefMiName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDefQty;
    }
}
