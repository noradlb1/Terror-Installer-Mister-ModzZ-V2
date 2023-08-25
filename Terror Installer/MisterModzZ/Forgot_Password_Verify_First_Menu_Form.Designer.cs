namespace MisterModzZ
{
	// Token: 0x02000011 RID: 17
	public partial class Forgot_Password_Verify_First_Menu_Form : global::System.Windows.Forms.Form
	{
		// Token: 0x06000069 RID: 105 RVA: 0x0000269A File Offset: 0x0000089A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000055B8 File Offset: 0x000037B8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MisterModzZ.Forgot_Password_Verify_First_Menu_Form));
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.LogoPictureBox = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.ExitButton = new global::System.Windows.Forms.Button();
			this.MinimizeButton = new global::System.Windows.Forms.Button();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.HeadingLabel = new global::System.Windows.Forms.Label();
			this.UsernameTextBox = new global::System.Windows.Forms.TextBox();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.NewPasswordAgainTextBox = new global::System.Windows.Forms.TextBox();
			this.NewPasswordTextBox = new global::System.Windows.Forms.TextBox();
			this.GoToLoginMenuButton = new global::System.Windows.Forms.Button();
			this.CreateAFreeAccountButton = new global::System.Windows.Forms.Button();
			this.ChangeThePasswordButton = new global::System.Windows.Forms.Button();
			this.QuestionAnswerTextBox = new global::System.Windows.Forms.TextBox();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			base.SuspendLayout();
			this.panel2.Controls.Add(this.LogoPictureBox);
			this.panel2.Location = new global::System.Drawing.Point(93, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(176, 140);
			this.panel2.TabIndex = 26;
			//this.LogoPictureBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LogoPictureBox.Image");
			this.LogoPictureBox.Location = new global::System.Drawing.Point(26, 7);
			this.LogoPictureBox.Name = "LogoPictureBox";
			this.LogoPictureBox.Size = new global::System.Drawing.Size(125, 125);
			this.LogoPictureBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.LogoPictureBox.TabIndex = 1;
			this.LogoPictureBox.TabStop = false;
			this.panel1.BackColor = global::System.Drawing.Color.Red;
			this.panel1.Location = new global::System.Drawing.Point(112, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(139, 10);
			this.panel1.TabIndex = 23;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			this.ExitButton.BackColor = global::System.Drawing.Color.Black;
			this.ExitButton.FlatAppearance.BorderSize = 0;
			this.ExitButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			//this.ExitButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ExitButton.Image");
			this.ExitButton.Location = new global::System.Drawing.Point(323, 6);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new global::System.Drawing.Size(32, 27);
			this.ExitButton.TabIndex = 7;
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new global::System.EventHandler(this.ExitButton_Click);
			this.MinimizeButton.BackColor = global::System.Drawing.Color.Black;
			this.MinimizeButton.FlatAppearance.BorderSize = 0;
			this.MinimizeButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			//this.MinimizeButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MinimizeButton.Image");
			this.MinimizeButton.Location = new global::System.Drawing.Point(285, 6);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.Size = new global::System.Drawing.Size(32, 27);
			this.MinimizeButton.TabIndex = 6;
			this.MinimizeButton.UseVisualStyleBackColor = false;
			this.MinimizeButton.Click += new global::System.EventHandler(this.MinimizeButton_Click);
			this.panel3.Controls.Add(this.HeadingLabel);
			this.panel3.Location = new global::System.Drawing.Point(0, 174);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(363, 31);
			this.panel3.TabIndex = 27;
			this.HeadingLabel.AutoSize = true;
			this.HeadingLabel.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.HeadingLabel.ForeColor = global::System.Drawing.Color.Red;
			this.HeadingLabel.Location = new global::System.Drawing.Point(104, 6);
			this.HeadingLabel.Name = "HeadingLabel";
			this.HeadingLabel.Size = new global::System.Drawing.Size(197, 23);
			this.HeadingLabel.TabIndex = 1;
			this.HeadingLabel.Text = "MisterModzZ Injector";
			this.UsernameTextBox.BackColor = global::System.Drawing.Color.Black;
			this.UsernameTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.UsernameTextBox.ForeColor = global::System.Drawing.Color.Red;
			this.UsernameTextBox.Location = new global::System.Drawing.Point(27, 18);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new global::System.Drawing.Size(309, 32);
			this.UsernameTextBox.TabIndex = 1;
			this.UsernameTextBox.Text = "  Username";
			this.UsernameTextBox.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.UsernameTextBox_MouseClick);
			this.panel4.Controls.Add(this.button1);
			this.panel4.Controls.Add(this.NewPasswordAgainTextBox);
			this.panel4.Controls.Add(this.NewPasswordTextBox);
			this.panel4.Controls.Add(this.GoToLoginMenuButton);
			this.panel4.Controls.Add(this.CreateAFreeAccountButton);
			this.panel4.Controls.Add(this.ChangeThePasswordButton);
			this.panel4.Controls.Add(this.QuestionAnswerTextBox);
			this.panel4.Controls.Add(this.UsernameTextBox);
			this.panel4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new global::System.Drawing.Point(0, 211);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(363, 416);
			this.panel4.TabIndex = 28;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.button1.ForeColor = global::System.Drawing.Color.Red;
			this.button1.Location = new global::System.Drawing.Point(61, 315);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(240, 31);
			this.button1.TabIndex = 8;
			this.button1.TabStop = false;
			this.button1.Text = "Delete My Accounts";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.NewPasswordAgainTextBox.BackColor = global::System.Drawing.Color.Black;
			this.NewPasswordAgainTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.NewPasswordAgainTextBox.ForeColor = global::System.Drawing.Color.Red;
			this.NewPasswordAgainTextBox.Location = new global::System.Drawing.Point(27, 164);
			this.NewPasswordAgainTextBox.Name = "NewPasswordAgainTextBox";
			this.NewPasswordAgainTextBox.Size = new global::System.Drawing.Size(309, 32);
			this.NewPasswordAgainTextBox.TabIndex = 7;
			this.NewPasswordAgainTextBox.Text = "  Re-enter New Password";
			this.NewPasswordAgainTextBox.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.NewPasswordAgainTextBox_MouseClick);
			this.NewPasswordTextBox.BackColor = global::System.Drawing.Color.Black;
			this.NewPasswordTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.NewPasswordTextBox.ForeColor = global::System.Drawing.Color.Red;
			this.NewPasswordTextBox.Location = new global::System.Drawing.Point(27, 112);
			this.NewPasswordTextBox.Name = "NewPasswordTextBox";
			this.NewPasswordTextBox.Size = new global::System.Drawing.Size(309, 32);
			this.NewPasswordTextBox.TabIndex = 6;
			this.NewPasswordTextBox.Text = "  New Password";
			this.NewPasswordTextBox.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.NewPasswordTextBox_MouseClick);
			this.GoToLoginMenuButton.FlatAppearance.BorderSize = 0;
			this.GoToLoginMenuButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.GoToLoginMenuButton.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.GoToLoginMenuButton.ForeColor = global::System.Drawing.Color.Red;
			this.GoToLoginMenuButton.Location = new global::System.Drawing.Point(61, 363);
			this.GoToLoginMenuButton.Name = "GoToLoginMenuButton";
			this.GoToLoginMenuButton.Size = new global::System.Drawing.Size(240, 31);
			this.GoToLoginMenuButton.TabIndex = 5;
			this.GoToLoginMenuButton.Text = "Back to Login Menu";
			this.GoToLoginMenuButton.UseVisualStyleBackColor = true;
			this.GoToLoginMenuButton.Click += new global::System.EventHandler(this.GoToLoginMenuButton_Click);
			this.CreateAFreeAccountButton.FlatAppearance.BorderSize = 0;
			this.CreateAFreeAccountButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.CreateAFreeAccountButton.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.CreateAFreeAccountButton.ForeColor = global::System.Drawing.Color.Red;
			this.CreateAFreeAccountButton.Location = new global::System.Drawing.Point(61, 269);
			this.CreateAFreeAccountButton.Name = "CreateAFreeAccountButton";
			this.CreateAFreeAccountButton.Size = new global::System.Drawing.Size(240, 31);
			this.CreateAFreeAccountButton.TabIndex = 4;
			this.CreateAFreeAccountButton.TabStop = false;
			this.CreateAFreeAccountButton.Text = "Create a new account";
			this.CreateAFreeAccountButton.UseVisualStyleBackColor = true;
			this.CreateAFreeAccountButton.Click += new global::System.EventHandler(this.CreateAFreeAccountButton_Click);
			this.ChangeThePasswordButton.BackColor = global::System.Drawing.Color.Red;
			this.ChangeThePasswordButton.FlatAppearance.BorderSize = 0;
			this.ChangeThePasswordButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ChangeThePasswordButton.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.ChangeThePasswordButton.ForeColor = global::System.Drawing.Color.Black;
			this.ChangeThePasswordButton.Location = new global::System.Drawing.Point(27, 221);
			this.ChangeThePasswordButton.Name = "ChangeThePasswordButton";
			this.ChangeThePasswordButton.Size = new global::System.Drawing.Size(309, 31);
			this.ChangeThePasswordButton.TabIndex = 3;
			this.ChangeThePasswordButton.Text = "Change Password";
			this.ChangeThePasswordButton.UseVisualStyleBackColor = false;
			this.ChangeThePasswordButton.Click += new global::System.EventHandler(this.ChangeThePasswordButton_Click);
			this.QuestionAnswerTextBox.BackColor = global::System.Drawing.Color.Black;
			this.QuestionAnswerTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.QuestionAnswerTextBox.ForeColor = global::System.Drawing.Color.Red;
			this.QuestionAnswerTextBox.Location = new global::System.Drawing.Point(27, 63);
			this.QuestionAnswerTextBox.Name = "QuestionAnswerTextBox";
			this.QuestionAnswerTextBox.Size = new global::System.Drawing.Size(309, 32);
			this.QuestionAnswerTextBox.TabIndex = 2;
			this.QuestionAnswerTextBox.Text = "Anwser to Verification Question";
			this.QuestionAnswerTextBox.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.QuestionAnswerTextBox_MouseClick);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(363, 627);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.ExitButton);
			base.Controls.Add(this.MinimizeButton);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel4);
			this.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Forgot_Password_Verify_First_Menu_Form";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GTA V Menu Installer";
			base.Load += new global::System.EventHandler(this.Forgot_Password_Verify_First_Menu_Form_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000057 RID: 87
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.PictureBox LogoPictureBox;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.Button ExitButton;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Button MinimizeButton;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Label HeadingLabel;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.TextBox UsernameTextBox;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Button GoToLoginMenuButton;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Button CreateAFreeAccountButton;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Button ChangeThePasswordButton;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.TextBox QuestionAnswerTextBox;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.TextBox NewPasswordTextBox;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.TextBox NewPasswordAgainTextBox;
	}
}
