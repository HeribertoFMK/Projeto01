using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Models
{
    public class Contato
    {
        [Required(ErrorMessage ="O Campo Nome é Obrigatorio")]
        [MaxLength(50,ErrorMessage ="O Campo deve conter no maximo 50 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo Email é Obrigatorio")]
        [MaxLength(70,ErrorMessage = "O Campo deve conter no maximo 70 caracteres")]
        [EmailAddress(ErrorMessage ="Email invalido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O Campo Assunto é Obrigatorio")]
        [MaxLength(70, ErrorMessage = "O Campo deve conter no maximo 70 caracteres")]
        public string Assunto { get; set; }
        [Required(ErrorMessage = "O Campo Mensagem é Obrigatorio")]
        [MaxLength(2000, ErrorMessage = "O Campo deve conter no maximo 2000 caracteres")]
        public string Menssagem { get; set; }
    }
}
