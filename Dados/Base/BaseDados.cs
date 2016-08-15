using Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Base
{
    public abstract class BaseDados<T> : IBaseDados<T> where T : EntidadeBase
    {
        protected DbContext _Contexto;

        protected IDbSet<T> _DbSet { get; set; }

        public BaseDados(DbContext aContexto)
        {
            _Contexto = aContexto;
            _DbSet = aContexto.Set<T>();
        }

        /// <summary>
        /// Busca todas as entidades do tipo T
        /// </summary>
        /// <returns>Lista da entidade</returns>
        public IEnumerable<T> Buscar()
        {
            return _DbSet.AsEnumerable();
        }

        /// <summary>
        /// Busca a entidade do tipo T pelo filtro passado como parâmetro
        /// </summary>
        /// <param name="aFiltro">Filtro da entidade</param>
        /// <returns>Lista da entidade</returns>
        public IQueryable<T> BuscarPorFiltro(Expression<Func<T, bool>> aFiltro)
        {
            return _DbSet.Where(aFiltro);
        }

        /// <summary>
        /// Busca uma entidade pelo identificador (chave primária)
        /// </summary>
        /// <param name="aIdentificador">Identificador da entidade</param>
        /// <returns>Entidade do tipo T</returns>
        public T BuscarPorIdentificador(long aIdentificador)
        {
            return _DbSet.Find(aIdentificador);
        }

        /// <summary>
        /// Inseri uma entidade no banco de dados
        /// </summary>
        /// <param name="aEntidade">Entidade do tipo T</param>
        /// <returns>Entidade do tipo T</returns>
        public T Inserir(T aEntidade)
        {
            return _DbSet.Add(aEntidade);
        }

        /// <summary>
        /// Deleta uma entidade no banco de dados
        /// </summary>
        /// <param name="aEntidade">Entidade do tipo T</param>
        /// <returns></returns>
        public void Deletar(T aEntidade)
        {
            _Contexto.Entry(aEntidade).State = EntityState.Deleted;
        }

        /// <summary>
        /// Atualiza uma entidade no banco de dados
        /// </summary>
        /// <param name="aEntidade"></param>
        public void Atualizar(T aEntidade)
        {
            _Contexto.Entry(aEntidade).State = EntityState.Modified;
        }

        /// <summary>
        /// Salva as modificações no banco de dados
        /// </summary>
        public void Salvar()
        {
            _Contexto.SaveChanges();
        }

        public void Dispose()
        {
            if (_Contexto != null)
                _Contexto.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}