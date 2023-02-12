namespace cswtool
{
    partial class cswEdit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cswOpen = new System.Windows.Forms.OpenFileDialog();
            this.bctOpen = new System.Windows.Forms.OpenFileDialog();
            this.cswSaveAs = new System.Windows.Forms.SaveFileDialog();
            this.bctSaveAs = new System.Windows.Forms.SaveFileDialog();
            this.soundList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.wavSaveAs = new System.Windows.Forms.SaveFileDialog();
            this.btnReplace = new System.Windows.Forms.Button();
            this.Sound = new System.Windows.Forms.Label();
            this.SoundName = new System.Windows.Forms.Label();
            this.soundNameEdit = new System.Windows.Forms.TextBox();
            this.sampleCount = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.loopText = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.wavOpen = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(523, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programInfoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // programInfoToolStripMenuItem
            // 
            this.programInfoToolStripMenuItem.Name = "programInfoToolStripMenuItem";
            this.programInfoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.programInfoToolStripMenuItem.Text = "Program Info";
            this.programInfoToolStripMenuItem.Click += new System.EventHandler(this.programInfoToolStripMenuItem_Click);
            // 
            // cswOpen
            // 
            this.cswOpen.Filter = "CSW File (*.csw)|*.csw|All files (*.*)|*.*";
            this.cswOpen.Title = "Open CSW";
            // 
            // bctOpen
            // 
            this.bctOpen.Filter = "BCT File (*.bct)|*.bct|All files (*.*)|*.*";
            this.bctOpen.Title = "Open BCT";
            this.bctOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.bctOpen_FileOk);
            // 
            // cswSaveAs
            // 
            this.cswSaveAs.Filter = "CSW File (*.csw)|*.csw|All files (*.*)|*.*";
            this.cswSaveAs.Title = "Save CSW as";
            // 
            // bctSaveAs
            // 
            this.bctSaveAs.Filter = "BCT File (*.bct)|*.bct|All files (*.*)|*.*";
            this.bctSaveAs.Title = "Save BCT as";
            this.bctSaveAs.FileOk += new System.ComponentModel.CancelEventHandler(this.bctSaveAs_FileOk);
            // 
            // soundList
            // 
            this.soundList.FormattingEnabled = true;
            this.soundList.ItemHeight = 15;
            this.soundList.Location = new System.Drawing.Point(0, 27);
            this.soundList.Name = "soundList";
            this.soundList.Size = new System.Drawing.Size(233, 454);
            this.soundList.TabIndex = 1;
            this.soundList.SelectedIndexChanged += new System.EventHandler(this.soundList_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 489);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(79, 489);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(72, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(239, 458);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(272, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play Sound";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(239, 429);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(272, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // wavSaveAs
            // 
            this.wavSaveAs.Filter = "WAV File (*.wav)|*.wav|All files (*.*)|*.*";
            this.wavSaveAs.Title = "Save WAV as";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(239, 400);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(272, 23);
            this.btnReplace.TabIndex = 6;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // Sound
            // 
            this.Sound.AutoSize = true;
            this.Sound.Location = new System.Drawing.Point(239, 27);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(41, 15);
            this.Sound.TabIndex = 7;
            this.Sound.Text = "Sound";
            // 
            // SoundName
            // 
            this.SoundName.AutoSize = true;
            this.SoundName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SoundName.Location = new System.Drawing.Point(239, 51);
            this.SoundName.Name = "SoundName";
            this.SoundName.Size = new System.Drawing.Size(182, 25);
            this.SoundName.TabIndex = 8;
            this.SoundName.Text = "No Sound Selected";
            // 
            // soundNameEdit
            // 
            this.soundNameEdit.Location = new System.Drawing.Point(239, 79);
            this.soundNameEdit.Name = "soundNameEdit";
            this.soundNameEdit.Size = new System.Drawing.Size(272, 23);
            this.soundNameEdit.TabIndex = 9;
            // 
            // sampleCount
            // 
            this.sampleCount.AutoSize = true;
            this.sampleCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sampleCount.Location = new System.Drawing.Point(239, 120);
            this.sampleCount.Name = "sampleCount";
            this.sampleCount.Size = new System.Drawing.Size(98, 25);
            this.sampleCount.TabIndex = 10;
            this.sampleCount.Text = "0 samples";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(157, 489);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // loopText
            // 
            this.loopText.AutoSize = true;
            this.loopText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loopText.Location = new System.Drawing.Point(239, 207);
            this.loopText.Name = "loopText";
            this.loopText.Size = new System.Drawing.Size(90, 25);
            this.loopText.TabIndex = 12;
            this.loopText.Text = "No Loop";
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorText.ForeColor = System.Drawing.Color.IndianRed;
            this.errorText.Location = new System.Drawing.Point(239, 359);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(281, 30);
            this.errorText.TabIndex = 13;
            this.errorText.Text = "Sounds with < 400 samples will be inaudible.\r\nBut only in the tool. This doesn\'t " +
    "affect the game.";
            this.errorText.Visible = false;
            // 
            // wavOpen
            // 
            this.wavOpen.FileName = "WAV";
            this.wavOpen.Filter = "WAV File (*.wav)|*.wav|All files (*.*)|*.*";
            this.wavOpen.Title = "Open WAV";
            // 
            // cswEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 524);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.loopText);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.sampleCount);
            this.Controls.Add(this.soundNameEdit);
            this.Controls.Add(this.SoundName);
            this.Controls.Add(this.Sound);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.soundList);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "cswEdit";
            this.Text = "cswEdit";
            this.Load += new System.EventHandler(this.cswEdit_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private OpenFileDialog cswOpen;
        private OpenFileDialog bctOpen;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private SaveFileDialog cswSaveAs;
        private SaveFileDialog bctSaveAs;
        private ListBox soundList;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnPlay;
        private Button btnExport;
        private SaveFileDialog wavSaveAs;
        private Button btnReplace;
        private Label Sound;
        private Label SoundName;
        private TextBox soundNameEdit;
        private Label sampleCount;
        private Button btnRefresh;
        private Label loopText;
        private Label errorText;
        private OpenFileDialog wavOpen;
        private ToolStripMenuItem programInfoToolStripMenuItem;
    }
}