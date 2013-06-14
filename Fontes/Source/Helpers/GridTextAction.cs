using System;
using System.Globalization;

using Artech.Genexus.Common;
using Artech.Genexus.Common.Helpers;

namespace Heurys.Patterns.HPattern.Helpers
{
    [System.Reflection.ObfuscationAttribute(Feature = "renaming", ApplyToMembers = true)]
	internal class GridTextAction : GridAction, IActionImplementation
	{
		public GridTextAction(ActionElement action)
			: base(action) { }

		public string DefineVariable()
		{
			return Variables.Basic(m_Action.Name, null, eDBType.CHARACTER);
		}

		public string InitializationCode()
		{
			return String.Format(CultureInfo.InvariantCulture, "{0} = \"{1}\"", m_Action.ControlName(), m_Action.Caption);
		}

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public override string EnableCode()
		{
			return LinkAction.EnableLink(m_Action);
		}

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public override string DisableCode()
		{
			return LinkAction.DisableLink(m_Action);
		}
	}
}
