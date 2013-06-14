using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Artech.Genexus.Common;
using Artech.Common.Collections;

using Artech.Genexus.Common.Helpers;

namespace Heurys.Patterns.HPattern
{
	public partial class FilterElement
	{

        public FilterAttributeElement AddFilterAttribute(string name)
        {
            return Attributes.AddFilterAttribute(name);
        }

        public IBaseCollection<FilterAttributeElement> FilterAttributes
        {
            get
            {
                IBaseCollection<FilterAttributeElement> tmpList = new BaseCollection<FilterAttributeElement>();
                foreach (IHPatternInstanceElement item in Attributes.Items)
                {
                    if (item is FilterAttributeElement)
                        tmpList.Add((item as FilterAttributeElement));

                    if (item is FRowElement)
                        AddRow((item as FRowElement), tmpList);
                }

                return tmpList.AsReadOnly();
            }
        }

        public int FilterAttributesCountAll
        {
            get
            {
                int c = 0;
                foreach (FilterAttributeElement item in FilterAttributes)
                {
                    c++;
                    if (item.FilterType == FilterAttributeElement.FilterTypeValue.Interval)
                        c++;
                }

                return c;
            }
        }

        private void AddRow(FRowElement row, IBaseCollection<FilterAttributeElement> lista)
        {
            foreach (FColElement col in row.Columns)
            {
                foreach (IHPatternInstanceElement item in col.Items)
                {
                    if (item is FilterAttributeElement)
                        lista.Add((item as FilterAttributeElement));

                    if (item is FGroupElement)
                    {
                        FGroupElement group = item as FGroupElement;
                        foreach (FRowElement grow in group.Rows)
                        {
                            AddRow(grow, lista);
                        }
                    }
                }
            }
        }


        private void DefineVariablesAux(StringBuilder sb)
        {
            foreach (ConditionElement con in Conditions)
            {
                if (!String.IsNullOrEmpty(con.FilterConditionVariable))
                {
                    foreach (FilterAttributeElement filterAtt in FilterAttributes)
                    {
                        if (filterAtt.Name.Equals(con.FilterConditionVariable))
                        {
                            int tamanho = 200;
                            if (filterAtt.Domain != null)
                            {
                                tamanho = filterAtt.Domain.Length+1;
                            }
                            else {
                                if (filterAtt.Attribute != null)
                                {
                                    tamanho = filterAtt.Attribute.Length + 1;
                                }
                                else
                                {
                                    Artech.Genexus.Common.Objects.Attribute att = Artech.Genexus.Common.Objects.Attribute.Get(Instance.Model, filterAtt.Name);
                                    if (att != null)
                                    {
                                        tamanho = att.Length + 1;
                                    }
                                }
                            }
                            sb.AppendLine(Variables.Basic(filterAtt.Name + "Aux", filterAtt.Name + "Aux",eDBType.CHARACTER,tamanho));
                            break;
                        }
                    }
                }
            }
        }

		public string DefineVariables()
		{            
			StringBuilder sb = new StringBuilder();

			foreach (FilterAttributeElement filterAtt in FilterAttributes)
			{
                if (filterAtt.Domain != null)
                    sb.AppendLine(Variables.BasedOnDomain(filterAtt.Name, filterAtt.Domain));
                else
                    sb.AppendLine(Variables.BasedOnAttribute(filterAtt.Name, (filterAtt.Attribute == null ? filterAtt.Name : filterAtt.AttributeName )));

                if (filterAtt.FilterType == FilterAttributeElement.FilterTypeValue.Interval)
                {
                    string name2 = filterAtt.Name.Replace("&", "") + "2";

                    if (filterAtt.Domain != null)
                        sb.AppendLine(Variables.BasedOnDomain(name2, filterAtt.Domain));
                    else
                        sb.AppendLine(Variables.BasedOnAttribute(name2, (filterAtt.Attribute == null ? filterAtt.Name : filterAtt.AttributeName)));

                }

			}
            DefineVariablesAux(sb);
			return sb.ToString();
		}

        public string DefineVariables(List<string> lista)
        {
            StringBuilder sb = new StringBuilder();

            foreach (FilterAttributeElement filterAtt in FilterAttributes)
            {
                if (!lista.Contains(filterAtt.Name.Replace("&", "")))
                {
                    lista.Add(filterAtt.Name.Replace("&", ""));
                    if (filterAtt.Domain != null)
                        sb.AppendLine(Variables.BasedOnDomain(filterAtt.Name, filterAtt.Domain));
                    else
                        sb.AppendLine(Variables.BasedOnAttribute(filterAtt.Name, (filterAtt.Attribute == null ? filterAtt.Name : filterAtt.AttributeName)));
                }

                if (filterAtt.FilterType == FilterAttributeElement.FilterTypeValue.Interval)
                {
                    string name2 = filterAtt.Name.Replace("&", "") + "2";
                    if (!lista.Contains(name2))
                    {
                        lista.Add(name2);
                        if (filterAtt.Domain != null)
                            sb.AppendLine(Variables.BasedOnDomain(name2, filterAtt.Domain));
                        else
                            sb.AppendLine(Variables.BasedOnAttribute(name2, (filterAtt.Attribute == null ? filterAtt.Name : filterAtt.AttributeName)));
                    }
                }
            }
            DefineVariablesAux(sb);
            return sb.ToString();
        }
	}
}
