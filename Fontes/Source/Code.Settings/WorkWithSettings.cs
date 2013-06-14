using System;
using Artech.Architecture.Common.Objects;
using Artech.Packages.Patterns;
using Artech.Packages.Patterns.Objects;
using Heurys.Patterns.HPattern.Resources;

namespace Heurys.Patterns.HPattern
{
    public partial class HPatternSettings
	{
		private const string k_ModelProperty = "HPattern:Settings";

        public static HPatternSettings Get(KBModel model)
		{
            PatternSettings current = PatternSettings.Get(model, HPatternPattern.Definition);
            HPatternSettings cached = model.GetPropertyValue<HPatternSettings>(k_ModelProperty);

			if (cached == null || cached.VersionId != current.VersionId)
			{
                cached = new HPatternSettings(current);
				cached.VersionId = current.VersionId;
				model.SilentSetPropertyValue(k_ModelProperty, cached);
			}

			return cached;
		}

		internal static void ResetCache(KBModel model)
		{
			model.ResetProperty(k_ModelProperty);
		}

		#region Properties

		private int m_VersionId = 0;

		internal int VersionId
		{
			get { return m_VersionId; }
			private set { m_VersionId = value; }
		}

		#endregion
	}
}
