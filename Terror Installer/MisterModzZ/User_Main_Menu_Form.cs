using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MisterModzZ.Injector;

namespace MisterModzZ
{
	// Token: 0x02000017 RID: 23
	public partial class User_Main_Menu_Form : Form
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00009504 File Offset: 0x00007704
		private void KillGta()
		{
			this.killsuccess = false;
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				if (processes[i].ProcessName == "GTA5")
				{
					int id = processes[i].Id;
					processes[i].Kill();
					this.LogInfo("Successfully killed all Gta5 processes");
					this.killsuccess = true;
				}
			}
			if (!this.killsuccess)
			{
				this.LogInfo("Cant close Gta5 (already closed?)");
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00009578 File Offset: 0x00007778
		private void Uninstall()
		{
			if (File.Exists(this.Appdata + "/Terror/Version.txt"))
			{
				File.Delete(this.Appdata + "/Terror/Version.txt");
				this.LogInfo("removed old Version file");
			}
			if (Directory.Exists(User_Main_Menu_Form.Documents))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(User_Main_Menu_Form.Documents);
				foreach (FileInfo fileInfo in directoryInfo.GetFiles())
				{
					try
					{
						fileInfo.Delete();
						this.LogInfo("removed " + fileInfo);
					}
					catch
					{
						this.LogError("Cant delete: " + fileInfo);
						this.KillGta();
						Thread.Sleep(3000);
						try
						{
							fileInfo.Delete();
							this.LogInfo("removed " + fileInfo);
						}
						catch
						{
							MessageBox.Show("Cant Delete: " + fileInfo + " Please Close all Gta5 Tasks and try again", "Terror Installer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				for (int i = 0; i < directories.Length; i++)
				{
					directories[i].Delete(true);
				}
				Directory.Delete(User_Main_Menu_Form.Documents);
				this.LogInfo("removed old Terror Folder form the Documents Directory");
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000096C0 File Offset: 0x000078C0
		private void UninstallMister()
		{
			if (File.Exists(this.Appdata + "/MisterModzZ/Version.txt"))
			{
				File.Delete(this.Appdata + "/MisterModzZ/Version.txt");
				this.LogInfo("removed old Version file");
			}
			if (Directory.Exists(User_Main_Menu_Form.DocumentsMister))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(User_Main_Menu_Form.DocumentsMister);
				foreach (FileInfo fileInfo in directoryInfo.GetFiles())
				{
					try
					{
						fileInfo.Delete();
						this.LogInfo("removed " + fileInfo);
					}
					catch
					{
						this.LogError("Cant delete: " + fileInfo);
						this.KillGta();
						Thread.Sleep(3000);
						try
						{
							fileInfo.Delete();
							this.LogInfo("removed " + fileInfo);
						}
						catch
						{
							MessageBox.Show("Cant Delete: " + fileInfo + " Please Close all Gta5 Tasks and try again", "Terror Installer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				for (int i = 0; i < directories.Length; i++)
				{
					directories[i].Delete(true);
				}
				Directory.Delete(User_Main_Menu_Form.DocumentsMister);
				this.LogInfo("removed old Mister//ModzZ Folder form the Documents Directory");
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00009808 File Offset: 0x00007A08
		private void GenerateName()
		{
			string text = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			int num = random.Next(5, 21);
			while (num-- > 0)
			{
				stringBuilder.Append(text[random.Next(text.Length)]);
			}
			StringBuilder stringBuilder2 = new StringBuilder();
			Random random2 = new Random();
			int num2 = random2.Next(3, 7);
			while (num2-- > 0)
			{
				stringBuilder2.Append(text[random2.Next(text.Length)]);
			}
			this.newfilename = stringBuilder.ToString() + "." + stringBuilder2.ToString();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000098B4 File Offset: 0x00007AB4
		private void SpoofFileSize(string Path)
		{
			string text = "0123456789";
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			int num = random.Next(5, 8);
			while (num-- > 0)
			{
				stringBuilder.Append(text[random.Next(text.Length)]);
			}
			int num2 = int.Parse(stringBuilder.ToString());
			using (FileStream fileStream = new FileStream(Path, FileMode.Append, FileAccess.Write, FileShare.None))
			{
				byte[] array = new byte[num2];
				fileStream.Write(array, 0, array.Length);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000994C File Offset: 0x00007B4C
		private void ChangeMenuFileName(string menufile, string documentslocation)
		{
			this.GenerateName();
			try
			{
				File.Move(menufile, documentslocation + "/" + this.newfilename);
				File.Delete(menufile);
				this.LogInfo("Sucessfully renamed the menu file");
				string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Terror/MenuName.txt";
				if (!File.Exists(path))
				{
					File.Create(path).Close();
				}
				if (File.Exists(path))
				{
					List<string> list = new List<string>();
					list = File.ReadAllLines(path).ToList<string>();
					list.Clear();
					list.Add(this.newfilename);
					File.WriteAllLines(path, list);
					this.LogInfo("Sucessfully saved name of new Menu File");
				}
			}
			catch
			{
				this.LogError("Cant rename the Menu File!");
			}
			this.SpoofFileSize(documentslocation + "/" + this.newfilename);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00009A24 File Offset: 0x00007C24
		private void ChangeMenuFileName2(string menufile, string documentslocation)
		{
			this.GenerateName();
			try
			{
				File.Move(menufile, documentslocation + "/" + this.newfilename);
				File.Delete(menufile);
				this.LogInfo("Sucessfully renamed the menu file");
				string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/MisterModzZ/MenuName.txt";
				if (!File.Exists(path))
				{
					File.Create(path).Close();
				}
				if (File.Exists(path))
				{
					List<string> list = new List<string>();
					list = File.ReadAllLines(path).ToList<string>();
					list.Clear();
					list.Add(this.newfilename);
					File.WriteAllLines(path, list);
					this.LogInfo("Sucessfully saved name of new Menu File");
				}
				else
				{
					this.LogError("Cant Create Menuname.txt File");
				}
			}
			catch
			{
				this.LogError("Cant rename the Menu File!");
			}
			this.SpoofFileSize(documentslocation + "/" + this.newfilename);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00009B08 File Offset: 0x00007D08
		private void InstallTerror(string location)
		{
			if (!Directory.Exists(User_Main_Menu_Form.Documents))
			{
				Directory.CreateDirectory(User_Main_Menu_Form.Documents);
				this.LogInfo("Created Documents Folder Successfully!");
			}
			if (!Directory.Exists(User_Main_Menu_Form.Documents))
			{
				this.LogError("Cant Create  Folder under Documents!");
				this.LogInfo("Please run the Installer as Admin + Disable anti Virus Programm and try again");
			}
			string address = "http://mistermodzzforum.space/Downloads/KPmcvgQdA34aJ8BX.zip";
			string text = location + "/KPmcvgQdA34aJ8BX.zip";
			using (WebClient webClient = new WebClient())
			{
				try
				{
					webClient.DownloadFile(address, text);
					this.LogInfo("Downloaded menu files zip successfully");
				}
				catch
				{
					this.Erfolg = false;
					this.LogError("Cant download the menu files zip");
				}
				if (File.Exists(text))
				{
					ZipFile.ExtractToDirectory(text, location);
					this.LogInfo("unzipped menu files successfully");
				}
				else
				{
					this.LogError("Cant find menu files zip");
					this.Erfolg = false;
				}
				try
				{
					File.Delete(text);
					this.LogInfo("removed menu files zip successfully");
				}
				catch
				{
					this.LogError("Cant delete the menu files zip");
				}
				if (File.Exists(location + "/UpP1YrVpA74DW11Y.menu"))
				{
					this.ChangeMenuFileName(location + "/UpP1YrVpA74DW11Y.menu", location);
					this.LogInfo("Downloaded and installed the Terror folder successfull");
					this.Terrorsuccess = true;
				}
				else
				{
					this.Erfolg = false;
					this.LogError("The Terror Folder in Documents didnt install Corerectly!");
					this.LogInfo("Please run the Installer as Admin + Disable anti Virus Programm and try again");
					this.Terrorsuccess = false;
				}
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00009C7C File Offset: 0x00007E7C
		private void InstallMisterModzZ(string location)
		{
			if (!Directory.Exists(User_Main_Menu_Form.DocumentsMister))
			{
				Directory.CreateDirectory(User_Main_Menu_Form.DocumentsMister);
				this.LogInfo("Created MisterModzZ documents folder successfully!");
			}
			if (!Directory.Exists(User_Main_Menu_Form.DocumentsMister))
			{
				this.LogError("Cant create MisterModzZ folder under documents!");
				this.LogInfo("Please run the installer as admin + disable anti virus programm and try again");
			}
			if (!Directory.Exists(this.Appdata + "/MisterModzZ"))
			{
				Directory.CreateDirectory(this.Appdata + "/MisterModzZ");
			}
			if (!Directory.Exists(this.Appdata + "/MisterModzZ"))
			{
				this.LogError("Cant create MisterModzZ folder under Appdata!");
			}
			string address = "https://mistermodzzforum.space/TerrorInstaller/MisterModzZV2/MenuFiles.zip";
			string text = location + "/MenuFiles.zip";
			using (WebClient webClient = new WebClient())
			{
				try
				{
					webClient.DownloadFile(address, text);
					this.LogInfo("Downloaded Mister//ModzZ menu files zip successfully");
				}
				catch
				{
					this.Erfolg2 = false;
					this.LogError("Cant download Mister//ModzZ menu files zip");
				}
				if (File.Exists(text))
				{
					ZipFile.ExtractToDirectory(text, location);
					this.LogInfo("unzipped menu files successfully");
				}
				else
				{
					this.LogError("Cant find menu files zip");
					this.Erfolg2 = false;
				}
				try
				{
					File.Delete(text);
					this.LogInfo("removed menu files zip successfully");
				}
				catch
				{
					this.LogError("Cant delete the menu files zip");
				}
				if (File.Exists(location + "/c3NSpqDvkTxYaysr.g6hmMn"))
				{
					this.ChangeMenuFileName2(location + "/c3NSpqDvkTxYaysr.g6hmMn", location);
					this.LogInfo("Downloaded and Installed the Mister//ModzZ Folder Successfull");
					this.Mistersuccess = true;
				}
				else
				{
					this.Erfolg2 = false;
					this.LogError("The MisterModzZ Folder in Documents didnt install Corerectly!");
					this.LogInfo("Please run the Installer as Admin + Disable anti Virus Programm and try again");
					this.Mistersuccess = false;
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00009E40 File Offset: 0x00008040
		private void Download_Terror()
		{
			Programm_Busy.CurrentProcess = "Uninsatlling Old Menu Files...";
			this.Uninstall();
			Programm_Busy.CurrentProcess = "Installing New Menu Files...";
			this.InstallTerror(User_Main_Menu_Form.Documents);
			if (this.Terrorsuccess)
			{
				this.LogInfo("Downloaded and Installed Files successfully");
				return;
			}
			this.Erfolg = false;
			MessageBox.Show("[ERROR] Cant install Terror Folder! Please Disable antivirus, Run Porgramm as Admin and Try Again!");
			this.LogError("Something went wrong douring the Terror Folder Installtion");
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000029A2 File Offset: 0x00000BA2
		public void Get_Gtav_Path_and_Install_Menu()
		{
			this.Download_Terror();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00009EA4 File Offset: 0x000080A4
		public void MisterModzZInstall()
		{
			Programm_Busy.CurrentProcess = "Uninsatlling Old Mister//ModzZ Menu Files...";
			this.UninstallMister();
			Programm_Busy.CurrentProcess = "Installing New  Mister//ModzZ Menu Files...";
			this.InstallMisterModzZ(User_Main_Menu_Form.DocumentsMister);
			if (this.Mistersuccess)
			{
				this.LogInfo("Downloaded and Installed Mister//ModzZ Files successfully");
				return;
			}
			this.Erfolg2 = false;
			MessageBox.Show("[ERROR] Cant install Mister//ModzZ Folder! Please Disable antivirus, Run Porgramm as Admin and Try Again!");
			this.LogError("Something went wrong douring the Mister//ModzZ Folder Installtion");
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00009F08 File Offset: 0x00008108
		public void Injection_Key(int Menu)
		{
			string text = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			int num = random.Next(10, 21);
			while (num-- > 0)
			{
				stringBuilder.Append(text[random.Next(text.Length)]);
			}
			this.Injection_Key_String = stringBuilder.ToString();
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["username"] = this.username;
			nameValueCollection["password"] = this.password;
			nameValueCollection["Injection_Key"] = this.Injection_Key_String;
			Encoding.UTF8.GetString(webClient.UploadValues("https://mistermodzzforum.space/TerrorInstaller/Installer_Insert_Injection_Key.php", nameValueCollection));
			this.LogInfo(this.Injection_Key_String);
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Terror/Injection_Key.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			if (File.Exists(path))
			{
				List<string> list = new List<string>();
				list = File.ReadAllLines(path).ToList<string>();
				list.Clear();
				list.Add(this.Injection_Key_String);
				File.WriteAllLines(path, list);
				this.LogInfo("Sucessfully saved Injection Key of new Menu File");
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000A038 File Offset: 0x00008238
		public void Get_New_Menu_Name()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Terror/MenuName.txt";
			if (!File.Exists(path))
			{
				this.LogError("MenuName File Doesnt Exist");
				MessageBox.Show("Error The MenuName.txt File is Missing! Disable your anitvirus and Runt the Programm as Admin!");
				this.Erfolg = false;
				return;
			}
			new List<string>();
			foreach (string text in File.ReadAllLines(path).ToList<string>())
			{
				this.Menunametest = text.ToString();
			}
			File.OpenRead(path).Close();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000A0E0 File Offset: 0x000082E0
		public void Get_New_MisterModzZ_Name()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/MisterModzZ/MenuName.txt";
			if (!File.Exists(path))
			{
				this.LogError("MenuName File Doesnt Exist");
				this.MisterModzZInstall();
				this.Erfolg2 = false;
				return;
			}
			new List<string>();
			foreach (string text in File.ReadAllLines(path).ToList<string>())
			{
				this.Menunametest2 = text.ToString();
			}
			File.OpenRead(path).Close();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000A184 File Offset: 0x00008384
		private bool terrorverscheck()
		{
			string b = "";
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string path = folderPath + "/Terror/Version.txt";
			if (!File.Exists(folderPath + "/Terror/Version.txt"))
			{
				this.LogInfo("No Terror Version File found");
				return false;
			}
			new List<string>();
			using (List<string>.Enumerator enumerator = File.ReadAllLines(path).ToList<string>().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					b = enumerator.Current;
				}
			}
			File.OpenRead(path).Close();
			WebClient webClient = new WebClient();
			string address = "https://mistermodzzforum.space/authserver/Terrormenu.php/";
			byte[] bytes = webClient.DownloadData(address);
			string @string = new UTF8Encoding().GetString(bytes);
			if (@string == b)
			{
				this.LogInfo("latest Terror Menu Version is installed");
				if (this.ButtonVersionCheck)
				{
					this.terrorlatest = 1;
				}
				return true;
			}
			this.LogInfo("Your Terror Menu is Outdated");
			this.LogInfo("Latest Terror Version is:  " + @string);
			if (this.ButtonVersionCheck)
			{
				this.terrorlatest = 2;
			}
			return false;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000A294 File Offset: 0x00008494
		private bool MisterVerscheck()
		{
			string b = "";
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string path = folderPath + "/MisterModzZ/Version.txt";
			if (!File.Exists(folderPath + "/MisterModzZ/Version.txt"))
			{
				this.LogInfo("No Mister//ModzZ Version File found");
				return false;
			}
			new List<string>();
			using (List<string>.Enumerator enumerator = File.ReadAllLines(path).ToList<string>().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					b = enumerator.Current;
				}
			}
			File.OpenRead(path).Close();
			WebClient webClient = new WebClient();
			string address = "https://mistermodzzforum.space/TerrorInstaller/MisterModzZV2/Version.php/";
			byte[] bytes = webClient.DownloadData(address);
			string @string = new UTF8Encoding().GetString(bytes);
			if (@string == b)
			{
				this.LogInfo("latest Mister//ModzZ Version is installed");
				if (this.ButtonVersionCheck)
				{
					this.misterlatest = 1;
				}
				return true;
			}
			this.LogInfo("Your Mister//ModzZ Menu is Outdated");
			this.LogInfo("Latest Mister//ModzZ Version is:  " + @string);
			if (this.ButtonVersionCheck)
			{
				this.misterlatest = 2;
			}
			return false;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000A3A4 File Offset: 0x000085A4
		private bool MenuVersionCheck(int Menu)
		{
			if (Menu == 1)
			{
				string b = "";
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string path = folderPath + "/Terror/Version.txt";
				if (!File.Exists(folderPath + "/Terror/Version.txt"))
				{
					this.LogInfo("No Version File found");
					return false;
				}
				new List<string>();
				using (List<string>.Enumerator enumerator = File.ReadAllLines(path).ToList<string>().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						b = enumerator.Current;
					}
				}
				File.OpenRead(path).Close();
				WebClient webClient = new WebClient();
				string address = "https://mistermodzzforum.space/authserver/Terrormenu.php/";
				byte[] bytes = webClient.DownloadData(address);
				string @string = new UTF8Encoding().GetString(bytes);
				if (@string == b)
				{
					this.LogInfo("latest Terror Menu Version is installed");
					if (this.ButtonVersionCheck)
					{
						MessageBox.Show("latest Menu Version is installed ", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					return true;
				}
				this.LogInfo("Your Terror Menu is Outdated");
				this.LogInfo("Latest Terror Version is:  " + @string);
				if (this.ButtonVersionCheck)
				{
					MessageBox.Show("You dont have the latest Terror Version! Latest version is " + @string, "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				return false;
			}
			else
			{
				if (Menu != 2)
				{
					this.terrorverscheck();
					this.MisterVerscheck();
					if (this.ButtonVersionCheck)
					{
						if (this.terrorlatest == 2 && this.misterlatest == 2)
						{
							MessageBox.Show("Both Menus are Outdated! By pressing Inject they get Updated automaticly", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return false;
						}
						if (this.terrorlatest == 2 && this.misterlatest != 2)
						{
							MessageBox.Show("Only the Terror Menu is Outdated. It gets auto updated when you inject it", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return false;
						}
						if (this.terrorlatest != 2 && this.misterlatest == 2)
						{
							MessageBox.Show("Only the Mister//ModzZ Menu is Outdated. It gets auto updated when you inject it", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return false;
						}
						if (this.terrorlatest == 0 && this.misterlatest == 0)
						{
							MessageBox.Show("Error You have to use the menus at least once to use this", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return false;
						}
						if (this.terrorlatest == 0)
						{
							MessageBox.Show("Terror Outdated", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return false;
						}
					}
					return true;
				}
				string b2 = "";
				string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string path2 = folderPath2 + "/MisterModzZ/Version.txt";
				if (!File.Exists(folderPath2 + "/MisterModzZ/Version.txt"))
				{
					this.LogInfo("No Version File found");
					return false;
				}
				new List<string>();
				using (List<string>.Enumerator enumerator = File.ReadAllLines(path2).ToList<string>().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						b2 = enumerator.Current;
					}
				}
				File.OpenRead(path2).Close();
				WebClient webClient2 = new WebClient();
				string address2 = "https://mistermodzzforum.space/TerrorInstaller/MisterModzZV2/Version.php/";
				byte[] bytes2 = webClient2.DownloadData(address2);
				string string2 = new UTF8Encoding().GetString(bytes2);
				if (string2 == b2)
				{
					this.LogInfo("latest Mister//ModzZ Version is installed");
					if (this.ButtonVersionCheck)
					{
						MessageBox.Show("latest Mister//ModzZ Version is installed ", "Mister//ModzZ Installer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					return true;
				}
				this.LogInfo("Your Mister//ModzZ Menu is Outdated");
				this.LogInfo("Latest Mister//ModzZ Version is:  " + string2);
				if (this.ButtonVersionCheck)
				{
					MessageBox.Show("You dont have the latest Mister//ModzZ Version! Latest version is " + string2, "Mister//ModzZ Installer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				return false;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000A6DC File Offset: 0x000088DC
		public bool IsProcessOpen(string name)
		{
			Process[] processes = Process.GetProcesses();
			int i = 0;
			while (i < processes.Length)
			{
				Process process = processes[i];
				if (!process.ProcessName.Contains(name))
				{
					i++;
				}
				else
				{
					if (process.ProcessName == null)
					{
						this.LogError("Cant handle other processes");
						return false;
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000A728 File Offset: 0x00008928
		private bool Inject_DLL(string Path)
		{
			if (!File.Exists(Path))
			{
				this.LogError("Menu File not Found!");
				this.injecterror = 1;
				return false;
			}
			Injection.GetInstance.Inject("GTA5", Path);
			if (!Injection.GetInstance.Injectionsuccess)
			{
				this.LogError("Injection Failed! Error #432");
				this.LogError("Gta5 not found! Load Gta5 into story mode!");
				return false;
			}
			return true;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000A788 File Offset: 0x00008988
		public User_Main_Menu_Form()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000A80C File Offset: 0x00008A0C
		public void UpdateLog(string texttoadd)
		{
			try
			{
				string item = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + " " + texttoadd;
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string path = folderPath + "\\Terror\\InstallerLog.txt";
				string item2 = "===============================================================";
				string item3 = "              Welcome to the Mister//ModzZ Injecter";
				string item4 = "===============================================================";
				if (!Directory.Exists(folderPath + "\\Terror"))
				{
					Directory.CreateDirectory(folderPath + "\\Terror");
				}
				if (!File.Exists(path))
				{
					File.Create(path).Close();
				}
				if (File.Exists(path))
				{
					List<string> list = new List<string>();
					list = File.ReadAllLines(path).ToList<string>();
					if ((this.richTextBox1.Text == "                  WELCOME TO THE MISTER//MODZZ MULTI INSTALLER" | this.richTextBox1.Text == "             WELCOME TO THE MISTER//MODZZ MULTI INSTALLER (VIP VERS)") && !this.justcleared)
					{
						list.Add(item2);
						list.Add(item3);
						list.Add(item4);
					}
					list.Add(item);
					File.WriteAllLines(path, list);
				}
			}
			catch
			{
				this.StopsavingLog = true;
				this.LogError("Cant write to log file");
				this.StopsavingLog = false;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000A940 File Offset: 0x00008B40
		public void LogInfo(string msg)
		{
			string text = this.richTextBox1.Text;
			text = text + "\n [INFO] " + msg;
			if (!this.StopsavingLog)
			{
				this.UpdateLog("[INFO] " + msg);
			}
			this.richTextBox1.Text = text;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000A98C File Offset: 0x00008B8C
		public void LogWarning(string msg)
		{
			string text = this.richTextBox1.Text;
			text = text + "\n [WARNING] " + msg;
			if (!this.StopsavingLog)
			{
				this.UpdateLog("[WARNING] " + msg);
			}
			this.richTextBox1.Text = text;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000A9D8 File Offset: 0x00008BD8
		public void LogError(string msg)
		{
			string text = this.richTextBox1.Text;
			text = text + "\n [ERROR] " + msg;
			if (!this.StopsavingLog)
			{
				this.UpdateLog("[ERROR] " + msg);
			}
			this.richTextBox1.Text = text;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000AA24 File Offset: 0x00008C24
		private bool Ping_Forum()
		{
			bool result;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://mistermodzzforum.space/");
				httpWebRequest.Timeout = 3000;
				httpWebRequest.AllowAutoRedirect = false;
				httpWebRequest.Method = "HEAD";
				using (httpWebRequest.GetResponse())
				{
					this.Forum_State = true;
					result = true;
				}
			}
			catch
			{
				this.LogError("Forum Site is currently offline / no connection possible");
				this.Forum_State = false;
				result = false;
			}
			return result;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000AAAC File Offset: 0x00008CAC
		private bool Ping_MisterModzZ()
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://mistermodzz.com/");
				httpWebRequest.Timeout = 3000;
				httpWebRequest.AllowAutoRedirect = false;
				httpWebRequest.Method = "HEAD";
				using (httpWebRequest.GetResponse())
				{
					this.mistermodzzsitestate = true;
				}
			}
			catch
			{
				this.mistermodzzsitestate = false;
				this.LogError("MisterModzZ.com is currently offline /no connection possible");
			}
			return this.mistermodzzsitestate;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000AB38 File Offset: 0x00008D38
		private void Loginladen()
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
				new List<string>();
				foreach (string text in File.ReadAllText(path2).Split(Array.Empty<char>()).ToList<string>())
				{
					if (this.counter2 == 1)
					{
						this.username = text;
					}
					if (this.counter2 == 4)
					{
						this.password = text;
					}
					this.counter2++;
				}
				File.OpenRead(path2).Close();
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000AC18 File Offset: 0x00008E18
		private void User_Main_Menu_Form_Load(object sender, EventArgs e)
		{
			this.Loginladen();
			this.Ping_Forum();
			this.Ping_MisterModzZ();
			this.Check_Is_Patreon();
			this.Username_Label.Text = "Welcome " + this.username + "!";
			if (this.is_Patreon)
			{
				this.richTextBox1.Text = "             WELCOME TO THE MISTER//MODZZ MULTI INSTALLER (VIP VERS)";
			}
			this.Installer_Versionchecker();
			this.label1.Text = "MULTI INSTALLER V" + this.Currentversion;
			if (!Directory.Exists(this.Appdata + "/MisterModzZ"))
			{
				Directory.CreateDirectory(this.Appdata + "/MisterModzZ");
			}
			if (!Directory.Exists(this.Appdata + "/Terror"))
			{
				Directory.CreateDirectory(this.Appdata + "/Terror");
			}
			this.timer2.Start();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000029AA File Offset: 0x00000BAA
		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
			Application.Exit();
			base.Close();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000024F9 File Offset: 0x000006F9
		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000AD00 File Offset: 0x00008F00
		private int Check_Remained_Injections()
		{
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["username"] = this.username;
			nameValueCollection["password"] = this.password;
			string @string = Encoding.UTF8.GetString(webClient.UploadValues("https://mistermodzzforum.space/TerrorInstaller/Installer_Remaind_Injects.php", nameValueCollection));
			if (!int.TryParse(@string, out this.n))
			{
				this.LogError("Cant Check Remained Injections");
				this.LogError(@string);
				MessageBox.Show("Remained Injection check Failed Please show this MisterModzZ!");
			}
			else
			{
				this.remainedInjection = int.Parse(@string);
			}
			return this.remainedInjection;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000AD94 File Offset: 0x00008F94
		private int Check_Is_Patreon()
		{
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["username"] = this.username;
			nameValueCollection["password"] = this.password;
			string @string = Encoding.UTF8.GetString(webClient.UploadValues("https://mistermodzzforum.space/TerrorInstaller/Installer_is_Patreon.php", nameValueCollection));
			if (!int.TryParse(@string, out this.n))
			{
				this.LogError("Patreon Check messsed up!");
				this.LogError(@string);
				MessageBox.Show("Patreon check Failed Please show this MisterModzZ!");
			}
			this.ispatreonint = int.Parse(@string);
			if (this.ispatreonint == 1)
			{
				this.is_Patreon = true;
			}
			return this.ispatreonint;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000AE34 File Offset: 0x00009034
		private void Remove_One_Remained_Injection()
		{
			this.remainedInjection--;
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["username"] = this.username;
			nameValueCollection["password"] = this.password;
			nameValueCollection["Remained_Injection"] = this.remainedInjection.ToString();
			Encoding.UTF8.GetString(webClient.UploadValues("https://mistermodzzforum.space/TerrorInstaller/Installer_Update_Remaind_Injections.php", nameValueCollection));
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000AEAC File Offset: 0x000090AC
		private void Total_Injections_Increment()
		{
			this.username = Login_Menu_Form.loginUsername;
			this.password = Login_Menu_Form.loginPassword;
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["username"] = this.username;
			nameValueCollection["password"] = this.password;
			string @string = Encoding.UTF8.GetString(webClient.UploadValues("https://mistermodzzforum.space/TerrorInstaller/Installer_Get_Total_Injects.php", nameValueCollection));
			if (!int.TryParse(@string, out this.n))
			{
				this.LogError("Total Injections update failed");
				if (this.Betaversion)
				{
					this.LogError(@string);
					return;
				}
			}
			else
			{
				int num = int.Parse(@string);
				num++;
				WebClient webClient2 = new WebClient();
				NameValueCollection nameValueCollection2 = new NameValueCollection();
				nameValueCollection2["username"] = this.username;
				nameValueCollection2["password"] = this.password;
				nameValueCollection2["Injection_Count"] = num.ToString();
				Encoding.UTF8.GetString(webClient2.UploadValues("https://mistermodzzforum.space/TerrorInstaller/Installer_Injection_Count.php", nameValueCollection2));
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000AFA8 File Offset: 0x000091A8
		public void IsTerrorEnabled()
		{
			WebClient webClient = new WebClient();
			string address = "https://mistermodzzforum.space/authserver/IsTerrorEnabled.php/";
			byte[] bytes = webClient.DownloadData(address);
			string @string = new UTF8Encoding().GetString(bytes);
			if (@string == "Enabled")
			{
				this.LogInfo("Terror Menu is Enabled on the Server");
				this.TerrorEnabled = true;
				return;
			}
			this.LogInfo("Terror Menu is DISABLED on the Server");
			this.LogInfo(@string);
			MessageBox.Show(@string, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000B014 File Offset: 0x00009214
		public void IsTerrorUndetected()
		{
			WebClient webClient = new WebClient();
			string address = "https://mistermodzzforum.space/authserver/TerrorDetected.php/";
			byte[] bytes = webClient.DownloadData(address);
			if (new UTF8Encoding().GetString(bytes) == "Undetected")
			{
				this.LogInfo("Terror is Undetected atm");
				this.TerrorUndetected = true;
				return;
			}
			this.LogInfo("Terror Menu is Detected !");
			if (MessageBox.Show("WARNING the Terror Mod Menu is DETECTED rn! Do you still want to Inject it ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				this.TerrorUndetected = true;
				return;
			}
			this.LogInfo("You choose to not Inject the menu because its Detected");
			this.TerrorUndetected = false;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000B098 File Offset: 0x00009298
		public void InjectingTerror()
		{
			if (this.AlreadyInjectedAMenu)
			{
				this.LogInfo("You already Injected a Menu!");
				if (MessageBox.Show("You already Injected the Menu! Did you restart your game and want to Inject the Menu now?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					this.AlreadyInjectedAMenu = false;
				}
			}
			if (!this.AlreadyInjectedAMenu)
			{
				this.IsTerrorEnabled();
				this.IsTerrorUndetected();
				if (this.TerrorUndetected && this.TerrorEnabled)
				{
					this.CurrentInjectinMenu = 1;
					new Programm_Busy();
					if (this.is_Patreon)
					{
						this.LogInfo("Patreon Mode is enabled and ads are disabled Enjoy!");
						this.remainedInjection = 10;
					}
					else
					{
						this.Check_Remained_Injections();
					}
					if (this.remainedInjection == 0 | this.remainedInjection <= 0)
					{
						if (MessageBox.Show("Yo Have 0 Injections Left! Would you like to Watch an Advertisement to Unlock more (FREE) Injections? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
						{
							Process.Start("https://link-to.net/35082/TerrorInjections");
							this.LogInfo("Please get more injections and then Inject again");
						}
						else
						{
							MessageBox.Show("Ok Menu DOESNT Get Injected Now!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							this.LogInfo("No Injections Left Please watch the Addvertisement!");
						}
					}
					else
					{
						Programm_Busy programm_Busy = new Programm_Busy();
						programm_Busy.Show();
						Programm_Busy.CurrentProcess = "Checking Menu Version...";
						while (Programm_Busy.Busybarshown == 1)
						{
							Thread.Sleep(100);
						}
						if (!this.MenuVersionCheck(this.CurrentInjectinMenu))
						{
							Programm_Busy.CurrentProcess = "Insatlling latest Menu Version...";
							this.LogInfo("Auto Instaling latest Menu Version Now");
							this.Get_Gtav_Path_and_Install_Menu();
						}
						this.Get_New_Menu_Name();
						this.Injection_Key(this.CurrentInjectinMenu);
						if (this.Erfolg)
						{
							Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
							Programm_Busy.CurrentProcess = "Injecting Dll...";
							if (!this.is_Patreon)
							{
								this.LogInfo("Remained Injections: " + this.remainedInjection);
							}
							if (this.Inject_DLL(User_Main_Menu_Form.Documents + "\\" + this.Menunametest))
							{
								this.Total_Injections_Increment();
								if (!this.is_Patreon)
								{
									this.Remove_One_Remained_Injection();
								}
								Thread.Sleep(1000);
								this.LogInfo("It can take up to 30 sec untill you see the Menu ingame");
								this.LogInfo("--------------INJECTED TERROR SUCCESFULL---------------");
								this.AlreadyInjectedAMenu = true;
								if (!this.is_Patreon)
								{
									MessageBox.Show(string.Format("Cheat Injected Successsful, Remained Injections: {0}", this.remainedInjection), "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								}
								programm_Busy.Hide();
							}
							else
							{
								if (this.injecterror == 1)
								{
									this.LogInfo("Menu File was missing trying to reinstall the menu");
									this.Get_Gtav_Path_and_Install_Menu();
									this.Get_New_Menu_Name();
									if (this.Inject_DLL(User_Main_Menu_Form.Documents + "\\" + this.Menunametest))
									{
										this.Total_Injections_Increment();
										if (!this.is_Patreon)
										{
											this.Remove_One_Remained_Injection();
										}
										Thread.Sleep(1000);
										if (!this.is_Patreon)
										{
											MessageBox.Show(string.Format("Cheat Injected Successsful, Remained Injections: {0}", this.remainedInjection), "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
										}
										else
										{
											MessageBox.Show("Cheat Injected Successsful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
										}
										programm_Busy.Hide();
									}
								}
								programm_Busy.Hide();
							}
						}
					}
					this.CurrentInjectinMenu = 0;
				}
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000029BC File Offset: 0x00000BBC
		private void LaunchTheCheatButton_Click(object sender, EventArgs e)
		{
			this.InjectingTerror();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000B38C File Offset: 0x0000958C
		private void LogOutButton_Click(object sender, EventArgs e)
		{
			string path = this.Appdata + "/Terror/InstallerLogin.txt";
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			this.SideNavigationPanel.Top = this.LogOutButton.Top;
			this.SideNavigationPanel.Height = this.LogOutButton.Height;
			Control control = new Login_Menu_Form();
			base.Hide();
			control.Show();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002541 File Offset: 0x00000741
		private void StatisticsMenuButton_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000029AA File Offset: 0x00000BAA
		private void eXITPROGRMMToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
			Application.Exit();
			base.Close();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000029C4 File Offset: 0x00000BC4
		private void joinTerrorDIscordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/dHSda6n");
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000029D1 File Offset: 0x00000BD1
		private void joinMisterModzZToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/raGRCr9");
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000029DE File Offset: 0x00000BDE
		private void visitWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://mistermodzz.com");
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000029EB File Offset: 0x00000BEB
		private void visitForumToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://mistermodzzforum.space");
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000029F8 File Offset: 0x00000BF8
		private void buyGtavCheapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.instant-gaming.com/de/186-kaufen-key-rockstar-grand-theft-auto-v/?igr=MisterModzZ");
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002A05 File Offset: 0x00000C05
		private void checkoutMyYouTubeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCq0VlDDPSbXYWii5qaJSy7w");
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002A12 File Offset: 0x00000C12
		private void clearLogBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.richTextBox1.Text = "                  WELCOME TO THE MISTER//MODZZ MULTI INSTALLER";
			this.justcleared = true;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002A2B File Offset: 0x00000C2B
		private void UninstallMenuFiles()
		{
			this.Uninstall();
			this.UninstallMister();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000B3F4 File Offset: 0x000095F4
		private void UninstallMenuSettings()
		{
			this.StopsavingLog = true;
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (MessageBox.Show("[WARNING] This will delete ALL your saved Userdata!", "Mister//ModzZ Multi Installer", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
			{
				return;
			}
			if (Directory.Exists(folderPath + "/Terror"))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(folderPath + "/Terror");
				FileInfo[] files = directoryInfo.GetFiles();
				for (int i = 0; i < files.Length; i++)
				{
					files[i].Delete();
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				for (int i = 0; i < directories.Length; i++)
				{
					directories[i].Delete(true);
				}
				Directory.Delete(folderPath + "/Terror");
				this.LogInfo("removed Terror Folder form the Appdata Directory");
			}
			if (Directory.Exists(folderPath + "/MisterModzZ"))
			{
				DirectoryInfo directoryInfo2 = new DirectoryInfo(folderPath + "/MisterModzZ");
				FileInfo[] files = directoryInfo2.GetFiles();
				for (int i = 0; i < files.Length; i++)
				{
					files[i].Delete();
				}
				DirectoryInfo[] directories = directoryInfo2.GetDirectories();
				for (int i = 0; i < directories.Length; i++)
				{
					directories[i].Delete(true);
				}
				Directory.Delete(folderPath + "/MisterModzZ");
				this.LogInfo("removed MisterModzZ Folder form the Appdata Directory");
			}
			this.StopsavingLog = false;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000B528 File Offset: 0x00009728
		private void panel3_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.move)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.mox, Control.MousePosition.Y - this.moy);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002A39 File Offset: 0x00000C39
		private void panel3_MouseUp(object sender, MouseEventArgs e)
		{
			this.move = false;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002A42 File Offset: 0x00000C42
		private void panel8_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.MouseDownLocation = e.Location;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000B56C File Offset: 0x0000976C
		private void panel8_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left = e.X + base.Left - this.MouseDownLocation.X;
				base.Top = e.Y + base.Top - this.MouseDownLocation.Y;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002A39 File Offset: 0x00000C39
		private void panel8_MouseUp(object sender, MouseEventArgs e)
		{
			this.move = false;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002541 File Offset: 0x00000741
		private void User_Main_Menu_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002A5D File Offset: 0x00000C5D
		private void checkMenuVersionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ButtonVersionCheck = true;
			this.MenuVersionCheck(this.CurrentInjectinMenu);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000B5C4 File Offset: 0x000097C4
		private void Installer_Versionchecker()
		{
			string address = "";
			WebClient webClient = new WebClient();
			if (this.Forum_State)
			{
				address = "https://mistermodzzforum.space/authserver/TerrorInstaller.php/";
			}
			byte[] bytes = webClient.DownloadData(address);
			string @string = new UTF8Encoding().GetString(bytes);
			if (!(@string == this.Currentversion))
			{
				int num = (int)MessageBox.Show("There is a Update for the Installer Avalible! Do you want to Download it now? ", "Mister//ModzZ Multi Installer Update", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
				this.LogInfo("There is a Update for the Installer Avalible");
				this.LogInfo("The latest version of the Installer is: " + @string);
				this.InstallerOutdated = true;
				if (num == 6)
				{
					Process.Start("https://mistermodzz.com/terrorinstallervers", "Mister//ModzZ Multi Installer");
					return;
				}
			}
			else if (this.frommenuoption)
			{
				MessageBox.Show("Yes this is the latest Version!", "Terror VIP Installer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.LogInfo("Latest Version of the Installer is already installed");
				this.frommenuoption = false;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002A73 File Offset: 0x00000C73
		private void checkInstallerVersionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.frommenuoption = true;
			this.Installer_Versionchecker();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002A82 File Offset: 0x00000C82
		private void createkeyfile(string path)
		{
			StreamWriter streamWriter = new StreamWriter(path + "/Keys.ini");
			streamWriter.Write("[Hotkeys]\r\n");
			streamWriter.Write("OpenKey=119");
			streamWriter.Close();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000B684 File Offset: 0x00009884
		private void setOpenKeyToF8ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = this.Appdata + "/Terror/Configs/Keys.ini";
			if (File.Exists(path))
			{
				File.Delete(path);
				this.LogInfo("removed old Keys.ini");
			}
			if (!Directory.Exists(this.Appdata + "/Terror/Configs"))
			{
				this.LogInfo("Config Folder doesnt exist creating it now");
				Directory.CreateDirectory(this.Appdata + "/Terror/Configs");
			}
			this.createkeyfile(this.Appdata + "/Terror/Configs");
			this.LogInfo("Successfully changed Open Key to F8 on the Numpad");
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000B714 File Offset: 0x00009914
		private void setOpenKeyToNumpadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (File.Exists(this.Appdata + "/Terror/Configs/Keys.ini"))
			{
				File.Delete(this.Appdata + "/Terror/Configs/Keys.ini");
				this.LogInfo("Successfully changed Open Key to * on the Numpad");
				return;
			}
			this.LogInfo("The Open key was already set to * on the Numpad");
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002AAF File Offset: 0x00000CAF
		private void openGtavPathToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(User_Main_Menu_Form.DocumentsMister))
			{
				Process.Start(User_Main_Menu_Form.DocumentsMister);
				return;
			}
			this.LogError("the Folder Doesnt Exist yet Inject the Menu first!");
			MessageBox.Show("[ERROR] the Folder Doesnt Exist yet Install the Menu first!", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002AE7 File Offset: 0x00000CE7
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(User_Main_Menu_Form.Documents))
			{
				Process.Start(User_Main_Menu_Form.Documents);
				return;
			}
			this.LogError("the Folder Doesnt Exist yet Inject the Menu first!");
			MessageBox.Show("[ERROR] the Folder Doesnt Exist yet Install the Menu first!", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002B1F File Offset: 0x00000D1F
		private void button1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("This will Uninstall EVERYTHING including ALL Menu and Installer Settings! Are you sure you want to do that? You can also go to (Uninsatll > All Menu Files) to only Uninstall the Files!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				this.UninstallMenuFiles();
				this.UninstallMenuSettings();
				MessageBox.Show("Ok everything is Uninsatlled Succsesfully! We hope to see you back soon!", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				base.Close();
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002A42 File Offset: 0x00000C42
		private void panel9_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.MouseDownLocation = e.Location;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000B56C File Offset: 0x0000976C
		private void panel9_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left = e.X + base.Left - this.MouseDownLocation.X;
				base.Top = e.Y + base.Top - this.MouseDownLocation.Y;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000B764 File Offset: 0x00009964
		private void appdataMisterModzZFilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/MisterModzZ";
			if (Directory.Exists(text))
			{
				Process.Start(text);
				return;
			}
			this.LogError("the Folder Doesnt Exist yet Install and open the Menu ingame first!");
			MessageBox.Show("[ERROR] the Folder Doesnt Exist yet Install and open the Menu ingame first!", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002B5B File Offset: 0x00000D5B
		private void becomePatreonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.patreon.com/mistermodzz/membership");
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000B7B4 File Offset: 0x000099B4
		private void openTerrorLogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (File.Exists(User_Main_Menu_Form.Documents + "\\Logs\\Terror.log") && Directory.Exists(User_Main_Menu_Form.Documents + "\\Logs"))
			{
				Process.Start(User_Main_Menu_Form.Documents + "\\Logs\\Terror.log");
				return;
			}
			this.LogError("The Terror log doesnt exist yet!");
			MessageBox.Show("Error The Terror Log doesnt Exist yet!", "Terror Installer");
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000B820 File Offset: 0x00009A20
		private void openMisterModzZV2LogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (File.Exists(User_Main_Menu_Form.DocumentsMister + "\\Logs\\MisterModzZ.log") && Directory.Exists(User_Main_Menu_Form.DocumentsMister + "\\Logs"))
			{
				Process.Start(User_Main_Menu_Form.DocumentsMister + "\\Logs\\MisterModzZ.log");
				return;
			}
			this.LogError("The MisterModzZ log doesnt exist yet!");
			MessageBox.Show("Error The MisterModzZ Log doesnt Exist yet!", "MisterModzZ Installer");
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002B68 File Offset: 0x00000D68
		private void menuSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.UninstallMenuSettings();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002B70 File Offset: 0x00000D70
		private void button3_Click(object sender, EventArgs e)
		{
			this.KillGta();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000B88C File Offset: 0x00009A8C
		private void openInstallerLogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Terror\\InstallerLog.txt";
			if (File.Exists(text))
			{
				Process.Start(text);
				return;
			}
			MessageBox.Show("The Installer log doesnt exist yet", "Terror Installer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			this.LogError("The Installer Log doesnt Exist yet");
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000B8DC File Offset: 0x00009ADC
		private void deleteInstallerLogToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.StopsavingLog = true;
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Terror\\InstallerLog.txt";
			if (File.Exists(path))
			{
				File.Delete(path);
				this.LogInfo("Successfully Deleted the log file");
			}
			else
			{
				MessageBox.Show("The Installer log doesnt exist yet", "Terror Installer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.LogError("The Installer Log doesnt Exist yet");
			}
			this.StopsavingLog = false;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002B78 File Offset: 0x00000D78
		private void uninstallAllMenuFilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.UninstallMenuFiles();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002541 File Offset: 0x00000741
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002541 File Offset: 0x00000741
		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002B80 File Offset: 0x00000D80
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("To disable the ads and to get more options you need to support me on Patreon! Do you want to open the Patreon page?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				Process.Start("https://www.patreon.com/mistermodzz/membership");
				return;
			}
			this.LogInfo("You choose to keep the ads!");
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000B944 File Offset: 0x00009B44
		private void timer2_Tick(object sender, EventArgs e)
		{
			string address = "https://mistermodzzforum.space/TerrorInstaller/CountOnlineUsers.php";
			using (WebClient webClient = new WebClient())
			{
				this.label3.Text = "Online Users: " + webClient.DownloadString(address);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002A39 File Offset: 0x00000C39
		private void panel9_MouseUp(object sender, MouseEventArgs e)
		{
			this.move = false;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000B998 File Offset: 0x00009B98
		public void IsV2MenuEnabled()
		{
			WebClient webClient = new WebClient();
			string address = "https://mistermodzzforum.space/authserver/IsV2Enabled.php/";
			byte[] bytes = webClient.DownloadData(address);
			string @string = new UTF8Encoding().GetString(bytes);
			if (@string == "Enabled")
			{
				this.LogInfo("MisterModzZ V2 Menu is Enabled on the Server");
				this.IsV2Enabled = true;
				return;
			}
			this.LogInfo("MisterModzZ V2 Menu is DISABLED on the Server");
			this.LogInfo(@string);
			MessageBox.Show(@string, "MisterModzZ Installer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			this.IsV2Enabled = false;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000BA0C File Offset: 0x00009C0C
		public void IsV2MenuUndetected()
		{
			WebClient webClient = new WebClient();
			string address = "https://mistermodzzforum.space/authserver/V2Detected.php/";
			byte[] bytes = webClient.DownloadData(address);
			if (new UTF8Encoding().GetString(bytes) == "Undetected")
			{
				this.LogInfo("The MisterModzZ V2 Menu is Undetected");
				this.isV2Detected = true;
				return;
			}
			this.LogWarning("The MisterModzZ V2 Menu is DETECTED !!");
			if (MessageBox.Show("WARNING the MisterModzZ Menu is DETECTED rn! Do you still want to Inject it ?", "Detected Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				this.isV2Detected = true;
				return;
			}
			this.LogInfo("You choose to not Inject the menu because its Detected");
			this.isV2Detected = false;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000BA90 File Offset: 0x00009C90
		public void InjectMisterModzZ()
		{
			if (this.AlreadyInjectedAMenu)
			{
				this.LogInfo("You already Injected a Menu!");
				if (MessageBox.Show("You already Injected the Menu! Did you restart your game and want to Inject the Menu now?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					this.AlreadyInjectedAMenu = false;
				}
			}
			if (!this.AlreadyInjectedAMenu)
			{
				this.IsV2MenuUndetected();
				this.IsV2MenuEnabled();
				if (this.IsV2Enabled && this.isV2Detected)
				{
					this.CurrentInjectinMenu = 2;
					new Programm_Busy();
					if (this.is_Patreon)
					{
						this.LogInfo("Patreon Mode is enabled you will see no ads");
						this.remainedInjection = 10;
					}
					else
					{
						this.Check_Remained_Injections();
					}
					if (this.remainedInjection == 0 | this.remainedInjection <= 0)
					{
						if (MessageBox.Show("Yo Have 0 Injections Left! Would you like to Watch an Advertisement to Unlock more (FREE) Injections? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
						{
							Process.Start("https://link-to.net/35082/TerrorInjections");
							this.LogInfo("Please get more injections and then Inject again");
						}
						else
						{
							MessageBox.Show("Ok Menu DOESNT Get Injected Now!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							this.LogInfo("No Injections Left Please watch the Addvertisement!");
						}
					}
					else
					{
						Programm_Busy programm_Busy = new Programm_Busy();
						programm_Busy.Show();
						Programm_Busy.CurrentProcess = "Checking Menu Version...";
						if (!this.MenuVersionCheck(this.CurrentInjectinMenu))
						{
							Programm_Busy.CurrentProcess = "Insatlling latest Menu Version...";
							this.LogInfo("Auto Instaling latest Mister//ModzZ Menu Version Now");
							this.MisterModzZInstall();
						}
						this.Get_New_MisterModzZ_Name();
						this.Injection_Key(this.CurrentInjectinMenu);
						if (this.Erfolg2)
						{
							Programm_Busy.CurrentProcess = "Injecting Dll...";
							if (!this.is_Patreon)
							{
								this.LogInfo("Remained Injections: " + this.remainedInjection);
							}
							if (this.Inject_DLL(User_Main_Menu_Form.DocumentsMister + "\\" + this.Menunametest2))
							{
								this.Total_Injections_Increment();
								if (!this.is_Patreon)
								{
									this.Remove_One_Remained_Injection();
								}
								this.LogInfo("It can take up to 30 sec until you see the Menu ingame!");
								this.LogInfo("---------INJECTED MISTER//MODZZ SUCCESFULL----------");
								this.AlreadyInjectedAMenu = true;
								if (!this.is_Patreon)
								{
									MessageBox.Show(string.Format("Cheat Injected Successsful, Remained Injections: {0}", this.remainedInjection), "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								}
								else
								{
									MessageBox.Show("Cheat Injected Successsful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								}
								programm_Busy.Hide();
							}
							else
							{
								if (this.injecterror == 1)
								{
									this.LogInfo("Menu File was missing trying to reinstall the menu");
									this.MisterModzZInstall();
									this.Get_New_MisterModzZ_Name();
									if (this.Inject_DLL(User_Main_Menu_Form.DocumentsMister + "\\" + this.Menunametest2))
									{
										this.Total_Injections_Increment();
										if (!this.is_Patreon)
										{
											this.Remove_One_Remained_Injection();
										}
										this.LogInfo("---------INJECTED MISTER//MODZZ SUCCESFULL----------");
										this.AlreadyInjectedAMenu = true;
										if (!this.is_Patreon)
										{
											MessageBox.Show(string.Format("Cheat Injected Successsful, Remained Injections: {0}", this.remainedInjection), "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
										}
										else
										{
											MessageBox.Show("Cheat Injected Successsful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
										}
										programm_Busy.Hide();
									}
								}
								programm_Busy.Hide();
							}
						}
					}
					this.CurrentInjectinMenu = 0;
					return;
				}
				this.LogInfo("Injection problems");
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void button2_Click_1(object sender, EventArgs e)
		{
			this.InjectMisterModzZ();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000BD7C File Offset: 0x00009F7C
		private void openMenuSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Terror";
			if (Directory.Exists(text))
			{
				Process.Start(text);
				return;
			}
			this.LogError("the Folder Doesnt Exist yet Install and open the Menu ingame first!");
			MessageBox.Show("[ERROR] the Folder Doesnt Exist yet Install and open the Menu ingame first!", "Mister//ModzZ Multi Installer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002BB6 File Offset: 0x00000DB6
		private void panel3_MouseDown(object sender, MouseEventArgs e)
		{
			this.move = true;
			this.mox = e.X;
			this.moy = e.Y;
		}

		// Token: 0x040000BD RID: 189
		private string Currentversion = "3.2";

		// Token: 0x040000BE RID: 190
		private bool Betaversion;

		// Token: 0x040000BF RID: 191
		private int remainedInjection;

		// Token: 0x040000C0 RID: 192
		private int ispatreonint;

		// Token: 0x040000C1 RID: 193
		private const string quote = "\\";

		// Token: 0x040000C2 RID: 194
		public string Appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x040000C3 RID: 195
		public static string Documents = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\Terror";

		// Token: 0x040000C4 RID: 196
		public static string DocumentsMister = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\MisterModzZ";

		// Token: 0x040000C5 RID: 197
		private bool Terrorsuccess;

		// Token: 0x040000C6 RID: 198
		private bool Mistersuccess;

		// Token: 0x040000C7 RID: 199
		private string newfilename = "";

		// Token: 0x040000C8 RID: 200
		private bool AlreadyInjectedAMenu;

		// Token: 0x040000C9 RID: 201
		private bool killsuccess;

		// Token: 0x040000CA RID: 202
		private string Menunametest = "";

		// Token: 0x040000CB RID: 203
		private string Menunametest2 = "";

		// Token: 0x040000CC RID: 204
		private string Injection_Key_String = "";

		// Token: 0x040000CD RID: 205
		private int CurrentInjectinMenu;

		// Token: 0x040000CE RID: 206
		private bool ButtonVersionCheck;

		// Token: 0x040000CF RID: 207
		private int terrorlatest;

		// Token: 0x040000D0 RID: 208
		private int misterlatest;

		// Token: 0x040000D1 RID: 209
		public bool Erfolg = true;

		// Token: 0x040000D2 RID: 210
		public bool Erfolg2 = true;

		// Token: 0x040000D3 RID: 211
		private int injecterror;

		// Token: 0x040000D4 RID: 212
		private bool Forum_State;

		// Token: 0x040000D5 RID: 213
		private bool mistermodzzsitestate;

		// Token: 0x040000D6 RID: 214
		public string testtext;

		// Token: 0x040000D7 RID: 215
		public string username = "";

		// Token: 0x040000D8 RID: 216
		public string password = "";

		// Token: 0x040000D9 RID: 217
		private int counter2;

		// Token: 0x040000DA RID: 218
		private bool is_Patreon;

		// Token: 0x040000DB RID: 219
		private int n;

		// Token: 0x040000DC RID: 220
		private bool TerrorEnabled;

		// Token: 0x040000DD RID: 221
		private bool TerrorUndetected;

		// Token: 0x040000DE RID: 222
		private bool justcleared;

		// Token: 0x040000DF RID: 223
		private bool StopsavingLog;

		// Token: 0x040000E0 RID: 224
		private Point lastPoint;

		// Token: 0x040000E1 RID: 225
		private int mov;

		// Token: 0x040000E2 RID: 226
		private int mox;

		// Token: 0x040000E3 RID: 227
		private int moy;

		// Token: 0x040000E4 RID: 228
		private bool frommenuoption;

		// Token: 0x040000E5 RID: 229
		private bool InstallerOutdated;

		// Token: 0x040000E6 RID: 230
		private Point MouseDownLocation;

		// Token: 0x040000E7 RID: 231
		private bool IsV2Enabled;

		// Token: 0x040000E8 RID: 232
		private bool isV2Detected;

		// Token: 0x040000E9 RID: 233
		private bool move;
	}
}
