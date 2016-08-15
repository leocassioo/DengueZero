using Dados.Interface;
using DispenserAplicacao;
using Entidade;
using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class FocoNegocio : BaseNegocio<FocoEntidade>
    {
        public FocoNegocio()
            : base(Dispenser.AcessoDadosUtilitario<IFocoDados>())
        {
        }
    }
}