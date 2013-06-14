// Pattern object constants for pattern HPattern (Heurys)
// Generated on 16/01/2013 17:16:49 by PatternCodeGen

using System;
using Artech.Packages.Patterns;
using Artech.Packages.Patterns.Definition;
using Artech.Packages.Patterns.Engine;

namespace Heurys.Patterns.HPattern
{
	/// <summary>
	/// Objects created by the HPattern pattern.
	/// </summary>
	public static class HPatternObject
	{
		/// <summary>
		/// SDTBC object (0 part templates).
		/// </summary>
		public static PatternObject SDTBC
		{
			get { return GetPatternObject("SDTBC"); }
		}

		/// <summary>
		/// DataProviderBC object (0 part templates).
		/// </summary>
		public static PatternObject DataProviderBC
		{
			get { return GetPatternObject("DataProviderBC"); }
		}

		/// <summary>
		/// DataProviderDSM object (0 part templates).
		/// </summary>
		public static PatternObject DataProviderDSM
		{
			get { return GetPatternObject("DataProviderDSM"); }
		}

		/// <summary>
		/// DataProviderDSM2 object (0 part templates).
		/// </summary>
		public static PatternObject DataProviderDSM2
		{
			get { return GetPatternObject("DataProviderDSM2"); }
		}

		/// <summary>
		/// ProcedureSaveBC object (0 part templates).
		/// </summary>
		public static PatternObject ProcedureSaveBC
		{
			get { return GetPatternObject("ProcedureSaveBC"); }
		}

		/// <summary>
		/// ProcedureBC object (0 part templates).
		/// </summary>
		public static PatternObject ProcedureBC
		{
			get { return GetPatternObject("ProcedureBC"); }
		}

		/// <summary>
		/// TransactionBC object (0 part templates).
		/// </summary>
		public static PatternObject TransactionBC
		{
			get { return GetPatternObject("TransactionBC"); }
		}

		/// <summary>
		/// TransactionBCTab object (0 part templates).
		/// </summary>
		public static PatternObject TransactionBCTab
		{
			get { return GetPatternObject("TransactionBCTab"); }
		}

		/// <summary>
		/// DataProviderGridModel object (3 part templates).
		/// </summary>
		public static PatternObject DataProviderGridModel
		{
			get { return GetPatternObject("DataProviderGridModel"); }
		}

		/// <summary>
		/// SDTGrid object (1 part templates).
		/// </summary>
		public static PatternObject SDTGrid
		{
			get { return GetPatternObject("SDTGrid"); }
		}

		/// <summary>
		/// DataProviderGrid object (3 part templates).
		/// </summary>
		public static PatternObject DataProviderGrid
		{
			get { return GetPatternObject("DataProviderGrid"); }
		}

		/// <summary>
		/// ProcedureGrid object (3 part templates).
		/// </summary>
		public static PatternObject ProcedureGrid
		{
			get { return GetPatternObject("ProcedureGrid"); }
		}

		/// <summary>
		/// Selection object (0 part templates).
		/// </summary>
		public static PatternObject Selection
		{
			get { return GetPatternObject("Selection"); }
		}

		/// <summary>
		/// Prompt object (0 part templates).
		/// </summary>
		public static PatternObject Prompt
		{
			get { return GetPatternObject("Prompt"); }
		}

		/// <summary>
		/// View object (0 part templates).
		/// </summary>
		public static PatternObject View
		{
			get { return GetPatternObject("View"); }
		}

		/// <summary>
		/// TabTabular object (0 part templates).
		/// </summary>
		public static PatternObject TabTabular
		{
			get { return GetPatternObject("TabTabular"); }
		}

		/// <summary>
		/// TabGrid object (0 part templates).
		/// </summary>
		public static PatternObject TabGrid
		{
			get { return GetPatternObject("TabGrid"); }
		}

		/// <summary>
		/// TabGridTrn object (0 part templates).
		/// </summary>
		public static PatternObject TabGridTrn
		{
			get { return GetPatternObject("TabGridTrn"); }
		}

		/// <summary>
		/// ExportSelection object (0 part templates).
		/// </summary>
		public static PatternObject ExportSelection
		{
			get { return GetPatternObject("ExportSelection"); }
		}

		/// <summary>
		/// ExportTabGrid object (0 part templates).
		/// </summary>
		public static PatternObject ExportTabGrid
		{
			get { return GetPatternObject("ExportTabGrid"); }
		}

		/// <summary>
		/// GridSDT object (0 part templates).
		/// </summary>
		public static PatternObject GridSDT
		{
			get { return GetPatternObject("GridSDT"); }
		}

		/// <summary>
		/// TabGridSDT object (0 part templates).
		/// </summary>
		public static PatternObject TabGridSDT
		{
			get { return GetPatternObject("TabGridSDT"); }
		}

		/// <summary>
		/// ListPrograms object (global, 0 part templates).
		/// </summary>
		public static PatternObject ListPrograms
		{
			get { return GetPatternObject("ListPrograms"); }
		}

		private static PatternDefinition PatternDefinition
		{
			get
			{
				PatternDefinition definition = PatternEngine.GetPatternDefinition("HPattern");
				if (definition == null)
					throw new PatternDefinitionException(String.Format("Pattern definition '{0}' not found.", "HPattern"));

				return definition;
			}
		}

		private static PatternObject GetPatternObject(string id)
		{
			PatternObject patternObject = PatternDefinition.GetPatternObject(id);
			if (patternObject == null)
				throw new PatternDefinitionException(String.Format("Object '{0}' not found in definition of pattern '{1}'", id, "HPattern"));

			return patternObject;
		}
	}

	public static class InstanceElements
	{
		public const string Instance = "Instance";
		public const string Documentation = "Documentation";
		public const string GridProperties = "GridProperties";
		public const string GridColumnProperties = "GridColumnProperties";
		public const string GridPropertie = "GridPropertie";
		public const string GridColumnPropertie = "GridColumnPropertie";
		public const string Action = "Action";
		public const string SubAction = "SubAction";
		public const string SubActions = "SubActions";
		public const string Actions = "Actions";
		public const string TransactionAttribute = "TransactionAttribute";
		public const string Attribute = "Attribute";
		public const string Attributes = "Attributes";
		public const string Condition = "Condition";
		public const string Conditions = "Conditions";
		public const string DescriptionAttribute = "DescriptionAttribute";
		public const string Filter = "Filter";
		public const string FilterAttribute = "FilterAttribute";
		public const string FilterAttributes = "FilterAttributes";
		public const string FixedData = "FixedData";
		public const string Level = "Level";
		public const string Link = "Link";
		public const string Modes = "Modes";
		public const string Order = "Order";
		public const string Orders = "Orders";
		public const string OrderAttribute = "OrderAttribute";
		public const string Parameter = "Parameter";
		public const string Parameters = "Parameters";
		public const string Selection = "Selection";
		public const string Prompt = "Prompt";
		public const string Tab = "Tab";
		public const string Tabs = "Tabs";
		public const string GroupTab = "GroupTab";
		public const string Groups = "Groups";
		public const string Transaction = "Transaction";
		public const string WebPanelRoot = "WebPanelRoot";
		public const string View = "View";
		public const string Variable = "Variable";
		public const string DynamicFilters = "DynamicFilters";
		public const string GridStandard = "GridStandard";
		public const string GridFreeStyle = "GridFreeStyle";
		public const string Form = "Form";
		public const string UserTable = "UserTable";
		public const string TabForm = "TabForm";
		public const string FRow = "FRow";
		public const string FCol = "FCol";
		public const string FGroup = "FGroup";
		public const string Row = "Row";
		public const string Text = "Text";
		public const string Group = "Group";
		public const string Column = "Column";
	}

	public static class InstanceChildren
	{
		public static class Instance
		{
			public const string Documentation = "Documentation";
			public const string Transaction = "transaction";
			public const string Level = "level";
			public const string WebPanelRoot = "webPanelRoot";
		}

		public static class GridProperties
		{
			public const string GridPropertie = "GridPropertie";
		}

		public static class GridColumnProperties
		{
			public const string GridColumnPropertie = "GridColumnPropertie";
		}

		public static class Action
		{
			public const string Parameters = "parameters";
			public const string SubActions = "subActions";
		}

		public static class SubAction
		{
			public const string Parameters = "parameters";
		}

		public static class SubActions
		{
			public const string SubAction = "subAction";
		}

		public static class Actions
		{
			public const string Action = "action";
		}

		public static class TransactionAttribute
		{
			public const string Link = "link";
			public const string GridColumnProperties = "GridColumnProperties";
		}

		public static class Attribute
		{
			public const string Link = "link";
			public const string GridColumnProperties = "GridColumnProperties";
		}

		public static class Attributes
		{
			public const string Attribute = "attribute";
			public const string Variable = "variable";
		}

		public static class Conditions
		{
			public const string Condition = "condition";
		}

		public static class Filter
		{
			public const string Attributes = "attributes";
			public const string Conditions = "conditions";
			public const string Dynamicfilters = "dynamicfilters";
		}

		public static class FilterAttribute
		{
			public const string Link = "link";
		}

		public static class FilterAttributes
		{
			public const string FilterAttribute = "filterAttribute";
			public const string Row = "row";
		}

		public static class FixedData
		{
			public const string Attributes = "attributes";
		}

		public static class Level
		{
			public const string DescriptionAttribute = "descriptionAttribute";
			public const string Selection = "selection";
			public const string Prompt = "prompt";
			public const string View = "view";
		}

		public static class Link
		{
			public const string Parameters = "parameters";
		}

		public static class Order
		{
			public const string Attribute = "attribute";
		}

		public static class Orders
		{
			public const string Order = "order";
		}

		public static class Parameters
		{
			public const string Parameter = "parameter";
		}

		public static class Selection
		{
			public const string Modes = "modes";
			public const string Attributes = "attributes";
			public const string Parameters = "parameters";
			public const string Orders = "orders";
			public const string Filter = "filter";
			public const string Actions = "actions";
			public const string GridProperties = "GridProperties";
		}

		public static class Prompt
		{
			public const string Modes = "modes";
			public const string Attributes = "attributes";
			public const string Parameters = "parameters";
			public const string Orders = "orders";
			public const string Filter = "filter";
			public const string Actions = "actions";
			public const string GridProperties = "GridProperties";
		}

		public static class Tab
		{
			public const string Parameters = "parameters";
			public const string Transaction = "transaction";
			public const string Modes = "modes";
			public const string Attributes = "attributes";
			public const string Orders = "orders";
			public const string Filter = "filter";
			public const string Actions = "actions";
			public const string GridProperties = "GridProperties";
		}

		public static class Tabs
		{
			public const string Tab = "tab";
		}

		public static class Groups
		{
			public const string GroupTab = "groupTab";
		}

		public static class Transaction
		{
			public const string Form = "form";
			public const string Parameters = "parameters";
			public const string Actions = "actions";
		}

		public static class WebPanelRoot
		{
			public const string Form = "form";
			public const string Parameters = "parameters";
			public const string Actions = "actions";
		}

		public static class View
		{
			public const string Parameters = "parameters";
			public const string FixedData = "fixedData";
			public const string Groups = "groups";
			public const string Tabs = "tabs";
		}

		public static class Variable
		{
			public const string Link = "link";
			public const string GridColumnProperties = "GridColumnProperties";
		}

		public static class DynamicFilters
		{
			public const string Attributes = "attributes";
		}

		public static class GridStandard
		{
			public const string Attributes = "attributes";
			public const string GridProperties = "GridProperties";
		}

		public static class GridFreeStyle
		{
			public const string Attribute = "attribute";
			public const string _GridFreeStyle = "gridFreeStyle";
			public const string GridStandard = "gridStandard";
		}

		public static class Form
		{
			public const string Row = "row";
			public const string Tab = "tab";
			public const string UserTable = "userTable";
			public const string TransactionAttribute = "TransactionAttribute";
			public const string Groups = "groups";
		}

		public static class TabForm
		{
			public const string Row = "row";
		}

		public static class FRow
		{
			public const string Column = "column";
		}

		public static class FCol
		{
			public const string FilterAttribute = "filterAttribute";
			public const string Text = "text";
			public const string Group = "group";
		}

		public static class FGroup
		{
			public const string Row = "row";
		}

		public static class Row
		{
			public const string Column = "column";
		}

		public static class Group
		{
			public const string Row = "row";
		}

		public static class Column
		{
			public const string Attribute = "attribute";
			public const string Variable = "variable";
			public const string Text = "text";
			public const string Group = "group";
			public const string GridFreeStyle = "gridFreeStyle";
			public const string GridStandard = "gridStandard";
			public const string UserTable = "userTable";
		}

	}

	public static class InstanceAttributes
	{
		public static class Instance
		{
			public const string UpdateTransaction = "updateTransaction";
			public const string UpdateWebPanelBC = "updateWebPanelBC";
			public const string AfterInsert = "afterInsert";
			public const string AfterUpdate = "afterUpdate";
			public const string AfterDelete = "afterDelete";
			public const string SecurityId = "securityId";
		}

		public static class Documentation
		{
			public const string Enabled = "Enabled";
			public const string ObjectName = "ObjectName";
			public const string ObjectDescription = "ObjectDescription";
			public const string SystemDescription = "SystemDescription";
			public const string Author = "Author";
			public const string Date = "Date";
			public const string Requirement = "Requirement";
			public const string Observation = "Observation";
		}

		public static class GridPropertie
		{
			public const string Name = "name";
			public const string Valor = "valor";
		}

		public static class GridColumnPropertie
		{
			public const string Name = "name";
			public const string Valor = "valor";
		}

		public static class Action
		{
			public const string Name = "name";
			public const string Caption = "caption";
			public const string Gxobject = "gxobject";
			public const string GxobjectReference = "gxobjectReference";
			public const string InGrid = "inGrid";
			public const string MultiRowSelection = "multiRowSelection";
			public const string Image = "image";
			public const string ImageReference = "imageReference";
			public const string DisabledImage = "disabledImage";
			public const string DisabledImageReference = "disabledImageReference";
			public const string Tooltip = "tooltip";
			public const string Condition = "condition";
			public const string ButtonClass = "buttonClass";
			public const string EventCode = "EventCode";
			public const string CodeEnable = "CodeEnable";
			public const string Position = "Position";
			public const string Legend = "Legend";
			public const string Width = "Width";
			public const string GridWidth = "GridWidth";
			public const string GridHeight = "GridHeight";
		}

		public static class SubAction
		{
			public const string Name = "name";
			public const string Caption = "caption";
			public const string Gxobject = "gxobject";
			public const string GxobjectReference = "gxobjectReference";
			public const string InGrid = "inGrid";
			public const string MultiRowSelection = "multiRowSelection";
			public const string Image = "image";
			public const string ImageReference = "imageReference";
			public const string DisabledImage = "disabledImage";
			public const string DisabledImageReference = "disabledImageReference";
			public const string Tooltip = "tooltip";
			public const string Condition = "condition";
			public const string ButtonClass = "buttonClass";
			public const string EventCode = "EventCode";
			public const string CodeEnable = "CodeEnable";
			public const string Position = "Position";
			public const string Legend = "Legend";
			public const string Width = "Width";
			public const string GridWidth = "GridWidth";
			public const string GridHeight = "GridHeight";
		}

		public static class TransactionAttribute
		{
			public const string Attribute = "attribute";
			public const string AttributeReference = "attributeReference";
			public const string Description = "description";
			public const string Autolink = "autolink";
			public const string Visible = "visible";
			public const string ThemeClass = "themeClass";
			public const string Format = "format";
			public const string IsValid = "isValid";
			public const string Required = "required";
			public const string RequiredMessage = "requiredMessage";
			public const string RequiredAfterValidate = "requiredAfterValidate";
			public const string Rule = "rule";
			public const string ValueRule = "valueRule";
			public const string Picture = "picture";
			public const string Readonly = "readonly";
			public const string EventValidation = "eventValidation";
			public const string EventStart = "EventStart";
			public const string MaskPicture = "MaskPicture";
			public const string Reverse = "Reverse";
			public const string Signed = "Signed";
			public const string UnmaskedChars = "UnmaskedChars";
			public const string UnmaskedValue = "UnmaskedValue";
			public const string Width = "Width";
			public const string Height = "Height";
			public const string Caption = "caption";
			public const string Class = "Class";
			public const string HTMLFormat = "HTMLFormat";
			public const string TextRule = "TextRule";
			public const string AttributeDescription = "attributeDescription";
			public const string AttributeDescriptionReference = "attributeDescriptionReference";
		}

		public static class Attribute
		{
			public const string _Attribute = "attribute";
			public const string _AttributeReference = "attributeReference";
			public const string Description = "description";
			public const string Autolink = "autolink";
			public const string Visible = "visible";
			public const string ThemeClass = "themeClass";
			public const string Format = "format";
			public const string IsValid = "isValid";
			public const string Required = "required";
			public const string RequiredMessage = "requiredMessage";
			public const string RequiredAfterValidate = "requiredAfterValidate";
			public const string Rule = "rule";
			public const string ValueRule = "valueRule";
			public const string Picture = "picture";
			public const string Readonly = "readonly";
			public const string EventValidation = "eventValidation";
			public const string EventStart = "EventStart";
			public const string MaskPicture = "MaskPicture";
			public const string Reverse = "Reverse";
			public const string Signed = "Signed";
			public const string UnmaskedChars = "UnmaskedChars";
			public const string UnmaskedValue = "UnmaskedValue";
			public const string Width = "Width";
			public const string Height = "Height";
		}

		public static class Condition
		{
			public const string Value = "value";
		}

		public static class DescriptionAttribute
		{
			public const string Attribute = "attribute";
			public const string AttributeReference = "attributeReference";
			public const string Description = "description";
		}

		public static class FilterAttribute
		{
			public const string Name = "name";
			public const string Description = "description";
			public const string Domain = "domain";
			public const string DomainReference = "domainReference";
			public const string Attribute = "attribute";
			public const string AttributeReference = "attributeReference";
			public const string Default = "default";
			public const string AllValue = "allValue";
			public const string Prompt = "prompt";
			public const string PromptReference = "promptReference";
			public const string IsValid = "isValid";
			public const string FilterType = "filterType";
			public const string Width = "Width";
			public const string Height = "Height";
		}

		public static class Level
		{
			public const string Id = "id";
			public const string Name = "name";
			public const string Description = "description";
		}

		public static class Link
		{
			public const string WebpanelObject = "webpanelObject";
			public const string WebpanelObjectReference = "webpanelObjectReference";
			public const string Tooltip = "tooltip";
			public const string Condition = "condition";
			public const string Image = "image";
			public const string ImageReference = "imageReference";
			public const string Type = "type";
		}

		public static class Modes
		{
			public const string Insert = "Insert";
			public const string Update = "Update";
			public const string Delete = "Delete";
			public const string Display = "Display";
			public const string Export = "Export";
			public const string Legend = "Legend";
			public const string InsertCondition = "InsertCondition";
			public const string UpdateCondition = "UpdateCondition";
			public const string DeleteCondition = "DeleteCondition";
			public const string DisplayCondition = "DisplayCondition";
			public const string ExportCondition = "ExportCondition";
		}

		public static class Order
		{
			public const string Name = "name";
		}

		public static class OrderAttribute
		{
			public const string Attribute = "attribute";
			public const string AttributeReference = "attributeReference";
			public const string Description = "description";
			public const string Ascending = "ascending";
		}

		public static class Parameter
		{
			public const string Name = "name";
			public const string Domain = "domain";
			public const string DomainReference = "domainReference";
			public const string Null = "null";
		}

		public static class Selection
		{
			public const string Caption = "caption";
			public const string Description = "description";
			public const string Page = "page";
			public const string IsMain = "isMain";
			public const string MasterPage = "masterPage";
			public const string LoadOnStart = "loadOnStart";
			public const string RequiredFilter = "requiredFilter";
			public const string RequiredFilterMessage = "requiredFilterMessage";
			public const string AutomaticRefresh = "automaticRefresh";
			public const string FilterCollapse = "filterCollapse";
			public const string FilterCollapseDefault = "filterCollapseDefault";
			public const string SetFocus = "setFocus";
			public const string SetFocusAttribute = "setFocusAttribute";
			public const string ObjName = "objName";
			public const string SearchEventCode = "SearchEventCode";
			public const string CurrentPageCombo = "CurrentPageCombo";
			public const string SubCode = "SubCode";
			public const string CallMethod = "CallMethod";
			public const string EventStart = "EventStart";
			public const string Identifier = "Identifier";
			public const string UpdateObject = "updateObject";
			public const string UpdateExport = "updateExport";
			public const string UpdateSDT = "updateSDT";
			public const string CustomRender = "CustomRender";
			public const string AutoResize = "AutoResize";
			public const string Width = "Width";
			public const string Height = "Height";
			public const string AllowSelection = "AllowSelection";
		}

		public static class Prompt
		{
			public const string Name = "name";
			public const string Caption = "caption";
			public const string Description = "description";
			public const string Page = "page";
			public const string IsMain = "isMain";
			public const string MasterPage = "masterPage";
			public const string LoadOnStart = "loadOnStart";
			public const string RequiredFilter = "requiredFilter";
			public const string RequiredFilterMessage = "requiredFilterMessage";
			public const string AutomaticRefresh = "automaticRefresh";
			public const string FilterCollapse = "filterCollapse";
			public const string FilterCollapseDefault = "filterCollapseDefault";
			public const string SetFocus = "setFocus";
			public const string SetFocusAttribute = "setFocusAttribute";
			public const string ObjName = "objName";
			public const string SearchEventCode = "SearchEventCode";
			public const string CurrentPageCombo = "CurrentPageCombo";
			public const string SubCode = "SubCode";
			public const string EventStart = "EventStart";
			public const string UpdateObject = "updateObject";
			public const string CustomRender = "CustomRender";
			public const string CallMethod = "CallMethod";
			public const string AutoResize = "AutoResize";
			public const string Width = "Width";
			public const string Height = "Height";
			public const string AllowSelection = "AllowSelection";
		}

		public static class Tab
		{
			public const string Name = "name";
			public const string Code = "code";
			public const string Description = "description";
			public const string Wcname = "wcname";
			public const string Page = "page";
			public const string Type = "type";
			public const string Condition = "condition";
			public const string ObjName = "objName";
			public const string ListNotNullTabGrid = "listNotNullTabGrid";
			public const string ListNotNullMessage = "listNotNullMessage";
			public const string ListNotNullCondition = "listNotNullCondition";
			public const string CurrentPageCombo = "CurrentPageCombo";
			public const string SubCode = "SubCode";
			public const string CallMethod = "CallMethod";
			public const string AfterInsert = "afterInsert";
			public const string EventStart = "EventStart";
			public const string UpdateObject = "updateObject";
			public const string UpdateExport = "updateExport";
			public const string UpdateSDT = "updateSDT";
			public const string CustomRender = "CustomRender";
			public const string Group = "group";
			public const string Image = "image";
			public const string ImageReference = "imageReference";
			public const string AutoResize = "AutoResize";
			public const string Width = "Width";
			public const string Height = "Height";
			public const string AllowSelection = "AllowSelection";
		}

		public static class GroupTab
		{
			public const string Name = "name";
			public const string Image = "image";
			public const string ImageReference = "imageReference";
		}

		public static class Transaction
		{
			public const string _Transaction = "transaction";
			public const string _TransactionReference = "transactionReference";
			public const string MasterPage = "masterPage";
			public const string DataEntryWebPanelBC = "dataEntryWebPanelBC";
			public const string SetFocus = "setFocus";
			public const string SetFocusAttribute = "setFocusAttribute";
			public const string SetFocusAttributeReference = "setFocusAttributeReference";
			public const string ObjName = "objName";
			public const string EventStart = "EventStart";
			public const string BCSucessCode = "BCSucessCode";
			public const string BCErrorCode = "BCErrorCode";
			public const string UpdateObject = "updateObject";
			public const string UpdateDataProviderAba = "updateDataProviderAba";
			public const string UpdateSDTBC = "updateSDTBC";
		}

		public static class WebPanelRoot
		{
			public const string UpdateObject = "updateObject";
			public const string UpdateDataProviderAba = "updateDataProviderAba";
		}

		public static class View
		{
			public const string Caption = "caption";
			public const string Description = "description";
			public const string BackToSelection = "backToSelection";
			public const string MasterPage = "masterPage";
			public const string UseAsSearchViewer = "useAsSearchViewer";
			public const string ObjName = "objName";
			public const string DisabledTabsIfEditing = "disabledTabsIfEditing";
			public const string UpdateObject = "updateObject";
		}

		public static class Variable
		{
			public const string Name = "name";
			public const string Description = "description";
			public const string Domain = "domain";
			public const string DomainReference = "domainReference";
			public const string Attribute = "attribute";
			public const string AttributeReference = "attributeReference";
			public const string LoadCode = "loadCode";
			public const string Visible = "visible";
			public const string ThemeClass = "themeClass";
			public const string Format = "format";
			public const string IsValid = "isValid";
			public const string Readonly = "readonly";
			public const string MaskPicture = "MaskPicture";
			public const string Reverse = "Reverse";
			public const string Signed = "Signed";
			public const string UnmaskedChars = "UnmaskedChars";
			public const string UnmaskedValue = "UnmaskedValue";
			public const string Width = "Width";
			public const string Height = "Height";
		}

		public static class GridStandard
		{
			public const string Name = "name";
			public const string Description = "description";
			public const string CustomRender = "CustomRender";
		}

		public static class GridFreeStyle
		{
			public const string Name = "name";
			public const string Description = "description";
		}

		public static class Form
		{
			public const string ExternalTab = "externalTab";
		}

		public static class UserTable
		{
			public const string Name = "name";
		}

		public static class TabForm
		{
			public const string Name = "name";
			public const string Description = "description";
			public const string ObjName = "objName";
			public const string Condition = "condition";
			public const string Group = "group";
			public const string Image = "image";
			public const string ImageReference = "imageReference";
			public const string UpdateObject = "updateObject";
		}

		public static class FCol
		{
			public const string ColSpan = "ColSpan";
			public const string RowSpan = "RowSpan";
			public const string Align = "Align";
		}

		public static class FGroup
		{
			public const string Caption = "Caption";
			public const string Class = "Class";
		}

		public static class Row
		{
			public const string Visible = "visible";
		}

		public static class Text
		{
			public const string Name = "name";
			public const string Caption = "caption";
			public const string Visible = "visible";
			public const string Class = "Class";
			public const string HTMLFormat = "HTMLFormat";
			public const string Rule = "Rule";
		}

		public static class Group
		{
			public const string Caption = "Caption";
			public const string Class = "Class";
		}

		public static class Column
		{
			public const string ColSpan = "ColSpan";
			public const string RowSpan = "RowSpan";
			public const string Align = "Align";
		}

	}

	public static class SettingsElements
	{
		public const string Config = "Config";
		public const string CustomCaptions = "CustomCaptions";
		public const string Caption = "Caption";
		public const string CustomThemeMasterPage = "CustomThemeMasterPage";
		public const string ThemeMasterPage = "ThemeMasterPage";
		public const string Documentation = "Documentation";
		public const string SuggestParametersST = "SuggestParametersST";
		public const string SuggestParameterST = "SuggestParameterST";
		public const string SuggestActions = "SuggestActions";
		public const string SuggestAction = "SuggestAction";
		public const string SuggestParameter = "SuggestParameter";
		public const string SuggestParameters = "SuggestParameters";
		public const string Template = "Template";
		public const string SuggestInstance = "SuggestInstance";
		public const string AttributeDefinition = "AttributeDefinition";
		public const string Objects = "Objects";
		public const string Theme = "Theme";
		public const string Labels = "Labels";
		public const string Grid = "Grid";
		public const string TabsProperties = "TabsProperties";
		public const string TabProperty = "TabProperty";
		public const string GridProperties = "GridProperties";
		public const string GridPropertie = "GridPropertie";
		public const string GridColumnPropertie = "GridColumnPropertie";
		public const string MasterPages = "MasterPages";
		public const string StandardActions = "StandardActions";
		public const string Action = "Action";
		public const string ExportAction = "ExportAction";
		public const string Context = "Context";
		public const string ContextVariable = "ContextVariable";
		public const string Security = "Security";
		public const string Parameters = "Parameters";
		public const string Parameter = "Parameter";
		public const string DefaultFilters = "DefaultFilters";
		public const string DefaultFilter = "DefaultFilter";
		public const string DynamicFilters = "DynamicFilters";
		public const string Filter = "Filter";
		public const string Codes = "Codes";
		public const string Code = "Code";
	}

	public static class SettingsChildren
	{
		public static class Config
		{
			public const string Template = "Template";
			public const string TabsProperties = "TabsProperties";
			public const string Documentation = "Documentation";
			public const string Objects = "Objects";
			public const string Theme = "Theme";
			public const string Labels = "Labels";
			public const string Grid = "Grid";
			public const string MasterPages = "MasterPages";
			public const string StandardActions = "StandardActions";
			public const string SuggestActions = "SuggestActions";
			public const string Context = "Context";
			public const string Security = "Security";
			public const string DynamicFilters = "DynamicFilters";
			public const string DefaultFilters = "DefaultFilters";
			public const string SuggestParameters = "SuggestParameters";
			public const string CustomThemeMasterPage = "CustomThemeMasterPage";
			public const string Codes = "Codes";
			public const string CustomCaptions = "CustomCaptions";
		}

		public static class CustomCaptions
		{
			public const string Caption = "Caption";
		}

		public static class CustomThemeMasterPage
		{
			public const string ThemeMasterPage = "ThemeMasterPage";
		}

		public static class SuggestParametersST
		{
			public const string Parameters = "parameters";
		}

		public static class SuggestActions
		{
			public const string Actions = "actions";
		}

		public static class SuggestAction
		{
			public const string Parameters = "parameters";
		}

		public static class SuggestParameters
		{
			public const string Parameter = "parameter";
		}

		public static class Template
		{
			public const string Suggest = "Suggest";
		}

		public static class SuggestInstance
		{
			public const string AttributeDefinition = "AttributeDefinition";
		}

		public static class Grid
		{
			public const string GridProperties = "GridProperties";
		}

		public static class TabsProperties
		{
			public const string TabProperty = "TabProperty";
		}

		public static class GridProperties
		{
			public const string GridPropertie = "GridPropertie";
			public const string GridColumnPropertie = "GridColumnPropertie";
		}

		public static class StandardActions
		{
			public const string Insert = "Insert";
			public const string Update = "Update";
			public const string Delete = "Delete";
			public const string Display = "Display";
			public const string Export = "Export";
			public const string Legend = "Legend";
		}

		public static class Context
		{
			public const string ContextVariable = "ContextVariable";
		}

		public static class Security
		{
			public const string Parameters = "Parameters";
		}

		public static class Parameters
		{
			public const string Parameter = "Parameter";
		}

		public static class DefaultFilters
		{
			public const string DefaultFilter = "DefaultFilter";
		}

		public static class DynamicFilters
		{
			public const string Filter = "Filter";
		}

		public static class Codes
		{
			public const string Code = "Code";
		}

	}

	public static class SettingsAttributes
	{
		public static class Caption
		{
			public const string Name = "name";
			public const string SetPrimaryKey = "SetPrimaryKey";
			public const string SetForeignKey = "SetForeignKey";
			public const string SetNullable = "SetNullable";
			public const string SetEditable = "SetEditable";
			public const string SetRequired = "SetRequired";
			public const string HTMLFormat = "HTMLFormat";
			public const string Rule = "Rule";
			public const string Class = "Class";
		}

		public static class ThemeMasterPage
		{
			public const string Name = "name";
			public const string SetTheme = "SetTheme";
			public const string SetMasterPage = "SetMasterPage";
			public const string Theme = "Theme";
			public const string ThemeReference = "ThemeReference";
			public const string Selection = "Selection";
			public const string SelectionReference = "SelectionReference";
			public const string Prompt = "Prompt";
			public const string PromptReference = "PromptReference";
			public const string Transaction = "Transaction";
			public const string TransactionReference = "TransactionReference";
			public const string View = "View";
			public const string ViewReference = "ViewReference";
		}

		public static class Documentation
		{
			public const string Enabled = "Enabled";
			public const string Template = "Template";
			public const string TemplateReference = "TemplateReference";
			public const string SystemDescription = "SystemDescription";
			public const string Author = "Author";
			public const string Date = "Date";
			public const string Requirement = "Requirement";
			public const string Observation = "Observation";
		}

		public static class SuggestParameterST
		{
			public const string Name = "name";
			public const string Domain = "domain";
			public const string DomainReference = "domainReference";
			public const string Null = "null";
			public const string ApplySelection = "applySelection";
			public const string ApplyTransaction = "applyTransaction";
		}

		public static class SuggestAction
		{
			public const string Name = "name";
			public const string Caption = "caption";
			public const string Gxobject = "gxobject";
			public const string GxobjectReference = "gxobjectReference";
			public const string InGrid = "inGrid";
			public const string MultiRowSelection = "multiRowSelection";
			public const string Image = "image";
			public const string ImageReference = "imageReference";
			public const string DisabledImage = "disabledImage";
			public const string DisabledImageReference = "disabledImageReference";
			public const string Tooltip = "tooltip";
			public const string Legend = "Legend";
			public const string Condition = "condition";
			public const string ButtonClass = "buttonClass";
			public const string EventCode = "EventCode";
			public const string CodeEnable = "CodeEnable";
			public const string Position = "Position";
			public const string SuggestSelection = "suggestSelection";
			public const string SuggestTransaction = "suggestTransaction";
			public const string SuggestPrompt = "suggestPrompt";
			public const string SuggestViewTab = "suggestViewTab";
			public const string Width = "Width";
			public const string GridWidth = "GridWidth";
			public const string GridHeight = "GridHeight";
		}

		public static class SuggestParameter
		{
			public const string Name = "name";
			public const string Domain = "domain";
			public const string DomainReference = "domainReference";
			public const string Null = "null";
		}

		public static class Template
		{
			public const string UpdateTransaction = "UpdateTransaction";
			public const string CompatibilidadeVersao = "CompatibilidadeVersao";
			public const string SelectionIsMain = "SelectionIsMain";
			public const string TabsForParallelTransactions = "TabsForParallelTransactions";
			public const string UseTransactionContext = "UseTransactionContext";
			public const string AfterInsert = "AfterInsert";
			public const string AfterUpdate = "AfterUpdate";
			public const string AfterDelete = "AfterDelete";
			public const string TitleTableClass = "TitleTableClass";
			public const string TitleTextClass = "TitleTextClass";
			public const string TitleImage = "TitleImage";
			public const string TitleImageReference = "TitleImageReference";
			public const string FilterCollapse = "FilterCollapse";
			public const string FilterCollapseDefault = "FilterCollapseDefault";
			public const string TrnTitleTableClass = "TrnTitleTableClass";
			public const string TrnTitleTextClass = "TrnTitleTextClass";
			public const string TrnTitleImage = "TrnTitleImage";
			public const string TrnTitleImageReference = "TrnTitleImageReference";
			public const string ButtonHelp = "ButtonHelp";
			public const string ButtonHelpClass = "ButtonHelpClass";
			public const string ButtonHelpCaption = "ButtonHelpCaption";
			public const string ButtonHelpApplySelection = "ButtonHelpApplySelection";
			public const string EventStart = "EventStart";
			public const string SelectionTemplate = "SelectionTemplate";
			public const string SelectionTemplateReference = "SelectionTemplateReference";
			public const string SelectionTemplateDebug = "SelectionTemplateDebug";
			public const string ViewTemplate = "ViewTemplate";
			public const string ViewTemplateReference = "ViewTemplateReference";
			public const string ViewTemplateDebug = "ViewTemplateDebug";
			public const string PromptTemplate = "PromptTemplate";
			public const string PromptTemplateReference = "PromptTemplateReference";
			public const string PromptTemplateDebug = "PromptTemplateDebug";
			public const string TransactionTemplate = "TransactionTemplate";
			public const string TransactionTemplateReference = "TransactionTemplateReference";
			public const string TransactionTemplateDebug = "TransactionTemplateDebug";
			public const string DataEntryWebPanelBC = "DataEntryWebPanelBC";
			public const string LoadSDTWithDataProvider = "LoadSDTWithDataProvider";
			public const string DisabledTabsIfEditing = "DisabledTabsIfEditing";
			public const string WebPanelBCDefault = "WebPanelBCDefault";
			public const string ListNotNullTabGrid = "ListNotNullTabGrid";
			public const string ListNotNullMessage = "ListNotNullMessage";
			public const string InferedAttributeInSameBeforeColumn = "InferedAttributeInSameBeforeColumn";
			public const string SuggestEventIsValidForForeignKey = "SuggestEventIsValidForForeignKey";
			public const string SuggestMessageNotFoundForeignKey = "SuggestMessageNotFoundForeignKey";
			public const string PopupMessage = "PopupMessage";
			public const string PopupMessageReference = "PopupMessageReference";
			public const string PopupMessageWidth = "PopupMessageWidth";
			public const string PopupMessageHeight = "PopupMessageHeight";
			public const string ValidationWarningMessage = "ValidationWarningMessage";
			public const string ValidationErrorMessage = "ValidationErrorMessage";
			public const string SelectionSetFocus = "SelectionSetFocus";
			public const string TransactionSetFocus = "TransactionSetFocus";
			public const string RequiredNotNullAttribute = "RequiredNotNullAttribute";
			public const string RequiredNotNullMessage = "RequiredNotNullMessage";
			public const string RequiredAfterValidate = "RequiredAfterValidate";
			public const string RuleDate = "RuleDate";
			public const string ValueRuleDate = "ValueRuleDate";
			public const string RuleDateTime = "RuleDateTime";
			public const string ValueRuleDateTime = "ValueRuleDateTime";
			public const string PictureCharacterDefault = "PictureCharacterDefault";
			public const string TabFunction = "TabFunction";
			public const string TabDisabled = "TabDisabled";
			public const string TabDisabledReference = "TabDisabledReference";
			public const string ObjectsNames = "ObjectsNames";
			public const string ObjectsNamesReference = "ObjectsNamesReference";
			public const string CollumnTextAlign = "CollumnTextAlign";
			public const string CollumnAttributeAlign = "CollumnAttributeAlign";
			public const string PromptImage = "PromptImage";
			public const string PromptImageReference = "PromptImageReference";
			public const string PromptClass = "PromptClass";
			public const string PromptSuggestForeignKey = "PromptSuggestForeignKey";
			public const string PromptSuggestNameContains = "PromptSuggestNameContains";
			public const string PromptSuggestParmDescription = "PromptSuggestParmDescription";
			public const string PromptSuggestGridPrimaryKey = "PromptSuggestGridPrimaryKey";
			public const string SuggestView = "SuggestView";
			public const string GenerateViewOnlyBC = "GenerateViewOnlyBC";
			public const string BCSucessCode = "BCSucessCode";
			public const string BCErrorCode = "BCErrorCode";
			public const string BCPrimaryKeyDelimiter = "BCPrimaryKeyDelimiter";
			public const string HideElementIfEdit = "HideElementIfEdit";
			public const string HideElementName = "HideElementName";
			public const string ApplyReturnOnClickAll = "ApplyReturnOnClickAll";
			public const string PromptSearchEvent = "PromptSearchEvent";
			public const string GenerateListPrograms = "GenerateListPrograms";
			public const string GenerateCallBackLink = "GenerateCallBackLink";
		}

		public static class SuggestInstance
		{
			public const string IsValid = "IsValid";
			public const string Required = "Required";
			public const string RequiredMessage = "RequiredMessage";
			public const string RequiredAfterValidate = "RequiredAfterValidate";
			public const string Rule = "Rule";
			public const string ValueRule = "ValueRule";
			public const string Picture = "Picture";
			public const string Readonly = "Readonly";
			public const string Visible = "Visible";
			public const string AttributeInSameBeforeColumn = "AttributeInSameBeforeColumn";
			public const string Description = "Description";
			public const string EventValidation = "EventValidation";
			public const string EventStart = "EventStart";
			public const string MaskPicture = "MaskPicture";
			public const string Reverse = "Reverse";
			public const string Signed = "Signed";
			public const string UnmaskedChars = "UnmaskedChars";
			public const string UnmaskedValue = "UnmaskedValue";
		}

		public static class AttributeDefinition
		{
			public const string Name = "name";
			public const string TypeCharacter = "typeCharacter";
			public const string TypeNumeric = "typeNumeric";
			public const string TypeData = "typeData";
			public const string TypeAll = "typeAll";
			public const string TypeSize = "typeSize";
			public const string TypeDecimal = "typeDecimal";
		}

		public static class Objects
		{
			public const string View = "View";
			public const string Selection = "Selection";
			public const string Controller = "Controller";
			public const string Tabular = "Tabular";
			public const string Export = "Export";
			public const string Prompt = "Prompt";
		}

		public static class Theme
		{
			public const string _Theme = "Theme";
			public const string _ThemeReference = "ThemeReference";
			public const string SetObjectTheme = "SetObjectTheme";
			public const string Button = "Button";
			public const string BtnEnter = "BtnEnter";
			public const string BtnCancel = "BtnCancel";
			public const string SearchButton = "SearchButton";
			public const string ClearButton = "ClearButton";
			public const string Image = "Image";
			public const string Subtitle = "Subtitle";
			public const string TextToLink = "TextToLink";
			public const string PlainText = "PlainText";
			public const string PlainTextEmpty = "PlainTextEmpty";
			public const string Label = "Label";
			public const string ViewTable = "ViewTable";
			public const string Grid = "Grid";
			public const string Table100 = "Table100";
			public const string Separator = "Separator";
			public const string ReadonlyAttribute = "ReadonlyAttribute";
			public const string ReadonlyGridAttribute = "ReadonlyGridAttribute";
			public const string ReadonlyBlobAttribute = "ReadonlyBlobAttribute";
			public const string ReadonlyGridBlobAttribute = "ReadonlyGridBlobAttribute";
			public const string TabTable = "TabTable";
			public const string AttributeKey = "AttributeKey";
			public const string LabelKey = "LabelKey";
			public const string Group = "Group";
			public const string FilterCollapse = "FilterCollapse";
			public const string FilterExpand = "FilterExpand";
		}

		public static class Labels
		{
			public const string GeneralTab = "GeneralTab";
			public const string WorkWithTitle = "WorkWithTitle";
			public const string PromptTitle = "PromptTitle";
			public const string ViewDescription = "ViewDescription";
			public const string OrderedBy = "OrderedBy";
			public const string AllInCombo = "AllInCombo";
			public const string PreviousTab = "PreviousTab";
			public const string NextTab = "NextTab";
			public const string RecordNotFound = "RecordNotFound";
			public const string SaveItem = "SaveItem";
			public const string CloseItem = "CloseItem";
			public const string AttributeCaption = "AttributeCaption";
			public const string GridCaption = "GridCaption";
			public const string FilterCaption = "FilterCaption";
			public const string HTMLFormat = "HTMLFormat";
		}

		public static class Grid
		{
			public const string Rules = "Rules";
			public const string BackColorStyle = "BackColorStyle";
			public const string CellSpacing = "CellSpacing";
			public const string CellPadding = "CellPadding";
			public const string Page = "Page";
			public const string SaveGridState = "SaveGridState";
			public const string EnableDisablePaging = "EnableDisablePaging";
			public const string SearchButton = "SearchButton";
			public const string SearchCaption = "SearchCaption";
			public const string SearchLegend = "SearchLegend";
			public const string ClearButton = "ClearButton";
			public const string ClearCaption = "ClearCaption";
			public const string ClearLegend = "ClearLegend";
			public const string ButtonsAlign = "ButtonsAlign";
			public const string DefaultPagingButtons = "DefaultPagingButtons";
			public const string ImageFirst = "ImageFirst";
			public const string ImageFirstReference = "ImageFirstReference";
			public const string ImageFirstDisabled = "ImageFirstDisabled";
			public const string ImageFirstDisabledReference = "ImageFirstDisabledReference";
			public const string TooltipFirst = "TooltipFirst";
			public const string ImagePrevious = "ImagePrevious";
			public const string ImagePreviousReference = "ImagePreviousReference";
			public const string ImagePreviousDisabled = "ImagePreviousDisabled";
			public const string ImagePreviousDisabledReference = "ImagePreviousDisabledReference";
			public const string TooltipPrevious = "TooltipPrevious";
			public const string ImageNext = "ImageNext";
			public const string ImageNextReference = "ImageNextReference";
			public const string ImageNextDisabled = "ImageNextDisabled";
			public const string ImageNextDisabledReference = "ImageNextDisabledReference";
			public const string TooltipNext = "TooltipNext";
			public const string ImageLast = "ImageLast";
			public const string ImageLastReference = "ImageLastReference";
			public const string ImageLastDisabled = "ImageLastDisabled";
			public const string ImageLastDisabledReference = "ImageLastDisabledReference";
			public const string TooltipLast = "TooltipLast";
			public const string InsertAlign = "InsertAlign";
			public const string LoadOnStart = "LoadOnStart";
			public const string RequiredFilter = "RequiredFilter";
			public const string RequiredFilterMessage = "RequiredFilterMessage";
			public const string AutomaticRefresh = "AutomaticRefresh";
			public const string CurrentPageVisible = "CurrentPageVisible";
			public const string CurrentPageCombo = "CurrentPageCombo";
			public const string MaxPage = "MaxPage";
			public const string MaxRecords = "MaxRecords";
			public const string PageRecordsCombo = "PageRecordsCombo";
			public const string SelectedRecords = "SelectedRecords";
			public const string CheckAll = "CheckAll";
			public const string PagingVariableClass = "PagingVariableClass";
			public const string BuildAutoLink = "BuildAutoLink";
			public const string GridType = "GridType";
			public const string CustomRender = "CustomRender";
			public const string GridGXUIActionOrientation = "GridGXUIActionOrientation";
			public const string AnimateCollapse = "AnimateCollapse";
			public const string PageSize = "PageSize";
			public const string AutoWidth = "AutoWidth";
			public const string Width = "Width";
			public const string Height = "Height";
			public const string RemoteSort = "RemoteSort";
			public const string ForceFit = "ForceFit";
			public const string FiltersText = "FiltersText";
			public const string FirstText = "FirstText";
			public const string PreviousText = "PreviousText";
			public const string NextText = "NextText";
			public const string LastText = "LastText";
			public const string RefreshText = "RefreshText";
			public const string BeforePageText = "BeforePageText";
			public const string AfterPageText = "AfterPageText";
			public const string DisplayMsg = "DisplayMsg";
			public const string EmptyMsg = "EmptyMsg";
			public const string LoadingMsg = "LoadingMsg";
			public const string MinColumnWidth = "MinColumnWidth";
			public const string TitleVisible = "TitleVisible";
			public const string DefaultCondition = "DefaultCondition";
			public const string DefaultConditionCharacter = "DefaultConditionCharacter";
			public const string DefaultConditionBoolean = "DefaultConditionBoolean";
			public const string ChangeRadioTocombo = "ChangeRadioTocombo";
			public const string ChangeLikeInVariableAux = "ChangeLikeInVariableAux";
			public const string SelectionCallMethod = "SelectionCallMethod";
			public const string ViewTabCallMethod = "ViewTabCallMethod";
			public const string PromptCallMethod = "PromptCallMethod";
			public const string FilterIntervalText = "FilterIntervalText";
			public const string GridStandardActionOrientation = "GridStandardActionOrientation";
			public const string GridLoadBitmaps = "GridLoadBitmaps";
			public const string AutoResize = "AutoResize";
			public const string GridWidth = "GridWidth";
			public const string GridHeight = "GridHeight";
			public const string AllowSelection = "AllowSelection";
		}

		public static class TabProperty
		{
			public const string Name = "name";
			public const string Valor = "valor";
		}

		public static class GridPropertie
		{
			public const string Name = "name";
			public const string Valor = "valor";
		}

		public static class GridColumnPropertie
		{
			public const string Name = "name";
			public const string Valor = "valor";
		}

		public static class MasterPages
		{
			public const string Selection = "Selection";
			public const string SelectionReference = "SelectionReference";
			public const string Prompt = "Prompt";
			public const string PromptReference = "PromptReference";
			public const string Transaction = "Transaction";
			public const string TransactionReference = "TransactionReference";
			public const string View = "View";
			public const string ViewReference = "ViewReference";
		}

		public static class StandardActions
		{
			public const string DisabledAppearance = "DisabledAppearance";
			public const string FirstLegend = "FirstLegend";
			public const string PreviousLegend = "PreviousLegend";
			public const string NextLegend = "NextLegend";
			public const string LastLegend = "LastLegend";
			public const string LegendObject = "LegendObject";
			public const string LegendObjectReference = "LegendObjectReference";
		}

		public static class Action
		{
			public const string Caption = "Caption";
			public const string Tooltip = "Tooltip";
			public const string DefaultMode = "DefaultMode";
			public const string PromptMode = "PromptMode";
			public const string Image = "Image";
			public const string ImageReference = "ImageReference";
			public const string DisabledImage = "DisabledImage";
			public const string DisabledImageReference = "DisabledImageReference";
			public const string ButtonClass = "ButtonClass";
			public const string Condition = "Condition";
			public const string CodeEnable = "CodeEnable";
			public const string Position = "Position";
			public const string Legend = "Legend";
			public const string Width = "Width";
			public const string GridWidth = "GridWidth";
			public const string GridHeight = "GridHeight";
		}

		public static class ExportAction
		{
			public const string Caption = "Caption";
			public const string Tooltip = "Tooltip";
			public const string DefaultMode = "DefaultMode";
			public const string PromptMode = "PromptMode";
			public const string Image = "Image";
			public const string ImageReference = "ImageReference";
			public const string DisabledImage = "DisabledImage";
			public const string DisabledImageReference = "DisabledImageReference";
			public const string ButtonClass = "ButtonClass";
			public const string Condition = "Condition";
			public const string CodeEnable = "CodeEnable";
			public const string Position = "Position";
			public const string Legend = "Legend";
			public const string Width = "Width";
			public const string GridWidth = "GridWidth";
			public const string GridHeight = "GridHeight";
			public const string BaseLocation = "BaseLocation";
			public const string Template = "Template";
			public const string StartRow = "StartRow";
			public const string StartColumn = "StartColumn";
		}

		public static class ContextVariable
		{
			public const string Name = "Name";
			public const string Type = "Type";
			public const string TypeReference = "TypeReference";
			public const string LoadProcedure = "LoadProcedure";
			public const string LoadProcedureReference = "LoadProcedureReference";
			public const string ApplyInGXUI = "ApplyInGXUI";
			public const string ApplyInPrompt = "ApplyInPrompt";
		}

		public static class Security
		{
			public const string Enabled = "Enabled";
			public const string Check = "Check";
			public const string CheckReference = "CheckReference";
			public const string NotAuthorized = "NotAuthorized";
			public const string NotAuthorizedReference = "NotAuthorizedReference";
			public const string PromptCheckSecurity = "PromptCheckSecurity";
			public const string ComponentCheckSecurity = "ComponentCheckSecurity";
			public const string SecurityIdTransaction = "SecurityIdTransaction";
			public const string SecurityCode = "SecurityCode";
			public const string PromptSecurityCode = "PromptSecurityCode";
			public const string ApplySecurityCodeInTransaction = "ApplySecurityCodeInTransaction";
			public const string EventStart = "EventStart";
			public const string RuleCode = "RuleCode";
			public const string SecurityInEvent = "SecurityInEvent";
		}

		public static class Parameter
		{
			public const string Name = "Name";
		}

		public static class DefaultFilters
		{
			public const string DefaultTemplateFilter = "DefaultTemplateFilter";
			public const string IntervalTemplateFilter = "IntervalTemplateFilter";
		}

		public static class DefaultFilter
		{
			public const string Attribute = "attribute";
			public const string AttributeReference = "attributeReference";
			public const string PartName = "PartName";
			public const string Value = "Value";
			public const string Selection = "Selection";
			public const string Prompt = "Prompt";
			public const string Parm = "Parm";
			public const string ParmNotNull = "ParmNotNull";
			public const string InGrid = "InGrid";
			public const string InGridSelection = "InGridSelection";
		}

		public static class DynamicFilters
		{
			public const string GenerateDynaicFilters = "GenerateDynaicFilters";
			public const string MaxAttributes = "MaxAttributes";
			public const string MaxChoices = "MaxChoices";
			public const string DefaultCondition = "DefaultCondition";
			public const string DefaultConditionCaracter = "DefaultConditionCaracter";
			public const string RemoveFilterImage = "RemoveFilterImage";
			public const string RemoveFilterImageReference = "RemoveFilterImageReference";
			public const string RemoveFilterImageTooltip = "RemoveFilterImageTooltip";
			public const string DomainChar = "DomainChar";
			public const string DomainCharReference = "DomainCharReference";
			public const string DomainDate = "DomainDate";
			public const string DomainDateReference = "DomainDateReference";
			public const string DomainNumber = "DomainNumber";
			public const string DomainNumberReference = "DomainNumberReference";
			public const string TemplateFilter = "TemplateFilter";
			public const string ElementContainer = "ElementContainer";
		}

		public static class Filter
		{
			public const string Name = "Name";
			public const string Description = "Description";
			public const string Expression = "Expression";
			public const string IsCaracter = "IsCaracter";
		}

		public static class Code
		{
			public const string Name = "Name";
			public const string Enabled = "Enabled";
			public const string EventCode = "EventCode";
			public const string RuleCode = "RuleCode";
			public const string ApplyProcedure = "ApplyProcedure";
			public const string ApplyTransaction = "ApplyTransaction";
			public const string ApplyWebPanel = "ApplyWebPanel";
		}

	}

	public static class HPatternCustomType
	{
		public const string GridCustomRenderProperty = "GridCustomRenderProperty";
		public const string GridCustomRenderColProperty = "GridCustomRenderColProperty";
		public const string ThemeClass = "ThemeClass";
		public const string CustomCaption = "CustomCaption";
		public const string GridCustomRender = "GridCustomRender";
		public const string Group = "Group";
		public const string TabProperty = "TabProperty";
	}
}