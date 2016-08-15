using Criptografar;
using Entidade;
using System.Data.Entity;
using System.Diagnostics;
using System.Web.Configuration;

namespace Dados.Base
{
    /// <summary>
    /// Classe que faz a interligação do banco de dados com a aplicação
    /// </summary>
    public class Contexto : DbContext
    {
        /// <summary>
        /// Construtor default, pega a connection string no Web.config e decripta
        /// </summary>
        public Contexto()
            : base(CriptografiaConnectionString.DecriptarConnectionString(WebConfigurationManager.AppSettings["settings"]))
        {
        }

        public DbSet<PessoaEntidade> Pessoas { get; set; }
        public DbSet<UsuarioEntidade> Usuarios { get; set; }
        public DbSet<EnderecoEntidade> Enderecos { get; set; }
        public DbSet<FocoEntidade> Focos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoaFisicaEntidade>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("PessoaFisica");
            });

            modelBuilder.Entity<PessoaJuridicaEntidade>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("PessoaJuridica");
            });

            #if DEBUG

            Database.Log = s => Debug.Write(s);

            #endif
        }
    }
}