namespace FIFA_Squad_Manager
{
	partial class Form1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.titleBar = new System.Windows.Forms.SplitContainer();
			this.teamLogo = new System.Windows.Forms.PictureBox();
			this.clubLabel = new System.Windows.Forms.Label();
			this.saveSquadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveSquadAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadSquadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageSquadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.titleBar)).BeginInit();
			this.titleBar.Panel1.SuspendLayout();
			this.titleBar.Panel2.SuspendLayout();
			this.titleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.teamLogo)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1266, 30);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSquadToolStripMenuItem,
            this.saveSquadAsToolStripMenuItem,
            this.loadSquadToolStripMenuItem,
            this.manageSquadsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// titleBar
			// 
			this.titleBar.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleBar.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.titleBar.IsSplitterFixed = true;
			this.titleBar.Location = new System.Drawing.Point(0, 30);
			this.titleBar.Name = "titleBar";
			// 
			// titleBar.Panel1
			// 
			this.titleBar.Panel1.BackColor = System.Drawing.Color.DodgerBlue;
			this.titleBar.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.titleBar.Panel1.Controls.Add(this.teamLogo);
			// 
			// titleBar.Panel2
			// 
			this.titleBar.Panel2.BackColor = System.Drawing.Color.LightGreen;
			this.titleBar.Panel2.Controls.Add(this.clubLabel);
			this.titleBar.Size = new System.Drawing.Size(1266, 100);
			this.titleBar.SplitterDistance = 167;
			this.titleBar.SplitterWidth = 1;
			this.titleBar.TabIndex = 3;
			// 
			// teamLogo
			// 
			this.teamLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.teamLogo.InitialImage = global::FIFA_Squad_Manager.Properties.Resources.Placeholder;
			this.teamLogo.Location = new System.Drawing.Point(0, 0);
			this.teamLogo.Name = "teamLogo";
			this.teamLogo.Size = new System.Drawing.Size(167, 100);
			this.teamLogo.TabIndex = 0;
			this.teamLogo.TabStop = false;
			// 
			// clubLabel
			// 
			this.clubLabel.BackColor = System.Drawing.Color.Gold;
			this.clubLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clubLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clubLabel.Location = new System.Drawing.Point(0, 0);
			this.clubLabel.Name = "clubLabel";
			this.clubLabel.Size = new System.Drawing.Size(1098, 100);
			this.clubLabel.TabIndex = 0;
			this.clubLabel.Text = "PLACEHOLDER CLUB FC";
			this.clubLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// saveSquadToolStripMenuItem
			// 
			this.saveSquadToolStripMenuItem.Name = "saveSquadToolStripMenuItem";
			this.saveSquadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.saveSquadToolStripMenuItem.Text = "Save Squad";
			// 
			// saveSquadAsToolStripMenuItem
			// 
			this.saveSquadAsToolStripMenuItem.Name = "saveSquadAsToolStripMenuItem";
			this.saveSquadAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.saveSquadAsToolStripMenuItem.Text = "Save Squad as...";
			// 
			// loadSquadToolStripMenuItem
			// 
			this.loadSquadToolStripMenuItem.Name = "loadSquadToolStripMenuItem";
			this.loadSquadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.loadSquadToolStripMenuItem.Text = "Load Squad";
			// 
			// manageSquadsToolStripMenuItem
			// 
			this.manageSquadsToolStripMenuItem.Name = "manageSquadsToolStripMenuItem";
			this.manageSquadsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.manageSquadsToolStripMenuItem.Text = "Manage Squads";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(0, 130);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1266, 523);
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1119, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Goalkeepers";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(1266, 653);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.titleBar);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1000, 668);
			this.Name = "Form1";
			this.Text = "FIFA SQUAD MANAGER";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.titleBar.Panel1.ResumeLayout(false);
			this.titleBar.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.titleBar)).EndInit();
			this.titleBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.teamLogo)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.SplitContainer titleBar;
		private System.Windows.Forms.PictureBox teamLogo;
		private System.Windows.Forms.Label clubLabel;
		private System.Windows.Forms.ToolStripMenuItem saveSquadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveSquadAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadSquadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageSquadsToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}

