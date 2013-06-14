using System;
using System.Xml;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Objects;
using Artech.Common.Collections;

namespace Heurys.Patterns.HPattern.Custom
{
	internal class HPatternInstanceVersionAdapter : PatternInstanceVersionAdapter
	{
		protected override bool ConvertAfterRead(PatternInstance instance, XmlDocument rawData, Version fromVersion, Version toVersion)
		{
			bool converted = false;

			if (fromVersion < new Version(0, 5) && toVersion >= new Version(0, 5))
			{
				AssignLevelIds(instance);
				converted = true;
			}

			return converted;
		}

		#region Version 0.5 - Add "Id" to Level elements

		private void AssignLevelIds(PatternInstance instance)
		{
			IBaseCollection<PatternInstanceElement> levels = instance.PatternPart.SelectElements("instance/level");
			for (int i = 0; i < levels.Count; i++)
				levels[i].Attributes["id"] = String.Format("{0}:{1}", instance.KBObject.Guid, i + 1);
		}

		#endregion
	}
}
