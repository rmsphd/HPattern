using System;
using System.Text;
using System.Collections.Generic;

using Artech.Genexus.Common;
using Artech.Genexus.Common.Parts;
using Artech.Genexus.Common.Objects;
using Artech.Genexus.Common.Helpers;
using Artech.Common.Properties;

namespace Heurys.Patterns.HPattern
{
	public interface IAttributesItem
	{
		string Id { get; }
		string Name { get; }
		ITypedObject TypeInfo { get; }
		string BasedOn { get; }
		string Description { get; }
        string DescriptionAspa { get; }
		bool Visible { get; }
		string ThemeClass { get; }
		string Format { get; }
		LinkElement Link { get; }
		bool SupportsLink { get; }
        String Width { get; set; }
        String Height { get; set; }
        bool InGrid { get; }
        Artech.Common.Collections.IBaseCollection<LinkElement> Links { get;}
	}

    public partial class FilterAttributeElement : IAttributesItem
    {
        string IAttributesItem.Id
        {
            get { return Name; }
        }

        public bool InGrid
        {
            get { return false; }
        }

        public string DescriptionAspa
        {
            get
            {               
                if (Description.IndexOf("'") >= 0)
                {
                    return String.Format("\"{0}\"", Helpers.TemplateInternal.ResolveDescription(this.Instance.Model, this.Attribute, this.Domain, Description));
                }
                else
                {
                    return String.Format("'{0}'", Helpers.TemplateInternal.ResolveDescription(this.Instance.Model, this.Attribute, this.Domain, Description));
                }
            }
        }

        public string ThemeClass 
        { 
            get { return null; } 
        }

        public bool Visible
        {
            get { return true; }
        }

        public string Format 
        {
            get { return null; }
        }


        public LinkElement Link 
        {
            get {
                if (Links != null)
                {
                    if (Links.Count > 0)
                    {
                        return Links[0];
                    }
                }
                return null;
            } 
        }

        public string LinksEventStart
        {
            get { return Helpers.Template.LinksEventStart(Links); }
        }
        
        string IAttributesItem.Name
        {
            get { return Name; }
        }

        ITypedObject IAttributesItem.TypeInfo
        {
            get { return Domain == null ? Artech.Genexus.Common.Objects.Attribute.Get(Instance.Model, Name) : null ; }
        }

        string IAttributesItem.BasedOn
        {
            get { return Domain == null ? "Attribute:" + Name : "Domain:" + DomainName; }
        }

        bool IAttributesItem.SupportsLink
        {
            get { return false; }
        }
    }

    public partial class AttributeElement : IAttributesItem
    {

        public bool InGrid
        {
            get 
            {
                if (Parent != null)
                {
                    if (Parent is IGridObject)
                    {
                        return true;
                    }
                    else
                    {
                        if (Parent.Parent != null && Parent.Parent is IGridObject)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }


        public string LinksEventStart
        {
            get { return Helpers.Template.LinksEventStart(Links); }
        }

        public string DescriptionAspa
        {
            get
            {
                if (Description.IndexOf("'") >= 0)
                {
                    return String.Format("\"{0}\"", Helpers.TemplateInternal.ResolveDescription(this.Instance.Model, this.Attribute, null, Description));
                }
                else
                {
                    return String.Format("'{0}'", Helpers.TemplateInternal.ResolveDescription(this.Instance.Model, this.Attribute, null, Description));
                }
            }
        }

        string IAttributesItem.Id
        {
            get { return AttributeName; }
        }

        string IAttributesItem.Name
        {
            get { return AttributeName; }
        }

        ITypedObject IAttributesItem.TypeInfo
        {
            get { return Attribute; }
        }

        string IAttributesItem.BasedOn
        {
            get { return "Attribute:" + AttributeName; }
        }

        bool IAttributesItem.SupportsLink
        {
            get { return SupportsLinkHelper.SupportsLink(Attribute); }
        }
        public LinkElement Link
        {
            get
            {
                if (Links != null)
                {
                    if (Links.Count > 0)
                    {
                        return Links[0];
                    }
                }
                return null;
            }
        }

        public bool RequiredAfterVal
        {
            get
            {
                if (RequiredAfterValidate == RequiredAfterValidateValue.True)
                    return true;
                if (RequiredAfterValidate == RequiredAfterValidateValue.False)
                    return false;
                return Instance.Settings.Template.RequiredAfterValidate;
            }
        }

        public bool getRequired(Transaction transaction)
        {
            HPatternSettings settings = Instance.Settings;
            bool required = settings.Template.RequiredNotNullAttribute;
            if (this.Required == AttributeElement.RequiredValue.Default)
            {
                if (transaction == null)
                {
                    required = false;
                }
                else
                {

                    TransactionAttribute ta = transaction.Structure.Root.GetAttribute(this.AttributeName);
                    if (ta == null)
                    {
                        required = false;
                    }
                    else
                    {
                        if (ta.IsNullable == TableAttribute.IsNullableValue.True || ta.IsInferred)
                        {
                            required = false;
                        }
                        if (required && ta.Attribute.GetPropertyValue<bool>(Properties.ATT.Autonumber))
                        {
                            required = false;
                        }
                        if (required && ta.Attribute.Type == eDBType.DATETIME)
                        {
                            required = false;
                        }

                    }
                }
            }
            if (this.Required == AttributeElement.RequiredValue.True)
                required = true;
            if (this.Required == AttributeElement.RequiredValue.False)
                required = false;

            return required;
        }
    }

	public partial class VariableElement : IAttributesItem
	{

        public bool InGrid
        {
            get
            {
                if (Parent != null)
                {
                    if (Parent is IGridObject)
                    {
                        return true;
                    }
                    else
                    {
                        if (Parent.Parent != null && Parent.Parent is IGridObject)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public string LoadCodeAll
        {
            get { return (Instance.Settings.Grid.GridType == SettingsGridElement.GridTypeValue.Standard ? LoadCode : String.Format("{0} = {1}",VariableName,LoadCode)) ; }
        }

        public string DescriptionAspa
        {
            get
            {
                if (Description.IndexOf("'") >= 0)
                {
                    return String.Format("\"{0}\"", Helpers.TemplateInternal.ResolveDescription(this.Instance.Model, this.Attribute, this.Domain, Description));
                }
                else
                {
                    return String.Format("'{0}'", Helpers.TemplateInternal.ResolveDescription(this.Instance.Model, this.Attribute, this.Domain, Description));
                }
            }
        }

        public string LinksEventStart
        {
            get { return Helpers.Template.LinksEventStart(Links); }
        }

		string IAttributesItem.Id
		{
			get { return Variables.VariableId(Name); }
		}

		string IAttributesItem.Name
		{
			get { return VariableName; }
		}

		ITypedObject IAttributesItem.TypeInfo
		{
			get 
            {
                if (Domain == null)
                    return Attribute;
                else
                    return Domain; 
            }
		}

        public LinkElement Link
        {
            get
            {
                if (Links != null)
                {
                    if (Links.Count > 0)
                    {
                        return Links[0];
                    }
                }
                return null;
            }
        }

		string IAttributesItem.BasedOn
		{
			get { return Domain == null ? "Attribute:"+AttributeName : "Domain:" + DomainName; }
		}

		bool IAttributesItem.SupportsLink
		{
			get { return SupportsLinkHelper.SupportsLink(Domain); }
		}
	}

	internal static class SupportsLinkHelper
	{
		public static bool SupportsLink(PropertiesObject obj)
		{
			if (obj != null)
			{
				object controlTypeObjValue = obj.GetPropertyValue(Properties.ATT.ControlType);
				if (controlTypeObjValue != null && controlTypeObjValue is Int32)
				{
					int controlType = (int)controlTypeObjValue;
					return (controlType == Properties.ATT.ControlType_Values.Edit);
				}
			}

			return false;
		}
	}
}
