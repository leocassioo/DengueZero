using Enumerador;
using Excecao.Interface;
using Excecao.BaseExcecao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecao
{
    /// <summary>
    /// "Insira uma connection string criptografada no arquivo web.config."
    /// </summary>
    public class ErroConStringExcecao : ExcecaoBase, IExcecaoBase
    {
        /// <summary>
        /// Construtor default
        /// </summary>
        public ErroConStringExcecao()
            : base(GestorContexto.ErroConString)
        {
        }

        public override TipoExcecaoEnum TipoExcecao { get { return TipoExcecaoEnum.Erro; } }
    }
}