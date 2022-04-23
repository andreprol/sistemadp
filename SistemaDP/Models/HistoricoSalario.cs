using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class HistoricoSalario
    {
        [Key]
        public Guid Id { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de modificação de Salário")]
        public DateTime data_mod_salario { get; set; }

        [Required(ErrorMessage = "O salário inicial é obrigatório preencher")]
        [Display(Name = "Salário inicial")]
        public int salario_inicial { get; set; }

        [Display(Name = "Salário Atual")]
        public int salario_atual { get; set; }

        public HistoricoSalario()
        {
            Id = Guid.NewGuid();
        }

        public HistoricoSalario(DateTime mod_salario, int inicial, int atual)
        {
            DateTime data_mod_salario = mod_salario;
            int salario_inicial = inicial;
            int salario_atual = atual;
        }
    }
}
