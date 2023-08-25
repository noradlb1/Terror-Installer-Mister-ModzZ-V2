using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MisterModzZ.Injector
{
	// Token: 0x0200001B RID: 27
	public class Injection
	{
		// Token: 0x0600010D RID: 269
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

		// Token: 0x0600010E RID: 270
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int CloseHandle(IntPtr hObject);

		// Token: 0x0600010F RID: 271
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x06000110 RID: 272
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x06000111 RID: 273
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x06000112 RID: 274
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

		// Token: 0x06000113 RID: 275
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002D1E File Offset: 0x00000F1E
		public static Injection GetInstance
		{
			get
			{
				if (Injection._instance == null)
				{
					Injection._instance = new Injection();
				}
				return Injection._instance;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000022F8 File Offset: 0x000004F8
		private Injection()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000DFD4 File Offset: 0x0000C1D4
		private bool bInject(uint pToBeInjected, string sDllPath)
		{
			IntPtr procAddress = Injection.GetProcAddress(Injection.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			IntPtr intPtr = Injection.OpenProcess(1082U, 1, pToBeInjected);
			if (intPtr == Injection.INTPTR_ZERO)
			{
				MessageBox.Show("Error hndProc", "Terror Insatller");
				Injection.CloseHandle(intPtr);
				return false;
			}
			if (procAddress == Injection.INTPTR_ZERO)
			{
				MessageBox.Show("Error lpLLAddress", "Terror Insatller");
				Injection.CloseHandle(intPtr);
				return false;
			}
			IntPtr intPtr2 = Injection.VirtualAllocEx(intPtr, (IntPtr)null, (IntPtr)sDllPath.Length, 12288U, 64U);
			if (intPtr2 == Injection.INTPTR_ZERO)
			{
				MessageBox.Show("Error lpAddress", "Terror Insatller");
				Injection.CloseHandle(intPtr);
				return false;
			}
			byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);
			if (Injection.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)bytes.Length, 0) == 0)
			{
				MessageBox.Show("Error  WriteProcessMemory", "Terror Insatller");
				Injection.CloseHandle(intPtr);
				return false;
			}
			if (Injection.CreateRemoteThread(intPtr, (IntPtr)null, 0U, procAddress, intPtr2, 0U, (IntPtr)null) == Injection.INTPTR_ZERO)
			{
				MessageBox.Show("Error CreateRemoteThread | Try to Restart the Game and the Terror Installer!", "Terror Insatller");
				Injection.CloseHandle(intPtr);
				return false;
			}
			Injection.CloseHandle(intPtr);
			return true;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000E110 File Offset: 0x0000C310
		public DllInjectionResult Inject(string sProcName, string sDllPath)
		{
			if (!File.Exists(sDllPath))
			{
				MessageBox.Show("Error Menu File not found pls try again", "Terror Insatller", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return DllInjectionResult.DllNotFound;
			}
			uint num = 0U;
			Process[] processes = Process.GetProcesses();
			int i = 0;
			while (i < processes.Length)
			{
				if (!(processes[i].ProcessName == sProcName))
				{
					i++;
				}
				else
				{
					num = (uint)processes[i].Id;
					IL_4E:
					if (num == 0U)
					{
						this.Injectionsuccess = false;
						new Programm_Busy().Hide();
						MessageBox.Show("GtaV not found! Please load into story mode and try again!", "Terror Insatller", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return DllInjectionResult.ProcessNotFound;
					}
					if (!this.bInject(num, sDllPath))
					{
						this.Injectionsuccess = false;
						return DllInjectionResult.InjectionFailed;
					}
					this.Injectionsuccess = true;
					return DllInjectionResult.Success;
				}
			}
			//goto IL_4E;
		}

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr INTPTR_ZERO = (IntPtr)0;

		// Token: 0x0400012E RID: 302
		private static Injection _instance;

		// Token: 0x0400012F RID: 303
		public bool Injectionsuccess;
	}
}
