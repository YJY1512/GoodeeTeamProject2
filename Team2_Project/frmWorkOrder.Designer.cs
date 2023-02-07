
namespace Team2_Project
{
    partial class frmWorkOrder
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
            this.ucProcess = new Team2_Project.Controls.ucSearch();
            this.label1 = new System.Windows.Forms.Label();
            this.ucWc = new Team2_Project.Controls.ucSearch();
            this.label13 = new System.Windows.Forms.Label();
            this.ucProd = new Team2_Project.Controls.ucSearch();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpWoTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpWoFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvWorkOrder = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpWo = new System.Windows.Forms.DateTimePicker();
            this.txtWoQty = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ucProcess2 = new Team2_Project.Controls.ucSearch();
            this.label23 = new System.Windows.Forms.Label();
            this.txtWorkOrder = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.ucProd2 = new Team2_Project.Controls.ucSearch();
            this.label27 = new System.Windows.Forms.Label();
            this.ucWc2 = new Team2_Project.Controls.ucSearch();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTitleD.SuspendLayout();
            this.pnlTitleU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.dtpWoTo);
            this.pnlSub.Controls.Add(this.label6);
            this.pnlSub.Controls.Add(this.dtpWoFrom);
            this.pnlSub.Controls.Add(this.label4);
            this.pnlSub.Controls.Add(this.ucProcess);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Controls.Add(this.ucWc);
            this.pnlSub.Controls.Add(this.label13);
            this.pnlSub.Controls.Add(this.ucProd);
            this.pnlSub.Controls.Add(this.label12);
            this.pnlSub.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSub.Size = new System.Drawing.Size(1232, 120);
            // 
            // lblTitleU
            // 
            this.lblTitleU.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleU.Size = new System.Drawing.Size(92, 17);
            this.lblTitleU.Text = "작업지시목록";
            // 
            // lblTitleD
            // 
            this.lblTitleD.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleD.Size = new System.Drawing.Size(124, 17);
            this.lblTitleD.Text = "작업지시 상세목록";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvWorkOrder);
            this.pnlList.Size = new System.Drawing.Size(1232, 283);
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.label29);
            this.pnlArea.Controls.Add(this.ucWc2);
            this.pnlArea.Controls.Add(this.label28);
            this.pnlArea.Controls.Add(this.label18);
            this.pnlArea.Controls.Add(this.label19);
            this.pnlArea.Controls.Add(this.dtpWo);
            this.pnlArea.Controls.Add(this.txtWoQty);
            this.pnlArea.Controls.Add(this.label20);
            this.pnlArea.Controls.Add(this.label21);
            this.pnlArea.Controls.Add(this.label22);
            this.pnlArea.Controls.Add(this.ucProcess2);
            this.pnlArea.Controls.Add(this.label23);
            this.pnlArea.Controls.Add(this.txtWorkOrder);
            this.pnlArea.Controls.Add(this.label24);
            this.pnlArea.Controls.Add(this.label25);
            this.pnlArea.Controls.Add(this.label26);
            this.pnlArea.Controls.Add(this.ucProd2);
            this.pnlArea.Controls.Add(this.label27);
            this.pnlArea.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlArea.Size = new System.Drawing.Size(1232, 173);
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 120);
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(1232, 546);
            this.splitContainer1.SplitterDistance = 326;
            // 
            // pnlTitleD
            // 
            this.pnlTitleD.Size = new System.Drawing.Size(1232, 43);
            // 
            // pnlTitleU
            // 
            this.pnlTitleU.Controls.Add(this.btnClose);
            this.pnlTitleU.Controls.Add(this.btnCancel);
            this.pnlTitleU.Controls.Add(this.label15);
            this.pnlTitleU.Controls.Add(this.label16);
            this.pnlTitleU.Controls.Add(this.label10);
            this.pnlTitleU.Controls.Add(this.label14);
            this.pnlTitleU.Controls.Add(this.label8);
            this.pnlTitleU.Controls.Add(this.label9);
            this.pnlTitleU.Controls.Add(this.label5);
            this.pnlTitleU.Controls.Add(this.label7);
            this.pnlTitleU.Controls.Add(this.label11);
            this.pnlTitleU.Controls.Add(this.label17);
            this.pnlTitleU.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTitleU.Size = new System.Drawing.Size(1232, 43);
            this.pnlTitleU.Controls.SetChildIndex(this.lblTitleU, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label17, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label11, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label7, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label5, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label9, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label8, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label14, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label10, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label16, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.label15, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlTitleU.Controls.SetChildIndex(this.btnClose, 0);
            // 
            // ucProcess
            // 
            this.ucProcess._Code = "";
            this.ucProcess._Name = "";
            this.ucProcess.BackColor = System.Drawing.Color.Transparent;
            this.ucProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucProcess.Location = new System.Drawing.Point(588, 23);
            this.ucProcess.Margin = new System.Windows.Forms.Padding(4);
            this.ucProcess.Name = "ucProcess";
            this.ucProcess.Size = new System.Drawing.Size(340, 28);
            this.ucProcess.TabIndex = 27;
            this.ucProcess.BtnClick += new System.EventHandler(this.ucProcess_BtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(523, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "공정";
            // 
            // ucWc
            // 
            this.ucWc._Code = "";
            this.ucWc._Name = "";
            this.ucWc.BackColor = System.Drawing.Color.Transparent;
            this.ucWc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucWc.Location = new System.Drawing.Point(588, 69);
            this.ucWc.Margin = new System.Windows.Forms.Padding(4);
            this.ucWc.Name = "ucWc";
            this.ucWc.Size = new System.Drawing.Size(340, 28);
            this.ucWc.TabIndex = 25;
            this.ucWc.BtnClick += new System.EventHandler(this.ucWc_BtnClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(523, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "작업장";
            // 
            // ucProd
            // 
            this.ucProd._Code = "";
            this.ucProd._Name = "";
            this.ucProd.BackColor = System.Drawing.Color.Transparent;
            this.ucProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucProd.Location = new System.Drawing.Point(137, 69);
            this.ucProd.Margin = new System.Windows.Forms.Padding(4);
            this.ucProd.Name = "ucProd";
            this.ucProd.Size = new System.Drawing.Size(340, 28);
            this.ucProd.TabIndex = 23;
            this.ucProd.BtnClick += new System.EventHandler(this.ucProd_BtnClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(30, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "품목";
            // 
            // dtpWoTo
            // 
            this.dtpWoTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWoTo.Location = new System.Drawing.Point(292, 23);
            this.dtpWoTo.Name = "dtpWoTo";
            this.dtpWoTo.Size = new System.Drawing.Size(125, 25);
            this.dtpWoTo.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(268, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "~";
            // 
            // dtpWoFrom
            // 
            this.dtpWoFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWoFrom.Location = new System.Drawing.Point(137, 23);
            this.dtpWoFrom.Name = "dtpWoFrom";
            this.dtpWoFrom.Size = new System.Drawing.Size(125, 25);
            this.dtpWoFrom.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(30, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "작업지시일자";
            // 
            // dgvWorkOrder
            // 
            this.dgvWorkOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvWorkOrder.Name = "dgvWorkOrder";
            this.dgvWorkOrder.RowTemplate.Height = 23;
            this.dgvWorkOrder.Size = new System.Drawing.Size(1232, 283);
            this.dgvWorkOrder.TabIndex = 0;
            this.dgvWorkOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkOrder_CellClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(639, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "작업지시 마감";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.DarkBlue;
            this.label16.Location = new System.Drawing.Point(601, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 17);
            this.label16.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(522, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "현장마감";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Location = new System.Drawing.Point(484, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 17);
            this.label14.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(405, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "생산중지";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(367, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(302, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "생산중";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(264, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(188, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "생산대기";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Orange;
            this.label17.Location = new System.Drawing.Point(150, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 17);
            this.label17.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(753, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 26);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "작업지시 마감";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(905, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 26);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "작업지시 마감취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(544, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 17);
            this.label18.TabIndex = 72;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(576, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 17);
            this.label19.TabIndex = 71;
            this.label19.Text = "작업지시일자";
            // 
            // dtpWo
            // 
            this.dtpWo.CustomFormat = "";
            this.dtpWo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWo.Location = new System.Drawing.Point(683, 125);
            this.dtpWo.Name = "dtpWo";
            this.dtpWo.Size = new System.Drawing.Size(170, 25);
            this.dtpWo.TabIndex = 70;
            // 
            // txtWoQty
            // 
            this.txtWoQty.Location = new System.Drawing.Point(683, 71);
            this.txtWoQty.Name = "txtWoQty";
            this.txtWoQty.Size = new System.Drawing.Size(170, 25);
            this.txtWoQty.TabIndex = 69;
            this.txtWoQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWoQty_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(544, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 17);
            this.label20.TabIndex = 68;
            this.label20.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(576, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 17);
            this.label21.TabIndex = 67;
            this.label21.Text = "작업지시수량";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(20, 129);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 17);
            this.label22.TabIndex = 66;
            this.label22.Text = "*";
            // 
            // ucProcess2
            // 
            this.ucProcess2._Code = "";
            this.ucProcess2._Name = "";
            this.ucProcess2.BackColor = System.Drawing.Color.Transparent;
            this.ucProcess2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucProcess2.Location = new System.Drawing.Point(147, 125);
            this.ucProcess2.Margin = new System.Windows.Forms.Padding(4);
            this.ucProcess2.Name = "ucProcess2";
            this.ucProcess2.Size = new System.Drawing.Size(340, 28);
            this.ucProcess2.TabIndex = 65;
            this.ucProcess2.BtnClick += new System.EventHandler(this.ucProcess_BtnClick);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(40, 129);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 17);
            this.label23.TabIndex = 64;
            this.label23.Text = "공정";
            // 
            // txtWorkOrder
            // 
            this.txtWorkOrder.Enabled = false;
            this.txtWorkOrder.Location = new System.Drawing.Point(147, 17);
            this.txtWorkOrder.Name = "txtWorkOrder";
            this.txtWorkOrder.Size = new System.Drawing.Size(170, 25);
            this.txtWorkOrder.TabIndex = 63;
            this.txtWorkOrder.Text = "시스템자동생성";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(20, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 17);
            this.label24.TabIndex = 62;
            this.label24.Text = "*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(40, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 17);
            this.label25.TabIndex = 61;
            this.label25.Text = "작업지시번호";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(20, 75);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 17);
            this.label26.TabIndex = 60;
            this.label26.Text = "*";
            // 
            // ucProd2
            // 
            this.ucProd2._Code = "";
            this.ucProd2._Name = "";
            this.ucProd2.BackColor = System.Drawing.Color.Transparent;
            this.ucProd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucProd2.Location = new System.Drawing.Point(147, 71);
            this.ucProd2.Margin = new System.Windows.Forms.Padding(4);
            this.ucProd2.Name = "ucProd2";
            this.ucProd2.Size = new System.Drawing.Size(340, 28);
            this.ucProd2.TabIndex = 59;
            this.ucProd2.BtnClick += new System.EventHandler(this.ucProd_BtnClick);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(40, 75);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(36, 17);
            this.label27.TabIndex = 58;
            this.label27.Text = "품목";
            // 
            // ucWc2
            // 
            this.ucWc2._Code = "";
            this.ucWc2._Name = "";
            this.ucWc2.BackColor = System.Drawing.Color.Transparent;
            this.ucWc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucWc2.Location = new System.Drawing.Point(683, 17);
            this.ucWc2.Margin = new System.Windows.Forms.Padding(4);
            this.ucWc2.Name = "ucWc2";
            this.ucWc2.Size = new System.Drawing.Size(340, 28);
            this.ucWc2.TabIndex = 74;
            this.ucWc2.BtnClick += new System.EventHandler(this.ucWc_BtnClick);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(576, 21);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 17);
            this.label28.TabIndex = 73;
            this.label28.Text = "작업장";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(544, 21);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 17);
            this.label29.TabIndex = 75;
            this.label29.Text = "*";
            // 
            // frmWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1232, 666);
            this.Name = "frmWorkOrder";
            this.Text = "작업지시 생성 및 마감";
            this.Load += new System.EventHandler(this.frmWorkOrder_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlTitleD.ResumeLayout(false);
            this.pnlTitleD.PerformLayout();
            this.pnlTitleU.ResumeLayout(false);
            this.pnlTitleU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ucSearch ucProcess;
        private System.Windows.Forms.Label label1;
        private Controls.ucSearch ucWc;
        private System.Windows.Forms.Label label13;
        private Controls.ucSearch ucProd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpWoTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpWoFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvWorkOrder;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpWo;
        private System.Windows.Forms.TextBox txtWoQty;
        public System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label22;
        private Controls.ucSearch ucProcess2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtWorkOrder;
        public System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.Label label26;
        private Controls.ucSearch ucProd2;
        private System.Windows.Forms.Label label27;
        public System.Windows.Forms.Label label29;
        private Controls.ucSearch ucWc2;
        private System.Windows.Forms.Label label28;
    }
}
