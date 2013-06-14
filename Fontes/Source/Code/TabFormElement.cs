using System;
using System.Collections.Generic;
using System.Text;

namespace Heurys.Patterns.HPattern
{
    public partial class TabFormElement : Code.ITabObject
    {

        private string m_ObjectName;

        public string ObjectName
        {
            get { return m_ObjectName; }
            set { m_ObjectName = value; }
        }

        public bool IsConditional()
        {
            return (Condition != null && Condition != String.Empty);
        }

        public String Code
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

    }
}
