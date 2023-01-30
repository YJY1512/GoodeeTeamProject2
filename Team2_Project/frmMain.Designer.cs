
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
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("생산요청 관리");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("생산계획 관리");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("시유 작업지시 생성");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("생산작업 관리", new System.Windows.Forms.TreeNode[] {
            treeNode61,
            treeNode62,
            treeNode63});
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("작업지시 생성 및 마감");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("시간대별 실적 조회");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("작업지시 현황");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("작업지시 관리", new System.Windows.Forms.TreeNode[] {
            treeNode65,
            treeNode66,
            treeNode67});
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("비가동 내역");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("실적 관리", new System.Windows.Forms.TreeNode[] {
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("일별 생산 현황");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("분석 관리", new System.Windows.Forms.TreeNode[] {
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("공정정보");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("작업장정보");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("조직 관리", new System.Windows.Forms.TreeNode[] {
            treeNode73,
            treeNode74});
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("품목정보");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("품목 관리", new System.Windows.Forms.TreeNode[] {
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("사용자 정의 관리");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("불량현상 대분류코드");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("불량현상 상세분류코드");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("비가동 대분류코드");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("비가동 상세분류코드");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("표준 관리", new System.Windows.Forms.TreeNode[] {
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81,
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("사용자 그룹코드");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("사용자 권한설정");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("사용자 관리");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("시스템 설정관리", new System.Windows.Forms.TreeNode[] {
            treeNode84,
            treeNode85,
            treeNode86});
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("시스템 코드 관리");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("즐겨찾기및 화면관리");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("시스템 운영관리", new System.Windows.Forms.TreeNode[] {
            treeNode88,
            treeNode89});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnSetting = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFavorite = new System.Windows.Forms.ToolStripButton();
            this.imageListLeftSideBar = new System.Windows.Forms.ImageList(this.components);
            this.imageList64 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.pnltreenode4 = new System.Windows.Forms.Panel();
            this.treeView4 = new System.Windows.Forms.TreeView();
            this.panel7 = new System.Windows.Forms.Panel();
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.chkHide = new System.Windows.Forms.CheckBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tStripDate = new System.Windows.Forms.ToolStripLabel();
            this.tStripTime = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.tStripName = new System.Windows.Forms.ToolStripLabel();
            this.tStripDept = new System.Windows.Forms.ToolStripLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new Team2_Project.Controls.ccTabControl();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnltreenode4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnltreenode3.SuspendLayout();
            this.pnlBig3.SuspendLayout();
            this.pnltreenode2.SuspendLayout();
            this.pnlBig2.SuspendLayout();
            this.pnltreenode1.SuspendLayout();
            this.pnlBig1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.toolStrip3.SuspendLayout();
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
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.toolStrip1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tsBtnSetting.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tsBtnFavorite.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnFavorite.ForeColor = System.Drawing.Color.White;
            this.tsBtnFavorite.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFavorite.Image")));
            this.tsBtnFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFavorite.Name = "tsBtnFavorite";
            this.tsBtnFavorite.Size = new System.Drawing.Size(79, 32);
            this.tsBtnFavorite.Text = "즐겨찾기";
            // 
            // imageListLeftSideBar
            // 
            this.imageListLeftSideBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLeftSideBar.ImageStream")));
            this.imageListLeftSideBar.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLeftSideBar.Images.SetKeyName(0, "- (1).png");
            this.imageListLeftSideBar.Images.SetKeyName(1, "check.png");
            this.imageListLeftSideBar.Images.SetKeyName(2, "- (4).png");
            this.imageListLeftSideBar.Images.SetKeyName(3, "process.png");
            this.imageListLeftSideBar.Images.SetKeyName(4, "png (12).png");
            this.imageListLeftSideBar.Images.SetKeyName(5, "png (13).png");
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 76);
            this.panel1.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 76);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(140, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "TILE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "GOODEE";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReLoad);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(827, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 76);
            this.panel3.TabIndex = 0;
            // 
            // btnReLoad
            // 
            this.btnReLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnReLoad.FlatAppearance.BorderSize = 4;
            this.btnReLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReLoad.ImageKey = "ReUpdate(2).png";
            this.btnReLoad.ImageList = this.imageList64;
            this.btnReLoad.Location = new System.Drawing.Point(434, 5);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(65, 65);
            this.btnReLoad.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnReLoad, "새로고침");
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnCancel.FlatAppearance.BorderSize = 4;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ImageKey = "Cancel64(2).png";
            this.btnCancel.ImageList = this.imageList64;
            this.btnCancel.Location = new System.Drawing.Point(363, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 65);
            this.btnCancel.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnCancel, "취소");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnSave.FlatAppearance.BorderSize = 4;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ImageKey = "Save64(2).png";
            this.btnSave.ImageList = this.imageList64;
            this.btnSave.Location = new System.Drawing.Point(292, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 65);
            this.btnSave.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnSave, "저장");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnDelete.FlatAppearance.BorderSize = 4;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ImageKey = "Delete64.png";
            this.btnDelete.ImageList = this.imageList64;
            this.btnDelete.Location = new System.Drawing.Point(221, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 65);
            this.btnDelete.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnDelete, "삭제");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnEdit.FlatAppearance.BorderSize = 4;
            this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ImageKey = "Edit64.png";
            this.btnEdit.ImageList = this.imageList64;
            this.btnEdit.Location = new System.Drawing.Point(150, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 65);
            this.btnEdit.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnEdit, "수정");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnAdd.FlatAppearance.BorderSize = 4;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageKey = "Add.png";
            this.btnAdd.ImageList = this.imageList64;
            this.btnAdd.Location = new System.Drawing.Point(79, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 65);
            this.btnAdd.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAdd, "추가");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnSearch.FlatAppearance.BorderSize = 4;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ImageKey = "Search.png";
            this.btnSearch.ImageList = this.imageList64;
            this.btnSearch.Location = new System.Drawing.Point(8, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 65);
            this.btnSearch.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSearch, "조회");
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.pnlMenu);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 792);
            this.panel2.TabIndex = 37;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnFavorite);
            this.pnlMenu.Controls.Add(this.pnltreenode4);
            this.pnlMenu.Controls.Add(this.panel7);
            this.pnlMenu.Controls.Add(this.pnltreenode3);
            this.pnlMenu.Controls.Add(this.pnlBig3);
            this.pnlMenu.Controls.Add(this.pnltreenode2);
            this.pnlMenu.Controls.Add(this.pnlBig2);
            this.pnlMenu.Controls.Add(this.pnltreenode1);
            this.pnlMenu.Controls.Add(this.pnlBig1);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(212, 757);
            this.pnlMenu.TabIndex = 48;
            // 
            // btnFavorite
            // 
            this.btnFavorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavorite.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFavorite.ForeColor = System.Drawing.Color.White;
            this.btnFavorite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorite.ImageIndex = 5;
            this.btnFavorite.ImageList = this.imageListLeftSideBar;
            this.btnFavorite.Location = new System.Drawing.Point(0, 365);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Padding = new System.Windows.Forms.Padding(8);
            this.btnFavorite.Size = new System.Drawing.Size(212, 65);
            this.btnFavorite.TabIndex = 46;
            this.btnFavorite.Text = "     즐겨 찾기";
            this.btnFavorite.UseVisualStyleBackColor = false;
            // 
            // pnltreenode4
            // 
            this.pnltreenode4.Controls.Add(this.treeView4);
            this.pnltreenode4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltreenode4.Location = new System.Drawing.Point(0, 355);
            this.pnltreenode4.Name = "pnltreenode4";
            this.pnltreenode4.Size = new System.Drawing.Size(212, 10);
            this.pnltreenode4.TabIndex = 45;
            // 
            // treeView4
            // 
            this.treeView4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.treeView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView4.Location = new System.Drawing.Point(0, 0);
            this.treeView4.Name = "treeView4";
            treeNode61.Name = "노드1";
            treeNode61.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode61.Text = "생산요청 관리";
            treeNode62.Name = "노드2";
            treeNode62.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode62.Text = "생산계획 관리";
            treeNode63.Name = "노드3";
            treeNode63.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode63.Text = "시유 작업지시 생성";
            treeNode64.Name = "노드0";
            treeNode64.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode64.Text = "생산작업 관리";
            this.treeView4.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode64});
            this.treeView4.Size = new System.Drawing.Size(212, 10);
            this.treeView4.TabIndex = 0;
            this.treeView4.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView4_NodeMouseDoubleClick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnProduce);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 290);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(212, 65);
            this.panel7.TabIndex = 44;
            // 
            // btnProduce
            // 
            this.btnProduce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProduce.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProduce.ForeColor = System.Drawing.Color.White;
            this.btnProduce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduce.ImageIndex = 4;
            this.btnProduce.ImageList = this.imageListLeftSideBar;
            this.btnProduce.Location = new System.Drawing.Point(0, 0);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Padding = new System.Windows.Forms.Padding(8);
            this.btnProduce.Size = new System.Drawing.Size(212, 65);
            this.btnProduce.TabIndex = 0;
            this.btnProduce.Text = "     생산 관리";
            this.btnProduce.UseVisualStyleBackColor = false;
            this.btnProduce.Click += new System.EventHandler(this.btnProduce_Click);
            // 
            // pnltreenode3
            // 
            this.pnltreenode3.Controls.Add(this.treeView3);
            this.pnltreenode3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltreenode3.Location = new System.Drawing.Point(0, 280);
            this.pnltreenode3.Name = "pnltreenode3";
            this.pnltreenode3.Size = new System.Drawing.Size(212, 10);
            this.pnltreenode3.TabIndex = 43;
            // 
            // treeView3
            // 
            this.treeView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.treeView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView3.ItemHeight = 30;
            this.treeView3.Location = new System.Drawing.Point(0, 0);
            this.treeView3.Name = "treeView3";
            treeNode65.Name = "노드1";
            treeNode65.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode65.Text = "작업지시 생성 및 마감";
            treeNode66.Name = "노드7";
            treeNode66.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode66.Text = "시간대별 실적 조회";
            treeNode67.Name = "노드8";
            treeNode67.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode67.Text = "작업지시 현황";
            treeNode68.Name = "노드0";
            treeNode68.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode68.Text = "작업지시 관리";
            treeNode69.Name = "노드3";
            treeNode69.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode69.Text = "비가동 내역";
            treeNode70.Name = "노드2";
            treeNode70.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold);
            treeNode70.Text = "실적 관리";
            treeNode71.Name = "노드6";
            treeNode71.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode71.Text = "일별 생산 현황";
            treeNode72.Name = "노드5";
            treeNode72.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold);
            treeNode72.Text = "분석 관리";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode68,
            treeNode70,
            treeNode72});
            this.treeView3.Size = new System.Drawing.Size(212, 10);
            this.treeView3.TabIndex = 0;
            this.treeView3.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView3_NodeMouseDoubleClick);
            // 
            // pnlBig3
            // 
            this.pnlBig3.Controls.Add(this.btnProcess);
            this.pnlBig3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBig3.Location = new System.Drawing.Point(0, 215);
            this.pnlBig3.Name = "pnlBig3";
            this.pnlBig3.Size = new System.Drawing.Size(212, 65);
            this.pnlBig3.TabIndex = 42;
            // 
            // btnProcess
            // 
            this.btnProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcess.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.ImageIndex = 3;
            this.btnProcess.ImageList = this.imageListLeftSideBar;
            this.btnProcess.Location = new System.Drawing.Point(0, 0);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Padding = new System.Windows.Forms.Padding(8);
            this.btnProcess.Size = new System.Drawing.Size(212, 65);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "      공정 관리";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // pnltreenode2
            // 
            this.pnltreenode2.Controls.Add(this.treeView2);
            this.pnltreenode2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltreenode2.Location = new System.Drawing.Point(0, 205);
            this.pnltreenode2.Name = "pnltreenode2";
            this.pnltreenode2.Size = new System.Drawing.Size(212, 10);
            this.pnltreenode2.TabIndex = 41;
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView2.ItemHeight = 30;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            treeNode73.Name = "노드3";
            treeNode73.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode73.Text = "공정정보";
            treeNode74.Name = "노드4";
            treeNode74.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode74.Text = "작업장정보";
            treeNode75.Name = "노드0";
            treeNode75.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode75.Text = "조직 관리";
            treeNode76.Name = "노드6";
            treeNode76.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode76.Text = "품목정보";
            treeNode77.Name = "노드5";
            treeNode77.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold);
            treeNode77.Text = "품목 관리";
            treeNode78.Name = "노드8";
            treeNode78.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode78.Text = "사용자 정의 관리";
            treeNode79.Name = "노드9";
            treeNode79.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode79.Text = "불량현상 대분류코드";
            treeNode80.Name = "노드3";
            treeNode80.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode80.Text = "불량현상 상세분류코드";
            treeNode81.Name = "노드10";
            treeNode81.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode81.Text = "비가동 대분류코드";
            treeNode82.Name = "노드0";
            treeNode82.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode82.Text = "비가동 상세분류코드";
            treeNode83.Name = "노드7";
            treeNode83.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold);
            treeNode83.Text = "표준 관리";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode75,
            treeNode77,
            treeNode83});
            this.treeView2.Size = new System.Drawing.Size(212, 10);
            this.treeView2.TabIndex = 0;
            this.treeView2.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView2_NodeMouseDoubleClick);
            // 
            // pnlBig2
            // 
            this.pnlBig2.Controls.Add(this.btnBasic);
            this.pnlBig2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBig2.Location = new System.Drawing.Point(0, 140);
            this.pnlBig2.Name = "pnlBig2";
            this.pnlBig2.Size = new System.Drawing.Size(212, 65);
            this.pnlBig2.TabIndex = 40;
            // 
            // btnBasic
            // 
            this.btnBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBasic.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBasic.ForeColor = System.Drawing.Color.White;
            this.btnBasic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasic.ImageKey = "- (4).png";
            this.btnBasic.ImageList = this.imageListLeftSideBar;
            this.btnBasic.Location = new System.Drawing.Point(0, 0);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Padding = new System.Windows.Forms.Padding(8);
            this.btnBasic.Size = new System.Drawing.Size(212, 65);
            this.btnBasic.TabIndex = 0;
            this.btnBasic.Text = "      기준 정보";
            this.btnBasic.UseVisualStyleBackColor = false;
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // pnltreenode1
            // 
            this.pnltreenode1.Controls.Add(this.treeView1);
            this.pnltreenode1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltreenode1.Location = new System.Drawing.Point(0, 130);
            this.pnltreenode1.Name = "pnltreenode1";
            this.pnltreenode1.Size = new System.Drawing.Size(212, 10);
            this.pnltreenode1.TabIndex = 39;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode84.Name = "node1";
            treeNode84.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode84.Tag = "0";
            treeNode84.Text = "사용자 그룹코드";
            treeNode85.Name = "노드0";
            treeNode85.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode85.Text = "사용자 권한설정";
            treeNode86.Name = "노드2";
            treeNode86.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode86.Tag = "1";
            treeNode86.Text = "사용자 관리";
            treeNode87.Checked = true;
            treeNode87.Name = "노드0";
            treeNode87.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode87.Text = "시스템 설정관리";
            treeNode88.Name = "노드4";
            treeNode88.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode88.Tag = "2";
            treeNode88.Text = "시스템 코드 관리";
            treeNode89.Name = "노드5";
            treeNode89.NodeFont = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            treeNode89.Tag = "3";
            treeNode89.Text = "즐겨찾기및 화면관리";
            treeNode90.Checked = true;
            treeNode90.ForeColor = System.Drawing.Color.Black;
            treeNode90.Name = "노드3";
            treeNode90.NodeFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold);
            treeNode90.SelectedImageIndex = -2;
            treeNode90.Text = "시스템 운영관리";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode87,
            treeNode90});
            this.treeView1.Size = new System.Drawing.Size(212, 10);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // pnlBig1
            // 
            this.pnlBig1.Controls.Add(this.btnsystem);
            this.pnlBig1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBig1.Location = new System.Drawing.Point(0, 65);
            this.pnlBig1.Name = "pnlBig1";
            this.pnlBig1.Size = new System.Drawing.Size(212, 65);
            this.pnlBig1.TabIndex = 38;
            // 
            // btnsystem
            // 
            this.btnsystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsystem.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnsystem.ForeColor = System.Drawing.Color.White;
            this.btnsystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsystem.ImageIndex = 1;
            this.btnsystem.ImageList = this.imageListLeftSideBar;
            this.btnsystem.Location = new System.Drawing.Point(0, 0);
            this.btnsystem.Name = "btnsystem";
            this.btnsystem.Padding = new System.Windows.Forms.Padding(8);
            this.btnsystem.Size = new System.Drawing.Size(212, 65);
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
            this.btnMenu.ImageList = this.imageListLeftSideBar;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(8);
            this.btnMenu.Size = new System.Drawing.Size(212, 65);
            this.btnMenu.TabIndex = 37;
            this.btnMenu.Text = "     홈";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.chkHide);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 757);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(212, 35);
            this.panel6.TabIndex = 47;
            // 
            // chkHide
            // 
            this.chkHide.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.chkHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkHide.FlatAppearance.BorderSize = 0;
            this.chkHide.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkHide.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkHide.ForeColor = System.Drawing.Color.Black;
            this.chkHide.Location = new System.Drawing.Point(0, 0);
            this.chkHide.Name = "chkHide";
            this.chkHide.Size = new System.Drawing.Size(208, 31);
            this.chkHide.TabIndex = 26;
            this.chkHide.Text = "<";
            this.chkHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHide.UseVisualStyleBackColor = false;
            this.chkHide.CheckedChanged += new System.EventHandler(this.chkHide_CheckedChanged);
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripDate,
            this.tStripTime,
            this.tsBtnLogOut,
            this.tStripName,
            this.tStripDept});
            this.toolStrip3.Location = new System.Drawing.Point(212, 868);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1123, 35);
            this.toolStrip3.TabIndex = 39;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tStripDate
            // 
            this.tStripDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.tStripDate.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripDate.ForeColor = System.Drawing.Color.White;
            this.tStripDate.Margin = new System.Windows.Forms.Padding(5);
            this.tStripDate.Name = "tStripDate";
            this.tStripDate.Size = new System.Drawing.Size(35, 25);
            this.tStripDate.Text = "Date";
            // 
            // tStripTime
            // 
            this.tStripTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.tStripTime.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripTime.ForeColor = System.Drawing.Color.White;
            this.tStripTime.Margin = new System.Windows.Forms.Padding(5);
            this.tStripTime.Name = "tStripTime";
            this.tStripTime.Size = new System.Drawing.Size(36, 25);
            this.tStripTime.Text = "Time";
            // 
            // tsBtnLogOut
            // 
            this.tsBtnLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnLogOut.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnLogOut.ForeColor = System.Drawing.Color.White;
            this.tsBtnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLogOut.Image")));
            this.tsBtnLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLogOut.Margin = new System.Windows.Forms.Padding(5);
            this.tsBtnLogOut.Name = "tsBtnLogOut";
            this.tsBtnLogOut.Size = new System.Drawing.Size(79, 25);
            this.tsBtnLogOut.Text = "로그아웃";
            this.tsBtnLogOut.Click += new System.EventHandler(this.tsBtnLogOut_Click);
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
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(212, 111);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 33);
            this.tabControl1.TabIndex = 38;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1335, 903);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnltreenode4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnltreenode3.ResumeLayout(false);
            this.pnlBig3.ResumeLayout(false);
            this.pnltreenode2.ResumeLayout(false);
            this.pnlBig2.ResumeLayout(false);
            this.pnltreenode1.ResumeLayout(false);
            this.pnlBig1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ImageList imageList64;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripButton tsBtnSetting;
        private System.Windows.Forms.ToolStripButton tsBtnFavorite;
        private System.Windows.Forms.ImageList imageListLeftSideBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Controls.ccTabControl tabControl1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel tStripDate;
        private System.Windows.Forms.ToolStripLabel tStripTime;
        private System.Windows.Forms.ToolStripButton tsBtnLogOut;
        private System.Windows.Forms.ToolStripLabel tStripName;
        private System.Windows.Forms.ToolStripLabel tStripDept;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Panel pnltreenode4;
        private System.Windows.Forms.TreeView treeView4;
        private System.Windows.Forms.Panel panel7;
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox chkHide;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

