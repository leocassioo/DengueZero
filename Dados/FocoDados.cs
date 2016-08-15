using Dados.Base;
using Dados.Interface;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class FocoDados : BaseDados<FocoEntidade>, IFocoDados
    {
        public FocoDados(Contexto aContexto)
            : base(aContexto)
        {
        }
    }
}