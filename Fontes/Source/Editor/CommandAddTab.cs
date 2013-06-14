using System;
using System.Collections.Generic;
//using Artech.Common.Controls.Basic;
using Microsoft.SqlServer.MessageBox;
using Artech.Common.Framework.Commands;
using Artech.Architecture.UI.Framework.Services;
using Artech.Architecture.Common.Descriptors;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common;
using Artech.Genexus.Common.Parts;
using Artech.Genexus.Common.Services;
using Gx = Artech.Genexus.Common.Objects;
using Artech.Genexus.UI.Common.ObjectBuilders;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Objects;
using Heurys.Patterns.HPattern.Resources;
using System.Windows.Forms;

namespace Heurys.Patterns.HPattern.Editor
{
	internal class CommandAddTab : PatternEditorCommand
	{
        public CommandAddTab(PatternInstanceElement onElement)
			: base(onElement) { }

		#region Properties

		public override string Text
		{
			get { return "Add Tabs"; }
		}

		#endregion

		public override void Exec(CommandData cmdData)
		{
            SelectObjectOptions dialogInfo = new SelectObjectOptions();
            dialogInfo.ObjectTypes.Add(KBObjectDescriptor.Get<Gx.WebPanel>());
            dialogInfo.ObjectTypes.Add(KBObjectDescriptor.Get<Gx.Transaction>());
			dialogInfo.MultipleSelection = true;

            IList<KBObject> selectedObjects = UIServices.SelectObjectDialog.SelectObjects(dialogInfo);
			if (selectedObjects != null && selectedObjects.Count != 0)
			{
                foreach (KBObject selectedObj in selectedObjects)
				{
                    
					PatternInstanceElement tabAttElement = BaseElement.Children.AddNewElement(InstanceChildren.Tabs.Tab);
                    tabAttElement.Attributes[InstanceAttributes.Tab.Name] = selectedObj.Name;
                    tabAttElement.Attributes[InstanceAttributes.Tab.Code] = selectedObj.Name;
                    tabAttElement.Attributes[InstanceAttributes.Tab.Description] = selectedObj.Description;
                    
                    String tipo = TabElement.TypeValue.UserDefined;

                    if (selectedObj is Gx.Transaction)
                    {
                        string[] btns = { "UserDefined", "Tabular", "Grid"};
                        int i = StandardMessageBox.Show("Qual tipo de aba ?", "Adicionar Aba", btns, ExceptionMessageBoxSymbol.Question, 0, ExceptionMessageBoxOptions.None);
                        switch (i)
                        {
                            case 1:
                                tipo = TabElement.TypeValue.Tabular;
                                break;
                            case 2:
                                tipo = TabElement.TypeValue.Grid;
                                break;
                        }
                    }
                    tabAttElement.Attributes[InstanceAttributes.Tab.Type] = tipo;                    
                    switch (tipo)
                    {
                        case TabElement.TypeValue.UserDefined:
                            tabAttElement.Attributes[InstanceAttributes.Tab.Wcname] = selectedObj.Name;
                            break;
                        
                        case TabElement.TypeValue.Tabular:
                            tabAttElement.Attributes[InstanceAttributes.Tab.Wcname] = BaseElement.Instance.Parent.Name+selectedObj.Name;
                            if (selectedObj is Gx.Transaction)
                            {
                                Gx.Transaction gxt = (Gx.Transaction)selectedObj;

                                AddTrn(tabAttElement, gxt);
                                
                                PatternInstanceElement actsElement = tabAttElement.Children.AddNewElement(InstanceChildren.Tab.Actions);
                                actsElement.Children.AddNewElement(InstanceChildren.Actions.Action).Attributes[InstanceAttributes.Action.Name] = Helpers.StandardAction.Update;
                                actsElement.Children.AddNewElement(InstanceChildren.Actions.Action).Attributes[InstanceAttributes.Action.Name] = Helpers.StandardAction.Delete;
                            }
                            break;

                        case TabElement.TypeValue.Grid:
                            tabAttElement.Attributes[InstanceAttributes.Tab.Wcname] = BaseElement.Instance.Parent.Name+selectedObj.Name + "WC";
                            if (selectedObj is Gx.Transaction)
                            {
                                Gx.Transaction gxt = (Gx.Transaction)selectedObj;

                                AddTrn(tabAttElement, gxt);

                                PatternInstanceElement modesElement = tabAttElement.Children.AddNewElement(InstanceChildren.Tab.Modes);
                                HPatternSettings sett = HPatternSettings.Get(BaseElement.Instance.Model);
                                modesElement.Attributes[InstanceAttributes.Modes.InsertCondition] = sett.StandardActions.Insert.Condition;
                                modesElement.Attributes[InstanceAttributes.Modes.UpdateCondition] = sett.StandardActions.Update.Condition;
                                modesElement.Attributes[InstanceAttributes.Modes.DeleteCondition] = sett.StandardActions.Delete.Condition;
                                modesElement.Attributes[InstanceAttributes.Modes.DisplayCondition] = sett.StandardActions.Display.Condition;
                                modesElement.Attributes[InstanceAttributes.Modes.ExportCondition] = sett.StandardActions.Export.Condition;

                            }
                            break;

                    }

				}

    		}
		}

        internal void AddTrn(PatternInstanceElement tabAttElement,Gx.Transaction gxt)
        {
            PatternInstanceElement tabElement = tabAttElement.Children.AddNewElement(InstanceChildren.Tab.Transaction);
            tabElement.Attributes[InstanceAttributes.Transaction._Transaction] = gxt;

            PatternInstanceElement parmsElement = tabElement.Children.AddNewElement(InstanceChildren.Transaction.Parameters);
            parmsElement.Children.AddNewElement(InstanceChildren.Parameters.Parameter).Attributes[InstanceAttributes.Parameter.Name] = "&Mode";
            foreach (TransactionAttribute ta in gxt.Structure.Root.PrimaryKey)
            {
                parmsElement.Children.AddNewElement(InstanceChildren.Parameters.Parameter).Attributes[InstanceAttributes.Parameter.Name] = ta.Name;
            }

            //TODO falta preencher o Form da Transaction, vamos fazer depois do item #20 - Novo elemento TransactionAtribute

            PatternInstanceElement tabAttsElement = tabAttElement.Children.AddNewElement(InstanceChildren.Tab.Attributes);
            foreach (TransactionAttribute ta in gxt.Structure.Root.Attributes)
            {
                PatternInstanceElement taElement = tabAttsElement.Children.AddNewElement(InstanceChildren.Attributes.Attribute);
                taElement.Attributes[InstanceAttributes.Attribute._Attribute] = ta.Attribute;
                taElement.Attributes[InstanceAttributes.Attribute.Description] = ta.Attribute.Description;
            }

        }

		private string CreateCondition(Gx.Attribute att,PatternInstanceElement element)
		{
			// TODO: Customize these options.
			return HPatternInstanceGenerator.CreateDefaultCondition(att,element);
		}
	}
}
