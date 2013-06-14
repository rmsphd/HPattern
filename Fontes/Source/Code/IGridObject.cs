using System;
using Artech.Genexus.Common.Objects;

namespace Heurys.Patterns.HPattern
{
	public interface IGridObject : IHPatternComponent
	{
		LevelElement Level { get; }
		AttributesElement Attributes { get; }
		ModesElement Modes { get; }
		OrdersElement Orders { get; }
		ActionsElement Actions { get; }
		FilterElement Filter { get; set; }        
        Transaction Transaction { get; }
        GridPropertiesElement GridProperties { get; }

        string GridType { get; }
        bool CurrentCombo { get; }
        string GetCallMethod { get; }
        bool GetLoadOnStart { get; }
        bool GetRequiredFilter { get; }
        bool GetFilterCollapse { get; }
        bool GetFilterCollapseDefault { get; }
        bool GetSetFocus { get; }
        String GetCustomRender { get; }
        String EventStart { get; set; }
        Boolean GetAllowSelection { get;  }
        String GetHeight { get; }
        String GetWidth { get;  }
        Boolean GetAutoResize { get;  }

	}

	public partial class SelectionElement : IGridObject
	{

        public Boolean GetAllowSelection
        {
            get
            {
                return GridHelper.GetAllowSelection(AllowSelection, Instance);
            }
        }

        public Boolean GetAutoResize
        {
            get
            {
                return GridHelper.GetAutoResize(AutoResize, Instance);
            }
        }

        public String GetWidth
        {
            get
            {
                return GridHelper.GetWidth(Width, Instance);
            }
        }

        public String GetHeight
        {
            get
            {
                return GridHelper.GetHeight(Height, Instance);
            }
        }

        public String GetCustomRender
        {
            get
            {
                if (CustomRender == "<default>")
                {
                    return Instance.Settings.Grid.CustomRender;
                }
                return CustomRender;
            }
        }

        public bool GetSetFocus
        {
            get
            {
                switch (SetFocus)
                {
                    case SetFocusValue.True:
                        return true;
                    case SetFocusValue.False:
                        return false;
                    default:
                        return Instance.Settings.Template.SelectionSetFocus;
                }
            }
        }

        public bool GetFilterCollapseDefault
        {
            get
            {
                switch (FilterCollapseDefault)
                {
                    case FilterCollapseDefaultValue.True:
                        return true;
                    case FilterCollapseDefaultValue.False:
                        return false;
                    default:
                        return Instance.Settings.Template.FilterCollapseDefault;
                }
            }
        }
        
        public bool GetFilterCollapse
        {
            get
            {
                {
                    switch (FilterCollapse)
                    {
                        case FilterCollapseValue.True:
                            return true;
                        case FilterCollapseValue.False:
                            return false;
                        default:
                            return Instance.Settings.Template.FilterCollapse;
                    }
                }
            }
        }

        public bool GetRequiredFilter
        {
            get
            {
                switch (RequiredFilter)
                {
                    case RequiredFilterValue.True:
                        return true;
                    case RequiredFilterValue.False:
                        return false;
                    default:
                        return Instance.Settings.Grid.RequiredFilter;
                }
            }
        }

        public bool GetLoadOnStart
        {
            get
            {
                if (GetRequiredFilter)
                {
                    return false;
                }
                else
                {
                    switch (LoadOnStart)
                    {
                        case LoadOnStartValue.True:
                            return true;
                        case LoadOnStartValue.False:
                            return false;
                        default:
                            return Instance.Settings.Grid.LoadOnStart;
                    }
                }
            }
        }

		public LevelElement Level
		{
			get { return Parent;}
		}

		Transaction IGridObject.Transaction
		{
            get { return (Instance.ParentObject is Transaction ? (Transaction)Instance.ParentObject : null); }
		}

        public string GetCallMethod
        {
            get { return (CallMethod == SelectionElement.CallMethodValue.Default ? Instance.Settings.Grid.SelectionCallMethod : CallMethod) ; }
        }

        public bool CurrentCombo
        {
            get 
            {
                if (CurrentPageCombo == CurrentPageComboValue.True)
                    return true;
                if (CurrentPageCombo == CurrentPageComboValue.Default)
                    return Instance.Settings.Grid.CurrentPageCombo;
                return false; 
            }
        }

        public string GridType 
        { 
            get { return Instance.Settings.Grid.GridType; } 
        }

        public string FilterRules
        {
            get
            {
                string rules = "";
                HPatternSettings settings = Instance.Settings;
                // Variables for filter.
                if (Filter != null)
                {
                    foreach (FilterAttributeElement fae in Filter.FilterAttributes)
                    {
                        if (!String.IsNullOrEmpty(rules)) rules += ",";
                        rules += "&" + fae.Name;
                    }

                }

                try
                {
                    int ch = settings.DynamicFilters.MaxChoices;
                    bool geraDF = false;
                    if (Filter != null)
                    {
                        if (Filter.Dynamicfilters != null)
                            geraDF = (Filter.Dynamicfilters.Count > 0 && ch > 0) ? true : false;
                    }
                    if (geraDF)
                    {
                        for (int i = 1; i <= ch; i++)
                        {
                            if (!String.IsNullOrEmpty(rules)) rules += ",";
                            rules += "&Campo" + i.ToString().Trim();
                            rules += ",&CondD" + i.ToString().Trim();
                            rules += ",&Carac" + i.ToString().Trim();
                            rules += ",&Numer" + i.ToString().Trim();
                            rules += ",&DataD" + i.ToString().Trim();
                        }
                    }
                }
                catch (System.Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Erro var: " + e.Message + Environment.NewLine + e.StackTrace);
                }

                if (!String.IsNullOrEmpty(rules))
                {
                    rules = "," + rules;
                }
                return rules;
            }
        }
        
	}

    public partial class PromptElement : IGridObject
    {
        public Boolean GetAllowSelection
        {
            get
            {
                return GridHelper.GetAllowSelection(AllowSelection, Instance);
            }
        }

        public Boolean GetAutoResize
        {
            get
            {
                return GridHelper.GetAutoResize(AutoResize, Instance);
            }
        }

        public String GetWidth
        {
            get
            {
                return GridHelper.GetWidth(Width, Instance);
            }
        }

        public String GetHeight
        {
            get
            {
                return GridHelper.GetHeight(Height, Instance);
            }
        }

        public String GetCustomRender
        {
            get
            {
                if (CustomRender == "<default>")
                {
                    return Instance.Settings.Grid.CustomRender;
                }
                return CustomRender;
            }
        }

        public bool GetSetFocus
        {
            get
            {
                switch (SetFocus)
                {
                    case SetFocusValue.True:
                        return true;
                    case SetFocusValue.False:
                        return false;
                    default:
                        return Instance.Settings.Template.SelectionSetFocus;
                }
            }
        }



        public bool GetFilterCollapseDefault
        {
            get
            {
                switch (FilterCollapseDefault)
                {
                    case FilterCollapseDefaultValue.True:
                        return true;
                    case FilterCollapseDefaultValue.False:
                        return false;
                    default:
                        return Instance.Settings.Template.FilterCollapseDefault;
                }
            }
        }

        public bool GetFilterCollapse
        {
            get
            {
                {
                    switch (FilterCollapse)
                    {
                        case FilterCollapseValue.True:
                            return true;
                        case FilterCollapseValue.False:
                            return false;
                        default:
                            return Instance.Settings.Template.FilterCollapse;
                    }
                }
            }
        }

        public bool GetRequiredFilter
        {
            get
            {
                switch (RequiredFilter)
                {
                    case RequiredFilterValue.True:
                        return true;
                    case RequiredFilterValue.False:
                        return false;
                    default:
                        return Instance.Settings.Grid.RequiredFilter;
                }
            }
        }

        public bool GetLoadOnStart
        {
            get
            {
                if (GetRequiredFilter)
                {
                    return false;
                }
                else
                {
                    switch (LoadOnStart)
                    {
                        case LoadOnStartValue.True:
                            return true;
                        case LoadOnStartValue.False:
                            return false;
                        default:
                            return Instance.Settings.Grid.LoadOnStart;
                    }
                }
            }
        }

        public LevelElement Level
        {
            get { return Parent; }
        }

        public string GetCallMethod
        {
            get { return (CallMethod == PromptElement.CallMethodValue.Default ? Instance.Settings.Grid.PromptCallMethod : CallMethod); }
        }

        public bool CurrentCombo
        {
            get
            {
                if (CurrentPageCombo == CurrentPageComboValue.True)
                    return true;
                if (CurrentPageCombo == CurrentPageComboValue.Default)
                    return Instance.Settings.Grid.CurrentPageCombo;
                return false;
            }
        }

        Transaction IGridObject.Transaction
        {
            get { return Instance.ParentObject is Transaction ? (Transaction)Instance.ParentObject : null ; }
        }

        public string GridType
        {
            get { return SettingsGridElement.GridTypeValue.Standard; }
        }

    }

	public partial class TabElement : IGridObject 
	{
        public Boolean GetAllowSelection
        {
            get
            {
                return GridHelper.GetAllowSelection(AllowSelection, Instance);
            }
        }

        public Boolean GetAutoResize
        {
            get
            {
                return GridHelper.GetAutoResize(AutoResize, Instance);
            }
        }

        public String GetWidth
        {
            get
            {
                return GridHelper.GetWidth(Width, Instance);
            }
        }

        public String GetHeight
        {
            get
            {
                return GridHelper.GetHeight(Height, Instance);
            }
        }

        public String GetCustomRender
        {
            get
            {
                if (CustomRender == "<default>")
                {
                    return Instance.Settings.Grid.CustomRender;
                }
                return CustomRender;
            }
        }

        public bool GetSetFocus
        {
            get
            {
                return false;
            }
        }

        public bool GetFilterCollapseDefault
        {
            get
            {
                return false;
            }
        }

        public bool GetFilterCollapse
        {
            get
            {
                return false;
            }
        }


        public bool GetRequiredFilter
        {
            get
            {
                return false;
            }
        }


        public bool GetLoadOnStart
        {
            get
            {
                return true;
            }
        }


		public LevelElement Level
		{
			get { return Parent.Parent; }
		}

        public string GetCallMethod
        {
            get { return (CallMethod == TabElement.CallMethodValue.Default ? Instance.Settings.Grid.ViewTabCallMethod : CallMethod); }
        }

        public bool CurrentCombo
        {
            get
            {
                if (CurrentPageCombo == CurrentPageComboValue.True)
                    return true;
                if (CurrentPageCombo == CurrentPageComboValue.Default)
                    return Instance.Settings.Grid.CurrentPageCombo;
                return false;
            }
        }

		Transaction IGridObject.Transaction
		{
			get { return TabTransaction; }
		}

        public string GridType
        {
            get { return SettingsGridElement.GridTypeValue.Standard; }
        }

	}

    public partial class GridStandardElement
    {
        public String GetCustomRender
        {
            get
            {
                if (CustomRender == "<default>")
                {
                    return Instance.Settings.Grid.CustomRender;
                }
                return CustomRender;
            }
        }


    }

    public class GridHelper
    {
        public static Boolean GetAllowSelection(String value, HPatternInstance instance)
        {
            switch (value) 
            {
                case SelectionElement.AllowSelectionValue.False:
                    return false;
                case SelectionElement.AllowSelectionValue.True:
                    return true;
                default:
                    return instance.Settings.Grid.AllowSelection;

            }
        }

        public static Boolean GetAutoResize(String value, HPatternInstance instance)
        {
            switch (value)
            {
                case SelectionElement.AutoResizeValue.False:
                    return false;
                case SelectionElement.AutoResizeValue.True:
                    return true;
                default:
                    return instance.Settings.Grid.AutoResize;

            }
        }

        public static String GetWidth(String value, HPatternInstance instance)
        {
            if (String.IsNullOrEmpty(value))
            {
                return instance.Settings.Grid.GridWidth;
            } else {
                return value;
            }
        }
        public static String GetHeight(String value, HPatternInstance instance)
        {
            if (String.IsNullOrEmpty(value))
            {
                return instance.Settings.Grid.GridHeight;
            }
            else
            {
                return value;
            }
        }

    }
}