using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PowerShell_ISE_Reworked
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void newToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}

		private void openToolStripButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Title = "Open Any File...";
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.Clear();
				using (StreamReader sr = new StreamReader(openFile.FileName))
				{
					richTextBox1.Text = sr.ReadToEnd();
					sr.Close();
				}
			}
		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.Title = "Save file as...";
			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				StreamWriter txtoutput = new StreamWriter(saveFile.FileName);
				txtoutput.Write(richTextBox1.Text);
				txtoutput.Close();
			}
		}

		private void cutToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void copyToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void pasteToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void pwshToolStripButton_Click(object sender, EventArgs e)
		{
			string pwsh = "pwsh.exe";
			System.Diagnostics.Process.Start(pwsh);
		}

		private void pwshpreviewToolStripButton_Click(object sender, EventArgs e)
		{
			string pwshPreview = "C:\\Program Files\\PowerShell\\7-preview\\pwsh.exe";
			System.Diagnostics.Process.Start(pwshPreview);
		}

		private void powershellToolStripButton_Click(object sender, EventArgs e)
		{
			string powershell = "powershell.exe";
			System.Diagnostics.Process.Start(powershell);
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			newToolStripButton.PerformClick();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openToolStripButton.PerformClick();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveToolStripButton.PerformClick();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Undo();
		}

		private void redoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Redo();
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
		}

		private void powerShellToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			pwshToolStripButton.PerformClick();
		}

		private void powerShellPreviewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pwshpreviewToolStripButton.PerformClick();
		}

		private void powerShell51ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			powershellToolStripButton.PerformClick();
		}

		private void webView21_Click(object sender, EventArgs e)
		{

		}

		private void webView21_Click_1(object sender, EventArgs e)
		{

		}

		private void webView21_Click_2(object sender, EventArgs e)
		{
			webView21.Dock = DockStyle.Fill;
		}
	}
}