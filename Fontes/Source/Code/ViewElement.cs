using System;
using Heurys.Patterns.HPattern;
using Heurys.Patterns.HPattern.Code;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common.Objects;

namespace Heurys.Patterns.HPattern
{
    public partial class ViewElement : Code.ITabsObject
	{

    	public string ObjectName
		{
            get { return (String.IsNullOrEmpty(m_ObjName) ? Instance.Settings.Objects.ViewName(this) : m_ObjName); }
            set { m_ObjName = value; }
		}

        public bool HasListNotNull()
        {
            foreach (TabElement tab in Tabs)
                if (tab.ListNotNull)
                    return true;

            return false;
        }

        private KBObject m_Gxobject = null;
        private KBObjectReference m_GxobjectReference = null;

        public KBObject Gxobject
        {
            get
            {
                if (m_Gxobject == null)
                {
                    m_Gxobject = WebPanel.Get(Instance.Model, ObjectName);
                }
                if (m_Gxobject != null && m_GxobjectReference == null)
                {
                    m_GxobjectReference = new KBObjectReference(m_Gxobject);
                }
                if (m_Gxobject == null && m_GxobjectReference != null)
                    m_Gxobject = (Artech.Architecture.Common.Objects.KBObject)m_GxobjectReference.GetKBObject(Instance.Model);

                return m_Gxobject;
            }
        }

		public bool HasConditionalTabs()
		{
			foreach (TabElement tab in Tabs)
				if (tab.IsConditional())
					return true;

			return false;
		}

        public Artech.Common.Collections.BaseCollection<ITabObject> ListTabs
        {
            get
            {
                Artech.Common.Collections.BaseCollection<ITabObject> lista = new Artech.Common.Collections.BaseCollection<ITabObject>();
                foreach (TabElement tab in Tabs)
                    lista.Add(tab);
                return lista;

            }
        }

        public bool DisabledTabs
        {
            get {
                if (this.DisabledTabsIfEditing == ViewElement.DisabledTabsIfEditingValue.Default)
                {
                    return Instance.Settings.Template.DisabledTabsIfEditing;
                }
                else
                {
                    return (this.DisabledTabsIfEditing == ViewElement.DisabledTabsIfEditingValue.True ? true : false);
                }
            }
        }
	}
}
