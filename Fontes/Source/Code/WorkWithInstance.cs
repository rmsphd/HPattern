using System;
using Artech.Architecture.Common.Objects;
using System.Collections.Generic;
using System.Collections;
using Heurys.Patterns.HPattern.Helpers;
using Heurys.Patterns.HPattern.Code;
using Artech.Packages.Patterns.Objects;
using Artech.Genexus.Common.Wiki;
using Artech.Genexus.Common.Objects;
using System.Text;

namespace Heurys.Patterns.HPattern
{
	public partial class HPatternInstance
	{
		#region Loading

		private const string k_CacheProperty = "HPatternInstance-Object";

        public static HPatternInstance Load(PatternInstance instance)
		{
			if (instance == null)
				throw new ArgumentNullException("instance");

            HPatternInstance cachedWWInstance = instance.GetPropertyValue<HPatternInstance>(k_CacheProperty);
			if (cachedWWInstance != null)
				return cachedWWInstance;

            HPatternInstance wwInstance = new HPatternInstance(instance);
			wwInstance.Prepare();

			instance.PatternPart.InstanceChanged += new EventHandler<InstanceChangedEventArgs>(wwInstance.AssociatedInstance_InstanceChanged);
			instance.SilentSetPropertyValue(k_CacheProperty, wwInstance);
			return wwInstance;
		}

        public static HPatternInstance FastLoadCache(PatternInstance instance)
        {
            if (instance == null)
                throw new ArgumentNullException("instance");

            HPatternInstance cachedWWInstance = instance.GetPropertyValue<HPatternInstance>(k_CacheProperty);
            if (cachedWWInstance != null)
                return cachedWWInstance;

            HPatternInstance wwInstance = new HPatternInstance(instance);
            return wwInstance;
        }

		public static HPatternInstance FastLoad(PatternInstance instance)
		{
			if (instance == null)
				throw new ArgumentNullException("instance");

            HPatternInstance wwInstance = new HPatternInstance(instance);
			return wwInstance;
		}

		private void AssociatedInstance_InstanceChanged(object sender, InstanceChangedEventArgs args)
		{
			args.Instance.ResetProperty(k_CacheProperty);
		}


		#endregion

		#region Work With Settings

        public HPatternSettings Settings
		{
            get { return HPatternSettings.Get(this.Model); }
		}

		#endregion

		#region Prepare instance

        private ArrayList listaWP = null;

        public ArrayList AtualizaWebPanel()
        {
            if (listaWP == null)
                listaWP = new ArrayList();
            return listaWP;
        }

		private bool m_Prepared = false;

		private void Prepare()
		{
//            modMain.SetGXPath(Artech.Common.Helpers.IO.PathHelper.StartupPath);
            //WWHeurys.HPatternBuildProcess.GetLic().CheckC();

			// "Preparing" an instance for generation entails:
			if (!m_Prepared)
			{
                
                linkCallBack();

                TransactionAttribute();

                // 0.- Se temos a view, vamos verificar se é para gerar, se não, vamos apagar :D
                if (Transaction != null)
                {
                    if (Settings.Template.GenerateViewOnlyBC)
                    {
                        if (Levels != null)
                        {
                            if (Levels.Count > 0)
                            {
                                if (Levels[0].View != null)
                                {
                                    if (!Transaction.WebBC)
                                    {
                                        Levels[0].SetViewNull();
                                    }
                                }
                            }
                        }
                    }
                }

                // 0.- Não esta implementado Export para Excel do Segundo nivel com View e BC
                if (Transaction != null)
                {
                    if (Transaction.WebBC)
                    {
                        foreach (TabElement tab in AllTabs())
                        {
                            if (tab != null)
                            {
                                if (tab.Modes != null)
                                {
                                    tab.Modes.Export = null; // ModesElement.ExportValue.False;
                                }
                            }
                        }
                    }
                }

				// 1.- Inheriting some properties from views to their tabs.
				PrepareViewTabs();

				// 2.- Creating auto-links for all attributes.
				AutoLinkAttributes();

				// 3.- Transform grid modes into default actions.
				foreach (IGridObject gridObject in AllGridObjects())
					CreateDefaultActions(gridObject);

				// 4.- Merging default actions with information from settings.
				foreach (ActionElement action in AllActions())
					ImplementAction(action);

				// 5.- Merge "After<X>" navigation options from settings.
				SetNavigationOptions();

                // TreeViewAnchor
                TreeViewAnchor();
                MenuContextActions();

				m_Prepared = true;
			}
		}

        internal void MenuContextActions()
        {
            foreach (ActionElement action in AllActions())
            {
                if (action.isMenuContext)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("&gxuiButtonCollection.Clear()");
                    foreach (SubActionElement subAct in action.SubActions)
                    {
                        sb.AppendLine(subAct.InitializationCode());
                    }
                    sb.AppendLine("gxui_Menu1.ShowMenu(&gxuiButtonCollection)");
                    action.EventCode = sb.ToString();
                    action.Gxobject = null;
                }
            }
                
        }

        internal void linkCallBack()
        {
            if (Settings.Template.GenerateCallBackLink)
            {
                if (Levels != null && Levels.Count > 0)
                {
                    if (Levels[0].View != null)
                    {
                        ViewElement view = Levels[0].View;
                        addParmlinkCallBack(view);
                    }
                }
                if (Transaction != null)
                {
                    addParmlinkCallBack(Transaction);
                }
            }

        }

        public const string PARMCALLBACK = "linkCallBack";

        internal void addParmlinkCallBack(IParameters objP)
        {
            ParameterElement par = objP.Parameters.FindParameter("&"+PARMCALLBACK);
            if (par == null)
            {
                par = new ParameterElement("&" + PARMCALLBACK);
                par.Domain = Domain.Get(Model, PARMCALLBACK);
                objP.Parameters.Add(par);
            }
        }

        #region TreeViewAnchor

        internal void TreeViewAnchor()
        {
            if (Settings.Template.TabFunction == SettingsTemplateElement.TabFunctionValue.TreeViewAnchor)
            {
                if (Levels != null && Levels.Count > 0 && Levels[0].View != null)
                {
                    ViewElement view = Levels[0].View;
                    ParameterElement par = view.Parameters.FindParameter("&Mode");
                    if (par == null) {
                        par = new ParameterElement("&Mode");
                        view.Parameters.Insert(0, par);
                    }
                }
            }
        }

        #endregion

        #region Tab inheritance

        public bool HasTabs
        {
            get
            {
                if (WebObject != null)
                {
                    if (WebObject.Form != null)
                    {
                        if (WebObject.Form.Tabs != null)
                        {
                            if (WebObject.Form.Tabs.Count > 1)
                            {
                                return true;
                            }
                        }
                    }
                }
                if (Levels != null)
                {
                    if (Levels.Count > 0)
                    {
                        if (Levels[0].View != null)
                        {
                            if (Levels[0].View.Tabs != null)
                            {
                                if (Levels[0].View.Tabs.Count > 1) 
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
                return false;
            }
        }

        public bool HasConditionalTabs()
        {
            if (Levels != null && Levels.Count > 0) {
                if (Levels[0].View != null)
                {
                    return Levels[0].View.HasConditionalTabs();
                }

            }
            if (WebObject != null && WebObject.Form != null)
            {
                return WebObject.Form.HasConditionalTabs();
            }

            return false;
        }

        public bool IsWebPanel
        {
            get
            {
                return WebPanelRoot != null ? true : false;
            }
        }

        public WebObject WebObject
        {
            get
            {
                if (Transaction != null)
                    return Transaction;
                if (WebPanelRoot != null)
                    return WebPanelRoot;
                return null;
            }
        }



		private void PrepareViewTabs()
		{
			foreach (TabElement tab in AllTabs())
			{
				// Tabs without custom transaction use instance transaction.
				if (tab.Transaction == null)
					tab.Transaction = tab.Instance.Transaction.Clone();

				// Tabs without custom parameters use view parameters.
				if (tab.Parameters == null || tab.Parameters.Count == 0)
				{
                    foreach (ParameterElement viewParameter in tab.Parent.Parameters)
                    {
                        tab.Parameters.Add(viewParameter.Clone());
                    }                    
				}
                if (Settings.Template.GenerateCallBackLink)
                {
                    addParmlinkCallBack(tab);
                    if (tab.Transaction != null)
                    {
                        addParmlinkCallBack(tab.Transaction);
                    }
                }
                // RMS Fix View Tab Grid com Popup
                foreach (ParameterElement parameter in tab.Parameters)
                {
                    if (parameter.IsAttribute)
                    {
                        if (tab.Attributes.FindAttribute(parameter.Name.Replace("&", "")) == null)
                        {
                            Artech.Genexus.Common.Objects.Attribute att = Artech.Genexus.Common.Objects.Attribute.Get(Model,parameter.Name.Replace("&", ""));
                            if (att != null)
                            {
                                AttributeElement attEl = tab.Attributes.AddAttribute(att);
                                attEl.Visible = false;
                            }

                        }
                    }
                }    
			}
		}

		#endregion

		#region Attribute Auto-links

        private void TransactionAttribute()
        {
            FormElement form = WebObject.Form;
            foreach (TransactionAttributeElement tae in form.TransactionAttributes)
            {
                // Linha
                RowElement row = form.AddRow();
                row.Visible = tae.Visible;

                // Primeira Coluna
                ColumnElement col = row.AddColumn();
                TextElement text = col.AddText("tb" + tae.AttributeName);
                text.Caption = tae.Caption;
                text.Class = tae.Class;
                text.HTMLFormat = tae.HTMLFormat;
                text.Rule = tae.TextRule;
                text.Visible = tae.Visible;

                // Segunda Coluna
                col = row.AddColumn();
                col.Add(tae);

                if (tae.AttributeDescription != null)
                {
                    AttributeElement attdesc = col.AddAttribute(tae.AttributeDescription);
                    attdesc.Readonly = true;
                }
            }

        }

		private void AutoLinkAttributes()
		{
			AutoLinkGenerator autoLinker = new AutoLinkGenerator(this);
            foreach (LevelElement level in Levels)
            {
                if (level.Selection != null && level.Selection.Attributes != null)
                {                    
                    foreach (AttributeElement attribute in level.Selection.Attributes.Attributes)
                    {
                        autoLinker.GenerateLink(attribute, level.Selection.Attributes);
                    }
                }

                if (level.View != null)
                {
                    foreach (TabElement tab in level.View.Tabs)
                    {
                        if (tab.Attributes != null)
                        {
                            foreach (AttributeElement attribute in tab.Attributes.Attributes)
                            {
                                autoLinker.GenerateLink(attribute, tab.Attributes);
                            }
                                
                        }
                    }
                }
            }
		}

		#endregion

		#region Standard actions

		private void CreateDefaultActions(IGridObject gridObject)
		{
			if (gridObject.Modes != null)
			{
				List<ActionElement> newActions = new List<ActionElement>();
				CreateDefaultAction(gridObject, StandardAction.Insert, gridObject.Modes.Insert, gridObject.Modes.InsertCondition,Settings.StandardActions.Insert.CodeEnable, newActions);
                CreateDefaultAction(gridObject, StandardAction.Display, gridObject.Modes.Display, gridObject.Modes.DisplayCondition, Settings.StandardActions.Display.CodeEnable, newActions);
                CreateDefaultAction(gridObject, StandardAction.Update, gridObject.Modes.Update, gridObject.Modes.UpdateCondition,Settings.StandardActions.Update.CodeEnable, newActions);
				CreateDefaultAction(gridObject, StandardAction.Delete, gridObject.Modes.Delete, gridObject.Modes.DeleteCondition,Settings.StandardActions.Delete.CodeEnable, newActions);				
				CreateDefaultAction(gridObject, StandardAction.Export, gridObject.Modes.Export, gridObject.Modes.ExportCondition,Settings.StandardActions.Export.CodeEnable, newActions);                
				gridObject.Actions.InsertRange(0, newActions);
                
                newActions = new List<ActionElement>();
                CreateDefaultAction(gridObject, StandardAction.Legend, gridObject.Modes.Legend, "", Settings.StandardActions.Legend.CodeEnable, newActions);
                gridObject.Actions.AddRange(newActions);
			}
		}

		private void CreateDefaultAction(IGridObject gridObject, string name, string mode, string condition,string codeEnable, List<ActionElement> newActions)
		{
			if (gridObject.Actions.FindAction(name) == null)
			{

                // Resolve "default" mode value from settings file.
				if (mode == ModesElement.InsertValue.Default)
				{
					SettingsActionElement settingsAction = Settings.StandardActions.FindAction(name);
                    if (settingsAction != null &&
                        ((settingsAction.DefaultMode && !(gridObject is PromptElement)) || 
                        (settingsAction.PromptMode && (gridObject is PromptElement))))
						mode = ModesElement.InsertValue.True;
				}

				if (mode == ModesElement.InsertValue.True)
				{
					ActionElement action = new ActionElement(name);                    
					action.Condition = condition;
                    action.CodeEnable = codeEnable;
					newActions.Add(action);
				}
			}
		}

		private void ImplementAction(ActionElement action)
		{
			action.CheckStandardAction();
			action.CreateImplementation();
		}

		#endregion

		#region Navigation options

		private void SetNavigationOptions()
		{
			if (AfterInsert == HPatternInstance.AfterInsertValue.Default)
				AfterInsert = Settings.Template.AfterInsert;

            if (AfterUpdate == HPatternInstance.AfterUpdateValue.Default)
				AfterUpdate = Settings.Template.AfterUpdate;

            if (AfterDelete == HPatternInstance.AfterDeleteValue.Default)
				AfterDelete = Settings.Template.AfterDelete;
		}

		#endregion

		#region Search for desired elements

		internal IEnumerable<IGridObject> AllGridObjects()
		{
			foreach (LevelElement level in Levels)
			{
				if (level.Selection != null)
					yield return level.Selection;

                if (level.Prompts != null)
                {
                    foreach (PromptElement prompt in level.Prompts)
                    {
                        yield return prompt;
                    }
                }

				if (level.View != null)
				{
					foreach (TabElement tab in level.View.Tabs)
					{
						if (tab.Type == TabElement.TypeValue.Grid)
							yield return tab;
					}
				}
			}
		}

		private IEnumerable<TabElement> AllTabs()
		{
			foreach (LevelElement level in Levels)
			{
				if (level.View != null)
				{
					foreach (TabElement tab in level.View.Tabs)
						yield return tab;
				}
			}
		}

		private IEnumerable<AttributeElement> AllAttributes()
		{
			foreach (LevelElement level in Levels)
			{
				if (level.Selection != null && level.Selection.Attributes != null)
				{
					foreach (AttributeElement attribute in level.Selection.Attributes.Attributes)
						yield return attribute;
				}

				if (level.View != null)
				{
					foreach (TabElement tab in level.View.Tabs)
					{
						if (tab.Attributes != null)
						{
							foreach (AttributeElement attribute in tab.Attributes.Attributes)
								yield return attribute;
						}
					}
				}
			}
		}

		private IEnumerable<ActionElement> AllActions()
		{
			foreach (LevelElement level in Levels)
			{
				if (level.Selection != null)
				{
                    foreach (ActionElement action in level.Selection.Actions)
                    {
                        yield return action;
                    }
				}

                if (level.Prompts != null)
                {
                    foreach (PromptElement prompt in level.Prompts)
                    {
                        foreach (ActionElement action in prompt.Actions)
                        {
                            yield return action;
                        }
                    }
                }

				if (level.View != null)
				{
					foreach (TabElement tab in level.View.Tabs)
					{
                        foreach (ActionElement action in tab.Actions)
                        {
                            yield return action;
                        }
					}
				}
			}
		}

		#endregion

		#endregion

        #region Utils

        public bool DocumentationEnabled
        {
            get
            {
                switch (Documentation.Enabled)
                {
                    case DocumentationElement.EnabledValue.True:
                        return true;
                    case DocumentationElement.EnabledValue.False:
                        return false;
                }
                return Settings.Documentation.Enabled;
            }
        }

        #endregion
    }
}
