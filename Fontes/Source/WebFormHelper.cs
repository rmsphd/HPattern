using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Artech.Packages.Patterns;
using Artech.Genexus.Common.Helpers;
using Artech.Genexus.Common;
using Artech.Genexus.Common.CustomTypes;
using Artech.Genexus.Common.Objects;
using System.Security;
using Artech.Common.Diagnostics;

namespace Heurys.Patterns.HPattern
{
    public static class WebFormHelper
    {
        public static string BeginControl(string type, string name, Dictionary<string, object> properties)
        {

            Debug.Assert(type != null);

            if (String.IsNullOrEmpty(name))

                throw new TemplateException(String.Format("Control must have a name ({0})", type));

            StringBuilder attributes = new StringBuilder();

            if (properties != null)

                foreach (KeyValuePair<string, object> prop in properties)

                    attributes.Append(String.Format(" {0}=\"{1}\"", prop.Key, prop.Value.ToString()));



            return String.Format("<gx{0} ControlName=\"{1}\"{2}>", type, name, attributes.ToString());

        }

        public static string EndControl(string type)
        {

            Debug.Assert(type != null);

            return String.Format("</gx{0}>", type);

        }

        public static string VariableSDTCollection(string name, string sdtName)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties["ATTCUSTOMTYPE"] = sdtName;
            properties[Properties.ATT.Collection] = true;            

            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            Dictionary<string, object> attributes = new Dictionary<string, object>();
            attributes["Name"] = Variables.VariableId(name);
            StringBuilder sb = new StringBuilder();
            sb.Append(General.BeginTag("Variable", attributes));
            
            //General.WriteProperties(sb, properties);
            if (properties != null)
            {
                sb.Append("<Properties>");
                foreach (KeyValuePair<string, object> pair in properties)
                {
                    if (string.IsNullOrEmpty(pair.Key))
                    {
                        throw new ArgumentNullException("property.Key");
                    }
                    if (pair.Value == null)
                    {
                        throw new ArgumentNullException("property.Value");
                    }
                    if (!SecurityElement.IsValidTag(pair.Key))
                    {
                        throw new GxException(string.Format("'{0}' is not a valid name when writing property '{0}={1}'.", pair.Key, pair.Value));
                    }
                    sb.Append("\r\n");
                    sb.Append("<Property>");
                    sb.AppendFormat("<Name>{0}</Name>", pair.Key);
                    sb.AppendFormat("<Value>{0}</Value>", SecurityElement.Escape(pair.Value.ToString()));
                    sb.Append("</Property>");
                }
                sb.Append("\r\n</Properties>");
            }

            sb.Append(General.EndTag("Variable"));
            return sb.ToString();        
        }

    }

}
