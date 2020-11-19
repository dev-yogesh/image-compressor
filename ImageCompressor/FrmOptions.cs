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
	public partial class FrmOptions
	{
		public FrmOptions()
		{
			InitializeComponent();
		}

		private void BtnBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderbrowse = new FolderBrowserDialog();
			if (folderbrowse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				TxtBoxOutPath.Text = folderbrowse.SelectedPath;

			}
		}

		private void FrmOptions_Load(object sender, EventArgs e)
		{
			ComboBoxQuality.SelectedIndex = 6;

		}

		private void BtnAccept_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}