using Dados.Base;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Base
{
    public abstract class BaseNegocio<T> : IBaseNegocio<T> where T : EntidadeBase
    {
        IBaseDados<T> _Repositorio;

        protected IBaseDados<T> Dados { get { return _Repositorio; } private set { _Repositorio = value; } }

        public BaseNegocio(IBaseDados<T> aRepositorio)
        {
            _Repositorio = aRepositorio;
        }

        public virtual T Inserir(T aEntidade)
        {
            if (aEntidade == null)
                throw new ArgumentNullException("Model");

            aEntidade = _Repositorio.Inserir(aEntidade);

            return aEntidade;
        }

        public virtual void Atualizar(T aEntidade)
        {
            if (aEntidade == null)
                throw new ArgumentNullException("Model");

            _Repositorio.Atualizar(aEntidade);
        }

        public virtual void Deletar(T aEntidade)
        {
            if (aEntidade == null)
                throw new ArgumentNullException("Model");

            _Repositorio.Deletar(aEntidade);
        }

        public virtual IEnumerable<T> Buscar()
        {
            return _Repositorio.Buscar();
        }

        public T BuscarPorIdentificador(long aIdentificador)
        {
            return _Repositorio.BuscarPorIdentificador(aIdentificador);
        }

        public void Salvar()
        {
            _Repositorio.Salvar();
        }

        public virtual IQueryable<T> BuscarPorFiltro(Expression<Func<T, bool>> aFiltro)
        {
            return Dados.BuscarPorFiltro(aFiltro);
        }
    }
}