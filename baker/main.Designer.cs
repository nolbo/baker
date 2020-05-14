namespace baker
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.titleBar = new System.Windows.Forms.Panel();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.line0 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_file_closeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_saveAndCloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.line1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_nameSave = new System.Windows.Forms.ToolStripMenuItem();
            this.line2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_compile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_compile_compile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_debug = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_debug_startD = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help_info = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomPnl = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.SplitContainer();
            this.editContainer = new System.Windows.Forms.SplitContainer();
            this.lineBox = new System.Windows.Forms.RichTextBox();
            this.printBox = new System.Windows.Forms.RichTextBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.btn_hide = new System.Windows.Forms.PictureBox();
            this.btn_ctrWiw = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.editBox = new newTextBoxControl.newTextBoxIME();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editContainer)).BeginInit();
            this.editContainer.Panel1.SuspendLayout();
            this.editContainer.Panel2.SuspendLayout();
            this.editContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ctrWiw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.Controls.Add(this.img_logo);
            this.titleBar.Controls.Add(this.menu);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1600, 50);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            // 
            // img_logo
            // 
            this.img_logo.Image = global::baker.Properties.Resources.baker;
            this.img_logo.Location = new System.Drawing.Point(7, 0);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(50, 50);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logo.TabIndex = 6;
            this.img_logo.TabStop = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_edit,
            this.menu_view,
            this.menu_tools,
            this.menu_compile,
            this.menu_debug,
            this.menu_help});
            this.menu.Location = new System.Drawing.Point(59, 9);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(816, 33);
            this.menu.TabIndex = 6;
            this.menu.Text = "menu";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_open,
            this.line0,
            this.menu_file_closeFile,
            this.menu_file_saveAndCloseFile,
            this.line1,
            this.menu_file_save,
            this.menu_file_nameSave,
            this.line2,
            this.menu_file_exit});
            this.menu_file.ForeColor = System.Drawing.Color.White;
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(83, 29);
            this.menu_file.Text = "파일(&F)";
            // 
            // menu_file_open
            // 
            this.menu_file_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menu_file_open.ForeColor = System.Drawing.Color.White;
            this.menu_file_open.Name = "menu_file_open";
            this.menu_file_open.Size = new System.Drawing.Size(304, 34);
            this.menu_file_open.Text = "열기(&O)";
            this.menu_file_open.Click += new System.EventHandler(this.menu_file_open_Click);
            // 
            // line0
            // 
            this.line0.BackColor = System.Drawing.Color.Black;
            this.line0.ForeColor = System.Drawing.Color.Black;
            this.line0.Name = "line0";
            this.line0.Size = new System.Drawing.Size(301, 6);
            // 
            // menu_file_closeFile
            // 
            this.menu_file_closeFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menu_file_closeFile.ForeColor = System.Drawing.Color.White;
            this.menu_file_closeFile.Name = "menu_file_closeFile";
            this.menu_file_closeFile.Size = new System.Drawing.Size(304, 34);
            this.menu_file_closeFile.Text = "파일 닫기(&C)";
            this.menu_file_closeFile.Click += new System.EventHandler(this.menu_file_closeFile_Click);
            // 
            // menu_file_saveAndCloseFile
            // 
            this.menu_file_saveAndCloseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menu_file_saveAndCloseFile.ForeColor = System.Drawing.Color.White;
            this.menu_file_saveAndCloseFile.Name = "menu_file_saveAndCloseFile";
            this.menu_file_saveAndCloseFile.Size = new System.Drawing.Size(304, 34);
            this.menu_file_saveAndCloseFile.Text = "저장하고 파일 닫기";
            this.menu_file_saveAndCloseFile.Click += new System.EventHandler(this.menu_file_saveAndCloseFile_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Black;
            this.line1.ForeColor = System.Drawing.Color.Black;
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(301, 6);
            // 
            // menu_file_save
            // 
            this.menu_file_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menu_file_save.ForeColor = System.Drawing.Color.White;
            this.menu_file_save.Name = "menu_file_save";
            this.menu_file_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menu_file_save.Size = new System.Drawing.Size(304, 34);
            this.menu_file_save.Text = "저장(&S)...";
            this.menu_file_save.Click += new System.EventHandler(this.menu_file_save_Click);
            // 
            // menu_file_nameSave
            // 
            this.menu_file_nameSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menu_file_nameSave.ForeColor = System.Drawing.Color.White;
            this.menu_file_nameSave.Name = "menu_file_nameSave";
            this.menu_file_nameSave.Size = new System.Drawing.Size(304, 34);
            this.menu_file_nameSave.Text = "다른 이름으로 저장(&A)...";
            this.menu_file_nameSave.Click += new System.EventHandler(this.menu_file_nameSave_Click);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.Black;
            this.line2.ForeColor = System.Drawing.Color.Black;
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(301, 6);
            // 
            // menu_file_exit
            // 
            this.menu_file_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menu_file_exit.ForeColor = System.Drawing.Color.White;
            this.menu_file_exit.Name = "menu_file_exit";
            this.menu_file_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menu_file_exit.Size = new System.Drawing.Size(304, 34);
            this.menu_file_exit.Text = "끝내기(&X)";
            this.menu_file_exit.Click += new System.EventHandler(this.menu_file_exit_Click);
            // 
            // menu_edit
            // 
            this.menu_edit.ForeColor = System.Drawing.Color.White;
            this.menu_edit.Name = "menu_edit";
            this.menu_edit.Size = new System.Drawing.Size(83, 29);
            this.menu_edit.Text = "편집(&E)";
            // 
            // menu_view
            // 
            this.menu_view.ForeColor = System.Drawing.Color.White;
            this.menu_view.Name = "menu_view";
            this.menu_view.Size = new System.Drawing.Size(85, 29);
            this.menu_view.Text = "보기(&V)";
            // 
            // menu_tools
            // 
            this.menu_tools.ForeColor = System.Drawing.Color.White;
            this.menu_tools.Name = "menu_tools";
            this.menu_tools.Size = new System.Drawing.Size(84, 29);
            this.menu_tools.Text = "도구(&T)";
            // 
            // menu_compile
            // 
            this.menu_compile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_compile_compile});
            this.menu_compile.ForeColor = System.Drawing.Color.White;
            this.menu_compile.Name = "menu_compile";
            this.menu_compile.Size = new System.Drawing.Size(103, 29);
            this.menu_compile.Text = "컴파일(&C)";
            // 
            // menu_compile_compile
            // 
            this.menu_compile_compile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menu_compile_compile.ForeColor = System.Drawing.Color.White;
            this.menu_compile_compile.Name = "menu_compile_compile";
            this.menu_compile_compile.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.menu_compile_compile.Size = new System.Drawing.Size(280, 34);
            this.menu_compile_compile.Text = "컴파일";
            this.menu_compile_compile.Click += new System.EventHandler(this.menu_compile_compile_Click);
            // 
            // menu_debug
            // 
            this.menu_debug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_debug_startD});
            this.menu_debug.ForeColor = System.Drawing.Color.White;
            this.menu_debug.Name = "menu_debug";
            this.menu_debug.Size = new System.Drawing.Size(85, 29);
            this.menu_debug.Text = "실행(&R)";
            // 
            // menu_debug_startD
            // 
            this.menu_debug_startD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menu_debug_startD.ForeColor = System.Drawing.Color.White;
            this.menu_debug_startD.Name = "menu_debug_startD";
            this.menu_debug_startD.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menu_debug_startD.Size = new System.Drawing.Size(244, 34);
            this.menu_debug_startD.Text = "코드 실행(&R)";
            this.menu_debug_startD.Click += new System.EventHandler(this.menu_debug_startD_Click);
            // 
            // menu_help
            // 
            this.menu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_help_info});
            this.menu_help.ForeColor = System.Drawing.Color.White;
            this.menu_help.Name = "menu_help";
            this.menu_help.Size = new System.Drawing.Size(105, 29);
            this.menu_help.Text = "도움말(&H)";
            // 
            // menu_help_info
            // 
            this.menu_help_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menu_help_info.ForeColor = System.Drawing.Color.White;
            this.menu_help_info.Name = "menu_help_info";
            this.menu_help_info.Size = new System.Drawing.Size(223, 34);
            this.menu_help_info.Text = "Baker 정보(&A)";
            // 
            // bottomPnl
            // 
            this.bottomPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.bottomPnl.Location = new System.Drawing.Point(0, 1097);
            this.bottomPnl.Name = "bottomPnl";
            this.bottomPnl.Size = new System.Drawing.Size(1600, 38);
            this.bottomPnl.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(0, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(72, 35);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "출력";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.BackColor = System.Drawing.Color.Transparent;
            this.container.Location = new System.Drawing.Point(12, 65);
            this.container.Name = "container";
            this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            this.container.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.container.Panel1.Controls.Add(this.editContainer);
            // 
            // container.Panel2
            // 
            this.container.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.container.Panel2.Controls.Add(this.printBox);
            this.container.Panel2.Controls.Add(this.logBox);
            this.container.Panel2.Controls.Add(this.btnPrint);
            this.container.Panel2.Controls.Add(this.btnLog);
            this.container.Size = new System.Drawing.Size(1576, 1032);
            this.container.SplitterDistance = 788;
            this.container.TabIndex = 6;
            // 
            // editContainer
            // 
            this.editContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.editContainer.Font = new System.Drawing.Font("D2Coding", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editContainer.Location = new System.Drawing.Point(0, 0);
            this.editContainer.Name = "editContainer";
            // 
            // editContainer.Panel1
            // 
            this.editContainer.Panel1.Controls.Add(this.lineBox);
            this.editContainer.Panel1MinSize = 30;
            // 
            // editContainer.Panel2
            // 
            this.editContainer.Panel2.Controls.Add(this.editBox);
            this.editContainer.Size = new System.Drawing.Size(1576, 789);
            this.editContainer.SplitterDistance = 53;
            this.editContainer.TabIndex = 0;
            // 
            // lineBox
            // 
            this.lineBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lineBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lineBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lineBox.Font = new System.Drawing.Font("D2Coding", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lineBox.Location = new System.Drawing.Point(0, 19);
            this.lineBox.Name = "lineBox";
            this.lineBox.ReadOnly = true;
            this.lineBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lineBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lineBox.Size = new System.Drawing.Size(50, 770);
            this.lineBox.TabIndex = 2;
            this.lineBox.Text = "";
            // 
            // printBox
            // 
            this.printBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.printBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.printBox.Font = new System.Drawing.Font("D2Coding", 10.5F);
            this.printBox.ForeColor = System.Drawing.Color.White;
            this.printBox.Location = new System.Drawing.Point(0, 34);
            this.printBox.Name = "printBox";
            this.printBox.ReadOnly = true;
            this.printBox.Size = new System.Drawing.Size(1576, 200);
            this.printBox.TabIndex = 1;
            this.printBox.Text = "";
            this.printBox.WordWrap = false;
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.Font = new System.Drawing.Font("D2Coding", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logBox.ForeColor = System.Drawing.Color.White;
            this.logBox.Location = new System.Drawing.Point(0, 34);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(1576, 200);
            this.logBox.TabIndex = 3;
            this.logBox.Text = "";
            this.logBox.WordWrap = false;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Black;
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(78, 3);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(72, 35);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "로그";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "yee.js";
            this.openFile.Filter = "JavaScript 파일 (*.js)|*.js";
            // 
            // saveFile
            // 
            this.saveFile.Filter = "JavaScript 파일 (*.js)|*.js";
            // 
            // btn_hide
            // 
            this.btn_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hide.Image = global::baker.Properties.Resources.hide;
            this.btn_hide.Location = new System.Drawing.Point(1450, 0);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(50, 50);
            this.btn_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_hide.TabIndex = 3;
            this.btn_hide.TabStop = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            this.btn_hide.MouseLeave += new System.EventHandler(this.btn_hide_MouseLeave);
            this.btn_hide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_hide_MouseMove);
            // 
            // btn_ctrWiw
            // 
            this.btn_ctrWiw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ctrWiw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ctrWiw.Image = global::baker.Properties.Resources.fullWiw;
            this.btn_ctrWiw.Location = new System.Drawing.Point(1500, 0);
            this.btn_ctrWiw.Name = "btn_ctrWiw";
            this.btn_ctrWiw.Size = new System.Drawing.Size(50, 50);
            this.btn_ctrWiw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_ctrWiw.TabIndex = 2;
            this.btn_ctrWiw.TabStop = false;
            this.btn_ctrWiw.Click += new System.EventHandler(this.btn_ctrWiw_Click);
            this.btn_ctrWiw.MouseLeave += new System.EventHandler(this.btn_ctrWiw_MouseLeave);
            this.btn_ctrWiw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_ctrWiw_MouseMove);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Image = global::baker.Properties.Resources.exit;
            this.btn_exit.Location = new System.Drawing.Point(1550, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(50, 50);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_exit_MouseMove);
            // 
            // editBox
            // 
            this.editBox.AcceptsTab = true;
            this.editBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.editBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editBox.Font = new System.Drawing.Font("D2Coding", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editBox.ForeColor = System.Drawing.Color.White;
            this.editBox.Location = new System.Drawing.Point(3, 19);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(1516, 770);
            this.editBox.TabIndex = 0;
            this.editBox.TabStop = false;
            this.editBox.Text = "";
            this.editBox.WordWrap = false;
            this.editBox.SelectionChanged += new System.EventHandler(this.editBox_SelectionChanged);
            this.editBox.VScroll += new System.EventHandler(this.editBox_VScroll);
            this.editBox.FontChanged += new System.EventHandler(this.editBox_FontChanged);
            this.editBox.TextChanged += new System.EventHandler(this.editBox_TextChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1600, 1135);
            this.Controls.Add(this.bottomPnl);
            this.Controls.Add(this.container);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_ctrWiw);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.titleBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "main";
            this.Text = "Baker";
            this.Load += new System.EventHandler(this.main_Load);
            this.Resize += new System.EventHandler(this.main_Resize);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.editContainer.Panel1.ResumeLayout(false);
            this.editContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editContainer)).EndInit();
            this.editContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ctrWiw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_ctrWiw;
        private System.Windows.Forms.PictureBox btn_hide;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem menu_edit;
        private System.Windows.Forms.ToolStripMenuItem menu_compile;
        private System.Windows.Forms.ToolStripMenuItem menu_debug;
        private System.Windows.Forms.ToolStripMenuItem menu_compile_compile;
        private System.Windows.Forms.Panel bottomPnl;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.SplitContainer container;
        private System.Windows.Forms.SplitContainer editContainer;
        private System.Windows.Forms.RichTextBox lineBox;
        private System.Windows.Forms.RichTextBox printBox;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.ToolStripMenuItem menu_file_open;
        private System.Windows.Forms.OpenFileDialog openFile;
        public newTextBoxControl.newTextBoxIME editBox;
        private System.Windows.Forms.ToolStripMenuItem menu_file_save;
        private System.Windows.Forms.ToolStripMenuItem menu_file_nameSave;
        private System.Windows.Forms.ToolStripSeparator line1;
        private System.Windows.Forms.ToolStripMenuItem menu_file_exit;
        private System.Windows.Forms.ToolStripSeparator line2;
        private System.Windows.Forms.ToolStripMenuItem menu_debug_startD;
        private System.Windows.Forms.ToolStripMenuItem menu_tools;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
        private System.Windows.Forms.ToolStripMenuItem menu_help_info;
        private System.Windows.Forms.ToolStripMenuItem menu_view;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripSeparator line0;
        private System.Windows.Forms.ToolStripMenuItem menu_file_closeFile;
        private System.Windows.Forms.ToolStripMenuItem menu_file_saveAndCloseFile;
    }
}

