using Apresentacao;
using Dados.Interface;
using DispenserAplicacao;
using Entidade;
using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EnderecoNegocio : BaseNegocio<EnderecoEntidade>
    {
        public EnderecoNegocio() 
            : base(Dispenser.AcessoDadosUtilitario<IEnderecoDados>())
        {
        }

        public void SalvarEndereco(MapaApresentacao aApresentacao)
        {
            EnderecoEntidade enderecoEntidade = new EnderecoEntidade();
            FocoEntidade focoEntidade = new FocoEntidade();
            FocoNegocio focoNegocio = new FocoNegocio();


            enderecoEntidade.Pais = aApresentacao.Pais;
            enderecoEntidade.Estado = aApresentacao.Estado;
            enderecoEntidade.Cidade = aApresentacao.Cidade;
            enderecoEntidade.Logradouro = aApresentacao.Rua;

            enderecoEntidade = Inserir(enderecoEntidade);

<<<<<<< HEAD
            focoEntidade.Status = aApresentacao.StatusFoco.Value;
            focoEntidade.Endereco = enderecoEntidade;
            focoEntidade.Descricao = aApresentacao.Descricao;
=======
            focoEntidade.Status = aApresentacao.StatusFoco;
            focoEntidade.Endereco = enderecoEntidade;
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e

            focoNegocio.Inserir(focoEntidade);

            Salvar();
        }

<<<<<<< HEAD
        public List<MapaApresentacao> AtualizarMapa(MapaApresentacao aApresentacao)
        {
            List<FocoEntidade> listaFoco = new FocoNegocio().BuscarPorFiltro(f => aApresentacao.Descricao != null && aApresentacao.Descricao != string.Empty ? f.Descricao == aApresentacao.Descricao : true
                                                                             && aApresentacao.Bairro != null && aApresentacao.Bairro != string.Empty ? f.Endereco.Bairro == aApresentacao.Bairro : true
                                                                             && aApresentacao.StatusFoco.HasValue ? f.Status == aApresentacao.StatusFoco : true
                                                                             && aApresentacao.Cidade != null && aApresentacao.Cidade != string.Empty ? f.Endereco.Cidade == aApresentacao.Cidade : true
                                                                             && aApresentacao.Estado != null && aApresentacao.Estado != string.Empty ? f.Endereco.Estado == aApresentacao.Estado : true
                                                                             && aApresentacao.Pais != null && aApresentacao.Pais != string.Empty ? f.Endereco.Pais == aApresentacao.Pais : true).ToList();
=======
        public List<MapaApresentacao> AtualizarMapa()
        {
            List<FocoEntidade> listaFoco = new FocoNegocio().Buscar().ToList();
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e
            var listaMapaApresentacao = new List<MapaApresentacao>();

            foreach (var focoEntidade in listaFoco)
            {
                MapaApresentacao mapaApresentacao = new MapaApresentacao();

                mapaApresentacao.Pais = focoEntidade.Endereco.Pais;
                mapaApresentacao.Estado = focoEntidade.Endereco.Estado;
                mapaApresentacao.Cidade = focoEntidade.Endereco.Cidade;
                mapaApresentacao.Rua = focoEntidade.Endereco.Logradouro;
                mapaApresentacao.StatusFoco = focoEntidade.Status;
<<<<<<< HEAD
                mapaApresentacao.Descricao = focoEntidade.Descricao;
=======
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e

                listaMapaApresentacao.Add(mapaApresentacao);
            }


            return listaMapaApresentacao;
        }
    }
}