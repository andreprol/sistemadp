using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class Divisao
    {
        [Key]
        public Guid Id { get; set; }

        public int numero_divisao { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        public string descricao { get; set; }

        public Divisao()
        {

        }
        public Divisao(int numero, string desc)
        {
            int numero_divisao = numero;
            string descricao = desc;
        }
    }
}
