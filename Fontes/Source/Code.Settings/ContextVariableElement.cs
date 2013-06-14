using System;

using Artech.Genexus.Common;
using Artech.Genexus.Common.Helpers;
using Gx = Artech.Genexus.Common.Objects;
using Artech.Packages.Patterns;
using Heurys.Patterns.HPattern.Resources;
using Artech.Genexus.Common.Types;

namespace Heurys.Patterns.HPattern
{
	public partial class SettingsContextVariableElement
	{
		public string VariableName
		{
			get { return Variables.VariableName(Name); }
		}

		public string DefineVariable()
		{
			if (Type is Gx.Attribute)
				return Variables.BasedOnAttribute(Name, (Gx.Attribute)Type);

			if (Type is Gx.Domain)
				return Variables.BasedOnDomain(Name, (Gx.Domain)Type);

			if (Type is Gx.SDT)
				return Variables.Sdt(Name, (Gx.SDT)Type);

			throw new TemplateException(Messages.FormatContextVariableInvalidType(Name));
		}

		internal void SetType(Variable var)
		{
			if (Type is Gx.Attribute || Type is Gx.Domain || Type is Gx.SDT)
			{
				if (Type is Gx.Attribute)
					var.AttributeBasedOn = (Gx.Attribute)Type;

				if (Type is Gx.Domain)
					var.DomainBasedOn = (Gx.Domain)Type;

				if (Type is Gx.SDT)
					DataType.ParseInto(Type.Model, Type.Name, var);
			}
			else
				throw new TemplateException(Messages.FormatContextVariableInvalidType(Name));
		}
	}
}
