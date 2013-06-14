using System;
using System.Collections.Generic;

namespace Heurys.Patterns.HPattern
{
	public partial class SettingsSecurityElement
	{
		public string CustomParameters()
		{
			List<string> parms = new List<string>();
			foreach (SettingsParameterElement parameter in Parameters)
				parms.Add(parameter.Name);

			return String.Join(", ", parms.ToArray());
		}
	}
}
