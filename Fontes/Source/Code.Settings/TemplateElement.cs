using System;
using System.Collections.Generic;
using System.Text;

namespace Heurys.Patterns.HPattern
{
    public partial class SettingsTemplateElement : IHPatternSettingsElement
    {
        public bool TemPrompt
        {
            get
            {
                if (String.IsNullOrEmpty(PromptImageName))
                {
                    return !String.IsNullOrEmpty(Helpers.Template.ImageDefault(this.Settings.Model));
                }
                else
                {

                    return true;
                }
            }
        }

    }
}
