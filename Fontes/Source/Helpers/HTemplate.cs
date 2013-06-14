using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Heurys.Patterns.HPattern.Helpers
{
    public class HTemplate
    {
        private Dictionary<string, string> mAttributes = new Dictionary<string, string>();
        private Dictionary<string, string> mPosicoes = new Dictionary<string, string>();
        private Dictionary<string, string> mGroupPosicoes = new Dictionary<string, string>();
        private string mTemplate;

        public HTemplate(string template)
        {
            mTemplate = template;
            preProcessor();
            preGroupProcessor();
        }

        private void preGroupProcessor()
        {
            // Exemplo
            // gxHPatternGroupUC
            int posini = mTemplate.IndexOf("<gxHPatternGroupUC", 0);
            int posfim;

            while (posini >= 0)
            {
                posfim = mTemplate.IndexOf("</gxHPatternGroupUC>", posini);
                posfim = (posfim - posini) + 20;

                string campouc = mTemplate.Substring(posini, posfim);
                //temp = {posini,posfim};
                mGroupPosicoes.Add(identificaNome(campouc), campouc);
                // próximo campo
                posini++;
                posini = mTemplate.IndexOf("<gxHPatternGroupUC", posini);
            }
        }

        private void preProcessor()
        {
            // Exemplo
            // "<gxHPatternUC Component="Filters" ControlName="HPatternUC4" />"
            int posini = mTemplate.IndexOf("<gxHPatternUC", 0);                                             
            int posfim;
           
            while (posini >= 0)
            {
                posfim = mTemplate.IndexOf("/>", posini);
                posfim = (posfim-posini)+2;

                string campouc = mTemplate.Substring(posini, posfim);
                //temp = {posini,posfim};
                mPosicoes.Add(identificaNome(campouc), campouc);
                // próximo campo
                posini++;
                posini = mTemplate.IndexOf("<gxHPatternUC", posini);                
            }
        }

        private string identificaNome(string campouc)
        {
            string nome = "";
            int posini = campouc.IndexOf("Component=", 0);
            posini += 11;
            int posfim = campouc.IndexOf("\"", posini);
            nome = campouc.Substring(posini, (posfim - posini));
            return nome;
        }

        private HTemplate(string template, Dictionary<string, string> posicoes, Dictionary<string, string> groupPosicoes)
        {
            mTemplate = template;
            mPosicoes = posicoes;
            mGroupPosicoes = groupPosicoes;
        }

        internal void SetAttribute(SelTemplate sc, string Conteudo)
        {
            SetAttribute(sc.ToString(), Conteudo);
        }

        private void SetAttribute(string chave, string Conteudo)
        {
            mAttributes.Add(chave, Conteudo);
        }

        public override string ToString()
        {
            string saida = (string)mTemplate.Clone();
            string value = "";

            // Vamos retirar os grupos que não se aplicam e colocar o conteudo do grupo que se aplica
            foreach (KeyValuePair<string, string> item in mGroupPosicoes)
            {
                if (mAttributes.ContainsKey(item.Key))
                {
                    saida = saida.Replace(item.Value, getGroupValue(item.Value));
                }
                else
                {
                    saida = saida.Replace(item.Value, "");
                }
            }

            // Vamos fazer a macro substituição dos valores
            foreach (KeyValuePair<string, string> item in mPosicoes)
            {
                value = "";
                if (mAttributes.ContainsKey(item.Key))
                {
                    value = mAttributes[item.Key];
                    
                }
                saida = saida.Replace(item.Value, value);
            }            

            return saida;
        }

        private string getGroupValue(string group)
        {
            string ret=group;
            int posini = ret.IndexOf("<gxHPatternGroupUC", 0);
            int posfim;

            if (posini >= 0)
            {
                posfim = ret.IndexOf(">", posini);
                posfim = (posfim - posini) + 1;

                string campouc = ret.Substring(posini, posfim)+"<container containerId=\"HPatternGroupUCId\">";
                ret = ret.Replace(campouc, "");
            }
            ret = ret.Replace("</container></gxHPatternGroupUC>", "");
            return ret;
        }

        public HTemplate Clone()
        {
            return new HTemplate(mTemplate, mPosicoes,mGroupPosicoes);
        }

    }

    public enum ObjTemplate
    {
        SelectionTemplate,
        TransactionTemplate,
        DocTemplate,
        ViewTemplate,
        PromptTemplate
    }

    public enum SelTemplate
    {
        Title,
        TitleImage,
        Description,
        Filters,
        FilterButtons,
        FilterCollapseImage,
        GridPaging,
        GridPagingFirst,
        GridPagingPrevious,
        GridPagingNext,
        GridPagingLast,
        GridExport,
        Currentpage,
        MaxPage,
        GridButtons,
        Grid,
        FooterButtons,
        Footer,
        Tabs,
        Transaction,
        Toolbar,
        Attributes,
        ButtonEnter,
        ButtonCancel,
        ButtonHelp,
        ButtonDelete,
        ButtonAction,
        Author,
        Date,
        ObjectDescription,
        ObjectName,
        Observation,
        Requirement,
        SystemDescription,
        ViewHeader,
        ViewAll,
        MaxRecords,
        PageRecords,
        CheckAll,
        SelectedRecords
    }

}
