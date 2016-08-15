using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    [Table("Usuario")]
    public class UsuarioEntidade : EntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UsuarioID { get; set; }
        [MaxLength(30), Index(IsUnique = true), Required]
        public string Login { get; set; }
        [MaxLength(40), Required]
        public string Senha { get; set; }
        [MaxLength(40), Required]
        public string RespostaSecreta { get; set; }

        //Chave estrangeira
        [Required]
        public virtual PessoaEntidade Pessoa { get; set; }
    }
}