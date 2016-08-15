using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Dispenser
{
    /// <summary>
    /// Classe responsável por carregar e instanciar as dependências do projeto.
    /// </summary>
    public static class Dispenser
    {
        public static void Inicializar()
        {
            UnityContainer unityContainer = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(unityContainer));
        }

        private static UnityContainer BuildUnityContainer()
        {
            UnityContainer unityContainer = new UnityContainer();

            unityContainer.RegisterType<>();

            return unityContainer;
        }

        /// <summary>
        /// Método responsável por acessar o repositório de dados da aplicação.
        /// </summary>
        /// <typeparam name="T">Interface do Repositório</typeparam>
        /// <returns></returns>
        public static T AcessoDadosUtilitarios<T>()
        {
            return DependencyResolver.Current.GetService<T>();
        }
    }
}