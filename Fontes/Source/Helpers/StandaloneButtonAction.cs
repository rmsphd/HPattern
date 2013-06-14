using System;

using Artech.Genexus.Common.Helpers;

namespace Heurys.Patterns.HPattern.Helpers
{
    [System.Reflection.ObfuscationAttribute(Feature = "renaming", ApplyToMembers = true)]
	internal class StandaloneButtonAction : StandaloneAction, IActionImplementation
	{
		public StandaloneButtonAction(ActionElement action)
			: base(action) { }

		public string ControlName()
		{
			return String.Format("Btn{0}", m_Action.Name);
		}

        public string ClassName()
        {
            string classButton = m_Action.ButtonClass;

            if (String.IsNullOrEmpty(classButton))
            {
                try
                {
                    classButton = m_Action.Instance.Settings.Theme.Button;

                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message + e.StackTrace);
                }
            }
            return classButton;
        }

		public string ToHtml()
		{
            return WebForm.Button(m_Action.ControlName(), ClassName(), m_Action.Caption, EventName());
		}

		public virtual string DefineVariable()
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
			return SetEnabled("True");
		}

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
		public override string DisableCode()
		{
			return SetEnabled("False");
		}

		private string SetEnabled(string value)
		{
			string enableProperty = (m_Action.Instance.Settings.StandardActions.DisabledAppearance == SettingsStandardActionsElement.DisabledAppearanceValue.Hidden ? "Visible" : "Enabled");
            string ret = "";
            if (!String.IsNullOrEmpty(m_Action.CodeEnable) && value.ToLower() == "true")
            {
                ret = String.Format(m_Action.CodeEnable, m_Action.ControlName()) + Environment.NewLine;
            }
			return ret+String.Format("{0}.{1} = {2}", m_Action.ControlName(), enableProperty, value);
		}
	}
}
