using System;
using System.Collections.Generic;
using System.Text;

using Artech.Genexus.Common;
using Artech.Genexus.Common.Objects;
using Artech.Genexus.Common.Helpers;
using Artech.Common.Properties;
using Artech.Common.Collections;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common.Parts;
using Artech.Genexus.Common.Wiki;

namespace Heurys.Patterns.HPattern.Helpers
{
    public static class TemplateInternal
    {
        private static int contaGroup = 0;

        public static void ZeraContaGroup()
        {
            contaGroup = 0;
        }

        public static void AddFilterRow(FRowElement row, StringBuilder rows,HPatternSettings settings)
        {

            rows.AppendLine("<tr>");

            foreach (FColElement col in row.Columns)
            {
                string align = col.Align;
                if (col.Align == FColElement.AlignValue.Default)
                {
                    align = settings.Template.CollumnTextAlign.ToLower();
                }
                else
                {
                    align = align.ToLower();
                }

                rows.AppendLine("<td align=\"" + align + "\" colspan='" + col.ColSpan.ToString() + "' rowspan='" + col.RowSpan.ToString() + "'>");

                foreach (IHPatternInstanceElement item in col.Items)
                {
                    if (item is TextElement)
                    {
                        TextElement text = (item as TextElement);
                        RenderText(text, null, rows, null);
                    }
                    if (item is FilterAttributeElement)
                    {
                        FilterAttributeElement filterVar = item as FilterAttributeElement;
                        if (filterVar.AllValue)
                        {
                            Dictionary<string, object> props = new Dictionary<string, object>();
                            Template.GetControlInfo(filterVar, props, true);
                            rows.AppendLine(WebForm.Variable(filterVar.Name, null, null, props));
                        }
                        else
                        {
                            Dictionary<string, object> props = new Dictionary<string, object>();
                            Template.GetControlSize(filterVar, props);
                            rows.AppendLine(WebForm.Variable(filterVar.Name,null,null,props));
                        }

                        if (filterVar.Link != null)
                        {
                            StringBuilder textob = new StringBuilder();
                            Template.LinkImage(textob, filterVar.Link, filterVar.Name, settings);
                            rows.AppendLine(textob.ToString());
                        }



                    }
                    if (item is FGroupElement)
                    {
                        FGroupElement gobj = item as FGroupElement;                       

                        contaGroup++;
                        string name = "Group" + contaGroup.ToString().Trim();

                        string tema = settings.Theme.Group;
                        if (String.IsNullOrEmpty(tema)) tema = "Group";
                        if (!String.IsNullOrEmpty(gobj.Class)) tema = gobj.Class;

                        rows.AppendLine(WebForm.BeginGroup(name, tema, gobj.Caption));
                        rows.AppendLine(WebForm.BeginTable("Table"+name,null));
                        foreach (FRowElement row2 in gobj.Rows)
                        {
                            AddFilterRow(row2, rows, settings);                            
                        }
                        rows.AppendLine(WebForm.EndTable());
                        rows.AppendLine(WebForm.EndGroup());

                    }
                    
                }

                rows.AppendLine("</td>");

            }

            rows.AppendLine("</tr>");
        }

        public static string ResolveDescription(KBModel model, Artech.Genexus.Common.Objects.Attribute att, Domain dom, string desc)
        {                    
            int pigual = desc.IndexOf("=");
            int tipo = 0;
            Artech.Genexus.Common.Objects.Attribute a = null;
            if (att != null)
            {
                a = att;
            }
            if (pigual >= 0)
            {
                int posf = desc.IndexOf(".ContextualTitle");
                if (posf >= 0)
                {
                    tipo = 1;
                }
                else
                {
                    posf = desc.IndexOf(".ColumnTitle");
                    if (posf >= 0)
                    {
                        tipo = 2;
                    }
                    else
                    {
                        posf = desc.IndexOf(".Title");
                        if (posf >= 0)
                        {
                            tipo = 3;
                        }
                        else
                        {
                            posf = desc.IndexOf(".Description");
                            if (posf >= 0)
                            {
                                tipo = 4;
                            }
                            else
                            {

                            }
                        }
                    }
                }
                if (posf >= 0)
                {                    
                    if (a==null) {
                        string nome = desc.Substring(pigual+1, (posf - pigual - 1));
                        a = Artech.Genexus.Common.Objects.Attribute.Get(model, nome);
                    }
                    if (a == null)
                    {
                        if (dom != null)
                        {
                            return dom.Description;
                        }
                    }
                    else
                    {
                        switch (tipo)
                        {
                            case 1:
                                return a.ContextualTitleProperty;
                            case 2:
                                return a.ColumnTitle;
                            case 3:
                                return a.Title;
                            case 4:
                                return a.Description;
                        }                        
                    }
                }
            }
            return desc;
        }

        public static void DocumentationSave(DocumentationPart docp, KBObject obj, HPatternInstance wwInstance, HPatternSettings settings)
        {
            bool atualiza = false;
            if (docp.Page == null)
            {                
                atualiza = true;
            }
            else
            {
                if (String.IsNullOrEmpty(docp.Page.EditableContent))
                {
                    atualiza = true;
                }
            }
            if (atualiza)
            {
                docp.Page = new WikiPage(wwInstance.Model, obj.Name, TemplateInternal.DocumentationFactory(obj.Name, obj.Description, wwInstance, settings));
            }
        }

        public static string DocumentationFactory(string objectName, string objectDescription,HPatternInstance instance, HPatternSettings settings)
        {
            HTemplate template = Template.GetDocTemplate(settings);

            string sAuthor = settings.Documentation.Author;
            if (!String.IsNullOrEmpty(instance.Documentation.Author))
                sAuthor = instance.Documentation.Author;

            string sDate = settings.Documentation.Date;
            if (instance.Documentation.Date != DocumentationElement.DateValue.Default)
                sDate = instance.Documentation.Date;
            if (sDate == DocumentationElement.DateValue.Today)
                sDate = DateTime.Today.ToShortDateString();

            string sObjectDescription = instance.Documentation.ObjectDescription;
            if (sObjectDescription == DocumentationElement.ObjectDescriptionValue.Pgmdesc)
                sObjectDescription = objectDescription;

            string sObjectName = instance.Documentation.ObjectName;
            if (sObjectName == DocumentationElement.ObjectNameValue.Pgmname)
                sObjectName = objectName;

            string sObservation = settings.Documentation.Observation;
            if (!String.IsNullOrEmpty(instance.Documentation.Observation))
                sObservation = instance.Documentation.Observation;

            string sRequirement = settings.Documentation.Requirement;
            if (!String.IsNullOrEmpty(instance.Documentation.Requirement))
                sRequirement = instance.Documentation.Requirement;

            string sSystemDescription = settings.Documentation.SystemDescription;
            if (!String.IsNullOrEmpty(instance.Documentation.SystemDescription))
                sSystemDescription = instance.Documentation.SystemDescription;

            if (!String.IsNullOrEmpty(sAuthor))
                template.SetAttribute(SelTemplate.Author, sAuthor);

            if (!String.IsNullOrEmpty(sDate))
                template.SetAttribute(SelTemplate.Date, sDate);

            if (!String.IsNullOrEmpty(sObjectDescription))
                template.SetAttribute(SelTemplate.ObjectDescription, sObjectDescription);

            if (!String.IsNullOrEmpty(sObjectName))
                template.SetAttribute(SelTemplate.ObjectName, sObjectName);

            if (!String.IsNullOrEmpty(sObservation))
                template.SetAttribute(SelTemplate.Observation, sObservation);

            if (!String.IsNullOrEmpty(sRequirement))
                template.SetAttribute(SelTemplate.Requirement, sRequirement);

            if (!String.IsNullOrEmpty(sSystemDescription))
                template.SetAttribute(SelTemplate.SystemDescription, sSystemDescription);

            return template.ToString();
        }

        #region Codes

        public enum CodeType
        {
            Transaction,
            WebPanel,
            Procedure
        }

        internal static IBaseCollection<SettingsCodeElement> GetCodes(CodeType type, HPatternSettings settings)
        {
            return settings.Codes.FindAll(delegate(SettingsCodeElement code)
            {
                return code.Enabled && ((code.ApplyProcedure && type == CodeType.Procedure) ||
                (code.ApplyTransaction && type == CodeType.Transaction) ||
                (code.ApplyWebPanel && type == CodeType.WebPanel));
            });
        }

        public static string RuleCodes(CodeType type,HPatternSettings settings)
        {
            StringBuilder b = new StringBuilder();
            IBaseCollection<SettingsCodeElement> codes = GetCodes(type, settings);
            foreach (SettingsCodeElement code in codes)
            {
                b.Append(Environment.NewLine);
                //b.AppendLine(String.Format("// [Start] Code: {0}", code.Name));
                b.AppendLine(code.RuleCode);
                //b.AppendLine(String.Format("// [End] Code: {0}", code.Name));
            }
            return b.ToString();
        }

        public static string EventCodes(CodeType type, HPatternSettings settings)
        {
            StringBuilder b = new StringBuilder();
            IBaseCollection<SettingsCodeElement> codes = GetCodes(type, settings);
            foreach (SettingsCodeElement code in codes)
            {
                b.Append(Environment.NewLine);
                //b.AppendLine(String.Format("// [Start] Code: {0}", code.Name));
                b.AppendLine(code.EventCode);
                //b.AppendLine(String.Format("// [End] Code: {0}", code.Name));
            }
            return b.ToString();
        }

        #endregion

        public static void RenderText(TextElement text, RowElement row, StringBuilder atts, Transaction transaction)
        {
            HPatternSettings settings = text.Instance.Settings;
            string themeClass = settings.Theme.PlainText;
            string textCaption = text.Caption;
            bool isHTML = settings.Labels.HTMLFormat;
            SettingsCaptionElement rule = null;

            if (text.HTMLFormat == TextElement.HTMLFormatValue.True)
                isHTML = true;

            if (String.IsNullOrEmpty(text.Class))
            {
                if (Template.IsEmpty(text.Caption))
                {
                    themeClass = settings.Theme.PlainTextEmpty;
                }
            }

            if (!String.IsNullOrEmpty(text.Rule) && text.Rule.ToLower() != "none")
            {
                if (text.Rule.ToLower() == "runtime")
                {
                    if (row != null)
                    {
                        rule = IdentifyRule(row, transaction, settings);
                    }
                }
                else
                {
                    rule = settings.CustomCaptions.FindCaption(text.Rule);
                }
            }
            bool isTemClass = false;
            if (rule != null)
            {
                if (!String.IsNullOrEmpty(rule.Class))
                {
                    themeClass = rule.Class;
                    isTemClass = true;
                }
                textCaption = ResolveDescription(text.Instance.Model, null, null, textCaption);
                textCaption = String.Format(rule.Rule, textCaption);
                if (rule.HTMLFormat == SettingsCaptionElement.HTMLFormatValue.True)
                    isHTML = true;
            }


            if (String.IsNullOrEmpty(text.Class))
            {
                if (row != null)
                {
                    if (!isTemClass)
                    {
                        themeClass = TextLabelPK(themeClass, row, transaction, settings.Theme.LabelKey);
                    }
                }
            }
            else
            {
                themeClass = text.Class;
            }
            if (isHTML)
            {
                Dictionary<string,object> props = new Dictionary<string,object>();
                props.Add(Properties.HTMLSPAN.Format, Properties.HTMLSPAN.Format_Values.Html);
                atts.AppendLine(WebForm.TextBlock(text.Name, themeClass, textCaption, props));
            }
            else
            {
                atts.AppendLine(WebForm.TextBlock(text.Name, themeClass, textCaption));
            }
        }

        private static string TextLabelPK(string mthemeClass, RowElement row, Transaction transaction, string LabelKey)
        {
            string themeClass = mthemeClass;
            bool achou = false;
            foreach (ColumnElement col2 in row.Columns)
            {
                foreach (IHPatternInstanceElement obj2 in col2.Items)
                {
                    if (obj2 is AttributeElement)
                    {
                        AttributeElement att2 = (AttributeElement)obj2;
                        if (transaction != null)
                        {
                            TransactionAttribute ta = transaction.Structure.Root.GetAttribute(att2.AttributeName);
                            if (ta != null && ta.IsKey && !String.IsNullOrEmpty(LabelKey))
                            {
                                themeClass = LabelKey;
                                achou = true;
                                break;
                            }
                        }
                    }
                }
                if (achou) break;

            }
            return themeClass;
        }

        private static SettingsCaptionElement IdentifyRule(RowElement row, Transaction transaction, HPatternSettings settings)
        {
            SettingsCaptionElement rule = null;

            bool achou = false;
            foreach (ColumnElement col2 in row.Columns)
            {
                foreach (IHPatternInstanceElement obj2 in col2.Items)
                {
                    if (obj2 is AttributeElement)
                    {
                        AttributeElement att2 = (AttributeElement)obj2;
                        bool ipk = false;
                        bool ifk = false;
                        bool inull = false;
                        bool ireq = att2.getRequired(transaction);
                        if (transaction != null)
                        {
                            TransactionAttribute ta = transaction.Structure.Root.GetAttribute(att2.AttributeName);
                            if (ta != null) {
                                ipk = ta.IsKey;
                                ifk = ta.IsForeignKey;
                                inull = ta.IsNullable == TableAttribute.IsNullableValue.True;
                            }
                        }
                        foreach (SettingsCaptionElement cap in settings.CustomCaptions)
                        {
                            bool isValido = true;
                            if (cap.SetPrimaryKey && !ipk)
                            {
                                continue;
                            }
                            if (cap.SetForeignKey && !ifk)
                            {
                                continue;
                            }
                            if (cap.SetNullable == SettingsCaptionElement.SetNullableValue.Null && !inull)
                            {
                                continue;
                            }
                            if (cap.SetNullable == SettingsCaptionElement.SetNullableValue.NotNull && inull)
                            {
                                continue;
                            }
                            if (cap.SetEditable == SettingsCaptionElement.SetEditableValue.Editable && (att2.Readonly || !att2.Visible))
                            {
                                continue;
                            }
                            if (cap.SetEditable == SettingsCaptionElement.SetEditableValue.ReadOnly && !att2.Readonly)
                            {
                                continue;
                            }
                            if (cap.SetRequired == SettingsCaptionElement.SetRequiredValue.Required && !ireq)
                            {
                                continue;
                            }
                            if (cap.SetRequired == SettingsCaptionElement.SetRequiredValue.NotRequired && ireq)
                            {
                                continue;
                            }

                            if (isValido)
                            {
                                rule = cap;
                                achou = true;
                                break;
                            }
                        }
                        
                    }
                    if (achou) break;
                }
                if (achou) break;

            }
            return rule;
        }


        #region

        public static string ViewWebForm(Artech.Architecture.Common.Objects.KBObject Object, Artech.Architecture.Common.Objects.KBObjectPart Part, Heurys.Patterns.HPattern.HPatternInstance Instance, ViewElement view)
        {
            string ret = "";

            HPatternSettings settings = Instance.Settings;
            SelectionElement selection = view.Parent.Selection;

		    string sdescription = view.Description;
            string stitle = String.Empty;
            string sviewall = WebForm.TextBlock("ViewAll", settings.Theme.TextToLink, selection.Description);
            string sviewheader = String.Empty;
            string stabs = String.Empty;
            string stransaction = String.Empty;
            if (view.BackToSelection && selection != null)	
	        {
                stitle = WebForm.TextBlock("ViewTitle", "" , view.Description);
            } else {
                stitle = WebForm.TextBlock("ViewTitle", settings.Theme.Subtitle, view.Description);
            }
            


	        if (view.FixedData != null)
	        {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(WebForm.BeginTable("TableView",null));
		        foreach (AttributeElement fixedAtt in view.FixedData.Attributes.Attributes)
		        {
                    sb.AppendLine("<TR><TD>");
                    sb.AppendLine(WebForm.TextBlock("FixText" + fixedAtt.Attribute.Name, settings.Theme.Label, fixedAtt.Description));
                    sb.AppendLine("</TD><TD>");
			        sb.AppendLine( WebForm.Attribute(fixedAtt.Attribute.Name));
                    sb.AppendLine("</TD></TR>");
		        }
                sb.AppendLine( WebForm.EndTable());
                sviewheader = sb.ToString();
	        }

            Tab tab = Tab.getTab(view,Object);
            if (tab != null)
            {
                stabs = tab.WebForm();
                stransaction = tab.WebFormCmp();
            }

			

            HTemplate viewTemplate = Template.GetTemplate(settings, ObjTemplate.ViewTemplate);

            if (stitle != String.Empty)
                viewTemplate.SetAttribute(SelTemplate.Title, stitle);

            if (sdescription != String.Empty)
                viewTemplate.SetAttribute(SelTemplate.Description, sdescription);

            if (sviewall != String.Empty)
                viewTemplate.SetAttribute(SelTemplate.ViewAll, sviewall);

            if (stabs != String.Empty)
                viewTemplate.SetAttribute(SelTemplate.Tabs, stabs);

            if (sviewheader != String.Empty)
                viewTemplate.SetAttribute(SelTemplate.ViewHeader, sviewheader);

            if (!String.IsNullOrEmpty(stransaction))
                viewTemplate.SetAttribute(SelTemplate.Transaction, stransaction);

            ret = viewTemplate.ToString();

            return ret;
        }

        #endregion

    }
}
