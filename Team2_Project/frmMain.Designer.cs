
namespace Team2_Project
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("생산요청 관리");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("생산계획 관리");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("시유 작업지시 생성");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("생산작업 관리", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("작업지시 생성 및 마감");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("시간대별 실적 조회");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("작업지시 현황");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("작업지시 관리", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("비가동 내역");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("실적 관리", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("일별 생산 현황");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("분석 관리", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("공정정보");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("작업장정보");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("조직 관리", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("품목정보");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("품목 관리", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("사용자 정의 관리");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("불량현상 관리");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("비가동 관리");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("표준 관리", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("사용자 관리");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("인사 관리");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("시스템 설정관리", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("시스템 코드 관리");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("즐겨찾기및 화면관리");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("시스템 운영관리", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnSetting = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFavorite = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnltreenode4 = new System.Windows.Forms.Panel();
            this.treeView4 = new System.Windows.Forms.TreeView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnProduce = new System.Windows.Forms.Button();
            this.pnltreenode3 = new System.Windows.Forms.Panel();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.pnlBig3 = new System.Windows.Forms.Panel();
            this.btnProcess = new System.Windows.Forms.Button();
            this.pnltreenode2 = new System.Windows.Forms.Panel();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.pnlBig2 = new System.Windows.Forms.Panel();
            this.btnBasic = new System.Windows.Forms.Button();
            this.pnltreenode1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pnlBig1 = new System.Windows.Forms.Panel();
            this.btnsystem = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList64 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tStripDate = new System.Windows.Forms.ToolStripLabel();
            this.tStripTime = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.tStripName = new System.Windows.Forms.ToolStripLabel();
            this.tStripDept = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1 = new Team2_Project.Controls.ccTabControl();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnltreenode4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnltreenode3.SuspendLayout();
            this.pnlBig3.SuspendLayout();
            this.pnltreenode2.SuspendLayout();
            this.pnlBig2.SuspendLayout();
            this.pnltreenode1.SuspendLayout();
            this.pnlBig1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1335, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            this.menuStrip1.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.menuStrip1_ItemAdded);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.toolStrip1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSetting,
            this.tsBtnFavorite});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1335, 35);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnSetting
            // 
            this.tsBtnSetting.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnSetting.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsBtnSetting.ForeColor = System.Drawing.Color.White;
            this.tsBtnSetting.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSetting.Image")));
            this.tsBtnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSetting.Margin = new System.Windows.Forms.Padding(5);
            this.tsBtnSetting.Name = "tsBtnSetting";
            this.tsBtnSetting.Size = new System.Drawing.Size(55, 25);
            this.tsBtnSetting.Text = "설정";
            // 
            // tsBtnFavorite
            // 
            this.tsBtnFavorite.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnFavorite.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsBtnFavorite.ForeColor = System.Drawing.Color.White;
            this.tsBtnFavorite.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFavorite.Image")));
            this.tsBtnFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFavorite.Name = "tsBtnFavorite";
            this.tsBtnFavorite.Size = new System.Drawing.Size(79, 32);
            this.tsBtnFavorite.Text = "즐겨찾기";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.btnFavorite);
            this.panel2.Controls.Add(this.pnltreenode4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.pnltreenode3);
            this.panel2.Controls.Add(this.pnlBig3);
            this.panel2.Controls.Add(this.pnltreenode2);
            this.panel2.Controls.Add(this.pnlBig2);
            this.panel2.Controls.Add(this.pnltreenode1);
            this.panel2.Controls.Add(this.pnlBig1);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 734);
            this.panel2.TabIndex = 24;
            // 
            // btnFavorite
            // 
            this.btnFavorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavorite.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFavorite.ForeColor = System.Drawing.Color.White;
            this.btnFavorite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorite.ImageIndex = 5;
            this.btnFavorite.ImageList = this.imageList1;
            this.btnFavorite.Location = new System.Drawing.Point(0, 441);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Padding = new System.Windows.Forms.Padding(8);
            this.btnFavorite.Size = new System.Drawing.Size(216, 65);
            this.btnFavorite.TabIndex = 36;
            this.btnFavorite.Text = "     즐겨 찾기";
            this.btnFavorite.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "- (1).png");
            this.imageList1.Images.SetKeyName(1, "check.png");
            this.imageList1.Images.SetKeyName(2, "- (4).png");
            this.imageList1.Images.SetKeyName(3, "process.png");
            this.imageList1.Images.SetKeyName(4, "png (12).png");
            this.imageList1.Images.SetKeyName(5, "png (13).png");
            // 
            // pnltreenode4
            // 
            this.pnltreenode4.Controls.Add(this.treeView4);
            this.pnltreenode4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltreenode4.Location = new System.Drawing.Point(0, 431);
            this.pnltreenode4.Name = "pnltreenode4";
            this.pnltreenode4.Size = new System.Drawing.Size(216, 10);
            this.pnltreenode4.TabIndex = 35;
            // 
            // treeView4
            // 
            this.treeView4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.treeView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView4.Location = new System.Drawing.Point(0, 0);
            this.treeView4.Name = "treeView4";
            treeNode1.Name = "노드1";
            treeNode1.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "생산요청 관리";
            treeNode2.Name = "노드2";
            treeNode2.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode2.Text = "생산계획 관리";
            treeNode3.Name = "노드3";
            treeNode3.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode3.Text = "시유 작업지시 생성";
            treeNode4.Name = "노드0";
            treeNode4.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode4.Text = "생산작업 관리";
            this.treeView4.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView4.Size = new System.Drawing.Size(216, 10);
            this.treeView4.TabIndex = 0;
            this.treeView4.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView4_NodeMouseDoubleClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnProduce);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 366);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 65);
            this.panel5.TabIndex = 34;
            // 
            // btnProduce
            // 
            this.btnProduce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProduce.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProduce.ForeColor = System.Drawing.Color.White;
            this.btnProduce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduce.ImageIndex = 4;
            this.btnProduce.ImageList = this.imageList1;
            this.btnProduce.Location = new System.Drawing.Point(0, 0);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Padding = new System.Windows.Forms.Padding(8);
            this.btnProduce.Size = new System.Drawing.Size(216, 65);
            this.btnProduce.TabIndex = 0;
            this.btnProduce.Text = "     생산 관리";
            this.btnProduce.UseVisualStyleBackColor = false;
            this.btnProduce.Click += new System.EventHandler(this.btnProduce_Click);
            // 
            // pnltreenode3
            // 
            this.pnltreenode3.Controls.Add(this.treeView3);
            this.pnltreenode3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltreenode3.Location = new System.Drawing.Point(0, 356);
            this.pnltreenode3.Name = "pnltreenode3";
            this.pnltreenode3.Size = new System.Drawing.Size(216, 10);
            this.pnltreenode3.TabIndex = 33;
            // 
            // treeView3
            // 
            this.treeView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.treeView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView3.ItemHeight = 30;
            this.treeView3.Location = new System.Drawing.Point(0, 0);
            this.treeView3.Name = "treeView3";
            treeNode5.Name = "노드1";
            treeNode5.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.Text = "작업지시 생성 및 마감";
            treeNode6.Name = "노드7";
            treeNode6.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode6.Text = "시간대별 실적 조회";
            treeNode7.Name = "노드8";
            treeNode7.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode7.Text = "작업지시 현황";
            treeNode8.Name = "노드0";
            treeNode8.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode8.Text = "작업지시 관리";
            treeNode9.Name = "노드3";
            treeNode9.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode9.Text = "비가동 내역";
            treeNode10.Name = "노드2";
            treeNode10.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold);
            treeNode10.Text = "실적 관리";
            treeNode11.Name = "노드6";
            treeNode11.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode11.Text = "일별 생산 현황";
            treeNode12.Name = "노드5";
            treeNode12.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold);
            treeNode12.Text = "분석 관리";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10,
            treeNode12});
            this.treeView3.Size = new System.Drawing.Size(216, 10);
            this.treeView3.TabIndex = 0;
            this.treeView3.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView3_NodeMouseDoubleClick);
            // 
            // pnlBig3
            // 
            this.pnlBig3.Controls.Add(this.btnProcess);
            this.pnlBig3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBig3.Location = new System.Drawing.Point(0, 291);
            this.pnlBig3.Name = "pnlBig3";
            this.pnlBig3.Size = new System.Drawing.Size(216, 65);
            this.pnlBig3.TabIndex = 32;
            // 
            // btnProcess
            // 
            this.btnProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcess.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.ImageIndex = 3;
            this.btnProcess.ImageList = this.imageList1;
            this.btnProcess.Location = new System.Drawing.Point(0, 0);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Padding = new System.Windows.Forms.Padding(8);
            this.btnProcess.Size = new System.Drawing.Size(216, 65);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "      공정 관리";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // pnltreenode2
            // 
            this.pnltreenode2.Controls.Add(this.treeView2);
            this.pnltreenode2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltreenode2.Location = new System.Drawing.Point(0, 281);
            this.pnltreenode2.Name = "pnltreenode2";
            this.pnltreenode2.Size = new System.Drawing.Size(216, 10);
            this.pnltreenode2.TabIndex = 31;
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView2.ItemHeight = 30;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            treeNode13.Name = "노드3";
            treeNode13.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode13.Text = "공정정보";
            treeNode14.Name = "노드4";
            treeNode14.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode14.Text = "작업장정보";
            treeNode15.Name = "노드0";
            treeNode15.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode15.Text = "조직 관리";
            treeNode16.Name = "노드6";
            treeNode16.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode16.Text = "품목정보";
            treeNode17.Name = "노드5";
            treeNode17.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode17.Text = "품목 관리";
            treeNode18.Name = "노드8";
            treeNode18.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode18.Text = "사용자 정의 관리";
            treeNode19.Name = "노드9";
            treeNode19.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode19.Text = "불량현상 관리";
            treeNode20.Name = "노드10";
            treeNode20.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode20.Text = "비가동 관리";
            treeNode21.Name = "노드7";
            treeNode21.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode21.Text = "표준 관리";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode17,
            treeNode21});
            this.treeView2.Size = new System.Drawing.Size(216, 10);
            this.treeView2.TabIndex = 0;
            this.treeView2.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView2_NodeMouseDoubleClick);
            // 
            // pnlBig2
            // 
            this.pnlBig2.Controls.Add(this.btnBasic);
            this.pnlBig2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBig2.Location = new System.Drawing.Point(0, 216);
            this.pnlBig2.Name = "pnlBig2";
            this.pnlBig2.Size = new System.Drawing.Size(216, 65);
            this.pnlBig2.TabIndex = 30;
            // 
            // btnBasic
            // 
            this.btnBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBasic.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBasic.ForeColor = System.Drawing.Color.White;
            this.btnBasic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasic.ImageKey = "- (4).png";
            this.btnBasic.ImageList = this.imageList1;
            this.btnBasic.Location = new System.Drawing.Point(0, 0);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Padding = new System.Windows.Forms.Padding(8);
            this.btnBasic.Size = new System.Drawing.Size(216, 65);
            this.btnBasic.TabIndex = 0;
            this.btnBasic.Text = "      기준 정보";
            this.btnBasic.UseVisualStyleBackColor = false;
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // pnltreenode1
            // 
            this.pnltreenode1.Controls.Add(this.treeView1);
            this.pnltreenode1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltreenode1.Location = new System.Drawing.Point(0, 206);
            this.pnltreenode1.Name = "pnltreenode1";
            this.pnltreenode1.Size = new System.Drawing.Size(216, 10);
            this.pnltreenode1.TabIndex = 29;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode22.Name = "node1";
            treeNode22.NodeFont = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            treeNode22.Tag = "0";
            treeNode22.Text = "사용자 관리";
            treeNode23.Name = "노드2";
            treeNode23.NodeFont = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            treeNode23.Tag = "1";
            treeNode23.Text = "인사 관리";
            treeNode24.Checked = true;
            treeNode24.Name = "노드0";
            treeNode24.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            treeNode24.Text = "시스템 설정관리";
            treeNode25.Name = "노드4";
            treeNode25.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode25.Tag = "2";
            treeNode25.Text = "시스템 코드 관리";
            treeNode26.Name = "노드5";
            treeNode26.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode26.Tag = "3";
            treeNode26.Text = "즐겨찾기및 화면관리";
            treeNode27.Checked = true;
            treeNode27.ForeColor = System.Drawing.Color.Black;
            treeNode27.Name = "노드3";
            treeNode27.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            treeNode27.SelectedImageIndex = -2;
            treeNode27.Text = "시스템 운영관리";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode27});
            this.treeView1.Size = new System.Drawing.Size(216, 10);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // pnlBig1
            // 
            this.pnlBig1.Controls.Add(this.btnsystem);
            this.pnlBig1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBig1.Location = new System.Drawing.Point(0, 141);
            this.pnlBig1.Name = "pnlBig1";
            this.pnlBig1.Size = new System.Drawing.Size(216, 65);
            this.pnlBig1.TabIndex = 28;
            // 
            // btnsystem
            // 
            this.btnsystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsystem.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnsystem.ForeColor = System.Drawing.Color.White;
            this.btnsystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsystem.ImageIndex = 1;
            this.btnsystem.ImageList = this.imageList1;
            this.btnsystem.Location = new System.Drawing.Point(0, 0);
            this.btnsystem.Name = "btnsystem";
            this.btnsystem.Padding = new System.Windows.Forms.Padding(8);
            this.btnsystem.Size = new System.Drawing.Size(216, 65);
            this.btnsystem.TabIndex = 0;
            this.btnsystem.Text = "      시스템 관리";
            this.btnsystem.UseVisualStyleBackColor = false;
            this.btnsystem.Click += new System.EventHandler(this.btnsystem_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.ImageIndex = 0;
            this.btnMenu.ImageList = this.imageList1;
            this.btnMenu.Location = new System.Drawing.Point(0, 76);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(8);
            this.btnMenu.Size = new System.Drawing.Size(216, 65);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "     홈";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 76);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAMHYUN";
            // 
            // imageList64
            // 
            this.imageList64.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList64.ImageStream")));
            this.imageList64.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList64.Images.SetKeyName(0, "Add.png");
            this.imageList64.Images.SetKeyName(1, "Search.png");
            this.imageList64.Images.SetKeyName(2, "Cancel64(2).png");
            this.imageList64.Images.SetKeyName(3, "Delete64.png");
            this.imageList64.Images.SetKeyName(4, "Edit64.png");
            this.imageList64.Images.SetKeyName(5, "Printer64.png");
            this.imageList64.Images.SetKeyName(6, "ReUpdate(2).png");
            this.imageList64.Images.SetKeyName(7, "Save64(2).png");
            this.imageList64.Images.SetKeyName(8, "Setting64.png");
            this.imageList64.Images.SetKeyName(9, "Printer64.png");
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripDate,
            this.tStripTime,
            this.tsBtnLogOut,
            this.tStripName,
            this.tStripDept});
            this.toolStrip3.Location = new System.Drawing.Point(216, 734);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1119, 35);
            this.toolStrip3.TabIndex = 33;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tStripDate
            // 
            this.tStripDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.tStripDate.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tStripDate.ForeColor = System.Drawing.Color.White;
            this.tStripDate.Margin = new System.Windows.Forms.Padding(5);
            this.tStripDate.Name = "tStripDate";
            this.tStripDate.Size = new System.Drawing.Size(35, 25);
            this.tStripDate.Text = "Date";
            // 
            // tStripTime
            // 
            this.tStripTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.tStripTime.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tStripTime.ForeColor = System.Drawing.Color.White;
            this.tStripTime.Margin = new System.Windows.Forms.Padding(5);
            this.tStripTime.Name = "tStripTime";
            this.tStripTime.Size = new System.Drawing.Size(36, 25);
            this.tStripTime.Text = "Time";
            // 
            // tsBtnLogOut
            // 
            this.tsBtnLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnLogOut.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsBtnLogOut.ForeColor = System.Drawing.Color.White;
            this.tsBtnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLogOut.Image")));
            this.tsBtnLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLogOut.Margin = new System.Windows.Forms.Padding(5);
            this.tsBtnLogOut.Name = "tsBtnLogOut";
            this.tsBtnLogOut.Size = new System.Drawing.Size(79, 25);
            this.tsBtnLogOut.Text = "로그아웃";
            // 
            // tStripName
            // 
            this.tStripName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tStripName.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripName.ForeColor = System.Drawing.Color.White;
            this.tStripName.Margin = new System.Windows.Forms.Padding(5);
            this.tStripName.Name = "tStripName";
            this.tStripName.Size = new System.Drawing.Size(31, 25);
            this.tStripName.Text = "이름";
            // 
            // tStripDept
            // 
            this.tStripDept.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tStripDept.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripDept.ForeColor = System.Drawing.Color.White;
            this.tStripDept.Margin = new System.Windows.Forms.Padding(5);
            this.tStripDept.Name = "tStripDept";
            this.tStripDept.Size = new System.Drawing.Size(31, 25);
            this.tStripDept.Text = "부서";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(216, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 76);
            this.panel1.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnReLoad);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(542, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 76);
            this.panel3.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ImageKey = "Printer64.png";
            this.btnPrint.ImageList = this.imageList64;
            this.btnPrint.Location = new System.Drawing.Point(505, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 65);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReLoad.ImageKey = "ReUpdate(2).png";
            this.btnReLoad.ImageList = this.imageList64;
            this.btnReLoad.Location = new System.Drawing.Point(434, 5);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(65, 65);
            this.btnReLoad.TabIndex = 6;
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ImageKey = "Cancel64(2).png";
            this.btnCancel.ImageList = this.imageList64;
            this.btnCancel.Location = new System.Drawing.Point(363, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 65);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ImageKey = "Save64(2).png";
            this.btnSave.ImageList = this.imageList64;
            this.btnSave.Location = new System.Drawing.Point(292, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 65);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ImageKey = "Delete64.png";
            this.btnDelete.ImageList = this.imageList64;
            this.btnDelete.Location = new System.Drawing.Point(221, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 65);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ImageKey = "Edit64.png";
            this.btnEdit.ImageList = this.imageList64;
            this.btnEdit.Location = new System.Drawing.Point(150, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 65);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageKey = "Add.png";
            this.btnAdd.ImageList = this.imageList64;
            this.btnAdd.Location = new System.Drawing.Point(79, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 65);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ImageKey = "Search.png";
            this.btnSearch.ImageList = this.imageList64;
            this.btnSearch.Location = new System.Drawing.Point(8, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 65);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(216, 111);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1119, 27);
            this.tabControl1.TabIndex = 35;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1335, 769);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnltreenode4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnltreenode3.ResumeLayout(false);
            this.pnlBig3.ResumeLayout(false);
            this.pnltreenode2.ResumeLayout(false);
            this.pnlBig2.ResumeLayout(false);
            this.pnltreenode1.ResumeLayout(false);
            this.pnlBig1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList64;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel tStripTime;
        private System.Windows.Forms.ToolStripLabel tStripDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private Controls.ccTabControl tabControl1;
        private System.Windows.Forms.ToolStripButton tsBtnSetting;
        private System.Windows.Forms.ToolStripButton tsBtnFavorite;
        private System.Windows.Forms.ToolStripButton tsBtnLogOut;
        private System.Windows.Forms.ToolStripLabel tStripName;
        private System.Windows.Forms.ToolStripLabel tStripDept;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Panel pnltreenode4;
        private System.Windows.Forms.TreeView treeView4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnProduce;
        private System.Windows.Forms.Panel pnltreenode3;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.Panel pnlBig3;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel pnltreenode2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Panel pnlBig2;
        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Panel pnltreenode1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel pnlBig1;
        private System.Windows.Forms.Button btnsystem;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ImageList imageList1;
    }
}

