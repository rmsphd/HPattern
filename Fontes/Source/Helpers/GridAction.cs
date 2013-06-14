using System;
using System.Collections;
using System.Collections.Generic;
using Artech.Genexus.Common;
using Artech.Genexus.Common.Helpers;
using System.Globalization;

namespace Heurys.Patterns.HPattern.Helpers
{
    [System.Reflection.ObfuscationAttribute(Feature = "renaming", ApplyToMembers = true)]
    internal abstract class GridAction : BaseAction
	{
		public GridAction(ActionElement action)
			: base(action) { }

		public string ControlName()
		{
			return Variables.VariableName(m_Action.Name);
		}

        public string ClassName()
        {
            return null;
        }

		public string ToHtml()
		{
            if (m_Action.CallMethod == SelectionElement.CallMethodValue.Popup)
            {
                Dictionary<String, Object> dict = new Dictionary<string, object>();
                dict[Properties.HTMLSFLCOL.OnClickEvent] = String.Format(CultureInfo.InvariantCulture,"'Do{0}'",m_Action.Name);
                if (m_Action.Image == null)
                {
                    dict[Properties.HTMLSFLCOL.ReadOnly] = true;
                }
                Template.GetControlSize(true,m_Action.GridWidth,m_Action.GridHeight,dict);
                return WebForm.GridVariable(ControlName(),ClassName(), String.Empty, true, null, dict);
            }
            else
            {
                if (m_Action.Image == null)
                {
                    Dictionary<String, Object> dict = new Dictionary<string, object>();
                    dict[Properties.HTMLSFLCOL.ReadOnly] = true;
                    Template.GetControlSize(true, m_Action.GridWidth, m_Action.GridHeight, dict);
                    return WebForm.GridVariable(ControlName(), ClassName(), String.Empty, true, null, dict);
                }
                else
                {
                    Dictionary<String, Object> dict = new Dictionary<string, object>();
                    Template.GetControlSize(true, m_Action.GridWidth, m_Action.GridHeight, dict);
                    return WebForm.GridVariable(ControlName(), ClassName(), String.Empty,true,null,dict);
                }
            }
		}

		protected override string EventBody()
		{           
            if (m_Action.Parent != null)
            {
                if (m_Action.Parent is IGridObject)
                {
                    if (!String.IsNullOrEmpty(m_Action.EventCode))
                    {
                        return m_Action.EventCode;
                    } 
                    else 
                    if (((IGridObject)m_Action.Parent).GetCallMethod == SelectionElement.CallMethodValue.Popup)
                    {
                        return m_Action.FormatMethod("Popup", m_Action.Parameters.List());
                    }
                }
            }            
			return String.Empty;
		}

	}
}
