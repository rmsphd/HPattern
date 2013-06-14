using System;
using System.Collections.Generic;

using Artech.Genexus.Common.Helpers;
using Gx = Artech.Genexus.Common.Objects;
using Artech.Genexus.Common;

namespace Heurys.Patterns.HPattern
{
	public partial class FilterAttributesElement
	{
		public string ListVariables()
		{
			List<string> varNames = new List<string>();
			foreach (FilterAttributeElement filterAtt in this)
				varNames.Add(filterAtt.VariableName);

			return String.Join(", ", varNames.ToArray());
		}

        public int CountAll
        {
            get
            {
                int ret = 0;
                foreach (FilterAttributeElement filterAtt in FilterAttributes)
                {
                    ret++;
                    if (filterAtt.FilterType == FilterAttributeElement.FilterTypeValue.Interval)
                        ret++;
                }
                return ret;
            }
        }
	}

	public partial class FilterAttributeElement
	{
		public string VariableName
		{
			get { return Variables.VariableName(Name); }
		}

		public Gx.Domain EnumeratedDomain
		{
			get
			{
				Gx.Domain domain = Domain;
				if (domain == null)
				{
					Gx.Attribute att = Gx.Attribute.Get(Instance.Model, Name);
					if (att != null)
						domain = att.DomainBasedOn;
				}

				if (domain != null && domain.IsEnumerated)
					return domain;

				return null;
			}
		}
	}
}
