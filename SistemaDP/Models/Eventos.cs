using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class Eventos
    {
        [Key]
        public Guid Id { get; set; }

        public int numero_evento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        private string descricao_evento { get; set; }

        private DateTime data_evento { get; set; }

        public Eventos()
        {

        }

        public Eventos(string descricao, DateTime data)
        {
            string descricao_evento = descricao;
            DateTime data_evento = data;
        }
    }
}
