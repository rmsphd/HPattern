using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Diagnostics;

using Artech.Architecture.Common.Descriptors;
using Artech.Architecture.Common.Objects;
using Artech.Architecture.Common.Packages;
using Artech.Common.Collections;
using Artech.Common.Helpers.Language;
using Artech.Common.Properties;
using Artech.Genexus.Common;
using Artech.Genexus.Common.Objects;
using Artech.Genexus.Common.Services;
using Gx = Artech.Genexus.Common.Objects;
using Artech.Genexus.Common.Parts;
using Artech.Genexus.Common.Parts.Structure;
using Artech.Packages.Patterns;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Objects;
using Heurys.Patterns.HPattern.Helpers;
using Heurys.Patterns.HPattern.Resources;
using Artech.Genexus.Common.Wiki;

using Artech.Architecture.UI.Framework.Packages;
using Artech.Architecture.UI.Framework.Services;
using Artech.Architecture.Common.Services;
using Artech.Genexus.Common.Objects.Sdt;
using Artech.Genexus.Common.Parts.SDT;
using Artech.Genexus.Common.Helpers;
using Artech.Genexus.Common.Types;
using Artech.Common.Helpers.Strings;
using Artech.Common.Helpers.Templates;
using Artech.Genexus.Common.CustomTypes;
using Artech.Common.Helpers.Structure;

namespace Heurys.Patterns.HPattern
{
	internal class HPatternInstanceGenerator : DefaultInstanceGenerator
    {

        #region Geral

        private HPatternSettings settings;

        private PatternInstance pinstance;

		public override void Generate(KBObject baseObject, PatternInstance instance)
		{

            if (baseObject is Transaction)
            {


                //modMain.SetGXPath(Artech.Common.Helpers.IO.PathHelper.StartupPath);

                pinstance = instance;
                Transaction transaction = (Transaction)baseObject;
                HPatternInstance wwInstance = new HPatternInstance(transaction.Model);

                settings = wwInstance.Settings;

                //Dictionary<string, object> propertiesg = new Dictionary<string, object>();
                //propertiesg[Properties.HTMLATT.ReadOnly] = true;
                //settings.Grid.Rules

                //Dictionary<string, object> propertiesg = new Dictionary<string, object>();
                //propertiesg[Properties.HTMLSFL.Rules] = Properties.HTMLSFL.Rules_Values.Rows;

                //System.Text.Encoding.w
                // string template = System.Text.Encoding.Default.GetString(file.BlobPart.Data);           

                // testes
                /*
                KBModel model = Artech.Architecture.UI.Framework.Services.UIServices.KB.CurrentModel;
                foreach (WikiFileKBObject file in WikiFileKBObject.GetAll(model)) {
                    System.Windows.Forms.MessageBox.Show("File: " + file.Name);
                    byte[] b = file.BlobPart.Data;
                    string saida = System.Text.StringBuilder .GetString(b);
                    System.Text.StringBuilder sb = System.Text.StringBuilder();
                
                }
                */


                //Antlr.StringTemplate.FileSystemTemplateLoader st = new Antlr.StringTemplate.FileSystemTemplateLoader("");

                Generate(transaction, wwInstance);
                wwInstance.SaveTo(instance);
            }
            else if (baseObject is WebPanel)
            {
                HPatternInstance wwInstance = new HPatternInstance(instance);
                if (wwInstance.WebPanelRoot == null)
                {
                    wwInstance.WebPanelRoot = new WebPanelRootElement();
                }
                wwInstance.SaveTo(instance);                
            } else {
                throw new PatternException(Messages.ParentMustBeTransaction);
            }
		}

		public override bool GetDependencies(IList<KBObjectDescriptor> dependencies)
		{
			//dependencies.Add(PackageManager.Manager.GetKBObjectDescriptor(ObjClass.Transaction));
			//dependencies.Add(PackageManager.Manager.GetKBObjectDescriptor(ObjClass.Table));
			//dependencies.Add(PackageManager.Manager.GetKBObjectDescriptor(ObjClass.Attribute));
			return true;
        }

        #endregion

        #region Instance / Level Generation

        private void Generate(Transaction transaction, HPatternInstance instance)
		{
			instance.UpdateTransaction = HPatternInstance.UpdateTransactionValue.CreateDefault;
            if (instance.Transaction == null)
            {
                instance.Transaction = new TransactionElement();
            }
			instance.Transaction.Transaction = transaction;
            instance.Transaction.BCErrorCode = settings.Template.BCErrorCode;
            instance.Transaction.BCSucessCode = settings.Template.BCSucessCode;
            HPatternBuildProcess.ClearSuggest();

            AddParameters(instance.Transaction.Parameters, true, transaction.Structure.Root.PrimaryKey, new List<TransactionAttribute>());

            AddSuggestParameters(instance.Transaction.Parameters, true, false);

            AddSuggestActions(instance.Transaction.Actions, instance.Settings,true);

            AddFormTransaction(transaction, instance.Transaction.Form);

			AddFirstLevel(transaction, instance, new List<TransactionAttribute>());

            string tmpn = HPatternBuildProcess.GetSugestName(transaction.Name, instance.Settings);
            if (!String.IsNullOrEmpty(tmpn))
                instance.Transaction.ObjName = tmpn;

            if (instance.Transaction.Form.Tabs.Count == 0 && settings.Template.TabFunction == SettingsTemplateElement.TabFunctionValue.TreeViewAnchor
                && instance.Transaction.Form.Instance.Levels != null && instance.Transaction.Form.Instance.Levels.Count > 0 
                && instance.Transaction.Form.Instance.Levels[0].View != null)
            {
                TabFormElement tabf = instance.Transaction.Form.AddTabForm(transaction.Name);
                tabf.Description = transaction.Description;
            }
		}

		private void AddFirstLevel(Transaction trn, HPatternInstance instance, IList<TransactionAttribute> fixedAttris)
		{
			string levelKey = String.Format("{0}:{1}", trn.Guid, trn.Structure.Root.Id);

			LevelElement levelElement = instance.AddLevel(levelKey);
			levelElement.Name = trn.Name;
			AddDescriptionAttribute(levelElement, trn.Structure.Root.DescriptionAttribute);
			AddSelection(trn, levelElement);
            AddPrompt(trn, levelElement);
            if (settings.Template.SuggestView)
            {
                AddView(trn, levelElement, true, trn.Structure.Root.PrimaryKey, trn.Structure.Root, trn.Name, trn.Description, true, fixedAttris);
            }
		}

		private void AddDescriptionAttribute(LevelElement levelElement, TransactionAttribute da)
		{
			if (da != null)
			{
				DescriptionAttributeElement daElement = new DescriptionAttributeElement();
				daElement.Attribute = da.Attribute;
				daElement.Description = da.Attribute.ContextualTitleProperty;
				levelElement.DescriptionAttribute = daElement;
			}
		}

		#endregion

		#region Selection Generation

		private void AddSelection(Transaction trn, LevelElement levelElement)
		{
			levelElement.Selection = new SelectionElement();

            string plulralDescription = trn.Description; // (Pluralizer.IsNounPlural(trn.Description) ? trn.Description : Pluralizer.ToPlural(trn.Description));
			levelElement.Selection.Description = FormatString(levelElement.Instance.Settings.Labels.WorkWithTitle, plulralDescription);
			levelElement.Selection.Page = SelectionElement.PageValue.Default;
			levelElement.Selection.MasterPage = SelectionElement.MasterPageValue.Default;
            levelElement.Selection.Modes.InsertCondition = levelElement.Instance.Settings.StandardActions.Insert.Condition;
            levelElement.Selection.Modes.UpdateCondition = levelElement.Instance.Settings.StandardActions.Update.Condition;
            levelElement.Selection.Modes.DeleteCondition = levelElement.Instance.Settings.StandardActions.Delete.Condition;
            levelElement.Selection.Modes.DisplayCondition = levelElement.Instance.Settings.StandardActions.Display.Condition;
            levelElement.Selection.Modes.ExportCondition = levelElement.Instance.Settings.StandardActions.Export.Condition;



            foreach (TransactionAttribute ta in trn.Structure.Root.PrimaryKey)
            {
                levelElement.Selection.Identifier = ta.Name;

                bool sai = true;
                foreach (SettingsDefaultFilterElement filter in levelElement.Instance.Settings.DefaultFilters.DefaultFilters)
                {
                    if (filter.Selection && !filter.InGridSelection)
                    {
                        if (filter.Attribute != null)
                        {
                            if (filter.Attribute.Name == ta.Name)
                            {
                                sai = false;
                            }
                        }
                        if (!String.IsNullOrEmpty(filter.PartName))
                        {
                            if (ta.Name.IndexOf(filter.PartName, StringComparison.CurrentCultureIgnoreCase) >= 0)
                            {
                                sai = false;
                            }
                        }
                    }
                }

                if (sai)
                    break;

            }

            AddSuggestParameters(levelElement.Selection.Parameters, false, true);

            AddSuggestActions(levelElement.Selection.Actions, levelElement.Instance.Settings);

            string tmpn = HPatternBuildProcess.GetSugestName(trn.Name, levelElement.Instance.Settings);
            if (!String.IsNullOrEmpty(tmpn))
                levelElement.Selection.ObjName = tmpn;

			AddTransactionAttributes(levelElement.Selection.Attributes, trn.Structure.Root, trn.Structure.Root.Attributes, AttributeTitle.Column);
			AddGridOrders(levelElement.Selection, trn, trn.Structure.Root);
			AddGridFilter(levelElement.Selection, trn, trn.Structure.Root);
		}

        private void AddSuggestActionsTab(ActionsElement actions, HPatternSettings settings)
        {
            AddSuggestActions(actions, settings, false,false,true);
        }

        private void AddSuggestActions(ActionsElement actions, HPatternSettings settings)
        {
            AddSuggestActions(actions, settings, false);
        }

        private void AddSuggestActions(ActionsElement actions, HPatternSettings settings, bool trn)
        {
            AddSuggestActions(actions, settings, trn,false,false);
        }

        private void AddSuggestActions(ActionsElement actions, HPatternSettings settings,bool trn,bool prt,bool tab)
        {
            foreach (SettingsSuggestActionElement act in settings.SuggestActions)
            {
                if ((act.SuggestSelection && trn == false && prt == false && tab == false) 
                    || (act.SuggestTransaction && trn == true) 
                    || (act.SuggestPrompt && prt == true)
                    || (act.SuggestViewTab && tab == true)) 
                {
                    ActionElement action = new ActionElement();
                    action.Name = act.Name;
                    action.Caption = act.Caption;
                    action.Legend = act.Legend;
                    action.Gxobject = act.Gxobject;
                    action.InGrid = act.InGrid;
                    action.MultiRowSelection = act.MultiRowSelection;
                    action.Image = act.Image;
                    action.DisabledImage = act.DisabledImage;
                    action.Tooltip = act.Tooltip;
                    action.Condition = act.Condition;
                    action.ButtonClass = act.ButtonClass;
                    action.EventCode = act.EventCode;
                    action.CodeEnable = act.CodeEnable;
                    action.Position = act.Position;
                    action.Width = act.Width;
                    action.GridHeight = act.GridHeight;
                    action.GridWidth = act.GridWidth;

                    // Parametros
                    foreach (SettingsSuggestParameterElement par in act.Parameters)
                    {
                        ParameterElement pare = new ParameterElement();
                        pare.Name = par.Name;
                        pare.Domain = par.Domain;
                        pare.Null = par.Null;
                        action.Parameters.Add(pare);
                    }

                    actions.Add(action);
                }
            }
        
        }


		private void AddGridOrders(IGridObject gridObject, Transaction trn, TransactionLevel level)
		{
			// Default order, by description attribute (if applicable).
			TransactionAttribute descAtt = level.DescriptionAttribute;
			if (descAtt != null &&
				(descAtt.Attribute.Type != eDBType.BINARY && descAtt.Attribute.Type != eDBType.LONGVARCHAR) &&
				(descAtt.Attribute.Class != AttributeClass.HORIZONTAL && descAtt.Attribute.Class != AttributeClass.VERTICAL))
			{
				OrderElement orderElement = AddOrder(gridObject, descAtt.Attribute.ContextualTitleProperty);
				AddOrderAttribute(orderElement, descAtt, descAtt.Attribute.ContextualTitleProperty, true);
			}
		}

		private OrderElement AddOrder(IGridObject gridObject, string name)
		{
			OrderElement orderElement = new OrderElement(name);
			gridObject.Orders.Add(orderElement);
			return orderElement;
		}

		private void AddOrderAttribute(OrderElement orderElement, TransactionAttribute att, string attDescription, bool ascending)
		{
			OrderAttributeElement orderAttElement = orderElement.AddOrderAttribute();
			orderAttElement.Attribute = att.Attribute;
			orderAttElement.Description = attDescription;
			orderAttElement.Ascending = ascending;
		}

		private void AddGridFilter(IGridObject gridObject, Transaction trn, TransactionLevel level)
		{
			gridObject.Filter = new FilterElement();
			AddGridFilterAttributes(gridObject.Filter, trn, level);
			AddGridFilterConditions(gridObject.Filter, trn, level);
            AddGridFilterDynamicFilters(gridObject.Filter, trn, level);
		}

        private void AddGridFilterDynamicFilters(FilterElement filterElement, Transaction trn, TransactionLevel level) {

            try
            {
                if (settings.DynamicFilters.GenerateDynaicFilters)
                {
                    int max = settings.DynamicFilters.MaxAttributes;
                    int c = 0;
                    foreach (TransactionAttribute ta in level.Attributes)
                    {
                        if (ta.Attribute.Type == eDBType.CHARACTER || ta.Attribute.Type == eDBType.VARCHAR || ta.Attribute.Type == eDBType.NUMERIC || ta.Attribute.Type == eDBType.DATE)
                        {
                            AttributeElement at = new AttributeElement(ta.Attribute);
                            at.Description = ta.Attribute.Description;
                            filterElement.Dynamicfilters.Add(at);
                            c++;
                            if (c >= max) break;
                        }
                    }
                }
            }
            catch (System.Exception e) {
                System.Windows.Forms.MessageBox.Show("Erro: " + e.Message + Environment.NewLine + e.StackTrace);                   
            }
        }

		private void AddGridFilterAttributes(FilterElement filterElement, Transaction trn, TransactionLevel level)
		{
			// Currently only the description attribute is added.
			if (level.DescriptionAttribute != null)
				AddFilterAttribute(filterElement, trn.Model, level.DescriptionAttribute.Name, BuildCaption(settings.Labels.FilterCaption,level.DescriptionAttribute,level.DescriptionAttribute.Attribute.ContextualTitleProperty), null, String.Empty);
		}

        private void AddFilterAttribute(FilterElement filterElement, KBModel model, string name, string description, Domain domain, string defaultValue)
		{
			FilterAttributeElement filterAttElement = filterElement.AddFilterAttribute(name);
			filterAttElement.Description = description;
			filterAttElement.Domain = domain;
			filterAttElement.Default = defaultValue;

			PropertiesObject underlying = (domain != null ? (PropertiesObject)domain : (PropertiesObject)Gx.Attribute.Get(model, name));
			if (underlying != null && underlying.GetPropertyValue<int>(Properties.ATT.ControlType) == Properties.ATT.ControlType_Values.ComboBox)
				filterAttElement.AllValue = true;
		}

		private void AddGridFilterConditions(FilterElement filterElement, Transaction trn, TransactionLevel level)
		{
			// Currently only the description attribute is added.
			if (level.DescriptionAttribute != null)
				AddFilterCondition(filterElement, level.DescriptionAttribute.Attribute);

            foreach (SettingsDefaultFilterElement filter in settings.DefaultFilters.DefaultFilters)
            {
                bool roda = false;
                if (filter.Selection)
                {
                    if (filterElement.Parent is SelectionElement)
                    {
                        roda = true;
                    }
                }
                if (filter.Prompt)
                {
                    if (filterElement.Parent is PromptElement)
                    {
                        roda = true;
                    }
                }

                if (roda)
                {
                    if (filter.Attribute != null)
                    {
                        if (trn.Structure.Root.ContainsAttribute(filter.Attribute, false))
                        {
                            if (!String.IsNullOrEmpty(filter.Value))
                            {
                                filterElement.AddCondition(filter.Value);
                            }
                        }
                    }
                }
            }
		}

		private void AddFilterCondition(FilterElement filterElement, Gx.Attribute att)
		{
            string conditionText = getCondition(att, filterElement.Instance.Settings);
			ConditionElement conditionElement = filterElement.AddCondition(conditionText);
		}

        internal static string getCondition(Gx.Attribute att, HPatternSettings settings)
        {
            string comparison;

            if (att.Type == eDBType.CHARACTER || att.Type == eDBType.VARCHAR || att.Type == eDBType.LONGVARCHAR)
                comparison = settings.Grid.DefaultConditionCharacter;
            else if (att.Type == eDBType.Boolean)
                comparison = settings.Grid.DefaultConditionBoolean;
            else
                comparison = settings.Grid.DefaultCondition;

            return String.Format(comparison, att.Name, "&" + att.Name);
        }

        internal static string CreateDefaultCondition(Gx.Attribute att,PatternInstanceElement element)
        {
            HPatternSettings settings = HPatternSettings.Get(element.Instance.Model);
            return getCondition(att, settings);
        }
		#endregion

        #region Prompt Generation

        private void AddPrompt(Transaction trn, LevelElement levelElement)
        {
            PromptElement prompt = new PromptElement();
            levelElement.Prompts.Add(prompt);
            string plulralDescription = trn.Description; //(Pluralizer.IsNounPlural(trn.Description) ? trn.Description : Pluralizer.ToPlural(trn.Description));
            if (String.IsNullOrEmpty(levelElement.Instance.Settings.Objects.Prompt))
            {
                prompt.Name = String.Format("Prompt{0}", trn.Name);
            }
            else
            {
                prompt.Name = levelElement.Instance.Settings.Objects.Prompt.Replace("<Object>", trn.Name);
            }
            prompt.Description = FormatString(levelElement.Instance.Settings.Labels.PromptTitle, plulralDescription);
            prompt.Page = PromptElement.PageValue.Default;
            prompt.MasterPage = PromptElement.MasterPageValue.Default;
            prompt.Modes.InsertCondition = levelElement.Instance.Settings.StandardActions.Insert.Condition;
            prompt.Modes.UpdateCondition = levelElement.Instance.Settings.StandardActions.Update.Condition;
            prompt.Modes.DeleteCondition = levelElement.Instance.Settings.StandardActions.Delete.Condition;
            prompt.Modes.DisplayCondition = levelElement.Instance.Settings.StandardActions.Display.Condition;
            prompt.Modes.ExportCondition = levelElement.Instance.Settings.StandardActions.Export.Condition;

            AddSuggestActions(prompt.Actions, levelElement.Instance.Settings); 

            AddPromptParameter(prompt, trn.Structure.Root);
            AddPromptAttributes(prompt.Attributes, trn.Structure.Root, trn.Structure.Root.Attributes, AttributeTitle.Column);
            AddGridOrders(prompt, trn, trn.Structure.Root);
            AddGridFilter(prompt, trn, trn.Structure.Root);
            
        }

        private void AddPromptParameter(PromptElement prompt, TransactionLevel level)
        {
            foreach (TransactionAttribute ta in level.PrimaryKey)
            {
                bool carrega = true;
                bool notnull = false;
                foreach (SettingsDefaultFilterElement filter in settings.DefaultFilters.DefaultFilters)
                {
                    if (filter.Prompt)
                    {
                        if (filter.Attribute != null)
                        {
                            if (filter.Attribute.Name == ta.Name)
                            {
                                if (!filter.Parm)
                                {
                                    carrega = false;
                                }
                                else
                                {
                                    if (filter.ParmNotNull)
                                    {
                                        notnull = true;
                                    }

                                }

                            }
                        }
                    }
                }
                if (carrega)
                {
                    ParameterElement par = prompt.AddParameter(ta.Name);
                    if (notnull)
                    {
                        par.Null = false;
                    }
                }
            }
            if (settings.Template.PromptSuggestParmDescription)
            {
                if (level.DescriptionAttribute != null)
                {
                    prompt.AddParameter(level.DescriptionAttribute.Name);
                }
            }
        }

        private void AddPromptAttributes(AttributesElement attributesElement, TransactionLevel level, IEnumerable<TransactionAttribute> attris, AttributeTitle descType)
        {
            if (settings.Template.PromptSuggestGridPrimaryKey)
            {
                foreach (TransactionAttribute ta in level.PrimaryKey)
                {
                    bool carrega = true;
                    foreach (SettingsDefaultFilterElement filter in settings.DefaultFilters.DefaultFilters)
                    {
                        if (filter.Prompt)
                        {
                            if (filter.Attribute != null)
                            {
                                if (filter.Attribute.Name == ta.Name)
                                {
                                    if (!filter.InGrid)
                                    {
                                        carrega = false;
                                    }

                                }
                            }
                        }
                    }

                    if (ta.IsKey || carrega)
                    {
                        bool visivel = true;
                        if (ta.IsKey && !carrega)
                        {
                            visivel = false;
                        }
                        AddTransactionAttribute(attributesElement, ta, BuildCaption(settings.Labels.GridCaption, ta, ta.GetTitle(descType)), visivel, false);
                    }
                    //AddTransactionAttribute(attributesElement, ta, ta.GetTitle(descType), true, false);
                }
            }

            TransactionAttribute da = level.Transaction.Structure.Root.DescriptionAttribute;
            if (da != null) {
                AddTransactionAttribute(attributesElement, da, BuildCaption(settings.Labels.GridCaption,da, da.GetTitle(descType)), true, false);
                //AddTransactionAttribute(attributesElement, da, da.GetTitle(descType), true, false);
            } else {
                IDictionary<TransactionAttribute, Gx.Attribute> attRelations = null;
                if (level != null)
                    attRelations = DefaultFormHelper.CalculateRelations(level);

                foreach (TransactionAttribute attri in attris)
                {
                    // Don't show those attributes that are "normally" invisible.
                    // For example, XId if it is a dynamic combo with descriptions from XName (providing XName is present).
                    bool visible = true;
                    if (attRelations != null && attRelations.ContainsKey(attri))
                    {
                        Gx.Attribute relatedAtt = attRelations[attri];
                        if (level.ContainsAttribute(relatedAtt, false))
                            visible = false;
                    }

                    AddTransactionAttribute(attributesElement, attri, BuildCaption(settings.Labels.GridCaption,attri, attri.GetTitle(descType)), true, false);
                    //AddTransactionAttribute(attributesElement, attri, attri.GetTitle(descType), visible, false);
                    if (visible)
                    {                        
                        break;
                    }
                }
            }


        }

        #endregion

		#region View Generation

		private void AddView(Transaction trn, LevelElement levelElement, bool backToSelection, IList<TransactionAttribute> pk, TransactionLevel level, string viewName, string description, bool needActions, IList<TransactionAttribute> fixedAttris)
		{
			levelElement.View = new ViewElement();
			levelElement.View.Description = FormatString(levelElement.Instance.Settings.Labels.ViewDescription, description);
			levelElement.View.BackToSelection = backToSelection;
			levelElement.View.MasterPage = ViewElement.MasterPageValue.Default;

			string trnCaption = (level.DescriptionAttribute != null ? String.Format("{0}.ToString()", level.DescriptionAttribute.Name) : String.Format("\"{0}\"", trn.Description));
			levelElement.View.Caption = trnCaption;

			AddParameters(levelElement.View, false, pk);

			if (level.DescriptionAttribute != null)
				fixedAttris.Add(level.DescriptionAttribute);
			levelElement.View.FixedData = new FixedDataElement();
			AddFixedDataAttributes(levelElement.View.FixedData, level, fixedAttris);

			AddTabs(trn, levelElement.View, viewName, description, level, needActions);
		}

		private void AddFixedDataAttributes(FixedDataElement fixedDataNode, TransactionLevel level, IList<TransactionAttribute> fixedAtts)
		{
			AddTransactionAttributes(fixedDataNode.Attributes, null, fixedAtts, AttributeTitle.Single);
		}

		#region View Tabs

		private void AddTabs(Transaction trn, ViewElement viewNode, string lvlName, string lvlDescription, TransactionLevel level, bool needActions)
		{
			// General tab
			AddTabularTab(viewNode, trn, level, lvlName, lvlDescription, needActions);

            //viewNode.Instance.Settings.Template.TitleImage
			// Tabs for parallel transactions.
			if (viewNode.Instance.Settings.Template.TabsForParallelTransactions)
			{
				if (trn.Structure.Root == level && level.AssociatedTable.AssociatedTransactions.Count > 1)
					AddParallelTabs(viewNode, trn, level);
			}

			// Tabs for subordinations.
			AddSuborTabs(viewNode, trn, level);
		}

		private void AddTabularTab(ViewElement viewElement, Transaction trn, TransactionLevel level, string lvlName, string wcDescription, bool needActions)
		{
			string code = "General";

			TabElement tabElement = viewElement.AddTab(code);
			tabElement.Name = viewElement.Instance.Settings.Labels.GeneralTab;
			tabElement.Wcname = lvlName + "General";
			tabElement.Description = wcDescription + " Info";
			tabElement.Type = TabElement.TypeValue.Tabular;

			AddTabularTabAttributes(tabElement, trn, level);

			if (needActions)
				AddActions(tabElement);

		}

		private void AddParallelTabs(ViewElement viewElement, Transaction trn, TransactionLevel level)
		{
			foreach (Transaction parallel in level.AssociatedTable.AssociatedTransactions)
			{
				if (!parallel.Equals(trn))
				{
					TabElement tabElement = viewElement.AddTab(parallel.Name);
					tabElement.Name = parallel.Description;
					tabElement.Wcname = trn.Name + parallel.Name;
					tabElement.Type = TabElement.TypeValue.Tabular;

					AddTrn(parallel, tabElement);
					AddTabularTabAttributes(tabElement, parallel, parallel.Structure.Root);
					AddActions(tabElement);            
				}
			}
		}

		private void AddTabularTabAttributes(TabElement tabNode, Transaction trn, TransactionLevel level)
		{
			tabNode.Attributes = new AttributesElement();
			AddTransactionAttributes(tabNode.Attributes, level, level.Attributes, AttributeTitle.Single);
            AddSuggestActionsTab(tabNode.Actions, tabNode.Instance.Settings);
		}

		private void AddSuborTabs(ViewElement tabsNode, Transaction trn, TransactionLevel fatherLvl)
		{
			// Tabs for each transaction level subordinated to the first one.
			List<Table> tablesInTrnLvls = new List<Table>();
			foreach (TransactionLevel suborLvl in fatherLvl.Levels)
			{
				AddSuborTabTrnLevel(tabsNode, trn, suborLvl);
				tablesInTrnLvls.Add(suborLvl.AssociatedTable);
			}

			// Tabs for other subordinated tables (by FK).
			foreach (TransactionLevelRelation relation in fatherLvl.GetSubordinations())
			{
				if (!fatherLvl.Levels.Contains(relation.RelatedLevel) &&
					!tablesInTrnLvls.Contains(relation.RelatedTransaction.Structure.Root.AssociatedTable))
				{
					string tabId = MakeTabUniqueId(fatherLvl, relation, tabsNode);
					AddSuborTabTransaction(tabsNode, tabId, relation);
				}
			}
		}

		private void AddSuborTabTrnLevel(ViewElement viewElement, Transaction trn, TransactionLevel subLevel)
		{
			TabElement tabElement = viewElement.AddTab(subLevel.Name);
			tabElement.Name = subLevel.Description;
			tabElement.Wcname = trn.Name + subLevel.Name + "WC";
            tabElement.Description = subLevel.Description;
			tabElement.Type = TabElement.TypeValue.Grid;
			tabElement.Page = TabElement.PageValue.Default;

			AddGridTabAttributes(tabElement, trn, subLevel, subLevel.Attributes);
		}

		private void AddSuborTabTransaction(ViewElement viewElement, string tabId, TransactionLevelRelation relation)
		{
			// Do not include the attributes "known due to context" (for example, when browsing the client's invoices, drop ClientId, ClientName, and ClientAddress).
			BaseCollection<TransactionAttribute> attrisInTab = new BaseCollection<TransactionAttribute>(relation.RelatedTransaction.Structure.Root.Attributes);
			attrisInTab.RemoveAll(delegate(TransactionAttribute trnAtt) { return relation.ContainsRelatedAttribute(trnAtt.Attribute); });

			// This may leave us with nothing to add, actually...
			if (attrisInTab.Count > 0)
			{
				TabElement tabElement = viewElement.AddTab(tabId);
				tabElement.Name = (relation.GroupRelation != null ? relation.GroupRelation.Description : relation.RelatedTransaction.Description);
				tabElement.Wcname = relation.BaseTransaction.Name + tabId + "WC";
                tabElement.Description = (relation.GroupRelation != null ? relation.GroupRelation.Description : relation.RelatedTransaction.Description);
				tabElement.Type = TabElement.TypeValue.Grid;
				tabElement.Page = TabElement.PageValue.Default;

				// If the attribute names in the subordinated tab differ from those in the view, they 
				// must be explicitly listed (for "trn level subordination", they are known to be equal).
				bool hasDifferentAttris = false;
				IList<Gx.Attribute> paramAttris = new List<Gx.Attribute>();
				foreach (AttributeRelation subordAttr in relation.KeyAttributes)
				{
					paramAttris.Add(subordAttr.Related);
					hasDifferentAttris = hasDifferentAttris || (subordAttr.Base != subordAttr.Related);
				}

				if (hasDifferentAttris)
				{
					foreach (Gx.Attribute paramAttri in paramAttris)
						AddParameter(tabElement.Parameters, paramAttri.Name, true);
				}

				AddTrn(relation.RelatedTransaction, tabElement);
				AddGridTabAttributes(tabElement, relation.RelatedTransaction, relation.RelatedTransaction.Structure.Root, attrisInTab);
				tabElement.Modes = new ModesElement();
                tabElement.Modes.InsertCondition = viewElement.Instance.Settings.StandardActions.Insert.Condition;
                tabElement.Modes.UpdateCondition = viewElement.Instance.Settings.StandardActions.Update.Condition;
                tabElement.Modes.DeleteCondition = viewElement.Instance.Settings.StandardActions.Delete.Condition;
                tabElement.Modes.DisplayCondition = viewElement.Instance.Settings.StandardActions.Display.Condition;
                tabElement.Modes.ExportCondition = viewElement.Instance.Settings.StandardActions.Export.Condition;

			}
		}

		private void AddGridTabAttributes(TabElement tabElement, Transaction trn, TransactionLevel level, IList<TransactionAttribute> atts)
		{
			tabElement.Attributes = new AttributesElement();
			AddTransactionAttributes(tabElement.Attributes, level, atts, AttributeTitle.Column);
            AddSuggestActionsTab(tabElement.Actions, tabElement.Instance.Settings);
		}

		private string MakeTabUniqueId(TransactionLevel level, TransactionLevelRelation subord, ViewElement viewElement)
		{
			// If a table is subordinated to the level's base table more than once, then it is indexed
			// (i.e. "Client1", "Client2", "Client3"). Otherwise the table name is used ("Client").
			int currentIndex = 0;
			bool addedIndex = false;
			string tabCode = subord.RelatedLevel.Name;

			while (viewElement.FindTab(tabCode) != null)
			{
				if (addedIndex)
				{
					// Remove this index to try with next one.
					Debug.Assert(tabCode.EndsWith(currentIndex.ToString()));
					tabCode = tabCode.Substring(0, subord.RelatedLevel.Name.Length);
				}

				currentIndex++;
				tabCode = tabCode + currentIndex.ToString();
				addedIndex = true;
			}

			return tabCode;
		}

		private void AddActions(TabElement tabElement)
		{
			tabElement.AddAction(StandardAction.Update);
			tabElement.AddAction(StandardAction.Delete);
		}

		#endregion

		#endregion

		#region Misc

        private void AddSuggestParameters(ParametersElement parms, bool trn, bool sel)
        {
            if (settings != null)
            {
                if (settings.SuggestParameters != null)
                {
                    foreach (SettingsSuggestParameterSTElement par in settings.SuggestParameters)
                    {
                        if ((trn && par.ApplyTransaction) || (sel && par.ApplySelection))
                        {

                            ParameterElement parm = new ParameterElement();
                            parm.Name = par.Name;
                            parm.Domain = par.Domain;
                            parm.Null = par.Null;
                            if (parms == null) parms = new ParametersElement();
                            parms.Add(parm);
                        }
                    }
                }

            }
        }

        private string BuildCaption(TransactionAttribute ta,string defaultv)
        {
            return BuildCaption(settings.Labels.AttributeCaption, ta,defaultv);
        }

        private string BuildCaption(string formato,TransactionAttribute ta, string defaultv)
        {
            return String.Format(formato, defaultv, ta.Attribute.ContextualTitleProperty, ta.Name);
        }

        private bool TemAttributoInferido(Transaction trn, TransactionAttribute ta)
        {
            foreach (TransactionAttribute a in trn.Structure.Root.Attributes)
            {
                if (a.IsInferred)
                {
                    if (ta.ForeignKeyTo.ContainsRelatedAttribute(a.Attribute))
                    {
                        return true;
                    }
                    else
                    {
                        if (a.Attribute.SuperType != null)
                        {
                            if (ta.ForeignKeyTo.ContainsRelatedAttribute(a.Attribute.SuperType))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private string BuildIsValid(Transaction trn,TransactionAttribute ta) 
        {
           
            // Temos atributos para Carregar
            bool carrega = TemAttributoInferido(trn, ta);

            StringBuilder saida = new StringBuilder();
            if (carrega) {
                
                saida.AppendLine("for each");

                // filtros
                foreach (AttributeRelation ar in ta.ForeignKeyTo.KeyAttributes)
                {
                    saida.AppendLine("   where " + ar.Related.Name + " = &" + trn.Name + "SDT." + ar.Base.Name);
                }

                // Preenche atributos inferidos
                foreach (TransactionAttribute a in trn.Structure.Root.Attributes)
                {
                    if (a.IsInferred)
                    {
                        foreach (AttributeRelation ar in ta.ForeignKeyTo.InferredAttributes)
                        {
                            if (a.Attribute == ar.Base)
                            {
                                saida.AppendLine("      &" + trn.Name + "SDT." + ar.Base.Name + " = " + ar.Related.Name);
                            }
                        }
                    }
                }

                // Se não encontrar
                saida.AppendLine("   when none");

                // Limpa os atributos inferidos
                foreach (TransactionAttribute a in trn.Structure.Root.Attributes)
                {
                    if (a.IsInferred)
                    {
                        if (ta.ForeignKeyTo.ContainsInferredAttribute(a.Attribute))
                        {
                            saida.AppendLine("      &" + trn.Name + "SDT." + a.Name + " = nullvalue(&" + trn.Name + "SDT." + a.Name + ")");
                        }
                    }
                }

                // Volta o foco para o campo chamador
                saida.AppendLine("      ctl" + ta.Name + ".SetFocus()");

                // Se tem mensagem mostra
                if (settings.Template.SuggestMessageNotFoundForeignKey != String.Empty)
                {
                    saida.AppendLine("      msg('" + String.Format(settings.Template.SuggestMessageNotFoundForeignKey, ta.ForeignKeyTo.RelatedTransaction.Description) + "')");
                }

                saida.Append("endfor");
            }

            return saida.ToString();
        }

		private void AddTransactionAttributes(AttributesElement attributesElement, TransactionLevel level, IEnumerable<TransactionAttribute> attris, AttributeTitle descType)
		{
			IDictionary<TransactionAttribute, Gx.Attribute> attRelations = null;
			if (level != null)
				attRelations = DefaultFormHelper.CalculateRelations(level);

            bool ehSelection = false;
            if (attributesElement.Parent is SelectionElement)
            {
                ehSelection = true;
            }

			foreach (TransactionAttribute attri in attris)
			{
                bool gera = true;
                foreach (SettingsDefaultFilterElement filter in settings.DefaultFilters.DefaultFilters)
                {
                    if (ehSelection && filter.Selection)
                    {
                        if (filter.Attribute != null)
                        {
                            if (filter.Attribute.Name == attri.Name)
                            {
                                if (!filter.InGridSelection)
                                {
                                    gera = false;
                                }
                            }
                        }
                        if (gera)
                        {
                            if (!String.IsNullOrEmpty(filter.PartName))
                            {
                                if (attri.Name.IndexOf(filter.PartName, StringComparison.InvariantCultureIgnoreCase) >= 0)
                                {
                                    if (!filter.InGridSelection)
                                    {
                                        gera = false;
                                    }
                                }
                            }
                        }
                    }
                }

                if (gera || attri.IsKey)
                {
                    // Don't show those attributes that are "normally" invisible.
                    // For example, XId if it is a dynamic combo with descriptions from XName (providing XName is present).
                    bool visible = true;
                    if (attRelations != null && attRelations.ContainsKey(attri))
                    {
                        Gx.Attribute relatedAtt = attRelations[attri];
                        if (level.ContainsAttribute(relatedAtt, false))
                            visible = false;
                    }
                    if (attri.IsKey && !gera)
                    {
                        visible = false;
                    }
                    string desc = attri.GetTitle(descType);
                    if (descType == AttributeTitle.Column && attri.Attribute.ColumnTitle.Replace(" ", "").ToLower() == attri.Name.ToLower())
                    {
                        desc = attri.Attribute.ContextualTitleProperty;
                    }
                    AddTransactionAttribute(attributesElement, attri, BuildCaption(settings.Labels.GridCaption, attri, desc), visible, false);
                }
			}
		}

		private void AddTransactionAttribute(AttributesElement attributesElement, TransactionAttribute att, string description, bool visible, bool forbidAutolink)
		{
			AttributeElement attElement = attributesElement.AddAttribute(att.Attribute);
			attElement.Description = description;
			attElement.Visible = visible;
			attElement.Autolink = (!forbidAutolink);
		}

		public void AddTrn(Transaction trn, TabElement node)
		{
			AddTrn(trn, node, new List<TransactionAttribute>());
		}

		public void AddTrn(Transaction trn, TabElement tabElement, IList<TransactionAttribute> fatherPK)
		{
			tabElement.Transaction = new TransactionElement();
			tabElement.Transaction.Transaction = trn;
			tabElement.Transaction.MasterPage = TransactionElement.MasterPageValue.Default;
            AddParameters(tabElement.Transaction.Parameters, true, trn.Structure.Root.PrimaryKey, new List<TransactionAttribute>());
            AddSuggestActions(tabElement.Transaction.Actions, tabElement.Instance.Settings, true);
            AddFormTransaction(trn, tabElement.Transaction.Form);
		}

		private void AddParameters(ViewElement viewElement, bool addMode, IList<TransactionAttribute> attris)
		{
			AddParameters(viewElement.Parameters, addMode, attris, new List<TransactionAttribute>());
		}

		private void AddParameters(IBaseCollection<ParameterElement> parametersElement, bool addMode, IList<TransactionAttribute> attris, IList<TransactionAttribute> notNullAttris)
		{
			if (addMode)
				AddParameter(parametersElement, "&Mode", true);

			foreach (TransactionAttribute attri in attris)
			{
				bool nullAttri = true;
				if (notNullAttris != null && notNullAttris.Contains(attri))
					nullAttri = false;

				AddParameter(parametersElement, attri.Name, nullAttri);
			}
		}

		private void AddParameter(IBaseCollection<ParameterElement> parametersElement, string parValue, bool nullAttri)
		{
			ParameterElement parm = new ParameterElement(parValue);
			parm.Null = nullAttri;
			parametersElement.Add(parm);
		}

		private string FormatString(string formatStr, string obj)
		{
			return formatStr.Replace("<Object>", obj);
		}

        private void AddGridFreeStyle(TransactionLevel subLevel, IHPatternInstanceElement nivel, Dictionary<string, int> Counters)
        {
            GridFreeStyleElement grid = new GridFreeStyleElement();
            grid.Name = String.Format("Grid{0}", Counters["GridCounter"]);
            Counters["GridCounter"]++;
            grid.Description = subLevel.Description;

            IDictionary<TransactionAttribute, Artech.Genexus.Common.Objects.Attribute> descAttNames;
            IList<int> toExclude = DefaultFormHelper.CalculateExcluded(subLevel, out descAttNames);

            foreach (IStructureItem structureItem in subLevel.Items)
            {
                if (structureItem is TransactionAttribute)
                {
                    TransactionAttribute trnAttribute = structureItem as TransactionAttribute;
                    if (trnAttribute.IsKey || !toExclude.Contains(trnAttribute.Attribute.Id))
                    {
	                    Artech.Genexus.Common.Objects.Attribute attName;
                        if (!descAttNames.TryGetValue(trnAttribute, out attName))
                            attName = trnAttribute.Attribute;

	                    string captionProperty = "Title";
                        if (trnAttribute.IsLocal)
		                    captionProperty = "ContextualTitle";

                        AttributeElement att = new AttributeElement(attName);
                        att.Description = String.Format("={0}.{1}", attName.Name, captionProperty);

                        grid.Items.Add(att);
                    }

                }
                else if (structureItem is TransactionLevel)
                {
                    TransactionLevel subLevel2 = structureItem as TransactionLevel;
			        bool hasMoreLevels = (subLevel2.Levels.Count > 0);
                    if (hasMoreLevels)
                    {
                        AddGridFreeStyle(subLevel2, grid, Counters);
                    }
                    else
                    {
                        AddGridStandard(subLevel2, grid, Counters);
                    }
                }

            }
            if (nivel is FormElement)
            {
                FormElement form = nivel as FormElement;
                ColumnElement col = new ColumnElement();
                col.ColSpan = 2;
                col.Items.Add(grid);
                form.AddRow().Columns.Add(col);
            }
            if (nivel is GridFreeStyleElement)
            {
                GridFreeStyleElement gridnivel = nivel as GridFreeStyleElement;
                gridnivel.Items.Add(grid);
            }
        }

        private void AddGridStandard(TransactionLevel subLevel, IHPatternInstanceElement nivel, Dictionary<string, int> Counters)
        {
            GridStandardElement grid = new GridStandardElement();
            grid.Name = String.Format("Grid{0}", Counters["GridCounter"]);
            Counters["GridCounter"]++;
            grid.Description = subLevel.Description;

            IDictionary<TransactionAttribute, Artech.Genexus.Common.Objects.Attribute> descAttNames;
            IList<int> toExclude = DefaultFormHelper.CalculateExcluded(subLevel, out descAttNames);

            foreach (TransactionAttribute ta in subLevel.Attributes)
            {
                if (!toExclude.Contains(ta.Attribute.Id))
                {

                    string colTitleProperty = "ColumnTitle";
                    Artech.Genexus.Common.Objects.Attribute attName;
                    if (!descAttNames.TryGetValue(ta, out attName))
                    {
                        attName = ta.Attribute;
                        if (ta.IsLocal)
                            colTitleProperty = "ContextualTitle";
                    }

                    string colTitleExpr = String.Format("={0}.{1}", attName.Name, colTitleProperty);

                    AttributeElement att = new AttributeElement(attName);
                    att.Description = colTitleExpr;
                    grid.Attributes.Add(att);
                }
            }

            if (nivel is FormElement)
            {
                FormElement form = nivel as FormElement;
                ColumnElement col = new ColumnElement();
                col.ColSpan = 2;
                col.Items.Add(grid);
                form.AddRow().Columns.Add(col);
            }
            if (nivel is GridFreeStyleElement)
            {
                GridFreeStyleElement gridnivel = nivel as GridFreeStyleElement;
                gridnivel.Items.Add(grid);
            }      
        }

        private void AddFormTransaction(Transaction transaction, FormElement form)
        {
            Dictionary<string, int> Counters = new Dictionary<string, int>();
            Counters.Add("GridCounter", 1);

            //FormElement form = instance.Transaction.Form;

            RowElement row = new RowElement();
            ColumnElement col = null;
            ColumnElement col2 = null;

            Transaction trn = form.Instance.Transaction.Transaction;
            List<Artech.Genexus.Common.Objects.Attribute> lista = new List<Artech.Genexus.Common.Objects.Attribute>();
            if (trn != null && trn != transaction)
            {
                foreach (TransactionAttribute ta2 in trn.Structure.Root.Attributes)
                {
                    lista.Add(ta2.Attribute);
                }
                
            }
            bool geraAtt = true;

            foreach (IStructureItem item in transaction.Structure.Root.Items)
            {
                if (item is TransactionLevel)
                {
                        TransactionLevel subLevel = item as TransactionLevel;
				        bool hasMoreLevels = (subLevel.Levels.Count > 0);
                        if (hasMoreLevels)
                        {
                            AddGridFreeStyle(subLevel, form, Counters);
                        }
                        else
                        {
                            AddGridStandard(subLevel, form, Counters);
                        }
                }
                if (item is TransactionAttribute) 
                {
                    TransactionAttribute ta = item as TransactionAttribute;
                    geraAtt = true;
//                    if (!ta.is.Properties.GetPropertyValue<bool>(Properties..tra.TransactionAttribute.ShowInDefaultForms))
//                    {
//                        geraAtt = false;
//                    }
                    if (trn != null && trn != transaction)
                    {
                        if (lista.Contains(ta.Attribute))
                        {
                            geraAtt = false;
                        }
                    }

                    if (geraAtt)
                    {
                        AttributeElement ae = new AttributeElement(ta.Attribute);
                        ae.Description = ta.Attribute.ContextualTitleProperty;
                        bool SameBeforeColumn = AddSuggestAttribute(row, ae, transaction);

                        if (col2 != null && (SameBeforeColumn || (settings.Template.InferedAttributeInSameBeforeColumn && ta.IsInferred)))
                        {
                            col2.Add(ae);
                        }
                        else
                        {
                            // Cria Linha
                            form.Add(row);

                            // Cria Coluna de TextBlock
                            col = row.AddColumn();

                            // Cria Textblock
                            TextElement te = col.AddText();
                            te.Name = "tb" + ta.Name;
                            te.Caption = BuildCaption(ta, "=" + ta.Name + ".ContextualTitle");

                            // Cria Coluna de Atributo
                            col2 = row.AddColumn();

                            // Cria Atributo
                            col2.Add(ae);

                            if (ta.IsForeignKey && settings.Template.SuggestEventIsValidForForeignKey && String.IsNullOrEmpty(ae.IsValid))
                            {
                                ae.IsValid = BuildIsValid(transaction, ta);
                            }

                            // Problema trava ao apagar objeto, loop infinito
                            /*
                            if (ta.IsForeignKey && settings.Template.PromptSuggestForeignKey && ae.Link == null)
                            {
                                BuildPrompt(form.Instance,ae, ta, trn);
                            }
                            */

                            row = new RowElement();
                        }
                    }                    
                }
            }
        }

        private void BuildPrompt(HPatternInstance instance, AttributeElement ae,TransactionAttribute ta,Transaction trn)
        {            
            
            List<string> listapk = new List<string>();
            foreach (AttributeRelation ar in ta.ForeignKeyTo.KeyAttributes)
            {
                listapk.Add(ar.Related.Name);                
            }

            IEnumerable<WebPanel> listaw = WebPanel.GetAll(instance.Model);
            bool geralink = false;
            foreach (WebPanel wobj in listaw)
            {
                // Se este objeto foi gerado pelo Pattern
                if (String.IsNullOrEmpty(settings.Template.PromptSuggestNameContains) || wobj.Name.ToLower().IndexOf(settings.Template.PromptSuggestNameContains.ToLower()) >= 0)
                {
                    // Aqui vamos retirar a o loop infinito, então nunca ira sugerir um prompt dele mesmo
                    bool gera = true;
                    if (wobj.Parent is PatternInstance)
                    {
                        if (((PatternInstance)wobj.Parent).KBObjectKey.Equals(pinstance.KBObjectKey))
                            gera = false;
                    }
                    if (gera)
                    {
                        foreach (Signature sig in wobj.GetSignatures())
                        {
                            if (sig.ParametersCount > 0)
                            {
                                foreach (AttributeRelation ar in ta.ForeignKeyTo.KeyAttributes)
                                {
                                    geralink = false;
                                    foreach (Parameter par in sig.Parameters)
                                    {
                                        if (par.Object.Name.ToLower().IndexOf(ar.Related.Name.ToLower()) >= 0)
                                        {
                                            geralink = true;
                                        }
                                    }
                                    if (!geralink)
                                        break;
                                }
                                if (geralink)
                                {
                                    LinkElement link = new LinkElement();
                                    ae.Links.Add(link);
                                    link = new LinkElement();
                                    link.WebpanelObject = wobj;
                                    link.Tooltip = wobj.Description;

                                    foreach (AttributeRelation ar in ta.ForeignKeyTo.KeyAttributes)
                                    {
                                        link.Parameters.Add(new ParameterElement(ar.Base.Name));
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                if (geralink)
                {
                    break;
                }
            } 
        }

        private bool AddSuggestAttribute(RowElement row, AttributeElement att, Transaction transaction)
        {
            bool ret = false;
            foreach (SettingsSuggestInstanceElement sugg in settings.Template.Suggests)
            {
                bool achou = false;
                foreach (SettingsAttributeDefinitionElement ad in sugg.AttributeDefinitions)
                {
                    if (att.AttributeName.Trim() == ad.Name.Trim() || att.AttributeName.IndexOf(ad.Name) >= 0 || String.IsNullOrEmpty(ad.Name))
                    {
                        if (ad.TypeAll)
                        {
                            achou = true;
                        }
                        else
                        {
                            switch (att.Attribute.Type)
                            {
                                case eDBType.CHARACTER:
                                    if (ad.TypeCharacter) achou = true;
                                    break;
                                case eDBType.VARCHAR:
                                    if (ad.TypeCharacter) achou = true;
                                    break;
                                case eDBType.LONGVARCHAR:
                                    if (ad.TypeCharacter) achou = true;
                                    break;
                                case eDBType.NUMERIC:
                                    if (ad.TypeNumeric) achou = true;
                                    break;
                                case eDBType.INT:
                                    if (ad.TypeNumeric) achou = true;
                                    break;
                                case eDBType.DATE:
                                    if (ad.TypeData) achou = true;
                                    break;
                                case eDBType.DATETIME:
                                    if (ad.TypeData) achou = true;
                                    break;
                            }
                            
                        }
                        if (achou)
                        {
                            if (ad.TypeSize > 0 && ad.TypeSize != att.Attribute.Length)
                                achou = false;
                            if (ad.TypeDecimal > 0 && ad.TypeDecimal != att.Attribute.Decimals)
                                achou = false;

                        }
                        if (achou) break;
                    }
                }
                
                if (achou)
                {
                    if (sugg.Picture.ToLower() != "none" && sugg.Picture != String.Empty)
                    {
                        att.Picture = sugg.Picture;
                    }

                    if (sugg.Required.ToLower() != "none")
                    {
                        att.Required = sugg.Required;
                    }

                    if (sugg.RequiredMessage != String.Empty)
                    {
                        att.RequiredMessage = sugg.RequiredMessage;
                    }

                    if (sugg.RequiredAfterValidate != SettingsSuggestInstanceElement.RequiredAfterValidateValue.None)
                    {
                        att.RequiredAfterValidate = sugg.RequiredAfterValidate;
                    }

                    if (sugg.Rule.ToLower() != "none")
                    {
                        att.Rule = sugg.Rule;
                    }

                    if (sugg.ValueRule != String.Empty)
                    {
                        att.ValueRule = sugg.ValueRule;
                    }

                    if (sugg.IsValid != String.Empty)
                    {
                        att.IsValid = sugg.IsValid;
                    }

                    if (sugg.Readonly.ToLower() != "none")
                    {
                        att.Readonly = sugg.Readonly.ToLower() == "true" ? true : false;
                    }

                    if (sugg.Visible.ToLower() != "none")
                    {
                        att.Visible = sugg.Visible.ToLower() == "true" ? true : false;
                        if (row != null)
                            row.Visible = sugg.Visible.ToLower() == "true" ? true : false;
                    }
                    if (sugg.AttributeInSameBeforeColumn)
                    {
                        ret = true;
                    }
                    if (sugg.Description != String.Empty)
                    {
                        att.Description = sugg.Description;
                    }
                    if (!String.IsNullOrEmpty(sugg.EventValidation))
                    {
                        att.EventValidation = sugg.EventValidation;
                    }
                    if (!String.IsNullOrEmpty(sugg.MaskPicture))
                    {
                        att.MaskPicture = sugg.MaskPicture;
                        att.Reverse = sugg.Reverse;
                        att.Signed = sugg.Signed;
                        att.UnmaskedChars = sugg.UnmaskedChars;
                        att.UnmaskedValue = sugg.UnmaskedValue;
                    }
                    if (!String.IsNullOrEmpty(sugg.EventStart))
                    {
                        att.EventStart = sugg.EventStart;
                    }

                }
            }
            return ret;
        }

		#endregion
	}
}
