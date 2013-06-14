using System;
using System.Collections.Generic;
using System.Text;

namespace Heurys.Patterns.HPattern
{
    public partial class ColumnElement
    {

        public string GetAlign()
        {
            if (Align == AlignValue.Default)
            {
                if (Items.Count > 0) {
                    if (Items[0] is TextElement)
                    {
                        return Instance.Settings.Template.CollumnTextAlign.ToLower();
                    }
                    else
                    {
                        return Instance.Settings.Template.CollumnAttributeAlign.ToLower();
                    }
                }
                else
                {
                    return Instance.Settings.Template.CollumnTextAlign.ToLower();
                }
            }
            else
            {
                return Align.ToLower();
            }
        }
    }
}
