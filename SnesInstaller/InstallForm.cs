using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnesInstaller
{
	public partial class InstallForm : Form
	{
		public InstallForm()
		{
			InitializeComponent();
		}

		private ProcessForm processDialog;

		private void InstallForm_Load(object sender, EventArgs e)
		{
			checkBoxIcon.Checked = true;
			labelInfo.Text = String.Format(Utils.GetString("Install_Info"), Environment.NewLine);
			checkBoxIcon.Text = Utils.GetString("Install_DesktopFieldText");
			linkLabelClose.Text = Utils.GetString("Install_ButtonClose");
			buttonConfirm.Text = Utils.GetString("Install_ButtonConfirm");
		}

		private void pictureBoxLogo_Click(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start(Utils.appWebsite);
			}
			catch (Exception) { }
		}

		private void linkLabelClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void buttonConfirm_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.processDialog = new ProcessForm();
			backgroundWorkerInstall.RunWorkerAsync(new object[] { checkBoxIcon.Checked, Utils.GetString("Install_Lang") }); // Utils.Install(bool, string);
			this.processDialog.ShowDialog();
		}

		private void backgroundWorkerInstall_DoWork(object sender, DoWorkEventArgs e)
		{
			object[] arguments;

			arguments = (object[]) e.Argument;
			e.Result = Utils.Install((bool) arguments[0], (string) arguments[1]);
		}

		private void backgroundWorkerInstall_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			bool result;

			this.processDialog.Finished();
			this.processDialog.Dispose();
			this.processDialog = null;

			result = (bool)e.Result;
			if (result)
			{
				MessageBox.Show(String.Format(Utils.GetString("Install_Success"), Environment.NewLine), Utils.GetString("Install_SuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
			}
			else
			{
				MessageBox.Show(String.Format(Utils.GetString("Install_Error"), Environment.NewLine), Utils.GetString("Install_ErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
			Program.instanceMutex.ReleaseMutex();
			Application.Restart();
		}
	}
}
