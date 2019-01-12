namespace SnesInstaller
{
	partial class InstallForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallForm));
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
			this.buttonConfirm = new System.Windows.Forms.Button();
			this.linkLabelClose = new System.Windows.Forms.LinkLabel();
			this.labelInfo = new System.Windows.Forms.Label();
			this.checkBoxIcon = new System.Windows.Forms.CheckBox();
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.backgroundWorkerInstall = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tableLayoutPanelButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 1;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelButtons, 0, 4);
			this.tableLayoutPanelMain.Controls.Add(this.labelInfo, 0, 1);
			this.tableLayoutPanelMain.Controls.Add(this.checkBoxIcon, 0, 2);
			this.tableLayoutPanelMain.Controls.Add(this.pictureBoxLogo, 0, 0);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 5;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(384, 461);
			this.tableLayoutPanelMain.TabIndex = 1;
			// 
			// tableLayoutPanelButtons
			// 
			this.tableLayoutPanelButtons.ColumnCount = 4;
			this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanelButtons.Controls.Add(this.buttonConfirm, 3, 0);
			this.tableLayoutPanelButtons.Controls.Add(this.linkLabelClose, 2, 0);
			this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelButtons.Location = new System.Drawing.Point(3, 414);
			this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
			this.tableLayoutPanelButtons.RowCount = 1;
			this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelButtons.Size = new System.Drawing.Size(378, 44);
			this.tableLayoutPanelButtons.TabIndex = 0;
			// 
			// buttonConfirm
			// 
			this.buttonConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonConfirm.Location = new System.Drawing.Point(268, 10);
			this.buttonConfirm.Margin = new System.Windows.Forms.Padding(10);
			this.buttonConfirm.Name = "buttonConfirm";
			this.buttonConfirm.Size = new System.Drawing.Size(100, 24);
			this.buttonConfirm.TabIndex = 1;
			this.buttonConfirm.Text = "Instalar";
			this.buttonConfirm.UseVisualStyleBackColor = true;
			this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
			// 
			// linkLabelClose
			// 
			this.linkLabelClose.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
			this.linkLabelClose.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.linkLabelClose.AutoSize = true;
			this.linkLabelClose.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelClose.Location = new System.Drawing.Point(151, 15);
			this.linkLabelClose.Name = "linkLabelClose";
			this.linkLabelClose.Size = new System.Drawing.Size(94, 13);
			this.linkLabelClose.TabIndex = 2;
			this.linkLabelClose.TabStop = true;
			this.linkLabelClose.Text = "Cancelar e Fechar";
			this.linkLabelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelClose.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaption;
			this.linkLabelClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClose_LinkClicked);
			// 
			// labelInfo
			// 
			this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelInfo.Location = new System.Drawing.Point(3, 50);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(378, 100);
			this.labelInfo.TabIndex = 1;
			this.labelInfo.Text = "Vamos prosseguir com a instalação do Snes.";
			this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBoxIcon
			// 
			this.checkBoxIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.checkBoxIcon.AutoSize = true;
			this.checkBoxIcon.Checked = true;
			this.checkBoxIcon.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxIcon.Location = new System.Drawing.Point(10, 161);
			this.checkBoxIcon.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.checkBoxIcon.Name = "checkBoxIcon";
			this.checkBoxIcon.Size = new System.Drawing.Size(225, 17);
			this.checkBoxIcon.TabIndex = 4;
			this.checkBoxIcon.Text = "Criar ícone de atalho na Área de Trabalho";
			this.checkBoxIcon.UseVisualStyleBackColor = true;
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxLogo.ErrorImage = null;
			this.pictureBoxLogo.Image = global::SnesInstaller.Properties.Resources.nameLogo;
			this.pictureBoxLogo.InitialImage = null;
			this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(378, 44);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLogo.TabIndex = 5;
			this.pictureBoxLogo.TabStop = false;
			this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
			// 
			// backgroundWorkerInstall
			// 
			this.backgroundWorkerInstall.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerInstall_DoWork);
			this.backgroundWorkerInstall.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerInstall_RunWorkerCompleted);
			// 
			// InstallForm
			// 
			this.AcceptButton = this.buttonConfirm;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.linkLabelClose;
			this.ClientSize = new System.Drawing.Size(384, 461);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "InstallForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SnesInstaller";
			this.Load += new System.EventHandler(this.InstallForm_Load);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelMain.PerformLayout();
			this.tableLayoutPanelButtons.ResumeLayout(false);
			this.tableLayoutPanelButtons.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
		private System.Windows.Forms.Button buttonConfirm;
		private System.Windows.Forms.LinkLabel linkLabelClose;
		private System.Windows.Forms.Label labelInfo;
		private System.Windows.Forms.CheckBox checkBoxIcon;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.ComponentModel.BackgroundWorker backgroundWorkerInstall;
	}
}