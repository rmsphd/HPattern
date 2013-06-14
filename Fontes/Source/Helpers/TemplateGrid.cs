using System;
using System.Collections.Generic;
using System.Text;
using Artech.Common.Collections;

namespace Heurys.Patterns.HPattern.Helpers
{
    public class TemplateGrid
    {
        public static String getCustomRender(IHPatternInstanceElement element)
        {
            String ret = "";
            if (element is IGridObject)
            {
                ret = ((IGridObject)element).GetCustomRender;
            } else if (element.Parent != null && element.Parent != element)
            {
                ret = getCustomRender(element.Parent);
            }
            return ret;
        }

        public static void DefProperty(Dictionary<string, Object> props, String customRender, IHPatternInstanceElement element)
        {
            String nome = "";
            String valor = "";
            if (element is GridPropertieElement)
            {
                GridPropertieElement grid = (GridPropertieElement)element;
                nome = grid.Name;
                valor = grid.Valor;
            }

            if (element is GridColumnPropertieElement)
            {
                GridColumnPropertieElement grid = (GridColumnPropertieElement)element;
                nome = grid.Name;
                valor = grid.Valor;
            }
            props[customRender + "_" + nome] = valor;
        }

        public static BaseCollection<GridPropertieElement> MergeGridProperties(GridPropertiesElement props,HPatternSettings sett)
        {
            BaseCollection<GridPropertieElement> ret = null;
            if (props == null)
            {
                ret = new BaseCollection<GridPropertieElement>();
            }
            else
            {
                ret = new BaseCollection<GridPropertieElement>(props);
            }
            if (sett.Grid.GridProperties != null && sett.Grid.GridProperties.GridProperties != null)
            {
                foreach (SettingsGridPropertieElement prop in sett.Grid.GridProperties.GridProperties)
                {
                    // Vamos verificar se já tem
                    bool tem = false;
                    foreach (GridPropertieElement prope in ret)
                    {
                        if (prope.Name == prop.Name)
                        {
                            tem = true;
                            break;
                        }
                    }

                    // Não tem
                    if (tem == false)
                    {
                        GridPropertieElement propi = new GridPropertieElement(prop.Name);
                        propi.Valor = prop.Valor;
                        ret.Add(propi);
                    }
                }
            }
            return ret;
        }

        public static BaseCollection<GridColumnPropertieElement> MergeGridColumnProperties(GridColumnPropertiesElement props, HPatternSettings sett)
        {
            BaseCollection<GridColumnPropertieElement> ret = null;
            if (props == null)
            {
                ret = new BaseCollection<GridColumnPropertieElement>();
            }
            else
            {
                ret = new BaseCollection<GridColumnPropertieElement>(props);
            }
            if (sett.Grid.GridProperties != null && sett.Grid.GridProperties.GridColumnProperties != null)
            {
                foreach (SettingsGridColumnPropertieElement prop in sett.Grid.GridProperties.GridColumnProperties)
                {
                    // Vamos verificar se já tem
                    bool tem = false;
                    foreach (GridColumnPropertieElement prope in ret)
                    {
                        if (prope.Name == prop.Name)
                        {
                            tem = true;
                            break;
                        }
                    }

                    // Não tem
                    if (tem == false)
                    {
                        GridColumnPropertieElement propi = new GridColumnPropertieElement(prop.Name);
                        propi.Valor = prop.Valor;
                        ret.Add(propi);
                    }
                }
            }
            return ret;
        }

    }
}
