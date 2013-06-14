using System;

namespace Heurys.Patterns.HPattern
{
	public interface IHPatternComponent : IHPatternInstanceElement,IParameters
	{
        string ObjectName { get; set; }
		string Description { get; }
		ComponentType ComponentType { get; }
        TransactionElement TrnElement { get; }
	}

	public enum ComponentType
	{
		Grid,
		Tabular,
		Unknown
	}

	public partial class SelectionElement : IHPatternComponent
	{

		public string ObjectName
		{
            get { return (String.IsNullOrEmpty(m_ObjName) ? Instance.Settings.Objects.SelectionName(this) : m_ObjName); }
            set { m_ObjName = value; }
		}

        public string GetObjectName()
        {
            return m_ObjName;
        }

        public TransactionElement TrnElement
        {
            get { return this.Instance.Transaction; }
        }

		ComponentType IHPatternComponent.ComponentType
		{
			get { return ComponentType.Grid; }
		}
	}

    public partial class PromptElement : IHPatternComponent
    {

        public string ObjectName
        {
            get { return (String.IsNullOrEmpty(m_ObjName) ? Instance.Settings.Objects.PromptName(this) : m_ObjName); }
            set { m_ObjName = value; }
        }

        public string GetObjectName()
        {
            return m_ObjName;
        }

        ComponentType IHPatternComponent.ComponentType
        {
            get { return ComponentType.Grid; }
        }

        public TransactionElement TrnElement
        {
            get { return this.Instance.Transaction; }
        }

    }

	public partial class ViewElement : IHPatternComponent
	{
		ComponentType IHPatternComponent.ComponentType
		{
			get { return ComponentType.Unknown; }
		}

        public string GetObjectName()
        {
            return m_ObjName;
        }

        public TransactionElement TrnElement
        {
            get { return this.Instance.Transaction; }
        }
	}

	public partial class TabElement : IHPatternComponent
	{
		public string ObjectName
		{
            get { return (String.IsNullOrEmpty(m_ObjName) ? Instance.Settings.Objects.TabName(this) : m_ObjName); }
            set { m_ObjName = value; }
		}

        public string GetObjectName()
        {
            return m_ObjName;
        }

		ComponentType IHPatternComponent.ComponentType
		{
			get
			{
				if (Type == TabElement.TypeValue.Grid)
					return ComponentType.Grid;

				if (Type == TabElement.TypeValue.Tabular)
					return ComponentType.Tabular;

				return ComponentType.Unknown;
			}
		}

        public TransactionElement TrnElement
        {
            get { return this.Transaction == null ? this.Instance.Transaction : this.Transaction; }
            //get { return this.Instance.Transaction; }
        }
	}
}
