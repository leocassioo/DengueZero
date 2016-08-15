using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    [Table("Endereco")]
    public class EnderecoEntidade : EntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EnderecoID { get; set; }
        [MaxLength(90), Required]
        public string Logradouro { get; set; }
        public int? Numero { get; set; }
        public int? Cep { get; set; }
        [MaxLength(80)]
        public string Bairro { get; set; }
        [MaxLength(80), Required]
        public string Cidade { get; set; }
        [MaxLength(40), Required]
        public string Estado { get; set; }
        [MaxLength(40), Required]
        public string Pais { get; set; }

        //Chave Estrangeira
        public virtual List<FocoEntidade> Focos { get; set; }
        public virtual List<PessoaEntidade> Pessoas { get; set; }
    }
}