
namespace Team2_Project
{
    partial class frmFavorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFavorite));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.trvAllList = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstSubList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNodeUp = new System.Windows.Forms.Button();
            this.btnNodeDown = new System.Windows.Forms.Button();
            this.btnNodeDel = new System.Windows.Forms.Button();
            this.trvFavorite = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 30);
            this.panel1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(977, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "즐겨찾기";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 507);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 50);
            this.panel3.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnSave.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(884, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // trvAllList
            // 
            this.trvAllList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.trvAllList.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trvAllList.Location = new System.Drawing.Point(12, 69);
            this.trvAllList.Name = "trvAllList";
            this.trvAllList.ShowLines = false;
            this.trvAllList.ShowPlusMinus = false;
            this.trvAllList.ShowRootLines = false;
            this.trvAllList.Size = new System.Drawing.Size(265, 416);
            this.trvAllList.TabIndex = 9;
            this.trvAllList.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvAllList_BeforeSelect);
            this.trvAllList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvAllList_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(107, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Menu List";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.btnAdd.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(598, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 83);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(774, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "즐겨찾기 List";
            // 
            // lstSubList
            // 
            this.lstSubList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.lstSubList.FormattingEnabled = true;
            this.lstSubList.ItemHeight = 17;
            this.lstSubList.Location = new System.Drawing.Point(328, 108);
            this.lstSubList.Name = "lstSubList";
            this.lstSubList.Size = new System.Drawing.Size(253, 378);
            this.lstSubList.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(442, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 39);
            this.label4.TabIndex = 16;
            // 
            // btnNodeUp
            // 
            this.btnNodeUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.btnNodeUp.Image = ((System.Drawing.Image)(resources.GetObject("btnNodeUp.Image")));
            this.btnNodeUp.Location = new System.Drawing.Point(959, 69);
            this.btnNodeUp.Name = "btnNodeUp";
            this.btnNodeUp.Size = new System.Drawing.Size(43, 39);
            this.btnNodeUp.TabIndex = 22;
            this.btnNodeUp.UseVisualStyleBackColor = false;
            this.btnNodeUp.Click += new System.EventHandler(this.btnNodeUp_Click);
            // 
            // btnNodeDown
            // 
            this.btnNodeDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.btnNodeDown.Image = ((System.Drawing.Image)(resources.GetObject("btnNodeDown.Image")));
            this.btnNodeDown.Location = new System.Drawing.Point(959, 116);
            this.btnNodeDown.Name = "btnNodeDown";
            this.btnNodeDown.Size = new System.Drawing.Size(43, 39);
            this.btnNodeDown.TabIndex = 23;
            this.btnNodeDown.UseVisualStyleBackColor = false;
            this.btnNodeDown.Click += new System.EventHandler(this.btnNodeDown_Click);
            // 
            // btnNodeDel
            // 
            this.btnNodeDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.btnNodeDel.Image = ((System.Drawing.Image)(resources.GetObject("btnNodeDel.Image")));
            this.btnNodeDel.Location = new System.Drawing.Point(959, 161);
            this.btnNodeDel.Name = "btnNodeDel";
            this.btnNodeDel.Size = new System.Drawing.Size(43, 39);
            this.btnNodeDel.TabIndex = 24;
            this.btnNodeDel.UseVisualStyleBackColor = false;
            this.btnNodeDel.Click += new System.EventHandler(this.btnNodeDel_Click);
            // 
            // trvFavorite
            // 
            this.trvFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.trvFavorite.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trvFavorite.ItemHeight = 30;
            this.trvFavorite.Location = new System.Drawing.Point(689, 69);
            this.trvFavorite.Name = "trvFavorite";
            this.trvFavorite.ShowLines = false;
            this.trvFavorite.ShowPlusMinus = false;
            this.trvFavorite.Size = new System.Drawing.Size(264, 416);
            this.trvFavorite.TabIndex = 26;
            this.trvFavorite.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvFavorite_BeforeSelect);
            this.trvFavorite.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvFavorite_AfterSelect);
            // 
            // frmFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 557);
            this.Controls.Add(this.trvFavorite);
            this.Controls.Add(this.btnNodeDel);
            this.Controls.Add(this.btnNodeDown);
            this.Controls.Add(this.btnNodeUp);
            this.Controls.Add(this.lstSubList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trvAllList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFavorite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFavorite";
            this.Load += new System.EventHandler(this.frmFavorite_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TreeView trvAllList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstSubList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNodeUp;
        private System.Windows.Forms.Button btnNodeDown;
        private System.Windows.Forms.Button btnNodeDel;
        private System.Windows.Forms.TreeView trvFavorite;
    }
}