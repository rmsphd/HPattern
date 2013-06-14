using System;
using System.Collections.Generic;
using System.Text;
using Artech.Architecture.Common.Defaults;
using Artech.Architecture.Common.Descriptors;
using Artech.Architecture.Common.Objects;
using Artech.Architecture.UI.Framework.Services;
using Artech.Genexus.Common;
using Artech.Genexus.Common.Objects;
using Artech.Genexus.Common.Parts;
using Artech.Genexus.Common.Types;
using System.Runtime.InteropServices;

namespace Heurys.Patterns.HPatternTemplate
{
    [KBObjectComposition(true, new Type[]{typeof(DocumentationPart)})]
    [Guid("a25a762b-96bc-4326-bd7b-184eb81d9a08")]
    [KBObjectDescriptor("2d6e6420-8d0f-443d-901b-b6a731523ecc", "HPatternTemplate", 
            "HPatternTemplate", "Heurys.Patterns.HPatternTemplate.Resources, Heurys")]	

    public class HPatternTemplate : WebPanel
    {
        public HPatternTemplate(KBModel model) : base(model)
		{
            base.SetPropertyValue(Artech.Genexus.Common.Properties.WBP.GenerateObject, false);
		}        


    }
}
