using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class MotivosAfastamento
    {
        [Key]
        public Guid Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage = "A descrição é obrigatória")]
        private string descricao { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "A data do afastamento é obrigatória")]
        [Display(Name = "Data do afastamento")]
        public DateTime data_afastamento { get; set; }

        public MotivosAfastamento()
        {

        }
        public MotivosAfastamento(string desc, DateTime data)
        {
            string descricao = desc;
            DateTime data_afastamento = data;
        }
    }
}
