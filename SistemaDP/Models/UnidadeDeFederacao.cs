using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class UnidadeDeFederacao
    {
        [Key]
        public Guid Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage ="O campo Estado é obrigatório")]
        public string estado { get; set; }

        [Required(ErrorMessage = "O campo Sigla é obrigatório")]
        public string sigla { get; set; }

        public UnidadeDeFederacao()
        {

        }
        public UnidadeDeFederacao(string est, string s)
        {
            string estado = est;
            string sigla = s;
        }
    }
}
