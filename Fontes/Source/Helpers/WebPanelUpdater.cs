using System;
using System.Collections.Generic;
using System.Text;
using Artech.Genexus.Common.Objects;
using Artech.Packages.Patterns.Objects;

namespace Heurys.Patterns.HPattern.Helpers
{
    public class WebPanelUpdater
    {

        public WebPanelUpdater(WebPanel obj,PatternInstance instance)
        {
            HPatternInstance wwInstance = HPatternInstance.Load(instance);

            ParserFactory pf = new ParserFactory(instance,null,null);
            ParserFactory.UpdateObject uo = getUpdateObject(wwInstance);
            if (uo != ParserFactory.UpdateObject.DoNotUpdate)
            {
                ParserFactory.ObjectTemplate ot = new ParserFactory.ObjectTemplate("",ParserFactory.ObjectType.WebPanel,"WPWebForm", "WPVariables", "WPEvents", "WPRules", "WPConditions");
                pf.MergeWebPanel(obj, instance.PatternPart.SelectSingleElement("instance/webPanelRoot"), uo, ot);
            }
        }

        private ParserFactory.UpdateObject getUpdateObject(HPatternInstance wwInstance)
        {
            ParserFactory.UpdateObject uo = ParserFactory.UpdateObject.DoNotUpdate;
            switch (wwInstance.WebPanelRoot.UpdateObject)
            {
                case WebPanelRootElement.UpdateObjectValue.CreateDefault:
                    uo = ParserFactory.UpdateObject.CreateDefault;
                    break;
                case WebPanelRootElement.UpdateObjectValue.DoNotUpdate:
                    uo = ParserFactory.UpdateObject.DoNotUpdate;
                    break;
                case WebPanelRootElement.UpdateObjectValue.OnlyRulesEventsAndConditions:
                    uo = ParserFactory.UpdateObject.OnlySource;
                    break;
                case WebPanelRootElement.UpdateObjectValue.Overwrite:
                    uo = ParserFactory.UpdateObject.OverWrite;
                    break;
            }
            return uo;
        }


    }
}
