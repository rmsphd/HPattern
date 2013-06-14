using System;
using System.Globalization;

using Artech.Common.Collections;
using Artech.Common.Helpers.Strings;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common.Helpers;
using Artech.Genexus.Common.Objects;
using Artech.Genexus.Common.Parts;
using Artech.Packages.Patterns;
using Heurys.Patterns.HPattern.Helpers;
using Heurys.Patterns.HPattern.Resources;
using System.Text;

namespace Heurys.Patterns.HPattern
{
	#region Collection class

	public partial class ActionsElement
	{

        public bool isMenuContext
        {
            get
            {
                return Find(delegate(ActionElement action) { return action.isMenuContext; }) != null;
            }
        }

		public IBaseCollection<ActionElement> MultiRowActions
		{
			get { return FindAll(delegate(ActionElement action) { return action.MultiRowSelection; }); }
		}

        public bool isMultiRowActions
        {
            get
            {
                return MultiRowActions.Count > 0;
            }
        }

		public IBaseCollection<ActionElement> GridActions
		{
			get { return FindAll(delegate(ActionElement action) { return action.InGrid; }); }
		}

        public IBaseCollection<ActionElement> GridLinkActions
        {
            get { return FindAll(delegate(ActionElement action) { return (action.CallMethod == SelectionElement.CallMethodValue.Link || action.Image == null) && action.InGrid && String.IsNullOrEmpty(action.EventCode); }); }
        }

		public IBaseCollection<ActionElement> StandaloneActions
		{
            get { return FindAll(delegate(ActionElement action) { return action.CallMethod == SelectionElement.CallMethodValue.Popup || !action.InGrid || !String.IsNullOrEmpty(action.EventCode); }); }
		}


        public IBaseCollection<ActionElement> StandaloneCustomActionsGrid
        {
            get
            {
                BaseCollection<ActionElement> standaloneActions = new BaseCollection<ActionElement>();

                // Exclude "special" actions.
                foreach (ActionElement action in this)
                    if (action.Position == ActionElement.PositionValue.Grid && (action.Name == StandardAction.Legend || !StandardAction.IsStandard(action)))
                        standaloneActions.Add(action);

                return standaloneActions.AsReadOnly();
            }
        }

		public IBaseCollection<ActionElement> StandaloneCustomActions
		{
			get
			{
				BaseCollection<ActionElement> standaloneActions = new BaseCollection<ActionElement>();

				// Exclude "special" actions.
				foreach (ActionElement action in this)
                    if (action.Position == ActionElement.PositionValue.Footer && (action.Name == StandardAction.Legend || !StandardAction.IsStandard(action)))
                        standaloneActions.Add(action);

                // Help Button
                if (this.Parent.Instance.Settings.Template.ButtonHelp) {

                    ActionElement act = new ActionElement("Help");                    
                    act.ButtonClass = this.Parent.Instance.Settings.Template.ButtonHelpClass;
                    act.Caption = this.Parent.Instance.Settings.Template.ButtonHelpCaption;
                    act.InGrid = false;
                    act.MultiRowSelection = false;
                    act.Image = null;
                    act.Condition = "";
                    act.Gxobject = null;
                    act.Position = ActionElement.PositionValue.Footer;
                    act.CreateImplementation();                    

                    standaloneActions.Add(act);
                }                

				return standaloneActions.AsReadOnly();
			}
		}

		#region Standard Actions

		public new ActionElement Insert
		{
			get { return FindAction(StandardAction.Insert); }
		}

		public ActionElement Update
		{
			get { return FindAction(StandardAction.Update); }
		}

		public ActionElement Delete
		{
			get { return FindAction(StandardAction.Delete); }
		}

		public ActionElement Display
		{
			get { return FindAction(StandardAction.Display); }
		}

		public ActionElement Export
		{
			get { return FindAction(StandardAction.Export); }
		}

        public ActionElement Legend
        {
            get { return FindAction(StandardAction.Legend); }
        }

		#endregion
	}

	#endregion

    public partial class ActionElement : IActionImplementation
	{

        public bool isSubAction
        {
            get 
            { 
                return false;
            }
        }

        public bool isMenuContext
        {
            get
            {
                return (this.SubActions != null && this.SubActions.Count > 0);
            }
        }

		private IActionImplementation m_Implementation;

		public IHPatternComponent Component
		{
			get
			{
				if (!(Parent is IHPatternComponent))
					throw new TemplateException(Messages.FormatActionNotInComponent(Name));

				return (IHPatternComponent)Parent;
			}
		}

		internal void CreateImplementation()
		{
			m_Implementation = ActionImplementationFactory.GetActionImplementation(this);
            if (StandardAction.IsStandard(this) &&  Name == StandardAction.Legend)
            {
                EventCode = BuildLegendCode();
            }
		}

		#region Standard Action

        public string CallMethod
        {
            get
            {
                string ret = SelectionElement.CallMethodValue.Link;
                if (this.Parent != null)
                {
                    if (this.Parent is IGridObject)
                    {
                        ret = ((IGridObject)this.Parent).GetCallMethod;                        
                    }
                }
                if (ret == SelectionElement.CallMethodValue.Link && !String.IsNullOrEmpty(this.EventCode))
                {
                    ret = SelectionElement.CallMethodValue.Popup;
                }
                return ret;
            }
        }

		internal void CheckStandardAction()
		{            
			SettingsActionElement standardAction = Instance.Settings.StandardActions.FindAction(this.Name);
			if (standardAction != null)
			{
				// Take settings from configuration file.
                Position = standardAction.Position;
                Width = standardAction.Width;
				MultiRowSelection = false;
                Legend = MergeProperty(Legend, standardAction.Legend);
				Caption = MergeProperty(Caption, standardAction.Caption);
				Tooltip = MergeProperty(Tooltip, standardAction.Tooltip);
				InGrid = standardAction.InGrid((IHPatternComponent)Parent);
                GridWidth = standardAction.GridWidth;
                GridHeight = standardAction.GridHeight;

				if (InGrid || Name == StandardAction.Insert || Name == StandardAction.Export)
				{
					Image = MergeProperty(Image, standardAction.Image);
					DisabledImage = MergeProperty(DisabledImage, standardAction.DisabledImage);
                    if (Image == null)
                    {
                        ButtonClass = MergeProperty(ButtonClass, standardAction.ButtonClass);
                    }
				}
				else
					ButtonClass = MergeProperty(ButtonClass, standardAction.ButtonClass);

                Caption = MergeProperty(Caption, Name);

				// Take settings from transaction.
                if (Name != StandardAction.Legend)
                {
                    Transaction transaction = ActionTransaction;
                    Gxobject = MergeProperty<KBObject>(Gxobject, transaction);
                    if (Parent != null && Parent is SelectionElement && Instance != null && Instance.Levels != null && Instance.Levels.Count > 0
                        && Instance.Levels[0].View != null && Instance.Settings.Template.TabFunction == SettingsTemplateElement.TabFunctionValue.TreeViewAnchor)
                    {
                        Gxobject = MergeProperty<KBObject>(this.Instance.Levels[0].View.Gxobject,Gxobject );
                    }

                    if (Parameters.Count == 0)
                        SetStandardParameters(transaction);
                }
			}
		}

        internal string BuildLegendCode()
        {
            StringBuilder code = new StringBuilder();
            if (Instance.Settings.StandardActions.LegendObject != null)
            {
                if (Instance.Settings.Grid.SearchButton)
                {
                    AddLegend(code, Instance.Settings.Grid.SearchCaption, ActionElement.MergeValue(Instance.Settings.Grid.SearchLegend, Instance.Settings.Grid.SearchCaption), (String.IsNullOrEmpty(Instance.Settings.Theme.SearchButton) ? Instance.Settings.Theme.Button : Instance.Settings.Theme.SearchButton), LegendType.Button);
                }
                if (Instance.Settings.Grid.ClearButton)
                {
                    AddLegend(code, Instance.Settings.Grid.ClearCaption, ActionElement.MergeValue(Instance.Settings.Grid.ClearLegend, Instance.Settings.Grid.ClearCaption), (String.IsNullOrEmpty(Instance.Settings.Theme.ClearButton) ? Instance.Settings.Theme.Button : Instance.Settings.Theme.ClearButton), LegendType.Button);
                }

                ActionsElement lista = null;
                if (this.Parent is ActionsElement)
                {
                    lista = (ActionsElement)this.Parent;
                }
                else if (this.Parent is IGridObject)
                {
                    lista = ((IGridObject)this.Parent).Actions;
                }

                if (lista != null)
                {
                    foreach (ActionElement act in lista)
                    {
                        string desc = act.MergeProperty(act.Legend,act.Tooltip);
                        desc = act.MergeProperty(desc, act.Caption);
                        LegendType tipo = LegendType.Button;
                        string nome = act.Caption;

                        if (act.Image != null && !String.IsNullOrEmpty(act.ImageName))
                        {
                            tipo = LegendType.Image;
                            nome = act.ImageName;
                        }
                        else if (act.InGrid)                            
                        {
                            tipo = LegendType.Text;
                        }                        
                        
                        AddLegend(code, nome, desc, (String.IsNullOrEmpty(act.ClassName()) ? "" : act.ClassName()), tipo);

                    }
                }
                if (Instance.Settings.Grid.DefaultPagingButtons)
                {                    
                    AddLegend(code, null, Instance.Settings.StandardActions.FirstLegend, "PagingButtonsFirst", LegendType.Text);
                    AddLegend(code, null, Instance.Settings.StandardActions.PreviousLegend, "PagingButtonsPrevious", LegendType.Text);
                    AddLegend(code, null, Instance.Settings.StandardActions.NextLegend, "PagingButtonsNext", LegendType.Text);
                    AddLegend(code, null, Instance.Settings.StandardActions.LastLegend, "PagingButtonsLast", LegendType.Text);
                }
                else
                {
                    AddLegend(code, Instance.Settings.Grid.ImageFirst.Name, ActionElement.MergeValue(Instance.Settings.StandardActions.FirstLegend, Instance.Settings.Grid.TooltipFirst), Instance.Settings.Theme.Image, LegendType.Image);
                    AddLegend(code, Instance.Settings.Grid.ImagePrevious.Name, ActionElement.MergeValue(Instance.Settings.StandardActions.PreviousLegend, Instance.Settings.Grid.TooltipPrevious), Instance.Settings.Theme.Image, LegendType.Image);
                    AddLegend(code, Instance.Settings.Grid.ImageNext.Name, ActionElement.MergeValue(Instance.Settings.StandardActions.NextLegend, Instance.Settings.Grid.TooltipNext), Instance.Settings.Theme.Image, LegendType.Image);
                    AddLegend(code, Instance.Settings.Grid.ImageLast.Name, ActionElement.MergeValue(Instance.Settings.StandardActions.LastLegend, Instance.Settings.Grid.TooltipLast),Instance.Settings.Theme.Image, LegendType.Image);
                }
                code.AppendLine();
                code.AppendLine("&Session.Set(!\"Legend\"+&PgmName.Trim(),&HPatternLegendCollection.ToXml())");
                code.AppendLine(Instance.Settings.StandardActions.LegendObjectName+".Popup(&pgmname)");
            }
            return code.ToString();
        }

        internal enum LegendType
        {
            Image, 
            Button,
            Text
        }

        internal void AddLegend(StringBuilder code, string Name, string desc, string res, LegendType tipo)
        {
            code.AppendLine("&HPatternLegend = new()");
            code.AppendLine("&HPatternLegend.Description = '" + desc + "'");
            switch (tipo) {
                case LegendType.Image:            
                    code.AppendLine("&HPatternLegend.Type = HPatternLegendType.Image");
                    if (!String.IsNullOrEmpty(Name))
                    {
                        code.AppendLine("&HPatternLegend.Name = " + Name + ".Link()");
                    }
                    break;

                case LegendType.Button:            
                    code.AppendLine("&HPatternLegend.Type = HPatternLegendType.Button");
                    if (!String.IsNullOrEmpty(Name))
                    {
                        code.AppendLine("&HPatternLegend.Name = '" + Name + "'");
                    }
                    break;
                case LegendType.Text:
                    code.AppendLine("&HPatternLegend.Type = HPatternLegendType.Text");
                    if (!String.IsNullOrEmpty(Name))
                    {
                        code.AppendLine("&HPatternLegend.Name = '" + Name + "'");
                    }
                    break;
            }

            if (!String.IsNullOrEmpty(res))
            {
                code.AppendLine("&HPatternLegend.Resource = '" + res + "'");
            }

            code.AppendLine("&HPatternLegendCollection.Add(&HPatternLegend)");
            code.AppendLine();
        }

		private void SetStandardParameters(Transaction transaction)
		{
			if (Name != StandardAction.Export)
			{

                LevelElement lev = this.Instance.Levels[0];
                string gridType = SettingsGridElement.GridTypeValue.Standard;
                if (lev != null)
                {
                    if (lev.Selection != null)
                    {
                        gridType = lev.Selection.GridType;
                    }
                }

				AddParameter("TrnMode." + Name);
                bool temload = false;
                foreach (ParameterElement pare in Component.TrnElement.Parameters)
				//foreach (TransactionAttribute pkAtt in transaction.Structure.Root.PrimaryKey)
				{
                    if (pare.Name.ToLower() != "&mode" && pare.Name.ToLower() != "mode")
                    {
                        string paramName = pare.Name;
                        if (pare.Name == "&" + HPatternInstance.PARMCALLBACK)
                        {
                            if (Component.ComponentType == ComponentType.Grid && Component is IGridObject)
                            {
                                IGridObject mgrid = (IGridObject)Component;
                                if (mgrid.GetCallMethod == SelectionElement.CallMethodValue.Popup)
                                {
                                    paramName = "''";
                                }
                                /*
                                else
                                {
                                    if (Component is SelectionElement)
                                    {
                                        SelectionElement mSel = (SelectionElement)Component;
                                        paramName = mSel.ObjectName + ".Link(" + mSel.Parameters.ListSelection() + ")";
                                    }
                                    else if (Component is TabElement)
                                    {
                                        if (Component.Parent!= null && Component.Parent.Parent != null && Component.Parent.Parent is ViewElement)
                                        {
                                            ViewElement mTab = (ViewElement)Component.Parent.Parent;
                                            paramName = mTab.ObjectName + ".Link(" + mTab.Parameters.ListView() + ")";
                                        }
                                    }
                                }
                                */
                            }
                        } else if (pare.IsAttribute && String.IsNullOrEmpty(pare.DomainName) && paramName.ToLower() != "load" && paramName.ToLower() != "&load")
                        {
                            if (Name == StandardAction.Insert)
                            {
                                if (pare.Null)
                                {
                                    if (gridType == SettingsGridElement.GridTypeValue.Standard)
                                    {
                                        paramName = String.Format(CultureInfo.InvariantCulture, "nullvalue({0})", paramName);
                                    }
                                    else
                                    {
                                        paramName = String.Format(CultureInfo.InvariantCulture, "nullvalue(&{0})", paramName);
                                    }
                                }
                                else
                                    paramName = Variables.VariableName(paramName);
                            }
                        }
                        else
                        {
                            if (paramName.ToLower() == "load" || paramName.ToLower() == "&load")
                            {
                                temload = true;
                                paramName = "true";
                            }
                            else 
                            {
                                paramName = Variables.VariableName(paramName);
                            }
                            
                        }

                        AddParameter(paramName);
                    }
				}

                bool geraBC = Component.TrnElement.WebBC;
                if (geraBC && temload == false)
                    AddParameter("true");
			}
			else
				SetExportStandardParameters();
		}

		private void SetExportStandardParameters()
		{
			if (Component.ComponentType == ComponentType.Grid)
			{
				// Parameters of the grid, filter, selected order + standard parameters.
				IGridObject gridObject = (IGridObject)Component;
                foreach (ParameterElement gridParameter in gridObject.Parameters)
                {
                    if (Instance.Settings.Template.GenerateCallBackLink == false || gridParameter.Name != "&" + HPatternInstance.PARMCALLBACK)
                    {
                        AddParameter(gridParameter.ParameterVariable);
                    }
                }

				if (gridObject.Filter != null)
                    foreach (FilterAttributeElement filterVar in gridObject.Filter.FilterAttributes)
                    {
                        AddParameter(filterVar.VariableName);
                        if (filterVar.FilterType == FilterAttributeElement.FilterTypeValue.Interval)
                        {
                            AddParameter(filterVar.VariableName+"2");
                        }
                    }

				if (gridObject.Orders.NeedsChoice)
					AddParameter(OrdersElement.OrderVariableName);
			}
			else
				throw new TemplateException(Messages.ActionExportNotInGrid);
		}

        public string MergeProperty(string value, string standardValue)
        {
            return ActionElement.MergeValue(value, standardValue);
        }

		public static string MergeValue(string value, string standardValue)
		{
			if (String.IsNullOrEmpty(value))
				return standardValue;
			else
				return value;
		}

		private TProp MergeProperty<TProp>(TProp value, TProp standardValue) where TProp : class
		{
			if (value == null)
				return standardValue;
			else
				return value;
		}

		private Transaction ActionTransaction
		{
			get
			{
				if (Parent is TabElement)
					return ((TabElement)Parent).TabTransaction;

                if (Instance.ParentObject is Transaction)
                {
                    return (Transaction)Instance.ParentObject;
                }
                else
                {
                }
                    return null;

			}
		}

		#endregion

		#region Action Implementation

        public string Eventgxui()
        {
            string eventBody = FormatMethod("Link", Parameters.ListGxui());
            if (eventBody != null && eventBody != String.Empty)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Event '{0}'", String.Format(CultureInfo.InvariantCulture, "Do{0}", Name));
                sb.Append(Environment.NewLine);
                sb.Append(Indentation.Indent(eventBody, 1));
                sb.Append(Environment.NewLine);
                sb.Append("EndEvent");
                return sb.ToString();
            }
            else
                return String.Empty;
        }

        public string Id
        {
            get
            {
                string id = Mode();
                if (id == null) id = Name;
                return id;
            }
        }

        public string gxuiCellClick
        {
            get 
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(String.Format("If gxuiSDTGrid.SelectedColumn = '{0}'",Id));
                sb.AppendLine("\t" + FormatMethod("Link", Parameters.ListGxui()));                		            
	            sb.AppendLine("endif");		
                return sb.ToString();
            }
        }

        public string Mode()
        { 
            string id = null;
            switch (Name)
            {
                case StandardAction.Insert:
                    id = "INS";
                    break;
                case StandardAction.Update:
                    id = "UPD";
                    break;
                case StandardAction.Delete:
                    id = "DLT";
                    break;
                case StandardAction.Display:
                    id = "DSP";
                    break;
                case StandardAction.Export:
                    id = "XLS";
                    break;

            }
            return id;

        }

		public string ControlName()
		{
			return m_Implementation.ControlName();
		}

        public string ClassName()
        {
            return m_Implementation.ClassName();
        }

		public string DefineVariable()
		{
			return m_Implementation.DefineVariable();
		}

		public string ToHtml()
		{
			return m_Implementation.ToHtml();
		}

		public string InitializationCode()
		{
			return m_Implementation.InitializationCode();
		}

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
		public string EnableDisableCode()
		{
			return m_Implementation.EnableDisableCode();
		}

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public string EnableCode()
		{
			return m_Implementation.EnableCode();
		}

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public string DisableCode()
		{
			return m_Implementation.DisableCode();
		}

		public string Event()
		{
			// Exclude special case: 'Export' has a custom event.
			if (Name == StandardAction.Export)
				return String.Empty;

			return m_Implementation.Event();
		}

		internal string FormatMethod(string method, string parameters)
		{
            // Se não for Standard Action e tem EventCode
            if ((Instance.Settings.StandardActions.FindAction(this.Name) == null || this.Name == StandardAction.Legend) && !String.IsNullOrEmpty(this.EventCode))
            {
                return this.EventCode;
            }
            else
            {
                if (Gxobject == null && String.IsNullOrEmpty(GxobjectName))
                    throw new TemplateException(Messages.FormatActionNeedsObject(Name));

                bool geraBC = false;
                if (Instance.Settings.StandardActions.FindAction(this.Name) != null) // Se for Standard Action
                {
                    geraBC = Instance.Transaction.WebBC;
                    /*
                    geraBC = Instance.Settings.Template.DataEntryWebPanelBC;
                    if (Instance.Transaction.DataEntryWebPanelBC.ToLower() == "true")
                        geraBC = true;
                    if (Instance.Transaction.DataEntryWebPanelBC.ToLower() == "false")
                        geraBC = false;
                    */
                }

                // The called object may not exist yet (especially if we are applying the pattern for
                // the first time, as the SDT for MultiRowSelection actions hasn't been created).
                string methodFormat = "{0}.{1}({2})";

                string ObjectName = GxobjectName;

                if (geraBC)
                {

                    bool tabtrn = true;
                    if (String.IsNullOrEmpty(Instance.Transaction.ObjectName))
                    {
                        methodFormat = "{0}BC.{1}({2})";
                        ObjectName = GxobjectName;
                    }
                    else
                    {
                        methodFormat = "{0}.{1}({2})";
                        ObjectName = Instance.Transaction.ObjectName;
                    }
                    if (Instance.Levels[0] != null)
                    {
                        if (Instance.Levels[0].View != null)
                        {
                            if (Instance.Levels[0].View.Tabs.Count > 0)
                            {
                                tabtrn = false;
                                if (String.IsNullOrEmpty(Instance.Levels[0].View.Tabs[0].ObjName))
                                {
                                    methodFormat = Instance.Transaction.TransactionName + Instance.Levels[0].View.Tabs[0].Code + "BC.{1}({2})";
                                }
                                else
                                {
                                    methodFormat = Instance.Levels[0].View.Tabs[0].ObjName + ".{1}({2})";
                                }
                            }
                        }
                    }
                    if (tabtrn)
                    {
                        if (Instance.Transaction.Form != null)
                        {
                            if (Instance.Transaction.Form.Tabs.Count > 0)
                            {
                                if (String.IsNullOrEmpty(Instance.Transaction.Form.Tabs[0].ObjectName))
                                {
                                    methodFormat = Instance.Transaction.TransactionName + Instance.Transaction.Form.Tabs[0].Name + "BC.{1}({2})";
                                }
                                else
                                {
                                    methodFormat = Instance.Transaction.Form.Tabs[0].ObjectName + ".{1}({2})";
                                }
                            }
                        }
                    }
                }

                if (Gxobject == null)
                    methodFormat = "{1}('{0}'" + (String.IsNullOrEmpty(parameters) ? "" : ", ") + "{2})";

                return String.Format(CultureInfo.InvariantCulture, methodFormat, ObjectName, method, parameters);
            }
		}

		#endregion
	}
}
