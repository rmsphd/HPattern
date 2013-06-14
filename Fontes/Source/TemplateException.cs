using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artech.Packages.Patterns;
using System.Runtime.Serialization;

namespace Heurys.Patterns.HPattern
{
    public class TemplateException : PatternApplicationException
    {
        public TemplateException() : base() { }
        public TemplateException(string errorMessage) : base(errorMessage) { }
        public TemplateException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public TemplateException(string message, Exception innerException) : base(message, innerException) 
        {
            try
            {
                Artech.Architecture.Common.Services.CommonServices.Output.AddErrorLine(innerException);
            }
            catch { 
            }
        }
        
        public TemplateException(string message, Exception innerException,string objName)
            : base(objName+": "+message, innerException)
        {
            try
            {
                Artech.Architecture.Common.Services.CommonServices.Output.AddErrorLine(innerException);
            }
            catch
            {
            }
        }

    }
}

