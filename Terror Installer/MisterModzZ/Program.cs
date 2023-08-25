using System;
using System.Windows.Forms;

namespace MisterModzZ
{
	// Token: 0x02000015 RID: 21
	internal static class Program
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00002838 File Offset: 0x00000A38
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login_Menu_Form());
		}
	}
}
