using System;
using System.Collections.Generic;
using System.Text;

namespace Heurys.Patterns.HPattern.Code
{
    public interface ITabObject : IHPatternInstanceElement
    {
        String Code { get; set; }
        String Name { get; set; }
        String Description { get; set; }
        String Condition { get; set; }
        String UpdateObject { get; set; }
        String ObjName { get; set; }
        String Group { get; set; }
        Artech.Genexus.Common.Objects.Image Image { get; set; }
        String ImageName { get; }
        bool IsConditional();

    }

    public interface ITabsObject : IHPatternInstanceElement, IParameters
    {
        Artech.Common.Collections.BaseCollection<ITabObject> ListTabs { get; }
        bool HasConditionalTabs();
        GroupsElement Groups { get; }

    }
}
