using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using Artech.Architecture.Common.Services;
using Artech.Architecture.UI.Framework.Packages;
using Artech.Architecture.UI.Framework.Services;
using Artech.Common;
using Artech.Common.Collections;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common;
using Artech.Genexus.Common.CustomTypes;
using Artech.Genexus.Common.Objects;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Definition;
using Artech.Packages.Patterns.Engine;
using Artech.Packages.Patterns.Objects;
using Heurys.Patterns.HPattern.Resources;
using Artech.Genexus.Common.Wiki;
using Artech.Genexus.Common.Parts;
using Heurys.Patterns.HPattern.Helpers;


/*
> 11/01/2011 SM 387 
- Associar as categorias da transação nos objetos gerados pelo HPattern
 
 */
namespace Heurys.Patterns.HPattern
{

    

	internal class HPatternBuildProcess : PatternBuildProcess
	{

        

		#region Import Resources
                

        //public static VersionC GetLic()
        //{
        //    return VersionC.GetLic();
        //}
        
		public override void BeforeStartBuild(PatternInstance instance)
		{
            //modMain.SetGXPath(Artech.Common.Helpers.IO.PathHelper.StartupPath);
            //GetLic().CheckC();
            
            if (Messages.TestTime())
            {
                CommonServices.Output.AddLine(String.Format(">>> BeforeStartBuild Begin {0}", DateTime.Now.ToString()));
            }
            if (Messages.Debug())
            {
                CommonServices.Output.AddLine(String.Format(">>> BeforeStartBuild {0}", DateTime.Now.ToString()));
            }
            
            /*
            if (modActiveLockVb2005.InitActivelock())
            {
                CommonServices.Output.AddLine(">>> Activelock True");
            }
            else
            {
                CommonServices.Output.AddLine(">>> Activelock False");
            }
            */
            
            base.BeforeStartBuild(instance);
			HPatternSettings.ResetCache(instance.Model);
            if (Messages.TestTime())
            {
                CommonServices.Output.AddLine(String.Format(">>> BeforeStartBuild End {0}", DateTime.Now.ToString()));
            }
		}

        public override void AfterEndBuild(Artech.Packages.Patterns.Objects.PatternInstance instance)
        {
            if (Messages.TestTime())
            {
                CommonServices.Output.AddLine(String.Format(">>> AfterEndBuild Begin {0}", DateTime.Now.ToString()));
            }
            base.AfterEndBuild(instance);
            if (Messages.TestTime())
            {
                CommonServices.Output.AddLine(String.Format(">>> AfterEndBuild End {0}", DateTime.Now.ToString()));
            }
            if (Messages.Debug())
            {
                CommonServices.Output.AddLine(String.Format(">>> AfterEndBuild {0}", DateTime.Now.ToString()));
            }
        }

		public override void AfterImportResources(PatternInstance instance)
		{
			base.AfterImportResources(instance);

			// Important: RELOAD the settings, cached version probably had invalid references.
			HPatternSettings.ResetCache(instance.Model);

			// Set the default theme for the Knowledge Base.
			HPatternSettings settings = HPatternSettings.Get(instance.Model);
			if (settings.Theme.Theme != null)
			{
				KBModel model = instance.KB.DesignModel.Environment.TargetModel;
				model.SetPropertyValue(Properties.MODEL.DefaultTheme, new KBObjectReference(settings.Theme.Theme));
				model.Save();
			}
		}

		#endregion

		#region Customize generation

		public override void BeforeGenerateObject(PatternInstance instance, InstanceObject instanceObject)
		{
            if (Messages.Debug())
            {
                CommonServices.Output.AddLine(String.Format(">>> BeforeGenerateObject Begin {0}", DateTime.Now.ToString()));
                CommonServices.Output.AddLine(String.Format(">>> instanceObject.Name {0}", instanceObject.Name));
            }
			HPatternInstance wwInstance = null;
			if (instanceObject.Instance != null)
                wwInstance = HPatternInstance.Load(instanceObject.Instance);

            //TESTS 
            

            HPatternSettings settings = HPatternSettings.Get(instanceObject.Model);

            if (instanceObject.Object == HPatternObject.ListPrograms && !settings.Template.GenerateListPrograms)
            {
                instanceObject.Generate = false;
                return;
            }

            // 0.- Se temos a view, vamos verificar se é para gerar, se não, vamos apagar :D
            if (instanceObject.Object == HPatternObject.View
                || instanceObject.Object == HPatternObject.TabTabular
                || instanceObject.Object == HPatternObject.TabGrid
                || instanceObject.Object == HPatternObject.TabGridTrn
                || instanceObject.Object == HPatternObject.ExportTabGrid
                || instanceObject.Object == HPatternObject.TabGridSDT)
            {
                if (wwInstance != null)
                {
                    if (wwInstance.Transaction != null)
                    {
                        if (settings.Template.GenerateViewOnlyBC)
                        {
                            if (wwInstance.Levels != null)
                            {
                                if (wwInstance.Levels.Count > 0)
                                {
                                    if (!wwInstance.Transaction.WebBC)
                                    {

                                        instanceObject.Generate = false;
                                        return;

                                    }
                                }
                            }
                        } else {
                            if (instanceObject.Object == HPatternObject.TabGridTrn) {
                                if (wwInstance.Levels != null)
                                {
                                    if (wwInstance.Levels.Count > 0)
                                    {
                                        if (!wwInstance.Transaction.WebBC)
                                        {

                                            instanceObject.Generate = false;
                                            return;

                                        }
                                    }
                                }
                            }
                            if (instanceObject.Object == HPatternObject.TabTabular && settings.Template.TabFunction == SettingsTemplateElement.TabFunctionValue.TreeViewAnchor && wwInstance.Levels != null && wwInstance.Levels.Count > 0)
                            {
                                instanceObject.Generate = false;
                            }
                        }
                    }
                }
            }

            if (instanceObject.Object == HPatternObject.DataProviderGridModel || instanceObject.Object == HPatternObject.DataProviderGrid || instanceObject.Object == HPatternObject.SDTGrid || instanceObject.Object == HPatternObject.ProcedureGrid)
            {
                if (settings.Grid.GridType != HPattern.SettingsGridElement.GridTypeValue.Gxui)
                {
                    instanceObject.Generate = false;
                    return;
                }
            }
			
            string trnName = "";
            if (wwInstance != null)
            {
                if (wwInstance.Transaction != null)
                {
                    trnName = wwInstance.Transaction.TransactionName.ToLower();
                }
            }

            // Gera BC
            if (instanceObject.Object == HPatternObject.TransactionBC || instanceObject.Object == HPatternObject.TransactionBCTab  || instanceObject.Object == HPatternObject.SDTBC || instanceObject.Object == HPatternObject.DataProviderBC || instanceObject.Object == HPatternObject.ProcedureBC || instanceObject.Object == HPatternObject.ProcedureSaveBC)
            {
                bool gera = wwInstance.Transaction.WebBC;
                /*
                bool gera = settings.Template.DataEntryWebPanelBC;
                if (wwInstance.Transaction.DataEntryWebPanelBC.ToLower() == "true")
                    gera = true;
                if (wwInstance.Transaction.DataEntryWebPanelBC.ToLower() == "false")
                b    gera = false;
                */

                if (gera)
                {
                    if (instanceObject.Object == HPatternObject.TransactionBC)
                    {
                        if (wwInstance.Transaction.Form.Tabs.Count > 0)
                            gera = false;
                    }
                    if (instanceObject.Object == HPatternObject.TransactionBCTab)
                    {
                        if (wwInstance.Transaction.Form.Tabs.Count <= 0)
                            gera = false;
                    }
                }

                if (gera)    
                {
                    if (instanceObject.Object == HPatternObject.DataProviderBC) { 
                        
                    }

                } else {

                    instanceObject.Generate = false;
                    return;
                }
            }

            if (instanceObject.Object == HPatternObject.DataProviderDSM)
            {
                bool geraAba = false;
                bool gera = false;
                if (wwInstance.Transaction != null && wwInstance.Transaction.WebBC)
                    gera = true;
                /*
                bool gera = settings.Template.DataEntryWebPanelBC;
                if (wwInstance.Transaction.DataEntryWebPanelBC.ToLower() == "true")
                    gera = true;
                if (wwInstance.Transaction.DataEntryWebPanelBC.ToLower() == "false")
                    gera = false;
                */

                if (gera)
                {
                    if (wwInstance.Levels != null && wwInstance.Levels.Count > 0)
                    {
                        LevelElement l = wwInstance.Levels[0];
                        if (l.View != null)
                        {
                            if (l.View.Tabs.Count > 0)
                            {
                                geraAba = true;
                            }
                        }
                    }
                }
                
                if (!geraAba)
                {
                    if (wwInstance.WebObject.Form.Tabs != null)
                    {
                        if (wwInstance.WebObject.Form.Tabs.Count > 0)
                        {
                            geraAba = true;
                        }
                    }
                }
                if (geraAba)
                {
                    if (settings.Template.TabFunction == SettingsTemplateElement.TabFunctionValue.TreeViewAnchor)
                    {
                        geraAba = false;
                    }

                }
                if (!geraAba)
                {
                    instanceObject.Generate = false;
                    return;
                }
            }

			// Customize generation of export procedure.
			if (instanceObject.Object == HPatternObject.ExportSelection || instanceObject.Object == HPatternObject.ExportTabGrid)
			{
				IGridObject gridObject = wwInstance.GetElement<IGridObject>(instanceObject.Element);
				if (gridObject.Actions.Export == null)
				{
					instanceObject.Generate = false;
					return;
				}
			}

			// Customize names.
            if (instanceObject.Object == HPatternObject.Selection)
            {
                SelectionElement selec = wwInstance.GetElement<SelectionElement>(instanceObject.Element);
                instanceObject.Name = settings.Objects.SelectionName(selec);
                instanceObject.Description = selec.Description;
            }

            if (instanceObject.Object == HPatternObject.Prompt)
            {
                PromptElement prompt = wwInstance.GetElement<PromptElement>(instanceObject.Element);
                instanceObject.Name = settings.Objects.PromptName(prompt);
                instanceObject.Description = prompt.Description;
            }

            if (instanceObject.Object == HPatternObject.View)
            {
                
                ViewElement view = wwInstance.GetElement<ViewElement>(instanceObject.Element);
                if (view != null)
                {
                    if (view.Tabs.Count > 0)
                    {
                        bool gera2 = wwInstance.Transaction.WebBC;
                        /*
                        bool gera2 = settings.Template.DataEntryWebPanelBC;
                        if (wwInstance.Transaction.DataEntryWebPanelBC.ToLower() == "true")
                            gera2 = true;
                        if (wwInstance.Transaction.DataEntryWebPanelBC.ToLower() == "false")
                            gera2 = false;
                        */

                        if (gera2)
                            instanceObject.Generate = false;
                    }

                    instanceObject.Name = settings.Objects.ViewName(view);

                }

            }

            if (!settings.Template.LoadSDTWithDataProvider)
            {
                if (instanceObject.Object == HPatternObject.DataProviderBC)
                {
                    instanceObject.Generate = false;
                }
            }
            

			if (instanceObject.Object == HPatternObject.ExportSelection || instanceObject.Object == HPatternObject.ExportTabGrid)
				instanceObject.Name = settings.Objects.ExportProcedureName(wwInstance.GetElement<IGridObject>(instanceObject.Element));

			if (instanceObject.Object == HPatternObject.GridSDT || instanceObject.Object == HPatternObject.TabGridSDT)
				instanceObject.Name = settings.Objects.GridSdtName(wwInstance.GetElement<IGridObject>(instanceObject.Element));


            if (instanceObject.Object == HPatternObject.TabGridTrn)
            {
                TabElement tabtrn = wwInstance.GetElement<TabElement>(instanceObject.Element);
                if (tabtrn.GetCallMethod != TabElement.CallMethodValue.Popup)
                {
                    instanceObject.Generate = false;
                }
            }

            // Vamos colocar os nomes conforme arquivo separado por ";"
            if (!String.IsNullOrEmpty(settings.Template.ObjectsNamesName))
            {
                if (instanceObject.Generate)
                {
                    if (instanceObject.Object == HPatternObject.Selection)
                    {
                        /*
                        string tmpN = GetSugestName(trnName, settings);
                        if (!String.IsNullOrEmpty(tmpN))
                        {
                            instanceObject.Name = tmpN;
                            SelectionElement selec = wwInstance.GetElement<SelectionElement>(instanceObject.Element);
                            selec.ObjectName = tmpN;

                        } 
                        */
                        SelectionElement selec = wwInstance.GetElement<SelectionElement>(instanceObject.Element);
                        if (!String.IsNullOrEmpty(selec.ObjName))
                        {
                            instanceObject.Name = selec.ObjName;
                        }

                    }

                    if (wwInstance != null)
                    {
                        if (wwInstance.Transaction.WebBC)
                        {

                            if (instanceObject.Object == HPatternObject.TransactionBC)
                            {
                                /*
                                string tmpN = GetSugestName(trnName, settings);
                                if (!String.IsNullOrEmpty(tmpN))
                                {
                                    instanceObject.Name = tmpN;
                                    TransactionElement selec = wwInstance.GetElement<TransactionElement>(instanceObject.Element);
                                    selec.ObjectName = tmpN;
                                }
                                */
                                TransactionElement selec = wwInstance.GetElement<TransactionElement>(instanceObject.Element);
                                if (!String.IsNullOrEmpty(selec.ObjName))
                                {
                                    instanceObject.Name = selec.ObjName;
                                }
                            }

                            if (instanceObject.Object == HPatternObject.TransactionBCTab)
                            {
                                if (wwInstance.Transaction.Form.Tabs.Count > 0)
                                {
                                    /*
                                    string tmpN = GetSugestName(trnName, settings);
                                    if (!String.IsNullOrEmpty(tmpN))
                                    {
                                        instanceObject.Name = tmpN;
                                        TabFormElement selec = wwInstance.GetElement<TabFormElement>(instanceObject.Element);
                                        selec.ObjectName = tmpN;

                                    }
                                    */
                                    TabFormElement selec = wwInstance.GetElement<TabFormElement>(instanceObject.Element);
                                    if (!String.IsNullOrEmpty(selec.ObjName))
                                    {
                                        instanceObject.Name = selec.ObjName;
                                    }
                                }
                            }

                            if (instanceObject.Object == HPatternObject.TabGrid)
                            {
                                if (wwInstance.Levels[0].View != null)
                                {
                                    ViewElement v = wwInstance.Levels[0].View;
                                    if (v.Tabs.Count > 0)
                                    {
                                        TabElement selec = wwInstance.GetElement<TabElement>(instanceObject.Element);
                                        if (!String.IsNullOrEmpty(selec.ObjName))
                                        {
                                            instanceObject.Name = selec.ObjName;
                                        }
                                    }
                                }
                            }

                            if (instanceObject.Object == HPatternObject.TabGridTrn)
                            {
                                if (wwInstance.Levels[0].View != null)
                                {
                                    ViewElement v = wwInstance.Levels[0].View;
                                    if (v.Tabs.Count > 0)
                                    {
                                        TabElement selec = wwInstance.GetElement<TabElement>(instanceObject.Element);
                                        if (!String.IsNullOrEmpty(selec.ObjNameTrn))
                                        {
                                            instanceObject.Name = selec.ObjNameTrn;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
             
            /*
            if (wwInstance != null)
            {
                if (instanceObject.Generate && (!settings.Template.WebPanelBCDefault) && wwInstance.UpdateWebPanelBC == HPatternInstance.UpdateWebPanelBCValue.Default)
                {
                    if (instanceObject.Object == HPatternObject.TransactionBC || instanceObject.Object == HPatternObject.TransactionBCTab)
                    {
                        WebPanel web3 = WebPanel.Get(instance.Model, instanceObject.Name);
                        if (web3 != null)
                        {
                            web3.Rules.IsDefault = true;
                            web3.Events.IsDefault = true;
                            web3.Conditions.IsDefault = true;
                            web3.Variables.IsDefault = true;
                            web3.WebForm.IsDefault = true;
                            web3.Save();

                        }
                    }
                }
            }
            */
            
            if (Messages.Debug())
            {
                CommonServices.Output.AddLine(String.Format(">>> BeforeGenerateObject End {0}", DateTime.Now.ToString()));                
            }
            
		}

		#endregion

		#region Update generated objects

        static string ftname = null;
        static string nomes = null;
        static ArrayList trns = new ArrayList();
        static ArrayList objs = new ArrayList();
        static ArrayList usados = new ArrayList();
        static WikiFileKBObject file = null;
        static string sigla = null;
        static string sugname = null;

        public static void ClearSuggest()
        {
            trns.Clear();
            objs.Clear();
            usados.Clear();
            sugname = null;
            sigla = null;
        }

        public static string GetSugestName(string trnNameB, HPatternSettings settings)
        {
            string trnName = trnNameB.ToLower();

            if (ftname == null)
            {
                try
                {
                    ftname = settings.Template.ObjectsNamesName;
                }
                catch (System.Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message + e.StackTrace);
                    ftname = null;
                }

                if (ftname != null)
                {
                    file = WikiFileKBObject.Get(Artech.Architecture.UI.Framework.Services.UIServices.KB.CurrentModel, ftname);
                }
            }

            if (file != null && trns.Count == 0)
            {
                nomes = System.Text.Encoding.Default.GetString(file.BlobPart.Data);

                foreach (string nomel in nomes.Split(Environment.NewLine.ToCharArray()))
                {
                    string[] nomef = nomel.Split(';');
                    if (nomef.Length > 0)
                    {
                        if (!String.IsNullOrEmpty(nomef[0]))
                        {
                            trns.Add(nomef[0].ToLower());
                            if (nomef.Length > 1)
                            {
                                if (String.IsNullOrEmpty(nomef[1]))
                                {
                                    objs.Add("");
                                }
                                else
                                {
                                    objs.Add(nomef[1]);
                                }
                            }
                            else
                            {
                                objs.Add("");
                            }
                        }
                    }
                }
            }

            if (trns.Count > 0 && sugname == null)
            {
                int achou = trns.IndexOf(trnName);
                if (achou >= 0)
                {
                    if (!String.IsNullOrEmpty((string)objs[achou]))
                    {
                        sugname = (string)objs[achou];
                    }
                }
                else
                {
                    if (trnName.Substring(0, 1) == "t")
                    {
                        string tmpName = trnName.Substring(1, trnName.Length - 1);
                        achou = trns.IndexOf(tmpName);
                        if (achou >= 0)
                        {
                            if (!String.IsNullOrEmpty((string)objs[achou]))
                            {
                                sugname = (string)objs[achou];
                            }
                        }
                    }
                }
            }

            string tmpn = null;

            if (!String.IsNullOrEmpty(sugname))
            {
                tmpn = sugname;
                if (usados.IndexOf(tmpn) < 0)
                {
                    usados.Add(tmpn);
                }
                else
                {
                    if (String.IsNullOrEmpty(sigla))
                    {
                        sigla = "a";
                    }
                    else
                    {
                        byte[] caracteres = new byte[System.Text.Encoding.ASCII.GetByteCount(sigla)];
                        caracteres = System.Text.Encoding.ASCII.GetBytes(sigla);
                        if (caracteres.Length > 0)
                        {
                            sigla = char.ConvertFromUtf32(caracteres[0] + 1);
                        }
                    }
                    tmpn = sugname + sigla;
                    usados.Add(tmpn);
                }
            }

            return tmpn;
        }

        public override void AfterSaveObjects(Artech.Packages.Patterns.Objects.PatternInstance instance, Artech.Packages.Patterns.Engine.InstanceObjects instanceObjects)
        {
            if (Messages.Debug())
            {
                CommonServices.Output.AddLine(String.Format(">>> AfterSaveObjects Begin {0}", DateTime.Now.ToString()));
            }
            base.AfterSaveObjects(instance, instanceObjects);

            HPatternInstance wwInstance = HPatternInstance.Load(instance);
            HPatternSettings settings = HPatternSettings.Get(instance.Model);
            string trnName = "";
            if (wwInstance.Transaction != null && wwInstance.Transaction.Transaction != null) 
            {
                trnName = wwInstance.Transaction.TransactionName;
            

                try
                {
                    string sdtname = "SDT" + trnName + "BC";
                    string dpname = "DP" + trnName + "BC";

                    SDT sdt = SDT.Get(instance.Model, sdtname);

                    DataProvider dp = DataProvider.Get(instance.Model, dpname);

                    if (dp != null && sdt != null)
                    {
                        dp.SetPropertyValue(Properties.DPRV.Output, new DataProviderOutputReference(new KBObjectReference(sdt)));
                        dp.Save();
                    }


                }
                catch (Exception e)
                {
                    // System.Windows.Forms.MessageBox.Show(e.Message + "\n" + e.StackTrace + "\n" + e.Source);
                }
            }


            try
            {
                foreach (DataProvider dp in instanceObjects.GetGroup(HPatternObject.DataProviderGrid).GetObjects<DataProvider>())
                {
                    SDT sdt = SDT.Get(instance.Model, "SDT" + trnName + "Grid");

                    if (sdt != null)
                    {
                        dp.SetPropertyValue(Properties.DPRV.Output, new DataProviderOutputReference(new KBObjectReference(sdt)));
                        dp.SetPropertyValue(Properties.DPRV.Collection, true);
                        dp.Save();
                    }

                }
            }
            catch (Exception e) {
                // System.Diagnostics.Debug.WriteLine(e.Message + e.StackTrace);
            }



            if (Messages.Debug())
            {
                CommonServices.Output.AddLine(String.Format(">>> AfterSaveObjects End {0}", DateTime.Now.ToString()));
            }
        }
        
		public override void BeforeSaveObjects(PatternInstance instance, InstanceObjects instanceObjects)
		{
            if (Messages.Debug())
            {                
                CommonServices.Output.AddLine(String.Format(">>> BeforeSaveObjects Begin {0}", DateTime.Now.ToString()));
            }
			base.BeforeSaveObjects(instance, instanceObjects);

            ParserFactory.getFactory(instance, instanceObjects);

			HPatternSettings settings = HPatternSettings.Get(instance.Model);
            HPatternInstance wwInstance = HPatternInstance.Load(instance);
            string trnName = "";
            if (wwInstance.Transaction != null && wwInstance.Transaction.Transaction != null)
            {
                trnName = wwInstance.Transaction.TransactionName;
            }

            foreach (DataProvider dp in instanceObjects.GetGroup(HPatternObject.DataProviderDSM).GetObjects<DataProvider>())
            {
                SDT sdt = SDT.Get(instance.Model, "MenuData");

                if (sdt != null)
                    dp.SetPropertyValue(Properties.DPRV.Output, new DataProviderOutputReference(new KBObjectReference(sdt)));
            }

            foreach (DataProvider dp in instanceObjects.GetGroup(HPatternObject.DataProviderGridModel).GetObjects<DataProvider>())
            {
                SDT sdt = SDT.Get(instance.Model, "gxuiGridColumnModel");

                if (sdt != null)
                    dp.SetPropertyValue(Properties.DPRV.Output, new DataProviderOutputReference(new KBObjectReference(sdt)));
            }

            if (wwInstance != null)
            {
                if (wwInstance.Levels.Count > 0)
                {
                    if (wwInstance.Levels[0].Selection != null)
                    {
                        if (wwInstance.Levels[0].Selection.GridType == SettingsGridElement.GridTypeValue.Gxui)
                        {
                            foreach (Procedure p in instanceObjects.GetGroup(HPatternObject.ProcedureGrid).GetObjects<Procedure>())
                            {
                                p.SetPropertyValue(Properties.PRC.MainProgram, true);
                                p.SetPropertyValue(Properties.PRC.CallProtocol, Properties.PRC.CallProtocol_Values.Http);
                            }
                        }
                    }
                }
            }

            bool gera = false;
            if (wwInstance.Transaction != null)
            {
                gera = wwInstance.Transaction.WebBC;
            }
            /*
            bool gera = settings.Template.DataEntryWebPanelBC;
            if (wwInstance.Transaction.DataEntryWebPanelBC.ToLower() == "true")
                gera = true;
            if (wwInstance.Transaction.DataEntryWebPanelBC.ToLower() == "false")
                gera = false;
            */

            LevelElement level = null;
            if (wwInstance.Levels != null && wwInstance.Levels.Count > 0)
            {
                level = wwInstance.Levels[0];
            }
            ViewElement view = null;
            if (gera || level == null)
            {
                gera = false;
            } 
            else 
            {
                view = level.View;
                if (view == null)
                    gera = false;
            }

            if (gera)
            {

                InstanceObjectsGroup group = instanceObjects.GetGroup(HPatternObject.TabGrid);

                foreach (WebPanel webi in group.GetObjects<WebPanel>())
                {                    
                    foreach (TabElement tabe in view.Tabs)
                    {
                        if (tabe.Type == TabElement.TypeValue.Grid && tabe.Transaction !=null && tabe.Transaction.Transaction != null)
                        {                            
                            if (webi.Name == tabe.Wcname) {
                                webi.SetPropertyValue(Properties.WBP.Type, Properties.WBP.Type_Values.WebPage);
                            }
                        }
                    }

                }

                InstanceObjectsGroup group2 = instanceObjects.GetGroup(HPatternObject.TabGridTrn);

                foreach (WebPanel webi in group2.GetObjects<WebPanel>())
                {
                    webi.SetPropertyValue(Properties.WBP.Type, Properties.WBP.Type_Values.WebPage);
                }
            }
                                    
            WebPanel mSelection = settings.MasterPages.Selection;
            WebPanel mPrompt = settings.MasterPages.Prompt;
            WebPanel mView = settings.MasterPages.View;
            WebPanel mTransaction = settings.MasterPages.Transaction;
            Theme tTema = null;
            string AMP = SettingsThemeElement.SetObjectThemeValue.True;
            string ATema = settings.Theme.SetObjectTheme;
            if (ATema != SettingsThemeElement.SetObjectThemeValue.False)
                tTema = settings.Theme.Theme;
            
            if (settings.CustomThemeMasterPage != null)
            {
                foreach (SettingsThemeMasterPageElement sis in settings.CustomThemeMasterPage)
                {
                    if (wwInstance.Transaction != null && wwInstance.Transaction.Transaction != null)
                    {
                        if (wwInstance.Transaction.TransactionName.IndexOf(sis.Name, StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            if (sis.SetMasterPage != SettingsThemeElement.SetObjectThemeValue.False)
                            {
                                AMP = sis.SetMasterPage;
                                mSelection = sis.Selection;
                                mPrompt = sis.Prompt;
                                mView = sis.View;
                                mTransaction = sis.Transaction;
                            }
                            if (sis.SetTheme != SettingsThemeElement.SetObjectThemeValue.False)
                            {
                                ATema = sis.SetTheme;
                                tTema = sis.Theme;
                            }
                            break;
                        }
                    }
                }
            }

            // Define a mesma Categoria da transação ao objetos gerados pelo pattern
            if (wwInstance.Transaction != null && wwInstance.Transaction.Transaction != null)
            {
                foreach (Artech.Udm.Framework.Entity cat in wwInstance.Transaction.Transaction.Categories)
                {
                    foreach (KBObject obj in instanceObjects.GeneratedObjects)
                    {
                        obj.AddCategory(cat);
                    }
                }
            }
            
            // Set master page for objects.
            SetObjectsMasterPage("s", settings.Grid.AutomaticRefresh, wwInstance, instanceObjects.GetGroup(HPatternObject.Selection), mSelection, tTema,ATema,AMP);
            SetObjectsMasterPage("p", settings.Grid.AutomaticRefresh, wwInstance, instanceObjects.GetGroup(HPatternObject.Prompt), mPrompt, tTema, ATema, AMP);
            SetObjectsMasterPage("", settings.Grid.AutomaticRefresh, wwInstance, instanceObjects.GetGroup(HPatternObject.View), mView, tTema, ATema, AMP);
            SetObjectsMasterPage("", settings.Grid.AutomaticRefresh, wwInstance, instanceObjects.GetGroup(HPatternObject.TransactionBC), mTransaction, tTema, ATema, AMP);
            SetObjectsMasterPage("", settings.Grid.AutomaticRefresh, wwInstance, instanceObjects.GetGroup(HPatternObject.TransactionBCTab), mTransaction, tTema, ATema, AMP);
            SetObjectsMasterPage("", settings.Grid.AutomaticRefresh, wwInstance, instanceObjects.GetGroup(HPatternObject.TabGrid), mTransaction, tTema, ATema, AMP);
            SetObjectsMasterPage("", settings.Grid.AutomaticRefresh, wwInstance, instanceObjects.GetGroup(HPatternObject.TabGridTrn), mTransaction, tTema, ATema, AMP);

            if (wwInstance.Transaction != null && wwInstance.Transaction.WebBC)
            {
                if (settings.Template.WebPanelBCDefault == false && wwInstance.UpdateWebPanelBC == HPatternInstance.UpdateWebPanelBCValue.Default)
                {

                    InstanceObjectsGroup group2 = null;
                    if (wwInstance.Transaction.Form.Tabs.Count > 0)
                    {
                        group2 = instanceObjects.GetGroup(HPatternObject.TransactionBCTab);
                        foreach (WebPanel web2 in group2.GetObjects<WebPanel>())
                        {

                            

                            web2.Rules.IsDefault = true;
                            web2.Events.IsDefault = true;
                            web2.Conditions.IsDefault = true;
                            web2.Variables.IsDefault = true;
                            web2.WebForm.IsDefault = true;
                            web2.Rules.IsDefault = false;
                            web2.Events.IsDefault = false;
                            web2.Conditions.IsDefault = false;
                            web2.Variables.IsDefault = false;
                            web2.WebForm.IsDefault = false;
                            //web2.Save();
                        }
                    }
                    else
                    {
                        group2 = instanceObjects.GetGroup(HPatternObject.TransactionBC);
                        foreach (WebPanel web2 in group2.GetObjects<WebPanel>())
                        {
                            web2.Rules.IsDefault = true;
                            web2.Events.IsDefault = true;
                            web2.Conditions.IsDefault = true;
                            web2.Variables.IsDefault = true;
                            web2.WebForm.IsDefault = true;
                            //web2.Save();
                            web2.Rules.IsDefault = false;
                            web2.Events.IsDefault = false;
                            web2.Conditions.IsDefault = false;
                            web2.Variables.IsDefault = false;
                            web2.WebForm.IsDefault = false;
                            //web2.Save();
                        }
                    }

                    if (wwInstance.Levels[0].View != null)
                    {
                        ViewElement v = wwInstance.Levels[0].View;
                        if (v.Tabs.Count > 0) 
                        {
                            group2 = instanceObjects.GetGroup(HPatternObject.TabGrid);
                            foreach (WebPanel web2 in group2.GetObjects<WebPanel>())
                            {
                                web2.Rules.IsDefault = true;
                                web2.Events.IsDefault = true;
                                web2.Conditions.IsDefault = true;
                                web2.Variables.IsDefault = true;
                                web2.WebForm.IsDefault = true;
                                //web2.Save();
                                web2.Rules.IsDefault = false;
                                web2.Events.IsDefault = false;
                                web2.Conditions.IsDefault = false;
                                web2.Variables.IsDefault = false;
                                web2.WebForm.IsDefault = false;
                                //web2.Save();
                            }                            
                        }
                    }
                }
            }

            if (wwInstance.DocumentationEnabled)
            {
                foreach (KBObject obj in instanceObjects.GeneratedObjects)
                {
                    if (obj is WebPanel)
                    {
                        WebPanel obja = obj as WebPanel;                                                
                        ChangeDocumentation(obja.Documentation, obj, wwInstance,settings);
                    }
                    if (obj is Procedure)
                    {
                        ChangeDocumentation((obj as Procedure).Documentation, obj, wwInstance, settings);
                    }
                    if (obj is DataProvider)
                    {
                        ChangeDocumentation((obj as DataProvider).Documentation, obj, wwInstance, settings);
                    }
                    if (obj is SDT)
                    {
                        ChangeDocumentation((obj as SDT).Documentation, obj, wwInstance, settings);
                    }

                }
            }

            if (Messages.Debug())
            {
                CommonServices.Output.AddLine(String.Format(">>> BeforeSaveObjects End {0}", DateTime.Now.ToString()));
            }

		}

        private void ChangeDocumentation(DocumentationPart docp, KBObject obj, HPatternInstance wwInstance, HPatternSettings settings)
        {
            TemplateInternal.DocumentationSave(docp, obj, wwInstance, settings);
        }

        private void SetObjectsMasterPage(string tipo, bool ar, HPatternInstance wwInstance, InstanceObjectsGroup group, WebPanel masterPage, Theme tTema, string ATema, string AMP)
		{
            if (group != null && tipo == "p")
            {
                foreach (WebPanel webPanel in group.GetObjects<WebPanel>())
                {
                    webPanel.SetPropertyValue(Properties.WBP.EncryptUrlParameters, Properties.WBP.EncryptUrlParameters_Values.No);
                }
            }

			if (group != null)
			{
				foreach (WebPanel webPanel in group.GetObjects<WebPanel>())
				{
                    if (webPanel.IsPropertyDefault(Properties.WBP.MasterPage) || AMP == SettingsThemeElement.SetObjectThemeValue.Force)
                    {
                        if (masterPage == null)
                        {
                            webPanel.SetPropertyValue(Properties.WBP.MasterPage, new WebPanelReference());
                        }
                        else
                        {
                            webPanel.SetPropertyValue(Properties.WBP.MasterPage, new WebPanelReference(masterPage));
                        }
                    }

                    if (tTema != null)
                    {
                        if (webPanel.IsPropertyDefault(Properties.WBP.Theme) || ATema == SettingsThemeElement.SetObjectThemeValue.Force)
                        {
                            webPanel.SetPropertyValue(Properties.WBP.Theme, new KBObjectReference(tTema));                            
                        }
                    }

                    if (tipo == "p") {
                        
                        foreach (LevelElement l in wwInstance.Levels) {
                            foreach (PromptElement p in l.Prompts) { 
                                bool ari = ar;
                                if (p.AutomaticRefresh.ToLower() == "true")
                                    ari = true;
                                if (p.AutomaticRefresh.ToLower() == "false")
                                    ari = false;


                                if (webPanel.Name.ToLower() == p.Name.ToLower()) {
                                    if (ari)
                                    {
                                        webPanel.SetPropertyValue(Properties.WBP.AutomaticRefresh, Properties.WBP.AutomaticRefresh_Values.WhenVariablesInConditionsChange);
                                    }
                                    else
                                    {
                                        webPanel.SetPropertyValue(Properties.WBP.AutomaticRefresh, Properties.WBP.AutomaticRefresh_Values.No);
                                    }
                                }

                            }
                        
                        }
                    }

                    if (tipo == "s") {
                        InstanceObject sl = group.Objects.Find(delegate(InstanceObject iobj) { return iobj.Object == HPatternObject.Selection; });

                        if (sl != null) 
                        {
                            if (webPanel.Name == sl.Name) {
                                foreach (LevelElement l in wwInstance.Levels) {
                                    bool ari = ar;
                                    if (l.Selection.AutomaticRefresh.ToLower() == "true")
                                        ari = true;
                                    if (l.Selection.AutomaticRefresh.ToLower() == "false")
                                        ari = false;

                                    if (ari)
                                    {
                                        webPanel.SetPropertyValue(Properties.WBP.AutomaticRefresh, Properties.WBP.AutomaticRefresh_Values.WhenVariablesInConditionsChange);
                                    }
                                    else
                                    {
                                        webPanel.SetPropertyValue(Properties.WBP.AutomaticRefresh, Properties.WBP.AutomaticRefresh_Values.No);
                                    }

                                }
                            }
                        }
                    }
				}
			}
		}

		public override void UpdateParentObject(KBObject parent, PatternInstance instance)
		{
            if (Messages.Debug())
            {
                CommonServices.Output.AddLine(String.Format(">>> UpdateParentObject Begin {0}", DateTime.Now.ToString()));
            }
			base.UpdateParentObject(parent, instance);

            if (!GXVersion.IsGenexusServer)
            {
                Debug.Assert(parent != null && (parent is Transaction || parent is WebPanel));

                if (parent is Transaction)
                {

                    Transaction transaction = (Transaction)parent;
                    HPatternTransactionUpdater.Apply(instance, transaction);


                    HPatternSettings settings = HPatternSettings.Get(instance.Model);
                    HPatternInstance wwInstance = HPatternInstance.Load(instance);

                    bool gera = wwInstance.Transaction.WebBC;
                    /*
                    bool gera = settings.Template.DataEntryWebPanelBC;
                    if (wwInstance.Transaction.DataEntryWebPanelBC.ToLower() == "true")
                        gera = true;
                    if (wwInstance.Transaction.DataEntryWebPanelBC.ToLower() == "false")
                        gera = false;
                    */

                    if (gera)
                    {
                        if (wwInstance.Levels[0] != null)
                        {
                            if (wwInstance.Levels[0].View != null)
                            {
                                foreach (TabElement tabe in wwInstance.Levels[0].View.Tabs)
                                {
                                    if (tabe.Type == TabElement.TypeValue.Grid && tabe.Transaction != null && tabe.Transaction.Transaction != null)
                                    {
                                        Transaction trn = tabe.Transaction.Transaction;
                                        trn.SetPropertyValue(Properties.TRN.BusinessComponent, true);
                                        trn.Save();
                                    }
                                }
                            }
                        }
                    }

                }
                else if (parent is WebPanel)
                {
                    //CommonServices.Output.AddLine(">>> WebPanel não implementado!");
                    new WebPanelUpdater((WebPanel)parent, instance);
                }
            }

            if (Messages.Debug())
            {
                CommonServices.Output.AddLine(String.Format(">>> UpdateParentObject End {0}", DateTime.Now.ToString()));
            }
		}

		#endregion
	}
}
