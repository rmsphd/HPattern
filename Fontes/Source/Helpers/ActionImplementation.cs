using System;

namespace Heurys.Patterns.HPattern.Helpers
{
    
    [System.Reflection.ObfuscationAttribute(Feature = "renaming", ApplyToMembers = true)]
	internal static class ActionImplementationFactory
	{
		public static IActionImplementation GetActionImplementation(ActionElement action)
		{
			if (action.MultiRowSelection)
				return new StandaloneMultiRowAction(action);

			if (action.InGrid)
			{
				if (action.Image != null)
					return new GridImageAction(action);
				else
					return new GridTextAction(action);
			}
			else
			{
				if (action.Image != null)
					return new StandaloneImageAction(action);
				else
					return new StandaloneButtonAction(action);
			}
		}
	}

    [System.Reflection.ObfuscationAttribute(Feature = "renaming", ApplyToMembers = true)]
    internal interface IActionImplementation
	{
        // Controle
        bool isSubAction { get; }
        bool isMenuContext { get; }


		// WebForm
		string ControlName();
		string ToHtml();
        string ClassName();

		// Events
		string InitializationCode();

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        string EnableDisableCode();

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        string EnableCode();

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
		string DisableCode();

		string Event();

		// Variables
		string DefineVariable();
	}
}
