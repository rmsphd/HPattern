using System;
using System.Collections.Generic;
using System.Text;

namespace Heurys.Patterns.HPattern
{
    internal class LogLicense
    {
        public static void Log(string message)
        {
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString() + " HPattern " + HPattern.Resources.Messages.VersionHPattern() + message);
        }

        public static void LogEmpty(string message)
        {
            if (message == String.Empty)
            {
                System.Diagnostics.Debug.WriteLine(message);
            }
        }
    }
}
