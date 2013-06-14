using System;
using System.Collections.Generic;
using System.Text;

using Artech.Genexus.Common;
using Artech.Genexus.Common.Helpers;
using Artech.Genexus.Common.Objects;

namespace Heurys.Patterns.HPattern.Helpers
{
    [System.Reflection.ObfuscationAttribute(Feature = "renaming", ApplyToMembers = true)]
	internal class GridImageAction : GridAction, IActionImplementation
	{
		public GridImageAction(ActionElement action)
			: base(action) { }

		public string DefineVariable()
		{
			Dictionary<string, object> varProps = new Dictionary<string, object>();
			varProps[Properties.ATT.TooltipText] = m_Action.Tooltip;

			return Variables.Basic(m_Action.Name, null, eDBType.BITMAP, null, null, null, varProps);
		}

		public string InitializationCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(ImageAction.LoadBitmap(m_Action, m_Action.Image));
			sb.Append(Environment.NewLine);
			sb.AppendFormat("{0}.TooltipText = \"{1}\"", m_Action.ControlName(), m_Action.Tooltip);
			return sb.ToString();
		}

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public override string EnableCode()
		{
			return ImageAction.EnableCode(m_Action);
		}

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public override string DisableCode()
		{
			return ImageAction.DisableCode(m_Action);
		}
	}
}
