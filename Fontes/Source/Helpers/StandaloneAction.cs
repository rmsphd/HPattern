using System;

namespace Heurys.Patterns.HPattern.Helpers
{
    [System.Reflection.ObfuscationAttribute(Feature = "renaming", ApplyToMembers = true)]
	internal abstract class StandaloneAction : BaseAction
	{
		public StandaloneAction(ActionElement action)
			: base(action) { }

		protected override string EventBody()
		{
            if (!String.IsNullOrEmpty(m_Action.EventCode))
            {
                return m_Action.EventCode;
            }
            string method = "Call";
            if (m_Action.Parent != null)
            {
                if (m_Action.Parent is IGridObject)
                {
                    if (((IGridObject)m_Action.Parent).GetCallMethod == SelectionElement.CallMethodValue.Popup)
                    {
                        method = "Popup";
                    }
                }
            }
            return m_Action.FormatMethod(method, m_Action.Parameters.List());
		}
	}
}
