using System;
using System.Text;
using System.Collections.Generic;
using Artech.Genexus.Common.Helpers;
using Artech.Genexus.Common;

namespace Heurys.Patterns.HPattern
{
	public partial class SettingsContextElement
	{
		public string DefineVariables()
		{
            return DefineVariables(null);
		}

        public string DefineVariables(List<string> lista)
        {
            if (lista == null) lista = new List<string>();
            StringBuilder sb = new StringBuilder();
            sb.Append(Variables.Basic("ErrorValidation", "Erro de Validação", eDBType.Boolean));
            sb.Append(Environment.NewLine);

            foreach (SettingsContextVariableElement contextVar in this)
            {
                if (!lista.Contains(contextVar.Name.Replace("&","")))
                {
                    sb.Append(contextVar.DefineVariable());
                    sb.Append(Environment.NewLine);                    
                }
            }

            return sb.ToString();
        }

	}
}
