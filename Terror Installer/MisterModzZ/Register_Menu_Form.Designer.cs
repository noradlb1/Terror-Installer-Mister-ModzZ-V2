namespace MisterModzZ
{
	// Token: 0x02000014 RID: 20
	public partial class Register_Menu_Form : global::System.Windows.Forms.Form
	{
		// Token: 0x06000088 RID: 136 RVA: 0x0000280D File Offset: 0x00000A0D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000784C File Offset: 0x00005A4C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MisterModzZ.Register_Menu_Form));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.ExitButton = new global::System.Windows.Forms.Button();
			this.MinimizeButton = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.LogoPictureBox = new global::System.Windows.Forms.PictureBox();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.HeadingLabel = new global::System.Windows.Forms.Label();
			this.UsernameTextBox = new global::System.Windows.Forms.TextBox();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.AnswerTextBox = new global::System.Windows.Forms.TextBox();
			this.PickAQuestionCombobox = new global::System.Windows.Forms.ComboBox();
			this.PasswordAgainTextBox = new global::System.Windows.Forms.TextBox();
			this.CreateAnAccountButton = new global::System.Windows.Forms.Button();
			this.PasswordTextBox = new global::System.Windows.Forms.TextBox();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.Red;
			this.panel1.Location = new global::System.Drawing.Point(112, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(139, 11);
			this.panel1.TabIndex = 0;
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
			this.ExitButton.TabIndex = 6;
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new global::System.EventHandler(this.ExitButton_Click);
			this.MinimizeButton.BackColor = global::System.Drawing.Color.Black;
			this.MinimizeButton.FlatAppearance.BorderSize = 0;
			this.MinimizeButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			//this.MinimizeButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MinimizeButton.Image");
			this.MinimizeButton.Location = new global::System.Drawing.Point(285, 6);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.Size = new global::System.Drawing.Size(32, 27);
			this.MinimizeButton.TabIndex = 5;
			this.MinimizeButton.UseVisualStyleBackColor = false;
			this.MinimizeButton.Click += new global::System.EventHandler(this.MinimizeButton_Click);
			this.panel2.Controls.Add(this.LogoPictureBox);
			this.panel2.Location = new global::System.Drawing.Point(93, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(176, 140);
			this.panel2.TabIndex = 7;
			//this.LogoPictureBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LogoPictureBox.Image");
			this.LogoPictureBox.Location = new global::System.Drawing.Point(26, 7);
			this.LogoPictureBox.Name = "LogoPictureBox";
			this.LogoPictureBox.Size = new global::System.Drawing.Size(125, 125);
			this.LogoPictureBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.LogoPictureBox.TabIndex = 1;
			this.LogoPictureBox.TabStop = false;
			this.panel3.Controls.Add(this.HeadingLabel);
			this.panel3.Location = new global::System.Drawing.Point(0, 174);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(363, 31);
			this.panel3.TabIndex = 8;
			this.HeadingLabel.AutoSize = true;
			this.HeadingLabel.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.HeadingLabel.ForeColor = global::System.Drawing.Color.Red;
			this.HeadingLabel.Location = new global::System.Drawing.Point(104, 6);
			this.HeadingLabel.Name = "HeadingLabel";
			this.HeadingLabel.Size = new global::System.Drawing.Size(183, 23);
			this.HeadingLabel.TabIndex = 1;
			this.HeadingLabel.Text = "GTAV Terror Menu";
			this.UsernameTextBox.BackColor = global::System.Drawing.Color.Black;
			this.UsernameTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.UsernameTextBox.ForeColor = global::System.Drawing.Color.Red;
			this.UsernameTextBox.Location = new global::System.Drawing.Point(27, 18);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new global::System.Drawing.Size(309, 32);
			this.UsernameTextBox.TabIndex = 0;
			this.UsernameTextBox.Text = "  Username";
			this.UsernameTextBox.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.UsernameTextBox_MouseClick);
			this.panel4.Controls.Add(this.button2);
			this.panel4.Controls.Add(this.button1);
			this.panel4.Controls.Add(this.AnswerTextBox);
			this.panel4.Controls.Add(this.PickAQuestionCombobox);
			this.panel4.Controls.Add(this.PasswordAgainTextBox);
			this.panel4.Controls.Add(this.CreateAnAccountButton);
			this.panel4.Controls.Add(this.PasswordTextBox);
			this.panel4.Controls.Add(this.UsernameTextBox);
			this.panel4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new global::System.Drawing.Point(0, 205);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(363, 405);
			this.panel4.TabIndex = 10;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.button2.ForeColor = global::System.Drawing.Color.Red;
			this.button2.Location = new global::System.Drawing.Point(67, 360);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(240, 31);
			this.button2.TabIndex = 8;
			this.button2.Text = "Go to Login menu";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.button1.ForeColor = global::System.Drawing.Color.Red;
			this.button1.Location = new global::System.Drawing.Point(67, 314);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(240, 31);
			this.button1.TabIndex = 7;
			this.button1.Text = "Delete old account";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.AnswerTextBox.BackColor = global::System.Drawing.Color.Black;
			this.AnswerTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.AnswerTextBox.ForeColor = global::System.Drawing.Color.Red;
			this.AnswerTextBox.Location = new global::System.Drawing.Point(27, 207);
			this.AnswerTextBox.Name = "AnswerTextBox";
			this.AnswerTextBox.Size = new global::System.Drawing.Size(309, 32);
			this.AnswerTextBox.TabIndex = 6;
			this.AnswerTextBox.Text = "  Answer";
			this.AnswerTextBox.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.AnswerTextBox_MouseClick);
			this.PickAQuestionCombobox.BackColor = global::System.Drawing.Color.Black;
			this.PickAQuestionCombobox.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.PickAQuestionCombobox.ForeColor = global::System.Drawing.Color.Red;
			this.PickAQuestionCombobox.FormattingEnabled = true;
			this.PickAQuestionCombobox.Items.AddRange(new object[]
			{
				"What is your first pets name?",
				"What is your first teachers name?",
				"What is your favorite car brand?",
				"What is your favorite fashion brand?"
			});
			this.PickAQuestionCombobox.Location = new global::System.Drawing.Point(27, 158);
			this.PickAQuestionCombobox.Name = "PickAQuestionCombobox";
			this.PickAQuestionCombobox.Size = new global::System.Drawing.Size(309, 31);
			this.PickAQuestionCombobox.TabIndex = 5;
			this.PickAQuestionCombobox.Text = "  Pick A Question";
			this.PasswordAgainTextBox.BackColor = global::System.Drawing.Color.Black;
			this.PasswordAgainTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.PasswordAgainTextBox.ForeColor = global::System.Drawing.Color.Red;
			this.PasswordAgainTextBox.Location = new global::System.Drawing.Point(27, 108);
			this.PasswordAgainTextBox.Name = "PasswordAgainTextBox";
			this.PasswordAgainTextBox.Size = new global::System.Drawing.Size(309, 32);
			this.PasswordAgainTextBox.TabIndex = 2;
			this.PasswordAgainTextBox.Text = "  Re-enter Password";
			this.PasswordAgainTextBox.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.PasswordAgainTextBox_MouseClick);
			this.CreateAnAccountButton.BackColor = global::System.Drawing.Color.Red;
			this.CreateAnAccountButton.FlatAppearance.BorderSize = 0;
			this.CreateAnAccountButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.CreateAnAccountButton.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.CreateAnAccountButton.ForeColor = global::System.Drawing.Color.Black;
			this.CreateAnAccountButton.Location = new global::System.Drawing.Point(27, 261);
			this.CreateAnAccountButton.Name = "CreateAnAccountButton";
			this.CreateAnAccountButton.Size = new global::System.Drawing.Size(309, 31);
			this.CreateAnAccountButton.TabIndex = 3;
			this.CreateAnAccountButton.Text = "Create An Account";
			this.CreateAnAccountButton.UseVisualStyleBackColor = false;
			this.CreateAnAccountButton.Click += new global::System.EventHandler(this.CreateAnAccountButton_Click);
			this.PasswordTextBox.BackColor = global::System.Drawing.Color.Black;
			this.PasswordTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.PasswordTextBox.ForeColor = global::System.Drawing.Color.Red;
			this.PasswordTextBox.Location = new global::System.Drawing.Point(27, 63);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new global::System.Drawing.Size(309, 32);
			this.PasswordTextBox.TabIndex = 1;
			this.PasswordTextBox.Text = "  Password";
			this.PasswordTextBox.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.PasswordTextBox_MouseClick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 23f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(363, 610);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.ExitButton);
			base.Controls.Add(this.MinimizeButton);
			this.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(5);
			base.Name = "Register_Menu_Form";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GTA V Menu Installer";
			base.Load += new global::System.EventHandler(this.Register_Menu_Form_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000090 RID: 144
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Button ExitButton;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Button MinimizeButton;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.PictureBox LogoPictureBox;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.Label HeadingLabel;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.TextBox UsernameTextBox;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.Button CreateAnAccountButton;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.TextBox PasswordTextBox;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.TextBox PasswordAgainTextBox;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.ComboBox PickAQuestionCombobox;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.TextBox AnswerTextBox;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Button button1;
	}
}
