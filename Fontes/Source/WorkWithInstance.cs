// Pattern Instance class for pattern HPattern (Heurys)
// Generated on 16/01/2013 17:16:48 by PatternCodeGen

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Artech.Common.Collections;
using Artech.Common.Diagnostics;
using Artech.Architecture.Common.Objects;
using Artech.Packages.Patterns;
using Artech.Packages.Patterns.Objects;

namespace Heurys.Patterns.HPattern
{
	#region Instance class

	public partial class HPatternInstance : IHPatternInstanceElement
	{
		private readonly KBModel m_Model;
		private int m_Id;
		private string m_Name;
		protected string m_ElementName;
		private System.String m_UpdateTransaction;
		private bool m_IsUpdateTransactionDefault;
		private System.String m_UpdateWebPanelBC;
		private bool m_IsUpdateWebPanelBCDefault;
		private System.String m_AfterInsert;
		private bool m_IsAfterInsertDefault;
		private System.String m_AfterUpdate;
		private bool m_IsAfterUpdateDefault;
		private System.String m_AfterDelete;
		private bool m_IsAfterDeleteDefault;
		private System.String m_SecurityId;
		private bool m_IsSecurityIdDefault;
		private DocumentationElement m_Documentation;
		private TransactionElement m_Transaction;
		private Artech.Common.Collections.BaseCollection<LevelElement> m_Levels;
		private WebPanelRootElement m_WebPanelRoot;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="HPatternInstance"/> class.
		/// </summary>
		public HPatternInstance(KBModel model)
		{
			m_Model = model;
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="HPatternInstance"/> class, loading its data from the specified Instance object.
		/// </summary>
		public HPatternInstance(PatternInstance instance)
			: this(instance.Model)
		{
			LoadFrom(instance);
		}

		/// <summary>
		/// Initializes this instance of the <see cref="HPatternInstance"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_UpdateTransaction = "Only rules and events";
			m_IsUpdateTransactionDefault = true;
			m_UpdateWebPanelBC = "Default";
			m_IsUpdateWebPanelBCDefault = true;
			m_AfterInsert = "<default>";
			m_IsAfterInsertDefault = true;
			m_AfterUpdate = "<default>";
			m_IsAfterUpdateDefault = true;
			m_AfterDelete = "<default>";
			m_IsAfterDeleteDefault = true;
			m_SecurityId = "default";
			m_IsSecurityIdDefault = true;
			m_Documentation = new DocumentationElement();
			m_Documentation.Parent = this;
			m_Transaction = null;
			m_Levels = new Artech.Common.Collections.BaseCollection<LevelElement>();
			m_Levels.ItemAdded += new EventHandler<CollectionItemEventArgs<LevelElement>>(Levels_ItemAdded);
			m_WebPanelRoot = null;
		}

		#endregion

		#region Properties

		public KBModel Model
		{
			get { return m_Model; }
		}

		public int Id
		{
			get { return m_Id; }
		}

		public string Name
		{
			get { return m_Name; }
		}

		private Artech.Architecture.Common.Objects.KBObject m_ParentObject;

		public Artech.Architecture.Common.Objects.KBObject ParentObject
		{
			get { return m_ParentObject; }
			private set { m_ParentObject = value; }
		}

		HPatternInstance IHPatternInstanceElement.Instance
		{
			get { return this; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return null; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Generate a default web form for all transactions used in this instance (to customize the generation, edit the corresponding template).
		*/
		/// </summary>
		public System.String UpdateTransaction
		{
			get { return m_UpdateTransaction; }
			set 
			{
				m_UpdateTransaction = value;
				m_IsUpdateTransactionDefault = false;
			}
		}

		/// <summary>
		/*
		Atualiza WebPanel BC ao aplicar o pattern, somente funciona quando a opção da Configuração Geral WebPanelBCDefault é False
		*/
		/// </summary>
		public System.String UpdateWebPanelBC
		{
			get { return m_UpdateWebPanelBC; }
			set 
			{
				m_UpdateWebPanelBC = value;
				m_IsUpdateWebPanelBCDefault = false;
			}
		}

		/// <summary>
		/*
		Action performed after inserting a record.
		/// &lt;default&gt; uses configuration file value.
		*/
		/// </summary>
		public System.String AfterInsert
		{
			get { return m_AfterInsert; }
			set 
			{
				m_AfterInsert = value;
				m_IsAfterInsertDefault = false;
			}
		}

		/// <summary>
		/*
		Action performed after updating a record.
		/// &lt;default&gt; uses configuration file value.
		*/
		/// </summary>
		public System.String AfterUpdate
		{
			get { return m_AfterUpdate; }
			set 
			{
				m_AfterUpdate = value;
				m_IsAfterUpdateDefault = false;
			}
		}

		/// <summary>
		/*
		Action performed after deleting a record.
		/// &lt;default&gt; uses configuration file value.
		*/
		/// </summary>
		public System.String AfterDelete
		{
			get { return m_AfterDelete; }
			set 
			{
				m_AfterDelete = value;
				m_IsAfterDeleteDefault = false;
			}
		}

		/// <summary>
		/*
		Código de segurança a ser utilizado
		*/
		/// </summary>
		public System.String SecurityId
		{
			get { return m_SecurityId; }
			set 
			{
				m_SecurityId = value;
				m_IsSecurityIdDefault = false;
			}
		}

		public DocumentationElement Documentation
		{
			get { return m_Documentation; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Documentation = value;
				m_Documentation.Parent = this;
			}
		}

		public TransactionElement Transaction
		{
			get { return m_Transaction; }
			set
			{
				m_Transaction = value;
				m_Transaction.Parent = this;
			}
		}

		public Artech.Common.Collections.IBaseCollection<LevelElement> Levels
		{
			get { return m_Levels; }
		}

		public WebPanelRootElement WebPanelRoot
		{
			get { return m_WebPanelRoot; }
			set
			{
				m_WebPanelRoot = value;
				m_WebPanelRoot.Parent = this;
			}
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="LevelElement"/> and adds it to the <see cref="Levels"/> collection.
		/// </summary>
		public LevelElement AddLevel()
		{
			LevelElement levelElement = new LevelElement();
			m_Levels.Add(levelElement);
			return levelElement;
		}

		/// <summary>
		/// Creates a new <see cref="LevelElement"/> and adds it to the <see cref="Levels"/> collection.
		/// The LevelElement is initialized with the specified value.
		/// </summary>
		public LevelElement AddLevel(System.String id)
		{
			LevelElement levelElement = new LevelElement(id);
			m_Levels.Add(levelElement);
			return levelElement;
		}

		/// <summary>
		/// Finds the <see cref="LevelElement"/> in the <see cref="Levels"/> collection that has the specified value in its <see cref="Id"/> property.
		/// If no levelElement is found, null is returned.
		/// </summary>
		public LevelElement FindLevel(System.String id)
		{
			return Levels.Find(delegate (LevelElement levelElement) { return levelElement.Id == id; });
		}

		private void Levels_ItemAdded(object sender, CollectionItemEventArgs<LevelElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		private void LoadFrom(PatternInstance instance)
		{
			Initialize();
			m_Id = instance.Id;
			m_Name = instance.Name;
			LoadFrom(instance.PatternPart.RootElement);
			ParentObject = (Artech.Architecture.Common.Objects.KBObject)instance.KBObject;
		}

		public void SaveTo(PatternInstance instance)
		{
			SaveTo(instance.PatternPart.RootElement);
		}

		/// <summary>
		/// Loads the current <see cref="HPatternInstance"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Instance")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Instance"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_UpdateTransaction = element.Attributes.GetPropertyValue<System.String>("updateTransaction");
			m_IsUpdateTransactionDefault = element.Attributes.IsPropertyDefault("updateTransaction");
			m_UpdateWebPanelBC = element.Attributes.GetPropertyValue<System.String>("updateWebPanelBC");
			m_IsUpdateWebPanelBCDefault = element.Attributes.IsPropertyDefault("updateWebPanelBC");
			m_AfterInsert = element.Attributes.GetPropertyValue<System.String>("afterInsert");
			m_IsAfterInsertDefault = element.Attributes.IsPropertyDefault("afterInsert");
			m_AfterUpdate = element.Attributes.GetPropertyValue<System.String>("afterUpdate");
			m_IsAfterUpdateDefault = element.Attributes.IsPropertyDefault("afterUpdate");
			m_AfterDelete = element.Attributes.GetPropertyValue<System.String>("afterDelete");
			m_IsAfterDeleteDefault = element.Attributes.IsPropertyDefault("afterDelete");
			m_SecurityId = element.Attributes.GetPropertyValue<System.String>("securityId");
			m_IsSecurityIdDefault = element.Attributes.IsPropertyDefault("securityId");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "Documentation" :
					{
						DocumentationElement documentation = new DocumentationElement();
						documentation.LoadFrom(_childElement);
						Documentation = documentation;
						break;
					}
					case "transaction" :
					{
						TransactionElement transaction = new TransactionElement();
						transaction.LoadFrom(_childElement);
						Transaction = transaction;
						break;
					}
					case "level" :
					{
						LevelElement level = new LevelElement();
						level.LoadFrom(_childElement);
						Levels.Add(level);
						break;
					}
					case "webPanelRoot" :
					{
						WebPanelRootElement webPanelRoot = new WebPanelRootElement();
						webPanelRoot.LoadFrom(_childElement);
						WebPanelRoot = webPanelRoot;
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="HPatternInstance"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Instance")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Instance"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "updateTransaction", m_UpdateTransaction, m_IsUpdateTransactionDefault);
			SaveAttribute(element, "updateWebPanelBC", m_UpdateWebPanelBC, m_IsUpdateWebPanelBCDefault);
			SaveAttribute(element, "afterInsert", m_AfterInsert, m_IsAfterInsertDefault);
			SaveAttribute(element, "afterUpdate", m_AfterUpdate, m_IsAfterUpdateDefault);
			SaveAttribute(element, "afterDelete", m_AfterDelete, m_IsAfterDeleteDefault);
			SaveAttribute(element, "securityId", m_SecurityId, m_IsSecurityIdDefault);

			Debug.Assert(m_UpdateTransaction == element.Attributes.GetPropertyValue<System.String>("updateTransaction"));
			Debug.Assert(m_UpdateWebPanelBC == element.Attributes.GetPropertyValue<System.String>("updateWebPanelBC"));
			Debug.Assert(m_AfterInsert == element.Attributes.GetPropertyValue<System.String>("afterInsert"));
			Debug.Assert(m_AfterUpdate == element.Attributes.GetPropertyValue<System.String>("afterUpdate"));
			Debug.Assert(m_AfterDelete == element.Attributes.GetPropertyValue<System.String>("afterDelete"));
			Debug.Assert(m_SecurityId == element.Attributes.GetPropertyValue<System.String>("securityId"));

			// Save element children.
			if (m_Documentation != null)
			{
				PatternInstanceElement documentation = element.Children["Documentation"];
				m_Documentation.SaveTo(documentation);
			}

			if (m_Transaction != null)
			{
				PatternInstanceElement transaction = element.Children.AddNewElement("transaction");
				m_Transaction.SaveTo(transaction);
			}

			if (m_Levels != null)
			{
				foreach (LevelElement _item in Levels)
				{
					PatternInstanceElement level = element.Children.AddNewElement("level");
					_item.SaveTo(level);
				}
			}

			if (m_WebPanelRoot != null)
			{
				PatternInstanceElement webPanelRoot = element.Children.AddNewElement("webPanelRoot");
				m_WebPanelRoot.SaveTo(webPanelRoot);
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="HPatternInstance"/>.
		/// </summary>
		public HPatternInstance Clone()
		{
			HPatternInstance clone = new HPatternInstance(this.Model);

			clone.UpdateTransaction = this.UpdateTransaction;
			clone.UpdateWebPanelBC = this.UpdateWebPanelBC;
			clone.AfterInsert = this.AfterInsert;
			clone.AfterUpdate = this.AfterUpdate;
			clone.AfterDelete = this.AfterDelete;
			clone.SecurityId = this.SecurityId;
			clone.Documentation = this.Documentation.Clone();
			if (Transaction != null)
				clone.Transaction = this.Transaction.Clone();
			foreach (LevelElement levelElement in this.Levels)
				clone.Levels.Add(levelElement.Clone());
			if (WebPanelRoot != null)
				clone.WebPanelRoot = this.WebPanelRoot.Clone();

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the object in the hierarchy corresponding to the element.
		/// </summary>
		public TElement GetElement<TElement>(PatternInstanceElement element) where TElement : class
		{
			if (element == null)
				throw new ArgumentNullException("element");

			string elementPath = element.InternalPath;
			List<string> path = new List<string>(elementPath.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries));
			if (path.Count < 1 || path[0] != "instance")
				throw new PatternInstanceException(String.Format("Element with path {0} not found in instance", element.Path));

			path.RemoveAt(0);
			object obj = this.GetElement(path);
			if (obj != null && !(obj is TElement))
				throw new PatternInstanceException(String.Format("Element with path {0} is not of type {1}", elementPath, typeof(TElement).FullName));

			return (TElement)obj;
		}

		private static System.Text.RegularExpressions.Regex ms_Regex = new System.Text.RegularExpressions.Regex(@"(?<name>\w*)(\[(?<index>[0-9]+)\])?");

		internal static void ParseChildPath(string childPath, out string childName, out int childIndex)
		{
			System.Text.RegularExpressions.Match expressionMatch = ms_Regex.Match(childPath);

			childName = childPath;
			if (expressionMatch.Groups["name"].Length > 0)
				childName = expressionMatch.Groups["name"].Value;

			childIndex = 0;
			if (expressionMatch.Groups["index"].Length > 0)
			{
				if (Int32.TryParse(expressionMatch.Groups["index"].Value, out childIndex))
					childIndex--; // XPath index is 1-based, collection index is 0-based.
			}
		}

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "Documentation" :
				{
					if (Documentation != null)
						return Documentation.GetElement(path);
					else
						return null;
				}
				case "transaction" :
				{
					if (Transaction != null)
						return Transaction.GetElement(path);
					else
						return null;
				}
				case "level" :
				{
					if (Levels != null && childIndex >= 0 && childIndex < Levels.Count)
						return Levels[childIndex].GetElement(path);
					else
						return null;
				}
				case "webPanelRoot" :
				{
					if (WebPanelRoot != null)
						return WebPanelRoot.GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="UpdateTransaction"/> property.
		/// </summary>
		public static class UpdateTransactionValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string OnlyRulesAndEvents = "Only rules and events";
			public const string ApplyWWStyle = "Apply WW Style";
			public const string CreateDefault = "Create default";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateWebPanelBC"/> property.
		/// </summary>
		public static class UpdateWebPanelBCValue
		{
			public const string Default = "Default";
			public const string False = "False";
		}

		/// <summary>
		/// Possible values for the <see cref="AfterInsert"/> property.
		/// </summary>
		public static class AfterInsertValue
		{
			public const string Default = "<default>";
			public const string ReturnToCaller = "Return to Caller";
			public const string GoToView = "Go to View";
			public const string GoToSelection = "Go to Selection";
			public const string EnterInUpdate = "EnterInUpdate";
		}

		/// <summary>
		/// Possible values for the <see cref="AfterUpdate"/> property.
		/// </summary>
		public static class AfterUpdateValue
		{
			public const string Default = "<default>";
			public const string ReturnToCaller = "Return to Caller";
			public const string GoToView = "Go to View";
			public const string GoToSelection = "Go to Selection";
		}

		/// <summary>
		/// Possible values for the <see cref="AfterDelete"/> property.
		/// </summary>
		public static class AfterDeleteValue
		{
			public const string Default = "<default>";
			public const string ReturnToCaller = "Return to Caller";
			public const string GoToSelection = "Go to Selection";
		}

		/// <summary>
		/// Possible values for the <see cref="SecurityId"/> property.
		/// </summary>
		public static class SecurityIdValue
		{
			public const string Default = "default";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "HPattern Pattern Instance";
		}

		#endregion
	}

	#endregion

	#region Element: Documentation

	public partial class DocumentationElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Enabled;
		private bool m_IsEnabledDefault;
		private System.String m_ObjectName;
		private bool m_IsObjectNameDefault;
		private System.String m_ObjectDescription;
		private bool m_IsObjectDescriptionDefault;
		private System.String m_SystemDescription;
		private bool m_IsSystemDescriptionDefault;
		private System.String m_Author;
		private bool m_IsAuthorDefault;
		private System.String m_Date;
		private bool m_IsDateDefault;
		private System.String m_Requirement;
		private bool m_IsRequirementDefault;
		private System.String m_Observation;
		private bool m_IsObservationDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentationElement"/> class.
		/// </summary>
		public DocumentationElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="DocumentationElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Enabled = "default";
			m_IsEnabledDefault = true;
			m_ObjectName = "Pgmname";
			m_IsObjectNameDefault = true;
			m_ObjectDescription = "Pgmdesc";
			m_IsObjectDescriptionDefault = true;
			m_SystemDescription = "";
			m_IsSystemDescriptionDefault = true;
			m_Author = "";
			m_IsAuthorDefault = true;
			m_Date = "default";
			m_IsDateDefault = true;
			m_Requirement = "";
			m_IsRequirementDefault = true;
			m_Observation = "";
			m_IsObservationDefault = true;
		}

		#endregion

		#region Properties

		private HPatternInstance m_Parent;

		/// <summary>
		/// Instance to which this <see cref="DocumentationElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternInstance Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Define se gera Documentação ou não
		*/
		/// </summary>
		public System.String Enabled
		{
			get { return m_Enabled; }
			set 
			{
				m_Enabled = value;
				m_IsEnabledDefault = false;
			}
		}

		/// <summary>
		/*
		Define o nome do Objeto
		*/
		/// </summary>
		public System.String ObjectName
		{
			get { return m_ObjectName; }
			set 
			{
				m_ObjectName = value;
				m_IsObjectNameDefault = false;
			}
		}

		/// <summary>
		/*
		Define a descrição do Objeto
		*/
		/// </summary>
		public System.String ObjectDescription
		{
			get { return m_ObjectDescription; }
			set 
			{
				m_ObjectDescription = value;
				m_IsObjectDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Define a descrição do sistema para a Documentação
		*/
		/// </summary>
		public System.String SystemDescription
		{
			get { return m_SystemDescription; }
			set 
			{
				m_SystemDescription = value;
				m_IsSystemDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Define o autor padrão para a Documentação
		*/
		/// </summary>
		public System.String Author
		{
			get { return m_Author; }
			set 
			{
				m_Author = value;
				m_IsAuthorDefault = false;
			}
		}

		/// <summary>
		/*
		Define a data padrão autor para a Documentação
		*/
		/// </summary>
		public System.String Date
		{
			get { return m_Date; }
			set 
			{
				m_Date = value;
				m_IsDateDefault = false;
			}
		}

		/// <summary>
		/*
		Define a identificação do Requesito
		*/
		/// </summary>
		public System.String Requirement
		{
			get { return m_Requirement; }
			set 
			{
				m_Requirement = value;
				m_IsRequirementDefault = false;
			}
		}

		/// <summary>
		/*
		Define a observação para a Documentação
		*/
		/// </summary>
		public System.String Observation
		{
			get { return m_Observation; }
			set 
			{
				m_Observation = value;
				m_IsObservationDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="DocumentationElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Documentation")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Documentation"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Enabled = element.Attributes.GetPropertyValue<System.String>("Enabled");
			m_IsEnabledDefault = element.Attributes.IsPropertyDefault("Enabled");
			m_ObjectName = element.Attributes.GetPropertyValue<System.String>("ObjectName");
			m_IsObjectNameDefault = element.Attributes.IsPropertyDefault("ObjectName");
			m_ObjectDescription = element.Attributes.GetPropertyValue<System.String>("ObjectDescription");
			m_IsObjectDescriptionDefault = element.Attributes.IsPropertyDefault("ObjectDescription");
			m_SystemDescription = element.Attributes.GetPropertyValue<System.String>("SystemDescription");
			m_IsSystemDescriptionDefault = element.Attributes.IsPropertyDefault("SystemDescription");
			m_Author = element.Attributes.GetPropertyValue<System.String>("Author");
			m_IsAuthorDefault = element.Attributes.IsPropertyDefault("Author");
			m_Date = element.Attributes.GetPropertyValue<System.String>("Date");
			m_IsDateDefault = element.Attributes.IsPropertyDefault("Date");
			m_Requirement = element.Attributes.GetPropertyValue<System.String>("Requirement");
			m_IsRequirementDefault = element.Attributes.IsPropertyDefault("Requirement");
			m_Observation = element.Attributes.GetPropertyValue<System.String>("Observation");
			m_IsObservationDefault = element.Attributes.IsPropertyDefault("Observation");
		}

		/// <summary>
		/// Saves the current <see cref="DocumentationElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Documentation")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Documentation"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "Enabled", m_Enabled, m_IsEnabledDefault);
			SaveAttribute(element, "ObjectName", m_ObjectName, m_IsObjectNameDefault);
			SaveAttribute(element, "ObjectDescription", m_ObjectDescription, m_IsObjectDescriptionDefault);
			SaveAttribute(element, "SystemDescription", m_SystemDescription, m_IsSystemDescriptionDefault);
			SaveAttribute(element, "Author", m_Author, m_IsAuthorDefault);
			SaveAttribute(element, "Date", m_Date, m_IsDateDefault);
			SaveAttribute(element, "Requirement", m_Requirement, m_IsRequirementDefault);
			SaveAttribute(element, "Observation", m_Observation, m_IsObservationDefault);

			Debug.Assert(m_Enabled == element.Attributes.GetPropertyValue<System.String>("Enabled"));
			Debug.Assert(m_ObjectName == element.Attributes.GetPropertyValue<System.String>("ObjectName"));
			Debug.Assert(m_ObjectDescription == element.Attributes.GetPropertyValue<System.String>("ObjectDescription"));
			Debug.Assert(m_SystemDescription == element.Attributes.GetPropertyValue<System.String>("SystemDescription"));
			Debug.Assert(m_Author == element.Attributes.GetPropertyValue<System.String>("Author"));
			Debug.Assert(m_Date == element.Attributes.GetPropertyValue<System.String>("Date"));
			Debug.Assert(m_Requirement == element.Attributes.GetPropertyValue<System.String>("Requirement"));
			Debug.Assert(m_Observation == element.Attributes.GetPropertyValue<System.String>("Observation"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="DocumentationElement"/>.
		/// </summary>
		public DocumentationElement Clone()
		{
			DocumentationElement clone = new DocumentationElement();

			clone.Enabled = this.Enabled;
			clone.ObjectName = this.ObjectName;
			clone.ObjectDescription = this.ObjectDescription;
			clone.SystemDescription = this.SystemDescription;
			clone.Author = this.Author;
			clone.Date = this.Date;
			clone.Requirement = this.Requirement;
			clone.Observation = this.Observation;

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Enabled"/> property.
		/// </summary>
		public static class EnabledValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Default = "default";
		}

		/// <summary>
		/// Possible values for the <see cref="ObjectName"/> property.
		/// </summary>
		public static class ObjectNameValue
		{
			public const string Pgmname = "Pgmname";
		}

		/// <summary>
		/// Possible values for the <see cref="ObjectDescription"/> property.
		/// </summary>
		public static class ObjectDescriptionValue
		{
			public const string Pgmdesc = "Pgmdesc";
		}

		/// <summary>
		/// Possible values for the <see cref="Date"/> property.
		/// </summary>
		public static class DateValue
		{
			public const string Default = "default";
			public const string Today = "Today";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Documentation";
		}

		#endregion
	}

	#endregion

	#region Element: GridProperties

	public partial class GridPropertiesElement : Artech.Common.Collections.BaseCollection<GridPropertieElement>
	{
		protected string m_ElementName;

		#region Construction

		internal GridPropertiesElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<GridPropertieElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<GridPropertieElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of GridPropertiesElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="GridPropertieElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no GridPropertie is found, <b>null</b> is returned.
		/// </summary>
		public GridPropertieElement FindGridPropertie(System.String name)
		{
			return this.Find(delegate (GridPropertieElement gridPropertieItem) { return gridPropertieItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Grid Custom Render Properties";
		}

		#endregion
	}

	#endregion

	#region Element: GridColumnProperties

	public partial class GridColumnPropertiesElement : Artech.Common.Collections.BaseCollection<GridColumnPropertieElement>
	{
		protected string m_ElementName;

		#region Construction

		internal GridColumnPropertiesElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<GridColumnPropertieElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<GridColumnPropertieElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of GridColumnPropertiesElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="GridColumnPropertieElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no GridColumnPropertie is found, <b>null</b> is returned.
		/// </summary>
		public GridColumnPropertieElement FindGridColumnPropertie(System.String name)
		{
			return this.Find(delegate (GridColumnPropertieElement gridColumnPropertieItem) { return gridColumnPropertieItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Grid Custom Render Properties";
		}

		#endregion
	}

	#endregion

	#region Element: GridPropertie

	public partial class GridPropertieElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Valor;
		private bool m_IsValorDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="GridPropertieElement"/> class.
		/// </summary>
		public GridPropertieElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GridPropertieElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public GridPropertieElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="GridPropertieElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = null;
			m_IsNameDefault = true;
			m_Valor = "";
			m_IsValorDefault = true;
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="GridPropertieElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Nome
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Valor
		*/
		/// </summary>
		public System.String Valor
		{
			get { return m_Valor; }
			set 
			{
				m_Valor = value;
				m_IsValorDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="GridPropertieElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridPropertie")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "GridPropertie"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Valor = element.Attributes.GetPropertyValue<System.String>("valor");
			m_IsValorDefault = element.Attributes.IsPropertyDefault("valor");
		}

		/// <summary>
		/// Saves the current <see cref="GridPropertieElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridPropertie")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "GridPropertie"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "valor", m_Valor, m_IsValorDefault);

			Debug.Assert(m_Valor == element.Attributes.GetPropertyValue<System.String>("valor"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="GridPropertieElement"/>.
		/// </summary>
		public GridPropertieElement Clone()
		{
			GridPropertieElement clone = new GridPropertieElement();

			clone.Name = this.Name;
			clone.Valor = this.Valor;

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Grid {0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: GridColumnPropertie

	public partial class GridColumnPropertieElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Valor;
		private bool m_IsValorDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="GridColumnPropertieElement"/> class.
		/// </summary>
		public GridColumnPropertieElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GridColumnPropertieElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public GridColumnPropertieElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="GridColumnPropertieElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = null;
			m_IsNameDefault = true;
			m_Valor = "";
			m_IsValorDefault = true;
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="GridColumnPropertieElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Nome
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Valor
		*/
		/// </summary>
		public System.String Valor
		{
			get { return m_Valor; }
			set 
			{
				m_Valor = value;
				m_IsValorDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="GridColumnPropertieElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridColumnPropertie")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "GridColumnPropertie"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Valor = element.Attributes.GetPropertyValue<System.String>("valor");
			m_IsValorDefault = element.Attributes.IsPropertyDefault("valor");
		}

		/// <summary>
		/// Saves the current <see cref="GridColumnPropertieElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridColumnPropertie")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "GridColumnPropertie"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "valor", m_Valor, m_IsValorDefault);

			Debug.Assert(m_Valor == element.Attributes.GetPropertyValue<System.String>("valor"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="GridColumnPropertieElement"/>.
		/// </summary>
		public GridColumnPropertieElement Clone()
		{
			GridColumnPropertieElement clone = new GridColumnPropertieElement();

			clone.Name = this.Name;
			clone.Valor = this.Valor;

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Column {0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: Action

	public partial class ActionElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Caption;
		private bool m_IsCaptionDefault;
		private Artech.Architecture.Common.Objects.KBObject m_Gxobject;
		private KBObjectReference m_GxobjectReference;
		private string m_GxobjectName;
		private bool m_IsGxobjectDefault;
		private System.Boolean m_InGrid;
		private bool m_IsInGridDefault;
		private System.Boolean m_MultiRowSelection;
		private bool m_IsMultiRowSelectionDefault;
		private Artech.Genexus.Common.Objects.Image m_Image;
		private KBObjectReference m_ImageReference;
		private bool m_IsImageDefault;
		private Artech.Genexus.Common.Objects.Image m_DisabledImage;
		private KBObjectReference m_DisabledImageReference;
		private bool m_IsDisabledImageDefault;
		private System.String m_Tooltip;
		private bool m_IsTooltipDefault;
		private System.String m_Condition;
		private bool m_IsConditionDefault;
		private System.String m_ButtonClass;
		private bool m_IsButtonClassDefault;
		private System.String m_EventCode;
		private bool m_IsEventCodeDefault;
		private System.String m_CodeEnable;
		private bool m_IsCodeEnableDefault;
		private System.String m_Position;
		private bool m_IsPositionDefault;
		private System.String m_Legend;
		private bool m_IsLegendDefault;
		private System.Int32 m_Width;
		private bool m_IsWidthDefault;
		private System.String m_GridWidth;
		private bool m_IsGridWidthDefault;
		private System.String m_GridHeight;
		private bool m_IsGridHeightDefault;
		private ParametersElement m_Parameters;
		private SubActionsElement m_SubActions;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="ActionElement"/> class.
		/// </summary>
		public ActionElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ActionElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public ActionElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="ActionElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Caption = "";
			m_IsCaptionDefault = true;
			m_Gxobject = null;
			m_GxobjectReference = null;
			m_GxobjectName = null;
			m_IsGxobjectDefault = true;
			m_InGrid = false;
			m_IsInGridDefault = true;
			m_MultiRowSelection = false;
			m_IsMultiRowSelectionDefault = true;
			m_Image = null;
			m_ImageReference = null;
			m_IsImageDefault = true;
			m_DisabledImage = null;
			m_DisabledImageReference = null;
			m_IsDisabledImageDefault = true;
			m_Tooltip = "";
			m_IsTooltipDefault = true;
			m_Condition = "";
			m_IsConditionDefault = true;
			m_ButtonClass = null;
			m_IsButtonClassDefault = true;
			m_EventCode = "";
			m_IsEventCodeDefault = true;
			m_CodeEnable = "";
			m_IsCodeEnableDefault = true;
			m_Position = "Footer";
			m_IsPositionDefault = true;
			m_Legend = "";
			m_IsLegendDefault = true;
			m_Width = 0;
			m_IsWidthDefault = true;
			m_GridWidth = "";
			m_IsGridWidthDefault = true;
			m_GridHeight = "";
			m_IsGridHeightDefault = true;
			m_Parameters = new ParametersElement();
			m_Parameters.Parent = this;
			m_Parameters.ElementName = "parameters";
			m_SubActions = new SubActionsElement();
			m_SubActions.Parent = this;
			m_SubActions.ElementName = "subActions";
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="ActionElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Action Name
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Caption (for the button, or for "in grid" actions that do not have an associated image ).
		*/
		/// </summary>
		public System.String Caption
		{
			get { return m_Caption; }
			set 
			{
				m_Caption = value;
				m_IsCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		GeneXus object invoked for performing the Action.
		*/
		/// </summary>
		public Artech.Architecture.Common.Objects.KBObject Gxobject
		{
			get
			{
				if (m_Gxobject == null && m_GxobjectReference != null)
					m_Gxobject = (Artech.Architecture.Common.Objects.KBObject)m_GxobjectReference.GetKBObject(Instance.Model);

				return m_Gxobject;
			}

			set 
			{
				m_Gxobject = value;
				m_GxobjectReference = (value != null ? new KBObjectReference(value) : null);
				m_GxobjectName = (value != null ? value.Name : null);
				m_IsGxobjectDefault = false;
			}
		}

		/// <summary>
		/// Gxobject name.
		/// </summary>
		public string GxobjectName
		{
			get
			{
				if (m_GxobjectName == null && m_GxobjectReference != null)
					m_GxobjectName = m_GxobjectReference.GetName(Instance.Model);

				return m_GxobjectName;
			}
		}

		/// <summary>
		/*
		True = Action in the grid. False = Action outside the grid. Always false if "MultiRowSelection" is set.
		*/
		/// </summary>
		public System.Boolean InGrid
		{
			get { return m_InGrid; }
			set 
			{
				m_InGrid = value;
				m_IsInGridDefault = false;
			}
		}

		/// <summary>
		/*
		The action applies to multiple rows (a checkbox column will be added to grids).
		*/
		/// </summary>
		public System.Boolean MultiRowSelection
		{
			get { return m_MultiRowSelection; }
			set 
			{
				m_MultiRowSelection = value;
				m_IsMultiRowSelectionDefault = false;
			}
		}

		/// <summary>
		/*
		Image to appear in the grid.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image Image
		{
			get
			{
				if (m_Image == null && m_ImageReference != null)
					m_Image = (Artech.Genexus.Common.Objects.Image)m_ImageReference.GetKBObject(Instance.Model);

				return m_Image;
			}

			set 
			{
				m_Image = value;
				m_ImageReference = (value != null ? new KBObjectReference(value) : null);
				m_IsImageDefault = false;
			}
		}

		/// <summary>
		/// Image name.
		/// </summary>
		public string ImageName
		{
			get { return (Image != null ? Image.Name : null); }
		}

		/// <summary>
		/*
		Image to appear in the grid when the action is not enabled (to make the button invisible, use a transparent image).
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image DisabledImage
		{
			get
			{
				if (m_DisabledImage == null && m_DisabledImageReference != null)
					m_DisabledImage = (Artech.Genexus.Common.Objects.Image)m_DisabledImageReference.GetKBObject(Instance.Model);

				return m_DisabledImage;
			}

			set 
			{
				m_DisabledImage = value;
				m_DisabledImageReference = (value != null ? new KBObjectReference(value) : null);
				m_IsDisabledImageDefault = false;
			}
		}

		/// <summary>
		/// DisabledImage name.
		/// </summary>
		public string DisabledImageName
		{
			get { return (DisabledImage != null ? DisabledImage.Name : null); }
		}

		/// <summary>
		/*
		Tooltip to appear in the grid.
		*/
		/// </summary>
		public System.String Tooltip
		{
			get { return m_Tooltip; }
			set 
			{
				m_Tooltip = value;
				m_IsTooltipDefault = false;
			}
		}

		/// <summary>
		/*
		Condition to determine whether the action will be enabled. If the action is defined as "InGrid", the check will be performed for each record. If empty, the action will be available.
		*/
		/// </summary>
		public System.String Condition
		{
			get { return m_Condition; }
			set 
			{
				m_Condition = value;
				m_IsConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Theme class for the button (if no class is specified, the one set in the configuration file will be used).
		*/
		/// </summary>
		public System.String ButtonClass
		{
			get { return m_ButtonClass; }
			set 
			{
				m_ButtonClass = value;
				m_IsButtonClassDefault = false;
			}
		}

		/// <summary>
		/*
		Código para o Evento da Action, somente para Action não Standard
		*/
		/// </summary>
		public System.String EventCode
		{
			get { return m_EventCode; }
			set 
			{
				m_EventCode = value;
				m_IsEventCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Evento adicionado a ação de habilitar a Action, Coringda {0} define o nome do controle
		*/
		/// </summary>
		public System.String CodeEnable
		{
			get { return m_CodeEnable; }
			set 
			{
				m_CodeEnable = value;
				m_IsCodeEnableDefault = false;
			}
		}

		/// <summary>
		/*
		Define a posição da action fora do Grid
		*/
		/// </summary>
		public System.String Position
		{
			get { return m_Position; }
			set 
			{
				m_Position = value;
				m_IsPositionDefault = false;
			}
		}

		/// <summary>
		/*
		Legend
		*/
		/// </summary>
		public System.String Legend
		{
			get { return m_Legend; }
			set 
			{
				m_Legend = value;
				m_IsLegendDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width da Coluna no Grid
		*/
		/// </summary>
		public System.Int32 Width
		{
			get { return m_Width; }
			set 
			{
				m_Width = value;
				m_IsWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width(tamanho horizontal)
		*/
		/// </summary>
		public System.String GridWidth
		{
			get { return m_GridWidth; }
			set 
			{
				m_GridWidth = value;
				m_IsGridWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Height(tamanho vertical)
		*/
		/// </summary>
		public System.String GridHeight
		{
			get { return m_GridHeight; }
			set 
			{
				m_GridHeight = value;
				m_IsGridHeightDefault = false;
			}
		}

		public ParametersElement Parameters
		{
			get { return m_Parameters; }
		}

		public SubActionsElement SubActions
		{
			get { return m_SubActions; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// </summary>
		public ParameterElement AddParameter()
		{
			ParameterElement parameterElement = new ParameterElement();
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// The ParameterElement is initialized with the specified value.
		/// </summary>
		public ParameterElement AddParameter(System.String name)
		{
			ParameterElement parameterElement = new ParameterElement(name);
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Finds the <see cref="ParameterElement"/> in the <see cref="Parameters"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no parameterElement is found, null is returned.
		/// </summary>
		public ParameterElement FindParameter(System.String name)
		{
			return Parameters.Find(delegate (ParameterElement parameterElement) { return parameterElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="SubActionElement"/> and adds it to the <see cref="SubActions"/> collection.
		/// </summary>
		public SubActionElement AddSubAction()
		{
			SubActionElement subActionElement = new SubActionElement();
			m_SubActions.Add(subActionElement);
			return subActionElement;
		}

		/// <summary>
		/// Creates a new <see cref="SubActionElement"/> and adds it to the <see cref="SubActions"/> collection.
		/// The SubActionElement is initialized with the specified value.
		/// </summary>
		public SubActionElement AddSubAction(System.String name)
		{
			SubActionElement subActionElement = new SubActionElement(name);
			m_SubActions.Add(subActionElement);
			return subActionElement;
		}

		/// <summary>
		/// Finds the <see cref="SubActionElement"/> in the <see cref="SubActions"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no subActionElement is found, null is returned.
		/// </summary>
		public SubActionElement FindSubAction(System.String name)
		{
			return SubActions.Find(delegate (SubActionElement subActionElement) { return subActionElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="ActionElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Action")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Action"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Caption = element.Attributes.GetPropertyValue<System.String>("caption");
			m_IsCaptionDefault = element.Attributes.IsPropertyDefault("caption");
			m_GxobjectReference = element.Attributes.GetPropertyValue<KBObjectReference>("gxobjectReference");
			m_IsGxobjectDefault = element.Attributes.IsPropertyDefault("gxobject");
			m_InGrid = element.Attributes.GetPropertyValue<System.Boolean>("inGrid");
			m_IsInGridDefault = element.Attributes.IsPropertyDefault("inGrid");
			m_MultiRowSelection = element.Attributes.GetPropertyValue<System.Boolean>("multiRowSelection");
			m_IsMultiRowSelectionDefault = element.Attributes.IsPropertyDefault("multiRowSelection");
			m_ImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("imageReference");
			m_IsImageDefault = element.Attributes.IsPropertyDefault("image");
			m_DisabledImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("disabledImageReference");
			m_IsDisabledImageDefault = element.Attributes.IsPropertyDefault("disabledImage");
			m_Tooltip = element.Attributes.GetPropertyValue<System.String>("tooltip");
			m_IsTooltipDefault = element.Attributes.IsPropertyDefault("tooltip");
			m_Condition = element.Attributes.GetPropertyValue<System.String>("condition");
			m_IsConditionDefault = element.Attributes.IsPropertyDefault("condition");
			m_ButtonClass = element.Attributes.GetPropertyValue<System.String>("buttonClass");
			m_IsButtonClassDefault = element.Attributes.IsPropertyDefault("buttonClass");
			m_EventCode = element.Attributes.GetPropertyValue<System.String>("EventCode");
			m_IsEventCodeDefault = element.Attributes.IsPropertyDefault("EventCode");
			m_CodeEnable = element.Attributes.GetPropertyValue<System.String>("CodeEnable");
			m_IsCodeEnableDefault = element.Attributes.IsPropertyDefault("CodeEnable");
			m_Position = element.Attributes.GetPropertyValue<System.String>("Position");
			m_IsPositionDefault = element.Attributes.IsPropertyDefault("Position");
			m_Legend = element.Attributes.GetPropertyValue<System.String>("Legend");
			m_IsLegendDefault = element.Attributes.IsPropertyDefault("Legend");
			m_Width = element.Attributes.GetPropertyValue<System.Int32>("Width");
			m_IsWidthDefault = element.Attributes.IsPropertyDefault("Width");
			m_GridWidth = element.Attributes.GetPropertyValue<System.String>("GridWidth");
			m_IsGridWidthDefault = element.Attributes.IsPropertyDefault("GridWidth");
			m_GridHeight = element.Attributes.GetPropertyValue<System.String>("GridHeight");
			m_IsGridHeightDefault = element.Attributes.IsPropertyDefault("GridHeight");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "parameters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ParameterElement parameterElement = new ParameterElement();
							parameterElement.LoadFrom(_childElementItem);
							Parameters.Add(parameterElement);
						}
						break;
					}
					case "subActions" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							SubActionElement subActionElement = new SubActionElement();
							subActionElement.LoadFrom(_childElementItem);
							SubActions.Add(subActionElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="ActionElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Action")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Action"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "caption", m_Caption, m_IsCaptionDefault);
			SaveAttribute(element, "gxobjectReference", m_GxobjectReference, m_IsGxobjectDefault);
			SaveAttribute(element, "inGrid", m_InGrid, m_IsInGridDefault);
			SaveAttribute(element, "multiRowSelection", m_MultiRowSelection, m_IsMultiRowSelectionDefault);
			SaveAttribute(element, "imageReference", m_ImageReference, m_IsImageDefault);
			SaveAttribute(element, "disabledImageReference", m_DisabledImageReference, m_IsDisabledImageDefault);
			SaveAttribute(element, "tooltip", m_Tooltip, m_IsTooltipDefault);
			SaveAttribute(element, "condition", m_Condition, m_IsConditionDefault);
			SaveAttribute(element, "buttonClass", m_ButtonClass, m_IsButtonClassDefault);
			SaveAttribute(element, "EventCode", m_EventCode, m_IsEventCodeDefault);
			SaveAttribute(element, "CodeEnable", m_CodeEnable, m_IsCodeEnableDefault);
			SaveAttribute(element, "Position", m_Position, m_IsPositionDefault);
			SaveAttribute(element, "Legend", m_Legend, m_IsLegendDefault);
			SaveAttribute(element, "Width", m_Width, m_IsWidthDefault);
			SaveAttribute(element, "GridWidth", m_GridWidth, m_IsGridWidthDefault);
			SaveAttribute(element, "GridHeight", m_GridHeight, m_IsGridHeightDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_Caption == element.Attributes.GetPropertyValue<System.String>("caption"));
			Debug.Assert(m_GxobjectReference == element.Attributes.GetPropertyValue<KBObjectReference>("gxobjectReference"));
			Debug.Assert(m_InGrid == element.Attributes.GetPropertyValue<System.Boolean>("inGrid"));
			Debug.Assert(m_MultiRowSelection == element.Attributes.GetPropertyValue<System.Boolean>("multiRowSelection"));
			Debug.Assert(m_ImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("imageReference"));
			Debug.Assert(m_DisabledImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("disabledImageReference"));
			Debug.Assert(m_Tooltip == element.Attributes.GetPropertyValue<System.String>("tooltip"));
			Debug.Assert(m_Condition == element.Attributes.GetPropertyValue<System.String>("condition"));
			Debug.Assert(m_EventCode == element.Attributes.GetPropertyValue<System.String>("EventCode"));
			Debug.Assert(m_CodeEnable == element.Attributes.GetPropertyValue<System.String>("CodeEnable"));
			Debug.Assert(m_Position == element.Attributes.GetPropertyValue<System.String>("Position"));
			Debug.Assert(m_Legend == element.Attributes.GetPropertyValue<System.String>("Legend"));
			Debug.Assert(m_Width == element.Attributes.GetPropertyValue<System.Int32>("Width"));
			Debug.Assert(m_GridWidth == element.Attributes.GetPropertyValue<System.String>("GridWidth"));
			Debug.Assert(m_GridHeight == element.Attributes.GetPropertyValue<System.String>("GridHeight"));

			// Save element children.
			if (m_Parameters != null)
			{
				if (m_Parameters.Count > 0)
					element.Children.AddNewElement("parameters");

				foreach (ParameterElement _item in Parameters)
				{
					PatternInstanceElement child = element.Children["parameters"].Children.AddNewElement("parameter");
					_item.SaveTo(child);
				}
			}

			if (m_SubActions != null)
			{
				if (m_SubActions.Count > 0)
					element.Children.AddNewElement("subActions");

				foreach (SubActionElement _item in SubActions)
				{
					PatternInstanceElement child = element.Children["subActions"].Children.AddNewElement("subAction");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="ActionElement"/>.
		/// </summary>
		public ActionElement Clone()
		{
			ActionElement clone = new ActionElement();

			clone.Name = this.Name;
			clone.Caption = this.Caption;
			clone.Gxobject = this.Gxobject;
			clone.InGrid = this.InGrid;
			clone.MultiRowSelection = this.MultiRowSelection;
			clone.Image = this.Image;
			clone.DisabledImage = this.DisabledImage;
			clone.Tooltip = this.Tooltip;
			clone.Condition = this.Condition;
			clone.ButtonClass = this.ButtonClass;
			clone.EventCode = this.EventCode;
			clone.CodeEnable = this.CodeEnable;
			clone.Position = this.Position;
			clone.Legend = this.Legend;
			clone.Width = this.Width;
			clone.GridWidth = this.GridWidth;
			clone.GridHeight = this.GridHeight;
			foreach (ParameterElement parameterElement in this.Parameters)
				clone.Parameters.Add(parameterElement.Clone());
			foreach (SubActionElement subActionElement in this.SubActions)
				clone.SubActions.Add(subActionElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "parameters" :
				{
					if (path.Count == 0)
						return Parameters;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "parameter")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Parameters != null && itemIndex >= 0 && itemIndex < Parameters.Count)
						return Parameters[itemIndex].GetElement(path);
					else
						return null;
				}
				case "subActions" :
				{
					if (path.Count == 0)
						return SubActions;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "subAction")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (SubActions != null && itemIndex >= 0 && itemIndex < SubActions.Count)
						return SubActions[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Position"/> property.
		/// </summary>
		public static class PositionValue
		{
			public const string Footer = "Footer";
			public const string Grid = "Grid";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Action ({0})", Name);
		}

		#endregion
	}

	#endregion

	#region Element: SubAction

	public partial class SubActionElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Caption;
		private bool m_IsCaptionDefault;
		private Artech.Architecture.Common.Objects.KBObject m_Gxobject;
		private KBObjectReference m_GxobjectReference;
		private string m_GxobjectName;
		private bool m_IsGxobjectDefault;
		private System.Boolean m_InGrid;
		private bool m_IsInGridDefault;
		private System.Boolean m_MultiRowSelection;
		private bool m_IsMultiRowSelectionDefault;
		private Artech.Genexus.Common.Objects.Image m_Image;
		private KBObjectReference m_ImageReference;
		private bool m_IsImageDefault;
		private Artech.Genexus.Common.Objects.Image m_DisabledImage;
		private KBObjectReference m_DisabledImageReference;
		private bool m_IsDisabledImageDefault;
		private System.String m_Tooltip;
		private bool m_IsTooltipDefault;
		private System.String m_Condition;
		private bool m_IsConditionDefault;
		private System.String m_ButtonClass;
		private bool m_IsButtonClassDefault;
		private System.String m_EventCode;
		private bool m_IsEventCodeDefault;
		private System.String m_CodeEnable;
		private bool m_IsCodeEnableDefault;
		private System.String m_Position;
		private bool m_IsPositionDefault;
		private System.String m_Legend;
		private bool m_IsLegendDefault;
		private System.Int32 m_Width;
		private bool m_IsWidthDefault;
		private System.String m_GridWidth;
		private bool m_IsGridWidthDefault;
		private System.String m_GridHeight;
		private bool m_IsGridHeightDefault;
		private ParametersElement m_Parameters;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SubActionElement"/> class.
		/// </summary>
		public SubActionElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SubActionElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public SubActionElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SubActionElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Caption = "";
			m_IsCaptionDefault = true;
			m_Gxobject = null;
			m_GxobjectReference = null;
			m_GxobjectName = null;
			m_IsGxobjectDefault = true;
			m_InGrid = false;
			m_IsInGridDefault = true;
			m_MultiRowSelection = false;
			m_IsMultiRowSelectionDefault = true;
			m_Image = null;
			m_ImageReference = null;
			m_IsImageDefault = true;
			m_DisabledImage = null;
			m_DisabledImageReference = null;
			m_IsDisabledImageDefault = true;
			m_Tooltip = "";
			m_IsTooltipDefault = true;
			m_Condition = "";
			m_IsConditionDefault = true;
			m_ButtonClass = null;
			m_IsButtonClassDefault = true;
			m_EventCode = "";
			m_IsEventCodeDefault = true;
			m_CodeEnable = "";
			m_IsCodeEnableDefault = true;
			m_Position = "Footer";
			m_IsPositionDefault = true;
			m_Legend = "";
			m_IsLegendDefault = true;
			m_Width = 0;
			m_IsWidthDefault = true;
			m_GridWidth = "";
			m_IsGridWidthDefault = true;
			m_GridHeight = "";
			m_IsGridHeightDefault = true;
			m_Parameters = new ParametersElement();
			m_Parameters.Parent = this;
			m_Parameters.ElementName = "parameters";
		}

		#endregion

		#region Properties

		private ActionElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="SubActionElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public ActionElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Action Name
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Caption (for the button, or for "in grid" actions that do not have an associated image ).
		*/
		/// </summary>
		public System.String Caption
		{
			get { return m_Caption; }
			set 
			{
				m_Caption = value;
				m_IsCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		GeneXus object invoked for performing the Action.
		*/
		/// </summary>
		public Artech.Architecture.Common.Objects.KBObject Gxobject
		{
			get
			{
				if (m_Gxobject == null && m_GxobjectReference != null)
					m_Gxobject = (Artech.Architecture.Common.Objects.KBObject)m_GxobjectReference.GetKBObject(Instance.Model);

				return m_Gxobject;
			}

			set 
			{
				m_Gxobject = value;
				m_GxobjectReference = (value != null ? new KBObjectReference(value) : null);
				m_GxobjectName = (value != null ? value.Name : null);
				m_IsGxobjectDefault = false;
			}
		}

		/// <summary>
		/// Gxobject name.
		/// </summary>
		public string GxobjectName
		{
			get
			{
				if (m_GxobjectName == null && m_GxobjectReference != null)
					m_GxobjectName = m_GxobjectReference.GetName(Instance.Model);

				return m_GxobjectName;
			}
		}

		/// <summary>
		/*
		True = Action in the grid. False = Action outside the grid. Always false if "MultiRowSelection" is set.
		*/
		/// </summary>
		public System.Boolean InGrid
		{
			get { return m_InGrid; }
			set 
			{
				m_InGrid = value;
				m_IsInGridDefault = false;
			}
		}

		/// <summary>
		/*
		The action applies to multiple rows (a checkbox column will be added to grids).
		*/
		/// </summary>
		public System.Boolean MultiRowSelection
		{
			get { return m_MultiRowSelection; }
			set 
			{
				m_MultiRowSelection = value;
				m_IsMultiRowSelectionDefault = false;
			}
		}

		/// <summary>
		/*
		Image to appear in the grid.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image Image
		{
			get
			{
				if (m_Image == null && m_ImageReference != null)
					m_Image = (Artech.Genexus.Common.Objects.Image)m_ImageReference.GetKBObject(Instance.Model);

				return m_Image;
			}

			set 
			{
				m_Image = value;
				m_ImageReference = (value != null ? new KBObjectReference(value) : null);
				m_IsImageDefault = false;
			}
		}

		/// <summary>
		/// Image name.
		/// </summary>
		public string ImageName
		{
			get { return (Image != null ? Image.Name : null); }
		}

		/// <summary>
		/*
		Image to appear in the grid when the action is not enabled (to make the button invisible, use a transparent image).
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image DisabledImage
		{
			get
			{
				if (m_DisabledImage == null && m_DisabledImageReference != null)
					m_DisabledImage = (Artech.Genexus.Common.Objects.Image)m_DisabledImageReference.GetKBObject(Instance.Model);

				return m_DisabledImage;
			}

			set 
			{
				m_DisabledImage = value;
				m_DisabledImageReference = (value != null ? new KBObjectReference(value) : null);
				m_IsDisabledImageDefault = false;
			}
		}

		/// <summary>
		/// DisabledImage name.
		/// </summary>
		public string DisabledImageName
		{
			get { return (DisabledImage != null ? DisabledImage.Name : null); }
		}

		/// <summary>
		/*
		Tooltip to appear in the grid.
		*/
		/// </summary>
		public System.String Tooltip
		{
			get { return m_Tooltip; }
			set 
			{
				m_Tooltip = value;
				m_IsTooltipDefault = false;
			}
		}

		/// <summary>
		/*
		Condition to determine whether the action will be enabled. If the action is defined as "InGrid", the check will be performed for each record. If empty, the action will be available.
		*/
		/// </summary>
		public System.String Condition
		{
			get { return m_Condition; }
			set 
			{
				m_Condition = value;
				m_IsConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Theme class for the button (if no class is specified, the one set in the configuration file will be used).
		*/
		/// </summary>
		public System.String ButtonClass
		{
			get { return m_ButtonClass; }
			set 
			{
				m_ButtonClass = value;
				m_IsButtonClassDefault = false;
			}
		}

		/// <summary>
		/*
		Código para o Evento da Action, somente para Action não Standard
		*/
		/// </summary>
		public System.String EventCode
		{
			get { return m_EventCode; }
			set 
			{
				m_EventCode = value;
				m_IsEventCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Evento adicionado a ação de habilitar a Action, Coringda {0} define o nome do controle
		*/
		/// </summary>
		public System.String CodeEnable
		{
			get { return m_CodeEnable; }
			set 
			{
				m_CodeEnable = value;
				m_IsCodeEnableDefault = false;
			}
		}

		/// <summary>
		/*
		Define a posição da action fora do Grid
		*/
		/// </summary>
		public System.String Position
		{
			get { return m_Position; }
			set 
			{
				m_Position = value;
				m_IsPositionDefault = false;
			}
		}

		/// <summary>
		/*
		Legend
		*/
		/// </summary>
		public System.String Legend
		{
			get { return m_Legend; }
			set 
			{
				m_Legend = value;
				m_IsLegendDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width da Coluna no Grid
		*/
		/// </summary>
		public System.Int32 Width
		{
			get { return m_Width; }
			set 
			{
				m_Width = value;
				m_IsWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width(tamanho horizontal)
		*/
		/// </summary>
		public System.String GridWidth
		{
			get { return m_GridWidth; }
			set 
			{
				m_GridWidth = value;
				m_IsGridWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Height(tamanho vertical)
		*/
		/// </summary>
		public System.String GridHeight
		{
			get { return m_GridHeight; }
			set 
			{
				m_GridHeight = value;
				m_IsGridHeightDefault = false;
			}
		}

		public ParametersElement Parameters
		{
			get { return m_Parameters; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// </summary>
		public ParameterElement AddParameter()
		{
			ParameterElement parameterElement = new ParameterElement();
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// The ParameterElement is initialized with the specified value.
		/// </summary>
		public ParameterElement AddParameter(System.String name)
		{
			ParameterElement parameterElement = new ParameterElement(name);
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Finds the <see cref="ParameterElement"/> in the <see cref="Parameters"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no parameterElement is found, null is returned.
		/// </summary>
		public ParameterElement FindParameter(System.String name)
		{
			return Parameters.Find(delegate (ParameterElement parameterElement) { return parameterElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SubActionElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "SubAction")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "SubAction"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Caption = element.Attributes.GetPropertyValue<System.String>("caption");
			m_IsCaptionDefault = element.Attributes.IsPropertyDefault("caption");
			m_GxobjectReference = element.Attributes.GetPropertyValue<KBObjectReference>("gxobjectReference");
			m_IsGxobjectDefault = element.Attributes.IsPropertyDefault("gxobject");
			m_InGrid = element.Attributes.GetPropertyValue<System.Boolean>("inGrid");
			m_IsInGridDefault = element.Attributes.IsPropertyDefault("inGrid");
			m_MultiRowSelection = element.Attributes.GetPropertyValue<System.Boolean>("multiRowSelection");
			m_IsMultiRowSelectionDefault = element.Attributes.IsPropertyDefault("multiRowSelection");
			m_ImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("imageReference");
			m_IsImageDefault = element.Attributes.IsPropertyDefault("image");
			m_DisabledImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("disabledImageReference");
			m_IsDisabledImageDefault = element.Attributes.IsPropertyDefault("disabledImage");
			m_Tooltip = element.Attributes.GetPropertyValue<System.String>("tooltip");
			m_IsTooltipDefault = element.Attributes.IsPropertyDefault("tooltip");
			m_Condition = element.Attributes.GetPropertyValue<System.String>("condition");
			m_IsConditionDefault = element.Attributes.IsPropertyDefault("condition");
			m_ButtonClass = element.Attributes.GetPropertyValue<System.String>("buttonClass");
			m_IsButtonClassDefault = element.Attributes.IsPropertyDefault("buttonClass");
			m_EventCode = element.Attributes.GetPropertyValue<System.String>("EventCode");
			m_IsEventCodeDefault = element.Attributes.IsPropertyDefault("EventCode");
			m_CodeEnable = element.Attributes.GetPropertyValue<System.String>("CodeEnable");
			m_IsCodeEnableDefault = element.Attributes.IsPropertyDefault("CodeEnable");
			m_Position = element.Attributes.GetPropertyValue<System.String>("Position");
			m_IsPositionDefault = element.Attributes.IsPropertyDefault("Position");
			m_Legend = element.Attributes.GetPropertyValue<System.String>("Legend");
			m_IsLegendDefault = element.Attributes.IsPropertyDefault("Legend");
			m_Width = element.Attributes.GetPropertyValue<System.Int32>("Width");
			m_IsWidthDefault = element.Attributes.IsPropertyDefault("Width");
			m_GridWidth = element.Attributes.GetPropertyValue<System.String>("GridWidth");
			m_IsGridWidthDefault = element.Attributes.IsPropertyDefault("GridWidth");
			m_GridHeight = element.Attributes.GetPropertyValue<System.String>("GridHeight");
			m_IsGridHeightDefault = element.Attributes.IsPropertyDefault("GridHeight");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "parameters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ParameterElement parameterElement = new ParameterElement();
							parameterElement.LoadFrom(_childElementItem);
							Parameters.Add(parameterElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="SubActionElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "SubAction")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "SubAction"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "caption", m_Caption, m_IsCaptionDefault);
			SaveAttribute(element, "gxobjectReference", m_GxobjectReference, m_IsGxobjectDefault);
			SaveAttribute(element, "inGrid", m_InGrid, m_IsInGridDefault);
			SaveAttribute(element, "multiRowSelection", m_MultiRowSelection, m_IsMultiRowSelectionDefault);
			SaveAttribute(element, "imageReference", m_ImageReference, m_IsImageDefault);
			SaveAttribute(element, "disabledImageReference", m_DisabledImageReference, m_IsDisabledImageDefault);
			SaveAttribute(element, "tooltip", m_Tooltip, m_IsTooltipDefault);
			SaveAttribute(element, "condition", m_Condition, m_IsConditionDefault);
			SaveAttribute(element, "buttonClass", m_ButtonClass, m_IsButtonClassDefault);
			SaveAttribute(element, "EventCode", m_EventCode, m_IsEventCodeDefault);
			SaveAttribute(element, "CodeEnable", m_CodeEnable, m_IsCodeEnableDefault);
			SaveAttribute(element, "Position", m_Position, m_IsPositionDefault);
			SaveAttribute(element, "Legend", m_Legend, m_IsLegendDefault);
			SaveAttribute(element, "Width", m_Width, m_IsWidthDefault);
			SaveAttribute(element, "GridWidth", m_GridWidth, m_IsGridWidthDefault);
			SaveAttribute(element, "GridHeight", m_GridHeight, m_IsGridHeightDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_Caption == element.Attributes.GetPropertyValue<System.String>("caption"));
			Debug.Assert(m_GxobjectReference == element.Attributes.GetPropertyValue<KBObjectReference>("gxobjectReference"));
			Debug.Assert(m_InGrid == element.Attributes.GetPropertyValue<System.Boolean>("inGrid"));
			Debug.Assert(m_MultiRowSelection == element.Attributes.GetPropertyValue<System.Boolean>("multiRowSelection"));
			Debug.Assert(m_ImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("imageReference"));
			Debug.Assert(m_DisabledImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("disabledImageReference"));
			Debug.Assert(m_Tooltip == element.Attributes.GetPropertyValue<System.String>("tooltip"));
			Debug.Assert(m_Condition == element.Attributes.GetPropertyValue<System.String>("condition"));
			Debug.Assert(m_EventCode == element.Attributes.GetPropertyValue<System.String>("EventCode"));
			Debug.Assert(m_CodeEnable == element.Attributes.GetPropertyValue<System.String>("CodeEnable"));
			Debug.Assert(m_Position == element.Attributes.GetPropertyValue<System.String>("Position"));
			Debug.Assert(m_Legend == element.Attributes.GetPropertyValue<System.String>("Legend"));
			Debug.Assert(m_Width == element.Attributes.GetPropertyValue<System.Int32>("Width"));
			Debug.Assert(m_GridWidth == element.Attributes.GetPropertyValue<System.String>("GridWidth"));
			Debug.Assert(m_GridHeight == element.Attributes.GetPropertyValue<System.String>("GridHeight"));

			// Save element children.
			if (m_Parameters != null)
			{
				if (m_Parameters.Count > 0)
					element.Children.AddNewElement("parameters");

				foreach (ParameterElement _item in Parameters)
				{
					PatternInstanceElement child = element.Children["parameters"].Children.AddNewElement("parameter");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SubActionElement"/>.
		/// </summary>
		public SubActionElement Clone()
		{
			SubActionElement clone = new SubActionElement();

			clone.Name = this.Name;
			clone.Caption = this.Caption;
			clone.Gxobject = this.Gxobject;
			clone.InGrid = this.InGrid;
			clone.MultiRowSelection = this.MultiRowSelection;
			clone.Image = this.Image;
			clone.DisabledImage = this.DisabledImage;
			clone.Tooltip = this.Tooltip;
			clone.Condition = this.Condition;
			clone.ButtonClass = this.ButtonClass;
			clone.EventCode = this.EventCode;
			clone.CodeEnable = this.CodeEnable;
			clone.Position = this.Position;
			clone.Legend = this.Legend;
			clone.Width = this.Width;
			clone.GridWidth = this.GridWidth;
			clone.GridHeight = this.GridHeight;
			foreach (ParameterElement parameterElement in this.Parameters)
				clone.Parameters.Add(parameterElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "parameters" :
				{
					if (path.Count == 0)
						return Parameters;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "parameter")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Parameters != null && itemIndex >= 0 && itemIndex < Parameters.Count)
						return Parameters[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Position"/> property.
		/// </summary>
		public static class PositionValue
		{
			public const string Footer = "Footer";
			public const string Grid = "Grid";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Action ({0})", Name);
		}

		#endregion
	}

	#endregion

	#region Element: SubActions

	public partial class SubActionsElement : Artech.Common.Collections.BaseCollection<SubActionElement>
	{
		protected string m_ElementName;

		#region Construction

		internal SubActionsElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<SubActionElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private ActionElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public ActionElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<SubActionElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of SubActionsElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="SubActionElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no SubAction is found, <b>null</b> is returned.
		/// </summary>
		public SubActionElement FindSubAction(System.String name)
		{
			return this.Find(delegate (SubActionElement subActionItem) { return subActionItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Actions";
		}

		#endregion
	}

	#endregion

	#region Element: Actions

	public partial class ActionsElement : Artech.Common.Collections.BaseCollection<ActionElement>
	{
		protected string m_ElementName;

		#region Construction

		internal ActionsElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<ActionElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<ActionElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of ActionsElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="ActionElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no Action is found, <b>null</b> is returned.
		/// </summary>
		public ActionElement FindAction(System.String name)
		{
			return this.Find(delegate (ActionElement actionItem) { return actionItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Actions";
		}

		#endregion
	}

	#endregion

	#region Element: TransactionAttribute

	public partial class TransactionAttributeElement : AttributeElement, IHPatternInstanceElement
	{
		private System.String m_Caption;
		private bool m_IsCaptionDefault;
		private System.String m_Class;
		private bool m_IsClassDefault;
		private System.String m_HTMLFormat;
		private bool m_IsHTMLFormatDefault;
		private System.String m_TextRule;
		private bool m_IsTextRuleDefault;
		private Artech.Genexus.Common.Objects.Attribute m_AttributeDescription;
		private KBObjectReference m_AttributeDescriptionReference;
		private bool m_IsAttributeDescriptionDefault;
		private Artech.Common.Collections.BaseCollection<LinkElement> m_Links;
		private GridColumnPropertiesElement m_GridColumnProperties;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="TransactionAttributeElement"/> class.
		/// </summary>
		public TransactionAttributeElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="TransactionAttributeElement"/> class, setting all its members to their default values.
		/// </summary>
		public override void Initialize()
		{
			base.Initialize();
			m_Caption = "";
			m_IsCaptionDefault = true;
			m_Class = null;
			m_IsClassDefault = true;
			m_HTMLFormat = "default";
			m_IsHTMLFormatDefault = true;
			m_TextRule = "Runtime";
			m_IsTextRuleDefault = true;
			m_AttributeDescription = null;
			m_AttributeDescriptionReference = null;
			m_IsAttributeDescriptionDefault = true;
			m_Links = new Artech.Common.Collections.BaseCollection<LinkElement>();
			m_Links.ItemAdded += new EventHandler<CollectionItemEventArgs<LinkElement>>(Links_ItemAdded);
			m_GridColumnProperties = new GridColumnPropertiesElement();
			m_GridColumnProperties.Parent = this;
			m_GridColumnProperties.ElementName = "GridColumnProperties";
		}

		#endregion

		#region Properties

		/// <summary>
		/*
		Caption Text.
		*/
		/// </summary>
		public System.String Caption
		{
			get { return m_Caption; }
			set 
			{
				m_Caption = value;
				m_IsCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		Class
		*/
		/// </summary>
		public System.String Class
		{
			get { return m_Class; }
			set 
			{
				m_Class = value;
				m_IsClassDefault = false;
			}
		}

		/// <summary>
		/*
		HTML Format
		*/
		/// </summary>
		public System.String HTMLFormat
		{
			get { return m_HTMLFormat; }
			set 
			{
				m_HTMLFormat = value;
				m_IsHTMLFormatDefault = false;
			}
		}

		/// <summary>
		/*
		Rule
		*/
		/// </summary>
		public System.String TextRule
		{
			get { return m_TextRule; }
			set 
			{
				m_TextRule = value;
				m_IsTextRuleDefault = false;
			}
		}

		/// <summary>
		/*
		Description Attribute.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Attribute AttributeDescription
		{
			get
			{
				if (m_AttributeDescription == null && m_AttributeDescriptionReference != null)
					m_AttributeDescription = (Artech.Genexus.Common.Objects.Attribute)m_AttributeDescriptionReference.GetKBObject(Instance.Model);

				return m_AttributeDescription;
			}

			set 
			{
				m_AttributeDescription = value;
				m_AttributeDescriptionReference = (value != null ? new KBObjectReference(value) : null);
				m_IsAttributeDescriptionDefault = false;
			}
		}

		/// <summary>
		/// AttributeDescription name.
		/// </summary>
		public string AttributeDescriptionName
		{
			get { return (AttributeDescription != null ? AttributeDescription.Name : null); }
		}

		public Artech.Common.Collections.IBaseCollection<LinkElement> Links
		{
			get { return m_Links; }
		}

		public GridColumnPropertiesElement GridColumnProperties
		{
			get { return m_GridColumnProperties; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="LinkElement"/> and adds it to the <see cref="Links"/> collection.
		/// </summary>
		public LinkElement AddLink()
		{
			LinkElement linkElement = new LinkElement();
			m_Links.Add(linkElement);
			return linkElement;
		}

		private void Links_ItemAdded(object sender, CollectionItemEventArgs<LinkElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="GridColumnPropertieElement"/> and adds it to the <see cref="GridColumnProperties"/> collection.
		/// </summary>
		public GridColumnPropertieElement AddGridColumnPropertie()
		{
			GridColumnPropertieElement gridColumnPropertieElement = new GridColumnPropertieElement();
			m_GridColumnProperties.Add(gridColumnPropertieElement);
			return gridColumnPropertieElement;
		}

		/// <summary>
		/// Creates a new <see cref="GridColumnPropertieElement"/> and adds it to the <see cref="GridColumnProperties"/> collection.
		/// The GridColumnPropertieElement is initialized with the specified value.
		/// </summary>
		public GridColumnPropertieElement AddGridColumnPropertie(System.String name)
		{
			GridColumnPropertieElement gridColumnPropertieElement = new GridColumnPropertieElement(name);
			m_GridColumnProperties.Add(gridColumnPropertieElement);
			return gridColumnPropertieElement;
		}

		/// <summary>
		/// Finds the <see cref="GridColumnPropertieElement"/> in the <see cref="GridColumnProperties"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridColumnPropertieElement is found, null is returned.
		/// </summary>
		public GridColumnPropertieElement FindGridColumnPropertie(System.String name)
		{
			return GridColumnProperties.Find(delegate (GridColumnPropertieElement gridColumnPropertieElement) { return gridColumnPropertieElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="TransactionAttributeElement"/> with the information present in the specified element.
		/// </summary>
		internal override void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "TransactionAttribute")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "TransactionAttribute"));

			Initialize();
			base.LoadFrom(element);
			m_ElementName = element.Name;

			// Load attribute values.
			m_Caption = element.Attributes.GetPropertyValue<System.String>("caption");
			m_IsCaptionDefault = element.Attributes.IsPropertyDefault("caption");
			m_Class = element.Attributes.GetPropertyValue<System.String>("Class");
			m_IsClassDefault = element.Attributes.IsPropertyDefault("Class");
			m_HTMLFormat = element.Attributes.GetPropertyValue<System.String>("HTMLFormat");
			m_IsHTMLFormatDefault = element.Attributes.IsPropertyDefault("HTMLFormat");
			m_TextRule = element.Attributes.GetPropertyValue<System.String>("TextRule");
			m_IsTextRuleDefault = element.Attributes.IsPropertyDefault("TextRule");
			m_AttributeDescriptionReference = element.Attributes.GetPropertyValue<KBObjectReference>("attributeDescriptionReference");
			m_IsAttributeDescriptionDefault = element.Attributes.IsPropertyDefault("attributeDescription");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "link" :
					{
						LinkElement link = new LinkElement();
						link.LoadFrom(_childElement);
						Links.Add(link);
						break;
					}
					case "GridColumnProperties" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							GridColumnPropertieElement gridColumnPropertieElement = new GridColumnPropertieElement();
							gridColumnPropertieElement.LoadFrom(_childElementItem);
							GridColumnProperties.Add(gridColumnPropertieElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="TransactionAttributeElement"/> information to the specified element.
		/// </summary>
		internal override void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "TransactionAttribute")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "TransactionAttribute"));

			element.Initialize();
			base.SaveTo(element);

			// Save attribute values.
			SaveAttribute(element, "caption", m_Caption, m_IsCaptionDefault);
			SaveAttribute(element, "Class", m_Class, m_IsClassDefault);
			SaveAttribute(element, "HTMLFormat", m_HTMLFormat, m_IsHTMLFormatDefault);
			SaveAttribute(element, "TextRule", m_TextRule, m_IsTextRuleDefault);
			SaveAttribute(element, "attributeDescriptionReference", m_AttributeDescriptionReference, m_IsAttributeDescriptionDefault);

			Debug.Assert(m_Caption == element.Attributes.GetPropertyValue<System.String>("caption"));
			Debug.Assert(m_HTMLFormat == element.Attributes.GetPropertyValue<System.String>("HTMLFormat"));
			Debug.Assert(m_AttributeDescriptionReference == element.Attributes.GetPropertyValue<KBObjectReference>("attributeDescriptionReference"));

			// Save element children.
			if (m_Links != null)
			{
				foreach (LinkElement _item in Links)
				{
					PatternInstanceElement link = element.Children.AddNewElement("link");
					_item.SaveTo(link);
				}
			}

			if (m_GridColumnProperties != null)
			{
				if (m_GridColumnProperties.Count > 0)
					element.Children.AddNewElement("GridColumnProperties");

				foreach (GridColumnPropertieElement _item in GridColumnProperties)
				{
					PatternInstanceElement child = element.Children["GridColumnProperties"].Children.AddNewElement("GridColumnPropertie");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="TransactionAttributeElement"/>.
		/// </summary>
		public new TransactionAttributeElement Clone()
		{
			TransactionAttributeElement clone = new TransactionAttributeElement();

			clone.Attribute = this.Attribute;
			clone.Description = this.Description;
			clone.Autolink = this.Autolink;
			clone.Visible = this.Visible;
			clone.ThemeClass = this.ThemeClass;
			clone.Format = this.Format;
			clone.IsValid = this.IsValid;
			clone.Required = this.Required;
			clone.RequiredMessage = this.RequiredMessage;
			clone.RequiredAfterValidate = this.RequiredAfterValidate;
			clone.Rule = this.Rule;
			clone.ValueRule = this.ValueRule;
			clone.Picture = this.Picture;
			clone.Readonly = this.Readonly;
			clone.EventValidation = this.EventValidation;
			clone.EventStart = this.EventStart;
			clone.MaskPicture = this.MaskPicture;
			clone.Reverse = this.Reverse;
			clone.Signed = this.Signed;
			clone.UnmaskedChars = this.UnmaskedChars;
			clone.UnmaskedValue = this.UnmaskedValue;
			clone.Width = this.Width;
			clone.Height = this.Height;
			clone.Caption = this.Caption;
			clone.Class = this.Class;
			clone.HTMLFormat = this.HTMLFormat;
			clone.TextRule = this.TextRule;
			clone.AttributeDescription = this.AttributeDescription;
			foreach (LinkElement linkElement in this.Links)
				clone.Links.Add(linkElement.Clone());
			foreach (GridColumnPropertieElement gridColumnPropertieElement in this.GridColumnProperties)
				clone.GridColumnProperties.Add(gridColumnPropertieElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal override object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "link" :
				{
					if (Links != null && childIndex >= 0 && childIndex < Links.Count)
						return Links[childIndex].GetElement(path);
					else
						return null;
				}
				case "GridColumnProperties" :
				{
					if (path.Count == 0)
						return GridColumnProperties;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "GridColumnPropertie")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (GridColumnProperties != null && itemIndex >= 0 && itemIndex < GridColumnProperties.Count)
						return GridColumnProperties[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="HTMLFormat"/> property.
		/// </summary>
		public static class HTMLFormatValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Default = "default";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return ElementName;
		}

		#endregion
	}

	#endregion

	#region Element: Attribute

	public partial class AttributeElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private Artech.Genexus.Common.Objects.Attribute m_Attribute;
		private KBObjectReference m_AttributeReference;
		private bool m_IsAttributeDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private System.Boolean m_Autolink;
		private bool m_IsAutolinkDefault;
		private System.Boolean m_Visible;
		private bool m_IsVisibleDefault;
		private System.String m_ThemeClass;
		private bool m_IsThemeClassDefault;
		private System.String m_Format;
		private bool m_IsFormatDefault;
		private System.String m_IsValid;
		private bool m_IsIsValidDefault;
		private System.String m_Required;
		private bool m_IsRequiredDefault;
		private System.String m_RequiredMessage;
		private bool m_IsRequiredMessageDefault;
		private System.String m_RequiredAfterValidate;
		private bool m_IsRequiredAfterValidateDefault;
		private System.String m_Rule;
		private bool m_IsRuleDefault;
		private System.String m_ValueRule;
		private bool m_IsValueRuleDefault;
		private System.String m_Picture;
		private bool m_IsPictureDefault;
		private System.Boolean m_Readonly;
		private bool m_IsReadonlyDefault;
		private System.String m_EventValidation;
		private bool m_IsEventValidationDefault;
		private System.String m_EventStart;
		private bool m_IsEventStartDefault;
		private System.String m_MaskPicture;
		private bool m_IsMaskPictureDefault;
		private System.Boolean m_Reverse;
		private bool m_IsReverseDefault;
		private System.Boolean m_Signed;
		private bool m_IsSignedDefault;
		private System.String m_UnmaskedChars;
		private bool m_IsUnmaskedCharsDefault;
		private System.Boolean m_UnmaskedValue;
		private bool m_IsUnmaskedValueDefault;
		private System.String m_Width;
		private bool m_IsWidthDefault;
		private System.String m_Height;
		private bool m_IsHeightDefault;
		private Artech.Common.Collections.BaseCollection<LinkElement> m_Links;
		private GridColumnPropertiesElement m_GridColumnProperties;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="AttributeElement"/> class.
		/// </summary>
		public AttributeElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AttributeElement"/> class, setting its <see cref="Attribute"/> property to the specified value.
		/// </summary>
		public AttributeElement(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			Initialize();
			Attribute = attribute;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="AttributeElement"/> class, setting all its members to their default values.
		/// </summary>
		public virtual void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Attribute = null;
			m_AttributeReference = null;
			m_IsAttributeDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_Autolink = false;
			m_IsAutolinkDefault = true;
			m_Visible = true;
			m_IsVisibleDefault = true;
			m_ThemeClass = null;
			m_IsThemeClassDefault = true;
			m_Format = "<default>";
			m_IsFormatDefault = true;
			m_IsValid = "";
			m_IsIsValidDefault = true;
			m_Required = "default";
			m_IsRequiredDefault = true;
			m_RequiredMessage = "default";
			m_IsRequiredMessageDefault = true;
			m_RequiredAfterValidate = "default";
			m_IsRequiredAfterValidateDefault = true;
			m_Rule = "<default>";
			m_IsRuleDefault = true;
			m_ValueRule = "<default>";
			m_IsValueRuleDefault = true;
			m_Picture = "default";
			m_IsPictureDefault = true;
			m_Readonly = false;
			m_IsReadonlyDefault = true;
			m_EventValidation = "";
			m_IsEventValidationDefault = true;
			m_EventStart = "";
			m_IsEventStartDefault = true;
			m_MaskPicture = "";
			m_IsMaskPictureDefault = true;
			m_Reverse = false;
			m_IsReverseDefault = true;
			m_Signed = false;
			m_IsSignedDefault = true;
			m_UnmaskedChars = "[().:/ -]";
			m_IsUnmaskedCharsDefault = true;
			m_UnmaskedValue = false;
			m_IsUnmaskedValueDefault = true;
			m_Width = "";
			m_IsWidthDefault = true;
			m_Height = "";
			m_IsHeightDefault = true;
			m_Links = new Artech.Common.Collections.BaseCollection<LinkElement>();
			m_Links.ItemAdded += new EventHandler<CollectionItemEventArgs<LinkElement>>(Links_ItemAdded);
			m_GridColumnProperties = new GridColumnPropertiesElement();
			m_GridColumnProperties.Parent = this;
			m_GridColumnProperties.ElementName = "GridColumnProperties";
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="AttributeElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Attribute.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Attribute Attribute
		{
			get
			{
				if (m_Attribute == null && m_AttributeReference != null)
					m_Attribute = (Artech.Genexus.Common.Objects.Attribute)m_AttributeReference.GetKBObject(Instance.Model);

				return m_Attribute;
			}

			set 
			{
				m_Attribute = value;
				m_AttributeReference = (value != null ? new KBObjectReference(value) : null);
				m_IsAttributeDefault = false;
			}
		}

		/// <summary>
		/// Attribute name.
		/// </summary>
		public string AttributeName
		{
			get { return (Attribute != null ? Attribute.Name : null); }
		}

		/// <summary>
		/*
		Attribute description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Automatically generate links to other pattern instances for description attributes and supertypes.
		*/
		/// </summary>
		public System.Boolean Autolink
		{
			get { return m_Autolink; }
			set 
			{
				m_Autolink = value;
				m_IsAutolinkDefault = false;
			}
		}

		/// <summary>
		/*
		Attribute is visible (if false, in grids the column will be hidden, and in tabular tabs the attribute will be invisible).
		*/
		/// </summary>
		public System.Boolean Visible
		{
			get { return m_Visible; }
			set 
			{
				m_Visible = value;
				m_IsVisibleDefault = false;
			}
		}

		/// <summary>
		/*
		Theme class for the attribute.
		*/
		/// </summary>
		public System.String ThemeClass
		{
			get { return m_ThemeClass; }
			set 
			{
				m_ThemeClass = value;
				m_IsThemeClassDefault = false;
			}
		}

		/// <summary>
		/*
		HTML format for the attribute.
		*/
		/// </summary>
		public System.String Format
		{
			get { return m_Format; }
			set 
			{
				m_Format = value;
				m_IsFormatDefault = false;
			}
		}

		/// <summary>
		/*
		Evento IsValid para Atributo ou variável
		*/
		/// </summary>
		public System.String IsValid
		{
			get { return m_IsValid; }
			set 
			{
				m_IsValid = value;
				m_IsIsValidDefault = false;
			}
		}

		/// <summary>
		/*
		Define como obrigatório atributo
		*/
		/// </summary>
		public System.String Required
		{
			get { return m_Required; }
			set 
			{
				m_Required = value;
				m_IsRequiredDefault = false;
			}
		}

		/// <summary>
		/*
		Define mensagem padrão para atributo obrigatório, Coringda {0} é a descrição do atributo
		*/
		/// </summary>
		public System.String RequiredMessage
		{
			get { return m_RequiredMessage; }
			set 
			{
				m_RequiredMessage = value;
				m_IsRequiredMessageDefault = false;
			}
		}

		/// <summary>
		/*
		Define se aplica a regra error no AfterValidate ou não
		*/
		/// </summary>
		public System.String RequiredAfterValidate
		{
			get { return m_RequiredAfterValidate; }
			set 
			{
				m_RequiredAfterValidate = value;
				m_IsRequiredAfterValidateDefault = false;
			}
		}

		/// <summary>
		/*
		Define regra para atributo
		*/
		/// </summary>
		public System.String Rule
		{
			get { return m_Rule; }
			set 
			{
				m_Rule = value;
				m_IsRuleDefault = false;
			}
		}

		/// <summary>
		/*
		Define valor da regra para atributo
		*/
		/// </summary>
		public System.String ValueRule
		{
			get { return m_ValueRule; }
			set 
			{
				m_ValueRule = value;
				m_IsValueRuleDefault = false;
			}
		}

		/// <summary>
		/*
		Define a picture para o atributo
		*/
		/// </summary>
		public System.String Picture
		{
			get { return m_Picture; }
			set 
			{
				m_Picture = value;
				m_IsPictureDefault = false;
			}
		}

		/// <summary>
		/*
		Define se é ReadOnly
		*/
		/// </summary>
		public System.Boolean Readonly
		{
			get { return m_Readonly; }
			set 
			{
				m_Readonly = value;
				m_IsReadonlyDefault = false;
			}
		}

		/// <summary>
		/*
		Define código de Evento que será utilizado para validação do Atributo, Coringa {0} define o nome do atributo com SDT, {1} define o nome do atributo, {2} define a variavel Mode, {3} define a lista SDT do segundo nivel
		*/
		/// </summary>
		public System.String EventValidation
		{
			get { return m_EventValidation; }
			set 
			{
				m_EventValidation = value;
				m_IsEventValidationDefault = false;
			}
		}

		/// <summary>
		/*
		Define código para o Evento Start, coringa {0} define o valor e {1} define o controle em tela
		*/
		/// </summary>
		public System.String EventStart
		{
			get { return m_EventStart; }
			set 
			{
				m_EventStart = value;
				m_IsEventStartDefault = false;
			}
		}

		/// <summary>
		/*
		Define a Picture
		*/
		/// </summary>
		public System.String MaskPicture
		{
			get { return m_MaskPicture; }
			set 
			{
				m_MaskPicture = value;
				m_IsMaskPictureDefault = false;
			}
		}

		/// <summary>
		/*
		Define se a digitação será invertida
		*/
		/// </summary>
		public System.Boolean Reverse
		{
			get { return m_Reverse; }
			set 
			{
				m_Reverse = value;
				m_IsReverseDefault = false;
			}
		}

		/// <summary>
		/*
		Define se permite valor negativo
		*/
		/// </summary>
		public System.Boolean Signed
		{
			get { return m_Signed; }
			set 
			{
				m_Signed = value;
				m_IsSignedDefault = false;
			}
		}

		/// <summary>
		/*
		Define os caracteres que serão retirados quando retorna valor sem a mascara
		*/
		/// </summary>
		public System.String UnmaskedChars
		{
			get { return m_UnmaskedChars; }
			set 
			{
				m_UnmaskedChars = value;
				m_IsUnmaskedCharsDefault = false;
			}
		}

		/// <summary>
		/*
		Define se retorna o valor sem a mascara ou não
		*/
		/// </summary>
		public System.Boolean UnmaskedValue
		{
			get { return m_UnmaskedValue; }
			set 
			{
				m_UnmaskedValue = value;
				m_IsUnmaskedValueDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width(tamanho horizontal) para o Atributo
		*/
		/// </summary>
		public System.String Width
		{
			get { return m_Width; }
			set 
			{
				m_Width = value;
				m_IsWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Height(tamanho vertical) para o Atributo
		*/
		/// </summary>
		public System.String Height
		{
			get { return m_Height; }
			set 
			{
				m_Height = value;
				m_IsHeightDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<LinkElement> Links
		{
			get { return m_Links; }
		}

		public GridColumnPropertiesElement GridColumnProperties
		{
			get { return m_GridColumnProperties; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="LinkElement"/> and adds it to the <see cref="Links"/> collection.
		/// </summary>
		public LinkElement AddLink()
		{
			LinkElement linkElement = new LinkElement();
			m_Links.Add(linkElement);
			return linkElement;
		}

		private void Links_ItemAdded(object sender, CollectionItemEventArgs<LinkElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="GridColumnPropertieElement"/> and adds it to the <see cref="GridColumnProperties"/> collection.
		/// </summary>
		public GridColumnPropertieElement AddGridColumnPropertie()
		{
			GridColumnPropertieElement gridColumnPropertieElement = new GridColumnPropertieElement();
			m_GridColumnProperties.Add(gridColumnPropertieElement);
			return gridColumnPropertieElement;
		}

		/// <summary>
		/// Creates a new <see cref="GridColumnPropertieElement"/> and adds it to the <see cref="GridColumnProperties"/> collection.
		/// The GridColumnPropertieElement is initialized with the specified value.
		/// </summary>
		public GridColumnPropertieElement AddGridColumnPropertie(System.String name)
		{
			GridColumnPropertieElement gridColumnPropertieElement = new GridColumnPropertieElement(name);
			m_GridColumnProperties.Add(gridColumnPropertieElement);
			return gridColumnPropertieElement;
		}

		/// <summary>
		/// Finds the <see cref="GridColumnPropertieElement"/> in the <see cref="GridColumnProperties"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridColumnPropertieElement is found, null is returned.
		/// </summary>
		public GridColumnPropertieElement FindGridColumnPropertie(System.String name)
		{
			return GridColumnProperties.Find(delegate (GridColumnPropertieElement gridColumnPropertieElement) { return gridColumnPropertieElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="AttributeElement"/> with the information present in the specified element.
		/// </summary>
		internal virtual void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_AttributeReference = element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference");
			m_IsAttributeDefault = element.Attributes.IsPropertyDefault("attribute");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");
			m_Autolink = element.Attributes.GetPropertyValue<System.Boolean>("autolink");
			m_IsAutolinkDefault = element.Attributes.IsPropertyDefault("autolink");
			m_Visible = element.Attributes.GetPropertyValue<System.Boolean>("visible");
			m_IsVisibleDefault = element.Attributes.IsPropertyDefault("visible");
			m_ThemeClass = element.Attributes.GetPropertyValue<System.String>("themeClass");
			m_IsThemeClassDefault = element.Attributes.IsPropertyDefault("themeClass");
			m_Format = element.Attributes.GetPropertyValue<System.String>("format");
			m_IsFormatDefault = element.Attributes.IsPropertyDefault("format");
			m_IsValid = element.Attributes.GetPropertyValue<System.String>("isValid");
			m_IsIsValidDefault = element.Attributes.IsPropertyDefault("isValid");
			m_Required = element.Attributes.GetPropertyValue<System.String>("required");
			m_IsRequiredDefault = element.Attributes.IsPropertyDefault("required");
			m_RequiredMessage = element.Attributes.GetPropertyValue<System.String>("requiredMessage");
			m_IsRequiredMessageDefault = element.Attributes.IsPropertyDefault("requiredMessage");
			m_RequiredAfterValidate = element.Attributes.GetPropertyValue<System.String>("requiredAfterValidate");
			m_IsRequiredAfterValidateDefault = element.Attributes.IsPropertyDefault("requiredAfterValidate");
			m_Rule = element.Attributes.GetPropertyValue<System.String>("rule");
			m_IsRuleDefault = element.Attributes.IsPropertyDefault("rule");
			m_ValueRule = element.Attributes.GetPropertyValue<System.String>("valueRule");
			m_IsValueRuleDefault = element.Attributes.IsPropertyDefault("valueRule");
			m_Picture = element.Attributes.GetPropertyValue<System.String>("picture");
			m_IsPictureDefault = element.Attributes.IsPropertyDefault("picture");
			m_Readonly = element.Attributes.GetPropertyValue<System.Boolean>("readonly");
			m_IsReadonlyDefault = element.Attributes.IsPropertyDefault("readonly");
			m_EventValidation = element.Attributes.GetPropertyValue<System.String>("eventValidation");
			m_IsEventValidationDefault = element.Attributes.IsPropertyDefault("eventValidation");
			m_EventStart = element.Attributes.GetPropertyValue<System.String>("EventStart");
			m_IsEventStartDefault = element.Attributes.IsPropertyDefault("EventStart");
			m_MaskPicture = element.Attributes.GetPropertyValue<System.String>("MaskPicture");
			m_IsMaskPictureDefault = element.Attributes.IsPropertyDefault("MaskPicture");
			m_Reverse = element.Attributes.GetPropertyValue<System.Boolean>("Reverse");
			m_IsReverseDefault = element.Attributes.IsPropertyDefault("Reverse");
			m_Signed = element.Attributes.GetPropertyValue<System.Boolean>("Signed");
			m_IsSignedDefault = element.Attributes.IsPropertyDefault("Signed");
			m_UnmaskedChars = element.Attributes.GetPropertyValue<System.String>("UnmaskedChars");
			m_IsUnmaskedCharsDefault = element.Attributes.IsPropertyDefault("UnmaskedChars");
			m_UnmaskedValue = element.Attributes.GetPropertyValue<System.Boolean>("UnmaskedValue");
			m_IsUnmaskedValueDefault = element.Attributes.IsPropertyDefault("UnmaskedValue");
			m_Width = element.Attributes.GetPropertyValue<System.String>("Width");
			m_IsWidthDefault = element.Attributes.IsPropertyDefault("Width");
			m_Height = element.Attributes.GetPropertyValue<System.String>("Height");
			m_IsHeightDefault = element.Attributes.IsPropertyDefault("Height");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "link" :
					{
						LinkElement link = new LinkElement();
						link.LoadFrom(_childElement);
						Links.Add(link);
						break;
					}
					case "GridColumnProperties" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							GridColumnPropertieElement gridColumnPropertieElement = new GridColumnPropertieElement();
							gridColumnPropertieElement.LoadFrom(_childElementItem);
							GridColumnProperties.Add(gridColumnPropertieElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="AttributeElement"/> information to the specified element.
		/// </summary>
		internal virtual void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "attributeReference", m_AttributeReference, m_IsAttributeDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);
			SaveAttribute(element, "autolink", m_Autolink, m_IsAutolinkDefault);
			SaveAttribute(element, "visible", m_Visible, m_IsVisibleDefault);
			SaveAttribute(element, "themeClass", m_ThemeClass, m_IsThemeClassDefault);
			SaveAttribute(element, "format", m_Format, m_IsFormatDefault);
			SaveAttribute(element, "isValid", m_IsValid, m_IsIsValidDefault);
			SaveAttribute(element, "required", m_Required, m_IsRequiredDefault);
			SaveAttribute(element, "requiredMessage", m_RequiredMessage, m_IsRequiredMessageDefault);
			SaveAttribute(element, "requiredAfterValidate", m_RequiredAfterValidate, m_IsRequiredAfterValidateDefault);
			SaveAttribute(element, "rule", m_Rule, m_IsRuleDefault);
			SaveAttribute(element, "valueRule", m_ValueRule, m_IsValueRuleDefault);
			SaveAttribute(element, "picture", m_Picture, m_IsPictureDefault);
			SaveAttribute(element, "readonly", m_Readonly, m_IsReadonlyDefault);
			SaveAttribute(element, "eventValidation", m_EventValidation, m_IsEventValidationDefault);
			SaveAttribute(element, "EventStart", m_EventStart, m_IsEventStartDefault);
			SaveAttribute(element, "MaskPicture", m_MaskPicture, m_IsMaskPictureDefault);
			SaveAttribute(element, "Reverse", m_Reverse, m_IsReverseDefault);
			SaveAttribute(element, "Signed", m_Signed, m_IsSignedDefault);
			SaveAttribute(element, "UnmaskedChars", m_UnmaskedChars, m_IsUnmaskedCharsDefault);
			SaveAttribute(element, "UnmaskedValue", m_UnmaskedValue, m_IsUnmaskedValueDefault);
			SaveAttribute(element, "Width", m_Width, m_IsWidthDefault);
			SaveAttribute(element, "Height", m_Height, m_IsHeightDefault);

			Debug.Assert(m_AttributeReference == element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));
			Debug.Assert(m_Autolink == element.Attributes.GetPropertyValue<System.Boolean>("autolink"));
			Debug.Assert(m_Visible == element.Attributes.GetPropertyValue<System.Boolean>("visible"));
			Debug.Assert(m_Format == element.Attributes.GetPropertyValue<System.String>("format"));
			Debug.Assert(m_IsValid == element.Attributes.GetPropertyValue<System.String>("isValid"));
			Debug.Assert(m_Required == element.Attributes.GetPropertyValue<System.String>("required"));
			Debug.Assert(m_RequiredMessage == element.Attributes.GetPropertyValue<System.String>("requiredMessage"));
			Debug.Assert(m_RequiredAfterValidate == element.Attributes.GetPropertyValue<System.String>("requiredAfterValidate"));
			Debug.Assert(m_Rule == element.Attributes.GetPropertyValue<System.String>("rule"));
			Debug.Assert(m_ValueRule == element.Attributes.GetPropertyValue<System.String>("valueRule"));
			Debug.Assert(m_Picture == element.Attributes.GetPropertyValue<System.String>("picture"));
			Debug.Assert(m_Readonly == element.Attributes.GetPropertyValue<System.Boolean>("readonly"));
			Debug.Assert(m_EventValidation == element.Attributes.GetPropertyValue<System.String>("eventValidation"));
			Debug.Assert(m_EventStart == element.Attributes.GetPropertyValue<System.String>("EventStart"));
			Debug.Assert(m_MaskPicture == element.Attributes.GetPropertyValue<System.String>("MaskPicture"));
			Debug.Assert(m_Reverse == element.Attributes.GetPropertyValue<System.Boolean>("Reverse"));
			Debug.Assert(m_Signed == element.Attributes.GetPropertyValue<System.Boolean>("Signed"));
			Debug.Assert(m_UnmaskedChars == element.Attributes.GetPropertyValue<System.String>("UnmaskedChars"));
			Debug.Assert(m_UnmaskedValue == element.Attributes.GetPropertyValue<System.Boolean>("UnmaskedValue"));
			Debug.Assert(m_Width == element.Attributes.GetPropertyValue<System.String>("Width"));
			Debug.Assert(m_Height == element.Attributes.GetPropertyValue<System.String>("Height"));

			// Save element children.
			if (m_Links != null)
			{
				foreach (LinkElement _item in Links)
				{
					PatternInstanceElement link = element.Children.AddNewElement("link");
					_item.SaveTo(link);
				}
			}

			if (m_GridColumnProperties != null)
			{
				if (m_GridColumnProperties.Count > 0)
					element.Children.AddNewElement("GridColumnProperties");

				foreach (GridColumnPropertieElement _item in GridColumnProperties)
				{
					PatternInstanceElement child = element.Children["GridColumnProperties"].Children.AddNewElement("GridColumnPropertie");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="AttributeElement"/>.
		/// </summary>
		public AttributeElement Clone()
		{
			AttributeElement clone = new AttributeElement();

			clone.Attribute = this.Attribute;
			clone.Description = this.Description;
			clone.Autolink = this.Autolink;
			clone.Visible = this.Visible;
			clone.ThemeClass = this.ThemeClass;
			clone.Format = this.Format;
			clone.IsValid = this.IsValid;
			clone.Required = this.Required;
			clone.RequiredMessage = this.RequiredMessage;
			clone.RequiredAfterValidate = this.RequiredAfterValidate;
			clone.Rule = this.Rule;
			clone.ValueRule = this.ValueRule;
			clone.Picture = this.Picture;
			clone.Readonly = this.Readonly;
			clone.EventValidation = this.EventValidation;
			clone.EventStart = this.EventStart;
			clone.MaskPicture = this.MaskPicture;
			clone.Reverse = this.Reverse;
			clone.Signed = this.Signed;
			clone.UnmaskedChars = this.UnmaskedChars;
			clone.UnmaskedValue = this.UnmaskedValue;
			clone.Width = this.Width;
			clone.Height = this.Height;
			foreach (LinkElement linkElement in this.Links)
				clone.Links.Add(linkElement.Clone());
			foreach (GridColumnPropertieElement gridColumnPropertieElement in this.GridColumnProperties)
				clone.GridColumnProperties.Add(gridColumnPropertieElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal virtual object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "link" :
				{
					if (Links != null && childIndex >= 0 && childIndex < Links.Count)
						return Links[childIndex].GetElement(path);
					else
						return null;
				}
				case "GridColumnProperties" :
				{
					if (path.Count == 0)
						return GridColumnProperties;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "GridColumnPropertie")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (GridColumnProperties != null && itemIndex >= 0 && itemIndex < GridColumnProperties.Count)
						return GridColumnProperties[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Format"/> property.
		/// </summary>
		public static class FormatValue
		{
			public const string Default = "<default>";
			public const string Text = "Text";
			public const string HTML = "HTML";
			public const string RawHTML = "Raw HTML";
			public const string TextWithMeaningfulSpaces = "Text with meaningful spaces";
		}

		/// <summary>
		/// Possible values for the <see cref="Required"/> property.
		/// </summary>
		public static class RequiredValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Default = "default";
		}

		/// <summary>
		/// Possible values for the <see cref="RequiredMessage"/> property.
		/// </summary>
		public static class RequiredMessageValue
		{
			public const string Default = "default";
		}

		/// <summary>
		/// Possible values for the <see cref="RequiredAfterValidate"/> property.
		/// </summary>
		public static class RequiredAfterValidateValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Default = "default";
		}

		/// <summary>
		/// Possible values for the <see cref="Rule"/> property.
		/// </summary>
		public static class RuleValue
		{
			public const string DefaultRule = "DefaultRule";
			public const string AfterValidate = "AfterValidate";
			public const string AfterInsert = "AfterInsert";
			public const string AfterUpdate = "AfterUpdate";
			public const string AfterDelete = "AfterDelete";
			public const string BeforeValidate = "BeforeValidate";
			public const string BeforeInsert = "BeforeInsert";
			public const string BeforeUpdate = "BeforeUpdate";
			public const string BeforeDelete = "BeforeDelete";
			public const string None = "None";
			public const string Default = "<default>";
		}

		/// <summary>
		/// Possible values for the <see cref="ValueRule"/> property.
		/// </summary>
		public static class ValueRuleValue
		{
			public const string Default = "<default>";
		}

		/// <summary>
		/// Possible values for the <see cref="Picture"/> property.
		/// </summary>
		public static class PictureValue
		{
			public const string Default = "default";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", AttributeName);
		}

		#endregion
	}

	#endregion

	#region Element: Attributes

	public partial class AttributesElement : IEnumerable<IHPatternInstanceElement>, IHPatternInstanceElement
	{
		protected string m_ElementName;
		private Artech.Common.Collections.BaseCollection<IHPatternInstanceElement> m_Items;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="AttributesElement"/> class.
		/// </summary>
		public AttributesElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="AttributesElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Items = new Artech.Common.Collections.BaseCollection<IHPatternInstanceElement>();
			m_Items.ItemAdded += new EventHandler<CollectionItemEventArgs<IHPatternInstanceElement>>(Items_ItemAdded);
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="AttributesElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		public Artech.Common.Collections.IBaseCollection<AttributeElement> Attributes
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<AttributeElement> tmpAttributes = new Artech.Common.Collections.BaseCollection<AttributeElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is AttributeElement)
						tmpAttributes.Add((AttributeElement)obj);

				return tmpAttributes.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<VariableElement> Variables
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<VariableElement> tmpVariables = new Artech.Common.Collections.BaseCollection<VariableElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is VariableElement)
						tmpVariables.Add((VariableElement)obj);

				return tmpVariables.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<IHPatternInstanceElement> Items
		{
			get { return m_Items; }
		}

		public IEnumerator<IHPatternInstanceElement> GetEnumerator()
		{
			return m_Items.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((System.Collections.IEnumerable)m_Items).GetEnumerator();
		}

		#endregion

		#region Helper methods

		public void Add(IHPatternInstanceElement item)
		{
			m_Items.Add(item);
		}

		/// <summary>
		/// Creates a new <see cref="AttributeElement"/> and adds it to the <see cref="Attributes"/> collection.
		/// </summary>
		public AttributeElement AddAttribute()
		{
			AttributeElement attributeElement = new AttributeElement();
			m_Items.Add(attributeElement);
			return attributeElement;
		}

		/// <summary>
		/// Creates a new <see cref="AttributeElement"/> and adds it to the <see cref="Attributes"/> collection.
		/// The AttributeElement is initialized with the specified value.
		/// </summary>
		public AttributeElement AddAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			AttributeElement attributeElement = new AttributeElement(attribute);
			m_Items.Add(attributeElement);
			return attributeElement;
		}

		/// <summary>
		/// Finds the <see cref="AttributeElement"/> in the <see cref="Attributes"/> collection that has the specified value in its <see cref="Attribute"/> property.
		/// If no attributeElement is found, null is returned.
		/// </summary>
		public AttributeElement FindAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			return Attributes.Find(delegate (AttributeElement attributeElement) { return attributeElement.Attribute == attribute; });
		}

		private void Attributes_ItemAdded(object sender, CollectionItemEventArgs<AttributeElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="VariableElement"/> and adds it to the <see cref="Variables"/> collection.
		/// </summary>
		public VariableElement AddVariable()
		{
			VariableElement variableElement = new VariableElement();
			m_Items.Add(variableElement);
			return variableElement;
		}

		/// <summary>
		/// Creates a new <see cref="VariableElement"/> and adds it to the <see cref="Variables"/> collection.
		/// The VariableElement is initialized with the specified value.
		/// </summary>
		public VariableElement AddVariable(System.String name)
		{
			VariableElement variableElement = new VariableElement(name);
			m_Items.Add(variableElement);
			return variableElement;
		}

		/// <summary>
		/// Finds the <see cref="VariableElement"/> in the <see cref="Variables"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no variableElement is found, null is returned.
		/// </summary>
		public VariableElement FindVariable(System.String name)
		{
			return Variables.Find(delegate (VariableElement variableElement) { return variableElement.Name == name; });
		}

		private void Variables_ItemAdded(object sender, CollectionItemEventArgs<VariableElement> e)
		{
			e.Data.Parent = this;
		}

		private void Items_ItemAdded(object sender, CollectionItemEventArgs<IHPatternInstanceElement> e)
		{
			if (e.Data is AttributeElement)
				((AttributeElement)e.Data).Parent = this;
			else if (e.Data is VariableElement)
				((VariableElement)e.Data).Parent = this;
			else
				throw new PatternInstanceException(String.Format("An object of an unexpected type {0} was added as child of {1}.", e.Data.GetType(), this.GetType()));
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="AttributesElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Attributes")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Attributes"));

			Initialize();
			m_ElementName = element.Name;

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "attribute" :
					{
						AttributeElement attribute = new AttributeElement();
						attribute.LoadFrom(_childElement);
						Add(attribute);
						break;
					}
					case "variable" :
					{
						VariableElement variable = new VariableElement();
						variable.LoadFrom(_childElement);
						Add(variable);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="AttributesElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Attributes")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Attributes"));

			element.Initialize();

			// Save element children.
			foreach (IHPatternInstanceElement _obj in m_Items)
			{
				if (_obj is AttributeElement)
				{
					PatternInstanceElement attribute = element.Children.AddNewElement("attribute");
					((AttributeElement)_obj).SaveTo(attribute);
				}
				else if (_obj is VariableElement)
				{
					PatternInstanceElement variable = element.Children.AddNewElement("variable");
					((VariableElement)_obj).SaveTo(variable);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="AttributesElement"/>.
		/// </summary>
		public AttributesElement Clone()
		{
			AttributesElement clone = new AttributesElement();
			foreach (IHPatternInstanceElement element in this)
				clone.Add(element.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "attribute" :
				{
					if (Attributes != null && childIndex >= 0 && childIndex < Attributes.Count)
						return Attributes[childIndex].GetElement(path);
					else
						return null;
				}
				case "variable" :
				{
					if (Variables != null && childIndex >= 0 && childIndex < Variables.Count)
						return Variables[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Attributes";
		}

		#endregion
	}

	#endregion

	#region Element: Condition

	public partial class ConditionElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Value;
		private bool m_IsValueDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="ConditionElement"/> class.
		/// </summary>
		public ConditionElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ConditionElement"/> class, setting its <see cref="Value"/> property to the specified value.
		/// </summary>
		public ConditionElement(System.String value)
		{
			Initialize();
			Value = value;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="ConditionElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Value = "";
			m_IsValueDefault = true;
		}

		#endregion

		#region Properties

		private FilterElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="ConditionElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public FilterElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Filter Condition. Pode utilizar o coringa {0} que define o nome da variavel SDT com ponto
		*/
		/// </summary>
		public System.String Value
		{
			get { return m_Value; }
			set 
			{
				m_Value = value;
				m_IsValueDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="ConditionElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Condition")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Condition"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Value = element.Attributes.GetPropertyValue<System.String>("value");
			m_IsValueDefault = element.Attributes.IsPropertyDefault("value");
		}

		/// <summary>
		/// Saves the current <see cref="ConditionElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Condition")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Condition"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "value", m_Value, m_IsValueDefault);

			Debug.Assert(m_Value == element.Attributes.GetPropertyValue<System.String>("value"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="ConditionElement"/>.
		/// </summary>
		public ConditionElement Clone()
		{
			ConditionElement clone = new ConditionElement();

			clone.Value = this.Value;

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Value);
		}

		#endregion
	}

	#endregion

	#region Element: Conditions

	public partial class ConditionsElement : Artech.Common.Collections.BaseCollection<ConditionElement>
	{
		protected string m_ElementName;

		#region Construction

		internal ConditionsElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<ConditionElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private FilterElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public FilterElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<ConditionElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of ConditionsElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="ConditionElement"/> in the collection that has the specified value in its <see cref="Value"/> property.
		/// If no Condition is found, <b>null</b> is returned.
		/// </summary>
		public ConditionElement FindCondition(System.String value)
		{
			return this.Find(delegate (ConditionElement conditionItem) { return conditionItem.Value == value; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Conditions";
		}

		#endregion
	}

	#endregion

	#region Element: DescriptionAttribute

	public partial class DescriptionAttributeElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private Artech.Genexus.Common.Objects.Attribute m_Attribute;
		private KBObjectReference m_AttributeReference;
		private bool m_IsAttributeDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="DescriptionAttributeElement"/> class.
		/// </summary>
		public DescriptionAttributeElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="DescriptionAttributeElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Attribute = null;
			m_AttributeReference = null;
			m_IsAttributeDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
		}

		#endregion

		#region Properties

		private LevelElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="DescriptionAttributeElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public LevelElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Attribute that represents the transaction. (For example: CustomerName for Customer).
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Attribute Attribute
		{
			get
			{
				if (m_Attribute == null && m_AttributeReference != null)
					m_Attribute = (Artech.Genexus.Common.Objects.Attribute)m_AttributeReference.GetKBObject(Instance.Model);

				return m_Attribute;
			}

			set 
			{
				m_Attribute = value;
				m_AttributeReference = (value != null ? new KBObjectReference(value) : null);
				m_IsAttributeDefault = false;
			}
		}

		/// <summary>
		/// Attribute name.
		/// </summary>
		public string AttributeName
		{
			get { return (Attribute != null ? Attribute.Name : null); }
		}

		/// <summary>
		/*
		Attribute Description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="DescriptionAttributeElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "DescriptionAttribute")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "DescriptionAttribute"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_AttributeReference = element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference");
			m_IsAttributeDefault = element.Attributes.IsPropertyDefault("attribute");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");
		}

		/// <summary>
		/// Saves the current <see cref="DescriptionAttributeElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "DescriptionAttribute")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "DescriptionAttribute"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "attributeReference", m_AttributeReference, m_IsAttributeDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);

			Debug.Assert(m_AttributeReference == element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="DescriptionAttributeElement"/>.
		/// </summary>
		public DescriptionAttributeElement Clone()
		{
			DescriptionAttributeElement clone = new DescriptionAttributeElement();

			clone.Attribute = this.Attribute;
			clone.Description = this.Description;

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "DescriptionAttribute ({0})", AttributeName);
		}

		#endregion
	}

	#endregion

	#region Element: Filter

	public partial class FilterElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private FilterAttributesElement m_Attributes;
		private ConditionsElement m_Conditions;
		private DynamicFiltersElement m_Dynamicfilters;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="FilterElement"/> class.
		/// </summary>
		public FilterElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="FilterElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Attributes = new FilterAttributesElement();
			m_Attributes.Parent = this;
			m_Conditions = new ConditionsElement();
			m_Conditions.Parent = this;
			m_Conditions.ElementName = "conditions";
			m_Dynamicfilters = new DynamicFiltersElement();
			m_Dynamicfilters.Parent = this;
			m_Dynamicfilters.ElementName = "dynamicfilters";
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="FilterElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		public FilterAttributesElement Attributes
		{
			get { return m_Attributes; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Attributes = value;
				m_Attributes.Parent = this;
			}
		}

		public ConditionsElement Conditions
		{
			get { return m_Conditions; }
		}

		public DynamicFiltersElement Dynamicfilters
		{
			get { return m_Dynamicfilters; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="ConditionElement"/> and adds it to the <see cref="Conditions"/> collection.
		/// </summary>
		public ConditionElement AddCondition()
		{
			ConditionElement conditionElement = new ConditionElement();
			m_Conditions.Add(conditionElement);
			return conditionElement;
		}

		/// <summary>
		/// Creates a new <see cref="ConditionElement"/> and adds it to the <see cref="Conditions"/> collection.
		/// The ConditionElement is initialized with the specified value.
		/// </summary>
		public ConditionElement AddCondition(System.String value)
		{
			ConditionElement conditionElement = new ConditionElement(value);
			m_Conditions.Add(conditionElement);
			return conditionElement;
		}

		/// <summary>
		/// Finds the <see cref="ConditionElement"/> in the <see cref="Conditions"/> collection that has the specified value in its <see cref="Value"/> property.
		/// If no conditionElement is found, null is returned.
		/// </summary>
		public ConditionElement FindCondition(System.String value)
		{
			return Conditions.Find(delegate (ConditionElement conditionElement) { return conditionElement.Value == value; });
		}

		/// <summary>
		/// Creates a new <see cref="AttributeElement"/> and adds it to the <see cref="Dynamicfilters"/> collection.
		/// </summary>
		public AttributeElement AddAttribute()
		{
			AttributeElement attributeElement = new AttributeElement();
			m_Dynamicfilters.Add(attributeElement);
			return attributeElement;
		}

		/// <summary>
		/// Creates a new <see cref="AttributeElement"/> and adds it to the <see cref="Dynamicfilters"/> collection.
		/// The AttributeElement is initialized with the specified value.
		/// </summary>
		public AttributeElement AddAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			AttributeElement attributeElement = new AttributeElement(attribute);
			m_Dynamicfilters.Add(attributeElement);
			return attributeElement;
		}

		/// <summary>
		/// Finds the <see cref="AttributeElement"/> in the <see cref="Dynamicfilters"/> collection that has the specified value in its <see cref="Attribute"/> property.
		/// If no attributeElement is found, null is returned.
		/// </summary>
		public AttributeElement FindAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			return Dynamicfilters.Find(delegate (AttributeElement attributeElement) { return attributeElement.Attribute == attribute; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="FilterElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Filter")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Filter"));

			Initialize();
			m_ElementName = element.Name;

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "attributes" :
					{
						FilterAttributesElement attributes = new FilterAttributesElement();
						attributes.LoadFrom(_childElement);
						Attributes = attributes;
						break;
					}
					case "conditions" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ConditionElement conditionElement = new ConditionElement();
							conditionElement.LoadFrom(_childElementItem);
							Conditions.Add(conditionElement);
						}
						break;
					}
					case "dynamicfilters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							AttributeElement attributeElement = new AttributeElement();
							attributeElement.LoadFrom(_childElementItem);
							Dynamicfilters.Add(attributeElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="FilterElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Filter")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Filter"));

			element.Initialize();

			// Save element children.
			if (m_Attributes != null)
			{
				PatternInstanceElement attributes = element.Children["attributes"];
				m_Attributes.SaveTo(attributes);
			}

			if (m_Conditions != null)
			{
				foreach (ConditionElement _item in Conditions)
				{
					PatternInstanceElement child = element.Children["conditions"].Children.AddNewElement("condition");
					_item.SaveTo(child);
				}
			}

			if (m_Dynamicfilters != null)
			{
				foreach (AttributeElement _item in Dynamicfilters)
				{
					PatternInstanceElement child = element.Children["dynamicfilters"].Children.AddNewElement("attributes");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="FilterElement"/>.
		/// </summary>
		public FilterElement Clone()
		{
			FilterElement clone = new FilterElement();
			clone.Attributes = this.Attributes.Clone();
			foreach (ConditionElement conditionElement in this.Conditions)
				clone.Conditions.Add(conditionElement.Clone());
			foreach (AttributeElement attributeElement in this.Dynamicfilters)
				clone.Dynamicfilters.Add(attributeElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "attributes" :
				{
					if (Attributes != null)
						return Attributes.GetElement(path);
					else
						return null;
				}
				case "conditions" :
				{
					if (path.Count == 0)
						return Conditions;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "condition")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Conditions != null && itemIndex >= 0 && itemIndex < Conditions.Count)
						return Conditions[itemIndex].GetElement(path);
					else
						return null;
				}
				case "dynamicfilters" :
				{
					if (path.Count == 0)
						return Dynamicfilters;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "attributes")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Dynamicfilters != null && itemIndex >= 0 && itemIndex < Dynamicfilters.Count)
						return Dynamicfilters[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Filter";
		}

		#endregion
	}

	#endregion

	#region Element: FilterAttribute

	public partial class FilterAttributeElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private Artech.Genexus.Common.Objects.Domain m_Domain;
		private KBObjectReference m_DomainReference;
		private bool m_IsDomainDefault;
		private Artech.Genexus.Common.Objects.Attribute m_Attribute;
		private KBObjectReference m_AttributeReference;
		private bool m_IsAttributeDefault;
		private System.String m_Default;
		private bool m_IsDefaultDefault;
		private System.Boolean m_AllValue;
		private bool m_IsAllValueDefault;
		private Artech.Genexus.Common.Objects.WebPanel m_Prompt;
		private KBObjectReference m_PromptReference;
		private bool m_IsPromptDefault;
		private System.String m_IsValid;
		private bool m_IsIsValidDefault;
		private System.String m_FilterType;
		private bool m_IsFilterTypeDefault;
		private System.String m_Width;
		private bool m_IsWidthDefault;
		private System.String m_Height;
		private bool m_IsHeightDefault;
		private Artech.Common.Collections.BaseCollection<LinkElement> m_Links;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="FilterAttributeElement"/> class.
		/// </summary>
		public FilterAttributeElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FilterAttributeElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public FilterAttributeElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="FilterAttributeElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_Domain = null;
			m_DomainReference = null;
			m_IsDomainDefault = true;
			m_Attribute = null;
			m_AttributeReference = null;
			m_IsAttributeDefault = true;
			m_Default = "";
			m_IsDefaultDefault = true;
			m_AllValue = false;
			m_IsAllValueDefault = true;
			m_Prompt = null;
			m_PromptReference = null;
			m_IsPromptDefault = true;
			m_IsValid = "";
			m_IsIsValidDefault = true;
			m_FilterType = "Default";
			m_IsFilterTypeDefault = true;
			m_Width = "";
			m_IsWidthDefault = true;
			m_Height = "";
			m_IsHeightDefault = true;
			m_Links = new Artech.Common.Collections.BaseCollection<LinkElement>();
			m_Links.ItemAdded += new EventHandler<CollectionItemEventArgs<LinkElement>>(Links_ItemAdded);
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="FilterAttributeElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Attribute or variable to be entered by the user and used in the conditions.
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Domain of the variable. Use only with variables, not necessary with attributes.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Domain Domain
		{
			get
			{
				if (m_Domain == null && m_DomainReference != null)
					m_Domain = (Artech.Genexus.Common.Objects.Domain)m_DomainReference.GetKBObject(Instance.Model);

				return m_Domain;
			}

			set 
			{
				m_Domain = value;
				m_DomainReference = (value != null ? new KBObjectReference(value) : null);
				m_IsDomainDefault = false;
			}
		}

		/// <summary>
		/// Domain name.
		/// </summary>
		public string DomainName
		{
			get { return (Domain != null ? Domain.Name : null); }
		}

		/// <summary>
		/*
		Attribute of the variable
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Attribute Attribute
		{
			get
			{
				if (m_Attribute == null && m_AttributeReference != null)
					m_Attribute = (Artech.Genexus.Common.Objects.Attribute)m_AttributeReference.GetKBObject(Instance.Model);

				return m_Attribute;
			}

			set 
			{
				m_Attribute = value;
				m_AttributeReference = (value != null ? new KBObjectReference(value) : null);
				m_IsAttributeDefault = false;
			}
		}

		/// <summary>
		/// Attribute name.
		/// </summary>
		public string AttributeName
		{
			get { return (Attribute != null ? Attribute.Name : null); }
		}

		/// <summary>
		/*
		Default value. Must be an expression of the same type of the attribute/variable.
		*/
		/// </summary>
		public System.String Default
		{
			get { return m_Default; }
			set 
			{
				m_Default = value;
				m_IsDefaultDefault = false;
			}
		}

		/// <summary>
		/*
		Add an 'all' option in ComboBox. (Use only when the attribute is a ComboBox).
		*/
		/// </summary>
		public System.Boolean AllValue
		{
			get { return m_AllValue; }
			set 
			{
				m_AllValue = value;
				m_IsAllValueDefault = false;
			}
		}

		/// <summary>
		/*
		Prompt object used to get the possible values for this filter attribute.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.WebPanel Prompt
		{
			get
			{
				if (m_Prompt == null && m_PromptReference != null)
					m_Prompt = (Artech.Genexus.Common.Objects.WebPanel)m_PromptReference.GetKBObject(Instance.Model);

				return m_Prompt;
			}

			set 
			{
				m_Prompt = value;
				m_PromptReference = (value != null ? new KBObjectReference(value) : null);
				m_IsPromptDefault = false;
			}
		}

		/// <summary>
		/// Prompt name.
		/// </summary>
		public string PromptName
		{
			get { return (Prompt != null ? Prompt.Name : null); }
		}

		/// <summary>
		/*
		Define o Evento isValid para a Variável de Filtro
		*/
		/// </summary>
		public System.String IsValid
		{
			get { return m_IsValid; }
			set 
			{
				m_IsValid = value;
				m_IsIsValidDefault = false;
			}
		}

		/// <summary>
		/*
		Define se o filtro será Normal ou Intervalo(Valor Inicial e Final)
		*/
		/// </summary>
		public System.String FilterType
		{
			get { return m_FilterType; }
			set 
			{
				m_FilterType = value;
				m_IsFilterTypeDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width(tamanho horizontal) para o Atributo
		*/
		/// </summary>
		public System.String Width
		{
			get { return m_Width; }
			set 
			{
				m_Width = value;
				m_IsWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Height(tamanho vertical) para o Atributo
		*/
		/// </summary>
		public System.String Height
		{
			get { return m_Height; }
			set 
			{
				m_Height = value;
				m_IsHeightDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<LinkElement> Links
		{
			get { return m_Links; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="LinkElement"/> and adds it to the <see cref="Links"/> collection.
		/// </summary>
		public LinkElement AddLink()
		{
			LinkElement linkElement = new LinkElement();
			m_Links.Add(linkElement);
			return linkElement;
		}

		private void Links_ItemAdded(object sender, CollectionItemEventArgs<LinkElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="FilterAttributeElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "FilterAttribute")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "FilterAttribute"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");
			m_DomainReference = element.Attributes.GetPropertyValue<KBObjectReference>("domainReference");
			m_IsDomainDefault = element.Attributes.IsPropertyDefault("domain");
			m_AttributeReference = element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference");
			m_IsAttributeDefault = element.Attributes.IsPropertyDefault("attribute");
			m_Default = element.Attributes.GetPropertyValue<System.String>("default");
			m_IsDefaultDefault = element.Attributes.IsPropertyDefault("default");
			m_AllValue = element.Attributes.GetPropertyValue<System.Boolean>("allValue");
			m_IsAllValueDefault = element.Attributes.IsPropertyDefault("allValue");
			m_PromptReference = element.Attributes.GetPropertyValue<KBObjectReference>("promptReference");
			m_IsPromptDefault = element.Attributes.IsPropertyDefault("prompt");
			m_IsValid = element.Attributes.GetPropertyValue<System.String>("isValid");
			m_IsIsValidDefault = element.Attributes.IsPropertyDefault("isValid");
			m_FilterType = element.Attributes.GetPropertyValue<System.String>("filterType");
			m_IsFilterTypeDefault = element.Attributes.IsPropertyDefault("filterType");
			m_Width = element.Attributes.GetPropertyValue<System.String>("Width");
			m_IsWidthDefault = element.Attributes.IsPropertyDefault("Width");
			m_Height = element.Attributes.GetPropertyValue<System.String>("Height");
			m_IsHeightDefault = element.Attributes.IsPropertyDefault("Height");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "link" :
					{
						LinkElement link = new LinkElement();
						link.LoadFrom(_childElement);
						Links.Add(link);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="FilterAttributeElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "FilterAttribute")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "FilterAttribute"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);
			SaveAttribute(element, "domainReference", m_DomainReference, m_IsDomainDefault);
			SaveAttribute(element, "attributeReference", m_AttributeReference, m_IsAttributeDefault);
			SaveAttribute(element, "default", m_Default, m_IsDefaultDefault);
			SaveAttribute(element, "allValue", m_AllValue, m_IsAllValueDefault);
			SaveAttribute(element, "promptReference", m_PromptReference, m_IsPromptDefault);
			SaveAttribute(element, "isValid", m_IsValid, m_IsIsValidDefault);
			SaveAttribute(element, "filterType", m_FilterType, m_IsFilterTypeDefault);
			SaveAttribute(element, "Width", m_Width, m_IsWidthDefault);
			SaveAttribute(element, "Height", m_Height, m_IsHeightDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));
			Debug.Assert(m_DomainReference == element.Attributes.GetPropertyValue<KBObjectReference>("domainReference"));
			Debug.Assert(m_AttributeReference == element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference"));
			Debug.Assert(m_Default == element.Attributes.GetPropertyValue<System.String>("default"));
			Debug.Assert(m_AllValue == element.Attributes.GetPropertyValue<System.Boolean>("allValue"));
			Debug.Assert(m_PromptReference == element.Attributes.GetPropertyValue<KBObjectReference>("promptReference"));
			Debug.Assert(m_IsValid == element.Attributes.GetPropertyValue<System.String>("isValid"));
			Debug.Assert(m_FilterType == element.Attributes.GetPropertyValue<System.String>("filterType"));
			Debug.Assert(m_Width == element.Attributes.GetPropertyValue<System.String>("Width"));
			Debug.Assert(m_Height == element.Attributes.GetPropertyValue<System.String>("Height"));

			// Save element children.
			if (m_Links != null)
			{
				foreach (LinkElement _item in Links)
				{
					PatternInstanceElement link = element.Children.AddNewElement("link");
					_item.SaveTo(link);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="FilterAttributeElement"/>.
		/// </summary>
		public FilterAttributeElement Clone()
		{
			FilterAttributeElement clone = new FilterAttributeElement();

			clone.Name = this.Name;
			clone.Description = this.Description;
			clone.Domain = this.Domain;
			clone.Attribute = this.Attribute;
			clone.Default = this.Default;
			clone.AllValue = this.AllValue;
			clone.Prompt = this.Prompt;
			clone.IsValid = this.IsValid;
			clone.FilterType = this.FilterType;
			clone.Width = this.Width;
			clone.Height = this.Height;
			foreach (LinkElement linkElement in this.Links)
				clone.Links.Add(linkElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "link" :
				{
					if (Links != null && childIndex >= 0 && childIndex < Links.Count)
						return Links[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="FilterType"/> property.
		/// </summary>
		public static class FilterTypeValue
		{
			public const string Default = "Default";
			public const string Interval = "Interval";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: FilterAttributes

	public partial class FilterAttributesElement : IEnumerable<IHPatternInstanceElement>, IHPatternInstanceElement
	{
		protected string m_ElementName;
		private Artech.Common.Collections.BaseCollection<IHPatternInstanceElement> m_Items;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="FilterAttributesElement"/> class.
		/// </summary>
		public FilterAttributesElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="FilterAttributesElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Items = new Artech.Common.Collections.BaseCollection<IHPatternInstanceElement>();
			m_Items.ItemAdded += new EventHandler<CollectionItemEventArgs<IHPatternInstanceElement>>(Items_ItemAdded);
		}

		#endregion

		#region Properties

		private FilterElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="FilterAttributesElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public FilterElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		public Artech.Common.Collections.IBaseCollection<FilterAttributeElement> FilterAttributes
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<FilterAttributeElement> tmpFilterAttributes = new Artech.Common.Collections.BaseCollection<FilterAttributeElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is FilterAttributeElement)
						tmpFilterAttributes.Add((FilterAttributeElement)obj);

				return tmpFilterAttributes.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<FRowElement> Rows
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<FRowElement> tmpRows = new Artech.Common.Collections.BaseCollection<FRowElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is FRowElement)
						tmpRows.Add((FRowElement)obj);

				return tmpRows.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<IHPatternInstanceElement> Items
		{
			get { return m_Items; }
		}

		public IEnumerator<IHPatternInstanceElement> GetEnumerator()
		{
			return m_Items.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((System.Collections.IEnumerable)m_Items).GetEnumerator();
		}

		#endregion

		#region Helper methods

		public void Add(IHPatternInstanceElement item)
		{
			m_Items.Add(item);
		}

		/// <summary>
		/// Creates a new <see cref="FilterAttributeElement"/> and adds it to the <see cref="FilterAttributes"/> collection.
		/// </summary>
		public FilterAttributeElement AddFilterAttribute()
		{
			FilterAttributeElement filterAttributeElement = new FilterAttributeElement();
			m_Items.Add(filterAttributeElement);
			return filterAttributeElement;
		}

		/// <summary>
		/// Creates a new <see cref="FilterAttributeElement"/> and adds it to the <see cref="FilterAttributes"/> collection.
		/// The FilterAttributeElement is initialized with the specified value.
		/// </summary>
		public FilterAttributeElement AddFilterAttribute(System.String name)
		{
			FilterAttributeElement filterAttributeElement = new FilterAttributeElement(name);
			m_Items.Add(filterAttributeElement);
			return filterAttributeElement;
		}

		/// <summary>
		/// Finds the <see cref="FilterAttributeElement"/> in the <see cref="FilterAttributes"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no filterAttributeElement is found, null is returned.
		/// </summary>
		public FilterAttributeElement FindFilterAttribute(System.String name)
		{
			return FilterAttributes.Find(delegate (FilterAttributeElement filterAttributeElement) { return filterAttributeElement.Name == name; });
		}

		private void FilterAttributes_ItemAdded(object sender, CollectionItemEventArgs<FilterAttributeElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="FRowElement"/> and adds it to the <see cref="Rows"/> collection.
		/// </summary>
		public FRowElement AddFRow()
		{
			FRowElement fRowElement = new FRowElement();
			m_Items.Add(fRowElement);
			return fRowElement;
		}

		private void Rows_ItemAdded(object sender, CollectionItemEventArgs<FRowElement> e)
		{
			e.Data.Parent = this;
		}

		private void Items_ItemAdded(object sender, CollectionItemEventArgs<IHPatternInstanceElement> e)
		{
			if (e.Data is FilterAttributeElement)
				((FilterAttributeElement)e.Data).Parent = this;
			else if (e.Data is FRowElement)
				((FRowElement)e.Data).Parent = this;
			else
				throw new PatternInstanceException(String.Format("An object of an unexpected type {0} was added as child of {1}.", e.Data.GetType(), this.GetType()));
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="FilterAttributesElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "FilterAttributes")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "FilterAttributes"));

			Initialize();
			m_ElementName = element.Name;

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "filterAttribute" :
					{
						FilterAttributeElement filterAttribute = new FilterAttributeElement();
						filterAttribute.LoadFrom(_childElement);
						Add(filterAttribute);
						break;
					}
					case "row" :
					{
						FRowElement row = new FRowElement();
						row.LoadFrom(_childElement);
						Add(row);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="FilterAttributesElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "FilterAttributes")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "FilterAttributes"));

			element.Initialize();

			// Save element children.
			foreach (IHPatternInstanceElement _obj in m_Items)
			{
				if (_obj is FilterAttributeElement)
				{
					PatternInstanceElement filterAttribute = element.Children.AddNewElement("filterAttribute");
					((FilterAttributeElement)_obj).SaveTo(filterAttribute);
				}
				else if (_obj is FRowElement)
				{
					PatternInstanceElement row = element.Children.AddNewElement("row");
					((FRowElement)_obj).SaveTo(row);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="FilterAttributesElement"/>.
		/// </summary>
		public FilterAttributesElement Clone()
		{
			FilterAttributesElement clone = new FilterAttributesElement();
			foreach (IHPatternInstanceElement element in this)
				clone.Add(element.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "filterAttribute" :
				{
					if (FilterAttributes != null && childIndex >= 0 && childIndex < FilterAttributes.Count)
						return FilterAttributes[childIndex].GetElement(path);
					else
						return null;
				}
				case "row" :
				{
					if (Rows != null && childIndex >= 0 && childIndex < Rows.Count)
						return Rows[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Attributes";
		}

		#endregion
	}

	#endregion

	#region Element: FixedData

	public partial class FixedDataElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private AttributesElement m_Attributes;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="FixedDataElement"/> class.
		/// </summary>
		public FixedDataElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="FixedDataElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Attributes = new AttributesElement();
			m_Attributes.Parent = this;
		}

		#endregion

		#region Properties

		private ViewElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="FixedDataElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public ViewElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		public AttributesElement Attributes
		{
			get { return m_Attributes; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Attributes = value;
				m_Attributes.Parent = this;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="FixedDataElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "FixedData")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "FixedData"));

			Initialize();
			m_ElementName = element.Name;

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "attributes" :
					{
						AttributesElement attributes = new AttributesElement();
						attributes.LoadFrom(_childElement);
						Attributes = attributes;
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="FixedDataElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "FixedData")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "FixedData"));

			element.Initialize();

			// Save element children.
			if (m_Attributes != null)
			{
				PatternInstanceElement attributes = element.Children["attributes"];
				m_Attributes.SaveTo(attributes);
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="FixedDataElement"/>.
		/// </summary>
		public FixedDataElement Clone()
		{
			FixedDataElement clone = new FixedDataElement();
			clone.Attributes = this.Attributes.Clone();

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "attributes" :
				{
					if (Attributes != null)
						return Attributes.GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Fixed Data";
		}

		#endregion
	}

	#endregion

	#region Element: Level

	public partial class LevelElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Id;
		private bool m_IsIdDefault;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private DescriptionAttributeElement m_DescriptionAttribute;
		private SelectionElement m_Selection;
		private Artech.Common.Collections.BaseCollection<PromptElement> m_Prompts;
		private ViewElement m_View;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="LevelElement"/> class.
		/// </summary>
		public LevelElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LevelElement"/> class, setting its <see cref="Id"/> property to the specified value.
		/// </summary>
		public LevelElement(System.String id)
		{
			Initialize();
			Id = id;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="LevelElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Id = "";
			m_IsIdDefault = true;
			m_Name = "";
			m_IsNameDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_DescriptionAttribute = null;
			m_Selection = null;
			m_Prompts = new Artech.Common.Collections.BaseCollection<PromptElement>();
			m_Prompts.ItemAdded += new EventHandler<CollectionItemEventArgs<PromptElement>>(Prompts_ItemAdded);
			m_View = null;
		}

		#endregion

		#region Properties

		private HPatternInstance m_Parent;

		/// <summary>
		/// Instance to which this <see cref="LevelElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternInstance Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		public System.String Id
		{
			get { return m_Id; }
			set 
			{
				m_Id = value;
				m_IsIdDefault = false;
			}
		}

		/// <summary>
		/*
		Level Name.
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Level Description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		public DescriptionAttributeElement DescriptionAttribute
		{
			get { return m_DescriptionAttribute; }
			set
			{
				m_DescriptionAttribute = value;
				m_DescriptionAttribute.Parent = this;
			}
		}

		public SelectionElement Selection
		{
			get { return m_Selection; }
			set
			{
				m_Selection = value;
				m_Selection.Parent = this;
			}
		}

		public Artech.Common.Collections.IBaseCollection<PromptElement> Prompts
		{
			get { return m_Prompts; }
		}

		public ViewElement View
		{
			get { return m_View; }
			set
			{
				m_View = value;
				m_View.Parent = this;
			}
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="PromptElement"/> and adds it to the <see cref="Prompts"/> collection.
		/// </summary>
		public PromptElement AddPrompt()
		{
			PromptElement promptElement = new PromptElement();
			m_Prompts.Add(promptElement);
			return promptElement;
		}

		private void Prompts_ItemAdded(object sender, CollectionItemEventArgs<PromptElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="LevelElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Level")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Level"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Id = element.Attributes.GetPropertyValue<System.String>("id");
			m_IsIdDefault = element.Attributes.IsPropertyDefault("id");
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "descriptionAttribute" :
					{
						DescriptionAttributeElement descriptionAttribute = new DescriptionAttributeElement();
						descriptionAttribute.LoadFrom(_childElement);
						DescriptionAttribute = descriptionAttribute;
						break;
					}
					case "selection" :
					{
						SelectionElement selection = new SelectionElement();
						selection.LoadFrom(_childElement);
						Selection = selection;
						break;
					}
					case "prompt" :
					{
						PromptElement prompt = new PromptElement();
						prompt.LoadFrom(_childElement);
						Prompts.Add(prompt);
						break;
					}
					case "view" :
					{
						ViewElement view = new ViewElement();
						view.LoadFrom(_childElement);
						View = view;
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="LevelElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Level")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Level"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "id", m_Id, m_IsIdDefault);
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);

			Debug.Assert(m_Id == element.Attributes.GetPropertyValue<System.String>("id"));
			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));

			// Save element children.
			if (m_DescriptionAttribute != null)
			{
				PatternInstanceElement descriptionAttribute = element.Children.AddNewElement("descriptionAttribute");
				m_DescriptionAttribute.SaveTo(descriptionAttribute);
			}

			if (m_Selection != null)
			{
				PatternInstanceElement selection = element.Children.AddNewElement("selection");
				m_Selection.SaveTo(selection);
			}

			if (m_Prompts != null)
			{
				foreach (PromptElement _item in Prompts)
				{
					PatternInstanceElement prompt = element.Children.AddNewElement("prompt");
					_item.SaveTo(prompt);
				}
			}

			if (m_View != null)
			{
				PatternInstanceElement view = element.Children.AddNewElement("view");
				m_View.SaveTo(view);
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="LevelElement"/>.
		/// </summary>
		public LevelElement Clone()
		{
			LevelElement clone = new LevelElement();

			clone.Id = this.Id;
			clone.Name = this.Name;
			clone.Description = this.Description;
			if (DescriptionAttribute != null)
				clone.DescriptionAttribute = this.DescriptionAttribute.Clone();
			if (Selection != null)
				clone.Selection = this.Selection.Clone();
			foreach (PromptElement promptElement in this.Prompts)
				clone.Prompts.Add(promptElement.Clone());
			if (View != null)
				clone.View = this.View.Clone();

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "descriptionAttribute" :
				{
					if (DescriptionAttribute != null)
						return DescriptionAttribute.GetElement(path);
					else
						return null;
				}
				case "selection" :
				{
					if (Selection != null)
						return Selection.GetElement(path);
					else
						return null;
				}
				case "prompt" :
				{
					if (Prompts != null && childIndex >= 0 && childIndex < Prompts.Count)
						return Prompts[childIndex].GetElement(path);
					else
						return null;
				}
				case "view" :
				{
					if (View != null)
						return View.GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Level ({0})", Name);
		}

		#endregion
	}

	#endregion

	#region Element: Link

	public partial class LinkElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private Artech.Architecture.Common.Objects.KBObject m_WebpanelObject;
		private KBObjectReference m_WebpanelObjectReference;
		private string m_WebpanelObjectName;
		private bool m_IsWebpanelObjectDefault;
		private System.String m_Tooltip;
		private bool m_IsTooltipDefault;
		private System.String m_Condition;
		private bool m_IsConditionDefault;
		private Artech.Genexus.Common.Objects.Image m_Image;
		private KBObjectReference m_ImageReference;
		private bool m_IsImageDefault;
		private System.String m_Type;
		private bool m_IsTypeDefault;
		private ParametersElement m_Parameters;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="LinkElement"/> class.
		/// </summary>
		public LinkElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="LinkElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_WebpanelObject = null;
			m_WebpanelObjectReference = null;
			m_WebpanelObjectName = null;
			m_IsWebpanelObjectDefault = true;
			m_Tooltip = "Consulta";
			m_IsTooltipDefault = true;
			m_Condition = "";
			m_IsConditionDefault = true;
			m_Image = null;
			m_ImageReference = null;
			m_IsImageDefault = true;
			m_Type = "Prompt";
			m_IsTypeDefault = true;
			m_Parameters = new ParametersElement();
			m_Parameters.Parent = this;
			m_Parameters.ElementName = "parameters";
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="LinkElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Web Panel to link.
		*/
		/// </summary>
		public Artech.Architecture.Common.Objects.KBObject WebpanelObject
		{
			get
			{
				if (m_WebpanelObject == null && m_WebpanelObjectReference != null)
					m_WebpanelObject = (Artech.Architecture.Common.Objects.KBObject)m_WebpanelObjectReference.GetKBObject(Instance.Model);

				return m_WebpanelObject;
			}

			set 
			{
				m_WebpanelObject = value;
				m_WebpanelObjectReference = (value != null ? new KBObjectReference(value) : null);
				m_WebpanelObjectName = (value != null ? value.Name : null);
				m_IsWebpanelObjectDefault = false;
			}
		}

		/// <summary>
		/// WebpanelObject name.
		/// </summary>
		public string WebpanelObjectName
		{
			get
			{
				if (m_WebpanelObjectName == null && m_WebpanelObjectReference != null)
					m_WebpanelObjectName = m_WebpanelObjectReference.GetName(Instance.Model);

				return m_WebpanelObjectName;
			}
		}

		/// <summary>
		/*
		Define o tooltip para a imagem de prompt
		*/
		/// </summary>
		public System.String Tooltip
		{
			get { return m_Tooltip; }
			set 
			{
				m_Tooltip = value;
				m_IsTooltipDefault = false;
			}
		}

		/// <summary>
		/*
		Condition evaluated to determine whether the user can Open Prompt.
		*/
		/// </summary>
		public System.String Condition
		{
			get { return m_Condition; }
			set 
			{
				m_Condition = value;
				m_IsConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Define a imagem a ser utilizada no prompt
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image Image
		{
			get
			{
				if (m_Image == null && m_ImageReference != null)
					m_Image = (Artech.Genexus.Common.Objects.Image)m_ImageReference.GetKBObject(Instance.Model);

				return m_Image;
			}

			set 
			{
				m_Image = value;
				m_ImageReference = (value != null ? new KBObjectReference(value) : null);
				m_IsImageDefault = false;
			}
		}

		/// <summary>
		/// Image name.
		/// </summary>
		public string ImageName
		{
			get { return (Image != null ? Image.Name : null); }
		}

		/// <summary>
		/*
		Define o tipo do Link, Regra Prompt ou chamada com popup a partir de evento
		*/
		/// </summary>
		public System.String Type
		{
			get { return m_Type; }
			set 
			{
				m_Type = value;
				m_IsTypeDefault = false;
			}
		}

		public ParametersElement Parameters
		{
			get { return m_Parameters; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// </summary>
		public ParameterElement AddParameter()
		{
			ParameterElement parameterElement = new ParameterElement();
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// The ParameterElement is initialized with the specified value.
		/// </summary>
		public ParameterElement AddParameter(System.String name)
		{
			ParameterElement parameterElement = new ParameterElement(name);
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Finds the <see cref="ParameterElement"/> in the <see cref="Parameters"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no parameterElement is found, null is returned.
		/// </summary>
		public ParameterElement FindParameter(System.String name)
		{
			return Parameters.Find(delegate (ParameterElement parameterElement) { return parameterElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="LinkElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Link")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Link"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_WebpanelObjectReference = element.Attributes.GetPropertyValue<KBObjectReference>("webpanelObjectReference");
			m_IsWebpanelObjectDefault = element.Attributes.IsPropertyDefault("webpanelObject");
			m_Tooltip = element.Attributes.GetPropertyValue<System.String>("tooltip");
			m_IsTooltipDefault = element.Attributes.IsPropertyDefault("tooltip");
			m_Condition = element.Attributes.GetPropertyValue<System.String>("condition");
			m_IsConditionDefault = element.Attributes.IsPropertyDefault("condition");
			m_ImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("imageReference");
			m_IsImageDefault = element.Attributes.IsPropertyDefault("image");
			m_Type = element.Attributes.GetPropertyValue<System.String>("type");
			m_IsTypeDefault = element.Attributes.IsPropertyDefault("type");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "parameters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ParameterElement parameterElement = new ParameterElement();
							parameterElement.LoadFrom(_childElementItem);
							Parameters.Add(parameterElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="LinkElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Link")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Link"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "webpanelObjectReference", m_WebpanelObjectReference, m_IsWebpanelObjectDefault);
			SaveAttribute(element, "tooltip", m_Tooltip, m_IsTooltipDefault);
			SaveAttribute(element, "condition", m_Condition, m_IsConditionDefault);
			SaveAttribute(element, "imageReference", m_ImageReference, m_IsImageDefault);
			SaveAttribute(element, "type", m_Type, m_IsTypeDefault);

			Debug.Assert(m_WebpanelObjectReference == element.Attributes.GetPropertyValue<KBObjectReference>("webpanelObjectReference"));
			Debug.Assert(m_Tooltip == element.Attributes.GetPropertyValue<System.String>("tooltip"));
			Debug.Assert(m_Condition == element.Attributes.GetPropertyValue<System.String>("condition"));
			Debug.Assert(m_ImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("imageReference"));
			Debug.Assert(m_Type == element.Attributes.GetPropertyValue<System.String>("type"));

			// Save element children.
			if (m_Parameters != null)
			{
				foreach (ParameterElement _item in Parameters)
				{
					PatternInstanceElement child = element.Children["parameters"].Children.AddNewElement("parameter");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="LinkElement"/>.
		/// </summary>
		public LinkElement Clone()
		{
			LinkElement clone = new LinkElement();

			clone.WebpanelObject = this.WebpanelObject;
			clone.Tooltip = this.Tooltip;
			clone.Condition = this.Condition;
			clone.Image = this.Image;
			clone.Type = this.Type;
			foreach (ParameterElement parameterElement in this.Parameters)
				clone.Parameters.Add(parameterElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "parameters" :
				{
					if (path.Count == 0)
						return Parameters;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "parameter")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Parameters != null && itemIndex >= 0 && itemIndex < Parameters.Count)
						return Parameters[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Type"/> property.
		/// </summary>
		public static class TypeValue
		{
			public const string Prompt = "Prompt";
			public const string Event = "Event";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Link ({0})", WebpanelObjectName);
		}

		#endregion
	}

	#endregion

	#region Element: Modes

	public partial class ModesElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Insert;
		private bool m_IsInsertDefault;
		private System.String m_Update;
		private bool m_IsUpdateDefault;
		private System.String m_Delete;
		private bool m_IsDeleteDefault;
		private System.String m_Display;
		private bool m_IsDisplayDefault;
		private System.String m_Export;
		private bool m_IsExportDefault;
		private System.String m_Legend;
		private bool m_IsLegendDefault;
		private System.String m_InsertCondition;
		private bool m_IsInsertConditionDefault;
		private System.String m_UpdateCondition;
		private bool m_IsUpdateConditionDefault;
		private System.String m_DeleteCondition;
		private bool m_IsDeleteConditionDefault;
		private System.String m_DisplayCondition;
		private bool m_IsDisplayConditionDefault;
		private System.String m_ExportCondition;
		private bool m_IsExportConditionDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="ModesElement"/> class.
		/// </summary>
		public ModesElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="ModesElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Insert = "default";
			m_IsInsertDefault = true;
			m_Update = "default";
			m_IsUpdateDefault = true;
			m_Delete = "default";
			m_IsDeleteDefault = true;
			m_Display = "default";
			m_IsDisplayDefault = true;
			m_Export = "default";
			m_IsExportDefault = true;
			m_Legend = "default";
			m_IsLegendDefault = true;
			m_InsertCondition = "";
			m_IsInsertConditionDefault = true;
			m_UpdateCondition = "";
			m_IsUpdateConditionDefault = true;
			m_DeleteCondition = "";
			m_IsDeleteConditionDefault = true;
			m_DisplayCondition = "";
			m_IsDisplayConditionDefault = true;
			m_ExportCondition = "";
			m_IsExportConditionDefault = true;
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="ModesElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Insert Mode.
		*/
		/// </summary>
		public System.String Insert
		{
			get { return m_Insert; }
			set 
			{
				m_Insert = value;
				m_IsInsertDefault = false;
			}
		}

		/// <summary>
		/*
		Update Mode.
		*/
		/// </summary>
		public System.String Update
		{
			get { return m_Update; }
			set 
			{
				m_Update = value;
				m_IsUpdateDefault = false;
			}
		}

		/// <summary>
		/*
		Delete Mode.
		*/
		/// </summary>
		public System.String Delete
		{
			get { return m_Delete; }
			set 
			{
				m_Delete = value;
				m_IsDeleteDefault = false;
			}
		}

		/// <summary>
		/*
		Display Mode.
		*/
		/// </summary>
		public System.String Display
		{
			get { return m_Display; }
			set 
			{
				m_Display = value;
				m_IsDisplayDefault = false;
			}
		}

		/// <summary>
		/*
		Export mode.
		*/
		/// </summary>
		public System.String Export
		{
			get { return m_Export; }
			set 
			{
				m_Export = value;
				m_IsExportDefault = false;
			}
		}

		/// <summary>
		/*
		Legend mode.
		*/
		/// </summary>
		public System.String Legend
		{
			get { return m_Legend; }
			set 
			{
				m_Legend = value;
				m_IsLegendDefault = false;
			}
		}

		/// <summary>
		/*
		Condition evaluated to determine whether the user can insert records in the grid. If empty, the action will be available.
		*/
		/// </summary>
		public System.String InsertCondition
		{
			get { return m_InsertCondition; }
			set 
			{
				m_InsertCondition = value;
				m_IsInsertConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Condition evaluated to determine whether the user can update a record of the grid (the check will be performed for each record). If empty, the action will be available.
		*/
		/// </summary>
		public System.String UpdateCondition
		{
			get { return m_UpdateCondition; }
			set 
			{
				m_UpdateCondition = value;
				m_IsUpdateConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Condition evaluated to determine whether the user can delete a record of the grid (the check will be performed for each record). If empty, the action will be available.
		*/
		/// </summary>
		public System.String DeleteCondition
		{
			get { return m_DeleteCondition; }
			set 
			{
				m_DeleteCondition = value;
				m_IsDeleteConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Condition evaluated to determine whether the user can display (invoke the View for) a record of the grid (the check will be performed for each record). If empty, the action will be available.
		*/
		/// </summary>
		public System.String DisplayCondition
		{
			get { return m_DisplayCondition; }
			set 
			{
				m_DisplayCondition = value;
				m_IsDisplayConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Condition evaluated to determine whether the user can export records in the grid and download them as an Excel spreadsheet. If empty, the action will be available.
		*/
		/// </summary>
		public System.String ExportCondition
		{
			get { return m_ExportCondition; }
			set 
			{
				m_ExportCondition = value;
				m_IsExportConditionDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="ModesElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Modes")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Modes"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Insert = element.Attributes.GetPropertyValue<System.String>("Insert");
			m_IsInsertDefault = element.Attributes.IsPropertyDefault("Insert");
			m_Update = element.Attributes.GetPropertyValue<System.String>("Update");
			m_IsUpdateDefault = element.Attributes.IsPropertyDefault("Update");
			m_Delete = element.Attributes.GetPropertyValue<System.String>("Delete");
			m_IsDeleteDefault = element.Attributes.IsPropertyDefault("Delete");
			m_Display = element.Attributes.GetPropertyValue<System.String>("Display");
			m_IsDisplayDefault = element.Attributes.IsPropertyDefault("Display");
			m_Export = element.Attributes.GetPropertyValue<System.String>("Export");
			m_IsExportDefault = element.Attributes.IsPropertyDefault("Export");
			m_Legend = element.Attributes.GetPropertyValue<System.String>("Legend");
			m_IsLegendDefault = element.Attributes.IsPropertyDefault("Legend");
			m_InsertCondition = element.Attributes.GetPropertyValue<System.String>("InsertCondition");
			m_IsInsertConditionDefault = element.Attributes.IsPropertyDefault("InsertCondition");
			m_UpdateCondition = element.Attributes.GetPropertyValue<System.String>("UpdateCondition");
			m_IsUpdateConditionDefault = element.Attributes.IsPropertyDefault("UpdateCondition");
			m_DeleteCondition = element.Attributes.GetPropertyValue<System.String>("DeleteCondition");
			m_IsDeleteConditionDefault = element.Attributes.IsPropertyDefault("DeleteCondition");
			m_DisplayCondition = element.Attributes.GetPropertyValue<System.String>("DisplayCondition");
			m_IsDisplayConditionDefault = element.Attributes.IsPropertyDefault("DisplayCondition");
			m_ExportCondition = element.Attributes.GetPropertyValue<System.String>("ExportCondition");
			m_IsExportConditionDefault = element.Attributes.IsPropertyDefault("ExportCondition");
		}

		/// <summary>
		/// Saves the current <see cref="ModesElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Modes")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Modes"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "Insert", m_Insert, m_IsInsertDefault);
			SaveAttribute(element, "Update", m_Update, m_IsUpdateDefault);
			SaveAttribute(element, "Delete", m_Delete, m_IsDeleteDefault);
			SaveAttribute(element, "Display", m_Display, m_IsDisplayDefault);
			SaveAttribute(element, "Export", m_Export, m_IsExportDefault);
			SaveAttribute(element, "Legend", m_Legend, m_IsLegendDefault);
			SaveAttribute(element, "InsertCondition", m_InsertCondition, m_IsInsertConditionDefault);
			SaveAttribute(element, "UpdateCondition", m_UpdateCondition, m_IsUpdateConditionDefault);
			SaveAttribute(element, "DeleteCondition", m_DeleteCondition, m_IsDeleteConditionDefault);
			SaveAttribute(element, "DisplayCondition", m_DisplayCondition, m_IsDisplayConditionDefault);
			SaveAttribute(element, "ExportCondition", m_ExportCondition, m_IsExportConditionDefault);

			Debug.Assert(m_Insert == element.Attributes.GetPropertyValue<System.String>("Insert"));
			Debug.Assert(m_Update == element.Attributes.GetPropertyValue<System.String>("Update"));
			Debug.Assert(m_Delete == element.Attributes.GetPropertyValue<System.String>("Delete"));
			Debug.Assert(m_Display == element.Attributes.GetPropertyValue<System.String>("Display"));
			Debug.Assert(m_Export == element.Attributes.GetPropertyValue<System.String>("Export"));
			Debug.Assert(m_Legend == element.Attributes.GetPropertyValue<System.String>("Legend"));
			Debug.Assert(m_InsertCondition == element.Attributes.GetPropertyValue<System.String>("InsertCondition"));
			Debug.Assert(m_UpdateCondition == element.Attributes.GetPropertyValue<System.String>("UpdateCondition"));
			Debug.Assert(m_DeleteCondition == element.Attributes.GetPropertyValue<System.String>("DeleteCondition"));
			Debug.Assert(m_DisplayCondition == element.Attributes.GetPropertyValue<System.String>("DisplayCondition"));
			Debug.Assert(m_ExportCondition == element.Attributes.GetPropertyValue<System.String>("ExportCondition"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="ModesElement"/>.
		/// </summary>
		public ModesElement Clone()
		{
			ModesElement clone = new ModesElement();

			clone.Insert = this.Insert;
			clone.Update = this.Update;
			clone.Delete = this.Delete;
			clone.Display = this.Display;
			clone.Export = this.Export;
			clone.Legend = this.Legend;
			clone.InsertCondition = this.InsertCondition;
			clone.UpdateCondition = this.UpdateCondition;
			clone.DeleteCondition = this.DeleteCondition;
			clone.DisplayCondition = this.DisplayCondition;
			clone.ExportCondition = this.ExportCondition;

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Insert"/> property.
		/// </summary>
		public static class InsertValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Default = "default";
		}

		/// <summary>
		/// Possible values for the <see cref="Update"/> property.
		/// </summary>
		public static class UpdateValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Default = "default";
		}

		/// <summary>
		/// Possible values for the <see cref="Delete"/> property.
		/// </summary>
		public static class DeleteValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Default = "default";
		}

		/// <summary>
		/// Possible values for the <see cref="Display"/> property.
		/// </summary>
		public static class DisplayValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Default = "default";
		}

		/// <summary>
		/// Possible values for the <see cref="Export"/> property.
		/// </summary>
		public static class ExportValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Default = "default";
		}

		/// <summary>
		/// Possible values for the <see cref="Legend"/> property.
		/// </summary>
		public static class LegendValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Default = "default";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Ins: {0}, Upd: {1}, Del: {2}, Dis: {3}", Insert, Update, Delete, Display);
		}

		#endregion
	}

	#endregion

	#region Element: Order

	public partial class OrderElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private Artech.Common.Collections.BaseCollection<OrderAttributeElement> m_Attributes;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="OrderElement"/> class.
		/// </summary>
		public OrderElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="OrderElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public OrderElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="OrderElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Attributes = new Artech.Common.Collections.BaseCollection<OrderAttributeElement>();
			m_Attributes.ItemAdded += new EventHandler<CollectionItemEventArgs<OrderAttributeElement>>(Attributes_ItemAdded);
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="OrderElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Name of the Order, for user selection.
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<OrderAttributeElement> Attributes
		{
			get { return m_Attributes; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="OrderAttributeElement"/> and adds it to the <see cref="Attributes"/> collection.
		/// </summary>
		public OrderAttributeElement AddOrderAttribute()
		{
			OrderAttributeElement orderAttributeElement = new OrderAttributeElement();
			m_Attributes.Add(orderAttributeElement);
			return orderAttributeElement;
		}

		/// <summary>
		/// Creates a new <see cref="OrderAttributeElement"/> and adds it to the <see cref="Attributes"/> collection.
		/// The OrderAttributeElement is initialized with the specified value.
		/// </summary>
		public OrderAttributeElement AddOrderAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			OrderAttributeElement orderAttributeElement = new OrderAttributeElement(attribute);
			m_Attributes.Add(orderAttributeElement);
			return orderAttributeElement;
		}

		/// <summary>
		/// Finds the <see cref="OrderAttributeElement"/> in the <see cref="Attributes"/> collection that has the specified value in its <see cref="Attribute"/> property.
		/// If no orderAttributeElement is found, null is returned.
		/// </summary>
		public OrderAttributeElement FindOrderAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			return Attributes.Find(delegate (OrderAttributeElement orderAttributeElement) { return orderAttributeElement.Attribute == attribute; });
		}

		private void Attributes_ItemAdded(object sender, CollectionItemEventArgs<OrderAttributeElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="OrderElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Order")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Order"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "attribute" :
					{
						OrderAttributeElement attribute = new OrderAttributeElement();
						attribute.LoadFrom(_childElement);
						Attributes.Add(attribute);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="OrderElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Order")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Order"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));

			// Save element children.
			if (m_Attributes != null)
			{
				foreach (OrderAttributeElement _item in Attributes)
				{
					PatternInstanceElement attribute = element.Children.AddNewElement("attribute");
					_item.SaveTo(attribute);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="OrderElement"/>.
		/// </summary>
		public OrderElement Clone()
		{
			OrderElement clone = new OrderElement();

			clone.Name = this.Name;
			foreach (OrderAttributeElement orderAttributeElement in this.Attributes)
				clone.Attributes.Add(orderAttributeElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "attribute" :
				{
					if (Attributes != null && childIndex >= 0 && childIndex < Attributes.Count)
						return Attributes[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Order ({0})", Name);
		}

		#endregion
	}

	#endregion

	#region Element: Orders

	public partial class OrdersElement : Artech.Common.Collections.BaseCollection<OrderElement>
	{
		protected string m_ElementName;

		#region Construction

		internal OrdersElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<OrderElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<OrderElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of OrdersElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="OrderElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no Order is found, <b>null</b> is returned.
		/// </summary>
		public OrderElement FindOrder(System.String name)
		{
			return this.Find(delegate (OrderElement orderItem) { return orderItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Orders";
		}

		#endregion
	}

	#endregion

	#region Element: OrderAttribute

	public partial class OrderAttributeElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private Artech.Genexus.Common.Objects.Attribute m_Attribute;
		private KBObjectReference m_AttributeReference;
		private bool m_IsAttributeDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private System.Boolean m_Ascending;
		private bool m_IsAscendingDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="OrderAttributeElement"/> class.
		/// </summary>
		public OrderAttributeElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="OrderAttributeElement"/> class, setting its <see cref="Attribute"/> property to the specified value.
		/// </summary>
		public OrderAttributeElement(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			Initialize();
			Attribute = attribute;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="OrderAttributeElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Attribute = null;
			m_AttributeReference = null;
			m_IsAttributeDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_Ascending = true;
			m_IsAscendingDefault = true;
		}

		#endregion

		#region Properties

		private OrderElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="OrderAttributeElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public OrderElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Attribute.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Attribute Attribute
		{
			get
			{
				if (m_Attribute == null && m_AttributeReference != null)
					m_Attribute = (Artech.Genexus.Common.Objects.Attribute)m_AttributeReference.GetKBObject(Instance.Model);

				return m_Attribute;
			}

			set 
			{
				m_Attribute = value;
				m_AttributeReference = (value != null ? new KBObjectReference(value) : null);
				m_IsAttributeDefault = false;
			}
		}

		/// <summary>
		/// Attribute name.
		/// </summary>
		public string AttributeName
		{
			get { return (Attribute != null ? Attribute.Name : null); }
		}

		/// <summary>
		/*
		Description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Ascending Order.
		*/
		/// </summary>
		public System.Boolean Ascending
		{
			get { return m_Ascending; }
			set 
			{
				m_Ascending = value;
				m_IsAscendingDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="OrderAttributeElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "OrderAttribute")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "OrderAttribute"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_AttributeReference = element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference");
			m_IsAttributeDefault = element.Attributes.IsPropertyDefault("attribute");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");
			m_Ascending = element.Attributes.GetPropertyValue<System.Boolean>("ascending");
			m_IsAscendingDefault = element.Attributes.IsPropertyDefault("ascending");
		}

		/// <summary>
		/// Saves the current <see cref="OrderAttributeElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "OrderAttribute")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "OrderAttribute"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "attributeReference", m_AttributeReference, m_IsAttributeDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);
			SaveAttribute(element, "ascending", m_Ascending, m_IsAscendingDefault);

			Debug.Assert(m_AttributeReference == element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));
			Debug.Assert(m_Ascending == element.Attributes.GetPropertyValue<System.Boolean>("ascending"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="OrderAttributeElement"/>.
		/// </summary>
		public OrderAttributeElement Clone()
		{
			OrderAttributeElement clone = new OrderAttributeElement();

			clone.Attribute = this.Attribute;
			clone.Description = this.Description;
			clone.Ascending = this.Ascending;

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", AttributeName);
		}

		#endregion
	}

	#endregion

	#region Element: Parameter

	public partial class ParameterElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private Artech.Genexus.Common.Objects.Domain m_Domain;
		private KBObjectReference m_DomainReference;
		private bool m_IsDomainDefault;
		private System.Boolean m_Null;
		private bool m_IsNullDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="ParameterElement"/> class.
		/// </summary>
		public ParameterElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ParameterElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public ParameterElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="ParameterElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Domain = null;
			m_DomainReference = null;
			m_IsDomainDefault = true;
			m_Null = true;
			m_IsNullDefault = true;
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="ParameterElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Parameter Name.
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Only needed for variables (defines their domain).
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Domain Domain
		{
			get
			{
				if (m_Domain == null && m_DomainReference != null)
					m_Domain = (Artech.Genexus.Common.Objects.Domain)m_DomainReference.GetKBObject(Instance.Model);

				return m_Domain;
			}

			set 
			{
				m_Domain = value;
				m_DomainReference = (value != null ? new KBObjectReference(value) : null);
				m_IsDomainDefault = false;
			}
		}

		/// <summary>
		/// Domain name.
		/// </summary>
		public string DomainName
		{
			get { return (Domain != null ? Domain.Name : null); }
		}

		/// <summary>
		/*
		If set to false, the parameter value cannot change in Insert. (For example, if inserting a City in a given Country, CountryId doesn't change when calling City transaction).
		*/
		/// </summary>
		public System.Boolean Null
		{
			get { return m_Null; }
			set 
			{
				m_Null = value;
				m_IsNullDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="ParameterElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Parameter")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Parameter"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_DomainReference = element.Attributes.GetPropertyValue<KBObjectReference>("domainReference");
			m_IsDomainDefault = element.Attributes.IsPropertyDefault("domain");
			m_Null = element.Attributes.GetPropertyValue<System.Boolean>("null");
			m_IsNullDefault = element.Attributes.IsPropertyDefault("null");
		}

		/// <summary>
		/// Saves the current <see cref="ParameterElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Parameter")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Parameter"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "domainReference", m_DomainReference, m_IsDomainDefault);
			SaveAttribute(element, "null", m_Null, m_IsNullDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_DomainReference == element.Attributes.GetPropertyValue<KBObjectReference>("domainReference"));
			Debug.Assert(m_Null == element.Attributes.GetPropertyValue<System.Boolean>("null"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="ParameterElement"/>.
		/// </summary>
		public ParameterElement Clone()
		{
			ParameterElement clone = new ParameterElement();

			clone.Name = this.Name;
			clone.Domain = this.Domain;
			clone.Null = this.Null;

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: Parameters

	public partial class ParametersElement : Artech.Common.Collections.BaseCollection<ParameterElement>
	{
		protected string m_ElementName;

		#region Construction

		internal ParametersElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<ParameterElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<ParameterElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of ParametersElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="ParameterElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no Parameter is found, <b>null</b> is returned.
		/// </summary>
		public ParameterElement FindParameter(System.String name)
		{
			return this.Find(delegate (ParameterElement parameterItem) { return parameterItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Parameters";
		}

		#endregion
	}

	#endregion

	#region Element: Selection

	public partial class SelectionElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Caption;
		private bool m_IsCaptionDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private System.String m_Page;
		private bool m_IsPageDefault;
		private System.Boolean m_IsMain;
		private bool m_IsIsMainDefault;
		private System.String m_MasterPage;
		private bool m_IsMasterPageDefault;
		private System.String m_LoadOnStart;
		private bool m_IsLoadOnStartDefault;
		private System.String m_RequiredFilter;
		private bool m_IsRequiredFilterDefault;
		private System.String m_RequiredFilterMessage;
		private bool m_IsRequiredFilterMessageDefault;
		private System.String m_AutomaticRefresh;
		private bool m_IsAutomaticRefreshDefault;
		private System.String m_FilterCollapse;
		private bool m_IsFilterCollapseDefault;
		private System.String m_FilterCollapseDefault;
		private bool m_IsFilterCollapseDefaultDefault;
		private System.String m_SetFocus;
		private bool m_IsSetFocusDefault;
		private System.String m_SetFocusAttribute;
		private bool m_IsSetFocusAttributeDefault;
		private System.String m_ObjName;
		private bool m_IsObjNameDefault;
		private System.String m_SearchEventCode;
		private bool m_IsSearchEventCodeDefault;
		private System.String m_CurrentPageCombo;
		private bool m_IsCurrentPageComboDefault;
		private System.String m_SubCode;
		private bool m_IsSubCodeDefault;
		private System.String m_CallMethod;
		private bool m_IsCallMethodDefault;
		private System.String m_EventStart;
		private bool m_IsEventStartDefault;
		private System.String m_Identifier;
		private bool m_IsIdentifierDefault;
		private System.String m_UpdateObject;
		private bool m_IsUpdateObjectDefault;
		private System.String m_UpdateExport;
		private bool m_IsUpdateExportDefault;
		private System.String m_UpdateSDT;
		private bool m_IsUpdateSDTDefault;
		private System.String m_CustomRender;
		private bool m_IsCustomRenderDefault;
		private System.String m_AutoResize;
		private bool m_IsAutoResizeDefault;
		private System.String m_Width;
		private bool m_IsWidthDefault;
		private System.String m_Height;
		private bool m_IsHeightDefault;
		private System.String m_AllowSelection;
		private bool m_IsAllowSelectionDefault;
		private ModesElement m_Modes;
		private AttributesElement m_Attributes;
		private ParametersElement m_Parameters;
		private OrdersElement m_Orders;
		private FilterElement m_Filter;
		private ActionsElement m_Actions;
		private GridPropertiesElement m_GridProperties;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SelectionElement"/> class.
		/// </summary>
		public SelectionElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SelectionElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Caption = "";
			m_IsCaptionDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_Page = "<default>";
			m_IsPageDefault = true;
			m_IsMain = false;
			m_IsIsMainDefault = true;
			m_MasterPage = "<default>";
			m_IsMasterPageDefault = true;
			m_LoadOnStart = "<default>";
			m_IsLoadOnStartDefault = true;
			m_RequiredFilter = "<default>";
			m_IsRequiredFilterDefault = true;
			m_RequiredFilterMessage = "<default>";
			m_IsRequiredFilterMessageDefault = true;
			m_AutomaticRefresh = "<default>";
			m_IsAutomaticRefreshDefault = true;
			m_FilterCollapse = "<default>";
			m_IsFilterCollapseDefault = true;
			m_FilterCollapseDefault = "<default>";
			m_IsFilterCollapseDefaultDefault = true;
			m_SetFocus = "<default>";
			m_IsSetFocusDefault = true;
			m_SetFocusAttribute = "";
			m_IsSetFocusAttributeDefault = true;
			m_ObjName = "";
			m_IsObjNameDefault = true;
			m_SearchEventCode = "";
			m_IsSearchEventCodeDefault = true;
			m_CurrentPageCombo = "default";
			m_IsCurrentPageComboDefault = true;
			m_SubCode = "";
			m_IsSubCodeDefault = true;
			m_CallMethod = "default";
			m_IsCallMethodDefault = true;
			m_EventStart = "";
			m_IsEventStartDefault = true;
			m_Identifier = "";
			m_IsIdentifierDefault = true;
			m_UpdateObject = "Create default";
			m_IsUpdateObjectDefault = true;
			m_UpdateExport = "Create default";
			m_IsUpdateExportDefault = true;
			m_UpdateSDT = "Create default";
			m_IsUpdateSDTDefault = true;
			m_CustomRender = "<default>";
			m_IsCustomRenderDefault = true;
			m_AutoResize = "default";
			m_IsAutoResizeDefault = true;
			m_Width = "";
			m_IsWidthDefault = true;
			m_Height = "";
			m_IsHeightDefault = true;
			m_AllowSelection = "default";
			m_IsAllowSelectionDefault = true;
			m_Modes = new ModesElement();
			m_Modes.Parent = this;
			m_Attributes = new AttributesElement();
			m_Attributes.Parent = this;
			m_Parameters = new ParametersElement();
			m_Parameters.Parent = this;
			m_Parameters.ElementName = "parameters";
			m_Orders = new OrdersElement();
			m_Orders.Parent = this;
			m_Orders.ElementName = "orders";
			m_Filter = null;
			m_Actions = new ActionsElement();
			m_Actions.Parent = this;
			m_Actions.ElementName = "actions";
			m_GridProperties = new GridPropertiesElement();
			m_GridProperties.Parent = this;
			m_GridProperties.ElementName = "GridProperties";
		}

		#endregion

		#region Properties

		private LevelElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="SelectionElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public LevelElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Literal to appear in the Form's caption (description is the default). If a literal, use quotes.
		*/
		/// </summary>
		public System.String Caption
		{
			get { return m_Caption; }
			set 
			{
				m_Caption = value;
				m_IsCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		Description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Number of rows in the grid per page (only for Grid type).
		*/
		/// </summary>
		public System.String Page
		{
			get { return m_Page; }
			set 
			{
				m_Page = value;
				m_IsPageDefault = false;
			}
		}

		/// <summary>
		/*
		Set "Main Program" flag in selection webpanel.
		*/
		/// </summary>
		public System.Boolean IsMain
		{
			get { return m_IsMain; }
			set 
			{
				m_IsMain = value;
				m_IsIsMainDefault = false;
			}
		}

		/// <summary>
		/*
		Object name of the master page to be used in this selection webpanel. 
		/// To use the one defined in the configuration file, set value to "&lt;default&gt;". 
		/// To disable the master page, use "&lt;none&gt;".
		*/
		/// </summary>
		public System.String MasterPage
		{
			get { return m_MasterPage; }
			set 
			{
				m_MasterPage = value;
				m_IsMasterPageDefault = false;
			}
		}

		/// <summary>
		/*
		Carrega Grid no Start, ou não somente quando clicar em procurar
		*/
		/// </summary>
		public System.String LoadOnStart
		{
			get { return m_LoadOnStart; }
			set 
			{
				m_LoadOnStart = value;
				m_IsLoadOnStartDefault = false;
			}
		}

		/// <summary>
		/*
		Define se será obrigatório informar pelo menos um filtro para pesquisa
		*/
		/// </summary>
		public System.String RequiredFilter
		{
			get { return m_RequiredFilter; }
			set 
			{
				m_RequiredFilter = value;
				m_IsRequiredFilterDefault = false;
			}
		}

		/// <summary>
		/*
		Define a mensagem padrão para o filtro requerido
		*/
		/// </summary>
		public System.String RequiredFilterMessage
		{
			get { return m_RequiredFilterMessage; }
			set 
			{
				m_RequiredFilterMessage = value;
				m_IsRequiredFilterMessageDefault = false;
			}
		}

		/// <summary>
		/*
		Automatic Refresh no Grid, pesquisa sem clicar no botão Pesquisar
		*/
		/// </summary>
		public System.String AutomaticRefresh
		{
			get { return m_AutomaticRefresh; }
			set 
			{
				m_AutomaticRefresh = value;
				m_IsAutomaticRefreshDefault = false;
			}
		}

		/// <summary>
		/*
		Utiliza Collapse/Expand para os Filtros da Selection
		*/
		/// </summary>
		public System.String FilterCollapse
		{
			get { return m_FilterCollapse; }
			set 
			{
				m_FilterCollapse = value;
				m_IsFilterCollapseDefault = false;
			}
		}

		/// <summary>
		/*
		Carrega os Filtros por padrão Collapse
		*/
		/// </summary>
		public System.String FilterCollapseDefault
		{
			get { return m_FilterCollapseDefault; }
			set 
			{
				m_FilterCollapseDefault = value;
				m_IsFilterCollapseDefaultDefault = false;
			}
		}

		/// <summary>
		/*
		Define Foco no primeiro atributo de filtro
		*/
		/// </summary>
		public System.String SetFocus
		{
			get { return m_SetFocus; }
			set 
			{
				m_SetFocus = value;
				m_IsSetFocusDefault = false;
			}
		}

		/// <summary>
		/*
		Define Foco no primeiro atributo de filtro
		*/
		/// </summary>
		public System.String SetFocusAttribute
		{
			get { return m_SetFocusAttribute; }
			set 
			{
				m_SetFocusAttribute = value;
				m_IsSetFocusAttributeDefault = false;
			}
		}

		/// <summary>
		/*
		Object Name
		*/
		/// </summary>
		public System.String ObjName
		{
			get { return m_ObjName; }
			set 
			{
				m_ObjName = value;
				m_IsObjNameDefault = false;
			}
		}

		/// <summary>
		/*
		Define Código para o Evento Search
		*/
		/// </summary>
		public System.String SearchEventCode
		{
			get { return m_SearchEventCode; }
			set 
			{
				m_SearchEventCode = value;
				m_IsSearchEventCodeDefault = false;
			}
		}

		/// <summary>
		/*
		CurrentPage ComboBox para seleção do número da pagina
		*/
		/// </summary>
		public System.String CurrentPageCombo
		{
			get { return m_CurrentPageCombo; }
			set 
			{
				m_CurrentPageCombo = value;
				m_IsCurrentPageComboDefault = false;
			}
		}

		/// <summary>
		/*
		Define Sub para utilização neste objeto
		*/
		/// </summary>
		public System.String SubCode
		{
			get { return m_SubCode; }
			set 
			{
				m_SubCode = value;
				m_IsSubCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Define o metodo de chamada ao cadastro, Link ou Popup Modal
		*/
		/// </summary>
		public System.String CallMethod
		{
			get { return m_CallMethod; }
			set 
			{
				m_CallMethod = value;
				m_IsCallMethodDefault = false;
			}
		}

		/// <summary>
		/*
		Define código para o Evento Start
		*/
		/// </summary>
		public System.String EventStart
		{
			get { return m_EventStart; }
			set 
			{
				m_EventStart = value;
				m_IsEventStartDefault = false;
			}
		}

		/// <summary>
		/*
		Define o identificador de registro no grid
		*/
		/// </summary>
		public System.String Identifier
		{
			get { return m_Identifier; }
			set 
			{
				m_Identifier = value;
				m_IsIdentifierDefault = false;
			}
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Only Rules, Events and Conditions - Atualiza somente as regras, eventos e condições e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateObject
		{
			get { return m_UpdateObject; }
			set 
			{
				m_UpdateObject = value;
				m_IsUpdateObjectDefault = false;
			}
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateExport
		{
			get { return m_UpdateExport; }
			set 
			{
				m_UpdateExport = value;
				m_IsUpdateExportDefault = false;
			}
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateSDT
		{
			get { return m_UpdateSDT; }
			set 
			{
				m_UpdateSDT = value;
				m_IsUpdateSDTDefault = false;
			}
		}

		/// <summary>
		/*
		Use a custom user control for rendering grids. Applies to all selection and grid tab objects.
		*/
		/// </summary>
		public System.String CustomRender
		{
			get { return m_CustomRender; }
			set 
			{
				m_CustomRender = value;
				m_IsCustomRenderDefault = false;
			}
		}

		/// <summary>
		/*
		Define o AutoResize para o Grid
		*/
		/// </summary>
		public System.String AutoResize
		{
			get { return m_AutoResize; }
			set 
			{
				m_AutoResize = value;
				m_IsAutoResizeDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width(tamanho horizontal) para o Grid
		*/
		/// </summary>
		public System.String Width
		{
			get { return m_Width; }
			set 
			{
				m_Width = value;
				m_IsWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Height(tamanho vertical) para o Grid
		*/
		/// </summary>
		public System.String Height
		{
			get { return m_Height; }
			set 
			{
				m_Height = value;
				m_IsHeightDefault = false;
			}
		}

		/// <summary>
		/*
		Define o AllowSelection para o Grid
		*/
		/// </summary>
		public System.String AllowSelection
		{
			get { return m_AllowSelection; }
			set 
			{
				m_AllowSelection = value;
				m_IsAllowSelectionDefault = false;
			}
		}

		public ModesElement Modes
		{
			get { return m_Modes; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Modes = value;
				m_Modes.Parent = this;
			}
		}

		public AttributesElement Attributes
		{
			get { return m_Attributes; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Attributes = value;
				m_Attributes.Parent = this;
			}
		}

		public ParametersElement Parameters
		{
			get { return m_Parameters; }
		}

		public OrdersElement Orders
		{
			get { return m_Orders; }
		}

		public FilterElement Filter
		{
			get { return m_Filter; }
			set
			{
				m_Filter = value;
				m_Filter.Parent = this;
			}
		}

		public ActionsElement Actions
		{
			get { return m_Actions; }
		}

		public GridPropertiesElement GridProperties
		{
			get { return m_GridProperties; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// </summary>
		public ParameterElement AddParameter()
		{
			ParameterElement parameterElement = new ParameterElement();
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// The ParameterElement is initialized with the specified value.
		/// </summary>
		public ParameterElement AddParameter(System.String name)
		{
			ParameterElement parameterElement = new ParameterElement(name);
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Finds the <see cref="ParameterElement"/> in the <see cref="Parameters"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no parameterElement is found, null is returned.
		/// </summary>
		public ParameterElement FindParameter(System.String name)
		{
			return Parameters.Find(delegate (ParameterElement parameterElement) { return parameterElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="OrderElement"/> and adds it to the <see cref="Orders"/> collection.
		/// </summary>
		public OrderElement AddOrder()
		{
			OrderElement orderElement = new OrderElement();
			m_Orders.Add(orderElement);
			return orderElement;
		}

		/// <summary>
		/// Creates a new <see cref="OrderElement"/> and adds it to the <see cref="Orders"/> collection.
		/// The OrderElement is initialized with the specified value.
		/// </summary>
		public OrderElement AddOrder(System.String name)
		{
			OrderElement orderElement = new OrderElement(name);
			m_Orders.Add(orderElement);
			return orderElement;
		}

		/// <summary>
		/// Finds the <see cref="OrderElement"/> in the <see cref="Orders"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no orderElement is found, null is returned.
		/// </summary>
		public OrderElement FindOrder(System.String name)
		{
			return Orders.Find(delegate (OrderElement orderElement) { return orderElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="ActionElement"/> and adds it to the <see cref="Actions"/> collection.
		/// </summary>
		public ActionElement AddAction()
		{
			ActionElement actionElement = new ActionElement();
			m_Actions.Add(actionElement);
			return actionElement;
		}

		/// <summary>
		/// Creates a new <see cref="ActionElement"/> and adds it to the <see cref="Actions"/> collection.
		/// The ActionElement is initialized with the specified value.
		/// </summary>
		public ActionElement AddAction(System.String name)
		{
			ActionElement actionElement = new ActionElement(name);
			m_Actions.Add(actionElement);
			return actionElement;
		}

		/// <summary>
		/// Finds the <see cref="ActionElement"/> in the <see cref="Actions"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no actionElement is found, null is returned.
		/// </summary>
		public ActionElement FindAction(System.String name)
		{
			return Actions.Find(delegate (ActionElement actionElement) { return actionElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="GridPropertieElement"/> and adds it to the <see cref="GridProperties"/> collection.
		/// </summary>
		public GridPropertieElement AddGridPropertie()
		{
			GridPropertieElement gridPropertieElement = new GridPropertieElement();
			m_GridProperties.Add(gridPropertieElement);
			return gridPropertieElement;
		}

		/// <summary>
		/// Creates a new <see cref="GridPropertieElement"/> and adds it to the <see cref="GridProperties"/> collection.
		/// The GridPropertieElement is initialized with the specified value.
		/// </summary>
		public GridPropertieElement AddGridPropertie(System.String name)
		{
			GridPropertieElement gridPropertieElement = new GridPropertieElement(name);
			m_GridProperties.Add(gridPropertieElement);
			return gridPropertieElement;
		}

		/// <summary>
		/// Finds the <see cref="GridPropertieElement"/> in the <see cref="GridProperties"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridPropertieElement is found, null is returned.
		/// </summary>
		public GridPropertieElement FindGridPropertie(System.String name)
		{
			return GridProperties.Find(delegate (GridPropertieElement gridPropertieElement) { return gridPropertieElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="SelectionElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Selection")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Selection"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Caption = element.Attributes.GetPropertyValue<System.String>("caption");
			m_IsCaptionDefault = element.Attributes.IsPropertyDefault("caption");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");
			m_Page = element.Attributes.GetPropertyValue<System.String>("page");
			m_IsPageDefault = element.Attributes.IsPropertyDefault("page");
			m_IsMain = element.Attributes.GetPropertyValue<System.Boolean>("isMain");
			m_IsIsMainDefault = element.Attributes.IsPropertyDefault("isMain");
			m_MasterPage = element.Attributes.GetPropertyValue<System.String>("masterPage");
			m_IsMasterPageDefault = element.Attributes.IsPropertyDefault("masterPage");
			m_LoadOnStart = element.Attributes.GetPropertyValue<System.String>("loadOnStart");
			m_IsLoadOnStartDefault = element.Attributes.IsPropertyDefault("loadOnStart");
			m_RequiredFilter = element.Attributes.GetPropertyValue<System.String>("requiredFilter");
			m_IsRequiredFilterDefault = element.Attributes.IsPropertyDefault("requiredFilter");
			m_RequiredFilterMessage = element.Attributes.GetPropertyValue<System.String>("requiredFilterMessage");
			m_IsRequiredFilterMessageDefault = element.Attributes.IsPropertyDefault("requiredFilterMessage");
			m_AutomaticRefresh = element.Attributes.GetPropertyValue<System.String>("automaticRefresh");
			m_IsAutomaticRefreshDefault = element.Attributes.IsPropertyDefault("automaticRefresh");
			m_FilterCollapse = element.Attributes.GetPropertyValue<System.String>("filterCollapse");
			m_IsFilterCollapseDefault = element.Attributes.IsPropertyDefault("filterCollapse");
			m_FilterCollapseDefault = element.Attributes.GetPropertyValue<System.String>("filterCollapseDefault");
			m_IsFilterCollapseDefaultDefault = element.Attributes.IsPropertyDefault("filterCollapseDefault");
			m_SetFocus = element.Attributes.GetPropertyValue<System.String>("setFocus");
			m_IsSetFocusDefault = element.Attributes.IsPropertyDefault("setFocus");
			m_SetFocusAttribute = element.Attributes.GetPropertyValue<System.String>("setFocusAttribute");
			m_IsSetFocusAttributeDefault = element.Attributes.IsPropertyDefault("setFocusAttribute");
			m_ObjName = element.Attributes.GetPropertyValue<System.String>("objName");
			m_IsObjNameDefault = element.Attributes.IsPropertyDefault("objName");
			m_SearchEventCode = element.Attributes.GetPropertyValue<System.String>("SearchEventCode");
			m_IsSearchEventCodeDefault = element.Attributes.IsPropertyDefault("SearchEventCode");
			m_CurrentPageCombo = element.Attributes.GetPropertyValue<System.String>("CurrentPageCombo");
			m_IsCurrentPageComboDefault = element.Attributes.IsPropertyDefault("CurrentPageCombo");
			m_SubCode = element.Attributes.GetPropertyValue<System.String>("SubCode");
			m_IsSubCodeDefault = element.Attributes.IsPropertyDefault("SubCode");
			m_CallMethod = element.Attributes.GetPropertyValue<System.String>("CallMethod");
			m_IsCallMethodDefault = element.Attributes.IsPropertyDefault("CallMethod");
			m_EventStart = element.Attributes.GetPropertyValue<System.String>("EventStart");
			m_IsEventStartDefault = element.Attributes.IsPropertyDefault("EventStart");
			m_Identifier = element.Attributes.GetPropertyValue<System.String>("Identifier");
			m_IsIdentifierDefault = element.Attributes.IsPropertyDefault("Identifier");
			m_UpdateObject = element.Attributes.GetPropertyValue<System.String>("updateObject");
			m_IsUpdateObjectDefault = element.Attributes.IsPropertyDefault("updateObject");
			m_UpdateExport = element.Attributes.GetPropertyValue<System.String>("updateExport");
			m_IsUpdateExportDefault = element.Attributes.IsPropertyDefault("updateExport");
			m_UpdateSDT = element.Attributes.GetPropertyValue<System.String>("updateSDT");
			m_IsUpdateSDTDefault = element.Attributes.IsPropertyDefault("updateSDT");
			m_CustomRender = element.Attributes.GetPropertyValue<System.String>("CustomRender");
			m_IsCustomRenderDefault = element.Attributes.IsPropertyDefault("CustomRender");
			m_AutoResize = element.Attributes.GetPropertyValue<System.String>("AutoResize");
			m_IsAutoResizeDefault = element.Attributes.IsPropertyDefault("AutoResize");
			m_Width = element.Attributes.GetPropertyValue<System.String>("Width");
			m_IsWidthDefault = element.Attributes.IsPropertyDefault("Width");
			m_Height = element.Attributes.GetPropertyValue<System.String>("Height");
			m_IsHeightDefault = element.Attributes.IsPropertyDefault("Height");
			m_AllowSelection = element.Attributes.GetPropertyValue<System.String>("AllowSelection");
			m_IsAllowSelectionDefault = element.Attributes.IsPropertyDefault("AllowSelection");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "modes" :
					{
						ModesElement modes = new ModesElement();
						modes.LoadFrom(_childElement);
						Modes = modes;
						break;
					}
					case "attributes" :
					{
						AttributesElement attributes = new AttributesElement();
						attributes.LoadFrom(_childElement);
						Attributes = attributes;
						break;
					}
					case "parameters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ParameterElement parameterElement = new ParameterElement();
							parameterElement.LoadFrom(_childElementItem);
							Parameters.Add(parameterElement);
						}
						break;
					}
					case "orders" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							OrderElement orderElement = new OrderElement();
							orderElement.LoadFrom(_childElementItem);
							Orders.Add(orderElement);
						}
						break;
					}
					case "filter" :
					{
						FilterElement filter = new FilterElement();
						filter.LoadFrom(_childElement);
						Filter = filter;
						break;
					}
					case "actions" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ActionElement actionElement = new ActionElement();
							actionElement.LoadFrom(_childElementItem);
							Actions.Add(actionElement);
						}
						break;
					}
					case "GridProperties" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							GridPropertieElement gridPropertieElement = new GridPropertieElement();
							gridPropertieElement.LoadFrom(_childElementItem);
							GridProperties.Add(gridPropertieElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="SelectionElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Selection")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Selection"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "caption", m_Caption, m_IsCaptionDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);
			SaveAttribute(element, "page", m_Page, m_IsPageDefault);
			SaveAttribute(element, "isMain", m_IsMain, m_IsIsMainDefault);
			SaveAttribute(element, "masterPage", m_MasterPage, m_IsMasterPageDefault);
			SaveAttribute(element, "loadOnStart", m_LoadOnStart, m_IsLoadOnStartDefault);
			SaveAttribute(element, "requiredFilter", m_RequiredFilter, m_IsRequiredFilterDefault);
			SaveAttribute(element, "requiredFilterMessage", m_RequiredFilterMessage, m_IsRequiredFilterMessageDefault);
			SaveAttribute(element, "automaticRefresh", m_AutomaticRefresh, m_IsAutomaticRefreshDefault);
			SaveAttribute(element, "filterCollapse", m_FilterCollapse, m_IsFilterCollapseDefault);
			SaveAttribute(element, "filterCollapseDefault", m_FilterCollapseDefault, m_IsFilterCollapseDefaultDefault);
			SaveAttribute(element, "setFocus", m_SetFocus, m_IsSetFocusDefault);
			SaveAttribute(element, "setFocusAttribute", m_SetFocusAttribute, m_IsSetFocusAttributeDefault);
			SaveAttribute(element, "objName", m_ObjName, m_IsObjNameDefault);
			SaveAttribute(element, "SearchEventCode", m_SearchEventCode, m_IsSearchEventCodeDefault);
			SaveAttribute(element, "CurrentPageCombo", m_CurrentPageCombo, m_IsCurrentPageComboDefault);
			SaveAttribute(element, "SubCode", m_SubCode, m_IsSubCodeDefault);
			SaveAttribute(element, "CallMethod", m_CallMethod, m_IsCallMethodDefault);
			SaveAttribute(element, "EventStart", m_EventStart, m_IsEventStartDefault);
			SaveAttribute(element, "Identifier", m_Identifier, m_IsIdentifierDefault);
			SaveAttribute(element, "updateObject", m_UpdateObject, m_IsUpdateObjectDefault);
			SaveAttribute(element, "updateExport", m_UpdateExport, m_IsUpdateExportDefault);
			SaveAttribute(element, "updateSDT", m_UpdateSDT, m_IsUpdateSDTDefault);
			SaveAttribute(element, "CustomRender", m_CustomRender, m_IsCustomRenderDefault);
			SaveAttribute(element, "AutoResize", m_AutoResize, m_IsAutoResizeDefault);
			SaveAttribute(element, "Width", m_Width, m_IsWidthDefault);
			SaveAttribute(element, "Height", m_Height, m_IsHeightDefault);
			SaveAttribute(element, "AllowSelection", m_AllowSelection, m_IsAllowSelectionDefault);

			Debug.Assert(m_Caption == element.Attributes.GetPropertyValue<System.String>("caption"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));
			Debug.Assert(m_Page == element.Attributes.GetPropertyValue<System.String>("page"));
			Debug.Assert(m_IsMain == element.Attributes.GetPropertyValue<System.Boolean>("isMain"));
			Debug.Assert(m_MasterPage == element.Attributes.GetPropertyValue<System.String>("masterPage"));
			Debug.Assert(m_LoadOnStart == element.Attributes.GetPropertyValue<System.String>("loadOnStart"));
			Debug.Assert(m_RequiredFilter == element.Attributes.GetPropertyValue<System.String>("requiredFilter"));
			Debug.Assert(m_RequiredFilterMessage == element.Attributes.GetPropertyValue<System.String>("requiredFilterMessage"));
			Debug.Assert(m_AutomaticRefresh == element.Attributes.GetPropertyValue<System.String>("automaticRefresh"));
			Debug.Assert(m_FilterCollapse == element.Attributes.GetPropertyValue<System.String>("filterCollapse"));
			Debug.Assert(m_FilterCollapseDefault == element.Attributes.GetPropertyValue<System.String>("filterCollapseDefault"));
			Debug.Assert(m_SetFocus == element.Attributes.GetPropertyValue<System.String>("setFocus"));
			Debug.Assert(m_SetFocusAttribute == element.Attributes.GetPropertyValue<System.String>("setFocusAttribute"));
			Debug.Assert(m_ObjName == element.Attributes.GetPropertyValue<System.String>("objName"));
			Debug.Assert(m_SearchEventCode == element.Attributes.GetPropertyValue<System.String>("SearchEventCode"));
			Debug.Assert(m_CurrentPageCombo == element.Attributes.GetPropertyValue<System.String>("CurrentPageCombo"));
			Debug.Assert(m_SubCode == element.Attributes.GetPropertyValue<System.String>("SubCode"));
			Debug.Assert(m_CallMethod == element.Attributes.GetPropertyValue<System.String>("CallMethod"));
			Debug.Assert(m_EventStart == element.Attributes.GetPropertyValue<System.String>("EventStart"));
			Debug.Assert(m_Identifier == element.Attributes.GetPropertyValue<System.String>("Identifier"));
			Debug.Assert(m_UpdateObject == element.Attributes.GetPropertyValue<System.String>("updateObject"));
			Debug.Assert(m_UpdateExport == element.Attributes.GetPropertyValue<System.String>("updateExport"));
			Debug.Assert(m_UpdateSDT == element.Attributes.GetPropertyValue<System.String>("updateSDT"));
			Debug.Assert(m_AutoResize == element.Attributes.GetPropertyValue<System.String>("AutoResize"));
			Debug.Assert(m_Width == element.Attributes.GetPropertyValue<System.String>("Width"));
			Debug.Assert(m_Height == element.Attributes.GetPropertyValue<System.String>("Height"));
			Debug.Assert(m_AllowSelection == element.Attributes.GetPropertyValue<System.String>("AllowSelection"));

			// Save element children.
			if (m_Modes != null)
			{
				PatternInstanceElement modes = element.Children["modes"];
				m_Modes.SaveTo(modes);
			}

			if (m_Attributes != null)
			{
				PatternInstanceElement attributes = element.Children["attributes"];
				m_Attributes.SaveTo(attributes);
			}

			if (m_Parameters != null)
			{
				if (m_Parameters.Count > 0)
					element.Children.AddNewElement("parameters");

				foreach (ParameterElement _item in Parameters)
				{
					PatternInstanceElement child = element.Children["parameters"].Children.AddNewElement("parameter");
					_item.SaveTo(child);
				}
			}

			if (m_Orders != null)
			{
				if (m_Orders.Count > 0)
					element.Children.AddNewElement("orders");

				foreach (OrderElement _item in Orders)
				{
					PatternInstanceElement child = element.Children["orders"].Children.AddNewElement("order");
					_item.SaveTo(child);
				}
			}

			if (m_Filter != null)
			{
				PatternInstanceElement filter = element.Children.AddNewElement("filter");
				m_Filter.SaveTo(filter);
			}

			if (m_Actions != null)
			{
				if (m_Actions.Count > 0)
					element.Children.AddNewElement("actions");

				foreach (ActionElement _item in Actions)
				{
					PatternInstanceElement child = element.Children["actions"].Children.AddNewElement("action");
					_item.SaveTo(child);
				}
			}

			if (m_GridProperties != null)
			{
				if (m_GridProperties.Count > 0)
					element.Children.AddNewElement("GridProperties");

				foreach (GridPropertieElement _item in GridProperties)
				{
					PatternInstanceElement child = element.Children["GridProperties"].Children.AddNewElement("GridPropertie");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SelectionElement"/>.
		/// </summary>
		public SelectionElement Clone()
		{
			SelectionElement clone = new SelectionElement();

			clone.Caption = this.Caption;
			clone.Description = this.Description;
			clone.Page = this.Page;
			clone.IsMain = this.IsMain;
			clone.MasterPage = this.MasterPage;
			clone.LoadOnStart = this.LoadOnStart;
			clone.RequiredFilter = this.RequiredFilter;
			clone.RequiredFilterMessage = this.RequiredFilterMessage;
			clone.AutomaticRefresh = this.AutomaticRefresh;
			clone.FilterCollapse = this.FilterCollapse;
			clone.FilterCollapseDefault = this.FilterCollapseDefault;
			clone.SetFocus = this.SetFocus;
			clone.SetFocusAttribute = this.SetFocusAttribute;
			clone.ObjName = this.ObjName;
			clone.SearchEventCode = this.SearchEventCode;
			clone.CurrentPageCombo = this.CurrentPageCombo;
			clone.SubCode = this.SubCode;
			clone.CallMethod = this.CallMethod;
			clone.EventStart = this.EventStart;
			clone.Identifier = this.Identifier;
			clone.UpdateObject = this.UpdateObject;
			clone.UpdateExport = this.UpdateExport;
			clone.UpdateSDT = this.UpdateSDT;
			clone.CustomRender = this.CustomRender;
			clone.AutoResize = this.AutoResize;
			clone.Width = this.Width;
			clone.Height = this.Height;
			clone.AllowSelection = this.AllowSelection;
			clone.Modes = this.Modes.Clone();
			clone.Attributes = this.Attributes.Clone();
			foreach (ParameterElement parameterElement in this.Parameters)
				clone.Parameters.Add(parameterElement.Clone());
			foreach (OrderElement orderElement in this.Orders)
				clone.Orders.Add(orderElement.Clone());
			if (Filter != null)
				clone.Filter = this.Filter.Clone();
			foreach (ActionElement actionElement in this.Actions)
				clone.Actions.Add(actionElement.Clone());
			foreach (GridPropertieElement gridPropertieElement in this.GridProperties)
				clone.GridProperties.Add(gridPropertieElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "modes" :
				{
					if (Modes != null)
						return Modes.GetElement(path);
					else
						return null;
				}
				case "attributes" :
				{
					if (Attributes != null)
						return Attributes.GetElement(path);
					else
						return null;
				}
				case "parameters" :
				{
					if (path.Count == 0)
						return Parameters;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "parameter")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Parameters != null && itemIndex >= 0 && itemIndex < Parameters.Count)
						return Parameters[itemIndex].GetElement(path);
					else
						return null;
				}
				case "orders" :
				{
					if (path.Count == 0)
						return Orders;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "order")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Orders != null && itemIndex >= 0 && itemIndex < Orders.Count)
						return Orders[itemIndex].GetElement(path);
					else
						return null;
				}
				case "filter" :
				{
					if (Filter != null)
						return Filter.GetElement(path);
					else
						return null;
				}
				case "actions" :
				{
					if (path.Count == 0)
						return Actions;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "action")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Actions != null && itemIndex >= 0 && itemIndex < Actions.Count)
						return Actions[itemIndex].GetElement(path);
					else
						return null;
				}
				case "GridProperties" :
				{
					if (path.Count == 0)
						return GridProperties;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "GridPropertie")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (GridProperties != null && itemIndex >= 0 && itemIndex < GridProperties.Count)
						return GridProperties[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Page"/> property.
		/// </summary>
		public static class PageValue
		{
			public const string Default = "<default>";
			public const string Unlimited = "<unlimited>";
		}

		/// <summary>
		/// Possible values for the <see cref="MasterPage"/> property.
		/// </summary>
		public static class MasterPageValue
		{
			public const string Default = "<default>";
			public const string None = "<none>";
		}

		/// <summary>
		/// Possible values for the <see cref="LoadOnStart"/> property.
		/// </summary>
		public static class LoadOnStartValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="RequiredFilter"/> property.
		/// </summary>
		public static class RequiredFilterValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="RequiredFilterMessage"/> property.
		/// </summary>
		public static class RequiredFilterMessageValue
		{
			public const string Default = "<default>";
		}

		/// <summary>
		/// Possible values for the <see cref="AutomaticRefresh"/> property.
		/// </summary>
		public static class AutomaticRefreshValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="FilterCollapse"/> property.
		/// </summary>
		public static class FilterCollapseValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="FilterCollapseDefault"/> property.
		/// </summary>
		public static class FilterCollapseDefaultValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="SetFocus"/> property.
		/// </summary>
		public static class SetFocusValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="CurrentPageCombo"/> property.
		/// </summary>
		public static class CurrentPageComboValue
		{
			public const string Default = "default";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="CallMethod"/> property.
		/// </summary>
		public static class CallMethodValue
		{
			public const string Default = "default";
			public const string Link = "Link";
			public const string Popup = "Popup";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateObject"/> property.
		/// </summary>
		public static class UpdateObjectValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string OnlyRulesEventsAndConditions = "Only Rules, Events and Conditions";
			public const string Overwrite = "Overwrite";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateExport"/> property.
		/// </summary>
		public static class UpdateExportValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string Overwrite = "Overwrite";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateSDT"/> property.
		/// </summary>
		public static class UpdateSDTValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string Overwrite = "Overwrite";
		}

		/// <summary>
		/// Possible values for the <see cref="AutoResize"/> property.
		/// </summary>
		public static class AutoResizeValue
		{
			public const string Default = "default";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="AllowSelection"/> property.
		/// </summary>
		public static class AllowSelectionValue
		{
			public const string Default = "default";
			public const string True = "true";
			public const string False = "false";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Selection ({0})", Description);
		}

		#endregion
	}

	#endregion

	#region Element: Prompt

	public partial class PromptElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Caption;
		private bool m_IsCaptionDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private System.String m_Page;
		private bool m_IsPageDefault;
		private System.Boolean m_IsMain;
		private bool m_IsIsMainDefault;
		private System.String m_MasterPage;
		private bool m_IsMasterPageDefault;
		private System.String m_LoadOnStart;
		private bool m_IsLoadOnStartDefault;
		private System.String m_RequiredFilter;
		private bool m_IsRequiredFilterDefault;
		private System.String m_RequiredFilterMessage;
		private bool m_IsRequiredFilterMessageDefault;
		private System.String m_AutomaticRefresh;
		private bool m_IsAutomaticRefreshDefault;
		private System.String m_FilterCollapse;
		private bool m_IsFilterCollapseDefault;
		private System.String m_FilterCollapseDefault;
		private bool m_IsFilterCollapseDefaultDefault;
		private System.String m_SetFocus;
		private bool m_IsSetFocusDefault;
		private System.String m_SetFocusAttribute;
		private bool m_IsSetFocusAttributeDefault;
		private System.String m_ObjName;
		private bool m_IsObjNameDefault;
		private System.String m_SearchEventCode;
		private bool m_IsSearchEventCodeDefault;
		private System.String m_CurrentPageCombo;
		private bool m_IsCurrentPageComboDefault;
		private System.String m_SubCode;
		private bool m_IsSubCodeDefault;
		private System.String m_EventStart;
		private bool m_IsEventStartDefault;
		private System.String m_UpdateObject;
		private bool m_IsUpdateObjectDefault;
		private System.String m_CustomRender;
		private bool m_IsCustomRenderDefault;
		private System.String m_CallMethod;
		private bool m_IsCallMethodDefault;
		private System.String m_AutoResize;
		private bool m_IsAutoResizeDefault;
		private System.String m_Width;
		private bool m_IsWidthDefault;
		private System.String m_Height;
		private bool m_IsHeightDefault;
		private System.String m_AllowSelection;
		private bool m_IsAllowSelectionDefault;
		private ModesElement m_Modes;
		private AttributesElement m_Attributes;
		private ParametersElement m_Parameters;
		private OrdersElement m_Orders;
		private FilterElement m_Filter;
		private ActionsElement m_Actions;
		private GridPropertiesElement m_GridProperties;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="PromptElement"/> class.
		/// </summary>
		public PromptElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="PromptElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Caption = "";
			m_IsCaptionDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_Page = "<default>";
			m_IsPageDefault = true;
			m_IsMain = false;
			m_IsIsMainDefault = true;
			m_MasterPage = "<default>";
			m_IsMasterPageDefault = true;
			m_LoadOnStart = "<default>";
			m_IsLoadOnStartDefault = true;
			m_RequiredFilter = "<default>";
			m_IsRequiredFilterDefault = true;
			m_RequiredFilterMessage = "<default>";
			m_IsRequiredFilterMessageDefault = true;
			m_AutomaticRefresh = "<default>";
			m_IsAutomaticRefreshDefault = true;
			m_FilterCollapse = "<default>";
			m_IsFilterCollapseDefault = true;
			m_FilterCollapseDefault = "<default>";
			m_IsFilterCollapseDefaultDefault = true;
			m_SetFocus = "<default>";
			m_IsSetFocusDefault = true;
			m_SetFocusAttribute = "";
			m_IsSetFocusAttributeDefault = true;
			m_ObjName = "";
			m_IsObjNameDefault = true;
			m_SearchEventCode = "";
			m_IsSearchEventCodeDefault = true;
			m_CurrentPageCombo = "default";
			m_IsCurrentPageComboDefault = true;
			m_SubCode = "";
			m_IsSubCodeDefault = true;
			m_EventStart = "";
			m_IsEventStartDefault = true;
			m_UpdateObject = "Create default";
			m_IsUpdateObjectDefault = true;
			m_CustomRender = "<default>";
			m_IsCustomRenderDefault = true;
			m_CallMethod = "default";
			m_IsCallMethodDefault = true;
			m_AutoResize = "default";
			m_IsAutoResizeDefault = true;
			m_Width = "";
			m_IsWidthDefault = true;
			m_Height = "";
			m_IsHeightDefault = true;
			m_AllowSelection = "default";
			m_IsAllowSelectionDefault = true;
			m_Modes = new ModesElement();
			m_Modes.Parent = this;
			m_Attributes = new AttributesElement();
			m_Attributes.Parent = this;
			m_Parameters = new ParametersElement();
			m_Parameters.Parent = this;
			m_Parameters.ElementName = "parameters";
			m_Orders = new OrdersElement();
			m_Orders.Parent = this;
			m_Orders.ElementName = "orders";
			m_Filter = null;
			m_Actions = new ActionsElement();
			m_Actions.Parent = this;
			m_Actions.ElementName = "actions";
			m_GridProperties = new GridPropertiesElement();
			m_GridProperties.Parent = this;
			m_GridProperties.ElementName = "GridProperties";
		}

		#endregion

		#region Properties

		private LevelElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="PromptElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public LevelElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Name
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Literal to appear in the Form's caption (description is the default). If a literal, use quotes.
		*/
		/// </summary>
		public System.String Caption
		{
			get { return m_Caption; }
			set 
			{
				m_Caption = value;
				m_IsCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		Description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Number of rows in the grid per page (only for Grid type).
		*/
		/// </summary>
		public System.String Page
		{
			get { return m_Page; }
			set 
			{
				m_Page = value;
				m_IsPageDefault = false;
			}
		}

		/// <summary>
		/*
		Set "Main Program" flag in selection webpanel.
		*/
		/// </summary>
		public System.Boolean IsMain
		{
			get { return m_IsMain; }
			set 
			{
				m_IsMain = value;
				m_IsIsMainDefault = false;
			}
		}

		/// <summary>
		/*
		Object name of the master page to be used in this selection webpanel. 
		/// To use the one defined in the configuration file, set value to "&lt;default&gt;". 
		/// To disable the master page, use "&lt;none&gt;".
		*/
		/// </summary>
		public System.String MasterPage
		{
			get { return m_MasterPage; }
			set 
			{
				m_MasterPage = value;
				m_IsMasterPageDefault = false;
			}
		}

		/// <summary>
		/*
		Carrega Grid no Start, ou não somente quando clicar em procurar
		*/
		/// </summary>
		public System.String LoadOnStart
		{
			get { return m_LoadOnStart; }
			set 
			{
				m_LoadOnStart = value;
				m_IsLoadOnStartDefault = false;
			}
		}

		/// <summary>
		/*
		Define se será obrigatório informar pelo menos um filtro para pesquisa
		*/
		/// </summary>
		public System.String RequiredFilter
		{
			get { return m_RequiredFilter; }
			set 
			{
				m_RequiredFilter = value;
				m_IsRequiredFilterDefault = false;
			}
		}

		/// <summary>
		/*
		Define a mensagem padrão para o filtro requerido
		*/
		/// </summary>
		public System.String RequiredFilterMessage
		{
			get { return m_RequiredFilterMessage; }
			set 
			{
				m_RequiredFilterMessage = value;
				m_IsRequiredFilterMessageDefault = false;
			}
		}

		/// <summary>
		/*
		Automatic Refresh no Grid, pesquisa sem clicar no botão Pesquisar
		*/
		/// </summary>
		public System.String AutomaticRefresh
		{
			get { return m_AutomaticRefresh; }
			set 
			{
				m_AutomaticRefresh = value;
				m_IsAutomaticRefreshDefault = false;
			}
		}

		/// <summary>
		/*
		Utiliza Collapse/Expand para os Filtros da Selection
		*/
		/// </summary>
		public System.String FilterCollapse
		{
			get { return m_FilterCollapse; }
			set 
			{
				m_FilterCollapse = value;
				m_IsFilterCollapseDefault = false;
			}
		}

		/// <summary>
		/*
		Carrega os Filtros por padrão Collapse
		*/
		/// </summary>
		public System.String FilterCollapseDefault
		{
			get { return m_FilterCollapseDefault; }
			set 
			{
				m_FilterCollapseDefault = value;
				m_IsFilterCollapseDefaultDefault = false;
			}
		}

		/// <summary>
		/*
		Define Foco no primeiro atributo de filtro
		*/
		/// </summary>
		public System.String SetFocus
		{
			get { return m_SetFocus; }
			set 
			{
				m_SetFocus = value;
				m_IsSetFocusDefault = false;
			}
		}

		/// <summary>
		/*
		Define Foco no primeiro atributo de filtro
		*/
		/// </summary>
		public System.String SetFocusAttribute
		{
			get { return m_SetFocusAttribute; }
			set 
			{
				m_SetFocusAttribute = value;
				m_IsSetFocusAttributeDefault = false;
			}
		}

		/// <summary>
		/*
		Object Name
		*/
		/// </summary>
		public System.String ObjName
		{
			get { return m_ObjName; }
			set 
			{
				m_ObjName = value;
				m_IsObjNameDefault = false;
			}
		}

		/// <summary>
		/*
		Define Código para o Evento Search
		*/
		/// </summary>
		public System.String SearchEventCode
		{
			get { return m_SearchEventCode; }
			set 
			{
				m_SearchEventCode = value;
				m_IsSearchEventCodeDefault = false;
			}
		}

		/// <summary>
		/*
		CurrentPage ComboBox para seleção do número da pagina
		*/
		/// </summary>
		public System.String CurrentPageCombo
		{
			get { return m_CurrentPageCombo; }
			set 
			{
				m_CurrentPageCombo = value;
				m_IsCurrentPageComboDefault = false;
			}
		}

		/// <summary>
		/*
		Define Sub para utilização neste objeto
		*/
		/// </summary>
		public System.String SubCode
		{
			get { return m_SubCode; }
			set 
			{
				m_SubCode = value;
				m_IsSubCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Define código para o Evento Start
		*/
		/// </summary>
		public System.String EventStart
		{
			get { return m_EventStart; }
			set 
			{
				m_EventStart = value;
				m_IsEventStartDefault = false;
			}
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Only Rules, Events and Conditions - Atualiza somente as regras, eventos e condições e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateObject
		{
			get { return m_UpdateObject; }
			set 
			{
				m_UpdateObject = value;
				m_IsUpdateObjectDefault = false;
			}
		}

		/// <summary>
		/*
		Use a custom user control for rendering grids. Applies to all selection and grid tab objects.
		*/
		/// </summary>
		public System.String CustomRender
		{
			get { return m_CustomRender; }
			set 
			{
				m_CustomRender = value;
				m_IsCustomRenderDefault = false;
			}
		}

		/// <summary>
		/*
		Define o metodo de chamada ao cadastro, Link ou Popup Modal
		*/
		/// </summary>
		public System.String CallMethod
		{
			get { return m_CallMethod; }
			set 
			{
				m_CallMethod = value;
				m_IsCallMethodDefault = false;
			}
		}

		/// <summary>
		/*
		Define o AutoResize para o Grid
		*/
		/// </summary>
		public System.String AutoResize
		{
			get { return m_AutoResize; }
			set 
			{
				m_AutoResize = value;
				m_IsAutoResizeDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width(tamanho horizontal) para o Grid
		*/
		/// </summary>
		public System.String Width
		{
			get { return m_Width; }
			set 
			{
				m_Width = value;
				m_IsWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Height(tamanho vertical) para o Grid
		*/
		/// </summary>
		public System.String Height
		{
			get { return m_Height; }
			set 
			{
				m_Height = value;
				m_IsHeightDefault = false;
			}
		}

		/// <summary>
		/*
		Define o AllowSelection para o Grid
		*/
		/// </summary>
		public System.String AllowSelection
		{
			get { return m_AllowSelection; }
			set 
			{
				m_AllowSelection = value;
				m_IsAllowSelectionDefault = false;
			}
		}

		public ModesElement Modes
		{
			get { return m_Modes; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Modes = value;
				m_Modes.Parent = this;
			}
		}

		public AttributesElement Attributes
		{
			get { return m_Attributes; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Attributes = value;
				m_Attributes.Parent = this;
			}
		}

		public ParametersElement Parameters
		{
			get { return m_Parameters; }
		}

		public OrdersElement Orders
		{
			get { return m_Orders; }
		}

		public FilterElement Filter
		{
			get { return m_Filter; }
			set
			{
				m_Filter = value;
				m_Filter.Parent = this;
			}
		}

		public ActionsElement Actions
		{
			get { return m_Actions; }
		}

		public GridPropertiesElement GridProperties
		{
			get { return m_GridProperties; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// </summary>
		public ParameterElement AddParameter()
		{
			ParameterElement parameterElement = new ParameterElement();
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// The ParameterElement is initialized with the specified value.
		/// </summary>
		public ParameterElement AddParameter(System.String name)
		{
			ParameterElement parameterElement = new ParameterElement(name);
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Finds the <see cref="ParameterElement"/> in the <see cref="Parameters"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no parameterElement is found, null is returned.
		/// </summary>
		public ParameterElement FindParameter(System.String name)
		{
			return Parameters.Find(delegate (ParameterElement parameterElement) { return parameterElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="OrderElement"/> and adds it to the <see cref="Orders"/> collection.
		/// </summary>
		public OrderElement AddOrder()
		{
			OrderElement orderElement = new OrderElement();
			m_Orders.Add(orderElement);
			return orderElement;
		}

		/// <summary>
		/// Creates a new <see cref="OrderElement"/> and adds it to the <see cref="Orders"/> collection.
		/// The OrderElement is initialized with the specified value.
		/// </summary>
		public OrderElement AddOrder(System.String name)
		{
			OrderElement orderElement = new OrderElement(name);
			m_Orders.Add(orderElement);
			return orderElement;
		}

		/// <summary>
		/// Finds the <see cref="OrderElement"/> in the <see cref="Orders"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no orderElement is found, null is returned.
		/// </summary>
		public OrderElement FindOrder(System.String name)
		{
			return Orders.Find(delegate (OrderElement orderElement) { return orderElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="ActionElement"/> and adds it to the <see cref="Actions"/> collection.
		/// </summary>
		public ActionElement AddAction()
		{
			ActionElement actionElement = new ActionElement();
			m_Actions.Add(actionElement);
			return actionElement;
		}

		/// <summary>
		/// Creates a new <see cref="ActionElement"/> and adds it to the <see cref="Actions"/> collection.
		/// The ActionElement is initialized with the specified value.
		/// </summary>
		public ActionElement AddAction(System.String name)
		{
			ActionElement actionElement = new ActionElement(name);
			m_Actions.Add(actionElement);
			return actionElement;
		}

		/// <summary>
		/// Finds the <see cref="ActionElement"/> in the <see cref="Actions"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no actionElement is found, null is returned.
		/// </summary>
		public ActionElement FindAction(System.String name)
		{
			return Actions.Find(delegate (ActionElement actionElement) { return actionElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="GridPropertieElement"/> and adds it to the <see cref="GridProperties"/> collection.
		/// </summary>
		public GridPropertieElement AddGridPropertie()
		{
			GridPropertieElement gridPropertieElement = new GridPropertieElement();
			m_GridProperties.Add(gridPropertieElement);
			return gridPropertieElement;
		}

		/// <summary>
		/// Creates a new <see cref="GridPropertieElement"/> and adds it to the <see cref="GridProperties"/> collection.
		/// The GridPropertieElement is initialized with the specified value.
		/// </summary>
		public GridPropertieElement AddGridPropertie(System.String name)
		{
			GridPropertieElement gridPropertieElement = new GridPropertieElement(name);
			m_GridProperties.Add(gridPropertieElement);
			return gridPropertieElement;
		}

		/// <summary>
		/// Finds the <see cref="GridPropertieElement"/> in the <see cref="GridProperties"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridPropertieElement is found, null is returned.
		/// </summary>
		public GridPropertieElement FindGridPropertie(System.String name)
		{
			return GridProperties.Find(delegate (GridPropertieElement gridPropertieElement) { return gridPropertieElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="PromptElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Prompt")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Prompt"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Caption = element.Attributes.GetPropertyValue<System.String>("caption");
			m_IsCaptionDefault = element.Attributes.IsPropertyDefault("caption");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");
			m_Page = element.Attributes.GetPropertyValue<System.String>("page");
			m_IsPageDefault = element.Attributes.IsPropertyDefault("page");
			m_IsMain = element.Attributes.GetPropertyValue<System.Boolean>("isMain");
			m_IsIsMainDefault = element.Attributes.IsPropertyDefault("isMain");
			m_MasterPage = element.Attributes.GetPropertyValue<System.String>("masterPage");
			m_IsMasterPageDefault = element.Attributes.IsPropertyDefault("masterPage");
			m_LoadOnStart = element.Attributes.GetPropertyValue<System.String>("loadOnStart");
			m_IsLoadOnStartDefault = element.Attributes.IsPropertyDefault("loadOnStart");
			m_RequiredFilter = element.Attributes.GetPropertyValue<System.String>("requiredFilter");
			m_IsRequiredFilterDefault = element.Attributes.IsPropertyDefault("requiredFilter");
			m_RequiredFilterMessage = element.Attributes.GetPropertyValue<System.String>("requiredFilterMessage");
			m_IsRequiredFilterMessageDefault = element.Attributes.IsPropertyDefault("requiredFilterMessage");
			m_AutomaticRefresh = element.Attributes.GetPropertyValue<System.String>("automaticRefresh");
			m_IsAutomaticRefreshDefault = element.Attributes.IsPropertyDefault("automaticRefresh");
			m_FilterCollapse = element.Attributes.GetPropertyValue<System.String>("filterCollapse");
			m_IsFilterCollapseDefault = element.Attributes.IsPropertyDefault("filterCollapse");
			m_FilterCollapseDefault = element.Attributes.GetPropertyValue<System.String>("filterCollapseDefault");
			m_IsFilterCollapseDefaultDefault = element.Attributes.IsPropertyDefault("filterCollapseDefault");
			m_SetFocus = element.Attributes.GetPropertyValue<System.String>("setFocus");
			m_IsSetFocusDefault = element.Attributes.IsPropertyDefault("setFocus");
			m_SetFocusAttribute = element.Attributes.GetPropertyValue<System.String>("setFocusAttribute");
			m_IsSetFocusAttributeDefault = element.Attributes.IsPropertyDefault("setFocusAttribute");
			m_ObjName = element.Attributes.GetPropertyValue<System.String>("objName");
			m_IsObjNameDefault = element.Attributes.IsPropertyDefault("objName");
			m_SearchEventCode = element.Attributes.GetPropertyValue<System.String>("SearchEventCode");
			m_IsSearchEventCodeDefault = element.Attributes.IsPropertyDefault("SearchEventCode");
			m_CurrentPageCombo = element.Attributes.GetPropertyValue<System.String>("CurrentPageCombo");
			m_IsCurrentPageComboDefault = element.Attributes.IsPropertyDefault("CurrentPageCombo");
			m_SubCode = element.Attributes.GetPropertyValue<System.String>("SubCode");
			m_IsSubCodeDefault = element.Attributes.IsPropertyDefault("SubCode");
			m_EventStart = element.Attributes.GetPropertyValue<System.String>("EventStart");
			m_IsEventStartDefault = element.Attributes.IsPropertyDefault("EventStart");
			m_UpdateObject = element.Attributes.GetPropertyValue<System.String>("updateObject");
			m_IsUpdateObjectDefault = element.Attributes.IsPropertyDefault("updateObject");
			m_CustomRender = element.Attributes.GetPropertyValue<System.String>("CustomRender");
			m_IsCustomRenderDefault = element.Attributes.IsPropertyDefault("CustomRender");
			m_CallMethod = element.Attributes.GetPropertyValue<System.String>("CallMethod");
			m_IsCallMethodDefault = element.Attributes.IsPropertyDefault("CallMethod");
			m_AutoResize = element.Attributes.GetPropertyValue<System.String>("AutoResize");
			m_IsAutoResizeDefault = element.Attributes.IsPropertyDefault("AutoResize");
			m_Width = element.Attributes.GetPropertyValue<System.String>("Width");
			m_IsWidthDefault = element.Attributes.IsPropertyDefault("Width");
			m_Height = element.Attributes.GetPropertyValue<System.String>("Height");
			m_IsHeightDefault = element.Attributes.IsPropertyDefault("Height");
			m_AllowSelection = element.Attributes.GetPropertyValue<System.String>("AllowSelection");
			m_IsAllowSelectionDefault = element.Attributes.IsPropertyDefault("AllowSelection");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "modes" :
					{
						ModesElement modes = new ModesElement();
						modes.LoadFrom(_childElement);
						Modes = modes;
						break;
					}
					case "attributes" :
					{
						AttributesElement attributes = new AttributesElement();
						attributes.LoadFrom(_childElement);
						Attributes = attributes;
						break;
					}
					case "parameters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ParameterElement parameterElement = new ParameterElement();
							parameterElement.LoadFrom(_childElementItem);
							Parameters.Add(parameterElement);
						}
						break;
					}
					case "orders" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							OrderElement orderElement = new OrderElement();
							orderElement.LoadFrom(_childElementItem);
							Orders.Add(orderElement);
						}
						break;
					}
					case "filter" :
					{
						FilterElement filter = new FilterElement();
						filter.LoadFrom(_childElement);
						Filter = filter;
						break;
					}
					case "actions" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ActionElement actionElement = new ActionElement();
							actionElement.LoadFrom(_childElementItem);
							Actions.Add(actionElement);
						}
						break;
					}
					case "GridProperties" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							GridPropertieElement gridPropertieElement = new GridPropertieElement();
							gridPropertieElement.LoadFrom(_childElementItem);
							GridProperties.Add(gridPropertieElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="PromptElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Prompt")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Prompt"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "caption", m_Caption, m_IsCaptionDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);
			SaveAttribute(element, "page", m_Page, m_IsPageDefault);
			SaveAttribute(element, "isMain", m_IsMain, m_IsIsMainDefault);
			SaveAttribute(element, "masterPage", m_MasterPage, m_IsMasterPageDefault);
			SaveAttribute(element, "loadOnStart", m_LoadOnStart, m_IsLoadOnStartDefault);
			SaveAttribute(element, "requiredFilter", m_RequiredFilter, m_IsRequiredFilterDefault);
			SaveAttribute(element, "requiredFilterMessage", m_RequiredFilterMessage, m_IsRequiredFilterMessageDefault);
			SaveAttribute(element, "automaticRefresh", m_AutomaticRefresh, m_IsAutomaticRefreshDefault);
			SaveAttribute(element, "filterCollapse", m_FilterCollapse, m_IsFilterCollapseDefault);
			SaveAttribute(element, "filterCollapseDefault", m_FilterCollapseDefault, m_IsFilterCollapseDefaultDefault);
			SaveAttribute(element, "setFocus", m_SetFocus, m_IsSetFocusDefault);
			SaveAttribute(element, "setFocusAttribute", m_SetFocusAttribute, m_IsSetFocusAttributeDefault);
			SaveAttribute(element, "objName", m_ObjName, m_IsObjNameDefault);
			SaveAttribute(element, "SearchEventCode", m_SearchEventCode, m_IsSearchEventCodeDefault);
			SaveAttribute(element, "CurrentPageCombo", m_CurrentPageCombo, m_IsCurrentPageComboDefault);
			SaveAttribute(element, "SubCode", m_SubCode, m_IsSubCodeDefault);
			SaveAttribute(element, "EventStart", m_EventStart, m_IsEventStartDefault);
			SaveAttribute(element, "updateObject", m_UpdateObject, m_IsUpdateObjectDefault);
			SaveAttribute(element, "CustomRender", m_CustomRender, m_IsCustomRenderDefault);
			SaveAttribute(element, "CallMethod", m_CallMethod, m_IsCallMethodDefault);
			SaveAttribute(element, "AutoResize", m_AutoResize, m_IsAutoResizeDefault);
			SaveAttribute(element, "Width", m_Width, m_IsWidthDefault);
			SaveAttribute(element, "Height", m_Height, m_IsHeightDefault);
			SaveAttribute(element, "AllowSelection", m_AllowSelection, m_IsAllowSelectionDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_Caption == element.Attributes.GetPropertyValue<System.String>("caption"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));
			Debug.Assert(m_Page == element.Attributes.GetPropertyValue<System.String>("page"));
			Debug.Assert(m_IsMain == element.Attributes.GetPropertyValue<System.Boolean>("isMain"));
			Debug.Assert(m_MasterPage == element.Attributes.GetPropertyValue<System.String>("masterPage"));
			Debug.Assert(m_LoadOnStart == element.Attributes.GetPropertyValue<System.String>("loadOnStart"));
			Debug.Assert(m_RequiredFilter == element.Attributes.GetPropertyValue<System.String>("requiredFilter"));
			Debug.Assert(m_RequiredFilterMessage == element.Attributes.GetPropertyValue<System.String>("requiredFilterMessage"));
			Debug.Assert(m_AutomaticRefresh == element.Attributes.GetPropertyValue<System.String>("automaticRefresh"));
			Debug.Assert(m_FilterCollapse == element.Attributes.GetPropertyValue<System.String>("filterCollapse"));
			Debug.Assert(m_FilterCollapseDefault == element.Attributes.GetPropertyValue<System.String>("filterCollapseDefault"));
			Debug.Assert(m_SetFocus == element.Attributes.GetPropertyValue<System.String>("setFocus"));
			Debug.Assert(m_SetFocusAttribute == element.Attributes.GetPropertyValue<System.String>("setFocusAttribute"));
			Debug.Assert(m_ObjName == element.Attributes.GetPropertyValue<System.String>("objName"));
			Debug.Assert(m_SearchEventCode == element.Attributes.GetPropertyValue<System.String>("SearchEventCode"));
			Debug.Assert(m_CurrentPageCombo == element.Attributes.GetPropertyValue<System.String>("CurrentPageCombo"));
			Debug.Assert(m_SubCode == element.Attributes.GetPropertyValue<System.String>("SubCode"));
			Debug.Assert(m_EventStart == element.Attributes.GetPropertyValue<System.String>("EventStart"));
			Debug.Assert(m_UpdateObject == element.Attributes.GetPropertyValue<System.String>("updateObject"));
			Debug.Assert(m_CallMethod == element.Attributes.GetPropertyValue<System.String>("CallMethod"));
			Debug.Assert(m_AutoResize == element.Attributes.GetPropertyValue<System.String>("AutoResize"));
			Debug.Assert(m_Width == element.Attributes.GetPropertyValue<System.String>("Width"));
			Debug.Assert(m_Height == element.Attributes.GetPropertyValue<System.String>("Height"));
			Debug.Assert(m_AllowSelection == element.Attributes.GetPropertyValue<System.String>("AllowSelection"));

			// Save element children.
			if (m_Modes != null)
			{
				PatternInstanceElement modes = element.Children["modes"];
				m_Modes.SaveTo(modes);
			}

			if (m_Attributes != null)
			{
				PatternInstanceElement attributes = element.Children["attributes"];
				m_Attributes.SaveTo(attributes);
			}

			if (m_Parameters != null)
			{
				if (m_Parameters.Count > 0)
					element.Children.AddNewElement("parameters");

				foreach (ParameterElement _item in Parameters)
				{
					PatternInstanceElement child = element.Children["parameters"].Children.AddNewElement("parameter");
					_item.SaveTo(child);
				}
			}

			if (m_Orders != null)
			{
				if (m_Orders.Count > 0)
					element.Children.AddNewElement("orders");

				foreach (OrderElement _item in Orders)
				{
					PatternInstanceElement child = element.Children["orders"].Children.AddNewElement("order");
					_item.SaveTo(child);
				}
			}

			if (m_Filter != null)
			{
				PatternInstanceElement filter = element.Children.AddNewElement("filter");
				m_Filter.SaveTo(filter);
			}

			if (m_Actions != null)
			{
				if (m_Actions.Count > 0)
					element.Children.AddNewElement("actions");

				foreach (ActionElement _item in Actions)
				{
					PatternInstanceElement child = element.Children["actions"].Children.AddNewElement("action");
					_item.SaveTo(child);
				}
			}

			if (m_GridProperties != null)
			{
				if (m_GridProperties.Count > 0)
					element.Children.AddNewElement("GridProperties");

				foreach (GridPropertieElement _item in GridProperties)
				{
					PatternInstanceElement child = element.Children["GridProperties"].Children.AddNewElement("GridPropertie");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="PromptElement"/>.
		/// </summary>
		public PromptElement Clone()
		{
			PromptElement clone = new PromptElement();

			clone.Name = this.Name;
			clone.Caption = this.Caption;
			clone.Description = this.Description;
			clone.Page = this.Page;
			clone.IsMain = this.IsMain;
			clone.MasterPage = this.MasterPage;
			clone.LoadOnStart = this.LoadOnStart;
			clone.RequiredFilter = this.RequiredFilter;
			clone.RequiredFilterMessage = this.RequiredFilterMessage;
			clone.AutomaticRefresh = this.AutomaticRefresh;
			clone.FilterCollapse = this.FilterCollapse;
			clone.FilterCollapseDefault = this.FilterCollapseDefault;
			clone.SetFocus = this.SetFocus;
			clone.SetFocusAttribute = this.SetFocusAttribute;
			clone.ObjName = this.ObjName;
			clone.SearchEventCode = this.SearchEventCode;
			clone.CurrentPageCombo = this.CurrentPageCombo;
			clone.SubCode = this.SubCode;
			clone.EventStart = this.EventStart;
			clone.UpdateObject = this.UpdateObject;
			clone.CustomRender = this.CustomRender;
			clone.CallMethod = this.CallMethod;
			clone.AutoResize = this.AutoResize;
			clone.Width = this.Width;
			clone.Height = this.Height;
			clone.AllowSelection = this.AllowSelection;
			clone.Modes = this.Modes.Clone();
			clone.Attributes = this.Attributes.Clone();
			foreach (ParameterElement parameterElement in this.Parameters)
				clone.Parameters.Add(parameterElement.Clone());
			foreach (OrderElement orderElement in this.Orders)
				clone.Orders.Add(orderElement.Clone());
			if (Filter != null)
				clone.Filter = this.Filter.Clone();
			foreach (ActionElement actionElement in this.Actions)
				clone.Actions.Add(actionElement.Clone());
			foreach (GridPropertieElement gridPropertieElement in this.GridProperties)
				clone.GridProperties.Add(gridPropertieElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "modes" :
				{
					if (Modes != null)
						return Modes.GetElement(path);
					else
						return null;
				}
				case "attributes" :
				{
					if (Attributes != null)
						return Attributes.GetElement(path);
					else
						return null;
				}
				case "parameters" :
				{
					if (path.Count == 0)
						return Parameters;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "parameter")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Parameters != null && itemIndex >= 0 && itemIndex < Parameters.Count)
						return Parameters[itemIndex].GetElement(path);
					else
						return null;
				}
				case "orders" :
				{
					if (path.Count == 0)
						return Orders;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "order")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Orders != null && itemIndex >= 0 && itemIndex < Orders.Count)
						return Orders[itemIndex].GetElement(path);
					else
						return null;
				}
				case "filter" :
				{
					if (Filter != null)
						return Filter.GetElement(path);
					else
						return null;
				}
				case "actions" :
				{
					if (path.Count == 0)
						return Actions;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "action")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Actions != null && itemIndex >= 0 && itemIndex < Actions.Count)
						return Actions[itemIndex].GetElement(path);
					else
						return null;
				}
				case "GridProperties" :
				{
					if (path.Count == 0)
						return GridProperties;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "GridPropertie")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (GridProperties != null && itemIndex >= 0 && itemIndex < GridProperties.Count)
						return GridProperties[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Page"/> property.
		/// </summary>
		public static class PageValue
		{
			public const string Default = "<default>";
			public const string Unlimited = "<unlimited>";
		}

		/// <summary>
		/// Possible values for the <see cref="MasterPage"/> property.
		/// </summary>
		public static class MasterPageValue
		{
			public const string Default = "<default>";
			public const string None = "<none>";
		}

		/// <summary>
		/// Possible values for the <see cref="LoadOnStart"/> property.
		/// </summary>
		public static class LoadOnStartValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="RequiredFilter"/> property.
		/// </summary>
		public static class RequiredFilterValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="RequiredFilterMessage"/> property.
		/// </summary>
		public static class RequiredFilterMessageValue
		{
			public const string Default = "<default>";
		}

		/// <summary>
		/// Possible values for the <see cref="AutomaticRefresh"/> property.
		/// </summary>
		public static class AutomaticRefreshValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="FilterCollapse"/> property.
		/// </summary>
		public static class FilterCollapseValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="FilterCollapseDefault"/> property.
		/// </summary>
		public static class FilterCollapseDefaultValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="SetFocus"/> property.
		/// </summary>
		public static class SetFocusValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="CurrentPageCombo"/> property.
		/// </summary>
		public static class CurrentPageComboValue
		{
			public const string Default = "default";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateObject"/> property.
		/// </summary>
		public static class UpdateObjectValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string OnlyRulesEventsAndConditions = "Only Rules, Events and Conditions";
			public const string Overwrite = "Overwrite";
		}

		/// <summary>
		/// Possible values for the <see cref="CallMethod"/> property.
		/// </summary>
		public static class CallMethodValue
		{
			public const string Default = "default";
			public const string Link = "Link";
			public const string Popup = "Popup";
		}

		/// <summary>
		/// Possible values for the <see cref="AutoResize"/> property.
		/// </summary>
		public static class AutoResizeValue
		{
			public const string Default = "default";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="AllowSelection"/> property.
		/// </summary>
		public static class AllowSelectionValue
		{
			public const string Default = "default";
			public const string True = "true";
			public const string False = "false";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Prompt ({0})", Description);
		}

		#endregion
	}

	#endregion

	#region Element: Tab

	public partial class TabElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Code;
		private bool m_IsCodeDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private System.String m_Wcname;
		private bool m_IsWcnameDefault;
		private System.String m_Page;
		private bool m_IsPageDefault;
		private System.String m_Type;
		private bool m_IsTypeDefault;
		private System.String m_Condition;
		private bool m_IsConditionDefault;
		private System.String m_ObjName;
		private bool m_IsObjNameDefault;
		private System.String m_ListNotNullTabGrid;
		private bool m_IsListNotNullTabGridDefault;
		private System.String m_ListNotNullMessage;
		private bool m_IsListNotNullMessageDefault;
		private System.String m_ListNotNullCondition;
		private bool m_IsListNotNullConditionDefault;
		private System.String m_CurrentPageCombo;
		private bool m_IsCurrentPageComboDefault;
		private System.String m_SubCode;
		private bool m_IsSubCodeDefault;
		private System.String m_CallMethod;
		private bool m_IsCallMethodDefault;
		private System.String m_AfterInsert;
		private bool m_IsAfterInsertDefault;
		private System.String m_EventStart;
		private bool m_IsEventStartDefault;
		private System.String m_UpdateObject;
		private bool m_IsUpdateObjectDefault;
		private System.String m_UpdateExport;
		private bool m_IsUpdateExportDefault;
		private System.String m_UpdateSDT;
		private bool m_IsUpdateSDTDefault;
		private System.String m_CustomRender;
		private bool m_IsCustomRenderDefault;
		private System.String m_Group;
		private bool m_IsGroupDefault;
		private Artech.Genexus.Common.Objects.Image m_Image;
		private KBObjectReference m_ImageReference;
		private bool m_IsImageDefault;
		private System.String m_AutoResize;
		private bool m_IsAutoResizeDefault;
		private System.String m_Width;
		private bool m_IsWidthDefault;
		private System.String m_Height;
		private bool m_IsHeightDefault;
		private System.String m_AllowSelection;
		private bool m_IsAllowSelectionDefault;
		private ParametersElement m_Parameters;
		private TransactionElement m_Transaction;
		private ModesElement m_Modes;
		private AttributesElement m_Attributes;
		private OrdersElement m_Orders;
		private FilterElement m_Filter;
		private ActionsElement m_Actions;
		private GridPropertiesElement m_GridProperties;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="TabElement"/> class.
		/// </summary>
		public TabElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TabElement"/> class, setting its <see cref="Code"/> property to the specified value.
		/// </summary>
		public TabElement(System.String code)
		{
			Initialize();
			Code = code;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="TabElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Code = "";
			m_IsCodeDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_Wcname = "";
			m_IsWcnameDefault = true;
			m_Page = "<default>";
			m_IsPageDefault = true;
			m_Type = "Grid";
			m_IsTypeDefault = true;
			m_Condition = "";
			m_IsConditionDefault = true;
			m_ObjName = "";
			m_IsObjNameDefault = true;
			m_ListNotNullTabGrid = "default";
			m_IsListNotNullTabGridDefault = true;
			m_ListNotNullMessage = "default";
			m_IsListNotNullMessageDefault = true;
			m_ListNotNullCondition = "";
			m_IsListNotNullConditionDefault = true;
			m_CurrentPageCombo = "default";
			m_IsCurrentPageComboDefault = true;
			m_SubCode = "";
			m_IsSubCodeDefault = true;
			m_CallMethod = "default";
			m_IsCallMethodDefault = true;
			m_AfterInsert = "<default>";
			m_IsAfterInsertDefault = true;
			m_EventStart = "";
			m_IsEventStartDefault = true;
			m_UpdateObject = "Create default";
			m_IsUpdateObjectDefault = true;
			m_UpdateExport = "Create default";
			m_IsUpdateExportDefault = true;
			m_UpdateSDT = "Create default";
			m_IsUpdateSDTDefault = true;
			m_CustomRender = "<default>";
			m_IsCustomRenderDefault = true;
			m_Group = null;
			m_IsGroupDefault = true;
			m_Image = null;
			m_ImageReference = null;
			m_IsImageDefault = true;
			m_AutoResize = "default";
			m_IsAutoResizeDefault = true;
			m_Width = "";
			m_IsWidthDefault = true;
			m_Height = "";
			m_IsHeightDefault = true;
			m_AllowSelection = "default";
			m_IsAllowSelectionDefault = true;
			m_Parameters = new ParametersElement();
			m_Parameters.Parent = this;
			m_Parameters.ElementName = "parameters";
			m_Transaction = null;
			m_Modes = null;
			m_Attributes = null;
			m_Orders = new OrdersElement();
			m_Orders.Parent = this;
			m_Orders.ElementName = "orders";
			m_Filter = null;
			m_Actions = new ActionsElement();
			m_Actions.Parent = this;
			m_Actions.ElementName = "actions";
			m_GridProperties = new GridPropertiesElement();
			m_GridProperties.Parent = this;
			m_GridProperties.ElementName = "GridProperties";
		}

		#endregion

		#region Properties

		private ViewElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="TabElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public ViewElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Literal to appear inside the Tab.
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Internal name. Must be unique.
		*/
		/// </summary>
		public System.String Code
		{
			get { return m_Code; }
			set 
			{
				m_Code = value;
				m_IsCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Tab description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Component Name.
		*/
		/// </summary>
		public System.String Wcname
		{
			get { return m_Wcname; }
			set 
			{
				m_Wcname = value;
				m_IsWcnameDefault = false;
			}
		}

		/// <summary>
		/*
		Number of rows in the grid per page (only for Grid type).
		*/
		/// </summary>
		public System.String Page
		{
			get { return m_Page; }
			set 
			{
				m_Page = value;
				m_IsPageDefault = false;
			}
		}

		/// <summary>
		/*
		Type of component
		*/
		/// </summary>
		public System.String Type
		{
			get { return m_Type; }
			set 
			{
				m_Type = value;
				m_IsTypeDefault = false;
			}
		}

		/// <summary>
		/*
		Condition to determine whether the Tab will be shown.
		*/
		/// </summary>
		public System.String Condition
		{
			get { return m_Condition; }
			set 
			{
				m_Condition = value;
				m_IsConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Object Name
		*/
		/// </summary>
		public System.String ObjName
		{
			get { return m_ObjName; }
			set 
			{
				m_ObjName = value;
				m_IsObjNameDefault = false;
			}
		}

		/// <summary>
		/*
		Não permite quantidade de itens em branco na Aba com Grid do WebPanel com BC
		*/
		/// </summary>
		public System.String ListNotNullTabGrid
		{
			get { return m_ListNotNullTabGrid; }
			set 
			{
				m_ListNotNullTabGrid = value;
				m_IsListNotNullTabGridDefault = false;
			}
		}

		/// <summary>
		/*
		ListNotNullTabGrid Mensagem, coringa {0} define a descrição da aba
		*/
		/// </summary>
		public System.String ListNotNullMessage
		{
			get { return m_ListNotNullMessage; }
			set 
			{
				m_ListNotNullMessage = value;
				m_IsListNotNullMessageDefault = false;
			}
		}

		/// <summary>
		/*
		Define Condição para verificar a quantidade de itens no item, se não informado o padrão é 'not temItens', coringa {0} é a variavel SDT do primeiro nivel
		*/
		/// </summary>
		public System.String ListNotNullCondition
		{
			get { return m_ListNotNullCondition; }
			set 
			{
				m_ListNotNullCondition = value;
				m_IsListNotNullConditionDefault = false;
			}
		}

		/// <summary>
		/*
		CurrentPage ComboBox para seleção do número da pagina
		*/
		/// </summary>
		public System.String CurrentPageCombo
		{
			get { return m_CurrentPageCombo; }
			set 
			{
				m_CurrentPageCombo = value;
				m_IsCurrentPageComboDefault = false;
			}
		}

		/// <summary>
		/*
		Define Sub para utilização neste objeto
		*/
		/// </summary>
		public System.String SubCode
		{
			get { return m_SubCode; }
			set 
			{
				m_SubCode = value;
				m_IsSubCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Define o metodo de chamada ao cadastro, Link ou Popup Modal
		*/
		/// </summary>
		public System.String CallMethod
		{
			get { return m_CallMethod; }
			set 
			{
				m_CallMethod = value;
				m_IsCallMethodDefault = false;
			}
		}

		/// <summary>
		/*
		Action performed after inserting a record.
		/// &lt;default&gt; uses configuration file value.
		*/
		/// </summary>
		public System.String AfterInsert
		{
			get { return m_AfterInsert; }
			set 
			{
				m_AfterInsert = value;
				m_IsAfterInsertDefault = false;
			}
		}

		/// <summary>
		/*
		Define código para o Evento Start
		*/
		/// </summary>
		public System.String EventStart
		{
			get { return m_EventStart; }
			set 
			{
				m_EventStart = value;
				m_IsEventStartDefault = false;
			}
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Only Rules, Events and Conditions - Atualiza somente as regras, eventos e condições e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateObject
		{
			get { return m_UpdateObject; }
			set 
			{
				m_UpdateObject = value;
				m_IsUpdateObjectDefault = false;
			}
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateExport
		{
			get { return m_UpdateExport; }
			set 
			{
				m_UpdateExport = value;
				m_IsUpdateExportDefault = false;
			}
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateSDT
		{
			get { return m_UpdateSDT; }
			set 
			{
				m_UpdateSDT = value;
				m_IsUpdateSDTDefault = false;
			}
		}

		/// <summary>
		/*
		Use a custom user control for rendering grids. Applies to all selection and grid tab objects.
		*/
		/// </summary>
		public System.String CustomRender
		{
			get { return m_CustomRender; }
			set 
			{
				m_CustomRender = value;
				m_IsCustomRenderDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Grupo da Aba
		*/
		/// </summary>
		public System.String Group
		{
			get { return m_Group; }
			set 
			{
				m_Group = value;
				m_IsGroupDefault = false;
			}
		}

		/// <summary>
		/*
		Define o icone
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image Image
		{
			get
			{
				if (m_Image == null && m_ImageReference != null)
					m_Image = (Artech.Genexus.Common.Objects.Image)m_ImageReference.GetKBObject(Instance.Model);

				return m_Image;
			}

			set 
			{
				m_Image = value;
				m_ImageReference = (value != null ? new KBObjectReference(value) : null);
				m_IsImageDefault = false;
			}
		}

		/// <summary>
		/// Image name.
		/// </summary>
		public string ImageName
		{
			get { return (Image != null ? Image.Name : null); }
		}

		/// <summary>
		/*
		Define o AutoResize para o Grid
		*/
		/// </summary>
		public System.String AutoResize
		{
			get { return m_AutoResize; }
			set 
			{
				m_AutoResize = value;
				m_IsAutoResizeDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width(tamanho horizontal) para o Grid
		*/
		/// </summary>
		public System.String Width
		{
			get { return m_Width; }
			set 
			{
				m_Width = value;
				m_IsWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Height(tamanho vertical) para o Grid
		*/
		/// </summary>
		public System.String Height
		{
			get { return m_Height; }
			set 
			{
				m_Height = value;
				m_IsHeightDefault = false;
			}
		}

		/// <summary>
		/*
		Define o AllowSelection para o Grid
		*/
		/// </summary>
		public System.String AllowSelection
		{
			get { return m_AllowSelection; }
			set 
			{
				m_AllowSelection = value;
				m_IsAllowSelectionDefault = false;
			}
		}

		public ParametersElement Parameters
		{
			get { return m_Parameters; }
		}

		public TransactionElement Transaction
		{
			get { return m_Transaction; }
			set
			{
				m_Transaction = value;
				m_Transaction.Parent = this;
			}
		}

		public ModesElement Modes
		{
			get { return m_Modes; }
			set
			{
				m_Modes = value;
				m_Modes.Parent = this;
			}
		}

		public AttributesElement Attributes
		{
			get { return m_Attributes; }
			set
			{
				m_Attributes = value;
				m_Attributes.Parent = this;
			}
		}

		public OrdersElement Orders
		{
			get { return m_Orders; }
		}

		public FilterElement Filter
		{
			get { return m_Filter; }
			set
			{
				m_Filter = value;
				m_Filter.Parent = this;
			}
		}

		public ActionsElement Actions
		{
			get { return m_Actions; }
		}

		public GridPropertiesElement GridProperties
		{
			get { return m_GridProperties; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// </summary>
		public ParameterElement AddParameter()
		{
			ParameterElement parameterElement = new ParameterElement();
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// The ParameterElement is initialized with the specified value.
		/// </summary>
		public ParameterElement AddParameter(System.String name)
		{
			ParameterElement parameterElement = new ParameterElement(name);
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Finds the <see cref="ParameterElement"/> in the <see cref="Parameters"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no parameterElement is found, null is returned.
		/// </summary>
		public ParameterElement FindParameter(System.String name)
		{
			return Parameters.Find(delegate (ParameterElement parameterElement) { return parameterElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="OrderElement"/> and adds it to the <see cref="Orders"/> collection.
		/// </summary>
		public OrderElement AddOrder()
		{
			OrderElement orderElement = new OrderElement();
			m_Orders.Add(orderElement);
			return orderElement;
		}

		/// <summary>
		/// Creates a new <see cref="OrderElement"/> and adds it to the <see cref="Orders"/> collection.
		/// The OrderElement is initialized with the specified value.
		/// </summary>
		public OrderElement AddOrder(System.String name)
		{
			OrderElement orderElement = new OrderElement(name);
			m_Orders.Add(orderElement);
			return orderElement;
		}

		/// <summary>
		/// Finds the <see cref="OrderElement"/> in the <see cref="Orders"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no orderElement is found, null is returned.
		/// </summary>
		public OrderElement FindOrder(System.String name)
		{
			return Orders.Find(delegate (OrderElement orderElement) { return orderElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="ActionElement"/> and adds it to the <see cref="Actions"/> collection.
		/// </summary>
		public ActionElement AddAction()
		{
			ActionElement actionElement = new ActionElement();
			m_Actions.Add(actionElement);
			return actionElement;
		}

		/// <summary>
		/// Creates a new <see cref="ActionElement"/> and adds it to the <see cref="Actions"/> collection.
		/// The ActionElement is initialized with the specified value.
		/// </summary>
		public ActionElement AddAction(System.String name)
		{
			ActionElement actionElement = new ActionElement(name);
			m_Actions.Add(actionElement);
			return actionElement;
		}

		/// <summary>
		/// Finds the <see cref="ActionElement"/> in the <see cref="Actions"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no actionElement is found, null is returned.
		/// </summary>
		public ActionElement FindAction(System.String name)
		{
			return Actions.Find(delegate (ActionElement actionElement) { return actionElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="GridPropertieElement"/> and adds it to the <see cref="GridProperties"/> collection.
		/// </summary>
		public GridPropertieElement AddGridPropertie()
		{
			GridPropertieElement gridPropertieElement = new GridPropertieElement();
			m_GridProperties.Add(gridPropertieElement);
			return gridPropertieElement;
		}

		/// <summary>
		/// Creates a new <see cref="GridPropertieElement"/> and adds it to the <see cref="GridProperties"/> collection.
		/// The GridPropertieElement is initialized with the specified value.
		/// </summary>
		public GridPropertieElement AddGridPropertie(System.String name)
		{
			GridPropertieElement gridPropertieElement = new GridPropertieElement(name);
			m_GridProperties.Add(gridPropertieElement);
			return gridPropertieElement;
		}

		/// <summary>
		/// Finds the <see cref="GridPropertieElement"/> in the <see cref="GridProperties"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridPropertieElement is found, null is returned.
		/// </summary>
		public GridPropertieElement FindGridPropertie(System.String name)
		{
			return GridProperties.Find(delegate (GridPropertieElement gridPropertieElement) { return gridPropertieElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="TabElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Tab")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Tab"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Code = element.Attributes.GetPropertyValue<System.String>("code");
			m_IsCodeDefault = element.Attributes.IsPropertyDefault("code");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");
			m_Wcname = element.Attributes.GetPropertyValue<System.String>("wcname");
			m_IsWcnameDefault = element.Attributes.IsPropertyDefault("wcname");
			m_Page = element.Attributes.GetPropertyValue<System.String>("page");
			m_IsPageDefault = element.Attributes.IsPropertyDefault("page");
			m_Type = element.Attributes.GetPropertyValue<System.String>("type");
			m_IsTypeDefault = element.Attributes.IsPropertyDefault("type");
			m_Condition = element.Attributes.GetPropertyValue<System.String>("condition");
			m_IsConditionDefault = element.Attributes.IsPropertyDefault("condition");
			m_ObjName = element.Attributes.GetPropertyValue<System.String>("objName");
			m_IsObjNameDefault = element.Attributes.IsPropertyDefault("objName");
			m_ListNotNullTabGrid = element.Attributes.GetPropertyValue<System.String>("listNotNullTabGrid");
			m_IsListNotNullTabGridDefault = element.Attributes.IsPropertyDefault("listNotNullTabGrid");
			m_ListNotNullMessage = element.Attributes.GetPropertyValue<System.String>("listNotNullMessage");
			m_IsListNotNullMessageDefault = element.Attributes.IsPropertyDefault("listNotNullMessage");
			m_ListNotNullCondition = element.Attributes.GetPropertyValue<System.String>("listNotNullCondition");
			m_IsListNotNullConditionDefault = element.Attributes.IsPropertyDefault("listNotNullCondition");
			m_CurrentPageCombo = element.Attributes.GetPropertyValue<System.String>("CurrentPageCombo");
			m_IsCurrentPageComboDefault = element.Attributes.IsPropertyDefault("CurrentPageCombo");
			m_SubCode = element.Attributes.GetPropertyValue<System.String>("SubCode");
			m_IsSubCodeDefault = element.Attributes.IsPropertyDefault("SubCode");
			m_CallMethod = element.Attributes.GetPropertyValue<System.String>("CallMethod");
			m_IsCallMethodDefault = element.Attributes.IsPropertyDefault("CallMethod");
			m_AfterInsert = element.Attributes.GetPropertyValue<System.String>("afterInsert");
			m_IsAfterInsertDefault = element.Attributes.IsPropertyDefault("afterInsert");
			m_EventStart = element.Attributes.GetPropertyValue<System.String>("EventStart");
			m_IsEventStartDefault = element.Attributes.IsPropertyDefault("EventStart");
			m_UpdateObject = element.Attributes.GetPropertyValue<System.String>("updateObject");
			m_IsUpdateObjectDefault = element.Attributes.IsPropertyDefault("updateObject");
			m_UpdateExport = element.Attributes.GetPropertyValue<System.String>("updateExport");
			m_IsUpdateExportDefault = element.Attributes.IsPropertyDefault("updateExport");
			m_UpdateSDT = element.Attributes.GetPropertyValue<System.String>("updateSDT");
			m_IsUpdateSDTDefault = element.Attributes.IsPropertyDefault("updateSDT");
			m_CustomRender = element.Attributes.GetPropertyValue<System.String>("CustomRender");
			m_IsCustomRenderDefault = element.Attributes.IsPropertyDefault("CustomRender");
			m_Group = element.Attributes.GetPropertyValue<System.String>("group");
			m_IsGroupDefault = element.Attributes.IsPropertyDefault("group");
			m_ImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("imageReference");
			m_IsImageDefault = element.Attributes.IsPropertyDefault("image");
			m_AutoResize = element.Attributes.GetPropertyValue<System.String>("AutoResize");
			m_IsAutoResizeDefault = element.Attributes.IsPropertyDefault("AutoResize");
			m_Width = element.Attributes.GetPropertyValue<System.String>("Width");
			m_IsWidthDefault = element.Attributes.IsPropertyDefault("Width");
			m_Height = element.Attributes.GetPropertyValue<System.String>("Height");
			m_IsHeightDefault = element.Attributes.IsPropertyDefault("Height");
			m_AllowSelection = element.Attributes.GetPropertyValue<System.String>("AllowSelection");
			m_IsAllowSelectionDefault = element.Attributes.IsPropertyDefault("AllowSelection");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "parameters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ParameterElement parameterElement = new ParameterElement();
							parameterElement.LoadFrom(_childElementItem);
							Parameters.Add(parameterElement);
						}
						break;
					}
					case "transaction" :
					{
						TransactionElement transaction = new TransactionElement();
						transaction.LoadFrom(_childElement);
						Transaction = transaction;
						break;
					}
					case "modes" :
					{
						ModesElement modes = new ModesElement();
						modes.LoadFrom(_childElement);
						Modes = modes;
						break;
					}
					case "attributes" :
					{
						AttributesElement attributes = new AttributesElement();
						attributes.LoadFrom(_childElement);
						Attributes = attributes;
						break;
					}
					case "orders" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							OrderElement orderElement = new OrderElement();
							orderElement.LoadFrom(_childElementItem);
							Orders.Add(orderElement);
						}
						break;
					}
					case "filter" :
					{
						FilterElement filter = new FilterElement();
						filter.LoadFrom(_childElement);
						Filter = filter;
						break;
					}
					case "actions" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ActionElement actionElement = new ActionElement();
							actionElement.LoadFrom(_childElementItem);
							Actions.Add(actionElement);
						}
						break;
					}
					case "GridProperties" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							GridPropertieElement gridPropertieElement = new GridPropertieElement();
							gridPropertieElement.LoadFrom(_childElementItem);
							GridProperties.Add(gridPropertieElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="TabElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Tab")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Tab"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "code", m_Code, m_IsCodeDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);
			SaveAttribute(element, "wcname", m_Wcname, m_IsWcnameDefault);
			SaveAttribute(element, "page", m_Page, m_IsPageDefault);
			SaveAttribute(element, "type", m_Type, m_IsTypeDefault);
			SaveAttribute(element, "condition", m_Condition, m_IsConditionDefault);
			SaveAttribute(element, "objName", m_ObjName, m_IsObjNameDefault);
			SaveAttribute(element, "listNotNullTabGrid", m_ListNotNullTabGrid, m_IsListNotNullTabGridDefault);
			SaveAttribute(element, "listNotNullMessage", m_ListNotNullMessage, m_IsListNotNullMessageDefault);
			SaveAttribute(element, "listNotNullCondition", m_ListNotNullCondition, m_IsListNotNullConditionDefault);
			SaveAttribute(element, "CurrentPageCombo", m_CurrentPageCombo, m_IsCurrentPageComboDefault);
			SaveAttribute(element, "SubCode", m_SubCode, m_IsSubCodeDefault);
			SaveAttribute(element, "CallMethod", m_CallMethod, m_IsCallMethodDefault);
			SaveAttribute(element, "afterInsert", m_AfterInsert, m_IsAfterInsertDefault);
			SaveAttribute(element, "EventStart", m_EventStart, m_IsEventStartDefault);
			SaveAttribute(element, "updateObject", m_UpdateObject, m_IsUpdateObjectDefault);
			SaveAttribute(element, "updateExport", m_UpdateExport, m_IsUpdateExportDefault);
			SaveAttribute(element, "updateSDT", m_UpdateSDT, m_IsUpdateSDTDefault);
			SaveAttribute(element, "CustomRender", m_CustomRender, m_IsCustomRenderDefault);
			SaveAttribute(element, "group", m_Group, m_IsGroupDefault);
			SaveAttribute(element, "imageReference", m_ImageReference, m_IsImageDefault);
			SaveAttribute(element, "AutoResize", m_AutoResize, m_IsAutoResizeDefault);
			SaveAttribute(element, "Width", m_Width, m_IsWidthDefault);
			SaveAttribute(element, "Height", m_Height, m_IsHeightDefault);
			SaveAttribute(element, "AllowSelection", m_AllowSelection, m_IsAllowSelectionDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_Code == element.Attributes.GetPropertyValue<System.String>("code"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));
			Debug.Assert(m_Wcname == element.Attributes.GetPropertyValue<System.String>("wcname"));
			Debug.Assert(m_Page == element.Attributes.GetPropertyValue<System.String>("page"));
			Debug.Assert(m_Type == element.Attributes.GetPropertyValue<System.String>("type"));
			Debug.Assert(m_Condition == element.Attributes.GetPropertyValue<System.String>("condition"));
			Debug.Assert(m_ObjName == element.Attributes.GetPropertyValue<System.String>("objName"));
			Debug.Assert(m_ListNotNullTabGrid == element.Attributes.GetPropertyValue<System.String>("listNotNullTabGrid"));
			Debug.Assert(m_ListNotNullMessage == element.Attributes.GetPropertyValue<System.String>("listNotNullMessage"));
			Debug.Assert(m_ListNotNullCondition == element.Attributes.GetPropertyValue<System.String>("listNotNullCondition"));
			Debug.Assert(m_CurrentPageCombo == element.Attributes.GetPropertyValue<System.String>("CurrentPageCombo"));
			Debug.Assert(m_SubCode == element.Attributes.GetPropertyValue<System.String>("SubCode"));
			Debug.Assert(m_CallMethod == element.Attributes.GetPropertyValue<System.String>("CallMethod"));
			Debug.Assert(m_AfterInsert == element.Attributes.GetPropertyValue<System.String>("afterInsert"));
			Debug.Assert(m_EventStart == element.Attributes.GetPropertyValue<System.String>("EventStart"));
			Debug.Assert(m_UpdateObject == element.Attributes.GetPropertyValue<System.String>("updateObject"));
			Debug.Assert(m_UpdateExport == element.Attributes.GetPropertyValue<System.String>("updateExport"));
			Debug.Assert(m_UpdateSDT == element.Attributes.GetPropertyValue<System.String>("updateSDT"));
			Debug.Assert(m_ImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("imageReference"));
			Debug.Assert(m_AutoResize == element.Attributes.GetPropertyValue<System.String>("AutoResize"));
			Debug.Assert(m_Width == element.Attributes.GetPropertyValue<System.String>("Width"));
			Debug.Assert(m_Height == element.Attributes.GetPropertyValue<System.String>("Height"));
			Debug.Assert(m_AllowSelection == element.Attributes.GetPropertyValue<System.String>("AllowSelection"));

			// Save element children.
			if (m_Parameters != null)
			{
				if (m_Parameters.Count > 0)
					element.Children.AddNewElement("parameters");

				foreach (ParameterElement _item in Parameters)
				{
					PatternInstanceElement child = element.Children["parameters"].Children.AddNewElement("parameter");
					_item.SaveTo(child);
				}
			}

			if (m_Transaction != null)
			{
				PatternInstanceElement transaction = element.Children.AddNewElement("transaction");
				m_Transaction.SaveTo(transaction);
			}

			if (m_Modes != null)
			{
				PatternInstanceElement modes = element.Children.AddNewElement("modes");
				m_Modes.SaveTo(modes);
			}

			if (m_Attributes != null)
			{
				PatternInstanceElement attributes = element.Children.AddNewElement("attributes");
				m_Attributes.SaveTo(attributes);
			}

			if (m_Orders != null)
			{
				if (m_Orders.Count > 0)
					element.Children.AddNewElement("orders");

				foreach (OrderElement _item in Orders)
				{
					PatternInstanceElement child = element.Children["orders"].Children.AddNewElement("order");
					_item.SaveTo(child);
				}
			}

			if (m_Filter != null)
			{
				PatternInstanceElement filter = element.Children.AddNewElement("filter");
				m_Filter.SaveTo(filter);
			}

			if (m_Actions != null)
			{
				if (m_Actions.Count > 0)
					element.Children.AddNewElement("actions");

				foreach (ActionElement _item in Actions)
				{
					PatternInstanceElement child = element.Children["actions"].Children.AddNewElement("action");
					_item.SaveTo(child);
				}
			}

			if (m_GridProperties != null)
			{
				if (m_GridProperties.Count > 0)
					element.Children.AddNewElement("GridProperties");

				foreach (GridPropertieElement _item in GridProperties)
				{
					PatternInstanceElement child = element.Children["GridProperties"].Children.AddNewElement("GridPropertie");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="TabElement"/>.
		/// </summary>
		public TabElement Clone()
		{
			TabElement clone = new TabElement();

			clone.Name = this.Name;
			clone.Code = this.Code;
			clone.Description = this.Description;
			clone.Wcname = this.Wcname;
			clone.Page = this.Page;
			clone.Type = this.Type;
			clone.Condition = this.Condition;
			clone.ObjName = this.ObjName;
			clone.ListNotNullTabGrid = this.ListNotNullTabGrid;
			clone.ListNotNullMessage = this.ListNotNullMessage;
			clone.ListNotNullCondition = this.ListNotNullCondition;
			clone.CurrentPageCombo = this.CurrentPageCombo;
			clone.SubCode = this.SubCode;
			clone.CallMethod = this.CallMethod;
			clone.AfterInsert = this.AfterInsert;
			clone.EventStart = this.EventStart;
			clone.UpdateObject = this.UpdateObject;
			clone.UpdateExport = this.UpdateExport;
			clone.UpdateSDT = this.UpdateSDT;
			clone.CustomRender = this.CustomRender;
			clone.Group = this.Group;
			clone.Image = this.Image;
			clone.AutoResize = this.AutoResize;
			clone.Width = this.Width;
			clone.Height = this.Height;
			clone.AllowSelection = this.AllowSelection;
			foreach (ParameterElement parameterElement in this.Parameters)
				clone.Parameters.Add(parameterElement.Clone());
			if (Transaction != null)
				clone.Transaction = this.Transaction.Clone();
			if (Modes != null)
				clone.Modes = this.Modes.Clone();
			if (Attributes != null)
				clone.Attributes = this.Attributes.Clone();
			foreach (OrderElement orderElement in this.Orders)
				clone.Orders.Add(orderElement.Clone());
			if (Filter != null)
				clone.Filter = this.Filter.Clone();
			foreach (ActionElement actionElement in this.Actions)
				clone.Actions.Add(actionElement.Clone());
			foreach (GridPropertieElement gridPropertieElement in this.GridProperties)
				clone.GridProperties.Add(gridPropertieElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "parameters" :
				{
					if (path.Count == 0)
						return Parameters;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "parameter")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Parameters != null && itemIndex >= 0 && itemIndex < Parameters.Count)
						return Parameters[itemIndex].GetElement(path);
					else
						return null;
				}
				case "transaction" :
				{
					if (Transaction != null)
						return Transaction.GetElement(path);
					else
						return null;
				}
				case "modes" :
				{
					if (Modes != null)
						return Modes.GetElement(path);
					else
						return null;
				}
				case "attributes" :
				{
					if (Attributes != null)
						return Attributes.GetElement(path);
					else
						return null;
				}
				case "orders" :
				{
					if (path.Count == 0)
						return Orders;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "order")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Orders != null && itemIndex >= 0 && itemIndex < Orders.Count)
						return Orders[itemIndex].GetElement(path);
					else
						return null;
				}
				case "filter" :
				{
					if (Filter != null)
						return Filter.GetElement(path);
					else
						return null;
				}
				case "actions" :
				{
					if (path.Count == 0)
						return Actions;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "action")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Actions != null && itemIndex >= 0 && itemIndex < Actions.Count)
						return Actions[itemIndex].GetElement(path);
					else
						return null;
				}
				case "GridProperties" :
				{
					if (path.Count == 0)
						return GridProperties;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "GridPropertie")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (GridProperties != null && itemIndex >= 0 && itemIndex < GridProperties.Count)
						return GridProperties[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Page"/> property.
		/// </summary>
		public static class PageValue
		{
			public const string Default = "<default>";
			public const string Unlimited = "<unlimited>";
		}

		/// <summary>
		/// Possible values for the <see cref="Type"/> property.
		/// </summary>
		public static class TypeValue
		{
			public const string Grid = "Grid";
			public const string Tabular = "Tabular";
			public const string UserDefined = "UserDefined";
		}

		/// <summary>
		/// Possible values for the <see cref="ListNotNullTabGrid"/> property.
		/// </summary>
		public static class ListNotNullTabGridValue
		{
			public const string Default = "default";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="ListNotNullMessage"/> property.
		/// </summary>
		public static class ListNotNullMessageValue
		{
			public const string Default = "default";
		}

		/// <summary>
		/// Possible values for the <see cref="CurrentPageCombo"/> property.
		/// </summary>
		public static class CurrentPageComboValue
		{
			public const string Default = "default";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="CallMethod"/> property.
		/// </summary>
		public static class CallMethodValue
		{
			public const string Default = "default";
			public const string Link = "Link";
			public const string Popup = "Popup";
		}

		/// <summary>
		/// Possible values for the <see cref="AfterInsert"/> property.
		/// </summary>
		public static class AfterInsertValue
		{
			public const string Default = "<default>";
			public const string EnterInInsert = "EnterInInsert";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateObject"/> property.
		/// </summary>
		public static class UpdateObjectValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string OnlyRulesEventsAndConditions = "Only Rules, Events and Conditions";
			public const string Overwrite = "Overwrite";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateExport"/> property.
		/// </summary>
		public static class UpdateExportValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string Overwrite = "Overwrite";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateSDT"/> property.
		/// </summary>
		public static class UpdateSDTValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string Overwrite = "Overwrite";
		}

		/// <summary>
		/// Possible values for the <see cref="AutoResize"/> property.
		/// </summary>
		public static class AutoResizeValue
		{
			public const string Default = "default";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="AllowSelection"/> property.
		/// </summary>
		public static class AllowSelectionValue
		{
			public const string Default = "default";
			public const string True = "true";
			public const string False = "false";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Tab ({0})", Name);
		}

		#endregion
	}

	#endregion

	#region Element: Tabs

	public partial class TabsElement : Artech.Common.Collections.BaseCollection<TabElement>
	{
		protected string m_ElementName;

		#region Construction

		internal TabsElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<TabElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private ViewElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public ViewElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<TabElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of TabsElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="TabElement"/> in the collection that has the specified value in its <see cref="Code"/> property.
		/// If no Tab is found, <b>null</b> is returned.
		/// </summary>
		public TabElement FindTab(System.String code)
		{
			return this.Find(delegate (TabElement tabItem) { return tabItem.Code == code; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Tabs";
		}

		#endregion
	}

	#endregion

	#region Element: GroupTab

	public partial class GroupTabElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private Artech.Genexus.Common.Objects.Image m_Image;
		private KBObjectReference m_ImageReference;
		private bool m_IsImageDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="GroupTabElement"/> class.
		/// </summary>
		public GroupTabElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GroupTabElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public GroupTabElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="GroupTabElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Image = null;
			m_ImageReference = null;
			m_IsImageDefault = true;
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="GroupTabElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Define o nome do Grupo
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Define o icone
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image Image
		{
			get
			{
				if (m_Image == null && m_ImageReference != null)
					m_Image = (Artech.Genexus.Common.Objects.Image)m_ImageReference.GetKBObject(Instance.Model);

				return m_Image;
			}

			set 
			{
				m_Image = value;
				m_ImageReference = (value != null ? new KBObjectReference(value) : null);
				m_IsImageDefault = false;
			}
		}

		/// <summary>
		/// Image name.
		/// </summary>
		public string ImageName
		{
			get { return (Image != null ? Image.Name : null); }
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="GroupTabElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GroupTab")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "GroupTab"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_ImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("imageReference");
			m_IsImageDefault = element.Attributes.IsPropertyDefault("image");
		}

		/// <summary>
		/// Saves the current <see cref="GroupTabElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GroupTab")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "GroupTab"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "imageReference", m_ImageReference, m_IsImageDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_ImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("imageReference"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="GroupTabElement"/>.
		/// </summary>
		public GroupTabElement Clone()
		{
			GroupTabElement clone = new GroupTabElement();

			clone.Name = this.Name;
			clone.Image = this.Image;

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Group ({0})", Name);
		}

		#endregion
	}

	#endregion

	#region Element: Groups

	public partial class GroupsElement : Artech.Common.Collections.BaseCollection<GroupTabElement>
	{
		protected string m_ElementName;

		#region Construction

		internal GroupsElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<GroupTabElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<GroupTabElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of GroupsElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="GroupTabElement"/> in the collection that has the specified value in its <see cref="Name"/> property.
		/// If no GroupTab is found, <b>null</b> is returned.
		/// </summary>
		public GroupTabElement FindGroupTab(System.String name)
		{
			return this.Find(delegate (GroupTabElement groupTabItem) { return groupTabItem.Name == name; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Groups";
		}

		#endregion
	}

	#endregion

	#region Element: Transaction

	public partial class TransactionElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private Artech.Genexus.Common.Objects.Transaction m_Transaction;
		private KBObjectReference m_TransactionReference;
		private bool m_IsTransactionDefault;
		private System.String m_MasterPage;
		private bool m_IsMasterPageDefault;
		private System.String m_DataEntryWebPanelBC;
		private bool m_IsDataEntryWebPanelBCDefault;
		private System.String m_SetFocus;
		private bool m_IsSetFocusDefault;
		private Artech.Genexus.Common.Objects.Attribute m_SetFocusAttribute;
		private KBObjectReference m_SetFocusAttributeReference;
		private bool m_IsSetFocusAttributeDefault;
		private System.String m_ObjName;
		private bool m_IsObjNameDefault;
		private System.String m_EventStart;
		private bool m_IsEventStartDefault;
		private System.String m_BCSucessCode;
		private bool m_IsBCSucessCodeDefault;
		private System.String m_BCErrorCode;
		private bool m_IsBCErrorCodeDefault;
		private System.String m_UpdateObject;
		private bool m_IsUpdateObjectDefault;
		private System.String m_UpdateDataProviderAba;
		private bool m_IsUpdateDataProviderAbaDefault;
		private System.String m_UpdateSDTBC;
		private bool m_IsUpdateSDTBCDefault;
		private FormElement m_Form;
		private ParametersElement m_Parameters;
		private ActionsElement m_Actions;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="TransactionElement"/> class.
		/// </summary>
		public TransactionElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="TransactionElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Transaction = null;
			m_TransactionReference = null;
			m_IsTransactionDefault = true;
			m_MasterPage = "<default>";
			m_IsMasterPageDefault = true;
			m_DataEntryWebPanelBC = "<default>";
			m_IsDataEntryWebPanelBCDefault = true;
			m_SetFocus = "<default>";
			m_IsSetFocusDefault = true;
			m_SetFocusAttribute = null;
			m_SetFocusAttributeReference = null;
			m_IsSetFocusAttributeDefault = true;
			m_ObjName = "";
			m_IsObjNameDefault = true;
			m_EventStart = "";
			m_IsEventStartDefault = true;
			m_BCSucessCode = "";
			m_IsBCSucessCodeDefault = true;
			m_BCErrorCode = "";
			m_IsBCErrorCodeDefault = true;
			m_UpdateObject = "Create default";
			m_IsUpdateObjectDefault = true;
			m_UpdateDataProviderAba = "Create default";
			m_IsUpdateDataProviderAbaDefault = true;
			m_UpdateSDTBC = "Create default";
			m_IsUpdateSDTBCDefault = true;
			m_Form = new FormElement();
			m_Form.Parent = this;
			m_Parameters = new ParametersElement();
			m_Parameters.Parent = this;
			m_Parameters.ElementName = "parameters";
			m_Actions = new ActionsElement();
			m_Actions.Parent = this;
			m_Actions.ElementName = "actions";
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="TransactionElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Transaction Name.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Transaction Transaction
		{
			get
			{
				if (m_Transaction == null && m_TransactionReference != null)
					m_Transaction = (Artech.Genexus.Common.Objects.Transaction)m_TransactionReference.GetKBObject(Instance.Model);

				return m_Transaction;
			}

			set 
			{
				m_Transaction = value;
				m_TransactionReference = (value != null ? new KBObjectReference(value) : null);
				m_IsTransactionDefault = false;
			}
		}

		/// <summary>
		/// Transaction name.
		/// </summary>
		public string TransactionName
		{
			get { return (Transaction != null ? Transaction.Name : null); }
		}

		/// <summary>
		/*
		Object name of the master page to be used in this transaction.
		/// To use the one defined in the configuration file, set value to "&lt;default&gt;".
		/// To disable the master page, use "&lt;none&gt;".
		*/
		/// </summary>
		public System.String MasterPage
		{
			get { return m_MasterPage; }
			set 
			{
				m_MasterPage = value;
				m_IsMasterPageDefault = false;
			}
		}

		/// <summary>
		/*
		Utiliza WebPanel com BC para cadastro ou a transação
		*/
		/// </summary>
		public System.String DataEntryWebPanelBC
		{
			get { return m_DataEntryWebPanelBC; }
			set 
			{
				m_DataEntryWebPanelBC = value;
				m_IsDataEntryWebPanelBCDefault = false;
			}
		}

		/// <summary>
		/*
		Define Foco no primeiro atributo
		*/
		/// </summary>
		public System.String SetFocus
		{
			get { return m_SetFocus; }
			set 
			{
				m_SetFocus = value;
				m_IsSetFocusDefault = false;
			}
		}

		/// <summary>
		/*
		Define Foco no primeiro atributo de filtro
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Attribute SetFocusAttribute
		{
			get
			{
				if (m_SetFocusAttribute == null && m_SetFocusAttributeReference != null)
					m_SetFocusAttribute = (Artech.Genexus.Common.Objects.Attribute)m_SetFocusAttributeReference.GetKBObject(Instance.Model);

				return m_SetFocusAttribute;
			}

			set 
			{
				m_SetFocusAttribute = value;
				m_SetFocusAttributeReference = (value != null ? new KBObjectReference(value) : null);
				m_IsSetFocusAttributeDefault = false;
			}
		}

		/// <summary>
		/// SetFocusAttribute name.
		/// </summary>
		public string SetFocusAttributeName
		{
			get { return (SetFocusAttribute != null ? SetFocusAttribute.Name : null); }
		}

		/// <summary>
		/*
		Object Name
		*/
		/// </summary>
		public System.String ObjName
		{
			get { return m_ObjName; }
			set 
			{
				m_ObjName = value;
				m_IsObjNameDefault = false;
			}
		}

		/// <summary>
		/*
		Define código para o Evento Start
		*/
		/// </summary>
		public System.String EventStart
		{
			get { return m_EventStart; }
			set 
			{
				m_EventStart = value;
				m_IsEventStartDefault = false;
			}
		}

		/// <summary>
		/*
		Define Código para Evento quando o BC Salvar com sucesso
		*/
		/// </summary>
		public System.String BCSucessCode
		{
			get { return m_BCSucessCode; }
			set 
			{
				m_BCSucessCode = value;
				m_IsBCSucessCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Define Código para Evento quando o BC não Salvar e retornar erro
		*/
		/// </summary>
		public System.String BCErrorCode
		{
			get { return m_BCErrorCode; }
			set 
			{
				m_BCErrorCode = value;
				m_IsBCErrorCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Only Rules, Events and Conditions - Atualiza somente as regras, eventos e condições e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateObject
		{
			get { return m_UpdateObject; }
			set 
			{
				m_UpdateObject = value;
				m_IsUpdateObjectDefault = false;
			}
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateDataProviderAba
		{
			get { return m_UpdateDataProviderAba; }
			set 
			{
				m_UpdateDataProviderAba = value;
				m_IsUpdateDataProviderAbaDefault = false;
			}
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateSDTBC
		{
			get { return m_UpdateSDTBC; }
			set 
			{
				m_UpdateSDTBC = value;
				m_IsUpdateSDTBCDefault = false;
			}
		}

		public FormElement Form
		{
			get { return m_Form; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Form = value;
				m_Form.Parent = this;
			}
		}

		public ParametersElement Parameters
		{
			get { return m_Parameters; }
		}

		public ActionsElement Actions
		{
			get { return m_Actions; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// </summary>
		public ParameterElement AddParameter()
		{
			ParameterElement parameterElement = new ParameterElement();
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// The ParameterElement is initialized with the specified value.
		/// </summary>
		public ParameterElement AddParameter(System.String name)
		{
			ParameterElement parameterElement = new ParameterElement(name);
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Finds the <see cref="ParameterElement"/> in the <see cref="Parameters"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no parameterElement is found, null is returned.
		/// </summary>
		public ParameterElement FindParameter(System.String name)
		{
			return Parameters.Find(delegate (ParameterElement parameterElement) { return parameterElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="ActionElement"/> and adds it to the <see cref="Actions"/> collection.
		/// </summary>
		public ActionElement AddAction()
		{
			ActionElement actionElement = new ActionElement();
			m_Actions.Add(actionElement);
			return actionElement;
		}

		/// <summary>
		/// Creates a new <see cref="ActionElement"/> and adds it to the <see cref="Actions"/> collection.
		/// The ActionElement is initialized with the specified value.
		/// </summary>
		public ActionElement AddAction(System.String name)
		{
			ActionElement actionElement = new ActionElement(name);
			m_Actions.Add(actionElement);
			return actionElement;
		}

		/// <summary>
		/// Finds the <see cref="ActionElement"/> in the <see cref="Actions"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no actionElement is found, null is returned.
		/// </summary>
		public ActionElement FindAction(System.String name)
		{
			return Actions.Find(delegate (ActionElement actionElement) { return actionElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="TransactionElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Transaction")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Transaction"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_TransactionReference = element.Attributes.GetPropertyValue<KBObjectReference>("transactionReference");
			m_IsTransactionDefault = element.Attributes.IsPropertyDefault("transaction");
			m_MasterPage = element.Attributes.GetPropertyValue<System.String>("masterPage");
			m_IsMasterPageDefault = element.Attributes.IsPropertyDefault("masterPage");
			m_DataEntryWebPanelBC = element.Attributes.GetPropertyValue<System.String>("dataEntryWebPanelBC");
			m_IsDataEntryWebPanelBCDefault = element.Attributes.IsPropertyDefault("dataEntryWebPanelBC");
			m_SetFocus = element.Attributes.GetPropertyValue<System.String>("setFocus");
			m_IsSetFocusDefault = element.Attributes.IsPropertyDefault("setFocus");
			m_SetFocusAttributeReference = element.Attributes.GetPropertyValue<KBObjectReference>("setFocusAttributeReference");
			m_IsSetFocusAttributeDefault = element.Attributes.IsPropertyDefault("setFocusAttribute");
			m_ObjName = element.Attributes.GetPropertyValue<System.String>("objName");
			m_IsObjNameDefault = element.Attributes.IsPropertyDefault("objName");
			m_EventStart = element.Attributes.GetPropertyValue<System.String>("EventStart");
			m_IsEventStartDefault = element.Attributes.IsPropertyDefault("EventStart");
			m_BCSucessCode = element.Attributes.GetPropertyValue<System.String>("BCSucessCode");
			m_IsBCSucessCodeDefault = element.Attributes.IsPropertyDefault("BCSucessCode");
			m_BCErrorCode = element.Attributes.GetPropertyValue<System.String>("BCErrorCode");
			m_IsBCErrorCodeDefault = element.Attributes.IsPropertyDefault("BCErrorCode");
			m_UpdateObject = element.Attributes.GetPropertyValue<System.String>("updateObject");
			m_IsUpdateObjectDefault = element.Attributes.IsPropertyDefault("updateObject");
			m_UpdateDataProviderAba = element.Attributes.GetPropertyValue<System.String>("updateDataProviderAba");
			m_IsUpdateDataProviderAbaDefault = element.Attributes.IsPropertyDefault("updateDataProviderAba");
			m_UpdateSDTBC = element.Attributes.GetPropertyValue<System.String>("updateSDTBC");
			m_IsUpdateSDTBCDefault = element.Attributes.IsPropertyDefault("updateSDTBC");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "form" :
					{
						FormElement form = new FormElement();
						form.LoadFrom(_childElement);
						Form = form;
						break;
					}
					case "parameters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ParameterElement parameterElement = new ParameterElement();
							parameterElement.LoadFrom(_childElementItem);
							Parameters.Add(parameterElement);
						}
						break;
					}
					case "actions" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ActionElement actionElement = new ActionElement();
							actionElement.LoadFrom(_childElementItem);
							Actions.Add(actionElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="TransactionElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Transaction")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Transaction"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "transactionReference", m_TransactionReference, m_IsTransactionDefault);
			SaveAttribute(element, "masterPage", m_MasterPage, m_IsMasterPageDefault);
			SaveAttribute(element, "dataEntryWebPanelBC", m_DataEntryWebPanelBC, m_IsDataEntryWebPanelBCDefault);
			SaveAttribute(element, "setFocus", m_SetFocus, m_IsSetFocusDefault);
			SaveAttribute(element, "setFocusAttributeReference", m_SetFocusAttributeReference, m_IsSetFocusAttributeDefault);
			SaveAttribute(element, "objName", m_ObjName, m_IsObjNameDefault);
			SaveAttribute(element, "EventStart", m_EventStart, m_IsEventStartDefault);
			SaveAttribute(element, "BCSucessCode", m_BCSucessCode, m_IsBCSucessCodeDefault);
			SaveAttribute(element, "BCErrorCode", m_BCErrorCode, m_IsBCErrorCodeDefault);
			SaveAttribute(element, "updateObject", m_UpdateObject, m_IsUpdateObjectDefault);
			SaveAttribute(element, "updateDataProviderAba", m_UpdateDataProviderAba, m_IsUpdateDataProviderAbaDefault);
			SaveAttribute(element, "updateSDTBC", m_UpdateSDTBC, m_IsUpdateSDTBCDefault);

			Debug.Assert(m_TransactionReference == element.Attributes.GetPropertyValue<KBObjectReference>("transactionReference"));
			Debug.Assert(m_MasterPage == element.Attributes.GetPropertyValue<System.String>("masterPage"));
			Debug.Assert(m_DataEntryWebPanelBC == element.Attributes.GetPropertyValue<System.String>("dataEntryWebPanelBC"));
			Debug.Assert(m_SetFocus == element.Attributes.GetPropertyValue<System.String>("setFocus"));
			Debug.Assert(m_SetFocusAttributeReference == element.Attributes.GetPropertyValue<KBObjectReference>("setFocusAttributeReference"));
			Debug.Assert(m_ObjName == element.Attributes.GetPropertyValue<System.String>("objName"));
			Debug.Assert(m_EventStart == element.Attributes.GetPropertyValue<System.String>("EventStart"));
			Debug.Assert(m_BCSucessCode == element.Attributes.GetPropertyValue<System.String>("BCSucessCode"));
			Debug.Assert(m_BCErrorCode == element.Attributes.GetPropertyValue<System.String>("BCErrorCode"));
			Debug.Assert(m_UpdateObject == element.Attributes.GetPropertyValue<System.String>("updateObject"));
			Debug.Assert(m_UpdateDataProviderAba == element.Attributes.GetPropertyValue<System.String>("updateDataProviderAba"));
			Debug.Assert(m_UpdateSDTBC == element.Attributes.GetPropertyValue<System.String>("updateSDTBC"));

			// Save element children.
			if (m_Form != null)
			{
				PatternInstanceElement form = element.Children["form"];
				m_Form.SaveTo(form);
			}

			if (m_Parameters != null)
			{
				if (m_Parameters.Count > 0)
					element.Children.AddNewElement("parameters");

				foreach (ParameterElement _item in Parameters)
				{
					PatternInstanceElement child = element.Children["parameters"].Children.AddNewElement("parameter");
					_item.SaveTo(child);
				}
			}

			if (m_Actions != null)
			{
				if (m_Actions.Count > 0)
					element.Children.AddNewElement("actions");

				foreach (ActionElement _item in Actions)
				{
					PatternInstanceElement child = element.Children["actions"].Children.AddNewElement("action");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="TransactionElement"/>.
		/// </summary>
		public TransactionElement Clone()
		{
			TransactionElement clone = new TransactionElement();

			clone.Transaction = this.Transaction;
			clone.MasterPage = this.MasterPage;
			clone.DataEntryWebPanelBC = this.DataEntryWebPanelBC;
			clone.SetFocus = this.SetFocus;
			clone.SetFocusAttribute = this.SetFocusAttribute;
			clone.ObjName = this.ObjName;
			clone.EventStart = this.EventStart;
			clone.BCSucessCode = this.BCSucessCode;
			clone.BCErrorCode = this.BCErrorCode;
			clone.UpdateObject = this.UpdateObject;
			clone.UpdateDataProviderAba = this.UpdateDataProviderAba;
			clone.UpdateSDTBC = this.UpdateSDTBC;
			clone.Form = this.Form.Clone();
			foreach (ParameterElement parameterElement in this.Parameters)
				clone.Parameters.Add(parameterElement.Clone());
			foreach (ActionElement actionElement in this.Actions)
				clone.Actions.Add(actionElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "form" :
				{
					if (Form != null)
						return Form.GetElement(path);
					else
						return null;
				}
				case "parameters" :
				{
					if (path.Count == 0)
						return Parameters;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "parameter")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Parameters != null && itemIndex >= 0 && itemIndex < Parameters.Count)
						return Parameters[itemIndex].GetElement(path);
					else
						return null;
				}
				case "actions" :
				{
					if (path.Count == 0)
						return Actions;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "action")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Actions != null && itemIndex >= 0 && itemIndex < Actions.Count)
						return Actions[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="MasterPage"/> property.
		/// </summary>
		public static class MasterPageValue
		{
			public const string Default = "<default>";
			public const string None = "<none>";
		}

		/// <summary>
		/// Possible values for the <see cref="DataEntryWebPanelBC"/> property.
		/// </summary>
		public static class DataEntryWebPanelBCValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="SetFocus"/> property.
		/// </summary>
		public static class SetFocusValue
		{
			public const string Default = "<default>";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateObject"/> property.
		/// </summary>
		public static class UpdateObjectValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string OnlyRulesEventsAndConditions = "Only Rules, Events and Conditions";
			public const string Overwrite = "Overwrite";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateDataProviderAba"/> property.
		/// </summary>
		public static class UpdateDataProviderAbaValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string Overwrite = "Overwrite";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateSDTBC"/> property.
		/// </summary>
		public static class UpdateSDTBCValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string Overwrite = "Overwrite";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Transaction ({0})", TransactionName);
		}

		#endregion
	}

	#endregion

	#region Element: WebPanelRoot

	public partial class WebPanelRootElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_UpdateObject;
		private bool m_IsUpdateObjectDefault;
		private System.String m_UpdateDataProviderAba;
		private bool m_IsUpdateDataProviderAbaDefault;
		private FormElement m_Form;
		private ParametersElement m_Parameters;
		private ActionsElement m_Actions;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="WebPanelRootElement"/> class.
		/// </summary>
		public WebPanelRootElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="WebPanelRootElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_UpdateObject = "Create default";
			m_IsUpdateObjectDefault = true;
			m_UpdateDataProviderAba = "Create default";
			m_IsUpdateDataProviderAbaDefault = true;
			m_Form = new FormElement();
			m_Form.Parent = this;
			m_Parameters = new ParametersElement();
			m_Parameters.Parent = this;
			m_Parameters.ElementName = "parameters";
			m_Actions = new ActionsElement();
			m_Actions.Parent = this;
			m_Actions.ElementName = "actions";
		}

		#endregion

		#region Properties

		private HPatternInstance m_Parent;

		/// <summary>
		/// Instance to which this <see cref="WebPanelRootElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public HPatternInstance Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Only Rules, Events and Conditions - Atualiza somente as regras, eventos e condições e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateObject
		{
			get { return m_UpdateObject; }
			set 
			{
				m_UpdateObject = value;
				m_IsUpdateObjectDefault = false;
			}
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateDataProviderAba
		{
			get { return m_UpdateDataProviderAba; }
			set 
			{
				m_UpdateDataProviderAba = value;
				m_IsUpdateDataProviderAbaDefault = false;
			}
		}

		public FormElement Form
		{
			get { return m_Form; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Form = value;
				m_Form.Parent = this;
			}
		}

		public ParametersElement Parameters
		{
			get { return m_Parameters; }
		}

		public ActionsElement Actions
		{
			get { return m_Actions; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// </summary>
		public ParameterElement AddParameter()
		{
			ParameterElement parameterElement = new ParameterElement();
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// The ParameterElement is initialized with the specified value.
		/// </summary>
		public ParameterElement AddParameter(System.String name)
		{
			ParameterElement parameterElement = new ParameterElement(name);
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Finds the <see cref="ParameterElement"/> in the <see cref="Parameters"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no parameterElement is found, null is returned.
		/// </summary>
		public ParameterElement FindParameter(System.String name)
		{
			return Parameters.Find(delegate (ParameterElement parameterElement) { return parameterElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="ActionElement"/> and adds it to the <see cref="Actions"/> collection.
		/// </summary>
		public ActionElement AddAction()
		{
			ActionElement actionElement = new ActionElement();
			m_Actions.Add(actionElement);
			return actionElement;
		}

		/// <summary>
		/// Creates a new <see cref="ActionElement"/> and adds it to the <see cref="Actions"/> collection.
		/// The ActionElement is initialized with the specified value.
		/// </summary>
		public ActionElement AddAction(System.String name)
		{
			ActionElement actionElement = new ActionElement(name);
			m_Actions.Add(actionElement);
			return actionElement;
		}

		/// <summary>
		/// Finds the <see cref="ActionElement"/> in the <see cref="Actions"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no actionElement is found, null is returned.
		/// </summary>
		public ActionElement FindAction(System.String name)
		{
			return Actions.Find(delegate (ActionElement actionElement) { return actionElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="WebPanelRootElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "WebPanelRoot")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "WebPanelRoot"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_UpdateObject = element.Attributes.GetPropertyValue<System.String>("updateObject");
			m_IsUpdateObjectDefault = element.Attributes.IsPropertyDefault("updateObject");
			m_UpdateDataProviderAba = element.Attributes.GetPropertyValue<System.String>("updateDataProviderAba");
			m_IsUpdateDataProviderAbaDefault = element.Attributes.IsPropertyDefault("updateDataProviderAba");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "form" :
					{
						FormElement form = new FormElement();
						form.LoadFrom(_childElement);
						Form = form;
						break;
					}
					case "parameters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ParameterElement parameterElement = new ParameterElement();
							parameterElement.LoadFrom(_childElementItem);
							Parameters.Add(parameterElement);
						}
						break;
					}
					case "actions" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ActionElement actionElement = new ActionElement();
							actionElement.LoadFrom(_childElementItem);
							Actions.Add(actionElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="WebPanelRootElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "WebPanelRoot")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "WebPanelRoot"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "updateObject", m_UpdateObject, m_IsUpdateObjectDefault);
			SaveAttribute(element, "updateDataProviderAba", m_UpdateDataProviderAba, m_IsUpdateDataProviderAbaDefault);

			Debug.Assert(m_UpdateObject == element.Attributes.GetPropertyValue<System.String>("updateObject"));
			Debug.Assert(m_UpdateDataProviderAba == element.Attributes.GetPropertyValue<System.String>("updateDataProviderAba"));

			// Save element children.
			if (m_Form != null)
			{
				PatternInstanceElement form = element.Children["form"];
				m_Form.SaveTo(form);
			}

			if (m_Parameters != null)
			{
				if (m_Parameters.Count > 0)
					element.Children.AddNewElement("parameters");

				foreach (ParameterElement _item in Parameters)
				{
					PatternInstanceElement child = element.Children["parameters"].Children.AddNewElement("parameter");
					_item.SaveTo(child);
				}
			}

			if (m_Actions != null)
			{
				if (m_Actions.Count > 0)
					element.Children.AddNewElement("actions");

				foreach (ActionElement _item in Actions)
				{
					PatternInstanceElement child = element.Children["actions"].Children.AddNewElement("action");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="WebPanelRootElement"/>.
		/// </summary>
		public WebPanelRootElement Clone()
		{
			WebPanelRootElement clone = new WebPanelRootElement();

			clone.UpdateObject = this.UpdateObject;
			clone.UpdateDataProviderAba = this.UpdateDataProviderAba;
			clone.Form = this.Form.Clone();
			foreach (ParameterElement parameterElement in this.Parameters)
				clone.Parameters.Add(parameterElement.Clone());
			foreach (ActionElement actionElement in this.Actions)
				clone.Actions.Add(actionElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "form" :
				{
					if (Form != null)
						return Form.GetElement(path);
					else
						return null;
				}
				case "parameters" :
				{
					if (path.Count == 0)
						return Parameters;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "parameter")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Parameters != null && itemIndex >= 0 && itemIndex < Parameters.Count)
						return Parameters[itemIndex].GetElement(path);
					else
						return null;
				}
				case "actions" :
				{
					if (path.Count == 0)
						return Actions;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "action")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Actions != null && itemIndex >= 0 && itemIndex < Actions.Count)
						return Actions[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="UpdateObject"/> property.
		/// </summary>
		public static class UpdateObjectValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string OnlyRulesEventsAndConditions = "Only Rules, Events and Conditions";
			public const string Overwrite = "Overwrite";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateDataProviderAba"/> property.
		/// </summary>
		public static class UpdateDataProviderAbaValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string Overwrite = "Overwrite";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "WebPanel";
		}

		#endregion
	}

	#endregion

	#region Element: View

	public partial class ViewElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Caption;
		private bool m_IsCaptionDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private System.Boolean m_BackToSelection;
		private bool m_IsBackToSelectionDefault;
		private System.String m_MasterPage;
		private bool m_IsMasterPageDefault;
		private System.Boolean m_UseAsSearchViewer;
		private bool m_IsUseAsSearchViewerDefault;
		private System.String m_ObjName;
		private bool m_IsObjNameDefault;
		private System.String m_DisabledTabsIfEditing;
		private bool m_IsDisabledTabsIfEditingDefault;
		private System.String m_UpdateObject;
		private bool m_IsUpdateObjectDefault;
		private ParametersElement m_Parameters;
		private FixedDataElement m_FixedData;
		private GroupsElement m_Groups;
		private TabsElement m_Tabs;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="ViewElement"/> class.
		/// </summary>
		public ViewElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="ViewElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Caption = "";
			m_IsCaptionDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_BackToSelection = true;
			m_IsBackToSelectionDefault = true;
			m_MasterPage = "<default>";
			m_IsMasterPageDefault = true;
			m_UseAsSearchViewer = true;
			m_IsUseAsSearchViewerDefault = true;
			m_ObjName = "";
			m_IsObjNameDefault = true;
			m_DisabledTabsIfEditing = "default";
			m_IsDisabledTabsIfEditingDefault = true;
			m_UpdateObject = "Create default";
			m_IsUpdateObjectDefault = true;
			m_Parameters = new ParametersElement();
			m_Parameters.Parent = this;
			m_Parameters.ElementName = "parameters";
			m_FixedData = null;
			m_Groups = new GroupsElement();
			m_Groups.Parent = this;
			m_Groups.ElementName = "groups";
			m_Tabs = new TabsElement();
			m_Tabs.Parent = this;
			m_Tabs.ElementName = "tabs";
		}

		#endregion

		#region Properties

		private LevelElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="ViewElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public LevelElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Caption to Appear in the Form. Must be a character expression. Usually it's the description attribute.
		*/
		/// </summary>
		public System.String Caption
		{
			get { return m_Caption; }
			set 
			{
				m_Caption = value;
				m_IsCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		Description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Indicates whether the View page has a link back to the Selection page.
		*/
		/// </summary>
		public System.Boolean BackToSelection
		{
			get { return m_BackToSelection; }
			set 
			{
				m_BackToSelection = value;
				m_IsBackToSelectionDefault = false;
			}
		}

		/// <summary>
		/*
		Object name of the master page to be used in this view webpanel. 
		/// To use the one defined in the configuration file, set value to "&lt;default&gt;". 
		/// To disable the master page, use "&lt;none&gt;".
		*/
		/// </summary>
		public System.String MasterPage
		{
			get { return m_MasterPage; }
			set 
			{
				m_MasterPage = value;
				m_IsMasterPageDefault = false;
			}
		}

		/// <summary>
		/*
		Set the view object as the Search Viewer for the associated transaction.
		*/
		/// </summary>
		public System.Boolean UseAsSearchViewer
		{
			get { return m_UseAsSearchViewer; }
			set 
			{
				m_UseAsSearchViewer = value;
				m_IsUseAsSearchViewerDefault = false;
			}
		}

		/// <summary>
		/*
		Object Name
		*/
		/// </summary>
		public System.String ObjName
		{
			get { return m_ObjName; }
			set 
			{
				m_ObjName = value;
				m_IsObjNameDefault = false;
			}
		}

		/// <summary>
		/*
		Desabilita outras abas quando esta editando registro de outro nivel
		*/
		/// </summary>
		public System.String DisabledTabsIfEditing
		{
			get { return m_DisabledTabsIfEditing; }
			set 
			{
				m_DisabledTabsIfEditing = value;
				m_IsDisabledTabsIfEditingDefault = false;
			}
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Only Rules, Events and Conditions - Atualiza somente as regras, eventos e condições e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateObject
		{
			get { return m_UpdateObject; }
			set 
			{
				m_UpdateObject = value;
				m_IsUpdateObjectDefault = false;
			}
		}

		public ParametersElement Parameters
		{
			get { return m_Parameters; }
		}

		public FixedDataElement FixedData
		{
			get { return m_FixedData; }
			set
			{
				m_FixedData = value;
				m_FixedData.Parent = this;
			}
		}

		public GroupsElement Groups
		{
			get { return m_Groups; }
		}

		public TabsElement Tabs
		{
			get { return m_Tabs; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// </summary>
		public ParameterElement AddParameter()
		{
			ParameterElement parameterElement = new ParameterElement();
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Creates a new <see cref="ParameterElement"/> and adds it to the <see cref="Parameters"/> collection.
		/// The ParameterElement is initialized with the specified value.
		/// </summary>
		public ParameterElement AddParameter(System.String name)
		{
			ParameterElement parameterElement = new ParameterElement(name);
			m_Parameters.Add(parameterElement);
			return parameterElement;
		}

		/// <summary>
		/// Finds the <see cref="ParameterElement"/> in the <see cref="Parameters"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no parameterElement is found, null is returned.
		/// </summary>
		public ParameterElement FindParameter(System.String name)
		{
			return Parameters.Find(delegate (ParameterElement parameterElement) { return parameterElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="GroupTabElement"/> and adds it to the <see cref="Groups"/> collection.
		/// </summary>
		public GroupTabElement AddGroupTab()
		{
			GroupTabElement groupTabElement = new GroupTabElement();
			m_Groups.Add(groupTabElement);
			return groupTabElement;
		}

		/// <summary>
		/// Creates a new <see cref="GroupTabElement"/> and adds it to the <see cref="Groups"/> collection.
		/// The GroupTabElement is initialized with the specified value.
		/// </summary>
		public GroupTabElement AddGroupTab(System.String name)
		{
			GroupTabElement groupTabElement = new GroupTabElement(name);
			m_Groups.Add(groupTabElement);
			return groupTabElement;
		}

		/// <summary>
		/// Finds the <see cref="GroupTabElement"/> in the <see cref="Groups"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no groupTabElement is found, null is returned.
		/// </summary>
		public GroupTabElement FindGroupTab(System.String name)
		{
			return Groups.Find(delegate (GroupTabElement groupTabElement) { return groupTabElement.Name == name; });
		}

		/// <summary>
		/// Creates a new <see cref="TabElement"/> and adds it to the <see cref="Tabs"/> collection.
		/// </summary>
		public TabElement AddTab()
		{
			TabElement tabElement = new TabElement();
			m_Tabs.Add(tabElement);
			return tabElement;
		}

		/// <summary>
		/// Creates a new <see cref="TabElement"/> and adds it to the <see cref="Tabs"/> collection.
		/// The TabElement is initialized with the specified value.
		/// </summary>
		public TabElement AddTab(System.String code)
		{
			TabElement tabElement = new TabElement(code);
			m_Tabs.Add(tabElement);
			return tabElement;
		}

		/// <summary>
		/// Finds the <see cref="TabElement"/> in the <see cref="Tabs"/> collection that has the specified value in its <see cref="Code"/> property.
		/// If no tabElement is found, null is returned.
		/// </summary>
		public TabElement FindTab(System.String code)
		{
			return Tabs.Find(delegate (TabElement tabElement) { return tabElement.Code == code; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="ViewElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "View")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "View"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Caption = element.Attributes.GetPropertyValue<System.String>("caption");
			m_IsCaptionDefault = element.Attributes.IsPropertyDefault("caption");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");
			m_BackToSelection = element.Attributes.GetPropertyValue<System.Boolean>("backToSelection");
			m_IsBackToSelectionDefault = element.Attributes.IsPropertyDefault("backToSelection");
			m_MasterPage = element.Attributes.GetPropertyValue<System.String>("masterPage");
			m_IsMasterPageDefault = element.Attributes.IsPropertyDefault("masterPage");
			m_UseAsSearchViewer = element.Attributes.GetPropertyValue<System.Boolean>("useAsSearchViewer");
			m_IsUseAsSearchViewerDefault = element.Attributes.IsPropertyDefault("useAsSearchViewer");
			m_ObjName = element.Attributes.GetPropertyValue<System.String>("objName");
			m_IsObjNameDefault = element.Attributes.IsPropertyDefault("objName");
			m_DisabledTabsIfEditing = element.Attributes.GetPropertyValue<System.String>("disabledTabsIfEditing");
			m_IsDisabledTabsIfEditingDefault = element.Attributes.IsPropertyDefault("disabledTabsIfEditing");
			m_UpdateObject = element.Attributes.GetPropertyValue<System.String>("updateObject");
			m_IsUpdateObjectDefault = element.Attributes.IsPropertyDefault("updateObject");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "parameters" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							ParameterElement parameterElement = new ParameterElement();
							parameterElement.LoadFrom(_childElementItem);
							Parameters.Add(parameterElement);
						}
						break;
					}
					case "fixedData" :
					{
						FixedDataElement fixedData = new FixedDataElement();
						fixedData.LoadFrom(_childElement);
						FixedData = fixedData;
						break;
					}
					case "groups" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							GroupTabElement groupTabElement = new GroupTabElement();
							groupTabElement.LoadFrom(_childElementItem);
							Groups.Add(groupTabElement);
						}
						break;
					}
					case "tabs" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							TabElement tabElement = new TabElement();
							tabElement.LoadFrom(_childElementItem);
							Tabs.Add(tabElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="ViewElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "View")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "View"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "caption", m_Caption, m_IsCaptionDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);
			SaveAttribute(element, "backToSelection", m_BackToSelection, m_IsBackToSelectionDefault);
			SaveAttribute(element, "masterPage", m_MasterPage, m_IsMasterPageDefault);
			SaveAttribute(element, "useAsSearchViewer", m_UseAsSearchViewer, m_IsUseAsSearchViewerDefault);
			SaveAttribute(element, "objName", m_ObjName, m_IsObjNameDefault);
			SaveAttribute(element, "disabledTabsIfEditing", m_DisabledTabsIfEditing, m_IsDisabledTabsIfEditingDefault);
			SaveAttribute(element, "updateObject", m_UpdateObject, m_IsUpdateObjectDefault);

			Debug.Assert(m_Caption == element.Attributes.GetPropertyValue<System.String>("caption"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));
			Debug.Assert(m_BackToSelection == element.Attributes.GetPropertyValue<System.Boolean>("backToSelection"));
			Debug.Assert(m_MasterPage == element.Attributes.GetPropertyValue<System.String>("masterPage"));
			Debug.Assert(m_UseAsSearchViewer == element.Attributes.GetPropertyValue<System.Boolean>("useAsSearchViewer"));
			Debug.Assert(m_ObjName == element.Attributes.GetPropertyValue<System.String>("objName"));
			Debug.Assert(m_DisabledTabsIfEditing == element.Attributes.GetPropertyValue<System.String>("disabledTabsIfEditing"));
			Debug.Assert(m_UpdateObject == element.Attributes.GetPropertyValue<System.String>("updateObject"));

			// Save element children.
			if (m_Parameters != null)
			{
				foreach (ParameterElement _item in Parameters)
				{
					PatternInstanceElement child = element.Children["parameters"].Children.AddNewElement("parameter");
					_item.SaveTo(child);
				}
			}

			if (m_FixedData != null)
			{
				PatternInstanceElement fixedData = element.Children.AddNewElement("fixedData");
				m_FixedData.SaveTo(fixedData);
			}

			if (m_Groups != null)
			{
				foreach (GroupTabElement _item in Groups)
				{
					PatternInstanceElement child = element.Children["groups"].Children.AddNewElement("groupTab");
					_item.SaveTo(child);
				}
			}

			if (m_Tabs != null)
			{
				foreach (TabElement _item in Tabs)
				{
					PatternInstanceElement child = element.Children["tabs"].Children.AddNewElement("tab");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="ViewElement"/>.
		/// </summary>
		public ViewElement Clone()
		{
			ViewElement clone = new ViewElement();

			clone.Caption = this.Caption;
			clone.Description = this.Description;
			clone.BackToSelection = this.BackToSelection;
			clone.MasterPage = this.MasterPage;
			clone.UseAsSearchViewer = this.UseAsSearchViewer;
			clone.ObjName = this.ObjName;
			clone.DisabledTabsIfEditing = this.DisabledTabsIfEditing;
			clone.UpdateObject = this.UpdateObject;
			foreach (ParameterElement parameterElement in this.Parameters)
				clone.Parameters.Add(parameterElement.Clone());
			if (FixedData != null)
				clone.FixedData = this.FixedData.Clone();
			foreach (GroupTabElement groupTabElement in this.Groups)
				clone.Groups.Add(groupTabElement.Clone());
			foreach (TabElement tabElement in this.Tabs)
				clone.Tabs.Add(tabElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "parameters" :
				{
					if (path.Count == 0)
						return Parameters;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "parameter")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Parameters != null && itemIndex >= 0 && itemIndex < Parameters.Count)
						return Parameters[itemIndex].GetElement(path);
					else
						return null;
				}
				case "fixedData" :
				{
					if (FixedData != null)
						return FixedData.GetElement(path);
					else
						return null;
				}
				case "groups" :
				{
					if (path.Count == 0)
						return Groups;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "groupTab")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Groups != null && itemIndex >= 0 && itemIndex < Groups.Count)
						return Groups[itemIndex].GetElement(path);
					else
						return null;
				}
				case "tabs" :
				{
					if (path.Count == 0)
						return Tabs;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "tab")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Tabs != null && itemIndex >= 0 && itemIndex < Tabs.Count)
						return Tabs[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="MasterPage"/> property.
		/// </summary>
		public static class MasterPageValue
		{
			public const string Default = "<default>";
			public const string None = "<none>";
		}

		/// <summary>
		/// Possible values for the <see cref="DisabledTabsIfEditing"/> property.
		/// </summary>
		public static class DisabledTabsIfEditingValue
		{
			public const string Default = "default";
			public const string True = "true";
			public const string False = "false";
		}

		/// <summary>
		/// Possible values for the <see cref="UpdateObject"/> property.
		/// </summary>
		public static class UpdateObjectValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string OnlyRulesEventsAndConditions = "Only Rules, Events and Conditions";
			public const string Overwrite = "Overwrite";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "View ({0})", Description);
		}

		#endregion
	}

	#endregion

	#region Element: Variable

	public partial class VariableElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private Artech.Genexus.Common.Objects.Domain m_Domain;
		private KBObjectReference m_DomainReference;
		private bool m_IsDomainDefault;
		private Artech.Genexus.Common.Objects.Attribute m_Attribute;
		private KBObjectReference m_AttributeReference;
		private bool m_IsAttributeDefault;
		private System.String m_LoadCode;
		private bool m_IsLoadCodeDefault;
		private System.Boolean m_Visible;
		private bool m_IsVisibleDefault;
		private System.String m_ThemeClass;
		private bool m_IsThemeClassDefault;
		private System.String m_Format;
		private bool m_IsFormatDefault;
		private System.String m_IsValid;
		private bool m_IsIsValidDefault;
		private System.Boolean m_Readonly;
		private bool m_IsReadonlyDefault;
		private System.String m_MaskPicture;
		private bool m_IsMaskPictureDefault;
		private System.Boolean m_Reverse;
		private bool m_IsReverseDefault;
		private System.Boolean m_Signed;
		private bool m_IsSignedDefault;
		private System.String m_UnmaskedChars;
		private bool m_IsUnmaskedCharsDefault;
		private System.Boolean m_UnmaskedValue;
		private bool m_IsUnmaskedValueDefault;
		private System.String m_Width;
		private bool m_IsWidthDefault;
		private System.String m_Height;
		private bool m_IsHeightDefault;
		private Artech.Common.Collections.BaseCollection<LinkElement> m_Links;
		private GridColumnPropertiesElement m_GridColumnProperties;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="VariableElement"/> class.
		/// </summary>
		public VariableElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="VariableElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public VariableElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="VariableElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_Domain = null;
			m_DomainReference = null;
			m_IsDomainDefault = true;
			m_Attribute = null;
			m_AttributeReference = null;
			m_IsAttributeDefault = true;
			m_LoadCode = "";
			m_IsLoadCodeDefault = true;
			m_Visible = true;
			m_IsVisibleDefault = true;
			m_ThemeClass = null;
			m_IsThemeClassDefault = true;
			m_Format = "<default>";
			m_IsFormatDefault = true;
			m_IsValid = "";
			m_IsIsValidDefault = true;
			m_Readonly = false;
			m_IsReadonlyDefault = true;
			m_MaskPicture = "";
			m_IsMaskPictureDefault = true;
			m_Reverse = false;
			m_IsReverseDefault = true;
			m_Signed = false;
			m_IsSignedDefault = true;
			m_UnmaskedChars = "[().:/ -]";
			m_IsUnmaskedCharsDefault = true;
			m_UnmaskedValue = false;
			m_IsUnmaskedValueDefault = true;
			m_Width = "";
			m_IsWidthDefault = true;
			m_Height = "";
			m_IsHeightDefault = true;
			m_Links = new Artech.Common.Collections.BaseCollection<LinkElement>();
			m_Links.ItemAdded += new EventHandler<CollectionItemEventArgs<LinkElement>>(Links_ItemAdded);
			m_GridColumnProperties = new GridColumnPropertiesElement();
			m_GridColumnProperties.Parent = this;
			m_GridColumnProperties.ElementName = "GridColumnProperties";
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="VariableElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Variable name.
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Variable description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Domain on which the variable is based.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Domain Domain
		{
			get
			{
				if (m_Domain == null && m_DomainReference != null)
					m_Domain = (Artech.Genexus.Common.Objects.Domain)m_DomainReference.GetKBObject(Instance.Model);

				return m_Domain;
			}

			set 
			{
				m_Domain = value;
				m_DomainReference = (value != null ? new KBObjectReference(value) : null);
				m_IsDomainDefault = false;
			}
		}

		/// <summary>
		/// Domain name.
		/// </summary>
		public string DomainName
		{
			get { return (Domain != null ? Domain.Name : null); }
		}

		/// <summary>
		/*
		Attribute on which the variable is based.
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Attribute Attribute
		{
			get
			{
				if (m_Attribute == null && m_AttributeReference != null)
					m_Attribute = (Artech.Genexus.Common.Objects.Attribute)m_AttributeReference.GetKBObject(Instance.Model);

				return m_Attribute;
			}

			set 
			{
				m_Attribute = value;
				m_AttributeReference = (value != null ? new KBObjectReference(value) : null);
				m_IsAttributeDefault = false;
			}
		}

		/// <summary>
		/// Attribute name.
		/// </summary>
		public string AttributeName
		{
			get { return (Attribute != null ? Attribute.Name : null); }
		}

		/// <summary>
		/*
		Code used in the panel or grid Load event to assign the value to be displayed.
		*/
		/// </summary>
		public System.String LoadCode
		{
			get { return m_LoadCode; }
			set 
			{
				m_LoadCode = value;
				m_IsLoadCodeDefault = false;
			}
		}

		/// <summary>
		/*
		Variable is visible (if false, in grids the column will be hidden, and in tabular tabs the variable will be invisible).
		*/
		/// </summary>
		public System.Boolean Visible
		{
			get { return m_Visible; }
			set 
			{
				m_Visible = value;
				m_IsVisibleDefault = false;
			}
		}

		/// <summary>
		/*
		Theme class for the variable.
		*/
		/// </summary>
		public System.String ThemeClass
		{
			get { return m_ThemeClass; }
			set 
			{
				m_ThemeClass = value;
				m_IsThemeClassDefault = false;
			}
		}

		/// <summary>
		/*
		HTML format for the variable.
		*/
		/// </summary>
		public System.String Format
		{
			get { return m_Format; }
			set 
			{
				m_Format = value;
				m_IsFormatDefault = false;
			}
		}

		/// <summary>
		/*
		Evento IsValid para Atributo ou variável
		*/
		/// </summary>
		public System.String IsValid
		{
			get { return m_IsValid; }
			set 
			{
				m_IsValid = value;
				m_IsIsValidDefault = false;
			}
		}

		/// <summary>
		/*
		Define se é ReadOnly
		*/
		/// </summary>
		public System.Boolean Readonly
		{
			get { return m_Readonly; }
			set 
			{
				m_Readonly = value;
				m_IsReadonlyDefault = false;
			}
		}

		/// <summary>
		/*
		Define a Picture
		*/
		/// </summary>
		public System.String MaskPicture
		{
			get { return m_MaskPicture; }
			set 
			{
				m_MaskPicture = value;
				m_IsMaskPictureDefault = false;
			}
		}

		/// <summary>
		/*
		Define se a digitação será invertida
		*/
		/// </summary>
		public System.Boolean Reverse
		{
			get { return m_Reverse; }
			set 
			{
				m_Reverse = value;
				m_IsReverseDefault = false;
			}
		}

		/// <summary>
		/*
		Define se permite valor negativo
		*/
		/// </summary>
		public System.Boolean Signed
		{
			get { return m_Signed; }
			set 
			{
				m_Signed = value;
				m_IsSignedDefault = false;
			}
		}

		/// <summary>
		/*
		Define os caracteres que serão retirados quando retorna valor sem a mascara
		*/
		/// </summary>
		public System.String UnmaskedChars
		{
			get { return m_UnmaskedChars; }
			set 
			{
				m_UnmaskedChars = value;
				m_IsUnmaskedCharsDefault = false;
			}
		}

		/// <summary>
		/*
		Define se retorna o valor sem a mascara ou não
		*/
		/// </summary>
		public System.Boolean UnmaskedValue
		{
			get { return m_UnmaskedValue; }
			set 
			{
				m_UnmaskedValue = value;
				m_IsUnmaskedValueDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Width(tamanho horizontal) para o Atributo
		*/
		/// </summary>
		public System.String Width
		{
			get { return m_Width; }
			set 
			{
				m_Width = value;
				m_IsWidthDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Height(tamanho vertical) para o Atributo
		*/
		/// </summary>
		public System.String Height
		{
			get { return m_Height; }
			set 
			{
				m_Height = value;
				m_IsHeightDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<LinkElement> Links
		{
			get { return m_Links; }
		}

		public GridColumnPropertiesElement GridColumnProperties
		{
			get { return m_GridColumnProperties; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="LinkElement"/> and adds it to the <see cref="Links"/> collection.
		/// </summary>
		public LinkElement AddLink()
		{
			LinkElement linkElement = new LinkElement();
			m_Links.Add(linkElement);
			return linkElement;
		}

		private void Links_ItemAdded(object sender, CollectionItemEventArgs<LinkElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="GridColumnPropertieElement"/> and adds it to the <see cref="GridColumnProperties"/> collection.
		/// </summary>
		public GridColumnPropertieElement AddGridColumnPropertie()
		{
			GridColumnPropertieElement gridColumnPropertieElement = new GridColumnPropertieElement();
			m_GridColumnProperties.Add(gridColumnPropertieElement);
			return gridColumnPropertieElement;
		}

		/// <summary>
		/// Creates a new <see cref="GridColumnPropertieElement"/> and adds it to the <see cref="GridColumnProperties"/> collection.
		/// The GridColumnPropertieElement is initialized with the specified value.
		/// </summary>
		public GridColumnPropertieElement AddGridColumnPropertie(System.String name)
		{
			GridColumnPropertieElement gridColumnPropertieElement = new GridColumnPropertieElement(name);
			m_GridColumnProperties.Add(gridColumnPropertieElement);
			return gridColumnPropertieElement;
		}

		/// <summary>
		/// Finds the <see cref="GridColumnPropertieElement"/> in the <see cref="GridColumnProperties"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridColumnPropertieElement is found, null is returned.
		/// </summary>
		public GridColumnPropertieElement FindGridColumnPropertie(System.String name)
		{
			return GridColumnProperties.Find(delegate (GridColumnPropertieElement gridColumnPropertieElement) { return gridColumnPropertieElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="VariableElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Variable")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Variable"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");
			m_DomainReference = element.Attributes.GetPropertyValue<KBObjectReference>("domainReference");
			m_IsDomainDefault = element.Attributes.IsPropertyDefault("domain");
			m_AttributeReference = element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference");
			m_IsAttributeDefault = element.Attributes.IsPropertyDefault("attribute");
			m_LoadCode = element.Attributes.GetPropertyValue<System.String>("loadCode");
			m_IsLoadCodeDefault = element.Attributes.IsPropertyDefault("loadCode");
			m_Visible = element.Attributes.GetPropertyValue<System.Boolean>("visible");
			m_IsVisibleDefault = element.Attributes.IsPropertyDefault("visible");
			m_ThemeClass = element.Attributes.GetPropertyValue<System.String>("themeClass");
			m_IsThemeClassDefault = element.Attributes.IsPropertyDefault("themeClass");
			m_Format = element.Attributes.GetPropertyValue<System.String>("format");
			m_IsFormatDefault = element.Attributes.IsPropertyDefault("format");
			m_IsValid = element.Attributes.GetPropertyValue<System.String>("isValid");
			m_IsIsValidDefault = element.Attributes.IsPropertyDefault("isValid");
			m_Readonly = element.Attributes.GetPropertyValue<System.Boolean>("readonly");
			m_IsReadonlyDefault = element.Attributes.IsPropertyDefault("readonly");
			m_MaskPicture = element.Attributes.GetPropertyValue<System.String>("MaskPicture");
			m_IsMaskPictureDefault = element.Attributes.IsPropertyDefault("MaskPicture");
			m_Reverse = element.Attributes.GetPropertyValue<System.Boolean>("Reverse");
			m_IsReverseDefault = element.Attributes.IsPropertyDefault("Reverse");
			m_Signed = element.Attributes.GetPropertyValue<System.Boolean>("Signed");
			m_IsSignedDefault = element.Attributes.IsPropertyDefault("Signed");
			m_UnmaskedChars = element.Attributes.GetPropertyValue<System.String>("UnmaskedChars");
			m_IsUnmaskedCharsDefault = element.Attributes.IsPropertyDefault("UnmaskedChars");
			m_UnmaskedValue = element.Attributes.GetPropertyValue<System.Boolean>("UnmaskedValue");
			m_IsUnmaskedValueDefault = element.Attributes.IsPropertyDefault("UnmaskedValue");
			m_Width = element.Attributes.GetPropertyValue<System.String>("Width");
			m_IsWidthDefault = element.Attributes.IsPropertyDefault("Width");
			m_Height = element.Attributes.GetPropertyValue<System.String>("Height");
			m_IsHeightDefault = element.Attributes.IsPropertyDefault("Height");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "link" :
					{
						LinkElement link = new LinkElement();
						link.LoadFrom(_childElement);
						Links.Add(link);
						break;
					}
					case "GridColumnProperties" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							GridColumnPropertieElement gridColumnPropertieElement = new GridColumnPropertieElement();
							gridColumnPropertieElement.LoadFrom(_childElementItem);
							GridColumnProperties.Add(gridColumnPropertieElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="VariableElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Variable")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Variable"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);
			SaveAttribute(element, "domainReference", m_DomainReference, m_IsDomainDefault);
			SaveAttribute(element, "attributeReference", m_AttributeReference, m_IsAttributeDefault);
			SaveAttribute(element, "loadCode", m_LoadCode, m_IsLoadCodeDefault);
			SaveAttribute(element, "visible", m_Visible, m_IsVisibleDefault);
			SaveAttribute(element, "themeClass", m_ThemeClass, m_IsThemeClassDefault);
			SaveAttribute(element, "format", m_Format, m_IsFormatDefault);
			SaveAttribute(element, "isValid", m_IsValid, m_IsIsValidDefault);
			SaveAttribute(element, "readonly", m_Readonly, m_IsReadonlyDefault);
			SaveAttribute(element, "MaskPicture", m_MaskPicture, m_IsMaskPictureDefault);
			SaveAttribute(element, "Reverse", m_Reverse, m_IsReverseDefault);
			SaveAttribute(element, "Signed", m_Signed, m_IsSignedDefault);
			SaveAttribute(element, "UnmaskedChars", m_UnmaskedChars, m_IsUnmaskedCharsDefault);
			SaveAttribute(element, "UnmaskedValue", m_UnmaskedValue, m_IsUnmaskedValueDefault);
			SaveAttribute(element, "Width", m_Width, m_IsWidthDefault);
			SaveAttribute(element, "Height", m_Height, m_IsHeightDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));
			Debug.Assert(m_DomainReference == element.Attributes.GetPropertyValue<KBObjectReference>("domainReference"));
			Debug.Assert(m_AttributeReference == element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference"));
			Debug.Assert(m_LoadCode == element.Attributes.GetPropertyValue<System.String>("loadCode"));
			Debug.Assert(m_Visible == element.Attributes.GetPropertyValue<System.Boolean>("visible"));
			Debug.Assert(m_Format == element.Attributes.GetPropertyValue<System.String>("format"));
			Debug.Assert(m_IsValid == element.Attributes.GetPropertyValue<System.String>("isValid"));
			Debug.Assert(m_Readonly == element.Attributes.GetPropertyValue<System.Boolean>("readonly"));
			Debug.Assert(m_MaskPicture == element.Attributes.GetPropertyValue<System.String>("MaskPicture"));
			Debug.Assert(m_Reverse == element.Attributes.GetPropertyValue<System.Boolean>("Reverse"));
			Debug.Assert(m_Signed == element.Attributes.GetPropertyValue<System.Boolean>("Signed"));
			Debug.Assert(m_UnmaskedChars == element.Attributes.GetPropertyValue<System.String>("UnmaskedChars"));
			Debug.Assert(m_UnmaskedValue == element.Attributes.GetPropertyValue<System.Boolean>("UnmaskedValue"));
			Debug.Assert(m_Width == element.Attributes.GetPropertyValue<System.String>("Width"));
			Debug.Assert(m_Height == element.Attributes.GetPropertyValue<System.String>("Height"));

			// Save element children.
			if (m_Links != null)
			{
				foreach (LinkElement _item in Links)
				{
					PatternInstanceElement link = element.Children.AddNewElement("link");
					_item.SaveTo(link);
				}
			}

			if (m_GridColumnProperties != null)
			{
				if (m_GridColumnProperties.Count > 0)
					element.Children.AddNewElement("GridColumnProperties");

				foreach (GridColumnPropertieElement _item in GridColumnProperties)
				{
					PatternInstanceElement child = element.Children["GridColumnProperties"].Children.AddNewElement("GridColumnPropertie");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="VariableElement"/>.
		/// </summary>
		public VariableElement Clone()
		{
			VariableElement clone = new VariableElement();

			clone.Name = this.Name;
			clone.Description = this.Description;
			clone.Domain = this.Domain;
			clone.Attribute = this.Attribute;
			clone.LoadCode = this.LoadCode;
			clone.Visible = this.Visible;
			clone.ThemeClass = this.ThemeClass;
			clone.Format = this.Format;
			clone.IsValid = this.IsValid;
			clone.Readonly = this.Readonly;
			clone.MaskPicture = this.MaskPicture;
			clone.Reverse = this.Reverse;
			clone.Signed = this.Signed;
			clone.UnmaskedChars = this.UnmaskedChars;
			clone.UnmaskedValue = this.UnmaskedValue;
			clone.Width = this.Width;
			clone.Height = this.Height;
			foreach (LinkElement linkElement in this.Links)
				clone.Links.Add(linkElement.Clone());
			foreach (GridColumnPropertieElement gridColumnPropertieElement in this.GridColumnProperties)
				clone.GridColumnProperties.Add(gridColumnPropertieElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "link" :
				{
					if (Links != null && childIndex >= 0 && childIndex < Links.Count)
						return Links[childIndex].GetElement(path);
					else
						return null;
				}
				case "GridColumnProperties" :
				{
					if (path.Count == 0)
						return GridColumnProperties;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "GridColumnPropertie")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (GridColumnProperties != null && itemIndex >= 0 && itemIndex < GridColumnProperties.Count)
						return GridColumnProperties[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Format"/> property.
		/// </summary>
		public static class FormatValue
		{
			public const string Default = "<default>";
			public const string Text = "Text";
			public const string HTML = "HTML";
			public const string RawHTML = "Raw HTML";
			public const string TextWithMeaningfulSpaces = "Text with meaningful spaces";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: DynamicFilters

	public partial class DynamicFiltersElement : Artech.Common.Collections.BaseCollection<AttributeElement>
	{
		protected string m_ElementName;

		#region Construction

		internal DynamicFiltersElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<AttributeElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private FilterElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public FilterElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<AttributeElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of DynamicFiltersElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="AttributeElement"/> in the collection that has the specified value in its <see cref="Attribute"/> property.
		/// If no Attribute is found, <b>null</b> is returned.
		/// </summary>
		public AttributeElement FindAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			return this.Find(delegate (AttributeElement attributesItem) { return attributesItem.Attribute == attribute; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Dynamic Filters";
		}

		#endregion
	}

	#endregion

	#region Element: GridStandard

	public partial class GridStandardElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private System.String m_CustomRender;
		private bool m_IsCustomRenderDefault;
		private AttributesElement m_Attributes;
		private GridPropertiesElement m_GridProperties;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="GridStandardElement"/> class.
		/// </summary>
		public GridStandardElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GridStandardElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public GridStandardElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="GridStandardElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_CustomRender = "<default>";
			m_IsCustomRenderDefault = true;
			m_Attributes = new AttributesElement();
			m_Attributes.Parent = this;
			m_GridProperties = new GridPropertiesElement();
			m_GridProperties.Parent = this;
			m_GridProperties.ElementName = "GridProperties";
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="GridStandardElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Grid name.
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Grid description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Use a custom user control for rendering grids. Applies to all selection and grid tab objects.
		*/
		/// </summary>
		public System.String CustomRender
		{
			get { return m_CustomRender; }
			set 
			{
				m_CustomRender = value;
				m_IsCustomRenderDefault = false;
			}
		}

		public AttributesElement Attributes
		{
			get { return m_Attributes; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Attributes = value;
				m_Attributes.Parent = this;
			}
		}

		public GridPropertiesElement GridProperties
		{
			get { return m_GridProperties; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="GridPropertieElement"/> and adds it to the <see cref="GridProperties"/> collection.
		/// </summary>
		public GridPropertieElement AddGridPropertie()
		{
			GridPropertieElement gridPropertieElement = new GridPropertieElement();
			m_GridProperties.Add(gridPropertieElement);
			return gridPropertieElement;
		}

		/// <summary>
		/// Creates a new <see cref="GridPropertieElement"/> and adds it to the <see cref="GridProperties"/> collection.
		/// The GridPropertieElement is initialized with the specified value.
		/// </summary>
		public GridPropertieElement AddGridPropertie(System.String name)
		{
			GridPropertieElement gridPropertieElement = new GridPropertieElement(name);
			m_GridProperties.Add(gridPropertieElement);
			return gridPropertieElement;
		}

		/// <summary>
		/// Finds the <see cref="GridPropertieElement"/> in the <see cref="GridProperties"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridPropertieElement is found, null is returned.
		/// </summary>
		public GridPropertieElement FindGridPropertie(System.String name)
		{
			return GridProperties.Find(delegate (GridPropertieElement gridPropertieElement) { return gridPropertieElement.Name == name; });
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="GridStandardElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridStandard")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "GridStandard"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");
			m_CustomRender = element.Attributes.GetPropertyValue<System.String>("CustomRender");
			m_IsCustomRenderDefault = element.Attributes.IsPropertyDefault("CustomRender");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "attributes" :
					{
						AttributesElement attributes = new AttributesElement();
						attributes.LoadFrom(_childElement);
						Attributes = attributes;
						break;
					}
					case "GridProperties" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							GridPropertieElement gridPropertieElement = new GridPropertieElement();
							gridPropertieElement.LoadFrom(_childElementItem);
							GridProperties.Add(gridPropertieElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="GridStandardElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridStandard")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "GridStandard"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);
			SaveAttribute(element, "CustomRender", m_CustomRender, m_IsCustomRenderDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));

			// Save element children.
			if (m_Attributes != null)
			{
				PatternInstanceElement attributes = element.Children["attributes"];
				m_Attributes.SaveTo(attributes);
			}

			if (m_GridProperties != null)
			{
				if (m_GridProperties.Count > 0)
					element.Children.AddNewElement("GridProperties");

				foreach (GridPropertieElement _item in GridProperties)
				{
					PatternInstanceElement child = element.Children["GridProperties"].Children.AddNewElement("GridPropertie");
					_item.SaveTo(child);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="GridStandardElement"/>.
		/// </summary>
		public GridStandardElement Clone()
		{
			GridStandardElement clone = new GridStandardElement();

			clone.Name = this.Name;
			clone.Description = this.Description;
			clone.CustomRender = this.CustomRender;
			clone.Attributes = this.Attributes.Clone();
			foreach (GridPropertieElement gridPropertieElement in this.GridProperties)
				clone.GridProperties.Add(gridPropertieElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "attributes" :
				{
					if (Attributes != null)
						return Attributes.GetElement(path);
					else
						return null;
				}
				case "GridProperties" :
				{
					if (path.Count == 0)
						return GridProperties;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "GridPropertie")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (GridProperties != null && itemIndex >= 0 && itemIndex < GridProperties.Count)
						return GridProperties[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Grid Standard {0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: GridFreeStyle

	public partial class GridFreeStyleElement : IEnumerable<IHPatternInstanceElement>, IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private Artech.Common.Collections.BaseCollection<IHPatternInstanceElement> m_Items;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="GridFreeStyleElement"/> class.
		/// </summary>
		public GridFreeStyleElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GridFreeStyleElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public GridFreeStyleElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="GridFreeStyleElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_Items = new Artech.Common.Collections.BaseCollection<IHPatternInstanceElement>();
			m_Items.ItemAdded += new EventHandler<CollectionItemEventArgs<IHPatternInstanceElement>>(Items_ItemAdded);
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="GridFreeStyleElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Grid name.
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Grid description.
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<AttributeElement> Attributes
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<AttributeElement> tmpAttributes = new Artech.Common.Collections.BaseCollection<AttributeElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is AttributeElement)
						tmpAttributes.Add((AttributeElement)obj);

				return tmpAttributes.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<GridFreeStyleElement> GridFreeStyles
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<GridFreeStyleElement> tmpGridFreeStyles = new Artech.Common.Collections.BaseCollection<GridFreeStyleElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is GridFreeStyleElement)
						tmpGridFreeStyles.Add((GridFreeStyleElement)obj);

				return tmpGridFreeStyles.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<GridStandardElement> GridStandards
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<GridStandardElement> tmpGridStandards = new Artech.Common.Collections.BaseCollection<GridStandardElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is GridStandardElement)
						tmpGridStandards.Add((GridStandardElement)obj);

				return tmpGridStandards.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<IHPatternInstanceElement> Items
		{
			get { return m_Items; }
		}

		public IEnumerator<IHPatternInstanceElement> GetEnumerator()
		{
			return m_Items.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((System.Collections.IEnumerable)m_Items).GetEnumerator();
		}

		#endregion

		#region Helper methods

		public void Add(IHPatternInstanceElement item)
		{
			m_Items.Add(item);
		}

		/// <summary>
		/// Creates a new <see cref="AttributeElement"/> and adds it to the <see cref="Attributes"/> collection.
		/// </summary>
		public AttributeElement AddAttribute()
		{
			AttributeElement attributeElement = new AttributeElement();
			m_Items.Add(attributeElement);
			return attributeElement;
		}

		/// <summary>
		/// Creates a new <see cref="AttributeElement"/> and adds it to the <see cref="Attributes"/> collection.
		/// The AttributeElement is initialized with the specified value.
		/// </summary>
		public AttributeElement AddAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			AttributeElement attributeElement = new AttributeElement(attribute);
			m_Items.Add(attributeElement);
			return attributeElement;
		}

		/// <summary>
		/// Finds the <see cref="AttributeElement"/> in the <see cref="Attributes"/> collection that has the specified value in its <see cref="Attribute"/> property.
		/// If no attributeElement is found, null is returned.
		/// </summary>
		public AttributeElement FindAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			return Attributes.Find(delegate (AttributeElement attributeElement) { return attributeElement.Attribute == attribute; });
		}

		private void Attributes_ItemAdded(object sender, CollectionItemEventArgs<AttributeElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="GridFreeStyleElement"/> and adds it to the <see cref="GridFreeStyles"/> collection.
		/// </summary>
		public GridFreeStyleElement AddGridFreeStyle()
		{
			GridFreeStyleElement gridFreeStyleElement = new GridFreeStyleElement();
			m_Items.Add(gridFreeStyleElement);
			return gridFreeStyleElement;
		}

		/// <summary>
		/// Creates a new <see cref="GridFreeStyleElement"/> and adds it to the <see cref="GridFreeStyles"/> collection.
		/// The GridFreeStyleElement is initialized with the specified value.
		/// </summary>
		public GridFreeStyleElement AddGridFreeStyle(System.String name)
		{
			GridFreeStyleElement gridFreeStyleElement = new GridFreeStyleElement(name);
			m_Items.Add(gridFreeStyleElement);
			return gridFreeStyleElement;
		}

		/// <summary>
		/// Finds the <see cref="GridFreeStyleElement"/> in the <see cref="GridFreeStyles"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridFreeStyleElement is found, null is returned.
		/// </summary>
		public GridFreeStyleElement FindGridFreeStyle(System.String name)
		{
			return GridFreeStyles.Find(delegate (GridFreeStyleElement gridFreeStyleElement) { return gridFreeStyleElement.Name == name; });
		}

		private void GridFreeStyles_ItemAdded(object sender, CollectionItemEventArgs<GridFreeStyleElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="GridStandardElement"/> and adds it to the <see cref="GridStandards"/> collection.
		/// </summary>
		public GridStandardElement AddGridStandard()
		{
			GridStandardElement gridStandardElement = new GridStandardElement();
			m_Items.Add(gridStandardElement);
			return gridStandardElement;
		}

		/// <summary>
		/// Creates a new <see cref="GridStandardElement"/> and adds it to the <see cref="GridStandards"/> collection.
		/// The GridStandardElement is initialized with the specified value.
		/// </summary>
		public GridStandardElement AddGridStandard(System.String name)
		{
			GridStandardElement gridStandardElement = new GridStandardElement(name);
			m_Items.Add(gridStandardElement);
			return gridStandardElement;
		}

		/// <summary>
		/// Finds the <see cref="GridStandardElement"/> in the <see cref="GridStandards"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridStandardElement is found, null is returned.
		/// </summary>
		public GridStandardElement FindGridStandard(System.String name)
		{
			return GridStandards.Find(delegate (GridStandardElement gridStandardElement) { return gridStandardElement.Name == name; });
		}

		private void GridStandards_ItemAdded(object sender, CollectionItemEventArgs<GridStandardElement> e)
		{
			e.Data.Parent = this;
		}

		private void Items_ItemAdded(object sender, CollectionItemEventArgs<IHPatternInstanceElement> e)
		{
			if (e.Data is AttributeElement)
				((AttributeElement)e.Data).Parent = this;
			else if (e.Data is GridFreeStyleElement)
				((GridFreeStyleElement)e.Data).Parent = this;
			else if (e.Data is GridStandardElement)
				((GridStandardElement)e.Data).Parent = this;
			else
				throw new PatternInstanceException(String.Format("An object of an unexpected type {0} was added as child of {1}.", e.Data.GetType(), this.GetType()));
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="GridFreeStyleElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridFreeStyle")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "GridFreeStyle"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "attribute" :
					{
						AttributeElement attribute = new AttributeElement();
						attribute.LoadFrom(_childElement);
						Add(attribute);
						break;
					}
					case "gridFreeStyle" :
					{
						GridFreeStyleElement gridFreeStyle = new GridFreeStyleElement();
						gridFreeStyle.LoadFrom(_childElement);
						Add(gridFreeStyle);
						break;
					}
					case "gridStandard" :
					{
						GridStandardElement gridStandard = new GridStandardElement();
						gridStandard.LoadFrom(_childElement);
						Add(gridStandard);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="GridFreeStyleElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "GridFreeStyle")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "GridFreeStyle"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));

			// Save element children.
			foreach (IHPatternInstanceElement _obj in m_Items)
			{
				if (_obj is AttributeElement)
				{
					PatternInstanceElement attribute = element.Children.AddNewElement("attribute");
					((AttributeElement)_obj).SaveTo(attribute);
				}
				else if (_obj is GridFreeStyleElement)
				{
					PatternInstanceElement gridFreeStyle = element.Children.AddNewElement("gridFreeStyle");
					((GridFreeStyleElement)_obj).SaveTo(gridFreeStyle);
				}
				else if (_obj is GridStandardElement)
				{
					PatternInstanceElement gridStandard = element.Children.AddNewElement("gridStandard");
					((GridStandardElement)_obj).SaveTo(gridStandard);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="GridFreeStyleElement"/>.
		/// </summary>
		public GridFreeStyleElement Clone()
		{
			GridFreeStyleElement clone = new GridFreeStyleElement();

			clone.Name = this.Name;
			clone.Description = this.Description;
			foreach (IHPatternInstanceElement element in this)
				clone.Add(element.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "attribute" :
				{
					if (Attributes != null && childIndex >= 0 && childIndex < Attributes.Count)
						return Attributes[childIndex].GetElement(path);
					else
						return null;
				}
				case "gridFreeStyle" :
				{
					if (GridFreeStyles != null && childIndex >= 0 && childIndex < GridFreeStyles.Count)
						return GridFreeStyles[childIndex].GetElement(path);
					else
						return null;
				}
				case "gridStandard" :
				{
					if (GridStandards != null && childIndex >= 0 && childIndex < GridStandards.Count)
						return GridStandards[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Grid FreeStyle {0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: Form

	public partial class FormElement : IEnumerable<IHPatternInstanceElement>, IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.Boolean m_ExternalTab;
		private bool m_IsExternalTabDefault;
		private GroupsElement m_Groups;
		private Artech.Common.Collections.BaseCollection<IHPatternInstanceElement> m_Items;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="FormElement"/> class.
		/// </summary>
		public FormElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="FormElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_ExternalTab = false;
			m_IsExternalTabDefault = true;
			m_Groups = new GroupsElement();
			m_Groups.Parent = this;
			m_Groups.ElementName = "groups";
			m_Items = new Artech.Common.Collections.BaseCollection<IHPatternInstanceElement>();
			m_Items.ItemAdded += new EventHandler<CollectionItemEventArgs<IHPatternInstanceElement>>(Items_ItemAdded);
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="FormElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Define se as abas seram controladas fora deste objeto
		*/
		/// </summary>
		public System.Boolean ExternalTab
		{
			get { return m_ExternalTab; }
			set 
			{
				m_ExternalTab = value;
				m_IsExternalTabDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<RowElement> Rows
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<RowElement> tmpRows = new Artech.Common.Collections.BaseCollection<RowElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is RowElement)
						tmpRows.Add((RowElement)obj);

				return tmpRows.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<TabFormElement> Tabs
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<TabFormElement> tmpTabs = new Artech.Common.Collections.BaseCollection<TabFormElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is TabFormElement)
						tmpTabs.Add((TabFormElement)obj);

				return tmpTabs.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<UserTableElement> UserTables
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<UserTableElement> tmpUserTables = new Artech.Common.Collections.BaseCollection<UserTableElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is UserTableElement)
						tmpUserTables.Add((UserTableElement)obj);

				return tmpUserTables.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<TransactionAttributeElement> TransactionAttributes
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<TransactionAttributeElement> tmpTransactionAttributes = new Artech.Common.Collections.BaseCollection<TransactionAttributeElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is TransactionAttributeElement)
						tmpTransactionAttributes.Add((TransactionAttributeElement)obj);

				return tmpTransactionAttributes.AsReadOnly();
			}
		}

		public GroupsElement Groups
		{
			get { return m_Groups; }
		}

		public Artech.Common.Collections.IBaseCollection<IHPatternInstanceElement> Items
		{
			get { return m_Items; }
		}

		public IEnumerator<IHPatternInstanceElement> GetEnumerator()
		{
			return m_Items.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((System.Collections.IEnumerable)m_Items).GetEnumerator();
		}

		#endregion

		#region Helper methods

		public void Add(IHPatternInstanceElement item)
		{
			m_Items.Add(item);
		}

		/// <summary>
		/// Creates a new <see cref="RowElement"/> and adds it to the <see cref="Rows"/> collection.
		/// </summary>
		public RowElement AddRow()
		{
			RowElement rowElement = new RowElement();
			m_Items.Add(rowElement);
			return rowElement;
		}

		private void Rows_ItemAdded(object sender, CollectionItemEventArgs<RowElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="TabFormElement"/> and adds it to the <see cref="Tabs"/> collection.
		/// </summary>
		public TabFormElement AddTabForm()
		{
			TabFormElement tabFormElement = new TabFormElement();
			m_Items.Add(tabFormElement);
			return tabFormElement;
		}

		/// <summary>
		/// Creates a new <see cref="TabFormElement"/> and adds it to the <see cref="Tabs"/> collection.
		/// The TabFormElement is initialized with the specified value.
		/// </summary>
		public TabFormElement AddTabForm(System.String name)
		{
			TabFormElement tabFormElement = new TabFormElement(name);
			m_Items.Add(tabFormElement);
			return tabFormElement;
		}

		/// <summary>
		/// Finds the <see cref="TabFormElement"/> in the <see cref="Tabs"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no tabFormElement is found, null is returned.
		/// </summary>
		public TabFormElement FindTabForm(System.String name)
		{
			return Tabs.Find(delegate (TabFormElement tabFormElement) { return tabFormElement.Name == name; });
		}

		private void Tabs_ItemAdded(object sender, CollectionItemEventArgs<TabFormElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="UserTableElement"/> and adds it to the <see cref="UserTables"/> collection.
		/// </summary>
		public UserTableElement AddUserTable()
		{
			UserTableElement userTableElement = new UserTableElement();
			m_Items.Add(userTableElement);
			return userTableElement;
		}

		/// <summary>
		/// Creates a new <see cref="UserTableElement"/> and adds it to the <see cref="UserTables"/> collection.
		/// The UserTableElement is initialized with the specified value.
		/// </summary>
		public UserTableElement AddUserTable(System.String name)
		{
			UserTableElement userTableElement = new UserTableElement(name);
			m_Items.Add(userTableElement);
			return userTableElement;
		}

		/// <summary>
		/// Finds the <see cref="UserTableElement"/> in the <see cref="UserTables"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no userTableElement is found, null is returned.
		/// </summary>
		public UserTableElement FindUserTable(System.String name)
		{
			return UserTables.Find(delegate (UserTableElement userTableElement) { return userTableElement.Name == name; });
		}

		private void UserTables_ItemAdded(object sender, CollectionItemEventArgs<UserTableElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="TransactionAttributeElement"/> and adds it to the <see cref="TransactionAttributes"/> collection.
		/// </summary>
		public TransactionAttributeElement AddTransactionAttribute()
		{
			TransactionAttributeElement transactionAttributeElement = new TransactionAttributeElement();
			m_Items.Add(transactionAttributeElement);
			return transactionAttributeElement;
		}

		private void TransactionAttributes_ItemAdded(object sender, CollectionItemEventArgs<TransactionAttributeElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="GroupTabElement"/> and adds it to the <see cref="Groups"/> collection.
		/// </summary>
		public GroupTabElement AddGroupTab()
		{
			GroupTabElement groupTabElement = new GroupTabElement();
			m_Items.Add(groupTabElement);
			return groupTabElement;
		}

		/// <summary>
		/// Creates a new <see cref="GroupTabElement"/> and adds it to the <see cref="Groups"/> collection.
		/// The GroupTabElement is initialized with the specified value.
		/// </summary>
		public GroupTabElement AddGroupTab(System.String name)
		{
			GroupTabElement groupTabElement = new GroupTabElement(name);
			m_Items.Add(groupTabElement);
			return groupTabElement;
		}

		/// <summary>
		/// Finds the <see cref="GroupTabElement"/> in the <see cref="Groups"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no groupTabElement is found, null is returned.
		/// </summary>
		public GroupTabElement FindGroupTab(System.String name)
		{
			return Groups.Find(delegate (GroupTabElement groupTabElement) { return groupTabElement.Name == name; });
		}

		private void Items_ItemAdded(object sender, CollectionItemEventArgs<IHPatternInstanceElement> e)
		{
			if (e.Data is RowElement)
				((RowElement)e.Data).Parent = this;
			else if (e.Data is TabFormElement)
				((TabFormElement)e.Data).Parent = this;
			else if (e.Data is UserTableElement)
				((UserTableElement)e.Data).Parent = this;
			else if (e.Data is TransactionAttributeElement)
				((TransactionAttributeElement)e.Data).Parent = this;
			else
				throw new PatternInstanceException(String.Format("An object of an unexpected type {0} was added as child of {1}.", e.Data.GetType(), this.GetType()));
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="FormElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Form")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Form"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_ExternalTab = element.Attributes.GetPropertyValue<System.Boolean>("externalTab");
			m_IsExternalTabDefault = element.Attributes.IsPropertyDefault("externalTab");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "row" :
					{
						RowElement row = new RowElement();
						row.LoadFrom(_childElement);
						Add(row);
						break;
					}
					case "tab" :
					{
						TabFormElement tab = new TabFormElement();
						tab.LoadFrom(_childElement);
						Add(tab);
						break;
					}
					case "userTable" :
					{
						UserTableElement userTable = new UserTableElement();
						userTable.LoadFrom(_childElement);
						Add(userTable);
						break;
					}
					case "TransactionAttribute" :
					{
						TransactionAttributeElement transactionAttribute = new TransactionAttributeElement();
						transactionAttribute.LoadFrom(_childElement);
						Add(transactionAttribute);
						break;
					}
					case "groups" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							GroupTabElement groupTabElement = new GroupTabElement();
							groupTabElement.LoadFrom(_childElementItem);
							Groups.Add(groupTabElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="FormElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Form")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Form"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "externalTab", m_ExternalTab, m_IsExternalTabDefault);

			Debug.Assert(m_ExternalTab == element.Attributes.GetPropertyValue<System.Boolean>("externalTab"));

			// Save element children.
			if (m_Groups != null)
			{
				foreach (GroupTabElement _item in Groups)
				{
					PatternInstanceElement child = element.Children["groups"].Children.AddNewElement("groupTab");
					_item.SaveTo(child);
				}
			}
			foreach (IHPatternInstanceElement _obj in m_Items)
			{
				if (_obj is RowElement)
				{
					PatternInstanceElement row = element.Children.AddNewElement("row");
					((RowElement)_obj).SaveTo(row);
				}
				else if (_obj is TabFormElement)
				{
					PatternInstanceElement tab = element.Children.AddNewElement("tab");
					((TabFormElement)_obj).SaveTo(tab);
				}
				else if (_obj is UserTableElement)
				{
					PatternInstanceElement userTable = element.Children.AddNewElement("userTable");
					((UserTableElement)_obj).SaveTo(userTable);
				}
				else if (_obj is TransactionAttributeElement)
				{
					PatternInstanceElement transactionAttribute = element.Children.AddNewElement("TransactionAttribute");
					((TransactionAttributeElement)_obj).SaveTo(transactionAttribute);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="FormElement"/>.
		/// </summary>
		public FormElement Clone()
		{
			FormElement clone = new FormElement();

			clone.ExternalTab = this.ExternalTab;
			foreach (GroupTabElement groupTabElement in this.Groups)
				clone.Groups.Add(groupTabElement.Clone());
			foreach (IHPatternInstanceElement element in this)
				clone.Add(element.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "row" :
				{
					if (Rows != null && childIndex >= 0 && childIndex < Rows.Count)
						return Rows[childIndex].GetElement(path);
					else
						return null;
				}
				case "tab" :
				{
					if (Tabs != null && childIndex >= 0 && childIndex < Tabs.Count)
						return Tabs[childIndex].GetElement(path);
					else
						return null;
				}
				case "userTable" :
				{
					if (UserTables != null && childIndex >= 0 && childIndex < UserTables.Count)
						return UserTables[childIndex].GetElement(path);
					else
						return null;
				}
				case "TransactionAttribute" :
				{
					if (TransactionAttributes != null && childIndex >= 0 && childIndex < TransactionAttributes.Count)
						return TransactionAttributes[childIndex].GetElement(path);
					else
						return null;
				}
				case "groups" :
				{
					if (path.Count == 0)
						return Groups;

					string itemName; int itemIndex;
					HPatternInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "groupTab")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Groups != null && itemIndex >= 0 && itemIndex < Groups.Count)
						return Groups[itemIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Form";
		}

		#endregion
	}

	#endregion

	#region Element: UserTable

	public partial class UserTableElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="UserTableElement"/> class.
		/// </summary>
		public UserTableElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UserTableElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public UserTableElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="UserTableElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="UserTableElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="UserTableElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "UserTable")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "UserTable"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
		}

		/// <summary>
		/// Saves the current <see cref="UserTableElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "UserTable")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "UserTable"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="UserTableElement"/>.
		/// </summary>
		public UserTableElement Clone()
		{
			UserTableElement clone = new UserTableElement();

			clone.Name = this.Name;

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "UserTable", Name);
		}

		#endregion
	}

	#endregion

	#region Element: TabForm

	public partial class TabFormElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Description;
		private bool m_IsDescriptionDefault;
		private System.String m_ObjName;
		private bool m_IsObjNameDefault;
		private System.String m_Condition;
		private bool m_IsConditionDefault;
		private System.String m_Group;
		private bool m_IsGroupDefault;
		private Artech.Genexus.Common.Objects.Image m_Image;
		private KBObjectReference m_ImageReference;
		private bool m_IsImageDefault;
		private System.String m_UpdateObject;
		private bool m_IsUpdateObjectDefault;
		private Artech.Common.Collections.BaseCollection<RowElement> m_Rows;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="TabFormElement"/> class.
		/// </summary>
		public TabFormElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TabFormElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public TabFormElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="TabFormElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Description = "";
			m_IsDescriptionDefault = true;
			m_ObjName = "";
			m_IsObjNameDefault = true;
			m_Condition = "";
			m_IsConditionDefault = true;
			m_Group = null;
			m_IsGroupDefault = true;
			m_Image = null;
			m_ImageReference = null;
			m_IsImageDefault = true;
			m_UpdateObject = "Create default";
			m_IsUpdateObjectDefault = true;
			m_Rows = new Artech.Common.Collections.BaseCollection<RowElement>();
			m_Rows.ItemAdded += new EventHandler<CollectionItemEventArgs<RowElement>>(Rows_ItemAdded);
		}

		#endregion

		#region Properties

		private FormElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="TabFormElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public FormElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Código único da Aba
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Descrição da aba
		*/
		/// </summary>
		public System.String Description
		{
			get { return m_Description; }
			set 
			{
				m_Description = value;
				m_IsDescriptionDefault = false;
			}
		}

		/// <summary>
		/*
		Object Name
		*/
		/// </summary>
		public System.String ObjName
		{
			get { return m_ObjName; }
			set 
			{
				m_ObjName = value;
				m_IsObjNameDefault = false;
			}
		}

		/// <summary>
		/*
		Condition to determine whether the Tab will be shown.
		*/
		/// </summary>
		public System.String Condition
		{
			get { return m_Condition; }
			set 
			{
				m_Condition = value;
				m_IsConditionDefault = false;
			}
		}

		/// <summary>
		/*
		Define o Grupo da Aba
		*/
		/// </summary>
		public System.String Group
		{
			get { return m_Group; }
			set 
			{
				m_Group = value;
				m_IsGroupDefault = false;
			}
		}

		/// <summary>
		/*
		Define o icone
		*/
		/// </summary>
		public Artech.Genexus.Common.Objects.Image Image
		{
			get
			{
				if (m_Image == null && m_ImageReference != null)
					m_Image = (Artech.Genexus.Common.Objects.Image)m_ImageReference.GetKBObject(Instance.Model);

				return m_Image;
			}

			set 
			{
				m_Image = value;
				m_ImageReference = (value != null ? new KBObjectReference(value) : null);
				m_IsImageDefault = false;
			}
		}

		/// <summary>
		/// Image name.
		/// </summary>
		public string ImageName
		{
			get { return (Image != null ? Image.Name : null); }
		}

		/// <summary>
		/*
		Do not update - Não atualiza o Objecto
		/// Create default - Atualiza o Objeto e mantem o código atual
		/// Only Rules, Events and Conditions - Atualiza somente as regras, eventos e condições e mantem o código atual
		/// Overwrite - Atualiza o objeto sobrescrevendo o código atual
		*/
		/// </summary>
		public System.String UpdateObject
		{
			get { return m_UpdateObject; }
			set 
			{
				m_UpdateObject = value;
				m_IsUpdateObjectDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<RowElement> Rows
		{
			get { return m_Rows; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="RowElement"/> and adds it to the <see cref="Rows"/> collection.
		/// </summary>
		public RowElement AddRow()
		{
			RowElement rowElement = new RowElement();
			m_Rows.Add(rowElement);
			return rowElement;
		}

		private void Rows_ItemAdded(object sender, CollectionItemEventArgs<RowElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="TabFormElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "TabForm")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "TabForm"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Description = element.Attributes.GetPropertyValue<System.String>("description");
			m_IsDescriptionDefault = element.Attributes.IsPropertyDefault("description");
			m_ObjName = element.Attributes.GetPropertyValue<System.String>("objName");
			m_IsObjNameDefault = element.Attributes.IsPropertyDefault("objName");
			m_Condition = element.Attributes.GetPropertyValue<System.String>("condition");
			m_IsConditionDefault = element.Attributes.IsPropertyDefault("condition");
			m_Group = element.Attributes.GetPropertyValue<System.String>("group");
			m_IsGroupDefault = element.Attributes.IsPropertyDefault("group");
			m_ImageReference = element.Attributes.GetPropertyValue<KBObjectReference>("imageReference");
			m_IsImageDefault = element.Attributes.IsPropertyDefault("image");
			m_UpdateObject = element.Attributes.GetPropertyValue<System.String>("updateObject");
			m_IsUpdateObjectDefault = element.Attributes.IsPropertyDefault("updateObject");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "row" :
					{
						RowElement row = new RowElement();
						row.LoadFrom(_childElement);
						Rows.Add(row);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="TabFormElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "TabForm")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "TabForm"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "description", m_Description, m_IsDescriptionDefault);
			SaveAttribute(element, "objName", m_ObjName, m_IsObjNameDefault);
			SaveAttribute(element, "condition", m_Condition, m_IsConditionDefault);
			SaveAttribute(element, "group", m_Group, m_IsGroupDefault);
			SaveAttribute(element, "imageReference", m_ImageReference, m_IsImageDefault);
			SaveAttribute(element, "updateObject", m_UpdateObject, m_IsUpdateObjectDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_Description == element.Attributes.GetPropertyValue<System.String>("description"));
			Debug.Assert(m_ObjName == element.Attributes.GetPropertyValue<System.String>("objName"));
			Debug.Assert(m_Condition == element.Attributes.GetPropertyValue<System.String>("condition"));
			Debug.Assert(m_ImageReference == element.Attributes.GetPropertyValue<KBObjectReference>("imageReference"));
			Debug.Assert(m_UpdateObject == element.Attributes.GetPropertyValue<System.String>("updateObject"));

			// Save element children.
			if (m_Rows != null)
			{
				foreach (RowElement _item in Rows)
				{
					PatternInstanceElement row = element.Children.AddNewElement("row");
					_item.SaveTo(row);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="TabFormElement"/>.
		/// </summary>
		public TabFormElement Clone()
		{
			TabFormElement clone = new TabFormElement();

			clone.Name = this.Name;
			clone.Description = this.Description;
			clone.ObjName = this.ObjName;
			clone.Condition = this.Condition;
			clone.Group = this.Group;
			clone.Image = this.Image;
			clone.UpdateObject = this.UpdateObject;
			foreach (RowElement rowElement in this.Rows)
				clone.Rows.Add(rowElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "row" :
				{
					if (Rows != null && childIndex >= 0 && childIndex < Rows.Count)
						return Rows[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="UpdateObject"/> property.
		/// </summary>
		public static class UpdateObjectValue
		{
			public const string DoNotUpdate = "Do not update";
			public const string CreateDefault = "Create default";
			public const string OnlyRulesEventsAndConditions = "Only Rules, Events and Conditions";
			public const string Overwrite = "Overwrite";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Tab {0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: FRow

	public partial class FRowElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private Artech.Common.Collections.BaseCollection<FColElement> m_Columns;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="FRowElement"/> class.
		/// </summary>
		public FRowElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="FRowElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Columns = new Artech.Common.Collections.BaseCollection<FColElement>();
			m_Columns.ItemAdded += new EventHandler<CollectionItemEventArgs<FColElement>>(Columns_ItemAdded);
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="FRowElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		public Artech.Common.Collections.IBaseCollection<FColElement> Columns
		{
			get { return m_Columns; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="FColElement"/> and adds it to the <see cref="Columns"/> collection.
		/// </summary>
		public FColElement AddFCol()
		{
			FColElement fColElement = new FColElement();
			m_Columns.Add(fColElement);
			return fColElement;
		}

		private void Columns_ItemAdded(object sender, CollectionItemEventArgs<FColElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="FRowElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "FRow")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "FRow"));

			Initialize();
			m_ElementName = element.Name;

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "column" :
					{
						FColElement column = new FColElement();
						column.LoadFrom(_childElement);
						Columns.Add(column);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="FRowElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "FRow")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "FRow"));

			element.Initialize();

			// Save element children.
			if (m_Columns != null)
			{
				foreach (FColElement _item in Columns)
				{
					PatternInstanceElement column = element.Children.AddNewElement("column");
					_item.SaveTo(column);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="FRowElement"/>.
		/// </summary>
		public FRowElement Clone()
		{
			FRowElement clone = new FRowElement();
			foreach (FColElement fColElement in this.Columns)
				clone.Columns.Add(fColElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "column" :
				{
					if (Columns != null && childIndex >= 0 && childIndex < Columns.Count)
						return Columns[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Row";
		}

		#endregion
	}

	#endregion

	#region Element: FCol

	public partial class FColElement : IEnumerable<IHPatternInstanceElement>, IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.Int32 m_ColSpan;
		private bool m_IsColSpanDefault;
		private System.Int32 m_RowSpan;
		private bool m_IsRowSpanDefault;
		private System.String m_Align;
		private bool m_IsAlignDefault;
		private Artech.Common.Collections.BaseCollection<IHPatternInstanceElement> m_Items;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="FColElement"/> class.
		/// </summary>
		public FColElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="FColElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_ColSpan = 1;
			m_IsColSpanDefault = true;
			m_RowSpan = 1;
			m_IsRowSpanDefault = true;
			m_Align = "default";
			m_IsAlignDefault = true;
			m_Items = new Artech.Common.Collections.BaseCollection<IHPatternInstanceElement>();
			m_Items.ItemAdded += new EventHandler<CollectionItemEventArgs<IHPatternInstanceElement>>(Items_ItemAdded);
		}

		#endregion

		#region Properties

		private FRowElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="FColElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public FRowElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		ColSpan
		*/
		/// </summary>
		public System.Int32 ColSpan
		{
			get { return m_ColSpan; }
			set 
			{
				m_ColSpan = value;
				m_IsColSpanDefault = false;
			}
		}

		/// <summary>
		/*
		colSpan
		*/
		/// </summary>
		public System.Int32 RowSpan
		{
			get { return m_RowSpan; }
			set 
			{
				m_RowSpan = value;
				m_IsRowSpanDefault = false;
			}
		}

		/// <summary>
		/*
		Define propriedade Align da celula
		*/
		/// </summary>
		public System.String Align
		{
			get { return m_Align; }
			set 
			{
				m_Align = value;
				m_IsAlignDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<FilterAttributeElement> FilterAttributes
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<FilterAttributeElement> tmpFilterAttributes = new Artech.Common.Collections.BaseCollection<FilterAttributeElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is FilterAttributeElement)
						tmpFilterAttributes.Add((FilterAttributeElement)obj);

				return tmpFilterAttributes.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<TextElement> Texts
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<TextElement> tmpTexts = new Artech.Common.Collections.BaseCollection<TextElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is TextElement)
						tmpTexts.Add((TextElement)obj);

				return tmpTexts.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<FGroupElement> Groups
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<FGroupElement> tmpGroups = new Artech.Common.Collections.BaseCollection<FGroupElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is FGroupElement)
						tmpGroups.Add((FGroupElement)obj);

				return tmpGroups.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<IHPatternInstanceElement> Items
		{
			get { return m_Items; }
		}

		public IEnumerator<IHPatternInstanceElement> GetEnumerator()
		{
			return m_Items.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((System.Collections.IEnumerable)m_Items).GetEnumerator();
		}

		#endregion

		#region Helper methods

		public void Add(IHPatternInstanceElement item)
		{
			m_Items.Add(item);
		}

		/// <summary>
		/// Creates a new <see cref="FilterAttributeElement"/> and adds it to the <see cref="FilterAttributes"/> collection.
		/// </summary>
		public FilterAttributeElement AddFilterAttribute()
		{
			FilterAttributeElement filterAttributeElement = new FilterAttributeElement();
			m_Items.Add(filterAttributeElement);
			return filterAttributeElement;
		}

		/// <summary>
		/// Creates a new <see cref="FilterAttributeElement"/> and adds it to the <see cref="FilterAttributes"/> collection.
		/// The FilterAttributeElement is initialized with the specified value.
		/// </summary>
		public FilterAttributeElement AddFilterAttribute(System.String name)
		{
			FilterAttributeElement filterAttributeElement = new FilterAttributeElement(name);
			m_Items.Add(filterAttributeElement);
			return filterAttributeElement;
		}

		/// <summary>
		/// Finds the <see cref="FilterAttributeElement"/> in the <see cref="FilterAttributes"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no filterAttributeElement is found, null is returned.
		/// </summary>
		public FilterAttributeElement FindFilterAttribute(System.String name)
		{
			return FilterAttributes.Find(delegate (FilterAttributeElement filterAttributeElement) { return filterAttributeElement.Name == name; });
		}

		private void FilterAttributes_ItemAdded(object sender, CollectionItemEventArgs<FilterAttributeElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="TextElement"/> and adds it to the <see cref="Texts"/> collection.
		/// </summary>
		public TextElement AddText()
		{
			TextElement textElement = new TextElement();
			m_Items.Add(textElement);
			return textElement;
		}

		/// <summary>
		/// Creates a new <see cref="TextElement"/> and adds it to the <see cref="Texts"/> collection.
		/// The TextElement is initialized with the specified value.
		/// </summary>
		public TextElement AddText(System.String name)
		{
			TextElement textElement = new TextElement(name);
			m_Items.Add(textElement);
			return textElement;
		}

		/// <summary>
		/// Finds the <see cref="TextElement"/> in the <see cref="Texts"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no textElement is found, null is returned.
		/// </summary>
		public TextElement FindText(System.String name)
		{
			return Texts.Find(delegate (TextElement textElement) { return textElement.Name == name; });
		}

		private void Texts_ItemAdded(object sender, CollectionItemEventArgs<TextElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="FGroupElement"/> and adds it to the <see cref="Groups"/> collection.
		/// </summary>
		public FGroupElement AddFGroup()
		{
			FGroupElement fGroupElement = new FGroupElement();
			m_Items.Add(fGroupElement);
			return fGroupElement;
		}

		private void Groups_ItemAdded(object sender, CollectionItemEventArgs<FGroupElement> e)
		{
			e.Data.Parent = this;
		}

		private void Items_ItemAdded(object sender, CollectionItemEventArgs<IHPatternInstanceElement> e)
		{
			if (e.Data is FilterAttributeElement)
				((FilterAttributeElement)e.Data).Parent = this;
			else if (e.Data is TextElement)
				((TextElement)e.Data).Parent = this;
			else if (e.Data is FGroupElement)
				((FGroupElement)e.Data).Parent = this;
			else
				throw new PatternInstanceException(String.Format("An object of an unexpected type {0} was added as child of {1}.", e.Data.GetType(), this.GetType()));
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="FColElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "FCol")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "FCol"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_ColSpan = element.Attributes.GetPropertyValue<System.Int32>("ColSpan");
			m_IsColSpanDefault = element.Attributes.IsPropertyDefault("ColSpan");
			m_RowSpan = element.Attributes.GetPropertyValue<System.Int32>("RowSpan");
			m_IsRowSpanDefault = element.Attributes.IsPropertyDefault("RowSpan");
			m_Align = element.Attributes.GetPropertyValue<System.String>("Align");
			m_IsAlignDefault = element.Attributes.IsPropertyDefault("Align");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "filterAttribute" :
					{
						FilterAttributeElement filterAttribute = new FilterAttributeElement();
						filterAttribute.LoadFrom(_childElement);
						Add(filterAttribute);
						break;
					}
					case "text" :
					{
						TextElement text = new TextElement();
						text.LoadFrom(_childElement);
						Add(text);
						break;
					}
					case "group" :
					{
						FGroupElement group = new FGroupElement();
						group.LoadFrom(_childElement);
						Add(group);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="FColElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "FCol")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "FCol"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "ColSpan", m_ColSpan, m_IsColSpanDefault);
			SaveAttribute(element, "RowSpan", m_RowSpan, m_IsRowSpanDefault);
			SaveAttribute(element, "Align", m_Align, m_IsAlignDefault);

			Debug.Assert(m_ColSpan == element.Attributes.GetPropertyValue<System.Int32>("ColSpan"));
			Debug.Assert(m_RowSpan == element.Attributes.GetPropertyValue<System.Int32>("RowSpan"));
			Debug.Assert(m_Align == element.Attributes.GetPropertyValue<System.String>("Align"));

			// Save element children.
			foreach (IHPatternInstanceElement _obj in m_Items)
			{
				if (_obj is FilterAttributeElement)
				{
					PatternInstanceElement filterAttribute = element.Children.AddNewElement("filterAttribute");
					((FilterAttributeElement)_obj).SaveTo(filterAttribute);
				}
				else if (_obj is TextElement)
				{
					PatternInstanceElement text = element.Children.AddNewElement("text");
					((TextElement)_obj).SaveTo(text);
				}
				else if (_obj is FGroupElement)
				{
					PatternInstanceElement group = element.Children.AddNewElement("group");
					((FGroupElement)_obj).SaveTo(group);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="FColElement"/>.
		/// </summary>
		public FColElement Clone()
		{
			FColElement clone = new FColElement();

			clone.ColSpan = this.ColSpan;
			clone.RowSpan = this.RowSpan;
			clone.Align = this.Align;
			foreach (IHPatternInstanceElement element in this)
				clone.Add(element.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "filterAttribute" :
				{
					if (FilterAttributes != null && childIndex >= 0 && childIndex < FilterAttributes.Count)
						return FilterAttributes[childIndex].GetElement(path);
					else
						return null;
				}
				case "text" :
				{
					if (Texts != null && childIndex >= 0 && childIndex < Texts.Count)
						return Texts[childIndex].GetElement(path);
					else
						return null;
				}
				case "group" :
				{
					if (Groups != null && childIndex >= 0 && childIndex < Groups.Count)
						return Groups[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Align"/> property.
		/// </summary>
		public static class AlignValue
		{
			public const string Default = "default";
			public const string Right = "Right";
			public const string Left = "Left";
			public const string Center = "Center";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Column";
		}

		#endregion
	}

	#endregion

	#region Element: FGroup

	public partial class FGroupElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Caption;
		private bool m_IsCaptionDefault;
		private System.String m_Class;
		private bool m_IsClassDefault;
		private Artech.Common.Collections.BaseCollection<FRowElement> m_Rows;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="FGroupElement"/> class.
		/// </summary>
		public FGroupElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="FGroupElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Caption = "";
			m_IsCaptionDefault = true;
			m_Class = null;
			m_IsClassDefault = true;
			m_Rows = new Artech.Common.Collections.BaseCollection<FRowElement>();
			m_Rows.ItemAdded += new EventHandler<CollectionItemEventArgs<FRowElement>>(Rows_ItemAdded);
		}

		#endregion

		#region Properties

		private FColElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="FGroupElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public FColElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Caption
		*/
		/// </summary>
		public System.String Caption
		{
			get { return m_Caption; }
			set 
			{
				m_Caption = value;
				m_IsCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		Class
		*/
		/// </summary>
		public System.String Class
		{
			get { return m_Class; }
			set 
			{
				m_Class = value;
				m_IsClassDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<FRowElement> Rows
		{
			get { return m_Rows; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="FRowElement"/> and adds it to the <see cref="Rows"/> collection.
		/// </summary>
		public FRowElement AddFRow()
		{
			FRowElement fRowElement = new FRowElement();
			m_Rows.Add(fRowElement);
			return fRowElement;
		}

		private void Rows_ItemAdded(object sender, CollectionItemEventArgs<FRowElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="FGroupElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "FGroup")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "FGroup"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Caption = element.Attributes.GetPropertyValue<System.String>("Caption");
			m_IsCaptionDefault = element.Attributes.IsPropertyDefault("Caption");
			m_Class = element.Attributes.GetPropertyValue<System.String>("Class");
			m_IsClassDefault = element.Attributes.IsPropertyDefault("Class");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "row" :
					{
						FRowElement row = new FRowElement();
						row.LoadFrom(_childElement);
						Rows.Add(row);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="FGroupElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "FGroup")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "FGroup"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "Caption", m_Caption, m_IsCaptionDefault);
			SaveAttribute(element, "Class", m_Class, m_IsClassDefault);

			Debug.Assert(m_Caption == element.Attributes.GetPropertyValue<System.String>("Caption"));

			// Save element children.
			if (m_Rows != null)
			{
				foreach (FRowElement _item in Rows)
				{
					PatternInstanceElement row = element.Children.AddNewElement("row");
					_item.SaveTo(row);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="FGroupElement"/>.
		/// </summary>
		public FGroupElement Clone()
		{
			FGroupElement clone = new FGroupElement();

			clone.Caption = this.Caption;
			clone.Class = this.Class;
			foreach (FRowElement fRowElement in this.Rows)
				clone.Rows.Add(fRowElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "row" :
				{
					if (Rows != null && childIndex >= 0 && childIndex < Rows.Count)
						return Rows[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Group {0}", Caption);
		}

		#endregion
	}

	#endregion

	#region Element: Row

	public partial class RowElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.Boolean m_Visible;
		private bool m_IsVisibleDefault;
		private Artech.Common.Collections.BaseCollection<ColumnElement> m_Columns;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="RowElement"/> class.
		/// </summary>
		public RowElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="RowElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Visible = true;
			m_IsVisibleDefault = true;
			m_Columns = new Artech.Common.Collections.BaseCollection<ColumnElement>();
			m_Columns.ItemAdded += new EventHandler<CollectionItemEventArgs<ColumnElement>>(Columns_ItemAdded);
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="RowElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Linha inteira é visivel.
		*/
		/// </summary>
		public System.Boolean Visible
		{
			get { return m_Visible; }
			set 
			{
				m_Visible = value;
				m_IsVisibleDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<ColumnElement> Columns
		{
			get { return m_Columns; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="ColumnElement"/> and adds it to the <see cref="Columns"/> collection.
		/// </summary>
		public ColumnElement AddColumn()
		{
			ColumnElement columnElement = new ColumnElement();
			m_Columns.Add(columnElement);
			return columnElement;
		}

		private void Columns_ItemAdded(object sender, CollectionItemEventArgs<ColumnElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="RowElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Row")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Row"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Visible = element.Attributes.GetPropertyValue<System.Boolean>("visible");
			m_IsVisibleDefault = element.Attributes.IsPropertyDefault("visible");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "column" :
					{
						ColumnElement column = new ColumnElement();
						column.LoadFrom(_childElement);
						Columns.Add(column);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="RowElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Row")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Row"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "visible", m_Visible, m_IsVisibleDefault);

			Debug.Assert(m_Visible == element.Attributes.GetPropertyValue<System.Boolean>("visible"));

			// Save element children.
			if (m_Columns != null)
			{
				foreach (ColumnElement _item in Columns)
				{
					PatternInstanceElement column = element.Children.AddNewElement("column");
					_item.SaveTo(column);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="RowElement"/>.
		/// </summary>
		public RowElement Clone()
		{
			RowElement clone = new RowElement();

			clone.Visible = this.Visible;
			foreach (ColumnElement columnElement in this.Columns)
				clone.Columns.Add(columnElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "column" :
				{
					if (Columns != null && childIndex >= 0 && childIndex < Columns.Count)
						return Columns[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Row";
		}

		#endregion
	}

	#endregion

	#region Element: Text

	public partial class TextElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private System.String m_Caption;
		private bool m_IsCaptionDefault;
		private System.Boolean m_Visible;
		private bool m_IsVisibleDefault;
		private System.String m_Class;
		private bool m_IsClassDefault;
		private System.String m_HTMLFormat;
		private bool m_IsHTMLFormatDefault;
		private System.String m_Rule;
		private bool m_IsRuleDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="TextElement"/> class.
		/// </summary>
		public TextElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TextElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public TextElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="TextElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Caption = "";
			m_IsCaptionDefault = true;
			m_Visible = true;
			m_IsVisibleDefault = true;
			m_Class = null;
			m_IsClassDefault = true;
			m_HTMLFormat = "default";
			m_IsHTMLFormatDefault = true;
			m_Rule = "Runtime";
			m_IsRuleDefault = true;
		}

		#endregion

		#region Properties

		private IHPatternInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="TextElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public IHPatternInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Name
		*/
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/*
		Caption Text.
		*/
		/// </summary>
		public System.String Caption
		{
			get { return m_Caption; }
			set 
			{
				m_Caption = value;
				m_IsCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		TextBlock is visible.
		*/
		/// </summary>
		public System.Boolean Visible
		{
			get { return m_Visible; }
			set 
			{
				m_Visible = value;
				m_IsVisibleDefault = false;
			}
		}

		/// <summary>
		/*
		Class
		*/
		/// </summary>
		public System.String Class
		{
			get { return m_Class; }
			set 
			{
				m_Class = value;
				m_IsClassDefault = false;
			}
		}

		/// <summary>
		/*
		HTML Format
		*/
		/// </summary>
		public System.String HTMLFormat
		{
			get { return m_HTMLFormat; }
			set 
			{
				m_HTMLFormat = value;
				m_IsHTMLFormatDefault = false;
			}
		}

		/// <summary>
		/*
		Rule
		*/
		/// </summary>
		public System.String Rule
		{
			get { return m_Rule; }
			set 
			{
				m_Rule = value;
				m_IsRuleDefault = false;
			}
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="TextElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Text")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Text"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_Caption = element.Attributes.GetPropertyValue<System.String>("caption");
			m_IsCaptionDefault = element.Attributes.IsPropertyDefault("caption");
			m_Visible = element.Attributes.GetPropertyValue<System.Boolean>("visible");
			m_IsVisibleDefault = element.Attributes.IsPropertyDefault("visible");
			m_Class = element.Attributes.GetPropertyValue<System.String>("Class");
			m_IsClassDefault = element.Attributes.IsPropertyDefault("Class");
			m_HTMLFormat = element.Attributes.GetPropertyValue<System.String>("HTMLFormat");
			m_IsHTMLFormatDefault = element.Attributes.IsPropertyDefault("HTMLFormat");
			m_Rule = element.Attributes.GetPropertyValue<System.String>("Rule");
			m_IsRuleDefault = element.Attributes.IsPropertyDefault("Rule");
		}

		/// <summary>
		/// Saves the current <see cref="TextElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Text")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Text"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "caption", m_Caption, m_IsCaptionDefault);
			SaveAttribute(element, "visible", m_Visible, m_IsVisibleDefault);
			SaveAttribute(element, "Class", m_Class, m_IsClassDefault);
			SaveAttribute(element, "HTMLFormat", m_HTMLFormat, m_IsHTMLFormatDefault);
			SaveAttribute(element, "Rule", m_Rule, m_IsRuleDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_Caption == element.Attributes.GetPropertyValue<System.String>("caption"));
			Debug.Assert(m_Visible == element.Attributes.GetPropertyValue<System.Boolean>("visible"));
			Debug.Assert(m_HTMLFormat == element.Attributes.GetPropertyValue<System.String>("HTMLFormat"));
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="TextElement"/>.
		/// </summary>
		public TextElement Clone()
		{
			TextElement clone = new TextElement();

			clone.Name = this.Name;
			clone.Caption = this.Caption;
			clone.Visible = this.Visible;
			clone.Class = this.Class;
			clone.HTMLFormat = this.HTMLFormat;
			clone.Rule = this.Rule;

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="HTMLFormat"/> property.
		/// </summary>
		public static class HTMLFormatValue
		{
			public const string True = "true";
			public const string False = "false";
			public const string Default = "default";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "{0}", Caption);
		}

		#endregion
	}

	#endregion

	#region Element: Group

	public partial class GroupElement : IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Caption;
		private bool m_IsCaptionDefault;
		private System.String m_Class;
		private bool m_IsClassDefault;
		private Artech.Common.Collections.BaseCollection<RowElement> m_Rows;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="GroupElement"/> class.
		/// </summary>
		public GroupElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="GroupElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Caption = "";
			m_IsCaptionDefault = true;
			m_Class = null;
			m_IsClassDefault = true;
			m_Rows = new Artech.Common.Collections.BaseCollection<RowElement>();
			m_Rows.ItemAdded += new EventHandler<CollectionItemEventArgs<RowElement>>(Rows_ItemAdded);
		}

		#endregion

		#region Properties

		private ColumnElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="GroupElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public ColumnElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		Caption
		*/
		/// </summary>
		public System.String Caption
		{
			get { return m_Caption; }
			set 
			{
				m_Caption = value;
				m_IsCaptionDefault = false;
			}
		}

		/// <summary>
		/*
		Class
		*/
		/// </summary>
		public System.String Class
		{
			get { return m_Class; }
			set 
			{
				m_Class = value;
				m_IsClassDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<RowElement> Rows
		{
			get { return m_Rows; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="RowElement"/> and adds it to the <see cref="Rows"/> collection.
		/// </summary>
		public RowElement AddRow()
		{
			RowElement rowElement = new RowElement();
			m_Rows.Add(rowElement);
			return rowElement;
		}

		private void Rows_ItemAdded(object sender, CollectionItemEventArgs<RowElement> e)
		{
			e.Data.Parent = this;
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="GroupElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Group")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Group"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Caption = element.Attributes.GetPropertyValue<System.String>("Caption");
			m_IsCaptionDefault = element.Attributes.IsPropertyDefault("Caption");
			m_Class = element.Attributes.GetPropertyValue<System.String>("Class");
			m_IsClassDefault = element.Attributes.IsPropertyDefault("Class");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "row" :
					{
						RowElement row = new RowElement();
						row.LoadFrom(_childElement);
						Rows.Add(row);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="GroupElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Group")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Group"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "Caption", m_Caption, m_IsCaptionDefault);
			SaveAttribute(element, "Class", m_Class, m_IsClassDefault);

			Debug.Assert(m_Caption == element.Attributes.GetPropertyValue<System.String>("Caption"));

			// Save element children.
			if (m_Rows != null)
			{
				foreach (RowElement _item in Rows)
				{
					PatternInstanceElement row = element.Children.AddNewElement("row");
					_item.SaveTo(row);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="GroupElement"/>.
		/// </summary>
		public GroupElement Clone()
		{
			GroupElement clone = new GroupElement();

			clone.Caption = this.Caption;
			clone.Class = this.Class;
			foreach (RowElement rowElement in this.Rows)
				clone.Rows.Add(rowElement.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "row" :
				{
					if (Rows != null && childIndex >= 0 && childIndex < Rows.Count)
						return Rows[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return String.Format(CultureInfo.CurrentCulture, "Group {0}", Caption);
		}

		#endregion
	}

	#endregion

	#region Element: Column

	public partial class ColumnElement : IEnumerable<IHPatternInstanceElement>, IHPatternInstanceElement
	{
		protected string m_ElementName;
		private System.Int32 m_ColSpan;
		private bool m_IsColSpanDefault;
		private System.Int32 m_RowSpan;
		private bool m_IsRowSpanDefault;
		private System.String m_Align;
		private bool m_IsAlignDefault;
		private Artech.Common.Collections.BaseCollection<IHPatternInstanceElement> m_Items;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="ColumnElement"/> class.
		/// </summary>
		public ColumnElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="ColumnElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_ColSpan = 1;
			m_IsColSpanDefault = true;
			m_RowSpan = 1;
			m_IsRowSpanDefault = true;
			m_Align = "default";
			m_IsAlignDefault = true;
			m_Items = new Artech.Common.Collections.BaseCollection<IHPatternInstanceElement>();
			m_Items.ItemAdded += new EventHandler<CollectionItemEventArgs<IHPatternInstanceElement>>(Items_ItemAdded);
		}

		#endregion

		#region Properties

		private RowElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="ColumnElement"/> belongs.
		/// </summary>
		public HPatternInstance Instance
		{
			get { return ((IHPatternInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public RowElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		IHPatternInstanceElement IHPatternInstanceElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/*
		ColSpan
		*/
		/// </summary>
		public System.Int32 ColSpan
		{
			get { return m_ColSpan; }
			set 
			{
				m_ColSpan = value;
				m_IsColSpanDefault = false;
			}
		}

		/// <summary>
		/*
		colSpan
		*/
		/// </summary>
		public System.Int32 RowSpan
		{
			get { return m_RowSpan; }
			set 
			{
				m_RowSpan = value;
				m_IsRowSpanDefault = false;
			}
		}

		/// <summary>
		/*
		Define propriedade Align da celula
		*/
		/// </summary>
		public System.String Align
		{
			get { return m_Align; }
			set 
			{
				m_Align = value;
				m_IsAlignDefault = false;
			}
		}

		public Artech.Common.Collections.IBaseCollection<AttributeElement> Attributes
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<AttributeElement> tmpAttributes = new Artech.Common.Collections.BaseCollection<AttributeElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is AttributeElement)
						tmpAttributes.Add((AttributeElement)obj);

				return tmpAttributes.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<VariableElement> Variables
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<VariableElement> tmpVariables = new Artech.Common.Collections.BaseCollection<VariableElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is VariableElement)
						tmpVariables.Add((VariableElement)obj);

				return tmpVariables.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<TextElement> Texts
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<TextElement> tmpTexts = new Artech.Common.Collections.BaseCollection<TextElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is TextElement)
						tmpTexts.Add((TextElement)obj);

				return tmpTexts.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<GroupElement> Groups
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<GroupElement> tmpGroups = new Artech.Common.Collections.BaseCollection<GroupElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is GroupElement)
						tmpGroups.Add((GroupElement)obj);

				return tmpGroups.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<GridFreeStyleElement> GridFreeStyles
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<GridFreeStyleElement> tmpGridFreeStyles = new Artech.Common.Collections.BaseCollection<GridFreeStyleElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is GridFreeStyleElement)
						tmpGridFreeStyles.Add((GridFreeStyleElement)obj);

				return tmpGridFreeStyles.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<GridStandardElement> GridStandards
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<GridStandardElement> tmpGridStandards = new Artech.Common.Collections.BaseCollection<GridStandardElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is GridStandardElement)
						tmpGridStandards.Add((GridStandardElement)obj);

				return tmpGridStandards.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<UserTableElement> UserTables
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<UserTableElement> tmpUserTables = new Artech.Common.Collections.BaseCollection<UserTableElement>();
				foreach (IHPatternInstanceElement obj in m_Items)
					if (obj is UserTableElement)
						tmpUserTables.Add((UserTableElement)obj);

				return tmpUserTables.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<IHPatternInstanceElement> Items
		{
			get { return m_Items; }
		}

		public IEnumerator<IHPatternInstanceElement> GetEnumerator()
		{
			return m_Items.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((System.Collections.IEnumerable)m_Items).GetEnumerator();
		}

		#endregion

		#region Helper methods

		public void Add(IHPatternInstanceElement item)
		{
			m_Items.Add(item);
		}

		/// <summary>
		/// Creates a new <see cref="AttributeElement"/> and adds it to the <see cref="Attributes"/> collection.
		/// </summary>
		public AttributeElement AddAttribute()
		{
			AttributeElement attributeElement = new AttributeElement();
			m_Items.Add(attributeElement);
			return attributeElement;
		}

		/// <summary>
		/// Creates a new <see cref="AttributeElement"/> and adds it to the <see cref="Attributes"/> collection.
		/// The AttributeElement is initialized with the specified value.
		/// </summary>
		public AttributeElement AddAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			AttributeElement attributeElement = new AttributeElement(attribute);
			m_Items.Add(attributeElement);
			return attributeElement;
		}

		/// <summary>
		/// Finds the <see cref="AttributeElement"/> in the <see cref="Attributes"/> collection that has the specified value in its <see cref="Attribute"/> property.
		/// If no attributeElement is found, null is returned.
		/// </summary>
		public AttributeElement FindAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			return Attributes.Find(delegate (AttributeElement attributeElement) { return attributeElement.Attribute == attribute; });
		}

		private void Attributes_ItemAdded(object sender, CollectionItemEventArgs<AttributeElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="VariableElement"/> and adds it to the <see cref="Variables"/> collection.
		/// </summary>
		public VariableElement AddVariable()
		{
			VariableElement variableElement = new VariableElement();
			m_Items.Add(variableElement);
			return variableElement;
		}

		/// <summary>
		/// Creates a new <see cref="VariableElement"/> and adds it to the <see cref="Variables"/> collection.
		/// The VariableElement is initialized with the specified value.
		/// </summary>
		public VariableElement AddVariable(System.String name)
		{
			VariableElement variableElement = new VariableElement(name);
			m_Items.Add(variableElement);
			return variableElement;
		}

		/// <summary>
		/// Finds the <see cref="VariableElement"/> in the <see cref="Variables"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no variableElement is found, null is returned.
		/// </summary>
		public VariableElement FindVariable(System.String name)
		{
			return Variables.Find(delegate (VariableElement variableElement) { return variableElement.Name == name; });
		}

		private void Variables_ItemAdded(object sender, CollectionItemEventArgs<VariableElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="TextElement"/> and adds it to the <see cref="Texts"/> collection.
		/// </summary>
		public TextElement AddText()
		{
			TextElement textElement = new TextElement();
			m_Items.Add(textElement);
			return textElement;
		}

		/// <summary>
		/// Creates a new <see cref="TextElement"/> and adds it to the <see cref="Texts"/> collection.
		/// The TextElement is initialized with the specified value.
		/// </summary>
		public TextElement AddText(System.String name)
		{
			TextElement textElement = new TextElement(name);
			m_Items.Add(textElement);
			return textElement;
		}

		/// <summary>
		/// Finds the <see cref="TextElement"/> in the <see cref="Texts"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no textElement is found, null is returned.
		/// </summary>
		public TextElement FindText(System.String name)
		{
			return Texts.Find(delegate (TextElement textElement) { return textElement.Name == name; });
		}

		private void Texts_ItemAdded(object sender, CollectionItemEventArgs<TextElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="GroupElement"/> and adds it to the <see cref="Groups"/> collection.
		/// </summary>
		public GroupElement AddGroup()
		{
			GroupElement groupElement = new GroupElement();
			m_Items.Add(groupElement);
			return groupElement;
		}

		private void Groups_ItemAdded(object sender, CollectionItemEventArgs<GroupElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="GridFreeStyleElement"/> and adds it to the <see cref="GridFreeStyles"/> collection.
		/// </summary>
		public GridFreeStyleElement AddGridFreeStyle()
		{
			GridFreeStyleElement gridFreeStyleElement = new GridFreeStyleElement();
			m_Items.Add(gridFreeStyleElement);
			return gridFreeStyleElement;
		}

		/// <summary>
		/// Creates a new <see cref="GridFreeStyleElement"/> and adds it to the <see cref="GridFreeStyles"/> collection.
		/// The GridFreeStyleElement is initialized with the specified value.
		/// </summary>
		public GridFreeStyleElement AddGridFreeStyle(System.String name)
		{
			GridFreeStyleElement gridFreeStyleElement = new GridFreeStyleElement(name);
			m_Items.Add(gridFreeStyleElement);
			return gridFreeStyleElement;
		}

		/// <summary>
		/// Finds the <see cref="GridFreeStyleElement"/> in the <see cref="GridFreeStyles"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridFreeStyleElement is found, null is returned.
		/// </summary>
		public GridFreeStyleElement FindGridFreeStyle(System.String name)
		{
			return GridFreeStyles.Find(delegate (GridFreeStyleElement gridFreeStyleElement) { return gridFreeStyleElement.Name == name; });
		}

		private void GridFreeStyles_ItemAdded(object sender, CollectionItemEventArgs<GridFreeStyleElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="GridStandardElement"/> and adds it to the <see cref="GridStandards"/> collection.
		/// </summary>
		public GridStandardElement AddGridStandard()
		{
			GridStandardElement gridStandardElement = new GridStandardElement();
			m_Items.Add(gridStandardElement);
			return gridStandardElement;
		}

		/// <summary>
		/// Creates a new <see cref="GridStandardElement"/> and adds it to the <see cref="GridStandards"/> collection.
		/// The GridStandardElement is initialized with the specified value.
		/// </summary>
		public GridStandardElement AddGridStandard(System.String name)
		{
			GridStandardElement gridStandardElement = new GridStandardElement(name);
			m_Items.Add(gridStandardElement);
			return gridStandardElement;
		}

		/// <summary>
		/// Finds the <see cref="GridStandardElement"/> in the <see cref="GridStandards"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no gridStandardElement is found, null is returned.
		/// </summary>
		public GridStandardElement FindGridStandard(System.String name)
		{
			return GridStandards.Find(delegate (GridStandardElement gridStandardElement) { return gridStandardElement.Name == name; });
		}

		private void GridStandards_ItemAdded(object sender, CollectionItemEventArgs<GridStandardElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="UserTableElement"/> and adds it to the <see cref="UserTables"/> collection.
		/// </summary>
		public UserTableElement AddUserTable()
		{
			UserTableElement userTableElement = new UserTableElement();
			m_Items.Add(userTableElement);
			return userTableElement;
		}

		/// <summary>
		/// Creates a new <see cref="UserTableElement"/> and adds it to the <see cref="UserTables"/> collection.
		/// The UserTableElement is initialized with the specified value.
		/// </summary>
		public UserTableElement AddUserTable(System.String name)
		{
			UserTableElement userTableElement = new UserTableElement(name);
			m_Items.Add(userTableElement);
			return userTableElement;
		}

		/// <summary>
		/// Finds the <see cref="UserTableElement"/> in the <see cref="UserTables"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no userTableElement is found, null is returned.
		/// </summary>
		public UserTableElement FindUserTable(System.String name)
		{
			return UserTables.Find(delegate (UserTableElement userTableElement) { return userTableElement.Name == name; });
		}

		private void UserTables_ItemAdded(object sender, CollectionItemEventArgs<UserTableElement> e)
		{
			e.Data.Parent = this;
		}

		private void Items_ItemAdded(object sender, CollectionItemEventArgs<IHPatternInstanceElement> e)
		{
			if (e.Data is AttributeElement)
				((AttributeElement)e.Data).Parent = this;
			else if (e.Data is VariableElement)
				((VariableElement)e.Data).Parent = this;
			else if (e.Data is TextElement)
				((TextElement)e.Data).Parent = this;
			else if (e.Data is GroupElement)
				((GroupElement)e.Data).Parent = this;
			else if (e.Data is GridFreeStyleElement)
				((GridFreeStyleElement)e.Data).Parent = this;
			else if (e.Data is GridStandardElement)
				((GridStandardElement)e.Data).Parent = this;
			else if (e.Data is UserTableElement)
				((UserTableElement)e.Data).Parent = this;
			else
				throw new PatternInstanceException(String.Format("An object of an unexpected type {0} was added as child of {1}.", e.Data.GetType(), this.GetType()));
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Loads the current <see cref="ColumnElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Column")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Column"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_ColSpan = element.Attributes.GetPropertyValue<System.Int32>("ColSpan");
			m_IsColSpanDefault = element.Attributes.IsPropertyDefault("ColSpan");
			m_RowSpan = element.Attributes.GetPropertyValue<System.Int32>("RowSpan");
			m_IsRowSpanDefault = element.Attributes.IsPropertyDefault("RowSpan");
			m_Align = element.Attributes.GetPropertyValue<System.String>("Align");
			m_IsAlignDefault = element.Attributes.IsPropertyDefault("Align");

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "attribute" :
					{
						AttributeElement attribute = new AttributeElement();
						attribute.LoadFrom(_childElement);
						Add(attribute);
						break;
					}
					case "variable" :
					{
						VariableElement variable = new VariableElement();
						variable.LoadFrom(_childElement);
						Add(variable);
						break;
					}
					case "text" :
					{
						TextElement text = new TextElement();
						text.LoadFrom(_childElement);
						Add(text);
						break;
					}
					case "group" :
					{
						GroupElement group = new GroupElement();
						group.LoadFrom(_childElement);
						Add(group);
						break;
					}
					case "gridFreeStyle" :
					{
						GridFreeStyleElement gridFreeStyle = new GridFreeStyleElement();
						gridFreeStyle.LoadFrom(_childElement);
						Add(gridFreeStyle);
						break;
					}
					case "gridStandard" :
					{
						GridStandardElement gridStandard = new GridStandardElement();
						gridStandard.LoadFrom(_childElement);
						Add(gridStandard);
						break;
					}
					case "userTable" :
					{
						UserTableElement userTable = new UserTableElement();
						userTable.LoadFrom(_childElement);
						Add(userTable);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="ColumnElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Column")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Column"));

			element.Initialize();

			// Save attribute values.
			SaveAttribute(element, "ColSpan", m_ColSpan, m_IsColSpanDefault);
			SaveAttribute(element, "RowSpan", m_RowSpan, m_IsRowSpanDefault);
			SaveAttribute(element, "Align", m_Align, m_IsAlignDefault);

			Debug.Assert(m_ColSpan == element.Attributes.GetPropertyValue<System.Int32>("ColSpan"));
			Debug.Assert(m_RowSpan == element.Attributes.GetPropertyValue<System.Int32>("RowSpan"));
			Debug.Assert(m_Align == element.Attributes.GetPropertyValue<System.String>("Align"));

			// Save element children.
			foreach (IHPatternInstanceElement _obj in m_Items)
			{
				if (_obj is AttributeElement)
				{
					PatternInstanceElement attribute = element.Children.AddNewElement("attribute");
					((AttributeElement)_obj).SaveTo(attribute);
				}
				else if (_obj is VariableElement)
				{
					PatternInstanceElement variable = element.Children.AddNewElement("variable");
					((VariableElement)_obj).SaveTo(variable);
				}
				else if (_obj is TextElement)
				{
					PatternInstanceElement text = element.Children.AddNewElement("text");
					((TextElement)_obj).SaveTo(text);
				}
				else if (_obj is GroupElement)
				{
					PatternInstanceElement group = element.Children.AddNewElement("group");
					((GroupElement)_obj).SaveTo(group);
				}
				else if (_obj is GridFreeStyleElement)
				{
					PatternInstanceElement gridFreeStyle = element.Children.AddNewElement("gridFreeStyle");
					((GridFreeStyleElement)_obj).SaveTo(gridFreeStyle);
				}
				else if (_obj is GridStandardElement)
				{
					PatternInstanceElement gridStandard = element.Children.AddNewElement("gridStandard");
					((GridStandardElement)_obj).SaveTo(gridStandard);
				}
				else if (_obj is UserTableElement)
				{
					PatternInstanceElement userTable = element.Children.AddNewElement("userTable");
					((UserTableElement)_obj).SaveTo(userTable);
				}
			}
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="ColumnElement"/>.
		/// </summary>
		public ColumnElement Clone()
		{
			ColumnElement clone = new ColumnElement();

			clone.ColSpan = this.ColSpan;
			clone.RowSpan = this.RowSpan;
			clone.Align = this.Align;
			foreach (IHPatternInstanceElement element in this)
				clone.Add(element.Clone());

			return clone;
		}

		IHPatternInstanceElement IHPatternInstanceElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			HPatternInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "attribute" :
				{
					if (Attributes != null && childIndex >= 0 && childIndex < Attributes.Count)
						return Attributes[childIndex].GetElement(path);
					else
						return null;
				}
				case "variable" :
				{
					if (Variables != null && childIndex >= 0 && childIndex < Variables.Count)
						return Variables[childIndex].GetElement(path);
					else
						return null;
				}
				case "text" :
				{
					if (Texts != null && childIndex >= 0 && childIndex < Texts.Count)
						return Texts[childIndex].GetElement(path);
					else
						return null;
				}
				case "group" :
				{
					if (Groups != null && childIndex >= 0 && childIndex < Groups.Count)
						return Groups[childIndex].GetElement(path);
					else
						return null;
				}
				case "gridFreeStyle" :
				{
					if (GridFreeStyles != null && childIndex >= 0 && childIndex < GridFreeStyles.Count)
						return GridFreeStyles[childIndex].GetElement(path);
					else
						return null;
				}
				case "gridStandard" :
				{
					if (GridStandards != null && childIndex >= 0 && childIndex < GridStandards.Count)
						return GridStandards[childIndex].GetElement(path);
					else
						return null;
				}
				case "userTable" :
				{
					if (UserTables != null && childIndex >= 0 && childIndex < UserTables.Count)
						return UserTables[childIndex].GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="Align"/> property.
		/// </summary>
		public static class AlignValue
		{
			public const string Default = "default";
			public const string Right = "Right";
			public const string Left = "Left";
			public const string Center = "Center";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Column";
		}

		#endregion
	}

	#endregion

	/// <summary>
	/// Base interface for all HPatternInstance elements.
	/// </summary>
	public interface IHPatternInstanceElement
	{
		HPatternInstance Instance { get; }
		IHPatternInstanceElement Parent { get; }
		IHPatternInstanceElement Clone();
	}
}