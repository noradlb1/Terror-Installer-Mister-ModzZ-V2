using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MisterModzZ.Properties
{
	// Token: 0x02000019 RID: 25
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002CB6 File Offset: 0x00000EB6
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002CC8 File Offset: 0x00000EC8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool Einstellung
		{
			get
			{
				return (bool)this["Einstellung"];
			}
			set
			{
				this["Einstellung"] = value;
			}
		}
	}
}
