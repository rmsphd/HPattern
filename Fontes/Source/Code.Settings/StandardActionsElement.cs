using System;
using Artech.Packages.Patterns;
using Heurys.Patterns.HPattern.Helpers;

namespace Heurys.Patterns.HPattern
{
	public partial class SettingsStandardActionsElement
	{
		public SettingsActionElement FindAction(string name)
		{
			switch (name)
			{
				case StandardAction.Insert:
					return this.Insert;
				case StandardAction.Update:
					return this.Update;
				case StandardAction.Delete:
					return this.Delete;
				case StandardAction.Display :
					return this.Display;
				case StandardAction.Export:
					return this.Export;
                case StandardAction.Legend:
                    return this.Legend;
				default :
					return null;
			}
		}

		internal bool IsInGrid(SettingsActionElement action)
		{
			return (action == this.Update || action == this.Delete || action == this.Display);
		}
	}
}
