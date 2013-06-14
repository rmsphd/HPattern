using System;
using System.Diagnostics;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common.Objects;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Objects;

namespace Heurys.Patterns.HPattern
{
	internal class HPatternDeleteProcess : PatternDeleteProcess
	{
		public override void UpdateParentObject(KBObject parent, PatternInstance instance)
		{
			base.UpdateParentObject(parent, instance);
            if (!GXVersion.IsGenexusServer)
            {
                Debug.Assert(parent != null && (parent is Transaction || parent is WebPanel));

                if (parent is Transaction)
                {
                    Transaction transaction = (Transaction)parent;
                    HPatternTransactionUpdater.Clear(instance, transaction);
                }
            }
		}
	}
}
