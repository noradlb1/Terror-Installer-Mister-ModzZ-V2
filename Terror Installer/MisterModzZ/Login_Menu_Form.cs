using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MisterModzZ
{
	// Token: 0x02000016 RID: 22
	public partial class Login_Menu_Form : Form
	{
		// Token: 0x0600008C RID: 140 RVA: 0x0000852C File Offset: 0x0000672C
		private static string GetIP()
		{
			string result = "";
			using (WebResponse response = WebRequest.Create("https://mistermodzzforum.space/TerrorInstaller/GetIP.php").GetResponse())
			{
				using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
				{
					result = streamReader.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000284F File Offset: 0x00000A4F
		public Login_Menu_Form()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00008598 File Offset: 0x00006798
		public void loadlogin()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string path = folderPath + "/Terror";
			string path2 = folderPath + "/Terror/InstallerLogin.txt";
			if (!Directory.Exists(path))
			{
				return;
			}
			if (File.Exists(folderPath + "/Terror/InstallerLogin.txt"))
			{
				Login_Menu_Form.loginfilethere = true;
				new List<string>();
				foreach (string text in File.ReadAllText(path2).Split(Array.Empty<char>()).ToList<string>())
				{
					if (this.counter == 1)
					{
						this.username = text;
					}
					if (this.counter == 4)
					{
						this.password = text;
					}
					this.counter++;
				}
				File.OpenRead(path2).Close();
				return;
			}
			Login_Menu_Form.loginfilethere = false;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00008688 File Offset: 0x00006888
		public void Afterlogin(string username, string password)
		{
			this.IP_Address = Login_Menu_Form.GetIP();
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["username"] = username;
			nameValueCollection["password"] = password;
			nameValueCollection["IP_Address"] = this.IP_Address;
			string @string = Encoding.UTF8.GetString(webClient.UploadValues("https://mistermodzzforum.space/TerrorInstaller/Installer_Login.php", nameValueCollection));
			if (@string == "Access granted!")
			{
				Login_Menu_Form.loginUsername = username;
				Login_Menu_Form.loginPassword = password;
				new User_Main_Menu_Form();
				base.Opacity = 0.0;
				base.Hide();
				base.ShowInTaskbar = false;
				User_Main_Menu_Form user_Main_Menu_Form = new User_Main_Menu_Form();
				user_Main_Menu_Form.Closed += delegate(object sender, EventArgs e)
				{
					base.Hide();
				};
				user_Main_Menu_Form.Show();
				return;
			}
			if (@string == "Bad username or password")
			{
				this.i++;
				MessageBox.Show("Password Or Username from the Login file was wrong!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Terror/InstallerLogin.txt");
				if (this.i == 5)
				{
					Login_Menu_Form.captchaComingLogin = true;
					Control control = new Captcha_Menu_Form();
					base.Hide();
					control.Show();
					return;
				}
			}
			else
			{
				this.i++;
				MessageBox.Show("Something went wrong pls use the Normal login!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Terror/InstallerLogin.txt");
				if (this.i == 5)
				{
					Login_Menu_Form.captchaComingLogin = true;
					Control control2 = new Captcha_Menu_Form();
					base.Hide();
					control2.Show();
				}
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000287E File Offset: 0x00000A7E
		private void Login_Menu_Form_Load(object sender, EventArgs e)
		{
			this.loadlogin();
			if (Login_Menu_Form.loginfilethere)
			{
				this.Afterlogin(this.username, this.password);
			}
			this.PasswordTextBox.UseSystemPasswordChar = true;
			this.checkBox2.Checked = false;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002502 File Offset: 0x00000702
		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
			base.Close();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000024F9 File Offset: 0x000006F9
		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000028B7 File Offset: 0x00000AB7
		private void UsernameTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.UsernameTextBox.Text == "  Username")
			{
				this.UsernameTextBox.Clear();
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000028DB File Offset: 0x00000ADB
		private void PasswordTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.PasswordTextBox.Text == "  Password")
			{
				this.PasswordTextBox.Clear();
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000028FF File Offset: 0x00000AFF
		private void ForgotMyPasswordButton_Click(object sender, EventArgs e)
		{
			Control control = new Forgot_Password_Verify_First_Menu_Form();
			base.Hide();
			control.Show();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002911 File Offset: 0x00000B11
		private void CreateAFreeAccountButton_Click(object sender, EventArgs e)
		{
			Control control = new Register_Menu_Form();
			base.Hide();
			control.Show();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00008800 File Offset: 0x00006A00
		private void SaveLogintoTxt(string username, string password)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string path = folderPath + "/Terror/InstallerLogin.txt";
			string path2 = folderPath + "/Terror";
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			if (File.Exists(path))
			{
				List<string> list = new List<string>();
				list = File.ReadAllLines(path).ToList<string>();
				foreach (string text in list)
				{
				}
				list.Clear();
				string item = "Username: " + username;
				string item2 = "Password: " + password;
				list.Add(item);
				list.Add(item2);
				File.WriteAllLines(path, list);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000088D8 File Offset: 0x00006AD8
		private void LoginButton_Click(object sender, EventArgs e)
		{
			Login_Menu_Form.captchaComingLogin = true;
			Control control2 = new Captcha_Menu_Form();
			base.Hide();
			control2.Show();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002923 File Offset: 0x00000B23
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.move = true;
			this.mox = e.X;
			this.moy = e.Y;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002944 File Offset: 0x00000B44
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox2.Checked)
			{
				this.PasswordTextBox.UseSystemPasswordChar = false;
				return;
			}
			this.PasswordTextBox.UseSystemPasswordChar = true;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002541 File Offset: 0x00000741
		private void panel4_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008B2C File Offset: 0x00006D2C
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.move)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.mox, Control.MousePosition.Y - this.moy);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000296C File Offset: 0x00000B6C
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this.move = false;
		}

		// Token: 0x040000A1 RID: 161
		public static bool captchaComingLogin;

		// Token: 0x040000A2 RID: 162
		private int i;

		// Token: 0x040000A3 RID: 163
		public static string loginUsername;

		// Token: 0x040000A4 RID: 164
		public static string loginPassword;

		// Token: 0x040000A5 RID: 165
		private static bool autologin = true;

		// Token: 0x040000A6 RID: 166
		private int counter;

		// Token: 0x040000A7 RID: 167
		private string username = "";

		// Token: 0x040000A8 RID: 168
		private string password = "";

		// Token: 0x040000A9 RID: 169
		private static bool loginfilethere = false;

		// Token: 0x040000AA RID: 170
		public bool loggedsuccesfull;

		// Token: 0x040000AB RID: 171
		public string IP_Address = "";

		// Token: 0x040000AC RID: 172
		private Point lastPoint;

		// Token: 0x040000AD RID: 173
		private int mov;

		// Token: 0x040000AE RID: 174
		private int mox;

		// Token: 0x040000AF RID: 175
		private int moy;

		// Token: 0x040000B0 RID: 176
		private bool move;
	}
}
