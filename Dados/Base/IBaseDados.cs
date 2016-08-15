using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Dados.Base
{
    public interface IBaseDados<T> : IDisposable where T : EntidadeBase
    {
        IEnumerable<T> Buscar();
        IQueryable<T> BuscarPorFiltro(Expression<Func<T, bool>> aFiltro);
        T BuscarPorIdentificador(long aIdentificador);
        T Inserir(T aEntidade);
        void Deletar(T aEntidade);
        void Atualizar(T aEntidade);
        void Salvar();
    }
}