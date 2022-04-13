using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class TarifasDeOnibus
    {
        [Key]
        public Guid Id { get; set; }

        public int tarifa_original { get; set; }

        [Required(ErrorMessage = "A tarifa atual é obrigatória")]
        public int tarifa_atual { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        public string tipo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "A data do afastamento é obrigatória")]
        [Display(Name = "Data do afastamento")]
        public DateTime data_modificacao { get; set; }

        public TarifasDeOnibus()
        {

        }
        public TarifasDeOnibus(int original, int atual, string tipo_passagem, DateTime data)
        {
            int tarifa_original = original;
            int tarifa_atual = atual;
            string tipo = tipo_passagem;
            DateTime data_modificacao = data;
        }
    }
}
