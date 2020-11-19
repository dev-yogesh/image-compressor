using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading;

namespace ImageCompressor
{
	public partial class Form1
	{

		public Form1()
		{
			InitializeComponent();
		}

#region Variables

		private string outputPath = string.Empty; // The target directory of the compressed images
		private int compressRatio = 80; // compression ration of the image , default value is 80
		private int totalFiles = 0; // total files added
		private int processedFiles = 0; // processed files (compressed files)
		private List<ListViewItem> itemsList = new List<ListViewItem>(); //this will hold all the listview items

#endregion


#region Compression


		private ImageCodecInfo GetEncoder(ImageFormat format)
		{
			ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
			foreach (ImageCodecInfo codec in codecs)
			{

				if (codec.FormatID == format.Guid)
				{
					return codec;

				}

			}
			return null;

		}

		private object CompressImage(ListViewItem lvitem)
		{
			try
			{

				// Alter the Listview item 
				AlterListviewItem(lvitem, "", "", "Compressing");


				string ext = Path.GetExtension(lvitem.SubItems[6].Text);
				string SourceNameWithoutExtention = Path.GetFileNameWithoutExtension(lvitem.SubItems[6].Text);
				string targetPath = outputPath + "\\" + SourceNameWithoutExtention + "_comp" + ext;

				// get the encoder 
				ImageCodecInfo encoder = null;

				switch (ext.ToLower())
				{
					case ".jpg":
						encoder = GetEncoder(ImageFormat.Jpeg);
						break;
					case ".jpeg":
						encoder = GetEncoder(ImageFormat.Jpeg);
						break;
					case ".bmp":
						encoder = GetEncoder(ImageFormat.Bmp);
						break;
					case ".png":
						encoder = GetEncoder(ImageFormat.Png);
						break;
					case ".jpe":
						encoder = GetEncoder(ImageFormat.Jpeg);
						break;
					case ".jfif":
						encoder = GetEncoder(ImageFormat.Jpeg);
						break;
				}

				EncoderParameter imagequality = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, compressRatio);

				EncoderParameters codecparameter = new EncoderParameters(1);
				codecparameter.Param[0] = imagequality;


				FileStream fs = new FileStream(lvitem.SubItems[6].Text, FileMode.Open, FileAccess.Read);
				using (fs)
				{

					Image image = Image.FromStream(fs);
					using (image)
					{

						image.Save(targetPath, encoder, codecparameter);
					}
				}

				fs.Close();


				FileInfo BeforeFileInfo = new FileInfo(lvitem.SubItems[6].Text);
				FileInfo afterFileInfo = new FileInfo(targetPath);

				double sizeBefore = BeforeFileInfo.Length;
				double sizeAfter = afterFileInfo.Length;

				double calculatedRatio = (100 * sizeAfter) / sizeBefore;



				AlterListviewItem(lvitem, string.Format("{0:0.00}", (sizeAfter / 1024)).ToString() + " KB", string.Format("{0:0.00}", (100 - calculatedRatio)).ToString() + " %", "Finished");


				// alter the listview item 
				processedFiles += 1;

				//alter the status bar 

				alterStatusLabel(lblFilesProcessed, processedFiles.ToString());
				alterStatusLabel(lblRemaining, (totalFiles - processedFiles).ToString());


			}
			catch (Exception ex)
			{
				
			}

//INSTANT C# NOTE: Inserted the following 'return' since all code paths must return a value in C#:
			return null;
		}

#endregion

#region helper Methods
		private bool CheckExtention(string ext)
		{
			switch (ext.ToLower())
			{
				case ".jpg":
					return true;
				case ".jpeg":
					return true;
				case ".jpe":
					return true;
				case ".jfif":
					return true;
				case ".png":
					return true;
				case ".bmp":
					return true;

				default:
					return false;



			}
		}


        private void AlterListviewItem(ListViewItem lvitem, string NewSize, string CompressionRatio, string stat)
        {

            if (ListViewFiles.InvokeRequired == true)
            {
                ListViewFiles.BeginInvoke(new Action(() => AlterListviewItem(lvitem, NewSize, CompressionRatio, stat)));
            }
            else
            {
                lvitem.SubItems[3].Text = NewSize;
                lvitem.SubItems[4].Text = CompressionRatio;
                lvitem.SubItems[5].Text = stat;

            }
        }


        private void alterStatusLabel(ToolStripStatusLabel lbl, string val)
        {
            if (StatusStrip1.InvokeRequired == true)
            {
                StatusStrip1.BeginInvoke(new Action(() => alterStatusLabel(lbl, val)));

            }
            else
            {
                lbl.Text = val;
            }
        }


        #endregion


        #region Adding Files
        private void AddFiles()
		{

			OpenFileDialog openFileDlg = new OpenFileDialog();
			openFileDlg.Multiselect = true;
			DialogResult dresult = openFileDlg.ShowDialog();
			if (dresult == System.Windows.Forms.DialogResult.OK)
			{
				string filepath = null;

				try
				{


					foreach (var file in openFileDlg.FileNames)
					{
						FileInfo fileInfo = new FileInfo(file);

						// check if the file is an image 
						if (CheckExtention(fileInfo.Extension))
						{

							ListViewItem lsitem = new ListViewItem();
							lsitem.Text = Path.GetFileName(file);
							lsitem.SubItems.Add(fileInfo.Extension);
							lsitem.SubItems.Add(Convert.ToInt32((fileInfo.Length / 1024.0)).ToString() + "KB");
							lsitem.SubItems.Add(""); // new size
							lsitem.SubItems.Add(""); // compression ration
							lsitem.SubItems.Add(""); // status
							lsitem.SubItems.Add(file);


							lsitem.ImageIndex = 0;

							ListViewFiles.Items.Add(lsitem);
						}

					}

				}
				catch (Exception ex)
				{
					
				}
			}

		}

		private void AddTopFiles(string FolderPath)
		{
			DirectoryInfo dirInfo = new DirectoryInfo(FolderPath);

			FileInfo[] filist = dirInfo.GetFiles();



			try
			{
				foreach (FileInfo file in filist)
				{


					// check if the file is an image 
					if (CheckExtention(file.Extension))
					{

						ListViewItem lsitem = new ListViewItem();
						lsitem.Text = Path.GetFileName(file.FullName);
						lsitem.SubItems.Add(file.Extension);
						lsitem.SubItems.Add(Convert.ToInt32((file.Length / 1024.0)).ToString() + "KB");
						lsitem.SubItems.Add(""); // new size
						lsitem.SubItems.Add(""); // compression ration
						lsitem.SubItems.Add(""); // status
						lsitem.SubItems.Add(file.FullName);


						lsitem.ImageIndex = 0;

						ListViewFiles.Items.Add(lsitem);
					}

				}


			}
			catch (Exception ex)
			{
				
			}


		}


		private void AddFilesWithSubDirectories(string FolderPath)
		{

			Stack<string> Stack = new Stack<string>();
			Stack.Push(FolderPath);

			try
			{
				while (Stack.Count > 0)
				{

					string dir = Convert.ToString(Stack.Pop());

					DirectoryInfo di = new DirectoryInfo(dir);
					FileInfo[] Fi = di.GetFiles();

					foreach (FileInfo file in Fi)
					{


						// check if the file is an image 
						if (CheckExtention(file.Extension))
						{

							ListViewItem lsitem = new ListViewItem();
							lsitem.Text = Path.GetFileName(file.FullName);
							lsitem.SubItems.Add(file.Extension);
							lsitem.SubItems.Add(Convert.ToInt32((file.Length / 1024.0)).ToString() + "KB");
							lsitem.SubItems.Add(""); // new size
							lsitem.SubItems.Add(""); // compression ration
							lsitem.SubItems.Add(""); // status
							lsitem.SubItems.Add(file.FullName);


							lsitem.ImageIndex = 0;

							ListViewFiles.Items.Add(lsitem);
						}

					}



					foreach (var direcName in Directory.GetDirectories(dir))
					{
						Stack.Push(direcName);
					}



				}









			}
			catch (Exception ex)
			{
				
			}




		}


		private void BtnAddFiles_Click(object sender, EventArgs e)
		{
			try
			{
				int x = 0;
				int y = Convert.ToInt32(5 / (double)x);


			}
			catch (Exception ex)
			{
				
			}
			AddFiles();

			if (ListViewFiles.Items.Count > 0)
			{
				lblStartView.Visible = false;
				lblFilesCount.Text = ListViewFiles.Items.Count.ToString();

			}


		}

		private void TopLevelToolStripMenuItem_Click(object sender, EventArgs e)
		{

			FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();
			if (FolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				AddTopFiles(FolderBrowserDialog.SelectedPath);

			}

			if (ListViewFiles.Items.Count > 0)
			{
				lblStartView.Visible = false;
				lblFilesCount.Text = ListViewFiles.Items.Count.ToString();

			}
		}

		private void WithSubdirectoriesToolStripMenuItem_Click(object sender, EventArgs e)
		{

			FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();
			if (FolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				AddFilesWithSubDirectories(FolderBrowserDialog.SelectedPath);

			}

			if (ListViewFiles.Items.Count > 0)
			{
				lblStartView.Visible = false;
				lblFilesCount.Text = ListViewFiles.Items.Count.ToString();

			}
		}
#endregion



		private void BtnOptions_Click(object sender, EventArgs e)
		{
			FrmOptions optFrm = new FrmOptions();
			optFrm.ShowDialog();
			outputPath = optFrm.TxtBoxOutPath.Text;
			compressRatio = int.Parse(optFrm.ComboBoxQuality.Text);

		}

		private void BtnRemoveSelected_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in ListViewFiles.Items)
			{
				if (item.Selected == true)
				{
					item.Remove();

				}

			}
			lblFilesCount.Text = ListViewFiles.Items.Count.ToString();
		}

		private void BtnClearAll_Click(object sender, EventArgs e)
		{
			ListViewFiles.Items.Clear();
			lblFilesCount.Text = ListViewFiles.Items.Count.ToString();
		}

		private void BtnStart_Click(object sender, EventArgs e)
		{

			// check if the target path 
			if (string.IsNullOrEmpty(outputPath))
			{
				MessageBox.Show("Please set the output directory", "Image compressor", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;

			}


			foreach (ListViewItem liItem in ListViewFiles.Items)
			{
				itemsList.Add(liItem);

			}


			totalFiles = ListViewFiles.Items.Count;
			lblFilesCount.Text = totalFiles.ToString();
			lblFilesProcessed.Text = "0";
			lblRemaining.Text = "0";


			if (BackgroundWorker1.IsBusy == false)
			{

				BtnStart.Enabled = false;
				BackgroundWorker1.RunWorkerAsync();


			}



		}

		private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{

			foreach (ListViewItem item in itemsList)
			{

				CompressImage(item);

				Thread.Sleep(500);

			}


		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private static Form1 _DefaultInstance;
		public static Form1 DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null)
					_DefaultInstance = new Form1();

				return _DefaultInstance;
			}
		}
	}

}