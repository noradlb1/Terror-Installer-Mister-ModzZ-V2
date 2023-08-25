using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MisterModzZ
{
	// Token: 0x02000011 RID: 17
	public partial class Forgot_Password_Verify_First_Menu_Form : Form
	{
		// Token: 0x0600005A RID: 90 RVA: 0x0000258C File Offset: 0x0000078C
		public Forgot_Password_Verify_First_Menu_Form()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002541 File Offset: 0x00000741
		private void Forgot_Password_Verify_First_Menu_Form_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000259A File Offset: 0x0000079A
		private void QuestionAnswerTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.QuestionAnswerTextBox.Text == "  The question you answered")
			{
				this.QuestionAnswerTextBox.Clear();
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000025BE File Offset: 0x000007BE
		private void UsernameTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.UsernameTextBox.Text == "  Username")
			{
				this.UsernameTextBox.Clear();
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005320 File Offset: 0x00003520
		private void ChangeThePasswordButton_Click(object sender, EventArgs e)
		{
			if (this.UsernameTextBox.Text == "" || this.UsernameTextBox.Text == "  Username" || this.UsernameTextBox.Text == " ")
			{
				MessageBox.Show("Please Enter a Valid Username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (this.QuestionAnswerTextBox.Text == "" || this.QuestionAnswerTextBox.Text == "Anwser to Verification Question" || this.UsernameTextBox.Text == " ")
			{
				MessageBox.Show("Please Enter the Answer to the Verification Question you selected when you created your account.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (this.NewPasswordTextBox.Text == "" || this.NewPasswordTextBox.Text == "  New Password" || this.NewPasswordTextBox.Text == " ")
			{
				MessageBox.Show("Please Enter a valid new Password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (this.NewPasswordAgainTextBox.Text == "" || this.NewPasswordAgainTextBox.Text == "  Re-enter New Password" || this.NewPasswordAgainTextBox.Text == " " || this.NewPasswordTextBox.Text != this.NewPasswordAgainTextBox.Text)
			{
				MessageBox.Show("Error New Password Invalid or not matching", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["username"] = this.UsernameTextBox.Text;
			nameValueCollection["password"] = this.NewPasswordTextBox.Text;
			nameValueCollection["VERIFICATION_QUESTION_ANSWER"] = this.QuestionAnswerTextBox.Text;
			if (Encoding.UTF8.GetString(webClient.UploadValues("https://mistermodzzforum.space/TerrorInstaller/Installer_PW_Reset.php", nameValueCollection)) == "Password changed Sucsessfully")
			{
				MessageBox.Show("Password changed Sucsessfully");
				Control control = new Login_Menu_Form();
				base.Close();
				control.Show();
				return;
			}
			MessageBox.Show("The Information You've Entered Is Incorrect! if you forgot it just press on Delete My Account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002502 File Offset: 0x00000702
		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
			base.Close();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000024F9 File Offset: 0x000006F9
		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000025E2 File Offset: 0x000007E2
		private void CreateAFreeAccountButton_Click(object sender, EventArgs e)
		{
			Control control = new Register_Menu_Form();
			base.Close();
			control.Show();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000025F4 File Offset: 0x000007F4
		private void GoToLoginMenuButton_Click(object sender, EventArgs e)
		{
			Control control = new Login_Menu_Form();
			base.Close();
			control.Show();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002606 File Offset: 0x00000806
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.move = true;
			this.mox = e.X;
			this.moy = e.Y;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002627 File Offset: 0x00000827
		private void button1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("This will Delete all Accounts with your IP Address on them! Are you sure you want to do that ? (You will have to do a few Steps on Linkvertise to do this)", "Mister//ModzZ Multi Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				Process.Start("https://link-to.net/35082/TerrorAccDelete");
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002649 File Offset: 0x00000849
		private void NewPasswordTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.NewPasswordTextBox.Text == "  New Password")
			{
				this.NewPasswordTextBox.Clear();
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000266D File Offset: 0x0000086D
		private void NewPasswordAgainTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.NewPasswordAgainTextBox.Text == "  Re - enter New Password")
			{
				this.NewPasswordAgainTextBox.Clear();
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005574 File Offset: 0x00003774
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.move)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.mox, Control.MousePosition.Y - this.moy);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002691 File Offset: 0x00000891
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this.move = false;
		}

		// Token: 0x04000050 RID: 80
		public static string usernameGo;

		// Token: 0x04000051 RID: 81
		public static string questionAnswerGo;

		// Token: 0x04000052 RID: 82
		private Point lastPoint;

		// Token: 0x04000053 RID: 83
		private int mov;

		// Token: 0x04000054 RID: 84
		private int mox;

		// Token: 0x04000055 RID: 85
		private int moy;

		// Token: 0x04000056 RID: 86
		private bool move;
	}
}
