using System;

namespace Heurys.Patterns.HPattern
{
	public partial class SettingsActionElement
	{
		public bool InGrid(IHPatternComponent component)
		{
			return (component.ComponentType == ComponentType.Grid &&
					Parent.IsInGrid(this));
		}
	}
}
