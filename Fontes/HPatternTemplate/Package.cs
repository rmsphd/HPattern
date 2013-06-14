using Artech.Architecture.Common.Services;
using System.Runtime.InteropServices;

using Artech.Architecture.Common.Packages;
using Artech.Architecture.UI.Framework.Commands;
using Artech.Architecture.UI.Framework.Packages;
using Artech.Architecture.UI.Framework.Services;
using Artech.Architecture.Common.Descriptors;
using Artech.Common.Framework.Commands;
using Artech.Architecture.Common.Services.KMW;
using Artech.Packages.KnowledgeManager.Services;

using Artech.Architecture.BL.Framework.Services;
using Artech.Architecture.Common.Events;
using Microsoft.Practices.CompositeUI.EventBroker;
using Artech.Architecture.BL.Framework.Packages;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using global::Heurys.Patterns.HPatternTemplate;
using System.Configuration;
using System.Net;
using System.IO;
using System.Reflection;

namespace Heurys.Patterns.HPatternTemplate
{
    [Guid("3cfbab1c-b5be-4415-ae0e-6ccd2ead6764")]
	public class Package : AbstractPackage, IGxPackageBL
	{

		public override string Name
		{
			get { return "HPatternTemplate"; }            
		}

		public override void Initialize(IGxServiceProvider services)
		{            
            
		    base.Initialize(services);
            this.AddObjectType<HPatternTemplate>();
		}
        
		#region IGxPackage Members

		public readonly static Guid Guid;

		static Package()
		{
			Guid = typeof(Package).GUID;
		}

		#endregion
	}
}
