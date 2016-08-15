using Enumerador;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    [Table("Foco")]
    public class FocoEntidade : EntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long FocoID { get; set; }
        [MaxLength(400)]
        public string Descricao { get; set; }
        public StatusFocoEnum Status { get; set; }
        public long? Latitude { get; set; }
        public long? Longitude { get; set; }
        public byte[] Foto { get; set; }
        public long EnderecoID { get; set; }

        //Chave estrangeira
        [Required, ForeignKey("EnderecoID")]
        public virtual EnderecoEntidade Endereco { get; set; }
        public virtual PessoaFisicaEntidade PessoaFisica { get; set; }
        public virtual PessoaJuridicaEntidade PessoaJuridica { get; set; }
    }
}