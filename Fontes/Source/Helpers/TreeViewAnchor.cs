using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artech.Genexus.Common;
using Artech.Genexus.Common.Parts;
using Artech.Common.Collections;
using ah=Artech.Genexus.Common.Helpers;
using Heurys.Patterns.HPattern.Code;
using Artech.Architecture.Common.Objects;

namespace Heurys.Patterns.HPattern.Helpers
{
    public class TreeViewAnchor : Tab
    {
        private HPatternSettings sett = null;
        private Code.ITabsObject viewtabs = null;
        private Artech.Architecture.Common.Objects.KBObject mObject = null;

        public TreeViewAnchor(Code.ITabsObject tabs, Artech.Architecture.Common.Objects.KBObject Object)
        {
            mObject = Object;
            viewtabs = tabs;
            sett = tabs.Instance.Settings;
        }

        public override KBObject Object { get { return mObject; } }
        public override ITabsObject Tabs { get { return viewtabs; } }

        public override string WebForm()
        {
            string ret = "";
            if (viewtabs is ViewElement)
            {
                Dictionary<string, object> props = new Dictionary<string, object>();
                props.Add("TreeNodeCollectionData", "&amp;treeNodeCollectionData");
                props.Add("SelectedTreeNode", "&amp;selectedTreeNode");
                if (sett.TabsProperties != null)
                {
                    foreach (SettingsTabPropertyElement tabprop in sett.TabsProperties)
                    {
                        props.Add(tabprop.Name, tabprop.Valor);
                    }
                }
                ret = WebFormHelper.BeginControl("Treeview", "Treeview1", props) + WebFormHelper.EndControl("Treeview");
            }
            return ret;
        }

        public override string WebFormCmp()
        {
            string ret = "";
            if (viewtabs is ViewElement)
            {
                ret += ah.WebForm.WebComponent("TabbedView", null);
                ret += ah.WebForm.Variable("IsTrn");
                ret += WebFormHelper.BeginControl("HTools", "HTools2", null) + WebFormHelper.EndControl("HTools");
            }
            ret += WebFormHelper.BeginControl("HTools", "HTools1", null) + WebFormHelper.EndControl("HTools");
            return ret;
        }

        public override string WebFormStart()
        {
            return "<div id=\"SecScroll\" class=\"Scroll\">";
        }

        public override string WebFormEnd()
        {
            return "</div>";
        }

        public override string Events()
        {
            StringBuilder ret = new StringBuilder();
            if (viewtabs is ViewElement)
            {
                add(ret, 1, "If &httpRequest.Method = 'GET'");
                add(ret, 2, "Do 'LoadTabs'");
                if (viewtabs.ListTabs != null && viewtabs.ListTabs.Count > 0)
                {
                    Code.ITabObject tab = viewtabs.ListTabs[0];
                    if (tab is TabElement)
                    {
                        TabElement tabe = (TabElement)tab;
                        add(ret, 2, "&IsTrn = true");
                        add(ret, 2, String.Format("TabbedView.Object = {0}.Create({1})", viewtabs.Instance.Transaction.ObjectName, viewtabs.Instance.Transaction.Parameters.ListWithVariables()));
                    }
                }
                add(ret, 1, "EndIf");
                add(ret, 1, "&IsTrn.Visible = false");
            }
            else
            {
                add(ret,0,"HTools1.CalcParentHeight('div.Scroll')");
            }
            return ret.ToString();
        }

        private short internalSubs(StringBuilder ret, ITabsObject view, short contaNivel1)
        {
            BaseCollection<Code.ITabObject> lista = view.ListTabs;

            Dictionary<string, short> grupos = new Dictionary<string, short>();

            GroupsElement groups = view.Groups;
            Boolean isGrupo = false;
            

            foreach (GroupTabElement group in groups)
            {
                add(ret, 0, "&treeNode = new()");
                add(ret, 0, String.Format("&treeNode.Id = \"#{0}\"", group.Name));
                add(ret, 0, String.Format("&treeNode.Name = \"{0}\"", group.Name));
                add(ret, 0, "&treeNode.Link = '#'");
                add(ret, 0, "&treeNode.Expanded = true");
                if (group.ImageName != null)
                {
                    add(ret, 0, String.Format("&treeNode.Icon = {0}.Link()", group.ImageName));
                }
                add(ret, 0, "&treeNodeCollectionData.Add(&treeNode)");
                add(ret, 0, "");

                contaNivel1++;
                grupos.Add(group.Name, contaNivel1);
            }

            short oldNivel = 0;
            bool IsPrimeiro = false;

            foreach (Code.ITabObject tab in lista)
            {
                bool podeRodar = true;
                if (tab is TabElement && !IsPrimeiro)
                {
                    IsPrimeiro = true;
                    podeRodar = false;
                }

                if (podeRodar)
                {

                    if (String.IsNullOrEmpty(tab.Group) || tab.Group.ToLower() == "none")
                    {
                        isGrupo = false;
                    }
                    else
                    {
                        isGrupo = true;
                        short tmpNivel = grupos[tab.Group];
                        if (tmpNivel == null || tmpNivel <= 0) tmpNivel = 1;
                        if (oldNivel != tmpNivel)
                        {
                            oldNivel = tmpNivel;
                            add(ret, 0, String.Format("&parent = &treeNodeCollectionData.Item({0})", tmpNivel));
                            add(ret, 0, "");
                        }
                    }

                    int ident = 0;
                    if (tab.IsConditional())
                    {
                        ident = 1;
                        add(ret, 0, String.Format("If ({0}) and ", tab.Condition));
                    }

                    bool IsDisableImage = false;

                    add(ret, ident, "&treeNode = new()");
                    if (tab is TabElement)
                    {
                        TabElement tabe = (TabElement)tab;

                        add(ret, ident, String.Format("&treeNode.Id = iif(&Mode = TrnMode.Insert,'#',{0}.Link({1}))", tabe.Wcname, view.Parameters.ListViewVariablesBK()));
                        add(ret, ident, String.Format("&treeNode.Name = \"{0}\"", tab.Name));
                        add(ret, ident, "&treeNode.Link = '#'");

                        if (sett.Template.TabDisabledName != null)
                        {
                            IsDisableImage = true;
                            add(ret, ident, "If &Mode = TrnMode.Insert");
                            add(ret, ident + 1, String.Format("&treeNode.Icon = {0}.Link()", sett.Template.TabDisabledName));
                            add(ret, ident + 1, String.Format("&treeNode.IconWhenSelected = {0}.Link()", sett.Template.TabDisabledName));
                            if (tab.ImageName != null)
                            {
                                add(ret, ident, "Else");
                            }
                            else
                            {
                                add(ret, ident, "EndIf");
                            }
                        }

                    }

                    if (tab is TabFormElement)
                    {
                        add(ret, ident, String.Format("&treeNode.Id = '#{0}'", tab.Code));
                        add(ret, ident, String.Format("&treeNode.Name = '{0}'", tab.Description));
                        add(ret, ident, String.Format("&treeNode.Link = '#{0}'", tab.Code));
                    }

                    
                    if (tab.ImageName != null)
                    {
                        if (IsDisableImage)
                        {
                            ident++;
                        }
                        add(ret, ident, String.Format("&treeNode.Icon = {0}.Link()", tab.ImageName));
                        add(ret, ident, String.Format("&treeNode.IconWhenSelected = {0}.Link()", tab.ImageName));
                        if (IsDisableImage)
                        {
                            ident--;
                            add(ret, ident, "EndIf");
                        }
                    }

                    if (isGrupo)
                    {
                        add(ret, ident, "&parent.Nodes.Add(&treeNode)");
                    }
                    else
                    {
                        add(ret, ident, "&treeNodeCollectionData.Add(&treeNode)");
                        contaNivel1++;
                    }
                    if (tab.IsConditional())
                    {
                        add(ret, 0, "EndIf");
                    }
                    add(ret, 0, "");
                }

            }

            add(ret, 0, "");
            return contaNivel1;
        }

        public override string Subs()
        {
            StringBuilder ret = new StringBuilder();
            if (viewtabs is ViewElement)
            {
                add(ret, 0, "Sub 'LoadTabs'");
                add(ret, 0, "");
                add(ret, 0, "&treeNodeCollectionData = new()");
                short contaNivel1 = 0;
                
                if (viewtabs.Instance != null && viewtabs.Instance.Transaction != null && viewtabs.Instance.Transaction.Form != null)
                {
                    contaNivel1 = internalSubs(ret, viewtabs.Instance.Transaction.Form, contaNivel1);
                }

                contaNivel1 = internalSubs(ret, viewtabs, contaNivel1);

                add(ret, 0, "EndSub");

                add(ret, 0, "");
                add(ret, 0, "Event Treeview1.NodeClicked");
                add(ret, 0, "If &selectedTreeNode.Id.Substring(1,1) <> '#'");
                add(ret, 1, "&IsTrn = false");
                add(ret, 1, "HTools1.EventTrigger()");                
	            add(ret, 0, "Else");
                add(ret, 1, "If &selectedTreeNode.Link <> '#' and &IsTrn = false");
			    add(ret, 2, "&IsTrn = true");
			    add(ret, 2, "HTools2.EventTrigger()");
                add(ret, 1, "EndIf");
                add(ret, 0, "EndIf");
                add(ret, 0, "EndEvent // Treeview1.NodeClicked");
                add(ret, 0, "");
                add(ret, 0, "Event HTools1.EventDispach");
                add(ret, 1, "&IsTrn = false");
                add(ret, 1, "TabbedView.Object = CreateFromURL(&selectedTreeNode.Id)");
                add(ret, 0, "EndEvent // HTools1.EventDispach");
                add(ret, 0, "");
                add(ret, 0, "Event HTools2.EventDispach");
                add(ret, 1, "&IsTrn = true");
                add(ret, 1, String.Format("TabbedView.Object = {0}.Create({1})", viewtabs.Instance.Transaction.ObjectName, viewtabs.Instance.Transaction.Parameters.ListWithVariables()));
                add(ret, 0, "EndEvent // HTools2.EventDispach");
                add(ret, 0, "");
            }
            return ret.ToString();
        }

        public override string Variables()
        {
            string ret = ah.Variables.Sdt("treeNode", "TreeNodeCollection.TreeNode");
            ret += ah.Variables.Sdt("selectedTreeNode", "TreeNodeCollection.TreeNode");
            ret += ah.Variables.Sdt("parent", "TreeNodeCollection.TreeNode");
            ret += ah.Variables.Sdt("treeNodeCollectionData", "TreeNodeCollection");
            ret += ah.Variables.Extended("httpRequest", null, "HttpRequest");
            ret += ah.Variables.Basic("IsTrn", null, eDBType.Boolean);
            return ret;
        }
    }

    public class TreeViewAnchorTab : TabItem
    {
        private HPatternSettings sett = null;
        private Code.ITabObject mTab = null;
        private Artech.Architecture.Common.Objects.KBObject mObject = null;

        public TreeViewAnchorTab(Code.ITabObject tab, Artech.Architecture.Common.Objects.KBObject Object)
        {
            mObject = Object;
            mTab = tab;
            sett = tab.Instance.Settings;
        }

        public override string WebFormStart()
        {
            Dictionary<string, object> props = new Dictionary<string, object>();
            props.Add(Properties.HTMLATT.Format, Properties.HTMLATT.Format_Values.RawHtml);
            string ret = "<tr><td>" + ah.WebForm.TextBlock("tb" + mTab.Code, null, String.Format("<a name='{0}'></a>", mTab.Code), props);
            ret += ah.WebForm.BeginTable("Tab" + mTab.Name, sett.Theme.TabTable);
            return ret;
        }

        public override string WebFormEnd()
        {
            return ah.WebForm.EndTable() + "</td></tr>";
        }

    }
}

