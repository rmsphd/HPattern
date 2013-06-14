using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Heurys.Patterns.HPattern
{
    internal class LicenseException : System.ApplicationException
    {

        public LicenseException(string message) : base(message)
        {

        }

        public LicenseException() : base("HPattern License Not Found")
        {
            //Artech.Architecture.Common.Services.CommonServices.Output.AddErrorLine("bla" + base.Message + " - " + base.StackTrace);
        }

        public override string StackTrace
        {
            get
            {
                LogLicense.Log(base.Message+Environment.NewLine+base.StackTrace);
                //Artech.Architecture.Common.Services.CommonServices.Output.AddErrorLine("bla" + base.Message + " - " + base.StackTrace);
                // RMS Teste
                //return base.StackTrace;
                return String.Empty;
            }
        }
    }
}
