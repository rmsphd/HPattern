using System;
using System.Collections.Generic;
using System.Text;
using Artech.Genexus.Common.Objects;
using Artech.Common.Helpers.Strings;
using Artech.Architecture.Common.Objects;
using Artech.Architecture.UI.Framework.Services;

namespace Heurys.Patterns.HPattern
{
	public partial class LinkElement
	{
		public string LinkExpression
		{
			get 
			{
                if (!String.IsNullOrEmpty(Webpanel))
                {
                    if (Webpanel.Trim().Length > 0)
                        return String.Format("{0}.Link({1})", Webpanel, Parameters.List());
                }

				return String.Empty;
			}
		}

        public string EventStart
        {
            get
            {
                StringBuilder ret = new StringBuilder();
                if (this.Parent is AttributeElement || this.Parent is VariableElement)
                {
//                    ret.AppendLine("if &Mode = TrnMode.Display or &Mode = TrnMode.Delete");
//                    ret.AppendLine(Indentation.Indent(String.Format("{0}.Visible = false",this.ControlName), 1));
                    if (!String.IsNullOrEmpty(this.Condition)) {
//                        ret.AppendLine("else");
                        ret.AppendLine(String.Format("if not ({0})", this.Condition));
                        ret.AppendLine(Indentation.Indent(String.Format("{0}.Visible = false", this.ControlName), 1));
                        ret.AppendLine("endif");
                    }
//                    ret.AppendLine("endif");
                }
                if (this.Parent is FilterAttributeElement)
                {
                    if (!String.IsNullOrEmpty(this.Condition))
                    {
                        ret.AppendLine(String.Format("if not ({0})", this.Condition));
                        ret.AppendLine(Indentation.Indent(String.Format("{0}.Visible = false", this.ControlName), 1));
                        ret.AppendLine("endif");
                    }
                }
                return ret.ToString();
            }
        }

        public string ControlName
        {
            get
            {
                return BuildName("p{0}{1}");
            }
        }

        public string EventName
        {
            get
            {
                return BuildName("e{0}{1}");
            }
        }

        private string BuildName(string texto)
        {
            int contador = 1;
            string nome = String.Empty;
            if (this.Parent is AttributeElement)
            {
                AttributeElement att = (AttributeElement)this.Parent;
                contador = att.Links.IndexOf(this) + 1;
                if (contador < 1) contador = 1;
                nome = att.AttributeName.Replace("&", "");
            }
            if (this.Parent is VariableElement)
            {
                VariableElement att = (VariableElement)this.Parent;
                contador = att.Links.IndexOf(this) + 1;
                if (contador < 1) contador = 1;
                nome = att.Name.Replace("&", "");
            }
            if (this.Parent is FilterAttributeElement)
            {
                FilterAttributeElement att = (FilterAttributeElement)this.Parent;
                contador = att.Links.IndexOf(this) + 1;
                if (contador < 1) contador = 1;
                nome = att.Name.Replace("&", "");
            }
            return String.Format(texto, nome, contador.ToString().Trim());
        }

        public string Webpanel
        {
            get
            {
                return this.WebpanelObjectName;
            }
            set
            {
                // UIServices.KB.CurrentModel
                KBModel model = null;
                try
                {
                    if (Instance != null)
                    {
                        if (Instance.Model != null)
                        {
                            model = Instance.Model;
                        }
                        else
                        {
                            model = UIServices.KB.CurrentModel;
                        }
                    }
                    else
                    {
                        model = UIServices.KB.CurrentModel;
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message + " " + e.StackTrace);
                    if (model == null) {
                        try
                        {
                            model = UIServices.KB.CurrentModel;
                        } catch (Exception e2)
                        {
                            System.Diagnostics.Debug.WriteLine(e2.Message + " " + e2.StackTrace);
                        }
                    }

                }
                if (model != null) {
                    this.WebpanelObject = WebPanel.Get(model, value);
                }
            }

        }
	}
}
