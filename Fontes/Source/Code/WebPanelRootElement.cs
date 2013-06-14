using System;
using System.Collections.Generic;
using System.Text;
using Heurys.Patterns.HPattern;
using Heurys.Patterns.HPattern.Helpers;
using Artech.Common.Collections;

namespace Heurys.Patterns.HPattern
{
    public partial class WebPanelRootElement : Code.WebObject
    {

        public String ObjectName { 
            get 
            {
                return (this.Instance != null && this.Instance.ParentObject !=null ? this.Instance.ParentObject.Name :  "");
            } 
            set 
            {

            } 
        }

        public bool WebBC { get { return false; } }

        public IBaseCollection<RowElement> GetRows(string tabBC)
        {
            return Template.GetRows(this, tabBC);
        }

        public string GeraParm(bool bc)
        {
            return this.Parameters.GeraParm(bc);
        }

    }
}
