using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace DengueZero.Extensao
{
    public static class MetodosExtensao
    {
        public static void PreencherDropDownComEnumerador<T>(this DropDownList aDropDown, bool aLinhaVazia) where T : struct, IConvertible
        {
            Array listaEnum = Enum.GetValues(typeof(T));

            foreach(var itemEnum in listaEnum)
            {
                aDropDown.Items.Add(itemEnum.ToString());
            }

            if (aLinhaVazia)
                aDropDown.Items.Insert(0, new ListItem());
        }
    }
}