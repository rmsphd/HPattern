using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using Artech.Packages.Patterns;
using Artech.Genexus.Common.Helpers;
using Artech.Genexus.Common;
using Artech.Genexus.Common.CustomTypes;
using Artech.Genexus.Common.Objects;
using System.Security;
using Artech.Common.Diagnostics;
using Heurys.Patterns.HPattern;
using Artech.Genexus.Common.Parts;
using Heurys.Patterns.HPattern.Resources;
using Heurys.Patterns.HPattern.Code;
using Artech.Architecture.Common.Services;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common.Wiki;
using Artech.Common.Helpers.Strings;
using Artech.Common.Collections;
using System.Text.RegularExpressions;

namespace Heurys.Patterns.HPattern.Helpers
{
    public class Template
    {
        private static HPatternSettings sett;

        #region Transaction

        public static string Button(string ControlName,string ControlCaption,string ControlClass,string ControlEvent,string ControlImage)
        {
            return WebForm.Button(ControlName, ControlClass, ControlCaption, ControlEvent);
        }

        private static string ButtonToolbar(string ControlName,string ControlCaption,string ControlTooltip,string ControlClass,string ControlEvent,string ControlImage)
        { 
            StringBuilder ret = new StringBuilder();

	        if (ControlImage.Length > 0)
	        {	
	            ret.AppendLine(WebForm.Image(ControlName, "ImageHandCenter", ControlImage, ControlEvent, ControlTooltip));
	        }
	        else
	        {
	            ret.AppendLine(WebForm.Button(ControlName, ControlClass, ControlCaption, ControlEvent));         
	        }
            ret.AppendLine(WebForm.Image(ControlName + "_separator", "ImageTop", "toolbarseparator", ControlEvent));

            return ret.ToString();
        }

        private static string Toolbar()
        {
            StringBuilder ret = new StringBuilder();
            ret.AppendLine("<div nowrap=\"nowrap\" class=\"ToolbarMain\" >");
            ret.AppendLine(ButtonToolbar("btn_first", "GX_BtnFirst", "GXM_first", "BtnFirst", "First", "First"));
            ret.AppendLine(ButtonToolbar("btn_previous", "GX_BtnPrevious", "GXM_previous", "BtnPrevious", "Previous", "Previous"));
            ret.AppendLine(ButtonToolbar("btn_next", "GX_BtnNext", "GXM_next", "BtnNext", "Next", "Next"));
            ret.AppendLine(ButtonToolbar("btn_last", "GX_BtnLast", "GXM_last", "BtnLast", "Last", "Last"));
            ret.AppendLine(ButtonToolbar("btn_select", "GX_BtnSelect", "GX_BtnSelect", "BtnSelect", "Select", "Select"));
            ret.AppendLine(ButtonToolbar("btn_enter2", "GX_BtnEnter", "GX_BtnEnter", "BtnEnter", "Enter", "Save"));
            ret.AppendLine(ButtonToolbar("btn_cancel2", "GX_BtnCancel", "GX_BtnCancel", "BtnCancel", "Cancel", "Cancel"));
            ret.AppendLine(ButtonToolbar("btn_delete2", "GX_BtnDelete", "GX_BtnDelete", "BtnDelete", "Delete", "ActionDelete"));
            ret.AppendLine("</div>");
            return ret.ToString();
        }

        private static string LeafLevel(TransactionLevel TransactionLevel, Dictionary<string, int> Counters)
        {
            StringBuilder ret = new StringBuilder();
	        string levelFullName = TransactionLevel.FullType.Replace(".", "_");
	        IDictionary<TransactionAttribute, Artech.Genexus.Common.Objects.Attribute> descAttNames;
	        IList<int> toExclude = DefaultFormHelper.CalculateExcluded(TransactionLevel, out descAttNames);

            ret.AppendLine(WebForm.BeginGrid("Grid" + levelFullName, null, null, null, null, Properties.HTMLSFL.BackColorStyle_Enum.Header, null, null));

	        foreach (TransactionAttribute trnAttribute in TransactionLevel.Attributes)
	        {
		        if (!toExclude.Contains(trnAttribute.Attribute.Id))
		        {
			        string colTitleProperty = "ColumnTitle";
			        Artech.Genexus.Common.Objects.Attribute attName;
			        if (!descAttNames.TryGetValue(trnAttribute, out attName))
			        {
				        attName = trnAttribute.Attribute;
				        if (trnAttribute.IsLocal)
					        colTitleProperty = "ContextualTitle";
			        }

			        string colTitleExpr = String.Format("={0}.{1}", attName.Name, colTitleProperty);

	                ret.AppendLine(WebForm.GridAttribute(trnAttribute.Name, null, colTitleExpr));
		        }
	        }
            ret.AppendLine(WebForm.EndGrid());

            return ret.ToString();
        }

        private static string OneAttribute(TransactionAttribute att, Dictionary<string, int> Counters, System.Boolean getButton, IDictionary<TransactionAttribute, Artech.Genexus.Common.Objects.Attribute> descAttNames)
        {
            StringBuilder ret = new StringBuilder();
	        Artech.Genexus.Common.Objects.Attribute attName;
	        if (!descAttNames.TryGetValue(att, out attName))
		        attName = att.Attribute;

	        string captionProperty = "Title";
	        if (att.IsLocal)
		        captionProperty = "ContextualTitle";
        		
	        //System.Collections.Generic.Dictionary<String,Object> cp = new System.Collections.Generic.Dictionary<String,Object>();
        	

	        // Don't show the get button.
	        getButton = false;        
            ret.AppendLine("<tr>");
                ret.AppendLine("<td class=\"td5\" valign=\"top\" nowrap=\"nowrap\">");
		            ret.AppendLine(WebForm.TextBlock("TextBlock" + att.Name, null, String.Format("={0}.{1}", attName.Name, captionProperty)));
	            ret.AppendLine("</td>");
	            ret.AppendLine("<td nowrap=\"nowrap\">");

	            if (getButton)
	            {

		            ret.AppendLine(WebForm.BeginTable("Table"+att.Name,null));
			            ret.AppendLine("<tr>");
				            ret.AppendLine("<td>");

            	}

		                        ret.AppendLine(WebForm.Attribute(att.Name));

            	if (getButton)
	            {
				            ret.AppendLine("</td>");
				            ret.AppendLine("<td>");
                                ret.AppendLine(Button("btn_get","GX_BtnGet","BtnGet","Get",""));
				            ret.AppendLine("</td>");
			            ret.AppendLine("</tr>");
                    ret.AppendLine(WebForm.EndTable());

            	}
                ret.AppendLine("</td>");
            ret.AppendLine("</tr>");
            return ret.ToString();
        }

        private static string InnerLevel(TransactionLevel TransactionLevel, System.Collections.Generic.Dictionary<string,int> Counters)
        {
            StringBuilder ret = new StringBuilder();
            ret.AppendLine("<tr>");
                ret.AppendLine("<td>");
		            ret.AppendLine(WebForm.BeginTable("Table" + (Counters["TableCounter"]++).ToString(), "Table"));

	        IDictionary<TransactionAttribute, Artech.Genexus.Common.Objects.Attribute> descAttNames;
	        IList<int> toExclude = DefaultFormHelper.CalculateExcluded(TransactionLevel, out descAttNames);

	        int attributesCounter = 0;
	        foreach (TransactionAttribute trnAttribute in TransactionLevel.PrimaryKey)
	        {
		        attributesCounter++;
		        bool getButton = (TransactionLevel.Parent == null) && (attributesCounter == TransactionLevel.PrimaryKey.Count);
                ret.AppendLine( Heurys.Patterns.HPattern.Helpers.Template.OneAttribute(trnAttribute,Counters,getButton,descAttNames));
	        }

	        foreach (Artech.Common.Helpers.Structure.IStructureItem structureItem in TransactionLevel.Items)
	        {
		        if (structureItem is TransactionAttribute)
		        {
			        TransactionAttribute trnAttribute = structureItem as TransactionAttribute;
			        if (!trnAttribute.IsKey && !toExclude.Contains(trnAttribute.Attribute.Id))
			        {

                        ret.AppendLine( Heurys.Patterns.HPattern.Helpers.Template.OneAttribute(trnAttribute,Counters,false,descAttNames));

			        }
		        }
		        else if (structureItem is TransactionLevel)
		        {
			        ret.AppendLine("<tr>");
				        ret.AppendLine("<td colspan=\"2\">");

			        TransactionLevel subLevel = structureItem as TransactionLevel;
			        bool hasMoreLevels = (subLevel.Levels.Count > 0);
			        if (hasMoreLevels)
			        {

					        ret.AppendLine("<br/>");
					        ret.AppendLine(WebForm.BeginTable("Table" + (Counters["TableCounter"]++).ToString(), "Table95"));
                                ret.AppendLine("<tr>");
                                    ret.AppendLine("<td class=\"SubTitle\">");
				                        ret.AppendLine(WebForm.TextBlock("Title" + subLevel.Name, "", subLevel.Description));
				                    ret.AppendLine("</td>");
                                ret.AppendLine("</tr>");
                            ret.AppendLine(WebForm.EndTable());
					        ret.AppendLine("<hr class=\"HRDefault\" />");
					        ret.AppendLine("<gxFreeStyle border=\"1\" freestyle=\"1\" gxProp=\"ControlName=Grid"+ (Counters["GridCounter"]++).ToString() +";class=FreeStyleGrid\">");
                                ret.AppendLine(InnerLevel(subLevel,Counters));
				            ret.AppendLine("</gxFreeStyle>");

			        }
			        else
			        {

					        ret.AppendLine("<br/>");
                            ret.AppendLine(WebForm.BeginTable("Table" + (Counters["TableCounter"]++).ToString(), "Table95"));
                                ret.AppendLine("<tr>");
                                    ret.AppendLine("<td class=\"SubTitle\">");
							            ret.AppendLine(WebForm.TextBlock("Title" + subLevel.Name, "", subLevel.Description));
							        ret.AppendLine("</td>");
                                 ret.AppendLine("</tr>");
                            ret.AppendLine(WebForm.EndTable());
                            ret.AppendLine("<hr class=\"HRDefault\" />");
                            ret.AppendLine( Heurys.Patterns.HPattern.Helpers.Template.LeafLevel(subLevel,Counters));

			        }

                    ret.AppendLine("</td>");
                    ret.AppendLine("</tr>");

		        }
	        }

            ret.AppendLine(WebForm.EndTable());
            ret.AppendLine("</td>");
            ret.AppendLine("</tr>");

            return ret.ToString();
        }

        public static string TrnWebForm(Artech.Architecture.Common.Objects.KBObject Object, Heurys.Patterns.HPattern.HPatternSettings Settings, Heurys.Patterns.HPattern.HPatternInstance Instance, Boolean geraBC, String tabBC, Boolean Component, Code.WebObject trnInstance)
        {
            return TrnWebForm2(Object,Settings,Instance,geraBC,tabBC,Component,trnInstance);
        }

/*
        private static string TrnWebForm3(Artech.Architecture.Common.Objects.KBObject Object, Heurys.Patterns.HPattern.HPatternSettings Settings, Heurys.Patterns.HPattern.HPatternInstance Instance, Boolean geraBC, String tabBC, Boolean Component, TransactionElement trnInstance)
        {

            FileStream f = File.OpenRead("c:\temptrn.txt");
            StringBuilder ret = new StringBuilder();
            byte[] buffer = new byte[100];
            while (f.Read(buffer, 100, 100) == 0)
            {
                ret.Append(buffer);
            }
            return ret.ToString();
        }
*/

        internal static string getUserTables(WebFormPart obj,string nome)
        {
            XmlNode xn = obj.Document.SelectSingleNode("//TABLE[@id=\"" + nome + "\"]");
            if (xn == null)
            {
                xn = obj.Document.SelectSingleNode("//table[@id=\"" + nome + "\"]");
            }
            if (xn != null)
            {
                return xn.OuterXml; 
            }
            return "";
        }



        internal static string TrnWebForm2(Artech.Architecture.Common.Objects.KBObject Object, Heurys.Patterns.HPattern.HPatternSettings Settings, Heurys.Patterns.HPattern.HPatternInstance Instance, Boolean geraBC, String tabBC, Boolean Component, Code.WebObject trnInstance)
        {
            //modMain.SetGXPath(Artech.Common.Helpers.IO.PathHelper.StartupPath);
            //HPatternBuildProcess.GetLic().CheckC(); 
            bool _webPanel = ((trnInstance is WebPanelRootElement) ? true : false);

            StringBuilder ret = new StringBuilder();
	        if (Messages.Debug())
	        {
		        CommonServices.Output.AddLine(String.Format(">>> TrnDefaultWebForm Begin {0}",DateTime.Now.ToString()));
		        CommonServices.Output.AddLine(String.Format(">>> geraBC = {0}",geraBC));
		        CommonServices.Output.AddLine(String.Format(">>> tabBC = {0}",tabBC));
		        CommonServices.Output.AddLine(String.Format(">>> Component = {0}",Component));
                string nome = (trnInstance is TransactionElement ? ((TransactionElement)trnInstance).TransactionName : "");
                CommonServices.Output.AddLine(String.Format(">>> trnInstance.TransactionName = {0}", nome));
		        CommonServices.Output.AddLine(String.Format(">>> Instance.Transaction.TransactionName = {0}",Instance.Transaction.TransactionName));
	        }

            WebFormPart wform = null;
            Transaction transaction = null;
            if (Object is Transaction)
            {
                transaction = Object as Transaction;
                wform = transaction.WebForm;
                if (transaction == null)
                    throw new ArgumentNullException("Object");
            }
            if (Object is WebPanel)
            {
                wform = ((WebPanel)Object).WebForm;
            }
        		
        		
	        HPatternSettings settings = Settings;

            HTemplate gridWebForm = GetTemplate(settings, 1);
        	

	        string stitle = "";
	        string stitleimage = "";
            string sdescription = Object.Description;
	        string stoolbar = "";	
	        string serrorviewer = "";		
	        string sattributes = "";
	        string sbuttonEnter = "";	
	        string sbuttonCancel = "";
	        string sbuttonHelp = "";
	        string sbuttonDelete = "";
            string sbuttonAction = "";
	        string sfooter = "";	
	        string stabs = "";
        	
	        //Transaction transaction
	        bool GenerateToolbar = false;
	        bool GenerateDelete = false;
            bool overwrite = trnInstance.UpdateObject == TransactionElement.UpdateObjectValue.Overwrite;
        		
	        if (!Component) {
		        serrorviewer = WebForm.ErrorViewer("ctlError", null);	
	        }
        		
	        if (GenerateToolbar) 
	        {
		        stoolbar = Heurys.Patterns.HPattern.Helpers.Template.Toolbar();
	        }
        	
	        if (settings.Template.TrnTitleImage != null) {							
		        stitleimage = WebForm.Image("ImgTitle",settings.Theme.Image,settings.Template.TrnTitleImage.Name);
		        stitle = WebForm.TextBlock("TitleText", settings.Template.TrnTitleTextClass, Object.Description);
	        } else {
                stitle = WebForm.TextBlock("TitleText", settings.Template.TrnTitleTextClass, Object.Description);
	        }

            Tab tabs = null;
            if (trnInstance.Form.Tabs.Count > 0 && !Component)
            {
                tabs = Tab.getTab(trnInstance.Form, Object);
            }

            if (tabs != null)
	        {
                stabs = tabs.WebForm();
                sfooter = tabs.WebFormCmp();
		        //Dictionary<string, Object> tabprops = new Dictionary<string, Object>();
		        //tabprops.Add("MenuData","&amp;MenuData");
		        //tabprops.Add("SelectedItem","&amp;MenuDataItem");
		        //stabs = WebFormHelper.BeginControl("DolphinStyleMenu","Tabs",tabprops)+WebFormHelper.EndControl("DolphinStyleMenu");		
	        }
        	
	        Dictionary<string, int> Counters = new Dictionary<string, int>();
	        Counters.Add("TextBlockCounter", 1);
	        Counters.Add("TableCounter", 2);
	        Counters.Add("GridCounter", 1);
        		
	        // Vamos montar os atributos que estão na tela
	        StringBuilder atts = new StringBuilder();
        	
	        //int contaAtts = 0;
        	
	        string sigla = "";
	        if (geraBC) {
		        if (Component) {
			        sigla = "BC";
		        } 
		        else 
		        {
			        sigla = "SDT";
		        }
	        }

            if (tabs != null)
            {
                atts.AppendLine(tabs.WebFormStart());
            }
	        atts.AppendLine(WebForm.BeginTable("Table1", "Table"));
            
            contaGroup = 0;	
	        
            foreach (IHPatternInstanceElement objele in trnInstance.Form.Items)		
	        {

		        if (objele is RowElement) {		
        			
			        RowElement row = (RowElement)objele;

                    ApplyRow(atts, row, Object, geraBC, sigla, settings, overwrite);
        			
		        }
        		
		        if (objele is TabFormElement) {
        		
			        TabFormElement tab = (TabFormElement)objele;
        			
			        if (tabBC == String.Empty || tab.Name == tabBC) {

                        TabItem tabit = Tab.getTabItem(tabs, tab);

                        atts.AppendLine(tabit.WebFormStart());
				        //atts.AppendLine("<tr><td>"+WebForm.BeginTable("Tab"+tab.Name, settings.Theme.TabTable));
        				
				        foreach (RowElement row in tab.Rows)		
				        {

                            ApplyRow(atts, row, Object, geraBC, sigla, settings, overwrite);
				        }

                        atts.AppendLine(tabit.WebFormEnd());
				        //atts.AppendLine(WebForm.EndTable()+"</td></tr>");		
			        }
        			
		        }

                if (objele is UserTableElement)
                {
                    AddUserTable((UserTableElement)objele, atts, wform, overwrite);
                }
	        }

            bool InstanceGrid = false;
            if (trnInstance is TransactionElement)
            {
                InstanceGrid = ((TransactionElement)trnInstance).InstanceGrid;
            }

            if (!geraBC && !InstanceGrid && transaction != null)
	        {
                
		        foreach (Artech.Common.Helpers.Structure.IStructureItem structureItem in transaction.Structure.Root.Items)
		        {
			        if (structureItem is TransactionLevel)
			        {
				        atts.AppendLine("<tr><td colspan='2'>");

				        TransactionLevel subLevel = structureItem as TransactionLevel;
				        bool hasMoreLevels = (subLevel.Levels.Count > 0);
				        if (hasMoreLevels)
				        {
        				
					        atts.AppendLine("<br/>");
					        atts.AppendLine(WebForm.BeginTable("Table" + (Counters["TableCounter"]++).ToString(), "Table95"));
					        atts.AppendLine("<tr><td class='SubTitle'>");
					        atts.AppendLine(WebForm.TextBlock("Title" + subLevel.Name, "", subLevel.Description));
					        atts.AppendLine("</td></tr>");
					        atts.AppendLine(WebForm.EndTable());
					        atts.AppendLine("<hr class='HRDefault' />");
					        atts.AppendLine("<gxFreeStyle border='1' freestyle='1' gxProp='ControlName=Grid"+(Counters["GridCounter"]++).ToString()+";class=FreeStyleGrid'>");
        					
					        atts.AppendLine(Heurys.Patterns.HPattern.Helpers.Template.InnerLevel(subLevel,Counters));
        					
					        atts.AppendLine("</gxFreeStyle>");

				        }
				        else
				        {
					        atts.AppendLine("<br/>");
					        atts.AppendLine(WebForm.BeginTable("Table" + (Counters["TableCounter"]++).ToString(), "Table95"));
					        atts.AppendLine("<tr><td class='SubTitle'>");
					        atts.AppendLine(WebForm.TextBlock("Title" + subLevel.Name, "", subLevel.Description));
					        atts.AppendLine("</td></tr>");
					        atts.AppendLine(WebForm.EndTable());
					        atts.AppendLine("<hr class='HRDefault' />");
        										
					        atts.AppendLine(Heurys.Patterns.HPattern.Helpers.Template.LeafLevel(subLevel,Counters));
        					

				        }
        				
				        atts.AppendLine("</td></tr>");
			        }
		        }	
	        }
        	
        	
	        atts.AppendLine(WebForm.EndTable());
            if (tabs != null)
            {
                atts.AppendLine(tabs.WebFormEnd());
            }
        	
	        sattributes = atts.ToString();
	        // fim dos atributos em tela

            foreach (ActionElement act in trnInstance.Actions)
            {
                string tclass = act.ButtonClass;
                if (String.IsNullOrEmpty(tclass))
                {
                    tclass = settings.Theme.Button;
                }
                sbuttonAction += Button(act.Name, act.Caption, tclass, String.Format("'{0}'", act.Name), "");
            }

            if (_webPanel == false)
            {
                sbuttonEnter = Heurys.Patterns.HPattern.Helpers.Template.Button("btn_enter", ((geraBC && Component) ? settings.Labels.SaveItem : "GX_BtnEnter"), settings.Theme.BtnEnter, ((geraBC && Component) ? "'SalvarItem'" : (geraBC ? "'Salvar'" : "Enter")), "");

                if (settings.Template.GenerateCallBackLink)
                {
                    sbuttonCancel = Heurys.Patterns.HPattern.Helpers.Template.Button("btn_cancel", "GX_BtnCancel", settings.Theme.BtnCancel, "'Fechar'" , "");
                }
                else
                {
                    sbuttonCancel = Heurys.Patterns.HPattern.Helpers.Template.Button("btn_cancel", ((geraBC && Component) ? settings.Labels.CloseItem : "GX_BtnCancel"), settings.Theme.BtnCancel, ((geraBC && Component) ? "'FecharItem'" : ((geraBC) ? "'Fechar'" : "Cancel")), "");
                }

                if (GenerateDelete)
                {
                    sbuttonDelete = Heurys.Patterns.HPattern.Helpers.Template.Button("btn_delete", "GX_BtnDelete", "BtnDelete", "Delete", "");
                }
            }

            if (settings.Template.ButtonHelp && !Component)
            {
                sbuttonHelp = Heurys.Patterns.HPattern.Helpers.Template.Button("BtnHelp", settings.Template.ButtonHelpCaption, settings.Template.ButtonHelpClass, "Help", "");
            }

            sfooter += MenuContext.get(trnInstance.Actions).WebForm();


	        if (stitle != String.Empty)
                gridWebForm.SetAttribute(SelTemplate.Title, stitle);
	        if (stitleimage != String.Empty)
		        gridWebForm.SetAttribute(SelTemplate.TitleImage,stitleimage);
	        if (sdescription != String.Empty)
		        gridWebForm.SetAttribute(SelTemplate.Description,sdescription);
	        if (stoolbar != String.Empty)
		        gridWebForm.SetAttribute(SelTemplate.Toolbar,stoolbar);
	        //if (serrorviewer != String.Empty)
		        //gridWebForm.SetAttribute(SelTemplate"errorviewer",serrorviewer);
	        if (sattributes != String.Empty)
		        gridWebForm.SetAttribute(SelTemplate.Attributes,sattributes);
	        if (sbuttonEnter != String.Empty)
		        gridWebForm.SetAttribute(SelTemplate.ButtonEnter,sbuttonEnter);
	        if (sbuttonCancel != String.Empty)
		        gridWebForm.SetAttribute(SelTemplate.ButtonCancel,sbuttonCancel);
	        if (sbuttonHelp != String.Empty)
		        gridWebForm.SetAttribute(SelTemplate.ButtonHelp,sbuttonHelp);
	        if (sbuttonDelete != String.Empty)
		        gridWebForm.SetAttribute(SelTemplate.ButtonDelete,sbuttonDelete);		
	        if (sfooter != String.Empty)
		        gridWebForm.SetAttribute(SelTemplate.Footer,sfooter);		
	        if (stabs != String.Empty)
		        gridWebForm.SetAttribute(SelTemplate.Tabs,stabs);
            if (sbuttonAction != String.Empty)
                gridWebForm.SetAttribute(SelTemplate.ButtonAction, sbuttonAction);
        		
        		
	        string tsaida = "";
	        try {
		        tsaida = gridWebForm.ToString();
	        } catch(System.Exception e) {
		        tsaida = "";
		        System.Windows.Forms.MessageBox.Show("Error processing the Transaction Template:" + Environment.NewLine + e.Message + Environment.NewLine + e.StackTrace);

	        }		
        	
	        if (settings.Template.TransactionTemplateDebug != String.Empty) {

		        System.IO.StreamWriter file2 = new System.IO.StreamWriter(settings.Template.TransactionTemplateDebug);
		        file2.WriteLine(tsaida);
		        file2.Close();
        		
	        }	
        		
	

            //if (!Component) { ret.AppendLine("<body>");}
            ret.AppendLine(tsaida);
            //if (!Component) { ret.AppendLine("</body>");}

	        if (Messages.Debug())
	        {
		        CommonServices.Output.AddLine(String.Format(">>> TrnDefaultWebForm End {0}",DateTime.Now.ToString()));
	        }

            return ret.ToString();
        }

        private static IBaseCollection<RowElement> GetRowsAllTabs(IBaseCollection<TabFormElement> tabs, TransactionElement trni)
        {
            IBaseCollection<RowElement> rows = new BaseCollection<RowElement>();
            if (tabs != null)
            {
                foreach (TabFormElement tabe in tabs)
                {
                    foreach (RowElement row in tabe.Rows)
                        rows.Add(row);                    
                }
            }
            return rows;
        }

        private static void GetRowsGridPP(IBaseCollection<RowElement> rows, IBaseCollection<AttributeElement> atts, RowElement baserow, ColumnElement basecol,IHPatternInstanceElement trni)
        {
            RowElement row = baserow.Clone();
            row.Parent = trni;
            row.Columns.Clear();
            
            ColumnElement col = basecol.Clone();
            col.Items.Clear();

            foreach (AttributeElement att in atts)
            {
                col.Items.Add(att);
            }

            row.Columns.Add(col);
            rows.Add(row);
        }

        private static void GetRowsGridFreeStylePP(IBaseCollection<RowElement> rows, GridFreeStyleElement grid, RowElement baserow, ColumnElement basecol, IHPatternInstanceElement trni)
        {
            GetRowsGridPP(rows, grid.Attributes, baserow, basecol, grid);
            foreach (GridFreeStyleElement grid2 in grid.GridFreeStyles)
            {
                GetRowsGridFreeStylePP(rows, grid2, baserow, basecol, grid2);
            }
            foreach (GridStandardElement grid2 in grid.GridStandards)
            {
                GetRowsGridPP(rows, grid2.Attributes.Attributes, baserow, basecol, grid2);
            }

        }


        private static void GetRowsAllTabsPP(IBaseCollection<RowElement> rows, RowElement row, bool GridFreeStyle, bool GridStandard, IHPatternInstanceElement trni)
        {
            // GetRowsAllTabs++ a revolta das Rows, a continuação :D
            rows.Add(row);
            foreach (ColumnElement col in row.Columns)
            {
                foreach (GroupElement grp in col.Groups)
                {
                    foreach (RowElement row2 in grp.Rows)
                    {
                        GetRowsAllTabsPP(rows, row2,GridFreeStyle, GridStandard,trni);
                    }
                }
                if (GridFreeStyle)
                {
                    foreach (GridFreeStyleElement grid in col.GridFreeStyles)
                    {
                        GetRowsGridFreeStylePP(rows, grid, row, col, grid);                        
                    }
                }
                if (GridStandard)
                {
                    foreach (GridStandardElement grid in col.GridStandards)
                    {
                        GetRowsGridPP(rows, grid.Attributes.Attributes, row, col, grid);
                    }
                }
            }
        }

        private static IBaseCollection<RowElement> GetRowsPP(WebObject trn, string tab, bool GridFreeStyle, bool GridStandard, WebObject trni)
        {
            // GetRows++ a revolta dos Rows :)
            IBaseCollection<RowElement> rows = new BaseCollection<RowElement>();
            if (String.IsNullOrEmpty(tab))
            {
                foreach (IHPatternInstanceElement i in trn.Form.Items)
                {
                    if (i is RowElement)
                    {
                        RowElement row = (RowElement)i;
                        GetRowsAllTabsPP(rows, row, GridFreeStyle, GridStandard, trni);
                    }
                    if (i is TabFormElement)
                    {
                        TabFormElement tabe = (TabFormElement)i;
                        foreach (RowElement row in tabe.Rows)
                        {
                            GetRowsAllTabsPP(rows, row, GridFreeStyle, GridStandard, trni);
                        }
                    }
                }
            }
            else
            {
                foreach (TabFormElement tabe in trn.Form.Tabs)
                {
                    if (tabe.Name == tab)
                    {
                        foreach (RowElement row in tabe.Rows)
                        {
                            GetRowsAllTabsPP(rows, row, GridFreeStyle, GridStandard, trni);
                        }
                    }
                }
                if (rows.Count == 0)
                {
                    if (trn.Form.Rows == null)
                    {
                        foreach (TabFormElement tabe in trn.Form.Tabs)
                        {
                            foreach (RowElement row in tabe.Rows)
                            {
                                GetRowsAllTabsPP(rows, row, GridFreeStyle, GridStandard, trni);
                            }
                        }
                    }
                    else
                    {
                        if (trn.Form.Rows.Count > 0)
                        {
                            foreach (RowElement row in trn.Form.Rows)
                            {
                                GetRowsAllTabsPP(rows, row, GridFreeStyle, GridStandard, trni);
                            }
                        }
                        else
                        {
                            foreach (TabFormElement tabe in trn.Form.Tabs)
                            {
                                foreach (RowElement row in tabe.Rows)
                                {
                                    GetRowsAllTabsPP(rows, row, GridFreeStyle, GridStandard, trni);
                                }
                            }
                        }
                    }
                }
            }
            return rows;

        }

        public static IBaseCollection<RowElement> GetRows(WebObject trn, string tab,bool GridFreeStyle,bool GridStandard)
        {
            return GetRowsPP(trn, tab, GridFreeStyle,GridStandard,trn);
        }

        public static IBaseCollection<RowElement> GetRows(WebObject trn, string tab)
        {
            return GetRows(trn,tab,false,false);
        }

        public static string HMaskEventStart(WebObject trn, string tab)
        {
            return HMaskEventStart(trn, tab, true);
        }

        public static string HMaskEventStart(WebObject trn, string tab, bool bc)
        {
            StringBuilder ret = new StringBuilder();
            Artech.Common.Collections.IBaseCollection<RowElement> rows = GetRows(trn, tab);

            foreach (RowElement row in rows)
            {
                foreach (ColumnElement col in row.Columns)
                {
                    foreach (IHPatternInstanceElement item in col.Items)
                    {
                        if (item is AttributeElement)
                        {
                            AttributeElement att = (AttributeElement)item;
                            if (!String.IsNullOrEmpty(att.MaskPicture))
                            {
                                ret.AppendLine(String.Format("{0}HMask.AttachControl = {1}{0}.InternalName", att.AttributeName,(bc ? "ctl":"")));
                            }
                        }
                        if (item is VariableElement)
                        {
                            VariableElement att = (VariableElement)item;
                            if (!String.IsNullOrEmpty(att.MaskPicture))
                            {
                                ret.AppendLine(String.Format("{0}HMask.AttachControl = &{0}.InternalName", att.Name));
                            }
                        }
                    }
                }
            }

            return ret.ToString();

        }

        public static string HMaskEventSave(WebObject trn, string tab, string sdtname)
        {
            StringBuilder ret = new StringBuilder();
            Artech.Common.Collections.IBaseCollection<RowElement> rows = GetRows(trn, tab);

            foreach (RowElement row in rows)
            {
                foreach (ColumnElement col in row.Columns)
                {
                    foreach (IHPatternInstanceElement item in col.Items)
                    {
                        if (item is AttributeElement)
                        {
                            AttributeElement att = (AttributeElement)item;
                            if (att.UnmaskedValue && !String.IsNullOrEmpty(att.MaskPicture))
                            {
                                if (att.Attribute.Type == eDBType.CHARACTER || att.Attribute.Type == eDBType.VARCHAR || att.Attribute.Type == eDBType.LONGVARCHAR)
                                {
                                    ret.AppendLine(String.Format("&{1}.{0} = {0}HMask.GetValue", att.AttributeName,sdtname));
                                }
                            }
                        }
                        if (item is VariableElement)
                        {
                            VariableElement att = (VariableElement)item;
                            if (att.UnmaskedValue && !String.IsNullOrEmpty(att.MaskPicture))
                            {
                                if (att.Type == eDBType.CHARACTER || att.Type == eDBType.VARCHAR || att.Type == eDBType.LONGVARCHAR)
                                {
                                    ret.AppendLine(String.Format("&{0} = {0}HMask.GetValue", att.Name));
                                }
                            }
                        }
                    }
                }
            }

            return ret.ToString();

        }

        public static string HMaskRuleSave(WebObject trn, string tab, string sdtname)
        {
            StringBuilder ret = new StringBuilder();
            Artech.Common.Collections.IBaseCollection<RowElement> rows = GetRows(trn, tab);

            foreach (RowElement row in rows)
            {
                foreach (ColumnElement col in row.Columns)
                {
                    foreach (IHPatternInstanceElement item in col.Items)
                    {
                        if (item is AttributeElement)
                        {
                            AttributeElement att = (AttributeElement)item;
                            if (att.UnmaskedValue && !String.IsNullOrEmpty(att.MaskPicture))
                            {
                                if (att.Attribute.Type == eDBType.CHARACTER || att.Attribute.Type == eDBType.VARCHAR || att.Attribute.Type == eDBType.LONGVARCHAR)
                                {
                                    ret.AppendLine(String.Format("HMask2UnmaskedValue.Call({0},'{1}',{0}) On BeforeValidate;", att.AttributeName, att.UnmaskedChars));
                                }
                            }
                        }
                        if (item is VariableElement)
                        {
                            VariableElement att = (VariableElement)item;
                            if (att.UnmaskedValue && !String.IsNullOrEmpty(att.MaskPicture))
                            {
                                if (att.Type == eDBType.CHARACTER || att.Type == eDBType.VARCHAR || att.Type == eDBType.LONGVARCHAR)
                                {
                                    ret.AppendLine(String.Format("HMask2UnmaskedValue.Call(&{0},'{1}',&{0}) On BeforeValidate;", att.Name, att.UnmaskedChars));
                                }
                            }
                        }
                    }
                }
            }

            return ret.ToString();

        }

        public static string TransactionActions(WebObject trn)
        {            
            StringBuilder ret = new StringBuilder();
            foreach (ActionElement act in trn.Actions)
            {
                ret.AppendLine(String.Format("Event '{0}'",act.Name));
                ret.AppendLine(Indentation.Indent(act.EventCode,1));
                ret.AppendLine("EndEvent");
                ret.AppendLine("");
            }
            if (trn.Instance.Settings.Template.GenerateCallBackLink)
            {
                ret.AppendLine(String.Format("Event '{0}'", "Fechar"));
                ret.AppendLine(Indentation.Indent(String.Format("If &{0}.IsEmpty()",HPatternInstance.PARMCALLBACK), 1));
                ret.AppendLine(Indentation.Indent("Return", 2));
                ret.AppendLine(Indentation.Indent("Else", 1));
                ret.AppendLine(Indentation.Indent(String.Format("PrLinkCallBack(&{0})", HPatternInstance.PARMCALLBACK), 2));
                ret.AppendLine(Indentation.Indent("EndIf", 1));
                ret.AppendLine("EndEvent");
                ret.AppendLine("");
            }
            return ret.ToString();
        }


        #endregion

        #region WebPanel

        public static string GridWebForm(Artech.Architecture.Common.Objects.KBObject Object, Artech.Architecture.Common.Objects.KBObjectPart Part, Heurys.Patterns.HPattern.HPatternInstance Instance, Heurys.Patterns.HPattern.IGridObject GridObject)
        {
                return GridWebForm2(Object, Part, Instance, GridObject);

        }

        private static string GetImageDeleteFilter(Artech.Architecture.Common.Objects.KBModel model)
        {
            string ret = null;
            Image i = null;
            i = Image.Get(model, "ActionDelete");
            if (i != null) ret = i.Name;
            return ret;
        }


        private static string GridWebForm2(Artech.Architecture.Common.Objects.KBObject Object,Artech.Architecture.Common.Objects.KBObjectPart Part,Heurys.Patterns.HPattern.HPatternInstance Instance,Heurys.Patterns.HPattern.IGridObject GridObject)
        {
            //modMain.SetGXPath(Artech.Common.Helpers.IO.PathHelper.StartupPath);
            //HPatternBuildProcess.GetLic().CheckC();

            string objtype = TabElement.ObjTypeValue.All;

            StringBuilder ret = new StringBuilder();
            HPatternSettings settings = Instance.Settings;
            sett = settings;


            bool geraBC = false;
            string codeTab = "";
            Transaction transaction = null;
            TransactionElement trnInstance = null;
            bool disabledTabs = false;
            if (GridObject is TabElement) {

	            TabElement tabe = (TabElement)GridObject;
                objtype = tabe.ObjType;
	            codeTab = tabe.Code;
	            transaction = tabe.Transaction.Transaction;
	            trnInstance = tabe.Transaction;

                geraBC = Instance.Transaction.WebBC;
                /*
	            geraBC = settings.Template.DataEntryWebPanelBC;
	            if (Instance.Transaction.DataEntryWebPanelBC.ToLower() == "true")
		            geraBC = true;
	            if (Instance.Transaction.DataEntryWebPanelBC.ToLower() == "false")
		            geraBC = false;
            	*/
	
	            if (geraBC) disabledTabs = tabe.Parent.DisabledTabs;		
            }

            if (GridObject is SelectionElement) {
	            transaction = Instance.Transaction.Transaction;
            }


            string ident = "";

            if (transaction != null)
            {
                if (GridObject is SelectionElement)
                {
                    ident = (GridObject as SelectionElement).Identifier;
                }
            }
                        	
            //Filter filter = null;
            string texto = "";
            
            string stitle = "";
            string stitleimage = "";
            string sdescription = "";
            ArrayList filters = new ArrayList();
            string sfilterRows = "";
            string sfilterButtons = "";
            string serrorviewer = WebForm.ErrorViewer("ErrorV1","ErrorViewer");
            string sgridPaging = "";
            string sgridPagingFirst = "";
            string sgridPagingPrevious = "";
            string sgridPagingNext = "";
            string sgridPagingLast = "";
            string sgridExport = "";
            string scurrentpage = "";
            string smaxpage = "";
            string sMaxRecords = "";
            string sRecordPage = "";
            string sCheckAll = "";
            string sSelectedRecords = "";
            string sgridButtons = "";
            string sgrid = "";
            string sfooterButtons = "";
            string sfooter = "";
            string sfiltercollapseimage = "";
            string stabs = "";
            string stransaction = "";

            if (objtype == TabElement.ObjTypeValue.Trn)
            {
                ret.AppendLine(String.Format("<Part type=\"{0}\">", PartType.WebForm));
                    ret.AppendLine("<Source><![CDATA[");
                            stransaction = Heurys.Patterns.HPattern.Helpers.Template.TrnWebForm(transaction, settings, Instance, true, "", true, trnInstance);
                            ret.AppendLine(stransaction);
                    ret.AppendLine("]]></Source>");
                ret.AppendLine("</Part>");
                return ret.ToString();
            }

            HTemplate gridWebForm = null; GetTemplate(settings, 2);
            if (GridObject is PromptElement)
            {
                gridWebForm = GetTemplate(settings,ObjTemplate.PromptTemplate);
            }
            if (gridWebForm == null)
                gridWebForm = GetTemplate(settings, 2);


            	
	            bool geraDF = false;
                int ch = 0;
                try
                {
                    ch = settings.DynamicFilters.MaxChoices;
                    if (GridObject.Filter != null)
                    {
                        if (GridObject.Filter.Dynamicfilters != null)
                        {
                            geraDF = (GridObject.Filter.Dynamicfilters.Count > 0 && ch > 0) ? true : false;
                        }
                    }
                }
                catch (Exception e) {
                    System.Diagnostics.Debug.WriteLine(e.Message + e.StackTrace);
                }

                bool collapse = GridObject.GetFilterCollapse; //false;

                bool loadOnStart = GridObject.GetLoadOnStart; // true;
                bool requiredFilter = GridObject.GetRequiredFilter; // false;	
	            string requiredFilterMessage = settings.Grid.RequiredFilterMessage;
            	
           	
	            if (GridObject is PromptElement)
	            {
		            PromptElement pe = (PromptElement)GridObject;
        			

		            try {
			            if (pe.RequiredFilterMessage.ToLower() != "<default>")
				            requiredFilterMessage = pe.RequiredFilterMessage;			
            			
		            } catch(System.Exception e) {
                        System.Diagnostics.Debug.WriteLine(e.Message + e.StackTrace);
                    }
            		
	            }		
	            if (GridObject is SelectionElement)
	            {
		            SelectionElement pe = (SelectionElement)GridObject;
            	
		            try {
			            if (pe.RequiredFilterMessage.ToLower() != "<default>")
				            requiredFilterMessage = pe.RequiredFilterMessage;			
            			
		            } catch(System.Exception e) {
                        System.Diagnostics.Debug.WriteLine(e.Message + e.StackTrace);
                    }
            		
	            }	
            	
	            if (geraBC && objtype != TabElement.ObjTypeValue.Trn)
	            {
		            Dictionary<string, Object> tabprops = new Dictionary<string, Object>();
		            tabprops.Add("MenuData","&amp;MenuData");
		            tabprops.Add("SelectedItem","&amp;MenuDataItem");
		            stabs = WebFormHelper.BeginControl("DolphinStyleMenu","Tabs",tabprops)+WebFormHelper.EndControl("DolphinStyleMenu");
                }

                if (geraBC && objtype == TabElement.ObjTypeValue.All)
                {
                    stransaction = WebForm.BeginTable("tabelaItem", "Table")+"<tr><td>";            	
		            stransaction +=Heurys.Patterns.HPattern.Helpers.Template.TrnWebForm(transaction,settings,Instance,true,"",true,trnInstance);            		
		            stransaction += "</td></tr>"+WebForm.EndTable();            		
	            }	
            	
           	
	            if (collapse && !((GridObject.Filter != null && (GridObject.Filter.FilterAttributes.Count > 0 || geraDF)) || GridObject.Orders.NeedsChoice)) {
		            collapse = false;
	            }
            			
            	
           		
	            bool actionsModes = true;
	            //if (!(GridObject is PromptElement)) {
		        //    actionsModes = true;
	            //}
            				
	            // Dummy vars
	            bool needCurrentPage = false;

                if (!settings.Grid.PagingButtons(GridObject))
                {
		            needCurrentPage = true;
	            }
            	
	            if (GridObject.Description != String.Empty)
	            {		
		            sdescription = GridObject.Description;
            		
		            if (settings.Template.TitleImage != null) {
			            stitleimage = WebForm.Image("ImgTitleS",settings.Theme.Image,settings.Template.TitleImage.Name);
		                stitle = WebForm.TextBlock("TitleTextS", settings.Template.TitleTextClass, GridObject.Description);
		            } else {
			            stitle = WebForm.TextBlock("TitleTextS", settings.Template.TitleTextClass, GridObject.Description) ;
		            }
            		
	            }


	            if ((GridObject.Filter != null && (GridObject.Filter.FilterAttributes.Count > 0 || geraDF)) || GridObject.Orders.NeedsChoice)
	            {

		            if (GridObject.Orders.Count > 1)		
		            {
            		
                        texto = String.Format(settings.DefaultFilters.DefaultTemplateFilter,
                            WebForm.TextBlock("OrderedText", settings.Theme.PlainText, settings.Labels.OrderedBy),
                            WebForm.Variable(OrdersElement.OrderVariable));
			            filters.Add(new Filter(texto));
            			
		            }
            		
	            try {		
		            if (geraDF) {
			            Dictionary<string, object> properties = new Dictionary<string, object>();
			            properties[Properties.ATT.ControlType] = Properties.ATT.ControlType_Values.ComboBox;
			            string valores = "GX_EmptyItemText:";
			            foreach (AttributeElement ta in GridObject.Filter.Dynamicfilters) {
				            if (ta.Attribute.Type == eDBType.CHARACTER || ta.Attribute.Type == eDBType.VARCHAR || ta.Attribute.Type == eDBType.NUMERIC || ta.Attribute.Type == eDBType.DATE) {
					            valores += ","+ta.Description+":"+ta.AttributeName;
				            }
			            }
			            properties[Properties.ATT.Values] = valores; 	
            			
			            Dictionary<string, object> properties2 = new Dictionary<string, object>();
			            properties2[Properties.ATT.ControlType] = Properties.ATT.ControlType_Values.ComboBox;
			            string valores2 = "GX_EmptyItemText:";
			            foreach (SettingsFilterElement sfe in settings.DynamicFilters.Filters) {
				            valores2 += ","+sfe.Description+":"+sfe.Name;
			            }		
            	
			            properties2[Properties.ATT.Values] = valores2; 			
            				
			            string imagem = null;
			            if (settings.DynamicFilters.RemoveFilterImage != null) {
				            imagem = settings.DynamicFilters.RemoveFilterImage.Name;
			            }
                        if (imagem == null)
                        {
                            imagem = GetImageDeleteFilter(settings.Model);
                        }
            					
			            for (int i = 1;i<=ch;i++) {

                            texto = String.Format(settings.DynamicFilters.TemplateFilter,
                                WebForm.Variable("Campo" + i.ToString().Trim(), "Attribute", null, properties),
                                WebForm.Variable("CondD" + i.ToString().Trim(), "Attribute", null, properties2),
                                WebForm.Variable("Carac" + i.ToString().Trim()) +
                                WebForm.Variable("Numer" + i.ToString().Trim()) +
                                WebForm.Variable("DataD" + i.ToString().Trim()),
                                WebForm.Image("excluiD" + i.ToString().Trim(), settings.Theme.Image, imagem, null, settings.DynamicFilters.RemoveFilterImageTooltip),
                                "ContainerCampo" + i.ToString().Trim());
				            filters.Add(new Filter(texto));				

			            }
		            }
            		
	            } catch(System.Exception e) {		
		            System.Windows.Forms.MessageBox.Show("Erro web: " + e.Message + Environment.NewLine + e.StackTrace);                   
	            }

		            if (GridObject.Filter != null)
		            {
			            foreach (FilterAttributeElement filterVar in GridObject.Filter.Attributes.FilterAttributes)
			            {
				            // ControlInfo fvControlInfo = new ControlInfo(filterVar);

                            string ftb1 = WebForm.TextBlock("FilterText" + filterVar.Name, settings.Theme.PlainText, filterVar.Description);
                            string fvar1 = "";
                            if (filterVar.AllValue)
                            {
                                Dictionary<string, object> props = new Dictionary<string, object>();
                                GetControlInfo(filterVar, props, true);
                                fvar1= WebForm.Variable(filterVar.Name, null, null, props);
                            }
                            else
                            {
                                Dictionary<string, object> props = new Dictionary<string, object>();
                                GetControlSize(filterVar, props);
                                fvar1= WebForm.Variable(filterVar.Name, null, null, props);
                            }

                            string flink = "";
                            if (filterVar.Link != null)
                            {
                                StringBuilder textob = new StringBuilder();
                                LinkImage(textob, filterVar.Link, filterVar.Name, settings);
                                flink = textob.ToString();
                            }

                            if (filterVar.FilterType == FilterAttributeElement.FilterTypeValue.Interval)
                            {

                                var ftb2 = WebForm.TextBlock("FilterText" + filterVar.Name + "2", settings.Theme.PlainText, settings.Grid.FilterIntervalText);
                                string fvar2 = "";
                                if (filterVar.AllValue)
                                {
                                    Dictionary<string, object> props = new Dictionary<string, object>();
                                    GetControlInfo(filterVar, props, true);
                                    fvar2 = WebForm.Variable(filterVar.Name + "2", null, null, props);
                                }
                                else
                                {
                                    Dictionary<string, object> props = new Dictionary<string, object>();
                                    GetControlSize(filterVar, props);
                                    fvar2 = WebForm.Variable(filterVar.Name + "2", null, null, props);
                                }

                                texto = String.Format(settings.DefaultFilters.IntervalTemplateFilter,
                                    ftb1,
                                    fvar1,
                                    ftb2,
                                    fvar2 + flink);
                            }
                            else
                            {
                                texto = String.Format(settings.DefaultFilters.DefaultTemplateFilter,
                                    ftb1,
                                    fvar1 + flink);
                            }
					        
                            filters.Add(new Filter(texto));	
            			
			            }

                        // Agora vamos fazer os filterRows

                        if (GridObject.Filter.Attributes != null ) 
                        {
                            StringBuilder rows = new StringBuilder();

                            TemplateInternal.ZeraContaGroup();

                            foreach (FRowElement row in GridObject.Filter.Attributes.Rows)
                            {
                                TemplateInternal.AddFilterRow(row, rows,settings);
                            }

                            sfilterRows = rows.ToString();
                        }


		            }           		

		            if (settings.Grid.SearchButton || settings.Grid.ClearButton) {
			            if (settings.Grid.SearchButton) {
                            string evento = "'Search'";
                            if (GridObject is PromptElement && settings.Template.PromptSearchEvent == SettingsTemplateElement.PromptSearchEventValue.Enter) evento = "Enter";
                            sfilterButtons += WebForm.Button("SearchButton", (String.IsNullOrEmpty(settings.Theme.SearchButton) ? settings.Theme.Button : settings.Theme.SearchButton), settings.Grid.SearchCaption, evento);
			            }
			            if (settings.Grid.ClearButton) {
                            sfilterButtons += WebForm.Button("ClearButton", (String.IsNullOrEmpty(settings.Theme.ClearButton) ? settings.Theme.Button : settings.Theme.ClearButton), settings.Grid.ClearCaption, "'ClearButton'");
			            }
		            }	
	            }

            bool insexp = true;
            if (actionsModes) {
	            insexp = GridObject.Actions.Insert != null || GridObject.Actions.Export != null;
            }
            	
	            if (needCurrentPage || insexp)
	            {
                    if (!settings.Grid.PagingButtons(GridObject))
                    {
			            sgridPagingFirst = settings.Grid.ImageFirst == null ? "" : WebForm.Image("bFirst",settings.Theme.Image,settings.Grid.ImageFirst.Name,"",settings.Grid.TooltipFirst);					
			            sgridPagingPrevious = settings.Grid.ImagePrevious == null ? "" : WebForm.Image("bPrevious",settings.Theme.Image,settings.Grid.ImagePrevious.Name,"",settings.Grid.TooltipPrevious);
			            sgridPagingNext = settings.Grid.ImageNext == null ? "" : WebForm.Image("bNext",settings.Theme.Image,settings.Grid.ImageNext.Name,"",settings.Grid.TooltipNext);
			            sgridPagingLast = settings.Grid.ImageLast == null ? "" : WebForm.Image("bLast",settings.Theme.Image,settings.Grid.ImageLast.Name,"",settings.Grid.TooltipLast);
			            sgridPaging += sgridPagingFirst+sgridPagingPrevious+sgridPagingNext+sgridPagingLast;
		             }						

		            if (needCurrentPage)
		            {
		                Dictionary<string, object> propertiesv = new Dictionary<string, object>();
			            //sgridPaging += WebForm.Variable("CurrentPage");
                        if (GridObject.CurrentCombo)
                        {
                            propertiesv[Properties.ATT.ControlType] = Properties.ATT.ControlType_Values.ComboBox;
                        }
                        else
                        {
                            propertiesv[Properties.HTMLATT.ReadOnly] = true;
                        }
			            scurrentpage = WebForm.Variable("CurrentPage",settings.Grid.PagingVariableClass,null,propertiesv);
			            sgridPaging += scurrentpage;

                        if (settings.Grid.GetMaxPage(GridObject))
                        {
            			
				            Dictionary<string, object> propertiesm = new Dictionary<string, object>();
				            propertiesm[Properties.HTMLATT.ReadOnly] = true;
				            //sgridPaging += WebForm.Variable("CurrentPage");
				            smaxpage = WebForm.Variable("MaxPage",settings.Grid.PagingVariableClass,null,propertiesm);	
            			
			            }

                        if (settings.Grid.MaxRecords)
                        {
                            Dictionary<string, object> propertiesm = new Dictionary<string, object>();
                            propertiesm[Properties.HTMLATT.ReadOnly] = true;
                            sMaxRecords = WebForm.Variable("MaxRecords", settings.Grid.PagingVariableClass, null, propertiesm);
                        }


                        if (settings.Grid.PageRecordsCombo)
                        {
                            sRecordPage = WebForm.Variable("RecordPage", settings.Grid.PagingVariableClass);
                        }

		            }

	                if (actionsModes) {
		                if (GridObject.Actions.Export != null)
		                {
                		
			                sgridExport = GridObject.Actions.Export.ToHtml();
			                sgridPaging += sgridExport;
		                }

                        foreach (ActionElement action in GridObject.Actions.StandaloneCustomActionsGrid)
                        {
                            if (settings.Template.ButtonHelpApplySelection || action.Name != "Help" || !(GridObject is SelectionElement))
                            {
                                sgridButtons += action.ToHtml();
                            }
                        }
                		   		
		                if (GridObject.Actions.Insert != null)
		                {
			                 sgridButtons += GridObject.Actions.Insert.ToHtml(); 
		                }
	                }

	            }
             string condls = null;
             if (!loadOnStart) {
	            condls = "&loadStart = 2;";
             }
             Properties.HTMLSFL.BackColorStyle_Enum bcs = Properties.HTMLSFL.BackColorStyle_Enum.Report;
             if (settings.Grid.BackColorStyle == "None")
	            bcs = Properties.HTMLSFL.BackColorStyle_Enum.None;
             if (settings.Grid.BackColorStyle == "Uniform")
	            bcs = Properties.HTMLSFL.BackColorStyle_Enum.Uniform;
             if (settings.Grid.BackColorStyle == "Header")
	            bcs = Properties.HTMLSFL.BackColorStyle_Enum.Header;		
             
            Dictionary<string, object> propertiesg = new Dictionary<string, object>();
            propertiesg[Properties.HTMLSFL.Rules] = Properties.HTMLSFL.Rules_Values.All;

            if (settings.Grid.Rules == "None")
	            propertiesg[Properties.HTMLSFL.Rules] = Properties.HTMLSFL.Rules_Values.None;
            if (settings.Grid.Rules == "Columns")
	            propertiesg[Properties.HTMLSFL.Rules] = Properties.HTMLSFL.Rules_Values.Columns;
            if (settings.Grid.Rules == "Rows")
	            propertiesg[Properties.HTMLSFL.Rules] = Properties.HTMLSFL.Rules_Values.Rows;

            if (!GridObject.GetAutoResize)
            {
                propertiesg[Properties.HTMLSFL.AutoResize] = false;
                propertiesg[Properties.HTMLSFL.Width] = getSize(GridObject.GetWidth);
                propertiesg[Properties.HTMLSFL.Height] = getSize(GridObject.GetHeight);
            }

            if (GridObject.GetAllowSelection)
            {
                propertiesg[Properties.HTMLSFL.AllowSelection] = true;
            }

            // Grid Custom Render
            if (!String.IsNullOrEmpty(GridObject.GetCustomRender))
            {
                propertiesg[Artech.Genexus.Common.Properties.HTMLSFL.CustomRender] = GridObject.GetCustomRender;
                foreach (GridPropertieElement prop in TemplateGrid.MergeGridProperties(GridObject.GridProperties, settings))
                {
                    TemplateGrid.DefProperty(propertiesg, GridObject.GetCustomRender, prop);
                    
                }
            }
 
             
            if (GridObject.GridType == SettingsGridElement.GridTypeValue.Standard) {
             

                sgrid += WebForm.BeginGrid(GridName, settings.Theme.Grid, condls, GridObject.Orders.Condition, null, bcs, settings.Grid.CellSpacing, settings.Grid.CellPadding, propertiesg);

                // grid Actions
                if (settings.Grid.GridStandardActionOrientation == SettingsGridElement.GridStandardActionOrientationValue.Left)
                {
                    sgrid += GridActions(GridObject, actionsModes, geraBC, settings);
                }

	            // Then, grid attributes and variables.
                bool primeiro = true;
	            foreach (IAttributesItem gridItem in GridObject.Attributes)
	            {
		            if (geraBC) 
		            {
			            sgrid += GridColumnBC(gridItem);	
		            } 
		            else 
		            {
			            if (GridObject is PromptElement) {
                            if (settings.Template.ApplyReturnOnClickAll)
                            {
                                sgrid += GridColumnPrompt(gridItem);
                            }
                            else
                            {
                                sgrid += GridColumnPrompt(gridItem, primeiro);
                                primeiro = false;
                            }
			            } else {
				            sgrid += GridColumn(gridItem);
			            }	
		            }
	            }

                if (settings.Grid.GridStandardActionOrientation == SettingsGridElement.GridStandardActionOrientationValue.Right)
                {
                    sgrid += GridActions(GridObject, actionsModes, geraBC, settings);
                }
            	
	            sgrid += WebForm.EndGrid(); 
            }
            else
            {
                string dotnet = "";

                try
                {
                    GxModel model = settings.Model.KB.DesignModel.Environment.TargetModel.GetAs<GxModel>();
                    if (model.Environment.Generator == 15) // Artech.Genexus.Common.Entities.GeneratorType.CSharpWeb
                    {
                        dotnet = ".aspx";
                    }
                }
                catch (Exception e)
                {
                    LogLicense.LogEmpty(e.Message);
                }


	            Dictionary<string, Object> gridprops = new Dictionary<string, Object>();
	            gridprops.Add("AnimateCollapse",settings.Grid.AnimateCollapse);
	            gridprops.Add("PageSize",settings.Grid.PageSize);
	            gridprops.Add("AutoWidth",settings.Grid.AutoWidth);
                gridprops.Add("AutoHeight", false); // Contorno para problema com Scrool no Chrome
	            gridprops.Add("ForceFit",settings.Grid.ForceFit);
	            gridprops.Add("Width",settings.Grid.Width);
	            gridprops.Add("Height",settings.Grid.Height);
	            gridprops.Add("RemoteSort",settings.Grid.RemoteSort);
	            gridprops.Add("FiltersText",settings.Grid.FiltersText);
	            gridprops.Add("FirstText",settings.Grid.FirstText);
	            gridprops.Add("PreviousText",settings.Grid.PreviousText);
	            gridprops.Add("NextText",settings.Grid.NextText);
	            gridprops.Add("LastText",settings.Grid.LastText);
	            gridprops.Add("RefreshText",settings.Grid.RefreshText);
	            gridprops.Add("BeforePageText",settings.Grid.BeforePageText);
	            gridprops.Add("AfterPageText",settings.Grid.AfterPageText);
	            gridprops.Add("DisplayMsg",settings.Grid.DisplayMsg);
	            gridprops.Add("EmptyMsg",settings.Grid.EmptyMsg);
	            gridprops.Add("LoadingMsg",settings.Grid.LoadingMsg);
	            gridprops.Add("DataStoreURL",String.Format("aprocgrid{0}{1}",transaction.Name.ToLower(),dotnet));
	            gridprops.Add("ToolbarData","&amp;gxuiToolbar");
	            gridprops.Add("Identifier",ident);
	            gridprops.Add("ColumnModel","&amp;gxuiGridColumnModel");
                if (settings.Grid.TitleVisible)
                {
                    gridprops.Add("Title", GridObject.Description);
                }
	            gridprops.Add("SelectedRowData","&amp;SelectedRow");
	            gridprops.Add("Record","SDT"+transaction.Name+"Grid");
	            gridprops.Add("Data","&amp;SDT"+transaction.Name+"Grid");
                gridprops.Add("MinColumnWidth", settings.Grid.MinColumnWidth);
	            sgrid += WebFormHelper.BeginControl("gxui.Grid","gxuiSDTGrid",gridprops)+WebFormHelper.EndControl("gxui.Grid");
            }	
             
            bool insexp2 = true;
            if (actionsModes) {
	            insexp2 = GridObject.Actions.Insert != null || GridObject.Actions.Export != null;
            }

            if (geraBC)
            {
                sfooterButtons += WebForm.Button("Savar",settings.Theme.BtnEnter , "GX_BtnEnter", "'Salvar'");
                sfooterButtons += WebForm.Button("btncancel", settings.Theme.BtnCancel, "GX_BtnCancel", "'Fechar'");
            }

            if (actionsModes) {
	            if (GridObject.Actions.Count > 0)
	            {

		            foreach (ActionElement action in GridObject.Actions.StandaloneCustomActions)
		            {
                        if (settings.Template.ButtonHelpApplySelection || action.Name != "Help" || !(GridObject is SelectionElement))
                        {
                            sfooterButtons += action.ToHtml(); 
                        }
		            }

	            }
            }	


	            if (!(GridObject is TabElement))
	            {
		            foreach (ParameterElement parameter in GridObject.Parameters)
		            {
			            if (!Variables.IsVariableName(parameter.Name) && GridObject.Attributes.FindAttribute(parameter.Name) == null && parameter.Domain == null)
			            {
				            // Always use edits (they are hidden).
				            sfooter += HiddenAttribute(parameter.Name); 
			            }
		            }
	            }

                if (GridObject is SelectionElement && settings.Template.GenerateCallBackLink)
                {
                    sfooter += WebForm.Variable(HPatternInstance.PARMCALLBACK); 
                }

            try {
	            if (geraDF) {
		            Dictionary<string, object> prop = new Dictionary<string, object>();
		            prop[Properties.HTMLATT.Format] = Properties.HTMLATT.Format_Values.RawHtml;
		            sfooter += WebForm.TextBlock("js","","js",prop);
		            sfooter += WebFormHelper.BeginControl("JSHandler","JSHandler1",null)+WebFormHelper.EndControl("JSHandler"); 
	            }
            } catch(System.Exception e) {		
	            System.Windows.Forms.MessageBox.Show("Erro web2: " + e.Message + Environment.NewLine + e.StackTrace);                   
            }

            if (collapse) {
	            sfooter += WebForm.Variable("collapse");
            }

            if (!loadOnStart)
            {
                sfooter += WebForm.Variable("loadStart");
            }

            if (geraBC)
            {
                sfooter += WebForm.Variable("editando");
                sfooter += WebForm.Variable("ModeI");
            }

            if (GridObject.Actions.isMultiRowActions && settings.Grid.CheckAll)
            {
                sCheckAll = WebForm.Variable("CheckAll");
            }

            if (GridObject.Actions.isMultiRowActions && settings.Grid.SelectedRecords)
            {
                Dictionary<string, object> props = new Dictionary<string, object>();
                props[Properties.HTMLATT.ReadOnly] = true;
                sSelectedRecords = WebForm.Variable("SelectedRecords",null,null,props);
                if (GridObject.GetCustomRender != null && GridObject.GetCustomRender.ToLower().IndexOf("gxui") >= 0) {
                    sfooter += WebFormHelper.BeginControl("HTools", "HTools1", null) + WebFormHelper.EndControl("HTools");
                }
            }
            
            sfooter += MenuContext.get(GridObject.Actions).WebForm();

            if (sCheckAll != String.Empty)
                gridWebForm.SetAttribute(SelTemplate.CheckAll, sCheckAll);
            if (sSelectedRecords != String.Empty)
                gridWebForm.SetAttribute(SelTemplate.SelectedRecords, sSelectedRecords);

            //gridWebForm.SetAttribute("header", sheader);	
            if (stitle != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.Title,stitle);
            if (stitleimage != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.TitleImage,stitleimage);
            if (sdescription != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.Description, sdescription);

            StringBuilder mfilters = new StringBuilder(WebForm.BeginTable("TableHFilters",null));
            foreach (Filter filter in filters)
            {
                mfilters.Append( filter.FilterRow);
            }
            if (sfilterRows != String.Empty)
                mfilters.Append(sfilterRows);
            mfilters.Append(WebForm.EndTable());
            gridWebForm.SetAttribute(SelTemplate.Filters, mfilters.ToString());

            if (sfilterButtons != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.FilterButtons, sfilterButtons);

            //if (serrorviewer != String.Empty)
	        //    gridWebForm.SetAttribute("errorviewer", serrorviewer); 	
            	
            if (sgridPaging != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.GridPaging, sgridPaging);
            	
            if (sgridPagingFirst != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.GridPagingFirst, sgridPagingFirst);
            if (sgridPagingPrevious != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.GridPagingPrevious, sgridPagingPrevious);
            if (sgridPagingNext != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.GridPagingNext, sgridPagingNext);
            if (sgridPagingLast != String.Empty)	
	            gridWebForm.SetAttribute(SelTemplate.GridPagingLast, sgridPagingLast);

            if (sgridExport != String.Empty)	
	            gridWebForm.SetAttribute(SelTemplate.GridExport, sgridExport);


            if (scurrentpage != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.Currentpage, scurrentpage);
            if (smaxpage != String.Empty)	
	            gridWebForm.SetAttribute(SelTemplate.MaxPage, smaxpage);

            if (sMaxRecords != String.Empty)
                gridWebForm.SetAttribute(SelTemplate.MaxRecords, sMaxRecords);

            if (sRecordPage != String.Empty)
                gridWebForm.SetAttribute(SelTemplate.PageRecords, sRecordPage);
            	
            if (sgridButtons != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.GridButtons, sgridButtons);
            if (sgrid != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.Grid, sgrid);
            if (sfooterButtons != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.FooterButtons, sfooterButtons);
            if (sfooter != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.Footer, sfooter);
            	
            if (sfiltercollapseimage != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.FilterCollapseImage, sfiltercollapseimage);
            	
            if (stabs != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.Tabs, stabs);
            	
            if (stransaction != String.Empty)
	            gridWebForm.SetAttribute(SelTemplate.Transaction, stransaction);

            //gridWebForm.SetAttribute("type"+stype, stype);

            string tsaida = "";
            try {
	            tsaida = gridWebForm.ToString();
            } catch(System.Exception e) {
	            tsaida = "";
	            System.Windows.Forms.MessageBox.Show("Error processing the Selection Template:" + Environment.NewLine + e.Message + Environment.NewLine + e.StackTrace);

            }

            if (settings.Template.SelectionTemplateDebug != String.Empty) {

	            System.IO.StreamWriter file2 = new System.IO.StreamWriter(settings.Template.SelectionTemplateDebug);
	            file2.WriteLine(tsaida);
	            file2.Close();
            	
            }


            ret.AppendLine(String.Format("<Part type=\"{0}\">",PartType.WebForm));
	            ret.AppendLine("<Source><![CDATA[");
	                //ret.AppendLine("<BODY>");
                        ret.AppendLine(tsaida);
	                //ret.AppendLine("</BODY>]]>");
	            ret.AppendLine("]]></Source>");
            ret.AppendLine("</Part>");
            return ret.ToString();
        }

        private static string GridActions(IGridObject GridObject, bool actionsModes, bool geraBC, HPatternSettings settings)
        {
            StringBuilder sgrid = new StringBuilder();
            if (actionsModes)
            {
                if (GridObject.Actions.MultiRowActions.Count > 0)
                {
                    // Checkbox is first column.
                    sgrid.Append(WebForm.GridVariable("Selected", null, ""));
                }

                foreach (ActionElement inGridAction in GridObject.Actions.GridActions)
                {
                    // InGrid actions go next.
                    if (geraBC && settings.StandardActions.FindAction(inGridAction.Name) != null)
                    {
                        Dictionary<String, Object> dict = new Dictionary<string, object>();
                        switch (inGridAction.Name)
                        {
                            case StandardAction.Insert:
                                dict[Properties.HTMLSFLCOL.OnClickEvent] = "'DoInsert'";
                                break;
                            case StandardAction.Update:
                                dict[Properties.HTMLSFLCOL.OnClickEvent] = "'Atualiza'";
                                break;
                            case StandardAction.Delete:
                                dict[Properties.HTMLSFLCOL.OnClickEvent] = "'Apaga'";
                                break;
                            case StandardAction.Display:
                                dict[Properties.HTMLSFLCOL.OnClickEvent] = "'DoDisplay'";
                                break;
                        }
                        sgrid.Append(WebForm.GridVariable(inGridAction.ControlName(), null, String.Empty, true, null, dict));
                    }
                    else
                    {
                        sgrid.Append(inGridAction.ToHtml());
                    }
                }
            }
            return sgrid.ToString();
        }

        

        public static string EnableDisableEdit(TabElement tab, string operacao)
        { 
            StringBuilder ret = new StringBuilder();
            foreach (RowElement row in tab.Transaction.GetRows(""))
            {
                EnableDisableEditRow(row, ret, operacao);
            }
            return ret.ToString();
        }

        private static void EnableDisableEditRow(RowElement objr, StringBuilder ret, string operacao)
        {
            string tabula = "\t\t\t";
            foreach (ColumnElement objc in objr.Columns)
            {
                foreach (IHPatternInstanceElement obji in objc.Items)
                {
                    if (obji is AttributeElement)
                    {
                        AttributeElement obja = (AttributeElement)obji;
                        if (!obja.Visible)
                        {
                            ret.AppendLine(tabula + String.Format("ctl{0}.Visible = false", obja.AttributeName));
                        }
                        else
                        {
                            if (obja.Readonly)
                            {
                                ret.AppendLine(tabula + String.Format("ctl{0}.Enabled = false", obja.AttributeName));
                            }
                            else
                            {
                                ret.AppendLine(tabula + String.Format("ctl{0}.Enabled = {1}", obja.AttributeName, operacao));
                            }
                        }
                    }
                    if (obji is VariableElement)
                    {
                        VariableElement objv = (VariableElement)obji;
                        if (!objv.Visible)
                        {
                            ret.AppendLine(tabula + String.Format("&{0}.Visible = false", objv.Name));
                        }
                        else
                        {
                            if (objv.Readonly)
                            {
                                ret.AppendLine(tabula + String.Format("&{0}.Enabled = false", objv.Name));
                            }
                            else
                            {
                                ret.AppendLine(tabula + String.Format("&{0}.Enabled = {1}", objv.Name, operacao));
                            }
                        }
                        
                    }
                }
            } 
        }

        #endregion

        #region Misc

        #region Grid

        public const string GridName = "Grid";

        public class Filter
        {
            string filterRow;
            public Filter(string filterRow)
            {
                this.filterRow = filterRow;
            }
            public string FilterRow { get { return filterRow; } }
        }

        private static string GridColumnPrompt(IAttributesItem item)
        {
            return GridColumnPrompt(item, true);
        }

        private static string GridColumnPrompt(IAttributesItem item,bool returnonclick)
        {
            if (item is AttributeElement)
                return GridAttributePrompt((AttributeElement)item, returnonclick);

            if (item is VariableElement)
                return GridVariablePrompt((VariableElement)item, returnonclick);

            throw new TemplateException("Unexpected attributes item: not an attribute or variable");
        }

        private static string GridAttributePrompt(AttributeElement att, bool returnonclick)
        {
            string defaultThemeClass = att.Instance.Settings.Theme.ReadonlyGridAttribute;
            if (att.Attribute.Type == eDBType.BINARY)
                defaultThemeClass = att.Instance.Settings.Theme.ReadonlyGridBlobAttribute;

            string themeClass = GetThemeClass(att, defaultThemeClass);
            Dictionary<string, object> properties = new Dictionary<string, object>();
            GetControlInfo(att, properties);
            if (returnonclick)
            {
                properties[Properties.HTMLSFLCOL.ReturnOnClick] = true;
            }
            AddCustomRenderColProperties(properties, att);
            return WebForm.GridAttribute(att.AttributeName, themeClass, att.Description, att.Visible, null, properties);
        }

        private static string GridVariablePrompt(VariableElement var, bool returnonclick)
        {
            string themeClass = GetThemeClass(var, var.Instance.Settings.Theme.ReadonlyGridAttribute);
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties[Properties.HTMLSFLCOL.ReadOnly] = true;
            GetControlInfo(var, properties);
            if (returnonclick)
            {
                properties[Properties.HTMLSFLCOL.ReturnOnClick] = true;
            }
            AddCustomRenderColProperties(properties, var);
            return WebForm.GridVariable(var.VariableName, themeClass, var.Description, var.Visible, null, properties);
        }

        private static string GridColumn(IAttributesItem item)
        {
            if (item is AttributeElement)
                return GridAttribute((AttributeElement)item);

            if (item is VariableElement)
                return GridVariable((VariableElement)item);

            throw new TemplateException("Unexpected attributes item: not an attribute or variable");
        }

        private static string GridColumnBC(IAttributesItem item)
        {
            if (item is AttributeElement)
            {
                return GridVariableBC((AttributeElement)item);
            }

            if (item is VariableElement)
                return GridVariable((VariableElement)item);

            throw new TemplateException("Unexpected attributes item: not an attribute or variable");
        }

        internal static HPatternSettings getSettings(IHPatternInstanceElement att)
        {
            HPatternSettings settings = sett;
            if (settings == null)
            {
                if (att != null)
                {
                    if (att.Instance != null)
                    {
                        if (att.Instance.Settings != null)
                        {
                            settings = att.Instance.Settings;
                        }
                    }
                }
            }
            return settings;
        }

        private static string GridAttribute(AttributeElement att)
        {
            string retorno = "";
            try
            {
                HPatternSettings settings = getSettings(att);

                string defaultThemeClass = "";
                if (settings != null)
                {
                    defaultThemeClass = settings.Theme.ReadonlyGridAttribute;
                    if (att.Attribute.Type == eDBType.BINARY)
                    {
                        defaultThemeClass = settings.Theme.ReadonlyGridBlobAttribute;
                    }
                }
                
                string themeClass = GetThemeClass(att, defaultThemeClass);
                Dictionary<string, object> properties = new Dictionary<string, object>();
                GetControlSize(att, properties);
                AddCustomRenderColProperties(properties, att);
                retorno = WebForm.GridAttribute(att.AttributeName, themeClass, att.Description, att.Visible, null, properties);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message + " " + e.StackTrace);
            }
            return retorno;
        }

        internal static void AddCustomRenderColProperties(Dictionary<string, object> properties, IHPatternInstanceElement att)
        {
            HPatternSettings settings = getSettings(att);
            GridColumnPropertiesElement props = null;
            String CustomRender = TemplateGrid.getCustomRender(att);
            if (att is AttributeElement)
            {
                props = ((AttributeElement)att).GridColumnProperties;
            } else if (att is VariableElement)
            {
                props = ((VariableElement)att).GridColumnProperties;
            }

            foreach (GridColumnPropertieElement prop in TemplateGrid.MergeGridColumnProperties(props, settings))
            {
                TemplateGrid.DefProperty(properties, CustomRender, prop);                
            }
        }

        public static string GridVariable(VariableElement var)
        {
            string themeClass = GetThemeClass(var, var.Instance.Settings.Theme.ReadonlyGridAttribute);
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties[Properties.HTMLSFLCOL.ReadOnly] = true;
            GetControlInfo(var, properties,false,true);
            AddCustomRenderColProperties(properties, var);
            return WebForm.GridVariable(var.VariableName, themeClass, var.Description, var.Visible, null, properties);
        }

        private static string GridVariableBC(AttributeElement var)
        {
            string themeClass = GetThemeClass(var, var.Instance.Settings.Theme.ReadonlyGridAttribute);
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties[Properties.HTMLSFLCOL.ReadOnly] = true;
            GetControlInfo(var, properties,false,true);
            AddCustomRenderColProperties(properties, var);
            return WebForm.GridVariable(var.AttributeName, themeClass, var.Description, var.Visible, null, properties);
        }

        #endregion

        #region Transaction

        public static string PromptRules(IHPatternInstanceElement objele, HPatternSettings settings)
        {
            return PromptRules(objele, settings, "");
        }

        public static string PromptRules(IHPatternInstanceElement objele, HPatternSettings settings, string prefix)
        {
            StringBuilder ret = new StringBuilder();
            if (settings.Template.TemPrompt)
            {
                if (objele is FormElement)
                {
                    FormElement form = (FormElement)objele;
                    foreach (IHPatternInstanceElement ele in form.Items)
                    {
                        if (ele is TabFormElement)
                        {
                            TabFormElement tab = (TabFormElement)ele;
                            foreach (RowElement row in tab.Rows)
                            {
                                PromptRulesRow(ret, row, settings,prefix);
                            }
                        }
                        if (ele is RowElement)
                        {
                            RowElement row = (RowElement)ele;
                            PromptRulesRow(ret, row, settings,prefix);
                        }
                    }
                }
                if (objele is TabFormElement)
                {
                    TabFormElement tab = (TabFormElement)objele;
                    foreach (RowElement row in tab.Rows)
                    {
                        PromptRulesRow(ret, row, settings,prefix);
                    }
                
                }
            }
            return ret.ToString();
        }

        private static void PromptRulesRow(StringBuilder ret, RowElement row, HPatternSettings settings, string prefix)
        {
            // Percorre as colunas
            foreach (ColumnElement col in row.Columns)
            {
                // Percorre os elementos
                foreach (IHPatternInstanceElement ele in col.Items)
                {
                    if (ele is AttributeElement || ele is VariableElement)
                    {
                        PromptRulesElement(ret, ele, settings,prefix);
                    }
                    if (ele is GroupElement)
                    {
                        GroupElement grp = (GroupElement)ele;
                        foreach (RowElement row2 in grp.Rows)
                        {
                            PromptRulesRow(ret, row2, settings, prefix);
                        }
                    }
                }
            }
        }

        private static void PromptRulesElement(StringBuilder ret, IHPatternInstanceElement ele, HPatternSettings settings, string prefix)
        {
            if (ele is AttributeElement)
            {
                AttributeElement att = (AttributeElement)ele;
                if (att.Links != null)
                {
                    foreach (LinkElement link in att.Links)
                    {
                        RulePrompt(ret, link, att.AttributeName, settings, prefix);
                    }
                }
            }
            if (ele is VariableElement)
            {
                VariableElement att = (VariableElement)ele;
                if (att.Links != null)
                {
                    foreach (LinkElement link in att.Links)
                    {
                        RulePrompt(ret, link, att.Name, settings, prefix);
                    }
                }
            }
        }

        public static void RulePrompt(StringBuilder ret, LinkElement link,string name, HPatternSettings settings,string prefix)
        {
            if (link.Type == LinkElement.TypeValue.Prompt && !String.IsNullOrEmpty(link.WebpanelObjectName))
            {
                ret.AppendLine(String.Format("Prompt({0},{1}) on {2};", link.WebpanelObjectName, link.Parameters.ConcatenatePrompt(prefix,false), link.ControlName));
            }
        }

        public static string PromptEvents(IHPatternInstanceElement objele, HPatternSettings settings)
        {
            return PromptEvents(objele, settings, "");
        }

        public static string PromptEvents(IHPatternInstanceElement objele, HPatternSettings settings, string prefix)
        {
            StringBuilder ret = new StringBuilder();
            if (settings.Template.TemPrompt)
            {
                if (objele is FormElement)
                {
                    FormElement form = (FormElement)objele;
                    foreach (IHPatternInstanceElement ele in form.Items)
                    {
                        if (ele is TabFormElement)
                        {
                            TabFormElement tab = (TabFormElement)ele;
                            foreach (RowElement row in tab.Rows)
                            {
                                PromptEventsRow(ret, row, settings, prefix);
                            }
                        }
                        if (ele is RowElement)
                        {
                            RowElement row = (RowElement)ele;
                            PromptEventsRow(ret, row, settings, prefix);
                        }
                    }
                }
                if (objele is TabFormElement)
                {
                    TabFormElement tab = (TabFormElement)objele;
                    foreach (RowElement row in tab.Rows)
                    {
                        PromptEventsRow(ret, row, settings, prefix);
                    }

                }
            }
            return ret.ToString();
        }

        private static void PromptEventsRow(StringBuilder ret, RowElement row, HPatternSettings settings, string prefix)
        {
            // Percorre as colunas
            foreach (ColumnElement col in row.Columns)
            {
                // Percorre os elementos
                foreach (IHPatternInstanceElement ele in col.Items)
                {
                    if (ele is AttributeElement || ele is VariableElement)
                    {
                        PromptEventsElement(ret, ele, settings, prefix);
                    }
                    if (ele is GroupElement)
                    {
                        GroupElement grp = (GroupElement)ele;
                        foreach (RowElement row2 in grp.Rows)
                        {
                            PromptEventsRow(ret, row2, settings, prefix);
                        }
                    }
                }
            }
        }

        private static void PromptEventsElement(StringBuilder ret, IHPatternInstanceElement ele, HPatternSettings settings, string prefix)
        {
            if (ele is AttributeElement)
            {
                AttributeElement att = (AttributeElement)ele;
                if (att.Links != null)
                {
                    foreach (LinkElement link in att.Links)
                    {
                        EventPrompt(ret, link, att.AttributeName, settings, prefix);
                    }
                }
            }
            if (ele is VariableElement)
            {
                VariableElement att = (VariableElement)ele;
                if (att.Links != null)
                {
                    foreach (LinkElement link in att.Links)
                    {
                        EventPrompt(ret, link, att.Name, settings, prefix);
                    }
                }
            }
        }

        private static void EventPrompt(StringBuilder ret, LinkElement link, string name, HPatternSettings settings, string prefix)
        {
            if (link.Type == LinkElement.TypeValue.Event && !String.IsNullOrEmpty(link.WebpanelObjectName))
            {
                ret.AppendLine(String.Format("Event '{0}'",link.EventName));
                ret.AppendLine(String.Format("\t{0}.Popup({1})", link.WebpanelObjectName, link.Parameters.ConcatenatePrompt(prefix, false)));
                ret.AppendLine(String.Format("EndEvent // {0}", link.EventName));
            }
        }

        private static void LinkBuild(StringBuilder atts, IHPatternInstanceElement ele,HPatternSettings settings)
        {
            if (settings.Template.TemPrompt)
            {
                if (ele is AttributeElement)
                {
                    AttributeElement att = (AttributeElement)ele;
                    if (att.Links != null)
                    {
                        foreach (LinkElement link in att.Links)
                        {
                            LinkImage(atts, link, att.AttributeName, settings);
                        }
                    }
                }
                if (ele is VariableElement)
                {
                    VariableElement att = (VariableElement)ele;
                    if (att.Links != null)
                    {
                        foreach (LinkElement link in att.Links)
                        {
                            LinkImage(atts, link, att.Name, settings);
                        }
                    }
                }
            }
        }

        public static string ImageDefault(Artech.Architecture.Common.Objects.KBModel model )
        {            
            Image i = Image.Get(model, "prompt");
            if (i != null)
            {
                return i.Name;
            }
            else
            {
                i = Image.Get(model, "Prompt");
                if (i != null)
                {
                    return i.Name;
                }
            }
            return null;
        }

        public static void LinkImage(StringBuilder atts, LinkElement link, string name, HPatternSettings settings)
        {
            string imagename = settings.Template.PromptImageName;
            string eventname = null;
            if (link.Image != null)
            {
                if (!String.IsNullOrEmpty(link.ImageName))
                    imagename = link.ImageName;
            }
            // Se não temos imagem de prompt definido, vamos procurar uma na kb
            if (String.IsNullOrEmpty(imagename))
            {
                imagename = ImageDefault(link.Instance.Model);
            }
            if (link.Type == LinkElement.TypeValue.Event)
                eventname = String.Format("'{0}'", link.EventName);
            atts.AppendLine(WebForm.Image(link.ControlName, settings.Template.PromptClass, imagename, eventname, link.Tooltip));
        }

        private static void ApplyRow(StringBuilder atts, RowElement row, KBObject objeto, Boolean geraBC, String sigla, HPatternSettings settings, bool overwrite)
        {
            atts.AppendLine("<tr>");
            
            Transaction transaction = null;
            if (objeto is Transaction) transaction = (Transaction)objeto;

            foreach (ColumnElement col in row.Columns)
            {
                atts.AppendLine("<td align=\"" + col.GetAlign() + "\" colspan='" + col.ColSpan.ToString() + "' rowspan='" + col.RowSpan.ToString() + "'>");
                
                foreach (Object obj in col.Items)
                {
                    if (obj is AttributeElement)
                    {
                        AttributeElement att = (AttributeElement)obj;
                        if (geraBC)
                        {
                            Dictionary<string, object> properties = new Dictionary<string, object>();
                            properties[Properties.HTMLATT.FieldSpecifier] = att.AttributeName;
                            bool vreadonly = false;
                            TransactionAttribute ta = null;
                            if (transaction != null)
                            {
                                ta = transaction.Structure.Root.GetAttribute(att.AttributeName);
                                if (ta == null)
                                {
                                    vreadonly = true;
                                }
                                else
                                {
                                    if (ta.IsInferred)
                                    {
                                        vreadonly = true;
                                    }
                                }
                            }

                            if (att.Readonly)
                            {
                                vreadonly = true;
                            }


                            if (vreadonly)
                            {
                                properties[Properties.HTMLATT.ReadOnly] = true;
                            }

                            string themeClass = "Attribute";
                            if (transaction != null && ta != null)
                            {
                                if (ta.IsKey && !String.IsNullOrEmpty(settings.Theme.AttributeKey))
                                    themeClass = settings.Theme.AttributeKey;
                            }
                            if (att.ThemeClass != String.Empty)
                                themeClass = att.ThemeClass;

                            

                            if (vreadonly)
                            {
                                if (att.Format.ToLower() == "text")
                                    properties[Properties.HTMLATT.Format] = Properties.HTMLATT.Format_Values.Text;

                                if (att.Format.ToLower() == "html")
                                    properties[Properties.HTMLATT.Format] = Properties.HTMLATT.Format_Values.Html;

                                if (att.Format.ToLower() == "raw html")
                                    properties[Properties.HTMLATT.Format] = Properties.HTMLATT.Format_Values.RawHtml;

                                if (att.Format.ToLower() == "text with meaningful spaces")
                                    properties[Properties.HTMLATT.Format] = Properties.HTMLATT.Format_Values.TextWithMeaningfulSpaces;

                            }

                            GetControlInfo(att, properties);

                            atts.AppendLine(WebForm.Variable((transaction != null ? transaction.Name : "") + sigla, themeClass, null, properties));
                        }
                        else
                        {
                            string themeClass = null;
                            if (transaction != null)
                            {
                                TransactionAttribute ta = transaction.Structure.Root.GetAttribute(att.AttributeName);
                                if (ta.IsKey && !String.IsNullOrEmpty(settings.Theme.AttributeKey))
                                    themeClass = settings.Theme.AttributeKey;
                            }
                            if (att.ThemeClass != String.Empty)
                                themeClass = att.ThemeClass;
                            Dictionary<string, object> properties = new Dictionary<string, object>();
                            if (att.Readonly)
                            {
                                properties[Properties.HTMLATT.ReadOnly] = true;
                            }

                            GetControlSize(att, properties);

                            atts.AppendLine(WebForm.Attribute(att.AttributeName, themeClass, null, properties));
                        }                        
                        LinkBuild(atts, att, settings);
                        if (!String.IsNullOrEmpty(att.MaskPicture))
                        {
                            Dictionary<string, object> props = new Dictionary<string, object>();
                            props.Add("Picture", att.MaskPicture);
                            props.Add("Reverse", att.Reverse);
                            props.Add("Signed", att.Signed);
                            props.Add("UnmaskedChars", att.UnmaskedChars);
                            props.Add("UnmaskedValue",att.UnmaskedValue);
                            atts.AppendLine(WebFormHelper.BeginControl("HMask2", att.AttributeName + "HMask", props));
                            atts.AppendLine(WebFormHelper.EndControl("HMask2"));
                        }
                    }
                    if (obj is VariableElement)
                    {
                        VariableElement var = (VariableElement)obj;

                        string themeClass = "Attribute";
                        if (var.ThemeClass != String.Empty)
                            themeClass = var.ThemeClass;

                        Dictionary<string, object> properties = new Dictionary<string, object>();
                        GetControlSize(var, properties);

                        atts.AppendLine(WebForm.Variable(var.Name, themeClass, null, properties));
                        LinkBuild(atts, var, settings);
                        if (!String.IsNullOrEmpty(var.MaskPicture))
                        {
                            Dictionary<string, object> props = new Dictionary<string, object>();
                            props.Add("Picture", var.MaskPicture);
                            props.Add("Reverse", var.Reverse);
                            props.Add("Signed", var.Signed);
                            props.Add("UnmaskedChars", var.UnmaskedChars);
                            props.Add("UnmaskedValue", var.UnmaskedValue);
                            atts.AppendLine(WebFormHelper.BeginControl("HMask2", var.Name + "HMask", props));
                            atts.AppendLine(WebFormHelper.EndControl("HMask2"));
                        }
                    }
                    if (obj is TextElement)
                    {
                        TextElement text = (TextElement)obj;
                        TemplateInternal.RenderText(text, row,atts,transaction);
                    }
                    if (obj is GroupElement)
                    {
                        GroupElement gobj = (GroupElement)obj;
                        
                        contaGroup++;
                        string name = "Group"+contaGroup.ToString().Trim();
                        
                        string tema = settings.Theme.Group;
                        if (String.IsNullOrEmpty(tema)) tema = "Group";
                        if (!String.IsNullOrEmpty(gobj.Class)) tema = gobj.Class;
                        
                        atts.AppendLine(WebForm.BeginGroup(name, tema, gobj.Caption));
                        atts.AppendLine(WebForm.BeginTable("Table"+name,null));
                        foreach (RowElement row2 in gobj.Rows) {
                            ApplyRow(atts, row2, objeto, geraBC, sigla, settings, overwrite);
                        }
                        atts.AppendLine(WebForm.EndTable());
                        atts.AppendLine(WebForm.EndGroup());
                    }
                    if (obj is UserTableElement)
                    {
                        WebFormPart wform = null;
                        if (transaction != null)
                        {
                            wform = transaction.WebForm;
                        }
                        else if (objeto is WebPanel)
                        {
                            wform = ((WebPanel)objeto).WebForm;
                        }
                        AddUserTable((UserTableElement)obj, atts, wform, overwrite);
                    }
                    if (!geraBC)
                    {
                        if (obj is GridFreeStyleElement)
                        {
                            GridFreeStyleElement grid = obj as GridFreeStyleElement;
                            AddGridFreeStyle(atts, grid, settings);
                        }
                        if (obj is GridStandardElement)
                        {
                            GridStandardElement grid = obj as GridStandardElement;
                            AddGridStandard(atts, grid, settings);
                        }
                    }
                }

                atts.AppendLine("</td>");
            }

            atts.AppendLine("</tr>");


        }

        private static void AddUserTable(UserTableElement userTable, StringBuilder atts, WebFormPart obj, bool overwrite)
        {
            string tabela = (overwrite ? String.Empty : getUserTables(obj, userTable.Name));
            if (String.IsNullOrEmpty(tabela))
            {
                atts.AppendLine(WebForm.BeginTable(userTable.Name, "Table"));
                atts.AppendLine("<tr><td>" + userTable.Name + "</td></tr>");
                atts.AppendLine(WebForm.EndTable());
            }
            else
            {
                atts.AppendLine(tabela);
            }
        }

        public static bool IsEmpty(string texto)
        {            
            if (String.IsNullOrEmpty(texto)) return true;
            int tamanho = texto.Length;
            string tmp = new String(' ',tamanho);
            if (texto.Equals(tmp)) return true;
            return false;
        }

        private static void AddGridStandard(StringBuilder atts, GridStandardElement grid, HPatternSettings settings)
        {
            if (!grid.Instance.IsWebPanel)
            {
                atts.AppendLine("<br/>");
                atts.AppendLine(WebForm.BeginTable("Table" + grid.Name, "Table95"));
                atts.AppendLine("<tr><td class='SubTitle'>");
                atts.AppendLine(WebForm.TextBlock("Title" + grid.Name, "", grid.Description));
                atts.AppendLine("</td></tr>");
                atts.AppendLine(WebForm.EndTable());
                atts.AppendLine("<hr class='HRDefault' />");
            }
            Dictionary<string, Object> props = new Dictionary<string, object>();
            if (!String.IsNullOrEmpty(grid.GetCustomRender))
            {
                props[Artech.Genexus.Common.Properties.HTMLSFL.CustomRender] = grid.GetCustomRender;
                foreach (GridPropertieElement prop in TemplateGrid.MergeGridProperties(grid.GridProperties, settings))
                {
                    TemplateGrid.DefProperty(props, grid.GetCustomRender, prop);
                }

            }
            atts.AppendLine(WebForm.BeginGrid(grid.Name, null, null, null, null, Properties.HTMLSFL.BackColorStyle_Enum.Header, null, null,props));
            foreach (AttributeElement att in grid.Attributes.Attributes)
            {
                string themeClass = null;
                if (!String.IsNullOrEmpty(att.ThemeClass))
                    themeClass = att.ThemeClass;
                Dictionary<string, object> properties = new Dictionary<string, object>();
                if (att.Readonly)
                {
                    properties[Properties.HTMLSFLCOL.ReadOnly] = true;
                }
                foreach (GridColumnPropertieElement prop in TemplateGrid.MergeGridColumnProperties(att.GridColumnProperties, settings))
                {
                    TemplateGrid.DefProperty(properties, grid.GetCustomRender, prop);
                }
                atts.AppendLine(WebForm.GridAttribute(att.AttributeName, themeClass, att.Description, att.Visible, null, properties));
            }
            atts.AppendLine(WebForm.EndGrid());            
        }

        private static void AddGridFreeStyle(StringBuilder atts, GridFreeStyleElement grid, HPatternSettings settings)
        {
            if (!grid.Instance.IsWebPanel)
            {
                atts.AppendLine("<br/>");
                atts.AppendLine(WebForm.BeginTable("Table" + grid.Name, "Table95"));
                atts.AppendLine("<tr><td class='SubTitle'>");
                atts.AppendLine(WebForm.TextBlock("Title" + grid.Name, "", grid.Description));
                atts.AppendLine("</td></tr>");
                atts.AppendLine(WebForm.EndTable());
                atts.AppendLine("<hr class='HRDefault' />");
            }
            atts.AppendLine("<gxFreeStyle border='1' freestyle='1' gxProp='ControlName=" + grid.Name + ";class=FreeStyleGrid'>");

            //atts.AppendLine(Heurys.Patterns.HPattern.Helpers.Template.InnerLevel(subLevel, Counters));
            atts.AppendLine("<tr>");
                atts.AppendLine("<td>");
                    atts.AppendLine(WebForm.BeginTable("Table2" + grid.Name, "Table"));

                    foreach (IHPatternInstanceElement item in grid.Items)
                    {
                        if (item is GridFreeStyleElement)
                        {
                            atts.AppendLine("<tr>");
                                atts.AppendLine("<td colspan=\"2\">");
                                    GridFreeStyleElement grid2 = item as GridFreeStyleElement;
                                    AddGridFreeStyle(atts, grid2, settings);
                                atts.AppendLine("</td>");
                            atts.AppendLine("</tr>");
                        }
                        if (item is GridStandardElement)
                        {
                            atts.AppendLine("<tr>");
                                atts.AppendLine("<td colspan=\"2\">");
                                    GridStandardElement grid2 = item as GridStandardElement;
                                    AddGridStandard(atts, grid2, settings);
                                atts.AppendLine("</td>");
                            atts.AppendLine("</tr>");
                        }
                        if (item is AttributeElement)
                        {
                            AttributeElement att = item as AttributeElement;

                            string themeClass = null;
                            if (!String.IsNullOrEmpty(att.ThemeClass))
                                themeClass = att.ThemeClass;
                            Dictionary<string, object> properties = new Dictionary<string, object>();
                            if (att.Readonly)
                            {
                                properties[Properties.HTMLATT.ReadOnly] = true;
                            }                            

                            atts.AppendLine("<tr>");
                                atts.AppendLine("<td class=\"td5\" valign=\"top\" nowrap=\"nowrap\">");
                                    atts.AppendLine(WebForm.TextBlock("TextBlock" + att.AttributeName, null, att.Description));
                                atts.AppendLine("</td>");
                                atts.AppendLine("<td nowrap=\"nowrap\">");
                                    atts.AppendLine(WebForm.Attribute(att.AttributeName, themeClass, null, properties));
                                atts.AppendLine("</td>");
                            atts.AppendLine("</tr>");
                        }
                    }

                    atts.AppendLine(WebForm.EndTable());
                atts.AppendLine("</td>");
            atts.AppendLine("</tr>");

            atts.AppendLine("</gxFreeStyle>");

        }

        private static int contaGroup = 0;

        #endregion

        #region Geral

        public static void AddStandardVariables(List<string> lista,HPatternSettings settings)
        {
            lista.Add("IsAuthorized");

	
	        if(!settings.Grid.DefaultPagingButtons) 
            {
	            lista.Add("CurrentPage");
                lista.Add("pagec");
	        }
    	
	        if(settings.Grid.MaxPage) 
            {
	            lista.Add("MaxPage");
	        }

	        if(settings.Grid.MaxRecords) {
	            lista.Add("MaxRecords");
	        }

            if (settings.Grid.PageRecordsCombo)
            {
	            lista.Add("RecordPage");
	        }
        }

        public static string GetPKLink(IBaseCollection<TransactionAttribute> atts)
        {
            return GetPKLink(atts, true);
        }

        public static string GetPKLink(IBaseCollection<TransactionAttribute> atts,bool IniciaComVirgula)
        {
            StringBuilder varpks = new StringBuilder();

            int conta = 0;
            if (IniciaComVirgula) conta = 1;

            foreach (TransactionAttribute trnAtt in atts)
            {
                if (conta > 0) varpks.Append(",");
                varpks.AppendFormat("&{0}", trnAtt.Name);
                conta = 1;
            }

            return varpks.ToString();
        }

        public static string GetPKVar(IBaseCollection<TransactionAttribute> atts)
        {
            StringBuilder varpksT = new StringBuilder();

            foreach (TransactionAttribute trnAtt in atts)
            {
                varpksT.AppendFormat("+&{0}", trnAtt.Name);

                if (!(trnAtt.Attribute.Type == eDBType.CHARACTER || trnAtt.Attribute.Type == eDBType.VARCHAR))
                {
                    varpksT.Append(".ToString()");
                }

            }
            return varpksT.ToString();
        }

        public static string GetPKSDT(IBaseCollection<TransactionAttribute> atts,string TrnName, string PKDelimiter)
        {
            StringBuilder varpksM = new StringBuilder();

            int contaVM = 0;

            foreach (TransactionAttribute trnAtt in atts)
            {
                if (contaVM == 1) varpksM.AppendFormat("+'{0}'+", PKDelimiter);
                varpksM.AppendFormat("&{0}SDT.{1}", TrnName, trnAtt.Name);
                contaVM = 1;

                if (!(trnAtt.Attribute.Type == eDBType.CHARACTER || trnAtt.Attribute.Type == eDBType.VARCHAR))
                {
                    varpksM.Append(".ToString()");
                }

            }
            return varpksM.ToString();
        }        

        public static string LinksEventStart(Artech.Common.Collections.IBaseCollection<LinkElement> links)
        {
            StringBuilder ret = new StringBuilder();
            if (links != null) 
            {
                if (links.Count > 0) {

                    if (sett == null) sett = links[0].Instance.Settings;
                    if (sett.Template.TemPrompt)
                    {
                        if (links != null)
                        {
                            if (links.Count > 0)
                            {
                                foreach (LinkElement link in links)
                                {
                                    ret.Append(link.EventStart);
                                }
                            }
                        }
                    }
                }
            }
            return ret.ToString();
        }

        public static string Item(IAttributesItem item)
        {
            if (item is AttributeElement)
                return Attribute((AttributeElement)item);

            if (item is VariableElement)
                return Variable((VariableElement)item);

            throw new TemplateException("Unexpected attributes item: not an attribute or variable");
        }

        public static string Attribute(AttributeElement att)
        {
            string defaultThemeClass = att.Instance.Settings.Theme.ReadonlyAttribute;
            if (att.Attribute.Type == eDBType.BINARY)
                defaultThemeClass = att.Instance.Settings.Theme.ReadonlyBlobAttribute;

            string themeClass = GetThemeClass(att, defaultThemeClass);
            Dictionary<string, object> properties = new Dictionary<string, object>();
            GetControlInfo(att, properties);

            return WebForm.Attribute(att.AttributeName, themeClass, null, properties);
        }

        public static string HiddenAttribute(string attName)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties[Properties.ATT.ControlType] = Properties.ATT.ControlType_Values.Edit;
            properties[Properties.ATT.InputType] = Properties.ATT.InputType_Values.Values;
            return WebForm.Attribute(attName, null, null, properties);
        }

        public static string Variable(VariableElement var)
        {
            string themeClass = GetThemeClass(var, var.Instance.Settings.Theme.ReadonlyAttribute);
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties[Properties.HTMLATT.ReadOnly] = true;
            GetControlInfo(var, properties);

            return WebForm.Variable(var.VariableName, themeClass, null, properties);
        }

        private static void GetControlInfo(IAttributesItem item, Dictionary<string, object> properties)
        {
            GetControlInfo(item, properties, false,false);
        }

        public static void GetControlInfo(IAttributesItem item, Dictionary<string, object> properties, bool AllCombo)
        {
            GetControlInfo(item, properties, AllCombo,false);
        }

        internal static String getSize(String size)
        {
            if (String.IsNullOrEmpty(size))
            {
                return "";
            }
            Regex rx = new Regex("%|in|cm|mm|em|ex|pt|pc|px|chr|row", RegexOptions.IgnoreCase);
            if (!rx.IsMatch(size))
            {
                return size.Trim() + "px";
            }
            return size.Trim();
        }

        internal static void GetControlSize(IAttributesItem item, Dictionary<string, object> properties)
        {
            GetControlSize(item.InGrid, item.Width, item.Height, properties);
        }

        internal static void GetControlSize(bool InGrid,string Width, string Height, Dictionary<string, object> properties)
        {
            if (!String.IsNullOrEmpty(Width) || !String.IsNullOrEmpty(Height))
            {
                properties[(InGrid ? Properties.HTMLSFLCOL.AutoResize : Properties.HTMLATT.AutoResize)] = false;
                if (!String.IsNullOrEmpty(Width))
                {
                    properties[(InGrid ? Properties.HTMLSFLCOL.Width : Properties.HTMLATT.Width)] = getSize(Width);
                }
                if (!String.IsNullOrEmpty(Height))
                {
                    properties[(InGrid ? Properties.HTMLSFLCOL.Height : Properties.HTMLATT.Height)] = getSize(Height);
                }
            }
        }
        private static void GetControlInfo(IAttributesItem item, Dictionary<string, object> properties,bool AllCombo,bool EhGrid)
        {
            GetControlSize(item, properties);
            ITypedObject typeInfo = item.TypeInfo;
            if (typeInfo != null && typeInfo is Artech.Common.Properties.PropertiesObject)
            {
                Artech.Common.Properties.PropertiesObject props = (Artech.Common.Properties.PropertiesObject)typeInfo;
                int controlType = props.GetPropertyValue<int>(Properties.ATT.ControlType);
                int editSuggest = props.GetPropertyValue<int>(Properties.ATT.Suggest);
                int editInputType = props.GetPropertyValue<int>(Properties.ATT.InputType);

                if ((controlType == Properties.ATT.ControlType_Values.DynamicComboBox) ||
                    (controlType == Properties.ATT.ControlType_Values.DynamicListBox) ||
                    (controlType == Properties.ATT.ControlType_Values.Edit && (editInputType == Properties.ATT.InputType_Values.Descriptions || editSuggest != Properties.ATT.Suggest_Values.No)))
                {
                    properties[Properties.ATT.ControlType] = Properties.ATT.ControlType_Values.Edit;
                    properties[Properties.ATT.InputType] = Properties.ATT.InputType_Values.Values;
                }
                else
                {
                    if (EhGrid)
                    {
                        if (sett.Grid.ChangeRadioTocombo)
                        {
                            if (controlType == Properties.ATT.ControlType_Values.RadioButton)
                            {
                                controlType = Properties.ATT.ControlType_Values.ComboBox;
                            }
                        }
                    }

                    if (controlType == Properties.ATT.ControlType_Values.CheckBox || 
                        controlType == Properties.ATT.ControlType_Values.ComboBox ||
                        controlType == Properties.ATT.ControlType_Values.RadioButton ||
                        controlType == Properties.ATT.ControlType_Values.ListBox) 
                    {
                        properties[Properties.ATT.ControlType] = controlType;
                        switch (controlType)
                        {
                            case Properties.ATT.ControlType_Values.CheckBox:
                                string vCT = props.GetPropertyValue<string>(Properties.ATT.ControlTitle);
                                if (String.IsNullOrEmpty(vCT))
                                    vCT = String.Empty;
                                properties[Properties.ATT.ControlTitle] = vCT;
                                properties[Properties.ATT.CheckedValue] = props.GetPropertyValue<string>(Properties.ATT.CheckedValue);
                                properties[Properties.ATT.UncheckedValue] = props.GetPropertyValue<string>(Properties.ATT.UncheckedValue);
                                break;
                            case Properties.ATT.ControlType_Values.RadioButton:
                                properties[Properties.ATT.Values] = GetValues(props.GetPropertyValue<CT_GXTXVAL_type>(Properties.ATT.Values).Data);
                                properties[Properties.ATT.RadioDirection] = props.GetPropertyValue<Int32>(Properties.ATT.RadioDirection);                                
                                break;
                            default:
                                if (controlType == Properties.ATT.ControlType_Values.ComboBox && AllCombo)
                                {
                                    bool number = false;
                                    if (typeInfo.Type == eDBType.NUMERIC) number = true;
                                    properties[Properties.ATT.Values] = GetValues(props.GetPropertyValue<CT_GXTXVAL_type>(Properties.ATT.Values).Data,true,number);
                                }
                                else
                                {
                                    properties[Properties.ATT.Values] = GetValues(props.GetPropertyValue<CT_GXTXVAL_type>(Properties.ATT.Values).Data);
                                }
                                break;                            
                        }
                    }
                }
            }
        }

        private static string GetValues(IList<KeyValuePair<string, string>> lista)
        {
            return GetValues(lista,false,false);
        }

        private static string GetValues(IList<KeyValuePair<string, string>> lista,bool AllCombo,bool number)
        {
            StringBuilder ret = new StringBuilder();
            int c = 0;
            if (AllCombo)
            {
                if (sett != null)
                {
                    ret.Append(sett.Labels.AllInCombo);
                    ret.Append(":");
                    if (number) ret.Append("0");
                    c = 1;
                }
            }

            foreach (KeyValuePair<string, string> item in lista)
            {
                if (c == 1) ret.Append(",");
                ret.Append(item.Key);
                ret.Append(":");
                ret.Append(item.Value);
                c = 1;                
            }
            return ret.ToString();
        }

        private static string GetThemeClass(IAttributesItem item, string defaultClass)
        {
            if (!String.IsNullOrEmpty(item.ThemeClass))
                return item.ThemeClass;

            if (!String.IsNullOrEmpty(defaultClass))
                return defaultClass;

            return null;
        }

        public static string GetDefinedBy(TransactionLevel trn)
        {
            string ret = "";
            foreach (TransactionAttribute ta in trn.Attributes)
            {
                if (ta.IsKey || ta.IsDescriptionAttribute || !ta.IsInferred)
                {
                    if (ret == String.Empty || (!ta.IsInferred && !ta.IsKey && !ta.IsForeignKey))
                    {
                        ret = ta.Name;
                    }
                }
            }
            if (ret != String.Empty) ret = "Defined By " + ret;
            return ret;
        }

        #endregion

        #endregion

        #region Template

        public static HTemplate GetDocTemplate(HPatternSettings settings)
        {
            return GetTemplate(settings, 3);
        }

        private static HTemplate GetTemplate(HPatternSettings settings, int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return GetTemplate(settings, ObjTemplate.TransactionTemplate);
                case 2:
                    return GetTemplate(settings, ObjTemplate.SelectionTemplate);
                case 3:
                    return GetTemplate(settings, ObjTemplate.DocTemplate);
                case 4:
                    return GetTemplate(settings, ObjTemplate.ViewTemplate);
                case 5:
                    return GetTemplate(settings, ObjTemplate.PromptTemplate);
            }

            return null;
        }

        internal static HTemplate GetTemplate(HPatternSettings settings, ObjTemplate tipo)
        {
            templateModel = settings.Model;
            switch (tipo)
            {
                case ObjTemplate.TransactionTemplate:
                    return CacheHTemplate.Cache.getTemplate(settings.Template.TransactionTemplate, tipo, templateModel);
                case ObjTemplate.SelectionTemplate:
                    return CacheHTemplate.Cache.getTemplate(settings.Template.SelectionTemplate, tipo, templateModel);
                case ObjTemplate.DocTemplate:
                    return CacheHTemplate.Cache.getTemplate(settings.Documentation.Template, tipo, templateModel);
                case ObjTemplate.ViewTemplate:
                    return CacheHTemplate.Cache.getTemplate(settings.Template.ViewTemplate, tipo, templateModel);
                case ObjTemplate.PromptTemplate:
                    return CacheHTemplate.Cache.getTemplate(settings.Template.PromptTemplate, tipo, templateModel);
            }

            return null;
        }


        private static Artech.Architecture.Common.Objects.KBModel templateModel = null;

        #endregion



    }

 }
