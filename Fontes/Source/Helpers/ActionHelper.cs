using System;
using System.Globalization;
using System.Text;
using Artech.Genexus.Common.Objects;

namespace Heurys.Patterns.HPattern.Helpers
{
	internal static class LinkAction
	{
		public static string EnableLink(ActionElement action)
		{
			return String.Format(CultureInfo.InvariantCulture, "{0}.Link = {1}", action.ControlName(), action.FormatMethod("Link", action.Parameters.List()));
		}

		public static string DisableLink(ActionElement action)
		{
			return String.Format(CultureInfo.InvariantCulture, "{0}.Link = \"\"", action.ControlName());
		}
	}

	internal static class ImageAction
	{
//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public static string EnableCode(ActionElement action)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(LinkAction.EnableLink(action));
            //sb.Append(Environment.NewLine);
            //sb.Append(JSEvent(action, true));
			if (action.Condition != String.Empty && action.DisabledImage != null)
			{
				sb.Append(Environment.NewLine);
				sb.Append(LoadBitmap(action, action.Image));
			}
            sb.Append(Environment.NewLine);
            sb.Append(EnableImage(action));

			return sb.ToString();
		}

//        [System.Reflection.ObfuscationAttribute(Feature = "renaming")]
        public static string DisableCode(ActionElement action)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(LinkAction.DisableLink(action));
            //sb.Append(Environment.NewLine);
            //sb.Append(JSEvent(action,false));
			if (action.DisabledImage != null)
			{
				sb.Append(Environment.NewLine);
				sb.Append(LoadBitmap(action, action.DisabledImage));
			}
            sb.Append(Environment.NewLine);
            sb.Append(DisableImage(action));
            sb.Append(Environment.NewLine);
            sb.Append(ClearTooltip(action));
			return sb.ToString();
		}

        public static string JSEvent(ActionElement action, bool Enable)
        {
            return String.Format("{0}.JSEvent('onclick',!'{1}')", action.ControlName(), Enable.ToString().ToLower());
        }

        public static string ClearTooltip(ActionElement action) 
        {
            return String.Format("{0}.Tooltiptext = ''", action.ControlName());
        }

        public static string DisableImage(ActionElement action)
        {
            return String.Format("{0}.Enabled = false", action.ControlName());
        }

        public static string EnableImage(ActionElement action)
        {
            return String.Format("{0}.Enabled = true", action.ControlName());
        }

		public static string LoadBitmap(ActionElement action, Image image)
		{
			return String.Format("{0}.FromImage({1})", action.ControlName(), image.Name);
		}
	}
}
