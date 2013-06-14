using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Artech.Genexus.Common.Helpers;
using Artech.Packages.Patterns;
using Heurys.Patterns.HPattern.Resources;

namespace Heurys.Patterns.HPattern
{
	public partial class ParametersElement
	{
		#region Rules

        public string GeraParm(bool bc)
        {
            StringBuilder rules = new StringBuilder();

            rules.Append("parm(");
            int contaParm = 0;
            bool temload = false;
            foreach (ParameterElement pare in this)
            {
                if (contaParm == 1) rules.Append(", ");
                contaParm = 1;
                string var = "&";
                if (pare.Name.Contains("&")) var = "";
                if (pare.Name == "load" || pare.Name == "&load") temload = true;
                rules.AppendFormat("in:{0}{1}", var, pare.Name);
            }
            if (bc && !temload)
            {
                contaParm = 1;
                rules.Append(", in:&load");
            }
            rules.Append(");\r\n");

            if (contaParm == 0) return "";

            return rules.ToString();
        }

		public string Rule()
		{
			return Rule("parm", "in", false);
		}

        public string RuleTabTabular()
        {
            return RuleTabTabular("parm", "in", false);
        }

        public string RuleTabGrid()
        {
            return RuleTabTabular("parm", "in", true);
        }

        public string RuleTabGridBC()
        {
            return RuleTabTabularBC("parm", "in", true);
        }

		public string RuleWithVariables()
		{
            
			return Rule("parm", "in", true);
		}
        
        public string RuleWithVariablesGxui()
        {

            return RuleGxui("parm", "in", true);
        }


        public string RuleWithVariablesPrompt()
        {

            return RulePrompt("parm", true);
        }

		public string RuleForView()
		{
			string parameters = Concatenate("in:", true);
            bool isGeraTabCode = true;
            if (this.Parent != null && this.Parent.Instance.Settings.Template.TabFunction == SettingsTemplateElement.TabFunctionValue.TreeViewAnchor)
            {
                isGeraTabCode = false;
            }
            if (isGeraTabCode)
            {
                if (parameters != String.Empty)
                    parameters += ", ";
                parameters += "in:&TabCode";
            }

			return String.Format("parm({0});", parameters);
		}

		#endregion

		#region Conditions

		public string WhereCondition()
		{
			List<string> conditions = new List<string>();
			foreach (ParameterElement parameter in this)
				if (parameter.IsAttribute)
					conditions.Add(parameter.ParameterCondition);

			return String.Join(" and ", conditions.ToArray());
		}

        public string WhereConditionPrc()
        {
            List<string> conditions = new List<string>();
            foreach (ParameterElement parameter in this)
                if (parameter.IsAttribute)
                    conditions.Add(parameter.ParameterConditionPrc);

            return String.Join(" and ", conditions.ToArray());
        }

		#endregion

		#region Lists

		public string List()
		{
			return Concatenate(String.Empty, false);
		}

        public string ListView()
        {
            return Concatenate(String.Empty, false,true,false,false);
        }

        public string ListSelection()
        {
            return ConcatenateSelection(String.Empty, true);
        }

        public string ListGxui()
        {
            return ConcatenateGXui(String.Empty, false);
        }

        public string ListViewVariablesBK()
        {
            return Concatenate(String.Empty, true, false, true, true);
        }

		public string ListWithVariables()
		{
			return Concatenate(String.Empty, true);
		}

        public string ListViewVariables()
        {
            return Concatenate(String.Empty, true, false, true,false);
        }

		#endregion

		#region Misc

		internal bool IsOnlyAttributes
		{
			get
			{
                bool podeMode = false;
                if (Parent != null && Parent is ViewElement && Parent.Instance.Settings.Template.TabFunction == SettingsTemplateElement.TabFunctionValue.TreeViewAnchor)
                {
                    podeMode = true;
                }
				foreach (ParameterElement parameter in this)
                    if (!parameter.IsAttribute && (!podeMode || parameter.Name.ToLower()!="&mode"))
						return false;

				return true;
			}
		}

		#endregion

		#region Private methods

		private string Rule(string rule, string mode, bool useVariables)
		{
			string contents = ConcatenateSelection((mode != String.Empty ? mode + ":" : String.Empty), useVariables);
			if (contents != String.Empty)
				return String.Format("{0}({1});", rule, contents);
			else
				return String.Empty;
		}

        public string RuleGxui(string rule, string mode, bool useVariables)
        {
            string contents = ConcatenateDPGxui((mode != String.Empty ? mode + ":" : String.Empty), useVariables);
            if (contents != String.Empty)
                return String.Format("{0}({1});", rule, contents);
            else
                return String.Empty;
        }


        private string RuleTabTabular(string rule, string mode, bool useVariables)
        {
            string contents = ConcatenateTabTabular((mode != String.Empty ? mode + ":" : String.Empty), useVariables);
            if (contents != String.Empty)
                return String.Format("{0}({1});", rule, contents);
            else
                return String.Empty;
        }

        private string RuleTabTabularBC(string rule, string mode, bool useVariables)
        {
            string contents = ConcatenateTabTabularBC((mode != String.Empty ? mode + ":" : String.Empty), useVariables);
            if (contents != String.Empty)
                return String.Format("{0}({1});", rule, contents);
            else
                return String.Empty;
        }

        public string Concatenate(string itemPrefix, bool useVariables)
        {
            return Concatenate(itemPrefix, useVariables,false,false,false);
        }

        internal IGridObject getGridObject(IHPatternInstanceElement element)
        {
            if (element != null)
            {
                if (element is IGridObject)
                {
                    return (IGridObject)element;
                } else {
                    return getGridObject(element.Parent);
                }
            }
            return null;
        }

		public string Concatenate(string itemPrefix, bool useVariables,bool events,bool tabgrid,bool ViewCP)
		{            
			StringBuilder sb = new StringBuilder(100);
            bool isCallBL = false;
            string linkCallBack = "''";
            if (Parent.Instance.Settings.Template.GenerateCallBackLink)
            {
                
                if (Parent is LinkElement)
                {
                    IGridObject mgrid = getGridObject(Parent);
                    if (mgrid is SelectionElement)
                    {                        
                        //linkCallBack = mgrid.ObjectName + ".Link(" + mgrid.Parameters.ListSelection() + ")";
                        linkCallBack = "&" + HPatternInstance.PARMCALLBACK;
                        isCallBL = true;
                    }
                }
                /*
                    if (mgrid is TabElement && mgrid.Parent is ViewElement)
                    {
                        ViewElement view = (ViewElement)mgrid.Parent;
                        linkCallBack = view.ObjectName + ".Link(" + view.Parameters.ListView() + ")";
                        isCallBL = true;
                    }
                }
                if (Parent is TabElement)
                {
                    IGridObject mgrid = getGridObject(Parent);
                    if (mgrid is TabElement && mgrid.Parent is ViewElement)
                    {
                        ViewElement view = (ViewElement)mgrid.Parent;
                        linkCallBack = view.ObjectName + ".Link(" + view.Parameters.ListView() + ")";
                        isCallBL = true;
                    }
                }
                */
                if (Parent is ViewElement)
                {                    
                    //if (ViewCP)
                    //{
                    //    ViewElement view = (ViewElement)Parent;
                    //    linkCallBack = "PrSaveLinkCallBack.Udp("+view.ObjectName + ".Link(" + view.Parameters.ListWithVariables() + "))";
                    //}
                    //else
                    //{
                        linkCallBack = "&" + HPatternInstance.PARMCALLBACK;
                    //}
                    isCallBL = true;
                }
            }
            bool changeMode = false;
            if ((events||tabgrid) && Parent != null && Parent is ViewElement && Parent.Instance.Settings.Template.TabFunction == SettingsTemplateElement.TabFunctionValue.TreeViewAnchor)
            {
                changeMode = true;
            }

			for (int i = 0; i < Count; i++)
			{
				sb.Append(itemPrefix);
                if (isCallBL && this[i].Name == "&" + HPatternInstance.PARMCALLBACK)
                {
                    sb.Append(linkCallBack);
                        if (i < Count - 1)
                            sb.Append(", ");
                } 
                else if (changeMode && this[i].Name.ToLower() == "&mode")
                {
                    if (tabgrid == false)
                    {
                        sb.Append("TrnMode.Update");
                        if (i < Count - 1)
                     
                            sb.Append(", ");
                    }
                }
                else
                {
                    sb.Append(useVariables && this[i].Name.IndexOf('&') < 0 ? Variables.VariableName("p" + this[i].Name) : this[i].Name);
                    if (i < Count - 1)
                        sb.Append(", ");
                }
			}

            if (changeMode == false && events == true) {
                if (sb.Length > 0)
                {
                    sb.Append(", ");
                }
                sb.Append("\"\"");
            }

			return sb.ToString();
		}

        public string ConcatenatePrompt(string itemPrefix, bool useVariables)
        {
            StringBuilder sb = new StringBuilder(100);

            for (int i = 0; i < Count; i++)
            {
                ParameterElement par = this[i];
                if (par.IsAttribute)
                {
                    sb.Append(itemPrefix);
                }
                sb.Append(useVariables && par.Name.IndexOf('&') < 0 ? Variables.VariableName("p" + par.Name) : par.Name);
                if (i < Count - 1)
                    sb.Append(", ");
            }

            return sb.ToString();
        }

        public string ConcatenateGXui(string itemPrefix, bool useVariables)
        {
            StringBuilder sb = new StringBuilder(100);

            for (int i = 0; i < Count; i++)
            {
                sb.Append(itemPrefix);
                if (this[i].IsAttribute && String.IsNullOrEmpty(this[i].DomainName) && this[i].Name.IndexOf("TrnMode.") < 0 && this[i].Name.ToLower() != "true")
                {                    
                    sb.Append("&SelectedRow.Item(1).");
                }
                sb.Append(useVariables && this[i].Name.IndexOf('&') < 0 ? Variables.VariableName("p" + this[i].Name) : this[i].Name);
                if (i < Count - 1)
                    sb.Append(", ");
            }

            return sb.ToString();
        }

        public string ConcatenateSelection(string itemPrefix, bool useVariables)
        {
            StringBuilder sb = new StringBuilder(100);

            for (int i = 0; i < Count; i++)
            {
                sb.Append(itemPrefix);
                sb.Append(useVariables ? Variables.VariableName(this[i].Name) : this[i].Name);
                if (i < Count - 1)
                    sb.Append(", ");
            }

            return sb.ToString();
        }

        public string ConcatenateDPGxui(string itemPrefix, bool useVariables)
        {
            StringBuilder sb = new StringBuilder(100);

            sb.Append("&PageNumber, &params");

            for (int i = 0; i < Count; i++)
            {
                //if (this[i].IsAttribute && String.IsNullOrEmpty(this[i].DomainName))
                //{
                    sb.Append(", ");
                    sb.Append(itemPrefix);
                    sb.Append(useVariables ? Variables.VariableName(this[i].Name) : this[i].Name);
                //}
                    
            }
            if (this.Parent.Instance.Levels.Count > 0)
            {
                if (this.Parent.Instance.Levels[0].Selection != null)
                {
                    sb.Append(this.Parent.Instance.Levels[0].Selection.FilterRules);
                }
            }

            foreach (SettingsContextVariableElement var in this.Parent.Instance.Settings.Context)
            {
                if (var.LoadProcedure != null && var.ApplyInGXUI)
                {
                    sb.Append(", &");
                    sb.Append(var.Name);
                }
            }

            return sb.ToString();
        }


        public string ConcatenateTabTabular(string itemPrefix, bool useVariables)
        {
            StringBuilder sb = new StringBuilder(100);

            for (int i = 0; i < Count; i++)
            {
                sb.Append(itemPrefix);
                sb.Append(useVariables ? Variables.VariableName(this[i].Name) : this[i].Name);
                if (i < Count - 1)
                    sb.Append(", ");
            }

            return sb.ToString();
        }

        public string ConcatenateTabTabularBC(string itemPrefix, bool useVariables)
        {
            StringBuilder sb = new StringBuilder(100);

            sb.Append(itemPrefix);
            sb.Append("&Modo, ");

            for (int i = 0; i < Count; i++)
            {
                sb.Append(itemPrefix);
                sb.Append(useVariables ? Variables.VariableName(this[i].Name) : this[i].Name);
                if (i < Count - 1)
                    sb.Append(", ");
            }

            sb.Append(", &load");

            return sb.ToString();
        }

        public string ConcatenatePrc(string itemPrefix, bool useVariables)
        {
            StringBuilder sb = new StringBuilder(100);

            for (int i = 0; i < Count; i++)
            {
                sb.Append(itemPrefix);
                sb.Append(useVariables ? Variables.VariableName(this[i].Name) : this[i].Name);
                if (i < Count - 1)
                    sb.Append(", ");
            }

            return sb.ToString();
        }

        private string RulePrompt(string rule, bool useVariables)
        {
            string contents = ConcatenatePrompt(useVariables);
            if (contents != String.Empty)
                return String.Format("{0}({1});", rule, contents);
            else
                return String.Empty;
        }

        public string ConcatenatePrompt( bool useVariables)
        {
            StringBuilder sb = new StringBuilder(100);
            string itemPrefix = "";

            for (int i = 0; i < Count; i++)
            {
                if (this[i].Null)
                {
                    itemPrefix = "inout:";
                }
                else
                {
                    itemPrefix = "in:";
                }
                sb.Append(itemPrefix);
                sb.Append(useVariables ? Variables.VariableName("p"+this[i].Name) : this[i].Name);
                if (i < Count - 1)
                    sb.Append(", ");
            }

            return sb.ToString();
        }

		#endregion
	}

	public partial class ParameterElement
	{
		public bool IsAttribute
		{
			get
			{
                bool tmp = true;
                if (Variables.IsVariableName(Name)) 
                    tmp = false;
                if (tmp && (Name.IndexOf(".") >= 0 || Name.IndexOf("'") >= 0 || Name.IndexOf("\"") >= 0)) 
                    tmp = false;
                try
                {
                    if (tmp && Artech.Genexus.Common.Objects.Attribute.Get(this.Instance.Model, Name) == null) tmp = false;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message + e.StackTrace);
                }

				return tmp;
			}
		}

		public string ParameterVariable
		{
			get { return Variables.VariableName(Name); }
		}

		public string ParameterCondition
		{
			get
			{
				if (!IsAttribute)
					throw new TemplateException(Messages.FormatParameterConditionNeedsAttribute(Name));

				return String.Format(CultureInfo.InvariantCulture, "{0} = &p{0}", Name);
			}
		}

        public string ParameterConditionPrc
        {
            get
            {
                if (!IsAttribute)
                    throw new TemplateException(Messages.FormatParameterConditionNeedsAttribute(Name));

                return String.Format(CultureInfo.InvariantCulture, "{0} = &{0}", Name);
            }
        }
	}

    public interface IParameters : IHPatternInstanceElement
    {
        ParametersElement Parameters { get; }
    }


}
