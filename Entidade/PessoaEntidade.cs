using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidade
{
    public abstract class PessoaEntidade : EntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PessoaID { get; set; }
        [MaxLength(90), Required]
        public string Nome { get; set; }
        [MaxLength(14)]
        public string Telefone { get; set; }
        [MaxLength(90)]
        public string Email { get; set; }

        //Chave estrangeira
        public virtual List<EnderecoEntidade> Enderecos { get; set; }
    }
}