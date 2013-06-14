using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Artech.Packages.Patterns;
using Artech.Genexus.Common.Helpers;
using Artech.Genexus.Common;
using Artech.Genexus.Common.CustomTypes;
using Artech.Genexus.Common.Objects;
using System.Security;
using Artech.Common.Diagnostics;
using Heurys.Patterns.HPattern;
using Artech.Genexus.Common.Parts;
using Heurys.Patterns.HPattern.Resources;
using Artech.Architecture.Common.Services;
using Artech.Genexus.Common.Wiki;
using Artech.Common.Helpers.Strings;
using Artech.Common.Collections;
using Heurys.Patterns.HPattern.Helpers;
using Heurys.Patterns.HPattern.Code;

namespace Heurys.Patterns.HPattern
{
    public partial class FormElement : Code.ITabsObject
    {
        public Artech.Common.Collections.BaseCollection<ITabObject> ListTabs
        {
            get
            {
                Artech.Common.Collections.BaseCollection<ITabObject> lista = new Artech.Common.Collections.BaseCollection<ITabObject>();
                foreach (TabFormElement tab in Tabs)
                    lista.Add(tab);
                return lista;

            }
        }

        public ParametersElement Parameters 
        { 
            get 
            {
                if (this.Parent is Code.WebObject)
                {
                    return ((Code.WebObject)this.Parent).Parameters;
                }
                return null;
            } 
        }

        public bool HasConditionalTabs()
        {
            foreach (TabFormElement tab in Tabs)
                if (tab.IsConditional())
                    return true;

            return false;
        }

        public IBaseCollection<IHPatternInstanceElement> Fields(string tabBC)
        {
            BaseCollection<IHPatternInstanceElement> ret = new BaseCollection<IHPatternInstanceElement>();
            foreach (IHPatternInstanceElement i in this.Items)
            {
                if (i is RowElement)
                {
                    RowElement row = (RowElement)i;
                    ApplyFieldsRow(ret, row);
                }
                if (i is TabFormElement)
                {
                    TabFormElement tab = (TabFormElement)i;
                    if (tabBC == String.Empty || tab.Name == tabBC)
                    {
                        foreach (RowElement row in tab.Rows)
                        {
                            ApplyFieldsRow(ret, row);
                        }
                    }

                }
            }
            return ret;
        }

        private void ApplyFieldsRow(IBaseCollection<IHPatternInstanceElement> ret, RowElement row)
        {
            foreach (ColumnElement col in row.Columns)
            {
                foreach (IHPatternInstanceElement i in col.Items)
                {
                    if (i is AttributeElement || i is VariableElement || i is TextElement)
                    {
                        ret.Add(i);
                    }
                    else
                    {
                        if (i is GroupElement)
                        {
                            GroupElement grp = (GroupElement)i;
                            foreach (RowElement row2 in grp.Rows)
                            {
                                ApplyFieldsRow(ret, row2);
                            }
                        }
                    }
                    
                }
            }
        }
    }
}
