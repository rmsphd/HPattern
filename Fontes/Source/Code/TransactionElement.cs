using System;
using System.Collections.Generic;
using System.Text;
using Heurys.Patterns.HPattern.Helpers;
using Artech.Common.Collections;

namespace Heurys.Patterns.HPattern
{
    public partial class TransactionElement : Code.WebObject
    {
        public bool GetSetFocus
        {
            get
            {
                switch (SetFocus)
                {
                    case SetFocusValue.True:
                        return true;
                    case SetFocusValue.False:
                        return false;
                    default:
                        return Instance.Settings.Template.TransactionSetFocus;
                }
            }
        }

        public bool WebBC
        {
            get
            {
                bool geraBC = false;
                HPatternSettings settings = this.Parent.Instance.Settings;                
                geraBC = settings.Template.DataEntryWebPanelBC;
		        if (Instance.Transaction.DataEntryWebPanelBC == TransactionElement.DataEntryWebPanelBCValue.True)
			        geraBC = true;
                if (Instance.Transaction.DataEntryWebPanelBC == TransactionElement.DataEntryWebPanelBCValue.False)
			        geraBC = false;
                return geraBC;
            }
        }

        public string ObjectName
        {
            get { return (this.Instance != null && this.Instance.ParentObject !=null ? this.Instance.ParentObject.Name :  m_ObjName); }
            set { m_ObjName = value; }
        }

        public string GeraChamada(bool bc, bool Att, bool Sellection, string Mode,string Prefix)
        {

            StringBuilder link = new StringBuilder();

            int contaParm = 0;
            bool temload = false;
            foreach (ParameterElement pare in this.Parameters)
            {
                if (contaParm == 1) link.Append(", ");
                contaParm = 1;
                string var = "&";
                if (!String.IsNullOrEmpty(Prefix)) var = Prefix;
                if (Att && Sellection && String.IsNullOrEmpty(pare.DomainName) && pare.IsAttribute) var = "";
                if (pare.Name.Contains("&")) var = "";
                if (pare.Name == "load" || pare.Name == "&load")
                {
                    temload = true;
                    if (bc)
                    {
                        var = "";
                        if (Att)
                        {
                            link.AppendFormat("{0}{1}", var, "true");
                        }
                        else
                        {
                            link.AppendFormat("{0}{1}", var, "false");
                        }
                    }
                    else
                    {
                        link.AppendFormat("{0}{1}", var, pare.Name);
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(Mode))
                    {
                        link.AppendFormat("{0}{1}", var, pare.Name);
                    }
                    else
                    {
                        if (pare.Name.ToLower() != "&mode" && pare.Name.ToLower() != "mode")
                        {
                            link.AppendFormat("{0}{1}", var, pare.Name);
                        }
                        else
                        {
                            link.Append(Mode);
                        }
                    }

                    
                }
            }
            if (bc && !temload)
            {
                if (bc)
                {
                    if (Att)
                    {
                        link.Append(", true");
                    }
                    else
                    {
                        link.Append(", false");
                    }
                }
                else
                {
                    link.Append(", &load");
                }
            }

            return link.ToString();
        }

        public string GeraChamada(bool bc, bool Att, bool Sellection)
        {
            return GeraChamada(bc, Att, Sellection, String.Empty,String.Empty);
        }

        public string GeraLink(string Objeto, bool bc, bool Att, bool Sellection, string Mode, string Prefix)
        {
            StringBuilder link = new StringBuilder();

            link.AppendFormat("{0}.Link(", Objeto);
            link.Append(GeraChamada(bc, Att, Sellection,Mode,Prefix));
            link.Append(")");

            return link.ToString();
        }

        public string GeraLink(string Objeto, bool bc, bool Att, bool Sellection)
        {
            return GeraLink(Objeto, bc, Att, Sellection, String.Empty, String.Empty);
        }

        public IBaseCollection<RowElement> GetRows(string tabBC)
        {
            return Template.GetRows(this,tabBC);
        }

        public IBaseCollection<RowElement> GetRows(string tabBC, bool GridFreeStyle, bool GridStandard)
        {
            return Template.GetRows(this, tabBC,GridFreeStyle,GridStandard);
        }

        public bool InScreen(string name,string tabBC)
        {
            IBaseCollection<RowElement> rows = Template.GetRows(this, tabBC);
            foreach (RowElement row in rows)
            {
                foreach (ColumnElement col in row.Columns)
                {
                    foreach (IHPatternInstanceElement item in col.Items)
                    {
                        if (item is AttributeElement)
                        {
                            AttributeElement att = item as AttributeElement;
                            if (att.AttributeName.ToLower() == name.ToLower())
                                return true;
                        }
                        if (item is VariableElement)
                        {
                            VariableElement att = item as VariableElement;
                            if (att.Name.ToLower() == name.ToLower())
                                return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool InstanceGrid
        {
            get
            {
                IBaseCollection<RowElement> rows = Template.GetRows(this,String.Empty);
                foreach (RowElement row in rows)
                {
                    foreach (ColumnElement col in row.Columns)
                    {
                        if (col.GridFreeStyles != null)
                        {
                            if (col.GridFreeStyles.Count > 0)
                            {
                                return true;
                            }
                        }
                        if (col.GridStandards != null)
                        {
                            if (col.GridStandards.Count > 0)
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }

        public string GeraParm(bool bc)
        {
            return this.Parameters.GeraParm(bc);
        }

    }
}
