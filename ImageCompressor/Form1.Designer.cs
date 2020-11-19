using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace ImageCompressor
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class Form1 : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolStripMenu = new System.Windows.Forms.ToolStrip();
            this.ListViewFiles = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblStartView = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFilesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFilesProcessed = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRemaining = new System.Windows.Forms.ToolStripStatusLabel();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnAddFiles = new System.Windows.Forms.ToolStripButton();
            this.BtnAddFolder = new System.Windows.Forms.ToolStripDropDownButton();
            this.TopLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WithSubdirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRemoveSelected = new System.Windows.Forms.ToolStripButton();
            this.BtnClearAll = new System.Windows.Forms.ToolStripButton();
            this.BtnOptions = new System.Windows.Forms.ToolStripButton();
            this.BtnStart = new System.Windows.Forms.ToolStripButton();
            this.ToolStripMenu.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripMenu
            // 
            this.ToolStripMenu.BackColor = System.Drawing.Color.White;
            this.ToolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAddFiles,
            this.BtnAddFolder,
            this.BtnRemoveSelected,
            this.BtnClearAll,
            this.BtnOptions,
            this.BtnStart});
            this.ToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.ToolStripMenu.Name = "ToolStripMenu";
            this.ToolStripMenu.Size = new System.Drawing.Size(859, 39);
            this.ToolStripMenu.TabIndex = 0;
            this.ToolStripMenu.Text = "ToolStrip1";
            // 
            // ListViewFiles
            // 
            this.ListViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7});
            this.ListViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewFiles.FullRowSelect = true;
            this.ListViewFiles.Location = new System.Drawing.Point(0, 39);
            this.ListViewFiles.Margin = new System.Windows.Forms.Padding(2);
            this.ListViewFiles.Name = "ListViewFiles";
            this.ListViewFiles.Size = new System.Drawing.Size(859, 422);
            this.ListViewFiles.SmallImageList = this.ImageList1;
            this.ListViewFiles.TabIndex = 1;
            this.ListViewFiles.UseCompatibleStateImageBehavior = false;
            this.ListViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "File";
            this.ColumnHeader1.Width = 109;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Extention";
            this.ColumnHeader2.Width = 135;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Size";
            this.ColumnHeader3.Width = 74;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "New Size";
            this.ColumnHeader4.Width = 104;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Compression %";
            this.ColumnHeader5.Width = 127;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Status";
            this.ColumnHeader6.Width = 88;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Source Path";
            this.ColumnHeader7.Width = 352;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Done.ico");
            // 
            // lblStartView
            // 
            this.lblStartView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStartView.AutoSize = true;
            this.lblStartView.BackColor = System.Drawing.Color.White;
            this.lblStartView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartView.ForeColor = System.Drawing.Color.Silver;
            this.lblStartView.Location = new System.Drawing.Point(288, 228);
            this.lblStartView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartView.Name = "lblStartView";
            this.lblStartView.Size = new System.Drawing.Size(283, 26);
            this.lblStartView.TabIndex = 4;
            this.lblStartView.Text = "Start By Adding Image Files";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.White;
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.lblFilesCount,
            this.ToolStripStatusLabel2,
            this.lblFilesProcessed,
            this.ToolStripStatusLabel3,
            this.lblRemaining});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 461);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(859, 22);
            this.StatusStrip1.TabIndex = 5;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.ToolStripStatusLabel1.Text = "Files Count : ";
            // 
            // lblFilesCount
            // 
            this.lblFilesCount.Name = "lblFilesCount";
            this.lblFilesCount.Size = new System.Drawing.Size(12, 17);
            this.lblFilesCount.Text = "-";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(95, 17);
            this.ToolStripStatusLabel2.Text = "Files Processed : ";
            // 
            // lblFilesProcessed
            // 
            this.lblFilesProcessed.Name = "lblFilesProcessed";
            this.lblFilesProcessed.Size = new System.Drawing.Size(12, 17);
            this.lblFilesProcessed.Text = "-";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(99, 17);
            this.ToolStripStatusLabel3.Text = "Files Remaining  :";
            // 
            // lblRemaining
            // 
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(12, 17);
            this.lblRemaining.Text = "-";
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // BtnAddFiles
            // 
            this.BtnAddFiles.Image = global::ImageCompressor.Properties.Resources._01_Add_Files;
            this.BtnAddFiles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnAddFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAddFiles.Name = "BtnAddFiles";
            this.BtnAddFiles.Size = new System.Drawing.Size(91, 36);
            this.BtnAddFiles.Text = "Add Files";
            this.BtnAddFiles.Click += new System.EventHandler(this.BtnAddFiles_Click);
            // 
            // BtnAddFolder
            // 
            this.BtnAddFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TopLevelToolStripMenuItem,
            this.WithSubdirectoriesToolStripMenuItem});
            this.BtnAddFolder.Image = global::ImageCompressor.Properties.Resources._02_Add_Folder;
            this.BtnAddFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAddFolder.Name = "BtnAddFolder";
            this.BtnAddFolder.Size = new System.Drawing.Size(110, 36);
            this.BtnAddFolder.Text = "Add Folder";
            // 
            // TopLevelToolStripMenuItem
            // 
            this.TopLevelToolStripMenuItem.Name = "TopLevelToolStripMenuItem";
            this.TopLevelToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.TopLevelToolStripMenuItem.Text = "Without Subdirectories";
            this.TopLevelToolStripMenuItem.Click += new System.EventHandler(this.TopLevelToolStripMenuItem_Click);
            // 
            // WithSubdirectoriesToolStripMenuItem
            // 
            this.WithSubdirectoriesToolStripMenuItem.Name = "WithSubdirectoriesToolStripMenuItem";
            this.WithSubdirectoriesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.WithSubdirectoriesToolStripMenuItem.Text = "With Subdirectories";
            this.WithSubdirectoriesToolStripMenuItem.Click += new System.EventHandler(this.WithSubdirectoriesToolStripMenuItem_Click);
            // 
            // BtnRemoveSelected
            // 
            this.BtnRemoveSelected.Image = global::ImageCompressor.Properties.Resources._03_Remove_Selected;
            this.BtnRemoveSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRemoveSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRemoveSelected.Name = "BtnRemoveSelected";
            this.BtnRemoveSelected.Size = new System.Drawing.Size(133, 36);
            this.BtnRemoveSelected.Text = "Remove Selected";
            this.BtnRemoveSelected.Click += new System.EventHandler(this.BtnRemoveSelected_Click);
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.Image = global::ImageCompressor.Properties.Resources._04_Clear_All;
            this.BtnClearAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnClearAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(87, 36);
            this.BtnClearAll.Text = "Clear All";
            this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // BtnOptions
            // 
            this.BtnOptions.Image = global::ImageCompressor.Properties.Resources._05_Target;
            this.BtnOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Size = new System.Drawing.Size(77, 36);
            this.BtnOptions.Text = "Target";
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Image = global::ImageCompressor.Properties.Resources._06_Compress;
            this.BtnStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(96, 36);
            this.BtnStart.Text = "Compress";
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 483);
            this.Controls.Add(this.lblStartView);
            this.Controls.Add(this.ListViewFiles);
            this.Controls.Add(this.ToolStripMenu);
            this.Controls.Add(this.StatusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Compressor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolStripMenu.ResumeLayout(false);
            this.ToolStripMenu.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

		internal ToolStrip ToolStripMenu;
		internal ToolStripButton BtnAddFiles;
		internal ToolStripDropDownButton BtnAddFolder;
		internal ToolStripMenuItem TopLevelToolStripMenuItem;
		internal ToolStripMenuItem WithSubdirectoriesToolStripMenuItem;
		internal ToolStripButton BtnRemoveSelected;
		internal ToolStripButton BtnClearAll;
		internal ToolStripButton BtnOptions;
		internal ToolStripButton BtnStart;
		internal ListView ListViewFiles;
		internal ColumnHeader ColumnHeader1;
		internal ColumnHeader ColumnHeader2;
		internal ColumnHeader ColumnHeader3;
		internal ColumnHeader ColumnHeader4;
		internal ColumnHeader ColumnHeader5;
		internal ColumnHeader ColumnHeader6;
		internal ColumnHeader ColumnHeader7;
		internal Label lblStartView;
		internal StatusStrip StatusStrip1;
		internal ToolStripStatusLabel ToolStripStatusLabel1;
		internal ToolStripStatusLabel lblFilesCount;
		internal ToolStripStatusLabel ToolStripStatusLabel2;
		internal ToolStripStatusLabel lblFilesProcessed;
		internal ToolStripStatusLabel ToolStripStatusLabel3;
		internal ToolStripStatusLabel lblRemaining;
		internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
		internal ImageList ImageList1;
	}

}