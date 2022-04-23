using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class Admissao
    {
        [Key]
        public Guid Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage ="Formato inválido")]
        public string tipo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage ="Data em formato incorreto")]
        [Required(ErrorMessage ="A data de admissão é obrigatória")]
        [Display(Name ="Data de admissão")]
        public DateTime data_admissao { get; set; }

        public Admissao()
        {
            Id = Guid.NewGuid();
        }

        public Admissao(string tipo_ad, DateTime data_admissao_ad)
        {
            tipo = tipo_ad;
            data_admissao = data_admissao_ad;

        }
    }
}
