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
        private string abreviacao { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        private string descricao { get; set; }

        private int diasexp { get; set; }

        private int diasprorr { get; set; }

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
