namespace INIManager
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCatFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddKeyValue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatMove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tbtnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.tbtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnAddHeader = new System.Windows.Forms.ToolStripButton();
            this.tbtnAddKeyValue = new System.Windows.Forms.ToolStripButton();
            this.tbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tbtnMoveDown = new System.Windows.Forms.ToolStripButton();
            this.key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statIndexTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.statIndex = new System.Windows.Forms.ToolStripStatusLabel();
            this.statProgressTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.statProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.workerOpenFile = new System.ComponentModel.BackgroundWorker();
            this.workerSaveFile = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCatFile,
            this.menuCatEdit,
            this.menuCatAdd,
            this.menuCatMove,
            this.menuCatAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCatFile
            // 
            this.menuCatFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuSave,
            this.menuSaveAs,
            this.menuClose,
            this.toolStripSeparator1,
            this.menuExit});
            this.menuCatFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuCatFile.Name = "menuCatFile";
            this.menuCatFile.Size = new System.Drawing.Size(37, 20);
            this.menuCatFile.Text = "File";
            // 
            // menuOpen
            // 
            this.menuOpen.Image = global::INIManager.Properties.Resources.OpenFile_16x;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(155, 22);
            this.menuOpen.Text = "Open...";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Image = global::INIManager.Properties.Resources.Save_16x;
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(155, 22);
            this.menuSave.Text = "Save...";
            this.menuSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Image = global::INIManager.Properties.Resources.SaveAs_16x;
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(155, 22);
            this.menuSaveAs.Text = "Save As...";
            this.menuSaveAs.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // menuClose
            // 
            this.menuClose.Image = global::INIManager.Properties.Resources.CloseDocument_16x;
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(155, 22);
            this.menuClose.Text = "Close File";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(155, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuCatEdit
            // 
            this.menuCatEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUndo,
            this.menuRedo,
            this.menuDelete});
            this.menuCatEdit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuCatEdit.Name = "menuCatEdit";
            this.menuCatEdit.Size = new System.Drawing.Size(39, 20);
            this.menuCatEdit.Text = "Edit";
            // 
            // menuUndo
            // 
            this.menuUndo.Image = global::INIManager.Properties.Resources.Undo_16x;
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuUndo.Size = new System.Drawing.Size(152, 22);
            this.menuUndo.Text = "Undo";
            // 
            // menuRedo
            // 
            this.menuRedo.Image = global::INIManager.Properties.Resources.Redo_16x;
            this.menuRedo.Name = "menuRedo";
            this.menuRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuRedo.Size = new System.Drawing.Size(152, 22);
            this.menuRedo.Text = "Redo";
            // 
            // menuDelete
            // 
            this.menuDelete.Image = global::INIManager.Properties.Resources.DeleteCell_16x;
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuDelete.Size = new System.Drawing.Size(152, 22);
            this.menuDelete.Text = "Delete";
            this.menuDelete.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // menuCatAdd
            // 
            this.menuCatAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddHeader,
            this.menuAddKeyValue});
            this.menuCatAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuCatAdd.Name = "menuCatAdd";
            this.menuCatAdd.Size = new System.Drawing.Size(41, 20);
            this.menuCatAdd.Text = "Add";
            // 
            // menuAddHeader
            // 
            this.menuAddHeader.Image = global::INIManager.Properties.Resources.AddParameter_16x;
            this.menuAddHeader.Name = "menuAddHeader";
            this.menuAddHeader.Size = new System.Drawing.Size(152, 22);
            this.menuAddHeader.Text = "Header";
            this.menuAddHeader.Click += new System.EventHandler(this.menuAddHeader_Click);
            // 
            // menuAddKeyValue
            // 
            this.menuAddKeyValue.Image = global::INIManager.Properties.Resources.AddRow_16x;
            this.menuAddKeyValue.Name = "menuAddKeyValue";
            this.menuAddKeyValue.Size = new System.Drawing.Size(152, 22);
            this.menuAddKeyValue.Text = "Key/Value";
            this.menuAddKeyValue.Click += new System.EventHandler(this.menuAddKeyValue_Click);
            // 
            // menuCatMove
            // 
            this.menuCatMove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMoveUp,
            this.menuMoveDown});
            this.menuCatMove.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuCatMove.Name = "menuCatMove";
            this.menuCatMove.Size = new System.Drawing.Size(49, 20);
            this.menuCatMove.Text = "Move";
            // 
            // menuMoveUp
            // 
            this.menuMoveUp.Image = global::INIManager.Properties.Resources.Upload_16x;
            this.menuMoveUp.Name = "menuMoveUp";
            this.menuMoveUp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.menuMoveUp.Size = new System.Drawing.Size(170, 22);
            this.menuMoveUp.Text = "Up";
            this.menuMoveUp.Click += new System.EventHandler(this.menuMoveUp_Click);
            // 
            // menuMoveDown
            // 
            this.menuMoveDown.Image = global::INIManager.Properties.Resources.Download_16x;
            this.menuMoveDown.Name = "menuMoveDown";
            this.menuMoveDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.menuMoveDown.Size = new System.Drawing.Size(170, 22);
            this.menuMoveDown.Text = "Down";
            this.menuMoveDown.Click += new System.EventHandler(this.menuMoveDown_Click);
            // 
            // menuCatAbout
            // 
            this.menuCatAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVersion});
            this.menuCatAbout.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuCatAbout.Name = "menuCatAbout";
            this.menuCatAbout.Size = new System.Drawing.Size(52, 20);
            this.menuCatAbout.Text = "About";
            // 
            // menuVersion
            // 
            this.menuVersion.Name = "menuVersion";
            this.menuVersion.Size = new System.Drawing.Size(152, 22);
            this.menuVersion.Text = "Version";
            this.menuVersion.Click += new System.EventHandler(this.menuVersion_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnOpen,
            this.tbtnSave,
            this.tbtnSaveAs,
            this.tbtnClose,
            this.toolStripSeparator2,
            this.tbtnAddHeader,
            this.tbtnAddKeyValue,
            this.tbtnDelete,
            this.toolStripSeparator3,
            this.tbtnMoveUp,
            this.tbtnMoveDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnOpen
            // 
            this.tbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnOpen.Image = global::INIManager.Properties.Resources.OpenFile_16x;
            this.tbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOpen.Name = "tbtnOpen";
            this.tbtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tbtnOpen.Text = "Open...";
            this.tbtnOpen.Click += new System.EventHandler(this.tbtnOpen_Click);
            // 
            // tbtnSave
            // 
            this.tbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSave.Image = global::INIManager.Properties.Resources.Save_16x;
            this.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tbtnSave.Text = "toolStripButton2";
            this.tbtnSave.Click += new System.EventHandler(this.tbtnSave_Click);
            // 
            // tbtnSaveAs
            // 
            this.tbtnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSaveAs.Image = global::INIManager.Properties.Resources.SaveAs_16x;
            this.tbtnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSaveAs.Name = "tbtnSaveAs";
            this.tbtnSaveAs.Size = new System.Drawing.Size(23, 22);
            this.tbtnSaveAs.Text = "toolStripButton1";
            this.tbtnSaveAs.Click += new System.EventHandler(this.tbtnSaveAs_Click);
            // 
            // tbtnClose
            // 
            this.tbtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnClose.Image = global::INIManager.Properties.Resources.CloseDocument_16x;
            this.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnClose.Name = "tbtnClose";
            this.tbtnClose.Size = new System.Drawing.Size(23, 22);
            this.tbtnClose.Text = "toolStripButton3";
            this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnAddHeader
            // 
            this.tbtnAddHeader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddHeader.Image = global::INIManager.Properties.Resources.AddParameter_16x;
            this.tbtnAddHeader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddHeader.Name = "tbtnAddHeader";
            this.tbtnAddHeader.Size = new System.Drawing.Size(23, 22);
            this.tbtnAddHeader.Text = "toolStripButton1";
            this.tbtnAddHeader.Click += new System.EventHandler(this.tbtnAddHeader_Click);
            // 
            // tbtnAddKeyValue
            // 
            this.tbtnAddKeyValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddKeyValue.Image = global::INIManager.Properties.Resources.AddRow_16x;
            this.tbtnAddKeyValue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddKeyValue.Name = "tbtnAddKeyValue";
            this.tbtnAddKeyValue.Size = new System.Drawing.Size(23, 22);
            this.tbtnAddKeyValue.Text = "toolStripButton2";
            this.tbtnAddKeyValue.Click += new System.EventHandler(this.tbtnAddKeyValue_Click);
            // 
            // tbtnDelete
            // 
            this.tbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDelete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDelete.Image")));
            this.tbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDelete.Name = "tbtnDelete";
            this.tbtnDelete.Size = new System.Drawing.Size(23, 22);
            this.tbtnDelete.Text = "toolStripButton1";
            this.tbtnDelete.Click += new System.EventHandler(this.tbtnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnMoveUp
            // 
            this.tbtnMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnMoveUp.Image = global::INIManager.Properties.Resources.Upload_16x;
            this.tbtnMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMoveUp.Name = "tbtnMoveUp";
            this.tbtnMoveUp.Size = new System.Drawing.Size(23, 22);
            this.tbtnMoveUp.Text = "toolStripButton4";
            this.tbtnMoveUp.Click += new System.EventHandler(this.tbtnMoveUp_Click);
            // 
            // tbtnMoveDown
            // 
            this.tbtnMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnMoveDown.Image = global::INIManager.Properties.Resources.Download_16x;
            this.tbtnMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMoveDown.Name = "tbtnMoveDown";
            this.tbtnMoveDown.Size = new System.Drawing.Size(23, 22);
            this.tbtnMoveDown.Text = "toolStripButton5";
            this.tbtnMoveDown.Click += new System.EventHandler(this.tbtnMoveDown_Click);
            // 
            // key
            // 
            this.key.Text = "Key";
            // 
            // value
            // 
            this.value.Text = "Value";
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.key,
            this.value});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 49);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(450, 495);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statIndexTitle,
            this.statIndex,
            this.statProgressTitle,
            this.statProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(450, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statIndexTitle
            // 
            this.statIndexTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.statIndexTitle.Name = "statIndexTitle";
            this.statIndexTitle.Size = new System.Drawing.Size(85, 17);
            this.statIndexTitle.Text = "Selected Index:";
            // 
            // statIndex
            // 
            this.statIndex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.statIndex.Name = "statIndex";
            this.statIndex.Size = new System.Drawing.Size(193, 17);
            this.statIndex.Spring = true;
            this.statIndex.Text = "statIndex";
            this.statIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statProgressTitle
            // 
            this.statProgressTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.statProgressTitle.Name = "statProgressTitle";
            this.statProgressTitle.Size = new System.Drawing.Size(55, 17);
            this.statProgressTitle.Text = "Progress:";
            // 
            // statProgressBar
            // 
            this.statProgressBar.Name = "statProgressBar";
            this.statProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // workerOpenFile
            // 
            this.workerOpenFile.WorkerReportsProgress = true;
            this.workerOpenFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerOpenFile_DoWork);
            this.workerOpenFile.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerOpenFile_ProgressChanged);
            this.workerOpenFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerOpenFile_RunWorkerCompleted);
            // 
            // workerSaveFile
            // 
            this.workerSaveFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerSaveFile_DoWork);
            this.workerSaveFile.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerSaveFile_ProgressChanged);
            this.workerSaveFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerSaveFile_RunWorkerCompleted);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 566);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "INI Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCatFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnOpen;
        private System.Windows.Forms.ToolStripMenuItem menuCatAdd;
        private System.Windows.Forms.ToolStripMenuItem menuAddHeader;
        private System.Windows.Forms.ToolStripMenuItem menuAddKeyValue;
        private System.Windows.Forms.ToolStripMenuItem menuCatMove;
        private System.Windows.Forms.ToolStripMenuItem menuMoveUp;
        private System.Windows.Forms.ToolStripMenuItem menuMoveDown;
        private System.Windows.Forms.ToolStripButton tbtnSave;
        private System.Windows.Forms.ToolStripButton tbtnClose;
        private System.Windows.Forms.ToolStripButton tbtnMoveUp;
        private System.Windows.Forms.ToolStripButton tbtnMoveDown;
        private System.Windows.Forms.ColumnHeader key;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker workerOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnAddHeader;
        private System.Windows.Forms.ToolStripButton tbtnAddKeyValue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtnSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuCatAbout;
        private System.Windows.Forms.ToolStripMenuItem menuVersion;
        private System.Windows.Forms.ToolStripStatusLabel statIndex;
        private System.Windows.Forms.ToolStripProgressBar statProgressBar;
        private System.Windows.Forms.ToolStripMenuItem menuCatEdit;
        private System.Windows.Forms.ToolStripMenuItem menuUndo;
        private System.Windows.Forms.ToolStripMenuItem menuRedo;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripButton tbtnDelete;
        private System.Windows.Forms.ToolStripStatusLabel statProgressTitle;
        private System.Windows.Forms.ToolStripStatusLabel statIndexTitle;
        private System.ComponentModel.BackgroundWorker workerSaveFile;
    }
}

