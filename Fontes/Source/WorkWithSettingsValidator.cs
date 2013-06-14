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
    internal class WorkWithSettingsValidator : PatternSettingsValidator
	{
        public override bool Validate(PatternSettings settings, OutputMessages output)
		{
			bool hasErrors = false;
            PatternInstanceElement grid = settings.PatternPart.SelectSingleElement("//Grid");
            String customrender = grid.Attributes.GetPropertyValueString(SettingsAttributes.Grid.CustomRender);

            ControlDefinition control = null;

            if (!String.IsNullOrEmpty(customrender))
            {
                control = Controls.getControl(customrender);
            }

            foreach (PatternInstanceElement gridprop in settings.PatternPart.SelectElements("//GridPropertie"))
            {
                if (control == null)
                {
                    output.Add(new OutputError("Invalid CustomRender: ", new PatternElementPosition(gridprop)));
                    hasErrors = true;
                }
                else
                {

                    String nome = gridprop.Attributes.GetPropertyValueString(SettingsAttributes.GridPropertie.Name);
                    String valor = gridprop.Attributes.GetPropertyValueString(SettingsAttributes.GridPropertie.Valor);

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

            if (!hasErrors)
            {
                PatternInstanceElement saction = settings.PatternPart.SelectSingleElement("//StandardActions");
                Object oLegendObject = saction.Attributes.GetPropertyValue(SettingsAttributes.StandardActions.LegendObject);

                PatternInstanceElement actLegend = settings.PatternPart.SelectSingleElement("//StandardActions/Legend");
                Boolean oLegendEnabled = actLegend.Attributes.GetPropertyValue<Boolean>(SettingsAttributes.Action.DefaultMode);
                Boolean oLegendEnabledPrompt = actLegend.Attributes.GetPropertyValue<Boolean>(SettingsAttributes.Action.PromptMode);

                if ((oLegendEnabled || oLegendEnabledPrompt) && oLegendObject == null)
                {
                    output.Add(new OutputError("Legend Object Not Defined: ", new PatternElementPosition(saction)));
                    hasErrors = true;
                }
                
            }

            if (!hasErrors)
            {
                PatternInstanceElement template = settings.PatternPart.SelectSingleElement("//Template");
                String tabfunction = template.Attributes.GetPropertyValueString(SettingsAttributes.Template.TabFunction);
                tabfunction = Controls.getTabUserControl(tabfunction);

                ControlDefinition controltab = null;

                if (!String.IsNullOrEmpty(tabfunction))
                {
                    controltab = Controls.getControl(tabfunction, null);
                }

                foreach (PatternInstanceElement tabprop in settings.PatternPart.SelectElements("//TabProperty"))
                {
                    if (controltab == null)
                    {
                        output.Add(new OutputError("Invalid UserControl Property: ", new PatternElementPosition(tabprop)));
                        hasErrors = true;
                    }
                    else
                    {

                        String nome = tabprop.Attributes.GetPropertyValueString(SettingsAttributes.TabProperty.Name);
                        String valor = tabprop.Attributes.GetPropertyValueString(SettingsAttributes.TabProperty.Valor);

                        PropDefinition p = controltab.GetPropertiesDefinition().GetPropDefinition(nome);
                        if (p != null)
                        {
                            try
                            {
                                p.PropertyConverter.ConvertFrom(valor);
                            }
                            catch (Exception e)
                            {
                                output.Add(new OutputError("Property: " + nome + " - " + e.Message, new PatternElementPosition(tabprop)));
                                hasErrors = true;
                            }
                        }
                    }
                }
                

            }

			return !hasErrors;
		}
	}
}
