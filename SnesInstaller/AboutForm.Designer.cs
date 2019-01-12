namespace SnesInstaller
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxAbout = new System.Windows.Forms.TextBox();
			this.tableLayoutPanelColumns = new System.Windows.Forms.TableLayoutPanel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.tableLayoutPanelLinks = new System.Windows.Forms.TableLayoutPanel();
			this.linkLabelAppWebsite = new System.Windows.Forms.LinkLabel();
			this.linkLabelDevWebsite = new System.Windows.Forms.LinkLabel();
			this.linkLabelWebsite = new System.Windows.Forms.LinkLabel();
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tableLayoutPanelColumns.SuspendLayout();
			this.tableLayoutPanelLinks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 1;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.Controls.Add(this.pictureBoxLogo, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.textBoxAbout, 0, 1);
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelColumns, 0, 2);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 3;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(524, 541);
			this.tableLayoutPanelMain.TabIndex = 1;
			// 
			// textBoxAbout
			// 
			this.textBoxAbout.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBoxAbout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAbout.Location = new System.Drawing.Point(10, 110);
			this.textBoxAbout.Margin = new System.Windows.Forms.Padding(10);
			this.textBoxAbout.Multiline = true;
			this.textBoxAbout.Name = "textBoxAbout";
			this.textBoxAbout.ReadOnly = true;
			this.textBoxAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxAbout.Size = new System.Drawing.Size(504, 321);
			this.textBoxAbout.TabIndex = 3;
			this.textBoxAbout.Text = "SnesInstaller\r\n\r\nMIT License";
			// 
			// tableLayoutPanelColumns
			// 
			this.tableLayoutPanelColumns.ColumnCount = 2;
			this.tableLayoutPanelColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanelColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelColumns.Controls.Add(this.buttonClose, 1, 0);
			this.tableLayoutPanelColumns.Controls.Add(this.tableLayoutPanelLinks, 0, 0);
			this.tableLayoutPanelColumns.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelColumns.Location = new System.Drawing.Point(3, 444);
			this.tableLayoutPanelColumns.Name = "tableLayoutPanelColumns";
			this.tableLayoutPanelColumns.RowCount = 1;
			this.tableLayoutPanelColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelColumns.Size = new System.Drawing.Size(518, 94);
			this.tableLayoutPanelColumns.TabIndex = 4;
			// 
			// buttonClose
			// 
			this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonClose.Location = new System.Drawing.Point(428, 10);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(10);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(80, 74);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.Text = "Fechar";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// tableLayoutPanelLinks
			// 
			this.tableLayoutPanelLinks.ColumnCount = 3;
			this.tableLayoutPanelLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.tableLayoutPanelLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanelLinks.Controls.Add(this.linkLabelAppWebsite, 2, 0);
			this.tableLayoutPanelLinks.Controls.Add(this.linkLabelDevWebsite, 2, 1);
			this.tableLayoutPanelLinks.Controls.Add(this.linkLabelWebsite, 1, 1);
			this.tableLayoutPanelLinks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelLinks.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelLinks.Name = "tableLayoutPanelLinks";
			this.tableLayoutPanelLinks.RowCount = 2;
			this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelLinks.Size = new System.Drawing.Size(412, 88);
			this.tableLayoutPanelLinks.TabIndex = 1;
			// 
			// linkLabelAppWebsite
			// 
			this.linkLabelAppWebsite.ActiveLinkColor = System.Drawing.Color.Black;
			this.linkLabelAppWebsite.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.linkLabelAppWebsite.AutoSize = true;
			this.linkLabelAppWebsite.Location = new System.Drawing.Point(283, 15);
			this.linkLabelAppWebsite.Name = "linkLabelAppWebsite";
			this.linkLabelAppWebsite.Size = new System.Drawing.Size(107, 13);
			this.linkLabelAppWebsite.TabIndex = 2;
			this.linkLabelAppWebsite.TabStop = true;
			this.linkLabelAppWebsite.Text = "http://nintendo.com/";
			this.linkLabelAppWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelAppWebsite.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkLabelAppWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAppWebsite_LinkClicked);
			// 
			// linkLabelDevWebsite
			// 
			this.linkLabelDevWebsite.ActiveLinkColor = System.Drawing.Color.Black;
			this.linkLabelDevWebsite.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.linkLabelDevWebsite.AutoSize = true;
			this.linkLabelDevWebsite.Location = new System.Drawing.Point(278, 59);
			this.linkLabelDevWebsite.Name = "linkLabelDevWebsite";
			this.linkLabelDevWebsite.Size = new System.Drawing.Size(118, 13);
			this.linkLabelDevWebsite.TabIndex = 1;
			this.linkLabelDevWebsite.TabStop = true;
			this.linkLabelDevWebsite.Text = "http://mcarvalhor.com/";
			this.linkLabelDevWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelDevWebsite.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkLabelDevWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDevWebsite_LinkClicked);
			// 
			// linkLabelWebsite
			// 
			this.linkLabelWebsite.ActiveLinkColor = System.Drawing.Color.Black;
			this.linkLabelWebsite.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.linkLabelWebsite.AutoSize = true;
			this.linkLabelWebsite.Location = new System.Drawing.Point(40, 59);
			this.linkLabelWebsite.Name = "linkLabelWebsite";
			this.linkLabelWebsite.Size = new System.Drawing.Size(194, 13);
			this.linkLabelWebsite.TabIndex = 3;
			this.linkLabelWebsite.TabStop = true;
			this.linkLabelWebsite.Text = "http://isc.mcarvalhor.com/SnesInstaller";
			this.linkLabelWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelWebsite.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkLabelWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWebsite_LinkClicked);
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
			this.pictureBoxLogo.Size = new System.Drawing.Size(518, 94);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLogo.TabIndex = 2;
			this.pictureBoxLogo.TabStop = false;
			this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
			// 
			// AboutForm
			// 
			this.AcceptButton = this.buttonClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 541);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SnesInstaller";
			this.Load += new System.EventHandler(this.AboutForm_Load);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelMain.PerformLayout();
			this.tableLayoutPanelColumns.ResumeLayout(false);
			this.tableLayoutPanelLinks.ResumeLayout(false);
			this.tableLayoutPanelLinks.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
		private System.Windows.Forms.TextBox textBoxAbout;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelColumns;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLinks;
		private System.Windows.Forms.LinkLabel linkLabelAppWebsite;
		private System.Windows.Forms.LinkLabel linkLabelDevWebsite;
		private System.Windows.Forms.LinkLabel linkLabelWebsite;
	}
}