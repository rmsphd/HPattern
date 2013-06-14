using System;
using Artech.Genexus.Common.Helpers;
using Artech.Genexus.Common;
using Artech.Genexus.Common.CustomTypes;
using Artech.Genexus.Common.Objects;

namespace Heurys.Patterns.HPattern
{
	public partial class VariableElement
	{
		public string VariableName
		{
			get { return Variables.VariableName(Name); }
		}

        public eDBType Type
        {
            get
            {
                if (Domain != null) return Domain.Type;
                if (Attribute != null) return Attribute.Type;
                return eDBType.NONE;
            }
        }
	}
}
