using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MisterModzZ
{
	// Token: 0x02000012 RID: 18
	public partial class Programm_Busy : Form
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00006294 File Offset: 0x00004494
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.panel2.Width += 3;
			this.label99.Text = Programm_Busy.CurrentProcess;
			Programm_Busy.Busybarshown = 1;
			if (this.panel2.Width >= 300)
			{
				this.timer1.Stop();
				Programm_Busy.Busybarshown = 0;
				base.Hide();
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000026B9 File Offset: 0x000008B9
		public Programm_Busy()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002541 File Offset: 0x00000741
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000026C7 File Offset: 0x000008C7
		public void Hidethis()
		{
			base.Hide();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000026CF File Offset: 0x000008CF
		private void Programm_Busy_Load(object sender, EventArgs e)
		{
			this.timer1.Start();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002541 File Offset: 0x00000741
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000068 RID: 104
		public static int Busybarshown = 0;

		// Token: 0x04000069 RID: 105
		public static string CurrentProcess = "Checking Menu Version...";
	}
}
