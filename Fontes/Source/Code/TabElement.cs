using System;
using Gx = Artech.Genexus.Common.Objects;
using System.Text;
using Artech.Genexus.Common.Helpers;

namespace Heurys.Patterns.HPattern
{
    public partial class TabElement : Code.ITabObject
	{


        public static class ObjTypeValue
        {
            public const string All = "All";
            public const string Grid = "grid";
            public const string Trn = "trn";
        }

        private string m_objtype = ObjTypeValue.All;

        public string ObjType
        {
            get
            {
                return m_objtype;
            }
            set
            {
                m_objtype = value;
            }
        }

        public string TrnPopup(string mode)
        {
            
            if (Transaction != null)
            {
                StringBuilder sb = new StringBuilder(100);
                for (int i = 0;i<Transaction.Parameters.Count;i++)
                {
                    ParameterElement par = Transaction.Parameters[i];
                    if (par.Name.ToLower() == "&mode")
                    {
                        sb.Append(mode);
                    }
                    else
                    {
                        if (mode.IndexOf("insert", StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            if (Instance.Transaction.Parameters.Find(delegate(ParameterElement par2) { return par2.Name == par.Name; }) == null)
                            {
                                sb.Append(String.Format("nullvalue({0})",Variables.VariableName(par.Name)));
                            }
                            else
                            {
                                sb.Append(Variables.VariableName(par.Name));
                            }
                        }
                        else
                        {
                            sb.Append(Variables.VariableName(par.Name));
                        }
                    }
                    if (i < Transaction.Parameters.Count - 1)
                        sb.Append(",");
                }
                return String.Format("{0}.Popup({1})", ObjNameTrn, sb.ToString());                

            }
            return String.Empty;
        }

		public bool IsConditional()
		{            
			return (Condition != null && Condition != String.Empty);
		}

        public string ObjNameTrn
        {
            get
            {
                string nome = String.IsNullOrEmpty(ObjName) ? ObjectName : ObjName;
                return String.Format("{0}Trn", nome);
            }
        }

        public bool ListNotNull
        {
            get
            {
                if (ListNotNullTabGrid == ListNotNullTabGridValue.Default) {
                    return Instance.Settings.Template.ListNotNullTabGrid;
                } 
                else 
                {
                    return (ListNotNullTabGrid == ListNotNullTabGridValue.True ? true : false);
                }
            }
        }

        public string ListNotNMessage
        {
            get
            {
                if (ListNotNullMessage == ListNotNullMessageValue.Default)
                {
                    return String.Format(Instance.Settings.Template.ListNotNullMessage,Description);
                }
                else
                {
                    return String.Format(ListNotNullMessage, Description);
                }
            }
        }


		public Gx.Transaction TabTransaction
		{
			get
			{
				// If the tab has a transaction, use it. Otherwise use the instance one.
				if (this.Transaction != null && this.Transaction.Transaction != null)
					return this.Transaction.Transaction;
                if (Instance.ParentObject is Gx.Transaction)
                    return (Gx.Transaction)Instance.ParentObject;
                else
                {
                    return null;
                }
			}
		}
	}
}
