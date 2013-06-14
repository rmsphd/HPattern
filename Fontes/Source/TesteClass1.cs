using System;
using System.Diagnostics;
using System.Text;
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

namespace Heurys.Patterns.HPattern
{
    class TesteClass1
    {

        public void Teste() {
            
            KBModel model = null;
            Transaction t = new Transaction(model);

            /*
            
            WebPanel web = new WebPanel(model);
            web.WebForm.IsDefault;
            */
            
            /*
            Properties.HTMLATT.ReadOnly =
            Properties.HTMLATT.Format = Properties.HTMLATT.Format_Values.Text;
            Properties.HTMLATT.Format = Properties.HTMLATT.Format_Values.Html;
            Properties.HTMLATT.Format = Properties.HTMLATT.Format_Values.RawHtml;
            Properties.HTMLATT.Format = Properties.HTMLATT.Format_Values.TextWithMeaningfulSpaces;
            

            Dictionary<String,Object> dict = new Dictionary<string,object>();
            dict[Properties.HTMLSFLCOL.OnClickEvent] = "";
            WebForm.GridVariable("teste", null, String.Empty, true, null, dict);
             */

            //StringBuilder sb = new StringBuilder();
            
        }
    }
}
