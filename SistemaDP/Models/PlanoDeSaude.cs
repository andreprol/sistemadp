using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class PlanoDeSaude
    {
        [Key]
        public Guid Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage = "O nome do plano é obrigatório")]
        [Display(Name = "Nome do plano")]
        public string plano { get; set; }

        public PlanoDeSaude()
        {
            Id = Guid.NewGuid();
        }
        public PlanoDeSaude(string plano_saude)
        {
            string plano = plano_saude;
        }

    }
}
