﻿namespace Mesen.GUI.Debugger
{
	partial class frmMemoryViewer
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
			if(disposing && (components != null)) {
				components.Dispose();
			}
			if(this._notifListener != null) {
				this._notifListener.Dispose();
				this._notifListener = null;
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
			this.ctrlHexViewer = new Mesen.GUI.Debugger.Controls.ctrlHexViewer();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.lblViewMemoryType = new System.Windows.Forms.Label();
			this.cboMemoryType = new System.Windows.Forms.ComboBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuIncreaseFontSize = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDecreaseFontSize = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuResetFontSize = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuAutoRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFindNext = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFindPrev = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuGoTo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnImport = new System.Windows.Forms.ToolStripButton();
			this.btnExport = new System.Windows.Forms.ToolStripButton();
			this.flowLayoutPanel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ctrlHexViewer
			// 
			this.ctrlHexViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctrlHexViewer.Location = new System.Drawing.Point(0, 49);
			this.ctrlHexViewer.Name = "ctrlHexViewer";
			this.ctrlHexViewer.Size = new System.Drawing.Size(461, 378);
			this.ctrlHexViewer.TabIndex = 0;
			this.ctrlHexViewer.ColumnCountChanged += new System.EventHandler(this.ctrlHexViewer_ColumnCountChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.lblViewMemoryType);
			this.flowLayoutPanel1.Controls.Add(this.cboMemoryType);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 49);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(167, 27);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// lblViewMemoryType
			// 
			this.lblViewMemoryType.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblViewMemoryType.AutoSize = true;
			this.lblViewMemoryType.Location = new System.Drawing.Point(3, 7);
			this.lblViewMemoryType.Name = "lblViewMemoryType";
			this.lblViewMemoryType.Size = new System.Drawing.Size(33, 13);
			this.lblViewMemoryType.TabIndex = 0;
			this.lblViewMemoryType.Text = "View:";
			// 
			// cboMemoryType
			// 
			this.cboMemoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMemoryType.FormattingEnabled = true;
			this.cboMemoryType.Items.AddRange(new object[] {
            "CPU Memory",
            "PPU Memory",
            "Palette Memory",
            "OAM Memory",
            "Secondary OAM Memory",
            "PRG ROM",
            "CHR ROM",
            "CHR RAM",
            "Work RAM",
            "Save RAM",
            "NES RAM"});
			this.cboMemoryType.Location = new System.Drawing.Point(42, 3);
			this.cboMemoryType.Name = "cboMemoryType";
			this.cboMemoryType.Size = new System.Drawing.Size(121, 21);
			this.cboMemoryType.TabIndex = 1;
			this.cboMemoryType.SelectedIndexChanged += new System.EventHandler(this.cboMemoryType_SelectedIndexChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuView,
            this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(461, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImport,
            this.mnuExport,
            this.toolStripMenuItem3,
            this.mnuClose});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// mnuImport
			// 
			this.mnuImport.Name = "mnuImport";
			this.mnuImport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.mnuImport.Size = new System.Drawing.Size(153, 22);
			this.mnuImport.Text = "Import";
			this.mnuImport.Click += new System.EventHandler(this.mnuImport_Click);
			// 
			// mnuExport
			// 
			this.mnuExport.Name = "mnuExport";
			this.mnuExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.mnuExport.Size = new System.Drawing.Size(153, 22);
			this.mnuExport.Text = "Export";
			this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(150, 6);
			// 
			// mnuClose
			// 
			this.mnuClose.Name = "mnuClose";
			this.mnuClose.Size = new System.Drawing.Size(153, 22);
			this.mnuClose.Text = "Close";
			this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
			// 
			// mnuView
			// 
			this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefresh,
            this.fontSizeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.mnuAutoRefresh});
			this.mnuView.Name = "mnuView";
			this.mnuView.Size = new System.Drawing.Size(44, 20);
			this.mnuView.Text = "View";
			// 
			// mnuRefresh
			// 
			this.mnuRefresh.Name = "mnuRefresh";
			this.mnuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.mnuRefresh.Size = new System.Drawing.Size(141, 22);
			this.mnuRefresh.Text = "Refresh";
			this.mnuRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
			// 
			// fontSizeToolStripMenuItem
			// 
			this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIncreaseFontSize,
            this.mnuDecreaseFontSize,
            this.mnuResetFontSize});
			this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
			this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.fontSizeToolStripMenuItem.Text = "Text Size";
			// 
			// mnuIncreaseFontSize
			// 
			this.mnuIncreaseFontSize.Name = "mnuIncreaseFontSize";
			this.mnuIncreaseFontSize.ShortcutKeyDisplayString = "Ctrl++";
			this.mnuIncreaseFontSize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
			this.mnuIncreaseFontSize.Size = new System.Drawing.Size(197, 22);
			this.mnuIncreaseFontSize.Text = "Increase";
			this.mnuIncreaseFontSize.Click += new System.EventHandler(this.mnuIncreaseFontSize_Click);
			// 
			// mnuDecreaseFontSize
			// 
			this.mnuDecreaseFontSize.Name = "mnuDecreaseFontSize";
			this.mnuDecreaseFontSize.ShortcutKeyDisplayString = "Ctrl+-";
			this.mnuDecreaseFontSize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
			this.mnuDecreaseFontSize.Size = new System.Drawing.Size(197, 22);
			this.mnuDecreaseFontSize.Text = "Decrease";
			this.mnuDecreaseFontSize.Click += new System.EventHandler(this.mnuDecreaseFontSize_Click);
			// 
			// mnuResetFontSize
			// 
			this.mnuResetFontSize.Name = "mnuResetFontSize";
			this.mnuResetFontSize.ShortcutKeyDisplayString = "Ctrl+0";
			this.mnuResetFontSize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
			this.mnuResetFontSize.Size = new System.Drawing.Size(197, 22);
			this.mnuResetFontSize.Text = "Reset to Default";
			this.mnuResetFontSize.Click += new System.EventHandler(this.mnuResetFontSize_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 6);
			// 
			// mnuAutoRefresh
			// 
			this.mnuAutoRefresh.Checked = true;
			this.mnuAutoRefresh.CheckOnClick = true;
			this.mnuAutoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuAutoRefresh.Name = "mnuAutoRefresh";
			this.mnuAutoRefresh.Size = new System.Drawing.Size(141, 22);
			this.mnuAutoRefresh.Text = "Auto-refresh";
			this.mnuAutoRefresh.Click += new System.EventHandler(this.mnuAutoRefresh_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFind,
            this.mnuFindNext,
            this.mnuFindPrev,
            this.mnuGoTo});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
			this.toolStripMenuItem1.Text = "Search";
			// 
			// mnuFind
			// 
			this.mnuFind.Name = "mnuFind";
			this.mnuFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.mnuFind.Size = new System.Drawing.Size(196, 22);
			this.mnuFind.Text = "Find...";
			this.mnuFind.Click += new System.EventHandler(this.mnuFind_Click);
			// 
			// mnuFindNext
			// 
			this.mnuFindNext.Name = "mnuFindNext";
			this.mnuFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.mnuFindNext.Size = new System.Drawing.Size(196, 22);
			this.mnuFindNext.Text = "Find Next";
			this.mnuFindNext.Click += new System.EventHandler(this.mnuFindNext_Click);
			// 
			// mnuFindPrev
			// 
			this.mnuFindPrev.Name = "mnuFindPrev";
			this.mnuFindPrev.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
			this.mnuFindPrev.Size = new System.Drawing.Size(196, 22);
			this.mnuFindPrev.Text = "Find Previous";
			this.mnuFindPrev.Click += new System.EventHandler(this.mnuFindPrev_Click);
			// 
			// mnuGoTo
			// 
			this.mnuGoTo.Name = "mnuGoTo";
			this.mnuGoTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.mnuGoTo.Size = new System.Drawing.Size(196, 22);
			this.mnuGoTo.Text = "Go To...";
			this.mnuGoTo.Click += new System.EventHandler(this.mnuGoTo_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImport,
            this.btnExport});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(461, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnImport
			// 
			this.btnImport.Image = global::Mesen.GUI.Properties.Resources.Import;
			this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(63, 22);
			this.btnImport.Text = "Import";
			this.btnImport.Click += new System.EventHandler(this.mnuImport_Click);
			// 
			// btnExport
			// 
			this.btnExport.Image = global::Mesen.GUI.Properties.Resources.Export;
			this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(60, 22);
			this.btnExport.Text = "Export";
			this.btnExport.Click += new System.EventHandler(this.mnuExport_Click);
			// 
			// frmMemoryViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 427);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.ctrlHexViewer);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(477, 465);
			this.Name = "frmMemoryViewer";
			this.Text = "Memory Viewer";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Controls.ctrlHexViewer ctrlHexViewer;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label lblViewMemoryType;
		private System.Windows.Forms.ComboBox cboMemoryType;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuFind;
		private System.Windows.Forms.ToolStripMenuItem mnuFindNext;
		private System.Windows.Forms.ToolStripMenuItem mnuFindPrev;
		private System.Windows.Forms.ToolStripMenuItem mnuGoTo;
		private System.Windows.Forms.ToolStripMenuItem mnuView;
		private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
		private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuIncreaseFontSize;
		private System.Windows.Forms.ToolStripMenuItem mnuDecreaseFontSize;
		private System.Windows.Forms.ToolStripMenuItem mnuResetFontSize;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuClose;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem mnuAutoRefresh;
		private System.Windows.Forms.ToolStripMenuItem mnuImport;
		private System.Windows.Forms.ToolStripMenuItem mnuExport;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnImport;
		private System.Windows.Forms.ToolStripButton btnExport;
	}
}