using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Base
{
    public interface IBaseNegocio<T> where T : EntidadeBase
    {
        T Inserir(T aEntidade);
        void Deletar(T aEntidade);
        IEnumerable<T> Buscar();
        void Atualizar(T aEntidade);
        T BuscarPorIdentificador(long aIdentificador);
        void Salvar();
        IQueryable<T> BuscarPorFiltro(Expression<Func<T, bool>> aFiltro);
    }
}