using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MisterModzZ
{
	// Token: 0x02000013 RID: 19
	public class Main_Menu_User_Control : UserControl
	{
		// Token: 0x06000074 RID: 116 RVA: 0x0000270D File Offset: 0x0000090D
		public Main_Menu_User_Control()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000271B File Offset: 0x0000091B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000686C File Offset: 0x00004A6C
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main_Menu_User_Control));
			this.panel2 = new Panel();
			this.panel1 = new Panel();
			this.panel4 = new Panel();
			this.ExitButton = new Button();
			this.MinimizeButton = new Button();
			this.panel3 = new Panel();
			this.SideNavigationPanel = new Panel();
			this.SettingsButton = new Button();
			this.StatsButton = new Button();
			this.UsersButton = new Button();
			this.MainMenuButton = new Button();
			this.panel5 = new Panel();
			this.HeadingLabel = new Label();
			this.panel6 = new Panel();
			this.LogoPictureBox = new PictureBox();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			((ISupportInitialize)this.LogoPictureBox).BeginInit();
			base.SuspendLayout();
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Dock = DockStyle.Fill;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(1094, 677);
			this.panel2.TabIndex = 1;
			this.panel1.Dock = DockStyle.Top;
			this.panel1.Location = new Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(1094, 674);
			this.panel1.TabIndex = 0;
			this.panel4.BackColor = Color.Black;
			this.panel4.Controls.Add(this.panel3);
			this.panel4.Controls.Add(this.MinimizeButton);
			this.panel4.Controls.Add(this.ExitButton);
			this.panel4.Dock = DockStyle.Fill;
			this.panel4.Location = new Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(1094, 677);
			this.panel4.TabIndex = 10;
			this.ExitButton.BackColor = Color.Black;
			this.ExitButton.FlatAppearance.BorderSize = 0;
			this.ExitButton.FlatStyle = FlatStyle.Flat;
            //this.ExitButton.Image = (Image)componentResourceManager.GetObject("ExitButton.Image");
            this.ExitButton.Location = new Point(1059, 3);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new Size(32, 27);
			this.ExitButton.TabIndex = 8;
			this.ExitButton.UseVisualStyleBackColor = false;
			this.MinimizeButton.BackColor = Color.Black;
			this.MinimizeButton.FlatAppearance.BorderSize = 0;
			this.MinimizeButton.FlatStyle = FlatStyle.Flat;
            //this.MinimizeButton.Image = (Image)componentResourceManager.GetObject("MinimizeButton.Image");
            this.MinimizeButton.Location = new Point(1031, 3);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.Size = new Size(32, 27);
			this.MinimizeButton.TabIndex = 9;
			this.MinimizeButton.UseVisualStyleBackColor = false;
			this.panel3.BackColor = Color.Black;
			this.panel3.Controls.Add(this.SideNavigationPanel);
			this.panel3.Controls.Add(this.SettingsButton);
			this.panel3.Controls.Add(this.StatsButton);
			this.panel3.Controls.Add(this.UsersButton);
			this.panel3.Controls.Add(this.MainMenuButton);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel6);
			this.panel3.Dock = DockStyle.Left;
			this.panel3.Location = new Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(176, 677);
			this.panel3.TabIndex = 10;
			this.SideNavigationPanel.BackColor = Color.Red;
			this.SideNavigationPanel.Location = new Point(0, 171);
			this.SideNavigationPanel.Name = "SideNavigationPanel";
			this.SideNavigationPanel.Size = new Size(3, 50);
			this.SideNavigationPanel.TabIndex = 1;
			this.SettingsButton.Dock = DockStyle.Bottom;
			this.SettingsButton.FlatAppearance.BorderSize = 0;
			this.SettingsButton.FlatStyle = FlatStyle.Flat;
			this.SettingsButton.Font = new Font("Century Gothic", 12f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.SettingsButton.ForeColor = Color.Red;
			//this.SettingsButton.Image = (Image)componentResourceManager.GetObject("SettingsButton.Image");
			this.SettingsButton.Location = new Point(0, 627);
			this.SettingsButton.Name = "SettingsButton";
			this.SettingsButton.Size = new Size(176, 50);
			this.SettingsButton.TabIndex = 5;
			this.SettingsButton.Text = "  Settings        ";
			this.SettingsButton.TextAlign = ContentAlignment.MiddleLeft;
			this.SettingsButton.TextImageRelation = TextImageRelation.TextBeforeImage;
			this.SettingsButton.UseVisualStyleBackColor = true;
			this.StatsButton.Dock = DockStyle.Top;
			this.StatsButton.FlatAppearance.BorderSize = 0;
			this.StatsButton.FlatStyle = FlatStyle.Flat;
			this.StatsButton.Font = new Font("Century Gothic", 12f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.StatsButton.ForeColor = Color.Red;
			//this.StatsButton.Image = (Image)componentResourceManager.GetObject("StatsButton.Image");
			this.StatsButton.Location = new Point(0, 271);
			this.StatsButton.Name = "StatsButton";
			this.StatsButton.Size = new Size(176, 50);
			this.StatsButton.TabIndex = 4;
			this.StatsButton.Text = "  Statistics        ";
			this.StatsButton.TextAlign = ContentAlignment.MiddleLeft;
			this.StatsButton.TextImageRelation = TextImageRelation.TextBeforeImage;
			this.StatsButton.UseVisualStyleBackColor = true;
			this.UsersButton.Dock = DockStyle.Top;
			this.UsersButton.FlatAppearance.BorderSize = 0;
			this.UsersButton.FlatStyle = FlatStyle.Flat;
			this.UsersButton.Font = new Font("Century Gothic", 12f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.UsersButton.ForeColor = Color.Red;
			//this.UsersButton.Image = (Image)componentResourceManager.GetObject("UsersButton.Image");
			this.UsersButton.ImageAlign = ContentAlignment.TopCenter;
			this.UsersButton.Location = new Point(0, 221);
			this.UsersButton.Name = "UsersButton";
			this.UsersButton.Size = new Size(176, 50);
			this.UsersButton.TabIndex = 3;
			this.UsersButton.Text = "  Users             ";
			this.UsersButton.TextAlign = ContentAlignment.BottomCenter;
			this.UsersButton.TextImageRelation = TextImageRelation.TextBeforeImage;
			this.UsersButton.UseVisualStyleBackColor = true;
			this.MainMenuButton.Dock = DockStyle.Top;
			this.MainMenuButton.FlatAppearance.BorderSize = 0;
			this.MainMenuButton.FlatStyle = FlatStyle.Flat;
			this.MainMenuButton.Font = new Font("Century Gothic", 12f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.MainMenuButton.ForeColor = Color.Red;
			//this.MainMenuButton.Image = (Image)componentResourceManager.GetObject("MainMenuButton.Image");
			this.MainMenuButton.Location = new Point(0, 171);
			this.MainMenuButton.Name = "MainMenuButton";
			this.MainMenuButton.Size = new Size(176, 50);
			this.MainMenuButton.TabIndex = 1;
			this.MainMenuButton.Text = "  Main Menu";
			this.MainMenuButton.TextAlign = ContentAlignment.MiddleLeft;
			this.MainMenuButton.TextImageRelation = TextImageRelation.TextBeforeImage;
			this.MainMenuButton.UseVisualStyleBackColor = true;
			this.panel5.Controls.Add(this.HeadingLabel);
			this.panel5.Dock = DockStyle.Top;
			this.panel5.Location = new Point(0, 140);
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size(176, 31);
			this.panel5.TabIndex = 1;
			this.HeadingLabel.AutoSize = true;
			this.HeadingLabel.Font = new Font("Century Gothic", 12f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.HeadingLabel.ForeColor = Color.Red;
			this.HeadingLabel.Location = new Point(23, 3);
			this.HeadingLabel.Name = "HeadingLabel";
			this.HeadingLabel.Size = new Size(128, 23);
			this.HeadingLabel.TabIndex = 1;
			this.HeadingLabel.Text = "GTA V Terror";
			this.panel6.Controls.Add(this.LogoPictureBox);
			this.panel6.Dock = DockStyle.Top;
			this.panel6.Location = new Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new Size(176, 140);
			this.panel6.TabIndex = 1;
			//this.LogoPictureBox.Image = (Image)componentResourceManager.GetObject("LogoPictureBox.Image");
			this.LogoPictureBox.Location = new Point(26, 7);
			this.LogoPictureBox.Name = "LogoPictureBox";
			this.LogoPictureBox.Size = new Size(125, 125);
			this.LogoPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
			this.LogoPictureBox.TabIndex = 1;
			this.LogoPictureBox.TabStop = false;
			base.AutoScaleMode = AutoScaleMode.None;
			this.BackColor = Color.FromArgb(46, 51, 73);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel2);
			this.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, 162);
			base.Name = "Main_Menu_User_Control";
			base.Size = new Size(1094, 677);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((ISupportInitialize)this.LogoPictureBox).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000073 RID: 115
		private IContainer components;

		// Token: 0x04000074 RID: 116
		private Panel panel2;

		// Token: 0x04000075 RID: 117
		private Panel panel1;

		// Token: 0x04000076 RID: 118
		private Panel panel4;

		// Token: 0x04000077 RID: 119
		private Button ExitButton;

		// Token: 0x04000078 RID: 120
		private Button MinimizeButton;

		// Token: 0x04000079 RID: 121
		private Panel panel3;

		// Token: 0x0400007A RID: 122
		private Panel SideNavigationPanel;

		// Token: 0x0400007B RID: 123
		private Button SettingsButton;

		// Token: 0x0400007C RID: 124
		private Button StatsButton;

		// Token: 0x0400007D RID: 125
		private Button UsersButton;

		// Token: 0x0400007E RID: 126
		private Button MainMenuButton;

		// Token: 0x0400007F RID: 127
		private Panel panel5;

		// Token: 0x04000080 RID: 128
		private Label HeadingLabel;

		// Token: 0x04000081 RID: 129
		private Panel panel6;

		// Token: 0x04000082 RID: 130
		private PictureBox LogoPictureBox;
	}
}
