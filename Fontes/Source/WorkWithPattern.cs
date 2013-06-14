using System;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common.Objects;
using Artech.Packages.Patterns;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Objects;
using Artech.Packages.Patterns.Definition;
using Heurys.Patterns.HPattern.Custom;
using Heurys.Patterns.HPattern.Editor;

[assembly: PatternImplementation(typeof(Heurys.Patterns.HPattern.HPatternPattern))]

namespace Heurys.Patterns.HPattern
{
	public class HPatternPattern : PatternImplementation
	{
		public static Guid Id
		{
            get { return new Guid("2A9DC385-5031-45EF-9294-37893450522C"); }
		}

		public static PatternDefinition Definition
		{
			get { return PatternEngine.GetPatternDefinition(Id); }
		}

		#region Pattern Implementation

		public override IPatternBuildProcess GetBuildProcess()
		{
			return new HPatternBuildProcess();
		}

		public override IPatternDeleteProcess GetDeleteProcess()
		{
			return new HPatternDeleteProcess();
		}

		public override IDefaultInstanceGenerator GetInstanceGenerator()
		{
			return new HPatternInstanceGenerator();
		}

		public override IPatternImportHelper GetImportHelper()
		{
			return new HPatternImportHelper();
		}

		public override IPatternVersionAdapter GetInstanceVersionAdapter()
		{
			return new HPatternInstanceVersionAdapter();
		}

        public override IPatternValidator GetInstanceValidator()
        {
            return new HPatternInstanceValidator();
        }

        public override IPatternValidator GetSettingsValidator()
        {
            return new WorkWithSettingsValidator();
        }

        public override IPatternCustomTypeSupport GetCustomTypeSupport()
        {
            return new HPatternCustomTypeSupport();
        }

        public override IPatternEditorHelper GetInstanceEditorHelper()
        {
            return new WorkWithEditorHelper();
        }

		#endregion
	}
}