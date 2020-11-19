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
	public partial class FrmOptions : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptions));
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtBoxOutPath = new System.Windows.Forms.TextBox();
            this.ComboBoxQuality = new System.Windows.Forms.ComboBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 29);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Outputh path :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 122);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Quality : ";
            // 
            // TxtBoxOutPath
            // 
            this.TxtBoxOutPath.Location = new System.Drawing.Point(25, 46);
            this.TxtBoxOutPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBoxOutPath.Name = "TxtBoxOutPath";
            this.TxtBoxOutPath.Size = new System.Drawing.Size(295, 20);
            this.TxtBoxOutPath.TabIndex = 2;
            // 
            // ComboBoxQuality
            // 
            this.ComboBoxQuality.FormattingEnabled = true;
            this.ComboBoxQuality.Items.AddRange(new object[] {
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90"});
            this.ComboBoxQuality.Location = new System.Drawing.Point(25, 139);
            this.ComboBoxQuality.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxQuality.Name = "ComboBoxQuality";
            this.ComboBoxQuality.Size = new System.Drawing.Size(295, 21);
            this.ComboBoxQuality.TabIndex = 3;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(237, 70);
            this.BtnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(82, 24);
            this.BtnBrowse.TabIndex = 4;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(237, 204);
            this.BtnAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(82, 24);
            this.BtnAccept.TabIndex = 5;
            this.BtnAccept.Text = "Accept";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 238);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.ComboBoxQuality);
            this.Controls.Add(this.TxtBoxOutPath);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

	}

		internal Label Label1;
		internal Label Label2;
		internal TextBox TxtBoxOutPath;
		internal ComboBox ComboBoxQuality;
		internal Button BtnBrowse;
		internal Button BtnAccept;
	}

}