using System;
using Artech.Packages.Patterns;
using Heurys.Patterns.HPattern.Resources;

namespace Heurys.Patterns.HPattern
{
	public partial class SettingsObjectsElement
	{
		public string SelectionName(SelectionElement selection)
		{
            return (String.IsNullOrEmpty(selection.GetObjectName()) ? ObjectName(this.Selection, selection.Parent.Name) : selection.GetObjectName());
		}

        public string PromptName(PromptElement prompt)
        {
            return (String.IsNullOrEmpty(prompt.GetObjectName()) ? prompt.Name : prompt.GetObjectName());
        }

		public string ViewName(ViewElement view)
		{
            return (String.IsNullOrEmpty(view.GetObjectName()) ? ObjectName(this.View, view.Parent.Name) : view.GetObjectName());
		}

		public string TabName(TabElement tab)
		{
            return (String.IsNullOrEmpty(tab.GetObjectName()) ? tab.Wcname : tab.GetObjectName());
		}

		public string ExportProcedureName(IGridObject gridObject)
		{
			return ObjectName(this.Export, GridObjectName(gridObject));
		}

		public string GridSdtName(IGridObject gridObject)
		{
			return GridObjectName(gridObject) + "SDT";
		}

		public string GridSdtItemName(IGridObject gridObject)
		{
			string gridSdtName = GridSdtName(gridObject);
			return String.Format("{0}.{0}Item", gridSdtName);
		}

		private string GridObjectName(IGridObject gridObject)
		{
			if (gridObject is TabElement)
				return TabName((TabElement)gridObject);

			if (gridObject is SelectionElement)
				return SelectionName((SelectionElement)gridObject);

            if (gridObject is PromptElement)
                return PromptName((PromptElement)gridObject);

			throw new TemplateException(Messages.FormatUnexpectedGridObjectType(gridObject.GetType().FullName));
		}

		private string ObjectName(string formatStr, string obj)
		{
			if (String.IsNullOrEmpty(formatStr))
				throw new ArgumentNullException("formatStr");

			return formatStr.Replace("<Object>", obj);
		}
	}
}
