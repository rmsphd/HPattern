using System;
using System.Collections.Generic;
using System.Text;

namespace Heurys.Patterns.HPattern.Helpers
{
	public static class StandardAction
	{
		public const string Insert = "Insert";
		public const string Update = "Update";
		public const string Delete = "Delete";
		public const string Display = "Display";
		public const string Export = "Export";
        public const string Legend = "Legend";

		public static readonly string[] All = new string[] { Insert, Update, Delete, Display, Export,Legend };

		public static bool IsStandard(string name)
		{
			return (Array.IndexOf(All, name) != -1);
		}

		public static bool IsStandard(ActionElement action)
		{
			return (IsStandard(action.Name));
		}
	}
}
