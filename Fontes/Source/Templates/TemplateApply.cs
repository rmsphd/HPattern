private static class TemplateApply
{
    public static string AppendTemplateOutput(string templateName, Generator.GeneratorParameters parameters)
    {
        StringBuilder stringBuilder = new StringBuilder();
        if (!templateName.ToLower().EndsWith(".dll"))
            templateName += ".dll";

        string templatesBasePath = Path.Combine(HPatternPattern.Definition.DefinitionBasePath, "Templates");
        string templatePath = Path.Combine(templatesBasePath, templateName);

        List<string> templateErrors;
        string output = Generator.GenerateToString(templatePath, parameters, out templateErrors);

        if (templateErrors.Count > 0)
            throw new TemplateException(Messages.FormatTemplateErrors(templateName, String.Join(String.Empty, templateErrors.ToArray())));

        stringBuilder.Append(output);
        return stringBuilder.ToString();
    }

    public static void ApplyRow(StringBuilder atts, RowElement row, Transaction transaction, Boolean geraBC, String sigla, HPatternSettings settings)
    {
        atts.AppendLine("<tr>");        

        foreach (ColumnElement col in row.Columns)
        {
            atts.AppendLine("<td colspan='" + col.ColSpan.ToString() + "' rowspan='" + col.RowSpan.ToString() + "'>");

            foreach (Object obj in col.Items)
            {
                if (obj is AttributeElement)
                {
                    AttributeElement att = (AttributeElement)obj;
                    if (geraBC)
                    {
                        Dictionary<string, object> properties = new Dictionary<string, object>();
                        properties[Properties.HTMLATT.FieldSpecifier] = att.AttributeName;
                        TransactionAttribute ta = transaction.Structure.Root.GetAttribute(att.AttributeName);
                        bool vreadonly = false;
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

                        if (att.Readonly)
                        {
                            vreadonly = true;
                        }


                        if (vreadonly)
                        {
                            properties[Properties.HTMLATT.ReadOnly] = true;
                        }

                        string themeClass = "Attribute";
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

                        atts.AppendLine(WebForm.Variable(transaction.Name + sigla, themeClass, null, properties));
                    }
                    else
                    {
                        Dictionary<string, object> properties = new Dictionary<string, object>();
                        if (att.Readonly)
                        {
                            properties[Properties.HTMLATT.ReadOnly] = true;
                        }
                        atts.AppendLine(WebForm.Attribute(att.AttributeName, null, null, properties));
                    }
                }
                if (obj is VariableElement)
                {
                    VariableElement var = (VariableElement)obj;

                    string themeClass = "Attribute";
                    if (var.ThemeClass != String.Empty)
                        themeClass = var.ThemeClass;

                    atts.AppendLine(WebForm.Variable(var.Name, themeClass));
                }
                if (obj is TextElement)
                {
                    TextElement text = (TextElement)obj;                    
                    //contaAtts++;
                    atts.AppendLine(WebForm.TextBlock(text.Name, settings.Theme.PlainText, text.Caption));
                }
            }

            atts.AppendLine("</td>");
        }

        atts.AppendLine("</tr>");    


    }

}