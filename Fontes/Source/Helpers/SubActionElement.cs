using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Heurys.Patterns.HPattern.Helpers;
using Artech.Common.Helpers.Strings;
using System.Globalization;

namespace Heurys.Patterns.HPattern
{


    public partial class SubActionElement : IActionImplementation
    {
        public bool isSubAction
        {
            get
            {
                return true;
            }
        }

        public bool isMenuContext
        {
            get
            {
                return false;
            }
        }

        public string ControlName()
        {
            return this.Parent.Name +"_"+ this.Name;
        }

        public string ToHtml()
        {
            return String.Empty;
        }

        public string ClassName()
        {
            return String.Empty;
        }

        // Events
        public string InitializationCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("&gxuiButton = new()");
            sb.AppendLine("&gxuiButton.Id = '"+this.ControlName()+"'");
            sb.AppendLine("&gxuiButton.Text = '"+this.Caption+"'");
            if (!String.IsNullOrEmpty(this.ImageName))
            {
                sb.AppendLine("&gxuiButton.Icon = " + this.ImageName + ".Link()");
            }
            if (!String.IsNullOrEmpty(this.Condition)) {
            	sb.AppendLine("if not ("+this.Condition+")");
		        sb.AppendLine(Indentation.Indent("&gxuiButton.Disabled = true",1));
                sb.AppendLine("EndIF");
            }
            if (!String.IsNullOrEmpty(this.Tooltip))
            {
                sb.AppendLine("&gxuiButton.Tooltip = '" + this.Tooltip + "'");
            }
            sb.AppendLine("&gxuiButtonCollection.Add(&gxuiButton)");

            return sb.ToString();
        }

        //        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public string EnableDisableCode()
        {
            return String.Empty;
        }

        //        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public string EnableCode()
        {
            return String.Empty;
        }

        //        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public string DisableCode()
        {
            return String.Empty;
        }

        public string Event()        
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("If gxui_Menu1.ItemClickedId = '" + this.ControlName() + "'");
            if (this.CallMethod == SelectionElement.CallMethodValue.Popup || !String.IsNullOrEmpty(this.EventCode))
            {
                sb.AppendLine(Indentation.Indent(this.EventBody(), 1));
                sb.AppendLine(Indentation.Indent("refresh", 1));
            }
            sb.AppendLine("EndIf");
            return sb.ToString();
        }

        private const string k_RowsVariable = "&SelectedRows";

        internal string EventBody()
        {
            bool isMultRow = (this.Parent.Parent is IGridObject && this.MultiRowSelection);

            string method = (this.CallMethod == SelectionElement.CallMethodValue.Popup ? "Popup" : "Call");

            StringBuilder eventBody = new StringBuilder();
            
            if (isMultRow) {
                method = "Call";
                eventBody.AppendLine("Do 'LoadSelectedRows'");
            }

            if (String.IsNullOrEmpty(this.EventCode)) 
            {
                if (!String.IsNullOrEmpty(this.GxobjectName))
                {
                    string callParameters = "";
                        
                    if (isMultRow) {
                        callParameters = k_RowsVariable;
                        if (this.Parameters.Count > 0)
                            callParameters += ", ";
                    }
                                                
                    callParameters += this.Parameters.List();

                    eventBody.Append(this.FormatMethod(method, callParameters));
                }
                else 
                {
                    eventBody.Append("// WARNING: No object defined for action");
                }
            } 
            else 
            {
                eventBody.Append(this.EventCode);
            }
                        
            return eventBody.ToString();

        }

        public string FormatMethod(string method, string parameters)
        {
            string methodFormat = "{1}.{0}({2})";
            return String.Format(CultureInfo.InvariantCulture, methodFormat, this.GxobjectName, method, parameters);
        }   

        public string CallMethod
        {
            get
            {
                if (this.Parent != null)
                {
                    return this.Parent.CallMethod;
                }
                return SelectionElement.CallMethodValue.Link;
            }
        }

        // Variables
        public string DefineVariable()
        {
            return String.Empty;
        }

    }

    
}
