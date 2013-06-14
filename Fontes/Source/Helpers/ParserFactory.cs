using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Artech.Packages.Patterns.Objects;
using Artech.Packages.Patterns.Engine;
using Artech.Packages.Patterns.Definition;
using Artech.Genexus.Common.Objects;
using Artech.Common.Collections;
using Artech.Common.Helpers.Templates;
using Artech.Packages.Patterns;
using System.Xml;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common.Parts;
using Artech.Genexus.Common.Parts.SDT;
using Artech.Common.Properties;
using Artech.Genexus.Common;
using Artech.Genexus.Common.CustomTypes;
using Artech.Genexus.Common.Types;
using Artech.Architecture.BL.Framework;
using Artech.Architecture.BL.Framework.Services;
using Artech.Architecture.BL;
using System.Threading;

namespace Heurys.Patterns.HPattern.Helpers
{
    public class ParserFactory
    {

        private PatternInstance mInstance = null;
        private InstanceObject mIo = null;
        private ManualResetEvent mDoneEvent = null;

        public ParserFactory(PatternInstance instance, InstanceObject io, ManualResetEvent doneEvent)
        {
            mInstance = instance;
            mIo = io;
            mDoneEvent = doneEvent;
        }

        internal PatternInstance Instance
        {
            get
            {
                return mInstance;
            }
        }

        internal bool MergeSDT(SDT obj, PatternInstanceElement c, UpdateObject uo, ObjectTemplate t)
        {
            int saveObject = 0;
            bool overwrite = (uo == UpdateObject.OverWrite ? true : false);
            saveObject += MergeSDTStructure(obj.SDTStructure, c, t.Source, overwrite);
            return saveObject > 0;
        }

        internal bool MergeDataProvider(DataProvider obj, PatternInstanceElement c, UpdateObject uo, ObjectTemplate t)
        {
            int saveObject = 0;
            bool overwrite = (uo == UpdateObject.OverWrite ? true : false);
            saveObject += MergeVariables(obj.Variables, c, t.Variables, overwrite);
            saveObject += MergeRules(obj.Rules, c, t.Rules, overwrite);
            saveObject += MergeDataProviderSource(obj.DataProviderSource, c, t.Source, overwrite);
            return saveObject > 0;
        }

        internal bool MergeProcedure(Procedure obj, PatternInstanceElement c, UpdateObject uo, ObjectTemplate t)
        {
            int saveObject = 0;
            bool overwrite = (uo == UpdateObject.OverWrite ? true : false);
            saveObject += MergeVariables(obj.Variables, c, t.Variables, overwrite);
            saveObject += MergeConditions(obj.Conditions, c, t.Conditons, overwrite);
            saveObject += MergeRules(obj.Rules, c, t.Rules, overwrite);
            saveObject += MergeProcedureSource(obj.ProcedurePart, c, t.Source, overwrite);
            return saveObject > 0;
        }

        internal bool MergeWebPanel(WebPanel obj, PatternInstanceElement c, UpdateObject uo, ObjectTemplate t)
        {
            int saveObject = 0;
            bool overwrite = (uo == UpdateObject.OverWrite ? true : false);
            saveObject += MergeVariables(obj.Variables, c, t.Variables, overwrite);
            saveObject += MergeConditions(obj.Conditions, c, t.Conditons, overwrite);
            if (uo != UpdateObject.OnlySource)
            {
                saveObject += MergeWebForm(obj.WebForm, c, t.WebForm, overwrite);
            }
            saveObject += MergeRules(obj.Rules, c, t.Rules, overwrite);
            saveObject += MergeEvents(obj.Events, c, t.Events, overwrite);
            saveObject += t.DeleteVariables(c, obj, overwrite);
            return saveObject > 0;            
        }

        internal int MergeWebForm(WebFormPart obj, PatternInstanceElement c, string template,bool overwrite)
        {
            if (!String.IsNullOrEmpty(template))
            {
                return MergeWebForm(obj, AppendTemplateOutput(obj.KBObject, obj, c, template));
            }
            return 0;
        }

        internal static int MergeWebForm(WebFormPart obj, string webform)
        {
            string oldValue = obj.EditableContent;
            try
            {
                obj.EditableContent = webform;
                obj.EditableToStored();
            }
            catch (Exception ex)
            {
                throw new TemplateException(obj.KBObject.Name, ex);
            }
            return (oldValue != obj.EditableContent ? 1 : 0);
        }

        private static string MergeTextMarked(string textOld, string textNew,bool overWrite)
        {            
            if (overWrite)
            {
                return HParser.BuildBlockMarked(textNew);
            }
            else
            {
                HParser pOld = new HParser(textOld);
                string codigo = HParser.BuildBlockMarked(textNew);
                pOld.ReplaceInsertBlockMarked(codigo);
                return pOld.Text;
            }
        }

        internal int MergeRules(RulesPart obj, PatternInstanceElement c, string template, bool overwrite)
        {
            if (!String.IsNullOrEmpty(template)) 
            {
                return MergeRules(obj, AppendTemplateOutput(obj.KBObject, obj, c, template), overwrite);                
            }
            return 0;
        }

        internal static int MergeRules(RulesPart obj, string novo, bool overwrite)
        {
            string oldValue = obj.Source;
            obj.Source = MergeTextMarked(obj.Source, novo, overwrite);
            return (oldValue != obj.Source ? 1 : 0);
        }


        internal int MergeProcedureSource(ProcedurePart obj, PatternInstanceElement c, string template, bool overwrite)
        {
            string oldValue = obj.Source;
            if (!String.IsNullOrEmpty(template))
            {
                try
                {
                    HParser pOld = new HParser(obj.Source);
                    HParser pNew = new HParser(AppendTemplateOutput(obj.KBObject, obj, c, template));
                    Dictionary<string, string> sNew = pNew.GetSubs();
                    Dictionary<string, string> sOld = pOld.GetSubs(true, sNew.Keys);
                    pOld.DeleteBlocks(new string[] { "Sub" }, new string[] { "EndSub" });
                    pNew.DeleteBlocks(new string[] { "Sub" }, new string[] { "EndSub" });

                    HParser p = (overwrite ? pNew : pOld);
                    p.ReplaceInsertBlockMarked(HParser.BuildBlockMarked(pNew.Text));
                    p.ClearCode();

                    MergeEventCode(sNew, sOld, "Sub", pNew, pOld, overwrite);

                    obj.Source = p.Text;
                }
                catch (Exception ex)
                {
                    throw new TemplateException(obj.KBObject.Name, ex);
                }

            }
            return (oldValue != obj.Source ? 1 : 0);
        }

        internal int MergeSDTStructure(SDTStructurePart obj, PatternInstanceElement c, string template, bool overwrite)
        {
            string oldValue = getSDTStructure(obj);
            if (!String.IsNullOrEmpty(template))
            {
                string newValue = AppendTemplateOutputXml(obj.KBObject, obj, c, template);
                if (oldValue == newValue)
                {
                    return 0;
                }
                try
                {
                    XmlReader xr = new XmlTextReader(new StringReader(newValue));
                    BLServices.KnowledgeManager.ImportInPart(xr, obj);
                }
                catch (Exception e)
                {
                    throw new TemplateException("ImportInPart - "+template+": "+e.Message, (e.InnerException != null ? e.InnerException : e), obj.KBObject.Name);
                }
            }
            return (oldValue != getSDTStructure(obj) ? 1 : 0);
        }

        internal string getSDTStructure(SDTStructurePart obj)
        {
            StringBuilder sb = new StringBuilder();
            TextWriter tw = new StringWriter(sb);
            obj.Serialize(tw, SerializationMode.FullContent);
            return sb.ToString();
        }

        internal int MergeDataProviderSource(DataProviderSourcePart obj, PatternInstanceElement c, string template, bool overwrite)
        {
            string oldValue = obj.Source;
            if (!String.IsNullOrEmpty(template))
            {
                obj.Source = MergeTextMarked(obj.Source, AppendTemplateOutput(obj.KBObject, obj, c, template),overwrite);
            }
            return (oldValue != obj.Source ? 1 : 0);
        }

        internal int MergeConditions(ConditionsPart obj, PatternInstanceElement c, string template, bool overwrite)
        {
            string oldValue = obj.Source;
            if (!String.IsNullOrEmpty(template))
            {
                obj.Source = MergeTextMarked(obj.Source, AppendTemplateOutput(obj.KBObject, obj, c, template),overwrite);
            }
            if (oldValue != obj.Source)
                return 1;
            return 0;
        }

#region Events

        internal int MergeEvents(EventsPart obj, PatternInstanceElement c, string template, bool overwrite)
        {
            if (!String.IsNullOrEmpty(template))
            {
                return MergeEvents(obj, AppendTemplateOutput(obj.KBObject, obj, c, template), overwrite);
            }
            return 0;
        }

        internal static int MergeEvents(EventsPart obj, string novo, bool overwrite)
        {
            string oldValue = obj.Source;
            HParser pNew = new HParser(novo);
            HParser pOld = new HParser(obj.Source);

            Dictionary<string, string> eNew = null;
            Dictionary<string, string> eOld = null;

            try
            {

                // Eventos
                eNew = pNew.GetEvents();
                eOld = pOld.GetEvents(true, eNew.Keys);
                MergeEventCode(eNew, eOld, "Event", pNew, pOld, overwrite);

                // Subs
                eNew = pNew.GetSubs();
                eOld = pOld.GetSubs(true, eNew.Keys);
                MergeEventCode(eNew, eOld, "Sub", pNew, pOld, overwrite);

                obj.Source = (overwrite ? pNew.Text : pOld.Text);
            }
            catch (Exception e)
            {
                throw new TemplateException("MergeEvents: "+e.Message, (e.InnerException != null ? e.InnerException : e), obj.KBObject.Name);
            }
            return (oldValue != obj.Source ? 1 : 0);
        }

        private static void MergeEventCode(Dictionary<string, string> eNew, Dictionary<string, string> eOld, string tipo, HParser pNew, HParser pOld,bool overwrite)
        {
            foreach (string eNome in eNew.Keys)
            {
                string evento = HParser.BuildBlockMarked(eNew[eNome]);
                if (eOld.ContainsKey(eNome) && overwrite == false)
                {
                    HParser ep = new HParser(eOld[eNome]);
                    ep.ReplaceInsertBlockMarked(evento);
                    evento = ep.Text;
                }
                evento = HParser.BuildBlock(tipo + " " + eNome, "End" + tipo + " // " + eNome, evento);
                HParser p = (overwrite ? pNew : pOld);
                p.ReplaceInsertBlock(new string[] { tipo, eNome }, new string[] { "End" + tipo }, evento);
            }
        }

#endregion

#region Variables

        internal string serializeVariables(VariablesPart obj)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Variable v in obj.Variables)
            {
                sb.Append(v.SerializeToXml());
            }
            return sb.ToString();
        }

        internal int MergeVariables(VariablesPart obj, PatternInstanceElement c, string template, bool overwrite)
        {
            string oldValue = serializeVariables(obj);
            if (overwrite)
            {
                obj.Clear();
            }
            if (!String.IsNullOrEmpty(template))
            {
                XmlDocument x = AppendTemplateOutputInner(obj.KBObject, obj, c, template);
                List<string> tem = new List<string>();
                foreach (XmlNode xn in x.FirstChild.SelectNodes("Variable"))
                {
                    string nome = xn.Attributes["Name"].Value.ToUpper();
                    if (!tem.Contains(nome))
                    {
                        tem.Add(nome);
                        XmlToVariable(obj, c, xn);
                    }
                }
            }
            if (serializeVariables(obj) != oldValue)
            {
                return 1;
            }
            return 0;
        }

        internal void XmlToVariable(VariablesPart obj,PatternInstanceElement c,XmlNode xn)
        {
            string nome = xn.Attributes["Name"].Value;
            bool IsNovo = false;
            if (Variable.IsValidName(nome))
            {
                try
                {
                    Variable var = getVariable(obj, nome, out IsNovo);
                    foreach (XmlNode xi in xn.SelectNodes("Properties/Property"))
                    {
                        string pnome = xi.SelectSingleNode("Name").InnerText;
                        string pvalue = xi.SelectSingleNode("Value").InnerText;                        
                        if (pnome == "ATTCUSTOMTYPE" && pvalue.ToUpper().Trim() == "BITMAP" && GXVersion.Version == GXVersion.Versions.Ev2)
                        {
                            pvalue = "IMAGE";
                        }

                        object vs = var.GetPropertyValueFromString(pnome, pvalue);
                        object v = var.GetPropertyValue(pnome);
                        bool atu = true;
                        if (v != null)
                        {
                            if (vs is AttCustomType)
                            {
                                AttCustomType act = (AttCustomType)vs;
                                AttCustomType act2 = (AttCustomType)v;
                                if (act.DataType == act2.DataType && (act.Guid == act2.Guid || (act.Guid == null && act2.Guid == "")))
                                {
                                    atu = false;
                                }
                            }
                            else if (vs is BasedOnReference)
                            {
                                BasedOnReference bof = (BasedOnReference)vs;
                                BasedOnReference bof2 = (BasedOnReference)v;
                                if (bof.ObjData == bof2.ObjData && bof.ObjKey.Equals(bof2.ObjKey))
                                {
                                    atu = false;
                                }
                            }
                            else if (vs is CT_GXTXVAL_type)
                            {
                                CT_GXTXVAL_type gxt = (CT_GXTXVAL_type)vs;
                                CT_GXTXVAL_type gxt2 = (CT_GXTXVAL_type)v;
                                if (gxt.Data.Count == gxt2.Data.Count)
                                {
                                    atu = false;
                                    foreach (KeyValuePair<string, string> current in gxt.Data)
                                    {
                                        if (!gxt2.Data.Contains(current))
                                        {
                                            atu = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }

                        if (atu && vs != v)
                        {
                            var.SetPropertyValue(pnome, vs);
                        }

                    }
                }
                catch (Exception e)
                {
                    throw new HPatternException(String.Format("Erro ao criar variável: {0}", nome),e);
                }
            }
        }

        internal static Variable getVariable(VariablesPart obj, string nome, out bool IsNovo)
        {
            if (nome.StartsWith("&"))
                nome = nome.Substring(1);
            Variable var = obj.GetVariable(nome);
            if (var == null)
            {
                IsNovo = true;
                var = new Variable(obj);
                var.Name = nome;
                obj.Variables.Add(var);
            }
            else
            {
                IsNovo = false;
                if (var.Name != nome)
                    var.Name = nome;
            }
            return var;
        }

#endregion

#region Template

        internal enum UpdateObject {
            DoNotUpdate,
            CreateDefault,
            OnlySource,
            OverWrite
        }

        internal enum ObjectType
        {
            WebPanel,
            Procedure,
            DataProvider,
            SDT
        }

        
        internal static UpdateObject getUpdate(PatternObject tipo, PatternInstanceElement element)
        {
            string gera = element.Attributes.GetPropertyValueString(getTemplate(tipo).AttributeUpdate);
            UpdateObject uo = UpdateObject.CreateDefault;
            if (gera == TransactionElement.UpdateObjectValue.DoNotUpdate)
            {
                uo = UpdateObject.DoNotUpdate;
            }
            else if (gera == TransactionElement.UpdateObjectValue.Overwrite)
            {
                uo = UpdateObject.OverWrite;
            }
            else if (gera == TransactionElement.UpdateObjectValue.OnlyRulesEventsAndConditions)
            {
                uo = UpdateObject.OnlySource;
            }
            return uo;
        }



        public static void getFactory(PatternInstance instance, InstanceObjects instanceObjects)
        {
            /*
            int mTot = 0;
            foreach (InstanceObject io in instanceObjects)
            {
                mTot++;
            }
            ManualResetEvent[] doneEvents = new ManualResetEvent[mTot];

            int i = 0;
            foreach (InstanceObject io in instanceObjects)
            {
                doneEvents[i] = new ManualResetEvent(false);
                ParserFactory pf = new ParserFactory(instance, io, doneEvents[i]);
                ThreadPool.QueueUserWorkItem(pf.MergeObject, i);
                i++;

            }
            WaitHandle.WaitAll(doneEvents);
            */
            foreach (InstanceObject io in instanceObjects)
            {
                ParserFactory pf = new ParserFactory(instance, io, null);
                pf.MergeObject(null);
            }
        }

        internal void MergeObject(Object threadContext)
        {
            if (GXVersion.IsGenexusServer)
            {
                mIo.SaveObject = false;
            }
            else
            {
                bool saveObject = false;
                ObjectTemplate template = getTemplate(mIo.Object);
                if (template == null)
                {
                    throw new HPatternException("Template não suportado: " + mIo.Object);
                }
                else
                {
                    UpdateObject uo = getUpdate(mIo.Object, mIo.Element);
                    if (uo != UpdateObject.DoNotUpdate)
                    {
                        switch (template.Tipo)
                        {
                            case ObjectType.WebPanel:
                                WebPanel wp = (WebPanel)mIo.GeneratedObject;
                                saveObject = MergeWebPanel(wp, mIo.Element, uo, template);
                                break;

                            case ObjectType.Procedure:
                                Procedure pr = (Procedure)mIo.GeneratedObject;
                                saveObject = MergeProcedure(pr, mIo.Element, uo, template);
                                break;

                            case ObjectType.DataProvider:
                                DataProvider dp = (DataProvider)mIo.GeneratedObject;
                                saveObject = MergeDataProvider(dp, mIo.Element, uo, template);
                                break;

                            case ObjectType.SDT:
                            //    saveObject = true;
                            //    break;
                                SDT sdp = (SDT)mIo.GeneratedObject;
                                saveObject = MergeSDT(sdp, mIo.Element, uo, template);
                                break;

                            //default:
                            //throw new HPatternException("Tipo de Objeto não suportado: " + template.Tipo);
                            //    break;

                        }
                    }
                }
                if (!saveObject)
                {
                    mIo.SaveObject = false;
                }
            }
            if (mDoneEvent != null)
            {
                mDoneEvent.Set();
            }
        }



        private static void LoadTemplate()
        {
            if (listaTemplates == null)
            {
                listaTemplates = new Dictionary<PatternObject, ObjectTemplate>();

                // WebPanel
                addTemplate("",ObjectType.WebPanel, HPatternObject.Selection,GridMultRow.get(), "SelectionWebForm", "SelectionVariables", "SelectionEvents", "SelectionRules", "SelectionConditions");
                addTemplate("", ObjectType.WebPanel, HPatternObject.Prompt, "PromptWebForm", "PromptVariables", "PromptEvents", "PromptRules", "PromptConditions");
                addTemplate("", ObjectType.WebPanel, HPatternObject.TransactionBC, "BCWebForm", "BCVariables", "BCEvents", "BCRules", "BCConditions");
                addTemplate("", ObjectType.WebPanel, HPatternObject.TransactionBCTab, "BCWebForm", "BCVariables", "BCEvents", "BCRules", "BCConditions");
                addTemplate("", ObjectType.WebPanel, HPatternObject.View, "ViewWebForm", "ViewVariables", "ViewEvents", "ViewRules", "ViewConditions");
                addTemplate("", ObjectType.WebPanel, HPatternObject.TabTabular, "TabTabularWebForm", "TabTabularVariables", "TabTabularEvents", "TabTabularRules");
                addTemplate("", ObjectType.WebPanel, HPatternObject.TabGrid,GridMultRow.get(), "TabGridWebForm", "TabGridVariables", "TabGridEvents", "TabGridRules", "TabGridConditions");
                addTemplate("", ObjectType.WebPanel, HPatternObject.TabGridTrn,GridMultRow.get(), "TabGridTrnWebForm", "TabGridTrnVariables", "TabGridTrnEvents", "TabGridTrnRules", "TabGridTrnConditions");
                
                // Procedure
                addTemplate(InstanceAttributes.Selection.UpdateExport, ObjectType.Procedure, HPatternObject.ExportSelection, "ExportProcedure", "ExportVariables", "", "ExportRules");
                addTemplate(InstanceAttributes.Selection.UpdateExport, ObjectType.Procedure, HPatternObject.ExportTabGrid, "ExportProcedure", "ExportVariables", "", "ExportRules");
                addTemplate("", ObjectType.Procedure, HPatternObject.ProcedureSaveBC, "ProcSaveBCProcedure", "ProcSaveBCVariables", "", "ProcSaveBCRules");
                addTemplate("", ObjectType.Procedure, HPatternObject.ProcedureBC, "ProcBCProcedure", "ProcBCVariables", "", "ProcBCRules");

                // Data Provider
                addTemplate(InstanceAttributes.Transaction.UpdateDataProviderAba, ObjectType.DataProvider, HPatternObject.DataProviderDSM, "DPDSMSource", "DPDSMVariables");
                addTemplate(InstanceAttributes.Transaction.UpdateDataProviderAba, ObjectType.DataProvider, HPatternObject.DataProviderDSM2, "DPDSMSource", "DPDSMVariables");
                addTemplate("", ObjectType.DataProvider, HPatternObject.DataProviderBC, "DPSource", "DPVariables", "", "DPRules");

                // SDT
                addTemplate(InstanceAttributes.Transaction.UpdateSDTBC, ObjectType.SDT, HPatternObject.SDTBC, "BCSdtStructure");
                addTemplate(InstanceAttributes.Selection.UpdateSDT, ObjectType.SDT, HPatternObject.GridSDT, "GridSdtStructure");
                addTemplate(InstanceAttributes.Tab.UpdateSDT, ObjectType.SDT, HPatternObject.TabGridSDT, "GridSdtStructure");
                
            }
        }

        internal String AppendTemplateOutput(KBObject obj, KBObjectPart part, PatternInstanceElement element, String template)
        {
            return AppendTemplateOutputInner(obj,part,element,template).InnerText;
        }

        internal String AppendTemplateOutputXml(KBObject obj, KBObjectPart part, PatternInstanceElement element, String template)
        {
            return AppendTemplateOutputInner(obj, part, element, template).InnerXml;
        }

        internal XmlDocument AppendTemplateOutputInner(KBObject obj, KBObjectPart part, PatternInstanceElement element, String template)
        {
            Generator.GeneratorParameters parms = new Generator.GeneratorParameters();
            DefaultProvider.PrepareTemplateParameters(parms);
            parms.Properties["Object"] = obj;
            parms.Properties["Part"] = part;
            parms.Properties["Instance"] = Instance;
            parms.Properties["Element"] = element;
            StringBuilder sb = new StringBuilder();
            Heurys.Patterns.HPattern.HPatternTransactionUpdater.AppendTemplateOutput(sb, template, parms);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(sb.ToString());
            return xmlDocument;
        }
                
        internal interface IDeleteVariables
        {
            int DeleteVariables(PatternInstanceElement element, KBObject obj, bool overwrite);
        }

        internal class GridMultRow : IDeleteVariables
        {
            public static IDeleteVariables get()
            {
                return new GridMultRow();
            }

            public int DeleteVariables(PatternInstanceElement element, KBObject obj, bool overwrite)
            {
                int ret = 0;
                if (obj is WebPanel 
                    && (element.Type == InstanceElements.Selection || element.Type == InstanceElements.Tab)
                    && element.SelectElements("actions/action[@multiRowSelection=\"True\"]").Count == 0)
                {
                    bool canDelete = true;
                    WebPanel webp = (WebPanel)obj;

                    if (overwrite == false)
                    {
                        if (webp.Events.Source.IndexOf("&SelectedRows.") >= 0)
                        {
                            canDelete = false;
                        }
                        else if (webp.Events.Source.IndexOf("&SelectedRow.") >= 0)
                        {
                            canDelete = false;
                        }
                    }
                    if (canDelete)
                    {                        
                        Variable var = webp.Variables.GetVariable("SelectedRows");
                        if (var != null)
                        {
                            ret = 1;
                            webp.Variables.Remove(var);
                        }
                        var = null;
                        var = webp.Variables.GetVariable("SelectedRow");
                        if (var != null)
                        {
                            ret = 1;
                            webp.Variables.Remove(var);
                        }
                    }
                }

                return ret;
            }
        }

        internal class ObjectTemplate
        {
            private string webForm="";
            private string variables="";
            private string events="";
            private string rules="";
            private string conditons="";
            private string attUpdate= "";
            private ObjectType tipo;
            private IDeleteVariables mDelVar=null;

            public ObjectType Tipo
            {
                get { return tipo; }
            }

            public string AttributeUpdate
            {
                get { return attUpdate; }
            }

            public string Source
            {
                get { return webForm; }
            }

            public string WebForm
            {
                get { return webForm; }
            }

            public string Variables
            {
                get { return variables; }
            }

            public string Events
            {
                get { return events; }
            }


            public string Conditons
            {
                get { return conditons; }
            }

            public string Rules
            {
                get { return rules; }
            }

            internal int DeleteVariables(PatternInstanceElement element, KBObject obj, bool overwrite)
            {
                if (mDelVar != null) {
                    return mDelVar.DeleteVariables(element, obj, overwrite);
                }
                return 0;
            }

            public ObjectTemplate(String matt, ObjectType otipo, IDeleteVariables delVar, params string[] templs) 
                : this(matt,otipo,templs)
            {                
                mDelVar = delVar;
            }

            public ObjectTemplate(String matt,ObjectType otipo,params string[] templs)
            {
                if (String.IsNullOrEmpty(matt))
                {
                    matt = InstanceAttributes.Transaction.UpdateObject;
                }
                attUpdate = matt;
                tipo = otipo;
//              WebForm, Variables, Events, Rules, Conditions
                if (templs.Length > 0)
                    webForm = templs[0];
                if (templs.Length > 1)
                    variables = templs[1];
                if (templs.Length > 2)
                    events = templs[2];
                if (templs.Length > 3)
                    rules = templs[3];
                if (templs.Length > 4)
                    conditons = templs[4];
            }
        }

        internal static ObjectTemplate getTemplate(PatternObject mtipo)
        {
            ObjectTemplate ot = null;
            LoadTemplate();
            if (listaTemplates.ContainsKey(mtipo))
            {
                ot = listaTemplates[mtipo];
            }
            return ot;
        }

        private static void addTemplate(String attUpdate, ObjectType tipo, PatternObject mtipo, params string[] templs)
        {
            listaTemplates.Add(mtipo, new ObjectTemplate(attUpdate, tipo, templs));
        }

        private static void addTemplate(String attUpdate, ObjectType tipo, PatternObject mtipo, IDeleteVariables delVar, params string[] templs)
        {
            listaTemplates.Add(mtipo, new ObjectTemplate(attUpdate, tipo, delVar, templs));
        }

        private static Dictionary<PatternObject, ObjectTemplate> listaTemplates = null;


#endregion

    }


}
