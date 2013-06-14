using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Heurys.Patterns.HPattern
{

	public partial class ConditionElement : IHPatternInstanceElement
	{

        private string GetFilter(int tipo)
        {
            string tipo1 = "";
            string tipo2 = "";
            string tipo3 = "";
            if (this.Instance.Settings.Grid.ChangeLikeInVariableAux)
            {
                string tvalue = this.Value.ToLower();
                string t1 = "";
                bool sai = true;
                string[] sc = { " when " };
                string[] split = tvalue.Split(sc, StringSplitOptions.None);
                if (split.Length > 0)
                    t1 = split[0];

                if (t1.IndexOf(" like ") >= 0 && t1.IndexOf("+") >= 0 && (t1.IndexOf("'") >= 0 || t1.IndexOf("\"") >= 0))
                {
                    string[] regex = {
                    "([a-zA-Z0-9_]*[(]*[a-zA-Z0-9_]+[a-zA-Z0-9_]*[)]*)",
                    "([ ]+like[ ]+)",
                    "([a-zA-Z0-9_]+[(]*)*",
                    "(['\"]?[a-zA-Z0-9_ %]*['\"]?[ ]*[+]?[ ]*[&][a-zA-Z0-9_]+)",
                    "([ ]*[.]?[&]?[a-zA-Z0-9_(]*[)|'|\"]+)?",
                    "([ ]+when[ ]+)?",
                    "([ ]*[&]?[a-zA-Z0-9_.()]+[.()]*)*",
                    "([;])?"}; 
                    string ptregex = regex[0]+regex[1]+regex[2]+regex[3]+regex[4]+regex[5]+regex[6]+regex[7];
                    Regex r = new Regex(ptregex, RegexOptions.IgnoreCase);

                    bool passoulike = false;
                    bool passouwhen = false;
                    string ret = "";                    

                    MatchCollection mc = r.Matches(this.Value);
                    
                    foreach (Match m in mc)
                    {
                        foreach (Group gt in m.Groups)
                        {
                            foreach (Capture g in gt.Captures)
                            {                                
                                if (!g.Value.Equals(this.Value))
                                {
                                    if (passoulike == false && Regex.IsMatch(g.Value, regex[1], RegexOptions.IgnoreCase)) // Like                                
                                        passoulike = true;
                                    if (passouwhen == false && Regex.IsMatch(g.Value, "([ ]+when[ ]+)", RegexOptions.IgnoreCase)) // when
                                        passouwhen = true;
                                    if (passoulike == true && passouwhen == false)
                                    {
                                        if (Regex.IsMatch(g.Value, regex[3], RegexOptions.IgnoreCase)) // '%'+&variavel+'%'
                                        {
                                            string[] regex2 = {
                                            "(['\"]?[a-zA-Z0-9_ %]*['\"]?[ ]*[+]?[ ]*)*",
                                            "([&][a-zA-Z0-9_]+)",
                                            "([ ]*[+]?[ ]*['\"]?[a-zA-Z0-9_ %]*['\"]?[ ]*)*"};
                                            string ptregex2 = regex2[0] + regex2[1] + regex2[2];
                                            foreach (Match c2 in Regex.Matches(g.Value, ptregex2, RegexOptions.IgnoreCase))
                                            {
                                                foreach (Group g2 in c2.Groups)
                                                {
                                                    foreach (Capture c in g2.Captures)
                                                    {
                                                        if (!c.Value.Equals(g.Value))
                                                        {
                                                            if (Regex.IsMatch(c.Value, regex2[1]))
                                                            {
                                                                ret += c.Value + "Aux";
                                                                tipo2 = c.Value + "Aux";
                                                                tipo3 = c.Value.Replace("&","");
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            tipo2 += " = " + g.Value;
                                        }
                                        else
                                        {
                                            ret += g.Value;
                                        }
                                    }
                                    else
                                    {
                                        ret += g.Value;
                                    }
                                }
                            }
                        }
                        tipo1 = ret;
                        sai = false;
                    }

                }
                if (sai)
                {
                    tipo1 = this.Value;
                }

            }
            else
            {
                tipo1 = this.Value;
            }
            if (tipo == 1)
            {
                return tipo1;
            }
            else
            {
                if (tipo == 2)
                {
                    return tipo2;
                }
                else
                {
                    return tipo3;
                }
            }
        }


        public string FilterConditionLike
        {
            get
            {
                return GetFilter(1);
            }
        }

        public string FilterConditionRefresh
        {
            get
            {
                return GetFilter(2);
            }
        }

        public string FilterConditionVariable
        {
            get
            {
                return GetFilter(3);
            }
        }

    }
}
