using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class Cargos
    {
        [Key]
        public Guid Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        public string abreviacao { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        public string descricao { get; set; }

        public int diasexp { get; set; }

        public int diasprorr { get; set; }

        public Cargos()
        {

        }
        public Cargos(string abv, string desc, int exp, int prorr)
        {
            string abreviacao = abv;
            string descricao = desc;
            int diasexp = exp;
            int diasprorr = prorr;
        }
    }
}
