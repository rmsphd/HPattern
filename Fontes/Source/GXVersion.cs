using System;
using System.Collections.Generic;
using System.Text;
using Artech.Genexus.Common.Helpers;
using Artech.Architecture.Common.Packages;

namespace Heurys.Patterns.HPattern
{
    public class GXVersion
    {
        private static Versions mVersion = Versions.Ev2;

        public enum Versions {
            Ev1,Ev2
        }

        public static Versions Version
        {
            get
            {
                return mVersion;
            }
        }

        public static bool IsGenexusServer
        {
            get
            {
                return GxProcess.IsGenexusServer;
            }
        }
    }
}