using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Helper
{
	// Token: 0x0200000D RID: 13
	public class KeyHelper
	{
		// Token: 0x06000039 RID: 57
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int id, KeyHelper.LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);

		// Token: 0x0600003A RID: 58
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, int wp, IntPtr lp);

		// Token: 0x0600003B RID: 59
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string name);

		// Token: 0x0600003C RID: 60
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool UnhookWindowsHookEx(IntPtr hook);

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600003D RID: 61 RVA: 0x0000456C File Offset: 0x0000276C
		// (remove) Token: 0x0600003E RID: 62 RVA: 0x000045A4 File Offset: 0x000027A4
		public event KeyEventHandler KeyUp;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600003F RID: 63 RVA: 0x000045DC File Offset: 0x000027DC
		// (remove) Token: 0x06000040 RID: 64 RVA: 0x00004614 File Offset: 0x00002814
		public event KeyEventHandler KeyDown;

		// Token: 0x06000041 RID: 65 RVA: 0x000024C5 File Offset: 0x000006C5
		public KeyHelper()
		{
			this.Hook();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000464C File Offset: 0x0000284C
		~KeyHelper()
		{
			this.Unhook();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004678 File Offset: 0x00002878
		public void Hook()
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			this.keyboardProcess = new KeyHelper.LowLevelKeyboardProc(this.CaptureKey);
			KeyHelper.ptrHook = KeyHelper.SetWindowsHookEx(13, this.keyboardProcess, KeyHelper.GetModuleHandle(mainModule.ModuleName), 0U);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000024D3 File Offset: 0x000006D3
		public void Unhook()
		{
			KeyHelper.UnhookWindowsHookEx(KeyHelper.ptrHook);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000046C0 File Offset: 0x000028C0
		private IntPtr CaptureKey(int nCode, int wp, IntPtr lp)
		{
			if (nCode >= 0)
			{
				KeyEventArgs keyEventArgs = new KeyEventArgs(((KeyHelper.KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KeyHelper.KBDLLHOOKSTRUCT))).key);
				if ((wp == 256 || wp == 260) && this.KeyDown != null)
				{
					this.KeyDown(this, keyEventArgs);
				}
				else if ((wp == 257 || wp == 261) && this.KeyUp != null)
				{
					this.KeyUp(this, keyEventArgs);
				}
				if (keyEventArgs.Handled)
				{
					return (IntPtr)1;
				}
			}
			return KeyHelper.CallNextHookEx(KeyHelper.ptrHook, nCode, wp, lp);
		}

		// Token: 0x0400002E RID: 46
		private const int WM_KEYDOWN = 256;

		// Token: 0x0400002F RID: 47
		private const int WM_KEYUP = 257;

		// Token: 0x04000030 RID: 48
		private const int WM_SYSKEYDOWN = 260;

		// Token: 0x04000031 RID: 49
		private const int WM_SYSKEYUP = 261;

		// Token: 0x04000032 RID: 50
		private KeyHelper.LowLevelKeyboardProc keyboardProcess;

		// Token: 0x04000033 RID: 51
		public static IntPtr ptrHook;

		// Token: 0x0200000E RID: 14
		private struct KBDLLHOOKSTRUCT
		{
			// Token: 0x04000036 RID: 54
			public Keys key;

			// Token: 0x04000037 RID: 55
			public int vkCode;

			// Token: 0x04000038 RID: 56
			public int scanCode;

			// Token: 0x04000039 RID: 57
			public int flags;

			// Token: 0x0400003A RID: 58
			public int time;

			// Token: 0x0400003B RID: 59
			public IntPtr extra;
		}

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000047 RID: 71
		private delegate IntPtr LowLevelKeyboardProc(int nCode, int wParam, IntPtr lParam);
	}
}
