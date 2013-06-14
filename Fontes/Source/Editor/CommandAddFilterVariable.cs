using System;
using System.Collections.Generic;
using Artech.Common.Framework.Commands;
using Artech.Architecture.UI.Framework.Services;
using Artech.Genexus.Common;
using Artech.Genexus.Common.Services;
using Gx = Artech.Genexus.Common.Objects;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Objects;
using Heurys.Patterns.HPattern.Resources;

namespace Heurys.Patterns.HPattern.Editor
{
	internal class CommandAddFilterVariable : PatternEditorCommand
	{
		public CommandAddFilterVariable(PatternInstanceElement onElement)
			: base(onElement) { }

		#region Properties

		public override string Text
		{
			get { return Messages.CmdAddFilterVariable; }
		}

		#endregion

		public override void Exec(CommandData cmdData)
		{
			AttributeVariableDialogInfo dialogInfo = new AttributeVariableDialogInfo();
			dialogInfo.Filter = TypedObjectKind.Attribute;
			dialogInfo.MultiSelection = true;

			IList<object> selectedObjects = GenexusUIServices.SelectAttributeVariable.SelectAttributeVariable(dialogInfo);
			if (selectedObjects != null && selectedObjects.Count != 0)
			{
				foreach (Gx.Attribute selectedAtt in selectedObjects)
				{
					PatternInstanceElement filterAttElement = BaseElement.Children.AddNewElement(InstanceChildren.FilterAttributes.FilterAttribute);
					filterAttElement.Attributes[InstanceAttributes.FilterAttribute.Name] = selectedAtt.Name;
					filterAttElement.Attributes[InstanceAttributes.FilterAttribute.Description] = selectedAtt.Title;
                    //filterAttElement.Attributes[InstanceAttributes.FilterAttribute.Attribute] = selectedAtt;
					if (selectedAtt.GetPropertyValue<int>(Properties.ATT.ControlType) == Properties.ATT.ControlType_Values.ComboBox)
						filterAttElement.Attributes[InstanceAttributes.FilterAttribute.AllValue] = true;
				}

				if (StandardMessageBox.Confirm(Messages.ConfirmAddFilterCondition))
				{
					PatternInstanceElement conditionsElement = BaseElement.Parent.Children[InstanceChildren.Filter.Conditions];
					foreach (Gx.Attribute selectedAtt in selectedObjects)
					{
						PatternInstanceElement conditionElement = conditionsElement.Children.AddNewElement(InstanceChildren.Conditions.Condition);
                        string attCondition = CreateCondition(selectedAtt, BaseElement);
						conditionElement.Attributes[InstanceAttributes.Condition.Value] = attCondition;
					}
				}
			}
		}

		private string CreateCondition(Gx.Attribute att,PatternInstanceElement element)
		{
			// TODO: Customize these options.
			return HPatternInstanceGenerator.CreateDefaultCondition(att,element);
		}
	}
}
