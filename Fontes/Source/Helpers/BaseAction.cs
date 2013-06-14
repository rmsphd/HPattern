using System;
using System.Globalization;
using System.Text;
using Artech.Common.Helpers.Strings;

namespace Heurys.Patterns.HPattern.Helpers
{
    [System.Reflection.ObfuscationAttribute(Feature = "renaming", ApplyToMembers = true)]
	internal abstract class BaseAction
	{
		protected readonly ActionElement m_Action;

		public BaseAction(ActionElement action)
		{
			m_Action = action;
		}

        public bool isSubAction
        {
            get
            {
                return m_Action.isSubAction;
            }
        }

        public bool isMenuContext
        {
            get
            {
                return m_Action.isMenuContext;
            }
        }

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public virtual string EnableDisableCode()
		{
			if (!String.IsNullOrEmpty(m_Action.Condition))
				return CheckSecurity(m_Action.Condition, EnableCode(), DisableCode());
			else
				return EnableCode();
		}

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public abstract string EnableCode();

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
		public abstract string DisableCode();

		protected string CheckSecurity(string condition, string successCode, string failCode)
		{
			if (String.IsNullOrEmpty(condition))
				throw new ArgumentNullException("condition");

			if (String.IsNullOrEmpty(successCode) && String.IsNullOrEmpty(failCode))
				return String.Empty; // Nothing to do.

			StringBuilder code = new StringBuilder();

			// If the condition is an Udp call (old or new format) try to convert it.
			// GeneXus currently doesn't accept "If (PPrc.Udp(...) = 2)"
			string trimmedCondition = condition.Replace(" ", "").ToLower();
			if (trimmedCondition.IndexOf(".udp(") != -1 || trimmedCondition.StartsWith("udp("))
			{
				// Separate the udp call in assignment to a temporal value and comparison inside the "If".
				code.AppendLine(String.Format("&TempBoolean = {0}", condition));
				condition = "&TempBoolean";
			}

			if (!String.IsNullOrEmpty(successCode) && !String.IsNullOrEmpty(failCode))
			{
				code.AppendLine(String.Format("If ({0})", condition));
				code.AppendLine(Indentation.Indent(successCode, 1));
				code.AppendLine("Else");
				code.AppendLine(Indentation.Indent(failCode, 1));
			}
			else if (!String.IsNullOrEmpty(successCode))
			{
				code.AppendLine(String.Format("If ({0})", condition));
				code.AppendLine(Indentation.Indent(successCode, 1));
			}
			else if (!String.IsNullOrEmpty(failCode))
			{
				code.AppendLine(String.Format("If not ({0})", condition));
				code.AppendLine(Indentation.Indent(failCode, 1));
			}
			else
				throw new InvalidOperationException();

			code.Append("Endif");

			return code.ToString();
		}

		public string Event()
		{
			string eventBody = EventBody();
			if (eventBody != null && eventBody != String.Empty)
			{
				StringBuilder sb = new StringBuilder();
				sb.AppendFormat("Event '{0}'", EventName());
				sb.Append(Environment.NewLine);
				sb.Append(Indentation.Indent(eventBody, 1));
				sb.Append(Environment.NewLine);
                if (m_Action.CallMethod == SelectionElement.CallMethodValue.Popup && StandardAction.IsStandard(m_Action))
                {

                    sb.Append(Indentation.Indent("refresh", 1));
                    sb.Append(Environment.NewLine);
                }
				sb.Append("EndEvent");
				return sb.ToString();
			}
			else
				return String.Empty;
		}

		protected virtual string EventName()
		{
			return String.Format(CultureInfo.InvariantCulture, "Do{0}", m_Action.Name);
		}

		protected abstract string EventBody();
	}
}
