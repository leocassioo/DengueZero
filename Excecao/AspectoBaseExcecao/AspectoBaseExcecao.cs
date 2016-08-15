using Enumerador;
using Excecao.BaseExcecao;
using PostSharp.Aspects;
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Excecao.AspectoBaseExcecao
{
    [Serializable]
    public class AspectoBaseExcecao : OnExceptionAspect
    {
        public string Message { get; set; }
        public Type ExceptionType { get; set; }
        public FlowBehavior Behavior { get; set; }

        public override void OnException(MethodExecutionArgs args)
        {
            string detalhes;
            //Variável com a página que ocorreu a exception
            Page paginaErro = ((Page)args.Instance).Page;
            //Variável com a master page da página que ocorreu a exception
            MasterPage masterPage = ((Page)args.Instance).Master;

            //Detalhes da exception
            detalhes = string.Format("Método: {0}<br />Stack Trace: {1}<br />Inner Exception:{2}", args.Method.Name,
                                     args.Exception.StackTrace, args.Exception.InnerException);

            args.FlowBehavior = FlowBehavior.Continue;

            //JQuery para abrir o modal com informações para o usuário sobre o erro
            ScriptManager.RegisterStartupScript(paginaErro, typeof(Page), "myModal", "$('#myModal').modal();", true);

            //Validação para mostrar a imagem e título correspondente ao tipo de exceção
            if (args.Exception is ExcecaoBase)
            {
                if (((ExcecaoBase)args.Exception).TipoExcecao == TipoExcecaoEnum.Alerta)
                {
                    ((Label)masterPage.FindControl("lblTituloModal")).Text = TipoExcecaoEnum.Alerta.ToString();
                    ((Image)masterPage.FindControl("imgException")).ImageUrl = "~/img/Alert-icon.ico";
                }
                else if (((ExcecaoBase)args.Exception).TipoExcecao == TipoExcecaoEnum.Erro)
                {
                    ((Label)masterPage.FindControl("lblTituloModal")).Text = TipoExcecaoEnum.Erro.ToString();
                    ((Image)masterPage.FindControl("imgException")).ImageUrl = "~/img/Error-icon.ico";
                }
                else
                {
                    ((Label)masterPage.FindControl("lblTituloModal")).Text = TipoExcecaoEnum.Informacao.ToString();
                    ((Image)masterPage.FindControl("imgException")).ImageUrl = "~/img/Information-icon.png";
                }
            }
            else
            {
                ((Label)masterPage.FindControl("lblTituloModal")).Text = TipoExcecaoEnum.Erro.ToString();
                ((Image)masterPage.FindControl("imgException")).ImageUrl = "~/img/Error-icon.ico";
            }

            ((Label)masterPage.FindControl("lblModalBody")).Text = args.Exception.Message;
            ((Label)masterPage.FindControl("lblDetalhesException")).Text = detalhes;
            ((UpdatePanel)masterPage.FindControl("upModal")).Update();
        }

        public override Type GetExceptionType(System.Reflection.MethodBase targetMethod)
        {
            return ExceptionType;
        }
    }
}