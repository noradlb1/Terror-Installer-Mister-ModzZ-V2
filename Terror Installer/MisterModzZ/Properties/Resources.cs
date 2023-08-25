using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MisterModzZ.Properties
{
	// Token: 0x02000018 RID: 24
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060000FE RID: 254 RVA: 0x000022F8 File Offset: 0x000004F8
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002C2A File Offset: 0x00000E2A
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("MisterModzZ.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00002C56 File Offset: 0x00000E56
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002C5D File Offset: 0x00000E5D
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000125 RID: 293
		private static ResourceManager resourceMan;

		// Token: 0x04000126 RID: 294
		private static CultureInfo resourceCulture;
	}
}
