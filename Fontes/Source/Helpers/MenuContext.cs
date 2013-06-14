using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ch = Artech.Genexus.Common.Helpers;
using Artech.Genexus.Common;
using Artech.Genexus.Common.Types;
using Artech.Genexus.Common.Parts;

namespace Heurys.Patterns.HPattern.Helpers
{
    public class MenuContext
    {
        ActionsElement mActions = null;

        private MenuContext(ActionsElement actions)
        {
            mActions = actions;
        }

        public static MenuContext get(ActionsElement actions)
        {
            return new MenuContext(actions);
        }

        public string Events()
        {
            StringBuilder sb = new StringBuilder();
            if (mActions.isMenuContext)
            {
                sb.AppendLine("Event gxui_Menu1.ItemClick");
                foreach (ActionElement action in mActions)
                {
                    foreach (SubActionElement subAct in action.SubActions)
                    {
                        sb.AppendLine(subAct.Event());
                    }
                }
                sb.AppendLine("EndEvent");
            }
            return sb.ToString();
        }

        public string WebForm()
        {
            StringBuilder sb = new StringBuilder();
            if (mActions.isMenuContext)
            {
                sb.Append(WebFormHelper.BeginControl("gxui.Menu","gxui_Menu1",null)+WebFormHelper.EndControl("gxui.Menu"));
            }
            return sb.ToString();
        }

        public string Variables()
        {
            StringBuilder sb = new StringBuilder();
            if (mActions.isMenuContext)
            {
                Dictionary<string, object> props = new Dictionary<string, object>();
                props.Add(Properties.ATT.Collection, true);
                sb.Append(ch.Variables.Sdt("gxuiButtonCollection", "gxuiButton", props));
                sb.Append(ch.Variables.Sdt("gxuiButton", "gxuiButton"));

            }
            return sb.ToString();
        }

        public void Variables(VariablesPart variables)
        {
            if (mActions.isMenuContext)
            {
                string vname = "gxuiButtonCollection";
                if (variables.GetVariable(vname) == null)
                {
                    Variable var = new Variable(variables);
                    var.Name = vname;
                    DataType.ParseInto(mActions.Parent.Instance.Model, "gxuiButton", var);
                    var.IsCollection = true;
                    variables.Variables.Add(var);
                }
                vname = "gxuiButton";
                if (variables.GetVariable(vname) == null)
                {
                    Variable var = new Variable(variables);                    
                    var.Name = vname;
                    DataType.ParseInto(mActions.Parent.Instance.Model, "gxuiButton", var);
                    variables.Variables.Add(var);
                }

            }
        }

    }
}
