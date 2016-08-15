using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitario
{
    public static class EnumeradorUtilitario
    {
        public static void PreencherDropDownComEnumerador<T>(DropDownList bool aLinhaVazia) where T : struct, IConvertible
        {
            Array listaEnum = Enum.GetValues(typeof(T));
        }
    }
}
