private static class WebFormScript
{

	public static string GridColumnPrompt(IAttributesItem item)
	{
		if (item is AttributeElement)
			return GridAttributePrompt((AttributeElement)item);

		if (item is VariableElement)
			return GridVariablePrompt((VariableElement)item);

		throw new TemplateException("Unexpected attributes item: not an attribute or variable");
	}

	public static string GridAttributePrompt(AttributeElement att)
	{
		string defaultThemeClass = att.Instance.Settings.Theme.ReadonlyGridAttribute;
		if (att.Attribute.Type == eDBType.BINARY)
			defaultThemeClass = att.Instance.Settings.Theme.ReadonlyGridBlobAttribute;

		string themeClass = GetThemeClass(att, defaultThemeClass);
		Dictionary<string, object> properties = new Dictionary<string, object>();
		GetControlInfo(att, properties);
		properties[Properties.HTMLSFLCOL.ReturnOnClick] = true;

		return WebForm.GridAttribute(att.AttributeName, themeClass, att.Description, att.Visible, null, properties);
	}

	public static string GridVariablePrompt(VariableElement var)
	{
		string themeClass = GetThemeClass(var, var.Instance.Settings.Theme.ReadonlyGridAttribute);
		Dictionary<string, object> properties = new Dictionary<string, object>();
		properties[Properties.HTMLSFLCOL.ReadOnly] = true;
		GetControlInfo(var, properties);
		properties[Properties.HTMLSFLCOL.ReturnOnClick] = true;
		
		return WebForm.GridVariable(var.VariableName, themeClass, var.Description, var.Visible, null, properties);
	}

	public static string GridColumn(IAttributesItem item)
	{
		if (item is AttributeElement)
			return GridAttribute((AttributeElement)item);

		if (item is VariableElement)
			return GridVariable((VariableElement)item);

		throw new TemplateException("Unexpected attributes item: not an attribute or variable");
	}

    public static string GridColumnBC(IAttributesItem item)
    {
        if (item is AttributeElement) {
            return GridVariableBC((AttributeElement)item);
        }

        if (item is VariableElement)
            return GridVariable((VariableElement)item);

        throw new TemplateException("Unexpected attributes item: not an attribute or variable");
    }

	public static string GridAttribute(AttributeElement att)
	{
		string defaultThemeClass = att.Instance.Settings.Theme.ReadonlyGridAttribute;
		if (att.Attribute.Type == eDBType.BINARY)
			defaultThemeClass = att.Instance.Settings.Theme.ReadonlyGridBlobAttribute;

		string themeClass = GetThemeClass(att, defaultThemeClass);
		Dictionary<string, object> properties = new Dictionary<string, object>();
		GetControlInfo(att, properties);

		return WebForm.GridAttribute(att.AttributeName, themeClass, att.Description, att.Visible, null, properties);
	}

	public static string GridVariable(VariableElement var)
	{
		string themeClass = GetThemeClass(var, var.Instance.Settings.Theme.ReadonlyGridAttribute);
		Dictionary<string, object> properties = new Dictionary<string, object>();
		properties[Properties.HTMLSFLCOL.ReadOnly] = true;
		GetControlInfo(var, properties);

		return WebForm.GridVariable(var.VariableName, themeClass, var.Description, var.Visible, null, properties);
	}

    public static string GridVariableBC(AttributeElement var)
    {
        string themeClass = GetThemeClass(var, var.Instance.Settings.Theme.ReadonlyGridAttribute);
        Dictionary<string, object> properties = new Dictionary<string, object>();
        properties[Properties.HTMLSFLCOL.ReadOnly] = true;
        GetControlInfo(var, properties);

        return WebForm.GridVariable(var.AttributeName, themeClass, var.Description, var.Visible, null, properties);
    }

	public static string Item(IAttributesItem item)
	{
		if (item is AttributeElement)
			return Attribute((AttributeElement)item);

		if (item is VariableElement)
			return Variable((VariableElement)item);

		throw new TemplateException("Unexpected attributes item: not an attribute or variable");
	}

	public static string Attribute(AttributeElement att)
	{
		string defaultThemeClass = att.Instance.Settings.Theme.ReadonlyAttribute;
		if (att.Attribute.Type == eDBType.BINARY)
			defaultThemeClass = att.Instance.Settings.Theme.ReadonlyBlobAttribute;

		string themeClass = GetThemeClass(att, defaultThemeClass);
		Dictionary<string, object> properties = new Dictionary<string, object>();
		GetControlInfo(att, properties);

		return WebForm.Attribute(att.AttributeName, themeClass, null, properties);
	}

	public static string HiddenAttribute(string attName)
	{
		Dictionary<string, object> properties = new Dictionary<string, object>();
		properties[Properties.ATT.ControlType] = Properties.ATT.ControlType_Values.Edit;
		properties[Properties.ATT.InputType] = Properties.ATT.InputType_Values.Values;
		return WebForm.Attribute(attName, null, null, properties);
	}

	public static string Variable(VariableElement var)
	{
		string themeClass = GetThemeClass(var, var.Instance.Settings.Theme.ReadonlyAttribute);
		Dictionary<string, object> properties = new Dictionary<string, object>();
		properties[Properties.HTMLATT.ReadOnly] = true;
		GetControlInfo(var, properties);

		return WebForm.Variable(var.VariableName, themeClass, null, properties);
	}

	private static void GetControlInfo(IAttributesItem item, Dictionary<string, object> properties)
	{
		ITypedObject typeInfo = item.TypeInfo;
		if (typeInfo != null && typeInfo is Artech.Common.Properties.PropertiesObject)
		{
			Artech.Common.Properties.PropertiesObject props = (Artech.Common.Properties.PropertiesObject)typeInfo;
			int controlType = props.GetPropertyValue<int>(Properties.ATT.ControlType);
			int editSuggest = props.GetPropertyValue<int>(Properties.ATT.Suggest);
			int editInputType = props.GetPropertyValue<int>(Properties.ATT.InputType);

			if ((controlType == Properties.ATT.ControlType_Values.DynamicComboBox) ||
				(controlType == Properties.ATT.ControlType_Values.DynamicListBox) ||
				(controlType == Properties.ATT.ControlType_Values.Edit && (editInputType == Properties.ATT.InputType_Values.Descriptions || editSuggest != Properties.ATT.Suggest_Values.No)))
			{
				properties[Properties.ATT.ControlType] = Properties.ATT.ControlType_Values.Edit;
				properties[Properties.ATT.InputType] = Properties.ATT.InputType_Values.Values;
			}
		}
	}

	private static string GetThemeClass(IAttributesItem item, string defaultClass)
	{
		if (!String.IsNullOrEmpty(item.ThemeClass))
			return item.ThemeClass;

		if (!String.IsNullOrEmpty(defaultClass))
			return defaultClass;

		return null;
	}
}
