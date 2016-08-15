using Enumerador;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidade
{
    public class PessoaFisicaEntidade : PessoaEntidade
    {
        [MaxLength(11), Required]
        public string CPF { get; set; }
        public SexoEnum? Sexo { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}