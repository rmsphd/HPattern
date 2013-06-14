using System;
using System.Collections.Generic;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Objects;

namespace Heurys.Patterns.HPattern.Editor
{
	internal class WorkWithEditorHelper : PatternEditorHelper
	{
		private static readonly string[] ALL_MODES = new string[] { InstanceAttributes.Modes.Insert, InstanceAttributes.Modes.Update, InstanceAttributes.Modes.Delete, InstanceAttributes.Modes.Display, InstanceAttributes.Modes.Export,InstanceAttributes.Modes.Legend };

		public override bool CustomShowElement(PatternInstanceElement element, ref string caption, ref System.Drawing.Icon icon)
		{
			if (element.Type == InstanceElements.Modes)
			{
				List<string> modes = new List<string>();
                SettingsStandardActionsElement ssa = HPatternSettings.Get(element.Instance.Model).StandardActions;
				foreach (string mode in ALL_MODES)
				{
					if (element.Attributes.GetPropertyValue<string>(mode) == ModesElement.InsertValue.True ||
						(element.Attributes.GetPropertyValue<string>(mode) == ModesElement.InsertValue.Default &&
                        ((ssa.FindAction(mode).DefaultMode && element.Parent.Type != InstanceElements.Prompt) || 
                        (ssa.FindAction(mode).PromptMode && element.Parent.Type == InstanceElements.Prompt))))
					{
						modes.Add(mode);
					}
				}

				caption = String.Format("modes ({0})", String.Join(", ", modes.ToArray()));
				return true;
			}

            return base.CustomShowElement(element, ref caption, ref icon);
		}

		public override IEnumerable<IPatternEditorCommand> GetCommands(PatternInstanceElement onElement)
		{
            if (onElement.Type == InstanceElements.FilterAttributes)
				yield return new CommandAddFilterVariable(onElement);
            if (onElement.Type == InstanceElements.Tabs)
                yield return new CommandAddTab(onElement);
        }

        public override void InitializeElement(PatternInstanceElement element)
        {
            if (element.Type == InstanceElements.WebPanelRoot || element.Type == InstanceElements.Transaction)
            {
                throw new HPatternException("Operação não permitida");
            }
            else 
            {
                if (element.Type == InstanceElements.Text || element.Type == InstanceElements.TabForm || element.Type == InstanceElements.UserTable )
                {
                    element.Attributes[InstanceAttributes.Text.Name] = GeraNomeUnico(element);
                }

                base.InitializeElement(element); 
            }            
        }

        internal String GeraNomeUnico(PatternInstanceElement element)
        {
            String ret = "";
            List<String> nomes = new List<string>();
            foreach (PatternInstanceElement el in element.InstancePart.SelectElements("//" + element.Name))
            {
                nomes.Add((String)el.Attributes[InstanceAttributes.Text.Name]);
            }
            ret = element.Name;
            int max = 0;
            int at = 0;
            foreach (String el in nomes)
            {
                try
                {
                    at = int.Parse(el.Replace(element.Name, ""));
                }
                catch (Exception e)
                {
                    at = 0;
                }
                if (at > max)
                    max = at;
            }
            max++;
            ret += max.ToString().Trim();
            return ret;
        }
	}
}
