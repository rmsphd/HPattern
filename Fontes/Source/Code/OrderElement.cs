using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Heurys.Patterns.HPattern
{
	#region Collection class

	public partial class OrdersElement
	{
		public bool NeedsChoice
		{
			get { return (Count > 1); }
		}

		public const string OrderVariable = "OrderedBy";
		public const string OrderVariableName = "&" + OrderVariable;

		public string ComboValues
		{
			get
			{
				Debug.Assert(NeedsChoice);
				List<string> comboValues = new List<string>();

				for (int i = 0; i < Count; i++)
					comboValues.Add(String.Format("{0}:{1}", this[i].Name, i + 1));

				return String.Join(",", comboValues.ToArray());
			}
		}

		public string Condition
		{
			get { return GetOrderExpression(String.Empty); }
		}

		public string ForEachOrder
		{
			get { return GetOrderExpression("order "); }
		}

        public string gxuiOrder
        {
            get
            {
                if (Count == 1)                    
                    return GetOrderExpression("order ") + " when &params.sort.IsEmpty()";
                return "";
            }
        }

		private string GetOrderExpression(string orderPrefix)
		{
			if (Count == 1)
				return orderPrefix + this[0].OrderExpression;

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < Count; i++)
				sb.AppendFormat("{3}{0} when &{1} = {2}\r\n", this[i].OrderExpression, OrderVariable, i + 1, orderPrefix);

			return sb.ToString();

		}
	}

	#endregion

	public partial class OrderElement
	{
		public string OrderExpression
		{
			get
			{
				StringBuilder atts = new StringBuilder(Attributes.Count * 50);
				foreach (OrderAttributeElement attribute in Attributes)
				{
					if (attribute.Ascending)
						atts.Append(attribute.AttributeName);
					else
						atts.Append("(" + attribute.AttributeName + ")");

					atts.Append(' ');
				}

				return atts.ToString();
			}
		}
	}
}
