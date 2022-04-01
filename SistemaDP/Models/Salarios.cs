using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class Salarios
    {
        [Key]
        public Guid Id { get; set; }


        private string cargo_original { get; set; }

        private string cargo_atual { get; set; }

        private int salario_original { get; set; }

        [Required(ErrorMessage = "O salário atual é obrigatório")]
        private int salario_atual { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de modificação de salário")]
        private DateTime data_modificao { get; set; }

        public Salarios()
        {

        }
        public Salarios(string c_original, string c_atual,int s_original, int s_atual, DateTime data)
        {
            string cargo_original = c_original;
            string cargo_atual = c_atual;
            int salario_original = s_original;
            int salario_atual = s_atual;
            DateTime data_modificacao = data;
        }
    }
}
