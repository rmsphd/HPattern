using System;
using System.Collections.Generic;
using System.Text;

namespace Heurys.Patterns.HPattern
{
    public partial class SettingsGridElement
    {
        public bool PagingButtons(IGridObject obj)
        {
            return (obj.GridType == GridTypeValue.Gxui ? true : DefaultPagingButtons);
        }

        public bool GetEnableDisablePaging(IGridObject obj)
        {        
            if (obj.GridType == GridTypeValue.Gxui)
                return false;
            if (DefaultPagingButtons)
                return false;            
            return EnableDisablePaging;
        }

        public bool GetMaxPage(IGridObject obj)
        {
            if (obj.GridType == GridTypeValue.Gxui)
                return false;
            if (DefaultPagingButtons)
                return false;  
            return MaxPage;
        }


    }
}
