using Enumerador;
using Excecao.Interface;
using System;

namespace Excecao.BaseExcecao
{
    public class ExcecaoBase : Exception, IExcecaoBase
    {
        /// <summary>
        /// Construtor default
        /// </summary>
        /// <param name="aMensagem"></param>
        public ExcecaoBase(string aMensagem)
            : base(aMensagem)
        {
        }

        /// <summary>
        /// Enumerador para identificar o tipo da exceção
        /// </summary>
        public virtual TipoExcecaoEnum TipoExcecao { get; }
    }
}