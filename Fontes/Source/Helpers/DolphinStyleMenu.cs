using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artech.Genexus.Common;
using Artech.Genexus.Common.Types;
using Artech.Genexus.Common.Objects;
using Artech.Genexus.Common.Parts;
using Artech.Common.Collections;
using Artech.Architecture.Common.Objects;
using ah=Artech.Genexus.Common.Helpers;
using Heurys.Patterns.HPattern.Code;

namespace Heurys.Patterns.HPattern.Helpers
{
    public class DolphinStyleMenu : Tab
    {
        private HPatternSettings sett = null;
        private Code.ITabsObject form = null;
        private Artech.Architecture.Common.Objects.KBObject mObject = null;

        public DolphinStyleMenu(Code.ITabsObject tabs, Artech.Architecture.Common.Objects.KBObject Object)
        {
            mObject = Object;
            form = tabs;
            sett = tabs.Instance.Settings;
        }

        public override KBObject Object { get { return mObject; } }
        public override ITabsObject Tabs { get { return form; } }

        public override string WebForm()
        {
            Dictionary<string, Object> tabprops = new Dictionary<string, Object>();
            tabprops.Add("MenuData", "&amp;MenuData");
            tabprops.Add("SelectedItem", "&amp;MenuDataItem");
            return WebFormHelper.BeginControl("DolphinStyleMenu", "Tabs", tabprops) + WebFormHelper.EndControl("DolphinStyleMenu");;
        }

        public override string WebFormCmp()
        {            
            return "";
        }

        internal String DPName(ITabsObject form)
        {
            HPatternInstance instance = form.Instance;
            String nome = "";
            if (instance.IsWebPanel)
            {
                if (instance.ParentObject != null)
                    nome = instance.ParentObject.Name;
            }
            else
            {
                if (instance.Transaction != null && instance.Transaction.Transaction != null)
                {
                    nome = instance.Transaction.TransactionName;
                }
            }
            return String.Format("DPDSM{0}", nome);
        }

        public override string Events()
        {
            StringBuilder events = new StringBuilder();

            if (form.Instance.HasTabs)
            {

                String nome = DPName(form);
                events.AppendLine(String.Format("&MenuData = {0}()", nome));

                events.AppendLine("if &HTTPRequest.Method = HttpMethod.Get");
                if (form.HasConditionalTabs())
                {
                    //eventCodeStart.AppendLine("\tfor &conta = &MenuData.Count to 1 step -1");
                    int ct = form.ListTabs.Count;
                    foreach (ITabObject tabit in form.ListTabs)
                    {
                        if (tabit.IsConditional())
                        {
                            events.AppendLine(String.Format("\tif &MenuData.Item({0}).MenuId = {0}", ct.ToString().Trim()));
                            events.AppendLine(String.Format("\t\tif not ({0})", string.Format(tabit.Condition, "")));
                            events.AppendLine(String.Format("\t\t\t&MenuData.Remove({0})", ct.ToString().Trim()));
                            events.AppendLine("\t\tendif");
                            events.AppendLine("\tendif");
                        }
                        ct--;
                    }
                    //eventCodeStart.AppendLine("\tendfor");
                    events.AppendLine("\tif &MenuData.Count > 0");
                    events.AppendLine("\t\t&MenuDataItem = &MenuData.Item(1)");
                    events.AppendLine("\t\tdo case");
                    int conta = 0;
                    foreach (ITabObject tabit in form.ListTabs)
                    {
                        conta++;
                        events.AppendLine("\t\t\tcase &MenuDataItem.MenuId = " + conta.ToString().Trim());
                        int tf = 0;
                        foreach (ITabObject tab in form.ListTabs)
                        {
                            tf++;
                            events.AppendLine(String.Format("\t\t\t\tTab{0}.Visible = {1}", tab.Name, (tf == conta ? "true" : "false")));
                        }
                    }
                    events.AppendLine("\t\tendcase");
                    events.AppendLine("\tendif");
                }
                else
                {
                    string tf = "true";
                    foreach (ITabObject tab in form.ListTabs)
                    {
                        events.AppendLine(String.Format("\tTab{0}.Visible = {1}", tab.Name, tf));
                        if (tf == "true")
                            tf = "false";
                    }
                }
                events.AppendLine("\t&n = SetCookie('\"Tabs'+Trim(str(&MenuData.Count,2,0))+'\"',\"0\",\"/\")");

                events.AppendLine("endif");
            }
            return events.ToString();
        }

        public override string Subs()
        {
            HPatternInstance instance = form.Instance;
            if (instance.HasTabs)
            {
                StringBuilder eventCode = new StringBuilder(100);
                eventCode.AppendLine();
                eventCode.AppendLine("Event Tabs.DolphinItemClicked");
                if (!instance.IsWebPanel)
                {
                    eventCode.AppendLine("[web]");
                    eventCode.AppendLine("{");
                }
                eventCode.AppendLine("do case");
                int conta = 0;
                foreach (ITabObject tab in form.ListTabs)
                {
                    conta++;
                    eventCode.AppendLine(String.Format("\tcase &MenuDataItem.MenuId = {0}", conta));
                    eventCode.AppendLine(String.Format("\t\t&n = SetCookie('\"Tabs'+Trim(str(&MenuData.Count,2,0))+'\"',\"{0}\",\"/\")", conta - 1));

                    foreach (ITabObject tab2 in form.ListTabs)
                    {
                        if (tab2.Name == tab.Name)
                        {
                            eventCode.AppendLine(String.Format("\t\tTab{0}.Visible = true", tab2.Name));
                        }
                        else
                        {
                            eventCode.AppendLine(String.Format("\t\tTab{0}.Visible = false", tab2.Name));
                        }
                    }

                }
                eventCode.AppendLine("endcase");
                if (!instance.IsWebPanel)
                {
                    eventCode.AppendLine("}");
                }
                eventCode.AppendLine("EndEvent");
                eventCode.AppendLine();
                return eventCode.ToString();
            }
            return "";
        }

        public override string Variables()
        {
            string ret = ah.Variables.Sdt("MenuData", "MenuData");
            ret += ah.Variables.Sdt("MenuDataItem", "MenuData.MenuDataItem");
            return ret;
        }

        public override void VariablesTrn()
        {
            if (mObject is Transaction)
            {
                Transaction transaction = (Transaction)mObject;
                Variable var2 = AddVariable(transaction, "MenuData");
                if (var2 != null)
                    DataType.ParseInto(transaction.Model, "MenuData", var2);

                var2 = AddVariable(transaction, "MenuDataItem");
                if (var2 != null)
                    DataType.ParseInto(transaction.Model, "MenuData.MenuDataItem", var2);
            }
        }
    }

    public class DolphinStyleMenuTab : TabItem
    {
        private HPatternSettings sett = null;
        private Code.ITabObject mTab = null;
        private Artech.Architecture.Common.Objects.KBObject mObject = null;

        public DolphinStyleMenuTab(Code.ITabObject tab, Artech.Architecture.Common.Objects.KBObject Object)
        {
            mObject = Object;
            mTab = tab;
            sett = tab.Instance.Settings;
        }

        public override string WebFormStart()
        {
            return "<tr><td>" + ah.WebForm.BeginTable("Tab" + mTab.Name, sett.Theme.TabTable);
        }

        public override string WebFormEnd()
        {
            return ah.WebForm.EndTable() + "</td></tr>";
        }

    }
}

