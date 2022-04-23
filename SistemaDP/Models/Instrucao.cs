using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class Instrucao
    {
        [Key]
        public Guid Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage = "A descrição é obrigatória")]
        [Display(Name = "Descrição da instrução")]
        public string descricao { get; set; }

        public Instrucao()
        {
            Id = Guid.NewGuid();
        }
        public Instrucao(string desc)
        {
            string descricao = desc;
        }
    }
}
