using System;
using System.Collections.Generic;
using System.Xml;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common;
using Artech.Genexus.Common.Objects;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Objects;

namespace Heurys.Patterns.HPattern
{
	internal class HPatternImportHelper : PatternImportHelper
	{
		public HPatternImportHelper()
			: base(HPatternPattern.Definition) { }

		public override KBObjectNameKey GetParentObject(KBModel model, OldInstanceFile instanceFile)
		{            
			XmlElement transactionElement = (XmlElement)instanceFile.Document.SelectSingleNode("/instance/transaction");
			if (transactionElement != null)
			{
				string trnName = transactionElement.GetAttribute("name");
				if (!String.IsNullOrEmpty(trnName))
				{
					trnName = ConvertReferenceToName(trnName);
					return new KBObjectNameKey(model, ObjClass.Transaction, trnName);
				}
			}

			return null;
		}

        public override void ConvertDocument(OldInstanceFile instanceFile)
		{

			RemoveEmptyAttributes(instanceFile.Document.DocumentElement, "//*");

			// Convert all references.
            ConvertReferences(instanceFile.Document.DocumentElement, "//transaction", "name", ObjClass.Transaction);
            ConvertReferences(instanceFile.Document.DocumentElement, "//attributes/attribute", "name", ObjClass.Attribute);
            ConvertReferences(instanceFile.Document.DocumentElement, "/instance/level/descriptionAttribute", "name", ObjClass.Attribute);
            ConvertReferences(instanceFile.Document.DocumentElement, "//order/orderAttribute", "name", ObjClass.Attribute);
            ConvertReferences(instanceFile.Document.DocumentElement, "//actions/action", "gxobject", Guid.Empty);
            ConvertReferencesToNames(instanceFile.Document.DocumentElement, "//filterAttributes/filterAttribute", "name");
            ConvertReferences(instanceFile.Document.DocumentElement, "//filterAttributes/filterAttribute", "domain", ObjClass.Domain);
            ConvertReferences(instanceFile.Document.DocumentElement, "//filterAttributes/filterAttribute", "prompt", ObjClass.WebPanel);
            ConvertReferencesToNames(instanceFile.Document.DocumentElement, "//parameters/parameter", "name");
            ConvertReferences(instanceFile.Document.DocumentElement, "//parameters/parameter", "domain", ObjClass.Domain);
            ConvertReferencesToNames(instanceFile.Document.DocumentElement, "//view", "caption");

			// Rename attributes.
            RenameAttributes(instanceFile.Document.DocumentElement, "//transaction", "name", "transaction");
            RenameAttributes(instanceFile.Document.DocumentElement, "//attributes/attribute", "name", "attribute");
            RenameAttributes(instanceFile.Document.DocumentElement, "//level/descriptionAttribute", "name", "attribute");
            RenameAttributes(instanceFile.Document.DocumentElement, "//orderAttribute", "name", "attribute");

			// Rename elements.
            RenameElements(instanceFile.Document.DocumentElement, "//order/orderAttribute", "attribute");
            RenameElements(instanceFile.Document.DocumentElement, "//filter/filterAttributes", "attributes");

			// Remove elements.
            RemoveElements(instanceFile.Document.DocumentElement, "//transaction/parameters");
            RemoveElements(instanceFile.Document.DocumentElement, "/instance/level/prompt");
		}

		public override void PostConvertInstance(PatternInstance instance, OldInstanceFile instanceFile)
		{
			int iLevel = 1;
			foreach (PatternInstanceElement levelElement in instance.PatternPart.RootElement.SelectElements("level"))
				levelElement.Attributes["id"] = String.Format("{0}:{1}", instance.Parent.Guid, iLevel++);
		}

        public override IEnumerable<KBObjectNameKey> GetObsoleteObjects(PatternInstance instance, OldInstanceFile instanceFile)
		{
			Transaction parentTransaction = (instance.KBObject as Transaction);
			if (parentTransaction != null)
				yield return new KBObjectNameKey(instance.Model, ObjClass.WebPanel, "Controller" + parentTransaction.Name);
		}
	}
}
