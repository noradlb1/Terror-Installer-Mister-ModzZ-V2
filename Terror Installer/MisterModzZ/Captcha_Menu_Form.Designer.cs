namespace MisterModzZ
{
	// Token: 0x02000010 RID: 16
	public partial class Captcha_Menu_Form : global::System.Windows.Forms.Form
	{
		// Token: 0x06000058 RID: 88 RVA: 0x0000256D File Offset: 0x0000076D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000048B0 File Offset: 0x00002AB0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MisterModzZ.Captcha_Menu_Form));
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.LogoPictureBox = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.ExitButton = new global::System.Windows.Forms.Button();
			this.MinimizeButton = new global::System.Windows.Forms.Button();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.HeadingLabel = new global::System.Windows.Forms.Label();
			this.CaptchaTextBox = new global::System.Windows.Forms.TextBox();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.ValidateCaptchaButton = new global::System.Windows.Forms.Button();
			this.PasswordTextBox = new global::System.Windows.Forms.TextBox();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			base.SuspendLayout();
			this.panel2.Controls.Add(this.LogoPictureBox);
			this.panel2.Location = new global::System.Drawing.Point(93, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(176, 140);
			this.panel2.TabIndex = 20;
			//this.LogoPictureBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LogoPictureBox.Image");
			this.LogoPictureBox.Location = new global::System.Drawing.Point(26, 7);
			this.LogoPictureBox.Name = "LogoPictureBox";
			this.LogoPictureBox.Size = new global::System.Drawing.Size(125, 125);
			this.LogoPictureBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.LogoPictureBox.TabIndex = 1;
			this.LogoPictureBox.TabStop = false;
			this.LogoPictureBox.Click += new global::System.EventHandler(this.LogoPictureBox_Click);
			this.panel1.BackColor = global::System.Drawing.Color.Red;
			this.panel1.Location = new global::System.Drawing.Point(112, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(139, 10);
			this.panel1.TabIndex = 17;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
			this.ExitButton.TabIndex = 19;
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new global::System.EventHandler(this.ExitButton_Click);
			this.MinimizeButton.BackColor = global::System.Drawing.Color.Black;
			this.MinimizeButton.FlatAppearance.BorderSize = 0;
			this.MinimizeButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			//this.MinimizeButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MinimizeButton.Image");
			this.MinimizeButton.Location = new global::System.Drawing.Point(285, 6);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.Size = new global::System.Drawing.Size(32, 27);
			this.MinimizeButton.TabIndex = 18;
			this.MinimizeButton.UseVisualStyleBackColor = false;
			this.MinimizeButton.Click += new global::System.EventHandler(this.MinimizeButton_Click);
			this.panel3.Controls.Add(this.HeadingLabel);
			this.panel3.Location = new global::System.Drawing.Point(0, 174);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(363, 31);
			this.panel3.TabIndex = 21;
			this.HeadingLabel.AutoSize = true;
			this.HeadingLabel.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.HeadingLabel.ForeColor = global::System.Drawing.Color.Red;
			this.HeadingLabel.Location = new global::System.Drawing.Point(104, 6);
			this.HeadingLabel.Name = "HeadingLabel";
			this.HeadingLabel.Size = new global::System.Drawing.Size(197, 23);
			this.HeadingLabel.TabIndex = 1;
			this.HeadingLabel.Text = "MisterModzZ Injector";
			this.CaptchaTextBox.BackColor = global::System.Drawing.Color.Black;
			this.CaptchaTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.CaptchaTextBox.ForeColor = global::System.Drawing.Color.Red;
			this.CaptchaTextBox.Location = new global::System.Drawing.Point(27, 18);
			this.CaptchaTextBox.Name = "CaptchaTextBox";
			this.CaptchaTextBox.Size = new global::System.Drawing.Size(309, 32);
			this.CaptchaTextBox.TabIndex = 9;
			this.CaptchaTextBox.Text = "  Captcha";
			this.CaptchaTextBox.TextChanged += new global::System.EventHandler(this.CaptchaTextBox_TextChanged);
			this.panel4.BackColor = global::System.Drawing.Color.Black;
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.ValidateCaptchaButton);
			this.panel4.Controls.Add(this.PasswordTextBox);
			this.panel4.Controls.Add(this.CaptchaTextBox);
			this.panel4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new global::System.Drawing.Point(0, 212);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(363, 257);
			this.panel4.TabIndex = 22;
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Black;
			this.label2.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label2.ForeColor = global::System.Drawing.Color.Red;
			this.label2.Location = new global::System.Drawing.Point(36, 202);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(300, 23);
			this.label2.TabIndex = 15;
			this.label2.Text = "Enter the captcha to try again";
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Black;
			this.label1.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label1.ForeColor = global::System.Drawing.Color.Red;
			this.label1.Location = new global::System.Drawing.Point(89, 159);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(203, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Too many attempts!";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.ValidateCaptchaButton.BackColor = global::System.Drawing.Color.Red;
			this.ValidateCaptchaButton.FlatAppearance.BorderSize = 0;
			this.ValidateCaptchaButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ValidateCaptchaButton.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.ValidateCaptchaButton.ForeColor = global::System.Drawing.Color.Black;
			this.ValidateCaptchaButton.Location = new global::System.Drawing.Point(27, 107);
			this.ValidateCaptchaButton.Name = "ValidateCaptchaButton";
			this.ValidateCaptchaButton.Size = new global::System.Drawing.Size(309, 31);
			this.ValidateCaptchaButton.TabIndex = 11;
			this.ValidateCaptchaButton.Text = "Validate Captcha";
			this.ValidateCaptchaButton.UseVisualStyleBackColor = false;
			this.ValidateCaptchaButton.Click += new global::System.EventHandler(this.ValidateCaptchaButton_Click);
			this.PasswordTextBox.BackColor = global::System.Drawing.Color.Black;
			this.PasswordTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.PasswordTextBox.ForeColor = global::System.Drawing.Color.Red;
			this.PasswordTextBox.Location = new global::System.Drawing.Point(27, 63);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new global::System.Drawing.Size(309, 32);
			this.PasswordTextBox.TabIndex = 10;
			this.PasswordTextBox.Text = "  Enter Captcha";
			this.PasswordTextBox.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.PasswordTextBox_MouseClick);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(363, 469);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.ExitButton);
			base.Controls.Add(this.MinimizeButton);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel4);
			this.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Captcha_Menu_Form";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mister//ModzZ Gtav Menu Installer";
			base.Load += new global::System.EventHandler(this.Captcha_Menu_Form_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000042 RID: 66
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.PictureBox LogoPictureBox;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Button ExitButton;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Button MinimizeButton;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label HeadingLabel;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.TextBox CaptchaTextBox;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Button ValidateCaptchaButton;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.TextBox PasswordTextBox;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label1;
	}
}
