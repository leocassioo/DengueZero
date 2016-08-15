using Excecao.BaseExcecao;
using Excecao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerador;

namespace Excecao
{
    public class ErroSalvarExcecao : ExcecaoBase, IExcecaoBase
    {
        public ErroSalvarExcecao()
            : base(GestorContexto.ErroSalvar)
        {
        }

        public override TipoExcecaoEnum TipoExcecao { get { return TipoExcecaoEnum.Erro; } }
    }
}