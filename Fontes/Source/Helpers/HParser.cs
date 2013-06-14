using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Heurys.Patterns.HPattern.Helpers
{
    internal class HParser : BasicParser
    {
        private static string k_GeneratedMarkerStart = HPatternTransactionUpdater.k_GeneratedMarkerStart;
        private static string k_GeneratedMarkerEnd = HPatternTransactionUpdater.k_GeneratedMarkerEnd;

        public HParser(string text) : base(text)
        {
            // fazer oque aqui ?
        }

        public static string BuildBlock(string Start,string End,string textBlock)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Start + Environment.NewLine);
            sb.Append(textBlock);
            sb.Append(Environment.NewLine + End);
            return sb.ToString();
        }

        public static string BuildBlockMarked(string textBlock)
        {
            return BuildBlock(k_GeneratedMarkerStart, k_GeneratedMarkerEnd, textBlock);
        }

        internal void ReplaceInsertBlockMarked(string newBlock)
        {
            ReplaceInsertBlock(new string[] { k_GeneratedMarkerStart }, new string[] { k_GeneratedMarkerEnd }, newBlock);
        }

        internal void ReplaceInsertBlock(string[] startTokens, string[] endTokens,string newBlock)
        {
            if (!base.ReplaceBlock(startTokens, endTokens, newBlock))
            {
                InsertAfter(newBlock + Environment.NewLine);
            }
        }

        public void InsertAfter(string block)
        {           
            string[] blockLines = DivideLines(block);
            int newTextLength = base.MText.Length + blockLines.Length;
            string[] newText = new string[newTextLength];

            for (int i = 0; i < newTextLength; i++)
            {
                if (i < base.MText.Length)
                    newText[i] = base.MText[i];
                else
                    newText[i] = blockLines[i - base.MText.Length];
            }

            base.MText = newText;
        }

        internal Dictionary<string, string> GetEvents()
        {
            return GetBlockCode("Event", "EndEvent",false,null);
        }

        internal Dictionary<string, string> GetSubs()
        {
            return GetBlockCode("Sub", "EndSub",false,null);
        }

        internal Dictionary<string, string> GetEvents(bool deleteEmpty,ICollection<String> lNew)
        {
            return GetBlockCode("Event", "EndEvent", deleteEmpty, lNew);
        }

        internal Dictionary<string, string> GetSubs(bool deleteEmpty, ICollection<String> lNew)
        {
            return GetBlockCode("Sub", "EndSub", deleteEmpty, lNew);
        }

        internal string[] GetEventBlocks(string[] startTokens, string[] endTokens, int startAtLine, bool checkNotCommented)
        {
            return GetBlocks(startTokens, endTokens, startAtLine, checkNotCommented);
        }

        internal Dictionary<string, string> GetBlockCode(string Start, string End, bool deleteEmpty, ICollection<String> lNew)
        {
            Dictionary<string, string> events = new Dictionary<string, string>();
            string[] eNew = GetEventBlocks(new string[] { Start }, new string[] { End }, 0, true);
            foreach (string eve in eNew)
            {
                Regex rx = new Regex(Start + "[ ]+(&?[\\w.-_]+[ ]?[\\w.-_]+|(['\"])[^'\"]+\\2)", RegexOptions.IgnoreCase);
                MatchCollection ec = rx.Matches(eve);
                string nome = String.Empty;
                if (ec.Count > 0)
                {
                    nome = ec[0].Groups[1].Value;
                }
                if (!String.IsNullOrEmpty(nome))
                {
                    string iBlock = InnerBlock(new string[] {Start,nome},new string[] {End},eve);
                    if (deleteEmpty && isBlockEmpty(iBlock) && !lNew.Contains(nome))
                    {
                        DeleteBlock(new string[] { Start, nome }, new string[] { End });
                        ClearCode();
                    } 
                    else 
                    {
                        events.Add(nome, iBlock);
                }
            }
            }
            return events;
        }

        internal void ClearCode()
        {
            List<string> newText = new List<string>();
            bool isStart = false;
            int nlinha=0;
            int range=0;
            for (int i = 0; i < MText.Length; i++)
            {
                string linha = MText[i];
                newText.Add(linha);
                if (isStart == false)
                {
                    if (i == 0 && String.IsNullOrEmpty(linha))
                    {
                        isStart = true;
                        nlinha = range-1;
                    } else if (LineContainsTokens(linha,new string[]{"EndSub"},false) 
                        || LineContainsTokens(linha,new string[]{"EndEvent"},false)
                        || LineContainsTokens(linha, new string[] { k_GeneratedMarkerEnd }, false))
                    {
                        
                        isStart = true;
                        nlinha = range;
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(linha))
                    {
                        if (LineContainsTokens(linha, new string[] { "Sub" }, false)
                            || LineContainsTokens(linha, new string[] { "Event" }, false)
                            || LineContainsTokens(linha, new string[] { k_GeneratedMarkerStart }, false))
                        {
                            isStart = false;
                            int posini = nlinha + 1;
                            int qtde = range-posini;
                            qtde--;
                            if (qtde > 1)
                            {
                                newText.RemoveRange(posini+1, qtde);
                                range = range - qtde;
                            }
                        }
                    }
                }
                range++;
            }
            if (isStart)
            {
                isStart = false;
                int posini = nlinha + 1;
                int qtde = range - posini;
                qtde--;
                if (qtde > 1)
                {
                    newText.RemoveRange(posini+1, qtde);
                    range = range - qtde;
                }
            }
            MText = newText.ToArray();
        }

        internal bool isBlockEmpty(string block)
        {
            bool ret = false;
            HParser hp = new HParser(block);
            if (hp.DeleteBlock(new string[] { k_GeneratedMarkerStart }, new string[] { k_GeneratedMarkerEnd }))
            {
                if (String.IsNullOrEmpty(hp.Text))
                {
                    ret = true;
                }
            }
            return ret;
        }

        private string InnerBlock(string[] Start,string[] End,string text)
        {
            string[] lins = DivideLines(text);
            int tam = lins.Length;
            List<string> ret = new List<string>();
            bool grava = false;
            for (int i = 0; i < tam; i++)
            {
                string linha = lins[i];
                if (grava == true && LineContainsTokens(linha, End, false))
                {
                    grava = false;
                    break;
                }
                if (grava)
                {
                    ret.Add(linha);
                }
                if (grava == false && LineContainsTokens(linha, Start, false))
                {
                    grava = true;
                }              
            }
            return String.Join(Environment.NewLine, ret.ToArray());
        }


    }
}
