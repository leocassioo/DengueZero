using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidade
{
    public class PessoaJuridicaEntidade : PessoaEntidade
    {
        [MaxLength(20), Required]
        public string CNPJ { get; set; }
    }
}