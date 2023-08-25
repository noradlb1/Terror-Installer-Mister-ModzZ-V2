namespace MisterModzZ
{
	// Token: 0x02000016 RID: 22
	public partial class Login_Menu_Form : global::System.Windows.Forms.Form
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00002975 File Offset: 0x00000B75
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00008B70 File Offset: 0x00006D70
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MisterModzZ.Login_Menu_Form));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.ExitButton = new global::System.Windows.Forms.Button();
			this.MinimizeButton = new global::System.Windows.Forms.Button();
			this.UsernameTextBox = new global::System.Windows.Forms.TextBox();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.checkBox2 = new global::System.Windows.Forms.CheckBox();
			this.ForgotMyPasswordButton = new global::System.Windows.Forms.Button();
			this.CreateAFreeAccountButton = new global::System.Windows.Forms.Button();
			this.LoginButton = new global::System.Windows.Forms.Button();
			this.PasswordTextBox = new global::System.Windows.Forms.TextBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.Red;
			this.panel1.Location = new global::System.Drawing.Point(112, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(139, 10);
			this.panel1.TabIndex = 11;
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
			this.ExitButton.TabIndex = 13;
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new global::System.EventHandler(this.ExitButton_Click);
			this.MinimizeButton.BackColor = global::System.Drawing.Color.Black;
			this.MinimizeButton.FlatAppearance.BorderSize = 0;
			this.MinimizeButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			//this.MinimizeButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MinimizeButton.Image");
			this.MinimizeButton.Location = new global::System.Drawing.Point(285, 6);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.Size = new global::System.Drawing.Size(32, 27);
			this.MinimizeButton.TabIndex = 12;
			this.MinimizeButton.UseVisualStyleBackColor = false;
			this.MinimizeButton.Click += new global::System.EventHandler(this.MinimizeButton_Click);
			this.UsernameTextBox.BackColor = global::System.Drawing.Color.Black;
			this.UsernameTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.UsernameTextBox.ForeColor = global::System.Drawing.Color.Red;
			this.UsernameTextBox.Location = new global::System.Drawing.Point(27, 14);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new global::System.Drawing.Size(309, 32);
			this.UsernameTextBox.TabIndex = 9;
			this.UsernameTextBox.Text = "  Username";
			this.UsernameTextBox.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.UsernameTextBox_MouseClick);
			this.panel4.Controls.Add(this.checkBox2);
			this.panel4.Controls.Add(this.ForgotMyPasswordButton);
			this.panel4.Controls.Add(this.CreateAFreeAccountButton);
			this.panel4.Controls.Add(this.LoginButton);
			this.panel4.Controls.Add(this.PasswordTextBox);
			this.panel4.Controls.Add(this.UsernameTextBox);
			this.panel4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new global::System.Drawing.Point(0, 212);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(363, 257);
			this.panel4.TabIndex = 16;
			this.panel4.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
			this.checkBox2.AutoSize = true;
			this.checkBox2.Font = new global::System.Drawing.Font("Century Gothic", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.checkBox2.ForeColor = global::System.Drawing.Color.Red;
			this.checkBox2.Location = new global::System.Drawing.Point(119, 101);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new global::System.Drawing.Size(135, 23);
			this.checkBox2.TabIndex = 15;
			this.checkBox2.Text = "Show Password";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new global::System.EventHandler(this.checkBox2_CheckedChanged);
			this.ForgotMyPasswordButton.FlatAppearance.BorderSize = 0;
			this.ForgotMyPasswordButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ForgotMyPasswordButton.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.ForgotMyPasswordButton.ForeColor = global::System.Drawing.Color.Red;
			this.ForgotMyPasswordButton.Location = new global::System.Drawing.Point(61, 214);
			this.ForgotMyPasswordButton.Name = "ForgotMyPasswordButton";
			this.ForgotMyPasswordButton.Size = new global::System.Drawing.Size(240, 31);
			this.ForgotMyPasswordButton.TabIndex = 13;
			this.ForgotMyPasswordButton.Text = "Forgot my password";
			this.ForgotMyPasswordButton.UseVisualStyleBackColor = true;
			this.ForgotMyPasswordButton.Click += new global::System.EventHandler(this.ForgotMyPasswordButton_Click);
			this.CreateAFreeAccountButton.FlatAppearance.BorderSize = 0;
			this.CreateAFreeAccountButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.CreateAFreeAccountButton.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.CreateAFreeAccountButton.ForeColor = global::System.Drawing.Color.Red;
			this.CreateAFreeAccountButton.Location = new global::System.Drawing.Point(61, 177);
			this.CreateAFreeAccountButton.Name = "CreateAFreeAccountButton";
			this.CreateAFreeAccountButton.Size = new global::System.Drawing.Size(240, 31);
			this.CreateAFreeAccountButton.TabIndex = 12;
			this.CreateAFreeAccountButton.Text = "Create a free account";
			this.CreateAFreeAccountButton.UseVisualStyleBackColor = true;
			this.CreateAFreeAccountButton.Click += new global::System.EventHandler(this.CreateAFreeAccountButton_Click);
			this.LoginButton.BackColor = global::System.Drawing.Color.Red;
			this.LoginButton.FlatAppearance.BorderSize = 0;
			this.LoginButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.LoginButton.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.LoginButton.ForeColor = global::System.Drawing.Color.Black;
			this.LoginButton.Location = new global::System.Drawing.Point(27, 140);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new global::System.Drawing.Size(309, 31);
			this.LoginButton.TabIndex = 11;
			this.LoginButton.Text = "Log In";
			this.LoginButton.UseVisualStyleBackColor = false;
			this.LoginButton.Click += new global::System.EventHandler(this.LoginButton_Click);
			this.PasswordTextBox.BackColor = global::System.Drawing.Color.Black;
			this.PasswordTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.PasswordTextBox.ForeColor = global::System.Drawing.Color.Red;
			this.PasswordTextBox.Location = new global::System.Drawing.Point(27, 63);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new global::System.Drawing.Size(309, 32);
			this.PasswordTextBox.TabIndex = 10;
			this.PasswordTextBox.Text = "  Password";
			this.PasswordTextBox.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.PasswordTextBox_MouseClick);
			//this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(348, 214);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(363, 469);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.ExitButton);
			base.Controls.Add(this.MinimizeButton);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.pictureBox1);
			this.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login_Menu_Form";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GTA V Menu Installer";
			base.Load += new global::System.EventHandler(this.Login_Menu_Form_Load);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000B1 RID: 177
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.Button ExitButton;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.Button MinimizeButton;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.TextBox UsernameTextBox;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.Button ForgotMyPasswordButton;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Button CreateAFreeAccountButton;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Button LoginButton;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.TextBox PasswordTextBox;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
