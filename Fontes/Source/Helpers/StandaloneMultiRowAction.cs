using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Artech.Packages.Patterns;

namespace Heurys.Patterns.HPattern.Helpers
{
    [System.Reflection.ObfuscationAttribute(Feature = "renaming", ApplyToMembers = true)]
	internal class StandaloneMultiRowAction : StandaloneButtonAction, IActionImplementation
	{
		public StandaloneMultiRowAction(ActionElement action)
			: base(action) { }

		private const string k_SelectionVariable = "&Selected";
		private const string k_RowsVariable = "&SelectedRows";
		private const string k_RowVariable = "&SelectedRow";

		public override string DefineVariable()
		{
			return base.DefineVariable();
		}

		protected override string EventBody()
		{
			if (m_Action.Parent is IGridObject)
			{
				StringBuilder eventBody = new StringBuilder();
				eventBody.AppendLine("Do 'LoadSelectedRows'");

				if (!String.IsNullOrEmpty(m_Action.GxobjectName))
				{
					string callParameters = k_RowsVariable;
					if (m_Action.Parameters.Count > 0)
						callParameters += ", " + m_Action.Parameters.List();

					eventBody.Append(m_Action.FormatMethod("Call", callParameters));
				}
				else
					eventBody.Append("// WARNING: No object defined for action");

				return eventBody.ToString();
			}
			else
				throw new TemplateException();
		}
	}
}
