using System;
using System.Text;
using Artech.Genexus.Common;
using Artech.Genexus.Common.Helpers;

namespace Heurys.Patterns.HPattern.Helpers
{
    [System.Reflection.ObfuscationAttribute(Feature = "renaming", ApplyToMembers = true)]
	internal class StandaloneImageAction : StandaloneAction, IActionImplementation
	{
		public StandaloneImageAction(ActionElement action)
			: base(action) { }

		#region IActionImplementation Members

		public string ControlName()
		{
			return m_Action.Name;
		}

        public string ClassName()
        {
            return m_Action.Instance.Settings.Theme.Image;
        }

		public string ToHtml()
		{
            return WebForm.Image(m_Action.Name, ClassName(), m_Action.ImageName, EventName(), m_Action.Tooltip);
		}

		public string DefineVariable()
		{
			return String.Empty;
		}

		public string InitializationCode()
		{
			return String.Empty;
		}

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public override string EnableCode()
		{
			// A standalone image action is "enabled" by default.
			return String.Empty;
		}

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public override string DisableCode()
		{
			return ImageAction.DisableCode(m_Action);
		}

		#endregion
	}
}
