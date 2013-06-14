using System;
using System.Collections.Generic;
using System.Text;
using Artech.Common.Collections;

namespace Heurys.Patterns.HPattern.Code
{
    public interface WebObject : IHPatternInstanceElement,IParameters
    {
        String ObjectName { get; set; }
        String UpdateObject { get; set; }
        String UpdateDataProviderAba { get; set; }
        FormElement Form { get; set; }
        ActionsElement Actions { get; }
        IBaseCollection<RowElement> GetRows(string tabBC);
        bool WebBC { get; }

        string GeraParm(bool bc);
    }
}
