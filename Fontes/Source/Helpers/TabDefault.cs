using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artech.Genexus.Common;
using Artech.Genexus.Common.Parts;
using ah=Artech.Genexus.Common.Helpers;
using Artech.Architecture.Common.Objects;
using Heurys.Patterns.HPattern.Code;

namespace Heurys.Patterns.HPattern.Helpers
{
    public class TabDefault : Tab
    {
        private HPatternSettings sett = null;
        private Code.ITabsObject view = null;
        private Artech.Architecture.Common.Objects.KBObject mObject = null;

        public TabDefault(Code.ITabsObject tabs, Artech.Architecture.Common.Objects.KBObject Object)
        {
            mObject = Object;
            view = tabs;
            sett = tabs.Instance.Settings;
        }

        public override KBObject Object { get { return mObject; } }
        public override ITabsObject Tabs { get { return view; } }

        public override string WebForm()
        {
            string ret = ah.WebForm.WebComponent("TabbedView", null);
            return ret;
        }

        public override string WebFormCmp()
        {
            return String.Empty;
        }

        public override string Events()
        {
            StringBuilder ret = new StringBuilder();
            add(ret, 0, "If (&Exists)");
            ret.AppendLine("Do 'LoadTabs'");
	        if (view.HasConditionalTabs())
	        {        
		        ret.AppendLine("Do 'CheckTabConditions'");        
	        }
            ret.AppendLine("TabbedView.Object = TabbedView.Create(&Tabs, &TabCode)");
            add(ret, 0, "EndIf");
            return ret.ToString();
        }

        public override string Subs()
        {
            StringBuilder ret = new StringBuilder();
            add(ret,0,"Sub 'LoadTabs'");
	        add(ret,0,"");
	        add(ret,0,"&Tabs = new()");

	        foreach (Code.ITabObject tab in view.ListTabs)
	        {

                if (tab is TabElement)
                {
                    TabElement tabe = (TabElement)tab;

                    add(ret, 0, "&Tab = new()");
                    add(ret, 0, String.Format("&Tab.Code = \"{0}\"", tab.Code));
                    add(ret, 0, String.Format("&Tab.Description = \"{0}\"", tab.Name));
                    add(ret, 0, String.Format("&Tab.WebComponent = {0}.Link({1})", tabe.Wcname, view.Parameters.ListViewVariablesBK()));
                    add(ret, 0, String.Format("&Tab.Link = {0}.Link({1}, &Tab.Code)", mObject.Name, view.Parameters.ListViewVariablesBK()));
                    add(ret, 0, "&Tabs.Add(&Tab)");
                }
            }	

            add(ret,0,"");
            add(ret,0,"EndSub");

	        if (view.HasConditionalTabs())
	        {
                add(ret,0,"");
                add(ret,0,"Sub 'CheckTabConditions'");
                add(ret,0,"");
                add(ret,0,"For Each");

		        if (true /*view.Parameters.IncludesAttributes()*/)
		        {
		            add(ret,0,String.Format("where {0}",view.Parameters.WhereCondition()));	
		        }
                add(ret,0,"");
                add(ret,1,"&Index = 1");
		        add(ret,1,"Do While (&Index <= &Tabs.Count)");
		        add(ret,2,"&Tab = &Tabs.Item(&Index)");
		        add(ret,2,"&Increment = 1");
		        add(ret,2,"Do Case");

		        foreach (Code.ITabObject tab in view.ListTabs)
		        {
			        if (tab.IsConditional())
			        {
				        add(ret,3,String.Format("Case &Tab.Code = \"{0}\"",tab.Code));
					    add(ret,4,String.Format("If not ({0})",tab.Condition));
					    add(ret,5,"&Tabs.Remove(&Index)");
					    add(ret,5,"&Increment = 0");
					    add(ret,4,"EndIf");
			        }
		        }

			    add(ret,2,"Endcase");
			    add(ret,2,"&Index = &Index + &Increment");
		        add(ret,1,"EndDo");
	            add(ret,0,"EndFor");
                add(ret,0,"EndSub");
            }
            return ret.ToString();
        }
        
        public override string Variables()
        {
            string ret = ah.Variables.Sdt("Tabs", "TabOptions");
	        ret += ah.Variables.Sdt("Tab", "TabOptions.TabOptionsItem");
            return ret;
        }
    }
}
