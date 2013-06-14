// Pattern Settings class for pattern HPattern (Heurys)
// Generated on 16/01/2013 17:16:49 by PatternCodeGen

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Artech.Common.Collections;
using Artech.Common.Diagnostics;
using Artech.Architecture.Common.Objects;
using Artech.Packages.Patterns;
using Artech.Packages.Patterns.Objects;

namespace Heurys.Patterns.HPattern
{
	#region Settings class

	public partial class HPatternSettings : IHPatternSettingsElement
	{
		private readonly KBModel m_Model;
		protected string m_ElementName;
		private SettingsTemplateElement m_Template;
		private SettingsTabsPropertiesElement m_TabsProperties;
		private SettingsDocumentationElement m_Documentation;
		private SettingsObjectsElement m_Objects;
		private SettingsThemeElement m_Theme;
		private SettingsLabelsElement m_Labels;
		private SettingsGridElement m_Grid;
		private SettingsMasterPagesElement m_MasterPages;
		private SettingsStandardActionsElement m_StandardActions;
		private SettingsSuggestActionsElement m_SuggestActions;
		private SettingsContextElement m_Context;
		private SettingsSecurityElement m_Security;
		private SettingsDynamicFiltersElement m_DynamicFilters;
		private SettingsDefaultFiltersElement m_DefaultFilters;
		private SettingsSuggestParametersSTElement m_SuggestParameters;
		private SettingsCustomThemeMasterPageElement m_CustomThemeMasterPage;
		private SettingsCodesElement m_Codes;
		private SettingsCustomCaptionsElement m_CustomCaptions;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="HPatternSettings"/> class.
		/// </summary>
		public HPatternSettings(KBModel model)
		{
			m_Model = model;
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="HPatternSettings"/> class, loading its data from the specified Settings object.
		/// </summary>
		public HPatternSettings(PatternSettings settings)
			: this(settings.Model)
		{
			LoadFrom(settings);
		}

		/// <summary>
		/// Initializes this instance of the <see cref="HPatternSettings"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Template = new SettingsTemplateElement();
			m_Template.Parent = this;
			m_TabsProperties = new SettingsTabsPropertiesElement();
			m_TabsProperties.Parent = this;
			m_TabsProperties.ElementName = "TabsProperties";
			m_Documentation = new SettingsDocumentationElement();
			m_Documentation.Parent = this;
			m_Objects = new SettingsObjectsElement();
			m_Objects.Parent = this;
			m_Theme = new SettingsThemeElement();
			m_Theme.Parent = this;
			m_Labels = new SettingsLabelsElement();
			m_Labels.Parent = this;
			m_Grid = new SettingsGridElement();
			m_Grid.Parent = this;
			m_MasterPages = new SettingsMasterPagesElement();
			m_MasterPages.Parent = this;
			m_StandardActions = new SettingsStandardActionsElement();
			m_StandardActions.Parent = this;
			m_SuggestActions = new SettingsSuggestActionsElement();
			m_SuggestActions.Parent = this;
			m_SuggestActions.ElementName = "SuggestActions";
			m_Context = new SettingsContextElement();
			m_Context.Parent = this;
			m_Context.ElementName = "Context";
			m_Security = new SettingsSecurityElement();
			m_Security.Parent = this;
			m_DynamicFilters = new SettingsDynamicFiltersElement();
			m_DynamicFilters.Parent = this;
			m_DefaultFilters = new SettingsDefaultFiltersElement();
			m_DefaultFilters.Parent = this;
			m_SuggestParameters = new SettingsSuggestParametersSTElement();
			m_SuggestParameters.Parent = this;
			m_SuggestParameters.ElementName = "SuggestParameters";
			m_CustomThemeMasterPage = new SettingsCustomThemeMasterPageElement();
			m_CustomThemeMasterPage.Parent = this;
			m_CustomThemeMasterPage.ElementName = "CustomThemeMasterPage";
			m_Codes = new SettingsCodesElement();
			m_Codes.Parent = this;
			m_Codes.ElementName = "Codes";
			m_CustomCaptions = new SettingsCustomCaptionsElement();
			m_CustomCaptions.Parent = this;
			m_CustomCaptions.ElementName = "CustomCaptions";
		}

		#endregion

		#region Properties

		public KBModel Model
		{
			get { return m_Model; }
		}

		HPatternSettings IHPatternSettingsElement.Settings
		{
			get { return this; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return null; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		public SettingsTemplateElement Template
		{
			get { return m_Template; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Template = value;
				m_Template.Parent = this;
			}
		}

		public SettingsTabsPropertiesElement TabsProperties
		{
			get { return m_TabsProperties; }
		}

		public SettingsDocumentationElement Documentation
		{
			get { return m_Documentation; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Documentation = value;
				m_Documentation.Parent = this;
			}
		}

		public SettingsObjectsElement Objects
		{
			get { return m_Objects; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Objects = value;
				m_Objects.Parent = this;
			}
		}

		public SettingsThemeElement Theme
		{
			get { return m_Theme; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Theme = value;
				m_Theme.Parent = this;
			}
		}

		public SettingsLabelsElement Labels
		{
			get { return m_Labels; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Labels = value;
				m_Labels.Parent = this;
			}
		}

		public SettingsGridElement Grid
		{
			get { return m_Grid; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Grid = value;
				m_Grid.Parent = this;
			}
		}

		public SettingsMasterPagesElement MasterPages
		{
			get { return m_MasterPages; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_MasterPages = value;
				m_MasterPages.Parent = this;
			}
		}

		public SettingsStandardActionsElement StandardActions
		{
			get { return m_StandardActions; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_StandardActions = value;
				m_StandardActions.Parent = this;
			}
		}

		public SettingsSuggestActionsElement SuggestActions
		{
			get { return m_SuggestActions; }
		}

		public SettingsContextElement Context
		{
			get { return m_Context; }
		}

		public SettingsSecurityElement Security
		{
			get { return m_Security; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Security = value;
				m_Security.Parent = this;
			}
		}

		public SettingsDynamicFiltersElement DynamicFilters
		{
			get { return m_DynamicFilters; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_DynamicFilters = value;
				m_DynamicFilters.Parent = this;
			}
		}

		public SettingsDefaultFiltersElement DefaultFilters
		{
			get { return m_DefaultFilters; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_DefaultFilters = value;
				m_DefaultFilters.Parent = this;
			}
		}

		public SettingsSuggestParametersSTElement SuggestParameters
		{
			get { return m_SuggestParameters; }
		}

		public SettingsCustomThemeMasterPageElement CustomThemeMasterPage
		{
			get { return m_CustomThemeMasterPage; }
		}

		public SettingsCodesElement Codes
		{
			get { return m_Codes; }
		}

		public SettingsCustomCaptionsElement CustomCaptions
		{
			get { return m_CustomCaptions; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="SettingsTabPropertyElement"/> and adds it to the <see cref="TabsProperties"/> collection.
		/// </summary>
		public SettingsTabPropertyElement AddTabProperty()
		{
			SettingsTabPropertyElement tabPropertyElement = new SettingsTabPropertyElement();
			m_TabsProperties.Add(tabPropertyElement);
			return tabPropertyElement;
		}

		/// <summary>
		/// Creates a new <see cref="SettingsTabPropertyElement"/> and adds it to the <see cref="TabsProperties"/> collection.
		/// The SettingsTabPropertyElement is initialized with the specified value.
		/// </summary>
		public SettingsTabPropertyElement AddTabProperty(System.String name)
		{
			SettingsTabPropertyElement tabPropertyElement = new SettingsTabPropertyElement(name);
			m_TabsProperties.Add(tabPropertyElement);
			return tabPropertyElement;
		}

		/// <summary>
		/// Finds the <see cref="SettingsTabPropertyElement"/> in the <see cref="TabsProperties"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no tabPropertyElement is found, null is returned.
		/// </summary>
		public SettingsTabPropertyElement FindTabProperty(System.String name)
		{
			return TabsProperties.Find(delegate (SettingsTabPropertyElement tabPropertyElement) { return tabPropertyElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="SettingsSuggestActionElement"/> and adds it to the <see cref="SuggestActions"/> collection.
		/// </summary>
		public SettingsSuggestActionElement AddSuggestAction()
		{
			SettingsSuggestActionElement suggestActionElement = new SettingsSuggestActionElement();
			m_SuggestActions.Add(suggestActionElement);
			return suggestActionElement;
		}

		/// <summary>
		/// Creates a new <see cref="SettingsSuggestActionElement"/> and adds it to the <see cref="SuggestActions"/> collection.
		/// The SettingsSuggestActionElement is initialized with the specified value.
		/// </summary>
		public SettingsSuggestActionElement AddSuggestAction(System.String name)
		{
			SettingsSuggestActionElement suggestActionElement = new SettingsSuggestActionElement(name);
			m_SuggestActions.Add(suggestActionElement);
			return suggestActionElement;
		}

		/// <summary>
		/// Finds the <see cref="SettingsSuggestActionElement"/> in the <see cref="SuggestActions"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no suggestActionElement is found, null is returned.
		/// </summary>
		public SettingsSuggestActionElement FindSuggestAction(System.String name)
		{
			return SuggestActions.Find(delegate (SettingsSuggestActionElement suggestActionElement) { return suggestActionElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="SettingsContextVariableElement"/> and adds it to the <see cref="Context"/> collection.
		/// </summary>
		public SettingsContextVariableElement AddContextVariable()
		{
			SettingsContextVariableElement contextVariableElement = new SettingsContextVariableElement();
			m_Context.Add(contextVariableElement);
			return contextVariableElement;
		}

		/// <summary>
		/// Creates a new <see cref="SettingsSuggestParameterSTElement"/> and adds it to the <see cref="SuggestParameters"/> collection.
		/// </summary>
		public SettingsSuggestParameterSTElement AddSuggestParameterST()
		{
			SettingsSuggestParameterSTElement suggestParameterSTElement = new SettingsSuggestParameterSTElement();
			m_SuggestParameters.Add(suggestParameterSTElement);
			return suggestParameterSTElement;
		}

		/// <summary>
		/// Creates a new <see cref="SettingsSuggestParameterSTElement"/> and adds it to the <see cref="SuggestParameters"/> collection.
		/// The SettingsSuggestParameterSTElement is initialized with the specified value.
		/// </summary>
		public SettingsSuggestParameterSTElement AddSuggestParameterST(System.String name)
		{
			SettingsSuggestParameterSTElement suggestParameterSTElement = new SettingsSuggestParameterSTElement(name);
			m_SuggestParameters.Add(suggestParameterSTElement);
			return suggestParameterSTElement;
		}

		/// <summary>
		/// Finds the <see cref="SettingsSuggestParameterSTElement"/> in the <see cref="SuggestParameters"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no suggestParameterSTElement is found, null is returned.
		/// </summary>
		public SettingsSuggestParameterSTElement FindSuggestParameterST(System.String name)
		{
			return SuggestParameters.Find(delegate (SettingsSuggestParameterSTElement suggestParameterSTElement) { return suggestParameterSTElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="SettingsThemeMasterPageElement"/> and adds it to the <see cref="CustomThemeMasterPage"/> collection.
		/// </summary>
		public SettingsThemeMasterPageElement AddThemeMasterPage()
		{
			SettingsThemeMasterPageElement themeMasterPageElement = new SettingsThemeMasterPageElement();
			m_CustomThemeMasterPage.Add(themeMasterPageElement);
			return themeMasterPageElement;
		}

		/// <summary>
		/// Creates a new <see cref="SettingsThemeMasterPageElement"/> and adds it to the <see cref="CustomThemeMasterPage"/> collection.
		/// The SettingsThemeMasterPageElement is initialized with the specified value.
		/// </summary>
		public SettingsThemeMasterPageElement AddThemeMasterPage(System.String name)
		{
			SettingsThemeMasterPageElement themeMasterPageElement = new SettingsThemeMasterPageElement(name);
			m_CustomThemeMasterPage.Add(themeMasterPageElement);
			return themeMasterPageElement;
		}

		/// <summary>
		/// Finds the <see cref="SettingsThemeMasterPageElement"/> in the <see cref="CustomThemeMasterPage"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no themeMasterPageElement is found, null is returned.
		/// </summary>
		public SettingsThemeMasterPageElement FindThemeMasterPage(System.String name)
		{
			return CustomThemeMasterPage.Find(delegate (SettingsThemeMasterPageElement themeMasterPageElement) { return themeMasterPageElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="SettingsCodeElement"/> and adds it to the <see cref="Codes"/> collection.
		/// </summary>
		public SettingsCodeElement AddCode()
		{
			SettingsCodeElement codeElement = new SettingsCodeElement();
			m_Codes.Add(codeElement);
			return codeElement;
		}

		/// <summary>
		/// Creates a new <see cref="SettingsCaptionElement"/> and adds it to the <see cref="CustomCaptions"/> collection.
		/// </summary>
		public SettingsCaptionElement AddCaption()
		{
			SettingsCaptionElement captionElement = new SettingsCaptionElement();
			m_CustomCaptions.Add(captionElement);
			return captionElement;
		}

		/// <summary>
		/// Creates a new <see cref="SettingsCaptionElement"/> and adds it to the <see cref="CustomCaptions"/> collection.
		/// The SettingsCaptionElement is initialized with the specified value.
		/// </summary>
		public SettingsCaptionElement AddCaption(System.String name)
		{
			SettingsCaptionElement captionElement = new SettingsCaptionElement(name);
			m_CustomCaptions.Add(captionElement);
			return captionElement;
		}

		/// <summary>
		/// Finds the <see cref="SettingsCaptionElement"/> in the <see cref="CustomCaptions"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no captionElement is found, null is returned.
		/// </summary>
		public SettingsCaptionElement FindCaption(System.String name)
		{
			return CustomCaptions.Find(delegate (SettingsCaptionElement captionElement) { return captionElement.Name == name; });
		}

		#endregion

		#region Serialization

		private void LoadFrom(PatternSettings settings)
		{
			Initialize();
			LoadFrom(settings.PatternPart.RootElement);
		}

		public void SaveTo(PatternSettings settings)
		{
			SaveTo(settings.PatternPart.RootElement);
		}

		/// <summary>
		/// Loads the current <see cref="HPatternSettings"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Config")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Config"));

			Initialize();
			m_ElementName = element.Name;

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "Template" :
					{
						SettingsTemplateElement template = new SettingsTemplateElement();
						template.LoadFrom(_childElement);
						Template = template;
						break;
					}
					case "TabsProperties" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							SettingsTabPropertyElement tabPropertyElement = new SettingsTabPropertyElement();
							tabPropertyElement.LoadFrom(_childElementItem);
							TabsProperties.Add(tabPropertyElement);
						}
						break;
					}
					case "Documentation" :
					{
						SettingsDocumentationElement documentation = new SettingsDocumentationElement();
						documentation.LoadFrom(_childElement);
						Documentation = documentation;
						break;
					}
					case "Objects" :
					{
						SettingsObjectsElement objects = new SettingsObjectsElement();
						objects.LoadFrom(_childElement);
						Objects = objects;
						break;
					}
					case "Theme" :
					{
						SettingsThemeElement theme = new SettingsThemeElement();
						theme.LoadFrom(_childElement);
						Theme = theme;
						break;
					}
					case "Labels" :
					{
						SettingsLabelsElement labels = new SettingsLabelsElement();
						labels.LoadFrom(_childElement);
						Labels = labels;
						break;
					}
					case "Grid" :
					{
						SettingsGridElement grid = new SettingsGridElement();
						grid.LoadFrom(_childElement);
						Grid = grid;
						break;
					}
					case "MasterPages" :
					{
						SettingsMasterPagesElement masterPages = new SettingsMasterPagesElement();
						masterPages.LoadFrom(_childElement);
						MasterPages = masterPages;
						break;
					}
					case "StandardActions" :
					{
						SettingsStandardActionsElement standardActions = new SettingsStandardActionsElement();
						standardActions.LoadFrom(_childElement);
						StandardActions = standardActions;
						break;
					}
					case "SuggestActions" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							SettingsSuggestActionElement suggestActionElement = new SettingsSuggestActionElement();
							suggestActionElement.LoadFrom(_childElementItem);
							SuggestActions.Add(suggestActionElement);
						}
						break;
					}
					case "Context" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							SettingsContextVariableElement contextVariableElement = new SettingsContextVariableElement();
							contextVariableElement.LoadFrom(_childElementItem);
							Context.Add(contextVariableElement);
						}
						break;
					}
					case "Security" :
					{
						SettingsSecurityElement security = new SettingsSecurityElement();
						security.LoadFrom(_childElement);
						Security = security;
						break;
					}
					case "DynamicFilters" :
					{
						SettingsDynamicFiltersElement dynamicFilters = new SettingsDynamicFiltersElement();
						dynamicFilters.LoadFrom(_childElement);
						DynamicFilters = dynamicFilters;
						break;
					}
					case "DefaultFilters" :
					{
						SettingsDefaultFiltersElement defaultFilters = new SettingsDefaultFiltersElement();
						defaultFilters.LoadFrom(_childElement);
						DefaultFilters = defaultFilters;
						break;
					}
					case "SuggestParameters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							SettingsSuggestParameterSTElement suggestParameterSTElement = new SettingsSuggestParameterSTElement();
							suggestParameterSTElement.LoadFrom(_childElementItem);
							SuggestParameters.Add(suggestParameterSTElement);
						}
						break;
					}
					case "CustomThemeMasterPage" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							SettingsThemeMasterPageElement themeMasterPageElement = new SettingsThemeMasterPageElement();
							themeMasterPageElement.LoadFrom(_childElementItem);
							CustomThemeMasterPage.Add(themeMasterPageElement);
						}
						break;
					}
					case "Codes" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							SettingsCodeElement codeElement = new SettingsCodeElement();
							codeElement.LoadFrom(_childElementItem);
							Codes.Add(codeElement);
						}
						break;
					}
					case "CustomCaptions" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							SettingsCaptionElement captionElement = new SettingsCaptionElement();
							captionElement.LoadFrom(_childElementItem);
							CustomCaptions.Add(captionElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="HPatternSettings"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Config")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Config"));

			element.Initialize();

			// Save element children.
			if (m_Template != null)
			{
				PatternInstanceElement template = element.Children["Template"];
				m_Template.SaveTo(template);
			}

			if (m_TabsProperties != null)
			{
				foreach (SettingsTabPropertyElement _item in TabsProperties)
				{
					PatternInstanceElement child = element.Children["TabsProperties"].Children.AddNewElement("TabProperty");
					_item.SaveTo(child);
				}
			}

			if (m_Documentation != null)
			{
				PatternInstanceElement documentation = element.Children["Documentation"];
				m_Documentation.SaveTo(documentation);
			}

			if (m_Objects != null)
			{
				PatternInstanceElement objects = element.Children["Objects"];
				m_Objects.SaveTo(objects);
			}

			if (m_Theme != null)
			{
				PatternInstanceElement theme = element.Children["Theme"];
				m_Theme.SaveTo(theme);
			}

			if (m_Labels != null)
			{
				PatternInstanceElement labels = element.Children["Labels"];
				m_Labels.SaveTo(labels);
			}

			if (m_Grid != null)
			{
				PatternInstanceElement grid = element.Children["Grid"];
				m_Grid.SaveTo(grid);
			}

			if (m_MasterPages != null)
			{
				PatternInstanceElement masterPages = element.Children["MasterPages"];
				m_MasterPages.SaveTo(masterPages);
			}

			if (m_StandardActions != null)
			{
				PatternInstanceElement standardActions = element.Children["StandardActions"];
				m_StandardActions.SaveTo(standardActions);
			}

			if (m_SuggestActions != null)
			{
				foreach (SettingsSuggestActionElement _item in SuggestActions)
				{
					PatternInstanceElement child = element.Children["SuggestActions"].Children.AddNewElement("actions");
					_item.SaveTo(child);
				}
			}

			if (m_Context != null)
			{
				foreach (SettingsContextVariableElement _item in Context)
				{
					PatternInstanceElement child = element.Children["Context"].Children.AddNewElement("ContextVariable");
					_item.SaveTo(child);
				}
			}

			if (m_Security != null)
			{
				PatternInstanceElement security = element.Children["Security"];
				m_Security.SaveTo(security);
			}

			if (m_DynamicFilters != null)
			{
				PatternInstanceElement dynamicFilters = element.Children["DynamicFilters"];
				m_DynamicFilters.SaveTo(dynamicFilters);
			}

			if (m_DefaultFilters != null)
			{
				PatternInstanceElement defaultFilters = element.Children["DefaultFilters"];
				m_DefaultFilters.SaveTo(defaultFilters);
			}

			if (m_SuggestParameters != null)
			{
				foreach (SettingsSuggestParameterSTElement _item in SuggestParameters)
				{
					PatternInstanceElement child = element.Children["SuggestParameters"].Children.AddNewElement("parameters");
					_item.SaveTo(child);
				}
			}

			if (m_CustomThemeMasterPage != null)
			{
				foreach (SettingsThemeMasterPageElement _item in CustomThemeMasterPage)
				{
					PatternInstanceElement child = element.Children["CustomThemeMasterPage"].Children.AddNewElement("ThemeMasterPage");
					_item.SaveTo(child);
				}
			}

			if (m_Codes != null)
			{
				foreach (SettingsCodeElement _item in Codes)
				{
					PatternInstanceElement child = element.Children["Codes"].Children.AddNewElement("Code");
					_item.SaveTo(child);
				}
			}

			if (m_CustomCaptions != null)
			{
				foreach (SettingsCaptionElement _item in CustomCaptions)
				{
					PatternInstanceElement child = element.Children["CustomCaptions"].Children.AddNewElement("Caption");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="HPatternSettings"/>.
		/// </summary>
		public HPatternSettings Clone()
		{
			HPatternSettings clone = new HPatternSettings(this.Model);
			clone.Template = this.Template.Clone();
			foreach (SettingsTabPropertyElement tabPropertyElement in this.TabsProperties)
				clone.TabsProperties.Add(tabPropertyElement.Clone());
			clone.Documentation = this.Documentation.Clone();
			clone.Objects = this.Objects.Clone();
			clone.Theme = this.Theme.Clone();
			clone.Labels = this.Labels.Clone();
			clone.Grid = this.Grid.Clone();
			clone.MasterPages = this.MasterPages.Clone();
			clone.StandardActions = this.StandardActions.Clone();
			foreach (SettingsSuggestActionElement suggestActionElement in this.SuggestActions)
				clone.SuggestActions.Add(suggestActionElement.Clone());
			foreach (SettingsContextVariableElement contextVariableElement in this.Context)
				clone.Context.Add(contextVariableElement.Clone());
			clone.Security = this.Security.Clone();
			clone.DynamicFilters = this.DynamicFilters.Clone();
			clone.DefaultFilters = this.DefaultFilters.Clone();
			foreach (SettingsSuggestParameterSTElement suggestParameterSTElement in this.SuggestParameters)
				clone.SuggestParameters.Add(suggestParameterSTElement.Clone());
			foreach (SettingsThemeMasterPageElement themeMasterPageElement in this.CustomThemeMasterPage)
				clone.CustomThemeMasterPage.Add(themeMasterPageElement.Clone());
			foreach (SettingsCodeElement codeElement in this.Codes)
				clone.Codes.Add(codeElement.Clone());
			foreach (SettingsCaptionElement captionElement in this.CustomCaptions)
				clone.CustomCaptions.Add(captionElement.Clone());

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the object in the hierarchy corresponding to the element.
		/// </summary>
		public TElement GetElement<TElement>(PatternInstanceElement element) where TElement : class
		{
			if (element == null)
				throw new ArgumentNullException("element");

			string elementPath = element.InternalPath;
			List<string> path = new List<string>(elementPath.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries));
			if (path.Count < 1 || path[0] != "Config")
				throw new PatternInstanceException(String.Format("Element with path {0} not found in settings", element.Path));

			path.RemoveAt(0);
			object obj = this.GetElement(path);
			if (obj != null && !(obj is TElement))
				throw new PatternInstanceException(String.Format("Element with path {0} is not of type {1}", elementPath, typeof(TElement).FullName));

			return (TElement)obj;
		}

		private static System.Text.RegularExpressions.Regex ms_Regex = new System.Text.RegularExpressions.Regex(@"(?<name>\w*)(\[(?<index>[0-9]+)\])?");

		internal static void ParseChildPath(string childPath, out string childName, out int childIndex)
		{
			System.Text.RegularExpressions.Match expressionMatch = ms_Regex.Match(childPath);

			childName = childPath;
			if (expressionMatch.Groups["name"].Length > 0)
				childName = expressionMatch.Groups["name"].Value;

			childIndex = 0;
			if (expressionMatch.Groups["index"].Length > 0)
			{
				if (Int32.TryParse(expressionMatch.Groups["index"].Value, out childIndex))
					childIndex--; // XPath index is 1-based, collection index is 0-based.
			}
		}

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternSettings.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "Template" :
				{
					if (Template != null)
						return Template.GetElement(path);
					else
						return null;
				}
				case "TabsProperties" :
				{
					if (path.Count == 0)
						return TabsProperties;

					string itemName; int itemIndex;
					HPatternSettings.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "TabProperty")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (TabsProperties != null && itemIndex >= 0 && itemIndex < TabsProperties.Count)
						return TabsProperties[itemIndex].GetElement(path);
					else
						return null;
				}
				case "Documentation" :
				{
					if (Documentation != null)
						return Documentation.GetElement(path);
					else
						return null;
				}
				case "Objects" :
				{
					if (Objects != null)
						return Objects.GetElement(path);
					else
						return null;
				}
				case "Theme" :
				{
					if (Theme != null)
						return Theme.GetElement(path);
					else
						return null;
				}
				case "Labels" :
				{
					if (Labels != null)
						return Labels.GetElement(path);
					else
						return null;
				}
				case "Grid" :
				{
					if (Grid != null)
						return Grid.GetElement(path);
					else
						return null;
				}
				case "MasterPages" :
				{
					if (MasterPages != null)
						return MasterPages.GetElement(path);
					else
						return null;
				}
				case "StandardActions" :
				{
					if (StandardActions != null)
						return StandardActions.GetElement(path);
					else
						return null;
				}
				case "SuggestActions" :
				{
					if (path.Count == 0)
						return SuggestActions;

					string itemName; int itemIndex;
					HPatternSettings.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "actions")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (SuggestActions != null && itemIndex >= 0 && itemIndex < SuggestActions.Count)
						return SuggestActions[itemIndex].GetElement(path);
					else
						return null;
				}
				case "Context" :
				{
					if (path.Count == 0)
						return Context;

					string itemName; int itemIndex;
					HPatternSettings.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "ContextVariable")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Context != null && itemIndex >= 0 && itemIndex < Context.Count)
						return Context[itemIndex].GetElement(path);
					else
						return null;
				}
				case "Security" :
				{
					if (Security != null)
						return Security.GetElement(path);
					else
						return null;
				}
				case "DynamicFilters" :
				{
					if (DynamicFilters != null)
						return DynamicFilters.GetElement(path);
					else
						return null;
				}
				case "DefaultFilters" :
				{
					if (DefaultFilters != null)
						return DefaultFilters.GetElement(path);
					else
						return null;
				}
				case "SuggestParameters" :
				{
					if (path.Count == 0)
						return SuggestParameters;

					string itemName; int itemIndex;
					HPatternSettings.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "parameters")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (SuggestParameters != null && itemIndex >= 0 && itemIndex < SuggestParameters.Count)
						return SuggestParameters[itemIndex].GetElement(path);
					else
						return null;
				}
				case "CustomThemeMasterPage" :
				{
					if (path.Count == 0)
						return CustomThemeMasterPage;

					string itemName; int itemIndex;
					HPatternSettings.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "ThemeMasterPage")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (CustomThemeMasterPage != null && itemIndex >= 0 && itemIndex < CustomThemeMasterPage.Count)
						return CustomThemeMasterPage[itemIndex].GetElement(path);
					else
						return null;
				}
				case "Codes" :
				{
					if (path.Count == 0)
						return Codes;

					string itemName; int itemIndex;
					HPatternSettings.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "Code")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Codes != null && itemIndex >= 0 && itemIndex < Codes.Count)
						return Codes[itemIndex].GetElement(path);
					else
						return null;
				}
				case "CustomCaptions" :
				{
					if (path.Count == 0)
						return CustomCaptions;

					string itemName; int itemIndex;
					HPatternSettings.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "Caption")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (CustomCaptions != null && itemIndex >= 0 && itemIndex < CustomCaptions.Count)
						return CustomCaptions[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "WW Configuration";
		}

		#endregion
	}

	#endregion

	#region Element: CustomCaptions

	public partial class SettingsCustomCaptionsElement : Artech.Common.Collections.BaseCollection<SettingsCaptionElement>
	{
		protected string m_ElementName;

		#region Construction

		internal SettingsCustomCaptionsElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsCaptionElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private HPatternSettings m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<SettingsCaptionElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of SettingsCustomCaptionsElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="SettingsCaptionElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no Caption is found, <b>null</b> is returned.
		/// </summary>
		public SettingsCaptionElement FindCaption(System.String name)
		{
			return this.Find(delegate (SettingsCaptionElement captionItem) { return captionItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Custom Captions";
		}

		#endregion
	}

	#endregion

	#region Element: Caption

	public partial class SettingsCaptionElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.Boolean m_SetPrimaryKey;
		private bool m_IsSetPrimaryKeyDefault;
		private System.Boolean m_SetForeignKey;
		private bool m_IsSetForeignKeyDefault;
		private System.String m_SetNullable;
		private bool m_IsSetNullableDefault;
		private System.String m_SetEditable;
		private bool m_IsSetEditableDefault;
		private System.String m_SetRequired;
		private bool m_IsSetRequiredDefault;
		private System.String m_HTMLFormat;
		private bool m_IsHTMLFormatDefault;
		private System.String m_Rule;
		private bool m_IsRuleDefault;
		private System.String m_Class;
		private bool m_IsClassDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsCaptionElement"/> class.
		/// </summary>
		public SettingsCaptionElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsCaptionElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public SettingsCaptionElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsCaptionElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_SetPrimaryKey = false;
			m_IsSetPrimaryKeyDefault = true;
			m_SetForeignKey = false;
			m_IsSetForeignKeyDefault = true;
			m_SetNullable = "All";
			m_IsSetNullableDefault = true;
			m_SetEditable = "All";
			m_IsSetEditableDefault = true;
			m_SetRequired = "All";
			m_IsSetRequiredDefault = true;
			m_HTMLFormat = "default";
			m_IsHTMLFormatDefault = true;
			m_Rule = "";
			m_IsRuleDefault = true;
			m_Class = null;
			m_IsClassDefault = true;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsCaptionElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Nome que identifica a regra
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Define esta regra para Primary Key
		*/
		/// </summary>
		public System.Boolean SetPrimaryKey
		{
			get { return m_SetPrimaryKey; }
			set 
			{
				m_SetPrimaryKey = value;
				m_IsSetPrimaryKeyDefault = false;
			}
		}

		/// <summary>
		/*
		Define esta regra para Foreign Key
		*/
		/// </summary>
		public System.Boolean SetForeignKey
		{
			get { return m_SetForeignKey; }
			set 
			{
				m_SetForeignKey = value;
				m_IsSetForeignKeyDefault = false;
			}
		}

		/// <summary>
		/*
		Define esta regra para atributo Null
		*/
		/// </summary>
		public System.String SetNullable
		{
			get { return m_SetNullable; }
			set 
			{
				m_SetNullable = value;
				m_IsSetNullableDefault = false;
			}
		}

		/// <summary>
		/*
		Define esta regra para atributo Editável ou ReadOnly
		*/
		/// </summary>
		public System.String SetEditable
		{
			get { return m_SetEditable; }
			set 
			{
				m_SetEditable = value;
				m_IsSetEditableDefault = false;
			}
		}

		/// <summary>
		/*
		Define esta regra para atributo Obrigatório ou não
		*/
		/// </summary>
		public System.String SetRequired
		{
			get { return m_SetRequired; }
			set 
			{
				m_SetRequired = value;
				m_IsSetRequiredDefault = false;
			}
		}

		/// <summary>
		/*
		HTML Format
		*/
		/// </summary>
		public System.String HTMLFormat
		{
			get { return m_HTMLFormat; }
			set 
			{
				m_HTMLFormat = value;
				m_IsHTMLFormatDefault = false;
			}
		}

		/// <summary>
		/*
		Define a Expressão da Regra, Coringa {0} é o caption do textblock
		*/
		/// </summary>
		public System.String Rule
		{
			get { return m_Rule; }
			set 
			{
				m_Rule = value;
				m_IsRuleDefault = false;
			}
		}

		/// <summary>
		/*
		Class
		*/
		/// </summary>
		public System.String Class
		{
			get { return m_Class; }
			set 
			{
				m_Class = value;
				m_IsClassDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsCaptionElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Caption")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Caption"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_SetPrimaryKey = element.Attributes.GetPropertyValue<System.Boolean>("SetPrimaryKey");
			m_IsSetPrimaryKeyDefault = element.Attributes.IsPropertyDefault("SetPrimaryKey");
			m_SetForeignKey = element.Attributes.GetPropertyValue<System.Boolean>("SetForeignKey");
			m_IsSetForeignKeyDefault = element.Attributes.IsPropertyDefault("SetForeignKey");
			m_SetNullable = element.Attributes.GetPropertyValue<System.String>("SetNullable");
			m_IsSetNullableDefault = element.Attributes.IsPropertyDefault("SetNullable");
			m_SetEditable = element.Attributes.GetPropertyValue<System.String>("SetEditable");
			m_IsSetEditableDefault = element.Attributes.IsPropertyDefault("SetEditable");
			m_SetRequired = element.Attributes.GetPropertyValue<System.String>("SetRequired");
			m_IsSetRequiredDefault = element.Attributes.IsPropertyDefault("SetRequired");
			m_HTMLFormat = element.Attributes.GetPropertyValue<System.String>("HTMLFormat");
			m_IsHTMLFormatDefault = element.Attributes.IsPropertyDefault("HTMLFormat");
			m_Rule = element.Attributes.GetPropertyValue<System.String>("Rule");
			m_IsRuleDefault = element.Attributes.IsPropertyDefault("Rule");
			m_Class = element.Attributes.GetPropertyValue<System.String>("Class");
			m_IsClassDefault = element.Attributes.IsPropertyDefault("Class");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsCaptionElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Caption")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Caption"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "SetPrimaryKey", m_SetPrimaryKey, m_IsSetPrimaryKeyDefault);
			SaveAttribute(element, "SetForeignKey", m_SetForeignKey, m_IsSetForeignKeyDefault);
			SaveAttribute(element, "SetNullable", m_SetNullable, m_IsSetNullableDefault);
			SaveAttribute(element, "SetEditable", m_SetEditable, m_IsSetEditableDefault);
			SaveAttribute(element, "SetRequired", m_SetRequired, m_IsSetRequiredDefault);
			SaveAttribute(element, "HTMLFormat", m_HTMLFormat, m_IsHTMLFormatDefault);
			SaveAttribute(element, "Rule", m_Rule, m_IsRuleDefault);
			SaveAttribute(element, "Class", m_Class, m_IsClassDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_SetPrimaryKey == element.Attributes.GetPropertyValue<System.Boolean>("SetPrimaryKey"));
			Debug.Assert(m_SetForeignKey == element.Attributes.GetPropertyValue<System.Boolean>("SetForeignKey"));
			Debug.Assert(m_SetNullable == element.Attributes.GetPropertyValue<System.String>("SetNullable"));
			Debug.Assert(m_SetEditable == element.Attributes.GetPropertyValue<System.String>("SetEditable"));
			Debug.Assert(m_SetRequired == element.Attributes.GetPropertyValue<System.String>("SetRequired"));
			Debug.Assert(m_HTMLFormat == element.Attributes.GetPropertyValue<System.String>("HTMLFormat"));
			Debug.Assert(m_Rule == element.Attributes.GetPropertyValue<System.String>("Rule"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsCaptionElement"/>.
		/// </summary>
		public SettingsCaptionElement Clone()
		{
			SettingsCaptionElement clone = new SettingsCaptionElement();

			clone.Name = this.Name;
			clone.SetPrimaryKey = this.SetPrimaryKey;
			clone.SetForeignKey = this.SetForeignKey;
			clone.SetNullable = this.SetNullable;
			clone.SetEditable = this.SetEditable;
			clone.SetRequired = this.SetRequired;
			clone.HTMLFormat = this.HTMLFormat;
			clone.Rule = this.Rule;
			clone.Class = this.Class;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="SetNullable"/> property.
		/// </summary>
		public static class SetNullableValue
		{
			public const string Null = "Null";
			public const string NotNull = "NotNull";
			public const string All = "All";
		}

		/// <summary>
		/// Possible values for the <see cref="SetEditable"/> property.
		/// </summary>
		public static class SetEditableValue
		{
			public const string Editable = "Editable";
			public const string ReadOnly = "ReadOnly";
			public const string All = "All";
		}

		/// <summary>
		/// Possible values for the <see cref="SetRequired"/> property.
		/// </summary>
		public static class SetRequiredValue
		{
			public const string Required = "Required";
			public const string NotRequired = "NotRequired";
			public const string All = "All";
		}

		/// <summary>
		/// Possible values for the <see cref="HTMLFormat"/> property.
		/// </summary>
		public static class HTMLFormatValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Default = "default";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: CustomThemeMasterPage

	public partial class SettingsCustomThemeMasterPageElement : Artech.Common.Collections.BaseCollection<SettingsThemeMasterPageElement>
	{
		protected string m_ElementName;

		#region Construction

		internal SettingsCustomThemeMasterPageElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsThemeMasterPageElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private HPatternSettings m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<SettingsThemeMasterPageElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of SettingsCustomThemeMasterPageElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="SettingsThemeMasterPageElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no ThemeMasterPage is found, <b>null</b> is returned.
		/// </summary>
		public SettingsThemeMasterPageElement FindThemeMasterPage(System.String name)
		{
			return this.Find(delegate (SettingsThemeMasterPageElement themeMasterPageItem) { return themeMasterPageItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Custom Theme and MasterPage";
		}

		#endregion
	}

	#endregion

	#region Element: ThemeMasterPage

	public partial class SettingsThemeMasterPageElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_SetTheme;
		private bool m_IsSetThemeDefault;
		private System.String m_SetMasterPage;
		private bool m_IsSetMasterPageDefault;
		private Artech.Genexus.Common.Objects.Theme m_Theme;
		private KBObjectReference m_ThemeReference;
		private string m_ThemeName;
		private bool m_IsThemeDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_Selection;
		private KBObjectReference m_SelectionReference;
		private string m_SelectionName;
		private bool m_IsSelectionDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_Prompt;
		private KBObjectReference m_PromptReference;
		private string m_PromptName;
		private bool m_IsPromptDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_Transaction;
		private KBObjectReference m_TransactionReference;
		private string m_TransactionName;
		private bool m_IsTransactionDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_View;
		private KBObjectReference m_ViewReference;
		private string m_ViewName;
		private bool m_IsViewDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsThemeMasterPageElement"/> class.
		/// </summary>
		public SettingsThemeMasterPageElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsThemeMasterPageElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public SettingsThemeMasterPageElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsThemeMasterPageElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_SetTheme = "true";
			m_IsSetThemeDefault = true;
			m_SetMasterPage = "true";
			m_IsSetMasterPageDefault = true;
			m_Theme = null;
			m_ThemeReference = null;
			m_ThemeName = null;
			m_IsThemeDefault = true;
			m_Selection = null;
			m_SelectionReference = null;
			m_SelectionName = null;
			m_IsSelectionDefault = true;
			m_Prompt = null;
			m_PromptReference = null;
			m_PromptName = null;
			m_IsPromptDefault = true;
			m_Transaction = null;
			m_TransactionReference = null;
			m_TransactionName = null;
			m_IsTransactionDefault = true;
			m_View = null;
			m_ViewReference = null;
			m_ViewName = null;
			m_IsViewDefault = true;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsThemeMasterPageElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Nome que identifica a transação
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Define o tema nos objetos gerados
		*/
		/// </summary>
		public System.String SetTheme
		{
			get { return m_SetTheme; }
			set 
			{
				m_SetTheme = value;
				m_IsSetThemeDefault = false;
			}
		}

		/// <summary>
		/*
		Define a master page nos objetos gerados
		*/
		/// </summary>
		public System.String SetMasterPage
		{
			get { return m_SetMasterPage; }
			set 
			{
				m_SetMasterPage = value;
				m_IsSetMasterPageDefault = false;
			}
		}

		/// <summary>
		/*
		Name of the Theme object. If not specified, the Knowledge Base default theme will be used.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Theme Theme
		{
			get
			{
				if (m_Theme == null && m_ThemeReference != null)
					m_Theme = (Artech.Genexus.Common.Objects.Theme)m_ThemeReference.GetKBObject(Settings.Model);

				return m_Theme;
			}

			set 
			{
				m_Theme = value;
				m_ThemeReference = (value != null ? new KBObjectReference(value) : null);
				m_ThemeName = (value != null ? value.Name : null);
				m_IsThemeDefault = false;
			}
		}

		/// <summary>
		/// Theme name.
		/// </summary>
		public string ThemeName
		{
			get
			{
				if (m_ThemeName == null && m_ThemeReference != null)
					m_ThemeName = m_ThemeReference.GetName(Settings.Model);

				return m_ThemeName;
			}
		}

		/// <summary>
		/*
		Master page object name for selection webpanels.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel Selection
		{
			get
			{
				if (m_Selection == null && m_SelectionReference != null)
					m_Selection = (Artech.Genexus.Common.Objects.WebPanel)m_SelectionReference.GetKBObject(Settings.Model);

				return m_Selection;
			}

			set 
			{
				m_Selection = value;
				m_SelectionReference = (value != null ? new KBObjectReference(value) : null);
				m_SelectionName = (value != null ? value.Name : null);
				m_IsSelectionDefault = false;
			}
		}

		/// <summary>
		/// Selection name.
		/// </summary>
		public string SelectionName
		{
			get
			{
				if (m_SelectionName == null && m_SelectionReference != null)
					m_SelectionName = m_SelectionReference.GetName(Settings.Model);

				return m_SelectionName;
			}
		}

		/// <summary>
		/*
		Master page object name for prompt webpanels.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel Prompt
		{
			get
			{
				if (m_Prompt == null && m_PromptReference != null)
					m_Prompt = (Artech.Genexus.Common.Objects.WebPanel)m_PromptReference.GetKBObject(Settings.Model);

				return m_Prompt;
			}

			set 
			{
				m_Prompt = value;
				m_PromptReference = (value != null ? new KBObjectReference(value) : null);
				m_PromptName = (value != null ? value.Name : null);
				m_IsPromptDefault = false;
			}
		}

		/// <summary>
		/// Prompt name.
		/// </summary>
		public string PromptName
		{
			get
			{
				if (m_PromptName == null && m_PromptReference != null)
					m_PromptName = m_PromptReference.GetName(Settings.Model);

				return m_PromptName;
			}
		}

		/// <summary>
		/*
		Master page object name for transaction webforms.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel Transaction
		{
			get
			{
				if (m_Transaction == null && m_TransactionReference != null)
					m_Transaction = (Artech.Genexus.Common.Objects.WebPanel)m_TransactionReference.GetKBObject(Settings.Model);

				return m_Transaction;
			}

			set 
			{
				m_Transaction = value;
				m_TransactionReference = (value != null ? new KBObjectReference(value) : null);
				m_TransactionName = (value != null ? value.Name : null);
				m_IsTransactionDefault = false;
			}
		}

		/// <summary>
		/// Transaction name.
		/// </summary>
		public string TransactionName
		{
			get
			{
				if (m_TransactionName == null && m_TransactionReference != null)
					m_TransactionName = m_TransactionReference.GetName(Settings.Model);

				return m_TransactionName;
			}
		}

		/// <summary>
		/*
		Master page object name for view webpanels.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel View
		{
			get
			{
				if (m_View == null && m_ViewReference != null)
					m_View = (Artech.Genexus.Common.Objects.WebPanel)m_ViewReference.GetKBObject(Settings.Model);

				return m_View;
			}

			set 
			{
				m_View = value;
				m_ViewReference = (value != null ? new KBObjectReference(value) : null);
				m_ViewName = (value != null ? value.Name : null);
				m_IsViewDefault = false;
			}
		}

		/// <summary>
		/// View name.
		/// </summary>
		public string ViewName
		{
			get
			{
				if (m_ViewName == null && m_ViewReference != null)
					m_ViewName = m_ViewReference.GetName(Settings.Model);

				return m_ViewName;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsThemeMasterPageElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "ThemeMasterPage")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "ThemeMasterPage"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_SetTheme = element.Attributes.GetPropertyValue<System.String>("SetTheme");
			m_IsSetThemeDefault = element.Attributes.IsPropertyDefault("SetTheme");
			m_SetMasterPage = element.Attributes.GetPropertyValue<System.String>("SetMasterPage");
			m_IsSetMasterPageDefault = element.Attributes.IsPropertyDefault("SetMasterPage");
			m_ThemeReference = element.Attributes.GetPropertyValue<KBObjectReference>("ThemeReference");
			m_IsThemeDefault = element.Attributes.IsPropertyDefault("Theme");
			m_SelectionReference = element.Attributes.GetPropertyValue<KBObjectReference>("SelectionReference");
			m_IsSelectionDefault = element.Attributes.IsPropertyDefault("Selection");
			m_PromptReference = element.Attributes.GetPropertyValue<KBObjectReference>("PromptReference");
			m_IsPromptDefault = element.Attributes.IsPropertyDefault("Prompt");
			m_TransactionReference = element.Attributes.GetPropertyValue<KBObjectReference>("TransactionReference");
			m_IsTransactionDefault = element.Attributes.IsPropertyDefault("Transaction");
			m_ViewReference = element.Attributes.GetPropertyValue<KBObjectReference>("ViewReference");
			m_IsViewDefault = element.Attributes.IsPropertyDefault("View");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsThemeMasterPageElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "ThemeMasterPage")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "ThemeMasterPage"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "SetTheme", m_SetTheme, m_IsSetThemeDefault);
			SaveAttribute(element, "SetMasterPage", m_SetMasterPage, m_IsSetMasterPageDefault);
			SaveAttribute(element, "ThemeReference", m_ThemeReference, m_IsThemeDefault);
			SaveAttribute(element, "SelectionReference", m_SelectionReference, m_IsSelectionDefault);
			SaveAttribute(element, "PromptReference", m_PromptReference, m_IsPromptDefault);
			SaveAttribute(element, "TransactionReference", m_TransactionReference, m_IsTransactionDefault);
			SaveAttribute(element, "ViewReference", m_ViewReference, m_IsViewDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_SetTheme == element.Attributes.GetPropertyValue<System.String>("SetTheme"));
			Debug.Assert(m_SetMasterPage == element.Attributes.GetPropertyValue<System.String>("SetMasterPage"));
			Debug.Assert(m_ThemeReference == element.Attributes.GetPropertyValue<KBObjectReference>("ThemeReference"));
			Debug.Assert(m_SelectionReference == element.Attributes.GetPropertyValue<KBObjectReference>("SelectionReference"));
			Debug.Assert(m_PromptReference == element.Attributes.GetPropertyValue<KBObjectReference>("PromptReference"));
			Debug.Assert(m_TransactionReference == element.Attributes.GetPropertyValue<KBObjectReference>("TransactionReference"));
			Debug.Assert(m_ViewReference == element.Attributes.GetPropertyValue<KBObjectReference>("ViewReference"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsThemeMasterPageElement"/>.
		/// </summary>
		public SettingsThemeMasterPageElement Clone()
		{
			SettingsThemeMasterPageElement clone = new SettingsThemeMasterPageElement();

			clone.Name = this.Name;
			clone.SetTheme = this.SetTheme;
			clone.SetMasterPage = this.SetMasterPage;
			clone.Theme = this.Theme;
			clone.Selection = this.Selection;
			clone.Prompt = this.Prompt;
			clone.Transaction = this.Transaction;
			clone.View = this.View;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="SetTheme"/> property.
		/// </summary>
		public static class SetThemeValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Force = "force";
		}

		/// <summary>
		/// Possible values for the <see cref="SetMasterPage"/> property.
		/// </summary>
		public static class SetMasterPageValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Force = "force";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: Documentation

	public partial class SettingsDocumentationElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.Boolean m_Enabled;
		private bool m_IsEnabledDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_Template;
		private KBObjectReference m_TemplateReference;
		private string m_TemplateName;
		private bool m_IsTemplateDefault;
		private System.String m_SystemDescription;
		private bool m_IsSystemDescriptionDefault;
		private System.String m_Author;
		private bool m_IsAuthorDefault;
		private System.String m_Date;
		private bool m_IsDateDefault;
		private System.String m_Requirement;
		private bool m_IsRequirementDefault;
		private System.String m_Observation;
		private bool m_IsObservationDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsDocumentationElement"/> class.
		/// </summary>
		public SettingsDocumentationElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsDocumentationElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Enabled = false;
			m_IsEnabledDefault = true;
			m_Template = null;
			m_TemplateReference = null;
			m_TemplateName = null;
			m_IsTemplateDefault = true;
			m_SystemDescription = "";
			m_IsSystemDescriptionDefault = true;
			m_Author = "";
			m_IsAuthorDefault = true;
			m_Date = "Today";
			m_IsDateDefault = true;
			m_Requirement = "";
			m_IsRequirementDefault = true;
			m_Observation = "";
			m_IsObservationDefault = true;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsDocumentationElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Define se gera Documentação ou não
		*/
		/// </summary>
		public System.Boolean Enabled
		{
			get { return m_Enabled; }
			set 
			{
				m_Enabled = value;
				m_IsEnabledDefault = false;
			}
		}

		/// <summary>
		/*
		Define o template para a Documentação
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel Template
		{
			get
			{
				if (m_Template == null && m_TemplateReference != null)
					m_Template = (Artech.Genexus.Common.Objects.WebPanel)m_TemplateReference.GetKBObject(Settings.Model);

				return m_Template;
			}

			set 
			{
				m_Template = value;
				m_TemplateReference = (value != null ? new KBObjectReference(value) : null);
				m_TemplateName = (value != null ? value.Name : null);
				m_IsTemplateDefault = false;
			}
		}

		/// <summary>
		/// Template name.
		/// </summary>
		public string TemplateName
		{
			get
			{
				if (m_TemplateName == null && m_TemplateReference != null)
					m_TemplateName = m_TemplateReference.GetName(Settings.Model);

				return m_TemplateName;
			}
		}

		/// <summary>
		/*
		Define a descrição do sistema para a Documentação
		*/
		/// </summary>
		public System.String SystemDescription
		{
			get { return m_SystemDescription; }
			set 
			{
				m_SystemDescription = value;
				m_IsSystemDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Define o autor padrão para a Documentação
		*/
		/// </summary>
		public System.String Author
		{
			get { return m_Author; }
			set 
			{
				m_Author = value;
				m_IsAuthorDefault = false;
			}
		}

		/// <summary>
		/*
		Define a data padrão autor para a Documentação
		*/
		/// </summary>
		public System.String Date
		{
			get { return m_Date; }
			set 
			{
				m_Date = value;
				m_IsDateDefault = false;
			}
		}

		/// <summary>
		/*
		Define a identificação do Requesito
		*/
		/// </summary>
		public System.String Requirement
		{
			get { return m_Requirement; }
			set 
			{
				m_Requirement = value;
				m_IsRequirementDefault = false;
			}
		}

		/// <summary>
		/*
		Define a observação para a Documentação
		*/
		/// </summary>
		public System.String Observation
		{
			get { return m_Observation; }
			set 
			{
				m_Observation = value;
				m_IsObservationDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsDocumentationElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Documentation")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Documentation"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Enabled = element.Attributes.GetPropertyValue<System.Boolean>("Enabled");
			m_IsEnabledDefault = element.Attributes.IsPropertyDefault("Enabled");
			m_TemplateReference = element.Attributes.GetPropertyValue<KBObjectReference>("TemplateReference");
			m_IsTemplateDefault = element.Attributes.IsPropertyDefault("Template");
			m_SystemDescription = element.Attributes.GetPropertyValue<System.String>("SystemDescription");
			m_IsSystemDescriptionDefault = element.Attributes.IsPropertyDefault("SystemDescription");
			m_Author = element.Attributes.GetPropertyValue<System.String>("Author");
			m_IsAuthorDefault = element.Attributes.IsPropertyDefault("Author");
			m_Date = element.Attributes.GetPropertyValue<System.String>("Date");
			m_IsDateDefault = element.Attributes.IsPropertyDefault("Date");
			m_Requirement = element.Attributes.GetPropertyValue<System.String>("Requirement");
			m_IsRequirementDefault = element.Attributes.IsPropertyDefault("Requirement");
			m_Observation = element.Attributes.GetPropertyValue<System.String>("Observation");
			m_IsObservationDefault = element.Attributes.IsPropertyDefault("Observation");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsDocumentationElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Documentation")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Documentation"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "Enabled", m_Enabled, m_IsEnabledDefault);
			SaveAttribute(element, "TemplateReference", m_TemplateReference, m_IsTemplateDefault);
			SaveAttribute(element, "SystemDescription", m_SystemDescription, m_IsSystemDescriptionDefault);
			SaveAttribute(element, "Author", m_Author, m_IsAuthorDefault);
			SaveAttribute(element, "Date", m_Date, m_IsDateDefault);
			SaveAttribute(element, "Requirement", m_Requirement, m_IsRequirementDefault);
			SaveAttribute(element, "Observation", m_Observation, m_IsObservationDefault);

			Debug.Assert(m_Enabled == element.Attributes.GetPropertyValue<System.Boolean>("Enabled"));
			Debug.Assert(m_TemplateReference == element.Attributes.GetPropertyValue<KBObjectReference>("TemplateReference"));
			Debug.Assert(m_SystemDescription == element.Attributes.GetPropertyValue<System.String>("SystemDescription"));
			Debug.Assert(m_Author == element.Attributes.GetPropertyValue<System.String>("Author"));
			Debug.Assert(m_Date == element.Attributes.GetPropertyValue<System.String>("Date"));
			Debug.Assert(m_Requirement == element.Attributes.GetPropertyValue<System.String>("Requirement"));
			Debug.Assert(m_Observation == element.Attributes.GetPropertyValue<System.String>("Observation"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsDocumentationElement"/>.
		/// </summary>
		public SettingsDocumentationElement Clone()
		{
			SettingsDocumentationElement clone = new SettingsDocumentationElement();

			clone.Enabled = this.Enabled;
			clone.Template = this.Template;
			clone.SystemDescription = this.SystemDescription;
			clone.Author = this.Author;
			clone.Date = this.Date;
			clone.Requirement = this.Requirement;
			clone.Observation = this.Observation;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Date"/> property.
		/// </summary>
		public static class DateValue
		{
			public const string Today = "Today";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Documentation";
		}

		#endregion
	}

	#endregion

	#region Element: SuggestParametersST

	public partial class SettingsSuggestParametersSTElement : Artech.Common.Collections.BaseCollection<SettingsSuggestParameterSTElement>
	{
		protected string m_ElementName;

		#region Construction

		internal SettingsSuggestParametersSTElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsSuggestParameterSTElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private HPatternSettings m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<SettingsSuggestParameterSTElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of SettingsSuggestParametersSTElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="SettingsSuggestParameterSTElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no SuggestParameterST is found, <b>null</b> is returned.
		/// </summary>
		public SettingsSuggestParameterSTElement FindSuggestParameterST(System.String name)
		{
			return this.Find(delegate (SettingsSuggestParameterSTElement parametersItem) { return parametersItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Suggest Parameters";
		}

		#endregion
	}

	#endregion

	#region Element: SuggestParameterST

	public partial class SettingsSuggestParameterSTElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private Artech.Genexus.Common.Objects.Domain m_Domain;
		private KBObjectReference m_DomainReference;
		private string m_DomainName;
		private bool m_IsDomainDefault;
		private System.Boolean m_Null;
		private bool m_IsNullDefault;
		private System.Boolean m_ApplySelection;
		private bool m_IsApplySelectionDefault;
		private System.Boolean m_ApplyTransaction;
		private bool m_IsApplyTransactionDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsSuggestParameterSTElement"/> class.
		/// </summary>
		public SettingsSuggestParameterSTElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsSuggestParameterSTElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public SettingsSuggestParameterSTElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsSuggestParameterSTElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Domain = null;
			m_DomainReference = null;
			m_DomainName = null;
			m_IsDomainDefault = true;
			m_Null = true;
			m_IsNullDefault = true;
			m_ApplySelection = true;
			m_IsApplySelectionDefault = true;
			m_ApplyTransaction = true;
			m_IsApplyTransactionDefault = true;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsSuggestParameterSTElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Parameter Name.
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Only needed for variables (defines their domain).
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Domain Domain
		{
			get
			{
				if (m_Domain == null && m_DomainReference != null)
					m_Domain = (Artech.Genexus.Common.Objects.Domain)m_DomainReference.GetKBObject(Settings.Model);

				return m_Domain;
			}

			set 
			{
				m_Domain = value;
				m_DomainReference = (value != null ? new KBObjectReference(value) : null);
				m_DomainName = (value != null ? value.Name : null);
				m_IsDomainDefault = false;
			}
		}

		/// <summary>
		/// Domain name.
		/// </summary>
		public string DomainName
		{
			get
			{
				if (m_DomainName == null && m_DomainReference != null)
					m_DomainName = m_DomainReference.GetName(Settings.Model);

				return m_DomainName;
			}
		}

		/// <summary>
		/*
		If set to false, the parameter value cannot change in Insert. (For example, if inserting a City in a given Country, CountryId doesn't change when calling City transaction).
		*/
		/// </summary>
		public System.Boolean Null
		{
			get { return m_Null; }
			set 
			{
				m_Null = value;
				m_IsNullDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica a Seleção
		*/
		/// </summary>
		public System.Boolean ApplySelection
		{
			get { return m_ApplySelection; }
			set 
			{
				m_ApplySelection = value;
				m_IsApplySelectionDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica a Transação
		*/
		/// </summary>
		public System.Boolean ApplyTransaction
		{
			get { return m_ApplyTransaction; }
			set 
			{
				m_ApplyTransaction = value;
				m_IsApplyTransactionDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsSuggestParameterSTElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "SuggestParameterST")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "SuggestParameterST"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_DomainReference = element.Attributes.GetPropertyValue<KBObjectReference>("domainReference");
			m_IsDomainDefault = element.Attributes.IsPropertyDefault("domain");
			m_Null = element.Attributes.GetPropertyValue<System.Boolean>("null");
			m_IsNullDefault = element.Attributes.IsPropertyDefault("null");
			m_ApplySelection = element.Attributes.GetPropertyValue<System.Boolean>("applySelection");
			m_IsApplySelectionDefault = element.Attributes.IsPropertyDefault("applySelection");
			m_ApplyTransaction = element.Attributes.GetPropertyValue<System.Boolean>("applyTransaction");
			m_IsApplyTransactionDefault = element.Attributes.IsPropertyDefault("applyTransaction");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsSuggestParameterSTElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "SuggestParameterST")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "SuggestParameterST"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "domainReference", m_DomainReference, m_IsDomainDefault);
			SaveAttribute(element, "null", m_Null, m_IsNullDefault);
			SaveAttribute(element, "applySelection", m_ApplySelection, m_IsApplySelectionDefault);
			SaveAttribute(element, "applyTransaction", m_ApplyTransaction, m_IsApplyTransactionDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_DomainReference == element.Attributes.GetPropertyValue<KBObjectReference>("domainReference"));
			Debug.Assert(m_Null == element.Attributes.GetPropertyValue<System.Boolean>("null"));
			Debug.Assert(m_ApplySelection == element.Attributes.GetPropertyValue<System.Boolean>("applySelection"));
			Debug.Assert(m_ApplyTransaction == element.Attributes.GetPropertyValue<System.Boolean>("applyTransaction"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsSuggestParameterSTElement"/>.
		/// </summary>
		public SettingsSuggestParameterSTElement Clone()
		{
			SettingsSuggestParameterSTElement clone = new SettingsSuggestParameterSTElement();

			clone.Name = this.Name;
			clone.Domain = this.Domain;
			clone.Null = this.Null;
			clone.ApplySelection = this.ApplySelection;
			clone.ApplyTransaction = this.ApplyTransaction;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Parameter {0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: SuggestActions

	public partial class SettingsSuggestActionsElement : Artech.Common.Collections.BaseCollection<SettingsSuggestActionElement>
	{
		protected string m_ElementName;

		#region Construction

		internal SettingsSuggestActionsElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsSuggestActionElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private HPatternSettings m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<SettingsSuggestActionElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of SettingsSuggestActionsElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="SettingsSuggestActionElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no SuggestAction is found, <b>null</b> is returned.
		/// </summary>
		public SettingsSuggestActionElement FindSuggestAction(System.String name)
		{
			return this.Find(delegate (SettingsSuggestActionElement actionsItem) { return actionsItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Suggest Actions";
		}

		#endregion
	}

	#endregion

	#region Element: SuggestAction

	public partial class SettingsSuggestActionElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Caption;
		private bool m_IsCaptionDefault;
		private Artech.Architecture.Common.Objects.KBObject m_Gxobject;
		private KBObjectReference m_GxobjectReference;
		private string m_GxobjectName;
		private bool m_IsGxobjectDefault;
		private System.Boolean m_InGrid;
		private bool m_IsInGridDefault;
		private System.Boolean m_MultiRowSelection;
		private bool m_IsMultiRowSelectionDefault;
		private Artech.Genexus.Common.Objects.Image m_Image;
		private KBObjectReference m_ImageReference;
		private string m_ImageName;
		private bool m_IsImageDefault;
		private Artech.Genexus.Common.Objects.Image m_DisabledImage;
		private KBObjectReference m_DisabledImageReference;
		private string m_DisabledImageName;
		private bool m_IsDisabledImageDefault;
		private System.String m_Tooltip;
		private bool m_IsTooltipDefault;
		private System.String m_Legend;
		private bool m_IsLegendDefault;
		private System.String m_Condition;
		private bool m_IsConditionDefault;
		private System.String m_ButtonClass;
		private bool m_IsButtonClassDefault;
		private System.String m_EventCode;
		private bool m_IsEventCodeDefault;
		private System.String m_CodeEnable;
		private bool m_IsCodeEnableDefault;
		private System.String m_Position;
		private bool m_IsPositionDefault;
		private System.Boolean m_SuggestSelection;
		private bool m_IsSuggestSelectionDefault;
		private System.Boolean m_SuggestTransaction;
		private bool m_IsSuggestTransactionDefault;
		private System.Boolean m_SuggestPrompt;
		private bool m_IsSuggestPromptDefault;
		private System.Boolean m_SuggestViewTab;
		private bool m_IsSuggestViewTabDefault;
		private System.Int32 m_Width;
		private bool m_IsWidthDefault;
		private System.String m_GridWidth;
		private bool m_IsGridWidthDefault;
		private System.String m_GridHeight;
		private bool m_IsGridHeightDefault;
		private SettingsSuggestParametersElement m_Parameters;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsSuggestActionElement"/> class.
		/// </summary>
		public SettingsSuggestActionElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsSuggestActionElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public SettingsSuggestActionElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsSuggestActionElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Caption = "";
			m_IsCaptionDefault = true;
			m_Gxobject = null;
			m_GxobjectReference = null;
			m_GxobjectName = null;
			m_IsGxobjectDefault = true;
			m_InGrid = false;
			m_IsInGridDefault = true;
			m_MultiRowSelection = false;
			m_IsMultiRowSelectionDefault = true;
			m_Image = null;
			m_ImageReference = null;
			m_ImageName = null;
			m_IsImageDefault = true;
			m_DisabledImage = null;
			m_DisabledImageReference = null;
			m_DisabledImageName = null;
			m_IsDisabledImageDefault = true;
			m_Tooltip = "";
			m_IsTooltipDefault = true;
			m_Legend = "";
			m_IsLegendDefault = true;
			m_Condition = "";
			m_IsConditionDefault = true;
			m_ButtonClass = null;
			m_IsButtonClassDefault = true;
			m_EventCode = "";
			m_IsEventCodeDefault = true;
			m_CodeEnable = "";
			m_IsCodeEnableDefault = true;
			m_Position = "Footer";
			m_IsPositionDefault = true;
			m_SuggestSelection = true;
			m_IsSuggestSelectionDefault = true;
			m_SuggestTransaction = false;
			m_IsSuggestTransactionDefault = true;
			m_SuggestPrompt = false;
			m_IsSuggestPromptDefault = true;
			m_SuggestViewTab = false;
			m_IsSuggestViewTabDefault = true;
			m_Width = 0;
			m_IsWidthDefault = true;
			m_GridWidth = "";
			m_IsGridWidthDefault = true;
			m_GridHeight = "";
			m_IsGridHeightDefault = true;
			m_Parameters = new SettingsSuggestParametersElement();
			m_Parameters.Parent = this;
			m_Parameters.ElementName = "parameters";
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsSuggestActionElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Action Name
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Caption (for the button, or for "in grid" actions that do not have an associated image ).
		*/
		/// </summary>
		public System.String Caption
		{
			get { return m_Caption; }
			set 
			{
				m_Caption = value;
				m_IsCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		GeneXus object invoked for performing the Action.
		*/
		/// </summary>
		public Artech.Architecture.Common.Objects.KBObject Gxobject
		{
			get
			{
				if (m_Gxobject == null && m_GxobjectReference != null)
					m_Gxobject = (Artech.Architecture.Common.Objects.KBObject)m_GxobjectReference.GetKBObject(Settings.Model);

				return m_Gxobject;
			}

			set 
			{
				m_Gxobject = value;
				m_GxobjectReference = (value != null ? new KBObjectReference(value) : null);
				m_GxobjectName = (value != null ? value.Name : null);
				m_IsGxobjectDefault = false;
			}
		}

		/// <summary>
		/// Gxobject name.
		/// </summary>
		public string GxobjectName
		{
			get
			{
				if (m_GxobjectName == null && m_GxobjectReference != null)
					m_GxobjectName = m_GxobjectReference.GetName(Settings.Model);

				return m_GxobjectName;
			}
		}

		/// <summary>
		/*
		True = Action in the grid. False = Action outside the grid. Always false if "MultiRowSelection" is set.
		*/
		/// </summary>
		public System.Boolean InGrid
		{
			get { return m_InGrid; }
			set 
			{
				m_InGrid = value;
				m_IsInGridDefault = false;
			}
		}

		/// <summary>
		/*
		The action applies to multiple rows (a checkbox column will be added to grids).
		*/
		/// </summary>
		public System.Boolean MultiRowSelection
		{
			get { return m_MultiRowSelection; }
			set 
			{
				m_MultiRowSelection = value;
				m_IsMultiRowSelectionDefault = false;
			}
		}

		/// <summary>
		/*
		Image to appear in the grid.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image Image
		{
			get
			{
				if (m_Image == null && m_ImageReference != null)
					m_Image = (Artech.Genexus.Common.Objects.Image)m_ImageReference.GetKBObject(Settings.Model);

				return m_Image;
			}

			set 
			{
				m_Image = value;
				m_ImageReference = (value != null ? new KBObjectReference(value) : null);
				m_ImageName = (value != null ? value.Name : null);
				m_IsImageDefault = false;
			}
		}

		/// <summary>
		/// Image name.
		/// </summary>
		public string ImageName
		{
			get
			{
				if (m_ImageName == null && m_ImageReference != null)
					m_ImageName = m_ImageReference.GetName(Settings.Model);

				return m_ImageName;
			}
		}

		/// <summary>
		/*
		Image to appear in the grid when the action is not enabled (to make the button invisible, use a transparent image).
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image DisabledImage
		{
			get
			{
				if (m_DisabledImage == null && m_DisabledImageReference != null)
					m_DisabledImage = (Artech.Genexus.Common.Objects.Image)m_DisabledImageReference.GetKBObject(Settings.Model);

				return m_DisabledImage;
			}

			set 
			{
				m_DisabledImage = value;
				m_DisabledImageReference = (value != null ? new KBObjectReference(value) : null);
				m_DisabledImageName = (value != null ? value.Name : null);
				m_IsDisabledImageDefault = false;
			}
		}

		/// <summary>
		/// DisabledImage name.
		/// </summary>
		public string DisabledImageName
		{
			get
			{
				if (m_DisabledImageName == null && m_DisabledImageReference != null)
					m_DisabledImageName = m_DisabledImageReference.GetName(Settings.Model);

				return m_DisabledImageName;
			}
		}

		/// <summary>
		/*
		Tooltip to appear in the grid.
		*/
		/// </summary>
		public System.String Tooltip
		{
			get { return m_Tooltip; }
			set 
			{
				m_Tooltip = value;
				m_IsTooltipDefault = false;
			}
		}

		/// <summary>
		/*
		Legend
		*/
		/// </summary>
		public System.String Legend
		{
			get { return m_Legend; }
			set 
			{
				m_Legend = value;
				m_IsLegendDefault = false;
			}
		}

		/// <summary>
		/*
		Condition to determine whether the action will be enabled. If the action is defined as "InGrid", the check will be performed for each record. If empty, the action will be available.
		*/
		/// </summary>
		public System.String Condition
		{
			get { return m_Condition; }
			set 
			{
				m_Condition = value;
				m_IsConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Theme class for the button (if no class is specified, the one set in the configuration file will be used).
		*/
		/// </summary>
		public System.String ButtonClass
		{
			get { return m_ButtonClass; }
			set 
			{
				m_ButtonClass = value;
				m_IsButtonClassDefault = false;
			}
		}

		/// <summary>
		/*
		Código para o Evento da Action, somente para Action não Standard
		*/
		/// </summary>
		public System.String EventCode
		{
			get { return m_EventCode; }
			set 
			{
				m_EventCode = value;
				m_IsEventCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Evento adicionado a ação de habilitar a Action, Coringda {0} define o nome do controle
		*/
		/// </summary>
		public System.String CodeEnable
		{
			get { return m_CodeEnable; }
			set 
			{
				m_CodeEnable = value;
				m_IsCodeEnableDefault = false;
			}
		}

		/// <summary>
		/*
		Define a posição da action fora do Grid
		*/
		/// </summary>
		public System.String Position
		{
			get { return m_Position; }
			set 
			{
				m_Position = value;
				m_IsPositionDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica esta Action a Seleção
		*/
		/// </summary>
		public System.Boolean SuggestSelection
		{
			get { return m_SuggestSelection; }
			set 
			{
				m_SuggestSelection = value;
				m_IsSuggestSelectionDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica esta Action ao Cadastro
		*/
		/// </summary>
		public System.Boolean SuggestTransaction
		{
			get { return m_SuggestTransaction; }
			set 
			{
				m_SuggestTransaction = value;
				m_IsSuggestTransactionDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica esta Action a Prompt
		*/
		/// </summary>
		public System.Boolean SuggestPrompt
		{
			get { return m_SuggestPrompt; }
			set 
			{
				m_SuggestPrompt = value;
				m_IsSuggestPromptDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica esta Action a Tab da View
		*/
		/// </summary>
		public System.Boolean SuggestViewTab
		{
			get { return m_SuggestViewTab; }
			set 
			{
				m_SuggestViewTab = value;
				m_IsSuggestViewTabDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width da Coluna no Grid
		*/
		/// </summary>
		public System.Int32 Width
		{
			get { return m_Width; }
			set 
			{
				m_Width = value;
				m_IsWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width(tamanho horizontal)
		*/
		/// </summary>
		public System.String GridWidth
		{
			get { return m_GridWidth; }
			set 
			{
				m_GridWidth = value;
				m_IsGridWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Height(tamanho vertical)
		*/
		/// </summary>
		public System.String GridHeight
		{
			get { return m_GridHeight; }
			set 
			{
				m_GridHeight = value;
				m_IsGridHeightDefault = false;
			}
		}

		public SettingsSuggestParametersElement Parameters
		{
			get { return m_Parameters; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="SettingsSuggestParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// </summary>
		public SettingsSuggestParameterElement AddSuggestParameter()
		{
			SettingsSuggestParameterElement suggestParameterElement = new SettingsSuggestParameterElement();
			m_Parameters.Add(suggestParameterElement);
			return suggestParameterElement;
		}

		/// <summary>
		/// Creates a new <see cref="SettingsSuggestParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// The SettingsSuggestParameterElement is initialized with the specified value.
		/// </summary>
		public SettingsSuggestParameterElement AddSuggestParameter(System.String name)
		{
			SettingsSuggestParameterElement suggestParameterElement = new SettingsSuggestParameterElement(name);
			m_Parameters.Add(suggestParameterElement);
			return suggestParameterElement;
		}

		/// <summary>
		/// Finds the <see cref="SettingsSuggestParameterElement"/> in the <see cref="Parameters"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no suggestParameterElement is found, null is returned.
		/// </summary>
		public SettingsSuggestParameterElement FindSuggestParameter(System.String name)
		{
			return Parameters.Find(delegate (SettingsSuggestParameterElement suggestParameterElement) { return suggestParameterElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsSuggestActionElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "SuggestAction")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "SuggestAction"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Caption = element.Attributes.GetPropertyValue<System.String>("caption");
			m_IsCaptionDefault = element.Attributes.IsPropertyDefault("caption");
			m_GxobjectReference = element.Attributes.GetPropertyValue<KBObjectReference>("gxobjectReference");
			m_IsGxobjectDefault = element.Attributes.IsPropertyDefault("gxobject");
			m_InGrid = element.Attributes.GetPropertyValue<System.Boolean>("inGrid");
			m_IsInGridDefault = element.Attributes.IsPropertyDefault("inGrid");
			m_MultiRowSelection = element.Attributes.GetPropertyValue<System.Boolean>("multiRowSelection");
			m_IsMultiRowSelectionDefault = element.Attributes.IsPropertyDefault("multiRowSelection");
			m_ImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("imageReference");
			m_IsImageDefault = element.Attributes.IsPropertyDefault("image");
			m_DisabledImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("disabledImageReference");
			m_IsDisabledImageDefault = element.Attributes.IsPropertyDefault("disabledImage");
			m_Tooltip = element.Attributes.GetPropertyValue<System.String>("tooltip");
			m_IsTooltipDefault = element.Attributes.IsPropertyDefault("tooltip");
			m_Legend = element.Attributes.GetPropertyValue<System.String>("Legend");
			m_IsLegendDefault = element.Attributes.IsPropertyDefault("Legend");
			m_Condition = element.Attributes.GetPropertyValue<System.String>("condition");
			m_IsConditionDefault = element.Attributes.IsPropertyDefault("condition");
			m_ButtonClass = element.Attributes.GetPropertyValue<System.String>("buttonClass");
			m_IsButtonClassDefault = element.Attributes.IsPropertyDefault("buttonClass");
			m_EventCode = element.Attributes.GetPropertyValue<System.String>("EventCode");
			m_IsEventCodeDefault = element.Attributes.IsPropertyDefault("EventCode");
			m_CodeEnable = element.Attributes.GetPropertyValue<System.String>("CodeEnable");
			m_IsCodeEnableDefault = element.Attributes.IsPropertyDefault("CodeEnable");
			m_Position = element.Attributes.GetPropertyValue<System.String>("Position");
			m_IsPositionDefault = element.Attributes.IsPropertyDefault("Position");
			m_SuggestSelection = element.Attributes.GetPropertyValue<System.Boolean>("suggestSelection");
			m_IsSuggestSelectionDefault = element.Attributes.IsPropertyDefault("suggestSelection");
			m_SuggestTransaction = element.Attributes.GetPropertyValue<System.Boolean>("suggestTransaction");
			m_IsSuggestTransactionDefault = element.Attributes.IsPropertyDefault("suggestTransaction");
			m_SuggestPrompt = element.Attributes.GetPropertyValue<System.Boolean>("suggestPrompt");
			m_IsSuggestPromptDefault = element.Attributes.IsPropertyDefault("suggestPrompt");
			m_SuggestViewTab = element.Attributes.GetPropertyValue<System.Boolean>("suggestViewTab");
			m_IsSuggestViewTabDefault = element.Attributes.IsPropertyDefault("suggestViewTab");
			m_Width = element.Attributes.GetPropertyValue<System.Int32>("Width");
			m_IsWidthDefault = element.Attributes.IsPropertyDefault("Width");
			m_GridWidth = element.Attributes.GetPropertyValue<System.String>("GridWidth");
			m_IsGridWidthDefault = element.Attributes.IsPropertyDefault("GridWidth");
			m_GridHeight = element.Attributes.GetPropertyValue<System.String>("GridHeight");
			m_IsGridHeightDefault = element.Attributes.IsPropertyDefault("GridHeight");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "parameters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							SettingsSuggestParameterElement suggestParameterElement = new SettingsSuggestParameterElement();
							suggestParameterElement.LoadFrom(_childElementItem);
							Parameters.Add(suggestParameterElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="SettingsSuggestActionElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "SuggestAction")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "SuggestAction"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "caption", m_Caption, m_IsCaptionDefault);
			SaveAttribute(element, "gxobjectReference", m_GxobjectReference, m_IsGxobjectDefault);
			SaveAttribute(element, "inGrid", m_InGrid, m_IsInGridDefault);
			SaveAttribute(element, "multiRowSelection", m_MultiRowSelection, m_IsMultiRowSelectionDefault);
			SaveAttribute(element, "imageReference", m_ImageReference, m_IsImageDefault);
			SaveAttribute(element, "disabledImageReference", m_DisabledImageReference, m_IsDisabledImageDefault);
			SaveAttribute(element, "tooltip", m_Tooltip, m_IsTooltipDefault);
			SaveAttribute(element, "Legend", m_Legend, m_IsLegendDefault);
			SaveAttribute(element, "condition", m_Condition, m_IsConditionDefault);
			SaveAttribute(element, "buttonClass", m_ButtonClass, m_IsButtonClassDefault);
			SaveAttribute(element, "EventCode", m_EventCode, m_IsEventCodeDefault);
			SaveAttribute(element, "CodeEnable", m_CodeEnable, m_IsCodeEnableDefault);
			SaveAttribute(element, "Position", m_Position, m_IsPositionDefault);
			SaveAttribute(element, "suggestSelection", m_SuggestSelection, m_IsSuggestSelectionDefault);
			SaveAttribute(element, "suggestTransaction", m_SuggestTransaction, m_IsSuggestTransactionDefault);
			SaveAttribute(element, "suggestPrompt", m_SuggestPrompt, m_IsSuggestPromptDefault);
			SaveAttribute(element, "suggestViewTab", m_SuggestViewTab, m_IsSuggestViewTabDefault);
			SaveAttribute(element, "Width", m_Width, m_IsWidthDefault);
			SaveAttribute(element, "GridWidth", m_GridWidth, m_IsGridWidthDefault);
			SaveAttribute(element, "GridHeight", m_GridHeight, m_IsGridHeightDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_Caption == element.Attributes.GetPropertyValue<System.String>("caption"));
			Debug.Assert(m_GxobjectReference == element.Attributes.GetPropertyValue<KBObjectReference>("gxobjectReference"));
			Debug.Assert(m_InGrid == element.Attributes.GetPropertyValue<System.Boolean>("inGrid"));
			Debug.Assert(m_MultiRowSelection == element.Attributes.GetPropertyValue<System.Boolean>("multiRowSelection"));
			Debug.Assert(m_ImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("imageReference"));
			Debug.Assert(m_DisabledImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("disabledImageReference"));
			Debug.Assert(m_Tooltip == element.Attributes.GetPropertyValue<System.String>("tooltip"));
			Debug.Assert(m_Legend == element.Attributes.GetPropertyValue<System.String>("Legend"));
			Debug.Assert(m_Condition == element.Attributes.GetPropertyValue<System.String>("condition"));
			Debug.Assert(m_EventCode == element.Attributes.GetPropertyValue<System.String>("EventCode"));
			Debug.Assert(m_CodeEnable == element.Attributes.GetPropertyValue<System.String>("CodeEnable"));
			Debug.Assert(m_Position == element.Attributes.GetPropertyValue<System.String>("Position"));
			Debug.Assert(m_SuggestSelection == element.Attributes.GetPropertyValue<System.Boolean>("suggestSelection"));
			Debug.Assert(m_SuggestTransaction == element.Attributes.GetPropertyValue<System.Boolean>("suggestTransaction"));
			Debug.Assert(m_SuggestPrompt == element.Attributes.GetPropertyValue<System.Boolean>("suggestPrompt"));
			Debug.Assert(m_SuggestViewTab == element.Attributes.GetPropertyValue<System.Boolean>("suggestViewTab"));
			Debug.Assert(m_Width == element.Attributes.GetPropertyValue<System.Int32>("Width"));
			Debug.Assert(m_GridWidth == element.Attributes.GetPropertyValue<System.String>("GridWidth"));
			Debug.Assert(m_GridHeight == element.Attributes.GetPropertyValue<System.String>("GridHeight"));

			// Save element children.
			if (m_Parameters != null)
			{
				if (m_Parameters.Count > 0)
					element.Children.AddNewElement("parameters");

				foreach (SettingsSuggestParameterElement _item in Parameters)
				{
					PatternInstanceElement child = element.Children["parameters"].Children.AddNewElement("parameter");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsSuggestActionElement"/>.
		/// </summary>
		public SettingsSuggestActionElement Clone()
		{
			SettingsSuggestActionElement clone = new SettingsSuggestActionElement();

			clone.Name = this.Name;
			clone.Caption = this.Caption;
			clone.Gxobject = this.Gxobject;
			clone.InGrid = this.InGrid;
			clone.MultiRowSelection = this.MultiRowSelection;
			clone.Image = this.Image;
			clone.DisabledImage = this.DisabledImage;
			clone.Tooltip = this.Tooltip;
			clone.Legend = this.Legend;
			clone.Condition = this.Condition;
			clone.ButtonClass = this.ButtonClass;
			clone.EventCode = this.EventCode;
			clone.CodeEnable = this.CodeEnable;
			clone.Position = this.Position;
			clone.SuggestSelection = this.SuggestSelection;
			clone.SuggestTransaction = this.SuggestTransaction;
			clone.SuggestPrompt = this.SuggestPrompt;
			clone.SuggestViewTab = this.SuggestViewTab;
			clone.Width = this.Width;
			clone.GridWidth = this.GridWidth;
			clone.GridHeight = this.GridHeight;
			foreach (SettingsSuggestParameterElement suggestParameterElement in this.Parameters)
				clone.Parameters.Add(suggestParameterElement.Clone());

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternSettings.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "parameters" :
				{
					if (path.Count == 0)
						return Parameters;

					string itemName; int itemIndex;
					HPatternSettings.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "parameter")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Parameters != null && itemIndex >= 0 && itemIndex < Parameters.Count)
						return Parameters[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Position"/> property.
		/// </summary>
		public static class PositionValue
		{
			public const string Footer = "Footer";
			public const string Grid = "Grid";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Action ({0})", Name);
		}

		#endregion
	}

	#endregion

	#region Element: SuggestParameter

	public partial class SettingsSuggestParameterElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private Artech.Genexus.Common.Objects.Domain m_Domain;
		private KBObjectReference m_DomainReference;
		private string m_DomainName;
		private bool m_IsDomainDefault;
		private System.Boolean m_Null;
		private bool m_IsNullDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsSuggestParameterElement"/> class.
		/// </summary>
		public SettingsSuggestParameterElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsSuggestParameterElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public SettingsSuggestParameterElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsSuggestParameterElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Domain = null;
			m_DomainReference = null;
			m_DomainName = null;
			m_IsDomainDefault = true;
			m_Null = true;
			m_IsNullDefault = true;
		}

		#endregion

		#region Properties

		private SettingsSuggestActionElement m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsSuggestParameterElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public SettingsSuggestActionElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Parameter Name.
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Only needed for variables (defines their domain).
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Domain Domain
		{
			get
			{
				if (m_Domain == null && m_DomainReference != null)
					m_Domain = (Artech.Genexus.Common.Objects.Domain)m_DomainReference.GetKBObject(Settings.Model);

				return m_Domain;
			}

			set 
			{
				m_Domain = value;
				m_DomainReference = (value != null ? new KBObjectReference(value) : null);
				m_DomainName = (value != null ? value.Name : null);
				m_IsDomainDefault = false;
			}
		}

		/// <summary>
		/// Domain name.
		/// </summary>
		public string DomainName
		{
			get
			{
				if (m_DomainName == null && m_DomainReference != null)
					m_DomainName = m_DomainReference.GetName(Settings.Model);

				return m_DomainName;
			}
		}

		/// <summary>
		/*
		If set to false, the parameter value cannot change in Insert. (For example, if inserting a City in a given Country, CountryId doesn't change when calling City transaction).
		*/
		/// </summary>
		public System.Boolean Null
		{
			get { return m_Null; }
			set 
			{
				m_Null = value;
				m_IsNullDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsSuggestParameterElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "SuggestParameter")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "SuggestParameter"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_DomainReference = element.Attributes.GetPropertyValue<KBObjectReference>("domainReference");
			m_IsDomainDefault = element.Attributes.IsPropertyDefault("domain");
			m_Null = element.Attributes.GetPropertyValue<System.Boolean>("null");
			m_IsNullDefault = element.Attributes.IsPropertyDefault("null");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsSuggestParameterElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "SuggestParameter")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "SuggestParameter"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "domainReference", m_DomainReference, m_IsDomainDefault);
			SaveAttribute(element, "null", m_Null, m_IsNullDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_DomainReference == element.Attributes.GetPropertyValue<KBObjectReference>("domainReference"));
			Debug.Assert(m_Null == element.Attributes.GetPropertyValue<System.Boolean>("null"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsSuggestParameterElement"/>.
		/// </summary>
		public SettingsSuggestParameterElement Clone()
		{
			SettingsSuggestParameterElement clone = new SettingsSuggestParameterElement();

			clone.Name = this.Name;
			clone.Domain = this.Domain;
			clone.Null = this.Null;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: SuggestParameters

	public partial class SettingsSuggestParametersElement : Artech.Common.Collections.BaseCollection<SettingsSuggestParameterElement>
	{
		protected string m_ElementName;

		#region Construction

		internal SettingsSuggestParametersElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsSuggestParameterElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private SettingsSuggestActionElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public SettingsSuggestActionElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<SettingsSuggestParameterElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of SettingsSuggestParametersElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="SettingsSuggestParameterElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no SuggestParameter is found, <b>null</b> is returned.
		/// </summary>
		public SettingsSuggestParameterElement FindSuggestParameter(System.String name)
		{
			return this.Find(delegate (SettingsSuggestParameterElement parameterItem) { return parameterItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Parameters";
		}

		#endregion
	}

	#endregion

	#region Element: Template

	public partial class SettingsTemplateElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_UpdateTransaction;
		private bool m_IsUpdateTransactionDefault;
		private System.String m_CompatibilidadeVersao;
		private bool m_IsCompatibilidadeVersaoDefault;
		private System.Boolean m_SelectionIsMain;
		private bool m_IsSelectionIsMainDefault;
		private System.Boolean m_TabsForParallelTransactions;
		private bool m_IsTabsForParallelTransactionsDefault;
		private System.Boolean m_UseTransactionContext;
		private bool m_IsUseTransactionContextDefault;
		private System.String m_AfterInsert;
		private bool m_IsAfterInsertDefault;
		private System.String m_AfterUpdate;
		private bool m_IsAfterUpdateDefault;
		private System.String m_AfterDelete;
		private bool m_IsAfterDeleteDefault;
		private System.String m_TitleTableClass;
		private bool m_IsTitleTableClassDefault;
		private System.String m_TitleTextClass;
		private bool m_IsTitleTextClassDefault;
		private Artech.Genexus.Common.Objects.Image m_TitleImage;
		private KBObjectReference m_TitleImageReference;
		private string m_TitleImageName;
		private bool m_IsTitleImageDefault;
		private System.Boolean m_FilterCollapse;
		private bool m_IsFilterCollapseDefault;
		private System.Boolean m_FilterCollapseDefault;
		private bool m_IsFilterCollapseDefaultDefault;
		private System.String m_TrnTitleTableClass;
		private bool m_IsTrnTitleTableClassDefault;
		private System.String m_TrnTitleTextClass;
		private bool m_IsTrnTitleTextClassDefault;
		private Artech.Genexus.Common.Objects.Image m_TrnTitleImage;
		private KBObjectReference m_TrnTitleImageReference;
		private string m_TrnTitleImageName;
		private bool m_IsTrnTitleImageDefault;
		private System.Boolean m_ButtonHelp;
		private bool m_IsButtonHelpDefault;
		private System.String m_ButtonHelpClass;
		private bool m_IsButtonHelpClassDefault;
		private System.String m_ButtonHelpCaption;
		private bool m_IsButtonHelpCaptionDefault;
		private System.Boolean m_ButtonHelpApplySelection;
		private bool m_IsButtonHelpApplySelectionDefault;
		private System.String m_EventStart;
		private bool m_IsEventStartDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_SelectionTemplate;
		private KBObjectReference m_SelectionTemplateReference;
		private string m_SelectionTemplateName;
		private bool m_IsSelectionTemplateDefault;
		private System.String m_SelectionTemplateDebug;
		private bool m_IsSelectionTemplateDebugDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_ViewTemplate;
		private KBObjectReference m_ViewTemplateReference;
		private string m_ViewTemplateName;
		private bool m_IsViewTemplateDefault;
		private System.String m_ViewTemplateDebug;
		private bool m_IsViewTemplateDebugDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_PromptTemplate;
		private KBObjectReference m_PromptTemplateReference;
		private string m_PromptTemplateName;
		private bool m_IsPromptTemplateDefault;
		private System.String m_PromptTemplateDebug;
		private bool m_IsPromptTemplateDebugDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_TransactionTemplate;
		private KBObjectReference m_TransactionTemplateReference;
		private string m_TransactionTemplateName;
		private bool m_IsTransactionTemplateDefault;
		private System.String m_TransactionTemplateDebug;
		private bool m_IsTransactionTemplateDebugDefault;
		private System.Boolean m_DataEntryWebPanelBC;
		private bool m_IsDataEntryWebPanelBCDefault;
		private System.Boolean m_LoadSDTWithDataProvider;
		private bool m_IsLoadSDTWithDataProviderDefault;
		private System.Boolean m_DisabledTabsIfEditing;
		private bool m_IsDisabledTabsIfEditingDefault;
		private System.Boolean m_WebPanelBCDefault;
		private bool m_IsWebPanelBCDefaultDefault;
		private System.Boolean m_ListNotNullTabGrid;
		private bool m_IsListNotNullTabGridDefault;
		private System.String m_ListNotNullMessage;
		private bool m_IsListNotNullMessageDefault;
		private System.Boolean m_InferedAttributeInSameBeforeColumn;
		private bool m_IsInferedAttributeInSameBeforeColumnDefault;
		private System.Boolean m_SuggestEventIsValidForForeignKey;
		private bool m_IsSuggestEventIsValidForForeignKeyDefault;
		private System.String m_SuggestMessageNotFoundForeignKey;
		private bool m_IsSuggestMessageNotFoundForeignKeyDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_PopupMessage;
		private KBObjectReference m_PopupMessageReference;
		private string m_PopupMessageName;
		private bool m_IsPopupMessageDefault;
		private System.Int32 m_PopupMessageWidth;
		private bool m_IsPopupMessageWidthDefault;
		private System.Int32 m_PopupMessageHeight;
		private bool m_IsPopupMessageHeightDefault;
		private System.String m_ValidationWarningMessage;
		private bool m_IsValidationWarningMessageDefault;
		private System.String m_ValidationErrorMessage;
		private bool m_IsValidationErrorMessageDefault;
		private System.Boolean m_SelectionSetFocus;
		private bool m_IsSelectionSetFocusDefault;
		private System.Boolean m_TransactionSetFocus;
		private bool m_IsTransactionSetFocusDefault;
		private System.Boolean m_RequiredNotNullAttribute;
		private bool m_IsRequiredNotNullAttributeDefault;
		private System.String m_RequiredNotNullMessage;
		private bool m_IsRequiredNotNullMessageDefault;
		private System.Boolean m_RequiredAfterValidate;
		private bool m_IsRequiredAfterValidateDefault;
		private System.String m_RuleDate;
		private bool m_IsRuleDateDefault;
		private System.String m_ValueRuleDate;
		private bool m_IsValueRuleDateDefault;
		private System.String m_RuleDateTime;
		private bool m_IsRuleDateTimeDefault;
		private System.String m_ValueRuleDateTime;
		private bool m_IsValueRuleDateTimeDefault;
		private System.String m_PictureCharacterDefault;
		private bool m_IsPictureCharacterDefaultDefault;
		private System.String m_TabFunction;
		private bool m_IsTabFunctionDefault;
		private Artech.Genexus.Common.Objects.Image m_TabDisabled;
		private KBObjectReference m_TabDisabledReference;
		private string m_TabDisabledName;
		private bool m_IsTabDisabledDefault;
		private Artech.Architecture.Common.Objects.KBObject m_ObjectsNames;
		private KBObjectReference m_ObjectsNamesReference;
		private string m_ObjectsNamesName;
		private bool m_IsObjectsNamesDefault;
		private System.String m_CollumnTextAlign;
		private bool m_IsCollumnTextAlignDefault;
		private System.String m_CollumnAttributeAlign;
		private bool m_IsCollumnAttributeAlignDefault;
		private Artech.Genexus.Common.Objects.Image m_PromptImage;
		private KBObjectReference m_PromptImageReference;
		private string m_PromptImageName;
		private bool m_IsPromptImageDefault;
		private System.String m_PromptClass;
		private bool m_IsPromptClassDefault;
		private System.Boolean m_PromptSuggestForeignKey;
		private bool m_IsPromptSuggestForeignKeyDefault;
		private System.String m_PromptSuggestNameContains;
		private bool m_IsPromptSuggestNameContainsDefault;
		private System.Boolean m_PromptSuggestParmDescription;
		private bool m_IsPromptSuggestParmDescriptionDefault;
		private System.Boolean m_PromptSuggestGridPrimaryKey;
		private bool m_IsPromptSuggestGridPrimaryKeyDefault;
		private System.Boolean m_SuggestView;
		private bool m_IsSuggestViewDefault;
		private System.Boolean m_GenerateViewOnlyBC;
		private bool m_IsGenerateViewOnlyBCDefault;
		private System.String m_BCSucessCode;
		private bool m_IsBCSucessCodeDefault;
		private System.String m_BCErrorCode;
		private bool m_IsBCErrorCodeDefault;
		private System.String m_BCPrimaryKeyDelimiter;
		private bool m_IsBCPrimaryKeyDelimiterDefault;
		private System.Boolean m_HideElementIfEdit;
		private bool m_IsHideElementIfEditDefault;
		private System.String m_HideElementName;
		private bool m_IsHideElementNameDefault;
		private System.Boolean m_ApplyReturnOnClickAll;
		private bool m_IsApplyReturnOnClickAllDefault;
		private System.String m_PromptSearchEvent;
		private bool m_IsPromptSearchEventDefault;
		private System.Boolean m_GenerateListPrograms;
		private bool m_IsGenerateListProgramsDefault;
		private System.Boolean m_GenerateCallBackLink;
		private bool m_IsGenerateCallBackLinkDefault;
		private Artech.Common.Collections.BaseCollection<SettingsSuggestInstanceElement> m_Suggests;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsTemplateElement"/> class.
		/// </summary>
		public SettingsTemplateElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsTemplateElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_UpdateTransaction = "Only rules and events";
			m_IsUpdateTransactionDefault = true;
			m_CompatibilidadeVersao = "1.2.0.15";
			m_IsCompatibilidadeVersaoDefault = true;
			m_SelectionIsMain = false;
			m_IsSelectionIsMainDefault = true;
			m_TabsForParallelTransactions = false;
			m_IsTabsForParallelTransactionsDefault = true;
			m_UseTransactionContext = true;
			m_IsUseTransactionContextDefault = true;
			m_AfterInsert = "Return to Caller";
			m_IsAfterInsertDefault = true;
			m_AfterUpdate = "Return to Caller";
			m_IsAfterUpdateDefault = true;
			m_AfterDelete = "Return to Caller";
			m_IsAfterDeleteDefault = true;
			m_TitleTableClass = "TabelaTitulo";
			m_IsTitleTableClassDefault = true;
			m_TitleTextClass = "tbTituloTela";
			m_IsTitleTextClassDefault = true;
			m_TitleImage = null;
			m_TitleImageReference = null;
			m_TitleImageName = null;
			m_IsTitleImageDefault = true;
			m_FilterCollapse = false;
			m_IsFilterCollapseDefault = true;
			m_FilterCollapseDefault = false;
			m_IsFilterCollapseDefaultDefault = true;
			m_TrnTitleTableClass = "TabelaTitulo";
			m_IsTrnTitleTableClassDefault = true;
			m_TrnTitleTextClass = "tbTituloTela";
			m_IsTrnTitleTextClassDefault = true;
			m_TrnTitleImage = null;
			m_TrnTitleImageReference = null;
			m_TrnTitleImageName = null;
			m_IsTrnTitleImageDefault = true;
			m_ButtonHelp = false;
			m_IsButtonHelpDefault = true;
			m_ButtonHelpClass = "BtnHelp";
			m_IsButtonHelpClassDefault = true;
			m_ButtonHelpCaption = "GX_BtnHelp";
			m_IsButtonHelpCaptionDefault = true;
			m_ButtonHelpApplySelection = true;
			m_IsButtonHelpApplySelectionDefault = true;
			m_EventStart = "";
			m_IsEventStartDefault = true;
			m_SelectionTemplate = null;
			m_SelectionTemplateReference = null;
			m_SelectionTemplateName = null;
			m_IsSelectionTemplateDefault = true;
			m_SelectionTemplateDebug = "";
			m_IsSelectionTemplateDebugDefault = true;
			m_ViewTemplate = null;
			m_ViewTemplateReference = null;
			m_ViewTemplateName = null;
			m_IsViewTemplateDefault = true;
			m_ViewTemplateDebug = "";
			m_IsViewTemplateDebugDefault = true;
			m_PromptTemplate = null;
			m_PromptTemplateReference = null;
			m_PromptTemplateName = null;
			m_IsPromptTemplateDefault = true;
			m_PromptTemplateDebug = "";
			m_IsPromptTemplateDebugDefault = true;
			m_TransactionTemplate = null;
			m_TransactionTemplateReference = null;
			m_TransactionTemplateName = null;
			m_IsTransactionTemplateDefault = true;
			m_TransactionTemplateDebug = "";
			m_IsTransactionTemplateDebugDefault = true;
			m_DataEntryWebPanelBC = false;
			m_IsDataEntryWebPanelBCDefault = true;
			m_LoadSDTWithDataProvider = true;
			m_IsLoadSDTWithDataProviderDefault = true;
			m_DisabledTabsIfEditing = false;
			m_IsDisabledTabsIfEditingDefault = true;
			m_WebPanelBCDefault = true;
			m_IsWebPanelBCDefaultDefault = true;
			m_ListNotNullTabGrid = false;
			m_IsListNotNullTabGridDefault = true;
			m_ListNotNullMessage = "{0} requerido";
			m_IsListNotNullMessageDefault = true;
			m_InferedAttributeInSameBeforeColumn = false;
			m_IsInferedAttributeInSameBeforeColumnDefault = true;
			m_SuggestEventIsValidForForeignKey = false;
			m_IsSuggestEventIsValidForForeignKeyDefault = true;
			m_SuggestMessageNotFoundForeignKey = "";
			m_IsSuggestMessageNotFoundForeignKeyDefault = true;
			m_PopupMessage = null;
			m_PopupMessageReference = null;
			m_PopupMessageName = null;
			m_IsPopupMessageDefault = true;
			m_PopupMessageWidth = 400;
			m_IsPopupMessageWidthDefault = true;
			m_PopupMessageHeight = 400;
			m_IsPopupMessageHeightDefault = true;
			m_ValidationWarningMessage = "Atenção: ";
			m_IsValidationWarningMessageDefault = true;
			m_ValidationErrorMessage = "Erro: ";
			m_IsValidationErrorMessageDefault = true;
			m_SelectionSetFocus = false;
			m_IsSelectionSetFocusDefault = true;
			m_TransactionSetFocus = false;
			m_IsTransactionSetFocusDefault = true;
			m_RequiredNotNullAttribute = false;
			m_IsRequiredNotNullAttributeDefault = true;
			m_RequiredNotNullMessage = "{0} requerido";
			m_IsRequiredNotNullMessageDefault = true;
			m_RequiredAfterValidate = false;
			m_IsRequiredAfterValidateDefault = true;
			m_RuleDate = "None";
			m_IsRuleDateDefault = true;
			m_ValueRuleDate = "";
			m_IsValueRuleDateDefault = true;
			m_RuleDateTime = "None";
			m_IsRuleDateTimeDefault = true;
			m_ValueRuleDateTime = "";
			m_IsValueRuleDateTimeDefault = true;
			m_PictureCharacterDefault = "";
			m_IsPictureCharacterDefaultDefault = true;
			m_TabFunction = "DolphinStyleMenu";
			m_IsTabFunctionDefault = true;
			m_TabDisabled = null;
			m_TabDisabledReference = null;
			m_TabDisabledName = null;
			m_IsTabDisabledDefault = true;
			m_ObjectsNames = null;
			m_ObjectsNamesReference = null;
			m_ObjectsNamesName = null;
			m_IsObjectsNamesDefault = true;
			m_CollumnTextAlign = "Left";
			m_IsCollumnTextAlignDefault = true;
			m_CollumnAttributeAlign = "Left";
			m_IsCollumnAttributeAlignDefault = true;
			m_PromptImage = null;
			m_PromptImageReference = null;
			m_PromptImageName = null;
			m_IsPromptImageDefault = true;
			m_PromptClass = "Image";
			m_IsPromptClassDefault = true;
			m_PromptSuggestForeignKey = false;
			m_IsPromptSuggestForeignKeyDefault = true;
			m_PromptSuggestNameContains = "prompt";
			m_IsPromptSuggestNameContainsDefault = true;
			m_PromptSuggestParmDescription = false;
			m_IsPromptSuggestParmDescriptionDefault = true;
			m_PromptSuggestGridPrimaryKey = false;
			m_IsPromptSuggestGridPrimaryKeyDefault = true;
			m_SuggestView = true;
			m_IsSuggestViewDefault = true;
			m_GenerateViewOnlyBC = false;
			m_IsGenerateViewOnlyBCDefault = true;
			m_BCSucessCode = "";
			m_IsBCSucessCodeDefault = true;
			m_BCErrorCode = "";
			m_IsBCErrorCodeDefault = true;
			m_BCPrimaryKeyDelimiter = "-";
			m_IsBCPrimaryKeyDelimiterDefault = true;
			m_HideElementIfEdit = false;
			m_IsHideElementIfEditDefault = true;
			m_HideElementName = "";
			m_IsHideElementNameDefault = true;
			m_ApplyReturnOnClickAll = true;
			m_IsApplyReturnOnClickAllDefault = true;
			m_PromptSearchEvent = "Search";
			m_IsPromptSearchEventDefault = true;
			m_GenerateListPrograms = true;
			m_IsGenerateListProgramsDefault = true;
			m_GenerateCallBackLink = false;
			m_IsGenerateCallBackLinkDefault = true;
			m_Suggests = new Artech.Common.Collections.BaseCollection<SettingsSuggestInstanceElement>();
			m_Suggests.ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsSuggestInstanceElement>>(Suggests_ItemAdded);
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsTemplateElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		[Do not update] - Não atualiza a transação
[Only rules and events] - Atualiza somente regras e eventos
[Apply WW Style] - Atualiza somente WebForm
[Create default] - Atualiza toda a transação
		*/
		/// </summary>
		public System.String UpdateTransaction
		{
			get { return m_UpdateTransaction; }
			set 
			{
				m_UpdateTransaction = value;
				m_IsUpdateTransactionDefault = false;
			}
		}

		/// <summary>
		/*
		Define a versão que será gerado os comentários nos objetos gerados pelo pattern
		*/
		/// </summary>
		public System.String CompatibilidadeVersao
		{
			get { return m_CompatibilidadeVersao; }
			set 
			{
				m_CompatibilidadeVersao = value;
				m_IsCompatibilidadeVersaoDefault = false;
			}
		}

		/// <summary>
		/*
		Default "Is Main" value for Selection nodes.
		*/
		/// </summary>
		public System.Boolean SelectionIsMain
		{
			get { return m_SelectionIsMain; }
			set 
			{
				m_SelectionIsMain = value;
				m_IsSelectionIsMainDefault = false;
			}
		}

		/// <summary>
		/*
		Add tabular tabs to the view for parallel transactrions.
		*/
		/// </summary>
		public System.Boolean TabsForParallelTransactions
		{
			get { return m_TabsForParallelTransactions; }
			set 
			{
				m_TabsForParallelTransactions = value;
				m_IsTabsForParallelTransactionsDefault = false;
			}
		}

		/// <summary>
		/*
		Use navigation context for transaction insert parameters (e.g. adding an Invoice to a Customer).
		*/
		/// </summary>
		public System.Boolean UseTransactionContext
		{
			get { return m_UseTransactionContext; }
			set 
			{
				m_UseTransactionContext = value;
				m_IsUseTransactionContextDefault = false;
			}
		}

		/// <summary>
		/*
		Default action performed after inserting a record.
		*/
		/// </summary>
		public System.String AfterInsert
		{
			get { return m_AfterInsert; }
			set 
			{
				m_AfterInsert = value;
				m_IsAfterInsertDefault = false;
			}
		}

		/// <summary>
		/*
		Default action performed after updating a record.
		*/
		/// </summary>
		public System.String AfterUpdate
		{
			get { return m_AfterUpdate; }
			set 
			{
				m_AfterUpdate = value;
				m_IsAfterUpdateDefault = false;
			}
		}

		/// <summary>
		/*
		Default action performed after deleting a record.
		*/
		/// </summary>
		public System.String AfterDelete
		{
			get { return m_AfterDelete; }
			set 
			{
				m_AfterDelete = value;
				m_IsAfterDeleteDefault = false;
			}
		}

		/// <summary>
		/*
		Classe para a tabela de Titulo da WW
		*/
		/// </summary>
		public System.String TitleTableClass
		{
			get { return m_TitleTableClass; }
			set 
			{
				m_TitleTableClass = value;
				m_IsTitleTableClassDefault = false;
			}
		}

		/// <summary>
		/*
		Classe para a texto de Titulo da WW
		*/
		/// </summary>
		public System.String TitleTextClass
		{
			get { return m_TitleTextClass; }
			set 
			{
				m_TitleTextClass = value;
				m_IsTitleTextClassDefault = false;
			}
		}

		/// <summary>
		/*
		Imagem para o Titulo da WW
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image TitleImage
		{
			get
			{
				if (m_TitleImage == null && m_TitleImageReference != null)
					m_TitleImage = (Artech.Genexus.Common.Objects.Image)m_TitleImageReference.GetKBObject(Settings.Model);

				return m_TitleImage;
			}

			set 
			{
				m_TitleImage = value;
				m_TitleImageReference = (value != null ? new KBObjectReference(value) : null);
				m_TitleImageName = (value != null ? value.Name : null);
				m_IsTitleImageDefault = false;
			}
		}

		/// <summary>
		/// TitleImage name.
		/// </summary>
		public string TitleImageName
		{
			get
			{
				if (m_TitleImageName == null && m_TitleImageReference != null)
					m_TitleImageName = m_TitleImageReference.GetName(Settings.Model);

				return m_TitleImageName;
			}
		}

		/// <summary>
		/*
		Utiliza Collapse/Expand para os Filtros da Selection
		*/
		/// </summary>
		public System.Boolean FilterCollapse
		{
			get { return m_FilterCollapse; }
			set 
			{
				m_FilterCollapse = value;
				m_IsFilterCollapseDefault = false;
			}
		}

		/// <summary>
		/*
		Carrega os Filtros por padrão Collapse
		*/
		/// </summary>
		public System.Boolean FilterCollapseDefault
		{
			get { return m_FilterCollapseDefault; }
			set 
			{
				m_FilterCollapseDefault = value;
				m_IsFilterCollapseDefaultDefault = false;
			}
		}

		/// <summary>
		/*
		Classe para a tabela de Titulo da Transaction
		*/
		/// </summary>
		public System.String TrnTitleTableClass
		{
			get { return m_TrnTitleTableClass; }
			set 
			{
				m_TrnTitleTableClass = value;
				m_IsTrnTitleTableClassDefault = false;
			}
		}

		/// <summary>
		/*
		Classe para a texto de Titulo da Transaction
		*/
		/// </summary>
		public System.String TrnTitleTextClass
		{
			get { return m_TrnTitleTextClass; }
			set 
			{
				m_TrnTitleTextClass = value;
				m_IsTrnTitleTextClassDefault = false;
			}
		}

		/// <summary>
		/*
		Imagem para o Titulo da Transação
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image TrnTitleImage
		{
			get
			{
				if (m_TrnTitleImage == null && m_TrnTitleImageReference != null)
					m_TrnTitleImage = (Artech.Genexus.Common.Objects.Image)m_TrnTitleImageReference.GetKBObject(Settings.Model);

				return m_TrnTitleImage;
			}

			set 
			{
				m_TrnTitleImage = value;
				m_TrnTitleImageReference = (value != null ? new KBObjectReference(value) : null);
				m_TrnTitleImageName = (value != null ? value.Name : null);
				m_IsTrnTitleImageDefault = false;
			}
		}

		/// <summary>
		/// TrnTitleImage name.
		/// </summary>
		public string TrnTitleImageName
		{
			get
			{
				if (m_TrnTitleImageName == null && m_TrnTitleImageReference != null)
					m_TrnTitleImageName = m_TrnTitleImageReference.GetName(Settings.Model);

				return m_TrnTitleImageName;
			}
		}

		/// <summary>
		/*
		Utiliza botão de Help ou não
		*/
		/// </summary>
		public System.Boolean ButtonHelp
		{
			get { return m_ButtonHelp; }
			set 
			{
				m_ButtonHelp = value;
				m_IsButtonHelpDefault = false;
			}
		}

		/// <summary>
		/*
		Classe para o botão de Help
		*/
		/// </summary>
		public System.String ButtonHelpClass
		{
			get { return m_ButtonHelpClass; }
			set 
			{
				m_ButtonHelpClass = value;
				m_IsButtonHelpClassDefault = false;
			}
		}

		/// <summary>
		/*
		Caption para o botão de Help
		*/
		/// </summary>
		public System.String ButtonHelpCaption
		{
			get { return m_ButtonHelpCaption; }
			set 
			{
				m_ButtonHelpCaption = value;
				m_IsButtonHelpCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		Adiciona o botão de Help na Selection
		*/
		/// </summary>
		public System.Boolean ButtonHelpApplySelection
		{
			get { return m_ButtonHelpApplySelection; }
			set 
			{
				m_ButtonHelpApplySelection = value;
				m_IsButtonHelpApplySelectionDefault = false;
			}
		}

		/// <summary>
		/*
		Código para o Evento Start da Transaction
		*/
		/// </summary>
		public System.String EventStart
		{
			get { return m_EventStart; }
			set 
			{
				m_EventStart = value;
				m_IsEventStartDefault = false;
			}
		}

		/// <summary>
		/*
		Arquivo de Templete para a Selection
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel SelectionTemplate
		{
			get
			{
				if (m_SelectionTemplate == null && m_SelectionTemplateReference != null)
					m_SelectionTemplate = (Artech.Genexus.Common.Objects.WebPanel)m_SelectionTemplateReference.GetKBObject(Settings.Model);

				return m_SelectionTemplate;
			}

			set 
			{
				m_SelectionTemplate = value;
				m_SelectionTemplateReference = (value != null ? new KBObjectReference(value) : null);
				m_SelectionTemplateName = (value != null ? value.Name : null);
				m_IsSelectionTemplateDefault = false;
			}
		}

		/// <summary>
		/// SelectionTemplate name.
		/// </summary>
		public string SelectionTemplateName
		{
			get
			{
				if (m_SelectionTemplateName == null && m_SelectionTemplateReference != null)
					m_SelectionTemplateName = m_SelectionTemplateReference.GetName(Settings.Model);

				return m_SelectionTemplateName;
			}
		}

		/// <summary>
		/*
		Debug do Templete para a Selection
		*/
		/// </summary>
		public System.String SelectionTemplateDebug
		{
			get { return m_SelectionTemplateDebug; }
			set 
			{
				m_SelectionTemplateDebug = value;
				m_IsSelectionTemplateDebugDefault = false;
			}
		}

		/// <summary>
		/*
		Arquivo de Templete para a View
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel ViewTemplate
		{
			get
			{
				if (m_ViewTemplate == null && m_ViewTemplateReference != null)
					m_ViewTemplate = (Artech.Genexus.Common.Objects.WebPanel)m_ViewTemplateReference.GetKBObject(Settings.Model);

				return m_ViewTemplate;
			}

			set 
			{
				m_ViewTemplate = value;
				m_ViewTemplateReference = (value != null ? new KBObjectReference(value) : null);
				m_ViewTemplateName = (value != null ? value.Name : null);
				m_IsViewTemplateDefault = false;
			}
		}

		/// <summary>
		/// ViewTemplate name.
		/// </summary>
		public string ViewTemplateName
		{
			get
			{
				if (m_ViewTemplateName == null && m_ViewTemplateReference != null)
					m_ViewTemplateName = m_ViewTemplateReference.GetName(Settings.Model);

				return m_ViewTemplateName;
			}
		}

		/// <summary>
		/*
		Debug do Templete para a View
		*/
		/// </summary>
		public System.String ViewTemplateDebug
		{
			get { return m_ViewTemplateDebug; }
			set 
			{
				m_ViewTemplateDebug = value;
				m_IsViewTemplateDebugDefault = false;
			}
		}

		/// <summary>
		/*
		Arquivo de Templete para a Prompt
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel PromptTemplate
		{
			get
			{
				if (m_PromptTemplate == null && m_PromptTemplateReference != null)
					m_PromptTemplate = (Artech.Genexus.Common.Objects.WebPanel)m_PromptTemplateReference.GetKBObject(Settings.Model);

				return m_PromptTemplate;
			}

			set 
			{
				m_PromptTemplate = value;
				m_PromptTemplateReference = (value != null ? new KBObjectReference(value) : null);
				m_PromptTemplateName = (value != null ? value.Name : null);
				m_IsPromptTemplateDefault = false;
			}
		}

		/// <summary>
		/// PromptTemplate name.
		/// </summary>
		public string PromptTemplateName
		{
			get
			{
				if (m_PromptTemplateName == null && m_PromptTemplateReference != null)
					m_PromptTemplateName = m_PromptTemplateReference.GetName(Settings.Model);

				return m_PromptTemplateName;
			}
		}

		/// <summary>
		/*
		Debug do Templete para a Prompt
		*/
		/// </summary>
		public System.String PromptTemplateDebug
		{
			get { return m_PromptTemplateDebug; }
			set 
			{
				m_PromptTemplateDebug = value;
				m_IsPromptTemplateDebugDefault = false;
			}
		}

		/// <summary>
		/*
		Arquivo de Templete para a Transaction
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel TransactionTemplate
		{
			get
			{
				if (m_TransactionTemplate == null && m_TransactionTemplateReference != null)
					m_TransactionTemplate = (Artech.Genexus.Common.Objects.WebPanel)m_TransactionTemplateReference.GetKBObject(Settings.Model);

				return m_TransactionTemplate;
			}

			set 
			{
				m_TransactionTemplate = value;
				m_TransactionTemplateReference = (value != null ? new KBObjectReference(value) : null);
				m_TransactionTemplateName = (value != null ? value.Name : null);
				m_IsTransactionTemplateDefault = false;
			}
		}

		/// <summary>
		/// TransactionTemplate name.
		/// </summary>
		public string TransactionTemplateName
		{
			get
			{
				if (m_TransactionTemplateName == null && m_TransactionTemplateReference != null)
					m_TransactionTemplateName = m_TransactionTemplateReference.GetName(Settings.Model);

				return m_TransactionTemplateName;
			}
		}

		/// <summary>
		/*
		Debug do Templete para a Transaction
		*/
		/// </summary>
		public System.String TransactionTemplateDebug
		{
			get { return m_TransactionTemplateDebug; }
			set 
			{
				m_TransactionTemplateDebug = value;
				m_IsTransactionTemplateDebugDefault = false;
			}
		}

		/// <summary>
		/*
		Utiliza WebPanel com BC para cadastro ou a transação
		*/
		/// </summary>
		public System.Boolean DataEntryWebPanelBC
		{
			get { return m_DataEntryWebPanelBC; }
			set 
			{
				m_DataEntryWebPanelBC = value;
				m_IsDataEntryWebPanelBCDefault = false;
			}
		}

		/// <summary>
		/*
		Carrega a SDT utilizando Data Provider
		*/
		/// </summary>
		public System.Boolean LoadSDTWithDataProvider
		{
			get { return m_LoadSDTWithDataProvider; }
			set 
			{
				m_LoadSDTWithDataProvider = value;
				m_IsLoadSDTWithDataProviderDefault = false;
			}
		}

		/// <summary>
		/*
		Desabilita outras abas quando esta editando registro de outro nivel
		*/
		/// </summary>
		public System.Boolean DisabledTabsIfEditing
		{
			get { return m_DisabledTabsIfEditing; }
			set 
			{
				m_DisabledTabsIfEditing = value;
				m_IsDisabledTabsIfEditingDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica pattern Default automático ao WebPanel com BC
		*/
		/// </summary>
		public System.Boolean WebPanelBCDefault
		{
			get { return m_WebPanelBCDefault; }
			set 
			{
				m_WebPanelBCDefault = value;
				m_IsWebPanelBCDefaultDefault = false;
			}
		}

		/// <summary>
		/*
		Não permite quantidade de itens em branco na Aba com Grid do WebPanel com BC
		*/
		/// </summary>
		public System.Boolean ListNotNullTabGrid
		{
			get { return m_ListNotNullTabGrid; }
			set 
			{
				m_ListNotNullTabGrid = value;
				m_IsListNotNullTabGridDefault = false;
			}
		}

		/// <summary>
		/*
		ListNotNullTabGrid Mensagem, coringa {0} define a descrição da aba
		*/
		/// </summary>
		public System.String ListNotNullMessage
		{
			get { return m_ListNotNullMessage; }
			set 
			{
				m_ListNotNullMessage = value;
				m_IsListNotNullMessageDefault = false;
			}
		}

		/// <summary>
		/*
		Coloca atributo inferido na mesma coluna do atributo anterior
		*/
		/// </summary>
		public System.Boolean InferedAttributeInSameBeforeColumn
		{
			get { return m_InferedAttributeInSameBeforeColumn; }
			set 
			{
				m_InferedAttributeInSameBeforeColumn = value;
				m_IsInferedAttributeInSameBeforeColumnDefault = false;
			}
		}

		/// <summary>
		/*
		Sugere evento IsValid para atributo ForeignKey que tem atributos inferidos
		*/
		/// </summary>
		public System.Boolean SuggestEventIsValidForForeignKey
		{
			get { return m_SuggestEventIsValidForForeignKey; }
			set 
			{
				m_SuggestEventIsValidForForeignKey = value;
				m_IsSuggestEventIsValidForForeignKeyDefault = false;
			}
		}

		/// <summary>
		/*
		Mensagem padrão quando não encontra ForeignKey, Coringa {0} é a descrição da transação
		*/
		/// </summary>
		public System.String SuggestMessageNotFoundForeignKey
		{
			get { return m_SuggestMessageNotFoundForeignKey; }
			set 
			{
				m_SuggestMessageNotFoundForeignKey = value;
				m_IsSuggestMessageNotFoundForeignKeyDefault = false;
			}
		}

		/// <summary>
		/*
		Define qual o objeto responsavel por mostrar a mensagem de alerta ao usuário, recebe a referencia da sdt de mensagens na sessão e o link de retorno
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel PopupMessage
		{
			get
			{
				if (m_PopupMessage == null && m_PopupMessageReference != null)
					m_PopupMessage = (Artech.Genexus.Common.Objects.WebPanel)m_PopupMessageReference.GetKBObject(Settings.Model);

				return m_PopupMessage;
			}

			set 
			{
				m_PopupMessage = value;
				m_PopupMessageReference = (value != null ? new KBObjectReference(value) : null);
				m_PopupMessageName = (value != null ? value.Name : null);
				m_IsPopupMessageDefault = false;
			}
		}

		/// <summary>
		/// PopupMessage name.
		/// </summary>
		public string PopupMessageName
		{
			get
			{
				if (m_PopupMessageName == null && m_PopupMessageReference != null)
					m_PopupMessageName = m_PopupMessageReference.GetName(Settings.Model);

				return m_PopupMessageName;
			}
		}

		/// <summary>
		/*
		Define o Width da Popup de mensagens
		*/
		/// </summary>
		public System.Int32 PopupMessageWidth
		{
			get { return m_PopupMessageWidth; }
			set 
			{
				m_PopupMessageWidth = value;
				m_IsPopupMessageWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Height da Popup de mensagens
		*/
		/// </summary>
		public System.Int32 PopupMessageHeight
		{
			get { return m_PopupMessageHeight; }
			set 
			{
				m_PopupMessageHeight = value;
				m_IsPopupMessageHeightDefault = false;
			}
		}

		/// <summary>
		/*
		Define o inicio da mensagem de alerta da validação
		*/
		/// </summary>
		public System.String ValidationWarningMessage
		{
			get { return m_ValidationWarningMessage; }
			set 
			{
				m_ValidationWarningMessage = value;
				m_IsValidationWarningMessageDefault = false;
			}
		}

		/// <summary>
		/*
		Define o inicio da mensagem de erro da validação
		*/
		/// </summary>
		public System.String ValidationErrorMessage
		{
			get { return m_ValidationErrorMessage; }
			set 
			{
				m_ValidationErrorMessage = value;
				m_IsValidationErrorMessageDefault = false;
			}
		}

		/// <summary>
		/*
		Define Foco no primeiro atributo de filtro
		*/
		/// </summary>
		public System.Boolean SelectionSetFocus
		{
			get { return m_SelectionSetFocus; }
			set 
			{
				m_SelectionSetFocus = value;
				m_IsSelectionSetFocusDefault = false;
			}
		}

		/// <summary>
		/*
		Define Foco no primeiro atributo editavel da tela
		*/
		/// </summary>
		public System.Boolean TransactionSetFocus
		{
			get { return m_TransactionSetFocus; }
			set 
			{
				m_TransactionSetFocus = value;
				m_IsTransactionSetFocusDefault = false;
			}
		}

		/// <summary>
		/*
		Define como obrigatório atributo NotNull
		*/
		/// </summary>
		public System.Boolean RequiredNotNullAttribute
		{
			get { return m_RequiredNotNullAttribute; }
			set 
			{
				m_RequiredNotNullAttribute = value;
				m_IsRequiredNotNullAttributeDefault = false;
			}
		}

		/// <summary>
		/*
		Define mensagem padrão para atributo obrigatório, Coringda {0} é a descrição do atributo
		*/
		/// </summary>
		public System.String RequiredNotNullMessage
		{
			get { return m_RequiredNotNullMessage; }
			set 
			{
				m_RequiredNotNullMessage = value;
				m_IsRequiredNotNullMessageDefault = false;
			}
		}

		/// <summary>
		/*
		Define se aplica a regra error no AfterValidate ou não
		*/
		/// </summary>
		public System.Boolean RequiredAfterValidate
		{
			get { return m_RequiredAfterValidate; }
			set 
			{
				m_RequiredAfterValidate = value;
				m_IsRequiredAfterValidateDefault = false;
			}
		}

		/// <summary>
		/*
		Define regra para atributo Date
		*/
		/// </summary>
		public System.String RuleDate
		{
			get { return m_RuleDate; }
			set 
			{
				m_RuleDate = value;
				m_IsRuleDateDefault = false;
			}
		}

		/// <summary>
		/*
		Define valor da regra para atributo Date
		*/
		/// </summary>
		public System.String ValueRuleDate
		{
			get { return m_ValueRuleDate; }
			set 
			{
				m_ValueRuleDate = value;
				m_IsValueRuleDateDefault = false;
			}
		}

		/// <summary>
		/*
		Define regra para atributo DateTime
		*/
		/// </summary>
		public System.String RuleDateTime
		{
			get { return m_RuleDateTime; }
			set 
			{
				m_RuleDateTime = value;
				m_IsRuleDateTimeDefault = false;
			}
		}

		/// <summary>
		/*
		Define valor da regra para atributo Datetime
		*/
		/// </summary>
		public System.String ValueRuleDateTime
		{
			get { return m_ValueRuleDateTime; }
			set 
			{
				m_ValueRuleDateTime = value;
				m_IsValueRuleDateTimeDefault = false;
			}
		}

		/// <summary>
		/*
		Define a picture padrão para atributos caracter
		*/
		/// </summary>
		public System.String PictureCharacterDefault
		{
			get { return m_PictureCharacterDefault; }
			set 
			{
				m_PictureCharacterDefault = value;
				m_IsPictureCharacterDefaultDefault = false;
			}
		}

		/// <summary>
		/*
		Define o metodo/User Control utilizado para criar abas na transação
		*/
		/// </summary>
		public System.String TabFunction
		{
			get { return m_TabFunction; }
			set 
			{
				m_TabFunction = value;
				m_IsTabFunctionDefault = false;
			}
		}

		/// <summary>
		/*
		Define a imagem desabilitado para os itens da treeview
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image TabDisabled
		{
			get
			{
				if (m_TabDisabled == null && m_TabDisabledReference != null)
					m_TabDisabled = (Artech.Genexus.Common.Objects.Image)m_TabDisabledReference.GetKBObject(Settings.Model);

				return m_TabDisabled;
			}

			set 
			{
				m_TabDisabled = value;
				m_TabDisabledReference = (value != null ? new KBObjectReference(value) : null);
				m_TabDisabledName = (value != null ? value.Name : null);
				m_IsTabDisabledDefault = false;
			}
		}

		/// <summary>
		/// TabDisabled name.
		/// </summary>
		public string TabDisabledName
		{
			get
			{
				if (m_TabDisabledName == null && m_TabDisabledReference != null)
					m_TabDisabledName = m_TabDisabledReference.GetName(Settings.Model);

				return m_TabDisabledName;
			}
		}

		/// <summary>
		/*
		Arquivo de definição de nomes de objetos a serem gerados separados por ;
		*/
		/// </summary>
		public Artech.Architecture.Common.Objects.KBObject ObjectsNames
		{
			get
			{
				if (m_ObjectsNames == null && m_ObjectsNamesReference != null)
					m_ObjectsNames = (Artech.Architecture.Common.Objects.KBObject)m_ObjectsNamesReference.GetKBObject(Settings.Model);

				return m_ObjectsNames;
			}

			set 
			{
				m_ObjectsNames = value;
				m_ObjectsNamesReference = (value != null ? new KBObjectReference(value) : null);
				m_ObjectsNamesName = (value != null ? value.Name : null);
				m_IsObjectsNamesDefault = false;
			}
		}

		/// <summary>
		/// ObjectsNames name.
		/// </summary>
		public string ObjectsNamesName
		{
			get
			{
				if (m_ObjectsNamesName == null && m_ObjectsNamesReference != null)
					m_ObjectsNamesName = m_ObjectsNamesReference.GetName(Settings.Model);

				return m_ObjectsNamesName;
			}
		}

		/// <summary>
		/*
		Define propriedade Align da celula onde esta o TextBlock com a descrição do attributo
		*/
		/// </summary>
		public System.String CollumnTextAlign
		{
			get { return m_CollumnTextAlign; }
			set 
			{
				m_CollumnTextAlign = value;
				m_IsCollumnTextAlignDefault = false;
			}
		}

		/// <summary>
		/*
		Define propriedade Align da celula onde esta o attributo
		*/
		/// </summary>
		public System.String CollumnAttributeAlign
		{
			get { return m_CollumnAttributeAlign; }
			set 
			{
				m_CollumnAttributeAlign = value;
				m_IsCollumnAttributeAlignDefault = false;
			}
		}

		/// <summary>
		/*
		Define a imagem para prompt
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image PromptImage
		{
			get
			{
				if (m_PromptImage == null && m_PromptImageReference != null)
					m_PromptImage = (Artech.Genexus.Common.Objects.Image)m_PromptImageReference.GetKBObject(Settings.Model);

				return m_PromptImage;
			}

			set 
			{
				m_PromptImage = value;
				m_PromptImageReference = (value != null ? new KBObjectReference(value) : null);
				m_PromptImageName = (value != null ? value.Name : null);
				m_IsPromptImageDefault = false;
			}
		}

		/// <summary>
		/// PromptImage name.
		/// </summary>
		public string PromptImageName
		{
			get
			{
				if (m_PromptImageName == null && m_PromptImageReference != null)
					m_PromptImageName = m_PromptImageReference.GetName(Settings.Model);

				return m_PromptImageName;
			}
		}

		/// <summary>
		/*
		Define a class da imagem para prompt
		*/
		/// </summary>
		public System.String PromptClass
		{
			get { return m_PromptClass; }
			set 
			{
				m_PromptClass = value;
				m_IsPromptClassDefault = false;
			}
		}

		/// <summary>
		/*
		Sugere Prompt para Atributo ForeignKeyt
		*/
		/// </summary>
		public System.Boolean PromptSuggestForeignKey
		{
			get { return m_PromptSuggestForeignKey; }
			set 
			{
				m_PromptSuggestForeignKey = value;
				m_IsPromptSuggestForeignKeyDefault = false;
			}
		}

		/// <summary>
		/*
		Pesquisa somente os WebPanel Prompts que comtem este nome
		*/
		/// </summary>
		public System.String PromptSuggestNameContains
		{
			get { return m_PromptSuggestNameContains; }
			set 
			{
				m_PromptSuggestNameContains = value;
				m_IsPromptSuggestNameContainsDefault = false;
			}
		}

		/// <summary>
		/*
		Sugere no Parm do Prompt o Atributo Description
		*/
		/// </summary>
		public System.Boolean PromptSuggestParmDescription
		{
			get { return m_PromptSuggestParmDescription; }
			set 
			{
				m_PromptSuggestParmDescription = value;
				m_IsPromptSuggestParmDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Sugere os atributos da chave primária no grid do Prompt
		*/
		/// </summary>
		public System.Boolean PromptSuggestGridPrimaryKey
		{
			get { return m_PromptSuggestGridPrimaryKey; }
			set 
			{
				m_PromptSuggestGridPrimaryKey = value;
				m_IsPromptSuggestGridPrimaryKeyDefault = false;
			}
		}

		/// <summary>
		/*
		Sugere configuração padrão da View ao criar nova instância do Pattern
		*/
		/// </summary>
		public System.Boolean SuggestView
		{
			get { return m_SuggestView; }
			set 
			{
				m_SuggestView = value;
				m_IsSuggestViewDefault = false;
			}
		}

		/// <summary>
		/*
		Gera a View somente quando for BC
		*/
		/// </summary>
		public System.Boolean GenerateViewOnlyBC
		{
			get { return m_GenerateViewOnlyBC; }
			set 
			{
				m_GenerateViewOnlyBC = value;
				m_IsGenerateViewOnlyBCDefault = false;
			}
		}

		/// <summary>
		/*
		Define Código para Evento quando o BC Salvar com sucesso,Coringa {0} é a chave primaria, {1} é o nome do objeto principal, {2} é os parametros para chamada
		*/
		/// </summary>
		public System.String BCSucessCode
		{
			get { return m_BCSucessCode; }
			set 
			{
				m_BCSucessCode = value;
				m_IsBCSucessCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Define Código para Evento quando o BC não Salvar e retornar erro,Coringa {0} é a chave primaria, {1} é o nome do objeto principal, {2} é os parametros para chamada
		*/
		/// </summary>
		public System.String BCErrorCode
		{
			get { return m_BCErrorCode; }
			set 
			{
				m_BCErrorCode = value;
				m_IsBCErrorCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Define o delimitador para concatenar a chave primaria
		*/
		/// </summary>
		public System.String BCPrimaryKeyDelimiter
		{
			get { return m_BCPrimaryKeyDelimiter; }
			set 
			{
				m_BCPrimaryKeyDelimiter = value;
				m_IsBCPrimaryKeyDelimiterDefault = false;
			}
		}

		/// <summary>
		/*
		No WebPanel de segundo nivel do BC, esconde o Grid e os botões Gerais se esta editando um item
		*/
		/// </summary>
		public System.Boolean HideElementIfEdit
		{
			get { return m_HideElementIfEdit; }
			set 
			{
				m_HideElementIfEdit = value;
				m_IsHideElementIfEditDefault = false;
			}
		}

		/// <summary>
		/*
		No WebPanel de segundo nivel do BC, define o elemento, tabela, que será ocultado ao editar um item
		*/
		/// </summary>
		public System.String HideElementName
		{
			get { return m_HideElementName; }
			set 
			{
				m_HideElementName = value;
				m_IsHideElementNameDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Return On Click em todos os atributos do Grid ou somente no primeiro
		*/
		/// </summary>
		public System.Boolean ApplyReturnOnClickAll
		{
			get { return m_ApplyReturnOnClickAll; }
			set 
			{
				m_ApplyReturnOnClickAll = value;
				m_IsApplyReturnOnClickAllDefault = false;
			}
		}

		/// <summary>
		/*
		Define o evento para o botão Procurar, Search ou Enter
		*/
		/// </summary>
		public System.String PromptSearchEvent
		{
			get { return m_PromptSearchEvent; }
			set 
			{
				m_PromptSearchEvent = value;
				m_IsPromptSearchEventDefault = false;
			}
		}

		/// <summary>
		/*
		Define se gera ou não o ListPrograms
		*/
		/// </summary>
		public System.Boolean GenerateListPrograms
		{
			get { return m_GenerateListPrograms; }
			set 
			{
				m_GenerateListPrograms = value;
				m_IsGenerateListProgramsDefault = false;
			}
		}

		/// <summary>
		/*
		Define se gera ou não um novo parâmetro de callback com o link para retorno em todos objetos do Pattern
		*/
		/// </summary>
		public System.Boolean GenerateCallBackLink
		{
			get { return m_GenerateCallBackLink; }
			set 
			{
				m_GenerateCallBackLink = value;
				m_IsGenerateCallBackLinkDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<SettingsSuggestInstanceElement> Suggests
		{
			get { return m_Suggests; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="SettingsSuggestInstanceElement"/> and adds it to the <see cref="Suggests"/> collection.
		/// </summary>
		public SettingsSuggestInstanceElement AddSuggestInstance()
		{
			SettingsSuggestInstanceElement suggestInstanceElement = new SettingsSuggestInstanceElement();
			m_Suggests.Add(suggestInstanceElement);
			return suggestInstanceElement;
		}

		private void Suggests_ItemAdded(object sender, CollectionItemEventArgs<SettingsSuggestInstanceElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsTemplateElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Template")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Template"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_UpdateTransaction = element.Attributes.GetPropertyValue<System.String>("UpdateTransaction");
			m_IsUpdateTransactionDefault = element.Attributes.IsPropertyDefault("UpdateTransaction");
			m_CompatibilidadeVersao = element.Attributes.GetPropertyValue<System.String>("CompatibilidadeVersao");
			m_IsCompatibilidadeVersaoDefault = element.Attributes.IsPropertyDefault("CompatibilidadeVersao");
			m_SelectionIsMain = element.Attributes.GetPropertyValue<System.Boolean>("SelectionIsMain");
			m_IsSelectionIsMainDefault = element.Attributes.IsPropertyDefault("SelectionIsMain");
			m_TabsForParallelTransactions = element.Attributes.GetPropertyValue<System.Boolean>("TabsForParallelTransactions");
			m_IsTabsForParallelTransactionsDefault = element.Attributes.IsPropertyDefault("TabsForParallelTransactions");
			m_UseTransactionContext = element.Attributes.GetPropertyValue<System.Boolean>("UseTransactionContext");
			m_IsUseTransactionContextDefault = element.Attributes.IsPropertyDefault("UseTransactionContext");
			m_AfterInsert = element.Attributes.GetPropertyValue<System.String>("AfterInsert");
			m_IsAfterInsertDefault = element.Attributes.IsPropertyDefault("AfterInsert");
			m_AfterUpdate = element.Attributes.GetPropertyValue<System.String>("AfterUpdate");
			m_IsAfterUpdateDefault = element.Attributes.IsPropertyDefault("AfterUpdate");
			m_AfterDelete = element.Attributes.GetPropertyValue<System.String>("AfterDelete");
			m_IsAfterDeleteDefault = element.Attributes.IsPropertyDefault("AfterDelete");
			m_TitleTableClass = element.Attributes.GetPropertyValue<System.String>("TitleTableClass");
			m_IsTitleTableClassDefault = element.Attributes.IsPropertyDefault("TitleTableClass");
			m_TitleTextClass = element.Attributes.GetPropertyValue<System.String>("TitleTextClass");
			m_IsTitleTextClassDefault = element.Attributes.IsPropertyDefault("TitleTextClass");
			m_TitleImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("TitleImageReference");
			m_IsTitleImageDefault = element.Attributes.IsPropertyDefault("TitleImage");
			m_FilterCollapse = element.Attributes.GetPropertyValue<System.Boolean>("FilterCollapse");
			m_IsFilterCollapseDefault = element.Attributes.IsPropertyDefault("FilterCollapse");
			m_FilterCollapseDefault = element.Attributes.GetPropertyValue<System.Boolean>("FilterCollapseDefault");
			m_IsFilterCollapseDefaultDefault = element.Attributes.IsPropertyDefault("FilterCollapseDefault");
			m_TrnTitleTableClass = element.Attributes.GetPropertyValue<System.String>("TrnTitleTableClass");
			m_IsTrnTitleTableClassDefault = element.Attributes.IsPropertyDefault("TrnTitleTableClass");
			m_TrnTitleTextClass = element.Attributes.GetPropertyValue<System.String>("TrnTitleTextClass");
			m_IsTrnTitleTextClassDefault = element.Attributes.IsPropertyDefault("TrnTitleTextClass");
			m_TrnTitleImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("TrnTitleImageReference");
			m_IsTrnTitleImageDefault = element.Attributes.IsPropertyDefault("TrnTitleImage");
			m_ButtonHelp = element.Attributes.GetPropertyValue<System.Boolean>("ButtonHelp");
			m_IsButtonHelpDefault = element.Attributes.IsPropertyDefault("ButtonHelp");
			m_ButtonHelpClass = element.Attributes.GetPropertyValue<System.String>("ButtonHelpClass");
			m_IsButtonHelpClassDefault = element.Attributes.IsPropertyDefault("ButtonHelpClass");
			m_ButtonHelpCaption = element.Attributes.GetPropertyValue<System.String>("ButtonHelpCaption");
			m_IsButtonHelpCaptionDefault = element.Attributes.IsPropertyDefault("ButtonHelpCaption");
			m_ButtonHelpApplySelection = element.Attributes.GetPropertyValue<System.Boolean>("ButtonHelpApplySelection");
			m_IsButtonHelpApplySelectionDefault = element.Attributes.IsPropertyDefault("ButtonHelpApplySelection");
			m_EventStart = element.Attributes.GetPropertyValue<System.String>("EventStart");
			m_IsEventStartDefault = element.Attributes.IsPropertyDefault("EventStart");
			m_SelectionTemplateReference = element.Attributes.GetPropertyValue<KBObjectReference>("SelectionTemplateReference");
			m_IsSelectionTemplateDefault = element.Attributes.IsPropertyDefault("SelectionTemplate");
			m_SelectionTemplateDebug = element.Attributes.GetPropertyValue<System.String>("SelectionTemplateDebug");
			m_IsSelectionTemplateDebugDefault = element.Attributes.IsPropertyDefault("SelectionTemplateDebug");
			m_ViewTemplateReference = element.Attributes.GetPropertyValue<KBObjectReference>("ViewTemplateReference");
			m_IsViewTemplateDefault = element.Attributes.IsPropertyDefault("ViewTemplate");
			m_ViewTemplateDebug = element.Attributes.GetPropertyValue<System.String>("ViewTemplateDebug");
			m_IsViewTemplateDebugDefault = element.Attributes.IsPropertyDefault("ViewTemplateDebug");
			m_PromptTemplateReference = element.Attributes.GetPropertyValue<KBObjectReference>("PromptTemplateReference");
			m_IsPromptTemplateDefault = element.Attributes.IsPropertyDefault("PromptTemplate");
			m_PromptTemplateDebug = element.Attributes.GetPropertyValue<System.String>("PromptTemplateDebug");
			m_IsPromptTemplateDebugDefault = element.Attributes.IsPropertyDefault("PromptTemplateDebug");
			m_TransactionTemplateReference = element.Attributes.GetPropertyValue<KBObjectReference>("TransactionTemplateReference");
			m_IsTransactionTemplateDefault = element.Attributes.IsPropertyDefault("TransactionTemplate");
			m_TransactionTemplateDebug = element.Attributes.GetPropertyValue<System.String>("TransactionTemplateDebug");
			m_IsTransactionTemplateDebugDefault = element.Attributes.IsPropertyDefault("TransactionTemplateDebug");
			m_DataEntryWebPanelBC = element.Attributes.GetPropertyValue<System.Boolean>("DataEntryWebPanelBC");
			m_IsDataEntryWebPanelBCDefault = element.Attributes.IsPropertyDefault("DataEntryWebPanelBC");
			m_LoadSDTWithDataProvider = element.Attributes.GetPropertyValue<System.Boolean>("LoadSDTWithDataProvider");
			m_IsLoadSDTWithDataProviderDefault = element.Attributes.IsPropertyDefault("LoadSDTWithDataProvider");
			m_DisabledTabsIfEditing = element.Attributes.GetPropertyValue<System.Boolean>("DisabledTabsIfEditing");
			m_IsDisabledTabsIfEditingDefault = element.Attributes.IsPropertyDefault("DisabledTabsIfEditing");
			m_WebPanelBCDefault = element.Attributes.GetPropertyValue<System.Boolean>("WebPanelBCDefault");
			m_IsWebPanelBCDefaultDefault = element.Attributes.IsPropertyDefault("WebPanelBCDefault");
			m_ListNotNullTabGrid = element.Attributes.GetPropertyValue<System.Boolean>("ListNotNullTabGrid");
			m_IsListNotNullTabGridDefault = element.Attributes.IsPropertyDefault("ListNotNullTabGrid");
			m_ListNotNullMessage = element.Attributes.GetPropertyValue<System.String>("ListNotNullMessage");
			m_IsListNotNullMessageDefault = element.Attributes.IsPropertyDefault("ListNotNullMessage");
			m_InferedAttributeInSameBeforeColumn = element.Attributes.GetPropertyValue<System.Boolean>("InferedAttributeInSameBeforeColumn");
			m_IsInferedAttributeInSameBeforeColumnDefault = element.Attributes.IsPropertyDefault("InferedAttributeInSameBeforeColumn");
			m_SuggestEventIsValidForForeignKey = element.Attributes.GetPropertyValue<System.Boolean>("SuggestEventIsValidForForeignKey");
			m_IsSuggestEventIsValidForForeignKeyDefault = element.Attributes.IsPropertyDefault("SuggestEventIsValidForForeignKey");
			m_SuggestMessageNotFoundForeignKey = element.Attributes.GetPropertyValue<System.String>("SuggestMessageNotFoundForeignKey");
			m_IsSuggestMessageNotFoundForeignKeyDefault = element.Attributes.IsPropertyDefault("SuggestMessageNotFoundForeignKey");
			m_PopupMessageReference = element.Attributes.GetPropertyValue<KBObjectReference>("PopupMessageReference");
			m_IsPopupMessageDefault = element.Attributes.IsPropertyDefault("PopupMessage");
			m_PopupMessageWidth = element.Attributes.GetPropertyValue<System.Int32>("PopupMessageWidth");
			m_IsPopupMessageWidthDefault = element.Attributes.IsPropertyDefault("PopupMessageWidth");
			m_PopupMessageHeight = element.Attributes.GetPropertyValue<System.Int32>("PopupMessageHeight");
			m_IsPopupMessageHeightDefault = element.Attributes.IsPropertyDefault("PopupMessageHeight");
			m_ValidationWarningMessage = element.Attributes.GetPropertyValue<System.String>("ValidationWarningMessage");
			m_IsValidationWarningMessageDefault = element.Attributes.IsPropertyDefault("ValidationWarningMessage");
			m_ValidationErrorMessage = element.Attributes.GetPropertyValue<System.String>("ValidationErrorMessage");
			m_IsValidationErrorMessageDefault = element.Attributes.IsPropertyDefault("ValidationErrorMessage");
			m_SelectionSetFocus = element.Attributes.GetPropertyValue<System.Boolean>("SelectionSetFocus");
			m_IsSelectionSetFocusDefault = element.Attributes.IsPropertyDefault("SelectionSetFocus");
			m_TransactionSetFocus = element.Attributes.GetPropertyValue<System.Boolean>("TransactionSetFocus");
			m_IsTransactionSetFocusDefault = element.Attributes.IsPropertyDefault("TransactionSetFocus");
			m_RequiredNotNullAttribute = element.Attributes.GetPropertyValue<System.Boolean>("RequiredNotNullAttribute");
			m_IsRequiredNotNullAttributeDefault = element.Attributes.IsPropertyDefault("RequiredNotNullAttribute");
			m_RequiredNotNullMessage = element.Attributes.GetPropertyValue<System.String>("RequiredNotNullMessage");
			m_IsRequiredNotNullMessageDefault = element.Attributes.IsPropertyDefault("RequiredNotNullMessage");
			m_RequiredAfterValidate = element.Attributes.GetPropertyValue<System.Boolean>("RequiredAfterValidate");
			m_IsRequiredAfterValidateDefault = element.Attributes.IsPropertyDefault("RequiredAfterValidate");
			m_RuleDate = element.Attributes.GetPropertyValue<System.String>("RuleDate");
			m_IsRuleDateDefault = element.Attributes.IsPropertyDefault("RuleDate");
			m_ValueRuleDate = element.Attributes.GetPropertyValue<System.String>("ValueRuleDate");
			m_IsValueRuleDateDefault = element.Attributes.IsPropertyDefault("ValueRuleDate");
			m_RuleDateTime = element.Attributes.GetPropertyValue<System.String>("RuleDateTime");
			m_IsRuleDateTimeDefault = element.Attributes.IsPropertyDefault("RuleDateTime");
			m_ValueRuleDateTime = element.Attributes.GetPropertyValue<System.String>("ValueRuleDateTime");
			m_IsValueRuleDateTimeDefault = element.Attributes.IsPropertyDefault("ValueRuleDateTime");
			m_PictureCharacterDefault = element.Attributes.GetPropertyValue<System.String>("PictureCharacterDefault");
			m_IsPictureCharacterDefaultDefault = element.Attributes.IsPropertyDefault("PictureCharacterDefault");
			m_TabFunction = element.Attributes.GetPropertyValue<System.String>("TabFunction");
			m_IsTabFunctionDefault = element.Attributes.IsPropertyDefault("TabFunction");
			m_TabDisabledReference = element.Attributes.GetPropertyValue<KBObjectReference>("TabDisabledReference");
			m_IsTabDisabledDefault = element.Attributes.IsPropertyDefault("TabDisabled");
			m_ObjectsNamesReference = element.Attributes.GetPropertyValue<KBObjectReference>("ObjectsNamesReference");
			m_IsObjectsNamesDefault = element.Attributes.IsPropertyDefault("ObjectsNames");
			m_CollumnTextAlign = element.Attributes.GetPropertyValue<System.String>("CollumnTextAlign");
			m_IsCollumnTextAlignDefault = element.Attributes.IsPropertyDefault("CollumnTextAlign");
			m_CollumnAttributeAlign = element.Attributes.GetPropertyValue<System.String>("CollumnAttributeAlign");
			m_IsCollumnAttributeAlignDefault = element.Attributes.IsPropertyDefault("CollumnAttributeAlign");
			m_PromptImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("PromptImageReference");
			m_IsPromptImageDefault = element.Attributes.IsPropertyDefault("PromptImage");
			m_PromptClass = element.Attributes.GetPropertyValue<System.String>("PromptClass");
			m_IsPromptClassDefault = element.Attributes.IsPropertyDefault("PromptClass");
			m_PromptSuggestForeignKey = element.Attributes.GetPropertyValue<System.Boolean>("PromptSuggestForeignKey");
			m_IsPromptSuggestForeignKeyDefault = element.Attributes.IsPropertyDefault("PromptSuggestForeignKey");
			m_PromptSuggestNameContains = element.Attributes.GetPropertyValue<System.String>("PromptSuggestNameContains");
			m_IsPromptSuggestNameContainsDefault = element.Attributes.IsPropertyDefault("PromptSuggestNameContains");
			m_PromptSuggestParmDescription = element.Attributes.GetPropertyValue<System.Boolean>("PromptSuggestParmDescription");
			m_IsPromptSuggestParmDescriptionDefault = element.Attributes.IsPropertyDefault("PromptSuggestParmDescription");
			m_PromptSuggestGridPrimaryKey = element.Attributes.GetPropertyValue<System.Boolean>("PromptSuggestGridPrimaryKey");
			m_IsPromptSuggestGridPrimaryKeyDefault = element.Attributes.IsPropertyDefault("PromptSuggestGridPrimaryKey");
			m_SuggestView = element.Attributes.GetPropertyValue<System.Boolean>("SuggestView");
			m_IsSuggestViewDefault = element.Attributes.IsPropertyDefault("SuggestView");
			m_GenerateViewOnlyBC = element.Attributes.GetPropertyValue<System.Boolean>("GenerateViewOnlyBC");
			m_IsGenerateViewOnlyBCDefault = element.Attributes.IsPropertyDefault("GenerateViewOnlyBC");
			m_BCSucessCode = element.Attributes.GetPropertyValue<System.String>("BCSucessCode");
			m_IsBCSucessCodeDefault = element.Attributes.IsPropertyDefault("BCSucessCode");
			m_BCErrorCode = element.Attributes.GetPropertyValue<System.String>("BCErrorCode");
			m_IsBCErrorCodeDefault = element.Attributes.IsPropertyDefault("BCErrorCode");
			m_BCPrimaryKeyDelimiter = element.Attributes.GetPropertyValue<System.String>("BCPrimaryKeyDelimiter");
			m_IsBCPrimaryKeyDelimiterDefault = element.Attributes.IsPropertyDefault("BCPrimaryKeyDelimiter");
			m_HideElementIfEdit = element.Attributes.GetPropertyValue<System.Boolean>("HideElementIfEdit");
			m_IsHideElementIfEditDefault = element.Attributes.IsPropertyDefault("HideElementIfEdit");
			m_HideElementName = element.Attributes.GetPropertyValue<System.String>("HideElementName");
			m_IsHideElementNameDefault = element.Attributes.IsPropertyDefault("HideElementName");
			m_ApplyReturnOnClickAll = element.Attributes.GetPropertyValue<System.Boolean>("ApplyReturnOnClickAll");
			m_IsApplyReturnOnClickAllDefault = element.Attributes.IsPropertyDefault("ApplyReturnOnClickAll");
			m_PromptSearchEvent = element.Attributes.GetPropertyValue<System.String>("PromptSearchEvent");
			m_IsPromptSearchEventDefault = element.Attributes.IsPropertyDefault("PromptSearchEvent");
			m_GenerateListPrograms = element.Attributes.GetPropertyValue<System.Boolean>("GenerateListPrograms");
			m_IsGenerateListProgramsDefault = element.Attributes.IsPropertyDefault("GenerateListPrograms");
			m_GenerateCallBackLink = element.Attributes.GetPropertyValue<System.Boolean>("GenerateCallBackLink");
			m_IsGenerateCallBackLinkDefault = element.Attributes.IsPropertyDefault("GenerateCallBackLink");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "Suggest" :
					{
						SettingsSuggestInstanceElement suggest = new SettingsSuggestInstanceElement();
						suggest.LoadFrom(_childElement);
						Suggests.Add(suggest);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="SettingsTemplateElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Template")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Template"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "UpdateTransaction", m_UpdateTransaction, m_IsUpdateTransactionDefault);
			SaveAttribute(element, "CompatibilidadeVersao", m_CompatibilidadeVersao, m_IsCompatibilidadeVersaoDefault);
			SaveAttribute(element, "SelectionIsMain", m_SelectionIsMain, m_IsSelectionIsMainDefault);
			SaveAttribute(element, "TabsForParallelTransactions", m_TabsForParallelTransactions, m_IsTabsForParallelTransactionsDefault);
			SaveAttribute(element, "UseTransactionContext", m_UseTransactionContext, m_IsUseTransactionContextDefault);
			SaveAttribute(element, "AfterInsert", m_AfterInsert, m_IsAfterInsertDefault);
			SaveAttribute(element, "AfterUpdate", m_AfterUpdate, m_IsAfterUpdateDefault);
			SaveAttribute(element, "AfterDelete", m_AfterDelete, m_IsAfterDeleteDefault);
			SaveAttribute(element, "TitleTableClass", m_TitleTableClass, m_IsTitleTableClassDefault);
			SaveAttribute(element, "TitleTextClass", m_TitleTextClass, m_IsTitleTextClassDefault);
			SaveAttribute(element, "TitleImageReference", m_TitleImageReference, m_IsTitleImageDefault);
			SaveAttribute(element, "FilterCollapse", m_FilterCollapse, m_IsFilterCollapseDefault);
			SaveAttribute(element, "FilterCollapseDefault", m_FilterCollapseDefault, m_IsFilterCollapseDefaultDefault);
			SaveAttribute(element, "TrnTitleTableClass", m_TrnTitleTableClass, m_IsTrnTitleTableClassDefault);
			SaveAttribute(element, "TrnTitleTextClass", m_TrnTitleTextClass, m_IsTrnTitleTextClassDefault);
			SaveAttribute(element, "TrnTitleImageReference", m_TrnTitleImageReference, m_IsTrnTitleImageDefault);
			SaveAttribute(element, "ButtonHelp", m_ButtonHelp, m_IsButtonHelpDefault);
			SaveAttribute(element, "ButtonHelpClass", m_ButtonHelpClass, m_IsButtonHelpClassDefault);
			SaveAttribute(element, "ButtonHelpCaption", m_ButtonHelpCaption, m_IsButtonHelpCaptionDefault);
			SaveAttribute(element, "ButtonHelpApplySelection", m_ButtonHelpApplySelection, m_IsButtonHelpApplySelectionDefault);
			SaveAttribute(element, "EventStart", m_EventStart, m_IsEventStartDefault);
			SaveAttribute(element, "SelectionTemplateReference", m_SelectionTemplateReference, m_IsSelectionTemplateDefault);
			SaveAttribute(element, "SelectionTemplateDebug", m_SelectionTemplateDebug, m_IsSelectionTemplateDebugDefault);
			SaveAttribute(element, "ViewTemplateReference", m_ViewTemplateReference, m_IsViewTemplateDefault);
			SaveAttribute(element, "ViewTemplateDebug", m_ViewTemplateDebug, m_IsViewTemplateDebugDefault);
			SaveAttribute(element, "PromptTemplateReference", m_PromptTemplateReference, m_IsPromptTemplateDefault);
			SaveAttribute(element, "PromptTemplateDebug", m_PromptTemplateDebug, m_IsPromptTemplateDebugDefault);
			SaveAttribute(element, "TransactionTemplateReference", m_TransactionTemplateReference, m_IsTransactionTemplateDefault);
			SaveAttribute(element, "TransactionTemplateDebug", m_TransactionTemplateDebug, m_IsTransactionTemplateDebugDefault);
			SaveAttribute(element, "DataEntryWebPanelBC", m_DataEntryWebPanelBC, m_IsDataEntryWebPanelBCDefault);
			SaveAttribute(element, "LoadSDTWithDataProvider", m_LoadSDTWithDataProvider, m_IsLoadSDTWithDataProviderDefault);
			SaveAttribute(element, "DisabledTabsIfEditing", m_DisabledTabsIfEditing, m_IsDisabledTabsIfEditingDefault);
			SaveAttribute(element, "WebPanelBCDefault", m_WebPanelBCDefault, m_IsWebPanelBCDefaultDefault);
			SaveAttribute(element, "ListNotNullTabGrid", m_ListNotNullTabGrid, m_IsListNotNullTabGridDefault);
			SaveAttribute(element, "ListNotNullMessage", m_ListNotNullMessage, m_IsListNotNullMessageDefault);
			SaveAttribute(element, "InferedAttributeInSameBeforeColumn", m_InferedAttributeInSameBeforeColumn, m_IsInferedAttributeInSameBeforeColumnDefault);
			SaveAttribute(element, "SuggestEventIsValidForForeignKey", m_SuggestEventIsValidForForeignKey, m_IsSuggestEventIsValidForForeignKeyDefault);
			SaveAttribute(element, "SuggestMessageNotFoundForeignKey", m_SuggestMessageNotFoundForeignKey, m_IsSuggestMessageNotFoundForeignKeyDefault);
			SaveAttribute(element, "PopupMessageReference", m_PopupMessageReference, m_IsPopupMessageDefault);
			SaveAttribute(element, "PopupMessageWidth", m_PopupMessageWidth, m_IsPopupMessageWidthDefault);
			SaveAttribute(element, "PopupMessageHeight", m_PopupMessageHeight, m_IsPopupMessageHeightDefault);
			SaveAttribute(element, "ValidationWarningMessage", m_ValidationWarningMessage, m_IsValidationWarningMessageDefault);
			SaveAttribute(element, "ValidationErrorMessage", m_ValidationErrorMessage, m_IsValidationErrorMessageDefault);
			SaveAttribute(element, "SelectionSetFocus", m_SelectionSetFocus, m_IsSelectionSetFocusDefault);
			SaveAttribute(element, "TransactionSetFocus", m_TransactionSetFocus, m_IsTransactionSetFocusDefault);
			SaveAttribute(element, "RequiredNotNullAttribute", m_RequiredNotNullAttribute, m_IsRequiredNotNullAttributeDefault);
			SaveAttribute(element, "RequiredNotNullMessage", m_RequiredNotNullMessage, m_IsRequiredNotNullMessageDefault);
			SaveAttribute(element, "RequiredAfterValidate", m_RequiredAfterValidate, m_IsRequiredAfterValidateDefault);
			SaveAttribute(element, "RuleDate", m_RuleDate, m_IsRuleDateDefault);
			SaveAttribute(element, "ValueRuleDate", m_ValueRuleDate, m_IsValueRuleDateDefault);
			SaveAttribute(element, "RuleDateTime", m_RuleDateTime, m_IsRuleDateTimeDefault);
			SaveAttribute(element, "ValueRuleDateTime", m_ValueRuleDateTime, m_IsValueRuleDateTimeDefault);
			SaveAttribute(element, "PictureCharacterDefault", m_PictureCharacterDefault, m_IsPictureCharacterDefaultDefault);
			SaveAttribute(element, "TabFunction", m_TabFunction, m_IsTabFunctionDefault);
			SaveAttribute(element, "TabDisabledReference", m_TabDisabledReference, m_IsTabDisabledDefault);
			SaveAttribute(element, "ObjectsNamesReference", m_ObjectsNamesReference, m_IsObjectsNamesDefault);
			SaveAttribute(element, "CollumnTextAlign", m_CollumnTextAlign, m_IsCollumnTextAlignDefault);
			SaveAttribute(element, "CollumnAttributeAlign", m_CollumnAttributeAlign, m_IsCollumnAttributeAlignDefault);
			SaveAttribute(element, "PromptImageReference", m_PromptImageReference, m_IsPromptImageDefault);
			SaveAttribute(element, "PromptClass", m_PromptClass, m_IsPromptClassDefault);
			SaveAttribute(element, "PromptSuggestForeignKey", m_PromptSuggestForeignKey, m_IsPromptSuggestForeignKeyDefault);
			SaveAttribute(element, "PromptSuggestNameContains", m_PromptSuggestNameContains, m_IsPromptSuggestNameContainsDefault);
			SaveAttribute(element, "PromptSuggestParmDescription", m_PromptSuggestParmDescription, m_IsPromptSuggestParmDescriptionDefault);
			SaveAttribute(element, "PromptSuggestGridPrimaryKey", m_PromptSuggestGridPrimaryKey, m_IsPromptSuggestGridPrimaryKeyDefault);
			SaveAttribute(element, "SuggestView", m_SuggestView, m_IsSuggestViewDefault);
			SaveAttribute(element, "GenerateViewOnlyBC", m_GenerateViewOnlyBC, m_IsGenerateViewOnlyBCDefault);
			SaveAttribute(element, "BCSucessCode", m_BCSucessCode, m_IsBCSucessCodeDefault);
			SaveAttribute(element, "BCErrorCode", m_BCErrorCode, m_IsBCErrorCodeDefault);
			SaveAttribute(element, "BCPrimaryKeyDelimiter", m_BCPrimaryKeyDelimiter, m_IsBCPrimaryKeyDelimiterDefault);
			SaveAttribute(element, "HideElementIfEdit", m_HideElementIfEdit, m_IsHideElementIfEditDefault);
			SaveAttribute(element, "HideElementName", m_HideElementName, m_IsHideElementNameDefault);
			SaveAttribute(element, "ApplyReturnOnClickAll", m_ApplyReturnOnClickAll, m_IsApplyReturnOnClickAllDefault);
			SaveAttribute(element, "PromptSearchEvent", m_PromptSearchEvent, m_IsPromptSearchEventDefault);
			SaveAttribute(element, "GenerateListPrograms", m_GenerateListPrograms, m_IsGenerateListProgramsDefault);
			SaveAttribute(element, "GenerateCallBackLink", m_GenerateCallBackLink, m_IsGenerateCallBackLinkDefault);

			Debug.Assert(m_UpdateTransaction == element.Attributes.GetPropertyValue<System.String>("UpdateTransaction"));
			Debug.Assert(m_CompatibilidadeVersao == element.Attributes.GetPropertyValue<System.String>("CompatibilidadeVersao"));
			Debug.Assert(m_SelectionIsMain == element.Attributes.GetPropertyValue<System.Boolean>("SelectionIsMain"));
			Debug.Assert(m_TabsForParallelTransactions == element.Attributes.GetPropertyValue<System.Boolean>("TabsForParallelTransactions"));
			Debug.Assert(m_UseTransactionContext == element.Attributes.GetPropertyValue<System.Boolean>("UseTransactionContext"));
			Debug.Assert(m_AfterInsert == element.Attributes.GetPropertyValue<System.String>("AfterInsert"));
			Debug.Assert(m_AfterUpdate == element.Attributes.GetPropertyValue<System.String>("AfterUpdate"));
			Debug.Assert(m_AfterDelete == element.Attributes.GetPropertyValue<System.String>("AfterDelete"));
			Debug.Assert(m_TitleTableClass == element.Attributes.GetPropertyValue<System.String>("TitleTableClass"));
			Debug.Assert(m_TitleTextClass == element.Attributes.GetPropertyValue<System.String>("TitleTextClass"));
			Debug.Assert(m_TitleImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("TitleImageReference"));
			Debug.Assert(m_FilterCollapse == element.Attributes.GetPropertyValue<System.Boolean>("FilterCollapse"));
			Debug.Assert(m_FilterCollapseDefault == element.Attributes.GetPropertyValue<System.Boolean>("FilterCollapseDefault"));
			Debug.Assert(m_TrnTitleTableClass == element.Attributes.GetPropertyValue<System.String>("TrnTitleTableClass"));
			Debug.Assert(m_TrnTitleTextClass == element.Attributes.GetPropertyValue<System.String>("TrnTitleTextClass"));
			Debug.Assert(m_TrnTitleImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("TrnTitleImageReference"));
			Debug.Assert(m_ButtonHelp == element.Attributes.GetPropertyValue<System.Boolean>("ButtonHelp"));
			Debug.Assert(m_ButtonHelpClass == element.Attributes.GetPropertyValue<System.String>("ButtonHelpClass"));
			Debug.Assert(m_ButtonHelpCaption == element.Attributes.GetPropertyValue<System.String>("ButtonHelpCaption"));
			Debug.Assert(m_ButtonHelpApplySelection == element.Attributes.GetPropertyValue<System.Boolean>("ButtonHelpApplySelection"));
			Debug.Assert(m_EventStart == element.Attributes.GetPropertyValue<System.String>("EventStart"));
			Debug.Assert(m_SelectionTemplateReference == element.Attributes.GetPropertyValue<KBObjectReference>("SelectionTemplateReference"));
			Debug.Assert(m_SelectionTemplateDebug == element.Attributes.GetPropertyValue<System.String>("SelectionTemplateDebug"));
			Debug.Assert(m_ViewTemplateReference == element.Attributes.GetPropertyValue<KBObjectReference>("ViewTemplateReference"));
			Debug.Assert(m_ViewTemplateDebug == element.Attributes.GetPropertyValue<System.String>("ViewTemplateDebug"));
			Debug.Assert(m_PromptTemplateReference == element.Attributes.GetPropertyValue<KBObjectReference>("PromptTemplateReference"));
			Debug.Assert(m_PromptTemplateDebug == element.Attributes.GetPropertyValue<System.String>("PromptTemplateDebug"));
			Debug.Assert(m_TransactionTemplateReference == element.Attributes.GetPropertyValue<KBObjectReference>("TransactionTemplateReference"));
			Debug.Assert(m_TransactionTemplateDebug == element.Attributes.GetPropertyValue<System.String>("TransactionTemplateDebug"));
			Debug.Assert(m_DataEntryWebPanelBC == element.Attributes.GetPropertyValue<System.Boolean>("DataEntryWebPanelBC"));
			Debug.Assert(m_LoadSDTWithDataProvider == element.Attributes.GetPropertyValue<System.Boolean>("LoadSDTWithDataProvider"));
			Debug.Assert(m_DisabledTabsIfEditing == element.Attributes.GetPropertyValue<System.Boolean>("DisabledTabsIfEditing"));
			Debug.Assert(m_WebPanelBCDefault == element.Attributes.GetPropertyValue<System.Boolean>("WebPanelBCDefault"));
			Debug.Assert(m_ListNotNullTabGrid == element.Attributes.GetPropertyValue<System.Boolean>("ListNotNullTabGrid"));
			Debug.Assert(m_ListNotNullMessage == element.Attributes.GetPropertyValue<System.String>("ListNotNullMessage"));
			Debug.Assert(m_InferedAttributeInSameBeforeColumn == element.Attributes.GetPropertyValue<System.Boolean>("InferedAttributeInSameBeforeColumn"));
			Debug.Assert(m_SuggestEventIsValidForForeignKey == element.Attributes.GetPropertyValue<System.Boolean>("SuggestEventIsValidForForeignKey"));
			Debug.Assert(m_SuggestMessageNotFoundForeignKey == element.Attributes.GetPropertyValue<System.String>("SuggestMessageNotFoundForeignKey"));
			Debug.Assert(m_PopupMessageReference == element.Attributes.GetPropertyValue<KBObjectReference>("PopupMessageReference"));
			Debug.Assert(m_PopupMessageWidth == element.Attributes.GetPropertyValue<System.Int32>("PopupMessageWidth"));
			Debug.Assert(m_PopupMessageHeight == element.Attributes.GetPropertyValue<System.Int32>("PopupMessageHeight"));
			Debug.Assert(m_ValidationWarningMessage == element.Attributes.GetPropertyValue<System.String>("ValidationWarningMessage"));
			Debug.Assert(m_ValidationErrorMessage == element.Attributes.GetPropertyValue<System.String>("ValidationErrorMessage"));
			Debug.Assert(m_SelectionSetFocus == element.Attributes.GetPropertyValue<System.Boolean>("SelectionSetFocus"));
			Debug.Assert(m_TransactionSetFocus == element.Attributes.GetPropertyValue<System.Boolean>("TransactionSetFocus"));
			Debug.Assert(m_RequiredNotNullAttribute == element.Attributes.GetPropertyValue<System.Boolean>("RequiredNotNullAttribute"));
			Debug.Assert(m_RequiredNotNullMessage == element.Attributes.GetPropertyValue<System.String>("RequiredNotNullMessage"));
			Debug.Assert(m_RequiredAfterValidate == element.Attributes.GetPropertyValue<System.Boolean>("RequiredAfterValidate"));
			Debug.Assert(m_RuleDate == element.Attributes.GetPropertyValue<System.String>("RuleDate"));
			Debug.Assert(m_ValueRuleDate == element.Attributes.GetPropertyValue<System.String>("ValueRuleDate"));
			Debug.Assert(m_RuleDateTime == element.Attributes.GetPropertyValue<System.String>("RuleDateTime"));
			Debug.Assert(m_ValueRuleDateTime == element.Attributes.GetPropertyValue<System.String>("ValueRuleDateTime"));
			Debug.Assert(m_PictureCharacterDefault == element.Attributes.GetPropertyValue<System.String>("PictureCharacterDefault"));
			Debug.Assert(m_TabFunction == element.Attributes.GetPropertyValue<System.String>("TabFunction"));
			Debug.Assert(m_TabDisabledReference == element.Attributes.GetPropertyValue<KBObjectReference>("TabDisabledReference"));
			Debug.Assert(m_ObjectsNamesReference == element.Attributes.GetPropertyValue<KBObjectReference>("ObjectsNamesReference"));
			Debug.Assert(m_CollumnTextAlign == element.Attributes.GetPropertyValue<System.String>("CollumnTextAlign"));
			Debug.Assert(m_CollumnAttributeAlign == element.Attributes.GetPropertyValue<System.String>("CollumnAttributeAlign"));
			Debug.Assert(m_PromptImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("PromptImageReference"));
			Debug.Assert(m_PromptClass == element.Attributes.GetPropertyValue<System.String>("PromptClass"));
			Debug.Assert(m_PromptSuggestForeignKey == element.Attributes.GetPropertyValue<System.Boolean>("PromptSuggestForeignKey"));
			Debug.Assert(m_PromptSuggestNameContains == element.Attributes.GetPropertyValue<System.String>("PromptSuggestNameContains"));
			Debug.Assert(m_PromptSuggestParmDescription == element.Attributes.GetPropertyValue<System.Boolean>("PromptSuggestParmDescription"));
			Debug.Assert(m_PromptSuggestGridPrimaryKey == element.Attributes.GetPropertyValue<System.Boolean>("PromptSuggestGridPrimaryKey"));
			Debug.Assert(m_SuggestView == element.Attributes.GetPropertyValue<System.Boolean>("SuggestView"));
			Debug.Assert(m_GenerateViewOnlyBC == element.Attributes.GetPropertyValue<System.Boolean>("GenerateViewOnlyBC"));
			Debug.Assert(m_BCSucessCode == element.Attributes.GetPropertyValue<System.String>("BCSucessCode"));
			Debug.Assert(m_BCErrorCode == element.Attributes.GetPropertyValue<System.String>("BCErrorCode"));
			Debug.Assert(m_BCPrimaryKeyDelimiter == element.Attributes.GetPropertyValue<System.String>("BCPrimaryKeyDelimiter"));
			Debug.Assert(m_HideElementIfEdit == element.Attributes.GetPropertyValue<System.Boolean>("HideElementIfEdit"));
			Debug.Assert(m_HideElementName == element.Attributes.GetPropertyValue<System.String>("HideElementName"));
			Debug.Assert(m_ApplyReturnOnClickAll == element.Attributes.GetPropertyValue<System.Boolean>("ApplyReturnOnClickAll"));
			Debug.Assert(m_PromptSearchEvent == element.Attributes.GetPropertyValue<System.String>("PromptSearchEvent"));
			Debug.Assert(m_GenerateListPrograms == element.Attributes.GetPropertyValue<System.Boolean>("GenerateListPrograms"));
			Debug.Assert(m_GenerateCallBackLink == element.Attributes.GetPropertyValue<System.Boolean>("GenerateCallBackLink"));

			// Save element children.
			if (m_Suggests != null)
			{
				foreach (SettingsSuggestInstanceElement _item in Suggests)
				{
					PatternInstanceElement suggest = element.Children.AddNewElement("Suggest");
					_item.SaveTo(suggest);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsTemplateElement"/>.
		/// </summary>
		public SettingsTemplateElement Clone()
		{
			SettingsTemplateElement clone = new SettingsTemplateElement();

			clone.UpdateTransaction = this.UpdateTransaction;
			clone.CompatibilidadeVersao = this.CompatibilidadeVersao;
			clone.SelectionIsMain = this.SelectionIsMain;
			clone.TabsForParallelTransactions = this.TabsForParallelTransactions;
			clone.UseTransactionContext = this.UseTransactionContext;
			clone.AfterInsert = this.AfterInsert;
			clone.AfterUpdate = this.AfterUpdate;
			clone.AfterDelete = this.AfterDelete;
			clone.TitleTableClass = this.TitleTableClass;
			clone.TitleTextClass = this.TitleTextClass;
			clone.TitleImage = this.TitleImage;
			clone.FilterCollapse = this.FilterCollapse;
			clone.FilterCollapseDefault = this.FilterCollapseDefault;
			clone.TrnTitleTableClass = this.TrnTitleTableClass;
			clone.TrnTitleTextClass = this.TrnTitleTextClass;
			clone.TrnTitleImage = this.TrnTitleImage;
			clone.ButtonHelp = this.ButtonHelp;
			clone.ButtonHelpClass = this.ButtonHelpClass;
			clone.ButtonHelpCaption = this.ButtonHelpCaption;
			clone.ButtonHelpApplySelection = this.ButtonHelpApplySelection;
			clone.EventStart = this.EventStart;
			clone.SelectionTemplate = this.SelectionTemplate;
			clone.SelectionTemplateDebug = this.SelectionTemplateDebug;
			clone.ViewTemplate = this.ViewTemplate;
			clone.ViewTemplateDebug = this.ViewTemplateDebug;
			clone.PromptTemplate = this.PromptTemplate;
			clone.PromptTemplateDebug = this.PromptTemplateDebug;
			clone.TransactionTemplate = this.TransactionTemplate;
			clone.TransactionTemplateDebug = this.TransactionTemplateDebug;
			clone.DataEntryWebPanelBC = this.DataEntryWebPanelBC;
			clone.LoadSDTWithDataProvider = this.LoadSDTWithDataProvider;
			clone.DisabledTabsIfEditing = this.DisabledTabsIfEditing;
			clone.WebPanelBCDefault = this.WebPanelBCDefault;
			clone.ListNotNullTabGrid = this.ListNotNullTabGrid;
			clone.ListNotNullMessage = this.ListNotNullMessage;
			clone.InferedAttributeInSameBeforeColumn = this.InferedAttributeInSameBeforeColumn;
			clone.SuggestEventIsValidForForeignKey = this.SuggestEventIsValidForForeignKey;
			clone.SuggestMessageNotFoundForeignKey = this.SuggestMessageNotFoundForeignKey;
			clone.PopupMessage = this.PopupMessage;
			clone.PopupMessageWidth = this.PopupMessageWidth;
			clone.PopupMessageHeight = this.PopupMessageHeight;
			clone.ValidationWarningMessage = this.ValidationWarningMessage;
			clone.ValidationErrorMessage = this.ValidationErrorMessage;
			clone.SelectionSetFocus = this.SelectionSetFocus;
			clone.TransactionSetFocus = this.TransactionSetFocus;
			clone.RequiredNotNullAttribute = this.RequiredNotNullAttribute;
			clone.RequiredNotNullMessage = this.RequiredNotNullMessage;
			clone.RequiredAfterValidate = this.RequiredAfterValidate;
			clone.RuleDate = this.RuleDate;
			clone.ValueRuleDate = this.ValueRuleDate;
			clone.RuleDateTime = this.RuleDateTime;
			clone.ValueRuleDateTime = this.ValueRuleDateTime;
			clone.PictureCharacterDefault = this.PictureCharacterDefault;
			clone.TabFunction = this.TabFunction;
			clone.TabDisabled = this.TabDisabled;
			clone.ObjectsNames = this.ObjectsNames;
			clone.CollumnTextAlign = this.CollumnTextAlign;
			clone.CollumnAttributeAlign = this.CollumnAttributeAlign;
			clone.PromptImage = this.PromptImage;
			clone.PromptClass = this.PromptClass;
			clone.PromptSuggestForeignKey = this.PromptSuggestForeignKey;
			clone.PromptSuggestNameContains = this.PromptSuggestNameContains;
			clone.PromptSuggestParmDescription = this.PromptSuggestParmDescription;
			clone.PromptSuggestGridPrimaryKey = this.PromptSuggestGridPrimaryKey;
			clone.SuggestView = this.SuggestView;
			clone.GenerateViewOnlyBC = this.GenerateViewOnlyBC;
			clone.BCSucessCode = this.BCSucessCode;
			clone.BCErrorCode = this.BCErrorCode;
			clone.BCPrimaryKeyDelimiter = this.BCPrimaryKeyDelimiter;
			clone.HideElementIfEdit = this.HideElementIfEdit;
			clone.HideElementName = this.HideElementName;
			clone.ApplyReturnOnClickAll = this.ApplyReturnOnClickAll;
			clone.PromptSearchEvent = this.PromptSearchEvent;
			clone.GenerateListPrograms = this.GenerateListPrograms;
			clone.GenerateCallBackLink = this.GenerateCallBackLink;
			foreach (SettingsSuggestInstanceElement suggestInstanceElement in this.Suggests)
				clone.Suggests.Add(suggestInstanceElement.Clone());

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternSettings.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "Suggest" :
				{
					if (Suggests != null && childIndex >= 0 && childIndex < Suggests.Count)
						return Suggests[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="UpdateTransaction"/> property.
		/// </summary>
		public static class UpdateTransactionValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string OnlyRulesAndEvents = "Only rules and events";
			public const string ApplyWWStyle = "Apply WW Style";
			public const string CreateDefault = "Create default";
		}

		/// <summary>
		/// Possible values for the <see cref="AfterInsert"/> property.
		/// </summary>
		public static class AfterInsertValue
		{
			public const string ReturnToCaller = "Return to Caller";
			public const string GoToView = "Go to View";
			public const string GoToSelection = "Go to Selection";
		}

		/// <summary>
		/// Possible values for the <see cref="AfterUpdate"/> property.
		/// </summary>
		public static class AfterUpdateValue
		{
			public const string ReturnToCaller = "Return to Caller";
			public const string GoToView = "Go to View";
			public const string GoToSelection = "Go to Selection";
		}

		/// <summary>
		/// Possible values for the <see cref="AfterDelete"/> property.
		/// </summary>
		public static class AfterDeleteValue
		{
			public const string ReturnToCaller = "Return to Caller";
			public const string GoToSelection = "Go to Selection";
		}

		/// <summary>
		/// Possible values for the <see cref="RuleDate"/> property.
		/// </summary>
		public static class RuleDateValue
		{
			public const string DefaultRule = "DefaultRule";
			public const string AfterValidate = "AfterValidate";
			public const string AfterInsert = "AfterInsert";
			public const string AfterUpdate = "AfterUpdate";
			public const string AfterDelete = "AfterDelete";
			public const string BeforeValidate = "BeforeValidate";
			public const string BeforeInsert = "BeforeInsert";
			public const string BeforeUpdate = "BeforeUpdate";
			public const string BeforeDelete = "BeforeDelete";
			public const string None = "None";
		}

		/// <summary>
		/// Possible values for the <see cref="RuleDateTime"/> property.
		/// </summary>
		public static class RuleDateTimeValue
		{
			public const string DefaultRule = "DefaultRule";
			public const string AfterValidate = "AfterValidate";
			public const string None = "None";
		}

		/// <summary>
		/// Possible values for the <see cref="TabFunction"/> property.
		/// </summary>
		public static class TabFunctionValue
		{
			public const string DolphinStyleMenu = "DolphinStyleMenu";
			public const string TreeViewAnchor = "TreeViewAnchor";
		}

		/// <summary>
		/// Possible values for the <see cref="CollumnTextAlign"/> property.
		/// </summary>
		public static class CollumnTextAlignValue
		{
			public const string Right = "Right";
			public const string Left = "Left";
			public const string Center = "Center";
		}

		/// <summary>
		/// Possible values for the <see cref="CollumnAttributeAlign"/> property.
		/// </summary>
		public static class CollumnAttributeAlignValue
		{
			public const string Right = "Right";
			public const string Left = "Left";
			public const string Center = "Center";
		}

		/// <summary>
		/// Possible values for the <see cref="PromptSearchEvent"/> property.
		/// </summary>
		public static class PromptSearchEventValue
		{
			public const string Search = "Search";
			public const string Enter = "Enter";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Template";
		}

		#endregion
	}

	#endregion

	#region Element: SuggestInstance

	public partial class SettingsSuggestInstanceElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_IsValid;
		private bool m_IsIsValidDefault;
		private System.String m_Required;
		private bool m_IsRequiredDefault;
		private System.String m_RequiredMessage;
		private bool m_IsRequiredMessageDefault;
		private System.String m_RequiredAfterValidate;
		private bool m_IsRequiredAfterValidateDefault;
		private System.String m_Rule;
		private bool m_IsRuleDefault;
		private System.String m_ValueRule;
		private bool m_IsValueRuleDefault;
		private System.String m_Picture;
		private bool m_IsPictureDefault;
		private System.String m_Readonly;
		private bool m_IsReadonlyDefault;
		private System.String m_Visible;
		private bool m_IsVisibleDefault;
		private System.Boolean m_AttributeInSameBeforeColumn;
		private bool m_IsAttributeInSameBeforeColumnDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private System.String m_EventValidation;
		private bool m_IsEventValidationDefault;
		private System.String m_EventStart;
		private bool m_IsEventStartDefault;
		private System.String m_MaskPicture;
		private bool m_IsMaskPictureDefault;
		private System.Boolean m_Reverse;
		private bool m_IsReverseDefault;
		private System.Boolean m_Signed;
		private bool m_IsSignedDefault;
		private System.String m_UnmaskedChars;
		private bool m_IsUnmaskedCharsDefault;
		private System.Boolean m_UnmaskedValue;
		private bool m_IsUnmaskedValueDefault;
		private Artech.Common.Collections.BaseCollection<SettingsAttributeDefinitionElement> m_AttributeDefinitions;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsSuggestInstanceElement"/> class.
		/// </summary>
		public SettingsSuggestInstanceElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsSuggestInstanceElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_IsValid = "";
			m_IsIsValidDefault = true;
			m_Required = "none";
			m_IsRequiredDefault = true;
			m_RequiredMessage = "default";
			m_IsRequiredMessageDefault = true;
			m_RequiredAfterValidate = "none";
			m_IsRequiredAfterValidateDefault = true;
			m_Rule = "None";
			m_IsRuleDefault = true;
			m_ValueRule = "<default>";
			m_IsValueRuleDefault = true;
			m_Picture = "none";
			m_IsPictureDefault = true;
			m_Readonly = "none";
			m_IsReadonlyDefault = true;
			m_Visible = "none";
			m_IsVisibleDefault = true;
			m_AttributeInSameBeforeColumn = false;
			m_IsAttributeInSameBeforeColumnDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_EventValidation = "";
			m_IsEventValidationDefault = true;
			m_EventStart = "";
			m_IsEventStartDefault = true;
			m_MaskPicture = "";
			m_IsMaskPictureDefault = true;
			m_Reverse = false;
			m_IsReverseDefault = true;
			m_Signed = false;
			m_IsSignedDefault = true;
			m_UnmaskedChars = "[().:/ -]";
			m_IsUnmaskedCharsDefault = true;
			m_UnmaskedValue = false;
			m_IsUnmaskedValueDefault = true;
			m_AttributeDefinitions = new Artech.Common.Collections.BaseCollection<SettingsAttributeDefinitionElement>();
			m_AttributeDefinitions.ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsAttributeDefinitionElement>>(AttributeDefinitions_ItemAdded);
		}

		#endregion

		#region Properties

		private SettingsTemplateElement m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsSuggestInstanceElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public SettingsTemplateElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Evento IsValid para Atributo ou variável
		*/
		/// </summary>
		public System.String IsValid
		{
			get { return m_IsValid; }
			set 
			{
				m_IsValid = value;
				m_IsIsValidDefault = false;
			}
		}

		/// <summary>
		/*
		Define como obrigatório atributo
		*/
		/// </summary>
		public System.String Required
		{
			get { return m_Required; }
			set 
			{
				m_Required = value;
				m_IsRequiredDefault = false;
			}
		}

		/// <summary>
		/*
		Define mensagem padrão para atributo obrigatório, Coringda {0} é a descrição do atributo
		*/
		/// </summary>
		public System.String RequiredMessage
		{
			get { return m_RequiredMessage; }
			set 
			{
				m_RequiredMessage = value;
				m_IsRequiredMessageDefault = false;
			}
		}

		/// <summary>
		/*
		Define se aplica a regra error no AfterValidate ou não
		*/
		/// </summary>
		public System.String RequiredAfterValidate
		{
			get { return m_RequiredAfterValidate; }
			set 
			{
				m_RequiredAfterValidate = value;
				m_IsRequiredAfterValidateDefault = false;
			}
		}

		/// <summary>
		/*
		Define regra para atributo
		*/
		/// </summary>
		public System.String Rule
		{
			get { return m_Rule; }
			set 
			{
				m_Rule = value;
				m_IsRuleDefault = false;
			}
		}

		/// <summary>
		/*
		Define valor da regra para atributo
		*/
		/// </summary>
		public System.String ValueRule
		{
			get { return m_ValueRule; }
			set 
			{
				m_ValueRule = value;
				m_IsValueRuleDefault = false;
			}
		}

		/// <summary>
		/*
		Define a picture para o atributo
		*/
		/// </summary>
		public System.String Picture
		{
			get { return m_Picture; }
			set 
			{
				m_Picture = value;
				m_IsPictureDefault = false;
			}
		}

		/// <summary>
		/*
		Define se é ReadOnly
		*/
		/// </summary>
		public System.String Readonly
		{
			get { return m_Readonly; }
			set 
			{
				m_Readonly = value;
				m_IsReadonlyDefault = false;
			}
		}

		/// <summary>
		/*
		Attribute is visible
		*/
		/// </summary>
		public System.String Visible
		{
			get { return m_Visible; }
			set 
			{
				m_Visible = value;
				m_IsVisibleDefault = false;
			}
		}

		/// <summary>
		/*
		Coloca atributo na mesma coluna do atributo anterior
		*/
		/// </summary>
		public System.Boolean AttributeInSameBeforeColumn
		{
			get { return m_AttributeInSameBeforeColumn; }
			set 
			{
				m_AttributeInSameBeforeColumn = value;
				m_IsAttributeInSameBeforeColumnDefault = false;
			}
		}

		/// <summary>
		/*
		Attribute description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Define código de Evento que será utilizado para validação do Atributo, Coringa {0} define o nome do atributo com SDT
		*/
		/// </summary>
		public System.String EventValidation
		{
			get { return m_EventValidation; }
			set 
			{
				m_EventValidation = value;
				m_IsEventValidationDefault = false;
			}
		}

		/// <summary>
		/*
		Define código para o Evento Start, coringa {0} define o valor e {1} define o controle em tela
		*/
		/// </summary>
		public System.String EventStart
		{
			get { return m_EventStart; }
			set 
			{
				m_EventStart = value;
				m_IsEventStartDefault = false;
			}
		}

		/// <summary>
		/*
		Define a Picture
		*/
		/// </summary>
		public System.String MaskPicture
		{
			get { return m_MaskPicture; }
			set 
			{
				m_MaskPicture = value;
				m_IsMaskPictureDefault = false;
			}
		}

		/// <summary>
		/*
		Define se a digitação será invertida
		*/
		/// </summary>
		public System.Boolean Reverse
		{
			get { return m_Reverse; }
			set 
			{
				m_Reverse = value;
				m_IsReverseDefault = false;
			}
		}

		/// <summary>
		/*
		Define se permite valor negativo
		*/
		/// </summary>
		public System.Boolean Signed
		{
			get { return m_Signed; }
			set 
			{
				m_Signed = value;
				m_IsSignedDefault = false;
			}
		}

		/// <summary>
		/*
		Define os caracteres que serão retirados quando retorna valor sem a mascara
		*/
		/// </summary>
		public System.String UnmaskedChars
		{
			get { return m_UnmaskedChars; }
			set 
			{
				m_UnmaskedChars = value;
				m_IsUnmaskedCharsDefault = false;
			}
		}

		/// <summary>
		/*
		Define se retorna o valor sem a mascara ou não
		*/
		/// </summary>
		public System.Boolean UnmaskedValue
		{
			get { return m_UnmaskedValue; }
			set 
			{
				m_UnmaskedValue = value;
				m_IsUnmaskedValueDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<SettingsAttributeDefinitionElement> AttributeDefinitions
		{
			get { return m_AttributeDefinitions; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="SettingsAttributeDefinitionElement"/> and adds it to the <see cref="AttributeDefinitions"/> collection.
		/// </summary>
		public SettingsAttributeDefinitionElement AddAttributeDefinition()
		{
			SettingsAttributeDefinitionElement attributeDefinitionElement = new SettingsAttributeDefinitionElement();
			m_AttributeDefinitions.Add(attributeDefinitionElement);
			return attributeDefinitionElement;
		}

		private void AttributeDefinitions_ItemAdded(object sender, CollectionItemEventArgs<SettingsAttributeDefinitionElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsSuggestInstanceElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "SuggestInstance")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "SuggestInstance"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_IsValid = element.Attributes.GetPropertyValue<System.String>("IsValid");
			m_IsIsValidDefault = element.Attributes.IsPropertyDefault("IsValid");
			m_Required = element.Attributes.GetPropertyValue<System.String>("Required");
			m_IsRequiredDefault = element.Attributes.IsPropertyDefault("Required");
			m_RequiredMessage = element.Attributes.GetPropertyValue<System.String>("RequiredMessage");
			m_IsRequiredMessageDefault = element.Attributes.IsPropertyDefault("RequiredMessage");
			m_RequiredAfterValidate = element.Attributes.GetPropertyValue<System.String>("RequiredAfterValidate");
			m_IsRequiredAfterValidateDefault = element.Attributes.IsPropertyDefault("RequiredAfterValidate");
			m_Rule = element.Attributes.GetPropertyValue<System.String>("Rule");
			m_IsRuleDefault = element.Attributes.IsPropertyDefault("Rule");
			m_ValueRule = element.Attributes.GetPropertyValue<System.String>("ValueRule");
			m_IsValueRuleDefault = element.Attributes.IsPropertyDefault("ValueRule");
			m_Picture = element.Attributes.GetPropertyValue<System.String>("Picture");
			m_IsPictureDefault = element.Attributes.IsPropertyDefault("Picture");
			m_Readonly = element.Attributes.GetPropertyValue<System.String>("Readonly");
			m_IsReadonlyDefault = element.Attributes.IsPropertyDefault("Readonly");
			m_Visible = element.Attributes.GetPropertyValue<System.String>("Visible");
			m_IsVisibleDefault = element.Attributes.IsPropertyDefault("Visible");
			m_AttributeInSameBeforeColumn = element.Attributes.GetPropertyValue<System.Boolean>("AttributeInSameBeforeColumn");
			m_IsAttributeInSameBeforeColumnDefault = element.Attributes.IsPropertyDefault("AttributeInSameBeforeColumn");
			m_Description = element.Attributes.GetPropertyValue<System.String>("Description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("Description");
			m_EventValidation = element.Attributes.GetPropertyValue<System.String>("EventValidation");
			m_IsEventValidationDefault = element.Attributes.IsPropertyDefault("EventValidation");
			m_EventStart = element.Attributes.GetPropertyValue<System.String>("EventStart");
			m_IsEventStartDefault = element.Attributes.IsPropertyDefault("EventStart");
			m_MaskPicture = element.Attributes.GetPropertyValue<System.String>("MaskPicture");
			m_IsMaskPictureDefault = element.Attributes.IsPropertyDefault("MaskPicture");
			m_Reverse = element.Attributes.GetPropertyValue<System.Boolean>("Reverse");
			m_IsReverseDefault = element.Attributes.IsPropertyDefault("Reverse");
			m_Signed = element.Attributes.GetPropertyValue<System.Boolean>("Signed");
			m_IsSignedDefault = element.Attributes.IsPropertyDefault("Signed");
			m_UnmaskedChars = element.Attributes.GetPropertyValue<System.String>("UnmaskedChars");
			m_IsUnmaskedCharsDefault = element.Attributes.IsPropertyDefault("UnmaskedChars");
			m_UnmaskedValue = element.Attributes.GetPropertyValue<System.Boolean>("UnmaskedValue");
			m_IsUnmaskedValueDefault = element.Attributes.IsPropertyDefault("UnmaskedValue");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "AttributeDefinition" :
					{
						SettingsAttributeDefinitionElement attributeDefinition = new SettingsAttributeDefinitionElement();
						attributeDefinition.LoadFrom(_childElement);
						AttributeDefinitions.Add(attributeDefinition);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="SettingsSuggestInstanceElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "SuggestInstance")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "SuggestInstance"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "IsValid", m_IsValid, m_IsIsValidDefault);
			SaveAttribute(element, "Required", m_Required, m_IsRequiredDefault);
			SaveAttribute(element, "RequiredMessage", m_RequiredMessage, m_IsRequiredMessageDefault);
			SaveAttribute(element, "RequiredAfterValidate", m_RequiredAfterValidate, m_IsRequiredAfterValidateDefault);
			SaveAttribute(element, "Rule", m_Rule, m_IsRuleDefault);
			SaveAttribute(element, "ValueRule", m_ValueRule, m_IsValueRuleDefault);
			SaveAttribute(element, "Picture", m_Picture, m_IsPictureDefault);
			SaveAttribute(element, "Readonly", m_Readonly, m_IsReadonlyDefault);
			SaveAttribute(element, "Visible", m_Visible, m_IsVisibleDefault);
			SaveAttribute(element, "AttributeInSameBeforeColumn", m_AttributeInSameBeforeColumn, m_IsAttributeInSameBeforeColumnDefault);
			SaveAttribute(element, "Description", m_Description, m_IsDescriptionDefault);
			SaveAttribute(element, "EventValidation", m_EventValidation, m_IsEventValidationDefault);
			SaveAttribute(element, "EventStart", m_EventStart, m_IsEventStartDefault);
			SaveAttribute(element, "MaskPicture", m_MaskPicture, m_IsMaskPictureDefault);
			SaveAttribute(element, "Reverse", m_Reverse, m_IsReverseDefault);
			SaveAttribute(element, "Signed", m_Signed, m_IsSignedDefault);
			SaveAttribute(element, "UnmaskedChars", m_UnmaskedChars, m_IsUnmaskedCharsDefault);
			SaveAttribute(element, "UnmaskedValue", m_UnmaskedValue, m_IsUnmaskedValueDefault);

			Debug.Assert(m_IsValid == element.Attributes.GetPropertyValue<System.String>("IsValid"));
			Debug.Assert(m_Required == element.Attributes.GetPropertyValue<System.String>("Required"));
			Debug.Assert(m_RequiredMessage == element.Attributes.GetPropertyValue<System.String>("RequiredMessage"));
			Debug.Assert(m_RequiredAfterValidate == element.Attributes.GetPropertyValue<System.String>("RequiredAfterValidate"));
			Debug.Assert(m_Rule == element.Attributes.GetPropertyValue<System.String>("Rule"));
			Debug.Assert(m_ValueRule == element.Attributes.GetPropertyValue<System.String>("ValueRule"));
			Debug.Assert(m_Picture == element.Attributes.GetPropertyValue<System.String>("Picture"));
			Debug.Assert(m_Readonly == element.Attributes.GetPropertyValue<System.String>("Readonly"));
			Debug.Assert(m_Visible == element.Attributes.GetPropertyValue<System.String>("Visible"));
			Debug.Assert(m_AttributeInSameBeforeColumn == element.Attributes.GetPropertyValue<System.Boolean>("AttributeInSameBeforeColumn"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("Description"));
			Debug.Assert(m_EventValidation == element.Attributes.GetPropertyValue<System.String>("EventValidation"));
			Debug.Assert(m_EventStart == element.Attributes.GetPropertyValue<System.String>("EventStart"));
			Debug.Assert(m_MaskPicture == element.Attributes.GetPropertyValue<System.String>("MaskPicture"));
			Debug.Assert(m_Reverse == element.Attributes.GetPropertyValue<System.Boolean>("Reverse"));
			Debug.Assert(m_Signed == element.Attributes.GetPropertyValue<System.Boolean>("Signed"));
			Debug.Assert(m_UnmaskedChars == element.Attributes.GetPropertyValue<System.String>("UnmaskedChars"));
			Debug.Assert(m_UnmaskedValue == element.Attributes.GetPropertyValue<System.Boolean>("UnmaskedValue"));

			// Save element children.
			if (m_AttributeDefinitions != null)
			{
				foreach (SettingsAttributeDefinitionElement _item in AttributeDefinitions)
				{
					PatternInstanceElement attributeDefinition = element.Children.AddNewElement("AttributeDefinition");
					_item.SaveTo(attributeDefinition);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsSuggestInstanceElement"/>.
		/// </summary>
		public SettingsSuggestInstanceElement Clone()
		{
			SettingsSuggestInstanceElement clone = new SettingsSuggestInstanceElement();

			clone.IsValid = this.IsValid;
			clone.Required = this.Required;
			clone.RequiredMessage = this.RequiredMessage;
			clone.RequiredAfterValidate = this.RequiredAfterValidate;
			clone.Rule = this.Rule;
			clone.ValueRule = this.ValueRule;
			clone.Picture = this.Picture;
			clone.Readonly = this.Readonly;
			clone.Visible = this.Visible;
			clone.AttributeInSameBeforeColumn = this.AttributeInSameBeforeColumn;
			clone.Description = this.Description;
			clone.EventValidation = this.EventValidation;
			clone.EventStart = this.EventStart;
			clone.MaskPicture = this.MaskPicture;
			clone.Reverse = this.Reverse;
			clone.Signed = this.Signed;
			clone.UnmaskedChars = this.UnmaskedChars;
			clone.UnmaskedValue = this.UnmaskedValue;
			foreach (SettingsAttributeDefinitionElement attributeDefinitionElement in this.AttributeDefinitions)
				clone.AttributeDefinitions.Add(attributeDefinitionElement.Clone());

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternSettings.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "AttributeDefinition" :
				{
					if (AttributeDefinitions != null && childIndex >= 0 && childIndex < AttributeDefinitions.Count)
						return AttributeDefinitions[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Required"/> property.
		/// </summary>
		public static class RequiredValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string None = "none";
		}

		/// <summary>
		/// Possible values for the <see cref="RequiredAfterValidate"/> property.
		/// </summary>
		public static class RequiredAfterValidateValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string None = "none";
		}

		/// <summary>
		/// Possible values for the <see cref="Rule"/> property.
		/// </summary>
		public static class RuleValue
		{
			public const string DefaultRule = "DefaultRule";
			public const string AfterValidate = "AfterValidate";
			public const string None = "None";
		}

		/// <summary>
		/// Possible values for the <see cref="Picture"/> property.
		/// </summary>
		public static class PictureValue
		{
			public const string None = "none";
		}

		/// <summary>
		/// Possible values for the <see cref="Readonly"/> property.
		/// </summary>
		public static class ReadonlyValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string None = "none";
		}

		/// <summary>
		/// Possible values for the <see cref="Visible"/> property.
		/// </summary>
		public static class VisibleValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string None = "none";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Suggest";
		}

		#endregion
	}

	#endregion

	#region Element: AttributeDefinition

	public partial class SettingsAttributeDefinitionElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.Boolean m_TypeCharacter;
		private bool m_IsTypeCharacterDefault;
		private System.Boolean m_TypeNumeric;
		private bool m_IsTypeNumericDefault;
		private System.Boolean m_TypeData;
		private bool m_IsTypeDataDefault;
		private System.Boolean m_TypeAll;
		private bool m_IsTypeAllDefault;
		private System.Int32 m_TypeSize;
		private bool m_IsTypeSizeDefault;
		private System.Int32 m_TypeDecimal;
		private bool m_IsTypeDecimalDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsAttributeDefinitionElement"/> class.
		/// </summary>
		public SettingsAttributeDefinitionElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsAttributeDefinitionElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_TypeCharacter = false;
			m_IsTypeCharacterDefault = true;
			m_TypeNumeric = false;
			m_IsTypeNumericDefault = true;
			m_TypeData = false;
			m_IsTypeDataDefault = true;
			m_TypeAll = true;
			m_IsTypeAllDefault = true;
			m_TypeSize = 0;
			m_IsTypeSizeDefault = true;
			m_TypeDecimal = 0;
			m_IsTypeDecimalDefault = true;
		}

		#endregion

		#region Properties

		private SettingsSuggestInstanceElement m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsAttributeDefinitionElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public SettingsSuggestInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Parte do nome do atributo que identifica o atributo
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica a Atributo Character
		*/
		/// </summary>
		public System.Boolean TypeCharacter
		{
			get { return m_TypeCharacter; }
			set 
			{
				m_TypeCharacter = value;
				m_IsTypeCharacterDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica a Atributo Numeric
		*/
		/// </summary>
		public System.Boolean TypeNumeric
		{
			get { return m_TypeNumeric; }
			set 
			{
				m_TypeNumeric = value;
				m_IsTypeNumericDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica a Atributo Data
		*/
		/// </summary>
		public System.Boolean TypeData
		{
			get { return m_TypeData; }
			set 
			{
				m_TypeData = value;
				m_IsTypeDataDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica a Atributo a qualquer tipo
		*/
		/// </summary>
		public System.Boolean TypeAll
		{
			get { return m_TypeAll; }
			set 
			{
				m_TypeAll = value;
				m_IsTypeAllDefault = false;
			}
		}

		/// <summary>
		/*
		Aplca a Atributo com o tamanho
		*/
		/// </summary>
		public System.Int32 TypeSize
		{
			get { return m_TypeSize; }
			set 
			{
				m_TypeSize = value;
				m_IsTypeSizeDefault = false;
			}
		}

		/// <summary>
		/*
		Aplca a Atributo com o Decimal
		*/
		/// </summary>
		public System.Int32 TypeDecimal
		{
			get { return m_TypeDecimal; }
			set 
			{
				m_TypeDecimal = value;
				m_IsTypeDecimalDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsAttributeDefinitionElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "AttributeDefinition")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "AttributeDefinition"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_TypeCharacter = element.Attributes.GetPropertyValue<System.Boolean>("typeCharacter");
			m_IsTypeCharacterDefault = element.Attributes.IsPropertyDefault("typeCharacter");
			m_TypeNumeric = element.Attributes.GetPropertyValue<System.Boolean>("typeNumeric");
			m_IsTypeNumericDefault = element.Attributes.IsPropertyDefault("typeNumeric");
			m_TypeData = element.Attributes.GetPropertyValue<System.Boolean>("typeData");
			m_IsTypeDataDefault = element.Attributes.IsPropertyDefault("typeData");
			m_TypeAll = element.Attributes.GetPropertyValue<System.Boolean>("typeAll");
			m_IsTypeAllDefault = element.Attributes.IsPropertyDefault("typeAll");
			m_TypeSize = element.Attributes.GetPropertyValue<System.Int32>("typeSize");
			m_IsTypeSizeDefault = element.Attributes.IsPropertyDefault("typeSize");
			m_TypeDecimal = element.Attributes.GetPropertyValue<System.Int32>("typeDecimal");
			m_IsTypeDecimalDefault = element.Attributes.IsPropertyDefault("typeDecimal");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsAttributeDefinitionElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "AttributeDefinition")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "AttributeDefinition"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "typeCharacter", m_TypeCharacter, m_IsTypeCharacterDefault);
			SaveAttribute(element, "typeNumeric", m_TypeNumeric, m_IsTypeNumericDefault);
			SaveAttribute(element, "typeData", m_TypeData, m_IsTypeDataDefault);
			SaveAttribute(element, "typeAll", m_TypeAll, m_IsTypeAllDefault);
			SaveAttribute(element, "typeSize", m_TypeSize, m_IsTypeSizeDefault);
			SaveAttribute(element, "typeDecimal", m_TypeDecimal, m_IsTypeDecimalDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_TypeCharacter == element.Attributes.GetPropertyValue<System.Boolean>("typeCharacter"));
			Debug.Assert(m_TypeNumeric == element.Attributes.GetPropertyValue<System.Boolean>("typeNumeric"));
			Debug.Assert(m_TypeData == element.Attributes.GetPropertyValue<System.Boolean>("typeData"));
			Debug.Assert(m_TypeAll == element.Attributes.GetPropertyValue<System.Boolean>("typeAll"));
			Debug.Assert(m_TypeSize == element.Attributes.GetPropertyValue<System.Int32>("typeSize"));
			Debug.Assert(m_TypeDecimal == element.Attributes.GetPropertyValue<System.Int32>("typeDecimal"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsAttributeDefinitionElement"/>.
		/// </summary>
		public SettingsAttributeDefinitionElement Clone()
		{
			SettingsAttributeDefinitionElement clone = new SettingsAttributeDefinitionElement();

			clone.Name = this.Name;
			clone.TypeCharacter = this.TypeCharacter;
			clone.TypeNumeric = this.TypeNumeric;
			clone.TypeData = this.TypeData;
			clone.TypeAll = this.TypeAll;
			clone.TypeSize = this.TypeSize;
			clone.TypeDecimal = this.TypeDecimal;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: Objects

	public partial class SettingsObjectsElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_View;
		private bool m_IsViewDefault;
		private System.String m_Selection;
		private bool m_IsSelectionDefault;
		private System.String m_Controller;
		private bool m_IsControllerDefault;
		private System.String m_Tabular;
		private bool m_IsTabularDefault;
		private System.String m_Export;
		private bool m_IsExportDefault;
		private System.String m_Prompt;
		private bool m_IsPromptDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsObjectsElement"/> class.
		/// </summary>
		public SettingsObjectsElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsObjectsElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_View = "View<Object>";
			m_IsViewDefault = true;
			m_Selection = "WW<Object>";
			m_IsSelectionDefault = true;
			m_Controller = "Controller<Object>";
			m_IsControllerDefault = true;
			m_Tabular = "<Object>General";
			m_IsTabularDefault = true;
			m_Export = "Export<Object>";
			m_IsExportDefault = true;
			m_Prompt = "Prompt<Object>";
			m_IsPromptDefault = true;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsObjectsElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Naming for view objects.
		*/
		/// </summary>
		public System.String View
		{
			get { return m_View; }
			set 
			{
				m_View = value;
				m_IsViewDefault = false;
			}
		}

		/// <summary>
		/*
		Naming for selection (work with) objects.
		*/
		/// </summary>
		public System.String Selection
		{
			get { return m_Selection; }
			set 
			{
				m_Selection = value;
				m_IsSelectionDefault = false;
			}
		}

		/// <summary>
		/*
		Naming for controller objects.
		*/
		/// </summary>
		public System.String Controller
		{
			get { return m_Controller; }
			set 
			{
				m_Controller = value;
				m_IsControllerDefault = false;
			}
		}

		/// <summary>
		/*
		Naming for tabular (general tab) objects.
		*/
		/// </summary>
		public System.String Tabular
		{
			get { return m_Tabular; }
			set 
			{
				m_Tabular = value;
				m_IsTabularDefault = false;
			}
		}

		/// <summary>
		/*
		Naming for Export procedures.
		*/
		/// </summary>
		public System.String Export
		{
			get { return m_Export; }
			set 
			{
				m_Export = value;
				m_IsExportDefault = false;
			}
		}

		/// <summary>
		/*
		Naming for prompt objects.
		*/
		/// </summary>
		public System.String Prompt
		{
			get { return m_Prompt; }
			set 
			{
				m_Prompt = value;
				m_IsPromptDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsObjectsElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Objects")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Objects"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_View = element.Attributes.GetPropertyValue<System.String>("View");
			m_IsViewDefault = element.Attributes.IsPropertyDefault("View");
			m_Selection = element.Attributes.GetPropertyValue<System.String>("Selection");
			m_IsSelectionDefault = element.Attributes.IsPropertyDefault("Selection");
			m_Controller = element.Attributes.GetPropertyValue<System.String>("Controller");
			m_IsControllerDefault = element.Attributes.IsPropertyDefault("Controller");
			m_Tabular = element.Attributes.GetPropertyValue<System.String>("Tabular");
			m_IsTabularDefault = element.Attributes.IsPropertyDefault("Tabular");
			m_Export = element.Attributes.GetPropertyValue<System.String>("Export");
			m_IsExportDefault = element.Attributes.IsPropertyDefault("Export");
			m_Prompt = element.Attributes.GetPropertyValue<System.String>("Prompt");
			m_IsPromptDefault = element.Attributes.IsPropertyDefault("Prompt");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsObjectsElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Objects")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Objects"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "View", m_View, m_IsViewDefault);
			SaveAttribute(element, "Selection", m_Selection, m_IsSelectionDefault);
			SaveAttribute(element, "Controller", m_Controller, m_IsControllerDefault);
			SaveAttribute(element, "Tabular", m_Tabular, m_IsTabularDefault);
			SaveAttribute(element, "Export", m_Export, m_IsExportDefault);
			SaveAttribute(element, "Prompt", m_Prompt, m_IsPromptDefault);

			Debug.Assert(m_View == element.Attributes.GetPropertyValue<System.String>("View"));
			Debug.Assert(m_Selection == element.Attributes.GetPropertyValue<System.String>("Selection"));
			Debug.Assert(m_Controller == element.Attributes.GetPropertyValue<System.String>("Controller"));
			Debug.Assert(m_Tabular == element.Attributes.GetPropertyValue<System.String>("Tabular"));
			Debug.Assert(m_Export == element.Attributes.GetPropertyValue<System.String>("Export"));
			Debug.Assert(m_Prompt == element.Attributes.GetPropertyValue<System.String>("Prompt"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsObjectsElement"/>.
		/// </summary>
		public SettingsObjectsElement Clone()
		{
			SettingsObjectsElement clone = new SettingsObjectsElement();

			clone.View = this.View;
			clone.Selection = this.Selection;
			clone.Controller = this.Controller;
			clone.Tabular = this.Tabular;
			clone.Export = this.Export;
			clone.Prompt = this.Prompt;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Objects";
		}

		#endregion
	}

	#endregion

	#region Element: Theme

	public partial class SettingsThemeElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private Artech.Genexus.Common.Objects.Theme m_Theme;
		private KBObjectReference m_ThemeReference;
		private string m_ThemeName;
		private bool m_IsThemeDefault;
		private System.String m_SetObjectTheme;
		private bool m_IsSetObjectThemeDefault;
		private System.String m_Button;
		private bool m_IsButtonDefault;
		private System.String m_BtnEnter;
		private bool m_IsBtnEnterDefault;
		private System.String m_BtnCancel;
		private bool m_IsBtnCancelDefault;
		private System.String m_SearchButton;
		private bool m_IsSearchButtonDefault;
		private System.String m_ClearButton;
		private bool m_IsClearButtonDefault;
		private System.String m_Image;
		private bool m_IsImageDefault;
		private System.String m_Subtitle;
		private bool m_IsSubtitleDefault;
		private System.String m_TextToLink;
		private bool m_IsTextToLinkDefault;
		private System.String m_PlainText;
		private bool m_IsPlainTextDefault;
		private System.String m_PlainTextEmpty;
		private bool m_IsPlainTextEmptyDefault;
		private System.String m_Label;
		private bool m_IsLabelDefault;
		private System.String m_ViewTable;
		private bool m_IsViewTableDefault;
		private System.String m_Grid;
		private bool m_IsGridDefault;
		private System.String m_Table100;
		private bool m_IsTable100Default;
		private System.String m_Separator;
		private bool m_IsSeparatorDefault;
		private System.String m_ReadonlyAttribute;
		private bool m_IsReadonlyAttributeDefault;
		private System.String m_ReadonlyGridAttribute;
		private bool m_IsReadonlyGridAttributeDefault;
		private System.String m_ReadonlyBlobAttribute;
		private bool m_IsReadonlyBlobAttributeDefault;
		private System.String m_ReadonlyGridBlobAttribute;
		private bool m_IsReadonlyGridBlobAttributeDefault;
		private System.String m_TabTable;
		private bool m_IsTabTableDefault;
		private System.String m_AttributeKey;
		private bool m_IsAttributeKeyDefault;
		private System.String m_LabelKey;
		private bool m_IsLabelKeyDefault;
		private System.String m_Group;
		private bool m_IsGroupDefault;
		private System.String m_FilterCollapse;
		private bool m_IsFilterCollapseDefault;
		private System.String m_FilterExpand;
		private bool m_IsFilterExpandDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsThemeElement"/> class.
		/// </summary>
		public SettingsThemeElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsThemeElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Theme = null;
			m_ThemeReference = null;
			m_ThemeName = null;
			m_IsThemeDefault = true;
			m_SetObjectTheme = "false";
			m_IsSetObjectThemeDefault = true;
			m_Button = "ActionButtons";
			m_IsButtonDefault = true;
			m_BtnEnter = "BtnEnter";
			m_IsBtnEnterDefault = true;
			m_BtnCancel = "BtnCancel";
			m_IsBtnCancelDefault = true;
			m_SearchButton = "ActionButtons";
			m_IsSearchButtonDefault = true;
			m_ClearButton = "ActionButtons";
			m_IsClearButtonDefault = true;
			m_Image = "PagingButtons";
			m_IsImageDefault = true;
			m_Subtitle = "SubTitle";
			m_IsSubtitleDefault = true;
			m_TextToLink = "TextBlock";
			m_IsTextToLinkDefault = true;
			m_PlainText = "TextBlock";
			m_IsPlainTextDefault = true;
			m_PlainTextEmpty = "TextBlock";
			m_IsPlainTextEmptyDefault = true;
			m_Label = "Label";
			m_IsLabelDefault = true;
			m_ViewTable = "ViewTable";
			m_IsViewTableDefault = true;
			m_Grid = "WorkWith";
			m_IsGridDefault = true;
			m_Table100 = "Table100x100";
			m_IsTable100Default = true;
			m_Separator = "Separator";
			m_IsSeparatorDefault = true;
			m_ReadonlyAttribute = "ReadonlyAttribute";
			m_IsReadonlyAttributeDefault = true;
			m_ReadonlyGridAttribute = null;
			m_IsReadonlyGridAttributeDefault = true;
			m_ReadonlyBlobAttribute = "ReadonlyAttribute";
			m_IsReadonlyBlobAttributeDefault = true;
			m_ReadonlyGridBlobAttribute = null;
			m_IsReadonlyGridBlobAttributeDefault = true;
			m_TabTable = "Table";
			m_IsTabTableDefault = true;
			m_AttributeKey = null;
			m_IsAttributeKeyDefault = true;
			m_LabelKey = null;
			m_IsLabelKeyDefault = true;
			m_Group = "Group";
			m_IsGroupDefault = true;
			m_FilterCollapse = "FilterOff";
			m_IsFilterCollapseDefault = true;
			m_FilterExpand = "FilterOn";
			m_IsFilterExpandDefault = true;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsThemeElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Selecionar um objeto Tema (somente ativo).
		/// Caso não seja selecionado, o tema padrão da KB será utilizado.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Theme Theme
		{
			get
			{
				if (m_Theme == null && m_ThemeReference != null)
					m_Theme = (Artech.Genexus.Common.Objects.Theme)m_ThemeReference.GetKBObject(Settings.Model);

				return m_Theme;
			}

			set 
			{
				m_Theme = value;
				m_ThemeReference = (value != null ? new KBObjectReference(value) : null);
				m_ThemeName = (value != null ? value.Name : null);
				m_IsThemeDefault = false;
			}
		}

		/// <summary>
		/// Theme name.
		/// </summary>
		public string ThemeName
		{
			get
			{
				if (m_ThemeName == null && m_ThemeReference != null)
					m_ThemeName = m_ThemeReference.GetName(Settings.Model);

				return m_ThemeName;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE, FALSE ou FORCE.
		/// Definir o tema especificado como o tema escolhido para cada objeto gerado. Se valor for FALSE, o tema padrão da KB será utilizado.
		*/
		/// </summary>
		public System.String SetObjectTheme
		{
			get { return m_SetObjectTheme; }
			set 
			{
				m_SetObjectTheme = value;
				m_IsSetObjectThemeDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Button.
		/// Utilizá-la nos botões.
		*/
		/// </summary>
		public System.String Button
		{
			get { return m_Button; }
			set 
			{
				m_Button = value;
				m_IsButtonDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Button.
		/// Botão Confirmar.
		*/
		/// </summary>
		public System.String BtnEnter
		{
			get { return m_BtnEnter; }
			set 
			{
				m_BtnEnter = value;
				m_IsBtnEnterDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Button.
		/// Botão Cancelar/Fechar.
		*/
		/// </summary>
		public System.String BtnCancel
		{
			get { return m_BtnCancel; }
			set 
			{
				m_BtnCancel = value;
				m_IsBtnCancelDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Button.
		/// Botão Pesquisar.
		*/
		/// </summary>
		public System.String SearchButton
		{
			get { return m_SearchButton; }
			set 
			{
				m_SearchButton = value;
				m_IsSearchButtonDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Button.
		/// Botão Limpar.
		*/
		/// </summary>
		public System.String ClearButton
		{
			get { return m_ClearButton; }
			set 
			{
				m_ClearButton = value;
				m_IsClearButtonDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Image.
		/// Objeto(s) Imagem.
		*/
		/// </summary>
		public System.String Image
		{
			get { return m_Image; }
			set 
			{
				m_Image = value;
				m_IsImageDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão TextBlock.
		/// Objeto(s) SubTitle.
		*/
		/// </summary>
		public System.String Subtitle
		{
			get { return m_Subtitle; }
			set 
			{
				m_Subtitle = value;
				m_IsSubtitleDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão TextBlock.
		/// Objeto(s) TextToLink.
		*/
		/// </summary>
		public System.String TextToLink
		{
			get { return m_TextToLink; }
			set 
			{
				m_TextToLink = value;
				m_IsTextToLinkDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão TextBlock.
		/// Objeto(s) PlainText.
		*/
		/// </summary>
		public System.String PlainText
		{
			get { return m_PlainText; }
			set 
			{
				m_PlainText = value;
				m_IsPlainTextDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão TextBlock.
		/// Objeto(s) PlainTextEmpty.
		*/
		/// </summary>
		public System.String PlainTextEmpty
		{
			get { return m_PlainTextEmpty; }
			set 
			{
				m_PlainTextEmpty = value;
				m_IsPlainTextEmptyDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão TextBlock.
		/// Objeto(s) Label.
		*/
		/// </summary>
		public System.String Label
		{
			get { return m_Label; }
			set 
			{
				m_Label = value;
				m_IsLabelDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Table.
		/// Objeto(s) ViewTable.
		*/
		/// </summary>
		public System.String ViewTable
		{
			get { return m_ViewTable; }
			set 
			{
				m_ViewTable = value;
				m_IsViewTableDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Grid.
		/// Objeto(s) Grid.
		*/
		/// </summary>
		public System.String Grid
		{
			get { return m_Grid; }
			set 
			{
				m_Grid = value;
				m_IsGridDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Table.
		/// Objeto(s) Table100.
		*/
		/// </summary>
		public System.String Table100
		{
			get { return m_Table100; }
			set 
			{
				m_Table100 = value;
				m_IsTable100Default = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão TextBlock.
		/// Objeto(s) Separator.
		*/
		/// </summary>
		public System.String Separator
		{
			get { return m_Separator; }
			set 
			{
				m_Separator = value;
				m_IsSeparatorDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Attribute.
		/// Atributo(s) somente leitura.
		*/
		/// </summary>
		public System.String ReadonlyAttribute
		{
			get { return m_ReadonlyAttribute; }
			set 
			{
				m_ReadonlyAttribute = value;
				m_IsReadonlyAttributeDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Attribute.
		/// Atributo(s) existente(s) no(s) Grid(s), sendo este(s) somente leitura.
		*/
		/// </summary>
		public System.String ReadonlyGridAttribute
		{
			get { return m_ReadonlyGridAttribute; }
			set 
			{
				m_ReadonlyGridAttribute = value;
				m_IsReadonlyGridAttributeDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Attribute.
		/// Atributo(s) do tipo Blob, sendo este(s) somente leitura.
		*/
		/// </summary>
		public System.String ReadonlyBlobAttribute
		{
			get { return m_ReadonlyBlobAttribute; }
			set 
			{
				m_ReadonlyBlobAttribute = value;
				m_IsReadonlyBlobAttributeDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Attribute.
		/// Atributo(s) do tipo Blob existente(s) no(s) Grid(s), sendo este(s) somente leitura.
		*/
		/// </summary>
		public System.String ReadonlyGridBlobAttribute
		{
			get { return m_ReadonlyGridBlobAttribute; }
			set 
			{
				m_ReadonlyGridBlobAttribute = value;
				m_IsReadonlyGridBlobAttributeDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Table.
		/// Tabela da aba.
		*/
		/// </summary>
		public System.String TabTable
		{
			get { return m_TabTable; }
			set 
			{
				m_TabTable = value;
				m_IsTabTableDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Attribute.
		/// Atributo(s) chave primária.
		*/
		/// </summary>
		public System.String AttributeKey
		{
			get { return m_AttributeKey; }
			set 
			{
				m_AttributeKey = value;
				m_IsAttributeKeyDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão TextBlock.
		/// Texto(s) referente(s) à chave primária.
		*/
		/// </summary>
		public System.String LabelKey
		{
			get { return m_LabelKey; }
			set 
			{
				m_LabelKey = value;
				m_IsLabelKeyDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma classe padrão Group.
		/// Objeto(s) Group.
		*/
		/// </summary>
		public System.String Group
		{
			get { return m_Group; }
			set 
			{
				m_Group = value;
				m_IsGroupDefault = false;
			}
		}

		/// <summary>
		/*
		Class Padrão para Collapse
		*/
		/// </summary>
		public System.String FilterCollapse
		{
			get { return m_FilterCollapse; }
			set 
			{
				m_FilterCollapse = value;
				m_IsFilterCollapseDefault = false;
			}
		}

		/// <summary>
		/*
		Class Padrão para Expand
		*/
		/// </summary>
		public System.String FilterExpand
		{
			get { return m_FilterExpand; }
			set 
			{
				m_FilterExpand = value;
				m_IsFilterExpandDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsThemeElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Theme")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Theme"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_ThemeReference = element.Attributes.GetPropertyValue<KBObjectReference>("ThemeReference");
			m_IsThemeDefault = element.Attributes.IsPropertyDefault("Theme");
			m_SetObjectTheme = element.Attributes.GetPropertyValue<System.String>("SetObjectTheme");
			m_IsSetObjectThemeDefault = element.Attributes.IsPropertyDefault("SetObjectTheme");
			m_Button = element.Attributes.GetPropertyValue<System.String>("Button");
			m_IsButtonDefault = element.Attributes.IsPropertyDefault("Button");
			m_BtnEnter = element.Attributes.GetPropertyValue<System.String>("BtnEnter");
			m_IsBtnEnterDefault = element.Attributes.IsPropertyDefault("BtnEnter");
			m_BtnCancel = element.Attributes.GetPropertyValue<System.String>("BtnCancel");
			m_IsBtnCancelDefault = element.Attributes.IsPropertyDefault("BtnCancel");
			m_SearchButton = element.Attributes.GetPropertyValue<System.String>("SearchButton");
			m_IsSearchButtonDefault = element.Attributes.IsPropertyDefault("SearchButton");
			m_ClearButton = element.Attributes.GetPropertyValue<System.String>("ClearButton");
			m_IsClearButtonDefault = element.Attributes.IsPropertyDefault("ClearButton");
			m_Image = element.Attributes.GetPropertyValue<System.String>("Image");
			m_IsImageDefault = element.Attributes.IsPropertyDefault("Image");
			m_Subtitle = element.Attributes.GetPropertyValue<System.String>("Subtitle");
			m_IsSubtitleDefault = element.Attributes.IsPropertyDefault("Subtitle");
			m_TextToLink = element.Attributes.GetPropertyValue<System.String>("TextToLink");
			m_IsTextToLinkDefault = element.Attributes.IsPropertyDefault("TextToLink");
			m_PlainText = element.Attributes.GetPropertyValue<System.String>("PlainText");
			m_IsPlainTextDefault = element.Attributes.IsPropertyDefault("PlainText");
			m_PlainTextEmpty = element.Attributes.GetPropertyValue<System.String>("PlainTextEmpty");
			m_IsPlainTextEmptyDefault = element.Attributes.IsPropertyDefault("PlainTextEmpty");
			m_Label = element.Attributes.GetPropertyValue<System.String>("Label");
			m_IsLabelDefault = element.Attributes.IsPropertyDefault("Label");
			m_ViewTable = element.Attributes.GetPropertyValue<System.String>("ViewTable");
			m_IsViewTableDefault = element.Attributes.IsPropertyDefault("ViewTable");
			m_Grid = element.Attributes.GetPropertyValue<System.String>("Grid");
			m_IsGridDefault = element.Attributes.IsPropertyDefault("Grid");
			m_Table100 = element.Attributes.GetPropertyValue<System.String>("Table100");
			m_IsTable100Default = element.Attributes.IsPropertyDefault("Table100");
			m_Separator = element.Attributes.GetPropertyValue<System.String>("Separator");
			m_IsSeparatorDefault = element.Attributes.IsPropertyDefault("Separator");
			m_ReadonlyAttribute = element.Attributes.GetPropertyValue<System.String>("ReadonlyAttribute");
			m_IsReadonlyAttributeDefault = element.Attributes.IsPropertyDefault("ReadonlyAttribute");
			m_ReadonlyGridAttribute = element.Attributes.GetPropertyValue<System.String>("ReadonlyGridAttribute");
			m_IsReadonlyGridAttributeDefault = element.Attributes.IsPropertyDefault("ReadonlyGridAttribute");
			m_ReadonlyBlobAttribute = element.Attributes.GetPropertyValue<System.String>("ReadonlyBlobAttribute");
			m_IsReadonlyBlobAttributeDefault = element.Attributes.IsPropertyDefault("ReadonlyBlobAttribute");
			m_ReadonlyGridBlobAttribute = element.Attributes.GetPropertyValue<System.String>("ReadonlyGridBlobAttribute");
			m_IsReadonlyGridBlobAttributeDefault = element.Attributes.IsPropertyDefault("ReadonlyGridBlobAttribute");
			m_TabTable = element.Attributes.GetPropertyValue<System.String>("TabTable");
			m_IsTabTableDefault = element.Attributes.IsPropertyDefault("TabTable");
			m_AttributeKey = element.Attributes.GetPropertyValue<System.String>("AttributeKey");
			m_IsAttributeKeyDefault = element.Attributes.IsPropertyDefault("AttributeKey");
			m_LabelKey = element.Attributes.GetPropertyValue<System.String>("LabelKey");
			m_IsLabelKeyDefault = element.Attributes.IsPropertyDefault("LabelKey");
			m_Group = element.Attributes.GetPropertyValue<System.String>("Group");
			m_IsGroupDefault = element.Attributes.IsPropertyDefault("Group");
			m_FilterCollapse = element.Attributes.GetPropertyValue<System.String>("FilterCollapse");
			m_IsFilterCollapseDefault = element.Attributes.IsPropertyDefault("FilterCollapse");
			m_FilterExpand = element.Attributes.GetPropertyValue<System.String>("FilterExpand");
			m_IsFilterExpandDefault = element.Attributes.IsPropertyDefault("FilterExpand");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsThemeElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Theme")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Theme"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "ThemeReference", m_ThemeReference, m_IsThemeDefault);
			SaveAttribute(element, "SetObjectTheme", m_SetObjectTheme, m_IsSetObjectThemeDefault);
			SaveAttribute(element, "Button", m_Button, m_IsButtonDefault);
			SaveAttribute(element, "BtnEnter", m_BtnEnter, m_IsBtnEnterDefault);
			SaveAttribute(element, "BtnCancel", m_BtnCancel, m_IsBtnCancelDefault);
			SaveAttribute(element, "SearchButton", m_SearchButton, m_IsSearchButtonDefault);
			SaveAttribute(element, "ClearButton", m_ClearButton, m_IsClearButtonDefault);
			SaveAttribute(element, "Image", m_Image, m_IsImageDefault);
			SaveAttribute(element, "Subtitle", m_Subtitle, m_IsSubtitleDefault);
			SaveAttribute(element, "TextToLink", m_TextToLink, m_IsTextToLinkDefault);
			SaveAttribute(element, "PlainText", m_PlainText, m_IsPlainTextDefault);
			SaveAttribute(element, "PlainTextEmpty", m_PlainTextEmpty, m_IsPlainTextEmptyDefault);
			SaveAttribute(element, "Label", m_Label, m_IsLabelDefault);
			SaveAttribute(element, "ViewTable", m_ViewTable, m_IsViewTableDefault);
			SaveAttribute(element, "Grid", m_Grid, m_IsGridDefault);
			SaveAttribute(element, "Table100", m_Table100, m_IsTable100Default);
			SaveAttribute(element, "Separator", m_Separator, m_IsSeparatorDefault);
			SaveAttribute(element, "ReadonlyAttribute", m_ReadonlyAttribute, m_IsReadonlyAttributeDefault);
			SaveAttribute(element, "ReadonlyGridAttribute", m_ReadonlyGridAttribute, m_IsReadonlyGridAttributeDefault);
			SaveAttribute(element, "ReadonlyBlobAttribute", m_ReadonlyBlobAttribute, m_IsReadonlyBlobAttributeDefault);
			SaveAttribute(element, "ReadonlyGridBlobAttribute", m_ReadonlyGridBlobAttribute, m_IsReadonlyGridBlobAttributeDefault);
			SaveAttribute(element, "TabTable", m_TabTable, m_IsTabTableDefault);
			SaveAttribute(element, "AttributeKey", m_AttributeKey, m_IsAttributeKeyDefault);
			SaveAttribute(element, "LabelKey", m_LabelKey, m_IsLabelKeyDefault);
			SaveAttribute(element, "Group", m_Group, m_IsGroupDefault);
			SaveAttribute(element, "FilterCollapse", m_FilterCollapse, m_IsFilterCollapseDefault);
			SaveAttribute(element, "FilterExpand", m_FilterExpand, m_IsFilterExpandDefault);

			Debug.Assert(m_ThemeReference == element.Attributes.GetPropertyValue<KBObjectReference>("ThemeReference"));
			Debug.Assert(m_SetObjectTheme == element.Attributes.GetPropertyValue<System.String>("SetObjectTheme"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsThemeElement"/>.
		/// </summary>
		public SettingsThemeElement Clone()
		{
			SettingsThemeElement clone = new SettingsThemeElement();

			clone.Theme = this.Theme;
			clone.SetObjectTheme = this.SetObjectTheme;
			clone.Button = this.Button;
			clone.BtnEnter = this.BtnEnter;
			clone.BtnCancel = this.BtnCancel;
			clone.SearchButton = this.SearchButton;
			clone.ClearButton = this.ClearButton;
			clone.Image = this.Image;
			clone.Subtitle = this.Subtitle;
			clone.TextToLink = this.TextToLink;
			clone.PlainText = this.PlainText;
			clone.PlainTextEmpty = this.PlainTextEmpty;
			clone.Label = this.Label;
			clone.ViewTable = this.ViewTable;
			clone.Grid = this.Grid;
			clone.Table100 = this.Table100;
			clone.Separator = this.Separator;
			clone.ReadonlyAttribute = this.ReadonlyAttribute;
			clone.ReadonlyGridAttribute = this.ReadonlyGridAttribute;
			clone.ReadonlyBlobAttribute = this.ReadonlyBlobAttribute;
			clone.ReadonlyGridBlobAttribute = this.ReadonlyGridBlobAttribute;
			clone.TabTable = this.TabTable;
			clone.AttributeKey = this.AttributeKey;
			clone.LabelKey = this.LabelKey;
			clone.Group = this.Group;
			clone.FilterCollapse = this.FilterCollapse;
			clone.FilterExpand = this.FilterExpand;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="SetObjectTheme"/> property.
		/// </summary>
		public static class SetObjectThemeValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Force = "force";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Theme";
		}

		#endregion
	}

	#endregion

	#region Element: Labels

	public partial class SettingsLabelsElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_GeneralTab;
		private bool m_IsGeneralTabDefault;
		private System.String m_WorkWithTitle;
		private bool m_IsWorkWithTitleDefault;
		private System.String m_PromptTitle;
		private bool m_IsPromptTitleDefault;
		private System.String m_ViewDescription;
		private bool m_IsViewDescriptionDefault;
		private System.String m_OrderedBy;
		private bool m_IsOrderedByDefault;
		private System.String m_AllInCombo;
		private bool m_IsAllInComboDefault;
		private System.String m_PreviousTab;
		private bool m_IsPreviousTabDefault;
		private System.String m_NextTab;
		private bool m_IsNextTabDefault;
		private System.String m_RecordNotFound;
		private bool m_IsRecordNotFoundDefault;
		private System.String m_SaveItem;
		private bool m_IsSaveItemDefault;
		private System.String m_CloseItem;
		private bool m_IsCloseItemDefault;
		private System.String m_AttributeCaption;
		private bool m_IsAttributeCaptionDefault;
		private System.String m_GridCaption;
		private bool m_IsGridCaptionDefault;
		private System.String m_FilterCaption;
		private bool m_IsFilterCaptionDefault;
		private System.Boolean m_HTMLFormat;
		private bool m_IsHTMLFormatDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsLabelsElement"/> class.
		/// </summary>
		public SettingsLabelsElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsLabelsElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_GeneralTab = "General";
			m_IsGeneralTabDefault = true;
			m_WorkWithTitle = "Work With <Object>";
			m_IsWorkWithTitleDefault = true;
			m_PromptTitle = "Prompt <Object>";
			m_IsPromptTitleDefault = true;
			m_ViewDescription = "<Object> Information";
			m_IsViewDescriptionDefault = true;
			m_OrderedBy = "Ordered By";
			m_IsOrderedByDefault = true;
			m_AllInCombo = "All";
			m_IsAllInComboDefault = true;
			m_PreviousTab = "Previous Tab";
			m_IsPreviousTabDefault = true;
			m_NextTab = "Next Tab";
			m_IsNextTabDefault = true;
			m_RecordNotFound = "Record not found";
			m_IsRecordNotFoundDefault = true;
			m_SaveItem = "Salvar Item";
			m_IsSaveItemDefault = true;
			m_CloseItem = "Fechar Item";
			m_IsCloseItemDefault = true;
			m_AttributeCaption = "{0}";
			m_IsAttributeCaptionDefault = true;
			m_GridCaption = "{0}";
			m_IsGridCaptionDefault = true;
			m_FilterCaption = "{0}";
			m_IsFilterCaptionDefault = true;
			m_HTMLFormat = false;
			m_IsHTMLFormatDefault = true;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsLabelsElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		public System.String GeneralTab
		{
			get { return m_GeneralTab; }
			set 
			{
				m_GeneralTab = value;
				m_IsGeneralTabDefault = false;
			}
		}

		public System.String WorkWithTitle
		{
			get { return m_WorkWithTitle; }
			set 
			{
				m_WorkWithTitle = value;
				m_IsWorkWithTitleDefault = false;
			}
		}

		public System.String PromptTitle
		{
			get { return m_PromptTitle; }
			set 
			{
				m_PromptTitle = value;
				m_IsPromptTitleDefault = false;
			}
		}

		/// <summary>
		/*
		Format string for View Description.
		*/
		/// </summary>
		public System.String ViewDescription
		{
			get { return m_ViewDescription; }
			set 
			{
				m_ViewDescription = value;
				m_IsViewDescriptionDefault = false;
			}
		}

		public System.String OrderedBy
		{
			get { return m_OrderedBy; }
			set 
			{
				m_OrderedBy = value;
				m_IsOrderedByDefault = false;
			}
		}

		/// <summary>
		/*
		Caption used for the All option in combos.
		*/
		/// </summary>
		public System.String AllInCombo
		{
			get { return m_AllInCombo; }
			set 
			{
				m_AllInCombo = value;
				m_IsAllInComboDefault = false;
			}
		}

		/// <summary>
		/*
		Tooltip to appear in the previous tab button
		*/
		/// </summary>
		public System.String PreviousTab
		{
			get { return m_PreviousTab; }
			set 
			{
				m_PreviousTab = value;
				m_IsPreviousTabDefault = false;
			}
		}

		/// <summary>
		/*
		Tooltip to appear in the next tab button
		*/
		/// </summary>
		public System.String NextTab
		{
			get { return m_NextTab; }
			set 
			{
				m_NextTab = value;
				m_IsNextTabDefault = false;
			}
		}

		/// <summary>
		/*
		Text used on Views when the requested record is not found in the database.
		*/
		/// </summary>
		public System.String RecordNotFound
		{
			get { return m_RecordNotFound; }
			set 
			{
				m_RecordNotFound = value;
				m_IsRecordNotFoundDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Caption para o botão que Salva o item
		*/
		/// </summary>
		public System.String SaveItem
		{
			get { return m_SaveItem; }
			set 
			{
				m_SaveItem = value;
				m_IsSaveItemDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Caption para o botão de Cancela o item
		*/
		/// </summary>
		public System.String CloseItem
		{
			get { return m_CloseItem; }
			set 
			{
				m_CloseItem = value;
				m_IsCloseItemDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Caption para TextBlock que acompanha atributo, permite coringa {0} Default(=Att.ContextualTitle) , {1} ContextualTitle, {2} Attribute Name 
		*/
		/// </summary>
		public System.String AttributeCaption
		{
			get { return m_AttributeCaption; }
			set 
			{
				m_AttributeCaption = value;
				m_IsAttributeCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Caption para TextBlock que acompanha atributo, permite coringa {0} Default(=Att.ContextualTitle) , {1} ContextualTitle, {2} Attribute Name 
		*/
		/// </summary>
		public System.String GridCaption
		{
			get { return m_GridCaption; }
			set 
			{
				m_GridCaption = value;
				m_IsGridCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Caption para TextBlock que acompanha atributo, permite coringa {0} Default(=Att.ContextualTitle) , {1} ContextualTitle, {2} Attribute Name 
		*/
		/// </summary>
		public System.String FilterCaption
		{
			get { return m_FilterCaption; }
			set 
			{
				m_FilterCaption = value;
				m_IsFilterCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		HTML Format
		*/
		/// </summary>
		public System.Boolean HTMLFormat
		{
			get { return m_HTMLFormat; }
			set 
			{
				m_HTMLFormat = value;
				m_IsHTMLFormatDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsLabelsElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Labels")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Labels"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_GeneralTab = element.Attributes.GetPropertyValue<System.String>("GeneralTab");
			m_IsGeneralTabDefault = element.Attributes.IsPropertyDefault("GeneralTab");
			m_WorkWithTitle = element.Attributes.GetPropertyValue<System.String>("WorkWithTitle");
			m_IsWorkWithTitleDefault = element.Attributes.IsPropertyDefault("WorkWithTitle");
			m_PromptTitle = element.Attributes.GetPropertyValue<System.String>("PromptTitle");
			m_IsPromptTitleDefault = element.Attributes.IsPropertyDefault("PromptTitle");
			m_ViewDescription = element.Attributes.GetPropertyValue<System.String>("ViewDescription");
			m_IsViewDescriptionDefault = element.Attributes.IsPropertyDefault("ViewDescription");
			m_OrderedBy = element.Attributes.GetPropertyValue<System.String>("OrderedBy");
			m_IsOrderedByDefault = element.Attributes.IsPropertyDefault("OrderedBy");
			m_AllInCombo = element.Attributes.GetPropertyValue<System.String>("AllInCombo");
			m_IsAllInComboDefault = element.Attributes.IsPropertyDefault("AllInCombo");
			m_PreviousTab = element.Attributes.GetPropertyValue<System.String>("PreviousTab");
			m_IsPreviousTabDefault = element.Attributes.IsPropertyDefault("PreviousTab");
			m_NextTab = element.Attributes.GetPropertyValue<System.String>("NextTab");
			m_IsNextTabDefault = element.Attributes.IsPropertyDefault("NextTab");
			m_RecordNotFound = element.Attributes.GetPropertyValue<System.String>("RecordNotFound");
			m_IsRecordNotFoundDefault = element.Attributes.IsPropertyDefault("RecordNotFound");
			m_SaveItem = element.Attributes.GetPropertyValue<System.String>("SaveItem");
			m_IsSaveItemDefault = element.Attributes.IsPropertyDefault("SaveItem");
			m_CloseItem = element.Attributes.GetPropertyValue<System.String>("CloseItem");
			m_IsCloseItemDefault = element.Attributes.IsPropertyDefault("CloseItem");
			m_AttributeCaption = element.Attributes.GetPropertyValue<System.String>("AttributeCaption");
			m_IsAttributeCaptionDefault = element.Attributes.IsPropertyDefault("AttributeCaption");
			m_GridCaption = element.Attributes.GetPropertyValue<System.String>("GridCaption");
			m_IsGridCaptionDefault = element.Attributes.IsPropertyDefault("GridCaption");
			m_FilterCaption = element.Attributes.GetPropertyValue<System.String>("FilterCaption");
			m_IsFilterCaptionDefault = element.Attributes.IsPropertyDefault("FilterCaption");
			m_HTMLFormat = element.Attributes.GetPropertyValue<System.Boolean>("HTMLFormat");
			m_IsHTMLFormatDefault = element.Attributes.IsPropertyDefault("HTMLFormat");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsLabelsElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Labels")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Labels"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "GeneralTab", m_GeneralTab, m_IsGeneralTabDefault);
			SaveAttribute(element, "WorkWithTitle", m_WorkWithTitle, m_IsWorkWithTitleDefault);
			SaveAttribute(element, "PromptTitle", m_PromptTitle, m_IsPromptTitleDefault);
			SaveAttribute(element, "ViewDescription", m_ViewDescription, m_IsViewDescriptionDefault);
			SaveAttribute(element, "OrderedBy", m_OrderedBy, m_IsOrderedByDefault);
			SaveAttribute(element, "AllInCombo", m_AllInCombo, m_IsAllInComboDefault);
			SaveAttribute(element, "PreviousTab", m_PreviousTab, m_IsPreviousTabDefault);
			SaveAttribute(element, "NextTab", m_NextTab, m_IsNextTabDefault);
			SaveAttribute(element, "RecordNotFound", m_RecordNotFound, m_IsRecordNotFoundDefault);
			SaveAttribute(element, "SaveItem", m_SaveItem, m_IsSaveItemDefault);
			SaveAttribute(element, "CloseItem", m_CloseItem, m_IsCloseItemDefault);
			SaveAttribute(element, "AttributeCaption", m_AttributeCaption, m_IsAttributeCaptionDefault);
			SaveAttribute(element, "GridCaption", m_GridCaption, m_IsGridCaptionDefault);
			SaveAttribute(element, "FilterCaption", m_FilterCaption, m_IsFilterCaptionDefault);
			SaveAttribute(element, "HTMLFormat", m_HTMLFormat, m_IsHTMLFormatDefault);

			Debug.Assert(m_GeneralTab == element.Attributes.GetPropertyValue<System.String>("GeneralTab"));
			Debug.Assert(m_WorkWithTitle == element.Attributes.GetPropertyValue<System.String>("WorkWithTitle"));
			Debug.Assert(m_PromptTitle == element.Attributes.GetPropertyValue<System.String>("PromptTitle"));
			Debug.Assert(m_ViewDescription == element.Attributes.GetPropertyValue<System.String>("ViewDescription"));
			Debug.Assert(m_OrderedBy == element.Attributes.GetPropertyValue<System.String>("OrderedBy"));
			Debug.Assert(m_AllInCombo == element.Attributes.GetPropertyValue<System.String>("AllInCombo"));
			Debug.Assert(m_PreviousTab == element.Attributes.GetPropertyValue<System.String>("PreviousTab"));
			Debug.Assert(m_NextTab == element.Attributes.GetPropertyValue<System.String>("NextTab"));
			Debug.Assert(m_RecordNotFound == element.Attributes.GetPropertyValue<System.String>("RecordNotFound"));
			Debug.Assert(m_SaveItem == element.Attributes.GetPropertyValue<System.String>("SaveItem"));
			Debug.Assert(m_CloseItem == element.Attributes.GetPropertyValue<System.String>("CloseItem"));
			Debug.Assert(m_AttributeCaption == element.Attributes.GetPropertyValue<System.String>("AttributeCaption"));
			Debug.Assert(m_GridCaption == element.Attributes.GetPropertyValue<System.String>("GridCaption"));
			Debug.Assert(m_FilterCaption == element.Attributes.GetPropertyValue<System.String>("FilterCaption"));
			Debug.Assert(m_HTMLFormat == element.Attributes.GetPropertyValue<System.Boolean>("HTMLFormat"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsLabelsElement"/>.
		/// </summary>
		public SettingsLabelsElement Clone()
		{
			SettingsLabelsElement clone = new SettingsLabelsElement();

			clone.GeneralTab = this.GeneralTab;
			clone.WorkWithTitle = this.WorkWithTitle;
			clone.PromptTitle = this.PromptTitle;
			clone.ViewDescription = this.ViewDescription;
			clone.OrderedBy = this.OrderedBy;
			clone.AllInCombo = this.AllInCombo;
			clone.PreviousTab = this.PreviousTab;
			clone.NextTab = this.NextTab;
			clone.RecordNotFound = this.RecordNotFound;
			clone.SaveItem = this.SaveItem;
			clone.CloseItem = this.CloseItem;
			clone.AttributeCaption = this.AttributeCaption;
			clone.GridCaption = this.GridCaption;
			clone.FilterCaption = this.FilterCaption;
			clone.HTMLFormat = this.HTMLFormat;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Labels";
		}

		#endregion
	}

	#endregion

	#region Element: Grid

	public partial class SettingsGridElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Rules;
		private bool m_IsRulesDefault;
		private System.String m_BackColorStyle;
		private bool m_IsBackColorStyleDefault;
		private System.Int32 m_CellSpacing;
		private bool m_IsCellSpacingDefault;
		private System.Int32 m_CellPadding;
		private bool m_IsCellPaddingDefault;
		private System.String m_Page;
		private bool m_IsPageDefault;
		private System.Boolean m_SaveGridState;
		private bool m_IsSaveGridStateDefault;
		private System.Boolean m_EnableDisablePaging;
		private bool m_IsEnableDisablePagingDefault;
		private System.Boolean m_SearchButton;
		private bool m_IsSearchButtonDefault;
		private System.String m_SearchCaption;
		private bool m_IsSearchCaptionDefault;
		private System.String m_SearchLegend;
		private bool m_IsSearchLegendDefault;
		private System.Boolean m_ClearButton;
		private bool m_IsClearButtonDefault;
		private System.String m_ClearCaption;
		private bool m_IsClearCaptionDefault;
		private System.String m_ClearLegend;
		private bool m_IsClearLegendDefault;
		private System.String m_ButtonsAlign;
		private bool m_IsButtonsAlignDefault;
		private System.Boolean m_DefaultPagingButtons;
		private bool m_IsDefaultPagingButtonsDefault;
		private Artech.Genexus.Common.Objects.Image m_ImageFirst;
		private KBObjectReference m_ImageFirstReference;
		private string m_ImageFirstName;
		private bool m_IsImageFirstDefault;
		private Artech.Genexus.Common.Objects.Image m_ImageFirstDisabled;
		private KBObjectReference m_ImageFirstDisabledReference;
		private string m_ImageFirstDisabledName;
		private bool m_IsImageFirstDisabledDefault;
		private System.String m_TooltipFirst;
		private bool m_IsTooltipFirstDefault;
		private Artech.Genexus.Common.Objects.Image m_ImagePrevious;
		private KBObjectReference m_ImagePreviousReference;
		private string m_ImagePreviousName;
		private bool m_IsImagePreviousDefault;
		private Artech.Genexus.Common.Objects.Image m_ImagePreviousDisabled;
		private KBObjectReference m_ImagePreviousDisabledReference;
		private string m_ImagePreviousDisabledName;
		private bool m_IsImagePreviousDisabledDefault;
		private System.String m_TooltipPrevious;
		private bool m_IsTooltipPreviousDefault;
		private Artech.Genexus.Common.Objects.Image m_ImageNext;
		private KBObjectReference m_ImageNextReference;
		private string m_ImageNextName;
		private bool m_IsImageNextDefault;
		private Artech.Genexus.Common.Objects.Image m_ImageNextDisabled;
		private KBObjectReference m_ImageNextDisabledReference;
		private string m_ImageNextDisabledName;
		private bool m_IsImageNextDisabledDefault;
		private System.String m_TooltipNext;
		private bool m_IsTooltipNextDefault;
		private Artech.Genexus.Common.Objects.Image m_ImageLast;
		private KBObjectReference m_ImageLastReference;
		private string m_ImageLastName;
		private bool m_IsImageLastDefault;
		private Artech.Genexus.Common.Objects.Image m_ImageLastDisabled;
		private KBObjectReference m_ImageLastDisabledReference;
		private string m_ImageLastDisabledName;
		private bool m_IsImageLastDisabledDefault;
		private System.String m_TooltipLast;
		private bool m_IsTooltipLastDefault;
		private System.String m_InsertAlign;
		private bool m_IsInsertAlignDefault;
		private System.Boolean m_LoadOnStart;
		private bool m_IsLoadOnStartDefault;
		private System.Boolean m_RequiredFilter;
		private bool m_IsRequiredFilterDefault;
		private System.String m_RequiredFilterMessage;
		private bool m_IsRequiredFilterMessageDefault;
		private System.Boolean m_AutomaticRefresh;
		private bool m_IsAutomaticRefreshDefault;
		private System.Boolean m_CurrentPageVisible;
		private bool m_IsCurrentPageVisibleDefault;
		private System.Boolean m_CurrentPageCombo;
		private bool m_IsCurrentPageComboDefault;
		private System.Boolean m_MaxPage;
		private bool m_IsMaxPageDefault;
		private System.Boolean m_MaxRecords;
		private bool m_IsMaxRecordsDefault;
		private System.Boolean m_PageRecordsCombo;
		private bool m_IsPageRecordsComboDefault;
		private System.Boolean m_SelectedRecords;
		private bool m_IsSelectedRecordsDefault;
		private System.Boolean m_CheckAll;
		private bool m_IsCheckAllDefault;
		private System.String m_PagingVariableClass;
		private bool m_IsPagingVariableClassDefault;
		private System.Boolean m_BuildAutoLink;
		private bool m_IsBuildAutoLinkDefault;
		private System.String m_GridType;
		private bool m_IsGridTypeDefault;
		private System.String m_CustomRender;
		private bool m_IsCustomRenderDefault;
		private System.String m_GridGXUIActionOrientation;
		private bool m_IsGridGXUIActionOrientationDefault;
		private System.Boolean m_AnimateCollapse;
		private bool m_IsAnimateCollapseDefault;
		private System.Int32 m_PageSize;
		private bool m_IsPageSizeDefault;
		private System.Boolean m_AutoWidth;
		private bool m_IsAutoWidthDefault;
		private System.Int32 m_Width;
		private bool m_IsWidthDefault;
		private System.Int32 m_Height;
		private bool m_IsHeightDefault;
		private System.Boolean m_RemoteSort;
		private bool m_IsRemoteSortDefault;
		private System.Boolean m_ForceFit;
		private bool m_IsForceFitDefault;
		private System.String m_FiltersText;
		private bool m_IsFiltersTextDefault;
		private System.String m_FirstText;
		private bool m_IsFirstTextDefault;
		private System.String m_PreviousText;
		private bool m_IsPreviousTextDefault;
		private System.String m_NextText;
		private bool m_IsNextTextDefault;
		private System.String m_LastText;
		private bool m_IsLastTextDefault;
		private System.String m_RefreshText;
		private bool m_IsRefreshTextDefault;
		private System.String m_BeforePageText;
		private bool m_IsBeforePageTextDefault;
		private System.String m_AfterPageText;
		private bool m_IsAfterPageTextDefault;
		private System.String m_DisplayMsg;
		private bool m_IsDisplayMsgDefault;
		private System.String m_EmptyMsg;
		private bool m_IsEmptyMsgDefault;
		private System.String m_LoadingMsg;
		private bool m_IsLoadingMsgDefault;
		private System.Int32 m_MinColumnWidth;
		private bool m_IsMinColumnWidthDefault;
		private System.Boolean m_TitleVisible;
		private bool m_IsTitleVisibleDefault;
		private System.String m_DefaultCondition;
		private bool m_IsDefaultConditionDefault;
		private System.String m_DefaultConditionCharacter;
		private bool m_IsDefaultConditionCharacterDefault;
		private System.String m_DefaultConditionBoolean;
		private bool m_IsDefaultConditionBooleanDefault;
		private System.Boolean m_ChangeRadioTocombo;
		private bool m_IsChangeRadioTocomboDefault;
		private System.Boolean m_ChangeLikeInVariableAux;
		private bool m_IsChangeLikeInVariableAuxDefault;
		private System.String m_SelectionCallMethod;
		private bool m_IsSelectionCallMethodDefault;
		private System.String m_ViewTabCallMethod;
		private bool m_IsViewTabCallMethodDefault;
		private System.String m_PromptCallMethod;
		private bool m_IsPromptCallMethodDefault;
		private System.String m_FilterIntervalText;
		private bool m_IsFilterIntervalTextDefault;
		private System.String m_GridStandardActionOrientation;
		private bool m_IsGridStandardActionOrientationDefault;
		private System.String m_GridLoadBitmaps;
		private bool m_IsGridLoadBitmapsDefault;
		private System.Boolean m_AutoResize;
		private bool m_IsAutoResizeDefault;
		private System.String m_GridWidth;
		private bool m_IsGridWidthDefault;
		private System.String m_GridHeight;
		private bool m_IsGridHeightDefault;
		private System.Boolean m_AllowSelection;
		private bool m_IsAllowSelectionDefault;
		private SettingsGridPropertiesElement m_GridProperties;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsGridElement"/> class.
		/// </summary>
		public SettingsGridElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsGridElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Rules = "All";
			m_IsRulesDefault = true;
			m_BackColorStyle = "Report";
			m_IsBackColorStyleDefault = true;
			m_CellSpacing = 2;
			m_IsCellSpacingDefault = true;
			m_CellPadding = 4;
			m_IsCellPaddingDefault = true;
			m_Page = "Page.Rows";
			m_IsPageDefault = true;
			m_SaveGridState = true;
			m_IsSaveGridStateDefault = true;
			m_EnableDisablePaging = true;
			m_IsEnableDisablePagingDefault = true;
			m_SearchButton = true;
			m_IsSearchButtonDefault = true;
			m_SearchCaption = "Procurar";
			m_IsSearchCaptionDefault = true;
			m_SearchLegend = "Pesquisar utilizando os filtros informados";
			m_IsSearchLegendDefault = true;
			m_ClearButton = true;
			m_IsClearButtonDefault = true;
			m_ClearCaption = "Limpar";
			m_IsClearCaptionDefault = true;
			m_ClearLegend = "Limpar os filtros da pesquisa";
			m_IsClearLegendDefault = true;
			m_ButtonsAlign = "Right";
			m_IsButtonsAlignDefault = true;
			m_DefaultPagingButtons = true;
			m_IsDefaultPagingButtonsDefault = true;
			m_ImageFirst = null;
			m_ImageFirstReference = null;
			m_ImageFirstName = null;
			m_IsImageFirstDefault = true;
			m_ImageFirstDisabled = null;
			m_ImageFirstDisabledReference = null;
			m_ImageFirstDisabledName = null;
			m_IsImageFirstDisabledDefault = true;
			m_TooltipFirst = "GXM_first";
			m_IsTooltipFirstDefault = true;
			m_ImagePrevious = null;
			m_ImagePreviousReference = null;
			m_ImagePreviousName = null;
			m_IsImagePreviousDefault = true;
			m_ImagePreviousDisabled = null;
			m_ImagePreviousDisabledReference = null;
			m_ImagePreviousDisabledName = null;
			m_IsImagePreviousDisabledDefault = true;
			m_TooltipPrevious = "GXM_previous";
			m_IsTooltipPreviousDefault = true;
			m_ImageNext = null;
			m_ImageNextReference = null;
			m_ImageNextName = null;
			m_IsImageNextDefault = true;
			m_ImageNextDisabled = null;
			m_ImageNextDisabledReference = null;
			m_ImageNextDisabledName = null;
			m_IsImageNextDisabledDefault = true;
			m_TooltipNext = "GXM_next";
			m_IsTooltipNextDefault = true;
			m_ImageLast = null;
			m_ImageLastReference = null;
			m_ImageLastName = null;
			m_IsImageLastDefault = true;
			m_ImageLastDisabled = null;
			m_ImageLastDisabledReference = null;
			m_ImageLastDisabledName = null;
			m_IsImageLastDisabledDefault = true;
			m_TooltipLast = "GXM_last";
			m_IsTooltipLastDefault = true;
			m_InsertAlign = "Right";
			m_IsInsertAlignDefault = true;
			m_LoadOnStart = true;
			m_IsLoadOnStartDefault = true;
			m_RequiredFilter = false;
			m_IsRequiredFilterDefault = true;
			m_RequiredFilterMessage = "Informe ao menos um filtro para pesquisa";
			m_IsRequiredFilterMessageDefault = true;
			m_AutomaticRefresh = true;
			m_IsAutomaticRefreshDefault = true;
			m_CurrentPageVisible = false;
			m_IsCurrentPageVisibleDefault = true;
			m_CurrentPageCombo = false;
			m_IsCurrentPageComboDefault = true;
			m_MaxPage = false;
			m_IsMaxPageDefault = true;
			m_MaxRecords = false;
			m_IsMaxRecordsDefault = true;
			m_PageRecordsCombo = false;
			m_IsPageRecordsComboDefault = true;
			m_SelectedRecords = false;
			m_IsSelectedRecordsDefault = true;
			m_CheckAll = false;
			m_IsCheckAllDefault = true;
			m_PagingVariableClass = "";
			m_IsPagingVariableClassDefault = true;
			m_BuildAutoLink = true;
			m_IsBuildAutoLinkDefault = true;
			m_GridType = "Standard";
			m_IsGridTypeDefault = true;
			m_CustomRender = null;
			m_IsCustomRenderDefault = true;
			m_GridGXUIActionOrientation = "Right";
			m_IsGridGXUIActionOrientationDefault = true;
			m_AnimateCollapse = true;
			m_IsAnimateCollapseDefault = true;
			m_PageSize = 20;
			m_IsPageSizeDefault = true;
			m_AutoWidth = true;
			m_IsAutoWidthDefault = true;
			m_Width = 1000;
			m_IsWidthDefault = true;
			m_Height = 360;
			m_IsHeightDefault = true;
			m_RemoteSort = true;
			m_IsRemoteSortDefault = true;
			m_ForceFit = true;
			m_IsForceFitDefault = true;
			m_FiltersText = "Filtros";
			m_IsFiltersTextDefault = true;
			m_FirstText = "Primeira página";
			m_IsFirstTextDefault = true;
			m_PreviousText = "Página anterior";
			m_IsPreviousTextDefault = true;
			m_NextText = "Próxima página";
			m_IsNextTextDefault = true;
			m_LastText = "Última página";
			m_IsLastTextDefault = true;
			m_RefreshText = "Atualizar";
			m_IsRefreshTextDefault = true;
			m_BeforePageText = "Página";
			m_IsBeforePageTextDefault = true;
			m_AfterPageText = "de {0}";
			m_IsAfterPageTextDefault = true;
			m_DisplayMsg = "Visualizando {0} - {1} de {2}";
			m_IsDisplayMsgDefault = true;
			m_EmptyMsg = "Não foram encontrados registros para esse filtro";
			m_IsEmptyMsgDefault = true;
			m_LoadingMsg = "Carregando...";
			m_IsLoadingMsgDefault = true;
			m_MinColumnWidth = 25;
			m_IsMinColumnWidthDefault = true;
			m_TitleVisible = true;
			m_IsTitleVisibleDefault = true;
			m_DefaultCondition = "{0} >= {1} when not {1}.IsEmpty()";
			m_IsDefaultConditionDefault = true;
			m_DefaultConditionCharacter = "{0} like {1} when not {1}.IsEmpty()";
			m_IsDefaultConditionCharacterDefault = true;
			m_DefaultConditionBoolean = "{0} = {1} when not {1}.IsEmpty()";
			m_IsDefaultConditionBooleanDefault = true;
			m_ChangeRadioTocombo = false;
			m_IsChangeRadioTocomboDefault = true;
			m_ChangeLikeInVariableAux = false;
			m_IsChangeLikeInVariableAuxDefault = true;
			m_SelectionCallMethod = "Link";
			m_IsSelectionCallMethodDefault = true;
			m_ViewTabCallMethod = "Link";
			m_IsViewTabCallMethodDefault = true;
			m_PromptCallMethod = "Link";
			m_IsPromptCallMethodDefault = true;
			m_FilterIntervalText = "até";
			m_IsFilterIntervalTextDefault = true;
			m_GridStandardActionOrientation = "Left";
			m_IsGridStandardActionOrientationDefault = true;
			m_GridLoadBitmaps = "Start";
			m_IsGridLoadBitmapsDefault = true;
			m_AutoResize = true;
			m_IsAutoResizeDefault = true;
			m_GridWidth = "";
			m_IsGridWidthDefault = true;
			m_GridHeight = "";
			m_IsGridHeightDefault = true;
			m_AllowSelection = false;
			m_IsAllowSelectionDefault = true;
			m_GridProperties = null;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsGridElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Grid rules
		*/
		/// </summary>
		public System.String Rules
		{
			get { return m_Rules; }
			set 
			{
				m_Rules = value;
				m_IsRulesDefault = false;
			}
		}

		public System.String BackColorStyle
		{
			get { return m_BackColorStyle; }
			set 
			{
				m_BackColorStyle = value;
				m_IsBackColorStyleDefault = false;
			}
		}

		public System.Int32 CellSpacing
		{
			get { return m_CellSpacing; }
			set 
			{
				m_CellSpacing = value;
				m_IsCellSpacingDefault = false;
			}
		}

		public System.Int32 CellPadding
		{
			get { return m_CellPadding; }
			set 
			{
				m_CellPadding = value;
				m_IsCellPaddingDefault = false;
			}
		}

		public System.String Page
		{
			get { return m_Page; }
			set 
			{
				m_Page = value;
				m_IsPageDefault = false;
			}
		}

		/// <summary>
		/*
		Remember current page, filters and selected order in selection objects.
		*/
		/// </summary>
		public System.Boolean SaveGridState
		{
			get { return m_SaveGridState; }
			set 
			{
				m_SaveGridState = value;
				m_IsSaveGridStateDefault = false;
			}
		}

		/// <summary>
		/*
		Disable paging buttons when action cannot be applied (such as 'Next page' when on last page).
		*/
		/// </summary>
		public System.Boolean EnableDisablePaging
		{
			get { return m_EnableDisablePaging; }
			set 
			{
				m_EnableDisablePaging = value;
				m_IsEnableDisablePagingDefault = false;
			}
		}

		/// <summary>
		/*
		Botão Procurar
		*/
		/// </summary>
		public System.Boolean SearchButton
		{
			get { return m_SearchButton; }
			set 
			{
				m_SearchButton = value;
				m_IsSearchButtonDefault = false;
			}
		}

		/// <summary>
		/*
		Caption do botão Procurar
		*/
		/// </summary>
		public System.String SearchCaption
		{
			get { return m_SearchCaption; }
			set 
			{
				m_SearchCaption = value;
				m_IsSearchCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		Legenda do botão Procurar
		*/
		/// </summary>
		public System.String SearchLegend
		{
			get { return m_SearchLegend; }
			set 
			{
				m_SearchLegend = value;
				m_IsSearchLegendDefault = false;
			}
		}

		/// <summary>
		/*
		Botão Limpar
		*/
		/// </summary>
		public System.Boolean ClearButton
		{
			get { return m_ClearButton; }
			set 
			{
				m_ClearButton = value;
				m_IsClearButtonDefault = false;
			}
		}

		/// <summary>
		/*
		Caption do botão Limpar
		*/
		/// </summary>
		public System.String ClearCaption
		{
			get { return m_ClearCaption; }
			set 
			{
				m_ClearCaption = value;
				m_IsClearCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		Legenda do botão Limpar
		*/
		/// </summary>
		public System.String ClearLegend
		{
			get { return m_ClearLegend; }
			set 
			{
				m_ClearLegend = value;
				m_IsClearLegendDefault = false;
			}
		}

		/// <summary>
		/*
		Alinhamento dos Botões Search e Clear
		*/
		/// </summary>
		public System.String ButtonsAlign
		{
			get { return m_ButtonsAlign; }
			set 
			{
				m_ButtonsAlign = value;
				m_IsButtonsAlignDefault = false;
			}
		}

		/// <summary>
		/*
		Utiliza Paginação padrão do Genexus
		*/
		/// </summary>
		public System.Boolean DefaultPagingButtons
		{
			get { return m_DefaultPagingButtons; }
			set 
			{
				m_DefaultPagingButtons = value;
				m_IsDefaultPagingButtonsDefault = false;
			}
		}

		/// <summary>
		/*
		Image First
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image ImageFirst
		{
			get
			{
				if (m_ImageFirst == null && m_ImageFirstReference != null)
					m_ImageFirst = (Artech.Genexus.Common.Objects.Image)m_ImageFirstReference.GetKBObject(Settings.Model);

				return m_ImageFirst;
			}

			set 
			{
				m_ImageFirst = value;
				m_ImageFirstReference = (value != null ? new KBObjectReference(value) : null);
				m_ImageFirstName = (value != null ? value.Name : null);
				m_IsImageFirstDefault = false;
			}
		}

		/// <summary>
		/// ImageFirst name.
		/// </summary>
		public string ImageFirstName
		{
			get
			{
				if (m_ImageFirstName == null && m_ImageFirstReference != null)
					m_ImageFirstName = m_ImageFirstReference.GetName(Settings.Model);

				return m_ImageFirstName;
			}
		}

		/// <summary>
		/*
		Image First Disabled
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image ImageFirstDisabled
		{
			get
			{
				if (m_ImageFirstDisabled == null && m_ImageFirstDisabledReference != null)
					m_ImageFirstDisabled = (Artech.Genexus.Common.Objects.Image)m_ImageFirstDisabledReference.GetKBObject(Settings.Model);

				return m_ImageFirstDisabled;
			}

			set 
			{
				m_ImageFirstDisabled = value;
				m_ImageFirstDisabledReference = (value != null ? new KBObjectReference(value) : null);
				m_ImageFirstDisabledName = (value != null ? value.Name : null);
				m_IsImageFirstDisabledDefault = false;
			}
		}

		/// <summary>
		/// ImageFirstDisabled name.
		/// </summary>
		public string ImageFirstDisabledName
		{
			get
			{
				if (m_ImageFirstDisabledName == null && m_ImageFirstDisabledReference != null)
					m_ImageFirstDisabledName = m_ImageFirstDisabledReference.GetName(Settings.Model);

				return m_ImageFirstDisabledName;
			}
		}

		/// <summary>
		/*
		Tooltip First
		*/
		/// </summary>
		public System.String TooltipFirst
		{
			get { return m_TooltipFirst; }
			set 
			{
				m_TooltipFirst = value;
				m_IsTooltipFirstDefault = false;
			}
		}

		/// <summary>
		/*
		Image Previous
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image ImagePrevious
		{
			get
			{
				if (m_ImagePrevious == null && m_ImagePreviousReference != null)
					m_ImagePrevious = (Artech.Genexus.Common.Objects.Image)m_ImagePreviousReference.GetKBObject(Settings.Model);

				return m_ImagePrevious;
			}

			set 
			{
				m_ImagePrevious = value;
				m_ImagePreviousReference = (value != null ? new KBObjectReference(value) : null);
				m_ImagePreviousName = (value != null ? value.Name : null);
				m_IsImagePreviousDefault = false;
			}
		}

		/// <summary>
		/// ImagePrevious name.
		/// </summary>
		public string ImagePreviousName
		{
			get
			{
				if (m_ImagePreviousName == null && m_ImagePreviousReference != null)
					m_ImagePreviousName = m_ImagePreviousReference.GetName(Settings.Model);

				return m_ImagePreviousName;
			}
		}

		/// <summary>
		/*
		Image Previous Disabled
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image ImagePreviousDisabled
		{
			get
			{
				if (m_ImagePreviousDisabled == null && m_ImagePreviousDisabledReference != null)
					m_ImagePreviousDisabled = (Artech.Genexus.Common.Objects.Image)m_ImagePreviousDisabledReference.GetKBObject(Settings.Model);

				return m_ImagePreviousDisabled;
			}

			set 
			{
				m_ImagePreviousDisabled = value;
				m_ImagePreviousDisabledReference = (value != null ? new KBObjectReference(value) : null);
				m_ImagePreviousDisabledName = (value != null ? value.Name : null);
				m_IsImagePreviousDisabledDefault = false;
			}
		}

		/// <summary>
		/// ImagePreviousDisabled name.
		/// </summary>
		public string ImagePreviousDisabledName
		{
			get
			{
				if (m_ImagePreviousDisabledName == null && m_ImagePreviousDisabledReference != null)
					m_ImagePreviousDisabledName = m_ImagePreviousDisabledReference.GetName(Settings.Model);

				return m_ImagePreviousDisabledName;
			}
		}

		/// <summary>
		/*
		Tooltip Previous
		*/
		/// </summary>
		public System.String TooltipPrevious
		{
			get { return m_TooltipPrevious; }
			set 
			{
				m_TooltipPrevious = value;
				m_IsTooltipPreviousDefault = false;
			}
		}

		/// <summary>
		/*
		Image Next
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image ImageNext
		{
			get
			{
				if (m_ImageNext == null && m_ImageNextReference != null)
					m_ImageNext = (Artech.Genexus.Common.Objects.Image)m_ImageNextReference.GetKBObject(Settings.Model);

				return m_ImageNext;
			}

			set 
			{
				m_ImageNext = value;
				m_ImageNextReference = (value != null ? new KBObjectReference(value) : null);
				m_ImageNextName = (value != null ? value.Name : null);
				m_IsImageNextDefault = false;
			}
		}

		/// <summary>
		/// ImageNext name.
		/// </summary>
		public string ImageNextName
		{
			get
			{
				if (m_ImageNextName == null && m_ImageNextReference != null)
					m_ImageNextName = m_ImageNextReference.GetName(Settings.Model);

				return m_ImageNextName;
			}
		}

		/// <summary>
		/*
		Image Next Disabled
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image ImageNextDisabled
		{
			get
			{
				if (m_ImageNextDisabled == null && m_ImageNextDisabledReference != null)
					m_ImageNextDisabled = (Artech.Genexus.Common.Objects.Image)m_ImageNextDisabledReference.GetKBObject(Settings.Model);

				return m_ImageNextDisabled;
			}

			set 
			{
				m_ImageNextDisabled = value;
				m_ImageNextDisabledReference = (value != null ? new KBObjectReference(value) : null);
				m_ImageNextDisabledName = (value != null ? value.Name : null);
				m_IsImageNextDisabledDefault = false;
			}
		}

		/// <summary>
		/// ImageNextDisabled name.
		/// </summary>
		public string ImageNextDisabledName
		{
			get
			{
				if (m_ImageNextDisabledName == null && m_ImageNextDisabledReference != null)
					m_ImageNextDisabledName = m_ImageNextDisabledReference.GetName(Settings.Model);

				return m_ImageNextDisabledName;
			}
		}

		/// <summary>
		/*
		Tooltip Next
		*/
		/// </summary>
		public System.String TooltipNext
		{
			get { return m_TooltipNext; }
			set 
			{
				m_TooltipNext = value;
				m_IsTooltipNextDefault = false;
			}
		}

		/// <summary>
		/*
		Image Last
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image ImageLast
		{
			get
			{
				if (m_ImageLast == null && m_ImageLastReference != null)
					m_ImageLast = (Artech.Genexus.Common.Objects.Image)m_ImageLastReference.GetKBObject(Settings.Model);

				return m_ImageLast;
			}

			set 
			{
				m_ImageLast = value;
				m_ImageLastReference = (value != null ? new KBObjectReference(value) : null);
				m_ImageLastName = (value != null ? value.Name : null);
				m_IsImageLastDefault = false;
			}
		}

		/// <summary>
		/// ImageLast name.
		/// </summary>
		public string ImageLastName
		{
			get
			{
				if (m_ImageLastName == null && m_ImageLastReference != null)
					m_ImageLastName = m_ImageLastReference.GetName(Settings.Model);

				return m_ImageLastName;
			}
		}

		/// <summary>
		/*
		Image Last Disabled
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image ImageLastDisabled
		{
			get
			{
				if (m_ImageLastDisabled == null && m_ImageLastDisabledReference != null)
					m_ImageLastDisabled = (Artech.Genexus.Common.Objects.Image)m_ImageLastDisabledReference.GetKBObject(Settings.Model);

				return m_ImageLastDisabled;
			}

			set 
			{
				m_ImageLastDisabled = value;
				m_ImageLastDisabledReference = (value != null ? new KBObjectReference(value) : null);
				m_ImageLastDisabledName = (value != null ? value.Name : null);
				m_IsImageLastDisabledDefault = false;
			}
		}

		/// <summary>
		/// ImageLastDisabled name.
		/// </summary>
		public string ImageLastDisabledName
		{
			get
			{
				if (m_ImageLastDisabledName == null && m_ImageLastDisabledReference != null)
					m_ImageLastDisabledName = m_ImageLastDisabledReference.GetName(Settings.Model);

				return m_ImageLastDisabledName;
			}
		}

		/// <summary>
		/*
		Tooltip Last
		*/
		/// </summary>
		public System.String TooltipLast
		{
			get { return m_TooltipLast; }
			set 
			{
				m_TooltipLast = value;
				m_IsTooltipLastDefault = false;
			}
		}

		/// <summary>
		/*
		Alinhamento do Botão Insert
		*/
		/// </summary>
		public System.String InsertAlign
		{
			get { return m_InsertAlign; }
			set 
			{
				m_InsertAlign = value;
				m_IsInsertAlignDefault = false;
			}
		}

		/// <summary>
		/*
		Carrega Grid no Start, ou não somente quando clicar em procurar
		*/
		/// </summary>
		public System.Boolean LoadOnStart
		{
			get { return m_LoadOnStart; }
			set 
			{
				m_LoadOnStart = value;
				m_IsLoadOnStartDefault = false;
			}
		}

		/// <summary>
		/*
		Define se será obrigatório informar pelo menos um filtro para pesquisa
		*/
		/// </summary>
		public System.Boolean RequiredFilter
		{
			get { return m_RequiredFilter; }
			set 
			{
				m_RequiredFilter = value;
				m_IsRequiredFilterDefault = false;
			}
		}

		/// <summary>
		/*
		Define a mensagem padrão para o filtro requerido
		*/
		/// </summary>
		public System.String RequiredFilterMessage
		{
			get { return m_RequiredFilterMessage; }
			set 
			{
				m_RequiredFilterMessage = value;
				m_IsRequiredFilterMessageDefault = false;
			}
		}

		/// <summary>
		/*
		Automatic Refresh no Grid, pesquisa sem clicar no botão Pesquisar
		*/
		/// </summary>
		public System.Boolean AutomaticRefresh
		{
			get { return m_AutomaticRefresh; }
			set 
			{
				m_AutomaticRefresh = value;
				m_IsAutomaticRefreshDefault = false;
			}
		}

		/// <summary>
		/*
		CurrentPage Visivel na tela do Grid
		*/
		/// </summary>
		public System.Boolean CurrentPageVisible
		{
			get { return m_CurrentPageVisible; }
			set 
			{
				m_CurrentPageVisible = value;
				m_IsCurrentPageVisibleDefault = false;
			}
		}

		/// <summary>
		/*
		CurrentPage ComboBox para seleção do número da pagina
		*/
		/// </summary>
		public System.Boolean CurrentPageCombo
		{
			get { return m_CurrentPageCombo; }
			set 
			{
				m_CurrentPageCombo = value;
				m_IsCurrentPageComboDefault = false;
			}
		}

		/// <summary>
		/*
		Utiliza Variavel MaxPage com o total de paginas do Grid
		*/
		/// </summary>
		public System.Boolean MaxPage
		{
			get { return m_MaxPage; }
			set 
			{
				m_MaxPage = value;
				m_IsMaxPageDefault = false;
			}
		}

		/// <summary>
		/*
		Utiliza Variavel MaxRecords com o total de registros do Grid
		*/
		/// </summary>
		public System.Boolean MaxRecords
		{
			get { return m_MaxRecords; }
			set 
			{
				m_MaxRecords = value;
				m_IsMaxRecordsDefault = false;
			}
		}

		/// <summary>
		/*
		Utiliza Variavel PageRecords para definir a quantidade de registros a paginar no Grid
		*/
		/// </summary>
		public System.Boolean PageRecordsCombo
		{
			get { return m_PageRecordsCombo; }
			set 
			{
				m_PageRecordsCombo = value;
				m_IsPageRecordsComboDefault = false;
			}
		}

		/// <summary>
		/*
		Utiliza Variavel SelectedRecords para definir a quantidade de registros selecionados no Grid
		*/
		/// </summary>
		public System.Boolean SelectedRecords
		{
			get { return m_SelectedRecords; }
			set 
			{
				m_SelectedRecords = value;
				m_IsSelectedRecordsDefault = false;
			}
		}

		/// <summary>
		/*
		Utiliza Variavel CheckAll para Marcar/Desmarcar todos os registros selecionados no Grid
		*/
		/// </summary>
		public System.Boolean CheckAll
		{
			get { return m_CheckAll; }
			set 
			{
				m_CheckAll = value;
				m_IsCheckAllDefault = false;
			}
		}

		/// <summary>
		/*
		Class para utilização
		*/
		/// </summary>
		public System.String PagingVariableClass
		{
			get { return m_PagingVariableClass; }
			set 
			{
				m_PagingVariableClass = value;
				m_IsPagingVariableClassDefault = false;
			}
		}

		/// <summary>
		/*
		Gera o Auto Link para atributos
		*/
		/// </summary>
		public System.Boolean BuildAutoLink
		{
			get { return m_BuildAutoLink; }
			set 
			{
				m_BuildAutoLink = value;
				m_IsBuildAutoLinkDefault = false;
			}
		}

		/// <summary>
		/*
		Define qual o grid que será utilizado, Standard Genexus ou gxui.Grid,(Descontinuado, utilize a propriedade CustomRender)
		*/
		/// </summary>
		public System.String GridType
		{
			get { return m_GridType; }
			set 
			{
				m_GridType = value;
				m_IsGridTypeDefault = false;
			}
		}

		/// <summary>
		/*
		Use a custom user control for rendering grids. Applies to all selection and grid tab objects.
		*/
		/// </summary>
		public System.String CustomRender
		{
			get { return m_CustomRender; }
			set 
			{
				m_CustomRender = value;
				m_IsCustomRenderDefault = false;
			}
		}

		/// <summary>
		/*
		Posição das Actions do Grid GXUI
		*/
		/// </summary>
		public System.String GridGXUIActionOrientation
		{
			get { return m_GridGXUIActionOrientation; }
			set 
			{
				m_GridGXUIActionOrientation = value;
				m_IsGridGXUIActionOrientationDefault = false;
			}
		}

		/// <summary>
		/*
		Animate Collapse
		*/
		/// </summary>
		public System.Boolean AnimateCollapse
		{
			get { return m_AnimateCollapse; }
			set 
			{
				m_AnimateCollapse = value;
				m_IsAnimateCollapseDefault = false;
			}
		}

		/// <summary>
		/*
		Page Size
		*/
		/// </summary>
		public System.Int32 PageSize
		{
			get { return m_PageSize; }
			set 
			{
				m_PageSize = value;
				m_IsPageSizeDefault = false;
			}
		}

		/// <summary>
		/*
		Auto Width
		*/
		/// </summary>
		public System.Boolean AutoWidth
		{
			get { return m_AutoWidth; }
			set 
			{
				m_AutoWidth = value;
				m_IsAutoWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Width
		*/
		/// </summary>
		public System.Int32 Width
		{
			get { return m_Width; }
			set 
			{
				m_Width = value;
				m_IsWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Height
		*/
		/// </summary>
		public System.Int32 Height
		{
			get { return m_Height; }
			set 
			{
				m_Height = value;
				m_IsHeightDefault = false;
			}
		}

		/// <summary>
		/*
		Remote Sort
		*/
		/// </summary>
		public System.Boolean RemoteSort
		{
			get { return m_RemoteSort; }
			set 
			{
				m_RemoteSort = value;
				m_IsRemoteSortDefault = false;
			}
		}

		/// <summary>
		/*
		Force Fit
		*/
		/// </summary>
		public System.Boolean ForceFit
		{
			get { return m_ForceFit; }
			set 
			{
				m_ForceFit = value;
				m_IsForceFitDefault = false;
			}
		}

		/// <summary>
		/*
		Filters Text
		*/
		/// </summary>
		public System.String FiltersText
		{
			get { return m_FiltersText; }
			set 
			{
				m_FiltersText = value;
				m_IsFiltersTextDefault = false;
			}
		}

		/// <summary>
		/*
		First Text
		*/
		/// </summary>
		public System.String FirstText
		{
			get { return m_FirstText; }
			set 
			{
				m_FirstText = value;
				m_IsFirstTextDefault = false;
			}
		}

		/// <summary>
		/*
		Previous Text
		*/
		/// </summary>
		public System.String PreviousText
		{
			get { return m_PreviousText; }
			set 
			{
				m_PreviousText = value;
				m_IsPreviousTextDefault = false;
			}
		}

		/// <summary>
		/*
		Next Text
		*/
		/// </summary>
		public System.String NextText
		{
			get { return m_NextText; }
			set 
			{
				m_NextText = value;
				m_IsNextTextDefault = false;
			}
		}

		/// <summary>
		/*
		Last Text
		*/
		/// </summary>
		public System.String LastText
		{
			get { return m_LastText; }
			set 
			{
				m_LastText = value;
				m_IsLastTextDefault = false;
			}
		}

		/// <summary>
		/*
		Refresh Text
		*/
		/// </summary>
		public System.String RefreshText
		{
			get { return m_RefreshText; }
			set 
			{
				m_RefreshText = value;
				m_IsRefreshTextDefault = false;
			}
		}

		/// <summary>
		/*
		Before Page Text
		*/
		/// </summary>
		public System.String BeforePageText
		{
			get { return m_BeforePageText; }
			set 
			{
				m_BeforePageText = value;
				m_IsBeforePageTextDefault = false;
			}
		}

		/// <summary>
		/*
		After Page Text
		*/
		/// </summary>
		public System.String AfterPageText
		{
			get { return m_AfterPageText; }
			set 
			{
				m_AfterPageText = value;
				m_IsAfterPageTextDefault = false;
			}
		}

		/// <summary>
		/*
		Display Msg
		*/
		/// </summary>
		public System.String DisplayMsg
		{
			get { return m_DisplayMsg; }
			set 
			{
				m_DisplayMsg = value;
				m_IsDisplayMsgDefault = false;
			}
		}

		/// <summary>
		/*
		Empty Msg
		*/
		/// </summary>
		public System.String EmptyMsg
		{
			get { return m_EmptyMsg; }
			set 
			{
				m_EmptyMsg = value;
				m_IsEmptyMsgDefault = false;
			}
		}

		/// <summary>
		/*
		Loading Msg
		*/
		/// </summary>
		public System.String LoadingMsg
		{
			get { return m_LoadingMsg; }
			set 
			{
				m_LoadingMsg = value;
				m_IsLoadingMsgDefault = false;
			}
		}

		/// <summary>
		/*
		Tamanho minímo da coluna no grid
		*/
		/// </summary>
		public System.Int32 MinColumnWidth
		{
			get { return m_MinColumnWidth; }
			set 
			{
				m_MinColumnWidth = value;
				m_IsMinColumnWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define se o título do Grid será visivel
		*/
		/// </summary>
		public System.Boolean TitleVisible
		{
			get { return m_TitleVisible; }
			set 
			{
				m_TitleVisible = value;
				m_IsTitleVisibleDefault = false;
			}
		}

		/// <summary>
		/*
		Define a condição padrão para filtros, coringa {0} é o nome do Filtro,{1} é a variável do Filtro
		*/
		/// </summary>
		public System.String DefaultCondition
		{
			get { return m_DefaultCondition; }
			set 
			{
				m_DefaultCondition = value;
				m_IsDefaultConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Define a condição padrão para filtros Caracter, coringa {0} é o nome do Filtro,{1} é a variável do Filtro
		*/
		/// </summary>
		public System.String DefaultConditionCharacter
		{
			get { return m_DefaultConditionCharacter; }
			set 
			{
				m_DefaultConditionCharacter = value;
				m_IsDefaultConditionCharacterDefault = false;
			}
		}

		/// <summary>
		/*
		Define a condição padrão para filtros Boolean, coringa {0} é o nome do Filtro,{1} é a variável do Filtro
		*/
		/// </summary>
		public System.String DefaultConditionBoolean
		{
			get { return m_DefaultConditionBoolean; }
			set 
			{
				m_DefaultConditionBoolean = value;
				m_IsDefaultConditionBooleanDefault = false;
			}
		}

		/// <summary>
		/*
		Altera o Control Info de Radio Button para Combo Box
		*/
		/// </summary>
		public System.Boolean ChangeRadioTocombo
		{
			get { return m_ChangeRadioTocombo; }
			set 
			{
				m_ChangeRadioTocombo = value;
				m_IsChangeRadioTocomboDefault = false;
			}
		}

		/// <summary>
		/*
		Altera o filtro quando utiliza like e caracter para utilizar variavel auxiliar concatenando
		*/
		/// </summary>
		public System.Boolean ChangeLikeInVariableAux
		{
			get { return m_ChangeLikeInVariableAux; }
			set 
			{
				m_ChangeLikeInVariableAux = value;
				m_IsChangeLikeInVariableAuxDefault = false;
			}
		}

		/// <summary>
		/*
		Define o metodo de chamada ao cadastro, Link ou Popup Modal
		*/
		/// </summary>
		public System.String SelectionCallMethod
		{
			get { return m_SelectionCallMethod; }
			set 
			{
				m_SelectionCallMethod = value;
				m_IsSelectionCallMethodDefault = false;
			}
		}

		/// <summary>
		/*
		Define o metodo de chamada ao cadastro, Link ou Popup Modal
		*/
		/// </summary>
		public System.String ViewTabCallMethod
		{
			get { return m_ViewTabCallMethod; }
			set 
			{
				m_ViewTabCallMethod = value;
				m_IsViewTabCallMethodDefault = false;
			}
		}

		/// <summary>
		/*
		Define o metodo de chamada ao cadastro, Link ou Popup Modal
		*/
		/// </summary>
		public System.String PromptCallMethod
		{
			get { return m_PromptCallMethod; }
			set 
			{
				m_PromptCallMethod = value;
				m_IsPromptCallMethodDefault = false;
			}
		}

		/// <summary>
		/*
		Define o texto utilizado entre as variaveis de filtro do tipo Intervalo
		*/
		/// </summary>
		public System.String FilterIntervalText
		{
			get { return m_FilterIntervalText; }
			set 
			{
				m_FilterIntervalText = value;
				m_IsFilterIntervalTextDefault = false;
			}
		}

		/// <summary>
		/*
		Posição das Actions do Grid Standard
		*/
		/// </summary>
		public System.String GridStandardActionOrientation
		{
			get { return m_GridStandardActionOrientation; }
			set 
			{
				m_GridStandardActionOrientation = value;
				m_IsGridStandardActionOrientationDefault = false;
			}
		}

		/// <summary>
		/*
		Carrega as imagens do Grid, no evento Start ou Refresh
		*/
		/// </summary>
		public System.String GridLoadBitmaps
		{
			get { return m_GridLoadBitmaps; }
			set 
			{
				m_GridLoadBitmaps = value;
				m_IsGridLoadBitmapsDefault = false;
			}
		}

		/// <summary>
		/*
		Define o AutoResize para o Grid
		*/
		/// </summary>
		public System.Boolean AutoResize
		{
			get { return m_AutoResize; }
			set 
			{
				m_AutoResize = value;
				m_IsAutoResizeDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width(tamanho horizontal) para o Grid
		*/
		/// </summary>
		public System.String GridWidth
		{
			get { return m_GridWidth; }
			set 
			{
				m_GridWidth = value;
				m_IsGridWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Height(tamanho vertical) para o Grid
		*/
		/// </summary>
		public System.String GridHeight
		{
			get { return m_GridHeight; }
			set 
			{
				m_GridHeight = value;
				m_IsGridHeightDefault = false;
			}
		}

		/// <summary>
		/*
		Define o AllowSelection para o Grid
		*/
		/// </summary>
		public System.Boolean AllowSelection
		{
			get { return m_AllowSelection; }
			set 
			{
				m_AllowSelection = value;
				m_IsAllowSelectionDefault = false;
			}
		}

		public SettingsGridPropertiesElement GridProperties
		{
			get { return m_GridProperties; }
			set
			{
				m_GridProperties = value;
				m_GridProperties.Parent = this;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsGridElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Grid")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Grid"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Rules = element.Attributes.GetPropertyValue<System.String>("Rules");
			m_IsRulesDefault = element.Attributes.IsPropertyDefault("Rules");
			m_BackColorStyle = element.Attributes.GetPropertyValue<System.String>("BackColorStyle");
			m_IsBackColorStyleDefault = element.Attributes.IsPropertyDefault("BackColorStyle");
			m_CellSpacing = element.Attributes.GetPropertyValue<System.Int32>("CellSpacing");
			m_IsCellSpacingDefault = element.Attributes.IsPropertyDefault("CellSpacing");
			m_CellPadding = element.Attributes.GetPropertyValue<System.Int32>("CellPadding");
			m_IsCellPaddingDefault = element.Attributes.IsPropertyDefault("CellPadding");
			m_Page = element.Attributes.GetPropertyValue<System.String>("Page");
			m_IsPageDefault = element.Attributes.IsPropertyDefault("Page");
			m_SaveGridState = element.Attributes.GetPropertyValue<System.Boolean>("SaveGridState");
			m_IsSaveGridStateDefault = element.Attributes.IsPropertyDefault("SaveGridState");
			m_EnableDisablePaging = element.Attributes.GetPropertyValue<System.Boolean>("EnableDisablePaging");
			m_IsEnableDisablePagingDefault = element.Attributes.IsPropertyDefault("EnableDisablePaging");
			m_SearchButton = element.Attributes.GetPropertyValue<System.Boolean>("SearchButton");
			m_IsSearchButtonDefault = element.Attributes.IsPropertyDefault("SearchButton");
			m_SearchCaption = element.Attributes.GetPropertyValue<System.String>("SearchCaption");
			m_IsSearchCaptionDefault = element.Attributes.IsPropertyDefault("SearchCaption");
			m_SearchLegend = element.Attributes.GetPropertyValue<System.String>("SearchLegend");
			m_IsSearchLegendDefault = element.Attributes.IsPropertyDefault("SearchLegend");
			m_ClearButton = element.Attributes.GetPropertyValue<System.Boolean>("ClearButton");
			m_IsClearButtonDefault = element.Attributes.IsPropertyDefault("ClearButton");
			m_ClearCaption = element.Attributes.GetPropertyValue<System.String>("ClearCaption");
			m_IsClearCaptionDefault = element.Attributes.IsPropertyDefault("ClearCaption");
			m_ClearLegend = element.Attributes.GetPropertyValue<System.String>("ClearLegend");
			m_IsClearLegendDefault = element.Attributes.IsPropertyDefault("ClearLegend");
			m_ButtonsAlign = element.Attributes.GetPropertyValue<System.String>("ButtonsAlign");
			m_IsButtonsAlignDefault = element.Attributes.IsPropertyDefault("ButtonsAlign");
			m_DefaultPagingButtons = element.Attributes.GetPropertyValue<System.Boolean>("DefaultPagingButtons");
			m_IsDefaultPagingButtonsDefault = element.Attributes.IsPropertyDefault("DefaultPagingButtons");
			m_ImageFirstReference = element.Attributes.GetPropertyValue<KBObjectReference>("ImageFirstReference");
			m_IsImageFirstDefault = element.Attributes.IsPropertyDefault("ImageFirst");
			m_ImageFirstDisabledReference = element.Attributes.GetPropertyValue<KBObjectReference>("ImageFirstDisabledReference");
			m_IsImageFirstDisabledDefault = element.Attributes.IsPropertyDefault("ImageFirstDisabled");
			m_TooltipFirst = element.Attributes.GetPropertyValue<System.String>("TooltipFirst");
			m_IsTooltipFirstDefault = element.Attributes.IsPropertyDefault("TooltipFirst");
			m_ImagePreviousReference = element.Attributes.GetPropertyValue<KBObjectReference>("ImagePreviousReference");
			m_IsImagePreviousDefault = element.Attributes.IsPropertyDefault("ImagePrevious");
			m_ImagePreviousDisabledReference = element.Attributes.GetPropertyValue<KBObjectReference>("ImagePreviousDisabledReference");
			m_IsImagePreviousDisabledDefault = element.Attributes.IsPropertyDefault("ImagePreviousDisabled");
			m_TooltipPrevious = element.Attributes.GetPropertyValue<System.String>("TooltipPrevious");
			m_IsTooltipPreviousDefault = element.Attributes.IsPropertyDefault("TooltipPrevious");
			m_ImageNextReference = element.Attributes.GetPropertyValue<KBObjectReference>("ImageNextReference");
			m_IsImageNextDefault = element.Attributes.IsPropertyDefault("ImageNext");
			m_ImageNextDisabledReference = element.Attributes.GetPropertyValue<KBObjectReference>("ImageNextDisabledReference");
			m_IsImageNextDisabledDefault = element.Attributes.IsPropertyDefault("ImageNextDisabled");
			m_TooltipNext = element.Attributes.GetPropertyValue<System.String>("TooltipNext");
			m_IsTooltipNextDefault = element.Attributes.IsPropertyDefault("TooltipNext");
			m_ImageLastReference = element.Attributes.GetPropertyValue<KBObjectReference>("ImageLastReference");
			m_IsImageLastDefault = element.Attributes.IsPropertyDefault("ImageLast");
			m_ImageLastDisabledReference = element.Attributes.GetPropertyValue<KBObjectReference>("ImageLastDisabledReference");
			m_IsImageLastDisabledDefault = element.Attributes.IsPropertyDefault("ImageLastDisabled");
			m_TooltipLast = element.Attributes.GetPropertyValue<System.String>("TooltipLast");
			m_IsTooltipLastDefault = element.Attributes.IsPropertyDefault("TooltipLast");
			m_InsertAlign = element.Attributes.GetPropertyValue<System.String>("InsertAlign");
			m_IsInsertAlignDefault = element.Attributes.IsPropertyDefault("InsertAlign");
			m_LoadOnStart = element.Attributes.GetPropertyValue<System.Boolean>("LoadOnStart");
			m_IsLoadOnStartDefault = element.Attributes.IsPropertyDefault("LoadOnStart");
			m_RequiredFilter = element.Attributes.GetPropertyValue<System.Boolean>("RequiredFilter");
			m_IsRequiredFilterDefault = element.Attributes.IsPropertyDefault("RequiredFilter");
			m_RequiredFilterMessage = element.Attributes.GetPropertyValue<System.String>("RequiredFilterMessage");
			m_IsRequiredFilterMessageDefault = element.Attributes.IsPropertyDefault("RequiredFilterMessage");
			m_AutomaticRefresh = element.Attributes.GetPropertyValue<System.Boolean>("AutomaticRefresh");
			m_IsAutomaticRefreshDefault = element.Attributes.IsPropertyDefault("AutomaticRefresh");
			m_CurrentPageVisible = element.Attributes.GetPropertyValue<System.Boolean>("CurrentPageVisible");
			m_IsCurrentPageVisibleDefault = element.Attributes.IsPropertyDefault("CurrentPageVisible");
			m_CurrentPageCombo = element.Attributes.GetPropertyValue<System.Boolean>("CurrentPageCombo");
			m_IsCurrentPageComboDefault = element.Attributes.IsPropertyDefault("CurrentPageCombo");
			m_MaxPage = element.Attributes.GetPropertyValue<System.Boolean>("MaxPage");
			m_IsMaxPageDefault = element.Attributes.IsPropertyDefault("MaxPage");
			m_MaxRecords = element.Attributes.GetPropertyValue<System.Boolean>("MaxRecords");
			m_IsMaxRecordsDefault = element.Attributes.IsPropertyDefault("MaxRecords");
			m_PageRecordsCombo = element.Attributes.GetPropertyValue<System.Boolean>("PageRecordsCombo");
			m_IsPageRecordsComboDefault = element.Attributes.IsPropertyDefault("PageRecordsCombo");
			m_SelectedRecords = element.Attributes.GetPropertyValue<System.Boolean>("SelectedRecords");
			m_IsSelectedRecordsDefault = element.Attributes.IsPropertyDefault("SelectedRecords");
			m_CheckAll = element.Attributes.GetPropertyValue<System.Boolean>("CheckAll");
			m_IsCheckAllDefault = element.Attributes.IsPropertyDefault("CheckAll");
			m_PagingVariableClass = element.Attributes.GetPropertyValue<System.String>("PagingVariableClass");
			m_IsPagingVariableClassDefault = element.Attributes.IsPropertyDefault("PagingVariableClass");
			m_BuildAutoLink = element.Attributes.GetPropertyValue<System.Boolean>("BuildAutoLink");
			m_IsBuildAutoLinkDefault = element.Attributes.IsPropertyDefault("BuildAutoLink");
			m_GridType = element.Attributes.GetPropertyValue<System.String>("GridType");
			m_IsGridTypeDefault = element.Attributes.IsPropertyDefault("GridType");
			m_CustomRender = element.Attributes.GetPropertyValue<System.String>("CustomRender");
			m_IsCustomRenderDefault = element.Attributes.IsPropertyDefault("CustomRender");
			m_GridGXUIActionOrientation = element.Attributes.GetPropertyValue<System.String>("GridGXUIActionOrientation");
			m_IsGridGXUIActionOrientationDefault = element.Attributes.IsPropertyDefault("GridGXUIActionOrientation");
			m_AnimateCollapse = element.Attributes.GetPropertyValue<System.Boolean>("AnimateCollapse");
			m_IsAnimateCollapseDefault = element.Attributes.IsPropertyDefault("AnimateCollapse");
			m_PageSize = element.Attributes.GetPropertyValue<System.Int32>("PageSize");
			m_IsPageSizeDefault = element.Attributes.IsPropertyDefault("PageSize");
			m_AutoWidth = element.Attributes.GetPropertyValue<System.Boolean>("AutoWidth");
			m_IsAutoWidthDefault = element.Attributes.IsPropertyDefault("AutoWidth");
			m_Width = element.Attributes.GetPropertyValue<System.Int32>("Width");
			m_IsWidthDefault = element.Attributes.IsPropertyDefault("Width");
			m_Height = element.Attributes.GetPropertyValue<System.Int32>("Height");
			m_IsHeightDefault = element.Attributes.IsPropertyDefault("Height");
			m_RemoteSort = element.Attributes.GetPropertyValue<System.Boolean>("RemoteSort");
			m_IsRemoteSortDefault = element.Attributes.IsPropertyDefault("RemoteSort");
			m_ForceFit = element.Attributes.GetPropertyValue<System.Boolean>("ForceFit");
			m_IsForceFitDefault = element.Attributes.IsPropertyDefault("ForceFit");
			m_FiltersText = element.Attributes.GetPropertyValue<System.String>("FiltersText");
			m_IsFiltersTextDefault = element.Attributes.IsPropertyDefault("FiltersText");
			m_FirstText = element.Attributes.GetPropertyValue<System.String>("FirstText");
			m_IsFirstTextDefault = element.Attributes.IsPropertyDefault("FirstText");
			m_PreviousText = element.Attributes.GetPropertyValue<System.String>("PreviousText");
			m_IsPreviousTextDefault = element.Attributes.IsPropertyDefault("PreviousText");
			m_NextText = element.Attributes.GetPropertyValue<System.String>("NextText");
			m_IsNextTextDefault = element.Attributes.IsPropertyDefault("NextText");
			m_LastText = element.Attributes.GetPropertyValue<System.String>("LastText");
			m_IsLastTextDefault = element.Attributes.IsPropertyDefault("LastText");
			m_RefreshText = element.Attributes.GetPropertyValue<System.String>("RefreshText");
			m_IsRefreshTextDefault = element.Attributes.IsPropertyDefault("RefreshText");
			m_BeforePageText = element.Attributes.GetPropertyValue<System.String>("BeforePageText");
			m_IsBeforePageTextDefault = element.Attributes.IsPropertyDefault("BeforePageText");
			m_AfterPageText = element.Attributes.GetPropertyValue<System.String>("AfterPageText");
			m_IsAfterPageTextDefault = element.Attributes.IsPropertyDefault("AfterPageText");
			m_DisplayMsg = element.Attributes.GetPropertyValue<System.String>("DisplayMsg");
			m_IsDisplayMsgDefault = element.Attributes.IsPropertyDefault("DisplayMsg");
			m_EmptyMsg = element.Attributes.GetPropertyValue<System.String>("EmptyMsg");
			m_IsEmptyMsgDefault = element.Attributes.IsPropertyDefault("EmptyMsg");
			m_LoadingMsg = element.Attributes.GetPropertyValue<System.String>("LoadingMsg");
			m_IsLoadingMsgDefault = element.Attributes.IsPropertyDefault("LoadingMsg");
			m_MinColumnWidth = element.Attributes.GetPropertyValue<System.Int32>("MinColumnWidth");
			m_IsMinColumnWidthDefault = element.Attributes.IsPropertyDefault("MinColumnWidth");
			m_TitleVisible = element.Attributes.GetPropertyValue<System.Boolean>("TitleVisible");
			m_IsTitleVisibleDefault = element.Attributes.IsPropertyDefault("TitleVisible");
			m_DefaultCondition = element.Attributes.GetPropertyValue<System.String>("DefaultCondition");
			m_IsDefaultConditionDefault = element.Attributes.IsPropertyDefault("DefaultCondition");
			m_DefaultConditionCharacter = element.Attributes.GetPropertyValue<System.String>("DefaultConditionCharacter");
			m_IsDefaultConditionCharacterDefault = element.Attributes.IsPropertyDefault("DefaultConditionCharacter");
			m_DefaultConditionBoolean = element.Attributes.GetPropertyValue<System.String>("DefaultConditionBoolean");
			m_IsDefaultConditionBooleanDefault = element.Attributes.IsPropertyDefault("DefaultConditionBoolean");
			m_ChangeRadioTocombo = element.Attributes.GetPropertyValue<System.Boolean>("ChangeRadioTocombo");
			m_IsChangeRadioTocomboDefault = element.Attributes.IsPropertyDefault("ChangeRadioTocombo");
			m_ChangeLikeInVariableAux = element.Attributes.GetPropertyValue<System.Boolean>("ChangeLikeInVariableAux");
			m_IsChangeLikeInVariableAuxDefault = element.Attributes.IsPropertyDefault("ChangeLikeInVariableAux");
			m_SelectionCallMethod = element.Attributes.GetPropertyValue<System.String>("SelectionCallMethod");
			m_IsSelectionCallMethodDefault = element.Attributes.IsPropertyDefault("SelectionCallMethod");
			m_ViewTabCallMethod = element.Attributes.GetPropertyValue<System.String>("ViewTabCallMethod");
			m_IsViewTabCallMethodDefault = element.Attributes.IsPropertyDefault("ViewTabCallMethod");
			m_PromptCallMethod = element.Attributes.GetPropertyValue<System.String>("PromptCallMethod");
			m_IsPromptCallMethodDefault = element.Attributes.IsPropertyDefault("PromptCallMethod");
			m_FilterIntervalText = element.Attributes.GetPropertyValue<System.String>("FilterIntervalText");
			m_IsFilterIntervalTextDefault = element.Attributes.IsPropertyDefault("FilterIntervalText");
			m_GridStandardActionOrientation = element.Attributes.GetPropertyValue<System.String>("GridStandardActionOrientation");
			m_IsGridStandardActionOrientationDefault = element.Attributes.IsPropertyDefault("GridStandardActionOrientation");
			m_GridLoadBitmaps = element.Attributes.GetPropertyValue<System.String>("GridLoadBitmaps");
			m_IsGridLoadBitmapsDefault = element.Attributes.IsPropertyDefault("GridLoadBitmaps");
			m_AutoResize = element.Attributes.GetPropertyValue<System.Boolean>("AutoResize");
			m_IsAutoResizeDefault = element.Attributes.IsPropertyDefault("AutoResize");
			m_GridWidth = element.Attributes.GetPropertyValue<System.String>("GridWidth");
			m_IsGridWidthDefault = element.Attributes.IsPropertyDefault("GridWidth");
			m_GridHeight = element.Attributes.GetPropertyValue<System.String>("GridHeight");
			m_IsGridHeightDefault = element.Attributes.IsPropertyDefault("GridHeight");
			m_AllowSelection = element.Attributes.GetPropertyValue<System.Boolean>("AllowSelection");
			m_IsAllowSelectionDefault = element.Attributes.IsPropertyDefault("AllowSelection");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "GridProperties" :
					{
						SettingsGridPropertiesElement gridProperties = new SettingsGridPropertiesElement();
						gridProperties.LoadFrom(_childElement);
						GridProperties = gridProperties;
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="SettingsGridElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Grid")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Grid"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "Rules", m_Rules, m_IsRulesDefault);
			SaveAttribute(element, "BackColorStyle", m_BackColorStyle, m_IsBackColorStyleDefault);
			SaveAttribute(element, "CellSpacing", m_CellSpacing, m_IsCellSpacingDefault);
			SaveAttribute(element, "CellPadding", m_CellPadding, m_IsCellPaddingDefault);
			SaveAttribute(element, "Page", m_Page, m_IsPageDefault);
			SaveAttribute(element, "SaveGridState", m_SaveGridState, m_IsSaveGridStateDefault);
			SaveAttribute(element, "EnableDisablePaging", m_EnableDisablePaging, m_IsEnableDisablePagingDefault);
			SaveAttribute(element, "SearchButton", m_SearchButton, m_IsSearchButtonDefault);
			SaveAttribute(element, "SearchCaption", m_SearchCaption, m_IsSearchCaptionDefault);
			SaveAttribute(element, "SearchLegend", m_SearchLegend, m_IsSearchLegendDefault);
			SaveAttribute(element, "ClearButton", m_ClearButton, m_IsClearButtonDefault);
			SaveAttribute(element, "ClearCaption", m_ClearCaption, m_IsClearCaptionDefault);
			SaveAttribute(element, "ClearLegend", m_ClearLegend, m_IsClearLegendDefault);
			SaveAttribute(element, "ButtonsAlign", m_ButtonsAlign, m_IsButtonsAlignDefault);
			SaveAttribute(element, "DefaultPagingButtons", m_DefaultPagingButtons, m_IsDefaultPagingButtonsDefault);
			SaveAttribute(element, "ImageFirstReference", m_ImageFirstReference, m_IsImageFirstDefault);
			SaveAttribute(element, "ImageFirstDisabledReference", m_ImageFirstDisabledReference, m_IsImageFirstDisabledDefault);
			SaveAttribute(element, "TooltipFirst", m_TooltipFirst, m_IsTooltipFirstDefault);
			SaveAttribute(element, "ImagePreviousReference", m_ImagePreviousReference, m_IsImagePreviousDefault);
			SaveAttribute(element, "ImagePreviousDisabledReference", m_ImagePreviousDisabledReference, m_IsImagePreviousDisabledDefault);
			SaveAttribute(element, "TooltipPrevious", m_TooltipPrevious, m_IsTooltipPreviousDefault);
			SaveAttribute(element, "ImageNextReference", m_ImageNextReference, m_IsImageNextDefault);
			SaveAttribute(element, "ImageNextDisabledReference", m_ImageNextDisabledReference, m_IsImageNextDisabledDefault);
			SaveAttribute(element, "TooltipNext", m_TooltipNext, m_IsTooltipNextDefault);
			SaveAttribute(element, "ImageLastReference", m_ImageLastReference, m_IsImageLastDefault);
			SaveAttribute(element, "ImageLastDisabledReference", m_ImageLastDisabledReference, m_IsImageLastDisabledDefault);
			SaveAttribute(element, "TooltipLast", m_TooltipLast, m_IsTooltipLastDefault);
			SaveAttribute(element, "InsertAlign", m_InsertAlign, m_IsInsertAlignDefault);
			SaveAttribute(element, "LoadOnStart", m_LoadOnStart, m_IsLoadOnStartDefault);
			SaveAttribute(element, "RequiredFilter", m_RequiredFilter, m_IsRequiredFilterDefault);
			SaveAttribute(element, "RequiredFilterMessage", m_RequiredFilterMessage, m_IsRequiredFilterMessageDefault);
			SaveAttribute(element, "AutomaticRefresh", m_AutomaticRefresh, m_IsAutomaticRefreshDefault);
			SaveAttribute(element, "CurrentPageVisible", m_CurrentPageVisible, m_IsCurrentPageVisibleDefault);
			SaveAttribute(element, "CurrentPageCombo", m_CurrentPageCombo, m_IsCurrentPageComboDefault);
			SaveAttribute(element, "MaxPage", m_MaxPage, m_IsMaxPageDefault);
			SaveAttribute(element, "MaxRecords", m_MaxRecords, m_IsMaxRecordsDefault);
			SaveAttribute(element, "PageRecordsCombo", m_PageRecordsCombo, m_IsPageRecordsComboDefault);
			SaveAttribute(element, "SelectedRecords", m_SelectedRecords, m_IsSelectedRecordsDefault);
			SaveAttribute(element, "CheckAll", m_CheckAll, m_IsCheckAllDefault);
			SaveAttribute(element, "PagingVariableClass", m_PagingVariableClass, m_IsPagingVariableClassDefault);
			SaveAttribute(element, "BuildAutoLink", m_BuildAutoLink, m_IsBuildAutoLinkDefault);
			SaveAttribute(element, "GridType", m_GridType, m_IsGridTypeDefault);
			SaveAttribute(element, "CustomRender", m_CustomRender, m_IsCustomRenderDefault);
			SaveAttribute(element, "GridGXUIActionOrientation", m_GridGXUIActionOrientation, m_IsGridGXUIActionOrientationDefault);
			SaveAttribute(element, "AnimateCollapse", m_AnimateCollapse, m_IsAnimateCollapseDefault);
			SaveAttribute(element, "PageSize", m_PageSize, m_IsPageSizeDefault);
			SaveAttribute(element, "AutoWidth", m_AutoWidth, m_IsAutoWidthDefault);
			SaveAttribute(element, "Width", m_Width, m_IsWidthDefault);
			SaveAttribute(element, "Height", m_Height, m_IsHeightDefault);
			SaveAttribute(element, "RemoteSort", m_RemoteSort, m_IsRemoteSortDefault);
			SaveAttribute(element, "ForceFit", m_ForceFit, m_IsForceFitDefault);
			SaveAttribute(element, "FiltersText", m_FiltersText, m_IsFiltersTextDefault);
			SaveAttribute(element, "FirstText", m_FirstText, m_IsFirstTextDefault);
			SaveAttribute(element, "PreviousText", m_PreviousText, m_IsPreviousTextDefault);
			SaveAttribute(element, "NextText", m_NextText, m_IsNextTextDefault);
			SaveAttribute(element, "LastText", m_LastText, m_IsLastTextDefault);
			SaveAttribute(element, "RefreshText", m_RefreshText, m_IsRefreshTextDefault);
			SaveAttribute(element, "BeforePageText", m_BeforePageText, m_IsBeforePageTextDefault);
			SaveAttribute(element, "AfterPageText", m_AfterPageText, m_IsAfterPageTextDefault);
			SaveAttribute(element, "DisplayMsg", m_DisplayMsg, m_IsDisplayMsgDefault);
			SaveAttribute(element, "EmptyMsg", m_EmptyMsg, m_IsEmptyMsgDefault);
			SaveAttribute(element, "LoadingMsg", m_LoadingMsg, m_IsLoadingMsgDefault);
			SaveAttribute(element, "MinColumnWidth", m_MinColumnWidth, m_IsMinColumnWidthDefault);
			SaveAttribute(element, "TitleVisible", m_TitleVisible, m_IsTitleVisibleDefault);
			SaveAttribute(element, "DefaultCondition", m_DefaultCondition, m_IsDefaultConditionDefault);
			SaveAttribute(element, "DefaultConditionCharacter", m_DefaultConditionCharacter, m_IsDefaultConditionCharacterDefault);
			SaveAttribute(element, "DefaultConditionBoolean", m_DefaultConditionBoolean, m_IsDefaultConditionBooleanDefault);
			SaveAttribute(element, "ChangeRadioTocombo", m_ChangeRadioTocombo, m_IsChangeRadioTocomboDefault);
			SaveAttribute(element, "ChangeLikeInVariableAux", m_ChangeLikeInVariableAux, m_IsChangeLikeInVariableAuxDefault);
			SaveAttribute(element, "SelectionCallMethod", m_SelectionCallMethod, m_IsSelectionCallMethodDefault);
			SaveAttribute(element, "ViewTabCallMethod", m_ViewTabCallMethod, m_IsViewTabCallMethodDefault);
			SaveAttribute(element, "PromptCallMethod", m_PromptCallMethod, m_IsPromptCallMethodDefault);
			SaveAttribute(element, "FilterIntervalText", m_FilterIntervalText, m_IsFilterIntervalTextDefault);
			SaveAttribute(element, "GridStandardActionOrientation", m_GridStandardActionOrientation, m_IsGridStandardActionOrientationDefault);
			SaveAttribute(element, "GridLoadBitmaps", m_GridLoadBitmaps, m_IsGridLoadBitmapsDefault);
			SaveAttribute(element, "AutoResize", m_AutoResize, m_IsAutoResizeDefault);
			SaveAttribute(element, "GridWidth", m_GridWidth, m_IsGridWidthDefault);
			SaveAttribute(element, "GridHeight", m_GridHeight, m_IsGridHeightDefault);
			SaveAttribute(element, "AllowSelection", m_AllowSelection, m_IsAllowSelectionDefault);

			Debug.Assert(m_Rules == element.Attributes.GetPropertyValue<System.String>("Rules"));
			Debug.Assert(m_BackColorStyle == element.Attributes.GetPropertyValue<System.String>("BackColorStyle"));
			Debug.Assert(m_CellSpacing == element.Attributes.GetPropertyValue<System.Int32>("CellSpacing"));
			Debug.Assert(m_CellPadding == element.Attributes.GetPropertyValue<System.Int32>("CellPadding"));
			Debug.Assert(m_Page == element.Attributes.GetPropertyValue<System.String>("Page"));
			Debug.Assert(m_SaveGridState == element.Attributes.GetPropertyValue<System.Boolean>("SaveGridState"));
			Debug.Assert(m_EnableDisablePaging == element.Attributes.GetPropertyValue<System.Boolean>("EnableDisablePaging"));
			Debug.Assert(m_SearchButton == element.Attributes.GetPropertyValue<System.Boolean>("SearchButton"));
			Debug.Assert(m_SearchCaption == element.Attributes.GetPropertyValue<System.String>("SearchCaption"));
			Debug.Assert(m_SearchLegend == element.Attributes.GetPropertyValue<System.String>("SearchLegend"));
			Debug.Assert(m_ClearButton == element.Attributes.GetPropertyValue<System.Boolean>("ClearButton"));
			Debug.Assert(m_ClearCaption == element.Attributes.GetPropertyValue<System.String>("ClearCaption"));
			Debug.Assert(m_ClearLegend == element.Attributes.GetPropertyValue<System.String>("ClearLegend"));
			Debug.Assert(m_ButtonsAlign == element.Attributes.GetPropertyValue<System.String>("ButtonsAlign"));
			Debug.Assert(m_DefaultPagingButtons == element.Attributes.GetPropertyValue<System.Boolean>("DefaultPagingButtons"));
			Debug.Assert(m_ImageFirstReference == element.Attributes.GetPropertyValue<KBObjectReference>("ImageFirstReference"));
			Debug.Assert(m_ImageFirstDisabledReference == element.Attributes.GetPropertyValue<KBObjectReference>("ImageFirstDisabledReference"));
			Debug.Assert(m_TooltipFirst == element.Attributes.GetPropertyValue<System.String>("TooltipFirst"));
			Debug.Assert(m_ImagePreviousReference == element.Attributes.GetPropertyValue<KBObjectReference>("ImagePreviousReference"));
			Debug.Assert(m_ImagePreviousDisabledReference == element.Attributes.GetPropertyValue<KBObjectReference>("ImagePreviousDisabledReference"));
			Debug.Assert(m_TooltipPrevious == element.Attributes.GetPropertyValue<System.String>("TooltipPrevious"));
			Debug.Assert(m_ImageNextReference == element.Attributes.GetPropertyValue<KBObjectReference>("ImageNextReference"));
			Debug.Assert(m_ImageNextDisabledReference == element.Attributes.GetPropertyValue<KBObjectReference>("ImageNextDisabledReference"));
			Debug.Assert(m_TooltipNext == element.Attributes.GetPropertyValue<System.String>("TooltipNext"));
			Debug.Assert(m_ImageLastReference == element.Attributes.GetPropertyValue<KBObjectReference>("ImageLastReference"));
			Debug.Assert(m_ImageLastDisabledReference == element.Attributes.GetPropertyValue<KBObjectReference>("ImageLastDisabledReference"));
			Debug.Assert(m_TooltipLast == element.Attributes.GetPropertyValue<System.String>("TooltipLast"));
			Debug.Assert(m_InsertAlign == element.Attributes.GetPropertyValue<System.String>("InsertAlign"));
			Debug.Assert(m_LoadOnStart == element.Attributes.GetPropertyValue<System.Boolean>("LoadOnStart"));
			Debug.Assert(m_RequiredFilter == element.Attributes.GetPropertyValue<System.Boolean>("RequiredFilter"));
			Debug.Assert(m_RequiredFilterMessage == element.Attributes.GetPropertyValue<System.String>("RequiredFilterMessage"));
			Debug.Assert(m_AutomaticRefresh == element.Attributes.GetPropertyValue<System.Boolean>("AutomaticRefresh"));
			Debug.Assert(m_CurrentPageVisible == element.Attributes.GetPropertyValue<System.Boolean>("CurrentPageVisible"));
			Debug.Assert(m_CurrentPageCombo == element.Attributes.GetPropertyValue<System.Boolean>("CurrentPageCombo"));
			Debug.Assert(m_MaxPage == element.Attributes.GetPropertyValue<System.Boolean>("MaxPage"));
			Debug.Assert(m_MaxRecords == element.Attributes.GetPropertyValue<System.Boolean>("MaxRecords"));
			Debug.Assert(m_PageRecordsCombo == element.Attributes.GetPropertyValue<System.Boolean>("PageRecordsCombo"));
			Debug.Assert(m_SelectedRecords == element.Attributes.GetPropertyValue<System.Boolean>("SelectedRecords"));
			Debug.Assert(m_CheckAll == element.Attributes.GetPropertyValue<System.Boolean>("CheckAll"));
			Debug.Assert(m_PagingVariableClass == element.Attributes.GetPropertyValue<System.String>("PagingVariableClass"));
			Debug.Assert(m_BuildAutoLink == element.Attributes.GetPropertyValue<System.Boolean>("BuildAutoLink"));
			Debug.Assert(m_GridType == element.Attributes.GetPropertyValue<System.String>("GridType"));
			Debug.Assert(m_GridGXUIActionOrientation == element.Attributes.GetPropertyValue<System.String>("GridGXUIActionOrientation"));
			Debug.Assert(m_AnimateCollapse == element.Attributes.GetPropertyValue<System.Boolean>("AnimateCollapse"));
			Debug.Assert(m_PageSize == element.Attributes.GetPropertyValue<System.Int32>("PageSize"));
			Debug.Assert(m_AutoWidth == element.Attributes.GetPropertyValue<System.Boolean>("AutoWidth"));
			Debug.Assert(m_Width == element.Attributes.GetPropertyValue<System.Int32>("Width"));
			Debug.Assert(m_Height == element.Attributes.GetPropertyValue<System.Int32>("Height"));
			Debug.Assert(m_RemoteSort == element.Attributes.GetPropertyValue<System.Boolean>("RemoteSort"));
			Debug.Assert(m_ForceFit == element.Attributes.GetPropertyValue<System.Boolean>("ForceFit"));
			Debug.Assert(m_FiltersText == element.Attributes.GetPropertyValue<System.String>("FiltersText"));
			Debug.Assert(m_FirstText == element.Attributes.GetPropertyValue<System.String>("FirstText"));
			Debug.Assert(m_PreviousText == element.Attributes.GetPropertyValue<System.String>("PreviousText"));
			Debug.Assert(m_NextText == element.Attributes.GetPropertyValue<System.String>("NextText"));
			Debug.Assert(m_LastText == element.Attributes.GetPropertyValue<System.String>("LastText"));
			Debug.Assert(m_RefreshText == element.Attributes.GetPropertyValue<System.String>("RefreshText"));
			Debug.Assert(m_BeforePageText == element.Attributes.GetPropertyValue<System.String>("BeforePageText"));
			Debug.Assert(m_AfterPageText == element.Attributes.GetPropertyValue<System.String>("AfterPageText"));
			Debug.Assert(m_DisplayMsg == element.Attributes.GetPropertyValue<System.String>("DisplayMsg"));
			Debug.Assert(m_EmptyMsg == element.Attributes.GetPropertyValue<System.String>("EmptyMsg"));
			Debug.Assert(m_LoadingMsg == element.Attributes.GetPropertyValue<System.String>("LoadingMsg"));
			Debug.Assert(m_MinColumnWidth == element.Attributes.GetPropertyValue<System.Int32>("MinColumnWidth"));
			Debug.Assert(m_TitleVisible == element.Attributes.GetPropertyValue<System.Boolean>("TitleVisible"));
			Debug.Assert(m_DefaultCondition == element.Attributes.GetPropertyValue<System.String>("DefaultCondition"));
			Debug.Assert(m_DefaultConditionCharacter == element.Attributes.GetPropertyValue<System.String>("DefaultConditionCharacter"));
			Debug.Assert(m_DefaultConditionBoolean == element.Attributes.GetPropertyValue<System.String>("DefaultConditionBoolean"));
			Debug.Assert(m_ChangeRadioTocombo == element.Attributes.GetPropertyValue<System.Boolean>("ChangeRadioTocombo"));
			Debug.Assert(m_ChangeLikeInVariableAux == element.Attributes.GetPropertyValue<System.Boolean>("ChangeLikeInVariableAux"));
			Debug.Assert(m_SelectionCallMethod == element.Attributes.GetPropertyValue<System.String>("SelectionCallMethod"));
			Debug.Assert(m_ViewTabCallMethod == element.Attributes.GetPropertyValue<System.String>("ViewTabCallMethod"));
			Debug.Assert(m_PromptCallMethod == element.Attributes.GetPropertyValue<System.String>("PromptCallMethod"));
			Debug.Assert(m_FilterIntervalText == element.Attributes.GetPropertyValue<System.String>("FilterIntervalText"));
			Debug.Assert(m_GridStandardActionOrientation == element.Attributes.GetPropertyValue<System.String>("GridStandardActionOrientation"));
			Debug.Assert(m_GridLoadBitmaps == element.Attributes.GetPropertyValue<System.String>("GridLoadBitmaps"));
			Debug.Assert(m_AutoResize == element.Attributes.GetPropertyValue<System.Boolean>("AutoResize"));
			Debug.Assert(m_GridWidth == element.Attributes.GetPropertyValue<System.String>("GridWidth"));
			Debug.Assert(m_GridHeight == element.Attributes.GetPropertyValue<System.String>("GridHeight"));
			Debug.Assert(m_AllowSelection == element.Attributes.GetPropertyValue<System.Boolean>("AllowSelection"));

			// Save element children.
			if (m_GridProperties != null)
			{
				PatternInstanceElement gridProperties = element.Children.AddNewElement("GridProperties");
				m_GridProperties.SaveTo(gridProperties);
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsGridElement"/>.
		/// </summary>
		public SettingsGridElement Clone()
		{
			SettingsGridElement clone = new SettingsGridElement();

			clone.Rules = this.Rules;
			clone.BackColorStyle = this.BackColorStyle;
			clone.CellSpacing = this.CellSpacing;
			clone.CellPadding = this.CellPadding;
			clone.Page = this.Page;
			clone.SaveGridState = this.SaveGridState;
			clone.EnableDisablePaging = this.EnableDisablePaging;
			clone.SearchButton = this.SearchButton;
			clone.SearchCaption = this.SearchCaption;
			clone.SearchLegend = this.SearchLegend;
			clone.ClearButton = this.ClearButton;
			clone.ClearCaption = this.ClearCaption;
			clone.ClearLegend = this.ClearLegend;
			clone.ButtonsAlign = this.ButtonsAlign;
			clone.DefaultPagingButtons = this.DefaultPagingButtons;
			clone.ImageFirst = this.ImageFirst;
			clone.ImageFirstDisabled = this.ImageFirstDisabled;
			clone.TooltipFirst = this.TooltipFirst;
			clone.ImagePrevious = this.ImagePrevious;
			clone.ImagePreviousDisabled = this.ImagePreviousDisabled;
			clone.TooltipPrevious = this.TooltipPrevious;
			clone.ImageNext = this.ImageNext;
			clone.ImageNextDisabled = this.ImageNextDisabled;
			clone.TooltipNext = this.TooltipNext;
			clone.ImageLast = this.ImageLast;
			clone.ImageLastDisabled = this.ImageLastDisabled;
			clone.TooltipLast = this.TooltipLast;
			clone.InsertAlign = this.InsertAlign;
			clone.LoadOnStart = this.LoadOnStart;
			clone.RequiredFilter = this.RequiredFilter;
			clone.RequiredFilterMessage = this.RequiredFilterMessage;
			clone.AutomaticRefresh = this.AutomaticRefresh;
			clone.CurrentPageVisible = this.CurrentPageVisible;
			clone.CurrentPageCombo = this.CurrentPageCombo;
			clone.MaxPage = this.MaxPage;
			clone.MaxRecords = this.MaxRecords;
			clone.PageRecordsCombo = this.PageRecordsCombo;
			clone.SelectedRecords = this.SelectedRecords;
			clone.CheckAll = this.CheckAll;
			clone.PagingVariableClass = this.PagingVariableClass;
			clone.BuildAutoLink = this.BuildAutoLink;
			clone.GridType = this.GridType;
			clone.CustomRender = this.CustomRender;
			clone.GridGXUIActionOrientation = this.GridGXUIActionOrientation;
			clone.AnimateCollapse = this.AnimateCollapse;
			clone.PageSize = this.PageSize;
			clone.AutoWidth = this.AutoWidth;
			clone.Width = this.Width;
			clone.Height = this.Height;
			clone.RemoteSort = this.RemoteSort;
			clone.ForceFit = this.ForceFit;
			clone.FiltersText = this.FiltersText;
			clone.FirstText = this.FirstText;
			clone.PreviousText = this.PreviousText;
			clone.NextText = this.NextText;
			clone.LastText = this.LastText;
			clone.RefreshText = this.RefreshText;
			clone.BeforePageText = this.BeforePageText;
			clone.AfterPageText = this.AfterPageText;
			clone.DisplayMsg = this.DisplayMsg;
			clone.EmptyMsg = this.EmptyMsg;
			clone.LoadingMsg = this.LoadingMsg;
			clone.MinColumnWidth = this.MinColumnWidth;
			clone.TitleVisible = this.TitleVisible;
			clone.DefaultCondition = this.DefaultCondition;
			clone.DefaultConditionCharacter = this.DefaultConditionCharacter;
			clone.DefaultConditionBoolean = this.DefaultConditionBoolean;
			clone.ChangeRadioTocombo = this.ChangeRadioTocombo;
			clone.ChangeLikeInVariableAux = this.ChangeLikeInVariableAux;
			clone.SelectionCallMethod = this.SelectionCallMethod;
			clone.ViewTabCallMethod = this.ViewTabCallMethod;
			clone.PromptCallMethod = this.PromptCallMethod;
			clone.FilterIntervalText = this.FilterIntervalText;
			clone.GridStandardActionOrientation = this.GridStandardActionOrientation;
			clone.GridLoadBitmaps = this.GridLoadBitmaps;
			clone.AutoResize = this.AutoResize;
			clone.GridWidth = this.GridWidth;
			clone.GridHeight = this.GridHeight;
			clone.AllowSelection = this.AllowSelection;
			if (GridProperties != null)
				clone.GridProperties = this.GridProperties.Clone();

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternSettings.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "GridProperties" :
				{
					if (GridProperties != null)
						return GridProperties.GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Rules"/> property.
		/// </summary>
		public static class RulesValue
		{
			public const string All = "All";
			public const string Columns = "Columns";
			public const string None = "None";
			public const string Rows = "Rows";
		}

		/// <summary>
		/// Possible values for the <see cref="BackColorStyle"/> property.
		/// </summary>
		public static class BackColorStyleValue
		{
			public const string None = "None";
			public const string Uniform = "Uniform";
			public const string Header = "Header";
			public const string Report = "Report";
		}

		/// <summary>
		/// Possible values for the <see cref="ButtonsAlign"/> property.
		/// </summary>
		public static class ButtonsAlignValue
		{
			public const string Right = "Right";
			public const string Left = "Left";
			public const string Center = "Center";
		}

		/// <summary>
		/// Possible values for the <see cref="InsertAlign"/> property.
		/// </summary>
		public static class InsertAlignValue
		{
			public const string Right = "Right";
			public const string Left = "Left";
		}

		/// <summary>
		/// Possible values for the <see cref="GridType"/> property.
		/// </summary>
		public static class GridTypeValue
		{
			public const string Standard = "Standard";
			public const string Gxui = "gxui";
		}

		/// <summary>
		/// Possible values for the <see cref="GridGXUIActionOrientation"/> property.
		/// </summary>
		public static class GridGXUIActionOrientationValue
		{
			public const string Right = "Right";
			public const string Left = "Left";
		}

		/// <summary>
		/// Possible values for the <see cref="SelectionCallMethod"/> property.
		/// </summary>
		public static class SelectionCallMethodValue
		{
			public const string Link = "Link";
			public const string Popup = "Popup";
		}

		/// <summary>
		/// Possible values for the <see cref="ViewTabCallMethod"/> property.
		/// </summary>
		public static class ViewTabCallMethodValue
		{
			public const string Link = "Link";
			public const string Popup = "Popup";
		}

		/// <summary>
		/// Possible values for the <see cref="PromptCallMethod"/> property.
		/// </summary>
		public static class PromptCallMethodValue
		{
			public const string Link = "Link";
			public const string Popup = "Popup";
		}

		/// <summary>
		/// Possible values for the <see cref="GridStandardActionOrientation"/> property.
		/// </summary>
		public static class GridStandardActionOrientationValue
		{
			public const string Right = "Right";
			public const string Left = "Left";
		}

		/// <summary>
		/// Possible values for the <see cref="GridLoadBitmaps"/> property.
		/// </summary>
		public static class GridLoadBitmapsValue
		{
			public const string Start = "Start";
			public const string Refresh = "Refresh";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Grid";
		}

		#endregion
	}

	#endregion

	#region Element: TabsProperties

	public partial class SettingsTabsPropertiesElement : Artech.Common.Collections.BaseCollection<SettingsTabPropertyElement>
	{
		protected string m_ElementName;

		#region Construction

		internal SettingsTabsPropertiesElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsTabPropertyElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private HPatternSettings m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<SettingsTabPropertyElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of SettingsTabsPropertiesElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="SettingsTabPropertyElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no TabProperty is found, <b>null</b> is returned.
		/// </summary>
		public SettingsTabPropertyElement FindTabProperty(System.String name)
		{
			return this.Find(delegate (SettingsTabPropertyElement tabPropertyItem) { return tabPropertyItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Tabs Properties";
		}

		#endregion
	}

	#endregion

	#region Element: TabProperty

	public partial class SettingsTabPropertyElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Valor;
		private bool m_IsValorDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsTabPropertyElement"/> class.
		/// </summary>
		public SettingsTabPropertyElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsTabPropertyElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public SettingsTabPropertyElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsTabPropertyElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = null;
			m_IsNameDefault = true;
			m_Valor = "";
			m_IsValorDefault = true;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsTabPropertyElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Nome
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Valor
		*/
		/// </summary>
		public System.String Valor
		{
			get { return m_Valor; }
			set 
			{
				m_Valor = value;
				m_IsValorDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsTabPropertyElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "TabProperty")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "TabProperty"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Valor = element.Attributes.GetPropertyValue<System.String>("valor");
			m_IsValorDefault = element.Attributes.IsPropertyDefault("valor");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsTabPropertyElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "TabProperty")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "TabProperty"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "valor", m_Valor, m_IsValorDefault);

			Debug.Assert(m_Valor == element.Attributes.GetPropertyValue<System.String>("valor"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsTabPropertyElement"/>.
		/// </summary>
		public SettingsTabPropertyElement Clone()
		{
			SettingsTabPropertyElement clone = new SettingsTabPropertyElement();

			clone.Name = this.Name;
			clone.Valor = this.Valor;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Tab {0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: GridProperties

	public partial class SettingsGridPropertiesElement : IEnumerable<IHPatternSettingsElement>, IHPatternSettingsElement
	{
		protected string m_ElementName;
		private Artech.Common.Collections.BaseCollection<IHPatternSettingsElement> m_Items;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsGridPropertiesElement"/> class.
		/// </summary>
		public SettingsGridPropertiesElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsGridPropertiesElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Items = new Artech.Common.Collections.BaseCollection<IHPatternSettingsElement>();
			m_Items.ItemAdded += new EventHandler<CollectionItemEventArgs<IHPatternSettingsElement>>(Items_ItemAdded);
		}

		#endregion

		#region Properties

		private SettingsGridElement m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsGridPropertiesElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public SettingsGridElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		public Artech.Common.Collections.IBaseCollection<SettingsGridPropertieElement> GridProperties
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<SettingsGridPropertieElement> tmpGridProperties = new Artech.Common.Collections.BaseCollection<SettingsGridPropertieElement>();
				foreach (IHPatternSettingsElement obj in m_Items)
					if (obj is SettingsGridPropertieElement)
						tmpGridProperties.Add((SettingsGridPropertieElement)obj);

				return tmpGridProperties.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<SettingsGridColumnPropertieElement> GridColumnProperties
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<SettingsGridColumnPropertieElement> tmpGridColumnProperties = new Artech.Common.Collections.BaseCollection<SettingsGridColumnPropertieElement>();
				foreach (IHPatternSettingsElement obj in m_Items)
					if (obj is SettingsGridColumnPropertieElement)
						tmpGridColumnProperties.Add((SettingsGridColumnPropertieElement)obj);

				return tmpGridColumnProperties.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<IHPatternSettingsElement> Items
		{
			get { return m_Items; }
		}

		public IEnumerator<IHPatternSettingsElement> GetEnumerator()
		{
			return m_Items.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((System.Collections.IEnumerable)m_Items).GetEnumerator();
		}

		#endregion

		#region Helper methods

		public void Add(IHPatternSettingsElement item)
		{
			m_Items.Add(item);
		}

		/// <summary>
		/// Creates a new <see cref="SettingsGridPropertieElement"/> and adds it to the <see cref="GridProperties"/> collection.
		/// </summary>
		public SettingsGridPropertieElement AddGridPropertie()
		{
			SettingsGridPropertieElement gridPropertieElement = new SettingsGridPropertieElement();
			m_Items.Add(gridPropertieElement);
			return gridPropertieElement;
		}

		/// <summary>
		/// Creates a new <see cref="SettingsGridPropertieElement"/> and adds it to the <see cref="GridProperties"/> collection.
		/// The SettingsGridPropertieElement is initialized with the specified value.
		/// </summary>
		public SettingsGridPropertieElement AddGridPropertie(System.String name)
		{
			SettingsGridPropertieElement gridPropertieElement = new SettingsGridPropertieElement(name);
			m_Items.Add(gridPropertieElement);
			return gridPropertieElement;
		}

		/// <summary>
		/// Finds the <see cref="SettingsGridPropertieElement"/> in the <see cref="GridProperties"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridPropertieElement is found, null is returned.
		/// </summary>
		public SettingsGridPropertieElement FindGridPropertie(System.String name)
		{
			return GridProperties.Find(delegate (SettingsGridPropertieElement gridPropertieElement) { return gridPropertieElement.Name == name; });
		}

		private void GridProperties_ItemAdded(object sender, CollectionItemEventArgs<SettingsGridPropertieElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="SettingsGridColumnPropertieElement"/> and adds it to the <see cref="GridColumnProperties"/> collection.
		/// </summary>
		public SettingsGridColumnPropertieElement AddGridColumnPropertie()
		{
			SettingsGridColumnPropertieElement gridColumnPropertieElement = new SettingsGridColumnPropertieElement();
			m_Items.Add(gridColumnPropertieElement);
			return gridColumnPropertieElement;
		}

		/// <summary>
		/// Creates a new <see cref="SettingsGridColumnPropertieElement"/> and adds it to the <see cref="GridColumnProperties"/> collection.
		/// The SettingsGridColumnPropertieElement is initialized with the specified value.
		/// </summary>
		public SettingsGridColumnPropertieElement AddGridColumnPropertie(System.String name)
		{
			SettingsGridColumnPropertieElement gridColumnPropertieElement = new SettingsGridColumnPropertieElement(name);
			m_Items.Add(gridColumnPropertieElement);
			return gridColumnPropertieElement;
		}

		/// <summary>
		/// Finds the <see cref="SettingsGridColumnPropertieElement"/> in the <see cref="GridColumnProperties"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridColumnPropertieElement is found, null is returned.
		/// </summary>
		public SettingsGridColumnPropertieElement FindGridColumnPropertie(System.String name)
		{
			return GridColumnProperties.Find(delegate (SettingsGridColumnPropertieElement gridColumnPropertieElement) { return gridColumnPropertieElement.Name == name; });
		}

		private void GridColumnProperties_ItemAdded(object sender, CollectionItemEventArgs<SettingsGridColumnPropertieElement> e)
		{
			e.Data.Parent = this;
		}

		private void Items_ItemAdded(object sender, CollectionItemEventArgs<IHPatternSettingsElement> e)
		{
			if (e.Data is SettingsGridPropertieElement)
				((SettingsGridPropertieElement)e.Data).Parent = this;
			else if (e.Data is SettingsGridColumnPropertieElement)
				((SettingsGridColumnPropertieElement)e.Data).Parent = this;
			else
				throw new PatternInstanceException(String.Format("An object of an unexpected type {0} was added as child of {1}.", e.Data.GetType(), this.GetType()));
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsGridPropertiesElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridProperties")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "GridProperties"));

			Initialize();
			m_ElementName = element.Name;

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "GridPropertie" :
					{
						SettingsGridPropertieElement gridPropertie = new SettingsGridPropertieElement();
						gridPropertie.LoadFrom(_childElement);
						Add(gridPropertie);
						break;
					}
					case "GridColumnPropertie" :
					{
						SettingsGridColumnPropertieElement gridColumnPropertie = new SettingsGridColumnPropertieElement();
						gridColumnPropertie.LoadFrom(_childElement);
						Add(gridColumnPropertie);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="SettingsGridPropertiesElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridProperties")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "GridProperties"));

			element.Initialize();

			// Save element children.
			foreach (IHPatternSettingsElement _obj in m_Items)
			{
				if (_obj is SettingsGridPropertieElement)
				{
					PatternInstanceElement gridPropertie = element.Children.AddNewElement("GridPropertie");
					((SettingsGridPropertieElement)_obj).SaveTo(gridPropertie);
				}
				else if (_obj is SettingsGridColumnPropertieElement)
				{
					PatternInstanceElement gridColumnPropertie = element.Children.AddNewElement("GridColumnPropertie");
					((SettingsGridColumnPropertieElement)_obj).SaveTo(gridColumnPropertie);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsGridPropertiesElement"/>.
		/// </summary>
		public SettingsGridPropertiesElement Clone()
		{
			SettingsGridPropertiesElement clone = new SettingsGridPropertiesElement();
			foreach (IHPatternSettingsElement element in this)
				clone.Add(element.Clone());

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternSettings.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "GridPropertie" :
				{
					if (GridProperties != null && childIndex >= 0 && childIndex < GridProperties.Count)
						return GridProperties[childIndex].GetElement(path);
					else
						return null;
				}
				case "GridColumnPropertie" :
				{
					if (GridColumnProperties != null && childIndex >= 0 && childIndex < GridColumnProperties.Count)
						return GridColumnProperties[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Grid Custom Render Properties";
		}

		#endregion
	}

	#endregion

	#region Element: GridPropertie

	public partial class SettingsGridPropertieElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Valor;
		private bool m_IsValorDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsGridPropertieElement"/> class.
		/// </summary>
		public SettingsGridPropertieElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsGridPropertieElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public SettingsGridPropertieElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsGridPropertieElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = null;
			m_IsNameDefault = true;
			m_Valor = "";
			m_IsValorDefault = true;
		}

		#endregion

		#region Properties

		private SettingsGridPropertiesElement m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsGridPropertieElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public SettingsGridPropertiesElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Nome
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Valor
		*/
		/// </summary>
		public System.String Valor
		{
			get { return m_Valor; }
			set 
			{
				m_Valor = value;
				m_IsValorDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsGridPropertieElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridPropertie")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "GridPropertie"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Valor = element.Attributes.GetPropertyValue<System.String>("valor");
			m_IsValorDefault = element.Attributes.IsPropertyDefault("valor");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsGridPropertieElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridPropertie")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "GridPropertie"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "valor", m_Valor, m_IsValorDefault);

			Debug.Assert(m_Valor == element.Attributes.GetPropertyValue<System.String>("valor"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsGridPropertieElement"/>.
		/// </summary>
		public SettingsGridPropertieElement Clone()
		{
			SettingsGridPropertieElement clone = new SettingsGridPropertieElement();

			clone.Name = this.Name;
			clone.Valor = this.Valor;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Grid {0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: GridColumnPropertie

	public partial class SettingsGridColumnPropertieElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Valor;
		private bool m_IsValorDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsGridColumnPropertieElement"/> class.
		/// </summary>
		public SettingsGridColumnPropertieElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsGridColumnPropertieElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public SettingsGridColumnPropertieElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsGridColumnPropertieElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = null;
			m_IsNameDefault = true;
			m_Valor = "";
			m_IsValorDefault = true;
		}

		#endregion

		#region Properties

		private SettingsGridPropertiesElement m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsGridColumnPropertieElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public SettingsGridPropertiesElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Nome
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Valor
		*/
		/// </summary>
		public System.String Valor
		{
			get { return m_Valor; }
			set 
			{
				m_Valor = value;
				m_IsValorDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsGridColumnPropertieElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridColumnPropertie")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "GridColumnPropertie"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Valor = element.Attributes.GetPropertyValue<System.String>("valor");
			m_IsValorDefault = element.Attributes.IsPropertyDefault("valor");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsGridColumnPropertieElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridColumnPropertie")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "GridColumnPropertie"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "valor", m_Valor, m_IsValorDefault);

			Debug.Assert(m_Valor == element.Attributes.GetPropertyValue<System.String>("valor"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsGridColumnPropertieElement"/>.
		/// </summary>
		public SettingsGridColumnPropertieElement Clone()
		{
			SettingsGridColumnPropertieElement clone = new SettingsGridColumnPropertieElement();

			clone.Name = this.Name;
			clone.Valor = this.Valor;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Column {0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: MasterPages

	public partial class SettingsMasterPagesElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private Artech.Genexus.Common.Objects.WebPanel m_Selection;
		private KBObjectReference m_SelectionReference;
		private string m_SelectionName;
		private bool m_IsSelectionDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_Prompt;
		private KBObjectReference m_PromptReference;
		private string m_PromptName;
		private bool m_IsPromptDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_Transaction;
		private KBObjectReference m_TransactionReference;
		private string m_TransactionName;
		private bool m_IsTransactionDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_View;
		private KBObjectReference m_ViewReference;
		private string m_ViewName;
		private bool m_IsViewDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsMasterPagesElement"/> class.
		/// </summary>
		public SettingsMasterPagesElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsMasterPagesElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Selection = null;
			m_SelectionReference = null;
			m_SelectionName = null;
			m_IsSelectionDefault = true;
			m_Prompt = null;
			m_PromptReference = null;
			m_PromptName = null;
			m_IsPromptDefault = true;
			m_Transaction = null;
			m_TransactionReference = null;
			m_TransactionName = null;
			m_IsTransactionDefault = true;
			m_View = null;
			m_ViewReference = null;
			m_ViewName = null;
			m_IsViewDefault = true;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsMasterPagesElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Selecionar objeto Master Page.
		/// Manutenção Webpanels.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel Selection
		{
			get
			{
				if (m_Selection == null && m_SelectionReference != null)
					m_Selection = (Artech.Genexus.Common.Objects.WebPanel)m_SelectionReference.GetKBObject(Settings.Model);

				return m_Selection;
			}

			set 
			{
				m_Selection = value;
				m_SelectionReference = (value != null ? new KBObjectReference(value) : null);
				m_SelectionName = (value != null ? value.Name : null);
				m_IsSelectionDefault = false;
			}
		}

		/// <summary>
		/// Selection name.
		/// </summary>
		public string SelectionName
		{
			get
			{
				if (m_SelectionName == null && m_SelectionReference != null)
					m_SelectionName = m_SelectionReference.GetName(Settings.Model);

				return m_SelectionName;
			}
		}

		/// <summary>
		/*
		Selecionar objeto Master Page.
		/// Prompt WebPanels.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel Prompt
		{
			get
			{
				if (m_Prompt == null && m_PromptReference != null)
					m_Prompt = (Artech.Genexus.Common.Objects.WebPanel)m_PromptReference.GetKBObject(Settings.Model);

				return m_Prompt;
			}

			set 
			{
				m_Prompt = value;
				m_PromptReference = (value != null ? new KBObjectReference(value) : null);
				m_PromptName = (value != null ? value.Name : null);
				m_IsPromptDefault = false;
			}
		}

		/// <summary>
		/// Prompt name.
		/// </summary>
		public string PromptName
		{
			get
			{
				if (m_PromptName == null && m_PromptReference != null)
					m_PromptName = m_PromptReference.GetName(Settings.Model);

				return m_PromptName;
			}
		}

		/// <summary>
		/*
		Selecionar objeto Master Page.
		/// WebForms Transaction.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel Transaction
		{
			get
			{
				if (m_Transaction == null && m_TransactionReference != null)
					m_Transaction = (Artech.Genexus.Common.Objects.WebPanel)m_TransactionReference.GetKBObject(Settings.Model);

				return m_Transaction;
			}

			set 
			{
				m_Transaction = value;
				m_TransactionReference = (value != null ? new KBObjectReference(value) : null);
				m_TransactionName = (value != null ? value.Name : null);
				m_IsTransactionDefault = false;
			}
		}

		/// <summary>
		/// Transaction name.
		/// </summary>
		public string TransactionName
		{
			get
			{
				if (m_TransactionName == null && m_TransactionReference != null)
					m_TransactionName = m_TransactionReference.GetName(Settings.Model);

				return m_TransactionName;
			}
		}

		/// <summary>
		/*
		Selecionar objeto Master Page.
		/// View Webpanels.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel View
		{
			get
			{
				if (m_View == null && m_ViewReference != null)
					m_View = (Artech.Genexus.Common.Objects.WebPanel)m_ViewReference.GetKBObject(Settings.Model);

				return m_View;
			}

			set 
			{
				m_View = value;
				m_ViewReference = (value != null ? new KBObjectReference(value) : null);
				m_ViewName = (value != null ? value.Name : null);
				m_IsViewDefault = false;
			}
		}

		/// <summary>
		/// View name.
		/// </summary>
		public string ViewName
		{
			get
			{
				if (m_ViewName == null && m_ViewReference != null)
					m_ViewName = m_ViewReference.GetName(Settings.Model);

				return m_ViewName;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsMasterPagesElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "MasterPages")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "MasterPages"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_SelectionReference = element.Attributes.GetPropertyValue<KBObjectReference>("SelectionReference");
			m_IsSelectionDefault = element.Attributes.IsPropertyDefault("Selection");
			m_PromptReference = element.Attributes.GetPropertyValue<KBObjectReference>("PromptReference");
			m_IsPromptDefault = element.Attributes.IsPropertyDefault("Prompt");
			m_TransactionReference = element.Attributes.GetPropertyValue<KBObjectReference>("TransactionReference");
			m_IsTransactionDefault = element.Attributes.IsPropertyDefault("Transaction");
			m_ViewReference = element.Attributes.GetPropertyValue<KBObjectReference>("ViewReference");
			m_IsViewDefault = element.Attributes.IsPropertyDefault("View");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsMasterPagesElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "MasterPages")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "MasterPages"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "SelectionReference", m_SelectionReference, m_IsSelectionDefault);
			SaveAttribute(element, "PromptReference", m_PromptReference, m_IsPromptDefault);
			SaveAttribute(element, "TransactionReference", m_TransactionReference, m_IsTransactionDefault);
			SaveAttribute(element, "ViewReference", m_ViewReference, m_IsViewDefault);

			Debug.Assert(m_SelectionReference == element.Attributes.GetPropertyValue<KBObjectReference>("SelectionReference"));
			Debug.Assert(m_PromptReference == element.Attributes.GetPropertyValue<KBObjectReference>("PromptReference"));
			Debug.Assert(m_TransactionReference == element.Attributes.GetPropertyValue<KBObjectReference>("TransactionReference"));
			Debug.Assert(m_ViewReference == element.Attributes.GetPropertyValue<KBObjectReference>("ViewReference"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsMasterPagesElement"/>.
		/// </summary>
		public SettingsMasterPagesElement Clone()
		{
			SettingsMasterPagesElement clone = new SettingsMasterPagesElement();

			clone.Selection = this.Selection;
			clone.Prompt = this.Prompt;
			clone.Transaction = this.Transaction;
			clone.View = this.View;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "MasterPages";
		}

		#endregion
	}

	#endregion

	#region Element: StandardActions

	public partial class SettingsStandardActionsElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_DisabledAppearance;
		private bool m_IsDisabledAppearanceDefault;
		private System.String m_FirstLegend;
		private bool m_IsFirstLegendDefault;
		private System.String m_PreviousLegend;
		private bool m_IsPreviousLegendDefault;
		private System.String m_NextLegend;
		private bool m_IsNextLegendDefault;
		private System.String m_LastLegend;
		private bool m_IsLastLegendDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_LegendObject;
		private KBObjectReference m_LegendObjectReference;
		private string m_LegendObjectName;
		private bool m_IsLegendObjectDefault;
		private SettingsActionElement m_Insert;
		private SettingsActionElement m_Update;
		private SettingsActionElement m_Delete;
		private SettingsActionElement m_Display;
		private SettingsExportActionElement m_Export;
		private SettingsActionElement m_Legend;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsStandardActionsElement"/> class.
		/// </summary>
		public SettingsStandardActionsElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsStandardActionsElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_DisabledAppearance = "Disabled";
			m_IsDisabledAppearanceDefault = true;
			m_FirstLegend = "Posiciona na primeira página";
			m_IsFirstLegendDefault = true;
			m_PreviousLegend = "Posiciona na página anterior";
			m_IsPreviousLegendDefault = true;
			m_NextLegend = "Posiciona na próxima página";
			m_IsNextLegendDefault = true;
			m_LastLegend = "Posiciona na última página";
			m_IsLastLegendDefault = true;
			m_LegendObject = null;
			m_LegendObjectReference = null;
			m_LegendObjectName = null;
			m_IsLegendObjectDefault = true;
			m_Insert = new SettingsActionElement();
			m_Insert.Parent = this;
			m_Update = new SettingsActionElement();
			m_Update.Parent = this;
			m_Delete = new SettingsActionElement();
			m_Delete.Parent = this;
			m_Display = new SettingsActionElement();
			m_Display.Parent = this;
			m_Export = new SettingsExportActionElement();
			m_Export.Parent = this;
			m_Legend = new SettingsActionElement();
			m_Legend.Parent = this;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsStandardActionsElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Selecionar DISABLED ou HIDDEN.
		/// Algumas ações estão desativadas devido há uma checagem de segurança personalizada, e são mostradas como desabilitadas ou não são exibidas.
		*/
		/// </summary>
		public System.String DisabledAppearance
		{
			get { return m_DisabledAppearance; }
			set 
			{
				m_DisabledAppearance = value;
				m_IsDisabledAppearanceDefault = false;
			}
		}

		/// <summary>
		/*
		Legenda primeira página
		*/
		/// </summary>
		public System.String FirstLegend
		{
			get { return m_FirstLegend; }
			set 
			{
				m_FirstLegend = value;
				m_IsFirstLegendDefault = false;
			}
		}

		/// <summary>
		/*
		Legenda página anterior
		*/
		/// </summary>
		public System.String PreviousLegend
		{
			get { return m_PreviousLegend; }
			set 
			{
				m_PreviousLegend = value;
				m_IsPreviousLegendDefault = false;
			}
		}

		/// <summary>
		/*
		Legenda próxima página
		*/
		/// </summary>
		public System.String NextLegend
		{
			get { return m_NextLegend; }
			set 
			{
				m_NextLegend = value;
				m_IsNextLegendDefault = false;
			}
		}

		/// <summary>
		/*
		Legenda última página
		*/
		/// </summary>
		public System.String LastLegend
		{
			get { return m_LastLegend; }
			set 
			{
				m_LastLegend = value;
				m_IsLastLegendDefault = false;
			}
		}

		/// <summary>
		/*
		WebPanel Legenda
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel LegendObject
		{
			get
			{
				if (m_LegendObject == null && m_LegendObjectReference != null)
					m_LegendObject = (Artech.Genexus.Common.Objects.WebPanel)m_LegendObjectReference.GetKBObject(Settings.Model);

				return m_LegendObject;
			}

			set 
			{
				m_LegendObject = value;
				m_LegendObjectReference = (value != null ? new KBObjectReference(value) : null);
				m_LegendObjectName = (value != null ? value.Name : null);
				m_IsLegendObjectDefault = false;
			}
		}

		/// <summary>
		/// LegendObject name.
		/// </summary>
		public string LegendObjectName
		{
			get
			{
				if (m_LegendObjectName == null && m_LegendObjectReference != null)
					m_LegendObjectName = m_LegendObjectReference.GetName(Settings.Model);

				return m_LegendObjectName;
			}
		}

		public SettingsActionElement Insert
		{
			get { return m_Insert; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Insert = value;
				m_Insert.Parent = this;
			}
		}

		public SettingsActionElement Update
		{
			get { return m_Update; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Update = value;
				m_Update.Parent = this;
			}
		}

		public SettingsActionElement Delete
		{
			get { return m_Delete; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Delete = value;
				m_Delete.Parent = this;
			}
		}

		public SettingsActionElement Display
		{
			get { return m_Display; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Display = value;
				m_Display.Parent = this;
			}
		}

		public SettingsExportActionElement Export
		{
			get { return m_Export; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Export = value;
				m_Export.Parent = this;
			}
		}

		public SettingsActionElement Legend
		{
			get { return m_Legend; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Legend = value;
				m_Legend.Parent = this;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsStandardActionsElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "StandardActions")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "StandardActions"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_DisabledAppearance = element.Attributes.GetPropertyValue<System.String>("DisabledAppearance");
			m_IsDisabledAppearanceDefault = element.Attributes.IsPropertyDefault("DisabledAppearance");
			m_FirstLegend = element.Attributes.GetPropertyValue<System.String>("FirstLegend");
			m_IsFirstLegendDefault = element.Attributes.IsPropertyDefault("FirstLegend");
			m_PreviousLegend = element.Attributes.GetPropertyValue<System.String>("PreviousLegend");
			m_IsPreviousLegendDefault = element.Attributes.IsPropertyDefault("PreviousLegend");
			m_NextLegend = element.Attributes.GetPropertyValue<System.String>("NextLegend");
			m_IsNextLegendDefault = element.Attributes.IsPropertyDefault("NextLegend");
			m_LastLegend = element.Attributes.GetPropertyValue<System.String>("LastLegend");
			m_IsLastLegendDefault = element.Attributes.IsPropertyDefault("LastLegend");
			m_LegendObjectReference = element.Attributes.GetPropertyValue<KBObjectReference>("LegendObjectReference");
			m_IsLegendObjectDefault = element.Attributes.IsPropertyDefault("LegendObject");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "Insert" :
					{
						SettingsActionElement insert = new SettingsActionElement();
						insert.LoadFrom(_childElement);
						Insert = insert;
						break;
					}
					case "Update" :
					{
						SettingsActionElement update = new SettingsActionElement();
						update.LoadFrom(_childElement);
						Update = update;
						break;
					}
					case "Delete" :
					{
						SettingsActionElement delete = new SettingsActionElement();
						delete.LoadFrom(_childElement);
						Delete = delete;
						break;
					}
					case "Display" :
					{
						SettingsActionElement display = new SettingsActionElement();
						display.LoadFrom(_childElement);
						Display = display;
						break;
					}
					case "Export" :
					{
						SettingsExportActionElement export = new SettingsExportActionElement();
						export.LoadFrom(_childElement);
						Export = export;
						break;
					}
					case "Legend" :
					{
						SettingsActionElement legend = new SettingsActionElement();
						legend.LoadFrom(_childElement);
						Legend = legend;
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="SettingsStandardActionsElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "StandardActions")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "StandardActions"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "DisabledAppearance", m_DisabledAppearance, m_IsDisabledAppearanceDefault);
			SaveAttribute(element, "FirstLegend", m_FirstLegend, m_IsFirstLegendDefault);
			SaveAttribute(element, "PreviousLegend", m_PreviousLegend, m_IsPreviousLegendDefault);
			SaveAttribute(element, "NextLegend", m_NextLegend, m_IsNextLegendDefault);
			SaveAttribute(element, "LastLegend", m_LastLegend, m_IsLastLegendDefault);
			SaveAttribute(element, "LegendObjectReference", m_LegendObjectReference, m_IsLegendObjectDefault);

			Debug.Assert(m_DisabledAppearance == element.Attributes.GetPropertyValue<System.String>("DisabledAppearance"));
			Debug.Assert(m_FirstLegend == element.Attributes.GetPropertyValue<System.String>("FirstLegend"));
			Debug.Assert(m_PreviousLegend == element.Attributes.GetPropertyValue<System.String>("PreviousLegend"));
			Debug.Assert(m_NextLegend == element.Attributes.GetPropertyValue<System.String>("NextLegend"));
			Debug.Assert(m_LastLegend == element.Attributes.GetPropertyValue<System.String>("LastLegend"));
			Debug.Assert(m_LegendObjectReference == element.Attributes.GetPropertyValue<KBObjectReference>("LegendObjectReference"));

			// Save element children.
			if (m_Insert != null)
			{
				PatternInstanceElement insert = element.Children["Insert"];
				m_Insert.SaveTo(insert);
			}

			if (m_Update != null)
			{
				PatternInstanceElement update = element.Children["Update"];
				m_Update.SaveTo(update);
			}

			if (m_Delete != null)
			{
				PatternInstanceElement delete = element.Children["Delete"];
				m_Delete.SaveTo(delete);
			}

			if (m_Display != null)
			{
				PatternInstanceElement display = element.Children["Display"];
				m_Display.SaveTo(display);
			}

			if (m_Export != null)
			{
				PatternInstanceElement export = element.Children["Export"];
				m_Export.SaveTo(export);
			}

			if (m_Legend != null)
			{
				PatternInstanceElement legend = element.Children["Legend"];
				m_Legend.SaveTo(legend);
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsStandardActionsElement"/>.
		/// </summary>
		public SettingsStandardActionsElement Clone()
		{
			SettingsStandardActionsElement clone = new SettingsStandardActionsElement();

			clone.DisabledAppearance = this.DisabledAppearance;
			clone.FirstLegend = this.FirstLegend;
			clone.PreviousLegend = this.PreviousLegend;
			clone.NextLegend = this.NextLegend;
			clone.LastLegend = this.LastLegend;
			clone.LegendObject = this.LegendObject;
			clone.Insert = this.Insert.Clone();
			clone.Update = this.Update.Clone();
			clone.Delete = this.Delete.Clone();
			clone.Display = this.Display.Clone();
			clone.Export = this.Export.Clone();
			clone.Legend = this.Legend.Clone();

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternSettings.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "Insert" :
				{
					if (Insert != null)
						return Insert.GetElement(path);
					else
						return null;
				}
				case "Update" :
				{
					if (Update != null)
						return Update.GetElement(path);
					else
						return null;
				}
				case "Delete" :
				{
					if (Delete != null)
						return Delete.GetElement(path);
					else
						return null;
				}
				case "Display" :
				{
					if (Display != null)
						return Display.GetElement(path);
					else
						return null;
				}
				case "Export" :
				{
					if (Export != null)
						return Export.GetElement(path);
					else
						return null;
				}
				case "Legend" :
				{
					if (Legend != null)
						return Legend.GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="DisabledAppearance"/> property.
		/// </summary>
		public static class DisabledAppearanceValue
		{
			public const string Disabled = "Disabled";
			public const string Hidden = "Hidden";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Standard Actions";
		}

		#endregion
	}

	#endregion

	#region Element: Action

	public partial class SettingsActionElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Caption;
		private bool m_IsCaptionDefault;
		private System.String m_Tooltip;
		private bool m_IsTooltipDefault;
		private System.Boolean m_DefaultMode;
		private bool m_IsDefaultModeDefault;
		private System.Boolean m_PromptMode;
		private bool m_IsPromptModeDefault;
		private Artech.Genexus.Common.Objects.Image m_Image;
		private KBObjectReference m_ImageReference;
		private string m_ImageName;
		private bool m_IsImageDefault;
		private Artech.Genexus.Common.Objects.Image m_DisabledImage;
		private KBObjectReference m_DisabledImageReference;
		private string m_DisabledImageName;
		private bool m_IsDisabledImageDefault;
		private System.String m_ButtonClass;
		private bool m_IsButtonClassDefault;
		private System.String m_Condition;
		private bool m_IsConditionDefault;
		private System.String m_CodeEnable;
		private bool m_IsCodeEnableDefault;
		private System.String m_Position;
		private bool m_IsPositionDefault;
		private System.String m_Legend;
		private bool m_IsLegendDefault;
		private System.Int32 m_Width;
		private bool m_IsWidthDefault;
		private System.String m_GridWidth;
		private bool m_IsGridWidthDefault;
		private System.String m_GridHeight;
		private bool m_IsGridHeightDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsActionElement"/> class.
		/// </summary>
		public SettingsActionElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsActionElement"/> class, setting all its members to their default values.
		/// </summary>
		public virtual void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Caption = "";
			m_IsCaptionDefault = true;
			m_Tooltip = "";
			m_IsTooltipDefault = true;
			m_DefaultMode = true;
			m_IsDefaultModeDefault = true;
			m_PromptMode = false;
			m_IsPromptModeDefault = true;
			m_Image = null;
			m_ImageReference = null;
			m_ImageName = null;
			m_IsImageDefault = true;
			m_DisabledImage = null;
			m_DisabledImageReference = null;
			m_DisabledImageName = null;
			m_IsDisabledImageDefault = true;
			m_ButtonClass = null;
			m_IsButtonClassDefault = true;
			m_Condition = "";
			m_IsConditionDefault = true;
			m_CodeEnable = "";
			m_IsCodeEnableDefault = true;
			m_Position = "Grid";
			m_IsPositionDefault = true;
			m_Legend = "";
			m_IsLegendDefault = true;
			m_Width = 0;
			m_IsWidthDefault = true;
			m_GridWidth = "";
			m_IsGridWidthDefault = true;
			m_GridHeight = "";
			m_IsGridHeightDefault = true;
		}

		#endregion

		#region Properties

		private SettingsStandardActionsElement m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsActionElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public SettingsStandardActionsElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Caption for buttons, and for grid column if no image is specified.
		*/
		/// </summary>
		public System.String Caption
		{
			get { return m_Caption; }
			set 
			{
				m_Caption = value;
				m_IsCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		Tooltip to be used for the image control in the grid.
		*/
		/// </summary>
		public System.String Tooltip
		{
			get { return m_Tooltip; }
			set 
			{
				m_Tooltip = value;
				m_IsTooltipDefault = false;
			}
		}

		/// <summary>
		/*
		Indicates whether to include this action in grids by default (applies to insert, update, delete, display and export actions).
		*/
		/// </summary>
		public System.Boolean DefaultMode
		{
			get { return m_DefaultMode; }
			set 
			{
				m_DefaultMode = value;
				m_IsDefaultModeDefault = false;
			}
		}

		/// <summary>
		/*
		Indicates whether to include this action in grids by default (applies to insert, update, delete, display and export actions).
		*/
		/// </summary>
		public System.Boolean PromptMode
		{
			get { return m_PromptMode; }
			set 
			{
				m_PromptMode = value;
				m_IsPromptModeDefault = false;
			}
		}

		/// <summary>
		/*
		Image to be used for the action.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image Image
		{
			get
			{
				if (m_Image == null && m_ImageReference != null)
					m_Image = (Artech.Genexus.Common.Objects.Image)m_ImageReference.GetKBObject(Settings.Model);

				return m_Image;
			}

			set 
			{
				m_Image = value;
				m_ImageReference = (value != null ? new KBObjectReference(value) : null);
				m_ImageName = (value != null ? value.Name : null);
				m_IsImageDefault = false;
			}
		}

		/// <summary>
		/// Image name.
		/// </summary>
		public string ImageName
		{
			get
			{
				if (m_ImageName == null && m_ImageReference != null)
					m_ImageName = m_ImageReference.GetName(Settings.Model);

				return m_ImageName;
			}
		}

		/// <summary>
		/*
		Image to be used when the action is disabled.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image DisabledImage
		{
			get
			{
				if (m_DisabledImage == null && m_DisabledImageReference != null)
					m_DisabledImage = (Artech.Genexus.Common.Objects.Image)m_DisabledImageReference.GetKBObject(Settings.Model);

				return m_DisabledImage;
			}

			set 
			{
				m_DisabledImage = value;
				m_DisabledImageReference = (value != null ? new KBObjectReference(value) : null);
				m_DisabledImageName = (value != null ? value.Name : null);
				m_IsDisabledImageDefault = false;
			}
		}

		/// <summary>
		/// DisabledImage name.
		/// </summary>
		public string DisabledImageName
		{
			get
			{
				if (m_DisabledImageName == null && m_DisabledImageReference != null)
					m_DisabledImageName = m_DisabledImageReference.GetName(Settings.Model);

				return m_DisabledImageName;
			}
		}

		/// <summary>
		/*
		Theme class for this action, when inserted as a button in a form.
		*/
		/// </summary>
		public System.String ButtonClass
		{
			get { return m_ButtonClass; }
			set 
			{
				m_ButtonClass = value;
				m_IsButtonClassDefault = false;
			}
		}

		/// <summary>
		/*
		Condição padrão
		*/
		/// </summary>
		public System.String Condition
		{
			get { return m_Condition; }
			set 
			{
				m_Condition = value;
				m_IsConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Evento adicionado a ação de habilitar a Action, Coringda {0} define o nome do controle
		*/
		/// </summary>
		public System.String CodeEnable
		{
			get { return m_CodeEnable; }
			set 
			{
				m_CodeEnable = value;
				m_IsCodeEnableDefault = false;
			}
		}

		/// <summary>
		/*
		Define a posição da action fora do Grid
		*/
		/// </summary>
		public System.String Position
		{
			get { return m_Position; }
			set 
			{
				m_Position = value;
				m_IsPositionDefault = false;
			}
		}

		/// <summary>
		/*
		Legenda
		*/
		/// </summary>
		public System.String Legend
		{
			get { return m_Legend; }
			set 
			{
				m_Legend = value;
				m_IsLegendDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width da Coluna no Grid
		*/
		/// </summary>
		public System.Int32 Width
		{
			get { return m_Width; }
			set 
			{
				m_Width = value;
				m_IsWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width(tamanho horizontal)
		*/
		/// </summary>
		public System.String GridWidth
		{
			get { return m_GridWidth; }
			set 
			{
				m_GridWidth = value;
				m_IsGridWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Height(tamanho vertical)
		*/
		/// </summary>
		public System.String GridHeight
		{
			get { return m_GridHeight; }
			set 
			{
				m_GridHeight = value;
				m_IsGridHeightDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsActionElement"/> with the information present in the specified element.
		/// </summary>
		internal virtual void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Caption = element.Attributes.GetPropertyValue<System.String>("Caption");
			m_IsCaptionDefault = element.Attributes.IsPropertyDefault("Caption");
			m_Tooltip = element.Attributes.GetPropertyValue<System.String>("Tooltip");
			m_IsTooltipDefault = element.Attributes.IsPropertyDefault("Tooltip");
			m_DefaultMode = element.Attributes.GetPropertyValue<System.Boolean>("DefaultMode");
			m_IsDefaultModeDefault = element.Attributes.IsPropertyDefault("DefaultMode");
			m_PromptMode = element.Attributes.GetPropertyValue<System.Boolean>("PromptMode");
			m_IsPromptModeDefault = element.Attributes.IsPropertyDefault("PromptMode");
			m_ImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("ImageReference");
			m_IsImageDefault = element.Attributes.IsPropertyDefault("Image");
			m_DisabledImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("DisabledImageReference");
			m_IsDisabledImageDefault = element.Attributes.IsPropertyDefault("DisabledImage");
			m_ButtonClass = element.Attributes.GetPropertyValue<System.String>("ButtonClass");
			m_IsButtonClassDefault = element.Attributes.IsPropertyDefault("ButtonClass");
			m_Condition = element.Attributes.GetPropertyValue<System.String>("Condition");
			m_IsConditionDefault = element.Attributes.IsPropertyDefault("Condition");
			m_CodeEnable = element.Attributes.GetPropertyValue<System.String>("CodeEnable");
			m_IsCodeEnableDefault = element.Attributes.IsPropertyDefault("CodeEnable");
			m_Position = element.Attributes.GetPropertyValue<System.String>("Position");
			m_IsPositionDefault = element.Attributes.IsPropertyDefault("Position");
			m_Legend = element.Attributes.GetPropertyValue<System.String>("Legend");
			m_IsLegendDefault = element.Attributes.IsPropertyDefault("Legend");
			m_Width = element.Attributes.GetPropertyValue<System.Int32>("Width");
			m_IsWidthDefault = element.Attributes.IsPropertyDefault("Width");
			m_GridWidth = element.Attributes.GetPropertyValue<System.String>("GridWidth");
			m_IsGridWidthDefault = element.Attributes.IsPropertyDefault("GridWidth");
			m_GridHeight = element.Attributes.GetPropertyValue<System.String>("GridHeight");
			m_IsGridHeightDefault = element.Attributes.IsPropertyDefault("GridHeight");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsActionElement"/> information to the specified element.
		/// </summary>
		internal virtual void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "Caption", m_Caption, m_IsCaptionDefault);
			SaveAttribute(element, "Tooltip", m_Tooltip, m_IsTooltipDefault);
			SaveAttribute(element, "DefaultMode", m_DefaultMode, m_IsDefaultModeDefault);
			SaveAttribute(element, "PromptMode", m_PromptMode, m_IsPromptModeDefault);
			SaveAttribute(element, "ImageReference", m_ImageReference, m_IsImageDefault);
			SaveAttribute(element, "DisabledImageReference", m_DisabledImageReference, m_IsDisabledImageDefault);
			SaveAttribute(element, "ButtonClass", m_ButtonClass, m_IsButtonClassDefault);
			SaveAttribute(element, "Condition", m_Condition, m_IsConditionDefault);
			SaveAttribute(element, "CodeEnable", m_CodeEnable, m_IsCodeEnableDefault);
			SaveAttribute(element, "Position", m_Position, m_IsPositionDefault);
			SaveAttribute(element, "Legend", m_Legend, m_IsLegendDefault);
			SaveAttribute(element, "Width", m_Width, m_IsWidthDefault);
			SaveAttribute(element, "GridWidth", m_GridWidth, m_IsGridWidthDefault);
			SaveAttribute(element, "GridHeight", m_GridHeight, m_IsGridHeightDefault);

			Debug.Assert(m_Caption == element.Attributes.GetPropertyValue<System.String>("Caption"));
			Debug.Assert(m_Tooltip == element.Attributes.GetPropertyValue<System.String>("Tooltip"));
			Debug.Assert(m_DefaultMode == element.Attributes.GetPropertyValue<System.Boolean>("DefaultMode"));
			Debug.Assert(m_PromptMode == element.Attributes.GetPropertyValue<System.Boolean>("PromptMode"));
			Debug.Assert(m_ImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("ImageReference"));
			Debug.Assert(m_DisabledImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("DisabledImageReference"));
			Debug.Assert(m_Condition == element.Attributes.GetPropertyValue<System.String>("Condition"));
			Debug.Assert(m_CodeEnable == element.Attributes.GetPropertyValue<System.String>("CodeEnable"));
			Debug.Assert(m_Position == element.Attributes.GetPropertyValue<System.String>("Position"));
			Debug.Assert(m_Legend == element.Attributes.GetPropertyValue<System.String>("Legend"));
			Debug.Assert(m_Width == element.Attributes.GetPropertyValue<System.Int32>("Width"));
			Debug.Assert(m_GridWidth == element.Attributes.GetPropertyValue<System.String>("GridWidth"));
			Debug.Assert(m_GridHeight == element.Attributes.GetPropertyValue<System.String>("GridHeight"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsActionElement"/>.
		/// </summary>
		public SettingsActionElement Clone()
		{
			SettingsActionElement clone = new SettingsActionElement();

			clone.Caption = this.Caption;
			clone.Tooltip = this.Tooltip;
			clone.DefaultMode = this.DefaultMode;
			clone.PromptMode = this.PromptMode;
			clone.Image = this.Image;
			clone.DisabledImage = this.DisabledImage;
			clone.ButtonClass = this.ButtonClass;
			clone.Condition = this.Condition;
			clone.CodeEnable = this.CodeEnable;
			clone.Position = this.Position;
			clone.Legend = this.Legend;
			clone.Width = this.Width;
			clone.GridWidth = this.GridWidth;
			clone.GridHeight = this.GridHeight;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal virtual object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Position"/> property.
		/// </summary>
		public static class PositionValue
		{
			public const string Footer = "Footer";
			public const string Grid = "Grid";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", ElementName);
		}

		#endregion
	}

	#endregion

	#region Element: ExportAction

	public partial class SettingsExportActionElement : SettingsActionElement, IHPatternSettingsElement
	{
		private System.String m_BaseLocation;
		private bool m_IsBaseLocationDefault;
		private System.String m_Template;
		private bool m_IsTemplateDefault;
		private System.String m_StartRow;
		private bool m_IsStartRowDefault;
		private System.String m_StartColumn;
		private bool m_IsStartColumnDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsExportActionElement"/> class.
		/// </summary>
		public SettingsExportActionElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsExportActionElement"/> class, setting all its members to their default values.
		/// </summary>
		public override void Initialize()
		{
			base.Initialize();
			m_BaseLocation = "";
			m_IsBaseLocationDefault = true;
			m_Template = "";
			m_IsTemplateDefault = true;
			m_StartRow = "1";
			m_IsStartRowDefault = true;
			m_StartColumn = "1";
			m_IsStartColumnDefault = true;
		}

		#endregion

		#region Properties

		/// <summary>
		/*
		Base location for generated files (if a directory, include trailing slash).
		*/
		/// </summary>
		public System.String BaseLocation
		{
			get { return m_BaseLocation; }
			set 
			{
				m_BaseLocation = value;
				m_IsBaseLocationDefault = false;
			}
		}

		/// <summary>
		/*
		File name of the template used when crearing the Excel spreadsheet (empty for no template).
		*/
		/// </summary>
		public System.String Template
		{
			get { return m_Template; }
			set 
			{
				m_Template = value;
				m_IsTemplateDefault = false;
			}
		}

		/// <summary>
		/*
		Initial row for data, when using a template file (can be any integer expression).
		*/
		/// </summary>
		public System.String StartRow
		{
			get { return m_StartRow; }
			set 
			{
				m_StartRow = value;
				m_IsStartRowDefault = false;
			}
		}

		/// <summary>
		/*
		Initial column for data, when using a template file (can be any integer expression).
		*/
		/// </summary>
		public System.String StartColumn
		{
			get { return m_StartColumn; }
			set 
			{
				m_StartColumn = value;
				m_IsStartColumnDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsExportActionElement"/> with the information present in the specified element.
		/// </summary>
		internal override void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "ExportAction")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "ExportAction"));

			Initialize();
			base.LoadFrom(element);
			m_ElementName = element.Name;

			// Load attribute values.
			m_BaseLocation = element.Attributes.GetPropertyValue<System.String>("BaseLocation");
			m_IsBaseLocationDefault = element.Attributes.IsPropertyDefault("BaseLocation");
			m_Template = element.Attributes.GetPropertyValue<System.String>("Template");
			m_IsTemplateDefault = element.Attributes.IsPropertyDefault("Template");
			m_StartRow = element.Attributes.GetPropertyValue<System.String>("StartRow");
			m_IsStartRowDefault = element.Attributes.IsPropertyDefault("StartRow");
			m_StartColumn = element.Attributes.GetPropertyValue<System.String>("StartColumn");
			m_IsStartColumnDefault = element.Attributes.IsPropertyDefault("StartColumn");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsExportActionElement"/> information to the specified element.
		/// </summary>
		internal override void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "ExportAction")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "ExportAction"));

			element.Initialize();
			base.SaveTo(element);

			// Save attribute values.
			SaveAttribute(element, "BaseLocation", m_BaseLocation, m_IsBaseLocationDefault);
			SaveAttribute(element, "Template", m_Template, m_IsTemplateDefault);
			SaveAttribute(element, "StartRow", m_StartRow, m_IsStartRowDefault);
			SaveAttribute(element, "StartColumn", m_StartColumn, m_IsStartColumnDefault);

			Debug.Assert(m_BaseLocation == element.Attributes.GetPropertyValue<System.String>("BaseLocation"));
			Debug.Assert(m_Template == element.Attributes.GetPropertyValue<System.String>("Template"));
			Debug.Assert(m_StartRow == element.Attributes.GetPropertyValue<System.String>("StartRow"));
			Debug.Assert(m_StartColumn == element.Attributes.GetPropertyValue<System.String>("StartColumn"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsExportActionElement"/>.
		/// </summary>
		public new SettingsExportActionElement Clone()
		{
			SettingsExportActionElement clone = new SettingsExportActionElement();

			clone.Caption = this.Caption;
			clone.Tooltip = this.Tooltip;
			clone.DefaultMode = this.DefaultMode;
			clone.PromptMode = this.PromptMode;
			clone.Image = this.Image;
			clone.DisabledImage = this.DisabledImage;
			clone.ButtonClass = this.ButtonClass;
			clone.Condition = this.Condition;
			clone.CodeEnable = this.CodeEnable;
			clone.Position = this.Position;
			clone.Legend = this.Legend;
			clone.Width = this.Width;
			clone.GridWidth = this.GridWidth;
			clone.GridHeight = this.GridHeight;
			clone.BaseLocation = this.BaseLocation;
			clone.Template = this.Template;
			clone.StartRow = this.StartRow;
			clone.StartColumn = this.StartColumn;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal override object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", ElementName);
		}

		#endregion
	}

	#endregion

	#region Element: Context

	public partial class SettingsContextElement : Artech.Common.Collections.BaseCollection<SettingsContextVariableElement>
	{
		protected string m_ElementName;

		#region Construction

		internal SettingsContextElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsContextVariableElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private HPatternSettings m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<SettingsContextVariableElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of SettingsContextElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion


		#region Basic methods

		public override string ToString()
		{
			return "Context";
		}

		#endregion
	}

	#endregion

	#region Element: ContextVariable

	public partial class SettingsContextVariableElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private Artech.Architecture.Common.Objects.KBObject m_Type;
		private KBObjectReference m_TypeReference;
		private string m_TypeName;
		private bool m_IsTypeDefault;
		private Artech.Genexus.Common.Objects.Procedure m_LoadProcedure;
		private KBObjectReference m_LoadProcedureReference;
		private string m_LoadProcedureName;
		private bool m_IsLoadProcedureDefault;
		private System.Boolean m_ApplyInGXUI;
		private bool m_IsApplyInGXUIDefault;
		private System.Boolean m_ApplyInPrompt;
		private bool m_IsApplyInPromptDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsContextVariableElement"/> class.
		/// </summary>
		public SettingsContextVariableElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsContextVariableElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Type = null;
			m_TypeReference = null;
			m_TypeName = null;
			m_IsTypeDefault = true;
			m_LoadProcedure = null;
			m_LoadProcedureReference = null;
			m_LoadProcedureName = null;
			m_IsLoadProcedureDefault = true;
			m_ApplyInGXUI = false;
			m_IsApplyInGXUIDefault = true;
			m_ApplyInPrompt = false;
			m_IsApplyInPromptDefault = true;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsContextVariableElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Informar um nome para o contexto.
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar um objeto Domínio, Atributo ou Sdt, em que a variável Context é baseada.
		*/
		/// </summary>
		public Artech.Architecture.Common.Objects.KBObject Type
		{
			get
			{
				if (m_Type == null && m_TypeReference != null)
					m_Type = (Artech.Architecture.Common.Objects.KBObject)m_TypeReference.GetKBObject(Settings.Model);

				return m_Type;
			}

			set 
			{
				m_Type = value;
				m_TypeReference = (value != null ? new KBObjectReference(value) : null);
				m_TypeName = (value != null ? value.Name : null);
				m_IsTypeDefault = false;
			}
		}

		/// <summary>
		/// Type name.
		/// </summary>
		public string TypeName
		{
			get
			{
				if (m_TypeName == null && m_TypeReference != null)
					m_TypeName = m_TypeReference.GetName(Settings.Model);

				return m_TypeName;
			}
		}

		/// <summary>
		/*
		Selecionar um objeto Procedure, que será utilizada para carregar as variáveis do Contexto.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Procedure LoadProcedure
		{
			get
			{
				if (m_LoadProcedure == null && m_LoadProcedureReference != null)
					m_LoadProcedure = (Artech.Genexus.Common.Objects.Procedure)m_LoadProcedureReference.GetKBObject(Settings.Model);

				return m_LoadProcedure;
			}

			set 
			{
				m_LoadProcedure = value;
				m_LoadProcedureReference = (value != null ? new KBObjectReference(value) : null);
				m_LoadProcedureName = (value != null ? value.Name : null);
				m_IsLoadProcedureDefault = false;
			}
		}

		/// <summary>
		/// LoadProcedure name.
		/// </summary>
		public string LoadProcedureName
		{
			get
			{
				if (m_LoadProcedureName == null && m_LoadProcedureReference != null)
					m_LoadProcedureName = m_LoadProcedureReference.GetName(Settings.Model);

				return m_LoadProcedureName;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE para definir se variável de contexto é utilizada como filtro no GXUI.
		*/
		/// </summary>
		public System.Boolean ApplyInGXUI
		{
			get { return m_ApplyInGXUI; }
			set 
			{
				m_ApplyInGXUI = value;
				m_IsApplyInGXUIDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE para definir se variável de contexto é utilizada como filtro no Prompt.
		*/
		/// </summary>
		public System.Boolean ApplyInPrompt
		{
			get { return m_ApplyInPrompt; }
			set 
			{
				m_ApplyInPrompt = value;
				m_IsApplyInPromptDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsContextVariableElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "ContextVariable")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "ContextVariable"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("Name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("Name");
			m_TypeReference = element.Attributes.GetPropertyValue<KBObjectReference>("TypeReference");
			m_IsTypeDefault = element.Attributes.IsPropertyDefault("Type");
			m_LoadProcedureReference = element.Attributes.GetPropertyValue<KBObjectReference>("LoadProcedureReference");
			m_IsLoadProcedureDefault = element.Attributes.IsPropertyDefault("LoadProcedure");
			m_ApplyInGXUI = element.Attributes.GetPropertyValue<System.Boolean>("ApplyInGXUI");
			m_IsApplyInGXUIDefault = element.Attributes.IsPropertyDefault("ApplyInGXUI");
			m_ApplyInPrompt = element.Attributes.GetPropertyValue<System.Boolean>("ApplyInPrompt");
			m_IsApplyInPromptDefault = element.Attributes.IsPropertyDefault("ApplyInPrompt");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsContextVariableElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "ContextVariable")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "ContextVariable"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "Name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "TypeReference", m_TypeReference, m_IsTypeDefault);
			SaveAttribute(element, "LoadProcedureReference", m_LoadProcedureReference, m_IsLoadProcedureDefault);
			SaveAttribute(element, "ApplyInGXUI", m_ApplyInGXUI, m_IsApplyInGXUIDefault);
			SaveAttribute(element, "ApplyInPrompt", m_ApplyInPrompt, m_IsApplyInPromptDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("Name"));
			Debug.Assert(m_TypeReference == element.Attributes.GetPropertyValue<KBObjectReference>("TypeReference"));
			Debug.Assert(m_LoadProcedureReference == element.Attributes.GetPropertyValue<KBObjectReference>("LoadProcedureReference"));
			Debug.Assert(m_ApplyInGXUI == element.Attributes.GetPropertyValue<System.Boolean>("ApplyInGXUI"));
			Debug.Assert(m_ApplyInPrompt == element.Attributes.GetPropertyValue<System.Boolean>("ApplyInPrompt"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsContextVariableElement"/>.
		/// </summary>
		public SettingsContextVariableElement Clone()
		{
			SettingsContextVariableElement clone = new SettingsContextVariableElement();

			clone.Name = this.Name;
			clone.Type = this.Type;
			clone.LoadProcedure = this.LoadProcedure;
			clone.ApplyInGXUI = this.ApplyInGXUI;
			clone.ApplyInPrompt = this.ApplyInPrompt;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: Security

	public partial class SettingsSecurityElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.Boolean m_Enabled;
		private bool m_IsEnabledDefault;
		private Artech.Genexus.Common.Objects.Procedure m_Check;
		private KBObjectReference m_CheckReference;
		private string m_CheckName;
		private bool m_IsCheckDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_NotAuthorized;
		private KBObjectReference m_NotAuthorizedReference;
		private string m_NotAuthorizedName;
		private bool m_IsNotAuthorizedDefault;
		private System.Boolean m_PromptCheckSecurity;
		private bool m_IsPromptCheckSecurityDefault;
		private System.Boolean m_ComponentCheckSecurity;
		private bool m_IsComponentCheckSecurityDefault;
		private System.Boolean m_SecurityIdTransaction;
		private bool m_IsSecurityIdTransactionDefault;
		private System.String m_SecurityCode;
		private bool m_IsSecurityCodeDefault;
		private System.String m_PromptSecurityCode;
		private bool m_IsPromptSecurityCodeDefault;
		private System.Boolean m_ApplySecurityCodeInTransaction;
		private bool m_IsApplySecurityCodeInTransactionDefault;
		private System.String m_EventStart;
		private bool m_IsEventStartDefault;
		private System.String m_RuleCode;
		private bool m_IsRuleCodeDefault;
		private System.String m_SecurityInEvent;
		private bool m_IsSecurityInEventDefault;
		private SettingsParametersElement m_Parameters;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsSecurityElement"/> class.
		/// </summary>
		public SettingsSecurityElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsSecurityElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Enabled = true;
			m_IsEnabledDefault = true;
			m_Check = null;
			m_CheckReference = null;
			m_CheckName = null;
			m_IsCheckDefault = true;
			m_NotAuthorized = null;
			m_NotAuthorizedReference = null;
			m_NotAuthorizedName = null;
			m_IsNotAuthorizedDefault = true;
			m_PromptCheckSecurity = false;
			m_IsPromptCheckSecurityDefault = true;
			m_ComponentCheckSecurity = false;
			m_IsComponentCheckSecurityDefault = true;
			m_SecurityIdTransaction = false;
			m_IsSecurityIdTransactionDefault = true;
			m_SecurityCode = "";
			m_IsSecurityCodeDefault = true;
			m_PromptSecurityCode = "";
			m_IsPromptSecurityCodeDefault = true;
			m_ApplySecurityCodeInTransaction = true;
			m_IsApplySecurityCodeInTransactionDefault = true;
			m_EventStart = "";
			m_IsEventStartDefault = true;
			m_RuleCode = "";
			m_IsRuleCodeDefault = true;
			m_SecurityInEvent = "Start";
			m_IsSecurityInEventDefault = true;
			m_Parameters = new SettingsParametersElement();
			m_Parameters.Parent = this;
			m_Parameters.ElementName = "Parameters";
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsSecurityElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE para gerar código de verificação de segurança em objetos Webpanels.
		/// Se valor for FALSE, a verificação será realizada na Página Principal de segurança.
		*/
		/// </summary>
		public System.Boolean Enabled
		{
			get { return m_Enabled; }
			set 
			{
				m_Enabled = value;
				m_IsEnabledDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar um objeto Procedure para verificar se o acesso ao objeto atual é autorizado.
		/// Se estiver em branco, nenhuma verificação será realizada.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Procedure Check
		{
			get
			{
				if (m_Check == null && m_CheckReference != null)
					m_Check = (Artech.Genexus.Common.Objects.Procedure)m_CheckReference.GetKBObject(Settings.Model);

				return m_Check;
			}

			set 
			{
				m_Check = value;
				m_CheckReference = (value != null ? new KBObjectReference(value) : null);
				m_CheckName = (value != null ? value.Name : null);
				m_IsCheckDefault = false;
			}
		}

		/// <summary>
		/// Check name.
		/// </summary>
		public string CheckName
		{
			get
			{
				if (m_CheckName == null && m_CheckReference != null)
					m_CheckName = m_CheckReference.GetName(Settings.Model);

				return m_CheckName;
			}
		}

		/// <summary>
		/*
		Selecionar um objeto MasterPage, WebComponent, Webpanel para ser carregado/exibido se o usuário não estiver autorizado a acessar o recurso atual.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel NotAuthorized
		{
			get
			{
				if (m_NotAuthorized == null && m_NotAuthorizedReference != null)
					m_NotAuthorized = (Artech.Genexus.Common.Objects.WebPanel)m_NotAuthorizedReference.GetKBObject(Settings.Model);

				return m_NotAuthorized;
			}

			set 
			{
				m_NotAuthorized = value;
				m_NotAuthorizedReference = (value != null ? new KBObjectReference(value) : null);
				m_NotAuthorizedName = (value != null ? value.Name : null);
				m_IsNotAuthorizedDefault = false;
			}
		}

		/// <summary>
		/// NotAuthorized name.
		/// </summary>
		public string NotAuthorizedName
		{
			get
			{
				if (m_NotAuthorizedName == null && m_NotAuthorizedReference != null)
					m_NotAuthorizedName = m_NotAuthorizedReference.GetName(Settings.Model);

				return m_NotAuthorizedName;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE.
		/// Gera segurança para objeto Prompt.
		*/
		/// </summary>
		public System.Boolean PromptCheckSecurity
		{
			get { return m_PromptCheckSecurity; }
			set 
			{
				m_PromptCheckSecurity = value;
				m_IsPromptCheckSecurityDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE.
		/// Gera segurança para objeto WebComponent.
		*/
		/// </summary>
		public System.Boolean ComponentCheckSecurity
		{
			get { return m_ComponentCheckSecurity; }
			set 
			{
				m_ComponentCheckSecurity = value;
				m_IsComponentCheckSecurityDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE onde código de segurança padrão é o nome da Transaction ou Pgmname.
		*/
		/// </summary>
		public System.Boolean SecurityIdTransaction
		{
			get { return m_SecurityIdTransaction; }
			set 
			{
				m_SecurityIdTransaction = value;
				m_IsSecurityIdTransactionDefault = false;
			}
		}

		/// <summary>
		/*
		Informar código de segurança que será utilizado para o evento Start de todos os objetos.
		/// Curinga {0} é o SecurityId, o nome da Transaction ou então o Pgmname.
		*/
		/// </summary>
		public System.String SecurityCode
		{
			get { return m_SecurityCode; }
			set 
			{
				m_SecurityCode = value;
				m_IsSecurityCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Informar código de segurança que será utilizado para o evento Start somente de objetos Prompt.
		/// Curinga {0} é o SecurityId, o nome da Transaction ou então o Pgmname.
		*/
		/// </summary>
		public System.String PromptSecurityCode
		{
			get { return m_PromptSecurityCode; }
			set 
			{
				m_PromptSecurityCode = value;
				m_IsPromptSecurityCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE.
		/// Aplica código de segurança na Transaction.
		*/
		/// </summary>
		public System.Boolean ApplySecurityCodeInTransaction
		{
			get { return m_ApplySecurityCodeInTransaction; }
			set 
			{
				m_ApplySecurityCodeInTransaction = value;
				m_IsApplySecurityCodeInTransactionDefault = false;
			}
		}

		/// <summary>
		/*
		Informar código de segurança que será utilizado para o evento start da Transaction.
		*/
		/// </summary>
		public System.String EventStart
		{
			get { return m_EventStart; }
			set 
			{
				m_EventStart = value;
				m_IsEventStartDefault = false;
			}
		}

		/// <summary>
		/*
		Informar código de segurança que será utilizado para as regras da Transaction.
		*/
		/// </summary>
		public System.String RuleCode
		{
			get { return m_RuleCode; }
			set 
			{
				m_RuleCode = value;
				m_IsRuleCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar START ou REFRESH.
		/// Define qual evento será aplicado código de segurança.
		*/
		/// </summary>
		public System.String SecurityInEvent
		{
			get { return m_SecurityInEvent; }
			set 
			{
				m_SecurityInEvent = value;
				m_IsSecurityInEventDefault = false;
			}
		}

		public SettingsParametersElement Parameters
		{
			get { return m_Parameters; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="SettingsParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// </summary>
		public SettingsParameterElement AddParameter()
		{
			SettingsParameterElement parameterElement = new SettingsParameterElement();
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsSecurityElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Security")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Security"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Enabled = element.Attributes.GetPropertyValue<System.Boolean>("Enabled");
			m_IsEnabledDefault = element.Attributes.IsPropertyDefault("Enabled");
			m_CheckReference = element.Attributes.GetPropertyValue<KBObjectReference>("CheckReference");
			m_IsCheckDefault = element.Attributes.IsPropertyDefault("Check");
			m_NotAuthorizedReference = element.Attributes.GetPropertyValue<KBObjectReference>("NotAuthorizedReference");
			m_IsNotAuthorizedDefault = element.Attributes.IsPropertyDefault("NotAuthorized");
			m_PromptCheckSecurity = element.Attributes.GetPropertyValue<System.Boolean>("PromptCheckSecurity");
			m_IsPromptCheckSecurityDefault = element.Attributes.IsPropertyDefault("PromptCheckSecurity");
			m_ComponentCheckSecurity = element.Attributes.GetPropertyValue<System.Boolean>("ComponentCheckSecurity");
			m_IsComponentCheckSecurityDefault = element.Attributes.IsPropertyDefault("ComponentCheckSecurity");
			m_SecurityIdTransaction = element.Attributes.GetPropertyValue<System.Boolean>("SecurityIdTransaction");
			m_IsSecurityIdTransactionDefault = element.Attributes.IsPropertyDefault("SecurityIdTransaction");
			m_SecurityCode = element.Attributes.GetPropertyValue<System.String>("SecurityCode");
			m_IsSecurityCodeDefault = element.Attributes.IsPropertyDefault("SecurityCode");
			m_PromptSecurityCode = element.Attributes.GetPropertyValue<System.String>("PromptSecurityCode");
			m_IsPromptSecurityCodeDefault = element.Attributes.IsPropertyDefault("PromptSecurityCode");
			m_ApplySecurityCodeInTransaction = element.Attributes.GetPropertyValue<System.Boolean>("ApplySecurityCodeInTransaction");
			m_IsApplySecurityCodeInTransactionDefault = element.Attributes.IsPropertyDefault("ApplySecurityCodeInTransaction");
			m_EventStart = element.Attributes.GetPropertyValue<System.String>("EventStart");
			m_IsEventStartDefault = element.Attributes.IsPropertyDefault("EventStart");
			m_RuleCode = element.Attributes.GetPropertyValue<System.String>("RuleCode");
			m_IsRuleCodeDefault = element.Attributes.IsPropertyDefault("RuleCode");
			m_SecurityInEvent = element.Attributes.GetPropertyValue<System.String>("SecurityInEvent");
			m_IsSecurityInEventDefault = element.Attributes.IsPropertyDefault("SecurityInEvent");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "Parameters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							SettingsParameterElement parameterElement = new SettingsParameterElement();
							parameterElement.LoadFrom(_childElementItem);
							Parameters.Add(parameterElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="SettingsSecurityElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Security")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Security"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "Enabled", m_Enabled, m_IsEnabledDefault);
			SaveAttribute(element, "CheckReference", m_CheckReference, m_IsCheckDefault);
			SaveAttribute(element, "NotAuthorizedReference", m_NotAuthorizedReference, m_IsNotAuthorizedDefault);
			SaveAttribute(element, "PromptCheckSecurity", m_PromptCheckSecurity, m_IsPromptCheckSecurityDefault);
			SaveAttribute(element, "ComponentCheckSecurity", m_ComponentCheckSecurity, m_IsComponentCheckSecurityDefault);
			SaveAttribute(element, "SecurityIdTransaction", m_SecurityIdTransaction, m_IsSecurityIdTransactionDefault);
			SaveAttribute(element, "SecurityCode", m_SecurityCode, m_IsSecurityCodeDefault);
			SaveAttribute(element, "PromptSecurityCode", m_PromptSecurityCode, m_IsPromptSecurityCodeDefault);
			SaveAttribute(element, "ApplySecurityCodeInTransaction", m_ApplySecurityCodeInTransaction, m_IsApplySecurityCodeInTransactionDefault);
			SaveAttribute(element, "EventStart", m_EventStart, m_IsEventStartDefault);
			SaveAttribute(element, "RuleCode", m_RuleCode, m_IsRuleCodeDefault);
			SaveAttribute(element, "SecurityInEvent", m_SecurityInEvent, m_IsSecurityInEventDefault);

			Debug.Assert(m_Enabled == element.Attributes.GetPropertyValue<System.Boolean>("Enabled"));
			Debug.Assert(m_CheckReference == element.Attributes.GetPropertyValue<KBObjectReference>("CheckReference"));
			Debug.Assert(m_NotAuthorizedReference == element.Attributes.GetPropertyValue<KBObjectReference>("NotAuthorizedReference"));
			Debug.Assert(m_PromptCheckSecurity == element.Attributes.GetPropertyValue<System.Boolean>("PromptCheckSecurity"));
			Debug.Assert(m_ComponentCheckSecurity == element.Attributes.GetPropertyValue<System.Boolean>("ComponentCheckSecurity"));
			Debug.Assert(m_SecurityIdTransaction == element.Attributes.GetPropertyValue<System.Boolean>("SecurityIdTransaction"));
			Debug.Assert(m_SecurityCode == element.Attributes.GetPropertyValue<System.String>("SecurityCode"));
			Debug.Assert(m_PromptSecurityCode == element.Attributes.GetPropertyValue<System.String>("PromptSecurityCode"));
			Debug.Assert(m_ApplySecurityCodeInTransaction == element.Attributes.GetPropertyValue<System.Boolean>("ApplySecurityCodeInTransaction"));
			Debug.Assert(m_EventStart == element.Attributes.GetPropertyValue<System.String>("EventStart"));
			Debug.Assert(m_RuleCode == element.Attributes.GetPropertyValue<System.String>("RuleCode"));
			Debug.Assert(m_SecurityInEvent == element.Attributes.GetPropertyValue<System.String>("SecurityInEvent"));

			// Save element children.
			if (m_Parameters != null)
			{
				foreach (SettingsParameterElement _item in Parameters)
				{
					PatternInstanceElement child = element.Children["Parameters"].Children.AddNewElement("Parameter");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsSecurityElement"/>.
		/// </summary>
		public SettingsSecurityElement Clone()
		{
			SettingsSecurityElement clone = new SettingsSecurityElement();

			clone.Enabled = this.Enabled;
			clone.Check = this.Check;
			clone.NotAuthorized = this.NotAuthorized;
			clone.PromptCheckSecurity = this.PromptCheckSecurity;
			clone.ComponentCheckSecurity = this.ComponentCheckSecurity;
			clone.SecurityIdTransaction = this.SecurityIdTransaction;
			clone.SecurityCode = this.SecurityCode;
			clone.PromptSecurityCode = this.PromptSecurityCode;
			clone.ApplySecurityCodeInTransaction = this.ApplySecurityCodeInTransaction;
			clone.EventStart = this.EventStart;
			clone.RuleCode = this.RuleCode;
			clone.SecurityInEvent = this.SecurityInEvent;
			foreach (SettingsParameterElement parameterElement in this.Parameters)
				clone.Parameters.Add(parameterElement.Clone());

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternSettings.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "Parameters" :
				{
					if (path.Count == 0)
						return Parameters;

					string itemName; int itemIndex;
					HPatternSettings.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "Parameter")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Parameters != null && itemIndex >= 0 && itemIndex < Parameters.Count)
						return Parameters[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="SecurityInEvent"/> property.
		/// </summary>
		public static class SecurityInEventValue
		{
			public const string Start = "Start";
			public const string Refresh = "Refresh";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Security";
		}

		#endregion
	}

	#endregion

	#region Element: Parameters

	public partial class SettingsParametersElement : Artech.Common.Collections.BaseCollection<SettingsParameterElement>
	{
		protected string m_ElementName;

		#region Construction

		internal SettingsParametersElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsParameterElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private SettingsSecurityElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public SettingsSecurityElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<SettingsParameterElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of SettingsParametersElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion


		#region Basic methods

		public override string ToString()
		{
			return "Parameters";
		}

		#endregion
	}

	#endregion

	#region Element: Parameter

	public partial class SettingsParameterElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsParameterElement"/> class.
		/// </summary>
		public SettingsParameterElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsParameterElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
		}

		#endregion

		#region Properties

		private SettingsSecurityElement m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsParameterElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public SettingsSecurityElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Parameter name
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsParameterElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Parameter")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Parameter"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("Name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("Name");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsParameterElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Parameter")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Parameter"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "Name", m_Name, m_IsNameDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("Name"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsParameterElement"/>.
		/// </summary>
		public SettingsParameterElement Clone()
		{
			SettingsParameterElement clone = new SettingsParameterElement();

			clone.Name = this.Name;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: DefaultFilters

	public partial class SettingsDefaultFiltersElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_DefaultTemplateFilter;
		private bool m_IsDefaultTemplateFilterDefault;
		private System.String m_IntervalTemplateFilter;
		private bool m_IsIntervalTemplateFilterDefault;
		private Artech.Common.Collections.BaseCollection<SettingsDefaultFilterElement> m_DefaultFilters;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsDefaultFiltersElement"/> class.
		/// </summary>
		public SettingsDefaultFiltersElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsDefaultFiltersElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_DefaultTemplateFilter = "<tr><td>{0}</td><td colspan=\"3\" >{1}</td></tr>";
			m_IsDefaultTemplateFilterDefault = true;
			m_IntervalTemplateFilter = "<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>";
			m_IsIntervalTemplateFilterDefault = true;
			m_DefaultFilters = new Artech.Common.Collections.BaseCollection<SettingsDefaultFilterElement>();
			m_DefaultFilters.ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsDefaultFilterElement>>(DefaultFilters_ItemAdded);
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsDefaultFiltersElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Define o Template para gerar as linhas de Filtro padrão: ({0} para Textblock), ({1} para Valor)
		*/
		/// </summary>
		public System.String DefaultTemplateFilter
		{
			get { return m_DefaultTemplateFilter; }
			set 
			{
				m_DefaultTemplateFilter = value;
				m_IsDefaultTemplateFilterDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Template para gerar as linhas de Filtro Intervalo: ({0} para Textblock), ({1} para Valor), ({2} para Textblock 2), ({3} para Valor 2)
		*/
		/// </summary>
		public System.String IntervalTemplateFilter
		{
			get { return m_IntervalTemplateFilter; }
			set 
			{
				m_IntervalTemplateFilter = value;
				m_IsIntervalTemplateFilterDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<SettingsDefaultFilterElement> DefaultFilters
		{
			get { return m_DefaultFilters; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="SettingsDefaultFilterElement"/> and adds it to the <see cref="DefaultFilters"/> collection.
		/// </summary>
		public SettingsDefaultFilterElement AddDefaultFilter()
		{
			SettingsDefaultFilterElement defaultFilterElement = new SettingsDefaultFilterElement();
			m_DefaultFilters.Add(defaultFilterElement);
			return defaultFilterElement;
		}

		private void DefaultFilters_ItemAdded(object sender, CollectionItemEventArgs<SettingsDefaultFilterElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsDefaultFiltersElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "DefaultFilters")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "DefaultFilters"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_DefaultTemplateFilter = element.Attributes.GetPropertyValue<System.String>("DefaultTemplateFilter");
			m_IsDefaultTemplateFilterDefault = element.Attributes.IsPropertyDefault("DefaultTemplateFilter");
			m_IntervalTemplateFilter = element.Attributes.GetPropertyValue<System.String>("IntervalTemplateFilter");
			m_IsIntervalTemplateFilterDefault = element.Attributes.IsPropertyDefault("IntervalTemplateFilter");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "DefaultFilter" :
					{
						SettingsDefaultFilterElement defaultFilter = new SettingsDefaultFilterElement();
						defaultFilter.LoadFrom(_childElement);
						DefaultFilters.Add(defaultFilter);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="SettingsDefaultFiltersElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "DefaultFilters")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "DefaultFilters"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "DefaultTemplateFilter", m_DefaultTemplateFilter, m_IsDefaultTemplateFilterDefault);
			SaveAttribute(element, "IntervalTemplateFilter", m_IntervalTemplateFilter, m_IsIntervalTemplateFilterDefault);

			Debug.Assert(m_DefaultTemplateFilter == element.Attributes.GetPropertyValue<System.String>("DefaultTemplateFilter"));
			Debug.Assert(m_IntervalTemplateFilter == element.Attributes.GetPropertyValue<System.String>("IntervalTemplateFilter"));

			// Save element children.
			if (m_DefaultFilters != null)
			{
				foreach (SettingsDefaultFilterElement _item in DefaultFilters)
				{
					PatternInstanceElement defaultFilter = element.Children.AddNewElement("DefaultFilter");
					_item.SaveTo(defaultFilter);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsDefaultFiltersElement"/>.
		/// </summary>
		public SettingsDefaultFiltersElement Clone()
		{
			SettingsDefaultFiltersElement clone = new SettingsDefaultFiltersElement();

			clone.DefaultTemplateFilter = this.DefaultTemplateFilter;
			clone.IntervalTemplateFilter = this.IntervalTemplateFilter;
			foreach (SettingsDefaultFilterElement defaultFilterElement in this.DefaultFilters)
				clone.DefaultFilters.Add(defaultFilterElement.Clone());

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternSettings.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "DefaultFilter" :
				{
					if (DefaultFilters != null && childIndex >= 0 && childIndex < DefaultFilters.Count)
						return DefaultFilters[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Default filters";
		}

		#endregion
	}

	#endregion

	#region Element: DefaultFilter

	public partial class SettingsDefaultFilterElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private Artech.Genexus.Common.Objects.Attribute m_Attribute;
		private KBObjectReference m_AttributeReference;
		private string m_AttributeName;
		private bool m_IsAttributeDefault;
		private System.String m_PartName;
		private bool m_IsPartNameDefault;
		private System.String m_Value;
		private bool m_IsValueDefault;
		private System.Boolean m_Selection;
		private bool m_IsSelectionDefault;
		private System.Boolean m_Prompt;
		private bool m_IsPromptDefault;
		private System.Boolean m_Parm;
		private bool m_IsParmDefault;
		private System.Boolean m_ParmNotNull;
		private bool m_IsParmNotNullDefault;
		private System.Boolean m_InGrid;
		private bool m_IsInGridDefault;
		private System.Boolean m_InGridSelection;
		private bool m_IsInGridSelectionDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsDefaultFilterElement"/> class.
		/// </summary>
		public SettingsDefaultFilterElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsDefaultFilterElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Attribute = null;
			m_AttributeReference = null;
			m_AttributeName = null;
			m_IsAttributeDefault = true;
			m_PartName = "";
			m_IsPartNameDefault = true;
			m_Value = "";
			m_IsValueDefault = true;
			m_Selection = true;
			m_IsSelectionDefault = true;
			m_Prompt = true;
			m_IsPromptDefault = true;
			m_Parm = true;
			m_IsParmDefault = true;
			m_ParmNotNull = false;
			m_IsParmNotNullDefault = true;
			m_InGrid = true;
			m_IsInGridDefault = true;
			m_InGridSelection = true;
			m_IsInGridSelectionDefault = true;
		}

		#endregion

		#region Properties

		private SettingsDefaultFiltersElement m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsDefaultFilterElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public SettingsDefaultFiltersElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Selecionar um objeto atributo.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Attribute Attribute
		{
			get
			{
				if (m_Attribute == null && m_AttributeReference != null)
					m_Attribute = (Artech.Genexus.Common.Objects.Attribute)m_AttributeReference.GetKBObject(Settings.Model);

				return m_Attribute;
			}

			set 
			{
				m_Attribute = value;
				m_AttributeReference = (value != null ? new KBObjectReference(value) : null);
				m_AttributeName = (value != null ? value.Name : null);
				m_IsAttributeDefault = false;
			}
		}

		/// <summary>
		/// Attribute name.
		/// </summary>
		public string AttributeName
		{
			get
			{
				if (m_AttributeName == null && m_AttributeReference != null)
					m_AttributeName = m_AttributeReference.GetName(Settings.Model);

				return m_AttributeName;
			}
		}

		/// <summary>
		/*
		Informar parte do nome de um objeto atributo.
		/// Somente preencher quando um atributo não for informado.
		*/
		/// </summary>
		public System.String PartName
		{
			get { return m_PartName; }
			set 
			{
				m_PartName = value;
				m_IsPartNameDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma condição para o atributo selecionado.
		/// Não aplica-se quando um PartName é informado.
		*/
		/// </summary>
		public System.String Value
		{
			get { return m_Value; }
			set 
			{
				m_Value = value;
				m_IsValueDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE.
		/// Define se este filtro será aplicado ao objeto Selection.
		*/
		/// </summary>
		public System.Boolean Selection
		{
			get { return m_Selection; }
			set 
			{
				m_Selection = value;
				m_IsSelectionDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE.
		/// Define se este filtro será aplicado ao objeto Prompt.
		*/
		/// </summary>
		public System.Boolean Prompt
		{
			get { return m_Prompt; }
			set 
			{
				m_Prompt = value;
				m_IsPromptDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE.
		/// Define se atributo(s) faz parte do parm.
		*/
		/// </summary>
		public System.Boolean Parm
		{
			get { return m_Parm; }
			set 
			{
				m_Parm = value;
				m_IsParmDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE.
		/// Define se atributo(s) no parm será NotNull.
		*/
		/// </summary>
		public System.Boolean ParmNotNull
		{
			get { return m_ParmNotNull; }
			set 
			{
				m_ParmNotNull = value;
				m_IsParmNotNullDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE.
		/// Define a exibição de atributo(s) no grid de objeto(s) Prompt.
		*/
		/// </summary>
		public System.Boolean InGrid
		{
			get { return m_InGrid; }
			set 
			{
				m_InGrid = value;
				m_IsInGridDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE.
		/// Define a exibição de atributo(s) no grid de objeto(s) Selection.
		*/
		/// </summary>
		public System.Boolean InGridSelection
		{
			get { return m_InGridSelection; }
			set 
			{
				m_InGridSelection = value;
				m_IsInGridSelectionDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsDefaultFilterElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "DefaultFilter")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "DefaultFilter"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_AttributeReference = element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference");
			m_IsAttributeDefault = element.Attributes.IsPropertyDefault("attribute");
			m_PartName = element.Attributes.GetPropertyValue<System.String>("PartName");
			m_IsPartNameDefault = element.Attributes.IsPropertyDefault("PartName");
			m_Value = element.Attributes.GetPropertyValue<System.String>("Value");
			m_IsValueDefault = element.Attributes.IsPropertyDefault("Value");
			m_Selection = element.Attributes.GetPropertyValue<System.Boolean>("Selection");
			m_IsSelectionDefault = element.Attributes.IsPropertyDefault("Selection");
			m_Prompt = element.Attributes.GetPropertyValue<System.Boolean>("Prompt");
			m_IsPromptDefault = element.Attributes.IsPropertyDefault("Prompt");
			m_Parm = element.Attributes.GetPropertyValue<System.Boolean>("Parm");
			m_IsParmDefault = element.Attributes.IsPropertyDefault("Parm");
			m_ParmNotNull = element.Attributes.GetPropertyValue<System.Boolean>("ParmNotNull");
			m_IsParmNotNullDefault = element.Attributes.IsPropertyDefault("ParmNotNull");
			m_InGrid = element.Attributes.GetPropertyValue<System.Boolean>("InGrid");
			m_IsInGridDefault = element.Attributes.IsPropertyDefault("InGrid");
			m_InGridSelection = element.Attributes.GetPropertyValue<System.Boolean>("InGridSelection");
			m_IsInGridSelectionDefault = element.Attributes.IsPropertyDefault("InGridSelection");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsDefaultFilterElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "DefaultFilter")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "DefaultFilter"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "attributeReference", m_AttributeReference, m_IsAttributeDefault);
			SaveAttribute(element, "PartName", m_PartName, m_IsPartNameDefault);
			SaveAttribute(element, "Value", m_Value, m_IsValueDefault);
			SaveAttribute(element, "Selection", m_Selection, m_IsSelectionDefault);
			SaveAttribute(element, "Prompt", m_Prompt, m_IsPromptDefault);
			SaveAttribute(element, "Parm", m_Parm, m_IsParmDefault);
			SaveAttribute(element, "ParmNotNull", m_ParmNotNull, m_IsParmNotNullDefault);
			SaveAttribute(element, "InGrid", m_InGrid, m_IsInGridDefault);
			SaveAttribute(element, "InGridSelection", m_InGridSelection, m_IsInGridSelectionDefault);

			Debug.Assert(m_AttributeReference == element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference"));
			Debug.Assert(m_PartName == element.Attributes.GetPropertyValue<System.String>("PartName"));
			Debug.Assert(m_Value == element.Attributes.GetPropertyValue<System.String>("Value"));
			Debug.Assert(m_Selection == element.Attributes.GetPropertyValue<System.Boolean>("Selection"));
			Debug.Assert(m_Prompt == element.Attributes.GetPropertyValue<System.Boolean>("Prompt"));
			Debug.Assert(m_Parm == element.Attributes.GetPropertyValue<System.Boolean>("Parm"));
			Debug.Assert(m_ParmNotNull == element.Attributes.GetPropertyValue<System.Boolean>("ParmNotNull"));
			Debug.Assert(m_InGrid == element.Attributes.GetPropertyValue<System.Boolean>("InGrid"));
			Debug.Assert(m_InGridSelection == element.Attributes.GetPropertyValue<System.Boolean>("InGridSelection"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsDefaultFilterElement"/>.
		/// </summary>
		public SettingsDefaultFilterElement Clone()
		{
			SettingsDefaultFilterElement clone = new SettingsDefaultFilterElement();

			clone.Attribute = this.Attribute;
			clone.PartName = this.PartName;
			clone.Value = this.Value;
			clone.Selection = this.Selection;
			clone.Prompt = this.Prompt;
			clone.Parm = this.Parm;
			clone.ParmNotNull = this.ParmNotNull;
			clone.InGrid = this.InGrid;
			clone.InGridSelection = this.InGridSelection;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Value);
		}

		#endregion
	}

	#endregion

	#region Element: DynamicFilters

	public partial class SettingsDynamicFiltersElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.Boolean m_GenerateDynaicFilters;
		private bool m_IsGenerateDynaicFiltersDefault;
		private System.Int32 m_MaxAttributes;
		private bool m_IsMaxAttributesDefault;
		private System.Int32 m_MaxChoices;
		private bool m_IsMaxChoicesDefault;
		private System.String m_DefaultCondition;
		private bool m_IsDefaultConditionDefault;
		private System.String m_DefaultConditionCaracter;
		private bool m_IsDefaultConditionCaracterDefault;
		private Artech.Genexus.Common.Objects.Image m_RemoveFilterImage;
		private KBObjectReference m_RemoveFilterImageReference;
		private string m_RemoveFilterImageName;
		private bool m_IsRemoveFilterImageDefault;
		private System.String m_RemoveFilterImageTooltip;
		private bool m_IsRemoveFilterImageTooltipDefault;
		private Artech.Genexus.Common.Objects.Domain m_DomainChar;
		private KBObjectReference m_DomainCharReference;
		private string m_DomainCharName;
		private bool m_IsDomainCharDefault;
		private Artech.Genexus.Common.Objects.Domain m_DomainDate;
		private KBObjectReference m_DomainDateReference;
		private string m_DomainDateName;
		private bool m_IsDomainDateDefault;
		private Artech.Genexus.Common.Objects.Domain m_DomainNumber;
		private KBObjectReference m_DomainNumberReference;
		private string m_DomainNumberName;
		private bool m_IsDomainNumberDefault;
		private System.String m_TemplateFilter;
		private bool m_IsTemplateFilterDefault;
		private System.Boolean m_ElementContainer;
		private bool m_IsElementContainerDefault;
		private Artech.Common.Collections.BaseCollection<SettingsFilterElement> m_Filters;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsDynamicFiltersElement"/> class.
		/// </summary>
		public SettingsDynamicFiltersElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsDynamicFiltersElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_GenerateDynaicFilters = false;
			m_IsGenerateDynaicFiltersDefault = true;
			m_MaxAttributes = 15;
			m_IsMaxAttributesDefault = true;
			m_MaxChoices = 5;
			m_IsMaxChoicesDefault = true;
			m_DefaultCondition = "";
			m_IsDefaultConditionDefault = true;
			m_DefaultConditionCaracter = "";
			m_IsDefaultConditionCaracterDefault = true;
			m_RemoveFilterImage = null;
			m_RemoveFilterImageReference = null;
			m_RemoveFilterImageName = null;
			m_IsRemoveFilterImageDefault = true;
			m_RemoveFilterImageTooltip = "Remover Filtro";
			m_IsRemoveFilterImageTooltipDefault = true;
			m_DomainChar = null;
			m_DomainCharReference = null;
			m_DomainCharName = null;
			m_IsDomainCharDefault = true;
			m_DomainDate = null;
			m_DomainDateReference = null;
			m_DomainDateName = null;
			m_IsDomainDateDefault = true;
			m_DomainNumber = null;
			m_DomainNumberReference = null;
			m_DomainNumberName = null;
			m_IsDomainNumberDefault = true;
			m_TemplateFilter = "<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>";
			m_IsTemplateFilterDefault = true;
			m_ElementContainer = false;
			m_IsElementContainerDefault = true;
			m_Filters = new Artech.Common.Collections.BaseCollection<SettingsFilterElement>();
			m_Filters.ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsFilterElement>>(Filters_ItemAdded);
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsDynamicFiltersElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE.
		/// Gera filtros dinâmicos na instância do Pattern.
		*/
		/// </summary>
		public System.Boolean GenerateDynaicFilters
		{
			get { return m_GenerateDynaicFilters; }
			set 
			{
				m_GenerateDynaicFilters = value;
				m_IsGenerateDynaicFiltersDefault = false;
			}
		}

		/// <summary>
		/*
		Informar um valor numérico.
		/// Indica a quantidade máxima de atributos permitidos.
		*/
		/// </summary>
		public System.Int32 MaxAttributes
		{
			get { return m_MaxAttributes; }
			set 
			{
				m_MaxAttributes = value;
				m_IsMaxAttributesDefault = false;
			}
		}

		/// <summary>
		/*
		Informar um valor numérico.
		/// Indica a quantidade máxima de opções de filtros.
		*/
		/// </summary>
		public System.Int32 MaxChoices
		{
			get { return m_MaxChoices; }
			set 
			{
				m_MaxChoices = value;
				m_IsMaxChoicesDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma condição padrão para o filtro.
		*/
		/// </summary>
		public System.String DefaultCondition
		{
			get { return m_DefaultCondition; }
			set 
			{
				m_DefaultCondition = value;
				m_IsDefaultConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma condição padrão para o filtro caracter.
		*/
		/// </summary>
		public System.String DefaultConditionCaracter
		{
			get { return m_DefaultConditionCaracter; }
			set 
			{
				m_DefaultConditionCaracter = value;
				m_IsDefaultConditionCaracterDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar uma imagem.
		/// Será utilizada para remover o filtro.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image RemoveFilterImage
		{
			get
			{
				if (m_RemoveFilterImage == null && m_RemoveFilterImageReference != null)
					m_RemoveFilterImage = (Artech.Genexus.Common.Objects.Image)m_RemoveFilterImageReference.GetKBObject(Settings.Model);

				return m_RemoveFilterImage;
			}

			set 
			{
				m_RemoveFilterImage = value;
				m_RemoveFilterImageReference = (value != null ? new KBObjectReference(value) : null);
				m_RemoveFilterImageName = (value != null ? value.Name : null);
				m_IsRemoveFilterImageDefault = false;
			}
		}

		/// <summary>
		/// RemoveFilterImage name.
		/// </summary>
		public string RemoveFilterImageName
		{
			get
			{
				if (m_RemoveFilterImageName == null && m_RemoveFilterImageReference != null)
					m_RemoveFilterImageName = m_RemoveFilterImageReference.GetName(Settings.Model);

				return m_RemoveFilterImageName;
			}
		}

		/// <summary>
		/*
		Informar uma descrição para ToolTipText da imagem utilizada para remover o filtro.
		*/
		/// </summary>
		public System.String RemoveFilterImageTooltip
		{
			get { return m_RemoveFilterImageTooltip; }
			set 
			{
				m_RemoveFilterImageTooltip = value;
				m_IsRemoveFilterImageTooltipDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar um objeto domínio.
		/// Será utilizado para valor caracter.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Domain DomainChar
		{
			get
			{
				if (m_DomainChar == null && m_DomainCharReference != null)
					m_DomainChar = (Artech.Genexus.Common.Objects.Domain)m_DomainCharReference.GetKBObject(Settings.Model);

				return m_DomainChar;
			}

			set 
			{
				m_DomainChar = value;
				m_DomainCharReference = (value != null ? new KBObjectReference(value) : null);
				m_DomainCharName = (value != null ? value.Name : null);
				m_IsDomainCharDefault = false;
			}
		}

		/// <summary>
		/// DomainChar name.
		/// </summary>
		public string DomainCharName
		{
			get
			{
				if (m_DomainCharName == null && m_DomainCharReference != null)
					m_DomainCharName = m_DomainCharReference.GetName(Settings.Model);

				return m_DomainCharName;
			}
		}

		/// <summary>
		/*
		Selecionar um objeto domínio.
		/// Será utilizado para valor data.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Domain DomainDate
		{
			get
			{
				if (m_DomainDate == null && m_DomainDateReference != null)
					m_DomainDate = (Artech.Genexus.Common.Objects.Domain)m_DomainDateReference.GetKBObject(Settings.Model);

				return m_DomainDate;
			}

			set 
			{
				m_DomainDate = value;
				m_DomainDateReference = (value != null ? new KBObjectReference(value) : null);
				m_DomainDateName = (value != null ? value.Name : null);
				m_IsDomainDateDefault = false;
			}
		}

		/// <summary>
		/// DomainDate name.
		/// </summary>
		public string DomainDateName
		{
			get
			{
				if (m_DomainDateName == null && m_DomainDateReference != null)
					m_DomainDateName = m_DomainDateReference.GetName(Settings.Model);

				return m_DomainDateName;
			}
		}

		/// <summary>
		/*
		Selecionar um objeto domínio.
		/// Será utilizado para valor número.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Domain DomainNumber
		{
			get
			{
				if (m_DomainNumber == null && m_DomainNumberReference != null)
					m_DomainNumber = (Artech.Genexus.Common.Objects.Domain)m_DomainNumberReference.GetKBObject(Settings.Model);

				return m_DomainNumber;
			}

			set 
			{
				m_DomainNumber = value;
				m_DomainNumberReference = (value != null ? new KBObjectReference(value) : null);
				m_DomainNumberName = (value != null ? value.Name : null);
				m_IsDomainNumberDefault = false;
			}
		}

		/// <summary>
		/// DomainNumber name.
		/// </summary>
		public string DomainNumberName
		{
			get
			{
				if (m_DomainNumberName == null && m_DomainNumberReference != null)
					m_DomainNumberName = m_DomainNumberReference.GetName(Settings.Model);

				return m_DomainNumberName;
			}
		}

		/// <summary>
		/*
		Define o Template para gerar as linhas de Filtro: ({0} para Campo), ({1} para Condição), ({2} para Valor), ({3} para Excluir), ({4} para IdContainer)
		*/
		/// </summary>
		public System.String TemplateFilter
		{
			get { return m_TemplateFilter; }
			set 
			{
				m_TemplateFilter = value;
				m_IsTemplateFilterDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE.
		/// Utiliza elemento container para cada item de filtro.
		*/
		/// </summary>
		public System.Boolean ElementContainer
		{
			get { return m_ElementContainer; }
			set 
			{
				m_ElementContainer = value;
				m_IsElementContainerDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<SettingsFilterElement> Filters
		{
			get { return m_Filters; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="SettingsFilterElement"/> and adds it to the <see cref="Filters"/> collection.
		/// </summary>
		public SettingsFilterElement AddFilter()
		{
			SettingsFilterElement filterElement = new SettingsFilterElement();
			m_Filters.Add(filterElement);
			return filterElement;
		}

		/// <summary>
		/// Creates a new <see cref="SettingsFilterElement"/> and adds it to the <see cref="Filters"/> collection.
		/// The SettingsFilterElement is initialized with the specified value.
		/// </summary>
		public SettingsFilterElement AddFilter(System.String name)
		{
			SettingsFilterElement filterElement = new SettingsFilterElement(name);
			m_Filters.Add(filterElement);
			return filterElement;
		}

		/// <summary>
		/// Finds the <see cref="SettingsFilterElement"/> in the <see cref="Filters"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no filterElement is found, null is returned.
		/// </summary>
		public SettingsFilterElement FindFilter(System.String name)
		{
			return Filters.Find(delegate (SettingsFilterElement filterElement) { return filterElement.Name == name; });
		}

		private void Filters_ItemAdded(object sender, CollectionItemEventArgs<SettingsFilterElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsDynamicFiltersElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "DynamicFilters")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "DynamicFilters"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_GenerateDynaicFilters = element.Attributes.GetPropertyValue<System.Boolean>("GenerateDynaicFilters");
			m_IsGenerateDynaicFiltersDefault = element.Attributes.IsPropertyDefault("GenerateDynaicFilters");
			m_MaxAttributes = element.Attributes.GetPropertyValue<System.Int32>("MaxAttributes");
			m_IsMaxAttributesDefault = element.Attributes.IsPropertyDefault("MaxAttributes");
			m_MaxChoices = element.Attributes.GetPropertyValue<System.Int32>("MaxChoices");
			m_IsMaxChoicesDefault = element.Attributes.IsPropertyDefault("MaxChoices");
			m_DefaultCondition = element.Attributes.GetPropertyValue<System.String>("DefaultCondition");
			m_IsDefaultConditionDefault = element.Attributes.IsPropertyDefault("DefaultCondition");
			m_DefaultConditionCaracter = element.Attributes.GetPropertyValue<System.String>("DefaultConditionCaracter");
			m_IsDefaultConditionCaracterDefault = element.Attributes.IsPropertyDefault("DefaultConditionCaracter");
			m_RemoveFilterImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("RemoveFilterImageReference");
			m_IsRemoveFilterImageDefault = element.Attributes.IsPropertyDefault("RemoveFilterImage");
			m_RemoveFilterImageTooltip = element.Attributes.GetPropertyValue<System.String>("RemoveFilterImageTooltip");
			m_IsRemoveFilterImageTooltipDefault = element.Attributes.IsPropertyDefault("RemoveFilterImageTooltip");
			m_DomainCharReference = element.Attributes.GetPropertyValue<KBObjectReference>("DomainCharReference");
			m_IsDomainCharDefault = element.Attributes.IsPropertyDefault("DomainChar");
			m_DomainDateReference = element.Attributes.GetPropertyValue<KBObjectReference>("DomainDateReference");
			m_IsDomainDateDefault = element.Attributes.IsPropertyDefault("DomainDate");
			m_DomainNumberReference = element.Attributes.GetPropertyValue<KBObjectReference>("DomainNumberReference");
			m_IsDomainNumberDefault = element.Attributes.IsPropertyDefault("DomainNumber");
			m_TemplateFilter = element.Attributes.GetPropertyValue<System.String>("TemplateFilter");
			m_IsTemplateFilterDefault = element.Attributes.IsPropertyDefault("TemplateFilter");
			m_ElementContainer = element.Attributes.GetPropertyValue<System.Boolean>("ElementContainer");
			m_IsElementContainerDefault = element.Attributes.IsPropertyDefault("ElementContainer");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "Filter" :
					{
						SettingsFilterElement filter = new SettingsFilterElement();
						filter.LoadFrom(_childElement);
						Filters.Add(filter);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="SettingsDynamicFiltersElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "DynamicFilters")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "DynamicFilters"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "GenerateDynaicFilters", m_GenerateDynaicFilters, m_IsGenerateDynaicFiltersDefault);
			SaveAttribute(element, "MaxAttributes", m_MaxAttributes, m_IsMaxAttributesDefault);
			SaveAttribute(element, "MaxChoices", m_MaxChoices, m_IsMaxChoicesDefault);
			SaveAttribute(element, "DefaultCondition", m_DefaultCondition, m_IsDefaultConditionDefault);
			SaveAttribute(element, "DefaultConditionCaracter", m_DefaultConditionCaracter, m_IsDefaultConditionCaracterDefault);
			SaveAttribute(element, "RemoveFilterImageReference", m_RemoveFilterImageReference, m_IsRemoveFilterImageDefault);
			SaveAttribute(element, "RemoveFilterImageTooltip", m_RemoveFilterImageTooltip, m_IsRemoveFilterImageTooltipDefault);
			SaveAttribute(element, "DomainCharReference", m_DomainCharReference, m_IsDomainCharDefault);
			SaveAttribute(element, "DomainDateReference", m_DomainDateReference, m_IsDomainDateDefault);
			SaveAttribute(element, "DomainNumberReference", m_DomainNumberReference, m_IsDomainNumberDefault);
			SaveAttribute(element, "TemplateFilter", m_TemplateFilter, m_IsTemplateFilterDefault);
			SaveAttribute(element, "ElementContainer", m_ElementContainer, m_IsElementContainerDefault);

			Debug.Assert(m_GenerateDynaicFilters == element.Attributes.GetPropertyValue<System.Boolean>("GenerateDynaicFilters"));
			Debug.Assert(m_MaxAttributes == element.Attributes.GetPropertyValue<System.Int32>("MaxAttributes"));
			Debug.Assert(m_MaxChoices == element.Attributes.GetPropertyValue<System.Int32>("MaxChoices"));
			Debug.Assert(m_DefaultCondition == element.Attributes.GetPropertyValue<System.String>("DefaultCondition"));
			Debug.Assert(m_DefaultConditionCaracter == element.Attributes.GetPropertyValue<System.String>("DefaultConditionCaracter"));
			Debug.Assert(m_RemoveFilterImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("RemoveFilterImageReference"));
			Debug.Assert(m_RemoveFilterImageTooltip == element.Attributes.GetPropertyValue<System.String>("RemoveFilterImageTooltip"));
			Debug.Assert(m_DomainCharReference == element.Attributes.GetPropertyValue<KBObjectReference>("DomainCharReference"));
			Debug.Assert(m_DomainDateReference == element.Attributes.GetPropertyValue<KBObjectReference>("DomainDateReference"));
			Debug.Assert(m_DomainNumberReference == element.Attributes.GetPropertyValue<KBObjectReference>("DomainNumberReference"));
			Debug.Assert(m_TemplateFilter == element.Attributes.GetPropertyValue<System.String>("TemplateFilter"));
			Debug.Assert(m_ElementContainer == element.Attributes.GetPropertyValue<System.Boolean>("ElementContainer"));

			// Save element children.
			if (m_Filters != null)
			{
				foreach (SettingsFilterElement _item in Filters)
				{
					PatternInstanceElement filter = element.Children.AddNewElement("Filter");
					_item.SaveTo(filter);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsDynamicFiltersElement"/>.
		/// </summary>
		public SettingsDynamicFiltersElement Clone()
		{
			SettingsDynamicFiltersElement clone = new SettingsDynamicFiltersElement();

			clone.GenerateDynaicFilters = this.GenerateDynaicFilters;
			clone.MaxAttributes = this.MaxAttributes;
			clone.MaxChoices = this.MaxChoices;
			clone.DefaultCondition = this.DefaultCondition;
			clone.DefaultConditionCaracter = this.DefaultConditionCaracter;
			clone.RemoveFilterImage = this.RemoveFilterImage;
			clone.RemoveFilterImageTooltip = this.RemoveFilterImageTooltip;
			clone.DomainChar = this.DomainChar;
			clone.DomainDate = this.DomainDate;
			clone.DomainNumber = this.DomainNumber;
			clone.TemplateFilter = this.TemplateFilter;
			clone.ElementContainer = this.ElementContainer;
			foreach (SettingsFilterElement filterElement in this.Filters)
				clone.Filters.Add(filterElement.Clone());

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternSettings.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "Filter" :
				{
					if (Filters != null && childIndex >= 0 && childIndex < Filters.Count)
						return Filters[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Dynamic filters";
		}

		#endregion
	}

	#endregion

	#region Element: Filter

	public partial class SettingsFilterElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private System.String m_Expression;
		private bool m_IsExpressionDefault;
		private System.Boolean m_IsCaracter;
		private bool m_IsIsCaracterDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsFilterElement"/> class.
		/// </summary>
		public SettingsFilterElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsFilterElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public SettingsFilterElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsFilterElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_Expression = "";
			m_IsExpressionDefault = true;
			m_IsCaracter = false;
			m_IsIsCaracterDefault = true;
		}

		#endregion

		#region Properties

		private SettingsDynamicFiltersElement m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsFilterElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public SettingsDynamicFiltersElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Informar um nome para o filtro.
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Informar uma descrição para o filtro.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar Expressão de Filtro onde: (n{0} para Atributo), (n{1} para Variável) e (n{2} para Campo e Condição).
		*/
		/// </summary>
		public System.String Expression
		{
			get { return m_Expression; }
			set 
			{
				m_Expression = value;
				m_IsExpressionDefault = false;
			}
		}

		/// <summary>
		/*
		Selecionar TRUE ou FALSE.
		/// Define se o filtro é caracter ou não.
		*/
		/// </summary>
		public System.Boolean IsCaracter
		{
			get { return m_IsCaracter; }
			set 
			{
				m_IsCaracter = value;
				m_IsIsCaracterDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsFilterElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Filter")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Filter"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("Name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("Name");
			m_Description = element.Attributes.GetPropertyValue<System.String>("Description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("Description");
			m_Expression = element.Attributes.GetPropertyValue<System.String>("Expression");
			m_IsExpressionDefault = element.Attributes.IsPropertyDefault("Expression");
			m_IsCaracter = element.Attributes.GetPropertyValue<System.Boolean>("IsCaracter");
			m_IsIsCaracterDefault = element.Attributes.IsPropertyDefault("IsCaracter");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsFilterElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Filter")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Filter"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "Name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "Description", m_Description, m_IsDescriptionDefault);
			SaveAttribute(element, "Expression", m_Expression, m_IsExpressionDefault);
			SaveAttribute(element, "IsCaracter", m_IsCaracter, m_IsIsCaracterDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("Name"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("Description"));
			Debug.Assert(m_Expression == element.Attributes.GetPropertyValue<System.String>("Expression"));
			Debug.Assert(m_IsCaracter == element.Attributes.GetPropertyValue<System.Boolean>("IsCaracter"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsFilterElement"/>.
		/// </summary>
		public SettingsFilterElement Clone()
		{
			SettingsFilterElement clone = new SettingsFilterElement();

			clone.Name = this.Name;
			clone.Description = this.Description;
			clone.Expression = this.Expression;
			clone.IsCaracter = this.IsCaracter;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Description);
		}

		#endregion
	}

	#endregion

	#region Element: Codes

	public partial class SettingsCodesElement : Artech.Common.Collections.BaseCollection<SettingsCodeElement>
	{
		protected string m_ElementName;

		#region Construction

		internal SettingsCodesElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<SettingsCodeElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private HPatternSettings m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<SettingsCodeElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of SettingsCodesElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion


		#region Basic methods

		public override string ToString()
		{
			return "Codes";
		}

		#endregion
	}

	#endregion

	#region Element: Code

	public partial class SettingsCodeElement : IHPatternSettingsElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.Boolean m_Enabled;
		private bool m_IsEnabledDefault;
		private System.String m_EventCode;
		private bool m_IsEventCodeDefault;
		private System.String m_RuleCode;
		private bool m_IsRuleCodeDefault;
		private System.Boolean m_ApplyProcedure;
		private bool m_IsApplyProcedureDefault;
		private System.Boolean m_ApplyTransaction;
		private bool m_IsApplyTransactionDefault;
		private System.Boolean m_ApplyWebPanel;
		private bool m_IsApplyWebPanelDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsCodeElement"/> class.
		/// </summary>
		public SettingsCodeElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsCodeElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Enabled = true;
			m_IsEnabledDefault = true;
			m_EventCode = "";
			m_IsEventCodeDefault = true;
			m_RuleCode = "";
			m_IsRuleCodeDefault = true;
			m_ApplyProcedure = false;
			m_IsApplyProcedureDefault = true;
			m_ApplyTransaction = false;
			m_IsApplyTransactionDefault = true;
			m_ApplyWebPanel = false;
			m_IsApplyWebPanelDefault = true;
		}

		#endregion

		#region Properties

		private HPatternSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsCodeElement"/> belongs.
		/// </summary>
		public HPatternSettings Settings
		{
			get { return ((IHPatternSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternSettingsElement IHPatternSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Nome
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Enabled
		*/
		/// </summary>
		public System.Boolean Enabled
		{
			get { return m_Enabled; }
			set 
			{
				m_Enabled = value;
				m_IsEnabledDefault = false;
			}
		}

		/// <summary>
		/*
		Código para os eventos e código de procedure
		*/
		/// </summary>
		public System.String EventCode
		{
			get { return m_EventCode; }
			set 
			{
				m_EventCode = value;
				m_IsEventCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Código para as regras
		*/
		/// </summary>
		public System.String RuleCode
		{
			get { return m_RuleCode; }
			set 
			{
				m_RuleCode = value;
				m_IsRuleCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica em Procedure
		*/
		/// </summary>
		public System.Boolean ApplyProcedure
		{
			get { return m_ApplyProcedure; }
			set 
			{
				m_ApplyProcedure = value;
				m_IsApplyProcedureDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica em Transaction
		*/
		/// </summary>
		public System.Boolean ApplyTransaction
		{
			get { return m_ApplyTransaction; }
			set 
			{
				m_ApplyTransaction = value;
				m_IsApplyTransactionDefault = false;
			}
		}

		/// <summary>
		/*
		Aplica em WebPanel
		*/
		/// </summary>
		public System.Boolean ApplyWebPanel
		{
			get { return m_ApplyWebPanel; }
			set 
			{
				m_ApplyWebPanel = value;
				m_IsApplyWebPanelDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SettingsCodeElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Code")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Code"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("Name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("Name");
			m_Enabled = element.Attributes.GetPropertyValue<System.Boolean>("Enabled");
			m_IsEnabledDefault = element.Attributes.IsPropertyDefault("Enabled");
			m_EventCode = element.Attributes.GetPropertyValue<System.String>("EventCode");
			m_IsEventCodeDefault = element.Attributes.IsPropertyDefault("EventCode");
			m_RuleCode = element.Attributes.GetPropertyValue<System.String>("RuleCode");
			m_IsRuleCodeDefault = element.Attributes.IsPropertyDefault("RuleCode");
			m_ApplyProcedure = element.Attributes.GetPropertyValue<System.Boolean>("ApplyProcedure");
			m_IsApplyProcedureDefault = element.Attributes.IsPropertyDefault("ApplyProcedure");
			m_ApplyTransaction = element.Attributes.GetPropertyValue<System.Boolean>("ApplyTransaction");
			m_IsApplyTransactionDefault = element.Attributes.IsPropertyDefault("ApplyTransaction");
			m_ApplyWebPanel = element.Attributes.GetPropertyValue<System.Boolean>("ApplyWebPanel");
			m_IsApplyWebPanelDefault = element.Attributes.IsPropertyDefault("ApplyWebPanel");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsCodeElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Code")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Code"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "Name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "Enabled", m_Enabled, m_IsEnabledDefault);
			SaveAttribute(element, "EventCode", m_EventCode, m_IsEventCodeDefault);
			SaveAttribute(element, "RuleCode", m_RuleCode, m_IsRuleCodeDefault);
			SaveAttribute(element, "ApplyProcedure", m_ApplyProcedure, m_IsApplyProcedureDefault);
			SaveAttribute(element, "ApplyTransaction", m_ApplyTransaction, m_IsApplyTransactionDefault);
			SaveAttribute(element, "ApplyWebPanel", m_ApplyWebPanel, m_IsApplyWebPanelDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("Name"));
			Debug.Assert(m_Enabled == element.Attributes.GetPropertyValue<System.Boolean>("Enabled"));
			Debug.Assert(m_EventCode == element.Attributes.GetPropertyValue<System.String>("EventCode"));
			Debug.Assert(m_RuleCode == element.Attributes.GetPropertyValue<System.String>("RuleCode"));
			Debug.Assert(m_ApplyProcedure == element.Attributes.GetPropertyValue<System.Boolean>("ApplyProcedure"));
			Debug.Assert(m_ApplyTransaction == element.Attributes.GetPropertyValue<System.Boolean>("ApplyTransaction"));
			Debug.Assert(m_ApplyWebPanel == element.Attributes.GetPropertyValue<System.Boolean>("ApplyWebPanel"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsCodeElement"/>.
		/// </summary>
		public SettingsCodeElement Clone()
		{
			SettingsCodeElement clone = new SettingsCodeElement();

			clone.Name = this.Name;
			clone.Enabled = this.Enabled;
			clone.EventCode = this.EventCode;
			clone.RuleCode = this.RuleCode;
			clone.ApplyProcedure = this.ApplyProcedure;
			clone.ApplyTransaction = this.ApplyTransaction;
			clone.ApplyWebPanel = this.ApplyWebPanel;

			return clone;
		}

		IHPatternSettingsElement IHPatternSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Name);
		}

		#endregion
	}

	#endregion

	/// <summary>
	/// Base interface for all HPatternSettings elements.
	/// </summary>
	public interface IHPatternSettingsElement
	{
		HPatternSettings Settings { get; }
		IHPatternSettingsElement Parent { get; }
		IHPatternSettingsElement Clone();
	}
}