using System;
using System.Collections.Generic;
using System.Text;

namespace Heurys.Patterns.HPattern
{
    internal class HPatternException : Artech.Packages.Patterns.PatternException
    {

        public HPatternException(string message) : base(message)
        {
        }

        public HPatternException(string message,Exception ex)
            : base(message,ex)
        {
        }

    }
}
