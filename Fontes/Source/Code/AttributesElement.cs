using System;
using System.Collections.Generic;
using System.Text;

namespace Heurys.Patterns.HPattern
{
	public partial class AttributesElement
	{
		public AttributeElement FindAttribute(string name)
		{
			return Attributes.Find(delegate (AttributeElement attribute) { return attribute.AttributeName == name; });
		}
	}
}
