using System;
using System.Collections.Generic;
using Artech.Packages.Patterns;
using Artech.Packages.Patterns.Custom;
using Heurys.Patterns.HPattern.Resources;
using Artech.Packages.Patterns.Objects;
using Artech.Packages.Patterns.Specification;
using Artech.Genexus.Common.Objects;
using Artech.Genexus.Common;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common.CustomTypes;
using Artech.Common.Collections;
using Artech.Common.Properties;
using System.Diagnostics;
using Artech.Genexus.Common.Services;

namespace Heurys.Patterns.HPattern.Custom
{
    internal class HPatternCustomTypeSupport : PatternCustomTypeSupport
	{
		public override IPatternCustomTypeEditor GetTypeEditor(string typeId)
		{
            switch (typeId)
            {
			    case HPatternCustomType.GridCustomRender:
				    return new GridCustomRenderTypeEditor();

                case HPatternCustomType.GridCustomRenderProperty:
                    return new GridCustomRenderPropertyTypeEditor();

                case HPatternCustomType.GridCustomRenderColProperty:
                    return new GridCustomRenderColPropertyTypeEditor();

                case HPatternCustomType.ThemeClass:
                    return new ThemeClassTypeEditor();
                
                case HPatternCustomType.CustomCaption:
                    return new CustomCaptionTypeEditor();

                case HPatternCustomType.Group:
                    return new GroupTypeEditor();

                case HPatternCustomType.TabProperty:
                    return new TabPropertyTypeEditor();

            }

			throw new PatternDefinitionException(Messages.FormatUnknownCustomType(typeId));
		}
	}

	#region Custom Render options

    public class Controls
    {
        public static ControlDefinition getControl(String nome)
        {
            return getControl(nome, ControlDefinition.CONTROL_TYPE_GRID);
        }

        public static ControlDefinition getControl(String nome, String controlType)
        {
            ControlDefinition temp = null;
            foreach (ControlDefinition control in GenexusBLServices.UserControlsManager.ControlDefinitionCollection)
            {
                if (control.ControlType == controlType || String.IsNullOrEmpty(controlType))
                {
                    if (nome == control.Name)
                    {
                        temp = control;
                        break;
                    }
                }

            }
            return temp;
        }
        
        public static String getTabUserControl(String tabfunction)
        {
            String nome = null;
            switch (tabfunction)
            {
                case SettingsTemplateElement.TabFunctionValue.DolphinStyleMenu:
                    nome = "DolphinStyleMenu";
                    break;

                case SettingsTemplateElement.TabFunctionValue.TreeViewAnchor:
                    nome = "Treeview";
                    break;

                default:
                    nome = null;
                    break;
            }
            return nome;
        }

        public static String getCustomRender(PatternInstanceElement element)
        {
            String nome = "";
            bool _inst = (element.Instance is PatternInstance) ? true : false;
            if (element.Parent.Parent.Attributes.ContainsPropertyDefinition("CustomRender"))
            {
                nome = (string)element.Parent.Parent.Attributes["CustomRender"];
            }
            else
            {
                if (element.Parent.Parent.Parent.Parent.Attributes.ContainsPropertyDefinition("CustomRender"))
                {
                    nome = (string)element.Parent.Parent.Parent.Parent.Attributes["CustomRender"];
                }
            }
            if (nome == "<default>" && _inst)
            {
                HPatternInstance instance = HPatternInstance.Load((PatternInstance)element.Instance);
                nome = instance.Settings.Grid.CustomRender;
            }
            return nome;
        }

    }

	internal class GridCustomRenderTypeEditor : PatternCustomTypeEditor
	{
		public override CustomTypeEditorKind EditorKind
		{
            get { return CustomTypeEditorKind.ComboBoxExclusive; }
		}

		public override void GetComboValues(PatternInstanceElement element, SpecificationAttribute attribute, List<object> values)
		{
            bool _inst = (element.Instance is PatternInstance) ? true : false;
            if (_inst)
            {
                values.Add("<default>");
            }
			values.Add(String.Empty);
			foreach (ControlDefinition control in GenexusBLServices.UserControlsManager.ControlDefinitionCollection)
			{
				if (control.ControlType == ControlDefinition.CONTROL_TYPE_GRID)
					values.Add(control.Name);
			}

			values.Sort();
		}
	}
    
    internal class GridCustomRenderPropertyTypeEditor : PatternCustomTypeEditor
    {
        public override CustomTypeEditorKind EditorKind
        {
            get { return CustomTypeEditorKind.ComboBoxExclusive; }
        }

        public override void GetComboValues(PatternInstanceElement element, SpecificationAttribute attribute, List<object> values)
        {            
            values.Add(String.Empty);

            string nome = Controls.getCustomRender(element);
            ControlDefinition control = Controls.getControl(nome);
            if (control != null)
            {
                foreach (PropDefinition p in control.GetPropertiesDefinition())
                {
                    values.Add(p.Name);
                }
            }

        }
    }

    internal class GridCustomRenderColPropertyTypeEditor : PatternCustomTypeEditor
    {
        public override CustomTypeEditorKind EditorKind
        {
            get { return CustomTypeEditorKind.ComboBoxExclusive; }
        }

        public override void GetComboValues(PatternInstanceElement element, SpecificationAttribute attribute, List<object> values)
        {
            values.Add(String.Empty);

            string nome = Controls.getCustomRender(element);
            ControlDefinition control = Controls.getControl(nome);
            if (control != null)
            {
                foreach (PropDefinition p in control.GetColumnPropertiesDefinition())
                {
                    values.Add(p.Name);
                }
            }

        }
    }

    internal class TabPropertyTypeEditor : PatternCustomTypeEditor
    {
        public override CustomTypeEditorKind EditorKind
        {
            get { return CustomTypeEditorKind.ComboBoxExclusive; }
        }

        public override void GetComboValues(PatternInstanceElement element, SpecificationAttribute attribute, List<object> values)
        {
            values.Add(String.Empty);
            if (element.Instance is PatternSettings)
            {
                HPatternSettings settings = new HPatternSettings((PatternSettings)element.Instance);
                String nome = Controls.getTabUserControl(settings.Template.TabFunction);

                if (!String.IsNullOrEmpty(nome))
                {
                    ControlDefinition control = Controls.getControl(nome, null);
                    if (control != null)
                    {
                        foreach (PropDefinition p in control.GetPropertiesDefinition())
                        {
                            values.Add(p.Name);
                        }
                    }
                }
            }

        }
    }

	#endregion

	#region Theme Class options
    
	internal class ThemeClassTypeEditor : PatternCustomTypeEditor
	{
		public override CustomTypeEditorKind EditorKind
		{
			get { return CustomTypeEditorKind.ComboBox; }
		}

		public override void GetComboValues(PatternInstanceElement element, SpecificationAttribute attribute, List<object> values)
		{
			Theme theme = GetDefaultTheme(element.Instance.Model);

			foreach (string baseClass in GetBaseClasses(element, attribute))
			{
				foreach (string themeClass in ClassTypeConverter.GetThemeClasses(theme, baseClass))
				{
					if (!values.Contains(themeClass))
						values.Add(themeClass);
				}
			}

			values.Sort();
		}

		private Theme GetDefaultTheme(KBModel model)
		{
			KBObjectReference themeRef = model.GetPropertyValue<KBObjectReference>(Properties.MODEL.DefaultTheme);
			if (themeRef != null)
				return (Theme)themeRef.GetKBObject(model);

			return null;
		}

		private static class BaseClass
		{
			public const string Button = "Button";
			public const string Image = "Image";
			public const string TextBlock = "TextBlock";
			public const string Grid = "Grid";
			public const string Table = "Table";
			public const string Attribute = "Attribute";
            public const string Group = "Group";
		}

		private IEnumerable<string> GetBaseClasses(PatternInstanceElement element, SpecificationAttribute attribute)
		{
			string primaryClass = GetBaseClass(element, attribute);
			yield return primaryClass;

			if (primaryClass != null &&
				((element.Instance is PatternInstance &&
				element.Type == InstanceElements.Action &&
				attribute.Name == InstanceAttributes.Action.ButtonClass) ||
                (!(element.Instance is PatternInstance) &&
				element.Type == SettingsElements.Action &&
				attribute.Name == SettingsAttributes.Action.ButtonClass)))
			{
				// We don't know what the implementation will be (button, image, or grid variable column).
				//Debug.Assert(primaryClass == BaseClass.Button);
				yield return BaseClass.Image;
				// yield return BaseClass.Attribute;
			}
		}

		private string GetBaseClass(PatternInstanceElement element, SpecificationAttribute attribute)
		{
            if (!(element.Instance is PatternInstance) &&
				attribute.ParentType.Name == SettingsElements.Theme)
			{
				switch (attribute.Name)
				{
					case SettingsAttributes.Theme.Button:
                    case SettingsAttributes.Theme.BtnCancel:
                    case SettingsAttributes.Theme.BtnEnter:
                    case SettingsAttributes.Theme.ClearButton:
                    case SettingsAttributes.Theme.SearchButton:
						return BaseClass.Button;

					case SettingsAttributes.Theme.Image:
						return BaseClass.Image;

					case SettingsAttributes.Theme.Subtitle:
					case SettingsAttributes.Theme.TextToLink:
					case SettingsAttributes.Theme.PlainText:
					case SettingsAttributes.Theme.LabelKey:
                    case SettingsAttributes.Theme.PlainTextEmpty:
                    case SettingsAttributes.Theme.Label:
                    case SettingsAttributes.Theme.Separator:
                    case SettingsAttributes.Theme.FilterCollapse:
                    case SettingsAttributes.Theme.FilterExpand:
						return BaseClass.TextBlock;

					case SettingsAttributes.Theme.Grid:
						return BaseClass.Grid;

					case SettingsAttributes.Theme.ViewTable:
					case SettingsAttributes.Theme.Table100:
					case SettingsAttributes.Theme.TabTable:
						return BaseClass.Table;

                    case SettingsAttributes.Theme.Group:
                        return BaseClass.Group;

                    default:
						return BaseClass.Attribute;
				}
                				
			}

			if ((element.Instance is PatternInstance &&
				element.Type == InstanceElements.Action &&
				attribute.Name == InstanceAttributes.Action.ButtonClass) ||
				(!(element.Instance is PatternInstance) &&
				element.Type == SettingsElements.Action &&
				attribute.Name == SettingsAttributes.Action.ButtonClass))
			{
				return BaseClass.Button;
			}

            if (element.Instance is PatternInstance &&
				(element.Type == InstanceElements.Attribute || element.Type == InstanceElements.Variable) &&
				attribute.Name == InstanceAttributes.Attribute.ThemeClass)
			{
				return BaseClass.Attribute;
			}

            if (element.Instance is PatternInstance &&
                (element.Type == InstanceElements.Text) &&
                attribute.Name == InstanceAttributes.Text.Class)
            {
                return BaseClass.TextBlock;
            }

            if (element.Instance is PatternInstance &&
                (element.Type == InstanceElements.FGroup || element.Type == InstanceElements.Group) &&
                attribute.Name == InstanceAttributes.Group.Class)
            {
                return BaseClass.Group;
            }

            if (!(element.Instance is PatternInstance) &&
                element.Type == SettingsElements.Caption && attribute.Name == SettingsAttributes.Caption.Class)
            {
                return BaseClass.TextBlock;
            }

			//Debug.Assert(false, Messages.FormatUnknownThemeClassAttribute(attribute.ParentType.Name, attribute.Name));
			return null;
		}
	}

    internal class CustomCaptionTypeEditor : PatternCustomTypeEditor
    {
        public override CustomTypeEditorKind EditorKind
        {
            get { return CustomTypeEditorKind.ComboBox; }
        }

        public override void GetComboValues(PatternInstanceElement element, SpecificationAttribute attribute, List<object> values)
        {
            HPatternInstance instance = HPatternInstance.Load((PatternInstance)element.Instance);
            values.Add("Runtime");
            values.Add("None");
            foreach (SettingsCaptionElement cap in instance.Settings.CustomCaptions)
            {
                if (!values.Contains(cap.Name))
                    values.Add(cap.Name);
            }

            values.Sort();
        }

    }

    #endregion

    #region Tabs

    internal class GroupTypeEditor : PatternCustomTypeEditor
    {
        public override CustomTypeEditorKind EditorKind
        {
            get { return CustomTypeEditorKind.ComboBoxExclusive; }
        }

        public override void GetComboValues(PatternInstanceElement element, SpecificationAttribute attribute, List<object> values)
        {
            HPatternInstance instance = HPatternInstance.Load((PatternInstance)element.Instance);
            values.Add("None");
            PatternInstanceElement groups = null;
            if (element.Instance is PatternInstance)
            {
                if (element.Type == InstanceElements.Tab && element.Parent.Type == InstanceElements.Tabs && element.Parent.Parent.Type == InstanceElements.View)
                {
                    groups = element.Parent.Parent.Children[InstanceChildren.View.Groups];
                }
                if (groups == null && element.Type == InstanceElements.TabForm && element.Parent.Type == InstanceElements.Form)
                {
                    groups = element.Parent.Children[InstanceChildren.Form.Groups];
                }
            }            

            if (groups != null && groups.Children != null)
            {
                foreach (PatternInstanceElement it in groups.Children)
                {
                    if (it.Type == InstanceElements.GroupTab)
                    {
                        string nome = (string)it.Attributes[InstanceAttributes.GroupTab.Name];
                        if (!values.Contains(nome))

                            values.Add(nome);
                    }
                }
            }
           
        }

    }
 

	#endregion
}
