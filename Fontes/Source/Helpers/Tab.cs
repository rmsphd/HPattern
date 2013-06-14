using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artech.Genexus.Common;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common.Objects;
using Artech.Genexus.Common.Parts;
using Artech.Common.Helpers.Strings;
using Heurys.Patterns.HPattern.Code;

namespace Heurys.Patterns.HPattern.Helpers
{
    public abstract class Tab
    {
        public abstract string WebForm();
        public abstract string WebFormCmp();
        public abstract string Events();
        public abstract string Subs();
        public abstract string Variables();

        public abstract KBObject Object { get; }
        public abstract ITabsObject Tabs { get; }

        public virtual string WebFormStart()
        {
            return "";
        }

        public virtual string WebFormEnd()
        {
            return "";
        }

        public virtual void VariablesTrn()
        {

        }

        public virtual Variable AddVariable(Transaction transaction, string name)
        {
            if (transaction.Variables.GetVariable(name) == null)
            {
                Variable var = new Variable(transaction.Variables);
                var.Name = name;
                transaction.Variables.Variables.Add(var);
                return var;
            }

            return null;
        }

        public virtual void add(StringBuilder sb, int i, string t)
        {
            if (i <= 0)
            {
                sb.AppendLine(t);
            }
            else
            {
                sb.AppendLine(Indentation.Indent(t, i));
            }
        }

        public static TabItem getTabItem(Tab tabs, Code.ITabObject tab)
        {
            if (tabs.Tabs is ViewElement)
            {
                if (tab.Instance.Settings.Template.TabFunction == SettingsTemplateElement.TabFunctionValue.TreeViewAnchor) 
                {
                    return new TreeViewAnchorTab(tab, tabs.Object);
                }
            }
            else
            {
                switch (tab.Instance.Settings.Template.TabFunction)
                {
                    case SettingsTemplateElement.TabFunctionValue.TreeViewAnchor:
                        return new TreeViewAnchorTab(tab, tabs.Object);
                    default:
                        return new DolphinStyleMenuTab(tab, tabs.Object);
                }
            }
            return null;
        }

        public static Tab getTab(Code.ITabsObject tabs, Artech.Architecture.Common.Objects.KBObject Object)
        {
            if (tabs is ViewElement)
            {
                switch (tabs.Instance.Settings.Template.TabFunction)
                {
                    case SettingsTemplateElement.TabFunctionValue.TreeViewAnchor:
                        return new TreeViewAnchor(tabs, Object);
                    default:
                        return new TabDefault(tabs, Object);
                }
            }
            else
            {

                switch (tabs.Instance.Settings.Template.TabFunction)
                {
                    case SettingsTemplateElement.TabFunctionValue.TreeViewAnchor:
                        return new TreeViewAnchor(tabs, Object);
                    default:
                        return new DolphinStyleMenu(tabs, Object);
                }
            }
        }

    }

    public abstract class TabItem
    {
        public abstract string WebFormStart();
        public abstract string WebFormEnd();

    }
}
