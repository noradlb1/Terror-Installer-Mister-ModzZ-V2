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
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002C65 File Offset: 0x00000E65
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00002C6C File Offset: 0x00000E6C
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002C7E File Offset: 0x00000E7E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool checkBox1
		{
			get
			{
				return (bool)this["checkBox1"];
			}
			set
			{
				this["checkBox1"] = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002C91 File Offset: 0x00000E91
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002CA3 File Offset: 0x00000EA3
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool checkBox2
		{
			get
			{
				return (bool)this["checkBox2"];
			}
			set
			{
				this["checkBox2"] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002CDB File Offset: 0x00000EDB
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002CED File Offset: 0x00000EED
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool Einstellung1
		{
			get
			{
				return (bool)this["Einstellung1"];
			}
			set
			{
				this["Einstellung1"] = value;
			}
		}

		// Token: 0x04000127 RID: 295
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
