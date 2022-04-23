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

        [Display(Name = "Tarifa original")]
        public int tarifa_original { get; set; }

        [Required(ErrorMessage = "A tarifa atual é obrigatória")]
        [Display(Name = "Tarifa atual")]
        public int tarifa_atual { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Tipo da tarifa")]
        public string tipo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de modificação da tarifa")]
        public DateTime data_modificacao { get; set; }

        public TarifasDeOnibus()
        {
            Id = Guid.NewGuid();
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
