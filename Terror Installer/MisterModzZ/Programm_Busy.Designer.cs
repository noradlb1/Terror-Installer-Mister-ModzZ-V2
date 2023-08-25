namespace MisterModzZ
{
	// Token: 0x02000012 RID: 18
	public partial class Programm_Busy : global::System.Windows.Forms.Form
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000026DC File Offset: 0x000008DC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000062F4 File Offset: 0x000044F4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MisterModzZ.Programm_Busy));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label99 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new global::System.Drawing.Point(0, 278);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(704, 26);
			this.panel1.TabIndex = 3;
			this.panel1.UseWaitCursor = true;
			this.panel2.BackColor = global::System.Drawing.Color.Lime;
			this.panel2.Location = new global::System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(241, 26);
			this.panel2.TabIndex = 4;
			this.panel2.UseWaitCursor = true;
			this.panel2.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.timer1.Enabled = true;
			this.timer1.Interval = 50;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.label99.AutoSize = true;
			this.label99.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label99.ForeColor = global::System.Drawing.Color.Red;
			this.label99.Location = new global::System.Drawing.Point(12, 235);
			this.label99.Name = "label99";
			this.label99.Size = new global::System.Drawing.Size(286, 29);
			this.label99.TabIndex = 2;
			this.label99.Text = "Checking Menu Version...";
			this.label99.UseWaitCursor = true;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 28.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Red;
			this.label1.Location = new global::System.Drawing.Point(186, 114);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(318, 55);
			this.label1.TabIndex = 5;
			this.label1.Text = "Please Wait...";
			this.label1.UseWaitCursor = true;
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.panel3.BackColor = global::System.Drawing.Color.Red;
			this.panel3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new global::System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(10, 278);
			this.panel3.TabIndex = 5;
			this.panel3.UseWaitCursor = true;
			this.panel4.BackColor = global::System.Drawing.Color.Red;
			this.panel4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new global::System.Drawing.Point(694, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(10, 278);
			this.panel4.TabIndex = 6;
			this.panel4.UseWaitCursor = true;
			this.panel5.BackColor = global::System.Drawing.Color.Red;
			this.panel5.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new global::System.Drawing.Point(10, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(684, 10);
			this.panel5.TabIndex = 7;
			this.panel5.UseWaitCursor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(704, 304);
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label99);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Programm_Busy";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Programm_Busy";
			base.UseWaitCursor = true;
			base.Load += new global::System.EventHandler(this.Programm_Busy_Load);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400006A RID: 106
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Label label99;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Panel panel5;
	}
}
