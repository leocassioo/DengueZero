using Dados;
using Dados.Interface;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DispenserAplicacao
{
    /// <summary>
    /// Classe responsável por carregar e instanciar as dependências do projeto
    /// </summary>
    public class Dispenser
    {
        public static void Inicializar()
        {
            UnityContainer container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static UnityContainer BuildUnityContainer()
        {
            UnityContainer container = new UnityContainer();

            container.RegisterType<IEnderecoDados, EnderecoDados>();
            container.RegisterType<IFocoDados, FocoDados>();

            return container;
        }

        /// <summary>
        /// Método responsável por acessar o repositório de dados da aplicação.
        /// </summary>
        /// <typeparam name="T">Interface do Repositório</typeparam>
        /// <returns></returns>
        public static T AcessoDadosUtilitario<T>()
        {
            return DependencyResolver.Current.GetService<T>();
        }
    }
}