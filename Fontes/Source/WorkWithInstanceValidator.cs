using System;
using Artech.Common.Diagnostics;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Objects;
using Heurys.Patterns.HPattern.Resources;
using System.Diagnostics;
using Artech.Genexus.Common.Objects;
using Artech.Genexus.Common;
using Heurys.Patterns.HPattern.Custom;
using Artech.Genexus.Common.Services;
using Artech.Common.Properties;

namespace Heurys.Patterns.HPattern
{
    internal class HPatternInstanceValidator : PatternInstanceValidator
	{
		public override bool Validate(PatternInstance instance, OutputMessages output)
		{
			bool hasErrors = false;
			foreach (PatternInstanceElement actionElement in instance.PatternPart.SelectElements("//actions/action"))
			{
				PatternInstanceElement container = actionElement.Parent.Parent;
                Debug.Assert(container != null && (container.Type == InstanceElements.Transaction || container.Type == InstanceElements.Selection || container.Type == InstanceElements.Tab || container.Type == InstanceElements.WebPanelRoot || container.Type == InstanceElements.Prompt));

				if (container != null)
				{
					bool cannotHaveInGrid = (container.Type == InstanceElements.Tab && container.Attributes.GetPropertyValue<string>(InstanceAttributes.Tab.Type) == TabElement.TypeValue.Tabular);
					bool isInGrid = actionElement.Attributes.GetPropertyValue<bool>(InstanceAttributes.Action.InGrid);

					if (isInGrid && cannotHaveInGrid)
					{
						output.Add(new OutputError(Messages.FormatValidationErrorActionCannotBeInGrid(actionElement.ToString()), new PatternElementPosition(actionElement)));
						hasErrors = true;
					}
				}
			}
            if (!hasErrors)
            {
                if (instance.Parent is Transaction)
                {
                    if (instance.PatternPart.SelectSingleElement("instance/transaction") == null)
                    {
                        output.Add(new OutputError("Não é permitido excluir o nó Transaction"));
                        hasErrors = true;
                    } else if (instance.PatternPart.SelectSingleElement("instance/webPanelRoot") != null)
                    {
                        output.Add(new OutputError("Não é permitido o nó WebPanel na Transação"));
                        hasErrors = true;
                    }
                }
            }
            if (!hasErrors)
            {
                if (instance.Parent is WebPanel)
                {
                    if (instance.PatternPart.SelectSingleElement("instance/webPanelRoot") == null)
                    {
                        output.Add(new OutputError("Não é permitido excluir o nó WebPanel"));
                        hasErrors = true;
                    }
                    else if (instance.PatternPart.SelectSingleElement("instance/transaction") != null)
                    {
                        output.Add(new OutputError("Não é permitido o nó Transaction no WebPanel"));
                        hasErrors = true;
                    }
                }
            }

            if (!hasErrors)
            {
                foreach (PatternInstanceElement tabElement in instance.PatternPart.SelectElements("tab"))
                {
                    string nome = tabElement.Attributes.GetPropertyValueString(InstanceAttributes.TabForm.Name);
                    string desc = tabElement.Attributes.GetPropertyValueString(InstanceAttributes.TabForm.Description);
                    if (!Variable.IsValidName(nome))
                    {
                        output.Add(new OutputError(String.Format("Caracter inválido no nome da Aba: '{0}', Descrição: {1} ",nome,desc)));
                        hasErrors = true;
                    }
                }
            }

            if (!hasErrors)
            {
                foreach (PatternInstanceElement gridprop in instance.PatternPart.SelectElements("//GridPropertie"))
                {
                    String nome = gridprop.Attributes.GetPropertyValueString(InstanceAttributes.GridPropertie.Name);
                    String valor = gridprop.Attributes.GetPropertyValueString(InstanceAttributes.GridPropertie.Valor);

                    String nomeControl = Controls.getCustomRender(gridprop);
                    ControlDefinition control = Controls.getControl(nomeControl);

                    if (control == null)
                    {
                        output.Add(new OutputError("Invalid CustomRender: ", new PatternElementPosition(gridprop)));
                        hasErrors = true;
                    }
                    else
                    {

                        PropDefinition p = control.GetPropertiesDefinition().GetPropDefinition(nome);
                        if (p != null)
                        {
                            try
                            {
                                p.PropertyConverter.ConvertFrom(valor);
                            }
                            catch (Exception e)
                            {
                                output.Add(new OutputError("Property: " + nome + " - " + e.Message, new PatternElementPosition(gridprop)));
                                hasErrors = true;
                            }
                        }
                    }
                }
            }

            if (!hasErrors)
            {

                foreach (PatternInstanceElement gridprop in instance.PatternPart.SelectElements("//GridColumnPropertie"))
                {
                    String nome = gridprop.Attributes.GetPropertyValueString(InstanceAttributes.GridColumnPropertie.Name);
                    String valor = gridprop.Attributes.GetPropertyValueString(InstanceAttributes.GridColumnPropertie.Valor);

                    String nomeControl = Controls.getCustomRender(gridprop);
                    ControlDefinition control = Controls.getControl(nomeControl);

                    if (control == null)
                    {

                        output.Add(new OutputError("Invalid CustomRender: ", new PatternElementPosition(gridprop)));
                        hasErrors = true;
                    } 
                    else 
                    {

                        PropDefinition p = control.GetColumnPropertiesDefinition().GetPropDefinition(nome);
                        if (p != null)
                        {
                            try
                            {
                                p.PropertyConverter.ConvertFrom(valor);
                            }
                            catch (Exception e)
                            {
                                output.Add(new OutputError("Column Property: " + nome + " - " + e.Message, new PatternElementPosition(gridprop)));
                                hasErrors = true;
                            }
                        }
                    }
                }
            }

            // TODO não permtir textblock no form com o nome internalname duplicado

			return !hasErrors;
		}
	}
}
