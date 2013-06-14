using System;
using System.Collections.Generic;
using Artech.Genexus.Common.Objects;
using Artech.Common.Collections;
using Artech.Genexus.Common;
using Gx = Artech.Genexus.Common.Objects;
using Artech.Packages.Patterns.Objects;

namespace Heurys.Patterns.HPattern.Helpers
{
	/// <summary>
	/// Class to automatically generate links for attributes.
	/// </summary>
	public class AutoLinkGenerator
	{
		// Current instance files.
        private BaseCollection<HPatternInstance> m_Instances = null;

        public AutoLinkGenerator(HPatternInstance instance)
		{
			// Read all the instances of this type to find links.
            m_Instances = new BaseCollection<HPatternInstance>();
			m_Instances.Add(instance);            

			// For performance reasons it is unfeasible to actually read the updated versions here.
			foreach (PatternInstance otherInstance in PatternInstance.GetInstances(instance.Model, HPatternPattern.Definition, PatternInstance.OpenOptions.SkipUpdate))
			{
				if (otherInstance.Id != instance.Id)
                    m_Instances.Add(HPatternInstance.FastLoad(otherInstance));
			}
		}

        public void GenerateLink(AttributeElement att, AttributesElement gridAtts)
		{
			// Process attributes that use links but don't have one already.
			if (att.Autolink && att.Link == null)
			{
				LevelElement levelToLink = FindLevelToLink(att,gridAtts);
				if (levelToLink != null)
				{
                    LinkElement link = new LinkElement();
                    att.Links.Add(link);
                    //link = new LinkElement();
                    link.Webpanel = levelToLink.View.ObjectName;
                    bool isTemCallBack = false;
                    if (gridAtts.Instance.Settings.Template.TabFunction == SettingsTemplateElement.TabFunctionValue.TreeViewAnchor)
                    {
                        link.Parameters.Add(new ParameterElement("TrnMode.Update"));
                    }
                    foreach (ParameterElement parameter in levelToLink.View.Parameters)
                    {
                        if (parameter.Name == "&" + HPatternInstance.PARMCALLBACK)
                        {
                            isTemCallBack = true;
                        }
                        link.Parameters.Add(parameter.Clone());
                    }
                    if (isTemCallBack == false && gridAtts.Instance.Settings.Template.GenerateCallBackLink)
                    {
                        ParameterElement parm = new ParameterElement("&" + HPatternInstance.PARMCALLBACK);
                        parm.Domain = Domain.Get(gridAtts.Instance.Model,HPatternInstance.PARMCALLBACK);
                        link.Parameters.Add(parm);
                    }
					/*
					bool isSuperTypeLink = (General.NodeName(attriNode) != levelToLink.Level.DescriptionAttribute);

					// Avoid self-links.
					if (IsAcceptableLink(filename, attriNode, levelToLink, isSuperTypeLink))
					{
						attriNode.Attributes["link"].Value = ExtractLinkName(levelToLink.Filename);
						attriNode.Attributes["level"].Value = levelToLink.Level.Name;

						if (isSuperTypeLink)
							AddSupertypeLinkParams(attriNode, levelToLink);
					}
					*/
				}
			}
		}

        private LevelElement FindLevelToLink(AttributeElement att, AttributesElement gridAtts)
		{
            foreach (HPatternInstance instance in m_Instances)
			{
                if (instance.Settings.Grid.BuildAutoLink)
                {
                    foreach (LevelElement level in instance.Levels)
                    {
                        // Don't include a link to the same view in tabs.
                        if (level.View != null && level.View.Parameters != null && level.DescriptionAttribute != null && level.DescriptionAttribute.Attribute == att.Attribute)
                        {
                            bool isTemTodos = true;
                            foreach (ParameterElement par in level.View.Parameters)
                            {
                                if (par.IsAttribute && gridAtts.FindAttribute(par.Name) == null)
                                {
                                    isTemTodos = false;
                                    break;
                                }
                                
                            }
                            if (isTemTodos)
                            {
                                return level;
                            }
                        }
                    }
                }
			}

			// Nothing found.
			return null;
		}

		/*
		private bool IsAcceptableLink(string filename, XmlNode attriNode, LevelToAutoLink levelToLink, bool isSuperTypeLink)
		{
			// Search for the level to which this attribute belongs.
			XmlNode attriLevelNode = attriNode;
			while (attriLevelNode != null && attriLevelNode.Name != "level")
				attriLevelNode = attriLevelNode.ParentNode;

			// Avoid self-links: link must be to another instance/level pair, or to this one but with another attribute (for example, in case of a recursive subtype definition).
			return (Path.Combine(GeneralConfiguration.Instance.InstanceFilesFolder(), levelToLink.Filename) != filename || levelToLink.Level.Name != General.AttributeValue(attriLevelNode, "name") || isSuperTypeLink);
		}

		private void AddSupertypeLinkParams(XmlNode attriNode, LevelElement levelToLink)
		{
			if (attriNode.Attributes[k_SupertypeLinkParams] == null)
				attriNode.Attributes.Append(attriNode.OwnerDocument.CreateAttribute(k_SupertypeLinkParams));

			List<string> parameters = new List<string>();

			string[] stgAttributes = KnowledgeBase.KB.GetSubtypeGroupAttributes(General.NodeName(attriNode));
			foreach (string viewParam in levelToLink.Level.View.Parameters)
			{
				GXAttribute viewParamAtt = KnowledgeBase.KB.GetAttribute(viewParam);

				// If I can find another member of the subtype group that matches (is a subtype of) a needed parameter, then it is used. Else the exact parameter is used.
				bool foundMatch = false;
				foreach (string stgAttName in stgAttributes)
				{
					GXAttribute stgAtt = KnowledgeBase.KB.GetAttribute(stgAttName);
					if (stgAtt != null && viewParamAtt != null && stgAtt.IsSubtypeOf(viewParamAtt))
					{
						// Add mapping.
						parameters.Add(stgAttName);
						foundMatch = true;
						break;
					}
				}
				if (!foundMatch)
					parameters.Add(viewParam);
			}

			attriNode.Attributes[k_SupertypeLinkParams].Value = EncodeAutoLinkParams(parameters);
		}
		*/

		/*
		internal static string EncodeAutoLinkParams(List<string> parameters)
		{
			string res = "";
			foreach (string param in parameters)
				res += (res != "" ? ";" : "") + param;
			return res;
		}

		internal static List<string> DecodeAutoLinkParams(string parameters)
		{
			return new List<string>(parameters.Split(';'));
		}
		*/
	}
}

