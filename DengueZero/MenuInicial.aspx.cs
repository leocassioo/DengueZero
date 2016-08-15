using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DengueZero.Extensao;
using Enumerador;
using Apresentacao;
using Negocio;
using Excecao.AspectoBaseExcecao;
using Excecao;
using System.Net;
using System.Xml.Linq;
using System.IO;

namespace DengueZero
{
    [AspectoBaseExcecao]
    public partial class MenuInicial : System.Web.UI.Page
    {
        private string Link { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ddlStatus.PreencherDropDownComEnumerador<StatusFocoEnum>(true);
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                MapaApresentacao mapaApresentacao = PreencherApresentacao();
                EnderecoNegocio negocio = new EnderecoNegocio();

                negocio.SalvarEndereco(mapaApresentacao);

<<<<<<< HEAD
                ScriptManager.RegisterStartupScript(Page, typeof(Page), "alert", "<script>alert('Dados salvos com sucesso.')</script>", true);
=======
                Response.Write("<script>alert('Dados salvos com sucesso.')</script>");
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e
            }
            catch (Exception)
            {
                throw new ErroSalvarExcecao();
            }
        }

        private MapaApresentacao PreencherApresentacao()
        {
            MapaApresentacao mapaApresentacao = new MapaApresentacao();

            mapaApresentacao.Pais = txtPais.Text;
            mapaApresentacao.Estado = txtEstado.Text;
            mapaApresentacao.Cidade = txtCidade.Text;
            mapaApresentacao.Rua = txtEndereco.Text;
            mapaApresentacao.Bairro = txtBairro.Text;
            mapaApresentacao.Descricao = txtDescricao.Text;
            mapaApresentacao.StatusFoco = !string.IsNullOrWhiteSpace(ddlStatus.Text) ? (StatusFocoEnum?)Enum.Parse(typeof(StatusFocoEnum), ddlStatus.Text) : null;

            return mapaApresentacao;
        }

        protected void btnAtualizarMapa_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            MapaApresentacao apresentacaoTela = PreencherApresentacao();

            List<MapaApresentacao> listaMapaApresentacao = new EnderecoNegocio().AtualizarMapa(apresentacaoTela);
=======
            List<MapaApresentacao> listaMapaApresentacao = new EnderecoNegocio().AtualizarMapa();
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e
            int cont = 0;

            foreach (var mapaApresentacao in listaMapaApresentacao)
            {
                Link = "https://maps.googleapis.com/maps/api/geocode/json?address=";

                if (!string.IsNullOrWhiteSpace(mapaApresentacao.Pais))
                    Link = string.Format("{0}{1}+", Link, mapaApresentacao.Pais);

                if (!string.IsNullOrWhiteSpace(mapaApresentacao.Estado))
                    Link = string.Format("{0}{1}+", Link, mapaApresentacao.Estado);

                if (!string.IsNullOrWhiteSpace(mapaApresentacao.Cidade))
                    Link = string.Format("{0}{1}+", Link, mapaApresentacao.Cidade);

<<<<<<< HEAD
                if (!string.IsNullOrWhiteSpace(mapaApresentacao.Cidade))
                    Link = string.Format("{0}{1}+", Link, mapaApresentacao.Bairro);
=======
                Link = string.Format("{0}Bueno Franco+", Link);
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e

                if (!string.IsNullOrWhiteSpace(mapaApresentacao.Rua))
                    Link = string.Format("{0}{1}", Link, mapaApresentacao.Rua);

<<<<<<< HEAD
                ScriptManager.RegisterStartupScript(Page, typeof(Page), string.Format("atualizarFocosMapa{0}", cont),
                                                    string.Format("atualizarFocosMapa('{0}', '{1}');", Link, mapaApresentacao.Descricao), true);
=======
                //var requisicao = WebRequest.Create(new Uri(link));
                //var response = requisicao.GetResponse();

                //StreamReader reader = new StreamReader(response.GetResponseStream());
                //string json = reader.ReadToEnd().Trim();

                ScriptManager.RegisterStartupScript(Page, typeof(Page), string.Format("atualizarFocosMapa{0}", cont),
                                                    string.Format("atualizarFocosMapa('{0}');", Link), true);
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e
                cont++;
            }
        }
    }
}