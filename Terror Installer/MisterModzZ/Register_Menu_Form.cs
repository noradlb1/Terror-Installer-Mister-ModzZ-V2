using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MisterModzZ
{
	// Token: 0x02000014 RID: 20
	public partial class Register_Menu_Form : Form
	{
		// Token: 0x06000077 RID: 119 RVA: 0x0000273A File Offset: 0x0000093A
		public Register_Menu_Form()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000073F8 File Offset: 0x000055F8
		private static string GetIP()
		{
			string text = "";
			using (WebResponse response = WebRequest.Create("https://mistermodzzforum.space/TerrorInstaller/GetIP.php").GetResponse())
			{
				using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
				{
					text = streamReader.ReadToEnd();
					Register_Menu_Form.Users_IP_String = text;
				}
			}
			return text;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002541 File Offset: 0x00000741
		private void Register_Menu_Form_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002502 File Offset: 0x00000702
		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
			base.Close();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000024F9 File Offset: 0x000006F9
		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002753 File Offset: 0x00000953
		private void UsernameTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.UsernameTextBox.Text == "  Username")
			{
				this.UsernameTextBox.Clear();
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002777 File Offset: 0x00000977
		private void PasswordTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.PasswordTextBox.Text == "  Password")
			{
				this.PasswordTextBox.Clear();
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000279B File Offset: 0x0000099B
		private void PasswordAgainTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.PasswordAgainTextBox.Text == "  Re-enter Password")
			{
				this.PasswordAgainTextBox.Clear();
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007468 File Offset: 0x00005668
		private void IPCheck()
		{
			this.IP_Address = Register_Menu_Form.GetIP();
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["IP_Address"] = this.IP_Address;
			if (Encoding.UTF8.GetString(webClient.UploadValues("https://mistermodzzforum.space/TerrorInstaller/Installer_Ip_Acc_Check.php", nameValueCollection)) == "Error you already have a Account")
			{
				MessageBox.Show("Error you already have a Account! Please try to Reset yor Password or Delete your old acc!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.CheckIfIpIsUsed = false;
				return;
			}
			this.CheckIfIpIsUsed = true;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000074E4 File Offset: 0x000056E4
		private void CreateAnAccountButton_Click(object sender, EventArgs e)
		{
			this.IPCheck();
			if (this.CheckIfIpIsUsed)
			{
				if (this.PickAQuestionCombobox.SelectedItem != null && this.UsernameTextBox.Text != "  Username" && this.AnswerTextBox.Text != "  Answer" && this.PasswordTextBox.Text != "  Password" && this.PasswordAgainTextBox.Text != "  Re-enter Password" && this.UsernameTextBox.Text.Length <= 32 && this.PasswordTextBox.Text.Length <= 32 && this.PasswordAgainTextBox.Text.Length <= 32)
				{
					if (this.PasswordTextBox.Text.Length >= 4)
					{
						if (this.UsernameTextBox.Text.Length >= 4)
						{
							Register_Menu_Form.usernameGo = this.UsernameTextBox.Text;
							Register_Menu_Form.passwordGo = this.PasswordTextBox.Text;
							if (this.PasswordTextBox.Text == this.PasswordAgainTextBox.Text && this.PasswordTextBox.Text.Length >= 4)
							{
								this.IP_Address = Register_Menu_Form.GetIP();
								WebClient webClient = new WebClient();
								NameValueCollection nameValueCollection = new NameValueCollection();
								nameValueCollection["username"] = Register_Menu_Form.usernameGo;
								nameValueCollection["password"] = Register_Menu_Form.passwordGo;
								nameValueCollection["IP_Address"] = this.IP_Address;
								nameValueCollection["VERIFICATION_QUESTION"] = this.PickAQuestionCombobox.Text;
								nameValueCollection["VERIFICATION_QUESTION_ANSWER"] = this.AnswerTextBox.Text;
								string @string = Encoding.UTF8.GetString(webClient.UploadValues("https://mistermodzzforum.space/TerrorInstaller/Installer_Register.php", nameValueCollection));
								if (@string == "New record created successfully")
								{
									MessageBox.Show("Account Created Please Login!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									Control control = new Login_Menu_Form();
									base.Close();
									control.Show();
									return;
								}
								if (@string == "Username Already Exits")
								{
									MessageBox.Show("Error that Username is already in Use! Please try another one", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return;
								}
								MessageBox.Show("Unknown Error Please contact Support or Try again.", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return;
							}
							else
							{
								MessageBox.Show("The Passwords Doesn't Match or is to small!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								this.i++;
								if (this.i == 5)
								{
									Register_Menu_Form.captchaComingRegister = true;
									Control control2 = new Captcha_Menu_Form();
									base.Close();
									control2.Show();
									return;
								}
							}
						}
						else
						{
							MessageBox.Show("Error Username is to Short!", "Mister//ModzZ Multi Installer");
							this.i++;
							if (this.i == 5)
							{
								Register_Menu_Form.captchaComingRegister = true;
								Control control3 = new Captcha_Menu_Form();
								base.Close();
								control3.Show();
								return;
							}
						}
					}
					else
					{
						MessageBox.Show("Error Password is to Short!", "Mister//ModzZ Multi Installer");
						this.i++;
						if (this.i == 5)
						{
							Register_Menu_Form.captchaComingRegister = true;
							Control control4 = new Captcha_Menu_Form();
							base.Close();
							control4.Show();
							return;
						}
					}
				}
				else
				{
					MessageBox.Show("Please fill in all the boxes. The Username/Password should be 4-32 Digits!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000025F4 File Offset: 0x000007F4
		private void GoToLoginMenuButton_Click(object sender, EventArgs e)
		{
			Control control = new Login_Menu_Form();
			base.Close();
			control.Show();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00007808 File Offset: 0x00005A08
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.move)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.mox, Control.MousePosition.Y - this.moy);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002627 File Offset: 0x00000827
		private void button1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("This will Delete all Accounts with your IP Address on them! Are you sure you want to do that ? (You will have to do a few Steps on Linkvertise to do this)", "Mister//ModzZ Multi Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				Process.Start("https://link-to.net/35082/TerrorAccDelete");
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000025F4 File Offset: 0x000007F4
		private void button2_Click(object sender, EventArgs e)
		{
			Control control = new Login_Menu_Form();
			base.Close();
			control.Show();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000027BF File Offset: 0x000009BF
		private void AnswerTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.AnswerTextBox.Text == "  Answer")
			{
				this.AnswerTextBox.Clear();
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000027E3 File Offset: 0x000009E3
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this.move = false;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000027EC File Offset: 0x000009EC
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.move = true;
			this.mox = e.X;
			this.moy = e.Y;
		}

		// Token: 0x04000083 RID: 131
		public static string usernameGo;

		// Token: 0x04000084 RID: 132
		public static string passwordGo;

		// Token: 0x04000085 RID: 133
		private int i;

		// Token: 0x04000086 RID: 134
		public static bool captchaComingRegister;

		// Token: 0x04000087 RID: 135
		private int accountChecker;

		// Token: 0x04000088 RID: 136
		private static string Users_IP_String = "";

		// Token: 0x04000089 RID: 137
		private string IP_Address = "";

		// Token: 0x0400008A RID: 138
		private bool CheckIfIpIsUsed;

		// Token: 0x0400008B RID: 139
		private Point lastPoint;

		// Token: 0x0400008C RID: 140
		private int mov;

		// Token: 0x0400008D RID: 141
		private int mox;

		// Token: 0x0400008E RID: 142
		private int moy;

		// Token: 0x0400008F RID: 143
		private bool move;
	}
}
