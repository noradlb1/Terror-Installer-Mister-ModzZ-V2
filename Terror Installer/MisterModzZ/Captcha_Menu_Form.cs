using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MisterModzZ
{
	// Token: 0x02000010 RID: 16
	public partial class Captcha_Menu_Form : Form
	{
		// Token: 0x0600004A RID: 74 RVA: 0x000024E0 File Offset: 0x000006E0
		public Captcha_Menu_Form()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000024F9 File Offset: 0x000006F9
		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002502 File Offset: 0x00000702
		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
			base.Close();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000475C File Offset: 0x0000295C
		private void ValidateCaptchaButton_Click(object sender, EventArgs e)
		{
			if (Register_Menu_Form.captchaComingRegister && this.CaptchaTextBox.Text == this.PasswordTextBox.Text)
			{
				MessageBox.Show("Enter The Captcha To Create New Account!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Register_Menu_Form.captchaComingRegister = false;
				Login_Menu_Form.captchaComingLogin = false;
				Control control = new Register_Menu_Form();
				base.Close();
				control.Show();
				return;
			}
			if (Login_Menu_Form.captchaComingLogin && this.CaptchaTextBox.Text == this.PasswordTextBox.Text)
			{
				MessageBox.Show("Enter The Captcha To Login!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Register_Menu_Form.captchaComingRegister = false;
				Login_Menu_Form.captchaComingLogin = false;
				Control control2 = new Login_Menu_Form();
				base.Close();
				control2.Show();
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004810 File Offset: 0x00002A10
		private void CaptchaCreator(TextBox textToWrite)
		{
			char[] array = new char[]
			{
				'a',
				'b',
				'c',
				'd',
				'e',
				'f',
				'g',
				'h',
				'i',
				'j',
				'k',
				'l',
				'm',
				'n',
				'o',
				'p',
				'q',
				'r',
				's',
				't',
				'u',
				'v',
				'w',
				'x',
				'y',
				'z',
				'A',
				'B',
				'C',
				'D',
				'E',
				'F',
				'G',
				'H',
				'I',
				'J',
				'K',
				'L',
				'M',
				'M',
				'O',
				'P',
				'Q',
				'R',
				'S',
				'T',
				'U',
				'V',
				'W',
				'X',
				'Y',
				'Z',
				'0',
				'1',
				'2',
				'3',
				'4',
				'5',
				'6',
				'7',
				'8',
				'9',
				'!',
				'^',
				'#',
				'$',
				'+',
				'%',
				'&',
				'/',
				'{',
				'}',
				'[',
				']',
				'(',
				')',
				'=',
				'*',
				'?',
				'-',
				'<',
				'>'
			};
			string text = "";
			for (int i = 0; i <= 8; i++)
			{
				int num = this.randomNumerator.Next(0, array.Length);
				text += array[num].ToString();
			}
			textToWrite.Text = text;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000250F File Offset: 0x0000070F
		private void Captcha_Menu_Form_Load(object sender, EventArgs e)
		{
			this.CaptchaCreator(this.CaptchaTextBox);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000251D File Offset: 0x0000071D
		private void PasswordTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.PasswordTextBox.Text == "  Enter Captcha")
			{
				this.PasswordTextBox.Clear();
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002541 File Offset: 0x00000741
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002543 File Offset: 0x00000743
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.move = true;
			this.mox = e.X;
			this.moy = e.Y;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002541 File Offset: 0x00000741
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002541 File Offset: 0x00000741
		private void LogoPictureBox_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002541 File Offset: 0x00000741
		private void CaptchaTextBox_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000486C File Offset: 0x00002A6C
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.move)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.mox, Control.MousePosition.Y - this.moy);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002564 File Offset: 0x00000764
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this.move = false;
		}

		// Token: 0x0400003C RID: 60
		private Random randomNumerator = new Random();

		// Token: 0x0400003D RID: 61
		private Point lastPoint;

		// Token: 0x0400003E RID: 62
		private int mov;

		// Token: 0x0400003F RID: 63
		private int mox;

		// Token: 0x04000040 RID: 64
		private int moy;

		// Token: 0x04000041 RID: 65
		private bool move;
	}
}
